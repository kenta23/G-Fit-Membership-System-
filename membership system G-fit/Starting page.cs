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
	public partial class Starting_page : Form
	{
		public Starting_page()
		{
			InitializeComponent();

		}


		//DATABASE CONNECTION
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		MySqlDataReader sqlReader;

		String server = "127.0.0.1";
		String username = "root";
		String password = "123";
		String database = "membership";

		private void btnLogin_Click(object sender, EventArgs e)
		{
			//connection string 
			sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
			//	string connectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
			//	MySqlConnection connection = new MySqlConnection(connectionString);

			int adminCount = 0;
			int memberCount = 0;

			try
			{

				sqlConn.Open();


				MySqlCommand adminAccount = new MySqlCommand("SELECT * FROM membership.admin WHERE username = @username AND password = @password", sqlConn);
				adminAccount.Parameters.AddWithValue("@username", txtUser.Text);
				adminAccount.Parameters.AddWithValue("@password", txtPass.Text);
				adminCount = Convert.ToInt32(adminAccount.ExecuteScalar());

				MySqlCommand memberAccount = new MySqlCommand("SELECT * FROM membership.members WHERE username = @username AND password = @password", sqlConn);
				memberAccount.Parameters.AddWithValue("@username", txtUser.Text);
				memberAccount.Parameters.AddWithValue("@password", txtPass.Text);
				memberCount = Convert.ToInt32(memberAccount.ExecuteScalar());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex.Message);
			}

			finally
			{
				sqlConn.Close();
			}


			//user input validations 

			try
			{
				if (txtUser.Text == "")
				{
					MessageBox.Show("Enter your Username", "Incorrect username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (txtPass.Text == "")
				{
					MessageBox.Show("Enter your Password", "Incorrect password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}


				else
				{
					//user entered correct account admin or members
					if (adminCount > 0)
					{

						//grant admin privileges
						MessageBox.Show("Succesful", "Account log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Dashboard dashboard = new Dashboard();
						dashboard.AdminName = txtUser.Text;
						dashboard.Show();
						this.Hide();
					}
					else if (memberCount > 0)
					{

						//set the username of the user who logged in and save it 
						ApplicationData.Instance.SharedData = txtUser.Text;

						// grant member privileges
						MessageBox.Show("Succesful", "Account log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Dashboard_members dashboard = new Dashboard_members();
						//dashboard.User = txtUser.Text;
						dashboard.Show();
						this.Hide();
					}

					else
					{
						MessageBox.Show("Username or Password doesn't match!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error " + ex.Message);
			}


		}

		private void lblexit_Click(object sender, EventArgs e)
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

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				txtPass.PasswordChar = '\0';
			}
			else
			{
				txtPass.PasswordChar = '*';

			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			string labelText = RunningText.Text;
			char firstChar = labelText[0];
			labelText = labelText.Substring(1) + firstChar;
			RunningText.Text = labelText;
		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			Register2 register2 = new Register2();
			register2.Show();
			this.Hide();
		}
	}
}
