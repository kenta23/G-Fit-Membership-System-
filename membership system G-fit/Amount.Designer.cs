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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblUser = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lblAmount = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnYes = new membership_system_G_fit.customizeButtons();
			this.btnNo = new membership_system_G_fit.customizeButtons();
			this.lblPaymentOpt = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lblUser);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(610, 71);
			this.panel1.TabIndex = 1;
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.lblUser.Location = new System.Drawing.Point(87, 22);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(72, 29);
			this.lblUser.TabIndex = 29;
			this.lblUser.Text = "label7";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(566, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 33);
			this.label2.TabIndex = 28;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::membership_system_G_fit.Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			this.pictureBox2.Location = new System.Drawing.Point(23, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(56, 52);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(54, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 39);
			this.label1.TabIndex = 2;
			this.label1.Text = "You choose";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(87, 287);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(193, 26);
			this.label3.TabIndex = 3;
			this.label3.Text = "Type of Membership:";
			// 
			// cmbType
			// 
			this.cmbType.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "Monthly",
            "6 Months ",
            "12 Months"});
			this.cmbType.Location = new System.Drawing.Point(286, 289);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(121, 27);
			this.cmbType.TabIndex = 4;
			this.cmbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(150, 343);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 26);
			this.label4.TabIndex = 5;
			this.label4.Text = "You pay:";
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblAmount.ForeColor = System.Drawing.Color.White;
			this.lblAmount.Location = new System.Drawing.Point(232, 343);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(65, 26);
			this.lblAmount.TabIndex = 7;
			this.lblAmount.Text = "P300?";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(153, 396);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 26);
			this.label5.TabIndex = 8;
			this.label5.Text = "Continue ?";
			// 
			// btnYes
			// 
			this.btnYes.BackColor = System.Drawing.Color.Green;
			this.btnYes.BackgroundColor = System.Drawing.Color.Green;
			this.btnYes.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnYes.BorderRadius = 12;
			this.btnYes.BorderSize = 0;
			this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnYes.FlatAppearance.BorderSize = 0;
			this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYes.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnYes.ForeColor = System.Drawing.Color.White;
			this.btnYes.Location = new System.Drawing.Point(262, 393);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(65, 29);
			this.btnYes.TabIndex = 9;
			this.btnYes.Text = "Yes";
			this.btnYes.TextColor = System.Drawing.Color.White;
			this.btnYes.UseVisualStyleBackColor = false;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// btnNo
			// 
			this.btnNo.BackColor = System.Drawing.Color.Red;
			this.btnNo.BackgroundColor = System.Drawing.Color.Red;
			this.btnNo.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btnNo.BorderRadius = 12;
			this.btnNo.BorderSize = 0;
			this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNo.FlatAppearance.BorderSize = 0;
			this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNo.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnNo.ForeColor = System.Drawing.Color.White;
			this.btnNo.Location = new System.Drawing.Point(333, 393);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(65, 29);
			this.btnNo.TabIndex = 10;
			this.btnNo.Text = "No";
			this.btnNo.TextColor = System.Drawing.Color.White;
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// lblPaymentOpt
			// 
			this.lblPaymentOpt.AutoSize = true;
			this.lblPaymentOpt.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPaymentOpt.ForeColor = System.Drawing.Color.White;
			this.lblPaymentOpt.Location = new System.Drawing.Point(216, 160);
			this.lblPaymentOpt.Name = "lblPaymentOpt";
			this.lblPaymentOpt.Size = new System.Drawing.Size(137, 39);
			this.lblPaymentOpt.TabIndex = 11;
			this.lblPaymentOpt.Text = "Payment";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(54, 199);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(337, 39);
			this.label6.TabIndex = 12;
			this.label6.Text = "as your payment option:";
			// 
			// Amount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.ClientSize = new System.Drawing.Size(610, 585);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblPaymentOpt);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnYes);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblAmount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Amount";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Amount";
			this.Load += new System.EventHandler(this.Amount_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}