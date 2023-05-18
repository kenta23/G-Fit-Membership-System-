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

		private string firstname;
		private string lastname;
		private string middlename;
		private string address;
		private string barangay;
		private string zipcode;
		private string city;
		private string age;
		private string gender;
		private string joindate;

		public string firstnameGet { get; set; }


		public Register()
		{
			//string firstnameText, string lastnameText, string  middlenameText, string addressText, string barangayText, string cityText, string zipcodeText, string ageText, string dateValue
			InitializeComponent();

		/*	firstname = firstnameText;
			lastname = lastnameText;
			middlename = middlenameText;
			address = addressText;
			barangay = barangayText;
			city = cityText;
			zipcode = zipcodeText;
			age = ageText;
			joindate = dateValue; */

	}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Starting_page start = new Starting_page();
			start.Show();
		}

		private void customizeButtons1_Click(object sender, EventArgs e)
		{
			string barangay = txtBarangay.Text;
			string zipcode = txtZipCode.Text;

			if (txtFirstname.Text == "" || txtLastname.Text == "" || txtAddress.Text == "" || txtBarangay.Text == "" || txtCity.Text == "" || txtAge.Text == "" || cmbGender.Text == "")
			{
				MessageBox.Show("Fill out all the fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(Regex.IsMatch(txtAge.Text, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("Invalid input in Age", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (Regex.IsMatch(barangay, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("Invalid input in " + "Barangay", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(Regex.IsMatch(zipcode, "^[a-zA-Z]+$"))
			{
				MessageBox.Show("Invalid input in " + "Zipcode", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


					txtFirstname.Text = firstnameGet;

					
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

		private void Register_Load(object sender, EventArgs e)
		{
			firstname = txtFirstname.Text;
			lastname = txtLastname.Text;
			middlename = txtMiddlename.Text;
			address = txtAddress.Text;
			barangay = txtBarangay.Text;
			city = txtCity.Text;
			zipcode = txtZipCode.Text;
			age = txtAge.Text;
			joindate = dateRegistration.Text;

		}
	}
}
