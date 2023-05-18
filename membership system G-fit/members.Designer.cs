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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridMembers = new System.Windows.Forms.DataGridView();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnUpdate = new membership_system_G_fit.customizeButtons();
			this.btnDelete = new membership_system_G_fit.customizeButtons();
			this.btnReset = new membership_system_G_fit.customizeButtons();
			this.customizeButtons4 = new membership_system_G_fit.customizeButtons();
			this.InfoContainer = new System.Windows.Forms.Panel();
			this.lblCustomerID = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.joinDate = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbGender = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtZipCode = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBarangay = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMiddlename = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdd = new membership_system_G_fit.customizeButtons();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
			this.InfoContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MistyRose;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lblWelcome);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1200, 70);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(300, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 33);
			this.label2.TabIndex = 26;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Corbel", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.lblWelcome.Location = new System.Drawing.Point(522, 17);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(109, 42);
			this.lblWelcome.TabIndex = 4;
			this.lblWelcome.Text = "G- FIT";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::membership_system_G_fit.Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			this.pictureBox1.Location = new System.Drawing.Point(9, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 49);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(458, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "Manage Members";
			// 
			// dataGridMembers
			// 
			this.dataGridMembers.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridMembers.GridColor = System.Drawing.Color.Brown;
			this.dataGridMembers.Location = new System.Drawing.Point(53, 123);
			this.dataGridMembers.Name = "dataGridMembers";
			this.dataGridMembers.RowTemplate.Height = 25;
			this.dataGridMembers.Size = new System.Drawing.Size(876, 225);
			this.dataGridMembers.TabIndex = 6;
			this.dataGridMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMembers_CellClick);
			this.dataGridMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMembers_CellContentClick);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtSearch.Location = new System.Drawing.Point(1029, 132);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PlaceholderText = "Search";
			this.txtSearch.Size = new System.Drawing.Size(149, 27);
			this.txtSearch.TabIndex = 8;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Crimson;
			this.btnUpdate.BackgroundColor = System.Drawing.Color.Crimson;
			this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnUpdate.BorderRadius = 12;
			this.btnUpdate.BorderSize = 0;
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(1041, 223);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(122, 35);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.TextColor = System.Drawing.Color.White;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.DarkOrange;
			this.btnDelete.BackgroundColor = System.Drawing.Color.DarkOrange;
			this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnDelete.BorderRadius = 12;
			this.btnDelete.BorderSize = 0;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(1041, 273);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(122, 35);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Archive";
			this.btnDelete.TextColor = System.Drawing.Color.White;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnReset.BackgroundColor = System.Drawing.Color.RoyalBlue;
			this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnReset.BorderRadius = 12;
			this.btnReset.BorderSize = 0;
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(1041, 329);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(122, 35);
			this.btnReset.TabIndex = 11;
			this.btnReset.Text = "Reset";
			this.btnReset.TextColor = System.Drawing.Color.White;
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.customizeButtons3_Click);
			// 
			// customizeButtons4
			// 
			this.customizeButtons4.BackColor = System.Drawing.Color.DimGray;
			this.customizeButtons4.BackgroundColor = System.Drawing.Color.DimGray;
			this.customizeButtons4.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.customizeButtons4.BorderRadius = 12;
			this.customizeButtons4.BorderSize = 0;
			this.customizeButtons4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.customizeButtons4.FlatAppearance.BorderSize = 0;
			this.customizeButtons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.customizeButtons4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.customizeButtons4.ForeColor = System.Drawing.Color.White;
			this.customizeButtons4.Location = new System.Drawing.Point(1041, 380);
			this.customizeButtons4.Name = "customizeButtons4";
			this.customizeButtons4.Size = new System.Drawing.Size(122, 35);
			this.customizeButtons4.TabIndex = 12;
			this.customizeButtons4.Text = "Back";
			this.customizeButtons4.TextColor = System.Drawing.Color.White;
			this.customizeButtons4.UseVisualStyleBackColor = false;
			this.customizeButtons4.Click += new System.EventHandler(this.customizeButtons4_Click);
			// 
			// InfoContainer
			// 
			this.InfoContainer.BackColor = System.Drawing.Color.Transparent;
			this.InfoContainer.Controls.Add(this.lblCustomerID);
			this.InfoContainer.Controls.Add(this.label14);
			this.InfoContainer.Controls.Add(this.joinDate);
			this.InfoContainer.Controls.Add(this.label12);
			this.InfoContainer.Controls.Add(this.cmbGender);
			this.InfoContainer.Controls.Add(this.label11);
			this.InfoContainer.Controls.Add(this.txtAge);
			this.InfoContainer.Controls.Add(this.label10);
			this.InfoContainer.Controls.Add(this.txtZipCode);
			this.InfoContainer.Controls.Add(this.label9);
			this.InfoContainer.Controls.Add(this.txtCity);
			this.InfoContainer.Controls.Add(this.label8);
			this.InfoContainer.Controls.Add(this.txtBarangay);
			this.InfoContainer.Controls.Add(this.label7);
			this.InfoContainer.Controls.Add(this.txtAddress);
			this.InfoContainer.Controls.Add(this.label6);
			this.InfoContainer.Controls.Add(this.txtLastname);
			this.InfoContainer.Controls.Add(this.label5);
			this.InfoContainer.Controls.Add(this.txtMiddlename);
			this.InfoContainer.Controls.Add(this.label4);
			this.InfoContainer.Controls.Add(this.txtFirstname);
			this.InfoContainer.Controls.Add(this.label3);
			this.InfoContainer.ForeColor = System.Drawing.Color.White;
			this.InfoContainer.Location = new System.Drawing.Point(43, 371);
			this.InfoContainer.Name = "InfoContainer";
			this.InfoContainer.Size = new System.Drawing.Size(758, 388);
			this.InfoContainer.TabIndex = 13;
			this.InfoContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.InfoContainer_Paint);
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblCustomerID.ForeColor = System.Drawing.Color.White;
			this.lblCustomerID.Location = new System.Drawing.Point(168, 23);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(18, 19);
			this.lblCustomerID.TabIndex = 63;
			this.lblCustomerID.Text = "*";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(33, 18);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(128, 26);
			this.label14.TabIndex = 62;
			this.label14.Text = "Customer ID: ";
			// 
			// joinDate
			// 
			this.joinDate.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.joinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.joinDate.Location = new System.Drawing.Point(572, 245);
			this.joinDate.Name = "joinDate";
			this.joinDate.Size = new System.Drawing.Size(117, 27);
			this.joinDate.TabIndex = 61;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(479, 245);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(95, 26);
			this.label12.TabIndex = 60;
			this.label12.Text = "Join date:";
			// 
			// cmbGender
			// 
			this.cmbGender.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cmbGender.ForeColor = System.Drawing.Color.Black;
			this.cmbGender.FormattingEnabled = true;
			this.cmbGender.Items.AddRange(new object[] {
            "Male ",
            "Female ",
            "Others"});
			this.cmbGender.Location = new System.Drawing.Point(568, 110);
			this.cmbGender.Name = "cmbGender";
			this.cmbGender.Size = new System.Drawing.Size(121, 27);
			this.cmbGender.TabIndex = 57;
			this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(490, 111);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 26);
			this.label11.TabIndex = 56;
			this.label11.Text = "Gender:";
			// 
			// txtAge
			// 
			this.txtAge.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAge.ForeColor = System.Drawing.Color.Black;
			this.txtAge.Location = new System.Drawing.Point(552, 62);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(102, 27);
			this.txtAge.TabIndex = 55;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(490, 63);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 26);
			this.label10.TabIndex = 54;
			this.label10.Text = "Age:";
			// 
			// txtZipCode
			// 
			this.txtZipCode.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtZipCode.ForeColor = System.Drawing.Color.Black;
			this.txtZipCode.Location = new System.Drawing.Point(151, 329);
			this.txtZipCode.Name = "txtZipCode";
			this.txtZipCode.Size = new System.Drawing.Size(113, 27);
			this.txtZipCode.TabIndex = 53;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(41, 330);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 26);
			this.label9.TabIndex = 52;
			this.label9.Text = "Zip code:";
			// 
			// txtCity
			// 
			this.txtCity.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtCity.ForeColor = System.Drawing.Color.Black;
			this.txtCity.Location = new System.Drawing.Point(151, 286);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(204, 27);
			this.txtCity.TabIndex = 51;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(80, 287);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 26);
			this.label8.TabIndex = 50;
			this.label8.Text = "City:";
			// 
			// txtBarangay
			// 
			this.txtBarangay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtBarangay.ForeColor = System.Drawing.Color.Black;
			this.txtBarangay.Location = new System.Drawing.Point(151, 245);
			this.txtBarangay.Name = "txtBarangay";
			this.txtBarangay.Size = new System.Drawing.Size(151, 27);
			this.txtBarangay.TabIndex = 49;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(33, 243);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(99, 26);
			this.label7.TabIndex = 48;
			this.label7.Text = "Barangay:";
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.White;
			this.txtAddress.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAddress.ForeColor = System.Drawing.Color.Black;
			this.txtAddress.Location = new System.Drawing.Point(267, 196);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(290, 23);
			this.txtAddress.TabIndex = 47;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(33, 196);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(231, 26);
			this.label6.TabIndex = 46;
			this.label6.Text = "Address/House no/Street:";
			// 
			// txtLastname
			// 
			this.txtLastname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLastname.ForeColor = System.Drawing.Color.Black;
			this.txtLastname.Location = new System.Drawing.Point(151, 149);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(204, 27);
			this.txtLastname.TabIndex = 45;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(33, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 26);
			this.label5.TabIndex = 44;
			this.label5.Text = "Last name:";
			// 
			// txtMiddlename
			// 
			this.txtMiddlename.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtMiddlename.ForeColor = System.Drawing.Color.Black;
			this.txtMiddlename.Location = new System.Drawing.Point(168, 107);
			this.txtMiddlename.Name = "txtMiddlename";
			this.txtMiddlename.Size = new System.Drawing.Size(187, 27);
			this.txtMiddlename.TabIndex = 43;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(33, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 26);
			this.label4.TabIndex = 42;
			this.label4.Text = "Middle name:";
			// 
			// txtFirstname
			// 
			this.txtFirstname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFirstname.ForeColor = System.Drawing.Color.Black;
			this.txtFirstname.Location = new System.Drawing.Point(151, 60);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(204, 27);
			this.txtFirstname.TabIndex = 41;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(33, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 26);
			this.label3.TabIndex = 40;
			this.label3.Text = "First name:";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Goldenrod;
			this.btnAdd.BackgroundColor = System.Drawing.Color.Goldenrod;
			this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnAdd.BorderRadius = 12;
			this.btnAdd.BorderSize = 0;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(1041, 177);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(122, 35);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Add";
			this.btnAdd.TextColor = System.Drawing.Color.White;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label13.ForeColor = System.Drawing.Color.Gold;
			this.label13.Location = new System.Drawing.Point(897, 573);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(65, 26);
			this.label13.TabIndex = 62;
			this.label13.Text = "Image";
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox.Location = new System.Drawing.Point(846, 404);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(173, 156);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 63;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// members
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::membership_system_G_fit.Properties.Resources.background_gfit1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1200, 780);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.InfoContainer);
			this.Controls.Add(this.customizeButtons4);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.dataGridMembers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "members";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "members";
			this.Load += new System.EventHandler(this.members_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
			this.InfoContainer.ResumeLayout(false);
			this.InfoContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private PictureBox pictureBox;
		private Label lblCustomerID;
		private Label label14;
	}
}