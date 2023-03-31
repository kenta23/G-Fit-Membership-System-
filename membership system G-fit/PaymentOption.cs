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

		public string GetTextBoxValue()
		{
			string choices = "";

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

		private void btnProceed_Click(object sender, EventArgs e)
		{
			/*string choices = "";

			if (rdbOnHand.Checked)
			{
				choices = "On hand Payment";
			}
		   if (rdbEwallet.Checked)
			{
				/*if (cmbEwallet.SelectedIndex == 0)
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


			//paymentString = choices;
			choices = label3.Text; */

			//GetTextBoxValue();

			Amount amount = new Amount();
			amount.user = lblUser.Text;
			//amount.pay = GetTextBoxValue();
			amount.paymentoption = GetTextBoxValue();
			amount.Show();
			this.Hide();
		}


	

		private void PaymentOption_Load(object sender, EventArgs e)
		{
			lblUser.Text = user;
			
		}

		private void rdbOnHand_CheckedChanged(object sender, EventArgs e)
		{
			string choices;
			choices = rdbOnHand.Text.ToString();
			
		}

		private void rdbEwallet_CheckedChanged(object sender, EventArgs e)
		{
			string choices = "";
			choices = rdbEwallet.Text.ToString();
		}

		private void rdbCreds_CheckedChanged(object sender, EventArgs e)
		{
			string choices = "";
			choices = rdbEwallet.Text.ToString();
		}

		private void rdbOlBanking_CheckedChanged(object sender, EventArgs e)
		{
			string choices = "";
			choices = rdbEwallet.Text.ToString();
		}

		private void cmbEwallet_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cmbEwallet.SelectedIndex == 0) {
				string choices = "";
				choices = "Gcash";
			}
			else if(cmbEwallet.SelectedIndex == 1) {
				string choices = "";
				choices = "Paymaya";

			}

			else if (cmbEwallet.SelectedIndex == 2)
			{
				string choices = "";
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
	}
}
