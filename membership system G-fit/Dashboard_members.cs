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

namespace membership_system_G_fit
{
	public partial class Dashboard_members : Form
	{
		
		public Dashboard_members()
		{
			InitializeComponent();
		}
		public String User { get; set; }

		//DATABASE CONNECTION
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlTable = new DataTable();
		String sqlQuery;
		MySqlDataAdapter Dta = new MySqlDataAdapter();
		DataSet Ds = new DataSet();
		MySqlDataReader sqlReader;

		String server = "127.0.0.1";
		String username = "root";
		String password = "123";
		String database = "membership";


		private void lblViewProfile_Click(object sender, EventArgs e)
		{
			//sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
			//sqlConn.Open();

			Profile profile = new Profile();
		//	profile.account = lblUser.Text;
			profile.Show();
			this.Hide();

			//sqlConn.Close();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Dashboard_members_Load(object sender, EventArgs e)
		{
			//Loginuser loginuser = new Loginuser();

			// Retrieve the data
			string data = ApplicationData.Instance.SharedData;  //load the saved user who logged in 

			/*	string nameData = "";
			   try
			   {
				   sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				   sqlConn.Open();
				   sqlQuery = "SELECT * FROM membership.members WHERE username = '"+ data + "'";
				   sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				   sqlReader = sqlCmd.ExecuteReader();

				   while (sqlReader.Read())
				   {
					   nameData = sqlReader.GetString("first_name");
					   //retrieve other column values as needed
				   }

				   lblUser.Text = nameData;

			   }
			   catch (Exception ex)
			   {

				   MessageBox.Show(ex.Message);
			   } */

			lblUser.Text = data;

			
		}

		private void label4_Click(object sender, EventArgs e)
		{
			PaymentOption option = new PaymentOption();
			option.user = lblUser.Text;
			option.Show();
			this.Hide();
			
		}

		private void label5_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Shop().Show();
		}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{

			DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Account Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (logout == DialogResult.Yes)
			{
				this.Hide();
				new Starting_page().Show();
			}
			
		}


	}
}
