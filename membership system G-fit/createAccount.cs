﻿using System;
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
	public partial class createAccount : Form
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


		public createAccount()
		{
			InitializeComponent();
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

		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		private void btnSignup_Click(object sender, EventArgs e)
		{
			//Register register = new Register();



			//Opening a database
		
			if (txtUsername.Text == "")
			{
				MessageBox.Show("Please input your username", "Username Required!", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else if (txtPassword.Text == "" && txtConfirmPass.Text == "")
			{
				MessageBox.Show("Please input your Password", "Password Required!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtConfirmPass.Text == "")
			{
				MessageBox.Show("Please confirm your Password", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtPassword.Text != txtConfirmPass.Text)
			{
				MessageBox.Show("Confirm Password correctly", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtPassword.Text.Length <= 8 || txtPassword.Text.Length <= 8)
			{
				MessageBox.Show("Password is too short", "Password not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		 else {

				sqlConn.ConnectionString = "server =" + server + "; user id =" + username + "; password =" + password + "; database =" + database;
				sqlConn.Open();

				string existedAccount = "SELECT * FROM membership.members WHERE username=@username AND password=@password";
				MySqlCommand command = new MySqlCommand(existedAccount, sqlConn);
				
				command.Parameters.AddWithValue("@username", txtUsername.Text);
				command.Parameters.AddWithValue("@password", txtPassword.Text);

				sqlReader = command.ExecuteReader();


				if (sqlReader.HasRows)
				{
					MessageBox.Show("This Username and Password already existed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				}

				else
				{
					sqlReader.Close();
					try
			      {
					
					string updateMember = "UPDATE members SET username = '" + txtUsername.Text + "', password = '" + txtPassword.Text + "' ORDER BY customer_ID DESC LIMIT 1"; //pick the last row

					MySqlCommand commandMember = new MySqlCommand(updateMember, sqlConn);
					commandMember.ExecuteNonQuery();

					MessageBox.Show("Successfully Created your Account!", "Membership Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
					Starting_page start = new Starting_page();
					start.ShowDialog();

					sqlConn.Close();
					txtUsername.Text = "";
					txtPassword.Text = "";
					txtConfirmPass.Text = "";

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
			sqlConn.Close();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			/*if(checkBox1.Checked)
			{
				txtPassword.PasswordChar = '\0';
				txtConfirmPass.PasswordChar = '\0';
			}

			else
			{
				txtPassword.PasswordChar = '*';
				txtConfirmPass.PasswordChar = '*';
			} ALREADY DELETED  */
		}

		private void createAccount_Load(object sender, EventArgs e)
		{
			Register register = new Register();
			string firstnameText = register.firstnameGet;
			//label8.Text = firstnameText;
		}
	}
}
