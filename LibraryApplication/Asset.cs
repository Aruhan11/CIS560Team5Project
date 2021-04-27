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
        private IGeneralQueryRepository general;
        private IQuestionQueryRepository question;


        public Asset()
        {
            general = new SqlGeneralQueryRepository(connectionString);
            question = new SqlQuestionQueryRepository(connectionString);
            InitializeComponent();
        }

        private void uxFetchCheckoutHistoryButton_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(uxAssetUserIDTextBox.Text);
            IReadOnlyList <LibarayData.Model.CheckOutHistory> list = question.FetchCheckOutHistory(userId);
            foreach (LibarayData.Model.CheckOutHistory coh in list)
            {
                uxFetchCheckoutHistoryListBox.Items.Add(coh.ToString());
            }
        }

        private void uxFetchSituationOfAssetButton_Click(object sender, EventArgs e)
        {
            int assetId = Convert.ToInt32(uxAssetAssetIDTextBox.Text);
            IReadOnlyList<LibarayData.Model.SituationOfAsset> list = question.FetchSituationOfAsset(assetId);
            foreach (LibarayData.Model.SituationOfAsset soa in list)
            {
                uxFetchSituationOfAssetListBox.Items.Add(soa.ToString());
            }
        }

        private void uxGetPossibleAssetsButton_Click(object sender, EventArgs e)
        {
            string assetName = uxAssetAssetNameTextBox.Text.ToString();
            IReadOnlyList<LibarayData.Model.PossibleAssets> list = question.GetPossibleAssets(assetName);
            foreach (LibarayData.Model.PossibleAssets pa in list)
            {
                uxGetPossibleAssetsListBox.Items.Add(pa.ToString());
            }
        }

        private void uxAddAssetButton_Click(object sender, EventArgs e)
        {
            string assetName = uxAddNameTextBox.Text;
            int assetType = 0;

            if (uxBookradioButton.Checked)
            {
                assetType = 1;
            }
            else if (uxAudioradioButton.Checked)
            {
                assetType = 2;
            }
            else if (uxMobieradioButton.Checked)
            {
                assetType = 3;
            }
            else if (uxGameradioButton.Checked)
            {
                assetType = 4;
            }

            DateTime datetime = uxAddDate.Value;
            string firstname = uxAddFNameTextBox.Text;
            string lastname = uxAddLNameTextBox.Text;
            string company = uxAddCompanyTextBox.Text;
            int stock = Convert.ToInt32(uxAddStock.Text);

            List<int> categorylist = new List<int>();

            if (uxAddFantasy.Checked) { categorylist.Add(1);}
            if (uxAddRomance.Checked) { categorylist.Add(2); }
            if (uxAddMystery.Checked) { categorylist.Add(3); }
            if (uxAddHorror.Checked) {categorylist.Add(4);}
            if (uxAddMemoir.Checked) {categorylist.Add(5);}
            if (uxAddCooking.Checked) {categorylist.Add(6);}
            if (uxAddHealth.Checked){ categorylist.Add(7);}
            if (uxAddHistory.Checked) { categorylist.Add(8);}
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

            var creator = general.InsertCreator(firstname, lastname, company);
            int creatorID = creator.CreatorID;

            var asset = general.InsertAsset(assetName, assetType, creatorID, datetime, stock);
            int assetID = asset.AssetID;

            foreach (int categoryID in categorylist)
            {
                var assetcategory = general.InsertAssetCategory(assetID, categoryID);
            }

           

            if (creator != null & asset != null) MessageBox.Show(asset.Name + " have been added!", "Asset Added");


        }
    }
}
