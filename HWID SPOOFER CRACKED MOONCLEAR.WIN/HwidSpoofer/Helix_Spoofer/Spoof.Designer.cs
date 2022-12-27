namespace Helix_Spoofer
{
	// Token: 0x02000006 RID: 6
	public partial class Spoof : global::System.Windows.Forms.Form
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00003FC8 File Offset: 0x000021C8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004000 File Offset: 0x00002200
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.diskdrive = new global::System.Windows.Forms.Label();
			this.baseboard = new global::System.Windows.Forms.Label();
			this.bios = new global::System.Windows.Forms.Label();
			this.cpu = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.guna2AnimateWindow1 = new global::Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.swofmac = new global::System.Windows.Forms.Label();
			this.gunaProgressBar1 = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.guna2PictureBox1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.guna2PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.diskdrive.AutoSize = true;
			this.diskdrive.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.diskdrive.ForeColor = global::System.Drawing.Color.DarkRed;
			this.diskdrive.Location = new global::System.Drawing.Point(7, 73);
			this.diskdrive.Name = "diskdrive";
			this.diskdrive.Size = new global::System.Drawing.Size(0, 15);
			this.diskdrive.TabIndex = 44;
			this.baseboard.AutoSize = true;
			this.baseboard.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.baseboard.ForeColor = global::System.Drawing.Color.DarkRed;
			this.baseboard.Location = new global::System.Drawing.Point(7, 51);
			this.baseboard.Name = "baseboard";
			this.baseboard.Size = new global::System.Drawing.Size(0, 15);
			this.baseboard.TabIndex = 43;
			this.bios.AutoSize = true;
			this.bios.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bios.ForeColor = global::System.Drawing.Color.DarkRed;
			this.bios.Location = new global::System.Drawing.Point(7, 29);
			this.bios.Name = "bios";
			this.bios.Size = new global::System.Drawing.Size(0, 15);
			this.bios.TabIndex = 42;
			this.cpu.AutoSize = true;
			this.cpu.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cpu.ForeColor = global::System.Drawing.Color.DarkRed;
			this.cpu.Location = new global::System.Drawing.Point(7, 7);
			this.cpu.Name = "cpu";
			this.cpu.Size = new global::System.Drawing.Size(0, 15);
			this.cpu.TabIndex = 41;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.label3.Location = new global::System.Drawing.Point(1001, 551);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(0, 21);
			this.label3.TabIndex = 48;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.label2.Location = new global::System.Drawing.Point(993, 543);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0, 21);
			this.label2.TabIndex = 47;
			this.guna2AnimateWindow1.AnimationType = global::Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label1.Location = new global::System.Drawing.Point(676, 731);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(539, 32);
			this.label1.TabIndex = 50;
			this.label1.Text = "Please wait 10-15 seconds until your PC Spoofs....";
			this.swofmac.AutoSize = true;
			this.swofmac.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.swofmac.ForeColor = global::System.Drawing.Color.DarkRed;
			this.swofmac.Location = new global::System.Drawing.Point(7, 95);
			this.swofmac.Name = "swofmac";
			this.swofmac.Size = new global::System.Drawing.Size(0, 15);
			this.swofmac.TabIndex = 45;
			this.gunaProgressBar1.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.gunaProgressBar1.Location = new global::System.Drawing.Point(389, 437);
			this.gunaProgressBar1.Maximum = 16000;
			this.gunaProgressBar1.Name = "gunaProgressBar1";
			this.gunaProgressBar1.ProgressColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.gunaProgressBar1.ProgressColor2 = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.gunaProgressBar1.ShadowDecoration.Parent = this.gunaProgressBar1;
			this.gunaProgressBar1.Size = new global::System.Drawing.Size(300, 30);
			this.gunaProgressBar1.TabIndex = 52;
			this.gunaProgressBar1.Text = "guna2ProgressBar1";
			this.gunaProgressBar1.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.guna2PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::HwidSpoofer.Properties.Resources.R_unscreen;
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(759, 510);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(318, 218);
			this.guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 51;
			this.guna2PictureBox1.TabStop = false;
			this.pictureBox1.Image = global::HwidSpoofer.Properties.Resources.logo_white2;
			this.pictureBox1.Location = new global::System.Drawing.Point(724, 348);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(363, 213);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 46;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			base.ClientSize = new global::System.Drawing.Size(1401, 964);
			base.Controls.Add(this.gunaProgressBar1);
			base.Controls.Add(this.guna2PictureBox1);
			base.Controls.Add(this.diskdrive);
			base.Controls.Add(this.baseboard);
			base.Controls.Add(this.bios);
			base.Controls.Add(this.cpu);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.swofmac);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Spoof";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "s";
			base.Load += new global::System.EventHandler(this.Spoof_Load);
			((global::System.ComponentModel.ISupportInitialize)this.guna2PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label diskdrive;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label baseboard;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label bios;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label cpu;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000023 RID: 35
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label swofmac;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

		// Token: 0x04000028 RID: 40
		private global::Guna.UI2.WinForms.Guna2ProgressBar gunaProgressBar1;
	}
}
