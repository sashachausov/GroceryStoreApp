using GroceryStore.Application.Other;
using GroceryStore.Application.Services;
using GroceryStore.Domain.Entities;
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
    public partial class ProductsForm : Form
    {
        private readonly ProductService _service;
        private ProductSortOption _currentSort = ProductSortOption.Default;

        public ProductsForm(ProductService service)
        {
            InitializeComponent();
            _service = service;
        }

        private ProductQuery BuildQuery()
        {
            return new ProductQuery
            {
                Name = txtName.Text,
                MaxPrice = nudPrice.Value > 0 ? nudPrice.Value : null,
                SortOption = _currentSort
            };
        }

        private async Task LoadProductsAsync()
        {
            var query = BuildQuery();

            var products = await _service.QueryAsync(query);

            dgvProducts.DataSource = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.Sku,
                p.Price,
                Unit = p.Unit.ToString(),
                p.IsActive,
            }).ToList();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new EditProductForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    var result = form.Result!;

                    await _service.CreateAsync(result.Name, result.Sku, result.Price, result.Unit);
                    await LoadProductsAsync();
                }
            }
            catch (Exception ex)
            {
                UIExceptionHandler.HandleException(ex);
            }            
        }

        private async Task btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            var id = (Guid)dgvProducts.CurrentRow.Cells["Id"].Value;

            var product = await _service.GetByIdAsync(id);

            if (product == null) return;

            var form = new EditProductForm(product);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var result = form.Result!;
                await _service.UpdateAsync(id, result.Name, result.Sku, result.Price, result.Unit);
                await LoadProductsAsync();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            var id = (Guid)dgvProducts.CurrentRow.Cells["Id"].Value;

            await _service.DeleteAsync(id);

            await LoadProductsAsync();
        }


        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
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
            _currentSort= ProductSortOption.PriceDescending;
            await LoadProductsAsync();
        }
    }
}
