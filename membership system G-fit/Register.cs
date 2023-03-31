using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace membership_system_G_fit
{
	
	public partial class Register : Form
	{
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
		String password = "123";
		String database = "membership";


		public string FirstName (string n)
		{
			n = txtFirstname.Text;
			return n;
			
	    }
		
		public Register()
		{
			InitializeComponent();
			
		}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void customizeButtons1_Click(object sender, EventArgs e)
		{
			string input = txtBarangay.Text;
			string input2 = txtZipCode.Text;

				if(txtFirstname.Text == "" || txtLastname.Text == "" || txtAddress.Text == "" || txtBarangay.Text == "" || txtCity.Text == "" || txtAge.Text == "" || cmbGender.Text == "")
			  {
				  MessageBox.Show("Missing information", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
			  }
		        else if (Regex.IsMatch(input, "^[a-zA-Z]+$") || Regex.IsMatch(input2, "^[a-zA-Z]+$"))
			    {
			    	MessageBox.Show("Invalid input in " + "Barangay" + " and " + " Zipcode", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
		     	}

			    else
		     	  {
				  try
				  {
					  MessageBox.Show("Successfully Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
					  //Opening a database
				     	  sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;

						  sqlConn.Open();
						  sqlQuery = "INSERT INTO membership.members (first_name, middle_name, last_name, age, gender, address, barangay, city, zipcode, date_of_registration)" +
									  "VALUES('"+txtFirstname.Text+"', '"+txtMiddlename.Text+"', '"+txtLastname.Text+"', '"+txtAge.Text+"', '"+cmbGender.Text+"', '"+txtAddress.Text+"', '"+txtBarangay.Text+"', '"+txtCity.Text+"', '"+txtZipCode.Text+"', '"+dateRegistration.Text+"')";

						  sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
						  sqlReader = sqlCmd.ExecuteReader();
						  sqlConn.Close();

					  this.Hide();
					  Register2 register2 = new Register2();
					  register2.ShowDialog();
					  this.Show();
				  }
				  catch(Exception ex)
				  {
					  MessageBox.Show(ex.Message);
				  }
				  finally
				  {

					  sqlConn.Close();
				  }
			  }
			 
		
		

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

		private void label13_Click(object sender, EventArgs e)
		{
			
		}

		private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		internal string FirstName()
		{
			throw new NotImplementedException();
		}
	}
}
