﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.uxLibraryNameLabel = new System.Windows.Forms.Label();
            this.uxAssetButton = new System.Windows.Forms.Button();
            this.uxRankButton = new System.Windows.Forms.Button();
            this.uxUserButton = new System.Windows.Forms.Button();
            this.uxSloganLabel = new System.Windows.Forms.Label();
            this.uxCreatorButton = new System.Windows.Forms.Button();
            this.uxLibManSysLabel = new System.Windows.Forms.Label();
            this.uxMangeCheckOutAssetButton = new System.Windows.Forms.Button();
            this.uxManageLibrarianButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLibraryNameLabel
            // 
            this.uxLibraryNameLabel.AutoSize = true;
            this.uxLibraryNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLibraryNameLabel.Location = new System.Drawing.Point(224, 21);
            this.uxLibraryNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLibraryNameLabel.Name = "uxLibraryNameLabel";
            this.uxLibraryNameLabel.Size = new System.Drawing.Size(244, 37);
            this.uxLibraryNameLabel.TabIndex = 0;
            this.uxLibraryNameLabel.Text = "Virtual Hale Library";
            // 
            // uxAssetButton
            // 
            this.uxAssetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAssetButton.Location = new System.Drawing.Point(52, 225);
            this.uxAssetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxAssetButton.Name = "uxAssetButton";
            this.uxAssetButton.Size = new System.Drawing.Size(251, 63);
            this.uxAssetButton.TabIndex = 1;
            this.uxAssetButton.Text = "Manage Asset";
            this.uxAssetButton.UseVisualStyleBackColor = true;
            this.uxAssetButton.Click += new System.EventHandler(this.uxAssetButton_Click);
            // 
            // uxRankButton
            // 
            this.uxRankButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxRankButton.Location = new System.Drawing.Point(357, 316);
            this.uxRankButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxRankButton.Name = "uxRankButton";
            this.uxRankButton.Size = new System.Drawing.Size(251, 63);
            this.uxRankButton.TabIndex = 5;
            this.uxRankButton.Text = "Interesting Report Queries";
            this.uxRankButton.UseVisualStyleBackColor = true;
            this.uxRankButton.Click += new System.EventHandler(this.uxRankButton_Click);
            // 
            // uxUserButton
            // 
            this.uxUserButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUserButton.Location = new System.Drawing.Point(52, 142);
            this.uxUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxUserButton.Name = "uxUserButton";
            this.uxUserButton.Size = new System.Drawing.Size(249, 63);
            this.uxUserButton.TabIndex = 6;
            this.uxUserButton.Text = "Manage User";
            this.uxUserButton.UseVisualStyleBackColor = true;
            this.uxUserButton.Click += new System.EventHandler(this.uxUserButton_Click);
            // 
            // uxSloganLabel
            // 
            this.uxSloganLabel.AutoSize = true;
            this.uxSloganLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxSloganLabel.Location = new System.Drawing.Point(290, 59);
            this.uxSloganLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxSloganLabel.Name = "uxSloganLabel";
            this.uxSloganLabel.Size = new System.Drawing.Size(109, 20);
            this.uxSloganLabel.TabIndex = 8;
            this.uxSloganLabel.Text = "Reading is Fun!";
            // 
            // uxCreatorButton
            // 
            this.uxCreatorButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxCreatorButton.Location = new System.Drawing.Point(357, 142);
            this.uxCreatorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxCreatorButton.Name = "uxCreatorButton";
            this.uxCreatorButton.Size = new System.Drawing.Size(251, 63);
            this.uxCreatorButton.TabIndex = 9;
            this.uxCreatorButton.Text = "Manage Creator";
            this.uxCreatorButton.UseVisualStyleBackColor = true;
            this.uxCreatorButton.Click += new System.EventHandler(this.uxCreatorButton_Click);
            // 
            // uxLibManSysLabel
            // 
            this.uxLibManSysLabel.AutoSize = true;
            this.uxLibManSysLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxLibManSysLabel.Location = new System.Drawing.Point(239, 99);
            this.uxLibManSysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxLibManSysLabel.Name = "uxLibManSysLabel";
            this.uxLibManSysLabel.Size = new System.Drawing.Size(202, 20);
            this.uxLibManSysLabel.TabIndex = 10;
            this.uxLibManSysLabel.Text = "Librarian Mangament System";
            // 
            // uxMangeCheckOutAssetButton
            // 
            this.uxMangeCheckOutAssetButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxMangeCheckOutAssetButton.Location = new System.Drawing.Point(357, 225);
            this.uxMangeCheckOutAssetButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMangeCheckOutAssetButton.Name = "uxMangeCheckOutAssetButton";
            this.uxMangeCheckOutAssetButton.Size = new System.Drawing.Size(251, 63);
            this.uxMangeCheckOutAssetButton.TabIndex = 11;
            this.uxMangeCheckOutAssetButton.Text = "Manage Check Out Asset";
            this.uxMangeCheckOutAssetButton.UseVisualStyleBackColor = true;
            this.uxMangeCheckOutAssetButton.Click += new System.EventHandler(this.uxMangeCheckOutAssetButton_Click);
            // 
            // uxManageLibrarianButton
            // 
            this.uxManageLibrarianButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxManageLibrarianButton.Location = new System.Drawing.Point(52, 316);
            this.uxManageLibrarianButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxManageLibrarianButton.Name = "uxManageLibrarianButton";
            this.uxManageLibrarianButton.Size = new System.Drawing.Size(251, 63);
            this.uxManageLibrarianButton.TabIndex = 12;
            this.uxManageLibrarianButton.Text = "Manage Librarian";
            this.uxManageLibrarianButton.UseVisualStyleBackColor = true;
            this.uxManageLibrarianButton.Click += new System.EventHandler(this.uxManageLibrarianButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 439);
            this.Controls.Add(this.uxManageLibrarianButton);
            this.Controls.Add(this.uxMangeCheckOutAssetButton);
            this.Controls.Add(this.uxLibManSysLabel);
            this.Controls.Add(this.uxCreatorButton);
            this.Controls.Add(this.uxSloganLabel);
            this.Controls.Add(this.uxUserButton);
            this.Controls.Add(this.uxRankButton);
            this.Controls.Add(this.uxAssetButton);
            this.Controls.Add(this.uxLibraryNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
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
        private System.Windows.Forms.Label uxLibManSysLabel;
        private System.Windows.Forms.Button uxMangeCheckOutAssetButton;
        private System.Windows.Forms.Button uxManageLibrarianButton;
    }
}