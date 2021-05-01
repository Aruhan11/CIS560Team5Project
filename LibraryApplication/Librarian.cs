using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using LibraryData;
namespace LibraryApplication
{
    public partial class Librarian : Form
    {

        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private ILibrarianQueryRepository libraianQ;
        private IUserQueryRepository userQ;
        public Librarian()
        {
            libraianQ = new SqlLibrarianQueryRepository(connectionString);
            userQ = new SqlUserQueryRepository(connectionString);
            InitializeComponent();
        }

        private void uxFetchLibrarian_Click(object sender, EventArgs e)
        {
            int librainID = Convert.ToInt32(uxLibrarianIDInput.Text);
            var lib = libraianQ.FetchLibrarian(librainID);
            var user = userQ.FetchUser(lib.UserID);
            uxUserID.Text = user.UserID.ToString();
            uxFirstName.Text = user.FirstName;
            uxLastName.Text = user.LastName;

            
        }

        private void uxRetrieveAllLibrarians_Click(object sender, EventArgs e)
        {
            var lib = libraianQ.RetrieveLibrarian();
            uxRetrieveAllLibrariansDataGridView.DataSource = lib;
        }

    }
}
