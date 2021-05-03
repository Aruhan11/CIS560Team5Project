
namespace LibraryProject
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.uxAddFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddFirstNameLabel = new System.Windows.Forms.Label();
            this.uxCreateUserButton = new System.Windows.Forms.Button();
            this.uxAddLastNameLabel = new System.Windows.Forms.Label();
            this.uxAddLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddPhoneLabel = new System.Windows.Forms.Label();
            this.uxFetchUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchButton = new System.Windows.Forms.Button();
            this.uxFetchPhoneLabel = new System.Windows.Forms.Label();
            this.uxFetchPhoneTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchLNameTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchLNameLabel = new System.Windows.Forms.Label();
            this.uxFetchFNameLabel = new System.Windows.Forms.Label();
            this.uxFetchFNameTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchUserIDLabel = new System.Windows.Forms.Label();
            this.uxGetPhoneLabel = new System.Windows.Forms.Label();
            this.uxGetLNameLabel = new System.Windows.Forms.Label();
            this.uxGetLNameTextBox = new System.Windows.Forms.TextBox();
            this.uxGetFNameTextBox = new System.Windows.Forms.TextBox();
            this.uxGetFNameLabel = new System.Windows.Forms.Label();
            this.uxGetUserIDLabel = new System.Windows.Forms.Label();
            this.uxGetUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxGetButton = new System.Windows.Forms.Button();
            this.uxGetPhoneTextBox = new System.Windows.Forms.TextBox();
            this.uxDeleteButton = new System.Windows.Forms.Button();
            this.uxDelUserLabel = new System.Windows.Forms.Label();
            this.uxDelUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxUpPhoneLabel = new System.Windows.Forms.Label();
            this.uxUpdatePhonenumberTextBox = new System.Windows.Forms.TextBox();
            this.uxUpdateUserButton = new System.Windows.Forms.Button();
            this.uxRetriveUsersGridView = new System.Windows.Forms.DataGridView();
            this.uxRetriveButton = new System.Windows.Forms.Button();
            this.uxUpUserIDLabel = new System.Windows.Forms.Label();
            this.uxUpdateUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxLine3 = new System.Windows.Forms.Label();
            this.uxLine2 = new System.Windows.Forms.Label();
            this.uxLine4 = new System.Windows.Forms.Label();
            this.uxLine1 = new System.Windows.Forms.Label();
            this.uxLine5 = new System.Windows.Forms.Label();
            this.uxAddPhoneTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveUsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAddFirstNameTextBox
            // 
            this.uxAddFirstNameTextBox.Location = new System.Drawing.Point(295, 59);
            this.uxAddFirstNameTextBox.Name = "uxAddFirstNameTextBox";
            this.uxAddFirstNameTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxAddFirstNameTextBox.TabIndex = 0;
            this.uxAddFirstNameTextBox.TextChanged += new System.EventHandler(this.uxAddFirstNameTextBox_TextChanged_1);
            // 
            // uxAddFirstNameLabel
            // 
            this.uxAddFirstNameLabel.AutoSize = true;
            this.uxAddFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddFirstNameLabel.Location = new System.Drawing.Point(41, 62);
            this.uxAddFirstNameLabel.Name = "uxAddFirstNameLabel";
            this.uxAddFirstNameLabel.Size = new System.Drawing.Size(223, 54);
            this.uxAddFirstNameLabel.TabIndex = 1;
            this.uxAddFirstNameLabel.Text = "First Name:";
            // 
            // uxCreateUserButton
            // 
            this.uxCreateUserButton.Enabled = false;
            this.uxCreateUserButton.Location = new System.Drawing.Point(264, 272);
            this.uxCreateUserButton.Name = "uxCreateUserButton";
            this.uxCreateUserButton.Size = new System.Drawing.Size(254, 85);
            this.uxCreateUserButton.TabIndex = 2;
            this.uxCreateUserButton.Text = "Create User";
            this.uxCreateUserButton.UseVisualStyleBackColor = true;
            this.uxCreateUserButton.Click += new System.EventHandler(this.uxCreateUserButton_Click);
            // 
            // uxAddLastNameLabel
            // 
            this.uxAddLastNameLabel.AutoSize = true;
            this.uxAddLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddLastNameLabel.Location = new System.Drawing.Point(46, 123);
            this.uxAddLastNameLabel.Name = "uxAddLastNameLabel";
            this.uxAddLastNameLabel.Size = new System.Drawing.Size(218, 54);
            this.uxAddLastNameLabel.TabIndex = 3;
            this.uxAddLastNameLabel.Text = "Last Name:";
            // 
            // uxAddLastNameTextBox
            // 
            this.uxAddLastNameTextBox.Location = new System.Drawing.Point(295, 120);
            this.uxAddLastNameTextBox.Name = "uxAddLastNameTextBox";
            this.uxAddLastNameTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxAddLastNameTextBox.TabIndex = 4;
            this.uxAddLastNameTextBox.TextChanged += new System.EventHandler(this.uxAddLastNameTextBox_TextChanged);
            // 
            // uxAddPhoneLabel
            // 
            this.uxAddPhoneLabel.AutoSize = true;
            this.uxAddPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddPhoneLabel.Location = new System.Drawing.Point(2, 184);
            this.uxAddPhoneLabel.Name = "uxAddPhoneLabel";
            this.uxAddPhoneLabel.Size = new System.Drawing.Size(301, 54);
            this.uxAddPhoneLabel.TabIndex = 6;
            this.uxAddPhoneLabel.Text = "Phone Number:";
            // 
            // uxFetchUserIDTextBox
            // 
            this.uxFetchUserIDTextBox.Location = new System.Drawing.Point(240, 508);
            this.uxFetchUserIDTextBox.Name = "uxFetchUserIDTextBox";
            this.uxFetchUserIDTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxFetchUserIDTextBox.TabIndex = 8;
            this.uxFetchUserIDTextBox.TextChanged += new System.EventHandler(this.uxFetchUserIDTextBox_TextChanged);
            // 
            // uxFetchButton
            // 
            this.uxFetchButton.Enabled = false;
            this.uxFetchButton.Location = new System.Drawing.Point(264, 580);
            this.uxFetchButton.Name = "uxFetchButton";
            this.uxFetchButton.Size = new System.Drawing.Size(254, 85);
            this.uxFetchButton.TabIndex = 9;
            this.uxFetchButton.Text = "Fetch User";
            this.uxFetchButton.UseVisualStyleBackColor = true;
            this.uxFetchButton.Click += new System.EventHandler(this.uxFetchButton_Click);
            // 
            // uxFetchPhoneLabel
            // 
            this.uxFetchPhoneLabel.AutoSize = true;
            this.uxFetchPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFetchPhoneLabel.Location = new System.Drawing.Point(2, 820);
            this.uxFetchPhoneLabel.Name = "uxFetchPhoneLabel";
            this.uxFetchPhoneLabel.Size = new System.Drawing.Size(301, 54);
            this.uxFetchPhoneLabel.TabIndex = 15;
            this.uxFetchPhoneLabel.Text = "Phone Number:";
            // 
            // uxFetchPhoneTextBox
            // 
            this.uxFetchPhoneTextBox.Enabled = false;
            this.uxFetchPhoneTextBox.Location = new System.Drawing.Point(295, 820);
            this.uxFetchPhoneTextBox.Name = "uxFetchPhoneTextBox";
            this.uxFetchPhoneTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxFetchPhoneTextBox.TabIndex = 14;
            // 
            // uxFetchLNameTextBox
            // 
            this.uxFetchLNameTextBox.Enabled = false;
            this.uxFetchLNameTextBox.Location = new System.Drawing.Point(295, 765);
            this.uxFetchLNameTextBox.Name = "uxFetchLNameTextBox";
            this.uxFetchLNameTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxFetchLNameTextBox.TabIndex = 13;
            // 
            // uxFetchLNameLabel
            // 
            this.uxFetchLNameLabel.AutoSize = true;
            this.uxFetchLNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFetchLNameLabel.Location = new System.Drawing.Point(64, 757);
            this.uxFetchLNameLabel.Name = "uxFetchLNameLabel";
            this.uxFetchLNameLabel.Size = new System.Drawing.Size(218, 54);
            this.uxFetchLNameLabel.TabIndex = 12;
            this.uxFetchLNameLabel.Text = "Last Name:";
            // 
            // uxFetchFNameLabel
            // 
            this.uxFetchFNameLabel.AutoSize = true;
            this.uxFetchFNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFetchFNameLabel.Location = new System.Drawing.Point(59, 703);
            this.uxFetchFNameLabel.Name = "uxFetchFNameLabel";
            this.uxFetchFNameLabel.Size = new System.Drawing.Size(223, 54);
            this.uxFetchFNameLabel.TabIndex = 11;
            this.uxFetchFNameLabel.Text = "First Name:";
            // 
            // uxFetchFNameTextBox
            // 
            this.uxFetchFNameTextBox.Enabled = false;
            this.uxFetchFNameTextBox.Location = new System.Drawing.Point(295, 706);
            this.uxFetchFNameTextBox.Name = "uxFetchFNameTextBox";
            this.uxFetchFNameTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxFetchFNameTextBox.TabIndex = 10;
            // 
            // uxFetchUserIDLabel
            // 
            this.uxFetchUserIDLabel.AutoSize = true;
            this.uxFetchUserIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxFetchUserIDLabel.Location = new System.Drawing.Point(64, 508);
            this.uxFetchUserIDLabel.Name = "uxFetchUserIDLabel";
            this.uxFetchUserIDLabel.Size = new System.Drawing.Size(161, 54);
            this.uxFetchUserIDLabel.TabIndex = 16;
            this.uxFetchUserIDLabel.Text = "UserID :";
            // 
            // uxGetPhoneLabel
            // 
            this.uxGetPhoneLabel.AutoSize = true;
            this.uxGetPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxGetPhoneLabel.Location = new System.Drawing.Point(757, 508);
            this.uxGetPhoneLabel.Name = "uxGetPhoneLabel";
            this.uxGetPhoneLabel.Size = new System.Drawing.Size(301, 54);
            this.uxGetPhoneLabel.TabIndex = 26;
            this.uxGetPhoneLabel.Text = "Phone Number:";
            // 
            // uxGetLNameLabel
            // 
            this.uxGetLNameLabel.AutoSize = true;
            this.uxGetLNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxGetLNameLabel.Location = new System.Drawing.Point(772, 839);
            this.uxGetLNameLabel.Name = "uxGetLNameLabel";
            this.uxGetLNameLabel.Size = new System.Drawing.Size(218, 54);
            this.uxGetLNameLabel.TabIndex = 25;
            this.uxGetLNameLabel.Text = "Last Name:";
            // 
            // uxGetLNameTextBox
            // 
            this.uxGetLNameTextBox.Enabled = false;
            this.uxGetLNameTextBox.Location = new System.Drawing.Point(1017, 839);
            this.uxGetLNameTextBox.Name = "uxGetLNameTextBox";
            this.uxGetLNameTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxGetLNameTextBox.TabIndex = 24;
            // 
            // uxGetFNameTextBox
            // 
            this.uxGetFNameTextBox.Enabled = false;
            this.uxGetFNameTextBox.Location = new System.Drawing.Point(1017, 769);
            this.uxGetFNameTextBox.Name = "uxGetFNameTextBox";
            this.uxGetFNameTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxGetFNameTextBox.TabIndex = 23;
            // 
            // uxGetFNameLabel
            // 
            this.uxGetFNameLabel.AutoSize = true;
            this.uxGetFNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxGetFNameLabel.Location = new System.Drawing.Point(767, 776);
            this.uxGetFNameLabel.Name = "uxGetFNameLabel";
            this.uxGetFNameLabel.Size = new System.Drawing.Size(223, 54);
            this.uxGetFNameLabel.TabIndex = 22;
            this.uxGetFNameLabel.Text = "First Name:";
            // 
            // uxGetUserIDLabel
            // 
            this.uxGetUserIDLabel.AutoSize = true;
            this.uxGetUserIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxGetUserIDLabel.Location = new System.Drawing.Point(780, 707);
            this.uxGetUserIDLabel.Name = "uxGetUserIDLabel";
            this.uxGetUserIDLabel.Size = new System.Drawing.Size(161, 54);
            this.uxGetUserIDLabel.TabIndex = 21;
            this.uxGetUserIDLabel.Text = "User ID:";
            // 
            // uxGetUserIDTextBox
            // 
            this.uxGetUserIDTextBox.Enabled = false;
            this.uxGetUserIDTextBox.Location = new System.Drawing.Point(1017, 700);
            this.uxGetUserIDTextBox.Name = "uxGetUserIDTextBox";
            this.uxGetUserIDTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxGetUserIDTextBox.TabIndex = 20;
            // 
            // uxGetButton
            // 
            this.uxGetButton.Enabled = false;
            this.uxGetButton.Location = new System.Drawing.Point(1032, 580);
            this.uxGetButton.Name = "uxGetButton";
            this.uxGetButton.Size = new System.Drawing.Size(254, 85);
            this.uxGetButton.TabIndex = 19;
            this.uxGetButton.Text = "Get User";
            this.uxGetButton.UseVisualStyleBackColor = true;
            this.uxGetButton.Click += new System.EventHandler(this.uxGetButton_Click);
            // 
            // uxGetPhoneTextBox
            // 
            this.uxGetPhoneTextBox.Location = new System.Drawing.Point(1045, 505);
            this.uxGetPhoneTextBox.Name = "uxGetPhoneTextBox";
            this.uxGetPhoneTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxGetPhoneTextBox.TabIndex = 18;
            this.uxGetPhoneTextBox.TextChanged += new System.EventHandler(this.uxGetPhoneTextBox_TextChanged);
            // 
            // uxDeleteButton
            // 
            this.uxDeleteButton.Enabled = false;
            this.uxDeleteButton.Location = new System.Drawing.Point(1831, 805);
            this.uxDeleteButton.Name = "uxDeleteButton";
            this.uxDeleteButton.Size = new System.Drawing.Size(254, 85);
            this.uxDeleteButton.TabIndex = 28;
            this.uxDeleteButton.Text = "Delete User";
            this.uxDeleteButton.UseVisualStyleBackColor = true;
            this.uxDeleteButton.Click += new System.EventHandler(this.uxDeleteButton_Click);
            // 
            // uxDelUserLabel
            // 
            this.uxDelUserLabel.AutoSize = true;
            this.uxDelUserLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDelUserLabel.Location = new System.Drawing.Point(1589, 733);
            this.uxDelUserLabel.Name = "uxDelUserLabel";
            this.uxDelUserLabel.Size = new System.Drawing.Size(161, 54);
            this.uxDelUserLabel.TabIndex = 30;
            this.uxDelUserLabel.Text = "UserID :";
            // 
            // uxDelUserIDTextBox
            // 
            this.uxDelUserIDTextBox.Location = new System.Drawing.Point(1767, 730);
            this.uxDelUserIDTextBox.Name = "uxDelUserIDTextBox";
            this.uxDelUserIDTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxDelUserIDTextBox.TabIndex = 29;
            this.uxDelUserIDTextBox.TextChanged += new System.EventHandler(this.uxDelUserIDTextBox_TextChanged);
            // 
            // uxUpPhoneLabel
            // 
            this.uxUpPhoneLabel.AutoSize = true;
            this.uxUpPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpPhoneLabel.Location = new System.Drawing.Point(753, 149);
            this.uxUpPhoneLabel.Name = "uxUpPhoneLabel";
            this.uxUpPhoneLabel.Size = new System.Drawing.Size(301, 54);
            this.uxUpPhoneLabel.TabIndex = 31;
            this.uxUpPhoneLabel.Text = "Phone Number:";
            // 
            // uxUpdatePhonenumberTextBox
            // 
            this.uxUpdatePhonenumberTextBox.Location = new System.Drawing.Point(1045, 149);
            this.uxUpdatePhonenumberTextBox.Name = "uxUpdatePhonenumberTextBox";
            this.uxUpdatePhonenumberTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxUpdatePhonenumberTextBox.TabIndex = 32;
            this.uxUpdatePhonenumberTextBox.TextChanged += new System.EventHandler(this.uxUpdatePhonenumberTextBox_TextChanged);
            // 
            // uxUpdateUserButton
            // 
            this.uxUpdateUserButton.Enabled = false;
            this.uxUpdateUserButton.Location = new System.Drawing.Point(854, 272);
            this.uxUpdateUserButton.Name = "uxUpdateUserButton";
            this.uxUpdateUserButton.Size = new System.Drawing.Size(596, 85);
            this.uxUpdateUserButton.TabIndex = 33;
            this.uxUpdateUserButton.Text = "Update User\'s Phone number";
            this.uxUpdateUserButton.UseVisualStyleBackColor = true;
            this.uxUpdateUserButton.Click += new System.EventHandler(this.uxUpdateUserButton_Click);
            // 
            // uxRetriveUsersGridView
            // 
            this.uxRetriveUsersGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxRetriveUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetriveUsersGridView.Location = new System.Drawing.Point(1610, 149);
            this.uxRetriveUsersGridView.Name = "uxRetriveUsersGridView";
            this.uxRetriveUsersGridView.RowHeadersWidth = 60;
            this.uxRetriveUsersGridView.RowTemplate.Height = 49;
            this.uxRetriveUsersGridView.Size = new System.Drawing.Size(685, 422);
            this.uxRetriveUsersGridView.TabIndex = 34;
            // 
            // uxRetriveButton
            // 
            this.uxRetriveButton.Location = new System.Drawing.Point(1782, 30);
            this.uxRetriveButton.Name = "uxRetriveButton";
            this.uxRetriveButton.Size = new System.Drawing.Size(344, 102);
            this.uxRetriveButton.TabIndex = 35;
            this.uxRetriveButton.Text = "Retrieve All Users";
            this.uxRetriveButton.UseVisualStyleBackColor = true;
            this.uxRetriveButton.Click += new System.EventHandler(this.uxRetriveButton_Click);
            // 
            // uxUpUserIDLabel
            // 
            this.uxUpUserIDLabel.AutoSize = true;
            this.uxUpUserIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpUserIDLabel.Location = new System.Drawing.Point(868, 95);
            this.uxUpUserIDLabel.Name = "uxUpUserIDLabel";
            this.uxUpUserIDLabel.Size = new System.Drawing.Size(161, 54);
            this.uxUpUserIDLabel.TabIndex = 37;
            this.uxUpUserIDLabel.Text = "UserID :";
            // 
            // uxUpdateUserIDTextBox
            // 
            this.uxUpdateUserIDTextBox.Location = new System.Drawing.Point(1045, 88);
            this.uxUpdateUserIDTextBox.Name = "uxUpdateUserIDTextBox";
            this.uxUpdateUserIDTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxUpdateUserIDTextBox.TabIndex = 36;
            this.uxUpdateUserIDTextBox.TextChanged += new System.EventHandler(this.uxUpdateUserIDTextBox_TextChanged);
            // 
            // uxLine3
            // 
            this.uxLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine3.Location = new System.Drawing.Point(1513, 30);
            this.uxLine3.Name = "uxLine3";
            this.uxLine3.Size = new System.Drawing.Size(2, 916);
            this.uxLine3.TabIndex = 89;
            this.uxLine3.Text = "                             ";
            // 
            // uxLine2
            // 
            this.uxLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine2.Location = new System.Drawing.Point(745, 30);
            this.uxLine2.Name = "uxLine2";
            this.uxLine2.Size = new System.Drawing.Size(2, 916);
            this.uxLine2.TabIndex = 90;
            this.uxLine2.Text = "                             ";
            // 
            // uxLine4
            // 
            this.uxLine4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine4.Location = new System.Drawing.Point(780, 420);
            this.uxLine4.Name = "uxLine4";
            this.uxLine4.Size = new System.Drawing.Size(698, 2);
            this.uxLine4.TabIndex = 91;
            this.uxLine4.Text = "                             ";
            // 
            // uxLine1
            // 
            this.uxLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine1.Location = new System.Drawing.Point(41, 420);
            this.uxLine1.Name = "uxLine1";
            this.uxLine1.Size = new System.Drawing.Size(673, 2);
            this.uxLine1.TabIndex = 92;
            this.uxLine1.Text = "                             ";
            // 
            // uxLine5
            // 
            this.uxLine5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine5.Location = new System.Drawing.Point(1553, 663);
            this.uxLine5.Name = "uxLine5";
            this.uxLine5.Size = new System.Drawing.Size(804, 2);
            this.uxLine5.TabIndex = 93;
            this.uxLine5.Text = " ";
            // 
            // uxAddPhoneTextBox
            // 
            this.uxAddPhoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uxAddPhoneTextBox.Location = new System.Drawing.Point(295, 181);
            this.uxAddPhoneTextBox.Name = "uxAddPhoneTextBox";
            this.uxAddPhoneTextBox.Size = new System.Drawing.Size(433, 61);
            this.uxAddPhoneTextBox.TabIndex = 5;
            this.uxAddPhoneTextBox.TextChanged += new System.EventHandler(this.uxAddPhoneTextBox_TextChanged);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2400, 979);
            this.Controls.Add(this.uxGetPhoneTextBox);
            this.Controls.Add(this.uxFetchPhoneTextBox);
            this.Controls.Add(this.uxAddPhoneTextBox);
            this.Controls.Add(this.uxLine5);
            this.Controls.Add(this.uxLine1);
            this.Controls.Add(this.uxLine4);
            this.Controls.Add(this.uxLine2);
            this.Controls.Add(this.uxLine3);
            this.Controls.Add(this.uxUpUserIDLabel);
            this.Controls.Add(this.uxUpdateUserIDTextBox);
            this.Controls.Add(this.uxRetriveButton);
            this.Controls.Add(this.uxRetriveUsersGridView);
            this.Controls.Add(this.uxUpdateUserButton);
            this.Controls.Add(this.uxUpdatePhonenumberTextBox);
            this.Controls.Add(this.uxUpPhoneLabel);
            this.Controls.Add(this.uxDelUserLabel);
            this.Controls.Add(this.uxDelUserIDTextBox);
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.uxGetPhoneLabel);
            this.Controls.Add(this.uxGetLNameLabel);
            this.Controls.Add(this.uxGetLNameTextBox);
            this.Controls.Add(this.uxGetFNameTextBox);
            this.Controls.Add(this.uxGetFNameLabel);
            this.Controls.Add(this.uxGetUserIDLabel);
            this.Controls.Add(this.uxGetUserIDTextBox);
            this.Controls.Add(this.uxGetButton);
            this.Controls.Add(this.uxFetchUserIDLabel);
            this.Controls.Add(this.uxFetchPhoneLabel);
            this.Controls.Add(this.uxFetchLNameTextBox);
            this.Controls.Add(this.uxFetchLNameLabel);
            this.Controls.Add(this.uxFetchFNameLabel);
            this.Controls.Add(this.uxFetchFNameTextBox);
            this.Controls.Add(this.uxFetchButton);
            this.Controls.Add(this.uxFetchUserIDTextBox);
            this.Controls.Add(this.uxAddPhoneLabel);
            this.Controls.Add(this.uxAddLastNameTextBox);
            this.Controls.Add(this.uxAddLastNameLabel);
            this.Controls.Add(this.uxCreateUserButton);
            this.Controls.Add(this.uxAddFirstNameLabel);
            this.Controls.Add(this.uxAddFirstNameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "User Controls";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveUsersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxAddFirstNameTextBox;
        private System.Windows.Forms.Label uxAddFirstNameLabel;
        private System.Windows.Forms.Button uxCreateUserButton;
        private System.Windows.Forms.Label uxAddLastNameLabel;
        private System.Windows.Forms.TextBox uxAddLastNameTextBox;
        private System.Windows.Forms.Label uxAddPhoneLabel;
        private System.Windows.Forms.TextBox uxFetchUserIDTextBox;
        private System.Windows.Forms.Button uxFetchButton;
        private System.Windows.Forms.Label uxFetchPhoneLabel;
        private System.Windows.Forms.TextBox uxFetchPhoneTextBox;
        private System.Windows.Forms.TextBox uxFetchLNameTextBox;
        private System.Windows.Forms.Label uxFetchLNameLabel;
        private System.Windows.Forms.Label uxFetchFNameLabel;
        private System.Windows.Forms.TextBox uxFetchFNameTextBox;
        private System.Windows.Forms.Label uxFetchUserIDLabel;
        private System.Windows.Forms.Label uxGetPhoneLabel;
        private System.Windows.Forms.Label uxGetLNameLabel;
        private System.Windows.Forms.TextBox uxGetLNameTextBox;
        private System.Windows.Forms.TextBox uxGetFNameTextBox;
        private System.Windows.Forms.Label uxGetFNameLabel;
        private System.Windows.Forms.Label uxGetUserIDLabel;
        private System.Windows.Forms.TextBox uxGetUserIDTextBox;
        private System.Windows.Forms.Button uxGetButton;
        private System.Windows.Forms.TextBox uxGetPhoneTextBox;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.Label uxDelUserLabel;
        private System.Windows.Forms.TextBox uxDelUserIDTextBox;
        private System.Windows.Forms.Label uxUpPhoneLabel;
        private System.Windows.Forms.TextBox uxUpdatePhonenumberTextBox;
        private System.Windows.Forms.Button uxUpdateUserButton;
        private System.Windows.Forms.DataGridView uxRetriveUsersGridView;
        private System.Windows.Forms.Button uxRetriveButton;
        private System.Windows.Forms.Label uxUpUserIDLabel;
        private System.Windows.Forms.TextBox uxUpdateUserIDTextBox;
        private System.Windows.Forms.Label uxUp;
        private System.Windows.Forms.Label uxLine3;
        private System.Windows.Forms.Label uxLine2;
        private System.Windows.Forms.Label uxLine4;
        private System.Windows.Forms.Label uxLine1;
        private System.Windows.Forms.Label uxLine5;
        private System.Windows.Forms.TextBox uxAddPhoneTextBox;
    }
}