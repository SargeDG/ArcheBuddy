using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A
{
	// Token: 0x02000012 RID: 18
	internal sealed class c18b57b77328324f24e8a135188b3a747
	{
		// Token: 0x06000064 RID: 100 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		static c18b57b77328324f24e8a135188b3a747()
		{
			if (c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc == null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_19_0 = methodof(c18b57b77328324f24e8a135188b3a747..cctor()).MethodHandle;
				}
				string text = "QXJjaGVCdWRkeSQ=";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc = cb3ca4465be1524a19d28180711379a86.c2752f94e7a118d91ea4022638efa05ca(97L, manifestResourceStream);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000FF78 File Offset: 0x0000E178
		internal static string ca2627375a3c55a847928012559959362(int num)
		{
			int num2;
			if ((c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num] & 128) == 0)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_23_0 = methodof(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(int)).MethodHandle;
				}
				num2 = (int)c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num];
				num++;
			}
			else if ((c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num] & 64) == 0)
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
				num2 = ((int)c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num] & -129) << 8;
				num2 |= (int)c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num + 1];
				num += 2;
			}
			else
			{
				num2 = ((int)c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num] & -193) << 24;
				num2 |= (int)c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num + 1] << 16;
				num2 |= (int)c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num + 2] << 8;
				num2 |= (int)c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc[num + 3];
				num += 4;
			}
			if (num2 < 1)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				return string.Empty;
			}
			string @string = Encoding.Unicode.GetString(c18b57b77328324f24e8a135188b3a747.cf6ccee63d7818e1c2f45e9413f0466fc, num, num2);
			return string.Intern(@string);
		}

		// Token: 0x0400002E RID: 46
		internal static readonly byte[] cf6ccee63d7818e1c2f45e9413f0466fc;
	}
}
