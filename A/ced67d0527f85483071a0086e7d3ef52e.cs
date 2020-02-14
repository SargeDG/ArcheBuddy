using System;
using System.IO;
using System.Net;

namespace A
{
	// Token: 0x020000F7 RID: 247
	internal sealed class ced67d0527f85483071a0086e7d3ef52e : WebResponse
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x0004753C File Offset: 0x0004573C
		public ced67d0527f85483071a0086e7d3ef52e(string text)
		{
			this.c5fefcfe61914041d27e058e8daec4175(text);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00047558 File Offset: 0x00045758
		public override Stream GetResponseStream()
		{
			if (c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(this.get_c3cc5af604fe385861ac0b35bf9641a03()) != 0)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_23_0 = methodof(ced67d0527f85483071a0086e7d3ef52e.GetResponseStream()).MethodHandle;
				}
				return c83b68828ffed0499b11deecf4ddc11de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), this.get_c3cc5af604fe385861ac0b35bf9641a03()));
			}
			return Stream.Null;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000475AC File Offset: 0x000457AC
		public override void Close()
		{
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x000475BC File Offset: 0x000457BC
		public override WebHeaderCollection Headers
		{
			get
			{
				if (this.ccc225c9a0db9a6c59f52a016cdd4146d == null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(ced67d0527f85483071a0086e7d3ef52e.get_Headers()).MethodHandle;
					}
					this.ccc225c9a0db9a6c59f52a016cdd4146d = ce01da08198236357c6ed4557b453a44f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				return this.ccc225c9a0db9a6c59f52a016cdd4146d;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000475F8 File Offset: 0x000457F8
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00047618 File Offset: 0x00045818
		public override long ContentLength
		{
			get
			{
				return (long)c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(this.get_c3cc5af604fe385861ac0b35bf9641a03());
			}
			set
			{
				throw c40aee1e3fbf30a2fdaa1d385977194d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0004762C File Offset: 0x0004582C
		private void c5fefcfe61914041d27e058e8daec4175(string text)
		{
			int num = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149328));
			string text2 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15756), num);
			object arg_62_0 = text2;
			string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15760));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15764)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149337);
			string[] array2 = cc19ced84c86a267bd615bafbf2c5917a.c30767ddca1f9c207888833aea5b5fc61(arg_62_0, array, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15768));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15772); i < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15796))
			{
				object arg_A6_0 = array2[i];
				char[] array3 = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15776));
				array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15780)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15784);
				string[] array4 = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_A6_0, array3);
				cbbdfec5db2edb7c02eb0a20e5248fbf6.c30767ddca1f9c207888833aea5b5fc61(c1c242d1bee0107baba5957289ba1ccbf.c30767ddca1f9c207888833aea5b5fc61(this), array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15788)], array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15792)]);
			}
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
				RuntimeMethodHandle arg_101_0 = methodof(ced67d0527f85483071a0086e7d3ef52e.c5fefcfe61914041d27e058e8daec4175(string)).MethodHandle;
			}
			this.set_c3cc5af604fe385861ac0b35bf9641a03(cdea27b7a0e0cc37081ac21c078bcf552.c30767ddca1f9c207888833aea5b5fc61(text, num + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15800)));
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00047758 File Offset: 0x00045958
		private string get_c3cc5af604fe385861ac0b35bf9641a03()
		{
			string arg_22_0;
			if ((arg_22_0 = this.ccfd5b726b4db8b16a00ec34e808948f8) == null)
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
					RuntimeMethodHandle arg_1B_0 = methodof(ced67d0527f85483071a0086e7d3ef52e.get_c3cc5af604fe385861ac0b35bf9641a03()).MethodHandle;
				}
				arg_22_0 = string.Empty;
			}
			return arg_22_0;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00047788 File Offset: 0x00045988
		private void set_c3cc5af604fe385861ac0b35bf9641a03(string text)
		{
			this.ccfd5b726b4db8b16a00ec34e808948f8 = text;
		}

		// Token: 0x0400045F RID: 1119
		private WebHeaderCollection ccc225c9a0db9a6c59f52a016cdd4146d;

		// Token: 0x04000460 RID: 1120
		private string ccfd5b726b4db8b16a00ec34e808948f8;
	}
}
