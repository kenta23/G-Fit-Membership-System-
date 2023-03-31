namespace membership_system_G_fit
{
	partial class Optionlogin
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.btnMembers = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::membership_system_G_fit.Properties.Resources._334911262_584837146896162_3113683020547611700_n_removebg_preview;
			this.pictureBox1.Location = new System.Drawing.Point(47, 97);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(174, 174);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(184, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 33);
			this.label3.TabIndex = 3;
			this.label3.Text = "WELCOME!";
			// 
			// btnAdmin
			// 
			this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdmin.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnAdmin.ForeColor = System.Drawing.Color.White;
			this.btnAdmin.Location = new System.Drawing.Point(297, 127);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(130, 44);
			this.btnAdmin.TabIndex = 4;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.UseVisualStyleBackColor = false;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// btnMembers
			// 
			this.btnMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnMembers.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMembers.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnMembers.ForeColor = System.Drawing.Color.White;
			this.btnMembers.Location = new System.Drawing.Point(297, 203);
			this.btnMembers.Name = "btnMembers";
			this.btnMembers.Size = new System.Drawing.Size(130, 44);
			this.btnMembers.TabIndex = 5;
			this.btnMembers.Text = "Members";
			this.btnMembers.UseVisualStyleBackColor = false;
			this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
			// 
			// Optionlogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
			this.BackgroundImage = global::membership_system_G_fit.Properties.Resources.logo_g___fit_removebg_preview;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(527, 332);
			this.Controls.Add(this.btnMembers);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Optionlogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Optionlogin";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private PictureBox pictureBox1;
		private Label label3;
		private Button btnAdmin;
		private Button btnMembers;
	}
}