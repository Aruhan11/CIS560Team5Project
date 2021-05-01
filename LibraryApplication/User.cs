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
        {  
            
            if (userRepo.CheckString(uxAddFirstNameTextBox.Text) && userRepo.CheckString(uxAddLastNameTextBox.Text) && userRepo.CheckInt(uxAddPhoneTextBox.Text))
            {
                
                string phonenumber = Regex.Replace(uxAddPhoneTextBox.Text, "[^0-9]", "");
                if (phonenumber.Length != 10)
                {
                    uxAddPhoneTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("Invalid entry, please insert in the format (###) ###-####", "Error", MessageBoxButtons.OK);
                    
                }
                else
                {
                    phonenumber = phonenumber.Insert(0, "(");
                    phonenumber = phonenumber.Insert(4, ")");
                    phonenumber = phonenumber.Insert(5, " ");
                    phonenumber = phonenumber.Insert(9, "-");
                    var user = userRepo.CreateUser(uxAddFirstNameTextBox.Text, uxAddLastNameTextBox.Text, phonenumber, default(DateTime), 0);
                    if (user != null) MessageBox.Show(user.FirstName + user.LastName + " have been added!", "User Added");
                    else
                    {
                        uxAddPhoneTextBox.BackColor = Color.LightCoral;
                        MessageBox.Show("Phone Number Not Added Number Already Exists", "Invalid Phone Number");

                    }
                }
            }
            else
            {
                if (!userRepo.CheckString(uxAddFirstNameTextBox.Text)) uxAddFirstNameTextBox.BackColor = Color.LightCoral;
                if (!userRepo.CheckString(uxAddLastNameTextBox.Text)) uxAddLastNameTextBox.BackColor = Color.LightCoral;
                if (!userRepo.CheckInt(uxAddPhoneTextBox.Text)) uxAddPhoneTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Input", "Invalid");
            }


        }



        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            if (userRepo.CheckInt(uxDelUserIDTextBox.Text))
            {
                int userid = Convert.ToInt32(uxDelUserIDTextBox.Text);

                userRepo.DeleteUser(userid);
                var checkDel = userRepo.FetchUser(userid);
                if (checkDel == null) 
                {
                    uxDelUserIDTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("UserID does not exist", "Invalid UserID");
                } 
                else if (checkDel.IsDeleted == 1) MessageBox.Show(userid + " have been deleted", "User Added");
                uxDelUserIDTextBox.Clear();
            }
            else
            {
                uxDelUserIDTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Please input a valid number for UserID", "Invalid UserID");
                uxDelUserIDTextBox.Text = "";

            }
        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {


            if (userRepo.CheckInt(uxFetchUserIDTextBox.Text))
            {
                int userId = Convert.ToInt32(uxFetchUserIDTextBox.Text);
                var fetchedUser = userRepo.FetchUser(userId);
                if (fetchedUser == null)
                {
                    uxFetchUserIDTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("UserID does not exist", "Invalid UserID");
                }
                else
                {
                    uxFetchFNameTextBox.Text = fetchedUser.FirstName.ToString();
                    uxFetchLNameTextBox.Text = fetchedUser.LastName.ToString();
                    uxFetchPhoneTextBox.Text = fetchedUser.PhoneNumber.ToString();
                }
            }
            else
            {
                uxFetchUserIDTextBox.BackColor = Color.LightCoral;
           
                MessageBox.Show("Please input a valid number for UserID", "Invalid UserID");
                
            }

        }

        private void uxGetButton_Click(object sender, EventArgs e)
        {

            if (userRepo.CheckInt(uxGetPhoneTextBox.Text))
            {
                string phonenumber = Regex.Replace(uxGetPhoneTextBox.Text, "[^0-9]", "");
                if (phonenumber.Length != 10)
                {
                    uxGetPhoneTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("Invalid entry, please insert in the format (###) ###-####", "Error", MessageBoxButtons.OK);

                }
                else
                {
                    phonenumber = phonenumber.Insert(0, "(");
                    phonenumber = phonenumber.Insert(4, ")");
                    phonenumber = phonenumber.Insert(5, " ");
                    phonenumber = phonenumber.Insert(9, "-");
                    
                    var user = userRepo.GetUser(phonenumber);
                    if(user == null)
                    {
                        uxGetPhoneTextBox.BackColor = Color.LightCoral;
                        MessageBox.Show("Phone Number Does Not Exists", "Invalid Phone Number");

                    }
                    else
                    {
                        uxGetUserIDTextBox.Text = user.UserID.ToString();
                        uxGetFNameTextBox.Text = user.FirstName.ToString();
                        uxGetLNameTextBox.Text = user.LastName.ToString();
                    }

                }
            }
            else
            {
                uxGetPhoneTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Please input a valid number for Phone Number", "Invalid Phone Number");
                uxGetPhoneTextBox.Text = "";
            }
        }


        private void uxUpdateUserButton_Click(object sender, EventArgs e)
        {

            if (userRepo.CheckInt(uxUpdateUserIDTextBox.Text) && userRepo.CheckInt(uxUpdatePhonenumberTextBox.Text))
            {
                string phonenumber = Regex.Replace(uxUpdatePhonenumberTextBox.Text, "[^0-9]", "");
                if (phonenumber.Length != 10)
                {
                    uxUpdatePhonenumberTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("Invalid entry, please insert in the format (###) ###-####", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    phonenumber = phonenumber.Insert(0, "(");
                    phonenumber = phonenumber.Insert(4, ")");
                    phonenumber = phonenumber.Insert(5, " ");
                    phonenumber = phonenumber.Insert(9, "-");

                    int userid = Convert.ToInt32(uxUpdateUserIDTextBox.Text);

                    var checkNumber = userRepo.UpdateUser(userid, phonenumber);
                    var check = userRepo.FetchUser(userid);
                    if (check == null)
                    {
                        uxUpdateUserIDTextBox.BackColor = Color.LightCoral;
                        MessageBox.Show("UserID does not exist", "Invalid UserID");
                    }
                    else
                    {
                        if (String.Compare(check.PhoneNumber, phonenumber) == 0 && checkNumber == true) MessageBox.Show(phonenumber + " have been updated", "Update User Phone Number");
                        else
                        {
                            uxUpdatePhonenumberTextBox.BackColor = Color.LightCoral;
                            MessageBox.Show("Phone Number Already Exists", "Number Exists");
                        }
                        uxDelUserIDTextBox.Clear();
                    }

                }
            }
            else
            {
                if(!userRepo.CheckInt(uxUpdatePhonenumberTextBox.Text)) uxUpdatePhonenumberTextBox.BackColor = Color.LightCoral;
                if(!userRepo.CheckInt(uxUpdateUserIDTextBox.Text)) uxUpdateUserIDTextBox.BackColor = Color.LightCoral;
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
                uxAddFirstNameTextBox.BackColor = Color.White;
                uxAddLastNameTextBox.BackColor = Color.White;
                uxAddPhoneTextBox.BackColor = Color.White;
            }
            else uxCreateUserButton.Enabled = false;
        }

        private void uxAddLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxAddFirstNameTextBox.Text.Trim().Length > 0 && uxAddLastNameTextBox.Text.Trim().Length > 0 && uxAddPhoneTextBox.Text.Trim().Length > 0)
            {
                uxCreateUserButton.Enabled = true;
                uxAddFirstNameTextBox.BackColor = Color.White;
                uxAddLastNameTextBox.BackColor = Color.White;
                uxAddPhoneTextBox.BackColor = Color.White;
            }
            else uxCreateUserButton.Enabled = false;
        }

        private void uxAddPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxAddFirstNameTextBox.Text.Trim().Length > 0 && uxAddLastNameTextBox.Text.Trim().Length > 0 && uxAddPhoneTextBox.Text.Trim().Length > 0)
            {
                uxCreateUserButton.Enabled = true;
                uxAddFirstNameTextBox.BackColor = Color.White;
                uxAddLastNameTextBox.BackColor = Color.White;
                uxAddPhoneTextBox.BackColor = Color.White;

            }
            else uxCreateUserButton.Enabled = false;
        }

        private void uxUpdateUserIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxUpdateUserIDTextBox.Text.Trim().Length > 0 && uxUpdatePhonenumberTextBox.Text.Trim().Length > 0 )
            {
                uxUpdateUserButton.Enabled = true;
                uxUpdateUserIDTextBox.BackColor = Color.White;
                uxUpdatePhonenumberTextBox.BackColor = Color.White;
            }
            else uxUpdateUserButton.Enabled = false;

        }

        private void uxUpdatePhonenumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxUpdateUserIDTextBox.Text.Trim().Length > 0 && uxUpdatePhonenumberTextBox.Text.Trim().Length > 0)
            {
                uxUpdateUserButton.Enabled = true;
                uxUpdateUserIDTextBox.BackColor = Color.White;
                uxUpdatePhonenumberTextBox.BackColor = Color.White;
            }
            else uxUpdateUserButton.Enabled = false;

        }

        private void uxFetchUserIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxFetchUserIDTextBox.Text.Trim().Length > 0)
            {
                uxFetchButton.Enabled = true;
                uxFetchUserIDTextBox.BackColor = Color.White;
            }
            else uxFetchButton.Enabled = false;

        }

        private void uxDelUserIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxDelUserIDTextBox.Text.Trim().Length > 0)
            {
                uxDeleteButton.Enabled = true;
                uxDelUserIDTextBox.BackColor = Color.White;
            }
            else uxDeleteButton.Enabled = false;
           
        }

        private void uxGetPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxGetPhoneTextBox.Text.Trim().Length > 0)
            {
                uxGetButton.Enabled = true;
                uxGetPhoneTextBox.BackColor = Color.White;
            }
            else uxGetButton.Enabled = false;
        }

        private void uxFetchPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
