using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;

namespace Spoof_fivem
{
    // Cracked By SREUOU#4243 Easy:)
    // My GitHub:https://github.com/SREUOU
    // Token: 0x02000006 RID: 6
    public partial class freedash : Form
	{
		// Token: 0x06000030 RID: 48 RVA: 0x0000497F File Offset: 0x00002B7F
		public freedash()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004997 File Offset: 0x00002B97
		private void freedash_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000499C File Offset: 0x00002B9C
		private void guna2Button8_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID /f");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory /f");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S -1-5-21-1282084573-1681065996-3115981261-1001 /va /f");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView /f");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched /f");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView /f");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S-1-5-21-332004695-2829936588-140372829-1002 /f");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched /f");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S -1-5-21-1282084573-1681065996-3115981261-1001 /f");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched /f");
				streamWriter.WriteLine("del /y c:\\windows\\tempor~1");
				streamWriter.WriteLine("del /y c:\\windows\\temp");
				streamWriter.WriteLine("del /y c:\\windows\\tmp");
				streamWriter.WriteLine("del /y c:\\windows\\ff *.tmp");
				streamWriter.WriteLine("del /y c:\\windows\\history");
				streamWriter.WriteLine("del /y c:\\windows\\cookies");
				streamWriter.WriteLine("del /y c:\\windows\\recent");
				streamWriter.WriteLine("del /y c:\\windows\\spool\\printers");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			this.listBox1.ForeColor = Color.White;
			this.listBox1.Items.Add("[+] Clean Bypass");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004C44 File Offset: 0x00002E44
		private void guna2Button7_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("timeout 2 >nul");
				streamWriter.WriteLine("rmdir /s /q %userprofile%\\AppData\\Roaming\\CitizenFX");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			this.listBox1.Items.Add("[+] Clean Citizen FX");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004CD8 File Offset: 0x00002ED8
		private void guna2Button6_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("del /s /q /f %LocalAppData%\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("RENAME %userprofile%\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc Leanwoofer");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			this.listBox1.Items.Add("[+] Unlink Discord");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004D6C File Offset: 0x00002F6C
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("rmdir /s /q  %LocalAppData%\\DigitalEntitlements");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			this.listBox1.Items.Add("[+] Unlink Rockstar");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004DF4 File Offset: 0x00002FF4
		private void guna2Button9_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine(":folderclean");
				streamWriter.WriteLine("call :getDiscordVersion");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("goto :xboxclean");
				streamWriter.WriteLine(": getDiscordVersion");
				streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
				streamWriter.WriteLine("     set 'varLoc =%%a'");
				streamWriter.WriteLine("   goto :d1");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(":d1");
				streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
				streamWriter.WriteLine("     set 'discordVersion =%%z'");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(" cls");
				streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
				streamWriter.WriteLine("sc stop XblAuthManager");
				streamWriter.WriteLine("sc stop XblGameSave");
				streamWriter.WriteLine("sc stop XboxNetApiSvc");
				streamWriter.WriteLine("sc stop XboxGipSvc");
				streamWriter.WriteLine("sc delete XblAuthManager");
				streamWriter.WriteLine("sc delete XblGameSave");
				streamWriter.WriteLine("sc delete XboxNetApiSvc");
				streamWriter.WriteLine("sc delete XboxGipSvc");
				streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
				streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
				streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DigitalEntitlements");
				bool flag = Directory.Exists(path);
				if (flag)
				{
					Directory.Delete(path, true);
				}
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("taskkill /f /im Discord.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc leanwoofer");
				streamWriter.WriteLine("cls");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Unlinked and logout ALL!", "leanwoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.listBox1.Items.Add("[+] Unlinked all");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005130 File Offset: 0x00003330
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Discord.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S-1-5-21-332004695-2829936588-140372829-1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\D3d10.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d9.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d8.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.txt");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del /s /q %systemdrive%\\Windows\\Temp\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q % userprofile %\\AppData\\Local\\Temp\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del /s /q / f  %LocalAppData%\\FiveM\\FiveM.app\\citizen*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\citizen-game-ipc.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\conhost-v2.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CoreRT.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\extra-natives-five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\glue.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\mojo.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\net.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\net-base.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\nng.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\node.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\sticky.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\v8-9.3.345.16.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %127.0.0.1 xboxlive.com >> %hostspath%*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f 127.0.0.1 user.auth.xboxlive.com >> %hostspath%%*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc Leanwoofer ");
				streamWriter.WriteLine("cls");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("Spoofed global ban", "leanwoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.listBox1.Items.Add("[+] Spoof Global ban");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005954 File Offset: 0x00003B54
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc Leanwoofer");
				streamWriter.WriteLine("cls");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("poof Token ban", "leanwoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.listBox1.Items.Add("[+] Spoof Token ban");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005EF0 File Offset: 0x000040F0
		private void guna2Button4_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2372Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2372Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2372Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2372Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveMSteamBlock dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveMSteamBlock dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMSteamBlock dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMSteamBlock dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveMRockstarBlock dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("firewall add rule name=FiveMRockstarBlock dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMRockstarBlock dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMRockstarBlock dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2189Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2189Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2189Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2189Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2060Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2060_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2060Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2060_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2060Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2060Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2545Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2545_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2545Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2545_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2545Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2545Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM1604Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b1604_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM1604Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b1604_gtaprocess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM1604Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM1604Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2372Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2372_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2372Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2372Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2372Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveMSteamBlock dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveMSteamBlock dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMSteamBlock dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMSteamBlock dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveMRockstarBlock dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveMRockstarBlock dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMRockstarBlock dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMRockstarBlock dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2189Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2189Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2189Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2189Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2060Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2060_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2060Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2060_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2060Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2060Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2545Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2545_GTAProcess > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM2545Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2545_GTAProcess > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2545Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2545Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM1604Block dir=in action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b1604_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall add rule name=FiveM1604Block dir=out action=block profile=any program= % LocalAppData %\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b1604_GTAProcess.exe > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM1604Block dir=in new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM1604Block dir=out new enable=yes > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("ipconfig /flushdns");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir /y c:\\windows\\tempor~1 rmdir /y c:\\windows\\temp rmdir /y c:\\windows\\tmp rmdir /y c:\\windows\\ff*.tmp rmdir /y c:\\windows\\history rmdir /y c:\\windows\\cookies rmdir /y c:\\windows\\recent rmdir /y c:\\windows\\spool\\printers rmdir c:\\WIN386.SWP");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rd /s /q C:\\Windows\\SoftwareDistribution");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("BYPASS ON!");
			this.listBox1.Items.Add("[+] BYPASS ON!");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000064FC File Offset: 0x000046FC
		private void guna2Button5_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2372Block dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2372Block dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMSteamBlock dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMSteamBlock dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMRockstarBlock dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMRockstarBlock dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2189Block dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2189Block dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2060Block dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2060Block dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2545Block dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM2545Block dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM1604Block dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveM1604Block dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMROSServiceBlock dir=in new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMROSServiceBlock dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMChromeBrowser dir =in new enable= no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMChromeBrowser dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMROSLauncher dir =in new enable= no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("netsh advfirewall firewall set rule name=FiveMROSLauncher dir=out new enable=no > nul");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir C:\\Windows\\Temp\\ /s /f /q");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("C:\\Windows\\Prefetch\\ /s /f /q");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("ipconfig /flushdns");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir /y c:\\windows\\tempor~1 rmdir /y c:\\windows\\temp rmdir /y c:\\windows\\tmp rmdir /y c:\\windows\\ff*.tmp rmdir /y c:\\windows\\history rmdir /y c:\\windows\\cookies rmdir /y c:\\windows\\recent rmdir /y c:\\windows\\spool\\printers rmdir c:\\WIN386.SWP");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rd /s /q C:\\Windows\\SoftwareDistribution");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del *.log /a /s /q /f");
				streamWriter.WriteLine("cls");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("BYPASS OFF");
			this.listBox1.Items.Add("[+] BYPASS OFF!");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006814 File Offset: 0x00004A14
		public void SpoofGlobal()
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Discord.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S-1-5-21-332004695-2829936588-140372829-1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\D3d10.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d9.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d8.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.txt");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del /s /q %systemdrive%\\Windows\\Temp\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q % userprofile %\\AppData\\Local\\Temp\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del /s /q / f  %LocalAppData%\\FiveM\\FiveM.app\\citizen*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\citizen-game-ipc.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\conhost-v2.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CoreRT.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\extra-natives-five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\glue.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\mojo.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\net.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\net-base.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\nng.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\node.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\sticky.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\v8-9.3.345.16.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %127.0.0.1 xboxlive.com >> %hostspath%*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f 127.0.0.1 user.auth.xboxlive.com >> %hostspath%%*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc Leanwoofer ");
				streamWriter.WriteLine("cls");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00007010 File Offset: 0x00005210
		private void guna2Button10_Click(object sender, EventArgs e)
		{
			this.SpoofGlobal();
			MessageBox.Show("Spoofed All System", "leanwoofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.listBox1.Items.Add("[+] Spoof All System");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00007044 File Offset: 0x00005244
		private void siticoneImageButton1_Click(object sender, EventArgs e)
		{
			freedash freedash = new freedash();
			freedash.Show();
			base.Hide();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00007066 File Offset: 0x00005266
		private void siticoneCirclePictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/ycDg4UbSN7");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00007074 File Offset: 0x00005274
		private void siticoneImageButton2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
