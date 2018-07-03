using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.DB
{
	class DBConnections
	{
        //Requires Nuget: MySQl.Data
		private static MySqlConnection cnx;
		private static MySqlCommand cmd;
		private static MySqlDataReader reader;
		private static String query;
		private static String lblResult;


        public DBConnections()
        {
            Console.WriteLine("MySQLConxAndQuery: Constructor...");
        }

		public static void MySQLConxAndQuery()
		{
			cnx = new MySqlConnection("server=192.168.0.80; port=3306; userid=outlaw1; password=outlaw1; database=outlaw; Encrypt=false;");
			
			
			try //DB Connection
				{
					cnx.Open();
					//MessageBox.Show("connected...");
					lblResult = "Connected....";
					cnx.Close();
				}
				catch
				{
					//MessageBox.Show("NOT connected...");
					lblResult = "NOT Connected....";
				}
            Console.WriteLine("MySQLConxAndQuery: DBConx: { 0}" + lblResult);

			try //Drupal DB Query
			{
				cnx.Open();
                query = "SELECT * FROM node";
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
				lblResult = sb.ToString();
				cnx.Close();
			}
			catch
			{
				lblResult = "Can't Execute Query";
			}
            Console.WriteLine("MySQLConxAndQuery: DBQuery: { 0}" + lblResult);

        }

    }
}
