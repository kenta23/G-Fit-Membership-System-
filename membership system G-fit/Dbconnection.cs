using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace membership_system_G_fit
{
	internal class Dbconnection
	{
		private string strserver = Properties.Settings.Default.server;
		private string strport = Properties.Settings.Default.port;
		private string strusername = Properties.Settings.Default.username;
		private string strpassword = Properties.Settings.Default.password;
		private string strDbase = Properties.Settings.Default.Dbase;

		public MySqlConnection con = new MySqlConnection();

		public void Connect () 
		{
			string ConString = "server = " +strserver+ "; port = " +strport+ "; username = " +strusername+ "; password = " +strpassword+"; database = "+strDbase+"; charset = utf8";
			con = new MySqlConnection(ConString);
			con.Open();
		}
		public void DisConnect () 
		{
			con.Dispose();
			con.Close();
		    
		}
	}
}
