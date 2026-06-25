namespace GroceryStore.UI.Forms
{
    partial class ProductsForm
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
            infoToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            searchLabel = new Label();
            priceLabel = new Label();
            txtName = new TextBox();
            btnSearchApply = new Button();
            dgvProducts = new DataGridView();
            statusStrip1 = new StatusStrip();
            nudPrice = new NumericUpDown();
            sortByLabel = new Label();
            btnSetDefault = new Button();
            btnSetAlphabetical = new Button();
            btnSetAsc = new Button();
            btnSetDesc = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(834, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(65, 20);
            infoToolStripMenuItem.Text = "Справка";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(65, 20);
            closeToolStripMenuItem.Text = "Закрыть";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            searchLabel.Location = new Point(25, 40);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(74, 17);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Название:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            priceLabel.Location = new Point(25, 70);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(89, 17);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Стоимость:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(639, 23);
            txtName.TabIndex = 3;
            // 
            // btnSearchApply
            // 
            btnSearchApply.Location = new Point(765, 38);
            btnSearchApply.Name = "btnSearchApply";
            btnSearchApply.Size = new Size(55, 55);
            btnSearchApply.TabIndex = 5;
            btnSearchApply.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(15, 105);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowTemplate.Height = 25;
            dgvProducts.Size = new Size(805, 235);
            dgvProducts.TabIndex = 6;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 389);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(834, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Location = new Point(120, 67);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(639, 23);
            nudPrice.TabIndex = 8;
            // 
            // sortByLabel
            // 
            sortByLabel.AutoSize = true;
            sortByLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sortByLabel.Location = new Point(15, 355);
            sortByLabel.Name = "sortByLabel";
            sortByLabel.Size = new Size(114, 17);
            sortByLabel.TabIndex = 9;
            sortByLabel.Text = "Сортировать по:";
            // 
            // btnSetDefault
            // 
            btnSetDefault.Location = new Point(135, 347);
            btnSetDefault.Name = "btnSetDefault";
            btnSetDefault.Size = new Size(40, 35);
            btnSetDefault.TabIndex = 10;
            btnSetDefault.UseVisualStyleBackColor = true;
            btnSetDefault.Click += btnSetDefault_Click;
            // 
            // btnSetAlphabetical
            // 
            btnSetAlphabetical.Location = new Point(181, 347);
            btnSetAlphabetical.Name = "btnSetAlphabetical";
            btnSetAlphabetical.Size = new Size(40, 35);
            btnSetAlphabetical.TabIndex = 11;
            btnSetAlphabetical.UseVisualStyleBackColor = true;
            btnSetAlphabetical.Click += btnSetAlphabetical_Click;
            // 
            // btnSetAsc
            // 
            btnSetAsc.Location = new Point(227, 347);
            btnSetAsc.Name = "btnSetAsc";
            btnSetAsc.Size = new Size(40, 35);
            btnSetAsc.TabIndex = 12;
            btnSetAsc.UseVisualStyleBackColor = true;
            btnSetAsc.Click += btnSetAsc_Click;
            // 
            // btnSetDesc
            // 
            btnSetDesc.Location = new Point(273, 347);
            btnSetDesc.Name = "btnSetDesc";
            btnSetDesc.Size = new Size(40, 35);
            btnSetDesc.TabIndex = 13;
            btnSetDesc.UseVisualStyleBackColor = true;
            btnSetDesc.Click += btnSetDesc_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(333, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(489, 353);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(175, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(670, 353);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 411);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSetDesc);
            Controls.Add(btnSetAsc);
            Controls.Add(btnSetAlphabetical);
            Controls.Add(btnSetDefault);
            Controls.Add(sortByLabel);
            Controls.Add(nudPrice);
            Controls.Add(statusStrip1);
            Controls.Add(dgvProducts);
            Controls.Add(btnSearchApply);
            Controls.Add(txtName);
            Controls.Add(priceLabel);
            Controls.Add(searchLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Продукты";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label searchLabel;
        private Label priceLabel;
        private TextBox txtName;
        private Button btnSearchApply;
        private DataGridView dgvProducts;
        private StatusStrip statusStrip1;
        private NumericUpDown nudPrice;
        private Label sortByLabel;
        private Button btnSetDefault;
        private Button btnSetAlphabetical;
        private Button btnSetAsc;
        private Button btnSetDesc;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}