using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace HwidSpoofer.Properties
{
	// Token: 0x02000011 RID: 17
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00009C58 File Offset: 0x00007E58
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000064 RID: 100
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
