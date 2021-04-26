
namespace LibraryProject
{
    partial class Creator
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
            this.uxFetchProductionsByCreatorGridView = new System.Windows.Forms.DataGridView();
            this.uxGetCreatorByTypeButton = new System.Windows.Forms.Button();
            this.uxCreatorCreatorTypeLabel = new System.Windows.Forms.Label();
            this.uxFetchProductionsByCreatorButton = new System.Windows.Forms.Button();
            this.uxCreatorCreatorIDLabel = new System.Windows.Forms.Label();
            this.uxCreatorCreatorIDTextBox = new System.Windows.Forms.TextBox();
            this.uxCreatorTypeDDL = new System.Windows.Forms.ComboBox();
            this.uxGetCreatorByTypeGridView = new System.Windows.Forms.DataGridView();
            this.uxLine3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchProductionsByCreatorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGetCreatorByTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFetchProductionsByCreatorGridView
            // 
            this.uxFetchProductionsByCreatorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxFetchProductionsByCreatorGridView.Location = new System.Drawing.Point(1538, 481);
            this.uxFetchProductionsByCreatorGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxFetchProductionsByCreatorGridView.Name = "uxFetchProductionsByCreatorGridView";
            this.uxFetchProductionsByCreatorGridView.RowHeadersWidth = 62;
            this.uxFetchProductionsByCreatorGridView.RowTemplate.Height = 33;
            this.uxFetchProductionsByCreatorGridView.Size = new System.Drawing.Size(1309, 1815);
            this.uxFetchProductionsByCreatorGridView.TabIndex = 81;
            // 
            // uxGetCreatorByTypeButton
            // 
            this.uxGetCreatorByTypeButton.Location = new System.Drawing.Point(595, 248);
            this.uxGetCreatorByTypeButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxGetCreatorByTypeButton.Name = "uxGetCreatorByTypeButton";
            this.uxGetCreatorByTypeButton.Size = new System.Drawing.Size(432, 139);
            this.uxGetCreatorByTypeButton.TabIndex = 80;
            this.uxGetCreatorByTypeButton.Text = "Get Creators By Type";
            this.uxGetCreatorByTypeButton.UseVisualStyleBackColor = true;
            this.uxGetCreatorByTypeButton.Click += new System.EventHandler(this.uxGetCreatorByTypeButton_Click);
            // 
            // uxCreatorCreatorTypeLabel
            // 
            this.uxCreatorCreatorTypeLabel.AutoSize = true;
            this.uxCreatorCreatorTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorTypeLabel.Location = new System.Drawing.Point(216, 154);
            this.uxCreatorCreatorTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxCreatorCreatorTypeLabel.Name = "uxCreatorCreatorTypeLabel";
            this.uxCreatorCreatorTypeLabel.Size = new System.Drawing.Size(257, 54);
            this.uxCreatorCreatorTypeLabel.TabIndex = 79;
            this.uxCreatorCreatorTypeLabel.Text = "Creator Type:";
            // 
            // uxFetchProductionsByCreatorButton
            // 
            this.uxFetchProductionsByCreatorButton.Location = new System.Drawing.Point(2043, 248);
            this.uxFetchProductionsByCreatorButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxFetchProductionsByCreatorButton.Name = "uxFetchProductionsByCreatorButton";
            this.uxFetchProductionsByCreatorButton.Size = new System.Drawing.Size(432, 139);
            this.uxFetchProductionsByCreatorButton.TabIndex = 84;
            this.uxFetchProductionsByCreatorButton.Text = "Fetch Productions by Creator";
            this.uxFetchProductionsByCreatorButton.UseVisualStyleBackColor = true;
            this.uxFetchProductionsByCreatorButton.Click += new System.EventHandler(this.uxFetchProductionsByCreatorButton_Click);
            // 
            // uxCreatorCreatorIDLabel
            // 
            this.uxCreatorCreatorIDLabel.AutoSize = true;
            this.uxCreatorCreatorIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDLabel.Location = new System.Drawing.Point(1726, 149);
            this.uxCreatorCreatorIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxCreatorCreatorIDLabel.Name = "uxCreatorCreatorIDLabel";
            this.uxCreatorCreatorIDLabel.Size = new System.Drawing.Size(202, 54);
            this.uxCreatorCreatorIDLabel.TabIndex = 83;
            this.uxCreatorCreatorIDLabel.Text = "CreatorID:";
            // 
            // uxCreatorCreatorIDTextBox
            // 
            this.uxCreatorCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDTextBox.Location = new System.Drawing.Point(1938, 149);
            this.uxCreatorCreatorIDTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxCreatorCreatorIDTextBox.Name = "uxCreatorCreatorIDTextBox";
            this.uxCreatorCreatorIDTextBox.Size = new System.Drawing.Size(699, 61);
            this.uxCreatorCreatorIDTextBox.TabIndex = 82;
            // 
            // uxCreatorTypeDDL
            // 
            this.uxCreatorTypeDDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorTypeDDL.FormattingEnabled = true;
            this.uxCreatorTypeDDL.Location = new System.Drawing.Point(490, 148);
            this.uxCreatorTypeDDL.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxCreatorTypeDDL.Name = "uxCreatorTypeDDL";
            this.uxCreatorTypeDDL.Size = new System.Drawing.Size(660, 62);
            this.uxCreatorTypeDDL.TabIndex = 85;
            // 
            // uxGetCreatorByTypeGridView
            // 
            this.uxGetCreatorByTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGetCreatorByTypeGridView.Location = new System.Drawing.Point(90, 481);
            this.uxGetCreatorByTypeGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uxGetCreatorByTypeGridView.Name = "uxGetCreatorByTypeGridView";
            this.uxGetCreatorByTypeGridView.RowHeadersWidth = 62;
            this.uxGetCreatorByTypeGridView.RowTemplate.Height = 33;
            this.uxGetCreatorByTypeGridView.Size = new System.Drawing.Size(1275, 1815);
            this.uxGetCreatorByTypeGridView.TabIndex = 86;
            // 
            // uxLine3
            // 
            this.uxLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine3.Location = new System.Drawing.Point(1455, 123);
            this.uxLine3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxLine3.Name = "uxLine3";
            this.uxLine3.Size = new System.Drawing.Size(3, 2222);
            this.uxLine3.TabIndex = 87;
            this.uxLine3.Text = "                             ";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2958, 2108);
            this.Controls.Add(this.uxLine3);
            this.Controls.Add(this.uxGetCreatorByTypeGridView);
            this.Controls.Add(this.uxCreatorTypeDDL);
            this.Controls.Add(this.uxFetchProductionsByCreatorButton);
            this.Controls.Add(this.uxCreatorCreatorIDLabel);
            this.Controls.Add(this.uxCreatorCreatorIDTextBox);
            this.Controls.Add(this.uxFetchProductionsByCreatorGridView);
            this.Controls.Add(this.uxGetCreatorByTypeButton);
            this.Controls.Add(this.uxCreatorCreatorTypeLabel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Creator";
            this.Text = "Creator";
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchProductionsByCreatorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGetCreatorByTypeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxFetchProductionsByCreatorGridView;
        private System.Windows.Forms.Button uxGetCreatorByTypeButton;
        private System.Windows.Forms.Label uxCreatorCreatorTypeLabel;
        private System.Windows.Forms.Button uxFetchProductionsByCreatorButton;
        private System.Windows.Forms.Label uxCreatorCreatorIDLabel;
        private System.Windows.Forms.TextBox uxCreatorCreatorIDTextBox;
        private System.Windows.Forms.ComboBox uxCreatorTypeDDL;
        private System.Windows.Forms.DataGridView uxGetCreatorByTypeGridView;
        private System.Windows.Forms.Label uxLine3;
    }
}