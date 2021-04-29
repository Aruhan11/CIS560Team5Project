using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibraryData;

namespace LibraryApplication
{
    public partial class CheckOutAsset : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";
        private ICheckOutAssetQueryRepository checkOutAssetRepo;

        public CheckOutAsset()
        {
            checkOutAssetRepo = new SqlCheckOutAssetQueryRepository(connectionString);
            InitializeComponent();
        }

        private void uxCreateCheckOutAssetButton_Click(object sender, EventArgs e)
        {
            int assetID = Convert.ToInt32(uxCreateAssetIDTextBox.Text);
            int userID = Convert.ToInt32(uxCreateUserIDTextBox.Text);
            int librarianID = Convert.ToInt32(uxCreateLibrarianIDTextBox.Text);

            var checkOutAsset = checkOutAssetRepo.CreateCheckOutAsset(assetID, userID, librarianID);
            if (checkOutAsset != null) MessageBox.Show(checkOutAsset.CheckOutAssetID + " have been added!", "CheckOutAsset Added");


        }

        private void uxUpdateButton_Click(object sender, EventArgs e)
        {
            int checkoutID = Convert.ToInt32(uxUpdateTextBox.Text);

            checkOutAssetRepo.UpdateCheckOutAsset(checkoutID);
            var check = checkOutAssetRepo.FetchCheckOutAsset(checkoutID);
            if (check.IsReturned == 1) MessageBox.Show(checkoutID + " have returned", "CheckOutAsset Returned");
            uxUpdateTextBox.Clear();
        }

        private void uxFetchCheckOutAssetButton_Click(object sender, EventArgs e)
        {
            int checkOutID = Convert.ToInt32(uxFetchCheckOutAssetIDTextBox.Text);
            var fetchedCheckOut = checkOutAssetRepo.FetchCheckOutAsset(checkOutID);
            uxFetchAssetIDTextBox.Text = fetchedCheckOut.AssetID.ToString();
            uxFetchUserIDTextBox.Text = fetchedCheckOut.UserID.ToString();       
            uxFetchLibrarianIDTextBox.Text = fetchedCheckOut.LibrarianID.ToString();
            uxFetchCheckDateTextBox.Text = fetchedCheckOut.CheckOutDate.ToString();
            uxFetchReturnDateTextBox.Text = fetchedCheckOut.ReturnByDate.ToString();
            uxFetchIsReturnTextBox.Text = fetchedCheckOut.IsReturned.ToString();
        }

        private void uxRetriveAllCheckOutAssetsButton_Click(object sender, EventArgs e)
        {
            var list = checkOutAssetRepo.RetrieveCheckOutAssets();

            uxRetriveGridView.DataSource = list;
        }

        private void uxGetHistoryOfUserButton_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(uxGetHistoryUserIDTextBox.Text);
            var list = checkOutAssetRepo.FetchCheckOutHistory(userID);

            uxCheckOutHistoryGridView.DataSource = list;
        }
    }
}
