using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace membership_system_G_fit
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();

		}

		string nameData = "";
		//DATABASE CONNECTION
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd;
		String sqlQuery;
		MySqlDataReader sqlReader;

		String server = "127.0.0.1";
		String username = "root";
		String password = "123";
		String database = "membership";

		public String AdminName { get; set; }

		private void label1_Click(object sender, EventArgs e)
		{


		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			

			try
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();
				sqlQuery = "SELECT * FROM membership.admin";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				sqlReader = sqlCmd.ExecuteReader();

				while (sqlReader.Read())
				{
					nameData = sqlReader.GetString("name");
					//retrieve other column values as needed
				}

				lblWelcome.Text = nameData;

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}

		}

		private void label4_Click(object sender, EventArgs e)
		{
			new Payment().Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Monitor().Show();
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

		private void label6_Click(object sender, EventArgs e)
		{
			//member List 
			//Walk in applicants 
			this.Hide();
			new members().Show();
		}

		private void lblStaff_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Staff().Show();
		}

		private void lblIDreg_Click(object sender, EventArgs e)
		{
			this.Hide();
			new RegisterID().Show();
		}

		private void lblArchives_Click(object sender, EventArgs e)
		{
			this.Hide();
			Archives archives = new Archives();
			archives.Show();

		}
	}
}
