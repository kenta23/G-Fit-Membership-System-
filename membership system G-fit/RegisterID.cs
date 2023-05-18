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
	public partial class RegisterID : Form
	{
		public RegisterID()
		{
			InitializeComponent();
		}

		public String username { get; set; }

		string sqlquery;

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			/*this.Hide();
			firstID firstid = new firstID();
			firstid.Show(); */
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			//second
			this.Hide();
		}

		private void RegisterID_Load(object sender, EventArgs e)
		{
			sqlquery = "SELECT first_name, last_name, date_of_registration, paid, member_type FROM membership.members";
			DBconn.displayDB(sqlquery, dataGridView1);

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			lblMembertype.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
		 DialogResult choice =	MessageBox.Show("Create ID for this member ?", "ID Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


			if(choice == DialogResult.Yes)
			{
				MessageBox.Show("ID Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void customizeButtons2_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			DialogResult exit;

			exit = MessageBox.Show("Do you want to exit?", "Exit page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if(exit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
