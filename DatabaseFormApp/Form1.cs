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
        MySqlConnection cnx = new MySqlConnection("server=192.168.0.80; port=3306; userid=outlaw1; password=outlaw1; database=outlaw; Encrypt=false;");
        MySqlCommand cmd = new MySqlCommand();
        String query = "SELECT * FROM node";
        MySqlDataReader reader;
        // for instert/delete/update ie.. non-'select' queries
        //MySqlDataReader queryResult = cmd.ExecuteQuery();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //String query = string.Format("SELECT * FROM node");
            try
            {
                cnx.Open();
                //MessageBox.Show("connected...");
                lblResult.Text = "Connected....";
                cnx.Close();
            }
            catch
            {
                //MessageBox.Show("NOT connected...");
                lblResult.Text = "NOT Connected....";
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                cmd = new MySqlCommand(query, cnx);
                reader = cmd.ExecuteReader();

                StringBuilder sb = new StringBuilder();
                while (reader.Read())
                {
                    string id = (string)reader["nid"].ToString();
                    string nid = reader["nid"].ToString();
                    string type = reader["type"].ToString();
                    string uuid = reader["uuid"].ToString();
                    string result = "string = " + nid + "--" + type + "--" + uuid;
                    sb.Append(result + "\n");
                }
                lblResult.Text = sb.ToString();
                cnx.Close();
            }
            catch
            {
                lblResult.Text = "Can't Execute Query";
                //Console.WriteLine("Can't Execute Query...");
            }
        }
    }
}
