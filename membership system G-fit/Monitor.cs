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
	}
}
