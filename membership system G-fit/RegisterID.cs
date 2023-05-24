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
		string membertype;

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
		    membertype = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
			lblName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
			lblMembertype.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

			lblName.Visible = true;
			lblMembertype.Visible = true;

			Color Platinum = ColorTranslator.FromHtml("#ff5253");
			Color Silver = ColorTranslator.FromHtml("#b1a8a9");
			Color Gold = ColorTranslator.FromHtml("#feb71d");


			if (membertype == "Monthly")
			{
				IdSilver.Visible = true;
				idGold.Visible = false;
				idPlatinum.Visible = false;
				lblName.BackColor = Silver;
				lblMembertype.BackColor = Silver;

			}
			else if (membertype == "6 Months")
			{
				idGold.Visible = true;
			    IdSilver.Visible = false;
				idPlatinum.Visible = false;
				lblName.BackColor = Gold;
				lblMembertype.BackColor = Gold;

			}
			else if (membertype == "12 Months")
			{
				idPlatinum.Visible = true;
				idGold.Visible = false;
				IdSilver.Visible = false;
				lblName.BackColor = Platinum;
				lblMembertype.BackColor = Platinum;

			}
			else
			{
				IdSilver.Visible = false;
				idGold.Visible = false;
				idPlatinum.Visible = false;
				lblName.Text = "";
			}



		}

		private void btnCreate_Click(object sender, EventArgs e)
		{

			if (lblMembertype.Text == "")
			{
				MessageBox.Show("ID not available for the current member type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}


			else
			{
				DialogResult choice = MessageBox.Show("Create ID for this member ?", "ID Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


				if (choice == DialogResult.Yes)
				{
					MessageBox.Show("ID Registration successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

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

			if (exit == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
