using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Net.Http.Headers;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;

namespace membership_system_G_fit
{
	public partial class Profile : Form
	{
		public Profile()
		{
			InitializeComponent();
		}

		public String account { get; set; }



		//DATABASE CONNECTION
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd = new MySqlCommand();
		DataTable sqlTable = new DataTable();
		string sqlQuery;
		MySqlDataAdapter Dta = new MySqlDataAdapter();
		DataSet Ds = new DataSet();
		MySqlDataReader sqlReader;

		String server = "127.0.0.1";
		String username = "root";
		String password = "123";
		String database = "membership";

		string data;
		private void label14_Click(object sender, EventArgs e)
		{

		}
		public void uploadData()
		{
			try
			{
				//get the user's data
				data = ApplicationData.Instance.SharedData;


				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();
				sqlCmd.Connection = sqlConn;


				sqlCmd.CommandText = "SELECT customer_ID, first_name, middle_name, last_name, age, gender, address,barangay, city, zipcode, username, password, date_of_registration, picture, paid, member_type, status, payment  FROM membership.members WHERE username = '" + data + "'";
				sqlReader = sqlCmd.ExecuteReader();



				sqlTable.Load(sqlReader);
				dataGridView1.DataSource = sqlTable;

				sqlReader.Close();
				sqlConn.Close();

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Profile_Load(object sender, EventArgs e)
		{
			uploadData();
			lblusername.Text = data;
		}

		private void lblExit_Click(object sender, EventArgs e)
		{
			DialogResult exit;

			exit = MessageBox.Show("Do you want to exit?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (exit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void browseImage_Click(object sender, EventArgs e)
		{

			String imageLocation = "";
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All Files(*.*)|*.*";

				if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					imageLocation = dialog.FileName;
					//picture.ImageLocation = imageLocation;
				}

				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();
				sqlQuery = "UPDATE members SET picture = '" + imageLocation + "' ORDER BY customer_ID DESC LIMIT 1";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				sqlCmd.ExecuteNonQuery();


				sqlConn.Close();

				uploadData();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Retrieving values from the database
			lblFirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			lblMiddlename.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			lblLastname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			lblAge.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			lblGender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			lblAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
			lblBarangay.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
			lblCity.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
			lblZipcode.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
			lblUser.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
			lblDateReg.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
			cmbRenewal.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
			cmbStatus.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
			lblPayment.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();



		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label0_Click(object sender, EventArgs e)
		{

		}

		private void lblFirstname_Click(object sender, EventArgs e)
		{

		}

		string nameData = "";
		string membertype = "";

		private void btnProfile_Click(object sender, EventArgs e)
		{


			Amount amount = new Amount();



		}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{

			// Retrieve the data
			string data = ApplicationData.Instance.SharedData;

			this.Hide();
			Dashboard_members members = new Dashboard_members();
			members.User = data;
			members.Show();
			this.Hide();

		}

		private void lblusername_Click(object sender, EventArgs e)
		{

		}

		public void updateStatusOrMemberType (string setQuery, ComboBox cmb)
		{
			try
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();

				string updateStatusQuery = "UPDATE membership.members SET '"+ setQuery+"' = '"+cmb+"' WHERE username = '" + lblUser.Text + "'";

				MySqlCommand command = new MySqlCommand(updateStatusQuery, sqlConn);
				command.ExecuteNonQuery();

				sqlConn.Close();

				MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong!", "Information", MessageBoxButtons.OK);
			}
		}

		private void btnUpdateStatus_Click(object sender, EventArgs e)
		{
			DialogResult choice;

			if (cmbStatus.Text == "" && cmbRenewal.Text == "")
			{
				MessageBox.Show("Nothing Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
			else if(cmbStatus.SelectedIndex != -1 )
			{

				string statusValue = "";
				MySqlConnection conn = new MySqlConnection();

				conn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				conn.Open();
				sqlQuery = "SELECT * FROM membership.members WHERE username = '" + lblUser.Text + "' ";
				sqlCmd = new MySqlCommand(sqlQuery, conn);

				sqlReader = sqlCmd.ExecuteReader();

				while (sqlReader.Read())
				{
					statusValue = sqlReader.GetString("status");

				}


				if (cmbStatus.Text != statusValue)
				{
				    choice = MessageBox.Show("Do you want to change your  status?", "Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (choice == DialogResult.Yes)
					{

						try
						{
							sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
							sqlConn.Open();

							string updateStatusQuery = "UPDATE membership.members SET status = '" + cmbStatus.Text + "' WHERE username = '" + lblUser.Text + "'";

							MySqlCommand command = new MySqlCommand(updateStatusQuery, sqlConn);
							command.ExecuteNonQuery();

							sqlConn.Close();

							MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

						catch (Exception ex)
						{
							MessageBox.Show("Something went wrong!", "Information", MessageBoxButtons.OK);
						}
					}
				}
			}

			else if (cmbRenewal.SelectedIndex != -1)
			{
				string membertypeValue = "";
			   
				MySqlConnection conn = new MySqlConnection();
				
				conn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				conn.Open();

				sqlQuery = "SELECT * FROM membership.members WHERE username = '" + data + "' ";
				sqlCmd = new MySqlCommand(sqlQuery, conn);

				sqlReader = sqlCmd.ExecuteReader();

				while (sqlReader.Read())
				{
					membertypeValue = sqlReader.GetString("member_type");

				}

				if(cmbRenewal.Text != membertypeValue)
				{
					 choice = MessageBox.Show("Do you want to change your  Membership type?", "Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (choice == DialogResult.Yes)
					{

						try
						{
							sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
							sqlConn.Open();

							string updateStatusQuery = "UPDATE membership.members SET member_type = '" + cmbRenewal.Text + "' WHERE username = '" + lblUser.Text + "'";

							MySqlCommand command = new MySqlCommand(updateStatusQuery, sqlConn);
							command.ExecuteNonQuery();

							sqlConn.Close();

							MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

						catch (Exception ex)
						{
							MessageBox.Show("Something went wrong!", "Information", MessageBoxButtons.OK);
						}
					}
				}	


			}

		/*	else if (cmbStatus.SelectedIndex != -1 && cmbRenewal.SelectedIndex != -1) 
			{

				DialogResult choice;
				if (cmbRenewal.SelectedIndex != -1)
				{
					choice = MessageBox.Show("Do you want to change your Membership status?", "Membership Renewal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


					if (choice == DialogResult.Yes)
					{

						try
						{
							sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
							sqlConn.Open();

							string updateStatusQuery = "UPDATE membership.members SET member_type = '" + cmbRenewal.Text + "' WHERE username = '" + lblUser.Text + "'";

							MySqlCommand command = new MySqlCommand(updateStatusQuery, sqlConn);
							command.ExecuteNonQuery();

							sqlConn.Close();

							MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

						catch (Exception ex)
						{
							MessageBox.Show("Something went wrong!", "Information", MessageBoxButtons.OK);
						}


					}

				}

				else if (cmbStatus.SelectedIndex != -1)
				{
					 choice = MessageBox.Show("Do you want to change your  status?", "Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (choice == DialogResult.Yes)
					{

						try
						{
							sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
							sqlConn.Open();

							string updateStatusQuery = "UPDATE membership.members SET status = '" + cmbStatus.Text + "' WHERE username = '" + lblUser.Text + "'";

							MySqlCommand command = new MySqlCommand(updateStatusQuery, sqlConn);
							command.ExecuteNonQuery();

							sqlConn.Close();

							MessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}

						catch (Exception ex)
						{
							MessageBox.Show("Something went wrong!", "Information", MessageBoxButtons.OK);
						}
					}
				}
				
			} */

			else
			{
				
			}
			uploadData();
		}
	}
}
