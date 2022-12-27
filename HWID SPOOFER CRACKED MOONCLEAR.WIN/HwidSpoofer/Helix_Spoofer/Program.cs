using System;
using System.Windows.Forms;

namespace Helix_Spoofer
{
	// Token: 0x02000005 RID: 5
	internal static class Program
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00003D5E File Offset: 0x00001F5E
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
