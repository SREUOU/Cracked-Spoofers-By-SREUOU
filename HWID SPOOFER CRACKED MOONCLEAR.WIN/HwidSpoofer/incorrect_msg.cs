using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace HwidSpoofer
{
	// Token: 0x0200000E RID: 14
	public partial class incorrect_msg : Form
	{
		// Token: 0x06000065 RID: 101
		[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern void BlockInput([MarshalAs(UnmanagedType.Bool)] [In] bool fBlockIt);

		// Token: 0x06000066 RID: 102
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000067 RID: 103 RVA: 0x00009084 File Offset: 0x00007284
		public incorrect_msg()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000090D7 File Offset: 0x000072D7
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000090E1 File Offset: 0x000072E1
		private void incorrect_msg_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x0400005A RID: 90
		private int w = Screen.PrimaryScreen.Bounds.Width;

		// Token: 0x0400005B RID: 91
		private int h = Screen.PrimaryScreen.Bounds.Height;
	}
}
