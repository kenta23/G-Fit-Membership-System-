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

			if(cmbType.SelectedIndex == 0)
			{
				amountPay = "P292.00";
			}
			else if(cmbType.SelectedIndex == 1)
			{
				amountPay = "P1750.00";
			}
			else if (cmbType.SelectedIndex == 2)
			{
				amountPay = "P3500.00";
			}

			lblAmount.Text = amountPay;
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			

         try
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();
				sqlQuery = "UPDATE membership.members SET paid = '"+"Yes"+"', member_type = '" + cmbType.Text + "' WHERE username = '"+lblUser.Text+"' ";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

				sqlCmd.ExecuteNonQuery();
				
				MessageBox.Show("You paid " + amountPay + " Thank you!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
				sqlConn.Close();
				this.Hide();
				new Loginuser().Show();
			}
	 	catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


			

		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("You want to go back to Homepage?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

			if(result == DialogResult.Yes)
			{
				this.Hide();
				this.Hide();
				new Dashboard_members().Show();
			}
		}

		private void Amount_Load(object sender, EventArgs e)
		{
			//	PaymentOption paymentopt = new PaymentOption();
			//	string textBoxValue = paymentopt.GetTextBoxValue();
			//	lblPaymentOpt.Text = textBoxValue;


			lblUser.Text = user;
			//lblAmount.Text = pay;
			lblPaymentOpt.Text = paymentoption;
			cmbType.Text = cmbOption;
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
