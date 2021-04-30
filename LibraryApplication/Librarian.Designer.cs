
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
            this.uxUserID = new System.Windows.Forms.TextBox();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxFetchLibrarian = new System.Windows.Forms.Button();
            this.uxRetrieveAllLibrarians = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxLibrarianIDInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxRetrieveAllLibrariansDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "_______________________________";
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
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(43, 163);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(44, 15);
            this.labelUserId.TabIndex = 10;
            this.labelUserId.Text = "UserID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last Name:";
            // 
            // uxLibrarianIDInput
            // 
            this.uxLibrarianIDInput.Location = new System.Drawing.Point(94, 107);
            this.uxLibrarianIDInput.Name = "uxLibrarianIDInput";
            this.uxLibrarianIDInput.Size = new System.Drawing.Size(188, 23);
            this.uxLibrarianIDInput.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "First Name:";
            // 
            // uxRetrieveAllLibrariansDataGridView
            // 
            this.uxRetrieveAllLibrariansDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxRetrieveAllLibrariansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetrieveAllLibrariansDataGridView.Location = new System.Drawing.Point(353, 107);
            this.uxRetrieveAllLibrariansDataGridView.Name = "uxRetrieveAllLibrariansDataGridView";
            this.uxRetrieveAllLibrariansDataGridView.RowTemplate.Height = 25;
            this.uxRetrieveAllLibrariansDataGridView.Size = new System.Drawing.Size(346, 135);
            this.uxRetrieveAllLibrariansDataGridView.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "LibrarianID:";
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxRetrieveAllLibrariansDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxLibrarianIDInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxRetrieveAllLibrarians);
            this.Controls.Add(this.uxFetchLibrarian);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.uxUserID);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Librarian";
            this.Text = "Librarian";
            ((System.ComponentModel.ISupportInitialize)(this.uxRetrieveAllLibrariansDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxUserID;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.Button uxFetchLibrarian;
        private System.Windows.Forms.Button uxRetrieveAllLibrarians;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxLibrarianIDInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView uxRetrieveAllLibrariansDataGridView;
        private System.Windows.Forms.Label label1;
    }
}