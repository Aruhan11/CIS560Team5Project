
namespace LibraryApplication
{
    partial class CheckOutAsset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutAsset));
            this.uxAddAssetIDLabel = new System.Windows.Forms.Label();
            this.uxCreateAssetIDTextBox = new System.Windows.Forms.TextBox();
            this.uxAddUserIDLabel = new System.Windows.Forms.Label();
            this.uxAddLibIDLabel = new System.Windows.Forms.Label();
            this.uxCreateUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxCreateLibrarianIDTextBox = new System.Windows.Forms.TextBox();
            this.uxCreateCheckOutAssetButton = new System.Windows.Forms.Button();
            this.uxUpdateButton = new System.Windows.Forms.Button();
            this.uxUpdateTextBox = new System.Windows.Forms.TextBox();
            this.uxCOAIDLabel = new System.Windows.Forms.Label();
            this.uxFetchUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchAssetIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchUserIDLabel = new System.Windows.Forms.Label();
            this.uxFetchAssetIDLabel = new System.Windows.Forms.Label();
            this.uxFetchCheckOutAssetIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchCOAIDLabel = new System.Windows.Forms.Label();
            this.uxFetchReturnDateTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchCheckDateTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchRBDLabel = new System.Windows.Forms.Label();
            this.uxFetchCODLabel = new System.Windows.Forms.Label();
            this.uxFetchLibrarianIDTextBox = new System.Windows.Forms.TextBox();
            this.uxFetchLibIDLabel = new System.Windows.Forms.Label();
            this.uxFetchIsReturnTextBox = new System.Windows.Forms.TextBox();
            this.uxIsReturnedLabel = new System.Windows.Forms.Label();
            this.uxFetchCheckOutAssetButton = new System.Windows.Forms.Button();
            this.uxRetriveAllCheckOutAssetsButton = new System.Windows.Forms.Button();
            this.uxGetHistoryOfUserButton = new System.Windows.Forms.Button();
            this.uxRetriveGridView = new System.Windows.Forms.DataGridView();
            this.uxCheckOutHistoryGridView = new System.Windows.Forms.DataGridView();
            this.uxGetHistoryUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxGetUserIDLabel = new System.Windows.Forms.Label();
            this.uxLine3 = new System.Windows.Forms.Label();
            this.uxLine4 = new System.Windows.Forms.Label();
            this.uxLine2 = new System.Windows.Forms.Label();
            this.uxLine1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxCheckOutHistoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAddAssetIDLabel
            // 
            this.uxAddAssetIDLabel.AutoSize = true;
            this.uxAddAssetIDLabel.Location = new System.Drawing.Point(51, 25);
            this.uxAddAssetIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxAddAssetIDLabel.Name = "uxAddAssetIDLabel";
            this.uxAddAssetIDLabel.Size = new System.Drawing.Size(52, 15);
            this.uxAddAssetIDLabel.TabIndex = 0;
            this.uxAddAssetIDLabel.Text = "AssetID: ";
            // 
            // uxCreateAssetIDTextBox
            // 
            this.uxCreateAssetIDTextBox.Location = new System.Drawing.Point(118, 22);
            this.uxCreateAssetIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxCreateAssetIDTextBox.Name = "uxCreateAssetIDTextBox";
            this.uxCreateAssetIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxCreateAssetIDTextBox.TabIndex = 1;
            this.uxCreateAssetIDTextBox.TextChanged += new System.EventHandler(this.CreateCheckoutAsset_EventListener);
            // 
            // uxAddUserIDLabel
            // 
            this.uxAddUserIDLabel.AutoSize = true;
            this.uxAddUserIDLabel.Location = new System.Drawing.Point(56, 56);
            this.uxAddUserIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxAddUserIDLabel.Name = "uxAddUserIDLabel";
            this.uxAddUserIDLabel.Size = new System.Drawing.Size(47, 15);
            this.uxAddUserIDLabel.TabIndex = 2;
            this.uxAddUserIDLabel.Text = "UserID: ";
            // 
            // uxAddLibIDLabel
            // 
            this.uxAddLibIDLabel.AutoSize = true;
            this.uxAddLibIDLabel.Location = new System.Drawing.Point(33, 90);
            this.uxAddLibIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxAddLibIDLabel.Name = "uxAddLibIDLabel";
            this.uxAddLibIDLabel.Size = new System.Drawing.Size(70, 15);
            this.uxAddLibIDLabel.TabIndex = 3;
            this.uxAddLibIDLabel.Text = "LibrarianID: ";
            // 
            // uxCreateUserIDTextBox
            // 
            this.uxCreateUserIDTextBox.Location = new System.Drawing.Point(118, 56);
            this.uxCreateUserIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxCreateUserIDTextBox.Name = "uxCreateUserIDTextBox";
            this.uxCreateUserIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxCreateUserIDTextBox.TabIndex = 4;
            this.uxCreateUserIDTextBox.TextChanged += new System.EventHandler(this.CreateCheckoutAsset_EventListener);
            // 
            // uxCreateLibrarianIDTextBox
            // 
            this.uxCreateLibrarianIDTextBox.Location = new System.Drawing.Point(118, 87);
            this.uxCreateLibrarianIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxCreateLibrarianIDTextBox.Name = "uxCreateLibrarianIDTextBox";
            this.uxCreateLibrarianIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxCreateLibrarianIDTextBox.TabIndex = 5;
            this.uxCreateLibrarianIDTextBox.TextChanged += new System.EventHandler(this.CreateCheckoutAsset_EventListener);
            // 
            // uxCreateCheckOutAssetButton
            // 
            this.uxCreateCheckOutAssetButton.Enabled = false;
            this.uxCreateCheckOutAssetButton.Location = new System.Drawing.Point(129, 113);
            this.uxCreateCheckOutAssetButton.Margin = new System.Windows.Forms.Padding(1);
            this.uxCreateCheckOutAssetButton.Name = "uxCreateCheckOutAssetButton";
            this.uxCreateCheckOutAssetButton.Size = new System.Drawing.Size(164, 35);
            this.uxCreateCheckOutAssetButton.TabIndex = 6;
            this.uxCreateCheckOutAssetButton.Text = "Create Check Out Asset";
            this.uxCreateCheckOutAssetButton.UseVisualStyleBackColor = true;
            this.uxCreateCheckOutAssetButton.Click += new System.EventHandler(this.uxCreateCheckOutAssetButton_Click);
            // 
            // uxUpdateButton
            // 
            this.uxUpdateButton.Enabled = false;
            this.uxUpdateButton.Location = new System.Drawing.Point(129, 227);
            this.uxUpdateButton.Margin = new System.Windows.Forms.Padding(1);
            this.uxUpdateButton.Name = "uxUpdateButton";
            this.uxUpdateButton.Size = new System.Drawing.Size(164, 29);
            this.uxUpdateButton.TabIndex = 9;
            this.uxUpdateButton.Text = "Update Returned";
            this.uxUpdateButton.UseVisualStyleBackColor = true;
            this.uxUpdateButton.Click += new System.EventHandler(this.uxUpdateButton_Click);
            // 
            // uxUpdateTextBox
            // 
            this.uxUpdateTextBox.Location = new System.Drawing.Point(129, 197);
            this.uxUpdateTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxUpdateTextBox.Name = "uxUpdateTextBox";
            this.uxUpdateTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxUpdateTextBox.TabIndex = 8;
            this.uxUpdateTextBox.TextChanged += new System.EventHandler(this.uxUpdateTextBox_TextChanged);
            // 
            // uxCOAIDLabel
            // 
            this.uxCOAIDLabel.AutoSize = true;
            this.uxCOAIDLabel.Location = new System.Drawing.Point(16, 197);
            this.uxCOAIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxCOAIDLabel.Name = "uxCOAIDLabel";
            this.uxCOAIDLabel.Size = new System.Drawing.Size(105, 15);
            this.uxCOAIDLabel.TabIndex = 7;
            this.uxCOAIDLabel.Text = "CheckOutAssetID: ";
            // 
            // uxFetchUserIDTextBox
            // 
            this.uxFetchUserIDTextBox.Enabled = false;
            this.uxFetchUserIDTextBox.Location = new System.Drawing.Point(597, 103);
            this.uxFetchUserIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchUserIDTextBox.Name = "uxFetchUserIDTextBox";
            this.uxFetchUserIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxFetchUserIDTextBox.TabIndex = 15;
            // 
            // uxFetchAssetIDTextBox
            // 
            this.uxFetchAssetIDTextBox.Enabled = false;
            this.uxFetchAssetIDTextBox.Location = new System.Drawing.Point(597, 71);
            this.uxFetchAssetIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchAssetIDTextBox.Name = "uxFetchAssetIDTextBox";
            this.uxFetchAssetIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxFetchAssetIDTextBox.TabIndex = 14;
            // 
            // uxFetchUserIDLabel
            // 
            this.uxFetchUserIDLabel.AutoSize = true;
            this.uxFetchUserIDLabel.Location = new System.Drawing.Point(542, 104);
            this.uxFetchUserIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxFetchUserIDLabel.Name = "uxFetchUserIDLabel";
            this.uxFetchUserIDLabel.Size = new System.Drawing.Size(41, 15);
            this.uxFetchUserIDLabel.TabIndex = 13;
            this.uxFetchUserIDLabel.Text = "UserID";
            // 
            // uxFetchAssetIDLabel
            // 
            this.uxFetchAssetIDLabel.AutoSize = true;
            this.uxFetchAssetIDLabel.Location = new System.Drawing.Point(538, 71);
            this.uxFetchAssetIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxFetchAssetIDLabel.Name = "uxFetchAssetIDLabel";
            this.uxFetchAssetIDLabel.Size = new System.Drawing.Size(46, 15);
            this.uxFetchAssetIDLabel.TabIndex = 12;
            this.uxFetchAssetIDLabel.Text = "AssetID";
            // 
            // uxFetchCheckOutAssetIDTextBox
            // 
            this.uxFetchCheckOutAssetIDTextBox.Location = new System.Drawing.Point(597, 16);
            this.uxFetchCheckOutAssetIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchCheckOutAssetIDTextBox.Name = "uxFetchCheckOutAssetIDTextBox";
            this.uxFetchCheckOutAssetIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxFetchCheckOutAssetIDTextBox.TabIndex = 11;
            this.uxFetchCheckOutAssetIDTextBox.TextChanged += new System.EventHandler(this.uxFetchCheckOutAssetIDTextBox_TextChanged);
            // 
            // uxFetchCOAIDLabel
            // 
            this.uxFetchCOAIDLabel.AutoSize = true;
            this.uxFetchCOAIDLabel.Location = new System.Drawing.Point(485, 19);
            this.uxFetchCOAIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxFetchCOAIDLabel.Name = "uxFetchCOAIDLabel";
            this.uxFetchCOAIDLabel.Size = new System.Drawing.Size(102, 15);
            this.uxFetchCOAIDLabel.TabIndex = 10;
            this.uxFetchCOAIDLabel.Text = "CheckOutAssetID:";
            // 
            // uxFetchReturnDateTextBox
            // 
            this.uxFetchReturnDateTextBox.Enabled = false;
            this.uxFetchReturnDateTextBox.Location = new System.Drawing.Point(597, 203);
            this.uxFetchReturnDateTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchReturnDateTextBox.Name = "uxFetchReturnDateTextBox";
            this.uxFetchReturnDateTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxFetchReturnDateTextBox.TabIndex = 21;
            // 
            // uxFetchCheckDateTextBox
            // 
            this.uxFetchCheckDateTextBox.Enabled = false;
            this.uxFetchCheckDateTextBox.Location = new System.Drawing.Point(597, 173);
            this.uxFetchCheckDateTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchCheckDateTextBox.Name = "uxFetchCheckDateTextBox";
            this.uxFetchCheckDateTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxFetchCheckDateTextBox.TabIndex = 20;
            // 
            // uxFetchRBDLabel
            // 
            this.uxFetchRBDLabel.AutoSize = true;
            this.uxFetchRBDLabel.Location = new System.Drawing.Point(500, 203);
            this.uxFetchRBDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxFetchRBDLabel.Name = "uxFetchRBDLabel";
            this.uxFetchRBDLabel.Size = new System.Drawing.Size(88, 15);
            this.uxFetchRBDLabel.TabIndex = 19;
            this.uxFetchRBDLabel.Text = "Return By Date:";
            // 
            // uxFetchCODLabel
            // 
            this.uxFetchCODLabel.AutoSize = true;
            this.uxFetchCODLabel.Location = new System.Drawing.Point(498, 173);
            this.uxFetchCODLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxFetchCODLabel.Name = "uxFetchCODLabel";
            this.uxFetchCODLabel.Size = new System.Drawing.Size(93, 15);
            this.uxFetchCODLabel.TabIndex = 18;
            this.uxFetchCODLabel.Text = "Check Out Date:";
            // 
            // uxFetchLibrarianIDTextBox
            // 
            this.uxFetchLibrarianIDTextBox.Enabled = false;
            this.uxFetchLibrarianIDTextBox.Location = new System.Drawing.Point(597, 140);
            this.uxFetchLibrarianIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchLibrarianIDTextBox.Name = "uxFetchLibrarianIDTextBox";
            this.uxFetchLibrarianIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxFetchLibrarianIDTextBox.TabIndex = 17;
            // 
            // uxFetchLibIDLabel
            // 
            this.uxFetchLibIDLabel.AutoSize = true;
            this.uxFetchLibIDLabel.Location = new System.Drawing.Point(526, 142);
            this.uxFetchLibIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxFetchLibIDLabel.Name = "uxFetchLibIDLabel";
            this.uxFetchLibIDLabel.Size = new System.Drawing.Size(67, 15);
            this.uxFetchLibIDLabel.TabIndex = 16;
            this.uxFetchLibIDLabel.Text = "LibrarianID:";
            // 
            // uxFetchIsReturnTextBox
            // 
            this.uxFetchIsReturnTextBox.Enabled = false;
            this.uxFetchIsReturnTextBox.Location = new System.Drawing.Point(597, 235);
            this.uxFetchIsReturnTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchIsReturnTextBox.Name = "uxFetchIsReturnTextBox";
            this.uxFetchIsReturnTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxFetchIsReturnTextBox.TabIndex = 23;
            // 
            // uxIsReturnedLabel
            // 
            this.uxIsReturnedLabel.AutoSize = true;
            this.uxIsReturnedLabel.Location = new System.Drawing.Point(516, 238);
            this.uxIsReturnedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxIsReturnedLabel.Name = "uxIsReturnedLabel";
            this.uxIsReturnedLabel.Size = new System.Drawing.Size(69, 15);
            this.uxIsReturnedLabel.TabIndex = 22;
            this.uxIsReturnedLabel.Text = "Is Returned:";
            // 
            // uxFetchCheckOutAssetButton
            // 
            this.uxFetchCheckOutAssetButton.Enabled = false;
            this.uxFetchCheckOutAssetButton.Location = new System.Drawing.Point(653, 47);
            this.uxFetchCheckOutAssetButton.Margin = new System.Windows.Forms.Padding(1);
            this.uxFetchCheckOutAssetButton.Name = "uxFetchCheckOutAssetButton";
            this.uxFetchCheckOutAssetButton.Size = new System.Drawing.Size(77, 21);
            this.uxFetchCheckOutAssetButton.TabIndex = 24;
            this.uxFetchCheckOutAssetButton.Text = "Fetch Check Out Asset";
            this.uxFetchCheckOutAssetButton.UseVisualStyleBackColor = true;
            this.uxFetchCheckOutAssetButton.Click += new System.EventHandler(this.uxFetchCheckOutAssetButton_Click);
            // 
            // uxRetriveAllCheckOutAssetsButton
            // 
            this.uxRetriveAllCheckOutAssetsButton.Location = new System.Drawing.Point(110, 322);
            this.uxRetriveAllCheckOutAssetsButton.Margin = new System.Windows.Forms.Padding(1);
            this.uxRetriveAllCheckOutAssetsButton.Name = "uxRetriveAllCheckOutAssetsButton";
            this.uxRetriveAllCheckOutAssetsButton.Size = new System.Drawing.Size(192, 28);
            this.uxRetriveAllCheckOutAssetsButton.TabIndex = 25;
            this.uxRetriveAllCheckOutAssetsButton.Text = "Retrieve All Checked Out Assets";
            this.uxRetriveAllCheckOutAssetsButton.UseVisualStyleBackColor = true;
            this.uxRetriveAllCheckOutAssetsButton.Click += new System.EventHandler(this.uxRetriveAllCheckOutAssetsButton_Click);
            // 
            // uxGetHistoryOfUserButton
            // 
            this.uxGetHistoryOfUserButton.Enabled = false;
            this.uxGetHistoryOfUserButton.Location = new System.Drawing.Point(597, 329);
            this.uxGetHistoryOfUserButton.Margin = new System.Windows.Forms.Padding(1);
            this.uxGetHistoryOfUserButton.Name = "uxGetHistoryOfUserButton";
            this.uxGetHistoryOfUserButton.Size = new System.Drawing.Size(190, 21);
            this.uxGetHistoryOfUserButton.TabIndex = 26;
            this.uxGetHistoryOfUserButton.Text = "Get Check Out History of User";
            this.uxGetHistoryOfUserButton.UseVisualStyleBackColor = true;
            this.uxGetHistoryOfUserButton.Click += new System.EventHandler(this.uxGetHistoryOfUserButton_Click);
            // 
            // uxRetriveGridView
            // 
            this.uxRetriveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetriveGridView.Location = new System.Drawing.Point(16, 359);
            this.uxRetriveGridView.Margin = new System.Windows.Forms.Padding(1);
            this.uxRetriveGridView.Name = "uxRetriveGridView";
            this.uxRetriveGridView.RowHeadersWidth = 102;
            this.uxRetriveGridView.RowTemplate.Height = 49;
            this.uxRetriveGridView.Size = new System.Drawing.Size(387, 298);
            this.uxRetriveGridView.TabIndex = 27;
            // 
            // uxCheckOutHistoryGridView
            // 
            this.uxCheckOutHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxCheckOutHistoryGridView.Location = new System.Drawing.Point(475, 359);
            this.uxCheckOutHistoryGridView.Margin = new System.Windows.Forms.Padding(1);
            this.uxCheckOutHistoryGridView.Name = "uxCheckOutHistoryGridView";
            this.uxCheckOutHistoryGridView.RowHeadersWidth = 102;
            this.uxCheckOutHistoryGridView.RowTemplate.Height = 49;
            this.uxCheckOutHistoryGridView.Size = new System.Drawing.Size(408, 298);
            this.uxCheckOutHistoryGridView.TabIndex = 28;
            // 
            // uxGetHistoryUserIDTextBox
            // 
            this.uxGetHistoryUserIDTextBox.Location = new System.Drawing.Point(597, 298);
            this.uxGetHistoryUserIDTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.uxGetHistoryUserIDTextBox.Name = "uxGetHistoryUserIDTextBox";
            this.uxGetHistoryUserIDTextBox.Size = new System.Drawing.Size(192, 23);
            this.uxGetHistoryUserIDTextBox.TabIndex = 29;
            this.uxGetHistoryUserIDTextBox.TextChanged += new System.EventHandler(this.uxGetHistoryUserIDTextBox_TextChanged);
            // 
            // uxGetUserIDLabel
            // 
            this.uxGetUserIDLabel.AutoSize = true;
            this.uxGetUserIDLabel.Location = new System.Drawing.Point(532, 301);
            this.uxGetUserIDLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.uxGetUserIDLabel.Name = "uxGetUserIDLabel";
            this.uxGetUserIDLabel.Size = new System.Drawing.Size(47, 15);
            this.uxGetUserIDLabel.TabIndex = 30;
            this.uxGetUserIDLabel.Text = "UserID: ";
            // 
            // uxLine3
            // 
            this.uxLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine3.Location = new System.Drawing.Point(437, 16);
            this.uxLine3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine3.Name = "uxLine3";
            this.uxLine3.Size = new System.Drawing.Size(1, 673);
            this.uxLine3.TabIndex = 88;
            this.uxLine3.Text = "                             ";
            // 
            // uxLine4
            // 
            this.uxLine4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine4.Location = new System.Drawing.Point(485, 277);
            this.uxLine4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine4.Name = "uxLine4";
            this.uxLine4.Size = new System.Drawing.Size(379, 1);
            this.uxLine4.TabIndex = 89;
            this.uxLine4.Text = "                             ";
            // 
            // uxLine2
            // 
            this.uxLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine2.Location = new System.Drawing.Point(24, 292);
            this.uxLine2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine2.Name = "uxLine2";
            this.uxLine2.Size = new System.Drawing.Size(379, 1);
            this.uxLine2.TabIndex = 91;
            this.uxLine2.Text = "                             ";
            // 
            // uxLine1
            // 
            this.uxLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine1.Location = new System.Drawing.Point(24, 172);
            this.uxLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine1.Name = "uxLine1";
            this.uxLine1.Size = new System.Drawing.Size(379, 1);
            this.uxLine1.TabIndex = 93;
            this.uxLine1.Text = "                             ";
            // 
            // CheckOutAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 696);
            this.Controls.Add(this.uxLine1);
            this.Controls.Add(this.uxLine2);
            this.Controls.Add(this.uxLine4);
            this.Controls.Add(this.uxLine3);
            this.Controls.Add(this.uxGetUserIDLabel);
            this.Controls.Add(this.uxGetHistoryUserIDTextBox);
            this.Controls.Add(this.uxCheckOutHistoryGridView);
            this.Controls.Add(this.uxRetriveGridView);
            this.Controls.Add(this.uxGetHistoryOfUserButton);
            this.Controls.Add(this.uxRetriveAllCheckOutAssetsButton);
            this.Controls.Add(this.uxFetchCheckOutAssetButton);
            this.Controls.Add(this.uxFetchIsReturnTextBox);
            this.Controls.Add(this.uxIsReturnedLabel);
            this.Controls.Add(this.uxFetchReturnDateTextBox);
            this.Controls.Add(this.uxFetchCheckDateTextBox);
            this.Controls.Add(this.uxFetchRBDLabel);
            this.Controls.Add(this.uxFetchCODLabel);
            this.Controls.Add(this.uxFetchLibrarianIDTextBox);
            this.Controls.Add(this.uxFetchLibIDLabel);
            this.Controls.Add(this.uxFetchUserIDTextBox);
            this.Controls.Add(this.uxFetchAssetIDTextBox);
            this.Controls.Add(this.uxFetchUserIDLabel);
            this.Controls.Add(this.uxFetchAssetIDLabel);
            this.Controls.Add(this.uxFetchCheckOutAssetIDTextBox);
            this.Controls.Add(this.uxFetchCOAIDLabel);
            this.Controls.Add(this.uxUpdateButton);
            this.Controls.Add(this.uxUpdateTextBox);
            this.Controls.Add(this.uxCOAIDLabel);
            this.Controls.Add(this.uxCreateCheckOutAssetButton);
            this.Controls.Add(this.uxCreateLibrarianIDTextBox);
            this.Controls.Add(this.uxCreateUserIDTextBox);
            this.Controls.Add(this.uxAddLibIDLabel);
            this.Controls.Add(this.uxAddUserIDLabel);
            this.Controls.Add(this.uxCreateAssetIDTextBox);
            this.Controls.Add(this.uxAddAssetIDLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CheckOutAsset";
            this.Text = "Check Out Asset Controls";
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxCheckOutHistoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxAddAssetIDLabel;
        private System.Windows.Forms.TextBox uxCreateAssetIDTextBox;
        private System.Windows.Forms.Label uxAddUserIDLabel;
        private System.Windows.Forms.Label uxAddLibIDLabel;
        private System.Windows.Forms.TextBox uxCreateUserIDTextBox;
        private System.Windows.Forms.TextBox uxCreateLibrarianIDTextBox;
        private System.Windows.Forms.Button uxCreateCheckOutAssetButton;
        private System.Windows.Forms.Button uxUpdateButton;
        private System.Windows.Forms.TextBox uxUpdateTextBox;
        private System.Windows.Forms.Label uxCOAIDLabel;
        private System.Windows.Forms.TextBox uxFetchUserIDTextBox;
        private System.Windows.Forms.TextBox uxFetchAssetIDTextBox;
        private System.Windows.Forms.Label uxFetchUserIDLabel;
        private System.Windows.Forms.Label uxFetchAssetIDLabel;
        private System.Windows.Forms.TextBox uxFetchCheckOutAssetIDTextBox;
        private System.Windows.Forms.Label uxFetchCOAIDLabel;
        private System.Windows.Forms.TextBox uxFetchReturnDateTextBox;
        private System.Windows.Forms.TextBox uxFetchCheckDateTextBox;
        private System.Windows.Forms.Label uxFetchRBDLabel;
        private System.Windows.Forms.Label uxFetchCODLabel;
        private System.Windows.Forms.TextBox uxFetchLibrarianIDTextBox;
        private System.Windows.Forms.Label uxFetchLibIDLabel;
        private System.Windows.Forms.TextBox uxFetchIsReturnTextBox;
        private System.Windows.Forms.Label uxIsReturnedLabel;
        private System.Windows.Forms.Button uxFetchCheckOutAssetButton;
        private System.Windows.Forms.Button uxRetriveAllCheckOutAssetsButton;
        private System.Windows.Forms.Button uxGetHistoryOfUserButton;
        private System.Windows.Forms.DataGridView uxRetriveGridView;
        private System.Windows.Forms.DataGridView uxCheckOutHistoryGridView;
        private System.Windows.Forms.TextBox uxGetHistoryUserIDTextBox;
        private System.Windows.Forms.Label uxGetUserIDLabel;
        private System.Windows.Forms.Label uxLine3;
        private System.Windows.Forms.Label uxLine4;
        private System.Windows.Forms.Label uxLine2;
        private System.Windows.Forms.Label uxLine1;
    }
}