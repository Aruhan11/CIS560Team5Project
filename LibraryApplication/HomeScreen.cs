using LibraryApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void uxAssetButton_Click(object sender, EventArgs e)
        {
            Asset a = new Asset();
            a.Show();
        }

        private void uxUserButton_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
        }

        private void uxCreatorButton_Click(object sender, EventArgs e)
        {
            Creator c = new Creator();
            c.Show();
        }

        private void uxRankButton_Click(object sender, EventArgs e)
        {
            Important i = new Important();
            i.Show();
        }

        private void uxMangeCheckOutAssetButton_Click(object sender, EventArgs e)
        {

            CheckOutAsset coa = new CheckOutAsset();
            coa.Show();
        }
    }
}
