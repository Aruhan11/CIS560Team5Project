
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creator));
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
            this.uxFetchProductionsByCreatorGridView.Location = new System.Drawing.Point(634, 460);
            this.uxFetchProductionsByCreatorGridView.Margin = new System.Windows.Forms.Padding(2);
            this.uxFetchProductionsByCreatorGridView.Name = "uxFetchProductionsByCreatorGridView";
            this.uxFetchProductionsByCreatorGridView.RowHeadersWidth = 62;
            this.uxFetchProductionsByCreatorGridView.RowTemplate.Height = 33;
            this.uxFetchProductionsByCreatorGridView.Size = new System.Drawing.Size(539, 227);
            this.uxFetchProductionsByCreatorGridView.TabIndex = 81;
            // 
            // uxGetCreatorByTypeButton
            // 
            this.uxGetCreatorByTypeButton.Location = new System.Drawing.Point(207, 417);
            this.uxGetCreatorByTypeButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxGetCreatorByTypeButton.Name = "uxGetCreatorByTypeButton";
            this.uxGetCreatorByTypeButton.Size = new System.Drawing.Size(178, 37);
            this.uxGetCreatorByTypeButton.TabIndex = 80;
            this.uxGetCreatorByTypeButton.Text = "Get Creators By Type";
            this.uxGetCreatorByTypeButton.UseVisualStyleBackColor = true;
            this.uxGetCreatorByTypeButton.Click += new System.EventHandler(this.uxGetCreatorByTypeButton_Click);
            // 
            // uxCreatorCreatorTypeLabel
            // 
            this.uxCreatorCreatorTypeLabel.AutoSize = true;
            this.uxCreatorCreatorTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorTypeLabel.Location = new System.Drawing.Point(57, 379);
            this.uxCreatorCreatorTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCreatorCreatorTypeLabel.Name = "uxCreatorCreatorTypeLabel";
            this.uxCreatorCreatorTypeLabel.Size = new System.Drawing.Size(101, 21);
            this.uxCreatorCreatorTypeLabel.TabIndex = 79;
            this.uxCreatorCreatorTypeLabel.Text = "Creator Type:";
            // 
            // uxFetchProductionsByCreatorButton
            // 
            this.uxFetchProductionsByCreatorButton.Enabled = false;
            this.uxFetchProductionsByCreatorButton.Location = new System.Drawing.Point(814, 417);
            this.uxFetchProductionsByCreatorButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxFetchProductionsByCreatorButton.Name = "uxFetchProductionsByCreatorButton";
            this.uxFetchProductionsByCreatorButton.Size = new System.Drawing.Size(178, 37);
            this.uxFetchProductionsByCreatorButton.TabIndex = 84;
            this.uxFetchProductionsByCreatorButton.Text = "Fetch Productions by Creator";
            this.uxFetchProductionsByCreatorButton.UseVisualStyleBackColor = true;
            this.uxFetchProductionsByCreatorButton.Click += new System.EventHandler(this.uxFetchProductionsByCreatorButton_Click);
            // 
            // uxCreatorCreatorIDLabel
            // 
            this.uxCreatorCreatorIDLabel.AutoSize = true;
            this.uxCreatorCreatorIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDLabel.Location = new System.Drawing.Point(672, 379);
            this.uxCreatorCreatorIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCreatorCreatorIDLabel.Name = "uxCreatorCreatorIDLabel";
            this.uxCreatorCreatorIDLabel.Size = new System.Drawing.Size(80, 21);
            this.uxCreatorCreatorIDLabel.TabIndex = 83;
            this.uxCreatorCreatorIDLabel.Text = "CreatorID:";
            // 
            // uxCreatorCreatorIDTextBox
            // 
            this.uxCreatorCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDTextBox.Location = new System.Drawing.Point(760, 379);
            this.uxCreatorCreatorIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxCreatorCreatorIDTextBox.Name = "uxCreatorCreatorIDTextBox";
            this.uxCreatorCreatorIDTextBox.Size = new System.Drawing.Size(290, 29);
            this.uxCreatorCreatorIDTextBox.TabIndex = 82;
            this.uxCreatorCreatorIDTextBox.TextChanged += new System.EventHandler(this.uxCreatorCreatorIDTextBox_TextChanged);
            // 
            // uxCreatorTypeDDL
            // 
            this.uxCreatorTypeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCreatorTypeDDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorTypeDDL.FormattingEnabled = true;
            this.uxCreatorTypeDDL.Location = new System.Drawing.Point(170, 379);
            this.uxCreatorTypeDDL.Margin = new System.Windows.Forms.Padding(2);
            this.uxCreatorTypeDDL.Name = "uxCreatorTypeDDL";
            this.uxCreatorTypeDDL.Size = new System.Drawing.Size(274, 29);
            this.uxCreatorTypeDDL.TabIndex = 85;
            // 
            // uxGetCreatorByTypeGridView
            // 
            this.uxGetCreatorByTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGetCreatorByTypeGridView.Location = new System.Drawing.Point(36, 460);
            this.uxGetCreatorByTypeGridView.Margin = new System.Windows.Forms.Padding(2);
            this.uxGetCreatorByTypeGridView.Name = "uxGetCreatorByTypeGridView";
            this.uxGetCreatorByTypeGridView.RowHeadersWidth = 62;
            this.uxGetCreatorByTypeGridView.RowTemplate.Height = 33;
            this.uxGetCreatorByTypeGridView.Size = new System.Drawing.Size(525, 229);
            this.uxGetCreatorByTypeGridView.TabIndex = 86;
            // 
            // uxLine3
            // 
            this.uxLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine3.Location = new System.Drawing.Point(594, 22);
            this.uxLine3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine3.Name = "uxLine3";
            this.uxLine3.Size = new System.Drawing.Size(1, 700);
            this.uxLine3.TabIndex = 87;
            this.uxLine3.Text = "                             ";
            // 
            // uxCreatorIDCLabel
            // 
            this.uxCreatorIDCLabel.AutoSize = true;
            this.uxCreatorIDCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorIDCLabel.Location = new System.Drawing.Point(82, 28);
            this.uxCreatorIDCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCreatorIDCLabel.Name = "uxCreatorIDCLabel";
            this.uxCreatorIDCLabel.Size = new System.Drawing.Size(80, 21);
            this.uxCreatorIDCLabel.TabIndex = 89;
            this.uxCreatorIDCLabel.Text = "CreatorID:";
            // 
            // uxUpdateCreatorIDTextBox
            // 
            this.uxUpdateCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpdateCreatorIDTextBox.Location = new System.Drawing.Point(177, 28);
            this.uxUpdateCreatorIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxUpdateCreatorIDTextBox.Name = "uxUpdateCreatorIDTextBox";
            this.uxUpdateCreatorIDTextBox.Size = new System.Drawing.Size(290, 29);
            this.uxUpdateCreatorIDTextBox.TabIndex = 88;
            this.uxUpdateCreatorIDTextBox.TextChanged += new System.EventHandler(this.UpdateCreator_EventListener);
            // 
            // uxAuthorCheckBox
            // 
            this.uxAuthorCheckBox.AutoSize = true;
            this.uxAuthorCheckBox.Location = new System.Drawing.Point(184, 63);
            this.uxAuthorCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxAuthorCheckBox.Name = "uxAuthorCheckBox";
            this.uxAuthorCheckBox.Size = new System.Drawing.Size(63, 19);
            this.uxAuthorCheckBox.TabIndex = 90;
            this.uxAuthorCheckBox.Text = "Author";
            this.uxAuthorCheckBox.UseVisualStyleBackColor = true;
            this.uxAuthorCheckBox.CheckedChanged += new System.EventHandler(this.UpdateCreator_EventListener);
            // 
            // uxProducerCheckBox
            // 
            this.uxProducerCheckBox.AutoSize = true;
            this.uxProducerCheckBox.Location = new System.Drawing.Point(281, 63);
            this.uxProducerCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxProducerCheckBox.Name = "uxProducerCheckBox";
            this.uxProducerCheckBox.Size = new System.Drawing.Size(74, 19);
            this.uxProducerCheckBox.TabIndex = 91;
            this.uxProducerCheckBox.Text = "Producer";
            this.uxProducerCheckBox.UseVisualStyleBackColor = true;
            this.uxProducerCheckBox.CheckedChanged += new System.EventHandler(this.UpdateCreator_EventListener);
            // 
            // uxDeveloperCheckBox
            // 
            this.uxDeveloperCheckBox.AutoSize = true;
            this.uxDeveloperCheckBox.Location = new System.Drawing.Point(379, 63);
            this.uxDeveloperCheckBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxDeveloperCheckBox.Name = "uxDeveloperCheckBox";
            this.uxDeveloperCheckBox.Size = new System.Drawing.Size(79, 19);
            this.uxDeveloperCheckBox.TabIndex = 92;
            this.uxDeveloperCheckBox.Text = "Developer";
            this.uxDeveloperCheckBox.UseVisualStyleBackColor = true;
            this.uxDeveloperCheckBox.CheckedChanged += new System.EventHandler(this.UpdateCreator_EventListener);
            // 
            // uxCreatorTypeCLabel
            // 
            this.uxCreatorTypeCLabel.AutoSize = true;
            this.uxCreatorTypeCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorTypeCLabel.Location = new System.Drawing.Point(70, 59);
            this.uxCreatorTypeCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCreatorTypeCLabel.Name = "uxCreatorTypeCLabel";
            this.uxCreatorTypeCLabel.Size = new System.Drawing.Size(97, 21);
            this.uxCreatorTypeCLabel.TabIndex = 93;
            this.uxCreatorTypeCLabel.Text = "CreatorType:";
            // 
            // uxUpdateButton
            // 
            this.uxUpdateButton.Enabled = false;
            this.uxUpdateButton.Location = new System.Drawing.Point(202, 98);
            this.uxUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxUpdateButton.Name = "uxUpdateButton";
            this.uxUpdateButton.Size = new System.Drawing.Size(178, 39);
            this.uxUpdateButton.TabIndex = 94;
            this.uxUpdateButton.Text = "Update Creator\'s Identity";
            this.uxUpdateButton.UseVisualStyleBackColor = true;
            this.uxUpdateButton.Click += new System.EventHandler(this.uxUpdateButton_Click);
            // 
            // uxCreatorCLabel
            // 
            this.uxCreatorCLabel.AutoSize = true;
            this.uxCreatorCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCLabel.Location = new System.Drawing.Point(68, 168);
            this.uxCreatorCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCreatorCLabel.Name = "uxCreatorCLabel";
            this.uxCreatorCLabel.Size = new System.Drawing.Size(80, 21);
            this.uxCreatorCLabel.TabIndex = 96;
            this.uxCreatorCLabel.Text = "CreatorID:";
            // 
            // uxFetchCreatorIDTextBox
            // 
            this.uxFetchCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFetchCreatorIDTextBox.Location = new System.Drawing.Point(161, 168);
            this.uxFetchCreatorIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxFetchCreatorIDTextBox.Name = "uxFetchCreatorIDTextBox";
            this.uxFetchCreatorIDTextBox.Size = new System.Drawing.Size(290, 29);
            this.uxFetchCreatorIDTextBox.TabIndex = 95;
            this.uxFetchCreatorIDTextBox.TextChanged += new System.EventHandler(this.uxFetchCreatorIDTextBox_TextChanged);
            // 
            // uxFNameCLabel
            // 
            this.uxFNameCLabel.AutoSize = true;
            this.uxFNameCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFNameCLabel.Location = new System.Drawing.Point(57, 244);
            this.uxFNameCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxFNameCLabel.Name = "uxFNameCLabel";
            this.uxFNameCLabel.Size = new System.Drawing.Size(93, 21);
            this.uxFNameCLabel.TabIndex = 98;
            this.uxFNameCLabel.Text = "First Name: ";
            // 
            // uxFirstNameTextBox
            // 
            this.uxFirstNameTextBox.Enabled = false;
            this.uxFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFirstNameTextBox.Location = new System.Drawing.Point(161, 244);
            this.uxFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxFirstNameTextBox.Name = "uxFirstNameTextBox";
            this.uxFirstNameTextBox.Size = new System.Drawing.Size(290, 29);
            this.uxFirstNameTextBox.TabIndex = 97;
            // 
            // uxLNameLabel
            // 
            this.uxLNameLabel.AutoSize = true;
            this.uxLNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLNameLabel.Location = new System.Drawing.Point(57, 276);
            this.uxLNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLNameLabel.Name = "uxLNameLabel";
            this.uxLNameLabel.Size = new System.Drawing.Size(91, 21);
            this.uxLNameLabel.TabIndex = 100;
            this.uxLNameLabel.Text = "Last Name: ";
            // 
            // uxLastNameTextBox
            // 
            this.uxLastNameTextBox.Enabled = false;
            this.uxLastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLastNameTextBox.Location = new System.Drawing.Point(161, 273);
            this.uxLastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxLastNameTextBox.Name = "uxLastNameTextBox";
            this.uxLastNameTextBox.Size = new System.Drawing.Size(290, 29);
            this.uxLastNameTextBox.TabIndex = 99;
            // 
            // uxFetchButton
            // 
            this.uxFetchButton.Enabled = false;
            this.uxFetchButton.Location = new System.Drawing.Point(207, 203);
            this.uxFetchButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxFetchButton.Name = "uxFetchButton";
            this.uxFetchButton.Size = new System.Drawing.Size(178, 30);
            this.uxFetchButton.TabIndex = 101;
            this.uxFetchButton.Text = "Fetch Creator";
            this.uxFetchButton.UseVisualStyleBackColor = true;
            this.uxFetchButton.Click += new System.EventHandler(this.uxFetchButton_Click);
            // 
            // uxCompanyCLabel
            // 
            this.uxCompanyCLabel.AutoSize = true;
            this.uxCompanyCLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCompanyCLabel.Location = new System.Drawing.Point(57, 306);
            this.uxCompanyCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxCompanyCLabel.Name = "uxCompanyCLabel";
            this.uxCompanyCLabel.Size = new System.Drawing.Size(84, 21);
            this.uxCompanyCLabel.TabIndex = 103;
            this.uxCompanyCLabel.Text = "Company: ";
            // 
            // uxCompanyTextBox
            // 
            this.uxCompanyTextBox.Enabled = false;
            this.uxCompanyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCompanyTextBox.Location = new System.Drawing.Point(161, 305);
            this.uxCompanyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxCompanyTextBox.Name = "uxCompanyTextBox";
            this.uxCompanyTextBox.Size = new System.Drawing.Size(290, 29);
            this.uxCompanyTextBox.TabIndex = 102;
            // 
            // uxRetriveButton
            // 
            this.uxRetriveButton.Location = new System.Drawing.Point(827, 28);
            this.uxRetriveButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxRetriveButton.Name = "uxRetriveButton";
            this.uxRetriveButton.Size = new System.Drawing.Size(178, 44);
            this.uxRetriveButton.TabIndex = 104;
            this.uxRetriveButton.Text = "Retrieve All Creators";
            this.uxRetriveButton.UseVisualStyleBackColor = true;
            this.uxRetriveButton.Click += new System.EventHandler(this.uxRetriveButton_Click);
            // 
            // uxRetriveCreatorsGridView
            // 
            this.uxRetriveCreatorsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxRetriveCreatorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetriveCreatorsGridView.Location = new System.Drawing.Point(634, 98);
            this.uxRetriveCreatorsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.uxRetriveCreatorsGridView.Name = "uxRetriveCreatorsGridView";
            this.uxRetriveCreatorsGridView.RowHeadersWidth = 62;
            this.uxRetriveCreatorsGridView.RowTemplate.Height = 33;
            this.uxRetriveCreatorsGridView.Size = new System.Drawing.Size(539, 230);
            this.uxRetriveCreatorsGridView.TabIndex = 105;
            // 
            // uxLine4
            // 
            this.uxLine4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine4.Location = new System.Drawing.Point(26, 357);
            this.uxLine4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine4.Name = "uxLine4";
            this.uxLine4.Size = new System.Drawing.Size(546, 1);
            this.uxLine4.TabIndex = 106;
            this.uxLine4.Text = "                             ";
            // 
            // uxLine2
            // 
            this.uxLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine2.Location = new System.Drawing.Point(26, 149);
            this.uxLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine2.Name = "uxLine2";
            this.uxLine2.Size = new System.Drawing.Size(546, 1);
            this.uxLine2.TabIndex = 107;
            this.uxLine2.Text = "                             ";
            // 
            // uxLine1
            // 
            this.uxLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine1.Location = new System.Drawing.Point(627, 357);
            this.uxLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine1.Name = "uxLine1";
            this.uxLine1.Size = new System.Drawing.Size(546, 1);
            this.uxLine1.TabIndex = 108;
            this.uxLine1.Text = "                             ";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 748);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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