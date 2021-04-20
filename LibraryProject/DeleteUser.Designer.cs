
namespace LibraryProject
{
    partial class DeleteUser
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
            this.uxDelUserIDLabel = new System.Windows.Forms.Label();
            this.uxDelUserIDTextBox = new System.Windows.Forms.TextBox();
            this.uxDelUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDelUserIDLabel
            // 
            this.uxDelUserIDLabel.AutoSize = true;
            this.uxDelUserIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDelUserIDLabel.Location = new System.Drawing.Point(117, 110);
            this.uxDelUserIDLabel.Name = "uxDelUserIDLabel";
            this.uxDelUserIDLabel.Size = new System.Drawing.Size(89, 32);
            this.uxDelUserIDLabel.TabIndex = 16;
            this.uxDelUserIDLabel.Text = "UserID:";
            // 
            // uxDelUserIDTextBox
            // 
            this.uxDelUserIDTextBox.Location = new System.Drawing.Point(285, 110);
            this.uxDelUserIDTextBox.Name = "uxDelUserIDTextBox";
            this.uxDelUserIDTextBox.Size = new System.Drawing.Size(430, 31);
            this.uxDelUserIDTextBox.TabIndex = 15;
            // 
            // uxDelUserButton
            // 
            this.uxDelUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDelUserButton.Location = new System.Drawing.Point(270, 255);
            this.uxDelUserButton.Name = "uxDelUserButton";
            this.uxDelUserButton.Size = new System.Drawing.Size(254, 85);
            this.uxDelUserButton.TabIndex = 14;
            this.uxDelUserButton.Text = "Delete Existing User";
            this.uxDelUserButton.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDelUserIDLabel);
            this.Controls.Add(this.uxDelUserIDTextBox);
            this.Controls.Add(this.uxDelUserButton);
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDelUserIDLabel;
        private System.Windows.Forms.TextBox uxDelUserIDTextBox;
        private System.Windows.Forms.Button uxDelUserButton;
    }
}