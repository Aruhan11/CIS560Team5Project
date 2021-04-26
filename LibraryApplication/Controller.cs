using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryProject
{
    public class Controller
    {
        public bool UsernamePasswordExists(string u, string p)
        {
            string connetionString = "";
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");



            cnn.Close();
        }

        public bool AssetExists(string u, string p)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");



            cnn.Close();
        }

        public bool UserExists(string u, string p)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open!");



            cnn.Close();
        }
    }
}
