using GroceryStore.Application.Exceptions;
using GroceryStore.Application.Mappers.Product;
using GroceryStore.Application.Services;
using GroceryStore.Domain.Entities;
using GroceryStore.UI.Forms.EditForms;
using GroceryStore.UI.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.UI.Forms
{
    public partial class ProductsForm : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private ProductSortOption _currentSort = ProductSortOption.Default;

        private ProductListItemDto? SelectedProduct
        {
            get
            {
                return dgvProducts.SelectedRows.Count == 0 ? null : dgvProducts.SelectedRows[0].DataBoundItem as ProductListItemDto;
            }
        }

        public ProductsForm(ProductService productService, CategoryService categoryService)
        {
            InitializeComponent();
            _productService = productService;
            _categoryService = categoryService;
        }

        private ProductQuery BuildQuery()
        {
            return new ProductQuery
            {
                Name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim(),
                MaxPrice = nudPrice.Value <= 0 ? null : nudPrice.Value,
                SortOption = _currentSort
            };
        }

        private void ConfigureProductsGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.RowHeadersVisible = false;

            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Наименование",
                DataPropertyName = nameof(ProductListItemDto.Name),
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Sku",
                HeaderText = "Артикул",
                DataPropertyName = nameof(ProductListItemDto.Sku),
                Width = 100
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Категория",
                DataPropertyName = nameof(ProductListItemDto.CategoryName),
                Width = 175
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Стоимость",
                DataPropertyName = nameof(ProductListItemDto.Price),
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2", FormatProvider = CultureInfo.GetCultureInfo("ru-RU") }
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UnitDisplayName",
                HeaderText = "Ед. измерения",
                DataPropertyName = nameof(ProductListItemDto.UnitDisplayName),
                Width = 110,
            });
        }

        private async Task LoadProductsAsync()
        {
            var query = BuildQuery();

            var products = await _productService.QueryAsync(query);

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
            dgvProducts.ClearSelection();
            ConfigureControls();
        }

        private void UpdateSelections()
        {
            var selected = SelectedProduct;
            bool hasSelection = selected != null;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            UpdateSelections();
        }

        private void ConfigureControls()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new EditProductForm(_categoryService);

            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (form.Result == null)
            {
                UIExceptionHandler.HandleException(new AppException("Product data was not returned from the editor."));
                return;
            }

            try
            {
                var dto = form.Result;

                await _productService.CreateAsync(dto.Name, dto.Sku, dto.Price, dto.Unit, dto.CategoryId);
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;

            try
            {
                var product = await _productService.GetByIdAsync(SelectedProduct.Id);

                using var form = new EditProductForm(product, _categoryService);

                if (form.ShowDialog() != DialogResult.OK)
                    return;

                if (form.Result == null)
                    return;

                var result = form.Result;

                await _productService.UpdateAsync(SelectedProduct.Id, result.Name, result.Sku, result.Price, result.Unit, result.CategoryId);
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;

            var result = MessageBox.Show($"Deactivate product \"{SelectedProduct.Name}\"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            try
            {
                await _productService.DeleteAsync(SelectedProduct.Id);
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }
        }


        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ConfigureProductsGrid();
            ConfigureControls();
            await LoadProductsAsync();
        }

        private async void btnSetDefault_Click(object sender, EventArgs e)
        {
            _currentSort = ProductSortOption.Default;
            await LoadProductsAsync();
        }

        private async void btnSetAlphabetical_Click(object sender, EventArgs e)
        {
            _currentSort = ProductSortOption.Alphabetical;
            await LoadProductsAsync();
        }

        private async void btnSetAsc_Click(object sender, EventArgs e)
        {
            _currentSort = ProductSortOption.PriceAscending;
            await LoadProductsAsync();
        }

        private async void btnSetDesc_Click(object sender, EventArgs e)
        {
            _currentSort = ProductSortOption.PriceDescending;
            await LoadProductsAsync();
        }

        private async void btnSearchApply_Click(object sender, EventArgs e)
        {
            await LoadProductsAsync();
        }
    }
}
