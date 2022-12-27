using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Helix_Spoofer
{
	// Token: 0x02000009 RID: 9
	public partial class SpoofMain : Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000658B File Offset: 0x0000478B
		public SpoofMain()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000065A3 File Offset: 0x000047A3
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000065A8 File Offset: 0x000047A8
		private void button1_Click(object sender, EventArgs e)
		{
			SpoofSettings spoofSettings = new SpoofSettings();
			spoofSettings.Show();
			base.Hide();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000065CA File Offset: 0x000047CA
		private void SpoofMain_Load(object sender, EventArgs e)
		{
		}
	}
}
