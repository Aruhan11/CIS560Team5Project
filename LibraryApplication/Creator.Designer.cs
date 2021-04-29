﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.uxUpdateCreatorIDTextBox = new System.Windows.Forms.TextBox();
            this.uxAuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.uxProducerCheckBox = new System.Windows.Forms.CheckBox();
            this.uxDeveloperCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxUpdateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uxFetchCreatorIDTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.uxCompanyTextBox = new System.Windows.Forms.TextBox();
            this.uxRetriveButton = new System.Windows.Forms.Button();
            this.uxRetriveCreatorsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxFetchProductionsByCreatorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGetCreatorByTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveCreatorsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFetchProductionsByCreatorGridView
            // 
            this.uxFetchProductionsByCreatorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxFetchProductionsByCreatorGridView.Location = new System.Drawing.Point(1540, 1258);
            this.uxFetchProductionsByCreatorGridView.Margin = new System.Windows.Forms.Padding(5);
            this.uxFetchProductionsByCreatorGridView.Name = "uxFetchProductionsByCreatorGridView";
            this.uxFetchProductionsByCreatorGridView.RowHeadersWidth = 62;
            this.uxFetchProductionsByCreatorGridView.RowTemplate.Height = 33;
            this.uxFetchProductionsByCreatorGridView.Size = new System.Drawing.Size(1309, 1038);
            this.uxFetchProductionsByCreatorGridView.TabIndex = 81;
            // 
            // uxGetCreatorByTypeButton
            // 
            this.uxGetCreatorByTypeButton.Location = new System.Drawing.Point(503, 1140);
            this.uxGetCreatorByTypeButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxGetCreatorByTypeButton.Name = "uxGetCreatorByTypeButton";
            this.uxGetCreatorByTypeButton.Size = new System.Drawing.Size(432, 102);
            this.uxGetCreatorByTypeButton.TabIndex = 80;
            this.uxGetCreatorByTypeButton.Text = "Get Creators By Type";
            this.uxGetCreatorByTypeButton.UseVisualStyleBackColor = true;
            this.uxGetCreatorByTypeButton.Click += new System.EventHandler(this.uxGetCreatorByTypeButton_Click);
            // 
            // uxCreatorCreatorTypeLabel
            // 
            this.uxCreatorCreatorTypeLabel.AutoSize = true;
            this.uxCreatorCreatorTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorTypeLabel.Location = new System.Drawing.Point(138, 1036);
            this.uxCreatorCreatorTypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxCreatorCreatorTypeLabel.Name = "uxCreatorCreatorTypeLabel";
            this.uxCreatorCreatorTypeLabel.Size = new System.Drawing.Size(257, 54);
            this.uxCreatorCreatorTypeLabel.TabIndex = 79;
            this.uxCreatorCreatorTypeLabel.Text = "Creator Type:";
            // 
            // uxFetchProductionsByCreatorButton
            // 
            this.uxFetchProductionsByCreatorButton.Location = new System.Drawing.Point(1977, 1140);
            this.uxFetchProductionsByCreatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxFetchProductionsByCreatorButton.Name = "uxFetchProductionsByCreatorButton";
            this.uxFetchProductionsByCreatorButton.Size = new System.Drawing.Size(432, 102);
            this.uxFetchProductionsByCreatorButton.TabIndex = 84;
            this.uxFetchProductionsByCreatorButton.Text = "Fetch Productions by Creator";
            this.uxFetchProductionsByCreatorButton.UseVisualStyleBackColor = true;
            this.uxFetchProductionsByCreatorButton.Click += new System.EventHandler(this.uxFetchProductionsByCreatorButton_Click);
            // 
            // uxCreatorCreatorIDLabel
            // 
            this.uxCreatorCreatorIDLabel.AutoSize = true;
            this.uxCreatorCreatorIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDLabel.Location = new System.Drawing.Point(1633, 1036);
            this.uxCreatorCreatorIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxCreatorCreatorIDLabel.Name = "uxCreatorCreatorIDLabel";
            this.uxCreatorCreatorIDLabel.Size = new System.Drawing.Size(202, 54);
            this.uxCreatorCreatorIDLabel.TabIndex = 83;
            this.uxCreatorCreatorIDLabel.Text = "CreatorID:";
            // 
            // uxCreatorCreatorIDTextBox
            // 
            this.uxCreatorCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorCreatorIDTextBox.Location = new System.Drawing.Point(1845, 1036);
            this.uxCreatorCreatorIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxCreatorCreatorIDTextBox.Name = "uxCreatorCreatorIDTextBox";
            this.uxCreatorCreatorIDTextBox.Size = new System.Drawing.Size(699, 61);
            this.uxCreatorCreatorIDTextBox.TabIndex = 82;
            // 
            // uxCreatorTypeDDL
            // 
            this.uxCreatorTypeDDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxCreatorTypeDDL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorTypeDDL.FormattingEnabled = true;
            this.uxCreatorTypeDDL.Location = new System.Drawing.Point(412, 1036);
            this.uxCreatorTypeDDL.Margin = new System.Windows.Forms.Padding(5);
            this.uxCreatorTypeDDL.Name = "uxCreatorTypeDDL";
            this.uxCreatorTypeDDL.Size = new System.Drawing.Size(660, 62);
            this.uxCreatorTypeDDL.TabIndex = 85;
            // 
            // uxGetCreatorByTypeGridView
            // 
            this.uxGetCreatorByTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGetCreatorByTypeGridView.Location = new System.Drawing.Point(90, 1255);
            this.uxGetCreatorByTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.uxGetCreatorByTypeGridView.Name = "uxGetCreatorByTypeGridView";
            this.uxGetCreatorByTypeGridView.RowHeadersWidth = 62;
            this.uxGetCreatorByTypeGridView.RowTemplate.Height = 33;
            this.uxGetCreatorByTypeGridView.Size = new System.Drawing.Size(1275, 1041);
            this.uxGetCreatorByTypeGridView.TabIndex = 86;
            // 
            // uxLine3
            // 
            this.uxLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine3.Location = new System.Drawing.Point(1455, 123);
            this.uxLine3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxLine3.Name = "uxLine3";
            this.uxLine3.Size = new System.Drawing.Size(2, 2222);
            this.uxLine3.TabIndex = 87;
            this.uxLine3.Text = "                             ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 54);
            this.label1.TabIndex = 89;
            this.label1.Text = "CreatorID:";
            // 
            // uxUpdateCreatorIDTextBox
            // 
            this.uxUpdateCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpdateCreatorIDTextBox.Location = new System.Drawing.Point(431, 76);
            this.uxUpdateCreatorIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxUpdateCreatorIDTextBox.Name = "uxUpdateCreatorIDTextBox";
            this.uxUpdateCreatorIDTextBox.Size = new System.Drawing.Size(699, 61);
            this.uxUpdateCreatorIDTextBox.TabIndex = 88;
            // 
            // uxAuthorCheckBox
            // 
            this.uxAuthorCheckBox.AutoSize = true;
            this.uxAuthorCheckBox.Location = new System.Drawing.Point(447, 171);
            this.uxAuthorCheckBox.Name = "uxAuthorCheckBox";
            this.uxAuthorCheckBox.Size = new System.Drawing.Size(147, 45);
            this.uxAuthorCheckBox.TabIndex = 90;
            this.uxAuthorCheckBox.Text = "Author";
            this.uxAuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxProducerCheckBox
            // 
            this.uxProducerCheckBox.AutoSize = true;
            this.uxProducerCheckBox.Location = new System.Drawing.Point(683, 171);
            this.uxProducerCheckBox.Name = "uxProducerCheckBox";
            this.uxProducerCheckBox.Size = new System.Drawing.Size(176, 45);
            this.uxProducerCheckBox.TabIndex = 91;
            this.uxProducerCheckBox.Text = "Producer";
            this.uxProducerCheckBox.UseVisualStyleBackColor = true;
            // 
            // uxDeveloperCheckBox
            // 
            this.uxDeveloperCheckBox.AutoSize = true;
            this.uxDeveloperCheckBox.Location = new System.Drawing.Point(920, 171);
            this.uxDeveloperCheckBox.Name = "uxDeveloperCheckBox";
            this.uxDeveloperCheckBox.Size = new System.Drawing.Size(192, 45);
            this.uxDeveloperCheckBox.TabIndex = 92;
            this.uxDeveloperCheckBox.Text = "Developer";
            this.uxDeveloperCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 54);
            this.label2.TabIndex = 93;
            this.label2.Text = "CreatorType:";
            // 
            // uxUpdateButton
            // 
            this.uxUpdateButton.Location = new System.Drawing.Point(490, 268);
            this.uxUpdateButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxUpdateButton.Name = "uxUpdateButton";
            this.uxUpdateButton.Size = new System.Drawing.Size(432, 107);
            this.uxUpdateButton.TabIndex = 94;
            this.uxUpdateButton.Text = "Update Creaetor\'s Identity";
            this.uxUpdateButton.UseVisualStyleBackColor = true;
            this.uxUpdateButton.Click += new System.EventHandler(this.uxUpdateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(164, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 54);
            this.label3.TabIndex = 96;
            this.label3.Text = "CreatorID:";
            // 
            // uxFetchCreatorIDTextBox
            // 
            this.uxFetchCreatorIDTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFetchCreatorIDTextBox.Location = new System.Drawing.Point(392, 460);
            this.uxFetchCreatorIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxFetchCreatorIDTextBox.Name = "uxFetchCreatorIDTextBox";
            this.uxFetchCreatorIDTextBox.Size = new System.Drawing.Size(699, 61);
            this.uxFetchCreatorIDTextBox.TabIndex = 95;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(138, 667);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 54);
            this.label4.TabIndex = 98;
            this.label4.Text = "First Name: ";
            // 
            // uxFirstNameTextBox
            // 
            this.uxFirstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFirstNameTextBox.Location = new System.Drawing.Point(392, 667);
            this.uxFirstNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxFirstNameTextBox.Name = "uxFirstNameTextBox";
            this.uxFirstNameTextBox.Size = new System.Drawing.Size(699, 61);
            this.uxFirstNameTextBox.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(138, 754);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 54);
            this.label5.TabIndex = 100;
            this.label5.Text = "Last Name: ";
            // 
            // uxLastNameTextBox
            // 
            this.uxLastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLastNameTextBox.Location = new System.Drawing.Point(392, 747);
            this.uxLastNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxLastNameTextBox.Name = "uxLastNameTextBox";
            this.uxLastNameTextBox.Size = new System.Drawing.Size(699, 61);
            this.uxLastNameTextBox.TabIndex = 99;
            // 
            // uxFetchButton
            // 
            this.uxFetchButton.Location = new System.Drawing.Point(503, 554);
            this.uxFetchButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxFetchButton.Name = "uxFetchButton";
            this.uxFetchButton.Size = new System.Drawing.Size(432, 81);
            this.uxFetchButton.TabIndex = 101;
            this.uxFetchButton.Text = "Fetch Creator";
            this.uxFetchButton.UseVisualStyleBackColor = true;
            this.uxFetchButton.Click += new System.EventHandler(this.uxFetchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(138, 837);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 54);
            this.label6.TabIndex = 103;
            this.label6.Text = "Company: ";
            // 
            // uxCompanyTextBox
            // 
            this.uxCompanyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCompanyTextBox.Location = new System.Drawing.Point(392, 834);
            this.uxCompanyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxCompanyTextBox.Name = "uxCompanyTextBox";
            this.uxCompanyTextBox.Size = new System.Drawing.Size(699, 61);
            this.uxCompanyTextBox.TabIndex = 102;
            // 
            // uxRetriveButton
            // 
            this.uxRetriveButton.Location = new System.Drawing.Point(2008, 76);
            this.uxRetriveButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxRetriveButton.Name = "uxRetriveButton";
            this.uxRetriveButton.Size = new System.Drawing.Size(432, 119);
            this.uxRetriveButton.TabIndex = 104;
            this.uxRetriveButton.Text = "Retrive All Creators";
            this.uxRetriveButton.UseVisualStyleBackColor = true;
            this.uxRetriveButton.Click += new System.EventHandler(this.uxRetriveButton_Click);
            // 
            // uxRetriveCreatorsGridView
            // 
            this.uxRetriveCreatorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetriveCreatorsGridView.Location = new System.Drawing.Point(1550, 226);
            this.uxRetriveCreatorsGridView.Margin = new System.Windows.Forms.Padding(5);
            this.uxRetriveCreatorsGridView.Name = "uxRetriveCreatorsGridView";
            this.uxRetriveCreatorsGridView.RowHeadersWidth = 62;
            this.uxRetriveCreatorsGridView.RowTemplate.Height = 33;
            this.uxRetriveCreatorsGridView.Size = new System.Drawing.Size(1309, 766);
            this.uxRetriveCreatorsGridView.TabIndex = 105;
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2958, 2108);
            this.Controls.Add(this.uxRetriveCreatorsGridView);
            this.Controls.Add(this.uxRetriveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxCompanyTextBox);
            this.Controls.Add(this.uxFetchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxLastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxFirstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxFetchCreatorIDTextBox);
            this.Controls.Add(this.uxUpdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxDeveloperCheckBox);
            this.Controls.Add(this.uxProducerCheckBox);
            this.Controls.Add(this.uxAuthorCheckBox);
            this.Controls.Add(this.label1);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Creator";
            this.Text = "Creator";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxUpdateCreatorIDTextBox;
        private System.Windows.Forms.CheckBox uxAuthorCheckBox;
        private System.Windows.Forms.CheckBox uxProducerCheckBox;
        private System.Windows.Forms.CheckBox uxDeveloperCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxUpdateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxFetchCreatorIDTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxFirstNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxLastNameTextBox;
        private System.Windows.Forms.Button uxFetchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxCompanyTextBox;
        private System.Windows.Forms.Button uxRetriveButton;
        private System.Windows.Forms.DataGridView uxRetriveCreatorsGridView;
    }
}