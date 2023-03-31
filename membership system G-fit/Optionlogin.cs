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
	public partial class Optionlogin : Form
	{
		public Optionlogin()
		{
			InitializeComponent();
		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			this.Hide();
		    Loginadmin admin = new Loginadmin();
			admin.Show();
			
		}

		private void btnMembers_Click(object sender, EventArgs e)
		{
			this.Hide();
			new Loginuser().Show();
			

		}
	}
}
