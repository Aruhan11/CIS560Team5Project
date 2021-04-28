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
    public partial class Important : Form
    {


        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";
        private IComplexQueryRepository complex;

        public Important()
        {
            complex = new SqlComplexQueryRepository(connectionString);
            InitializeComponent();
        }

        private void uxTopTenButtons_Click(object sender, EventArgs e)
        {
            var list = complex.TopTenAssetsStillAvaliable();
            uxTopTenGridView.DataSource = list;
        }

        private void uxRankAssetByTypeButton_Click(object sender, EventArgs e)
        {
            var list = complex.RankingAssetByAssetType();
            uxRankAssetByTypeGridView.DataSource = list;
        }

        private void uxRankCreatorByUserButton_Click(object sender, EventArgs e)
        {
            var list = complex.RankingCreatorByUser();
            uxRankCreatorByUserGridView.DataSource = list;
        }

        private void uxRankCreatorByTypeButton_Click(object sender, EventArgs e)
        {
            var list = complex.RankingCreatorByAssetType();
            uxRankCreatorByAssetGridView.DataSource = list;
        }
    }
}
