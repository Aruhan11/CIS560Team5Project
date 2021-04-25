
namespace LibraryProject
{
    partial class HomeScreen
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
            this.uxLibraryNameLabel = new System.Windows.Forms.Label();
            this.uxAssetButton = new System.Windows.Forms.Button();
            this.uxRankButton = new System.Windows.Forms.Button();
            this.uxUserButton = new System.Windows.Forms.Button();
            this.uxSloganLabel = new System.Windows.Forms.Label();
            this.uxCreatorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLibraryNameLabel
            // 
            this.uxLibraryNameLabel.AutoSize = true;
            this.uxLibraryNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLibraryNameLabel.Location = new System.Drawing.Point(323, 77);
            this.uxLibraryNameLabel.Name = "uxLibraryNameLabel";
            this.uxLibraryNameLabel.Size = new System.Drawing.Size(360, 54);
            this.uxLibraryNameLabel.TabIndex = 0;
            this.uxLibraryNameLabel.Text = "Virtual Hale Library";
            // 
            // uxAssetButton
            // 
            this.uxAssetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetButton.Location = new System.Drawing.Point(185, 205);
            this.uxAssetButton.Name = "uxAssetButton";
            this.uxAssetButton.Size = new System.Drawing.Size(621, 104);
            this.uxAssetButton.TabIndex = 1;
            this.uxAssetButton.Text = "Add or Search By Assets";
            this.uxAssetButton.UseVisualStyleBackColor = true;
            // 
            // uxRankButton
            // 
            this.uxRankButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxRankButton.Location = new System.Drawing.Point(185, 534);
            this.uxRankButton.Name = "uxRankButton";
            this.uxRankButton.Size = new System.Drawing.Size(621, 104);
            this.uxRankButton.TabIndex = 5;
            this.uxRankButton.Text = "Rankings and Top Ten Assets";
            this.uxRankButton.UseVisualStyleBackColor = true;
            // 
            // uxUserButton
            // 
            this.uxUserButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUserButton.Location = new System.Drawing.Point(185, 314);
            this.uxUserButton.Name = "uxUserButton";
            this.uxUserButton.Size = new System.Drawing.Size(621, 104);
            this.uxUserButton.TabIndex = 6;
            this.uxUserButton.Text = "Add or Search By Users";
            this.uxUserButton.UseVisualStyleBackColor = true;
            // 
            // uxSloganLabel
            // 
            this.uxSloganLabel.AutoSize = true;
            this.uxSloganLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxSloganLabel.Location = new System.Drawing.Point(430, 151);
            this.uxSloganLabel.Name = "uxSloganLabel";
            this.uxSloganLabel.Size = new System.Drawing.Size(158, 30);
            this.uxSloganLabel.TabIndex = 8;
            this.uxSloganLabel.Text = "Reading is Fun!";
            // 
            // uxCreatorButton
            // 
            this.uxCreatorButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorButton.Location = new System.Drawing.Point(185, 424);
            this.uxCreatorButton.Name = "uxCreatorButton";
            this.uxCreatorButton.Size = new System.Drawing.Size(621, 104);
            this.uxCreatorButton.TabIndex = 9;
            this.uxCreatorButton.Text = "Add or Search By Creator";
            this.uxCreatorButton.UseVisualStyleBackColor = true;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 743);
            this.Controls.Add(this.uxCreatorButton);
            this.Controls.Add(this.uxSloganLabel);
            this.Controls.Add(this.uxUserButton);
            this.Controls.Add(this.uxRankButton);
            this.Controls.Add(this.uxAssetButton);
            this.Controls.Add(this.uxLibraryNameLabel);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLibraryNameLabel;
        private System.Windows.Forms.Button uxAssetButton;
        private System.Windows.Forms.Button uxRankButton;
        private System.Windows.Forms.Button uxUserButton;
        private System.Windows.Forms.Label uxSloganLabel;
        private System.Windows.Forms.Button uxCreatorButton;
    }
}