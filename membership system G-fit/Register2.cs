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

namespace membership_system_G_fit
{
	public partial class Register2 : Form
	{


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

		public string txtzipcode { get; set; }

		public string membershipDataString { get; set; }
		
		public Register2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//SILVER MEMBER

			membershipData.Instance.SharedData = "Monthly";

			this.Hide();
			Register register = new Register();
			register.membershipDataGet = membershipData.Instance.SharedData;
			register.ShowDialog();
			this.Show();
		}
		private void button2_Click(object sender, EventArgs e)
		{
			//GOLD MEMBER

			membershipData.Instance.SharedData = "6 Months";


			this.Hide();
			Register register = new Register();
			register.membershipDataGet = membershipData.Instance.SharedData;
			register.ShowDialog();
			this.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			//PLATINUM MEMBER 

			membershipData.Instance.SharedData = "12 Months";

			this.Hide();
			Register register = new Register();
			register.membershipDataGet = membershipData.Instance.SharedData;
			register.ShowDialog();
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
