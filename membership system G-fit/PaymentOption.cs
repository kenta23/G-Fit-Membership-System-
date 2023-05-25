using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;


namespace membership_system_G_fit
{
	public partial class PaymentOption : Form
	{
		public PaymentOption()
		{
			InitializeComponent();
		}



		


		private void btnSkip_Click(object sender, EventArgs e)
		{

		}
		public String paymentString { get; set; }
		public String user { get; set; }


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

		string choices = "";

		public string GetTextBoxValue()
		{
			
			if (rdbOnHand.Checked)
			{
				choices = "On hand Payment";
			}
			if (rdbEwallet.Checked)
			{
				if (cmbEwallet.SelectedIndex == 0)
				{
					choices = "Gcash";
				}
				else if (cmbEwallet.SelectedIndex == 1)
				{
					choices = "Paymaya";
				}
				else if (cmbEwallet.SelectedIndex == 2)
				{
					choices = "Paypal";
				}
				else
				{
					choices = "";
				} 
				choices = "E wallet";
			}
		  if (rdbCreds.Checked)
			{
				choices = "Credit card/Debit card";
			}
		  if (rdbOlBanking.Checked)
			{
				choices = "Online Banking";
			}

			return choices;
		}


		private void paymentTypes (string payment)
		{
			try
			{
				string usernameData = ApplicationData.Instance.SharedData;

				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;

				sqlConn.Open();
				sqlQuery = "UPDATE membership.members SET payment = '"+payment+"' WHERE username = '" + usernameData + "'";

				//string updateMember = "UPDATE membership.members SET first_name = '" + txtFirstname.Text + "', middle_name = '" + txtMiddlename.Text + "', last_name = '" + txtLastname.Text + "', age = '" + txtAge.Text + "', gender = '" + cmbGender.Text + "', address = '" + txtAddress.Text + "'," +
				//	" barangay = '" + txtBarangay.Text + "', city = '" + txtCity.Text + "', zipcode = '" + txtZipCode.Text + "', date_of_registration = '" + dateRegistration.Text + "', member_type = '" + membershipDataGet + "' ORDER BY customer_ID DESC LIMIT 1";

				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				sqlReader = sqlCmd.ExecuteReader();
				sqlConn.Close();
			}


			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}



			Amount amount = new Amount();
			amount.user = lblUser.Text;
			amount.pay = GetTextBoxValue();
			amount.paymentoption = GetTextBoxValue();
			amount.Show();
			this.Hide();
		}

		private void btnProceed_Click(object sender, EventArgs e)
		{
			if (rdbOnHand.Checked)
			{
				paymentTypes("On hand");

			}

			else if(rdbCreds.Checked)
			{
				paymentTypes("Credit/Debit Card");

			}

			else if (rdbOlBanking.Checked)
			{
				paymentTypes("Online banking");

			}


			else if (rdbEwallet.Checked)
			{
				if (cmbEwallet.Visible)
				{
					if (cmbEwallet.SelectedItem == null)
					{
						MessageBox.Show("Please select your E-wallet payment", "Payment failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}

					else
					{
						paymentTypes("E wallet "+cmbEwallet.SelectedItem.ToString());

					}

				}
				
			}
			
			else
			{
				
			}

		}



		private void PaymentOption_Load(object sender, EventArgs e)
		{
		  string data =	ApplicationData.Instance.SharedData;

			//lblUser.Text = user;
			lblUser.Text = data;
			
		}

		private void rdbOnHand_CheckedChanged(object sender, EventArgs e)
		{
			
			choices = rdbOnHand.Text.ToString();
			
		}

		private void rdbEwallet_CheckedChanged(object sender, EventArgs e)
		{
			if(rdbEwallet.Checked)
			{
				cmbEwallet.Visible = true;
			}
			else
			{
				cmbEwallet.Visible = false;
			}


			choices = rdbEwallet.Text.ToString();
		}

		private void rdbCreds_CheckedChanged(object sender, EventArgs e)
		{
			
			choices = rdbEwallet.Text.ToString();
		}

		private void rdbOlBanking_CheckedChanged(object sender, EventArgs e)
		{
			
			choices = rdbEwallet.Text.ToString();
		}

		private void cmbEwallet_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbEwallet.SelectedIndex == 0) {
				//string choices = "";
				choices = "Gcash";
			}
			else if(cmbEwallet.SelectedIndex == 1) {
				
				choices = "Paymaya";

			}

			else if (cmbEwallet.SelectedIndex == 2)
			{
				choices = "Paypal";

			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			DialogResult exit;

			exit = MessageBox.Show("Do you want to exit?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (exit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void customizeButtons4_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard_members().Show();
		}

		private void cmbEwallet_SelectedValueChanged(object sender, EventArgs e)
		{

		}
		private void rdbEwallet_Click(object sender, EventArgs e)
		{
			
		}
	}
}
