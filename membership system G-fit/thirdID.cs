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
	public partial class thirdID : Form
	{
		public thirdID()
		{
			InitializeComponent();
		}

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
		String password = "ramospogi23";
		String database = "membership";


		public String name { get; set; }


		private void thirdID_Load(object sender, EventArgs e)
		{
			string nameData = "";
			string membertype = "";
			try
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();

				sqlQuery = "SELECT first_name, last_name, member_type from membership.members WHERE username = '" + name + "' ";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

				sqlReader = sqlCmd.ExecuteReader();

				//sqlCmd.ExecuteNonQuery();
				while (sqlReader.Read())
				{
					nameData = sqlReader.GetString("first_name") + " " + sqlReader.GetString("last_name");
					membertype = sqlReader.GetString("member_type");
					// retrieve other column values as needed
				}

				lblName.Text = nameData;
				lblType.Text = membertype;


				sqlConn.Close();
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			lblusername.Text = name;
		}

		private void customizeButtons4_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Profile().Show();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			DialogResult choice = MessageBox.Show("Print your ID?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (choice == DialogResult.Yes)
			{
				MessageBox.Show("The admin has received your request, We will ask you to claim your ID here once your ID been proccessed, Thank you!", "ID Request", MessageBoxButtons.OK, MessageBoxIcon.None);
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
	}
}
