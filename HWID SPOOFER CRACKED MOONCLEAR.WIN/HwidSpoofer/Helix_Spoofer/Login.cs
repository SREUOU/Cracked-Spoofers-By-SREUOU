using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using HwidSpoofer;
using HwidSpoofer.Properties;
using KeyAuth;
using Siticone.UI.WinForms;

namespace Helix_Spoofer
{
	// Token: 0x02000003 RID: 3
	public partial class Login : Form
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002744 File Offset: 0x00000944
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000275C File Offset: 0x0000095C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.siticoneShadowForm1.SetShadowForm(this);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000276C File Offset: 0x0000096C
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Loading loading = new Loading();
				loading.Show();
				base.Hide();
			}
			else
			{
				incorrect_msg incorrect_msg = new incorrect_msg();
				incorrect_msg.Show();
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000027D5 File Offset: 0x000009D5
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			base.TopMost = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000027EC File Offset: 0x000009EC
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
			bool success = Login.KeyAuthApp.response.success;
			if (success)
			{
				Loading loading = new Loading();
				loading.Show();
				base.Hide();
			}
			else
			{
				incorrect_msg incorrect_msg = new incorrect_msg();
				incorrect_msg.Show();
			}
		}

		// Token: 0x0400000A RID: 10
		public static api KeyAuthApp = new api("test", "pirYmlWzUE", "0d3411a89e6665814e37296bdb32ec321b392e9b8c5ff3b5b7fdd312a3f3075e", "1.0");
	}
}
