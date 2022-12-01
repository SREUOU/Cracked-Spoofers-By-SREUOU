using System;
using System.Windows.Forms;

namespace Spoof_fivem
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00008A62 File Offset: 0x00006C62
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new freedash());
		}
	}
}
