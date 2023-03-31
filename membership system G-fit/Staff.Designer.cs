namespace membership_system_G_fit
{
	partial class Staff
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridEmployees = new System.Windows.Forms.DataGridView();
			this.lblFirstname = new System.Windows.Forms.Label();
			this.txtFirstname = new System.Windows.Forms.TextBox();
			this.txtLastname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtContact = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbPosition = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAdd = new membership_system_G_fit.customizeButtons();
			this.btnEdit = new membership_system_G_fit.customizeButtons();
			this.btnRemove = new membership_system_G_fit.customizeButtons();
			this.btnBack = new membership_system_G_fit.customizeButtons();
			this.label9 = new System.Windows.Forms.Label();
			this.rdbMale = new System.Windows.Forms.RadioButton();
			this.rdbFemale = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MistyRose;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 70);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(963, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 33);
			this.label1.TabIndex = 27;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.label2.Location = new System.Drawing.Point(123, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 36);
			this.label2.TabIndex = 5;
			this.label2.Text = "Welcome ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::membership_system_G_fit.Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			this.pictureBox1.Location = new System.Drawing.Point(42, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(56, 52);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(42, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 36);
			this.label3.TabIndex = 2;
			this.label3.Text = "Staffs/Employees";
			// 
			// dataGridEmployees
			// 
			this.dataGridEmployees.BackgroundColor = System.Drawing.Color.White;
			this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridEmployees.GridColor = System.Drawing.SystemColors.HotTrack;
			this.dataGridEmployees.Location = new System.Drawing.Point(68, 195);
			this.dataGridEmployees.Name = "dataGridEmployees";
			this.dataGridEmployees.RowTemplate.Height = 25;
			this.dataGridEmployees.Size = new System.Drawing.Size(851, 149);
			this.dataGridEmployees.TabIndex = 3;
			this.dataGridEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellClick);
			this.dataGridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellContentClick);
			// 
			// lblFirstname
			// 
			this.lblFirstname.AutoSize = true;
			this.lblFirstname.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblFirstname.Location = new System.Drawing.Point(96, 430);
			this.lblFirstname.Name = "lblFirstname";
			this.lblFirstname.Size = new System.Drawing.Size(104, 26);
			this.lblFirstname.TabIndex = 4;
			this.lblFirstname.Text = "Firstname:";
			// 
			// txtFirstname
			// 
			this.txtFirstname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtFirstname.Location = new System.Drawing.Point(200, 429);
			this.txtFirstname.Name = "txtFirstname";
			this.txtFirstname.Size = new System.Drawing.Size(210, 27);
			this.txtFirstname.TabIndex = 5;
			// 
			// txtLastname
			// 
			this.txtLastname.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtLastname.Location = new System.Drawing.Point(200, 481);
			this.txtLastname.Name = "txtLastname";
			this.txtLastname.Size = new System.Drawing.Size(210, 27);
			this.txtLastname.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(96, 482);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "Last name:";
			// 
			// txtContact
			// 
			this.txtContact.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtContact.Location = new System.Drawing.Point(200, 534);
			this.txtContact.Name = "txtContact";
			this.txtContact.Size = new System.Drawing.Size(210, 27);
			this.txtContact.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(96, 535);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 26);
			this.label5.TabIndex = 8;
			this.label5.Text = "Contact #:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(464, 530);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 26);
			this.label6.TabIndex = 10;
			this.label6.Text = "Position:";
			// 
			// txtAge
			// 
			this.txtAge.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAge.Location = new System.Drawing.Point(523, 478);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(64, 27);
			this.txtAge.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(465, 479);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 26);
			this.label7.TabIndex = 12;
			this.label7.Text = "Age:";
			// 
			// cmbPosition
			// 
			this.cmbPosition.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cmbPosition.FormattingEnabled = true;
			this.cmbPosition.Items.AddRange(new object[] {
            "Coach",
            "Assistant Coach",
            "Secretary",
            "Administrator",
            "Manager",
            "Cashier "});
			this.cmbPosition.Location = new System.Drawing.Point(553, 533);
			this.cmbPosition.Name = "cmbPosition";
			this.cmbPosition.Size = new System.Drawing.Size(130, 27);
			this.cmbPosition.TabIndex = 14;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtAddress.Location = new System.Drawing.Point(188, 580);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(256, 89);
			this.txtAddress.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label8.Location = new System.Drawing.Point(96, 580);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 26);
			this.label8.TabIndex = 15;
			this.label8.Text = "Address:";
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnAdd.BorderRadius = 12;
			this.btnAdd.BorderSize = 0;
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderSize = 0;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(776, 484);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(81, 38);
			this.btnAdd.TabIndex = 17;
			this.btnAdd.Text = "Add";
			this.btnAdd.TextColor = System.Drawing.Color.White;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.Navy;
			this.btnEdit.BackgroundColor = System.Drawing.Color.Navy;
			this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnEdit.BorderRadius = 12;
			this.btnEdit.BorderSize = 0;
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatAppearance.BorderSize = 0;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnEdit.ForeColor = System.Drawing.Color.White;
			this.btnEdit.Location = new System.Drawing.Point(880, 484);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(81, 38);
			this.btnEdit.TabIndex = 18;
			this.btnEdit.Text = "Edit";
			this.btnEdit.TextColor = System.Drawing.Color.White;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.BackColor = System.Drawing.Color.Crimson;
			this.btnRemove.BackgroundColor = System.Drawing.Color.Crimson;
			this.btnRemove.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnRemove.BorderRadius = 12;
			this.btnRemove.BorderSize = 0;
			this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRemove.FlatAppearance.BorderSize = 0;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnRemove.ForeColor = System.Drawing.Color.White;
			this.btnRemove.Location = new System.Drawing.Point(776, 551);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(81, 38);
			this.btnRemove.TabIndex = 19;
			this.btnRemove.Text = "Remove";
			this.btnRemove.TextColor = System.Drawing.Color.White;
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.Red;
			this.btnBack.BackgroundColor = System.Drawing.Color.Red;
			this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnBack.BorderRadius = 12;
			this.btnBack.BorderSize = 0;
			this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnBack.ForeColor = System.Drawing.Color.White;
			this.btnBack.Location = new System.Drawing.Point(880, 549);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(81, 38);
			this.btnBack.TabIndex = 20;
			this.btnBack.Text = "Back";
			this.btnBack.TextColor = System.Drawing.Color.White;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(464, 428);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 26);
			this.label9.TabIndex = 21;
			this.label9.Text = "Gender:";
			// 
			// rdbMale
			// 
			this.rdbMale.AutoSize = true;
			this.rdbMale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rdbMale.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.rdbMale.Location = new System.Drawing.Point(551, 433);
			this.rdbMale.Name = "rdbMale";
			this.rdbMale.Size = new System.Drawing.Size(60, 23);
			this.rdbMale.TabIndex = 22;
			this.rdbMale.TabStop = true;
			this.rdbMale.Text = "Male";
			this.rdbMale.UseVisualStyleBackColor = true;
			// 
			// rdbFemale
			// 
			this.rdbFemale.AutoSize = true;
			this.rdbFemale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rdbFemale.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.rdbFemale.Location = new System.Drawing.Point(617, 433);
			this.rdbFemale.Name = "rdbFemale";
			this.rdbFemale.Size = new System.Drawing.Size(76, 23);
			this.rdbFemale.TabIndex = 23;
			this.rdbFemale.TabStop = true;
			this.rdbFemale.Text = "Female";
			this.rdbFemale.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radioButton1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.radioButton1.Location = new System.Drawing.Point(699, 433);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(73, 23);
			this.radioButton1.TabIndex = 24;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Others";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label10.Location = new System.Drawing.Point(96, 391);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(83, 26);
			this.label10.TabIndex = 25;
			this.label10.Text = "Staff ID:";
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtID.Location = new System.Drawing.Point(200, 390);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(37, 27);
			this.txtID.TabIndex = 27;
			// 
			// Staff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1016, 711);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.rdbFemale);
			this.Controls.Add(this.rdbMale);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cmbPosition);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtContact);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtLastname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFirstname);
			this.Controls.Add(this.lblFirstname);
			this.Controls.Add(this.dataGridEmployees);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Staff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Staff";
			this.Load += new System.EventHandler(this.Staff_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Label label2;
		private PictureBox pictureBox1;
		private Label label1;
		private Label label3;
		private DataGridView dataGridEmployees;
		private Label lblFirstname;
		private TextBox txtFirstname;
		private TextBox txtLastname;
		private Label label4;
		private TextBox txtContact;
		private Label label5;
		private Label label6;
		private TextBox txtAge;
		private Label label7;
		private ComboBox cmbPosition;
		private TextBox txtAddress;
		private Label label8;
		private customizeButtons btnAdd;
		private customizeButtons btnEdit;
		private customizeButtons btnRemove;
		private customizeButtons btnBack;
		private Label label9;
		private RadioButton rdbMale;
		private RadioButton rdbFemale;
		private RadioButton radioButton1;
		private Label label10;
		private TextBox txtID;
	}
}