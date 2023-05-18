using System;
using System.Collections;
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
	public partial class Staff : Form
	{
		public Staff()
		{
			InitializeComponent();
		}

		

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

		private void display()
		{
			string sqlQuery = "SELECT * FROM membership.staff";
			DBconn.displayDB(sqlQuery, dataGridEmployees);
		}
		public void Clear()
		{
			lblID.Text = "";
			txtFirstname.Text = "";
			txtLastname.Text = "";
			txtContact.Text = "";
			txtAddress.Text = "";
			cmbPosition.Text = "";
			txtAge.Text = "";
			txtUsername.Text = "";
			txtPassword.Text = "";
		}
	     string gender = "";

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if(rdbMale.Checked)
			{
				gender = "Male";
			}
			else if(rdbFemale.Checked) 
			{
				gender = "Female";
			}
			else
			{
				gender = "Others";
			}

			if (txtFirstname.Text == "" || txtLastname.Text == "" || txtContact.Text == "" || txtAddress.Text == "" || txtAge.Text == "" || cmbPosition.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Complete all the fields", "Incomplete input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{

				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();

				string existedAccount = "SELECT * FROM membership.staff WHERE username=@username AND password=@password";
				MySqlCommand command = new MySqlCommand(existedAccount, sqlConn);
				//command.Parameters.AddWithValue("@firstname", txtFirstname.Text);
				//command.Parameters.AddWithValue("@lastname", txtLastname.Text);
				command.Parameters.AddWithValue("@username", txtUsername.Text);
				command.Parameters.AddWithValue("@password", txtPassword.Text);

				sqlReader = command.ExecuteReader();
				

				if(sqlReader.HasRows) {
					MessageBox.Show("This Username and Password already existed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					
				}

				else
				{
					sqlReader.Close();


					try
					{
						sqlQuery = "INSERT INTO membership.staff (firstname, lastname, contact, address, Gender, age, position, username, password) " +
								   "VALUES('" + txtFirstname.Text + "', '" + txtLastname.Text + "', '" + txtContact.Text + "', '" + txtAddress.Text + "', '" + gender + "', '" + txtAge.Text + "', '" + cmbPosition.Text + "', '" + txtUsername.Text + "',  '" + txtPassword.Text + "')";


						sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
						sqlReader = sqlCmd.ExecuteReader();


						MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						sqlReader.Close();


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
		  }
			


				display();
				Clear();
			
			sqlConn.Close();

    }

		private void dataGridEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblID.Text = dataGridEmployees.SelectedRows[0].Cells[0].Value.ToString();
			txtFirstname.Text = dataGridEmployees.SelectedRows[0].Cells[1].Value.ToString();
			txtLastname.Text = dataGridEmployees.SelectedRows[0].Cells[2].Value.ToString();	
			txtLastname.Text = dataGridEmployees.SelectedRows[0].Cells[2].Value.ToString();
			txtContact.Text = dataGridEmployees.SelectedRows[0].Cells[3].Value.ToString();
			txtAddress.Text = dataGridEmployees.SelectedRows[0].Cells[4].Value.ToString();
			gender = dataGridEmployees.SelectedRows[0].Cells[5].Value.ToString();
			txtAge.Text = dataGridEmployees.SelectedRows[0].Cells[6].Value.ToString();
			cmbPosition.Text = dataGridEmployees.SelectedRows[0].Cells[7].Value.ToString();
			//txtUsername.Text = dataGridEmployees.SelectedRows[0].Cells[8].Value.ToString();
			//txtPassword.Text = dataGridEmployees.SelectedRows[0].Cells[9].Value.ToString();
		}

		private void dataGridEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void Staff_Load(object sender, EventArgs e)
		{
			display();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
		    sqlConn.Open();

				try
				 {
				  
				   sqlCmd.Connection = sqlConn;
				   sqlQuery = "UPDATE membership.staff SET firstname = @firstname, contact = @contact, address =@address, Gender =@gender, age = @age, position = @position, username = @username, password = @password WHERE id = @idValue";
										
				   sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
				  

				   sqlCmd.CommandType = CommandType.Text;

				   sqlCmd.Parameters.AddWithValue("@idValue", lblID.Text);
			       sqlCmd.Parameters.AddWithValue("@firstname", txtFirstname.Text);
				   sqlCmd.Parameters.AddWithValue("@lastname", txtLastname.Text);
				   sqlCmd.Parameters.AddWithValue("@contact", txtContact.Text);
				   sqlCmd.Parameters.AddWithValue("@address", txtAddress.Text);
				   sqlCmd.Parameters.AddWithValue("@gender", gender);
				   sqlCmd.Parameters.AddWithValue("@age", txtAge.Text);
				   sqlCmd.Parameters.AddWithValue("@position", cmbPosition.Text);
				   sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text);
				   sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text);


				sqlCmd.ExecuteNonQuery(); //for update, insert and deleting data 
				  sqlConn.Close();

				  MessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			   }
			   catch (Exception ex)
			   {
				   MessageBox.Show(ex.Message);	
			   }
			   finally
			   {
				   sqlConn.Close();
			   }

			display();
			Clear();

		}
	

		private void btnRemove_Click(object sender, EventArgs e)
		{
			int key = Convert.ToInt32(dataGridEmployees.SelectedRows[0].Cells[0].Value.ToString());

			if (key == 0)
			{
				MessageBox.Show("Select member to be deleted");
			}
			else
			{
				try
				{
					MySqlCommand sqlcmd = new MySqlCommand();
					sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
					sqlConn.Open();
					sqlCmd.Connection = sqlConn;
					sqlCmd.CommandText = "DELETE FROM staff WHERE id = " + key + ";";



					sqlCmd.ExecuteNonQuery();
					sqlConn.Close();

					MessageBox.Show("Member deleted Successfully!", "Member Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
					display();

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
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}

		//don't delete!!
		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void cmbPosition_SelectedValueChanged(object sender, EventArgs e)
		{
			if(cmbPosition.SelectedItem != null)
			{
				lblUsername.Visible = true;
				lblPassword.Visible = true;
				txtUsername.Visible = true;
				txtPassword.Visible = true;
			}
			else
			{
				lblUsername.Visible = false;
				lblPassword.Visible = false;
				txtUsername.Visible = false;
				txtPassword.Visible = false;
			}
			
		}

		private void txtUsername_TextChanged(object sender, EventArgs e)
		{

		}

		private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
