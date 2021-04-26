using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using LibraryData;

namespace LibraryProject
{
    public partial class User : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";
        private IGeneralQueryRepository general;
        private IQuestionQueryRepository question;
        private TransactionScope transaction;


        public User()
        {
            general = new SqlGeneralQueryRepository(connectionString);
            question = new SqlQuestionQueryRepository(connectionString);
            transaction = new TransactionScope();
            InitializeComponent();
        }

        private void uxCreateUserButton_Click(object sender, EventArgs e)
        {
            var user = general.CreateUser(uxAddFirstNameTextBox.Text, uxAddLastNameTextBox.Text, uxAddPhoneTextBox.Text);
            if  (user != null) MessageBox.Show(user.FirstName + user.LastName + " have been added!", "User Added");
        }

    

        private void uxDeleteButton_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBox9.Text);

            general.DeleteUser(userid);
            var checkDel = question.FetchUser(userid);
            if(checkDel.IsDeleted == 1) MessageBox.Show(userid + " have been deleted", "User Added");
            textBox9.Clear();
        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(textBox1.Text);
            var fetchedUser = question.FetchUser(userId);
            textBox4.Text = fetchedUser.FirstName.ToString();
            textBox3.Text = fetchedUser.LastName.ToString();
            textBox2.Text = fetchedUser.PhoneNumber.ToString();
        }

        private void uxGetButton_Click(object sender, EventArgs e)
        {
            string phone = textBox8.Text;
            var user = question.GetUser(phone);
            textBox7.Text = user.UserID.ToString();
            textBox6.Text = user.FirstName.ToString();
            textBox5.Text = user.LastName.ToString();
        }
    }
}
