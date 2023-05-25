using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Mysqlx.Expect.Open.Types.Condition.Types;


namespace membership_system_G_fit
{
	public partial class members : Form
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

		public members()
		{
			InitializeComponent();
		}


		public string firstname, middlename, lastname, age, gender, address, city, joindate;
		public int barangay, zipcode;



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

		private void dataGridMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}



		public void uploadData()
		{
			DateTime currentTime = DateTime.Now;
			DateTime onMinute = currentTime.AddMinutes(-1); //1 minute 


			try
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();
				sqlCmd.Connection = sqlConn;
				sqlCmd.CommandText = "SELECT * FROM membership.members";
				sqlReader = sqlCmd.ExecuteReader();
				sqlTable.Load(sqlReader);
				sqlReader.Close();
				sqlConn.Close();

				dataGridMembers.DataSource = sqlTable;
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void Clear()
		{
			txtFirstname.Text = "";
			txtMiddlename.Text = "";
			txtLastname.Text = "";
			txtAge.Text = "";
			cmbGender.Text = "";
			txtAddress.Text = "";
			txtBarangay.Text = "";
			txtZipCode.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
			txtCity.Text = "";
			joinDate.Text = "";
		}
		private void display()
		{
			string sqlQuery = "SELECT * FROM membership.members";
			DBconn.displayDB(sqlQuery, dataGridMembers);
		}
		private void members_Load(object sender, EventArgs e)
		{
			display();


		}

		private void customizeButtons4_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}

		private void customizeButtons3_Click(object sender, EventArgs e)
		{
			Clear();

		}

		public void UpdateInfo()
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			if (dataGridMembers.SelectedCells.Count == 0)
			{
				MessageBox.Show("No Data has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			string input = txtBarangay.Text;
			string input2 = txtZipCode.Text;

			if (Regex.IsMatch(input, "^[a-zA-Z]+$") || Regex.IsMatch(input2, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("Invalid input in " + input + " and " + input2, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{

					memberClass memberclass = new memberClass(lblCustomerID.Text, txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, txtAge.Text, cmbGender.Text, txtAddress.Text, txtBarangay.Text, txtCity.Text, txtZipCode.Text, joinDate.Text);
					DBconn.Updatemembers(memberclass, lblCustomerID.Text);
					display();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}

		public void dataGridMembers_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			try
			{

				string connectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				string sql = "SELECT picture FROM membership.members WHERE customer_ID = @id";

				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					using (MySqlCommand command = new MySqlCommand(sql, connection))
					{
						command.Parameters.AddWithValue("@id", lblCustomerID.Text); // replace 1 with the ID of the image you want to retrieve

						connection.Open();

						string imageLocation = (string)command.ExecuteScalar();

						//pictureboxMembers.ImageLocation = imageLocation;

						connection.Close();
					}
				}
			}

			catch (Exception ex)
			{

				//MessageBox.Show(ex.Message);
			}
			finally
			{
				sqlConn.Close();
			}

			lblCustomerID.Text = dataGridMembers.SelectedRows[0].Cells[0].Value.ToString();
			txtFirstname.Text = dataGridMembers.SelectedRows[0].Cells[1].Value.ToString();
			txtMiddlename.Text = dataGridMembers.SelectedRows[0].Cells[2].Value.ToString();
			txtLastname.Text = dataGridMembers.SelectedRows[0].Cells[3].Value.ToString();
			txtAge.Text = dataGridMembers.SelectedRows[0].Cells[4].Value.ToString();
			cmbGender.Text = dataGridMembers.SelectedRows[0].Cells[5].Value.ToString();
			txtAddress.Text = dataGridMembers.SelectedRows[0].Cells[6].Value.ToString();
			txtBarangay.Text = dataGridMembers.SelectedRows[0].Cells[7].Value.ToString();
			txtCity.Text = dataGridMembers.SelectedRows[0].Cells[8].Value.ToString();
			txtZipCode.Text = dataGridMembers.SelectedRows[0].Cells[9].Value.ToString();
			txtUsername.Text = dataGridMembers.SelectedRows[0].Cells[10].Value.ToString();
			txtPassword.Text = dataGridMembers.SelectedRows[0].Cells[11].Value.ToString();
			joinDate.Text = dataGridMembers.SelectedRows[0].Cells[12].Value.ToString();
			//imageLocation = dataGridMembers.SelectedRows[0].Cells[14].Value.ToString();
			//pictureboxMembers.ImageLocation = dataGridMembers.SelectedRows[0].Cells[13].Value.ToString();




		}


		private void InfoContainer_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			int key = Convert.ToInt32(dataGridMembers.SelectedRows[0].Cells[0].Value.ToString());

			if (key == 0)
			{
				MessageBox.Show("Select member to move to archive");
			}
			else
			{

				try
				{

					sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
					sqlConn.Open();


					//member moved to archive first 
					string archiveMembers = "INSERT INTO membership.archives (first_name, middle_name, last_name, age, gender, address, barangay, city, zipcode, username, password, date_of_registration) " +
						"VALUES('" + txtFirstname.Text + "', '" + txtMiddlename.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + cmbGender.Text + "', '" + txtAddress.Text + "', '" + txtBarangay.Text + "', '" + txtCity.Text + "', '" + txtZipCode.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + joinDate.Text + "')";

					MySqlCommand archivecommand = new MySqlCommand(archiveMembers, sqlConn);

					archivecommand.ExecuteNonQuery();


					//Delete member after 
					sqlCmd.Connection = sqlConn;
					sqlCmd.CommandText = "DELETE FROM members WHERE customer_ID = " + key + ";";

					sqlCmd.ExecuteNonQuery();
					sqlConn.Close();

					MessageBox.Show("Member moved to Archived!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					uploadData();


					sqlConn.Close();

					Clear();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					sqlConn.Close();
				}
			}

			uploadData();

		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				DataView view = sqlTable.DefaultView;
				view.RowFilter = string.Format("first_name like '%{0}%'", txtSearch.Text);
				dataGridMembers.DataSource = view.ToTable();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string patternLettersOnly = @"^[^\d]+$";
			string patternNumbersOnly = @"^[^\p{L}]+$";



			if (txtFirstname.Text == "" || txtLastname.Text == "" || txtAddress.Text == "" || txtBarangay.Text == "" || txtCity.Text == "" || txtAge.Text == "" || cmbGender.Text == "")
			{
				MessageBox.Show("Fill out all the fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if (!Regex.IsMatch(txtFirstname.Text, patternLettersOnly))
			{
				MessageBox.Show("Names should not contain any numbers", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtMiddlename.Text != "" && !Regex.IsMatch(txtMiddlename.Text, patternLettersOnly))
			{
				MessageBox.Show("Names should not contain any numbers", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (!Regex.IsMatch(txtLastname.Text, patternLettersOnly))
			{
				MessageBox.Show("Names should not contain any numbers", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (!Regex.IsMatch(txtAge.Text, patternNumbersOnly))
			{
				MessageBox.Show("Invalid input in Age", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else if (!Regex.IsMatch(cmbGender.Text, patternLettersOnly))
			{
				MessageBox.Show("Invalid Gender", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (cmbGender.Text != "Male" && cmbGender.Text != "Female" && cmbGender.Text != "Others")
			{
				MessageBox.Show("Please Select a valid Gender", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (Regex.IsMatch(txtBarangay.Text, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("Invalid input in " + "Barangay", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (!Regex.IsMatch(txtCity.Text, patternLettersOnly))
			{
				MessageBox.Show("Country name should not contain any numbers or characters", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			else if (Regex.IsMatch(txtZipCode.Text, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("Invalid input in " + "Zipcode", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


			else
			{
				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();

				try
				{
					sqlQuery = "INSERT INTO membership.members (first_name, middle_name, last_name, age, gender, address, barangay, city, zipcode, date_of_registration) " +
							   "VALUES('" + txtFirstname.Text + "', '" + txtMiddlename.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + cmbGender.Text + "', '" + txtAddress.Text + "', '" + txtBarangay.Text + "', '" + txtCity.Text + "', '" + txtZipCode.Text + "', '" + joinDate.Text + "')";


					sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
					sqlReader = sqlCmd.ExecuteReader();
					sqlConn.Close();

					Clear();

					MessageBox.Show("Added member successfully!", "New member!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

			uploadData();
		}

		private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox_Click(object sender, EventArgs e)
		{

		}
	}
}
