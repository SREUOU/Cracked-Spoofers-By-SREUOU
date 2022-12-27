using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace KeyAuth
{
	// Token: 0x0200000B RID: 11
	public class api
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00007560 File Offset: 0x00005760
		public api(string name, string ownerid, string secret, string version)
		{
			bool flag = string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version);
			if (flag)
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00007600 File Offset: 0x00005800
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			bool flag = text2 == "KeyAuth_Invalid";
			if (flag)
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_app_data(response_structure.appinfo);
				this.sessionid = response_structure.sessionid;
				this.initzalized = true;
			}
			else
			{
				bool flag2 = response_structure.message == "invalidver";
				if (flag2)
				{
					this.app_data.downloadLink = response_structure.download;
				}
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000077A4 File Offset: 0x000059A4
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000077B8 File Offset: 0x000059B8
		public void Checkinit()
		{
			bool flag = !this.initzalized;
			if (flag)
			{
				bool isDebugRelease = api.IsDebugRelease;
				if (isDebugRelease)
				{
					api.error("Not initialized Check if KeyAuthApp.init() does exist");
				}
				else
				{
					api.error("Please initialize first");
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000077FC File Offset: 0x000059FC
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007970 File Offset: 0x00005B70
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007AC8 File Offset: 0x00005CC8
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.load_response_struct(response_structure);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007BF8 File Offset: 0x00005DF8
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			if (success)
			{
				this.load_user_data(response_structure.info);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007D38 File Offset: 0x00005F38
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007E18 File Offset: 0x00006018
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data2 = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00007F2C File Offset: 0x0000612C
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00008044 File Offset: 0x00006244
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure data = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(data);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00008124 File Offset: 0x00006324
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008250 File Offset: 0x00006450
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			List<api.msg> result;
			if (success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008368 File Offset: 0x00006568
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00008494 File Offset: 0x00006694
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			return response_structure.success;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000085B8 File Offset: 0x000067B8
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.enckey, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			string result;
			if (success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000871C File Offset: 0x0000691C
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			string text2 = api.req(post_data);
			text2 = encryption.decrypt(text2, this.enckey, text);
			api.response_structure response_structure = this.response_decoder.string_to_generic<api.response_structure>(text2);
			this.load_response_struct(response_structure);
			bool success = response_structure.success;
			byte[] result;
			if (success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00008838 File Offset: 0x00006A38
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection post_data = nameValueCollection;
			api.req(post_data);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000892C File Offset: 0x00006B2C
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000089AC File Offset: 0x00006BAC
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008A04 File Offset: 0x00006C04
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					Thread.Sleep(1000);
					result = api.req(post_data);
				}
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00008AB4 File Offset: 0x00006CB4
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008B1C File Offset: 0x00006D1C
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00008B98 File Offset: 0x00006D98
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008C30 File Offset: 0x00006E30
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x0400004D RID: 77
		public string name;

		// Token: 0x0400004E RID: 78
		public string ownerid;

		// Token: 0x0400004F RID: 79
		public string secret;

		// Token: 0x04000050 RID: 80
		public string version;

		// Token: 0x04000051 RID: 81
		private string sessionid;

		// Token: 0x04000052 RID: 82
		private string enckey;

		// Token: 0x04000053 RID: 83
		private bool initzalized;

		// Token: 0x04000054 RID: 84
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000055 RID: 85
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x04000056 RID: 86
		public api.response_class response = new api.response_class();

		// Token: 0x04000057 RID: 87
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000012 RID: 18
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00009C8E File Offset: 0x00007E8E
			// (set) Token: 0x0600008C RID: 140 RVA: 0x00009C96 File Offset: 0x00007E96
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00009C9F File Offset: 0x00007E9F
			// (set) Token: 0x0600008E RID: 142 RVA: 0x00009CA7 File Offset: 0x00007EA7
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00009CB0 File Offset: 0x00007EB0
			// (set) Token: 0x06000090 RID: 144 RVA: 0x00009CB8 File Offset: 0x00007EB8
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000091 RID: 145 RVA: 0x00009CC1 File Offset: 0x00007EC1
			// (set) Token: 0x06000092 RID: 146 RVA: 0x00009CC9 File Offset: 0x00007EC9
			[DataMember]
			public string response { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000093 RID: 147 RVA: 0x00009CD2 File Offset: 0x00007ED2
			// (set) Token: 0x06000094 RID: 148 RVA: 0x00009CDA File Offset: 0x00007EDA
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000095 RID: 149 RVA: 0x00009CE3 File Offset: 0x00007EE3
			// (set) Token: 0x06000096 RID: 150 RVA: 0x00009CEB File Offset: 0x00007EEB
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000097 RID: 151 RVA: 0x00009CF4 File Offset: 0x00007EF4
			// (set) Token: 0x06000098 RID: 152 RVA: 0x00009CFC File Offset: 0x00007EFC
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000099 RID: 153 RVA: 0x00009D05 File Offset: 0x00007F05
			// (set) Token: 0x0600009A RID: 154 RVA: 0x00009D0D File Offset: 0x00007F0D
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600009B RID: 155 RVA: 0x00009D16 File Offset: 0x00007F16
			// (set) Token: 0x0600009C RID: 156 RVA: 0x00009D1E File Offset: 0x00007F1E
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000013 RID: 19
		public class msg
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00009D30 File Offset: 0x00007F30
			// (set) Token: 0x0600009F RID: 159 RVA: 0x00009D38 File Offset: 0x00007F38
			public string message { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00009D41 File Offset: 0x00007F41
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x00009D49 File Offset: 0x00007F49
			public string author { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00009D52 File Offset: 0x00007F52
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x00009D5A File Offset: 0x00007F5A
			public string timestamp { get; set; }
		}

		// Token: 0x02000014 RID: 20
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00009D6C File Offset: 0x00007F6C
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x00009D74 File Offset: 0x00007F74
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x00009D7D File Offset: 0x00007F7D
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x00009D85 File Offset: 0x00007F85
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x00009D8E File Offset: 0x00007F8E
			// (set) Token: 0x060000AA RID: 170 RVA: 0x00009D96 File Offset: 0x00007F96
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000AB RID: 171 RVA: 0x00009D9F File Offset: 0x00007F9F
			// (set) Token: 0x060000AC RID: 172 RVA: 0x00009DA7 File Offset: 0x00007FA7
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060000AD RID: 173 RVA: 0x00009DB0 File Offset: 0x00007FB0
			// (set) Token: 0x060000AE RID: 174 RVA: 0x00009DB8 File Offset: 0x00007FB8
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060000AF RID: 175 RVA: 0x00009DC1 File Offset: 0x00007FC1
			// (set) Token: 0x060000B0 RID: 176 RVA: 0x00009DC9 File Offset: 0x00007FC9
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000015 RID: 21
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00009DDB File Offset: 0x00007FDB
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x00009DE3 File Offset: 0x00007FE3
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00009DEC File Offset: 0x00007FEC
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x00009DF4 File Offset: 0x00007FF4
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060000B6 RID: 182 RVA: 0x00009DFD File Offset: 0x00007FFD
			// (set) Token: 0x060000B7 RID: 183 RVA: 0x00009E05 File Offset: 0x00008005
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009E0E File Offset: 0x0000800E
			// (set) Token: 0x060000B9 RID: 185 RVA: 0x00009E16 File Offset: 0x00008016
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000BA RID: 186 RVA: 0x00009E1F File Offset: 0x0000801F
			// (set) Token: 0x060000BB RID: 187 RVA: 0x00009E27 File Offset: 0x00008027
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00009E30 File Offset: 0x00008030
			// (set) Token: 0x060000BD RID: 189 RVA: 0x00009E38 File Offset: 0x00008038
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x02000016 RID: 22
		public class app_data_class
		{
			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000BF RID: 191 RVA: 0x00009E4A File Offset: 0x0000804A
			// (set) Token: 0x060000C0 RID: 192 RVA: 0x00009E52 File Offset: 0x00008052
			public string numUsers { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x00009E5B File Offset: 0x0000805B
			// (set) Token: 0x060000C2 RID: 194 RVA: 0x00009E63 File Offset: 0x00008063
			public string numOnlineUsers { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x00009E6C File Offset: 0x0000806C
			// (set) Token: 0x060000C4 RID: 196 RVA: 0x00009E74 File Offset: 0x00008074
			public string numKeys { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000C5 RID: 197 RVA: 0x00009E7D File Offset: 0x0000807D
			// (set) Token: 0x060000C6 RID: 198 RVA: 0x00009E85 File Offset: 0x00008085
			public string version { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x00009E8E File Offset: 0x0000808E
			// (set) Token: 0x060000C8 RID: 200 RVA: 0x00009E96 File Offset: 0x00008096
			public string customerPanelLink { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000C9 RID: 201 RVA: 0x00009E9F File Offset: 0x0000809F
			// (set) Token: 0x060000CA RID: 202 RVA: 0x00009EA7 File Offset: 0x000080A7
			public string downloadLink { get; set; }
		}

		// Token: 0x02000017 RID: 23
		public class user_data_class
		{
			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00009EB9 File Offset: 0x000080B9
			// (set) Token: 0x060000CD RID: 205 RVA: 0x00009EC1 File Offset: 0x000080C1
			public string username { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000CE RID: 206 RVA: 0x00009ECA File Offset: 0x000080CA
			// (set) Token: 0x060000CF RID: 207 RVA: 0x00009ED2 File Offset: 0x000080D2
			public string ip { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x00009EDB File Offset: 0x000080DB
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x00009EE3 File Offset: 0x000080E3
			public string hwid { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x00009EEC File Offset: 0x000080EC
			// (set) Token: 0x060000D3 RID: 211 RVA: 0x00009EF4 File Offset: 0x000080F4
			public string createdate { get; set; }

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x00009EFD File Offset: 0x000080FD
			// (set) Token: 0x060000D5 RID: 213 RVA: 0x00009F05 File Offset: 0x00008105
			public string lastlogin { get; set; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x00009F0E File Offset: 0x0000810E
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x00009F16 File Offset: 0x00008116
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000018 RID: 24
		public class Data
		{
			// Token: 0x1700003C RID: 60
			// (get) Token: 0x060000D9 RID: 217 RVA: 0x00009F28 File Offset: 0x00008128
			// (set) Token: 0x060000DA RID: 218 RVA: 0x00009F30 File Offset: 0x00008130
			public string subscription { get; set; }

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x060000DB RID: 219 RVA: 0x00009F39 File Offset: 0x00008139
			// (set) Token: 0x060000DC RID: 220 RVA: 0x00009F41 File Offset: 0x00008141
			public string expiry { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000DD RID: 221 RVA: 0x00009F4A File Offset: 0x0000814A
			// (set) Token: 0x060000DE RID: 222 RVA: 0x00009F52 File Offset: 0x00008152
			public string timeleft { get; set; }
		}

		// Token: 0x02000019 RID: 25
		public class response_class
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00009F64 File Offset: 0x00008164
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x00009F6C File Offset: 0x0000816C
			public bool success { get; set; }

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00009F75 File Offset: 0x00008175
			// (set) Token: 0x060000E3 RID: 227 RVA: 0x00009F7D File Offset: 0x0000817D
			public string message { get; set; }
		}
	}
}
