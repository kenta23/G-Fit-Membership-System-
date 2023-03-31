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
	public partial class Loginadmin : Form
	{
		public Loginadmin()
		{
			InitializeComponent();
		}

		//DATABASE CONNECTION
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd;
		String sqlQuery;
		MySqlDataReader sqlReader;

		String server = "127.0.0.1";
		String username = "root";
		String password = "123";
		String database = "membership";




		private void label2_Click(object sender, EventArgs e)
		{
			DialogResult exitApp;

			exitApp = MessageBox.Show("Exit Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


			try
			{


				if (exitApp == DialogResult.Yes)
				{
					Application.Exit();
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if(txtUserAdmin.Text == "" && txtUserPass.Text == "")
			{
				MessageBox.Show("Please input your username and Password", "Admin login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}

			else if (txtUserAdmin.Text == "")
			{
				MessageBox.Show("Please input your username", "Admin login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			else if (txtUserPass.Text == "")
			{
				MessageBox.Show("Please input your password", "Admin login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;

			try
				{

					sqlConn.Open();
					sqlQuery = "SELECT * FROM membership.admin WHERE username = '"+txtUserAdmin.Text+"' and password ='"+txtUserPass.Text+"'";
					sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
					sqlReader = sqlCmd.ExecuteReader();


					if(sqlReader.Read())
					{
						MessageBox.Show("Succesful", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
					    Dashboard dashboard	= new Dashboard();

						dashboard.AdminName = txtUserAdmin.Text;
						dashboard.Show();
						this.Hide();
					}

					else
					{
						MessageBox.Show("Admin login Failed", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}

			catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}

			finally
				{
			      sqlConn.Close();
				}
				
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Optionlogin().Show();
		}
	}
}
