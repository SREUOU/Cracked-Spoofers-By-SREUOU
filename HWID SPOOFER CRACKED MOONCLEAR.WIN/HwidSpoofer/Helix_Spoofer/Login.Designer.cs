namespace Helix_Spoofer
{
	// Token: 0x02000003 RID: 3
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002860 File Offset: 0x00000A60
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002898 File Offset: 0x00000A98
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.key = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.password = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.username = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.siticoneShadowForm1 = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::HwidSpoofer.Properties.Resources.Neues_Projekt__2_;
			this.pictureBox1.Location = new global::System.Drawing.Point(122, 118);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(163, 152);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.key.Animated = true;
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.BorderColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.key.BorderRadius = 4;
			this.key.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.key.DefaultText = "";
			this.key.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.key.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.key.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.DisabledState.Parent = this.key;
			this.key.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.key.FillColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.key.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(85, 85, 85);
			this.key.FocusedState.Parent = this.key;
			this.key.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.key.ForeColor = global::System.Drawing.Color.White;
			this.key.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(85, 85, 85);
			this.key.HoverState.Parent = this.key;
			this.key.Location = new global::System.Drawing.Point(292, 203);
			this.key.Margin = new global::System.Windows.Forms.Padding(4);
			this.key.Name = "key";
			this.key.PasswordChar = '\0';
			this.key.PlaceholderText = "License";
			this.key.SelectedText = "";
			this.key.ShadowDecoration.Parent = this.key;
			this.key.Size = new global::System.Drawing.Size(222, 27);
			this.key.TabIndex = 18;
			this.password.Animated = true;
			this.password.BackColor = global::System.Drawing.Color.Transparent;
			this.password.BorderColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.password.BorderRadius = 4;
			this.password.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.Parent = this.password;
			this.password.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.password.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(85, 85, 85);
			this.password.FocusedState.Parent = this.password;
			this.password.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.password.ForeColor = global::System.Drawing.Color.White;
			this.password.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(85, 85, 85);
			this.password.HoverState.Parent = this.password;
			this.password.Location = new global::System.Drawing.Point(292, 168);
			this.password.Margin = new global::System.Windows.Forms.Padding(4);
			this.password.Name = "password";
			this.password.PasswordChar = '•';
			this.password.PlaceholderText = "Password";
			this.password.SelectedText = "";
			this.password.ShadowDecoration.Parent = this.password;
			this.password.Size = new global::System.Drawing.Size(222, 27);
			this.password.TabIndex = 15;
			this.username.Animated = true;
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.username.BorderColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.username.BorderRadius = 4;
			this.username.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.Parent = this.username;
			this.username.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.username.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(85, 85, 85);
			this.username.FocusedState.Parent = this.username;
			this.username.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.Color.White;
			this.username.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(85, 85, 85);
			this.username.HoverState.Parent = this.username;
			this.username.Location = new global::System.Drawing.Point(292, 133);
			this.username.Margin = new global::System.Windows.Forms.Padding(4);
			this.username.Name = "username";
			this.username.PasswordChar = '\0';
			this.username.PlaceholderText = "Username";
			this.username.SelectedText = "";
			this.username.ShadowDecoration.Parent = this.username;
			this.username.Size = new global::System.Drawing.Size(222, 27);
			this.username.TabIndex = 14;
			this.guna2Button3.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button3.BorderColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.guna2Button3.BorderRadius = 3;
			this.guna2Button3.BorderThickness = 1;
			this.guna2Button3.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button3.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button3.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.CheckedState.Parent = this.guna2Button3;
			this.guna2Button3.CustomImages.Parent = this.guna2Button3;
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.DisabledState.Parent = this.guna2Button3;
			this.guna2Button3.FillColor = global::System.Drawing.Color.White;
			this.guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.Black;
			this.guna2Button3.HoverState.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.guna2Button3.HoverState.FillColor = global::System.Drawing.Color.PowderBlue;
			this.guna2Button3.HoverState.Parent = this.guna2Button3;
			this.guna2Button3.Location = new global::System.Drawing.Point(292, 237);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
			this.guna2Button3.Size = new global::System.Drawing.Size(108, 23);
			this.guna2Button3.TabIndex = 19;
			this.guna2Button3.Text = "REGISTER";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			this.guna2Button4.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button4.BorderColor = global::System.Drawing.Color.DodgerBlue;
			this.guna2Button4.BorderRadius = 3;
			this.guna2Button4.BorderThickness = 1;
			this.guna2Button4.CheckedState.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button4.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button4.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button4.CheckedState.Parent = this.guna2Button4;
			this.guna2Button4.CustomImages.Parent = this.guna2Button4;
			this.guna2Button4.DisabledState.BorderColor = global::System.Drawing.Color.White;
			this.guna2Button4.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button4.DisabledState.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button4.DisabledState.Parent = this.guna2Button4;
			this.guna2Button4.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button4.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button4.HoverState.BorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.guna2Button4.HoverState.Parent = this.guna2Button4;
			this.guna2Button4.Location = new global::System.Drawing.Point(406, 237);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
			this.guna2Button4.Size = new global::System.Drawing.Size(108, 23);
			this.guna2Button4.TabIndex = 20;
			this.guna2Button4.Text = "LOGIN";
			this.guna2Button4.Click += new global::System.EventHandler(this.guna2Button4_Click);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Gray;
			this.label1.Location = new global::System.Drawing.Point(238, 408);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(178, 13);
			this.label1.TabIndex = 21;
			this.label1.Text = "© 2017 - 2022 - hwidspoofer.com";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::HwidSpoofer.Properties.Resources.R;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(658, 430);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2Button4);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.key);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Login";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HwidSpoofer";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000B RID: 11
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400000D RID: 13
		private global::Guna.UI2.WinForms.Guna2TextBox key;

		// Token: 0x0400000E RID: 14
		private global::Guna.UI2.WinForms.Guna2TextBox password;

		// Token: 0x0400000F RID: 15
		private global::Guna.UI2.WinForms.Guna2TextBox username;

		// Token: 0x04000010 RID: 16
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;

		// Token: 0x04000011 RID: 17
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;

		// Token: 0x04000012 RID: 18
		private global::Guna.UI2.WinForms.Guna2Button guna2Button4;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Label label1;
	}
}
