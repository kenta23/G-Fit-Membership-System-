using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace membership_system_G_fit
{
	public partial class Monitor : Form
	{
		public Monitor()
		{
			InitializeComponent();
		}


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
		private void display()
		{

			string sqlQuery = "SELECT customer_ID, first_name, last_name, username, member_type, status FROM membership.members";
			DBconn.displayDB(sqlQuery, dataGridView1);


			
		}



		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblCustomer_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			lblName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			lblUsername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			lblType.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			cmbStatus.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
			sqlConn.Open();		
			try
			{
				sqlQuery = "UPDATE membership.members SET status = '" + cmbStatus.Text + "' WHERE customer_ID = '"+lblCustomer_ID.Text+"'";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();

				MessageBox.Show("Updated status successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			display();

		}

		private void Monitor_Load(object sender, EventArgs e)
		{
			display();


			/*	try
				{
					//Update the status of members daily 

					TimeSpan oneDay = TimeSpan.FromDays(1); // duration of one day
					DateTime lastActionTime = DateTime.MinValue; // initialize to the earliest possible date

					while (true)
					{
						if (DateTime.Now - lastActionTime >= TimeSpan.FromSeconds(50)) // check if one day has passed since the last action
						{
							// perform the daily action here
							Console.WriteLine("Performing daily action...");

							sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
							String sqlDelete = "UPDATE membership.members SET status = null";

							sqlConn.Open();

							MySqlCommand command = new MySqlCommand(sqlDelete, sqlConn);
							command.ExecuteNonQuery();
							sqlConn.Close();


							// update the last action time to the current time
							lastActionTime = DateTime.Now;
						}
					}
					Thread.Sleep(1000);
					/*

					/* while (true) // loop indefinitely
					  {
						 /*	sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
						  String sqlDelete = "UPDATE membership.members SET status = null";

						  sqlConn.Open();

						  MySqlCommand command = new MySqlCommand(sqlDelete, sqlConn);

						  command.ExecuteNonQuery();


						  sqlConn.Close(); 

					// wait for one day before deleting the column again
					//Thread.Sleep(TimeSpan.FromSeconds(50)); // wait for 1 day

					}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				} */
		}



		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
			sqlConn.Open();
			try
			{
				String sqlDelete = "UPDATE membership.members SET status = null";
				sqlCmd = new MySqlCommand(sqlDelete, sqlConn);

				sqlCmd.ExecuteNonQuery();
				sqlConn.Close();


				DialogResult choice;

			 choice = MessageBox.Show("Are you sure you want to reset all the status of the members?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
  
				try
				{
					if (choice == DialogResult.Yes)
					{
						MessageBox.Show("Cleared status successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			 
			 
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			display();
		}
	}
  }


