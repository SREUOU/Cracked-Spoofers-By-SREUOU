using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Helix_Spoofer;

namespace HwidSpoofer
{
	// Token: 0x0200000F RID: 15
	public partial class spoofed : Form
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000946B File Offset: 0x0000766B
		public spoofed()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00009484 File Offset: 0x00007684
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			Loading loading = new Loading();
			loading.Show();
			base.Hide();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000094A6 File Offset: 0x000076A6
		private void spoofed_Load(object sender, EventArgs e)
		{
		}
	}
}
