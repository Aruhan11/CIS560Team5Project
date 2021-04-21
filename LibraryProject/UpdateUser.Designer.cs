
namespace LibraryProject
{
    partial class UpdateUser
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
            this.uxUpPhoneLabel = new System.Windows.Forms.Label();
            this.uxUpPhoneTextBox = new System.Windows.Forms.TextBox();
            this.uxUpLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxUpLastNameLabel = new System.Windows.Forms.Label();
            this.uxUpUserButton = new System.Windows.Forms.Button();
            this.uxUpFirstNameLabel = new System.Windows.Forms.Label();
            this.uxUpFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.uxUpUserIDLabel = new System.Windows.Forms.Label();
            this.uxUpUserIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxUpPhoneLabel
            // 
            this.uxUpPhoneLabel.AutoSize = true;
            this.uxUpPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpPhoneLabel.Location = new System.Drawing.Point(78, 405);
            this.uxUpPhoneLabel.Name = "uxUpPhoneLabel";
            this.uxUpPhoneLabel.Size = new System.Drawing.Size(182, 32);
            this.uxUpPhoneLabel.TabIndex = 13;
            this.uxUpPhoneLabel.Text = "Phone Number:";
            // 
            // uxUpPhoneTextBox
            // 
            this.uxUpPhoneTextBox.Location = new System.Drawing.Point(278, 402);
            this.uxUpPhoneTextBox.Name = "uxUpPhoneTextBox";
            this.uxUpPhoneTextBox.Size = new System.Drawing.Size(430, 31);
            this.uxUpPhoneTextBox.TabIndex = 12;
            // 
            // uxUpLastNameTextBox
            // 
            this.uxUpLastNameTextBox.Location = new System.Drawing.Point(278, 285);
            this.uxUpLastNameTextBox.Name = "uxUpLastNameTextBox";
            this.uxUpLastNameTextBox.Size = new System.Drawing.Size(433, 31);
            this.uxUpLastNameTextBox.TabIndex = 11;
            // 
            // uxUpLastNameLabel
            // 
            this.uxUpLastNameLabel.AutoSize = true;
            this.uxUpLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpLastNameLabel.Location = new System.Drawing.Point(101, 288);
            this.uxUpLastNameLabel.Name = "uxUpLastNameLabel";
            this.uxUpLastNameLabel.Size = new System.Drawing.Size(131, 32);
            this.uxUpLastNameLabel.TabIndex = 10;
            this.uxUpLastNameLabel.Text = "Last Name:";
            // 
            // uxUpUserButton
            // 
            this.uxUpUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpUserButton.Location = new System.Drawing.Point(263, 547);
            this.uxUpUserButton.Name = "uxUpUserButton";
            this.uxUpUserButton.Size = new System.Drawing.Size(254, 85);
            this.uxUpUserButton.TabIndex = 9;
            this.uxUpUserButton.Text = "Add New User";
            this.uxUpUserButton.UseVisualStyleBackColor = true;
            // 
            // uxUpFirstNameLabel
            // 
            this.uxUpFirstNameLabel.AutoSize = true;
            this.uxUpFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpFirstNameLabel.Location = new System.Drawing.Point(101, 176);
            this.uxUpFirstNameLabel.Name = "uxUpFirstNameLabel";
            this.uxUpFirstNameLabel.Size = new System.Drawing.Size(134, 32);
            this.uxUpFirstNameLabel.TabIndex = 8;
            this.uxUpFirstNameLabel.Text = "First Name:";
            // 
            // uxUpFirstNameTextBox
            // 
            this.uxUpFirstNameTextBox.Location = new System.Drawing.Point(278, 176);
            this.uxUpFirstNameTextBox.Name = "uxUpFirstNameTextBox";
            this.uxUpFirstNameTextBox.Size = new System.Drawing.Size(433, 31);
            this.uxUpFirstNameTextBox.TabIndex = 7;
            // 
            // uxUpUserIDLabel
            // 
            this.uxUpUserIDLabel.AutoSize = true;
            this.uxUpUserIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUpUserIDLabel.Location = new System.Drawing.Point(121, 70);
            this.uxUpUserIDLabel.Name = "uxUpUserIDLabel";
            this.uxUpUserIDLabel.Size = new System.Drawing.Size(96, 32);
            this.uxUpUserIDLabel.TabIndex = 15;
            this.uxUpUserIDLabel.Text = "User ID:";
            // 
            // uxUpUserIDTextBox
            // 
            this.uxUpUserIDTextBox.Location = new System.Drawing.Point(275, 70);
            this.uxUpUserIDTextBox.Name = "uxUpUserIDTextBox";
            this.uxUpUserIDTextBox.Size = new System.Drawing.Size(433, 31);
            this.uxUpUserIDTextBox.TabIndex = 14;
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 765);
            this.Controls.Add(this.uxUpUserIDLabel);
            this.Controls.Add(this.uxUpUserIDTextBox);
            this.Controls.Add(this.uxUpPhoneLabel);
            this.Controls.Add(this.uxUpPhoneTextBox);
            this.Controls.Add(this.uxUpLastNameTextBox);
            this.Controls.Add(this.uxUpLastNameLabel);
            this.Controls.Add(this.uxUpUserButton);
            this.Controls.Add(this.uxUpFirstNameLabel);
            this.Controls.Add(this.uxUpFirstNameTextBox);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxUpPhoneLabel;
        private System.Windows.Forms.TextBox uxUpPhoneTextBox;
        private System.Windows.Forms.TextBox uxUpLastNameTextBox;
        private System.Windows.Forms.Label uxUpLastNameLabel;
        private System.Windows.Forms.Button uxUpUserButton;
        private System.Windows.Forms.Label uxUpFirstNameLabel;
        private System.Windows.Forms.TextBox uxUpFirstNameTextBox;
        private System.Windows.Forms.Label uxUpUserIDLabel;
        private System.Windows.Forms.TextBox uxUpUserIDTextBox;
    }
}