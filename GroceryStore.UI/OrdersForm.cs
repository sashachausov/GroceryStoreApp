using GroceryStore.Application.DTO.Orders;
using GroceryStore.Application.Services;
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

namespace GroceryStore.UI
{
    public partial class OrdersForm : Form
    {
        private readonly OrderService _orderService;
        private Guid? _currentDraftId;
        private Order? _currentDraft;

        public OrdersForm(OrderService orderService)
        {
            InitializeComponent();

            _orderService = orderService;
        }

        private void InitializeStatusCombo()
        {
            cmbAddNewStatusOrder.DataSource = Enum.GetValues(typeof(OrderStatus));
            cmbAddNewStatusOrder.SelectedItem = OrderStatus.Draft; // default
            cmbAddExistStatusOrder.DataSource = Enum.GetValues(typeof(OrderStatus));
            cmbAddExistStatusOrder.SelectedItem = OrderStatus.Draft;
        }

        private void InitializeGrids()
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.ReadOnly = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "#",
                DataPropertyName = "OrderNumber"
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Дата заказа",
                DataPropertyName = "CreatedAtUtc",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy HH:mm" }
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Покупатель",
                DataPropertyName = "CustomerName",
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Статус заказа",
                DataPropertyName = "Status"
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Итого",
                DataPropertyName = "Total",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.AllowUserToResizeColumns = false;
            dgvOrderItems.RowHeadersVisible = false;
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Название товара",
                DataPropertyName = "ProductName"
            });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Кол-во",
                DataPropertyName = "Quantity"
            });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Цена",
                DataPropertyName = "UnitPrice",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });
        }

        private async Task RefreshOrdersGridAsync()
        {
            //var orders = await _orderService.GetRunningOrdersAsync();

        }

        private void ConfigureControls()
        {
            btnEditOrder.Enabled = false;
            btnMarkOrderPaid.Enabled = false;
            btnMarkOrderCancelled.Enabled = false;

            btnAddNewCustomerOrder.Enabled = false;
            txtTotalCost.ReadOnly = true;
            dgvOrders.MultiSelect = false;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderItems.ReadOnly = true;
        }

        private void InitializeUi()
        {
            InitializeStatusCombo();
            InitializeGrids();
            ConfigureControls();
        }

        private async Task LoadDataAsync()
        {
            //await LoadCustomerAsync();
            await RefreshOrdersGridAsync();
        }

        private void ToggleOrderButtons(bool isEnabled)
        {
            btnEditOrder.Enabled = isEnabled;
            btnMarkOrderPaid.Enabled = isEnabled;
            btnMarkOrderCancelled.Enabled = isEnabled;
        }

        private void UpdateOrderButtons(OrderListItemDto? order)
        {
            bool selected = order != null;

            btnEditOrder.Enabled = selected;
            btnMarkOrderCancelled.Enabled = selected && 
                order!.Status != OrderStatus.Cancelled && 
                order.Status != OrderStatus.Paid;
            btnMarkOrderPaid.Enabled = selected &&
                order.Status == OrderStatus.Confirmed;
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitializeStatusCombo();
            InitializeGrids();

            await RefreshOrdersGridAsync();
            ToggleOrderButtons(false);
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            ToggleOrderButtons(dgvOrders.CurrentRow != null);
        }
    }
}
