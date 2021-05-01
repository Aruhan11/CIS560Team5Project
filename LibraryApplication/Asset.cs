using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using LibraryData;
using System.Linq;

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
            uxAddTypeDDL.SelectedIndex = 0;
        }

     

        private void uxFetchSituationOfAssetButton_Click(object sender, EventArgs e)
        {
            // uxFetchSituationOfAssetGridView
            if (uxAssetAssetIDTextBox.Text != "" && !uxAssetAssetIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxAssetAssetIDTextBox.Text != "0")
            {
                int assetId = Convert.ToInt32(uxAssetAssetIDTextBox.Text);
                var list = assetQ.FetchSituationOfAsset(assetId);
                uxFetchSituationOfAssetGridView.DataSource = list;
            }
            else
            {
                uxAssetAssetIDTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid AssetID", "Invalid Input");
            }

        }

        private void uxGetPossibleAssetsButton_Click(object sender, EventArgs e)
        {
            // uxGetPossibleAssetsGridView
            if (uxAssetAssetNameTextBox.Text != "" && !uxAssetAssetNameTextBox.Text.Any(c => Char.IsDigit(c)))
            {
                string assetName = uxAssetAssetNameTextBox.Text;
                var list = assetQ.GetPossibleAssets(assetName);
                uxGetPossibleAssetsGridView.DataSource = list;
            }
            else
            {
                uxAssetAssetNameTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid AssetName", "Invalid Input");
            }
        }



        private void uxAddAssetButton_Click_1(object sender, EventArgs e)
        {
            if ((uxAddNameTextBox.Text != "" && !uxAddNameTextBox.Text.Any(c => Char.IsDigit(c)))
                && (uxAddStockTextBox.Text != "" && !uxAddStockTextBox.Text.Any(c => Char.IsLetter(c)) && uxAddStockTextBox.Text !="0")
                &&(uxAddFNameTextBox.Text != "" && !uxAddFNameTextBox.Text.Any(c => Char.IsDigit(c)))
                &&(uxAddLNameTextBox.Text != "" && !uxAddLNameTextBox.Text.Any(c => Char.IsDigit(c)))
                && (uxAddCompanyTextBox.Text != "" && !uxAddCompanyTextBox.Text.Any(c => Char.IsDigit(c)))
                &&(uxAddFantasy.Checked || uxAddRomance.Checked || uxAddMystery.Checked || uxAddHorror.Checked || uxAddMemoir.Checked ||
                uxAddCooking.Checked || uxAddHealth.Checked || uxAddHistory.Checked || uxAddTravel.Checked || uxAddChildren.Checked || uxAddAdventure.Checked ||
                uxAddAction.Checked || uxAddRPG.Checked || uxAddHumor.Checked || uxAddSport.Checked || uxAddSimulation.Checked || uxAddMMO.Checked)) 
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

            else {
                if (uxAddNameTextBox.Text == "" || uxAddNameTextBox.Text.Any(c => Char.IsDigit(c))) uxAddNameTextBox.BackColor = Color.LightCoral;
                if (uxAddStockTextBox.Text == "" || uxAddStockTextBox.Text.Any(c => Char.IsLetter(c))) uxAddStockTextBox.BackColor = Color.LightCoral;
                if (uxAddFNameTextBox.Text == "" || uxAddFNameTextBox.Text.Any(c => Char.IsDigit(c))) uxAddFNameTextBox.BackColor = Color.LightCoral;
                if (uxAddLNameTextBox.Text == "" || uxAddLNameTextBox.Text.Any(c => Char.IsDigit(c))) uxAddLNameTextBox.BackColor = Color.LightCoral;
                if (uxAddCompanyTextBox.Text == "" || uxAddCompanyTextBox.Text.Any(c => Char.IsDigit(c))) uxAddCompanyTextBox.BackColor = Color.LightCoral;
                if(!(uxAddFantasy.Checked || uxAddRomance.Checked || uxAddMystery.Checked || uxAddHorror.Checked || uxAddMemoir.Checked ||
                uxAddCooking.Checked || uxAddHealth.Checked || uxAddHistory.Checked || uxAddTravel.Checked || uxAddChildren.Checked || uxAddAdventure.Checked ||
                uxAddAction.Checked || uxAddRPG.Checked || uxAddHumor.Checked || uxAddSport.Checked || uxAddSimulation.Checked || uxAddMMO.Checked))
                {
                    uxAddFantasy.BackColor = Color.LightCoral;
                    uxAddRomance.BackColor = Color.LightCoral;
                    uxAddMystery.BackColor = Color.LightCoral;
                    uxAddHorror.BackColor = Color.LightCoral;
                    uxAddMemoir.BackColor = Color.LightCoral;
                    uxAddCooking.BackColor = Color.LightCoral;
                    uxAddHealth.BackColor = Color.LightCoral;
                    uxAddHistory.BackColor = Color.LightCoral;
                    uxAddTravel.BackColor = Color.LightCoral;
                    uxAddChildren.BackColor = Color.LightCoral;
                    uxAddAdventure.BackColor = Color.LightCoral;
                    uxAddAction.BackColor = Color.LightCoral;
                    uxAddRPG.BackColor = Color.LightCoral;
                    uxAddHumor.BackColor = Color.LightCoral;
                    uxAddSport.BackColor = Color.LightCoral;
                    uxAddSimulation.BackColor = Color.LightCoral;
                    uxAddMMO.BackColor = Color.LightCoral;

                }
                MessageBox.Show("Invalid Input", "Invalid Input");
            }

        }

        private void uxRetriveButton_Click(object sender, EventArgs e)
        {
            
            var list = assetQ.RetrieveAssets();
            uxRetriveGridView.DataSource = list;

        }

        private void uxUpdateButton_Click(object sender, EventArgs e)
        {
            if ((uxUpAssetIDTextBox.Text != "" && !uxUpAssetIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxUpAssetIDTextBox.Text != "0") && (uxUpStockTextBox.Text != "" && !uxUpStockTextBox.Text.Any(c => Char.IsLetter(c)) && uxUpStockTextBox.Text != "0"))
            {
                int assetID = Convert.ToInt32(uxUpAssetIDTextBox.Text);
                int stock = Convert.ToInt32(uxUpStockTextBox.Text);
                assetQ.UpdateAsset(assetID, stock);
                var check = assetQ.FetchAsset(assetID);
                if (check == null)
                {
                    uxUpAssetIDTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("Invalid AssetID", "Invalid Input");
                }
                else
                {
                    if (check.Stock == stock) MessageBox.Show(assetID + " stock has been updated!", "Stock Updated");
                }
            }
            else
            {
                if(uxUpAssetIDTextBox.Text.Any(c => Char.IsLetter(c))) uxUpAssetIDTextBox.BackColor = Color.LightCoral;
                if (uxUpStockTextBox.Text.Any(c => Char.IsLetter(c))) uxUpStockTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Input", "Invalid Input");
                uxUpAssetIDTextBox.Text = "";
                uxUpStockTextBox.Text = "";

            }
        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {
            if (uxFetchAssetIDTextBox.Text != "" && !uxFetchAssetIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxFetchAssetIDTextBox.Text != "0")
            {
                int assetId = Convert.ToInt32(uxFetchAssetIDTextBox.Text);
                var assets = assetQ.FetchAsset(assetId);
                if(assets == null)
                {
                    uxFetchAssetIDTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("Invalid assetID", "Invalid Input");
                    
                }
                else
                {
                    uxFetchNameTextBox.Text = assets.Name;
                    uxFetchTypeTextBox.Text = assets.AssetTypeID.ToString();
                    uxFetchReleaseDateTextBox.Text = assets.ReleaseDate.ToString();
                    uxFetchCreatorIDTextBox.Text = assets.CreatorID.ToString();
                    uxFetchStockTextBox.Text = assets.Stock.ToString();

                }

            }
            else
            {
                uxFetchAssetIDTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid Input", "Invalid Input");
                uxFetchAssetIDTextBox.Text = "";

            }
        }

        private void uxFetchAssetIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxFetchAssetIDTextBox.Text.Trim().Length > 0)
            {
                uxFetchButton.Enabled = true;
                uxFetchAssetIDTextBox.BackColor = Color.White;
            }
            else uxFetchButton.Enabled = false;
        }

        private void uxUpAssetIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxUpAssetIDTextBox.Text.Trim().Length > 0 && uxUpStockTextBox.Text.Trim().Length > 0)
            {
                uxUpdateButton.Enabled = true;
                uxUpAssetIDTextBox.BackColor = Color.White;
                uxUpStockTextBox.BackColor = Color.White;
            }
            else uxUpdateButton.Enabled = false;
        }

        private void uxUpStockTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxUpAssetIDTextBox.Text.Trim().Length > 0 && uxUpStockTextBox.Text.Trim().Length > 0)
            {
                uxUpdateButton.Enabled = true;
                uxUpStockTextBox.BackColor = Color.White;
                uxUpAssetIDTextBox.BackColor = Color.White;
            }
            else uxUpdateButton.Enabled = false;
        }

        private void uxAssetAssetIDTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (uxAssetAssetIDTextBox.Text.Trim().Length > 0 )
            {
                uxFetchSituationOfAssetButton.Enabled = true;
                uxAssetAssetIDTextBox.BackColor = Color.White;

            }
            else uxFetchSituationOfAssetButton.Enabled = false;
        }

        private void uxAssetAssetNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxAssetAssetNameTextBox.Text.Trim().Length > 0)
            {
                uxGetPossibleAssetsButton.Enabled = true;
                uxAssetAssetNameTextBox.BackColor = Color.White;

            }
            else uxGetPossibleAssetsButton.Enabled = false;
        }

        private void InsetAsset_Changed(object sender, EventArgs e)
        {
            if (uxAddStockTextBox.Text.Trim().Length > 0 && uxAddNameTextBox.Text.Trim().Length > 0 && uxAddStockTextBox.Text.Trim().Length > 0
                && uxAddFNameTextBox.Text.Trim().Length > 0 && uxAddLNameTextBox.Text.Trim().Length > 0 && uxAddCompanyTextBox.Text.Trim().Length > 0 && (uxAddFantasy.Checked || uxAddRomance.Checked || uxAddMystery.Checked || uxAddHorror.Checked || uxAddMemoir.Checked ||
                uxAddCooking.Checked || uxAddHealth.Checked || uxAddHistory.Checked || uxAddTravel.Checked || uxAddChildren.Checked || uxAddAdventure.Checked ||
                uxAddAction.Checked || uxAddRPG.Checked || uxAddHumor.Checked || uxAddSport.Checked || uxAddSimulation.Checked || uxAddMMO.Checked))
            {
                uxAddAssetButton.Enabled = true;
                uxAddStockTextBox.BackColor = Color.White;
                uxAddNameTextBox.BackColor = Color.White;
                uxAddStockTextBox.BackColor = Color.White;
                uxAddFNameTextBox.BackColor = Color.White;
                uxAddLNameTextBox.BackColor = Color.White;
                uxAddCompanyTextBox.BackColor = Color.White;
            }
            else uxAddAssetButton.Enabled = false;
        }
    }

     
    
}
