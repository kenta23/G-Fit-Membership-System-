using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace membership_system_G_fit
{
	public partial class Register2 : Form
	{
	
		public string txtzipcode { get; set; }
		
		public Register2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			createAccount createaccount = new createAccount();
			createaccount.ShowDialog();
			this.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			createAccount createaccount = new createAccount();
			createaccount.ShowDialog();
			this.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Hide();
			createAccount createaccount = new createAccount();
			createaccount.ShowDialog();
			this.Show();
		}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Register register = new Register();
			register.Show();
		}

		private void label12_Click(object sender, EventArgs e)
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
