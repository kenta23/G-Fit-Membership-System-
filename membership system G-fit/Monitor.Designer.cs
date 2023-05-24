namespace membership_system_G_fit
{
	partial class Monitor
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
			label1 = new Label();
			label2 = new Label();
			lblWelcome = new Label();
			pictureBox1 = new PictureBox();
			dataGridView1 = new DataGridView();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			lblName = new Label();
			lblUsername = new Label();
			lblType = new Label();
			cmbStatus = new ComboBox();
			btnUpdate = new customizeButtons();
			customizeButtons2 = new customizeButtons();
			label7 = new Label();
			lblCustomer_ID = new Label();
			label9 = new Label();
			clearBtn = new customizeButtons();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MistyRose;
			panel1.Controls.Add(label1);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(lblWelcome);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1040, 65);
			panel1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Cursor = Cursors.Hand;
			label1.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(255, 82, 83);
			label1.Location = new Point(980, 17);
			label1.Name = "label1";
			label1.Size = new Size(32, 33);
			label1.TabIndex = 28;
			label1.Text = "X";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Cursor = Cursors.Hand;
			label2.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(1035, 18);
			label2.Name = "label2";
			label2.Size = new Size(32, 33);
			label2.TabIndex = 27;
			label2.Text = "X";
			// 
			// lblWelcome
			// 
			lblWelcome.AutoSize = true;
			lblWelcome.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
			lblWelcome.ForeColor = Color.FromArgb(255, 82, 83);
			lblWelcome.Location = new Point(478, 17);
			lblWelcome.Name = "lblWelcome";
			lblWelcome.Size = new Size(97, 36);
			lblWelcome.TabIndex = 4;
			lblWelcome.Text = "G- FIT ";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			pictureBox1.Location = new Point(36, 11);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(48, 49);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.WhiteSmoke;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.GridColor = Color.Red;
			dataGridView1.Location = new Point(27, 168);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(633, 388);
			dataGridView1.TabIndex = 3;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(706, 207);
			label3.Name = "label3";
			label3.Size = new Size(70, 26);
			label3.TabIndex = 4;
			label3.Text = "Name:";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.BackColor = Color.Transparent;
			label4.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(706, 251);
			label4.Name = "label4";
			label4.Size = new Size(105, 26);
			label4.TabIndex = 5;
			label4.Text = "Username:";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = Color.Transparent;
			label5.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(706, 296);
			label5.Name = "label5";
			label5.Size = new Size(132, 26);
			label5.TabIndex = 6;
			label5.Text = "Member type:";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(706, 343);
			label6.Name = "label6";
			label6.Size = new Size(73, 26);
			label6.TabIndex = 7;
			label6.Text = "Status:";
			label6.Click += label6_Click;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.BackColor = Color.Transparent;
			lblName.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblName.ForeColor = Color.White;
			lblName.Location = new Point(768, 207);
			lblName.Name = "lblName";
			lblName.Size = new Size(60, 26);
			lblName.TabIndex = 8;
			lblName.Text = "name";
			lblName.Click += lblName_Click;
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.BackColor = Color.Transparent;
			lblUsername.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsername.ForeColor = Color.White;
			lblUsername.Location = new Point(803, 251);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(96, 26);
			lblUsername.TabIndex = 9;
			lblUsername.Text = "username";
			lblUsername.Click += lblUsername_Click;
			// 
			// lblType
			// 
			lblType.AutoSize = true;
			lblType.BackColor = Color.Transparent;
			lblType.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblType.ForeColor = Color.White;
			lblType.Location = new Point(835, 296);
			lblType.Name = "lblType";
			lblType.Size = new Size(50, 26);
			lblType.TabIndex = 10;
			lblType.Text = "type";
			lblType.Click += lblType_Click;
			// 
			// cmbStatus
			// 
			cmbStatus.BackColor = Color.WhiteSmoke;
			cmbStatus.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cmbStatus.ForeColor = Color.Black;
			cmbStatus.FormattingEnabled = true;
			cmbStatus.Items.AddRange(new object[] { "Present ", "Out" });
			cmbStatus.Location = new Point(778, 343);
			cmbStatus.Name = "cmbStatus";
			cmbStatus.Size = new Size(121, 27);
			cmbStatus.TabIndex = 12;
			cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.Green;
			btnUpdate.BackgroundColor = Color.Green;
			btnUpdate.BorderColor = Color.PaleVioletRed;
			btnUpdate.BorderRadius = 12;
			btnUpdate.BorderSize = 0;
			btnUpdate.FlatAppearance.BorderSize = 0;
			btnUpdate.FlatStyle = FlatStyle.Flat;
			btnUpdate.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnUpdate.ForeColor = Color.White;
			btnUpdate.Location = new Point(835, 390);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(107, 35);
			btnUpdate.TabIndex = 13;
			btnUpdate.Text = "Update";
			btnUpdate.TextColor = Color.White;
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// customizeButtons2
			// 
			customizeButtons2.BackColor = Color.Red;
			customizeButtons2.BackgroundColor = Color.Red;
			customizeButtons2.BorderColor = Color.PaleVioletRed;
			customizeButtons2.BorderRadius = 12;
			customizeButtons2.BorderSize = 0;
			customizeButtons2.FlatAppearance.BorderSize = 0;
			customizeButtons2.FlatStyle = FlatStyle.Flat;
			customizeButtons2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			customizeButtons2.ForeColor = Color.White;
			customizeButtons2.Location = new Point(910, 548);
			customizeButtons2.Name = "customizeButtons2";
			customizeButtons2.Size = new Size(107, 35);
			customizeButtons2.TabIndex = 14;
			customizeButtons2.Text = "Back";
			customizeButtons2.TextColor = Color.White;
			customizeButtons2.UseVisualStyleBackColor = false;
			customizeButtons2.Click += customizeButtons2_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.BackColor = Color.Transparent;
			label7.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.White;
			label7.Location = new Point(359, 91);
			label7.Name = "label7";
			label7.Size = new Size(343, 36);
			label7.TabIndex = 15;
			label7.Text = "Monitoring inside the gym";
			// 
			// lblCustomer_ID
			// 
			lblCustomer_ID.AutoSize = true;
			lblCustomer_ID.BackColor = Color.Transparent;
			lblCustomer_ID.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblCustomer_ID.ForeColor = Color.White;
			lblCustomer_ID.Location = new Point(816, 168);
			lblCustomer_ID.Name = "lblCustomer_ID";
			lblCustomer_ID.Size = new Size(31, 26);
			lblCustomer_ID.TabIndex = 17;
			lblCustomer_ID.Text = "ID";
			lblCustomer_ID.Click += label8_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.BackColor = Color.Transparent;
			label9.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label9.ForeColor = Color.White;
			label9.Location = new Point(706, 168);
			label9.Name = "label9";
			label9.Size = new Size(113, 26);
			label9.TabIndex = 16;
			label9.Text = "Member ID:";
			label9.Click += label9_Click;
			// 
			// clearBtn
			// 
			clearBtn.BackColor = Color.Crimson;
			clearBtn.BackgroundColor = Color.Crimson;
			clearBtn.BorderColor = Color.PaleVioletRed;
			clearBtn.BorderRadius = 12;
			clearBtn.BorderSize = 0;
			clearBtn.FlatAppearance.BorderSize = 0;
			clearBtn.FlatStyle = FlatStyle.Flat;
			clearBtn.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			clearBtn.ForeColor = Color.White;
			clearBtn.Location = new Point(712, 390);
			clearBtn.Name = "clearBtn";
			clearBtn.Size = new Size(107, 35);
			clearBtn.TabIndex = 18;
			clearBtn.Text = "Clear Status ";
			clearBtn.TextColor = Color.White;
			clearBtn.UseVisualStyleBackColor = false;
			clearBtn.Click += clearBtn_Click;
			// 
			// Monitor
			// 
			AutoScaleDimensions = new SizeF(6F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonFace;
			BackgroundImage = Properties.Resources.background_gfit1;
			BackgroundImageLayout = ImageLayout.Center;
			ClientSize = new Size(1040, 603);
			Controls.Add(clearBtn);
			Controls.Add(lblCustomer_ID);
			Controls.Add(label9);
			Controls.Add(label7);
			Controls.Add(customizeButtons2);
			Controls.Add(btnUpdate);
			Controls.Add(cmbStatus);
			Controls.Add(lblType);
			Controls.Add(lblUsername);
			Controls.Add(lblName);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(dataGridView1);
			Controls.Add(panel1);
			Cursor = Cursors.Hand;
			Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Monitor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Monitor";
			Load += Monitor_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private Label lblWelcome;
		private PictureBox pictureBox1;
		private Label label1;
		private DataGridView dataGridView1;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label lblName;
		private Label lblUsername;
		private Label lblType;
		private ComboBox cmbStatus;
		private customizeButtons btnUpdate;
		private customizeButtons customizeButtons2;
		private Label label7;
		private Label lblCustomer_ID;
		private Label label9;
		private customizeButtons clearBtn;
	}
}