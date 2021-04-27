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

        private IQuestionQueryRepository question;



        public Creator()
        {
            question = new SqlQuestionQueryRepository(connectionString);
            InitializeComponent();
            uxCreatorTypeDDL.Items.Add("Author");
            uxCreatorTypeDDL.Items.Add("Developer");
        }

        private void uxGetCreatorByTypeButton_Click(object sender, EventArgs e)
        {
            string selectedItem = uxCreatorTypeDDL.Items[uxCreatorTypeDDL.SelectedIndex].ToString();
            var list = question.GetCreatorsByType(selectedItem);
            uxGetCreatorByTypeGridView.DataSource = list;
        }

        private void uxFetchProductionsByCreatorButton_Click(object sender, EventArgs e)
        {
            int creatorID = Int32.Parse(uxCreatorCreatorIDTextBox.Text);
            var list = question.FetchProductionOfCreator(creatorID);
            uxFetchProductionsByCreatorGridView.DataSource = list;
        }
    }
}
