
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
            this.uxCreatorIDCLabel = new System.Windows.Forms.Label();
            this.uxUpdateCreatorIDTextBox = new System.Windows.Forms.TextBox();
            this.uxAuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.uxProducerCheckBox = new System.Windows.Forms.CheckBox();
            this.uxDeveloperCheckBox = new System.Windows.Forms.CheckBox();
            this.uxCreatorTypeCLabel = new System.Windows.Forms.Label();
            this.uxUpdateButton = new System.Windows.Forms.Button();
            this.uxCreatorCLabel = new System.Windows.Forms.Label();
            this.uxFetchCreatorIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFNameCLabel = new System.Windows.Forms.Label();
            this.uxFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.uxLNameLabel = new System.Windows.Forms.Label();
            this.uxLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchButton = new System.Windows.Forms.Button();
            this.uxCompanyCLabel = new System.Windows.Forms.Label();
            this.uxCompanyTextBox = new System.Windows.Forms.TextBox();
            this.uxRetriveButton = new System.Windows.Forms.Button();
            this.uxRetriveCreatorsGridView = new System.Windows.Forms.DataGridView();
            this.uxLine4 = new System.Windows.Forms.Label();
            this.uxLine2 = new System.Windows.Forms.Label();
            this.uxLine1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchProductionsByCreatorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGetCreatorByTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveCreatorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFetchProductionsByCreatorGridView
            // 
            this.uxFetchProductionsByCreatorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxFetchProductionsByCreatorGridView.Location = new System.Drawing.Point(906, 767);
            this.uxFetchProductionsByCreatorGridView.Name = "uxFetchProductionsByCreatorGridView";
            this.uxFetchProductionsByCreatorGridView.RowHeadersWidth = 62;
            this.uxFetchProductionsByCreatorGridView.RowTemplate.Height = 33;
            this.uxFetchProductionsByCreatorGridView.Size = new System.Drawing.Size(770, 379);
            this.uxFetchProductionsByCreatorGridView.TabIndex = 81;
            // 
            // uxGetCreatorByTypeButton
            // 
            this.uxGetCreatorByTypeButton.Location = new System.Drawing.Point(296, 695);
            this.uxGetCreatorByTypeButton.Name = "uxGetCreatorByTypeButton";
            this.uxGetCreatorByTypeButton.Size = new System.Drawing.Size(254, 62);
            this.uxGetCreatorByTypeButton.TabIndex = 80;
            this.uxGetCreatorByTypeButton.Text = "Get Creators By Type";
            this.uxGetCreatorByTypeButton.UseVisualStyleBackColor = true;
            this.uxGetCreatorByTypeButton.Click += new System.EventHandler(this.uxGetCreatorByTypeButton_Click);
            // 
            // uxCreatorCreatorTypeLabel
            // 
            this.uxCreatorCreatorTypeLabel.AutoSize = true;
            this.uxCreatorCreatorTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorTypeLabel.Location = new System.Drawing.Point(81, 632);
            this.uxCreatorCreatorTypeLabel.Name = "uxCreatorCreatorTypeLabel";
            this.uxCreatorCreatorTypeLabel.Size = new System.Drawing.Size(155, 32);
            this.uxCreatorCreatorTypeLabel.TabIndex = 79;
            this.uxCreatorCreatorTypeLabel.Text = "Creator Type:";
            // 
            // uxFetchProductionsByCreatorButton
            // 
            this.uxFetchProductionsByCreatorButton.Location = new System.Drawing.Point(1163, 695);
            this.uxFetchProductionsByCreatorButton.Name = "uxFetchProductionsByCreatorButton";
            this.uxFetchProductionsByCreatorButton.Size = new System.Drawing.Size(254, 62);
            this.uxFetchProductionsByCreatorButton.TabIndex = 84;
            this.uxFetchProductionsByCreatorButton.Text = "Fetch Productions by Creator";
            this.uxFetchProductionsByCreatorButton.UseVisualStyleBackColor = true;
            this.uxFetchProductionsByCreatorButton.Click += new System.EventHandler(this.uxFetchProductionsByCreatorButton_Click);
            // 
            // uxCreatorCreatorIDLabel
            // 
            this.uxCreatorCreatorIDLabel.AutoSize = true;
            this.uxCreatorCreatorIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDLabel.Location = new System.Drawing.Point(960, 632);
            this.uxCreatorCreatorIDLabel.Name = "uxCreatorCreatorIDLabel";
            this.uxCreatorCreatorIDLabel.Size = new System.Drawing.Size(120, 32);
            this.uxCreatorCreatorIDLabel.TabIndex = 83;
            this.uxCreatorCreatorIDLabel.Text = "CreatorID:";
            // 
            // uxCreatorCreatorIDTextBox
            // 
            this.uxCreatorCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDTextBox.Location = new System.Drawing.Point(1086, 632);
            this.uxCreatorCreatorIDTextBox.Name = "uxCreatorCreatorIDTextBox";
            this.uxCreatorCreatorIDTextBox.Size = new System.Drawing.Size(413, 39);
            this.uxCreatorCreatorIDTextBox.TabIndex = 82;
            // 
            // uxCreatorTypeDDL
            // 
            this.uxCreatorTypeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCreatorTypeDDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorTypeDDL.FormattingEnabled = true;
            this.uxCreatorTypeDDL.Location = new System.Drawing.Point(243, 632);
            this.uxCreatorTypeDDL.Name = "uxCreatorTypeDDL";
            this.uxCreatorTypeDDL.Size = new System.Drawing.Size(390, 40);
            this.uxCreatorTypeDDL.TabIndex = 85;
            // 
            // uxGetCreatorByTypeGridView
            // 
            this.uxGetCreatorByTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGetCreatorByTypeGridView.Location = new System.Drawing.Point(52, 767);
            this.uxGetCreatorByTypeGridView.Name = "uxGetCreatorByTypeGridView";
            this.uxGetCreatorByTypeGridView.RowHeadersWidth = 62;
            this.uxGetCreatorByTypeGridView.RowTemplate.Height = 33;
            this.uxGetCreatorByTypeGridView.Size = new System.Drawing.Size(750, 381);
            this.uxGetCreatorByTypeGridView.TabIndex = 86;
            // 
            // uxLine3
            // 
            this.uxLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine3.Location = new System.Drawing.Point(848, 36);
            this.uxLine3.Name = "uxLine3";
            this.uxLine3.Size = new System.Drawing.Size(2, 1167);
            this.uxLine3.TabIndex = 87;
            this.uxLine3.Text = "                             ";
            // 
            // uxCreatorIDCLabel
            // 
            this.uxCreatorIDCLabel.AutoSize = true;
            this.uxCreatorIDCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorIDCLabel.Location = new System.Drawing.Point(117, 47);
            this.uxCreatorIDCLabel.Name = "uxCreatorIDCLabel";
            this.uxCreatorIDCLabel.Size = new System.Drawing.Size(120, 32);
            this.uxCreatorIDCLabel.TabIndex = 89;
            this.uxCreatorIDCLabel.Text = "CreatorID:";
            // 
            // uxUpdateCreatorIDTextBox
            // 
            this.uxUpdateCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpdateCreatorIDTextBox.Location = new System.Drawing.Point(253, 47);
            this.uxUpdateCreatorIDTextBox.Name = "uxUpdateCreatorIDTextBox";
            this.uxUpdateCreatorIDTextBox.Size = new System.Drawing.Size(413, 39);
            this.uxUpdateCreatorIDTextBox.TabIndex = 88;
            // 
            // uxAuthorCheckBox
            // 
            this.uxAuthorCheckBox.AutoSize = true;
            this.uxAuthorCheckBox.Location = new System.Drawing.Point(263, 105);
            this.uxAuthorCheckBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.uxAuthorCheckBox.Name = "uxAuthorCheckBox";
            this.uxAuthorCheckBox.Size = new System.Drawing.Size(93, 29);
            this.uxAuthorCheckBox.TabIndex = 90;
            this.uxAuthorCheckBox.Text = "Author";
            this.uxAuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxProducerCheckBox
            // 
            this.uxProducerCheckBox.AutoSize = true;
            this.uxProducerCheckBox.Location = new System.Drawing.Point(401, 105);
            this.uxProducerCheckBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.uxProducerCheckBox.Name = "uxProducerCheckBox";
            this.uxProducerCheckBox.Size = new System.Drawing.Size(109, 29);
            this.uxProducerCheckBox.TabIndex = 91;
            this.uxProducerCheckBox.Text = "Producer";
            this.uxProducerCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxDeveloperCheckBox
            // 
            this.uxDeveloperCheckBox.AutoSize = true;
            this.uxDeveloperCheckBox.Location = new System.Drawing.Point(541, 105);
            this.uxDeveloperCheckBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.uxDeveloperCheckBox.Name = "uxDeveloperCheckBox";
            this.uxDeveloperCheckBox.Size = new System.Drawing.Size(119, 29);
            this.uxDeveloperCheckBox.TabIndex = 92;
            this.uxDeveloperCheckBox.Text = "Developer";
            this.uxDeveloperCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxCreatorTypeCLabel
            // 
            this.uxCreatorTypeCLabel.AutoSize = true;
            this.uxCreatorTypeCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorTypeCLabel.Location = new System.Drawing.Point(100, 98);
            this.uxCreatorTypeCLabel.Name = "uxCreatorTypeCLabel";
            this.uxCreatorTypeCLabel.Size = new System.Drawing.Size(148, 32);
            this.uxCreatorTypeCLabel.TabIndex = 93;
            this.uxCreatorTypeCLabel.Text = "CreatorType:";
            // 
            // uxUpdateButton
            // 
            this.uxUpdateButton.Location = new System.Drawing.Point(289, 163);
            this.uxUpdateButton.Name = "uxUpdateButton";
            this.uxUpdateButton.Size = new System.Drawing.Size(254, 65);
            this.uxUpdateButton.TabIndex = 94;
            this.uxUpdateButton.Text = "Update Creator\'s Identity";
            this.uxUpdateButton.UseVisualStyleBackColor = true;
            this.uxUpdateButton.Click += new System.EventHandler(this.uxUpdateButton_Click);
            // 
            // uxCreatorCLabel
            // 
            this.uxCreatorCLabel.AutoSize = true;
            this.uxCreatorCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCLabel.Location = new System.Drawing.Point(97, 280);
            this.uxCreatorCLabel.Name = "uxCreatorCLabel";
            this.uxCreatorCLabel.Size = new System.Drawing.Size(120, 32);
            this.uxCreatorCLabel.TabIndex = 96;
            this.uxCreatorCLabel.Text = "CreatorID:";
            // 
            // uxFetchCreatorIDTextBox
            // 
            this.uxFetchCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFetchCreatorIDTextBox.Location = new System.Drawing.Point(230, 280);
            this.uxFetchCreatorIDTextBox.Name = "uxFetchCreatorIDTextBox";
            this.uxFetchCreatorIDTextBox.Size = new System.Drawing.Size(413, 39);
            this.uxFetchCreatorIDTextBox.TabIndex = 95;
            // 
            // uxFNameCLabel
            // 
            this.uxFNameCLabel.AutoSize = true;
            this.uxFNameCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFNameCLabel.Location = new System.Drawing.Point(81, 407);
            this.uxFNameCLabel.Name = "uxFNameCLabel";
            this.uxFNameCLabel.Size = new System.Drawing.Size(141, 32);
            this.uxFNameCLabel.TabIndex = 98;
            this.uxFNameCLabel.Text = "First Name: ";
            // 
            // uxFirstNameTextBox
            // 
            this.uxFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFirstNameTextBox.Location = new System.Drawing.Point(230, 407);
            this.uxFirstNameTextBox.Name = "uxFirstNameTextBox";
            this.uxFirstNameTextBox.Size = new System.Drawing.Size(413, 39);
            this.uxFirstNameTextBox.TabIndex = 97;
            // 
            // uxLNameLabel
            // 
            this.uxLNameLabel.AutoSize = true;
            this.uxLNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLNameLabel.Location = new System.Drawing.Point(81, 460);
            this.uxLNameLabel.Name = "uxLNameLabel";
            this.uxLNameLabel.Size = new System.Drawing.Size(138, 32);
            this.uxLNameLabel.TabIndex = 100;
            this.uxLNameLabel.Text = "Last Name: ";
            // 
            // uxLastNameTextBox
            // 
            this.uxLastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLastNameTextBox.Location = new System.Drawing.Point(230, 455);
            this.uxLastNameTextBox.Name = "uxLastNameTextBox";
            this.uxLastNameTextBox.Size = new System.Drawing.Size(413, 39);
            this.uxLastNameTextBox.TabIndex = 99;
            // 
            // uxFetchButton
            // 
            this.uxFetchButton.Location = new System.Drawing.Point(296, 338);
            this.uxFetchButton.Name = "uxFetchButton";
            this.uxFetchButton.Size = new System.Drawing.Size(254, 50);
            this.uxFetchButton.TabIndex = 101;
            this.uxFetchButton.Text = "Fetch Creator";
            this.uxFetchButton.UseVisualStyleBackColor = true;
            this.uxFetchButton.Click += new System.EventHandler(this.uxFetchButton_Click);
            // 
            // uxCompanyCLabel
            // 
            this.uxCompanyCLabel.AutoSize = true;
            this.uxCompanyCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCompanyCLabel.Location = new System.Drawing.Point(81, 510);
            this.uxCompanyCLabel.Name = "uxCompanyCLabel";
            this.uxCompanyCLabel.Size = new System.Drawing.Size(128, 32);
            this.uxCompanyCLabel.TabIndex = 103;
            this.uxCompanyCLabel.Text = "Company: ";
            // 
            // uxCompanyTextBox
            // 
            this.uxCompanyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCompanyTextBox.Location = new System.Drawing.Point(230, 508);
            this.uxCompanyTextBox.Name = "uxCompanyTextBox";
            this.uxCompanyTextBox.Size = new System.Drawing.Size(413, 39);
            this.uxCompanyTextBox.TabIndex = 102;
            // 
            // uxRetriveButton
            // 
            this.uxRetriveButton.Location = new System.Drawing.Point(1181, 47);
            this.uxRetriveButton.Name = "uxRetriveButton";
            this.uxRetriveButton.Size = new System.Drawing.Size(254, 73);
            this.uxRetriveButton.TabIndex = 104;
            this.uxRetriveButton.Text = "Retrieve All Creators";
            this.uxRetriveButton.UseVisualStyleBackColor = true;
            this.uxRetriveButton.Click += new System.EventHandler(this.uxRetriveButton_Click);
            // 
            // uxRetriveCreatorsGridView
            // 
            this.uxRetriveCreatorsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxRetriveCreatorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetriveCreatorsGridView.Location = new System.Drawing.Point(906, 164);
            this.uxRetriveCreatorsGridView.Name = "uxRetriveCreatorsGridView";
            this.uxRetriveCreatorsGridView.RowHeadersWidth = 62;
            this.uxRetriveCreatorsGridView.RowTemplate.Height = 33;
            this.uxRetriveCreatorsGridView.Size = new System.Drawing.Size(770, 383);
            this.uxRetriveCreatorsGridView.TabIndex = 105;
            // 
            // uxLine4
            // 
            this.uxLine4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine4.Location = new System.Drawing.Point(37, 595);
            this.uxLine4.Name = "uxLine4";
            this.uxLine4.Size = new System.Drawing.Size(780, 2);
            this.uxLine4.TabIndex = 106;
            this.uxLine4.Text = "                             ";
            // 
            // uxLine2
            // 
            this.uxLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine2.Location = new System.Drawing.Point(37, 248);
            this.uxLine2.Name = "uxLine2";
            this.uxLine2.Size = new System.Drawing.Size(780, 2);
            this.uxLine2.TabIndex = 107;
            this.uxLine2.Text = "                             ";
            // 
            // uxLine1
            // 
            this.uxLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine1.Location = new System.Drawing.Point(896, 595);
            this.uxLine1.Name = "uxLine1";
            this.uxLine1.Size = new System.Drawing.Size(780, 2);
            this.uxLine1.TabIndex = 108;
            this.uxLine1.Text = "                             ";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 1247);
            this.Controls.Add(this.uxLine1);
            this.Controls.Add(this.uxLine2);
            this.Controls.Add(this.uxLine4);
            this.Controls.Add(this.uxRetriveCreatorsGridView);
            this.Controls.Add(this.uxRetriveButton);
            this.Controls.Add(this.uxCompanyCLabel);
            this.Controls.Add(this.uxCompanyTextBox);
            this.Controls.Add(this.uxFetchButton);
            this.Controls.Add(this.uxLNameLabel);
            this.Controls.Add(this.uxLastNameTextBox);
            this.Controls.Add(this.uxFNameCLabel);
            this.Controls.Add(this.uxFirstNameTextBox);
            this.Controls.Add(this.uxCreatorCLabel);
            this.Controls.Add(this.uxFetchCreatorIDTextBox);
            this.Controls.Add(this.uxUpdateButton);
            this.Controls.Add(this.uxCreatorTypeCLabel);
            this.Controls.Add(this.uxDeveloperCheckBox);
            this.Controls.Add(this.uxProducerCheckBox);
            this.Controls.Add(this.uxAuthorCheckBox);
            this.Controls.Add(this.uxCreatorIDCLabel);
            this.Controls.Add(this.uxUpdateCreatorIDTextBox);
            this.Controls.Add(this.uxLine3);
            this.Controls.Add(this.uxGetCreatorByTypeGridView);
            this.Controls.Add(this.uxCreatorTypeDDL);
            this.Controls.Add(this.uxFetchProductionsByCreatorButton);
            this.Controls.Add(this.uxCreatorCreatorIDLabel);
            this.Controls.Add(this.uxCreatorCreatorIDTextBox);
            this.Controls.Add(this.uxFetchProductionsByCreatorGridView);
            this.Controls.Add(this.uxGetCreatorByTypeButton);
            this.Controls.Add(this.uxCreatorCreatorTypeLabel);
            this.Name = "Creator";
            this.Text = "Creator Controls";
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchProductionsByCreatorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGetCreatorByTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveCreatorsGridView)).EndInit();
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
        private System.Windows.Forms.Label uxCreatorIDCLabel;
        private System.Windows.Forms.TextBox uxUpdateCreatorIDTextBox;
        private System.Windows.Forms.CheckBox uxAuthorCheckBox;
        private System.Windows.Forms.CheckBox uxProducerCheckBox;
        private System.Windows.Forms.CheckBox uxDeveloperCheckBox;
        private System.Windows.Forms.Label uxCreatorTypeCLabel;
        private System.Windows.Forms.Button uxUpdateButton;
        private System.Windows.Forms.Label uxCreatorCLabel;
        private System.Windows.Forms.TextBox uxFetchCreatorIDTextBox;
        private System.Windows.Forms.Label uxFNameCLabel;
        private System.Windows.Forms.TextBox uxFirstNameTextBox;
        private System.Windows.Forms.Label uxLNameLabel;
        private System.Windows.Forms.TextBox uxLastNameTextBox;
        private System.Windows.Forms.Button uxFetchButton;
        private System.Windows.Forms.Label uxCompanyCLabel;
        private System.Windows.Forms.TextBox uxCompanyTextBox;
        private System.Windows.Forms.Button uxRetriveButton;
        private System.Windows.Forms.DataGridView uxRetriveCreatorsGridView;
        private System.Windows.Forms.Label uxLine4;
        private System.Windows.Forms.Label uxLine2;
        private System.Windows.Forms.Label uxLine1;
    }
}