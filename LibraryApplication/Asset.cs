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
    public partial class Asset : Form
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";
       
        private IAssetQueryRepository assetQ;
        


        public Asset()
        {

            assetQ = new SqlAssetQueryRepository(connectionString);
            InitializeComponent();


            uxAddTypeDDL.Items.Add("Book");
            uxAddTypeDDL.Items.Add("Audio Book");
            uxAddTypeDDL.Items.Add("Movie");
            uxAddTypeDDL.Items.Add("Game");
        }

     

        private void uxFetchSituationOfAssetButton_Click(object sender, EventArgs e)
        {
            // uxFetchSituationOfAssetGridView
            int assetId = Convert.ToInt32(uxAssetAssetIDTextBox.Text);
            var list = assetQ.FetchSituationOfAsset(assetId);
            uxFetchSituationOfAssetGridView.DataSource = list;

        }

        private void uxGetPossibleAssetsButton_Click(object sender, EventArgs e)
        {
            // uxGetPossibleAssetsGridView
            string assetName = uxAssetAssetNameTextBox.Text;
            var list = assetQ.GetPossibleAssets(assetName);
            uxGetPossibleAssetsGridView.DataSource = list;
        }



        private void uxAddAssetButton_Click_1(object sender, EventArgs e)
        {
            string assetName = uxAddNameTextBox.Text;
            int assetType = 0;


            if (uxAddTypeDDL.Text == "Book")
            {
                assetType = 1;
            }
            else if (uxAddTypeDDL.Text == "Audio Book")
            {
                assetType = 2;
            }
            else if (uxAddTypeDDL.Text == "Movie")
            {
                assetType = 3;
            }
            else if (uxAddTypeDDL.Text == "Game")
            {
                assetType = 4;
            }


            DateTime datetime = uxAddDate.Value;
            string firstname = uxAddFNameTextBox.Text;
            string lastname = uxAddLNameTextBox.Text;
            string company = uxAddCompanyTextBox.Text;
            int stock = Convert.ToInt32(uxAddStockTextBox.Text);

            List<int> categorylist = new List<int>();

            if (uxAddFantasy.Checked) { categorylist.Add(1); }
            if (uxAddRomance.Checked) { categorylist.Add(2); }
            if (uxAddMystery.Checked) { categorylist.Add(3); }
            if (uxAddHorror.Checked) { categorylist.Add(4); }
            if (uxAddMemoir.Checked) { categorylist.Add(5); }
            if (uxAddCooking.Checked) { categorylist.Add(6); }
            if (uxAddHealth.Checked) { categorylist.Add(7); }
            if (uxAddHistory.Checked) { categorylist.Add(8); }
            if (uxAddTravel.Checked) { categorylist.Add(9); }
            if (uxAddHumor.Checked) { categorylist.Add(10); }
            if (uxAddChildren.Checked) { categorylist.Add(11); }
            if (uxAddAdventure.Checked) { categorylist.Add(12); }
            if (uxAddAction.Checked) { categorylist.Add(13); }
            if (uxAddRPG.Checked) { categorylist.Add(14); }
            if (uxAddSport.Checked) { categorylist.Add(15); }
            if (uxAddSimulation.Checked) { categorylist.Add(16); }
            if (uxAddMMO.Checked) { categorylist.Add(17); }

            //List<LibraryData.Model.Asset> assets = new List<LibraryData.Model.Asset>();

            var creator = assetQ.InsertCreator(firstname, lastname, company);
            int creatorID = creator.CreatorID;

            var asset = assetQ.InsertAsset(assetName, assetType, creatorID, datetime, stock);
            int assetID = asset.AssetID;

            foreach (int categoryID in categorylist)
            {
                assetQ.InsertAssetCategory(assetID, categoryID);
            }



            if (creator != null & asset != null) MessageBox.Show(asset.Name + " have been added!", "Asset Added");

        }

        private void uxRetriveButton_Click(object sender, EventArgs e)
        {
            
            var list = assetQ.RetrieveAssets();
            uxRetriveGridView.DataSource = list;

        }

        private void uxUpdateButton_Click(object sender, EventArgs e)
        {
            int assetID = Convert.ToInt32(textBox1.Text);
            int stock = Convert.ToInt32(textBox2.Text);
            assetQ.UpdateAsset(assetID, stock);
            var check = assetQ.FetchAsset(assetID);
            if (check.Stock == stock) MessageBox.Show(assetID + " stock has been updated!", "Stock Updated");
        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {
            int assetId = Convert.ToInt32(uxFetchAssetIDTextBox.Text);
            var assets = assetQ.FetchAsset(assetId);

            uxFetchNameTextBox.Text = assets.Name;
            uxFetchTypeTextBox.Text = assets.AssetTypeID.ToString();
            uxFetchReleaseDateTextBox.Text = assets.ReleaseDate.ToString();
            uxFetchCreatorIDTextBox.Text = assets.CreatorID.ToString();
            uxFetchStockTextBox.Text = assets.Stock.ToString();
        }
    
    
    
    }

     
    
}
