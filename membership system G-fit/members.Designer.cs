namespace membership_system_G_fit
{
	partial class members
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
			label2 = new Label();
			lblWelcome = new Label();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			dataGridMembers = new DataGridView();
			txtSearch = new TextBox();
			btnUpdate = new customizeButtons();
			btnDelete = new customizeButtons();
			btnReset = new customizeButtons();
			customizeButtons4 = new customizeButtons();
			InfoContainer = new Panel();
			lblCustomerID = new Label();
			label14 = new Label();
			joinDate = new DateTimePicker();
			label12 = new Label();
			cmbGender = new ComboBox();
			label11 = new Label();
			txtAge = new TextBox();
			label10 = new Label();
			txtZipCode = new TextBox();
			label9 = new Label();
			txtCity = new TextBox();
			label8 = new Label();
			txtBarangay = new TextBox();
			label7 = new Label();
			txtAddress = new TextBox();
			label6 = new Label();
			txtLastname = new TextBox();
			label5 = new Label();
			txtMiddlename = new TextBox();
			label4 = new Label();
			txtFirstname = new TextBox();
			label3 = new Label();
			btnAdd = new customizeButtons();
			label13 = new Label();
			pictureboxMembers = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridMembers).BeginInit();
			InfoContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureboxMembers).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MistyRose;
			panel1.Controls.Add(label2);
			panel1.Controls.Add(lblWelcome);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1200, 70);
			panel1.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Cursor = Cursors.Hand;
			label2.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(300, 73);
			label2.Name = "label2";
			label2.Size = new Size(32, 33);
			label2.TabIndex = 26;
			label2.Text = "X";
			label2.Click += label2_Click;
			// 
			// lblWelcome
			// 
			lblWelcome.AutoSize = true;
			lblWelcome.Font = new Font("Corbel", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblWelcome.ForeColor = Color.FromArgb(255, 82, 83);
			lblWelcome.Location = new Point(522, 17);
			lblWelcome.Name = "lblWelcome";
			lblWelcome.Size = new Size(109, 42);
			lblWelcome.TabIndex = 4;
			lblWelcome.Text = "G- FIT";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			pictureBox1.Location = new Point(9, 10);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(48, 49);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(458, 91);
			label1.Name = "label1";
			label1.Size = new Size(195, 29);
			label1.TabIndex = 5;
			label1.Text = "Manage Members";
			// 
			// dataGridMembers
			// 
			dataGridMembers.BackgroundColor = SystemColors.Control;
			dataGridMembers.BorderStyle = BorderStyle.Fixed3D;
			dataGridMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridMembers.GridColor = Color.Brown;
			dataGridMembers.Location = new Point(53, 123);
			dataGridMembers.Name = "dataGridMembers";
			dataGridMembers.RowTemplate.Height = 25;
			dataGridMembers.Size = new Size(876, 225);
			dataGridMembers.TabIndex = 6;
			dataGridMembers.CellClick += dataGridMembers_CellClick;
			dataGridMembers.CellContentClick += dataGridMembers_CellContentClick;
			// 
			// txtSearch
			// 
			txtSearch.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtSearch.Location = new Point(1029, 132);
			txtSearch.Name = "txtSearch";
			txtSearch.PlaceholderText = "Search";
			txtSearch.Size = new Size(149, 27);
			txtSearch.TabIndex = 8;
			txtSearch.KeyPress += textBox1_KeyPress;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.Crimson;
			btnUpdate.BackgroundColor = Color.Crimson;
			btnUpdate.BorderColor = Color.PaleVioletRed;
			btnUpdate.BorderRadius = 12;
			btnUpdate.BorderSize = 0;
			btnUpdate.Cursor = Cursors.Hand;
			btnUpdate.FlatAppearance.BorderSize = 0;
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnUpdate.ForeColor = Color.White;
			btnUpdate.Location = new Point(1041, 223);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(122, 35);
			btnUpdate.TabIndex = 9;
			btnUpdate.Text = "Update";
			btnUpdate.TextColor = Color.White;
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.DarkOrange;
			btnDelete.BackgroundColor = Color.DarkOrange;
			btnDelete.BorderColor = Color.PaleVioletRed;
			btnDelete.BorderRadius = 12;
			btnDelete.BorderSize = 0;
			btnDelete.Cursor = Cursors.Hand;
			btnDelete.FlatAppearance.BorderSize = 0;
			btnDelete.FlatStyle = FlatStyle.Flat;
			btnDelete.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnDelete.ForeColor = Color.White;
			btnDelete.Location = new Point(1041, 273);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(122, 35);
			btnDelete.TabIndex = 10;
			btnDelete.Text = "Archive";
			btnDelete.TextColor = Color.White;
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnReset
			// 
			btnReset.BackColor = Color.RoyalBlue;
			btnReset.BackgroundColor = Color.RoyalBlue;
			btnReset.BorderColor = Color.PaleVioletRed;
			btnReset.BorderRadius = 12;
			btnReset.BorderSize = 0;
			btnReset.Cursor = Cursors.Hand;
			btnReset.FlatAppearance.BorderSize = 0;
			btnReset.FlatStyle = FlatStyle.Flat;
			btnReset.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnReset.ForeColor = Color.White;
			btnReset.Location = new Point(1041, 329);
			btnReset.Name = "btnReset";
			btnReset.Size = new Size(122, 35);
			btnReset.TabIndex = 11;
			btnReset.Text = "Reset";
			btnReset.TextColor = Color.White;
			btnReset.UseVisualStyleBackColor = false;
			btnReset.Click += customizeButtons3_Click;
			// 
			// customizeButtons4
			// 
			customizeButtons4.BackColor = Color.DimGray;
			customizeButtons4.BackgroundColor = Color.DimGray;
			customizeButtons4.BorderColor = Color.PaleVioletRed;
			customizeButtons4.BorderRadius = 12;
			customizeButtons4.BorderSize = 0;
			customizeButtons4.Cursor = Cursors.Hand;
			customizeButtons4.FlatAppearance.BorderSize = 0;
			customizeButtons4.FlatStyle = FlatStyle.Flat;
			customizeButtons4.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			customizeButtons4.ForeColor = Color.White;
			customizeButtons4.Location = new Point(1041, 380);
			customizeButtons4.Name = "customizeButtons4";
			customizeButtons4.Size = new Size(122, 35);
			customizeButtons4.TabIndex = 12;
			customizeButtons4.Text = "Back";
			customizeButtons4.TextColor = Color.White;
			customizeButtons4.UseVisualStyleBackColor = false;
			customizeButtons4.Click += customizeButtons4_Click;
			// 
			// InfoContainer
			// 
			InfoContainer.BackColor = Color.Transparent;
			InfoContainer.Controls.Add(lblCustomerID);
			InfoContainer.Controls.Add(label14);
			InfoContainer.Controls.Add(joinDate);
			InfoContainer.Controls.Add(label12);
			InfoContainer.Controls.Add(cmbGender);
			InfoContainer.Controls.Add(label11);
			InfoContainer.Controls.Add(txtAge);
			InfoContainer.Controls.Add(label10);
			InfoContainer.Controls.Add(txtZipCode);
			InfoContainer.Controls.Add(label9);
			InfoContainer.Controls.Add(txtCity);
			InfoContainer.Controls.Add(label8);
			InfoContainer.Controls.Add(txtBarangay);
			InfoContainer.Controls.Add(label7);
			InfoContainer.Controls.Add(txtAddress);
			InfoContainer.Controls.Add(label6);
			InfoContainer.Controls.Add(txtLastname);
			InfoContainer.Controls.Add(label5);
			InfoContainer.Controls.Add(txtMiddlename);
			InfoContainer.Controls.Add(label4);
			InfoContainer.Controls.Add(txtFirstname);
			InfoContainer.Controls.Add(label3);
			InfoContainer.ForeColor = Color.White;
			InfoContainer.Location = new Point(43, 371);
			InfoContainer.Name = "InfoContainer";
			InfoContainer.Size = new Size(758, 388);
			InfoContainer.TabIndex = 13;
			InfoContainer.Paint += InfoContainer_Paint;
			// 
			// lblCustomerID
			// 
			lblCustomerID.AutoSize = true;
			lblCustomerID.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblCustomerID.ForeColor = Color.White;
			lblCustomerID.Location = new Point(168, 23);
			lblCustomerID.Name = "lblCustomerID";
			lblCustomerID.Size = new Size(18, 19);
			lblCustomerID.TabIndex = 63;
			lblCustomerID.Text = "*";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label14.ForeColor = Color.White;
			label14.Location = new Point(33, 18);
			label14.Name = "label14";
			label14.Size = new Size(128, 26);
			label14.TabIndex = 62;
			label14.Text = "Customer ID: ";
			// 
			// joinDate
			// 
			joinDate.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			joinDate.Format = DateTimePickerFormat.Custom;
			joinDate.Location = new Point(572, 245);
			joinDate.Name = "joinDate";
			joinDate.Size = new Size(117, 27);
			joinDate.TabIndex = 61;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label12.ForeColor = Color.White;
			label12.Location = new Point(479, 245);
			label12.Name = "label12";
			label12.Size = new Size(95, 26);
			label12.TabIndex = 60;
			label12.Text = "Join date:";
			// 
			// cmbGender
			// 
			cmbGender.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cmbGender.ForeColor = Color.Black;
			cmbGender.FormattingEnabled = true;
			cmbGender.Items.AddRange(new object[] { "Male ", "Female ", "Others" });
			cmbGender.Location = new Point(568, 110);
			cmbGender.Name = "cmbGender";
			cmbGender.Size = new Size(121, 27);
			cmbGender.TabIndex = 57;
			cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label11.ForeColor = Color.White;
			label11.Location = new Point(490, 111);
			label11.Name = "label11";
			label11.Size = new Size(81, 26);
			label11.TabIndex = 56;
			label11.Text = "Gender:";
			// 
			// txtAge
			// 
			txtAge.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtAge.ForeColor = Color.Black;
			txtAge.Location = new Point(552, 62);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(102, 27);
			txtAge.TabIndex = 55;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label10.ForeColor = Color.White;
			label10.Location = new Point(490, 63);
			label10.Name = "label10";
			label10.Size = new Size(52, 26);
			label10.TabIndex = 54;
			label10.Text = "Age:";
			// 
			// txtZipCode
			// 
			txtZipCode.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtZipCode.ForeColor = Color.Black;
			txtZipCode.Location = new Point(151, 329);
			txtZipCode.Name = "txtZipCode";
			txtZipCode.Size = new Size(113, 27);
			txtZipCode.TabIndex = 53;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = Color.White;
			label9.Location = new Point(41, 330);
			label9.Name = "label9";
			label9.Size = new Size(91, 26);
			label9.TabIndex = 52;
			label9.Text = "Zip code:";
			// 
			// txtCity
			// 
			txtCity.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtCity.ForeColor = Color.Black;
			txtCity.Location = new Point(151, 286);
			txtCity.Name = "txtCity";
			txtCity.Size = new Size(204, 27);
			txtCity.TabIndex = 51;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label8.ForeColor = Color.White;
			label8.Location = new Point(80, 287);
			label8.Name = "label8";
			label8.Size = new Size(52, 26);
			label8.TabIndex = 50;
			label8.Text = "City:";
			// 
			// txtBarangay
			// 
			txtBarangay.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtBarangay.ForeColor = Color.Black;
			txtBarangay.Location = new Point(151, 245);
			txtBarangay.Name = "txtBarangay";
			txtBarangay.Size = new Size(151, 27);
			txtBarangay.TabIndex = 49;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = Color.White;
			label7.Location = new Point(33, 243);
			label7.Name = "label7";
			label7.Size = new Size(99, 26);
			label7.TabIndex = 48;
			label7.Text = "Barangay:";
			// 
			// txtAddress
			// 
			txtAddress.BackColor = Color.White;
			txtAddress.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtAddress.ForeColor = Color.Black;
			txtAddress.Location = new Point(267, 196);
			txtAddress.Multiline = true;
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(290, 23);
			txtAddress.TabIndex = 47;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(33, 196);
			label6.Name = "label6";
			label6.Size = new Size(231, 26);
			label6.TabIndex = 46;
			label6.Text = "Address/House no/Street:";
			// 
			// txtLastname
			// 
			txtLastname.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtLastname.ForeColor = Color.Black;
			txtLastname.Location = new Point(151, 149);
			txtLastname.Name = "txtLastname";
			txtLastname.Size = new Size(204, 27);
			txtLastname.TabIndex = 45;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(33, 150);
			label5.Name = "label5";
			label5.Size = new Size(106, 26);
			label5.TabIndex = 44;
			label5.Text = "Last name:";
			// 
			// txtMiddlename
			// 
			txtMiddlename.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtMiddlename.ForeColor = Color.Black;
			txtMiddlename.Location = new Point(168, 107);
			txtMiddlename.Name = "txtMiddlename";
			txtMiddlename.Size = new Size(187, 27);
			txtMiddlename.TabIndex = 43;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(33, 108);
			label4.Name = "label4";
			label4.Size = new Size(129, 26);
			label4.TabIndex = 42;
			label4.Text = "Middle name:";
			// 
			// txtFirstname
			// 
			txtFirstname.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtFirstname.ForeColor = Color.Black;
			txtFirstname.Location = new Point(151, 60);
			txtFirstname.Name = "txtFirstname";
			txtFirstname.Size = new Size(204, 27);
			txtFirstname.TabIndex = 41;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(33, 60);
			label3.Name = "label3";
			label3.Size = new Size(108, 26);
			label3.TabIndex = 40;
			label3.Text = "First name:";
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.Goldenrod;
			btnAdd.BackgroundColor = Color.Goldenrod;
			btnAdd.BorderColor = Color.PaleVioletRed;
			btnAdd.BorderRadius = 12;
			btnAdd.BorderSize = 0;
			btnAdd.Cursor = Cursors.Hand;
			btnAdd.FlatAppearance.BorderSize = 0;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnAdd.ForeColor = Color.White;
			btnAdd.Location = new Point(1041, 177);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(122, 35);
			btnAdd.TabIndex = 14;
			btnAdd.Text = "Add";
			btnAdd.TextColor = Color.White;
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.BackColor = Color.Transparent;
			label13.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label13.ForeColor = Color.Gold;
			label13.Location = new Point(897, 573);
			label13.Name = "label13";
			label13.Size = new Size(65, 26);
			label13.TabIndex = 62;
			label13.Text = "Image";
			// 
			// pictureboxMembers
			// 
			pictureboxMembers.BorderStyle = BorderStyle.FixedSingle;
			pictureboxMembers.Location = new Point(846, 404);
			pictureboxMembers.Name = "pictureboxMembers";
			pictureboxMembers.Size = new Size(173, 156);
			pictureboxMembers.SizeMode = PictureBoxSizeMode.Zoom;
			pictureboxMembers.TabIndex = 63;
			pictureboxMembers.TabStop = false;
			pictureboxMembers.Click += pictureBox_Click;
			// 
			// members
			// 
			AutoScaleDimensions = new SizeF(6F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.background_gfit1;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1200, 780);
			Controls.Add(pictureboxMembers);
			Controls.Add(label13);
			Controls.Add(btnAdd);
			Controls.Add(InfoContainer);
			Controls.Add(customizeButtons4);
			Controls.Add(btnReset);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(txtSearch);
			Controls.Add(dataGridMembers);
			Controls.Add(label1);
			Controls.Add(panel1);
			Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Name = "members";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "members";
			Load += members_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridMembers).EndInit();
			InfoContainer.ResumeLayout(false);
			InfoContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureboxMembers).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label lblWelcome;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private DataGridView dataGridMembers;
		private TextBox txtSearch;
		private customizeButtons btnUpdate;
		private customizeButtons btnDelete;
		private customizeButtons btnReset;
		private customizeButtons customizeButtons4;
		private Panel InfoContainer;
		private ComboBox cmbGender;
		private Label label11;
		private TextBox txtAge;
		private Label label10;
		private TextBox txtZipCode;
		private Label label9;
		private TextBox txtCity;
		private Label label8;
		private TextBox txtBarangay;
		private Label label7;
		private TextBox txtAddress;
		private Label label6;
		private TextBox txtLastname;
		private Label label5;
		private TextBox txtMiddlename;
		private Label label4;
		private TextBox txtFirstname;
		private Label label3;
		private customizeButtons btnAdd;
		private DateTimePicker joinDate;
		private Label label12;
		private Label label13;
		private PictureBox pictureboxMembers;
		private Label lblCustomerID;
		private Label label14;
	}
}