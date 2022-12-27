namespace Helix_Spoofer
{
	// Token: 0x02000008 RID: 8
	public partial class Spoofer_BE : global::System.Windows.Forms.Form
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00005C30 File Offset: 0x00003E30
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005C68 File Offset: 0x00003E68
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
			this.diskdrive.Location = new global::System.Drawing.Point(10, 76);
			this.diskdrive.Name = "diskdrive";
			this.diskdrive.Size = new global::System.Drawing.Size(0, 15);
			this.diskdrive.TabIndex = 56;
			this.baseboard.AutoSize = true;
			this.baseboard.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.baseboard.ForeColor = global::System.Drawing.Color.DarkRed;
			this.baseboard.Location = new global::System.Drawing.Point(10, 54);
			this.baseboard.Name = "baseboard";
			this.baseboard.Size = new global::System.Drawing.Size(0, 15);
			this.baseboard.TabIndex = 55;
			this.bios.AutoSize = true;
			this.bios.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bios.ForeColor = global::System.Drawing.Color.DarkRed;
			this.bios.Location = new global::System.Drawing.Point(10, 32);
			this.bios.Name = "bios";
			this.bios.Size = new global::System.Drawing.Size(0, 15);
			this.bios.TabIndex = 54;
			this.cpu.AutoSize = true;
			this.cpu.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cpu.ForeColor = global::System.Drawing.Color.DarkRed;
			this.cpu.Location = new global::System.Drawing.Point(10, 10);
			this.cpu.Name = "cpu";
			this.cpu.Size = new global::System.Drawing.Size(0, 15);
			this.cpu.TabIndex = 53;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.label3.Location = new global::System.Drawing.Point(1003, 453);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(0, 21);
			this.label3.TabIndex = 60;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(70, 70, 70);
			this.label2.Location = new global::System.Drawing.Point(995, 445);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0, 21);
			this.label2.TabIndex = 59;
			this.guna2AnimateWindow1.AnimationType = global::Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label1.Location = new global::System.Drawing.Point(678, 644);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(451, 32);
			this.label1.TabIndex = 61;
			this.label1.Text = "Please wait 10-15 then close this window";
			this.swofmac.AutoSize = true;
			this.swofmac.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.swofmac.ForeColor = global::System.Drawing.Color.DarkRed;
			this.swofmac.Location = new global::System.Drawing.Point(10, 98);
			this.swofmac.Name = "swofmac";
			this.swofmac.Size = new global::System.Drawing.Size(0, 15);
			this.swofmac.TabIndex = 57;
			this.gunaProgressBar1.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.gunaProgressBar1.Location = new global::System.Drawing.Point(410, 294);
			this.gunaProgressBar1.Maximum = 16000;
			this.gunaProgressBar1.Name = "gunaProgressBar1";
			this.gunaProgressBar1.ProgressColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.gunaProgressBar1.ProgressColor2 = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.gunaProgressBar1.ShadowDecoration.Parent = this.gunaProgressBar1;
			this.gunaProgressBar1.Size = new global::System.Drawing.Size(300, 30);
			this.gunaProgressBar1.TabIndex = 63;
			this.gunaProgressBar1.Text = "guna2ProgressBar1";
			this.gunaProgressBar1.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.gunaProgressBar1.ValueChanged += new global::System.EventHandler(this.gunaProgressBar1_ValueChanged);
			this.guna2PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = global::HwidSpoofer.Properties.Resources.R_unscreen;
			this.guna2PictureBox1.ImageRotate = 0f;
			this.guna2PictureBox1.Location = new global::System.Drawing.Point(761, 423);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
			this.guna2PictureBox1.Size = new global::System.Drawing.Size(318, 218);
			this.guna2PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 62;
			this.guna2PictureBox1.TabStop = false;
			this.pictureBox1.Image = global::HwidSpoofer.Properties.Resources.logo_white1;
			this.pictureBox1.Location = new global::System.Drawing.Point(737, 236);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(366, 301);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 58;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			base.ClientSize = new global::System.Drawing.Size(1401, 964);
			base.Controls.Add(this.gunaProgressBar1);
			base.Controls.Add(this.diskdrive);
			base.Controls.Add(this.baseboard);
			base.Controls.Add(this.bios);
			base.Controls.Add(this.cpu);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.guna2PictureBox1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.swofmac);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Spoofer_BE";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Spoofer_BE";
			base.Load += new global::System.EventHandler(this.Spoofer_BE_Load);
			((global::System.ComponentModel.ISupportInitialize)this.guna2PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000031 RID: 49
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label diskdrive;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label baseboard;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label bios;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label cpu;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000039 RID: 57
		private global::Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

		// Token: 0x0400003A RID: 58
		private global::Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label swofmac;

		// Token: 0x0400003E RID: 62
		private global::Guna.UI2.WinForms.Guna2ProgressBar gunaProgressBar1;
	}
}
