namespace membership_system_G_fit
{
	partial class Amount
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
			lblUser = new Label();
			label2 = new Label();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			label3 = new Label();
			cmbType = new ComboBox();
			label4 = new Label();
			lblAmount = new Label();
			label5 = new Label();
			btnYes = new customizeButtons();
			btnNo = new customizeButtons();
			lblPaymentOpt = new Label();
			label6 = new Label();
			lblMembership = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(lblUser);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(pictureBox2);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(610, 71);
			panel1.TabIndex = 1;
			// 
			// lblUser
			// 
			lblUser.AutoSize = true;
			lblUser.Font = new Font("Corbel", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lblUser.ForeColor = Color.FromArgb(255, 82, 83);
			lblUser.Location = new Point(87, 22);
			lblUser.Name = "lblUser";
			lblUser.Size = new Size(72, 29);
			lblUser.TabIndex = 29;
			lblUser.Text = "label7";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Cursor = Cursors.Hand;
			label2.Font = new Font("Corbel", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Red;
			label2.Location = new Point(566, 22);
			label2.Name = "label2";
			label2.Size = new Size(32, 33);
			label2.TabIndex = 28;
			label2.Text = "X";
			label2.Click += label2_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			pictureBox2.Location = new Point(23, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(56, 52);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(54, 160);
			label1.Name = "label1";
			label1.Size = new Size(168, 39);
			label1.TabIndex = 2;
			label1.Text = "You choose";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(87, 287);
			label3.Name = "label3";
			label3.Size = new Size(193, 26);
			label3.TabIndex = 3;
			label3.Text = "Type of Membership:";
			// 
			// cmbType
			// 
			cmbType.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cmbType.FormattingEnabled = true;
			cmbType.Items.AddRange(new object[] { "Monthly", "6 Months ", "12 Months" });
			cmbType.Location = new Point(412, 284);
			cmbType.Name = "cmbType";
			cmbType.Size = new Size(121, 27);
			cmbType.TabIndex = 4;
			cmbType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.White;
			label4.Location = new Point(150, 343);
			label4.Name = "label4";
			label4.Size = new Size(85, 26);
			label4.TabIndex = 5;
			label4.Text = "You pay:";
			// 
			// lblAmount
			// 
			lblAmount.AutoSize = true;
			lblAmount.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblAmount.ForeColor = Color.White;
			lblAmount.Location = new Point(232, 343);
			lblAmount.Name = "lblAmount";
			lblAmount.Size = new Size(65, 26);
			lblAmount.TabIndex = 7;
			lblAmount.Text = "P300?";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.White;
			label5.Location = new Point(153, 396);
			label5.Name = "label5";
			label5.Size = new Size(103, 26);
			label5.TabIndex = 8;
			label5.Text = "Continue ?";
			// 
			// btnYes
			// 
			btnYes.BackColor = Color.Green;
			btnYes.BackgroundColor = Color.Green;
			btnYes.BorderColor = Color.PaleVioletRed;
			btnYes.BorderRadius = 12;
			btnYes.BorderSize = 0;
			btnYes.Cursor = Cursors.Hand;
			btnYes.FlatAppearance.BorderSize = 0;
			btnYes.FlatStyle = FlatStyle.Flat;
			btnYes.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnYes.ForeColor = Color.White;
			btnYes.Location = new Point(262, 393);
			btnYes.Name = "btnYes";
			btnYes.Size = new Size(65, 29);
			btnYes.TabIndex = 9;
			btnYes.Text = "Yes";
			btnYes.TextColor = Color.White;
			btnYes.UseVisualStyleBackColor = false;
			btnYes.Click += btnYes_Click;
			// 
			// btnNo
			// 
			btnNo.BackColor = Color.Red;
			btnNo.BackgroundColor = Color.Red;
			btnNo.BorderColor = Color.PaleVioletRed;
			btnNo.BorderRadius = 12;
			btnNo.BorderSize = 0;
			btnNo.Cursor = Cursors.Hand;
			btnNo.FlatAppearance.BorderSize = 0;
			btnNo.FlatStyle = FlatStyle.Flat;
			btnNo.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnNo.ForeColor = Color.White;
			btnNo.Location = new Point(333, 393);
			btnNo.Name = "btnNo";
			btnNo.Size = new Size(65, 29);
			btnNo.TabIndex = 10;
			btnNo.Text = "No";
			btnNo.TextColor = Color.White;
			btnNo.UseVisualStyleBackColor = false;
			btnNo.Click += btnNo_Click;
			// 
			// lblPaymentOpt
			// 
			lblPaymentOpt.AutoSize = true;
			lblPaymentOpt.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point);
			lblPaymentOpt.ForeColor = Color.White;
			lblPaymentOpt.Location = new Point(216, 160);
			lblPaymentOpt.Name = "lblPaymentOpt";
			lblPaymentOpt.Size = new Size(137, 39);
			lblPaymentOpt.TabIndex = 11;
			lblPaymentOpt.Text = "Payment";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Corbel", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.White;
			label6.Location = new Point(54, 199);
			label6.Name = "label6";
			label6.Size = new Size(337, 39);
			label6.TabIndex = 12;
			label6.Text = "as your payment option:";
			// 
			// lblMembership
			// 
			lblMembership.AutoSize = true;
			lblMembership.Font = new Font("Corbel", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lblMembership.ForeColor = Color.White;
			lblMembership.Location = new Point(286, 287);
			lblMembership.Name = "lblMembership";
			lblMembership.Size = new Size(120, 24);
			lblMembership.TabIndex = 13;
			lblMembership.Text = "Membership ";
			// 
			// Amount
			// 
			AutoScaleDimensions = new SizeF(6F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 82, 83);
			ClientSize = new Size(610, 585);
			Controls.Add(lblMembership);
			Controls.Add(label6);
			Controls.Add(lblPaymentOpt);
			Controls.Add(btnNo);
			Controls.Add(btnYes);
			Controls.Add(label5);
			Controls.Add(lblAmount);
			Controls.Add(label4);
			Controls.Add(cmbType);
			Controls.Add(label3);
			Controls.Add(label1);
			Controls.Add(panel1);
			Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Amount";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Amount";
			Load += Amount_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label2;
		private PictureBox pictureBox2;
		private Label label1;
		private Label label3;
		private ComboBox cmbType;
		private Label label4;
		private Label lblAmount;
		private Label label5;
		private customizeButtons btnYes;
		private customizeButtons btnNo;
		private Label lblPaymentOpt;
		private Label label6;
		private Label lblUser;
		private Label lblMembership;
	}
}