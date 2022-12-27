using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using HwidSpoofer.Properties;

namespace Helix_Spoofer
{
	// Token: 0x02000007 RID: 7
	public partial class spoofeac_loader : Form
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000048ED File Offset: 0x00002AED
		public spoofeac_loader()
		{
			this.InitializeComponent();
			this.timer1.Start();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004914 File Offset: 0x00002B14
		private void spoofeac_loader_Load(object sender, EventArgs e)
		{
			Process.Start("taskkill", "/F /IDA Freeware 7.7");
			Process.Start("taskkill", "/F /ida64");
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			foreach (Process process in processesByName)
			{
				process.Kill();
			}
			Process[] processesByName2 = Process.GetProcessesByName("HTTP Debugger");
			foreach (Process process2 in processesByName2)
			{
				process2.Kill();
			}
			Process[] processesByName3 = Process.GetProcessesByName("Fiddler");
			foreach (Process process3 in processesByName3)
			{
				process3.Kill();
			}
			Process[] processesByName4 = Process.GetProcessesByName("x96dbg");
			foreach (Process process4 in processesByName4)
			{
				process4.Kill();
			}
			Process[] processesByName5 = Process.GetProcessesByName("x64dbg");
			foreach (Process process5 in processesByName5)
			{
				process5.Kill();
			}
			Process[] processesByName6 = Process.GetProcessesByName("HxD");
			foreach (Process process6 in processesByName6)
			{
				process6.Kill();
			}
			Process[] processesByName7 = Process.GetProcessesByName("Hexy");
			foreach (Process process7 in processesByName7)
			{
				process7.Kill();
			}
			Process[] processesByName8 = Process.GetProcessesByName("dotPeek64");
			foreach (Process process8 in processesByName8)
			{
				process8.Kill();
			}
			Process[] processesByName9 = Process.GetProcessesByName("dotPeek32");
			foreach (Process process9 in processesByName9)
			{
				process9.Kill();
			}
			Process[] processesByName10 = Process.GetProcessesByName("cheatengine-x86_64-SSE4-AVX2");
			foreach (Process process10 in processesByName10)
			{
				process10.Kill();
			}
			Process[] processesByName11 = Process.GetProcessesByName("Cheat Engine");
			foreach (Process process11 in processesByName3)
			{
				process11.Kill();
			}
			Process[] processesByName12 = Process.GetProcessesByName("cheatengine-i386");
			foreach (Process process12 in processesByName2)
			{
				process12.Kill();
			}
			Process[] processesByName13 = Process.GetProcessesByName("cheatengine-x86_64");
			foreach (Process process13 in processesByName13)
			{
				process13.Kill();
			}
			Process[] processesByName14 = Process.GetProcessesByName("windowsrepair");
			foreach (Process process14 in processesByName14)
			{
				process14.Kill();
			}
			Process[] processesByName15 = Process.GetProcessesByName("ida64");
			foreach (Process process15 in processesByName14)
			{
				process15.Kill();
			}
			Process[] processesByName16 = Process.GetProcessesByName("x64dbg");
			foreach (Process process16 in processesByName14)
			{
				process16.Kill();
			}
			Process[] processesByName17 = Process.GetProcessesByName("dnSpy");
			foreach (Process process17 in processesByName14)
			{
				process17.Kill();
			}
			Process[] processesByName18 = Process.GetProcessesByName("FolderChangesView");
			foreach (Process process18 in processesByName14)
			{
				process18.Kill();
			}
			Process[] processesByName19 = Process.GetProcessesByName("BinaryNinja");
			foreach (Process process19 in processesByName14)
			{
				process19.Kill();
			}
			Process[] processesByName20 = Process.GetProcessesByName("Cheat Engine 7.4");
			foreach (Process process20 in processesByName14)
			{
				process20.Kill();
			}
			Process[] processesByName21 = Process.GetProcessesByName("Process Hacker");
			foreach (Process process21 in processesByName14)
			{
				process21.Kill();
			}
			Process[] processesByName22 = Process.GetProcessesByName("Process Hacker 1");
			foreach (Process process22 in processesByName14)
			{
				process22.Kill();
			}
			Process[] processesByName23 = Process.GetProcessesByName("Process Hacker 2");
			foreach (Process process23 in processesByName14)
			{
				process23.Kill();
			}
			Process[] processesByName24 = Process.GetProcessesByName("OllyDbg");
			foreach (Process process24 in processesByName14)
			{
				process24.Kill();
			}
			Process[] processesByName25 = Process.GetProcessesByName("Spy");
			foreach (Process process25 in processesByName14)
			{
				process25.Kill();
			}
			Process[] processesByName26 = Process.GetProcessesByName("Debugger");
			foreach (Process process26 in processesByName14)
			{
				process26.Kill();
			}
			Process[] processesByName27 = Process.GetProcessesByName("Xenon");
			foreach (Process process27 in processesByName14)
			{
				process27.Kill();
			}
			Process[] processesByName28 = Process.GetProcessesByName("xdebug");
			foreach (Process process28 in processesByName14)
			{
				process28.Kill();
			}
			Process[] processesByName29 = Process.GetProcessesByName("ida");
			foreach (Process process29 in processesByName14)
			{
				process29.Kill();
			}
			Process[] processesByName30 = Process.GetProcessesByName("CocoaDebug");
			foreach (Process process30 in processesByName14)
			{
				process30.Kill();
			}
			Process[] processesByName31 = Process.GetProcessesByName("x32dbg");
			foreach (Process process31 in processesByName14)
			{
				process31.Kill();
			}
			Process[] processesByName32 = Process.GetProcessesByName("krzydbg");
			foreach (Process process32 in processesByName14)
			{
				process32.Kill();
			}
			Process[] processesByName33 = Process.GetProcessesByName("OllyDBG");
			foreach (Process process33 in processesByName14)
			{
				process33.Kill();
			}
			Process[] processesByName34 = Process.GetProcessesByName("die");
			foreach (Process process34 in processesByName14)
			{
				process34.Kill();
			}
			Process[] processesByName35 = Process.GetProcessesByName(".NET Reflector");
			foreach (Process process35 in processesByName14)
			{
				process35.Kill();
			}
			Process[] processesByName36 = Process.GetProcessesByName("4fr33");
			foreach (Process process36 in processesByName14)
			{
				process36.Kill();
			}
			Process[] processesByName37 = Process.GetProcessesByName("HxD64");
			foreach (Process process37 in processesByName14)
			{
				process37.Kill();
			}
			Process[] processesByName38 = Process.GetProcessesByName("HxD32");
			foreach (Process process38 in processesByName14)
			{
				process38.Kill();
			}
			Process[] processesByName39 = Process.GetProcessesByName("PE-bear");
			foreach (Process process39 in processesByName14)
			{
				process39.Kill();
			}
			Process[] processesByName40 = Process.GetProcessesByName("HWorks32");
			foreach (Process process40 in processesByName14)
			{
				process40.Kill();
			}
			Process[] processesByName41 = Process.GetProcessesByName("CFF Explorer");
			foreach (Process process41 in processesByName14)
			{
				process41.Kill();
			}
			Process[] processesByName42 = Process.GetProcessesByName("winhex");
			foreach (Process process42 in processesByName14)
			{
				process42.Kill();
			}
			Process[] processesByName43 = Process.GetProcessesByName("vsd_win32");
			foreach (Process process43 in processesByName14)
			{
				process43.Kill();
			}
			Process[] processesByName44 = Process.GetProcessesByName("PETools");
			foreach (Process process44 in processesByName14)
			{
				process44.Kill();
			}
			Process[] processesByName45 = Process.GetProcessesByName("nfd");
			foreach (Process process45 in processesByName14)
			{
				process45.Kill();
			}
			Process[] processesByName46 = Process.GetProcessesByName("ResourceHacker");
			foreach (Process process46 in processesByName14)
			{
				process46.Kill();
			}
			Process[] processesByName47 = Process.GetProcessesByName("ESEADriver2");
			foreach (Process process47 in processesByName14)
			{
				process47.Kill();
			}
			Process[] processesByName48 = Process.GetProcessesByName("Injector");
			foreach (Process process48 in processesByName14)
			{
				process48.Kill();
			}
			Process[] processesByName49 = Process.GetProcessesByName("Extrem Injector");
			foreach (Process process49 in processesByName14)
			{
				process49.Kill();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005360 File Offset: 0x00003560
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
				this.drc.Text = "Checking Whitelist...";
			}
			bool flag4 = this.gunaProgressBar1.Value >= 115;
			if (flag4)
			{
				this.drc.Text = "Checking for Software-Updates...";
			}
			bool flag5 = this.gunaProgressBar1.Value >= 135;
			if (flag5)
			{
				this.drc.Text = "Checking for Debuggers...";
			}
			bool flag6 = this.gunaProgressBar1.Value == 140;
			if (flag6)
			{
				Spoof spoof = new Spoof();
				spoof.Show();
				base.Hide();
				this.timer1.Enabled = false;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005490 File Offset: 0x00003690
		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005493 File Offset: 0x00003693
		private void drc_Click(object sender, EventArgs e)
		{
		}
	}
}
