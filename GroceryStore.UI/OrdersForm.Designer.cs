namespace GroceryStore.UI
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tabControl1 = new TabControl();
            RunningOrdersTabPage = new TabPage();
            groupBox3 = new GroupBox();
            btnMarkOrderCancelled = new Button();
            btnMarkOrderPaid = new Button();
            btnEditOrder = new Button();
            groupBox2 = new GroupBox();
            currencyLabel = new Label();
            txtTotalCost = new TextBox();
            totalCostLabel = new Label();
            dgvOrderItems = new DataGridView();
            groupBox1 = new GroupBox();
            tabControl2 = new TabControl();
            newOrderTabPage = new TabPage();
            btnAddNewCustomerOrder = new Button();
            dtpNewOrderDate = new DateTimePicker();
            newOrderCreatedAtLabel = new Label();
            cmbAddNewStatusOrder = new ComboBox();
            newOrderStatusLabel = new Label();
            txtNewCustomerPhone = new TextBox();
            newOrderCustomerPhone = new Label();
            txtCustomer = new TextBox();
            newOrderCustomerLabel = new Label();
            existOrderTabPage = new TabPage();
            label2 = new Label();
            btnAddExistCustomerOrder = new Button();
            dtpExistOrderDate = new DateTimePicker();
            label1 = new Label();
            cmbAddExistStatusOrder = new ComboBox();
            cmbAddExistCustomer = new ComboBox();
            existOrderCustomerLabel = new Label();
            dgvOrders = new DataGridView();
            tabPage2 = new TabPage();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            RunningOrdersTabPage.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            groupBox1.SuspendLayout();
            tabControl2.SuspendLayout();
            newOrderTabPage.SuspendLayout();
            existOrderTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, adminToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(48, 20);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(134, 20);
            adminToolStripMenuItem.Text = "Администрирование";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(65, 20);
            infoToolStripMenuItem.Text = "Справка";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(RunningOrdersTabPage);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(960, 490);
            tabControl1.TabIndex = 2;
            // 
            // RunningOrdersTabPage
            // 
            RunningOrdersTabPage.Controls.Add(groupBox3);
            RunningOrdersTabPage.Controls.Add(groupBox2);
            RunningOrdersTabPage.Controls.Add(groupBox1);
            RunningOrdersTabPage.Controls.Add(dgvOrders);
            RunningOrdersTabPage.Location = new Point(4, 24);
            RunningOrdersTabPage.Name = "RunningOrdersTabPage";
            RunningOrdersTabPage.Padding = new Padding(3);
            RunningOrdersTabPage.Size = new Size(952, 462);
            RunningOrdersTabPage.TabIndex = 0;
            RunningOrdersTabPage.Text = "Выполняются";
            RunningOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnMarkOrderCancelled);
            groupBox3.Controls.Add(btnMarkOrderPaid);
            groupBox3.Controls.Add(btnEditOrder);
            groupBox3.Location = new Point(696, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(245, 195);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Панель управления:";
            // 
            // btnMarkOrderCancelled
            // 
            btnMarkOrderCancelled.Location = new Point(20, 120);
            btnMarkOrderCancelled.Name = "btnMarkOrderCancelled";
            btnMarkOrderCancelled.Size = new Size(205, 36);
            btnMarkOrderCancelled.TabIndex = 2;
            btnMarkOrderCancelled.Text = "Отменить";
            btnMarkOrderCancelled.UseVisualStyleBackColor = true;
            // 
            // btnMarkOrderPaid
            // 
            btnMarkOrderPaid.Location = new Point(20, 80);
            btnMarkOrderPaid.Name = "btnMarkOrderPaid";
            btnMarkOrderPaid.Size = new Size(205, 36);
            btnMarkOrderPaid.TabIndex = 1;
            btnMarkOrderPaid.Text = "Завершить";
            btnMarkOrderPaid.UseVisualStyleBackColor = true;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new Point(20, 40);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(205, 36);
            btnEditOrder.TabIndex = 0;
            btnEditOrder.Text = "Редактировать";
            btnEditOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(currencyLabel);
            groupBox2.Controls.Add(txtTotalCost);
            groupBox2.Controls.Add(totalCostLabel);
            groupBox2.Controls.Add(dgvOrderItems);
            groupBox2.Location = new Point(362, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 195);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выбор продукта:";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(289, 166);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(30, 15);
            currencyLabel.TabIndex = 3;
            currencyLabel.Text = "руб.";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(183, 162);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(100, 23);
            txtTotalCost.TabIndex = 2;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            totalCostLabel.Location = new Point(123, 165);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(54, 17);
            totalCostLabel.TabIndex = 1;
            totalCostLabel.Text = "Итого:";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Location = new Point(9, 22);
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowTemplate.Height = 25;
            dgvOrderItems.Size = new Size(310, 134);
            dgvOrderItems.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl2);
            groupBox1.Location = new Point(6, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 195);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Формирование заказа:";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(newOrderTabPage);
            tabControl2.Controls.Add(existOrderTabPage);
            tabControl2.Location = new Point(6, 22);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(338, 167);
            tabControl2.TabIndex = 0;
            // 
            // newOrderTabPage
            // 
            newOrderTabPage.Controls.Add(btnAddNewCustomerOrder);
            newOrderTabPage.Controls.Add(dtpNewOrderDate);
            newOrderTabPage.Controls.Add(newOrderCreatedAtLabel);
            newOrderTabPage.Controls.Add(cmbAddNewStatusOrder);
            newOrderTabPage.Controls.Add(newOrderStatusLabel);
            newOrderTabPage.Controls.Add(txtNewCustomerPhone);
            newOrderTabPage.Controls.Add(newOrderCustomerPhone);
            newOrderTabPage.Controls.Add(txtCustomer);
            newOrderTabPage.Controls.Add(newOrderCustomerLabel);
            newOrderTabPage.Location = new Point(4, 24);
            newOrderTabPage.Name = "newOrderTabPage";
            newOrderTabPage.Padding = new Padding(3);
            newOrderTabPage.Size = new Size(330, 139);
            newOrderTabPage.TabIndex = 0;
            newOrderTabPage.Text = "Новый";
            newOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCustomerOrder
            // 
            btnAddNewCustomerOrder.Location = new Point(197, 95);
            btnAddNewCustomerOrder.Name = "btnAddNewCustomerOrder";
            btnAddNewCustomerOrder.Size = new Size(124, 23);
            btnAddNewCustomerOrder.TabIndex = 8;
            btnAddNewCustomerOrder.Text = "Добавить";
            btnAddNewCustomerOrder.UseVisualStyleBackColor = true;
            // 
            // dtpNewOrderDate
            // 
            dtpNewOrderDate.CustomFormat = "dd.MM.yyyy";
            dtpNewOrderDate.Format = DateTimePickerFormat.Custom;
            dtpNewOrderDate.Location = new Point(91, 95);
            dtpNewOrderDate.Name = "dtpNewOrderDate";
            dtpNewOrderDate.Size = new Size(100, 23);
            dtpNewOrderDate.TabIndex = 7;
            // 
            // newOrderCreatedAtLabel
            // 
            newOrderCreatedAtLabel.AutoSize = true;
            newOrderCreatedAtLabel.Location = new Point(30, 99);
            newOrderCreatedAtLabel.Name = "newOrderCreatedAtLabel";
            newOrderCreatedAtLabel.Size = new Size(55, 15);
            newOrderCreatedAtLabel.TabIndex = 6;
            newOrderCreatedAtLabel.Text = "Заказ от:";
            // 
            // cmbAddNewStatusOrder
            // 
            cmbAddNewStatusOrder.FormattingEnabled = true;
            cmbAddNewStatusOrder.Location = new Point(91, 67);
            cmbAddNewStatusOrder.Name = "cmbAddNewStatusOrder";
            cmbAddNewStatusOrder.Size = new Size(230, 23);
            cmbAddNewStatusOrder.TabIndex = 5;
            // 
            // newOrderStatusLabel
            // 
            newOrderStatusLabel.AutoSize = true;
            newOrderStatusLabel.Location = new Point(39, 71);
            newOrderStatusLabel.Name = "newOrderStatusLabel";
            newOrderStatusLabel.Size = new Size(46, 15);
            newOrderStatusLabel.TabIndex = 4;
            newOrderStatusLabel.Text = "Статус:";
            // 
            // txtNewCustomerPhone
            // 
            txtNewCustomerPhone.Location = new Point(91, 38);
            txtNewCustomerPhone.Name = "txtNewCustomerPhone";
            txtNewCustomerPhone.Size = new Size(230, 23);
            txtNewCustomerPhone.TabIndex = 3;
            // 
            // newOrderCustomerPhone
            // 
            newOrderCustomerPhone.AutoSize = true;
            newOrderCustomerPhone.Location = new Point(26, 42);
            newOrderCustomerPhone.Name = "newOrderCustomerPhone";
            newOrderCustomerPhone.Size = new Size(59, 15);
            newOrderCustomerPhone.TabIndex = 2;
            newOrderCustomerPhone.Text = "Телефон:";
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(91, 11);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(230, 23);
            txtCustomer.TabIndex = 1;
            // 
            // newOrderCustomerLabel
            // 
            newOrderCustomerLabel.AutoSize = true;
            newOrderCustomerLabel.Location = new Point(10, 15);
            newOrderCustomerLabel.Name = "newOrderCustomerLabel";
            newOrderCustomerLabel.Size = new Size(75, 15);
            newOrderCustomerLabel.TabIndex = 0;
            newOrderCustomerLabel.Text = "Покупатель:";
            // 
            // existOrderTabPage
            // 
            existOrderTabPage.Controls.Add(label2);
            existOrderTabPage.Controls.Add(btnAddExistCustomerOrder);
            existOrderTabPage.Controls.Add(dtpExistOrderDate);
            existOrderTabPage.Controls.Add(label1);
            existOrderTabPage.Controls.Add(cmbAddExistStatusOrder);
            existOrderTabPage.Controls.Add(cmbAddExistCustomer);
            existOrderTabPage.Controls.Add(existOrderCustomerLabel);
            existOrderTabPage.Location = new Point(4, 24);
            existOrderTabPage.Name = "existOrderTabPage";
            existOrderTabPage.Padding = new Padding(3);
            existOrderTabPage.Size = new Size(330, 139);
            existOrderTabPage.TabIndex = 1;
            existOrderTabPage.Text = "Существующий";
            existOrderTabPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 46);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 13;
            label2.Text = "Статус:";
            // 
            // btnAddExistCustomerOrder
            // 
            btnAddExistCustomerOrder.Location = new Point(197, 70);
            btnAddExistCustomerOrder.Name = "btnAddExistCustomerOrder";
            btnAddExistCustomerOrder.Size = new Size(124, 23);
            btnAddExistCustomerOrder.TabIndex = 12;
            btnAddExistCustomerOrder.Text = "Добавить";
            btnAddExistCustomerOrder.UseVisualStyleBackColor = true;
            // 
            // dtpExistOrderDate
            // 
            dtpExistOrderDate.CustomFormat = "dd.MM.yyyy";
            dtpExistOrderDate.Format = DateTimePickerFormat.Custom;
            dtpExistOrderDate.Location = new Point(91, 70);
            dtpExistOrderDate.Name = "dtpExistOrderDate";
            dtpExistOrderDate.Size = new Size(100, 23);
            dtpExistOrderDate.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 74);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 10;
            label1.Text = "Заказ от:";
            // 
            // cmbAddExistStatusOrder
            // 
            cmbAddExistStatusOrder.FormattingEnabled = true;
            cmbAddExistStatusOrder.Location = new Point(91, 42);
            cmbAddExistStatusOrder.Name = "cmbAddExistStatusOrder";
            cmbAddExistStatusOrder.Size = new Size(230, 23);
            cmbAddExistStatusOrder.TabIndex = 9;
            // 
            // cmbAddExistCustomer
            // 
            cmbAddExistCustomer.FormattingEnabled = true;
            cmbAddExistCustomer.Location = new Point(91, 12);
            cmbAddExistCustomer.Name = "cmbAddExistCustomer";
            cmbAddExistCustomer.Size = new Size(230, 23);
            cmbAddExistCustomer.TabIndex = 1;
            // 
            // existOrderCustomerLabel
            // 
            existOrderCustomerLabel.AutoSize = true;
            existOrderCustomerLabel.Location = new Point(10, 16);
            existOrderCustomerLabel.Name = "existOrderCustomerLabel";
            existOrderCustomerLabel.Size = new Size(75, 15);
            existOrderCustomerLabel.TabIndex = 0;
            existOrderCustomerLabel.Text = "Покупатель:";
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.Size = new Size(947, 250);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(952, 462);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "OrdersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrdersForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            RunningOrdersTabPage.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            groupBox1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            newOrderTabPage.ResumeLayout(false);
            newOrderTabPage.PerformLayout();
            existOrderTabPage.ResumeLayout(false);
            existOrderTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage RunningOrdersTabPage;
        private DataGridView dgvOrders;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TabControl tabControl2;
        private TabPage newOrderTabPage;
        private TextBox txtCustomer;
        private Label newOrderCustomerLabel;
        private TabPage existOrderTabPage;
        private Button btnMarkOrderCancelled;
        private Button btnMarkOrderPaid;
        private Button btnEditOrder;
        private Label currencyLabel;
        private TextBox txtTotalCost;
        private Label totalCostLabel;
        private DataGridView dgvOrderItems;
        private TextBox txtNewCustomerPhone;
        private Label newOrderCustomerPhone;
        private Label existOrderCustomerLabel;
        private ComboBox cmbAddExistCustomer;
        private DateTimePicker dtpNewOrderDate;
        private Label newOrderCreatedAtLabel;
        private ComboBox cmbAddNewStatusOrder;
        private Label newOrderStatusLabel;
        private Button btnAddNewCustomerOrder;
        private Label label2;
        private Button btnAddExistCustomerOrder;
        private DateTimePicker dtpExistOrderDate;
        private Label label1;
        private ComboBox cmbAddExistStatusOrder;
    }
}