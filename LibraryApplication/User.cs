using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using LibraryData;
using System.Text.RegularExpressions;
using System.Linq;

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
        {   if (userRepo.CheckString(uxAddFirstNameTextBox.Text) && userRepo.CheckString(uxAddLastNameTextBox.Text) && userRepo.CheckInt(uxAddPhoneTextBox.Text))
            {
                var user = userRepo.CreateUser(uxAddFirstNameTextBox.Text, uxAddLastNameTextBox.Text, uxAddPhoneTextBox.Text, default(DateTime), 0);
                if (user != null) MessageBox.Show(user.FirstName + user.LastName + " have been added!", "User Added");
                else MessageBox.Show("Phone Number Not Added Number Already Exists", "User exists");
            }
            else MessageBox.Show("Invalid Input", "Invalid");
        }



        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            if (userRepo.CheckInt(textBox9.Text))
            {
                int userid = Convert.ToInt32(textBox9.Text);

                userRepo.DeleteUser(userid);
                var checkDel = userRepo.FetchUser(userid);
                if (checkDel.IsDeleted == 1) MessageBox.Show(userid + " have been deleted", "User Added");
                textBox9.Clear();
            }
            else
            {
                MessageBox.Show("Please input a valid number for UserID", "Invalid UserID");
                textBox9.Text = "";

            }
        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {


            if (userRepo.CheckInt(textBox1.Text))
            {
                int userId = Convert.ToInt32(textBox1.Text);
                var fetchedUser = userRepo.FetchUser(userId);
                if (fetchedUser == null) MessageBox.Show("UserID does not exist", "Invalid UserID");
                else
                {
                    textBox4.Text = fetchedUser.FirstName.ToString();
                    textBox3.Text = fetchedUser.LastName.ToString();
                    textBox2.Text = fetchedUser.PhoneNumber.ToString();
                }
            }
            else MessageBox.Show("Please input a valid number for UserID", "Invalid UserID");

        }

        private void uxGetButton_Click(object sender, EventArgs e)
        {
            if (userRepo.CheckInt(textBox8.Text))
            {
                string phone = textBox8.Text;
                var user = userRepo.GetUser(phone);
                textBox7.Text = user.UserID.ToString();
                textBox6.Text = user.FirstName.ToString();
                textBox5.Text = user.LastName.ToString();
            }
            else
            {

                MessageBox.Show("Please input a valid number for Phone Number", "Invalid Phone Number");
                textBox8.Text = "";
            }
        }


        private void uxUpdateUserButton_Click(object sender, EventArgs e)
        {

            if (userRepo.CheckInt(uxUpdateUserIDTextBox.Text) && userRepo.CheckInt(uxUpdatePhonenumberTextBox.Text))
            {
                string phonenumber = uxUpdatePhonenumberTextBox.Text;
                int userid = Convert.ToInt32(uxUpdateUserIDTextBox.Text);

                var checkNumber = userRepo.UpdateUser(userid, phonenumber);
                var check = userRepo.FetchUser(userid);
                if (String.Compare(check.PhoneNumber, phonenumber) == 0 && checkNumber == true) MessageBox.Show(phonenumber + " have been updated", "Update User Phone Number");
                else { MessageBox.Show("Phone Number Already Exists", "Number Exists"); }
                textBox9.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Input", "Invalid Input");
                uxUpdatePhonenumberTextBox.Text = "";
                uxUpdateUserIDTextBox.Text = "";
            }


        }

        private void uxRetriveButton_Click(object sender, EventArgs e)
        {

            var list = userRepo.RetrieveUsers();

            uxRetriveUsersGridView.DataSource = list;
        }

        private void uxAddFirstNameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (uxAddFirstNameTextBox.Text.Trim().Length > 0 && uxAddLastNameTextBox.Text.Trim().Length > 0 && uxAddPhoneTextBox.Text.Trim().Length > 0)
            {
                uxCreateUserButton.Enabled = true;
            }
            else uxCreateUserButton.Enabled = false;
        }

        private void uxAddLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxAddFirstNameTextBox.Text.Trim().Length > 0 && uxAddLastNameTextBox.Text.Trim().Length > 0 && uxAddPhoneTextBox.Text.Trim().Length > 0)
            {
                uxCreateUserButton.Enabled = true;
            }
            else uxCreateUserButton.Enabled = false;
        }

        private void uxAddPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxAddFirstNameTextBox.Text.Trim().Length > 0 && uxAddLastNameTextBox.Text.Trim().Length > 0 && uxAddPhoneTextBox.Text.Trim().Length > 0)
            {
                uxCreateUserButton.Enabled = true;
            }
            else uxCreateUserButton.Enabled = false;
        }

        private void uxUpdateUserIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxUpdateUserIDTextBox.Text.Trim().Length > 0 && uxUpdatePhonenumberTextBox.Text.Trim().Length > 0 )
            {
                uxUpdateUserButton.Enabled = true;
            }
            else uxUpdateUserButton.Enabled = false;
            
        }

        private void uxUpdatePhonenumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxUpdateUserIDTextBox.Text.Trim().Length > 0 && uxUpdatePhonenumberTextBox.Text.Trim().Length > 0)
            {
                uxUpdateUserButton.Enabled = true;
            }
            else uxUpdateUserButton.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                uxFetchButton.Enabled = true;
            }
            else uxFetchButton.Enabled = false;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Trim().Length > 0)
            {
                uxDeleteButton.Enabled = true;
            }
            else uxDeleteButton.Enabled = false;
           
        }
    }
}
