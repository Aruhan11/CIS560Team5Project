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
    public partial class Creator : Form
    {

        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private ICreatorQueryRepository creatorRepo;


        public Creator()
        {

            creatorRepo = new SqlCreatorQueryRepository(connectionString);
            InitializeComponent();
            uxCreatorTypeDDL.Items.Add("Author");
            uxCreatorTypeDDL.Items.Add("Producer");
            uxCreatorTypeDDL.Items.Add("Developer");
            uxCreatorTypeDDL.SelectedIndex = 0;


        }


        private void uxUpdateButton_Click(object sender, EventArgs e)
        {
            int creataorID = Convert.ToInt32(uxUpdateCreatorIDTextBox.Text);

            List<int> creatorTypeIDs = new List<int>();

            if (uxAuthorCheckBox.Checked) { creatorTypeIDs.Add(1); }
            if (uxProducerCheckBox.Checked) { creatorTypeIDs.Add(2); }
            if (uxProducerCheckBox.Checked) { creatorTypeIDs.Add(3); }

            foreach (int creatorTypeID in creatorTypeIDs)
            {
                creatorRepo.UpdateCreator(creataorID, creatorTypeID);
            }

           // fetch creatorcreatortype

        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {

            int creatorID = Convert.ToInt32(uxFetchCreatorIDTextBox.Text);
            var fetchedCreator = creatorRepo.FetchCreator(creatorID);

            uxFirstNameTextBox.Text = fetchedCreator.FirstName.ToString();
            uxLastNameTextBox.Text = fetchedCreator.LastName.ToString();
            uxCompanyTextBox.Text = fetchedCreator.CompanyName.ToString();
        }

        private void uxRetriveButton_Click(object sender, EventArgs e)
        {
            var list = creatorRepo.RetrieveCreators();

            uxRetriveCreatorsGridView.DataSource = list;
        }

        private void uxGetCreatorByTypeButton_Click(object sender, EventArgs e)
        {
            string selectedItem = uxCreatorTypeDDL.Items[uxCreatorTypeDDL.SelectedIndex].ToString();
            var list = creatorRepo.GetCreatorsByType(selectedItem);
            uxGetCreatorByTypeGridView.DataSource = list;
           
        }

        private void uxFetchProductionsByCreatorButton_Click(object sender, EventArgs e)
        {
            int creatorID = Int32.Parse(uxCreatorCreatorIDTextBox.Text);
            var list = creatorRepo.FetchProductionsOfCreator(creatorID);
            uxFetchProductionsByCreatorGridView.DataSource = list;
        }

       
    }
}
