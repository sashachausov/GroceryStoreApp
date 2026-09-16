namespace GroceryStore.UI.Forms.EditForms
{
    partial class EditCategoryForm
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
            txtCategoryName = new TextBox();
            categoryLabel = new Label();
            pbxCategoryImage = new PictureBox();
            statusStrip1 = new StatusStrip();
            btnRemoveImage = new Button();
            btnBrowseImage = new Button();
            btnSaveChanges = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCategoryImage).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 2;
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
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(115, 42);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(225, 23);
            txtCategoryName.TabIndex = 17;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            categoryLabel.Location = new Point(25, 44);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(84, 17);
            categoryLabel.TabIndex = 16;
            categoryLabel.Text = "Категория:";
            // 
            // pbxCategoryImage
            // 
            pbxCategoryImage.BackColor = SystemColors.ControlDark;
            pbxCategoryImage.Location = new Point(115, 71);
            pbxCategoryImage.Name = "pbxCategoryImage";
            pbxCategoryImage.Size = new Size(225, 200);
            pbxCategoryImage.TabIndex = 15;
            pbxCategoryImage.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 339);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(384, 22);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // btnRemoveImage
            // 
            btnRemoveImage.Location = new Point(13, 303);
            btnRemoveImage.Name = "btnRemoveImage";
            btnRemoveImage.Size = new Size(175, 23);
            btnRemoveImage.TabIndex = 20;
            btnRemoveImage.Text = "Удалить изображение";
            btnRemoveImage.UseVisualStyleBackColor = true;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(13, 277);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(175, 23);
            btnBrowseImage.TabIndex = 19;
            btnBrowseImage.Text = "Обзор...";
            btnBrowseImage.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(194, 277);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(175, 49);
            btnSaveChanges.TabIndex = 21;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // EditCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnRemoveImage);
            Controls.Add(btnBrowseImage);
            Controls.Add(statusStrip1);
            Controls.Add(txtCategoryName);
            Controls.Add(categoryLabel);
            Controls.Add(pbxCategoryImage);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование категории";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCategoryImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private TextBox txtCategoryName;
        private Label categoryLabel;
        private PictureBox pbxCategoryImage;
        private StatusStrip statusStrip1;
        private Button btnRemoveImage;
        private Button btnBrowseImage;
        private Button btnSaveChanges;
    }
}