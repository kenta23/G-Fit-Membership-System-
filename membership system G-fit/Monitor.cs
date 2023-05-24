using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
			string sqlQuery = "SELECT customer_ID, first_name, last_name, username, member_type, date_of_registration, status FROM membership.members";
			DBconn.displayDB(sqlQuery, dataGridView1);
		}


		private void displayTable()
		{

			//sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database";
			string connectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;


			// Create a new DataTable to store the retrieved data
			DataTable dataTable = new DataTable();

			// Retrieve the current date and time
			DateTime currentDate = DateTime.Now;

			// Calculate the date and time 60 seconds ago
			DateTime timeThreshold = currentDate.AddSeconds(-60);

			// Format the date and time values as "m/dd/yyyy hh:mm:ss"
			string formattedCurrentDate = currentDate.ToString("M/dd/yyyy HH:mm:ss");
			string formattedTimeThreshold = timeThreshold.ToString("M/dd/yyyy HH:mm:ss");

			// Connect to the MySQL database
			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				connection.Open();

				// Retrieve the current date and time
				DateTime currentTime = DateTime.Now;

				// Calculate the date and time 60 seconds ago
				DateTime thresholdTime = currentTime.AddSeconds(-60);

				// Format the threshold time as "M/d/yyyy H:mm:ss"
				string formattedThresholdTime = thresholdTime.ToString("M/d/yyyy HH:mm:ss");

				// Construct the SQL query to delete records older than 60 seconds

				string query = $"DELETE  FROM membership.members WHERE date_of_registration < '{formattedThresholdTime}'";

				// Construct the SQL query to fetch all records from the table
				//string query = $"SELECT customer_ID, first_name, last_name, username, member_type, date_of_registration, status FROM membership.members WHERE date_of_registration < '{formattedTimeThreshold:}'";
				//string query = $"SELECT * FROM members WHERE STR_TO_DATE(registration_date, '%c/%e/%Y %r') < STR_TO_DATE('{formattedTimeThreshold}', '%c/%e/%Y %r')";


				// Create a new MySqlDataAdapter with the query and connection
				using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection))
				{
					// Fill the DataTable with the retrieved data
					dataAdapter.Fill(dataTable);
				}

				// Close the database connection
				connection.Close();
			}

			// Set the DataTable as the data source for the DataGridView
			dataGridView1.DataSource = dataTable;

			display();

		}


		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblCustomer_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
			lblName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			lblUsername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			lblType.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			cmbStatus.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
			sqlConn.Open();
			try
			{
				sqlQuery = "UPDATE membership.members SET status = '" + cmbStatus.Text + "' WHERE customer_ID = '" + lblCustomer_ID.Text + "'";
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
			//display();
			displayTable();

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
				catch (Exception ex)
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

		private void lblType_Click(object sender, EventArgs e)
		{

		}

		private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void label9_Click(object sender, EventArgs e)
		{
		}

		private void lblUsername_Click(object sender, EventArgs e)
		{
		}

		private void lblName_Click(object sender, EventArgs e)
		{
		}

		private void label6_Click(object sender, EventArgs e)
		{
		}

		private void label5_Click(object sender, EventArgs e)
		{
		}

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}
	}

}










