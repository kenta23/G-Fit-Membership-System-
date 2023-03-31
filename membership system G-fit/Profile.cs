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
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace membership_system_G_fit
{
	public partial class Profile : Form
	{
		public Profile()
		{
			InitializeComponent();
		}

		public String account { get; set; }



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
		private void label14_Click(object sender, EventArgs e)
		{

		}
		public void uploadData()
		{
			try
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();
				sqlCmd.Connection = sqlConn;


				sqlCmd.CommandText = "SELECT customer_ID, first_name, middle_name, last_name, age, gender, address,barangay, city, zipcode, username, password, date_of_registration, picture, member_type  FROM membership.members WHERE first_name = '"+ account + "'";
				sqlReader = sqlCmd.ExecuteReader();
					
					
					
				sqlTable.Load(sqlReader);
				dataGridView1.DataSource = sqlTable;

				sqlReader.Close();
				sqlConn.Close();

			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void Profile_Load(object sender, EventArgs e)
		{
			uploadData();
			lblusername.Text = account;
		}

		private void lblExit_Click(object sender, EventArgs e)
		{
			DialogResult exit;

			exit = MessageBox.Show("Do you want to exit?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(exit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void browseImage_Click(object sender, EventArgs e)
		{
					
			String imageLocation = "";
			try
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All Files(*.*)|*.*";

				if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					imageLocation = dialog.FileName;
					picture.ImageLocation = imageLocation;
				}

				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();
				sqlQuery = "UPDATE members SET picture = '" + imageLocation + "' ORDER BY customer_ID DESC LIMIT 1";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);	
				sqlCmd.ExecuteNonQuery();

			
				sqlConn.Close();

				uploadData();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//Retrieving values from the database
			lblFirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			lblMiddlename.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			lblLastname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			lblAge.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			lblGender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
			lblAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
			lblBarangay.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
			lblCity.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
			lblZipcode.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
			lblUser.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
			lblDateReg.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
			lblMemberType.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();

		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label0_Click(object sender, EventArgs e)
		{

		}

		private void lblFirstname_Click(object sender, EventArgs e)
		{

		}

		string nameData = "";
		string membertype = "";

		private void btnProfile_Click(object sender, EventArgs e)
		{

		/*	try
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();

				sqlQuery = "SELECT first_name, last_name, member_type from membership.members WHERE username = '" + lblUser.Text + "' ";
				sqlCmd = new MySqlCommand(sqlQuery, sqlConn);

				sqlReader = sqlCmd.ExecuteReader();

				//sqlCmd.ExecuteNonQuery();
				while (sqlReader.Read())
				{
					membertype = sqlReader.GetString("member_type");
					// retrieve other column values as needed
				}


				sqlConn.Close();
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		*/
			 Amount amount = new Amount();

			
 
		/*	if (lblMemberType.Text == "Monthly")
			{
				firstID firstid = new firstID();
				firstid.name = lblusername.Text;
				firstid.Show();
			}

			else if (lblMemberType.Text == "6 Months")
			{
				
				secondID secondid = new secondID();
				secondid.name = lblusername.Text;
				secondid.Show();
			}
		   else if (lblMemberType.Text == "12 Months/Annually")
			{
				
				thirdID thirdid = new thirdID();
				thirdid.name = lblusername.Text;
				thirdid.Show();
			}

			else
			{
				MessageBox.Show("You need to pay your Membership Subscription to get the ID ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

	   */
		}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard_members().Show();
		}

		private void lblusername_Click(object sender, EventArgs e)
		{

		}
	}
}
