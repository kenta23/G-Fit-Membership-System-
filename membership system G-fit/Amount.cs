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
	public partial class Amount : Form
	{
		public Amount()
		{
			InitializeComponent();
		}



		string amountPay = "";
		public string pay { get; set; }

		public string user { get; set; }

		public string paymentoption { get; set; }
		public string cmbOption { get; set; }

		string data;
		string membertypeValue = "";

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
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		/*	if (cmbType.SelectedIndex == 0)
			{
				amountPay = "P292.00";
			}
			else if (cmbType.SelectedIndex == 1)
			{
				amountPay = "P1750.00";
			}
			else if (cmbType.SelectedIndex == 2)
			{
				amountPay = "P3500.00";
			}

			lblAmount.Text = amountPay; */
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			if (cmbType.SelectedItem == null)
			{
				MessageBox.Show("Please select your membership type", "Membership type required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

			else
			{
				try
				{
					sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
					sqlConn.Open();
					sqlQuery = "UPDATE membership.members SET paid = '" + "yes" + "', member_type = '" + cmbType.Text + "' WHERE username = '" + data + "' ";
					sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

					sqlCmd.ExecuteNonQuery();

					MessageBox.Show("You paid " + amountPay + " Thank you!", "Membership paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
					sqlConn.Close();


					this.Hide();
					Dashboard_members members = new Dashboard_members();
					this.Hide();
					members.Show();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}


			}

		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("You want to go back", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if (result == DialogResult.Yes)
			{
				this.Hide();
				new PaymentOption().Show();
			}
		}

		private void Amount_Load(object sender, EventArgs e)
		{
			
		 	data = ApplicationData.Instance.SharedData;


			lblUser.Text = data;
	

			lblPaymentOpt.Text = paymentoption;
			cmbType.Text = cmbOption;

			sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
			sqlConn.Open();
			sqlQuery = "SELECT member_type FROM membership.members WHERE username = '" + data + "' ";
			sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

			 sqlReader = sqlCmd.ExecuteReader();

			while(sqlReader.Read())
			{
				 membertypeValue = sqlReader.GetString("member_type");
			}

			
			lblMembership.Text = membertypeValue;


			if (membertypeValue == "Monthly")
			{
				amountPay = "P699";
			}
			else if (membertypeValue == "6 Months")
			{
				amountPay = "P3700";
			}
			else if (membertypeValue == "12 Months")
			{
				amountPay = "8700";
			}

			else
			{
				lblAmount.Text = amountPay;
			}

			lblAmount.Text = amountPay;

			sqlConn.Close();
			sqlReader.Close();
		}


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
	}
}
