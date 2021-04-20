
namespace LibraryProject
{
    partial class AddAsset
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
            this.uxPhoneLabel = new System.Windows.Forms.Label();
            this.uxPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.uxAddLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddLastNameLabel = new System.Windows.Forms.Label();
            this.uxAddUser = new System.Windows.Forms.Button();
            this.uxAddFirstNameLabel = new System.Windows.Forms.Label();
            this.uxAddFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxPhoneLabel
            // 
            this.uxPhoneLabel.AutoSize = true;
            this.uxPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxPhoneLabel.Location = new System.Drawing.Point(70, 283);
            this.uxPhoneLabel.Name = "uxPhoneLabel";
            this.uxPhoneLabel.Size = new System.Drawing.Size(182, 32);
            this.uxPhoneLabel.TabIndex = 13;
            this.uxPhoneLabel.Text = "Phone Number:";
            // 
            // uxPhoneNumberTextBox
            // 
            this.uxPhoneNumberTextBox.Location = new System.Drawing.Point(270, 280);
            this.uxPhoneNumberTextBox.Name = "uxPhoneNumberTextBox";
            this.uxPhoneNumberTextBox.Size = new System.Drawing.Size(430, 31);
            this.uxPhoneNumberTextBox.TabIndex = 12;
            // 
            // uxAddLastNameTextBox
            // 
            this.uxAddLastNameTextBox.Location = new System.Drawing.Point(270, 163);
            this.uxAddLastNameTextBox.Name = "uxAddLastNameTextBox";
            this.uxAddLastNameTextBox.Size = new System.Drawing.Size(433, 31);
            this.uxAddLastNameTextBox.TabIndex = 11;
            // 
            // uxAddLastNameLabel
            // 
            this.uxAddLastNameLabel.AutoSize = true;
            this.uxAddLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddLastNameLabel.Location = new System.Drawing.Point(93, 166);
            this.uxAddLastNameLabel.Name = "uxAddLastNameLabel";
            this.uxAddLastNameLabel.Size = new System.Drawing.Size(131, 32);
            this.uxAddLastNameLabel.TabIndex = 10;
            this.uxAddLastNameLabel.Text = "Last Name:";
            // 
            // uxAddUser
            // 
            this.uxAddUser.Location = new System.Drawing.Point(255, 425);
            this.uxAddUser.Name = "uxAddUser";
            this.uxAddUser.Size = new System.Drawing.Size(254, 85);
            this.uxAddUser.TabIndex = 9;
            this.uxAddUser.Text = "Add New User";
            this.uxAddUser.UseVisualStyleBackColor = true;
            // 
            // uxAddFirstNameLabel
            // 
            this.uxAddFirstNameLabel.AutoSize = true;
            this.uxAddFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddFirstNameLabel.Location = new System.Drawing.Point(93, 54);
            this.uxAddFirstNameLabel.Name = "uxAddFirstNameLabel";
            this.uxAddFirstNameLabel.Size = new System.Drawing.Size(134, 32);
            this.uxAddFirstNameLabel.TabIndex = 8;
            this.uxAddFirstNameLabel.Text = "First Name:";
            // 
            // uxAddFirstNameTextBox
            // 
            this.uxAddFirstNameTextBox.Location = new System.Drawing.Point(270, 54);
            this.uxAddFirstNameTextBox.Name = "uxAddFirstNameTextBox";
            this.uxAddFirstNameTextBox.Size = new System.Drawing.Size(433, 31);
            this.uxAddFirstNameTextBox.TabIndex = 7;
            // 
            // AddAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 620);
            this.Controls.Add(this.uxPhoneLabel);
            this.Controls.Add(this.uxPhoneNumberTextBox);
            this.Controls.Add(this.uxAddLastNameTextBox);
            this.Controls.Add(this.uxAddLastNameLabel);
            this.Controls.Add(this.uxAddUser);
            this.Controls.Add(this.uxAddFirstNameLabel);
            this.Controls.Add(this.uxAddFirstNameTextBox);
            this.Name = "AddAsset";
            this.Text = "AddAsset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxPhoneLabel;
        private System.Windows.Forms.TextBox uxPhoneNumberTextBox;
        private System.Windows.Forms.TextBox uxAddLastNameTextBox;
        private System.Windows.Forms.Label uxAddLastNameLabel;
        private System.Windows.Forms.Button uxAddUser;
        private System.Windows.Forms.Label uxAddFirstNameLabel;
        private System.Windows.Forms.TextBox uxAddFirstNameTextBox;
    }
}