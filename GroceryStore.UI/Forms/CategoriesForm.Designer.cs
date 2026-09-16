namespace GroceryStore.UI.Forms
{
    partial class CategoriesForm
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
            dgvCategory = new DataGridView();
            pbxCategoryImage = new PictureBox();
            btnAdd = new Button();
            btnEdit = new Button();
            searchLabel = new Label();
            txtSearchBox = new TextBox();
            btnDelete = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxCategoryImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(564, 24);
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
            statusStrip1.Location = new Point(0, 359);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(564, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(76, 66);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowTemplate.Height = 25;
            dgvCategory.Size = new Size(240, 280);
            dgvCategory.TabIndex = 9;
            dgvCategory.SelectionChanged += dgvCategory_SelectionChanged;
            // 
            // pbxCategoryImage
            // 
            pbxCategoryImage.BackColor = SystemColors.ControlDark;
            pbxCategoryImage.BorderStyle = BorderStyle.FixedSingle;
            pbxCategoryImage.Location = new Point(332, 66);
            pbxCategoryImage.Name = "pbxCategoryImage";
            pbxCategoryImage.Size = new Size(200, 200);
            pbxCategoryImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCategoryImage.TabIndex = 10;
            pbxCategoryImage.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(332, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(332, 298);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 23);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            searchLabel.Location = new Point(20, 40);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(50, 17);
            searchLabel.TabIndex = 13;
            searchLabel.Text = "Поиск:";
            // 
            // txtSearchBox
            // 
            txtSearchBox.Location = new Point(76, 37);
            txtSearchBox.Name = "txtSearchBox";
            txtSearchBox.Size = new Size(240, 23);
            txtSearchBox.TabIndex = 14;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(332, 323);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 381);
            Controls.Add(btnDelete);
            Controls.Add(txtSearchBox);
            Controls.Add(searchLabel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(pbxCategoryImage);
            Controls.Add(dgvCategory);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CategoriesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Категории продуктов";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxCategoryImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private DataGridView dgvCategory;
        private PictureBox pbxCategoryImage;
        private Button btnAdd;
        private Button btnEdit;
        private Label searchLabel;
        private TextBox txtSearchBox;
        private Button btnDelete;
    }
}