using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace membership_system_G_fit
{
	public partial class Payment : Form
	{
		public Payment()
		{
			InitializeComponent();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Dashboard().Show();
		}

		private void display()
		{
			string sqlQuery = "SELECT customer_ID, first_name, middle_name, last_name, paid, date_of_registration, member_type FROM membership.members WHERE paid IS NOT NULL AND member_type IS NOT NULL";
			DBconn.displayDB(sqlQuery, dataGridView1);
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblMemberName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
			lblMembershipType.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
			lblPaidDate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
		}

		private void Payment_Load(object sender, EventArgs e)
		{
			display();

			
		}

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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
