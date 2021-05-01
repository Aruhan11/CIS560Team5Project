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


            if (uxUpdateCreatorIDTextBox.Text != "" && !uxUpdateCreatorIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxUpdateCreatorIDTextBox.Text != "0")
            {

                int creataorID = Convert.ToInt32(uxUpdateCreatorIDTextBox.Text);

                List<int> creatorTypeIDs = new List<int>();

                if (uxAuthorCheckBox.Checked) { creatorTypeIDs.Add(1); }
                if (uxProducerCheckBox.Checked) { creatorTypeIDs.Add(2); }
                if (uxProducerCheckBox.Checked) { creatorTypeIDs.Add(3); }
                if (creatorRepo.FetchCreator(creataorID) == null)
                {
                    uxUpdateCreatorIDTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("CreatorID does not exist", "Invalid Input"); 
                }
                else
                {
                    foreach (int creatorTypeID in creatorTypeIDs)
                    {
                        creatorRepo.UpdateCreator(creataorID, creatorTypeID);
                    }

                    MessageBox.Show("Updated Creator", "Update");
                }
            }
            else
            {
                if (uxUpdateCreatorIDTextBox.Text == "" || uxUpdateCreatorIDTextBox.Text.Any(c => Char.IsLetter(c))) uxUpdateCreatorIDTextBox.BackColor = Color.LightCoral;
                if (!uxAuthorCheckBox.Checked && !uxProducerCheckBox.Checked && !uxDeveloperCheckBox.Checked) 
                {
                    uxAuthorCheckBox.BackColor = Color.LightCoral;
                    uxProducerCheckBox.BackColor = Color.LightCoral;
                    uxDeveloperCheckBox.BackColor = Color.LightCoral;
                }

                MessageBox.Show("Invalid CreatorID", "Invalid Input");
            }

            // fetch creatorcreatortype

        }

        private void uxFetchButton_Click(object sender, EventArgs e)
        {
            if (uxFetchCreatorIDTextBox.Text != "" && !uxFetchCreatorIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxFetchCreatorIDTextBox.Text != "0")
            {
                int creatorID = Convert.ToInt32(uxFetchCreatorIDTextBox.Text);
                var fetchedCreator = creatorRepo.FetchCreator(creatorID);
                if (fetchedCreator == null) 
                {
                    uxFetchCreatorIDTextBox.BackColor = Color.LightCoral;
                    MessageBox.Show("CreatorID does not exist", "Invalid Input");
                }
                else
                {
                    uxFirstNameTextBox.Text = fetchedCreator.FirstName.ToString();
                    uxLastNameTextBox.Text = fetchedCreator.LastName.ToString();
                    uxCompanyTextBox.Text = fetchedCreator.CompanyName.ToString();
                }
            }
            else
            {
                uxFetchCreatorIDTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid CreatorID", "Invalid Input");

            }

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
            if (uxCreatorCreatorIDTextBox.Text != "" && !uxCreatorCreatorIDTextBox.Text.Any(c => Char.IsLetter(c)) && uxCreatorCreatorIDTextBox.Text != "0")
            {
                int creatorID = Int32.Parse(uxCreatorCreatorIDTextBox.Text);
                var list = creatorRepo.FetchProductionsOfCreator(creatorID);
                uxFetchProductionsByCreatorGridView.DataSource = list;
            }
            else
            {
                uxCreatorCreatorIDTextBox.BackColor = Color.LightCoral;
                MessageBox.Show("Invalid CreatorID", "Invalid Input");
            }
        }

        private void UpdateCreator_EventListener(object sender, EventArgs e)
        {
            if (uxUpdateCreatorIDTextBox.Text.Trim().Length > 0 && (uxAuthorCheckBox.Checked || uxProducerCheckBox.Checked || uxProducerCheckBox.Checked))
            {
                uxUpdateButton.Enabled = true;
                uxUpdateCreatorIDTextBox.BackColor = Color.White;
                uxAuthorCheckBox.BackColor = Color.White;
                uxProducerCheckBox.BackColor = Color.White;
                uxDeveloperCheckBox.BackColor = Color.White;

            }
            else uxUpdateButton.Enabled = false;


        }

        private void uxFetchCreatorIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxFetchCreatorIDTextBox.Text.Trim().Length > 0)
            {
                uxFetchCreatorIDTextBox.BackColor = Color.White;
                uxFetchButton.Enabled = true;
            }
            else uxFetchButton.Enabled = false;
        }

        private void uxCreatorCreatorIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxCreatorCreatorIDTextBox.Text.Trim().Length > 0)
            {
                uxCreatorCreatorIDTextBox.BackColor = Color.White;
                uxFetchProductionsByCreatorButton.Enabled = true;
            }
            else uxFetchProductionsByCreatorButton.Enabled = false;
        }
    }
}
