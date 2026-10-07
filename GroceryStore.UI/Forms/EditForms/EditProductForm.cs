using GroceryStore.Application.Mappers.Categories;
using GroceryStore.Application.Mappers.Product;
using GroceryStore.Application.Services;
using GroceryStore.Domain.Entities;
using GroceryStore.Domain.Enums;
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
    public partial class EditProductForm : Form
    {
        private readonly CategoryService _categoryService;
        private Guid? _productId;
        private Product? _existingProduct;
        public ProductEditDto? Result { get; private set; }

        public EditProductForm(CategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            this.Text = "Добавление продукции";
            btnSaveChanges.Text = "Добавить";
        }

        public EditProductForm(Product product, CategoryService categoryService) : this(categoryService)
        {
            _existingProduct = product;
            this.Text = "Редактирование продукции";
            btnSaveChanges.Text = "Сохранить";
            LoadProduct(product);
        }

        private void LoadProduct(Product product)
        {
            txtName.Text = product.Name;
            txtSku.Text = product.Sku;
            nudPriceTag.Value = product.Price;
        }

        private void ConfigureUnitComboBox()
        {
            cmbUnit.DataSource = ProductUnitDisplayHelper.GetComboItems();
            cmbUnit.DisplayMember = "DisplayName";
            cmbUnit.ValueMember = "Value";
        }

        private async Task LoadCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = nameof(CategoryListItemDto.Name);
            cmbCategory.ValueMember = nameof(CategoryListItemDto.Id);
            cmbCategory.SelectedIndex = -1;
        }

        private bool ValidateInput(out string errorMessage)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorMessage = "Product name is required.";
                return false;
            }

            if (string.IsNullOrEmpty(txtSku.Text))
            {
                errorMessage = "SKU is required.";
                return false;
            }

            if (nudPriceTag.Value <= 0)
            {
                errorMessage = "Price must be greater than zero.";
                return false;
            }

            if (cmbUnit.SelectedItem == null)
            {
                errorMessage = "Unit must be selected.";
                return false;
            }

            if (cmbCategory.SelectedValue == null)
            {
                errorMessage = "Category must be selected.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Result = new ProductEditDto
            {
                Id = _productId,
                Name = txtName.Text.Trim(),
                Sku = txtSku.Text.Trim(),
                Price = nudPriceTag.Value,
                Unit = (ProductUnit)cmbUnit.SelectedValue!,
                CategoryId = (Guid)cmbCategory.SelectedValue!
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ConfigureUnitComboBox();
            await LoadCategoriesAsync();
            
            if (_existingProduct != null)
            {
                cmbUnit.SelectedValue = _existingProduct.Unit;
                cmbCategory.SelectedValue = _existingProduct.CategoryId;

                // Выбор категории выполняется после загрузки категорий.
                // Нужно переделать существующий продукт в поле, если требуется точное восстановление
                // cmbUnit.DataSource = Enum.GetValues(typeof(ProductUnit));
            }
        }
    }
}
