using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using HwidSpoofer.Properties;

namespace Helix_Spoofer
{
	// Token: 0x02000004 RID: 4
	public partial class Main : Form
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00003758 File Offset: 0x00001958
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003770 File Offset: 0x00001970
		private void Main_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003774 File Offset: 0x00001974
		private void button1_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003796 File Offset: 0x00001996
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Comming Soon...", "Soon", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000037AC File Offset: 0x000019AC
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			SpoofMain spoofMain = new SpoofMain();
			spoofMain.Show();
		}
	}
}
