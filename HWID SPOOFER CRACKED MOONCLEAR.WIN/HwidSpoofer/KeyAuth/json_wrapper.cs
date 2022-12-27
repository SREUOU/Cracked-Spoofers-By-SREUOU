﻿using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x0200000D RID: 13
	public class json_wrapper
	{
		// Token: 0x06000061 RID: 97 RVA: 0x00008FB0 File Offset: 0x000071B0
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00008FD0 File Offset: 0x000071D0
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			bool flag = !json_wrapper.is_serializable(type);
			if (flag)
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00009028 File Offset: 0x00007228
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00009074 File Offset: 0x00007274
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000058 RID: 88
		private DataContractJsonSerializer serializer;

		// Token: 0x04000059 RID: 89
		private object current_object;
	}
}
