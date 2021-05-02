using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryData;

namespace LibraryApplication
{
    public partial class CheckOutAsset : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";
        private ICheckOutAssetQueryRepository checkOutAssetRepo;
        private IUserQueryRepository userRepo;
        private ILibrarianQueryRepository librarianRepo;
        private IAssetQueryRepository assetRepo;
        
        public CheckOutAsset()
        {
            checkOutAssetRepo = new SqlCheckOutAssetQueryRepository(connectionString);
            userRepo = new SqlUserQueryRepository(connectionString);
            librarianRepo = new SqlLibrarianQueryRepository(connectionString);
            assetRepo = new SqlAssetQueryRepository(connectionString);

            InitializeComponent();
        }

        private void uxCreateCheckOutAssetButton_Click(object sender, EventArgs e)
        {

            if ((uxCreateAssetIDTextBox.Text != "" && !uxCreateAssetIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxCreateAssetIDTextBox.Text != "0")
                && (uxCreateUserIDTextBox.Text != "" && !uxCreateUserIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxCreateUserIDTextBox.Text != "0")
                && (uxCreateLibrarianIDTextBox.Text != "" && !uxCreateLibrarianIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxCreateLibrarianIDTextBox.Text != "0"))
            {
                int assetID = Convert.ToInt32(uxCreateAssetIDTextBox.Text);
                int userID = Convert.ToInt32(uxCreateUserIDTextBox.Text);
                int librarianID = Convert.ToInt32(uxCreateLibrarianIDTextBox.Text);
                if (assetRepo.FetchAsset(assetID) == null) 
                {
                    uxCreateAssetIDTextBox.BackColor = Color.LightCoral;
                }
                if (userRepo.FetchUser(userID) == null)
                {
                    uxCreateUserIDTextBox.BackColor = Color.LightCoral;
                }
                if (librarianRepo.FetchLibrarian(librarianID) == null)
                {
                    uxCreateLibrarianIDTextBox.BackColor = Color.LightCoral;
                }
                if(assetRepo.FetchAsset(assetID) == null 
                    || userRepo.FetchUser(userID) == null 
                    || librarianRepo.FetchLibrarian(librarianID) == null)
                    MessageBox.Show("Invalid Input", "Invalid Input");
                else
                {
                    var checkOutAsset = checkOutAssetRepo.CreateCheckOutAsset(assetID, userID, librarianID);
                    if (checkOutAsset != null) MessageBox.Show(checkOutAsset.CheckOutAssetID + " has been added!", "CheckOutAsset Added");
                }
            }
            else
            {
                if (uxCreateAssetIDTextBox.Text == "" || uxCreateAssetIDTextBox.Text.Any(c => Char.IsLetter(c)) || uxCreateAssetIDTextBox.Text == "0")
                    uxCreateAssetIDTextBox.BackColor = Color.LightCoral;
                if (uxCreateUserIDTextBox.Text == "" || uxCreateUserIDTextBox.Text.Any(c => Char.IsLetter(c)) || uxCreateUserIDTextBox.Text == "0")
                    uxCreateUserIDTextBox.BackColor = Color.LightCoral;
                if (uxCreateLibrarianIDTextBox.Text == "" || uxCreateLibrarianIDTextBox.Text.Any(c => Char.IsLetter(c)) || uxCreateLibrarianIDTextBox.Text == "0")
                    uxCreateLibrarianIDTextBox.BackColor = Color.LightCoral;

                MessageBox.Show("Invalid Input", "Invalid Input");
            }


        }

        private void uxUpdateButton_Click(object sender, EventArgs e)
        {
            if((uxUpdateTextBox.Text != "" && !uxUpdateTextBox.Text.Any(c => Char.IsLetter(c)) && uxUpdateTextBox.Text != "0")){
                int checkoutID = Convert.ToInt32(uxUpdateTextBox.Text);

                checkOutAssetRepo.UpdateCheckOutAsset(checkoutID);
                var check = checkOutAssetRepo.FetchCheckOutAsset(checkoutID);
                if (check == null)
                {
                    uxUpdateTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("CheckOutAssetID does not exist", "Invalid Input");
                }
                else
                {
                    if (check.IsReturned == 1) MessageBox.Show(checkoutID + " is returned", "CheckOutAsset Returned");
                    uxUpdateTextBox.Clear();
                }

            }
            else
            {
                uxUpdateTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Input", "Invalid Input");
            }

        }

        private void uxFetchCheckOutAssetButton_Click(object sender, EventArgs e)
        {
            if ((uxFetchCheckOutAssetIDTextBox.Text != "" && !uxFetchCheckOutAssetIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxFetchCheckOutAssetIDTextBox.Text != "0"))
            {
                int checkOutID = Convert.ToInt32(uxFetchCheckOutAssetIDTextBox.Text);
                var fetchedCheckOut = checkOutAssetRepo.FetchCheckOutAsset(checkOutID);
                if(fetchedCheckOut != null)
                {
                    uxFetchAssetIDTextBox.Text = fetchedCheckOut.AssetID.ToString();
                    uxFetchUserIDTextBox.Text = fetchedCheckOut.UserID.ToString();
                    uxFetchLibrarianIDTextBox.Text = fetchedCheckOut.LibrarianID.ToString();
                    uxFetchCheckDateTextBox.Text = fetchedCheckOut.CheckOutDate.ToString();
                    uxFetchReturnDateTextBox.Text = fetchedCheckOut.ReturnByDate.ToString();
                    uxFetchIsReturnTextBox.Text = fetchedCheckOut.IsReturned.ToString();
                }
                else
                {
                    uxFetchCheckOutAssetIDTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("CheckOutAssetID does not exist", "Invalid Input");
                }

            }
            else
            {
                uxFetchCheckOutAssetIDTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Input", "Invalid Input");
            }
        }

        private void uxRetriveAllCheckOutAssetsButton_Click(object sender, EventArgs e)
        {
            var list = checkOutAssetRepo.RetrieveCheckOutAssets();

            uxRetriveGridView.DataSource = list;
        }

        private void uxGetHistoryOfUserButton_Click(object sender, EventArgs e)
        {
            if ((uxGetHistoryUserIDTextBox.Text != "" && !uxGetHistoryUserIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxGetHistoryUserIDTextBox.Text != "0"))
            {
                int userID = Convert.ToInt32(uxGetHistoryUserIDTextBox.Text);
                var list = checkOutAssetRepo.FetchCheckOutHistory(userID);

                uxCheckOutHistoryGridView.DataSource = list;
            }
            else
            {
                uxGetHistoryUserIDTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Input", "Invalid Input");
            }
        }

        private void CreateCheckoutAsset_EventListener(object sender, EventArgs e)
        {
            if (uxCreateAssetIDTextBox.Text.Trim().Length > 0 
                && uxCreateUserIDTextBox.Text.Trim().Length > 0
                && uxCreateLibrarianIDTextBox.Text.Trim().Length > 0)
            {
                uxCreateCheckOutAssetButton.Enabled = true;
                uxCreateAssetIDTextBox.BackColor = Color.White;
                uxCreateUserIDTextBox.BackColor = Color.White;
                uxCreateLibrarianIDTextBox.BackColor = Color.White;

            }
            else uxCreateCheckOutAssetButton.Enabled = false;
        }

        private void uxUpdateTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxUpdateTextBox.Text.Trim().Length > 0)
            {
                uxUpdateTextBox.BackColor = Color.White;
                uxUpdateButton.Enabled = true;
            }
            else uxUpdateButton.Enabled = false;
        }

        private void uxFetchCheckOutAssetIDTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (uxFetchCheckOutAssetIDTextBox.Text.Trim().Length > 0)
            {
                uxFetchCheckOutAssetIDTextBox.BackColor = Color.White;
                uxFetchCheckOutAssetButton.Enabled = true;
            }
            else uxFetchCheckOutAssetButton.Enabled = false;

        }

        private void uxGetHistoryUserIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxGetHistoryUserIDTextBox.Text.Trim().Length > 0)
            {
                uxGetHistoryUserIDTextBox.BackColor = Color.White;
                uxGetHistoryOfUserButton.Enabled = true;
            }
            else uxGetHistoryOfUserButton.Enabled = false;
        }
    }
}
