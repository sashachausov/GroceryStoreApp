namespace GroceryStore.UI.Forms.EditForms
{
    partial class EditOrderForm
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
            statusStrip1 = new StatusStrip();
            dgvAllGroceries = new DataGridView();
            dgvOrderedGroceries = new DataGridView();
            btnMoveItemOutOfCart = new Button();
            btnMoveItemIntoCart = new Button();
            productListLabel = new Label();
            orderedProductsLabel = new Label();
            totalAmountLabel = new Label();
            txtTotalAmount = new TextBox();
            btnConfirm = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllGroceries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderedGroceries).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(719, 24);
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
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(719, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // dgvAllGroceries
            // 
            dgvAllGroceries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllGroceries.Location = new Point(15, 70);
            dgvAllGroceries.Name = "dgvAllGroceries";
            dgvAllGroceries.RowTemplate.Height = 25;
            dgvAllGroceries.Size = new Size(300, 180);
            dgvAllGroceries.TabIndex = 2;
            // 
            // dgvOrderedGroceries
            // 
            dgvOrderedGroceries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderedGroceries.Location = new Point(406, 70);
            dgvOrderedGroceries.Name = "dgvOrderedGroceries";
            dgvOrderedGroceries.RowTemplate.Height = 25;
            dgvOrderedGroceries.Size = new Size(300, 180);
            dgvOrderedGroceries.TabIndex = 3;
            // 
            // btnMoveItemOutOfCart
            // 
            btnMoveItemOutOfCart.Location = new Point(323, 111);
            btnMoveItemOutOfCart.Name = "btnMoveItemOutOfCart";
            btnMoveItemOutOfCart.Size = new Size(75, 45);
            btnMoveItemOutOfCart.TabIndex = 4;
            btnMoveItemOutOfCart.UseVisualStyleBackColor = true;
            // 
            // btnMoveItemIntoCart
            // 
            btnMoveItemIntoCart.Location = new Point(323, 162);
            btnMoveItemIntoCart.Name = "btnMoveItemIntoCart";
            btnMoveItemIntoCart.Size = new Size(75, 45);
            btnMoveItemIntoCart.TabIndex = 5;
            btnMoveItemIntoCart.UseVisualStyleBackColor = true;
            // 
            // productListLabel
            // 
            productListLabel.AutoSize = true;
            productListLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            productListLabel.Location = new Point(15, 40);
            productListLabel.Name = "productListLabel";
            productListLabel.Size = new Size(126, 21);
            productListLabel.TabIndex = 6;
            productListLabel.Text = "Все продукты:";
            // 
            // orderedProductsLabel
            // 
            orderedProductsLabel.AutoSize = true;
            orderedProductsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            orderedProductsLabel.Location = new Point(406, 40);
            orderedProductsLabel.Name = "orderedProductsLabel";
            orderedProductsLabel.Size = new Size(176, 21);
            orderedProductsLabel.TabIndex = 7;
            orderedProductsLabel.Text = "Заказные продукты:";
            // 
            // totalAmountLabel
            // 
            totalAmountLabel.AutoSize = true;
            totalAmountLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            totalAmountLabel.Location = new Point(406, 259);
            totalAmountLabel.Name = "totalAmountLabel";
            totalAmountLabel.Size = new Size(64, 20);
            totalAmountLabel.TabIndex = 8;
            totalAmountLabel.Text = "Итого:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(476, 259);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(100, 23);
            txtTotalAmount.TabIndex = 9;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(583, 259);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(123, 23);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Готово";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // EditOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 311);
            Controls.Add(btnConfirm);
            Controls.Add(txtTotalAmount);
            Controls.Add(totalAmountLabel);
            Controls.Add(orderedProductsLabel);
            Controls.Add(productListLabel);
            Controls.Add(btnMoveItemIntoCart);
            Controls.Add(btnMoveItemOutOfCart);
            Controls.Add(dgvOrderedGroceries);
            Controls.Add(dgvAllGroceries);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "EditOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditOrderForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllGroceries).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderedGroceries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private DataGridView dgvAllGroceries;
        private DataGridView dgvOrderedGroceries;
        private Button btnMoveItemOutOfCart;
        private Button btnMoveItemIntoCart;
        private Label productListLabel;
        private Label orderedProductsLabel;
        private Label totalAmountLabel;
        private TextBox txtTotalAmount;
        private Button btnConfirm;
    }
}