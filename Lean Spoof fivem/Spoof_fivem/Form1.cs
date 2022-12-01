using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;

namespace Spoof_fivem
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003B72 File Offset: 0x00001D72
		public Form1()
		{
			this.InitializeComponent();
			Form1.KeyAuthApp.init();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003B95 File Offset: 0x00001D95
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003B98 File Offset: 0x00001D98
		private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/ycDg4UbSN7");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003BA6 File Offset: 0x00001DA6
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003BAC File Offset: 0x00001DAC
		private void button1_Click(object sender, EventArgs e)
		{
			Form1.KeyAuthApp.login(this.txtUsername.Text, this.txtpassword.Text);
			bool success = Form1.KeyAuthApp.response.success;
			if (success)
			{
				MessageBox.Show("Login successful");
				freedash freedash = new freedash();
				freedash.Show();
				base.Hide();
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003C42 File Offset: 0x00001E42
		private void txtpassword_TextChanged(object sender, EventArgs e)
		{
			this.txtpassword.PasswordChar = '*';
		}

		// Token: 0x0400000E RID: 14
		private static string name = "WarTest";

		// Token: 0x0400000F RID: 15
		private static string ownerid = "hVbk0YTvZs";

		// Token: 0x04000010 RID: 16
		private static string secret = "89f9f0cbee6fc9f321df8641f822f154595d049cf7ec97e0f798505fad4ce9c0";

		// Token: 0x04000011 RID: 17
		private static string version = "1.0";

		// Token: 0x04000012 RID: 18
		public static api KeyAuthApp = new api(Form1.name, Form1.ownerid, Form1.secret, Form1.version);

		private void siticoneCirclePictureBox2_Click_1(object sender, EventArgs e)
		{

		}
	}
}
