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


        private TransactionScope transaction;

        public Asset()
        {
            general = new SqlGeneralQueryRepository(connectionString);
            question = new SqlQuestionQueryRepository(connectionString);
            transaction = new TransactionScope();
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
    }
}
