using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseFormApp
{
    public partial class Form1 : Form
    {
        MySqlConnection cnx = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            cnx.ConnectionString = "server=192.168.0.80; port=3306; userid=outlaw1; password=outlaw1; database=outlaw; Encrypt=false;";
            //String query = string.Format("SELECT * FROM node");
            String query = "SELECT * FROM node";
            MySqlCommand cmd = new MySqlCommand(query, cnx);
            cnx.Open();

            //MessageBox.Show("connected...");

            //MySqlDataReader queryResult = cmd.ExecuteQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = (string)reader["nid"].ToString();
                string nid = reader["nid"].ToString();
                string type = reader["type"].ToString();
                string uuid = reader["uuid"].ToString();

                Console.WriteLine("string = {0}--{1}--{2}", nid, type, uuid);
            }
            



            //int id = (int)cmd.LastInsertedId;
            //cmd.
            //Console.WriteLine("id =", id);
            cnx.Close();


        }
    }
}
