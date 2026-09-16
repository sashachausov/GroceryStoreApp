using GroceryStore.Application.Mappers.Categories;
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

namespace GroceryStore.UI.Forms.EditForms
{
    public partial class EditCategoryForm : Form
    {
        private Guid? _categoryId;
        private string? _relativeImagePath;
        public CategoryEditDto? Result { get; private set; }

        public EditCategoryForm()
        {
            InitializeComponent();
            InitializeForm();
            this.Text = "Добавление категории";
            btnSaveChanges.Text = "Добавить";
        }

        public EditCategoryForm(CategoryEditDto category) : this()
        {
            _categoryId = category.Id;
            txtCategoryName.Text = category.Name;
            _relativeImagePath = category.RelativeImagePath;
            btnRemoveImage.Enabled = !string.IsNullOrWhiteSpace(_relativeImagePath);
            this.Text = "Редактирование категории";
            btnSaveChanges.Text = "Сохранить";
            
            if (string.IsNullOrWhiteSpace(_relativeImagePath))
                LoadDefaultImage();
            else
                LoadCustomImage();
        }

        private void InitializeForm()
        {
            pbxCategoryImage.BorderStyle = BorderStyle.FixedSingle;
            LoadDefaultImage();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            btnBrowseImage.Click += BtnBrowseImage_Click;
            btnRemoveImage.Click += BtnRemoveImage_Click;
            btnSaveChanges.Click += BtnSaveChanges_Click;
            closeToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
        }

        private void CloseToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnSaveChanges_Click(object? sender, EventArgs e)
        {
            if (!ValidateInput(out var errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Result = new CategoryEditDto
            {
                Id = _categoryId,
                Name = txtCategoryName.Text.Trim(),
                RelativeImagePath = _relativeImagePath
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnRemoveImage_Click(object? sender, EventArgs e)
        {
            _relativeImagePath = null;
            btnRemoveImage.Enabled = false;
            LoadDefaultImage();
        }

        private void BtnBrowseImage_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
            dialog.Title = "Select category image";
            if (dialog.ShowDialog() != DialogResult.OK) 
                return;

            try
            {
                _relativeImagePath = ImagePathHelper.CopyCategoryImageToAppFolder(dialog.FileName);
                LoadCustomImage();
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        private void LoadCustomImage()
        {
            try
            {
                pbxCategoryImage.SizeMode = PictureBoxSizeMode.Zoom;
                LoadImage(ImagePathHelper.GetCategoryDisplayImagePath(_relativeImagePath));
            }
            catch (Exception)
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

        private bool ValidateInput(out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                errorMessage = "Category name is required.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
