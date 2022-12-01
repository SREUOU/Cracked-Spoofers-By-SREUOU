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
	// Token: 0x02000002 RID: 2
	public class api
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x06000002 RID: 2 RVA: 0x000020F0 File Offset: 0x000002F0
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
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002294 File Offset: 0x00000494
		public static bool IsDebugRelease
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000022A8 File Offset: 0x000004A8
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

		// Token: 0x06000005 RID: 5 RVA: 0x000022EC File Offset: 0x000004EC
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

		// Token: 0x06000006 RID: 6 RVA: 0x00002460 File Offset: 0x00000660
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

		// Token: 0x06000007 RID: 7 RVA: 0x000025B8 File Offset: 0x000007B8
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

		// Token: 0x06000008 RID: 8 RVA: 0x000026E8 File Offset: 0x000008E8
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

		// Token: 0x06000009 RID: 9 RVA: 0x00002828 File Offset: 0x00000A28
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

		// Token: 0x0600000A RID: 10 RVA: 0x00002908 File Offset: 0x00000B08
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

		// Token: 0x0600000B RID: 11 RVA: 0x00002A1C File Offset: 0x00000C1C
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

		// Token: 0x0600000C RID: 12 RVA: 0x00002B34 File Offset: 0x00000D34
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

		// Token: 0x0600000D RID: 13 RVA: 0x00002C14 File Offset: 0x00000E14
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

		// Token: 0x0600000E RID: 14 RVA: 0x00002D40 File Offset: 0x00000F40
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

		// Token: 0x0600000F RID: 15 RVA: 0x00002E58 File Offset: 0x00001058
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

		// Token: 0x06000010 RID: 16 RVA: 0x00002F84 File Offset: 0x00001184
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

		// Token: 0x06000011 RID: 17 RVA: 0x000030A8 File Offset: 0x000012A8
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

		// Token: 0x06000012 RID: 18 RVA: 0x0000320C File Offset: 0x0000140C
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

		// Token: 0x06000013 RID: 19 RVA: 0x00003328 File Offset: 0x00001528
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

		// Token: 0x06000014 RID: 20 RVA: 0x0000341C File Offset: 0x0000161C
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

		// Token: 0x06000015 RID: 21 RVA: 0x0000349C File Offset: 0x0000169C
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

		// Token: 0x06000016 RID: 22 RVA: 0x000034F4 File Offset: 0x000016F4
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

		// Token: 0x06000017 RID: 23 RVA: 0x000035A4 File Offset: 0x000017A4
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000360C File Offset: 0x0000180C
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003688 File Offset: 0x00001888
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			d = d.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003720 File Offset: 0x00001920
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000001 RID: 1
		public string name;

		// Token: 0x04000002 RID: 2
		public string ownerid;

		// Token: 0x04000003 RID: 3
		public string secret;

		// Token: 0x04000004 RID: 4
		public string version;

		// Token: 0x04000005 RID: 5
		private string sessionid;

		// Token: 0x04000006 RID: 6
		private string enckey;

		// Token: 0x04000007 RID: 7
		private bool initzalized;

		// Token: 0x04000008 RID: 8
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x04000009 RID: 9
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400000A RID: 10
		public api.response_class response = new api.response_class();

		// Token: 0x0400000B RID: 11
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x0200000A RID: 10
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600004A RID: 74 RVA: 0x00008B26 File Offset: 0x00006D26
			// (set) Token: 0x0600004B RID: 75 RVA: 0x00008B2E File Offset: 0x00006D2E
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600004C RID: 76 RVA: 0x00008B37 File Offset: 0x00006D37
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00008B3F File Offset: 0x00006D3F
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00008B48 File Offset: 0x00006D48
			// (set) Token: 0x0600004F RID: 79 RVA: 0x00008B50 File Offset: 0x00006D50
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000050 RID: 80 RVA: 0x00008B59 File Offset: 0x00006D59
			// (set) Token: 0x06000051 RID: 81 RVA: 0x00008B61 File Offset: 0x00006D61
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000052 RID: 82 RVA: 0x00008B6A File Offset: 0x00006D6A
			// (set) Token: 0x06000053 RID: 83 RVA: 0x00008B72 File Offset: 0x00006D72
			[DataMember]
			public string message { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000054 RID: 84 RVA: 0x00008B7B File Offset: 0x00006D7B
			// (set) Token: 0x06000055 RID: 85 RVA: 0x00008B83 File Offset: 0x00006D83
			[DataMember]
			public string download { get; set; }

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000056 RID: 86 RVA: 0x00008B8C File Offset: 0x00006D8C
			// (set) Token: 0x06000057 RID: 87 RVA: 0x00008B94 File Offset: 0x00006D94
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000058 RID: 88 RVA: 0x00008B9D File Offset: 0x00006D9D
			// (set) Token: 0x06000059 RID: 89 RVA: 0x00008BA5 File Offset: 0x00006DA5
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600005A RID: 90 RVA: 0x00008BAE File Offset: 0x00006DAE
			// (set) Token: 0x0600005B RID: 91 RVA: 0x00008BB6 File Offset: 0x00006DB6
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class msg
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600005D RID: 93 RVA: 0x00008BC8 File Offset: 0x00006DC8
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00008BD0 File Offset: 0x00006DD0
			public string message { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600005F RID: 95 RVA: 0x00008BD9 File Offset: 0x00006DD9
			// (set) Token: 0x06000060 RID: 96 RVA: 0x00008BE1 File Offset: 0x00006DE1
			public string author { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00008BEA File Offset: 0x00006DEA
			// (set) Token: 0x06000062 RID: 98 RVA: 0x00008BF2 File Offset: 0x00006DF2
			public string timestamp { get; set; }
		}

		// Token: 0x0200000C RID: 12
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00008C04 File Offset: 0x00006E04
			// (set) Token: 0x06000065 RID: 101 RVA: 0x00008C0C File Offset: 0x00006E0C
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00008C15 File Offset: 0x00006E15
			// (set) Token: 0x06000067 RID: 103 RVA: 0x00008C1D File Offset: 0x00006E1D
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00008C26 File Offset: 0x00006E26
			// (set) Token: 0x06000069 RID: 105 RVA: 0x00008C2E File Offset: 0x00006E2E
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600006A RID: 106 RVA: 0x00008C37 File Offset: 0x00006E37
			// (set) Token: 0x0600006B RID: 107 RVA: 0x00008C3F File Offset: 0x00006E3F
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00008C48 File Offset: 0x00006E48
			// (set) Token: 0x0600006D RID: 109 RVA: 0x00008C50 File Offset: 0x00006E50
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00008C59 File Offset: 0x00006E59
			// (set) Token: 0x0600006F RID: 111 RVA: 0x00008C61 File Offset: 0x00006E61
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000D RID: 13
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000071 RID: 113 RVA: 0x00008C73 File Offset: 0x00006E73
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00008C7B File Offset: 0x00006E7B
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000073 RID: 115 RVA: 0x00008C84 File Offset: 0x00006E84
			// (set) Token: 0x06000074 RID: 116 RVA: 0x00008C8C File Offset: 0x00006E8C
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00008C95 File Offset: 0x00006E95
			// (set) Token: 0x06000076 RID: 118 RVA: 0x00008C9D File Offset: 0x00006E9D
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000077 RID: 119 RVA: 0x00008CA6 File Offset: 0x00006EA6
			// (set) Token: 0x06000078 RID: 120 RVA: 0x00008CAE File Offset: 0x00006EAE
			[DataMember]
			public string version { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000079 RID: 121 RVA: 0x00008CB7 File Offset: 0x00006EB7
			// (set) Token: 0x0600007A RID: 122 RVA: 0x00008CBF File Offset: 0x00006EBF
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600007B RID: 123 RVA: 0x00008CC8 File Offset: 0x00006EC8
			// (set) Token: 0x0600007C RID: 124 RVA: 0x00008CD0 File Offset: 0x00006ED0
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000E RID: 14
		public class app_data_class
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00008CE2 File Offset: 0x00006EE2
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00008CEA File Offset: 0x00006EEA
			public string numUsers { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00008CF3 File Offset: 0x00006EF3
			// (set) Token: 0x06000081 RID: 129 RVA: 0x00008CFB File Offset: 0x00006EFB
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000082 RID: 130 RVA: 0x00008D04 File Offset: 0x00006F04
			// (set) Token: 0x06000083 RID: 131 RVA: 0x00008D0C File Offset: 0x00006F0C
			public string numKeys { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00008D15 File Offset: 0x00006F15
			// (set) Token: 0x06000085 RID: 133 RVA: 0x00008D1D File Offset: 0x00006F1D
			public string version { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000086 RID: 134 RVA: 0x00008D26 File Offset: 0x00006F26
			// (set) Token: 0x06000087 RID: 135 RVA: 0x00008D2E File Offset: 0x00006F2E
			public string customerPanelLink { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00008D37 File Offset: 0x00006F37
			// (set) Token: 0x06000089 RID: 137 RVA: 0x00008D3F File Offset: 0x00006F3F
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000F RID: 15
		public class user_data_class
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00008D51 File Offset: 0x00006F51
			// (set) Token: 0x0600008C RID: 140 RVA: 0x00008D59 File Offset: 0x00006F59
			public string username { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00008D62 File Offset: 0x00006F62
			// (set) Token: 0x0600008E RID: 142 RVA: 0x00008D6A File Offset: 0x00006F6A
			public string ip { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00008D73 File Offset: 0x00006F73
			// (set) Token: 0x06000090 RID: 144 RVA: 0x00008D7B File Offset: 0x00006F7B
			public string hwid { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000091 RID: 145 RVA: 0x00008D84 File Offset: 0x00006F84
			// (set) Token: 0x06000092 RID: 146 RVA: 0x00008D8C File Offset: 0x00006F8C
			public string createdate { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000093 RID: 147 RVA: 0x00008D95 File Offset: 0x00006F95
			// (set) Token: 0x06000094 RID: 148 RVA: 0x00008D9D File Offset: 0x00006F9D
			public string lastlogin { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000095 RID: 149 RVA: 0x00008DA6 File Offset: 0x00006FA6
			// (set) Token: 0x06000096 RID: 150 RVA: 0x00008DAE File Offset: 0x00006FAE
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x02000010 RID: 16
		public class Data
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000098 RID: 152 RVA: 0x00008DC0 File Offset: 0x00006FC0
			// (set) Token: 0x06000099 RID: 153 RVA: 0x00008DC8 File Offset: 0x00006FC8
			public string subscription { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600009A RID: 154 RVA: 0x00008DD1 File Offset: 0x00006FD1
			// (set) Token: 0x0600009B RID: 155 RVA: 0x00008DD9 File Offset: 0x00006FD9
			public string expiry { get; set; }

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00008DE2 File Offset: 0x00006FE2
			// (set) Token: 0x0600009D RID: 157 RVA: 0x00008DEA File Offset: 0x00006FEA
			public string timeleft { get; set; }
		}

		// Token: 0x02000011 RID: 17
		public class response_class
		{
			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600009F RID: 159 RVA: 0x00008DFC File Offset: 0x00006FFC
			// (set) Token: 0x060000A0 RID: 160 RVA: 0x00008E04 File Offset: 0x00007004
			public bool success { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x00008E0D File Offset: 0x0000700D
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00008E15 File Offset: 0x00007015
			public string message { get; set; }
		}
	}
}
