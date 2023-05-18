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
using static Mysqlx.Expect.Open.Types.Condition.Types;

namespace membership_system_G_fit
{
	public partial class Archives : Form
	{
		public Archives()
		{
			InitializeComponent();
		}

		//DATABASE CONNECTION
		MySqlConnection sqlConn = new MySqlConnection();
		MySqlCommand sqlCmd;
		String sqlQuery;
		MySqlDataReader sqlReader;

		String server = "127.0.0.1";
		String username = "root";
		String password = "123";
		String database = "membership";

		private void label1_Click(object sender, EventArgs e)
		{
			DialogResult logout = MessageBox.Show("Are you sure you want to exit", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (logout == DialogResult.Yes)
			{
				this.Hide();
				new Starting_page().Show();
			}
		}

		private void uploadData()
		{
			try
			{

				sqlQuery = "SELECT * FROM membership.archives";
				DBconn.displayDB(sqlQuery, datagridviewArchives);
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Archives_Load(object sender, EventArgs e)
		{
			uploadData();
		}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}

		private void btnRetrieve_Click(object sender, EventArgs e)
		{
			int key = Convert.ToInt32(datagridviewArchives.SelectedRows[0].Cells[0].Value.ToString());

			if (key == 0)
			{
				MessageBox.Show("Select member to be deleted");
			}
			else
			{
				try
				{
					DialogResult choice = MessageBox.Show("Are you sure you want to retrieve this member?", "Member Retrieval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (choice == DialogResult.Yes)
					{

						sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
						sqlConn.Open();
						//member going back to membership 
						string relocate = "INSERT INTO membership.members (first_name, middle_name, last_name, age, gender, address, barangay, city, zipcode, date_of_registration) " +
							"VALUES('" + txtFirstname.Text + "', '" + txtMiddlename.Text + "', '" + txtLastname.Text + "', '" + txtAge.Text + "', '" + cmbGender.Text + "', '" + txtAddress.Text + "', '" + txtBarangay.Text + "', '" + txtCity.Text + "', '" + txtZipCode.Text + "', '" + joinDate.Text + "')";
						MySqlCommand archivecommand = new MySqlCommand(relocate, sqlConn);
						archivecommand.ExecuteNonQuery();

						MessageBox.Show("Account retrieved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


						//Delete member from archive after 
						string deleteData = "DELETE FROM membership.archives WHERE customer_ID = " + key + ";";

						MySqlCommand deleteCommand = new MySqlCommand(deleteData, sqlConn);
						deleteCommand.ExecuteNonQuery();

						uploadData();

						sqlConn.Close();

					}
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

		private void datagridviewArchives_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblCustomerID.Text = datagridviewArchives.SelectedRows[0].Cells[0].Value.ToString();
			txtFirstname.Text = datagridviewArchives.SelectedRows[0].Cells[1].Value.ToString();
			txtMiddlename.Text = datagridviewArchives.SelectedRows[0].Cells[2].Value.ToString();
			txtLastname.Text = datagridviewArchives.SelectedRows[0].Cells[3].Value.ToString();
			txtAge.Text = datagridviewArchives.SelectedRows[0].Cells[4].Value.ToString();
			cmbGender.Text = datagridviewArchives.SelectedRows[0].Cells[5].Value.ToString();
			txtAddress.Text = datagridviewArchives.SelectedRows[0].Cells[6].Value.ToString();
			txtBarangay.Text = datagridviewArchives.SelectedRows[0].Cells[7].Value.ToString();
			txtCity.Text = datagridviewArchives.SelectedRows[0].Cells[8].Value.ToString();
			txtZipCode.Text = datagridviewArchives.SelectedRows[0].Cells[9].Value.ToString();
			joinDate.Text = datagridviewArchives.SelectedRows[0].Cells[12].Value.ToString();
			//imageLocation = dataGridMembers.SelectedRows[0].Cells[14].Value.ToString();
			//pictureBox.ImageLocation = dataGridMembers.SelectedRows[0].Cells[13].Value.ToString();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult choice = MessageBox.Show("Are you sure you want to delete this member?", "Member Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(choice == DialogResult.Yes)
			{
				DBconn.DeleteMembersFromArchive(lblCustomerID.Text);
			}
			uploadData();
		}
	}
}
