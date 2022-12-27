using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using HwidSpoofer.Properties;
using KeyAuth;

namespace Helix_Spoofer
{
	// Token: 0x02000002 RID: 2
	public partial class Loading : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Loading()
		{
			this.InitializeComponent();
			this.timer1.Start();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000209F File Offset: 0x0000029F
		private void Loading_Load(object sender, EventArgs e)
		{
			Loading.KeyAuthApp.init();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020B0 File Offset: 0x000002B0
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.gunaProgressBar1.Value += 5;
			bool flag = this.gunaProgressBar1.Value >= 5;
			if (flag)
			{
				this.drc.Text = "authenicating with server, loading modules.";
			}
			bool flag2 = this.gunaProgressBar1.Value >= 65;
			if (flag2)
			{
				this.drc.Text = "verifying application integrity, checking...";
			}
			bool flag3 = this.gunaProgressBar1.Value >= 95;
			if (flag3)
			{
				this.drc.Text = "verifying your OS information...";
				this.label1.Text = "Welcome, " + Login.KeyAuthApp.user_data.username;
			}
			bool flag4 = this.gunaProgressBar1.Value >= 115;
			if (flag4)
			{
				this.drc.Text = "retrieving software status...";
			}
			bool flag5 = this.gunaProgressBar1.Value >= 135;
			if (flag5)
			{
				this.drc.Text = "retrieving your licenses...";
			}
			bool flag6 = this.gunaProgressBar1.Value == 140;
			if (flag6)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
				this.timer1.Enabled = false;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002205 File Offset: 0x00000405
		private void webBrowser122_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002208 File Offset: 0x00000408
		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000220B File Offset: 0x0000040B
		private void drc_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		public static api KeyAuthApp = new api("test", "pirYmlWzUE", "0d3411a89e6665814e37296bdb32ec321b392e9b8c5ff3b5b7fdd312a3f3075e", "1.0");

		// Token: 0x04000002 RID: 2
		private WebClient wc = new WebClient();

		// Token: 0x04000003 RID: 3
		private string defPath = Application.StartupPath + "//Monaco//";
	}
}
