using GroceryStore.Application.Exceptions;
using GroceryStore.Application.Mappers.Categories;
using GroceryStore.Application.Services;
using GroceryStore.UI.Forms.EditForms;
using GroceryStore.UI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.UI.Forms
{
    public partial class CategoriesForm : Form
    {
        private readonly CategoryService _categoryService;
        private List<CategoryListItemDto> _categories = new List<CategoryListItemDto>();
        
        private CategoryListItemDto? SelectedCategory
        {
            get
            {
                if (dgvCategory.SelectedRows.Count == 0)
                    return null;
                return dgvCategory.SelectedRows[0].DataBoundItem as CategoryListItemDto;
            }
        }

        public CategoriesForm(CategoryService categoryService)
        {
            InitializeComponent();
            this._categoryService = categoryService;
        }

        private void ConfigureCategoryGrid()
        {
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.ReadOnly = true;
            dgvCategory.MultiSelect = false;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeRows = false;
            dgvCategory.RowHeadersVisible = false;

            dgvCategory.Columns.Clear();
            dgvCategory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Наименование",
                DataPropertyName = nameof(CategoryListItemDto.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvCategory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductCount",
                HeaderText = "Кол-во",
                DataPropertyName = nameof(CategoryListItemDto.ProductCount),
                Width = 75
            });
        }

        private async void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            await RefreshGridAsync(txtSearchBox.Text);
        }

        private async Task RefreshGridAsync(string? searchText = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchText))
                    _categories = await _categoryService.GetAllAsync();
                else
                    _categories = await _categoryService.SearchAsync(searchText);

                dgvCategory.DataSource = null;
                dgvCategory.DataSource = _categories;
                dgvCategory.ClearSelection();
                UpdateSelection();
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        private void dgvCategory_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelection();
        }

        private void UpdateSelection()
        {
            var selected = SelectedCategory;
            bool hasSelection = selected != null;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;

            if (!hasSelection)
            {
                LoadDefaultImage();
                return;
            }

            ShowCategoryImage(selected);
        }

        private void ShowCategoryImage(CategoryListItemDto category)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(category.ImagePath))
                {
                    LoadDefaultImage();
                    return;
                }

                pbxCategoryImage.SizeMode = PictureBoxSizeMode.Zoom;
                LoadImage(ImagePathHelper.GetCategoryDisplayImagePath(category.ImagePath));

                //var imagePath = ImagePathHelper.GetCategoryDisplayImagePath(category.ImagePath);
                //pbxCategoryImage.Image = Image.FromFile(imagePath);
            }
            catch
            {
                LoadDefaultImage();
            }
        }

        private void LoadDefaultImage()
        {
            try
            {
                pbxCategoryImage.SizeMode = PictureBoxSizeMode.CenterImage;
                LoadImage(ImagePathHelper.GetCategoryDisplayImagePath(null));
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        private void LoadImage(string path)
        {
            using var stream = File.OpenRead(path);
            using var image = Image.FromStream(stream);
            pbxCategoryImage.Image?.Dispose();
            pbxCategoryImage.Image = new Bitmap(image);
        }

        private void RegisterEvents()
        {
            dgvCategory.SelectionChanged += dgvCategory_SelectionChanged;
            txtSearchBox.TextChanged += txtSearchBox_TextChanged;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            dgvCategory.CellDoubleClick += DgvCategory_CellDoubleClick;
        }

        private void DgvCategory_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void CloseToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void ConfigureControls()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            pbxCategoryImage.BorderStyle = BorderStyle.FixedSingle;
        }

        private async void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (SelectedCategory == null) return;

            var result = MessageBox.Show($"Deactivate category \"{SelectedCategory.Name}\"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            try
            {
                await _categoryService.DeactivateAsync(SelectedCategory.Id);
                await RefreshGridAsync(txtSearchBox.Text);
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        private async void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (SelectedCategory == null) return;

            try
            {
                var dto = await _categoryService.GetForEditAsync(SelectedCategory.Id);
                using var form = new EditCategoryForm(dto);
                if (form.ShowDialog() != DialogResult.OK) return;
                if (form.Result is null)
                {
                    UIExceptionHandler.HandleException(new AppException("Category data wa not returned from the editor."));
                    return;
                }
                await _categoryService.UpdateAsync(form.Result);
                await RefreshGridAsync(txtSearchBox.Text);
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        private async void BtnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new EditCategoryForm();

            if (form.ShowDialog() != DialogResult.OK) return;

            try
            {
                await _categoryService.CreateAsync(form.Result);
                await RefreshGridAsync(txtSearchBox.Text);
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ConfigureCategoryGrid();
            ConfigureControls();
            RegisterEvents();
            await RefreshGridAsync();
            LoadDefaultImage();
        }
    }
}
