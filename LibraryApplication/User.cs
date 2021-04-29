﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using LibraryData;
using System.Text.RegularExpressions;

namespace LibraryProject
{
    public partial class User : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";
       // private IGeneralQueryRepository general;
      //  private IQuestionQueryRepository question;
        private IUserQueryRepository userRepo;

        public User()
        {
            //general = new SqlGeneralQueryRepository(connectionString);
          //  question = new SqlQuestionQueryRepository(connectionString);
            userRepo = new SqlUserQueryRepository(connectionString);

            InitializeComponent();
            
        }

        private void uxCreateUserButton_Click(object sender, EventArgs e)
        {
            var user = userRepo.CreateUser(uxAddFirstNameTextBox.Text, uxAddLastNameTextBox.Text, uxAddPhoneTextBox.Text, default(DateTime), 0 );
            if  (user != null) MessageBox.Show(user.FirstName + " " + user.LastName + " has been added!", "User Added");
        }

    

        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBox9.Text);

            userRepo.DeleteUser(userid);
            var checkDel = userRepo.FetchUser(userid);
            if(checkDel.IsDeleted == 1) MessageBox.Show(userid + " has been deleted", "User Added");
            textBox9.Clear();
        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(textBox1.Text);
            var fetchedUser = userRepo.FetchUser(userId);
            textBox4.Text = fetchedUser.FirstName.ToString();
            textBox3.Text = fetchedUser.LastName.ToString();
            textBox2.Text = fetchedUser.PhoneNumber.ToString();
        }

        private void uxGetButton_Click(object sender, EventArgs e)
        {
            string phonenumber = Regex.Replace(textBox8.Text, "[^0-9]", "");
            if (phonenumber.Length != 10)
            {
                MessageBox.Show("Invalid entry, please insert in the format (###) ###-####", "Error", MessageBoxButtons.OK);
            }
            else
            {
                var user = userRepo.GetUser(phonenumber);
                textBox7.Text = user.UserID.ToString();
                textBox6.Text = user.FirstName.ToString();
                textBox5.Text = user.LastName.ToString();
            }
        }


        private void uxUpdateUserButton_Click(object sender, EventArgs e)
        {
            string phonenumber = Regex.Replace(uxUpdatePhonenumberTextBox.Text, "[^0-9]", "");
            if (phonenumber.Length != 10)
            {
                MessageBox.Show("Invalid entry, please insert in the format (###) ###-####", "Error", MessageBoxButtons.OK);
            }
            else
            {
                phonenumber = phonenumber.Insert(0, "(");
                phonenumber = phonenumber.Insert(4, ")");
                phonenumber = phonenumber.Insert(5, " ");
                phonenumber = phonenumber.Insert(9, "-");

                int userid = Convert.ToInt32(uxUpdateUserIDTextBox.Text);

                userRepo.UpdateUser(userid, phonenumber);
                var check = userRepo.FetchUser(userid);
                if (String.Compare(check.PhoneNumber, phonenumber) == 0) MessageBox.Show(check.FirstName + "'s phone number has been updated", "Update User Phone Number");
                textBox9.Clear();

            }
        }

        private void uxRetriveButton_Click(object sender, EventArgs e)
        {
            
          
            var list = userRepo.RetrieveUsers();

            uxRetriveUsersGridView.DataSource = list;
        }
    }
}
