
namespace LibraryProject
{
    partial class User
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
            this.uxCreateUserButton = new System.Windows.Forms.Button();
            this.uxAddLastNameLabel = new System.Windows.Forms.Label();
            this.uxAddLastNameTextBox = new System.Windows.Forms.TextBox();
            this.uxAddPhoneTextBox = new System.Windows.Forms.TextBox();
            this.uxAddPhoneLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.uxFetchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.uxGetButton = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.uxDeleteButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uxUpdatePhonenumberTextBox = new System.Windows.Forms.TextBox();
            this.uxUpdateUserButton = new System.Windows.Forms.Button();
            this.uxRetriveUsersGridView = new System.Windows.Forms.DataGridView();
            this.uxRetriveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.uxUpdateUserIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveUsersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uxAddFirstNameTextBox
            // 
            this.uxAddFirstNameTextBox.Location = new System.Drawing.Point(184, 76);
            this.uxAddFirstNameTextBox.Name = "uxAddFirstNameTextBox";
            this.uxAddFirstNameTextBox.Size = new System.Drawing.Size(433, 29);
            this.uxAddFirstNameTextBox.TabIndex = 0;
            this.uxAddFirstNameTextBox.TextChanged += new System.EventHandler(this.uxAddFirstNameTextBox_TextChanged_1);
            // 
            // uxAddFirstNameLabel
            // 
            this.uxAddFirstNameLabel.AutoSize = true;
            this.uxAddFirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddFirstNameLabel.Location = new System.Drawing.Point(59, 79);
            this.uxAddFirstNameLabel.Name = "uxAddFirstNameLabel";
            this.uxAddFirstNameLabel.Size = new System.Drawing.Size(89, 21);
            this.uxAddFirstNameLabel.TabIndex = 1;
            this.uxAddFirstNameLabel.Text = "First Name:";
            // 
            // uxCreateUserButton
            // 
            this.uxCreateUserButton.Enabled = false;
            this.uxCreateUserButton.Location = new System.Drawing.Point(260, 196);
            this.uxCreateUserButton.Name = "uxCreateUserButton";
            this.uxCreateUserButton.Size = new System.Drawing.Size(254, 85);
            this.uxCreateUserButton.TabIndex = 2;
            this.uxCreateUserButton.Text = "Create User";
            this.uxCreateUserButton.UseVisualStyleBackColor = true;
            this.uxCreateUserButton.Click += new System.EventHandler(this.uxCreateUserButton_Click);
            // 
            // uxAddLastNameLabel
            // 
            this.uxAddLastNameLabel.AutoSize = true;
            this.uxAddLastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddLastNameLabel.Location = new System.Drawing.Point(59, 114);
            this.uxAddLastNameLabel.Name = "uxAddLastNameLabel";
            this.uxAddLastNameLabel.Size = new System.Drawing.Size(87, 21);
            this.uxAddLastNameLabel.TabIndex = 3;
            this.uxAddLastNameLabel.Text = "Last Name:";
            // 
            // uxAddLastNameTextBox
            // 
            this.uxAddLastNameTextBox.Location = new System.Drawing.Point(184, 111);
            this.uxAddLastNameTextBox.Name = "uxAddLastNameTextBox";
            this.uxAddLastNameTextBox.Size = new System.Drawing.Size(433, 29);
            this.uxAddLastNameTextBox.TabIndex = 4;
            this.uxAddLastNameTextBox.TextChanged += new System.EventHandler(this.uxAddLastNameTextBox_TextChanged);
            // 
            // uxAddPhoneTextBox
            // 
            this.uxAddPhoneTextBox.Location = new System.Drawing.Point(184, 146);
            this.uxAddPhoneTextBox.Name = "uxAddPhoneTextBox";
            this.uxAddPhoneTextBox.Size = new System.Drawing.Size(433, 29);
            this.uxAddPhoneTextBox.TabIndex = 5;
            this.uxAddPhoneTextBox.TextChanged += new System.EventHandler(this.uxAddPhoneTextBox_TextChanged);
            // 
            // uxAddPhoneLabel
            // 
            this.uxAddPhoneLabel.AutoSize = true;
            this.uxAddPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxAddPhoneLabel.Location = new System.Drawing.Point(27, 154);
            this.uxAddPhoneLabel.Name = "uxAddPhoneLabel";
            this.uxAddPhoneLabel.Size = new System.Drawing.Size(119, 21);
            this.uxAddPhoneLabel.TabIndex = 6;
            this.uxAddPhoneLabel.Text = "Phone Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 29);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uxFetchButton
            // 
            this.uxFetchButton.Enabled = false;
            this.uxFetchButton.Location = new System.Drawing.Point(260, 410);
            this.uxFetchButton.Name = "uxFetchButton";
            this.uxFetchButton.Size = new System.Drawing.Size(254, 85);
            this.uxFetchButton.TabIndex = 9;
            this.uxFetchButton.Text = "Fetch User";
            this.uxFetchButton.UseVisualStyleBackColor = true;
            this.uxFetchButton.Click += new System.EventHandler(this.uxFetchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Phone Number:";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(170, 593);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 29);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(170, 558);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(433, 29);
            this.textBox3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "First Name:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(170, 523);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(433, 29);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(84, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "UserID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(903, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(935, 858);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Last Name:";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(1114, 852);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(433, 29);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(1114, 817);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(433, 29);
            this.textBox6.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(933, 825);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(958, 788);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "User ID:";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(1114, 782);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(433, 29);
            this.textBox7.TabIndex = 20;
            // 
            // uxGetButton
            // 
            this.uxGetButton.Location = new System.Drawing.Point(1207, 658);
            this.uxGetButton.Name = "uxGetButton";
            this.uxGetButton.Size = new System.Drawing.Size(254, 85);
            this.uxGetButton.TabIndex = 19;
            this.uxGetButton.Text = "Get User";
            this.uxGetButton.UseVisualStyleBackColor = true;
            this.uxGetButton.Click += new System.EventHandler(this.uxGetButton_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1114, 626);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(433, 29);
            this.textBox8.TabIndex = 18;
            // 
            // uxDeleteButton
            // 
            this.uxDeleteButton.Enabled = false;
            this.uxDeleteButton.Location = new System.Drawing.Point(1207, 402);
            this.uxDeleteButton.Name = "uxDeleteButton";
            this.uxDeleteButton.Size = new System.Drawing.Size(254, 85);
            this.uxDeleteButton.TabIndex = 28;
            this.uxDeleteButton.Text = "Delete User";
            this.uxDeleteButton.UseVisualStyleBackColor = true;
            this.uxDeleteButton.Click += new System.EventHandler(this.uxDeleteButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(950, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 21);
            this.label11.TabIndex = 30;
            this.label11.Text = "UserID :";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1114, 367);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(433, 29);
            this.textBox9.TabIndex = 29;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(903, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Phone Number:";
            // 
            // uxUpdatePhonenumberTextBox
            // 
            this.uxUpdatePhonenumberTextBox.Location = new System.Drawing.Point(1114, 114);
            this.uxUpdatePhonenumberTextBox.Name = "uxUpdatePhonenumberTextBox";
            this.uxUpdatePhonenumberTextBox.Size = new System.Drawing.Size(433, 29);
            this.uxUpdatePhonenumberTextBox.TabIndex = 32;
            this.uxUpdatePhonenumberTextBox.TextChanged += new System.EventHandler(this.uxUpdatePhonenumberTextBox_TextChanged);
            // 
            // uxUpdateUserButton
            // 
            this.uxUpdateUserButton.Enabled = false;
            this.uxUpdateUserButton.Location = new System.Drawing.Point(903, 196);
            this.uxUpdateUserButton.Name = "uxUpdateUserButton";
            this.uxUpdateUserButton.Size = new System.Drawing.Size(717, 85);
            this.uxUpdateUserButton.TabIndex = 33;
            this.uxUpdateUserButton.Text = "Update User\'s Phone number";
            this.uxUpdateUserButton.UseVisualStyleBackColor = true;
            this.uxUpdateUserButton.Click += new System.EventHandler(this.uxUpdateUserButton_Click);
            // 
            // uxRetriveUsersGridView
            // 
            this.uxRetriveUsersGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxRetriveUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxRetriveUsersGridView.Location = new System.Drawing.Point(59, 796);
            this.uxRetriveUsersGridView.Name = "uxRetriveUsersGridView";
            this.uxRetriveUsersGridView.RowHeadersWidth = 60;
            this.uxRetriveUsersGridView.RowTemplate.Height = 49;
            this.uxRetriveUsersGridView.Size = new System.Drawing.Size(685, 422);
            this.uxRetriveUsersGridView.TabIndex = 34;
            // 
            // uxRetriveButton
            // 
            this.uxRetriveButton.Location = new System.Drawing.Point(184, 688);
            this.uxRetriveButton.Name = "uxRetriveButton";
            this.uxRetriveButton.Size = new System.Drawing.Size(398, 102);
            this.uxRetriveButton.TabIndex = 35;
            this.uxRetriveButton.Text = "Retrive All Users";
            this.uxRetriveButton.UseVisualStyleBackColor = true;
            this.uxRetriveButton.Click += new System.EventHandler(this.uxRetriveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(950, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "UserID :";
            // 
            // uxUpdateUserIDTextBox
            // 
            this.uxUpdateUserIDTextBox.Location = new System.Drawing.Point(1114, 47);
            this.uxUpdateUserIDTextBox.Name = "uxUpdateUserIDTextBox";
            this.uxUpdateUserIDTextBox.Size = new System.Drawing.Size(433, 29);
            this.uxUpdateUserIDTextBox.TabIndex = 36;
            this.uxUpdateUserIDTextBox.TextChanged += new System.EventHandler(this.uxUpdateUserIDTextBox_TextChanged);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 1421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxUpdateUserIDTextBox);
            this.Controls.Add(this.uxRetriveButton);
            this.Controls.Add(this.uxRetriveUsersGridView);
            this.Controls.Add(this.uxUpdateUserButton);
            this.Controls.Add(this.uxUpdatePhonenumberTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.uxDeleteButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.uxGetButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.uxFetchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxAddPhoneLabel);
            this.Controls.Add(this.uxAddPhoneTextBox);
            this.Controls.Add(this.uxAddLastNameTextBox);
            this.Controls.Add(this.uxAddLastNameLabel);
            this.Controls.Add(this.uxCreateUserButton);
            this.Controls.Add(this.uxAddFirstNameLabel);
            this.Controls.Add(this.uxAddFirstNameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "User";
            this.Text = "Phone Number:";
            ((System.ComponentModel.ISupportInitialize)(this.uxRetriveUsersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxAddFirstNameTextBox;
        private System.Windows.Forms.Label uxAddFirstNameLabel;
        private System.Windows.Forms.Button uxCreateUserButton;
        private System.Windows.Forms.Label uxAddLastNameLabel;
        private System.Windows.Forms.TextBox uxAddLastNameTextBox;
        private System.Windows.Forms.TextBox uxAddPhoneTextBox;
        private System.Windows.Forms.Label uxAddPhoneLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button uxFetchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button uxGetButton;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button uxDeleteButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uxUpdatePhonenumberTextBox;
        private System.Windows.Forms.Button uxUpdateUserButton;
        private System.Windows.Forms.DataGridView uxRetriveUsersGridView;
        private System.Windows.Forms.Button uxRetriveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxUpdateUserIDTextBox;
    }
}