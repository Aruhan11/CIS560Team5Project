﻿
namespace LibraryProject
{
    partial class Important
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
            this.uxRankAssetByTypeButton = new System.Windows.Forms.Button();
            this.uxRankAssetByTypeGridView = new System.Windows.Forms.DataGridView();
            this.uxTopTenButtons = new System.Windows.Forms.Button();
            this.uxTopTenGridView = new System.Windows.Forms.DataGridView();
            this.uxRankCreatorByUserButton = new System.Windows.Forms.Button();
            this.uxRankCreatorByUserGridView = new System.Windows.Forms.DataGridView();
            this.uxRankCreatorByTypeButton = new System.Windows.Forms.Button();
            this.uxRankCreatorByAssetGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uxRankAssetByTypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTopTenGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRankCreatorByUserGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRankCreatorByAssetGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxRankAssetByTypeButton
            // 
            this.uxRankAssetByTypeButton.Location = new System.Drawing.Point(2538, 38);
            this.uxRankAssetByTypeButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxRankAssetByTypeButton.Name = "uxRankAssetByTypeButton";
            this.uxRankAssetByTypeButton.Size = new System.Drawing.Size(432, 139);
            this.uxRankAssetByTypeButton.TabIndex = 90;
            this.uxRankAssetByTypeButton.Text = "Rank Assets by Asset Type";
            this.uxRankAssetByTypeButton.UseVisualStyleBackColor = true;
            this.uxRankAssetByTypeButton.Click += new System.EventHandler(this.uxRankAssetByTypeButton_Click);
            // 
            // uxRankAssetByTypeGridView
            // 
            this.uxRankAssetByTypeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxRankAssetByTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRankAssetByTypeGridView.Location = new System.Drawing.Point(1926, 243);
            this.uxRankAssetByTypeGridView.Margin = new System.Windows.Forms.Padding(5);
            this.uxRankAssetByTypeGridView.Name = "uxRankAssetByTypeGridView";
            this.uxRankAssetByTypeGridView.RowHeadersWidth = 62;
            this.uxRankAssetByTypeGridView.RowTemplate.Height = 33;
            this.uxRankAssetByTypeGridView.Size = new System.Drawing.Size(1681, 683);
            this.uxRankAssetByTypeGridView.TabIndex = 89;
            // 
            // uxTopTenButtons
            // 
            this.uxTopTenButtons.Location = new System.Drawing.Point(664, 49);
            this.uxTopTenButtons.Margin = new System.Windows.Forms.Padding(5);
            this.uxTopTenButtons.Name = "uxTopTenButtons";
            this.uxTopTenButtons.Size = new System.Drawing.Size(432, 139);
            this.uxTopTenButtons.TabIndex = 94;
            this.uxTopTenButtons.Text = "Top Ten Assets Still Available";
            this.uxTopTenButtons.UseVisualStyleBackColor = true;
            this.uxTopTenButtons.Click += new System.EventHandler(this.uxTopTenButtons_Click);
            // 
            // uxTopTenGridView
            // 
            this.uxTopTenGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxTopTenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxTopTenGridView.Location = new System.Drawing.Point(49, 212);
            this.uxTopTenGridView.Margin = new System.Windows.Forms.Padding(5);
            this.uxTopTenGridView.Name = "uxTopTenGridView";
            this.uxTopTenGridView.RowHeadersWidth = 62;
            this.uxTopTenGridView.RowTemplate.Height = 33;
            this.uxTopTenGridView.Size = new System.Drawing.Size(1681, 683);
            this.uxTopTenGridView.TabIndex = 93;
            // 
            // uxRankCreatorByUserButton
            // 
            this.uxRankCreatorByUserButton.Location = new System.Drawing.Point(664, 1010);
            this.uxRankCreatorByUserButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxRankCreatorByUserButton.Name = "uxRankCreatorByUserButton";
            this.uxRankCreatorByUserButton.Size = new System.Drawing.Size(432, 139);
            this.uxRankCreatorByUserButton.TabIndex = 96;
            this.uxRankCreatorByUserButton.Text = "Rank Creators by User";
            this.uxRankCreatorByUserButton.UseVisualStyleBackColor = true;
            this.uxRankCreatorByUserButton.Click += new System.EventHandler(this.uxRankCreatorByUserButton_Click);
            // 
            // uxRankCreatorByUserGridView
            // 
            this.uxRankCreatorByUserGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxRankCreatorByUserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRankCreatorByUserGridView.Location = new System.Drawing.Point(49, 1170);
            this.uxRankCreatorByUserGridView.Margin = new System.Windows.Forms.Padding(5);
            this.uxRankCreatorByUserGridView.Name = "uxRankCreatorByUserGridView";
            this.uxRankCreatorByUserGridView.RowHeadersWidth = 62;
            this.uxRankCreatorByUserGridView.RowTemplate.Height = 33;
            this.uxRankCreatorByUserGridView.Size = new System.Drawing.Size(1681, 706);
            this.uxRankCreatorByUserGridView.TabIndex = 95;
            // 
            // uxRankCreatorByTypeButton
            // 
            this.uxRankCreatorByTypeButton.Location = new System.Drawing.Point(2663, 999);
            this.uxRankCreatorByTypeButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxRankCreatorByTypeButton.Name = "uxRankCreatorByTypeButton";
            this.uxRankCreatorByTypeButton.Size = new System.Drawing.Size(432, 139);
            this.uxRankCreatorByTypeButton.TabIndex = 98;
            this.uxRankCreatorByTypeButton.Text = "Rank Creators by Asset Type";
            this.uxRankCreatorByTypeButton.UseVisualStyleBackColor = true;
            this.uxRankCreatorByTypeButton.Click += new System.EventHandler(this.uxRankCreatorByTypeButton_Click);
            // 
            // uxRankCreatorByAssetGridView
            // 
            this.uxRankCreatorByAssetGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxRankCreatorByAssetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRankCreatorByAssetGridView.Location = new System.Drawing.Point(1915, 1170);
            this.uxRankCreatorByAssetGridView.Margin = new System.Windows.Forms.Padding(5);
            this.uxRankCreatorByAssetGridView.Name = "uxRankCreatorByAssetGridView";
            this.uxRankCreatorByAssetGridView.RowHeadersWidth = 62;
            this.uxRankCreatorByAssetGridView.RowTemplate.Height = 33;
            this.uxRankCreatorByAssetGridView.Size = new System.Drawing.Size(1681, 706);
            this.uxRankCreatorByAssetGridView.TabIndex = 97;
            // 
            // Important
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3677, 1970);
            this.Controls.Add(this.uxRankCreatorByTypeButton);
            this.Controls.Add(this.uxRankCreatorByAssetGridView);
            this.Controls.Add(this.uxRankCreatorByUserButton);
            this.Controls.Add(this.uxRankCreatorByUserGridView);
            this.Controls.Add(this.uxTopTenButtons);
            this.Controls.Add(this.uxTopTenGridView);
            this.Controls.Add(this.uxRankAssetByTypeButton);
            this.Controls.Add(this.uxRankAssetByTypeGridView);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Important";
            this.Text = "Rankings and Top Ten";
            ((System.ComponentModel.ISupportInitialize)(this.uxRankAssetByTypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTopTenGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRankCreatorByUserGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRankCreatorByAssetGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button uxRankAssetByTypeButton;
        private System.Windows.Forms.DataGridView uxRankAssetByTypeGridView;
        private System.Windows.Forms.Button uxTopTenButtons;
        private System.Windows.Forms.DataGridView uxTopTenGridView;
        private System.Windows.Forms.Button uxRankCreatorByUserButton;
        private System.Windows.Forms.DataGridView uxRankCreatorByUserGridView;
        private System.Windows.Forms.Button uxRankCreatorByTypeButton;
        private System.Windows.Forms.DataGridView uxRankCreatorByAssetGridView;
    }
}