using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A
{
	// Token: 0x02000010 RID: 16
	internal sealed class c4929ffb646fb9ba9deb5f553efe8c57b
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000F98C File Offset: 0x0000DB8C
		static c4929ffb646fb9ba9deb5f553efe8c57b()
		{
			if (c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc == null)
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_19_0 = methodof(c4929ffb646fb9ba9deb5f553efe8c57b..cctor()).MethodHandle;
				}
				string text = "QXJjaGVCdWRkeSU=";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc = cb3ca4465be1524a19d28180711379a86.c2752f94e7a118d91ea4022638efa05ca(97L, manifestResourceStream);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		internal static int c185d731bee241637ed623c74ebeedc15(int startIndex)
		{
			return BitConverter.ToInt32(c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc, startIndex);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000FA28 File Offset: 0x0000DC28
		internal static long cf689e68d6dd576cdef73b561dd78b9dd(int startIndex)
		{
			return BitConverter.ToInt64(c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc, startIndex);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000FA44 File Offset: 0x0000DC44
		internal static float cdf46f43e0afdf3dce063f22f1e47bb37(int startIndex)
		{
			return BitConverter.ToSingle(c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc, startIndex);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000FA60 File Offset: 0x0000DC60
		internal static double c4fafdd186626774c53f349c01980872a(int startIndex)
		{
			return BitConverter.ToDouble(c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc, startIndex);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		internal static void ce949ceea17f892b85c7d5a923178e119(Array dst, int num)
		{
			int num2;
			if ((c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num] & 128) == 0)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_23_0 = methodof(c4929ffb646fb9ba9deb5f553efe8c57b.ce949ceea17f892b85c7d5a923178e119(Array, int)).MethodHandle;
				}
				num2 = (int)c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num];
				num++;
			}
			else if ((c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num] & 64) == 0)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				num2 = ((int)c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num] & -129) << 8;
				num2 |= (int)c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num + 1];
				num += 2;
			}
			else
			{
				num2 = ((int)c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num] & -193) << 24;
				num2 |= (int)c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num + 1] << 16;
				num2 |= (int)c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num + 2] << 8;
				num2 |= (int)c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc[num + 3];
				num += 4;
			}
			if (num2 < 1)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				return;
			}
			Buffer.BlockCopy(c4929ffb646fb9ba9deb5f553efe8c57b.cf6ccee63d7818e1c2f45e9413f0466fc, num, dst, 0, num2);
		}

		// Token: 0x04000027 RID: 39
		internal static readonly byte[] cf6ccee63d7818e1c2f45e9413f0466fc;

		// Token: 0x04000028 RID: 40
		internal readonly int c0ba91563d7e6b49e54723de1b4ab42db;
	}
}
