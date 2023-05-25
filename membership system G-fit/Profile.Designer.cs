namespace membership_system_G_fit
{
	partial class Profile
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			lblusername = new Label();
			pictureBox2 = new PictureBox();
			lblExit = new Label();
			label1 = new Label();
			panel2 = new Panel();
			lblPayment = new Label();
			payment = new Label();
			cmbRenewal = new ComboBox();
			label11 = new Label();
			label8 = new Label();
			label2 = new Label();
			cmbStatus = new ComboBox();
			dataGridView1 = new DataGridView();
			lblDateReg = new Label();
			lblBarangay = new Label();
			label19 = new Label();
			lblUser = new Label();
			lblZipcode = new Label();
			lblCity = new Label();
			lblAddress = new Label();
			lblGender = new Label();
			lblAge = new Label();
			lblLastname = new Label();
			lblMiddlename = new Label();
			lblFirstname = new Label();
			label13 = new Label();
			label12 = new Label();
			label10 = new Label();
			label9 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label0 = new Label();
			customizeButtons2 = new customizeButtons();
			btnUpdateStatus = new customizeButtons();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MistyRose;
			panel1.Controls.Add(lblusername);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(lblExit);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1037, 70);
			panel1.TabIndex = 1;
			// 
			// lblusername
			// 
			lblusername.AutoSize = true;
			lblusername.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lblusername.ForeColor = Color.FromArgb(255, 82, 83);
			lblusername.Location = new Point(92, 22);
			lblusername.Name = "lblusername";
			lblusername.Size = new Size(59, 29);
			lblusername.TabIndex = 9;
			lblusername.Text = "User";
			lblusername.Click += lblusername_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			pictureBox2.Location = new Point(30, 9);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(56, 52);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			// 
			// lblExit
			// 
			lblExit.AutoSize = true;
			lblExit.Cursor = Cursors.Hand;
			lblExit.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblExit.ForeColor = Color.Red;
			lblExit.Location = new Point(993, 22);
			lblExit.Name = "lblExit";
			lblExit.Size = new Size(32, 33);
			lblExit.TabIndex = 6;
			lblExit.Text = "X";
			lblExit.Click += lblExit_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Corbel", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 82, 83);
			label1.Location = new Point(442, 19);
			label1.Name = "label1";
			label1.Size = new Size(158, 36);
			label1.TabIndex = 5;
			label1.Text = "Profile View";
			// 
			// panel2
			// 
			panel2.BackColor = Color.Transparent;
			panel2.Controls.Add(lblPayment);
			panel2.Controls.Add(payment);
			panel2.Controls.Add(cmbRenewal);
			panel2.Controls.Add(label11);
			panel2.Controls.Add(label8);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(cmbStatus);
			panel2.Controls.Add(dataGridView1);
			panel2.Controls.Add(lblDateReg);
			panel2.Controls.Add(lblBarangay);
			panel2.Controls.Add(label19);
			panel2.Controls.Add(lblUser);
			panel2.Controls.Add(lblZipcode);
			panel2.Controls.Add(lblCity);
			panel2.Controls.Add(lblAddress);
			panel2.Controls.Add(lblGender);
			panel2.Controls.Add(lblAge);
			panel2.Controls.Add(lblLastname);
			panel2.Controls.Add(lblMiddlename);
			panel2.Controls.Add(lblFirstname);
			panel2.Controls.Add(label13);
			panel2.Controls.Add(label12);
			panel2.Controls.Add(label10);
			panel2.Controls.Add(label9);
			panel2.Controls.Add(label7);
			panel2.Controls.Add(label6);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(label4);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(label0);
			panel2.Location = new Point(28, 105);
			panel2.Name = "panel2";
			panel2.Size = new Size(780, 558);
			panel2.TabIndex = 2;
			panel2.Paint += panel2_Paint;
			// 
			// lblPayment
			// 
			lblPayment.AutoSize = true;
			lblPayment.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblPayment.Location = new Point(618, 33);
			lblPayment.Name = "lblPayment";
			lblPayment.Size = new Size(95, 26);
			lblPayment.TabIndex = 30;
			lblPayment.Text = "Payment:";
			// 
			// payment
			// 
			payment.AutoSize = true;
			payment.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			payment.Location = new Point(526, 33);
			payment.Name = "payment";
			payment.Size = new Size(95, 26);
			payment.TabIndex = 29;
			payment.Text = "Payment:";
			// 
			// cmbRenewal
			// 
			cmbRenewal.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			cmbRenewal.FormattingEnabled = true;
			cmbRenewal.Items.AddRange(new object[] { "Monthly", "6 Months", "12 Months" });
			cmbRenewal.Location = new Point(501, 242);
			cmbRenewal.Name = "cmbRenewal";
			cmbRenewal.Size = new Size(120, 24);
			cmbRenewal.TabIndex = 28;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label11.ForeColor = Color.Black;
			label11.ImageAlign = ContentAlignment.MiddleLeft;
			label11.Location = new Point(363, 238);
			label11.Name = "label11";
			label11.Size = new Size(132, 26);
			label11.TabIndex = 27;
			label11.Text = "Member type:";
			label11.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label8.ForeColor = Color.Black;
			label8.Location = new Point(363, 280);
			label8.Name = "label8";
			label8.Size = new Size(67, 26);
			label8.TabIndex = 20;
			label8.Text = "Status";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.ImageAlign = ContentAlignment.MiddleLeft;
			label2.Location = new Point(199, 417);
			label2.Name = "label2";
			label2.Size = new Size(323, 26);
			label2.TabIndex = 26;
			label2.Text = "Click here to view your Personal info ";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// cmbStatus
			// 
			cmbStatus.Font = new Font("Corbel", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			cmbStatus.FormattingEnabled = true;
			cmbStatus.Items.AddRange(new object[] { "In ", "Out" });
			cmbStatus.Location = new Point(436, 285);
			cmbStatus.Name = "cmbStatus";
			cmbStatus.Size = new Size(121, 23);
			cmbStatus.TabIndex = 19;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.ControlLight;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(30, 456);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(709, 70);
			dataGridView1.TabIndex = 7;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
			// 
			// lblDateReg
			// 
			lblDateReg.AutoSize = true;
			lblDateReg.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblDateReg.ForeColor = Color.Black;
			lblDateReg.Location = new Point(544, 194);
			lblDateReg.Name = "lblDateReg";
			lblDateReg.Size = new Size(0, 23);
			lblDateReg.TabIndex = 23;
			// 
			// lblBarangay
			// 
			lblBarangay.AutoSize = true;
			lblBarangay.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblBarangay.ForeColor = Color.Black;
			lblBarangay.ImageAlign = ContentAlignment.MiddleLeft;
			lblBarangay.Location = new Point(451, 33);
			lblBarangay.Name = "lblBarangay";
			lblBarangay.Size = new Size(0, 23);
			lblBarangay.TabIndex = 25;
			lblBarangay.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label19.ForeColor = Color.Black;
			label19.ImageAlign = ContentAlignment.MiddleLeft;
			label19.Location = new Point(361, 30);
			label19.Name = "label19";
			label19.Size = new Size(99, 26);
			label19.TabIndex = 24;
			label19.Text = "Barangay:";
			label19.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblUser
			// 
			lblUser.AutoSize = true;
			lblUser.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblUser.ForeColor = Color.Black;
			lblUser.ImageAlign = ContentAlignment.MiddleLeft;
			lblUser.Location = new Point(467, 154);
			lblUser.Name = "lblUser";
			lblUser.Size = new Size(0, 23);
			lblUser.TabIndex = 22;
			lblUser.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblZipcode
			// 
			lblZipcode.AutoSize = true;
			lblZipcode.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblZipcode.ForeColor = Color.Black;
			lblZipcode.ImageAlign = ContentAlignment.MiddleLeft;
			lblZipcode.Location = new Point(442, 114);
			lblZipcode.Name = "lblZipcode";
			lblZipcode.Size = new Size(0, 23);
			lblZipcode.TabIndex = 20;
			lblZipcode.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblCity
			// 
			lblCity.AutoSize = true;
			lblCity.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblCity.ForeColor = Color.Black;
			lblCity.ImageAlign = ContentAlignment.MiddleLeft;
			lblCity.Location = new Point(406, 74);
			lblCity.Name = "lblCity";
			lblCity.Size = new Size(0, 23);
			lblCity.TabIndex = 19;
			lblCity.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblAddress
			// 
			lblAddress.AutoSize = true;
			lblAddress.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblAddress.ForeColor = Color.Black;
			lblAddress.Location = new Point(103, 238);
			lblAddress.Name = "lblAddress";
			lblAddress.Size = new Size(0, 23);
			lblAddress.TabIndex = 17;
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblGender.ForeColor = Color.Black;
			lblGender.Location = new Point(94, 201);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(0, 23);
			lblGender.TabIndex = 16;
			// 
			// lblAge
			// 
			lblAge.AutoSize = true;
			lblAge.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblAge.ForeColor = Color.Black;
			lblAge.Location = new Point(66, 164);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(0, 23);
			lblAge.TabIndex = 15;
			// 
			// lblLastname
			// 
			lblLastname.AutoSize = true;
			lblLastname.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblLastname.ForeColor = Color.Black;
			lblLastname.Location = new Point(123, 126);
			lblLastname.Name = "lblLastname";
			lblLastname.Size = new Size(0, 23);
			lblLastname.TabIndex = 14;
			// 
			// lblMiddlename
			// 
			lblMiddlename.AutoSize = true;
			lblMiddlename.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblMiddlename.ForeColor = Color.Black;
			lblMiddlename.Location = new Point(145, 85);
			lblMiddlename.Name = "lblMiddlename";
			lblMiddlename.Size = new Size(0, 23);
			lblMiddlename.TabIndex = 13;
			// 
			// lblFirstname
			// 
			lblFirstname.AutoSize = true;
			lblFirstname.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			lblFirstname.ForeColor = Color.Black;
			lblFirstname.Location = new Point(123, 44);
			lblFirstname.Name = "lblFirstname";
			lblFirstname.Size = new Size(0, 23);
			lblFirstname.TabIndex = 12;
			lblFirstname.Click += lblFirstname_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label13.ForeColor = Color.Black;
			label13.ImageAlign = ContentAlignment.MiddleLeft;
			label13.Location = new Point(363, 151);
			label13.Name = "label13";
			label13.Size = new Size(105, 26);
			label13.TabIndex = 11;
			label13.Text = "Username:";
			label13.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label12.ForeColor = Color.Black;
			label12.ImageAlign = ContentAlignment.MiddleLeft;
			label12.Location = new Point(363, 191);
			label12.Name = "label12";
			label12.Size = new Size(189, 26);
			label12.TabIndex = 10;
			label12.Text = "Date of Registration:";
			label12.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label10.ForeColor = Color.Black;
			label10.ImageAlign = ContentAlignment.MiddleLeft;
			label10.Location = new Point(363, 112);
			label10.Name = "label10";
			label10.Size = new Size(87, 26);
			label10.TabIndex = 8;
			label10.Text = "Zipcode:";
			label10.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = Color.Black;
			label9.ImageAlign = ContentAlignment.MiddleLeft;
			label9.Location = new Point(363, 71);
			label9.Name = "label9";
			label9.Size = new Size(52, 26);
			label9.TabIndex = 7;
			label9.Text = "City:";
			label9.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = Color.Black;
			label7.Location = new Point(20, 235);
			label7.Name = "label7";
			label7.Size = new Size(86, 26);
			label7.TabIndex = 5;
			label7.Text = "Address:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.Black;
			label6.Location = new Point(20, 161);
			label6.Name = "label6";
			label6.Size = new Size(52, 26);
			label6.TabIndex = 4;
			label6.Text = "Age:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.Black;
			label5.Location = new Point(20, 198);
			label5.Name = "label5";
			label5.Size = new Size(75, 26);
			label5.TabIndex = 3;
			label5.Text = "Gender";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(20, 123);
			label4.Name = "label4";
			label4.Size = new Size(110, 26);
			label4.TabIndex = 2;
			label4.Text = "Last Name:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(20, 82);
			label3.Name = "label3";
			label3.Size = new Size(133, 26);
			label3.TabIndex = 1;
			label3.Text = "Middle Name:";
			// 
			// label0
			// 
			label0.AutoSize = true;
			label0.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label0.ForeColor = Color.Black;
			label0.Location = new Point(20, 41);
			label0.Name = "label0";
			label0.Size = new Size(112, 26);
			label0.TabIndex = 0;
			label0.Text = "First Name:";
			label0.Click += label0_Click;
			// 
			// customizeButtons2
			// 
			customizeButtons2.BackColor = Color.Red;
			customizeButtons2.BackgroundColor = Color.Red;
			customizeButtons2.BorderColor = Color.PaleVioletRed;
			customizeButtons2.BorderRadius = 12;
			customizeButtons2.BorderSize = 0;
			customizeButtons2.Cursor = Cursors.Hand;
			customizeButtons2.FlatAppearance.BorderSize = 0;
			customizeButtons2.FlatStyle = FlatStyle.Flat;
			customizeButtons2.Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			customizeButtons2.ForeColor = Color.White;
			customizeButtons2.Location = new Point(900, 659);
			customizeButtons2.Name = "customizeButtons2";
			customizeButtons2.Size = new Size(107, 38);
			customizeButtons2.TabIndex = 18;
			customizeButtons2.Text = "back";
			customizeButtons2.TextColor = Color.White;
			customizeButtons2.UseVisualStyleBackColor = false;
			customizeButtons2.Click += customizeButtons2_Click;
			// 
			// btnUpdateStatus
			// 
			btnUpdateStatus.BackColor = Color.FromArgb(0, 192, 0);
			btnUpdateStatus.BackgroundColor = Color.FromArgb(0, 192, 0);
			btnUpdateStatus.BorderColor = Color.PeachPuff;
			btnUpdateStatus.BorderRadius = 12;
			btnUpdateStatus.BorderSize = 0;
			btnUpdateStatus.Cursor = Cursors.Hand;
			btnUpdateStatus.FlatAppearance.BorderSize = 0;
			btnUpdateStatus.FlatStyle = FlatStyle.Flat;
			btnUpdateStatus.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnUpdateStatus.ForeColor = Color.White;
			btnUpdateStatus.Location = new Point(900, 149);
			btnUpdateStatus.Name = "btnUpdateStatus";
			btnUpdateStatus.Size = new Size(107, 38);
			btnUpdateStatus.TabIndex = 21;
			btnUpdateStatus.Text = "Update ";
			btnUpdateStatus.TextColor = Color.White;
			btnUpdateStatus.UseVisualStyleBackColor = false;
			btnUpdateStatus.Click += btnUpdateStatus_Click;
			// 
			// Profile
			// 
			AutoScaleDimensions = new SizeF(6F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLight;
			ClientSize = new Size(1037, 720);
			Controls.Add(btnUpdateStatus);
			Controls.Add(customizeButtons2);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Profile";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Profile";
			Load += Profile_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label lblExit;
		private Panel panel2;
		private Label label13;
		private Label label12;
		private Label label10;
		private Label label9;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label0;
		private DataGridView dataGridView1;
		private PictureBox pictureBox2;
		private Label lblDateReg;
		private Label lblBarangay;
		private Label label19;
		private Label lblUser;
		private Label lblZipcode;
		private Label lblCity;
		private Label lblAddress;
		private Label lblGender;
		private Label lblAge;
		private Label lblLastname;
		private Label lblMiddlename;
		private Label lblFirstname;
		private Label label2;
		private Label lblusername;
		private customizeButtons customizeButtons2;
		private Label label11;
		private ComboBox cmbStatus;
		private Label label8;
		private customizeButtons btnUpdateStatus;
		private ComboBox cmbRenewal;
		private Label payment;
		private Label lblPayment;
	}
}