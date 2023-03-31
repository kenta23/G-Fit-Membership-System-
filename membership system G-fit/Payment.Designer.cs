namespace membership_system_G_fit
{
	partial class Payment
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBack = new membership_system_G_fit.customizeButtons();
			this.lblMemberName = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblMembershipType = new System.Windows.Forms.Label();
			this.lblPaidDate = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lblWelcome);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1079, 65);
			this.panel1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(1035, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 33);
			this.label2.TabIndex = 27;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lblWelcome
			// 
			this.lblWelcome.AutoSize = true;
			this.lblWelcome.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.lblWelcome.Location = new System.Drawing.Point(528, 18);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(97, 36);
			this.lblWelcome.TabIndex = 4;
			this.lblWelcome.Text = "G- FIT ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::membership_system_G_fit.Properties.Resources._334911878_1440815073393289_6073420652339816876_n_removebg_preview;
			this.pictureBox1.Location = new System.Drawing.Point(36, 11);
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
			this.label1.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(400, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(334, 39);
			this.label1.TabIndex = 2;
			this.label1.Text = "Membership Payments";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(102, 191);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(685, 207);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(102, 439);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(182, 33);
			this.label3.TabIndex = 4;
			this.label3.Text = "Member name:";
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
			this.btnBack.Location = new System.Drawing.Point(952, 569);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(103, 40);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "Back";
			this.btnBack.TextColor = System.Drawing.Color.White;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// lblMemberName
			// 
			this.lblMemberName.AutoSize = true;
			this.lblMemberName.BackColor = System.Drawing.Color.Transparent;
			this.lblMemberName.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMemberName.ForeColor = System.Drawing.Color.Black;
			this.lblMemberName.Location = new System.Drawing.Point(275, 445);
			this.lblMemberName.Name = "lblMemberName";
			this.lblMemberName.Size = new System.Drawing.Size(142, 26);
			this.lblMemberName.TabIndex = 12;
			this.lblMemberName.Text = "Member name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(102, 487);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(216, 33);
			this.label6.TabIndex = 13;
			this.label6.Text = "Membership Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(102, 534);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(241, 33);
			this.label4.TabIndex = 14;
			this.label4.Text = "Date of Registration:";
			// 
			// lblMembershipType
			// 
			this.lblMembershipType.AutoSize = true;
			this.lblMembershipType.BackColor = System.Drawing.Color.Transparent;
			this.lblMembershipType.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblMembershipType.ForeColor = System.Drawing.Color.Black;
			this.lblMembershipType.Location = new System.Drawing.Point(310, 493);
			this.lblMembershipType.Name = "lblMembershipType";
			this.lblMembershipType.Size = new System.Drawing.Size(170, 26);
			this.lblMembershipType.TabIndex = 15;
			this.lblMembershipType.Text = "Membership Type:";
			// 
			// lblPaidDate
			// 
			this.lblPaidDate.AutoSize = true;
			this.lblPaidDate.BackColor = System.Drawing.Color.Transparent;
			this.lblPaidDate.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblPaidDate.ForeColor = System.Drawing.Color.Black;
			this.lblPaidDate.Location = new System.Drawing.Point(338, 541);
			this.lblPaidDate.Name = "lblPaidDate";
			this.lblPaidDate.Size = new System.Drawing.Size(53, 26);
			this.lblPaidDate.TabIndex = 16;
			this.lblPaidDate.Text = "Date";
			// 
			// Payment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1079, 653);
			this.Controls.Add(this.lblPaidDate);
			this.Controls.Add(this.lblMembershipType);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblMemberName);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Payment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payment";
			this.Load += new System.EventHandler(this.Payment_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel panel1;
		private Label lblWelcome;
		private PictureBox pictureBox1;
		private Label label2;
		private Label label1;
		private DataGridView dataGridView1;
		private Label label3;
		private customizeButtons btnBack;
		private Label lblMemberName;
		private Label label6;
		private Label label4;
		private Label lblMembershipType;
		private Label lblPaidDate;
	}
}