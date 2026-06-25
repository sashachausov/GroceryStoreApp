using GroceryStore.Application.DataTransfer;
using GroceryStore.Domain.Entities;
using GroceryStore.Domain.Enums;
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
        private ProductFormResult? _result;
        public ProductFormResult? Result { get { return _result; } }

        public EditProductForm()
        {
            InitializeComponent();
        }

        public EditProductForm(Product existingProduct)
        {
            InitializeComponent();

            txtName.Text = existingProduct.Name;
            txtSku.Text = existingProduct.Sku;
            nudPriceTag.Value = existingProduct.Price;
            cmbUnit.SelectedItem = existingProduct.Unit;
        }

        private bool ValidateInput(out string errorMessage)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorMessage = "Name is required.";
                return false;
            }

            if (string.IsNullOrEmpty(txtSku.Text))
            {
                errorMessage = "SKU is required";
                return false;
            }

            if (nudPriceTag.Value <= 0)
            {
                errorMessage = "Price must be greater than zero";
                return false;
            }

            if (cmbUnit.SelectedItem == null)
            {
                errorMessage = "Unit must be selected.";
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

            _result = new ProductFormResult
            {
                Name = txtName.Text.Trim(),
                Sku = txtSku.Text.Trim(),
                Price = nudPriceTag.Value,
                Unit = (ProductUnit)cmbUnit.SelectedItem,
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmbUnit.DataSource = Enum.GetValues(typeof(ProductUnit));
        }
    }
}
