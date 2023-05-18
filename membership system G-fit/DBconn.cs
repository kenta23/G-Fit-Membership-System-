using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace membership_system_G_fit
{
	internal class DBconn
	{
		public static MySqlConnection GetConnection()
		{
			string sql = "datasource=127.0.0.1;port=3306;username=root;password=123;database=membership";
			MySqlConnection con = new MySqlConnection(sql);
			try
			{

				con.Open();

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return con;
		}

		public static void Addmember(memberClass val)
		{
			string sql = "INSERT INTO membership.members(first_name, middle_name, last_name, age, gender, address, barangay, city, zipcode, date_of_registration) VALUES (@firstname, @middlename, @lastname, @age, @gender, @address, @barangay, @city, @zipcode, @joinDate)";
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);

			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = val.firstName;
			cmd.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = val.middleName;
			cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = val.lastName;
			cmd.Parameters.Add("@age", MySqlDbType.Int32).Value = val.Age;
			cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = val.Gender;
			cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = val.Address;
			cmd.Parameters.Add("@barangay", MySqlDbType.VarChar).Value = val.Barangay;
			cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = val.City;
			cmd.Parameters.Add("@zipcode", MySqlDbType.VarChar).Value = val.Zipcode;
			cmd.Parameters.Add("@joinDate", MySqlDbType.VarChar).Value = val.JoinDate;


			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Added Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public static void Updatemembers(memberClass members, string id)
		{
			string sql = "UPDATE membership.members SET first_name = @firstname, middle_name=@middlename, last_name=@lastname, age=@age, gender=@gender, address=@address, barangay=@barangay, city=@city, zipcode=@zipcode, date_of_registration=@joindate WHERE customer_ID=@customerID";
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);

			try
		  {
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Add("@customerID", MySqlDbType.Int16).Value = members.customerID;
			cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = members.firstName;
			cmd.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = members.middleName;
			cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = members.lastName;
			cmd.Parameters.Add("@age", MySqlDbType.Int32).Value = members.Age;
			cmd.Parameters.Add("@gender", MySqlDbType.VarChar).Value = members.Gender;
			cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = members.Address;
			cmd.Parameters.Add("@barangay", MySqlDbType.Int32).Value = members.Barangay;
			cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = members.City;
			cmd.Parameters.Add("@zipcode", MySqlDbType.Int32).Value = members.Zipcode;
			cmd.Parameters.Add("@joinDate", MySqlDbType.VarChar).Value = members.JoinDate;
			
			cmd.ExecuteNonQuery();
			MessageBox.Show("Updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public static void DeleteMembers(string id)
		{
			string sql = "DELETE FROM membership.members WHERE customer_ID = @customerID";
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Add("@customerID", MySqlDbType.VarChar).Value = id;
			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Updated Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public static void DeleteMembersFromArchive(string id)
		{
			string sql = "DELETE FROM membership.archives WHERE customer_ID = @customerID";
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql, con);
			cmd.CommandType = CommandType.Text;
			cmd.Parameters.Add("@customerID", MySqlDbType.VarChar).Value = id;
			try
			{
				cmd.ExecuteNonQuery();
				MessageBox.Show("Member deleted succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
		}

		public static void displayDB (string query, DataGridView dgv)
		{
			string sql = query;
			MySqlConnection con = GetConnection();
			MySqlCommand cmd = new MySqlCommand(sql,con);
			MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
			DataTable tbl = new DataTable();
			adp.Fill(tbl);
			dgv.DataSource = tbl;
		}
		
	}
}
