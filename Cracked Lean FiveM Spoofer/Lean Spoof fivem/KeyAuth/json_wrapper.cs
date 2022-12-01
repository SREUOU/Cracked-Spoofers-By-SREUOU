using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000004 RID: 4
	public class json_wrapper
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003AA0 File Offset: 0x00001CA0
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003AC0 File Offset: 0x00001CC0
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

		// Token: 0x06000025 RID: 37 RVA: 0x00003B18 File Offset: 0x00001D18
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

		// Token: 0x06000026 RID: 38 RVA: 0x00003B64 File Offset: 0x00001D64
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400000C RID: 12
		private DataContractJsonSerializer serializer;

		// Token: 0x0400000D RID: 13
		private object current_object;
	}
}
