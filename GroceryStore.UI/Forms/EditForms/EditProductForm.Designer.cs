namespace GroceryStore.UI.Forms.EditForms
{
    partial class EditProductForm
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
            nameLabel = new Label();
            unitLabel = new Label();
            txtName = new TextBox();
            cmbUnit = new ComboBox();
            label1 = new Label();
            nudPriceTag = new NumericUpDown();
            btnSaveChanges = new Button();
            label2 = new Label();
            txtSku = new TextBox();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPriceTag).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 1;
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
            statusStrip1.Location = new Point(0, 224);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(40, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Название:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new Point(40, 120);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(56, 15);
            unitLabel.TabIndex = 10;
            unitLabel.Text = "Единица:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(421, 23);
            txtName.TabIndex = 12;
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(120, 117);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(421, 23);
            cmbUnit.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 150);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 17;
            label1.Text = "Стоимость:";
            // 
            // nudPriceTag
            // 
            nudPriceTag.DecimalPlaces = 2;
            nudPriceTag.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPriceTag.Location = new Point(120, 147);
            nudPriceTag.Name = "nudPriceTag";
            nudPriceTag.Size = new Size(150, 23);
            nudPriceTag.TabIndex = 18;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(341, 146);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(200, 23);
            btnSaveChanges.TabIndex = 19;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(275, 150);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 20;
            label2.Text = "руб.";
            // 
            // txtSku
            // 
            txtSku.Location = new Point(120, 86);
            txtSku.Name = "txtSku";
            txtSku.Size = new Size(421, 23);
            txtSku.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 90);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 22;
            label3.Text = "Код (ЕСУ):";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 246);
            Controls.Add(label3);
            Controls.Add(txtSku);
            Controls.Add(label2);
            Controls.Add(btnSaveChanges);
            Controls.Add(nudPriceTag);
            Controls.Add(label1);
            Controls.Add(cmbUnit);
            Controls.Add(txtName);
            Controls.Add(unitLabel);
            Controls.Add(nameLabel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление/Редактирование продукта";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPriceTag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private Label nameLabel;
        private Label unitLabel;
        private TextBox txtName;
        private ComboBox cmbUnit;
        private Label label1;
        private NumericUpDown nudPriceTag;
        private Button btnSaveChanges;
        private Label label2;
        private TextBox txtSku;
        private Label label3;
    }
}