
namespace LibraryApplication
{
    partial class Librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian));
            this.uxUserID = new System.Windows.Forms.TextBox();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxFetchLibrarian = new System.Windows.Forms.Button();
            this.uxRetrieveAllLibrarians = new System.Windows.Forms.Button();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxUserIDLabel = new System.Windows.Forms.Label();
            this.uxLNameLabel = new System.Windows.Forms.Label();
            this.uxLibrarianIDInput = new System.Windows.Forms.TextBox();
            this.uxFNameLabel = new System.Windows.Forms.Label();
            this.uxRetrieveAllLibrariansDataGridView = new System.Windows.Forms.DataGridView();
            this.uxLibIDLabel = new System.Windows.Forms.Label();
            this.uxLine3 = new System.Windows.Forms.Label();
            this.uxLine1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxRetrieveAllLibrariansDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxUserID
            // 
            this.uxUserID.BackColor = System.Drawing.SystemColors.Menu;
            this.uxUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxUserID.Enabled = false;
            this.uxUserID.Location = new System.Drawing.Point(94, 161);
            this.uxUserID.Name = "uxUserID";
            this.uxUserID.Size = new System.Drawing.Size(188, 23);
            this.uxUserID.TabIndex = 1;
            // 
            // uxFirstName
            // 
            this.uxFirstName.BackColor = System.Drawing.SystemColors.Menu;
            this.uxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxFirstName.Enabled = false;
            this.uxFirstName.Location = new System.Drawing.Point(94, 190);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(188, 23);
            this.uxFirstName.TabIndex = 3;
            // 
            // uxFetchLibrarian
            // 
            this.uxFetchLibrarian.Enabled = false;
            this.uxFetchLibrarian.Location = new System.Drawing.Point(94, 32);
            this.uxFetchLibrarian.Name = "uxFetchLibrarian";
            this.uxFetchLibrarian.Size = new System.Drawing.Size(188, 64);
            this.uxFetchLibrarian.TabIndex = 4;
            this.uxFetchLibrarian.Text = "Fetch Librarian";
            this.uxFetchLibrarian.UseVisualStyleBackColor = true;
            this.uxFetchLibrarian.Click += new System.EventHandler(this.uxFetchLibrarian_Click);
            // 
            // uxRetrieveAllLibrarians
            // 
            this.uxRetrieveAllLibrarians.Location = new System.Drawing.Point(437, 32);
            this.uxRetrieveAllLibrarians.Name = "uxRetrieveAllLibrarians";
            this.uxRetrieveAllLibrarians.Size = new System.Drawing.Size(188, 64);
            this.uxRetrieveAllLibrarians.TabIndex = 5;
            this.uxRetrieveAllLibrarians.Text = "Retrieve All Librarians";
            this.uxRetrieveAllLibrarians.UseVisualStyleBackColor = true;
            this.uxRetrieveAllLibrarians.Click += new System.EventHandler(this.uxRetrieveAllLibrarians_Click);
            // 
            // uxLastName
            // 
            this.uxLastName.BackColor = System.Drawing.SystemColors.Menu;
            this.uxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uxLastName.Enabled = false;
            this.uxLastName.Location = new System.Drawing.Point(94, 219);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(188, 23);
            this.uxLastName.TabIndex = 9;
            // 
            // uxUserIDLabel
            // 
            this.uxUserIDLabel.AutoSize = true;
            this.uxUserIDLabel.Location = new System.Drawing.Point(43, 163);
            this.uxUserIDLabel.Name = "uxUserIDLabel";
            this.uxUserIDLabel.Size = new System.Drawing.Size(44, 15);
            this.uxUserIDLabel.TabIndex = 10;
            this.uxUserIDLabel.Text = "UserID:";
            // 
            // uxLNameLabel
            // 
            this.uxLNameLabel.AutoSize = true;
            this.uxLNameLabel.Location = new System.Drawing.Point(21, 221);
            this.uxLNameLabel.Name = "uxLNameLabel";
            this.uxLNameLabel.Size = new System.Drawing.Size(66, 15);
            this.uxLNameLabel.TabIndex = 12;
            this.uxLNameLabel.Text = "Last Name:";
            // 
            // uxLibrarianIDInput
            // 
            this.uxLibrarianIDInput.Location = new System.Drawing.Point(94, 107);
            this.uxLibrarianIDInput.Name = "uxLibrarianIDInput";
            this.uxLibrarianIDInput.Size = new System.Drawing.Size(188, 23);
            this.uxLibrarianIDInput.TabIndex = 13;
            this.uxLibrarianIDInput.TextChanged += new System.EventHandler(this.uxLibrarianIDInput_TextChanged);
            // 
            // uxFNameLabel
            // 
            this.uxFNameLabel.AutoSize = true;
            this.uxFNameLabel.Location = new System.Drawing.Point(21, 192);
            this.uxFNameLabel.Name = "uxFNameLabel";
            this.uxFNameLabel.Size = new System.Drawing.Size(67, 15);
            this.uxFNameLabel.TabIndex = 15;
            this.uxFNameLabel.Text = "First Name:";
            // 
            // uxRetrieveAllLibrariansDataGridView
            // 
            this.uxRetrieveAllLibrariansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxRetrieveAllLibrariansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetrieveAllLibrariansDataGridView.Location = new System.Drawing.Point(353, 107);
            this.uxRetrieveAllLibrariansDataGridView.Name = "uxRetrieveAllLibrariansDataGridView";
            this.uxRetrieveAllLibrariansDataGridView.RowHeadersWidth = 62;
            this.uxRetrieveAllLibrariansDataGridView.RowTemplate.Height = 25;
            this.uxRetrieveAllLibrariansDataGridView.Size = new System.Drawing.Size(346, 135);
            this.uxRetrieveAllLibrariansDataGridView.TabIndex = 16;
            // 
            // uxLibIDLabel
            // 
            this.uxLibIDLabel.AutoSize = true;
            this.uxLibIDLabel.Location = new System.Drawing.Point(21, 110);
            this.uxLibIDLabel.Name = "uxLibIDLabel";
            this.uxLibIDLabel.Size = new System.Drawing.Size(67, 15);
            this.uxLibIDLabel.TabIndex = 17;
            this.uxLibIDLabel.Text = "LibrarianID:";
            // 
            // uxLine3
            // 
            this.uxLine3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine3.Location = new System.Drawing.Point(318, 11);
            this.uxLine3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine3.Name = "uxLine3";
            this.uxLine3.Size = new System.Drawing.Size(1, 280);
            this.uxLine3.TabIndex = 88;
            this.uxLine3.Text = "                             ";
            // 
            // uxLine1
            // 
            this.uxLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxLine1.Location = new System.Drawing.Point(21, 143);
            this.uxLine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLine1.Name = "uxLine1";
            this.uxLine1.Size = new System.Drawing.Size(281, 1);
            this.uxLine1.TabIndex = 89;
            this.uxLine1.Text = "                             ";
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 302);
            this.Controls.Add(this.uxLine1);
            this.Controls.Add(this.uxLine3);
            this.Controls.Add(this.uxLibIDLabel);
            this.Controls.Add(this.uxRetrieveAllLibrariansDataGridView);
            this.Controls.Add(this.uxFNameLabel);
            this.Controls.Add(this.uxLibrarianIDInput);
            this.Controls.Add(this.uxLNameLabel);
            this.Controls.Add(this.uxUserIDLabel);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxRetrieveAllLibrarians);
            this.Controls.Add(this.uxFetchLibrarian);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.uxUserID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Librarian";
            this.Text = "Librarian Controls";
            ((System.ComponentModel.ISupportInitialize)(this.uxRetrieveAllLibrariansDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxUserID;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.Button uxFetchLibrarian;
        private System.Windows.Forms.Button uxRetrieveAllLibrarians;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.Label uxUserIDLabel;
        private System.Windows.Forms.Label uxLNameLabel;
        private System.Windows.Forms.TextBox uxLibrarianIDInput;
        private System.Windows.Forms.Label uxFNameLabel;
        private System.Windows.Forms.DataGridView uxRetrieveAllLibrariansDataGridView;
        private System.Windows.Forms.Label uxLibIDLabel;
        private System.Windows.Forms.Label uxLine3;
        private System.Windows.Forms.Label uxLine1;
    }
}