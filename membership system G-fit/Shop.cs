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
	public partial class Shop : Form
	{
		public Shop()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
		public String buttonString (String n)
		{
			return n;
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

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard_members().Show();
		}

		private void panelProducts_Paint(object sender, PaintEventArgs e)
		{
			

			customizeButtons1.Click += ButtonClick;
			customizeButtons2.Click += ButtonClick;
			customizeButtons3.Click += ButtonClick;
			customizeButtons4.Click += ButtonClick;
			customizeButtons5.Click += ButtonClick;
			customizeButtons6.Click += ButtonClick;
			customizeButtons7.Click += ButtonClick;
			customizeButtons8.Click += ButtonClick;
			customizeButtons9.Click += ButtonClick;
			customizeButtons10.Click += ButtonClick;
			customizeButtons11.Click += ButtonClick;
			customizeButtons12.Click += ButtonClick;
			customizeButtons13.Click += ButtonClick;
			customizeButtons14.Click += ButtonClick;
			customizeButtons15.Click += ButtonClick;
			customizeButtons16.Click += ButtonClick;
			customizeButtons17.Click += ButtonClick;
			customizeButtons18.Click += ButtonClick;

		
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			//get the value of text in each buttons
			
			

			DialogResult choice =	MessageBox.Show("Buy this Product?", "Shop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(choice == DialogResult.Yes)
			{
				MessageBox.Show("Processing, Please wait. Thank you", "Shop", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
	
		}

		private void customizeButtons1_Click(object sender, EventArgs e)
		{

		}
		
	}

	
}
