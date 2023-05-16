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
	public partial class Loginuser : Form
	{
		public Loginuser()
		{
			InitializeComponent();
			
		}

		public String user { get; set; }
		public String Username { get; set; }

		//DATABASE CONNECTION
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		MySqlDataReader sqlReader;

		String server = "127.0.0.1";
		String username = "root";
		String password = "123";
		String database = "membership";

		
		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
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

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			this.Hide();
			Register register = new Register();
			register.ShowDialog();
			this.Show();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			//connection string 
			sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;



				try
				{
					sqlConn.Open();
					String account = "SELECT * FROM membership.members WHERE username = '" + txtUser.Text + "' and password = '" + txtPass.Text + "'";

					sqlCmd = new MySqlCommand(account, sqlConn);
					sqlReader = sqlCmd.ExecuteReader();



					if (sqlReader.Read() == true)
					{

						MessageBox.Show("Succesful", "Account log in", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Dashboard_members dashboard = new Dashboard_members();
						dashboard.User = txtUser.Text;
						dashboard.Show();
						this.Hide();


						//   Username = txtUser.Text;
					}

					else
					{
						MessageBox.Show("Username or Password doesn't match!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}




				}

				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					sqlConn.Close();
				}

				finally
				{
					sqlConn.Close();
				}
			
			
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if(checkBox1.Checked)
			{
				txtPass.PasswordChar = '\0';
			}else
			{
				txtPass.PasswordChar = '*';

			}
		}

		private void txtPass_TextChanged(object sender, EventArgs e)
		{

		}

		private void Loginuser_Load(object sender, EventArgs e)
		{
			
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Optionlogin().Show();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void txtUser_TextChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{

		}
	}
}
