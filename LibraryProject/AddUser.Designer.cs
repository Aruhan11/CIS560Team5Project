
namespace LibraryProject
{
    partial class AddUser
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
            this.uxAddFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddFirstNameLabel = new System.Windows.Forms.Label();
            this.uxAddUserButton = new System.Windows.Forms.Button();
            this.uxAddLastNameLabel = new System.Windows.Forms.Label();
            this.uxAddLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddPhoneTextBox = new System.Windows.Forms.TextBox();
            this.uxAddPhoneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAddFirstNameTextBox
            // 
            this.uxAddFirstNameTextBox.Location = new System.Drawing.Point(298, 45);
            this.uxAddFirstNameTextBox.Name = "uxAddFirstNameTextBox";
            this.uxAddFirstNameTextBox.Size = new System.Drawing.Size(433, 39);
            this.uxAddFirstNameTextBox.TabIndex = 0;
            // 
            // uxAddFirstNameLabel
            // 
            this.uxAddFirstNameLabel.AutoSize = true;
            this.uxAddFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddFirstNameLabel.Location = new System.Drawing.Point(121, 45);
            this.uxAddFirstNameLabel.Name = "uxAddFirstNameLabel";
            this.uxAddFirstNameLabel.Size = new System.Drawing.Size(134, 32);
            this.uxAddFirstNameLabel.TabIndex = 1;
            this.uxAddFirstNameLabel.Text = "First Name:";
            // 
            // uxAddUserButton
            // 
            this.uxAddUserButton.Location = new System.Drawing.Point(283, 416);
            this.uxAddUserButton.Name = "uxAddUserButton";
            this.uxAddUserButton.Size = new System.Drawing.Size(254, 85);
            this.uxAddUserButton.TabIndex = 2;
            this.uxAddUserButton.Text = "Add New User";
            this.uxAddUserButton.UseVisualStyleBackColor = true;
            // 
            // uxAddLastNameLabel
            // 
            this.uxAddLastNameLabel.AutoSize = true;
            this.uxAddLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddLastNameLabel.Location = new System.Drawing.Point(121, 157);
            this.uxAddLastNameLabel.Name = "uxAddLastNameLabel";
            this.uxAddLastNameLabel.Size = new System.Drawing.Size(131, 32);
            this.uxAddLastNameLabel.TabIndex = 3;
            this.uxAddLastNameLabel.Text = "Last Name:";
            // 
            // uxAddLastNameTextBox
            // 
            this.uxAddLastNameTextBox.Location = new System.Drawing.Point(298, 154);
            this.uxAddLastNameTextBox.Name = "uxAddLastNameTextBox";
            this.uxAddLastNameTextBox.Size = new System.Drawing.Size(433, 39);
            this.uxAddLastNameTextBox.TabIndex = 4;
            // 
            // uxAddPhoneTextBox
            // 
            this.uxAddPhoneTextBox.Location = new System.Drawing.Point(298, 271);
            this.uxAddPhoneTextBox.Name = "uxAddPhoneTextBox";
            this.uxAddPhoneTextBox.Size = new System.Drawing.Size(430, 39);
            this.uxAddPhoneTextBox.TabIndex = 5;
            // 
            // uxAddPhoneLabel
            // 
            this.uxAddPhoneLabel.AutoSize = true;
            this.uxAddPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddPhoneLabel.Location = new System.Drawing.Point(98, 274);
            this.uxAddPhoneLabel.Name = "uxAddPhoneLabel";
            this.uxAddPhoneLabel.Size = new System.Drawing.Size(182, 32);
            this.uxAddPhoneLabel.TabIndex = 6;
            this.uxAddPhoneLabel.Text = "Phone Number:";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 581);
            this.Controls.Add(this.uxAddPhoneLabel);
            this.Controls.Add(this.uxAddPhoneTextBox);
            this.Controls.Add(this.uxAddLastNameTextBox);
            this.Controls.Add(this.uxAddLastNameLabel);
            this.Controls.Add(this.uxAddUserButton);
            this.Controls.Add(this.uxAddFirstNameLabel);
            this.Controls.Add(this.uxAddFirstNameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxAddFirstNameTextBox;
        private System.Windows.Forms.Label uxAddFirstNameLabel;
        private System.Windows.Forms.Button uxAddUserButton;
        private System.Windows.Forms.Label uxAddLastNameLabel;
        private System.Windows.Forms.TextBox uxAddLastNameTextBox;
        private System.Windows.Forms.TextBox uxAddPhoneTextBox;
        private System.Windows.Forms.Label uxAddPhoneLabel;
    }
}