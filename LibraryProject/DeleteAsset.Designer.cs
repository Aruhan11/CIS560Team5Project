
namespace LibraryProject
{
    partial class DeleteAsset
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
            this.uxDelAssetIDLabel = new System.Windows.Forms.Label();
            this.uxDelAssetIDTextBox = new System.Windows.Forms.TextBox();
            this.uxDelAssetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxDelAssetIDLabel
            // 
            this.uxDelAssetIDLabel.AutoSize = true;
            this.uxDelAssetIDLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDelAssetIDLabel.Location = new System.Drawing.Point(101, 110);
            this.uxDelAssetIDLabel.Name = "uxDelAssetIDLabel";
            this.uxDelAssetIDLabel.Size = new System.Drawing.Size(105, 32);
            this.uxDelAssetIDLabel.TabIndex = 19;
            this.uxDelAssetIDLabel.Text = "Asset ID:";
            // 
            // uxDelAssetIDTextBox
            // 
            this.uxDelAssetIDTextBox.Location = new System.Drawing.Point(269, 110);
            this.uxDelAssetIDTextBox.Name = "uxDelAssetIDTextBox";
            this.uxDelAssetIDTextBox.Size = new System.Drawing.Size(430, 31);
            this.uxDelAssetIDTextBox.TabIndex = 18;
            // 
            // uxDelAssetButton
            // 
            this.uxDelAssetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDelAssetButton.Location = new System.Drawing.Point(254, 255);
            this.uxDelAssetButton.Name = "uxDelAssetButton";
            this.uxDelAssetButton.Size = new System.Drawing.Size(254, 85);
            this.uxDelAssetButton.TabIndex = 17;
            this.uxDelAssetButton.Text = "Delete Existing Asset";
            this.uxDelAssetButton.UseVisualStyleBackColor = true;
            // 
            // DeleteAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxDelAssetIDLabel);
            this.Controls.Add(this.uxDelAssetIDTextBox);
            this.Controls.Add(this.uxDelAssetButton);
            this.Name = "DeleteAsset";
            this.Text = "DeleteAsset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDelAssetIDLabel;
        private System.Windows.Forms.TextBox uxDelAssetIDTextBox;
        private System.Windows.Forms.Button uxDelAssetButton;
    }
}