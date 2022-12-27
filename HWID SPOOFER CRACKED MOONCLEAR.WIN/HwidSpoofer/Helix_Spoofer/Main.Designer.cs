namespace Helix_Spoofer
{
	// Token: 0x02000004 RID: 4
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000037C8 File Offset: 0x000019C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003800 File Offset: 0x00001A00
		private void InitializeComponent()
		{
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.DisabledState.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.White;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.SkyBlue;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Location = new global::System.Drawing.Point(-2, 153);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(354, 32);
			this.guna2Button1.TabIndex = 4;
			this.guna2Button1.Text = "SPOOF";
			this.guna2Button1.TextOffset = new global::System.Drawing.Point(0, -2);
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button2.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.SteelBlue;
			this.button2.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.SteelBlue;
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(-1, 126);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(178, 28);
			this.button2.TabIndex = 5;
			this.button2.Text = "MANAGER SEEDS";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.button1.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.SteelBlue;
			this.button1.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.SteelBlue;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(172, 126);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(180, 28);
			this.button1.TabIndex = 6;
			this.button1.Text = "LOG-OUT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.pictureBox1.Image = global::HwidSpoofer.Properties.Resources.logo_white;
			this.pictureBox1.Location = new global::System.Drawing.Point(65, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(206, 116);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			base.ClientSize = new global::System.Drawing.Size(351, 184);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Main";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HwidSpoofer";
			base.Load += new global::System.EventHandler(this.Main_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000014 RID: 20
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000016 RID: 22
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button button1;
	}
}
