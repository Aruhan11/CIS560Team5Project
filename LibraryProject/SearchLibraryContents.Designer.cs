
namespace LibraryProject
{
    partial class SearchLibraryContents
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
            this.uxGridView = new System.Windows.Forms.DataGridView();
            this.uxTypeDDL = new System.Windows.Forms.ComboBox();
            this.uxGenreDDL = new System.Windows.Forms.ComboBox();
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxTitleTextBox = new System.Windows.Forms.TextBox();
            this.uxCreatorTextBox = new System.Windows.Forms.TextBox();
            this.uxCreatorLabel = new System.Windows.Forms.Label();
            this.uxCategoryLabel = new System.Windows.Forms.Label();
            this.uxTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGridView
            // 
            this.uxGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGridView.Location = new System.Drawing.Point(140, 205);
            this.uxGridView.Name = "uxGridView";
            this.uxGridView.RowHeadersWidth = 62;
            this.uxGridView.RowTemplate.Height = 33;
            this.uxGridView.Size = new System.Drawing.Size(1858, 1156);
            this.uxGridView.TabIndex = 0;
            // 
            // uxTypeDDL
            // 
            this.uxTypeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxTypeDDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTypeDDL.FormattingEnabled = true;
            this.uxTypeDDL.IntegralHeight = false;
            this.uxTypeDDL.Location = new System.Drawing.Point(1595, 115);
            this.uxTypeDDL.Name = "uxTypeDDL";
            this.uxTypeDDL.Size = new System.Drawing.Size(403, 40);
            this.uxTypeDDL.TabIndex = 1;
            // 
            // uxGenreDDL
            // 
            this.uxGenreDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGenreDDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxGenreDDL.FormattingEnabled = true;
            this.uxGenreDDL.IntegralHeight = false;
            this.uxGenreDDL.Location = new System.Drawing.Point(1118, 115);
            this.uxGenreDDL.Name = "uxGenreDDL";
            this.uxGenreDDL.Size = new System.Drawing.Size(403, 40);
            this.uxGenreDDL.TabIndex = 2;
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTitleLabel.Location = new System.Drawing.Point(257, 74);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(155, 38);
            this.uxTitleLabel.TabIndex = 5;
            this.uxTitleLabel.Text = "Title/Name";
            // 
            // uxTitleTextBox
            // 
            this.uxTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTitleTextBox.Location = new System.Drawing.Point(140, 115);
            this.uxTitleTextBox.Name = "uxTitleTextBox";
            this.uxTitleTextBox.Size = new System.Drawing.Size(398, 39);
            this.uxTitleTextBox.TabIndex = 6;
            // 
            // uxCreatorTextBox
            // 
            this.uxCreatorTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorTextBox.Location = new System.Drawing.Point(628, 115);
            this.uxCreatorTextBox.Name = "uxCreatorTextBox";
            this.uxCreatorTextBox.Size = new System.Drawing.Size(398, 39);
            this.uxCreatorTextBox.TabIndex = 7;
            // 
            // uxCreatorLabel
            // 
            this.uxCreatorLabel.AutoSize = true;
            this.uxCreatorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorLabel.Location = new System.Drawing.Point(650, 74);
            this.uxCreatorLabel.Name = "uxCreatorLabel";
            this.uxCreatorLabel.Size = new System.Drawing.Size(363, 38);
            this.uxCreatorLabel.TabIndex = 8;
            this.uxCreatorLabel.Text = "Author/Producer/Developer";
            // 
            // uxCategoryLabel
            // 
            this.uxCategoryLabel.AutoSize = true;
            this.uxCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCategoryLabel.Location = new System.Drawing.Point(1261, 74);
            this.uxCategoryLabel.Name = "uxCategoryLabel";
            this.uxCategoryLabel.Size = new System.Drawing.Size(128, 38);
            this.uxCategoryLabel.TabIndex = 9;
            this.uxCategoryLabel.Text = "Category";
            // 
            // uxTypeLabel
            // 
            this.uxTypeLabel.AutoSize = true;
            this.uxTypeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTypeLabel.Location = new System.Drawing.Point(1767, 74);
            this.uxTypeLabel.Name = "uxTypeLabel";
            this.uxTypeLabel.Size = new System.Drawing.Size(75, 38);
            this.uxTypeLabel.TabIndex = 10;
            this.uxTypeLabel.Text = "Type";
            // 
            // SearchLibraryContents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2172, 1467);
            this.Controls.Add(this.uxTypeLabel);
            this.Controls.Add(this.uxCategoryLabel);
            this.Controls.Add(this.uxCreatorLabel);
            this.Controls.Add(this.uxCreatorTextBox);
            this.Controls.Add(this.uxTitleTextBox);
            this.Controls.Add(this.uxTitleLabel);
            this.Controls.Add(this.uxGenreDDL);
            this.Controls.Add(this.uxTypeDDL);
            this.Controls.Add(this.uxGridView);
            this.Name = "SearchLibraryContents";
            this.Text = "SearchLibraryContents";
            ((System.ComponentModel.ISupportInitialize)(this.uxGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxGridView;
        private System.Windows.Forms.ComboBox uxTypeDDL;
        private System.Windows.Forms.ComboBox uxGenreDDL;
        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.TextBox uxTitleTextBox;
        private System.Windows.Forms.TextBox uxCreatorTextBox;
        private System.Windows.Forms.Label uxCreatorLabel;
        private System.Windows.Forms.Label uxCategoryLabel;
        private System.Windows.Forms.Label uxTypeLabel;
    }
}