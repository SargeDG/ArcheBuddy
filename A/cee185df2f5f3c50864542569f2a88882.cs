using System;
using System.IO;
using System.Security.Cryptography;

namespace A
{
	// Token: 0x020000EA RID: 234
	internal sealed class cee185df2f5f3c50864542569f2a88882 : HashAlgorithm
	{
		// Token: 0x060007FD RID: 2045 RVA: 0x00045C64 File Offset: 0x00043E64
		public cee185df2f5f3c50864542569f2a88882()
		{
			this.cd7bdaa236a9b93ab33cd64f58848594e = cee185df2f5f3c50864542569f2a88882.c1f4d9da5184e1ec383f275a77b1bc173((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15400));
			this.c5bdc1aea506f1efad1f829403048e239 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15404);
			ccca501ec9d1a2818f4fb587c956e1b4f.c30767ddca1f9c207888833aea5b5fc61(this);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00045CA4 File Offset: 0x00043EA4
		public cee185df2f5f3c50864542569f2a88882(uint num, uint num2)
		{
			this.cd7bdaa236a9b93ab33cd64f58848594e = cee185df2f5f3c50864542569f2a88882.c1f4d9da5184e1ec383f275a77b1bc173(num);
			this.c5bdc1aea506f1efad1f829403048e239 = num2;
			ccca501ec9d1a2818f4fb587c956e1b4f.c30767ddca1f9c207888833aea5b5fc61(this);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00045CD4 File Offset: 0x00043ED4
		public override void Initialize()
		{
			this.c86b174cf7d9ad07093c9d044a3c41dc8 = this.c5bdc1aea506f1efad1f829403048e239;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00045CF0 File Offset: 0x00043EF0
		protected override void HashCore(byte[] buffer, int start, int length)
		{
			this.c86b174cf7d9ad07093c9d044a3c41dc8 = cee185df2f5f3c50864542569f2a88882.c471968a9c7cd7de33773d350a3114aeb(this.cd7bdaa236a9b93ab33cd64f58848594e, this.c86b174cf7d9ad07093c9d044a3c41dc8, buffer, start, length);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00045D1C File Offset: 0x00043F1C
		protected override byte[] HashFinal()
		{
			byte[] array = this.c50e13512c3539a489ca924c0a41b0f17(~this.c86b174cf7d9ad07093c9d044a3c41dc8);
			this.HashValue = array;
			return array;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00045D44 File Offset: 0x00043F44
		public override int get_HashSize()
		{
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15236);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00045D5C File Offset: 0x00043F5C
		public static uint c40889dbd61ec820653d54c738782eca5(byte[] array)
		{
			return ~cee185df2f5f3c50864542569f2a88882.c471968a9c7cd7de33773d350a3114aeb(cee185df2f5f3c50864542569f2a88882.c1f4d9da5184e1ec383f275a77b1bc173((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15240)), (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15244), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15248), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00045DA0 File Offset: 0x00043FA0
		public static uint c40889dbd61ec820653d54c738782eca5(uint num, byte[] array)
		{
			return ~cee185df2f5f3c50864542569f2a88882.c471968a9c7cd7de33773d350a3114aeb(cee185df2f5f3c50864542569f2a88882.c1f4d9da5184e1ec383f275a77b1bc173((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15252)), num, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15256), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00045DDC File Offset: 0x00043FDC
		public static uint c40889dbd61ec820653d54c738782eca5(uint num, uint num2, byte[] array)
		{
			return ~cee185df2f5f3c50864542569f2a88882.c471968a9c7cd7de33773d350a3114aeb(cee185df2f5f3c50864542569f2a88882.c1f4d9da5184e1ec383f275a77b1bc173(num), num2, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15260), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00045E10 File Offset: 0x00044010
		private static uint[] c1f4d9da5184e1ec383f275a77b1bc173(uint num)
		{
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15264))
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
					RuntimeMethodHandle arg_1F_0 = methodof(cee185df2f5f3c50864542569f2a88882.c1f4d9da5184e1ec383f275a77b1bc173(uint)).MethodHandle;
				}
				if (cee185df2f5f3c50864542569f2a88882.cb10e7fcc56d2ccc601d76fead12935ef != null)
				{
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					return cee185df2f5f3c50864542569f2a88882.cb10e7fcc56d2ccc601d76fead12935ef;
				}
			}
			uint[] array = cabad7e3df3841c97f7c5aa47c5c3c2a1.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15268));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15272); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15308); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15304))
			{
				uint num2 = (uint)i;
				for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15276); j < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15300); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15296))
				{
					if ((num2 & (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15280)) == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15284))
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
						num2 = (num2 >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15288) ^ num);
					}
					else
					{
						num2 >>= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15292);
					}
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				array[i] = num2;
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15312))
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
				cee185df2f5f3c50864542569f2a88882.cb10e7fcc56d2ccc601d76fead12935ef = array;
			}
			return array;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00045F34 File Offset: 0x00044134
		private static uint c471968a9c7cd7de33773d350a3114aeb(uint[] array, uint num, byte[] array2, int num2, int num3)
		{
			uint num4 = num;
			for (int i = num2; i < num3; i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15324))
			{
				num4 = (num4 >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15316) ^ array[(int)((UIntPtr)((uint)array2[i] ^ (num4 & (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15320))))]);
			}
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
				RuntimeMethodHandle arg_4B_0 = methodof(cee185df2f5f3c50864542569f2a88882.c471968a9c7cd7de33773d350a3114aeb(uint[], uint, byte[], int, int)).MethodHandle;
			}
			return num4;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00045F90 File Offset: 0x00044190
		private byte[] c50e13512c3539a489ca924c0a41b0f17(uint num)
		{
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15328));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15332)] = (byte)(num >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15336) & (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15340));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15344)] = (byte)(num >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15348) & (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15352));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15356)] = (byte)(num >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15360) & (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15364));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15368)] = (byte)(num & (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15372));
			return array;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00046038 File Offset: 0x00044238
		public uint c032cd36437328437887c0ca354f72f86(string text)
		{
			uint result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15376);
			try
			{
				FileStream fileStream = c4213b184f42f2ab9b15020e5a1f14340.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, (FileMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15380), (FileAccess)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15384), (FileShare)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15388));
				try
				{
					byte[] array = c46fa720deb5b9905521c69dda550a429.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, fileStream);
					cd66607b3b69537cf76497e7b46afc8e2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15392), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
					result = c961357f9cc9cb93480ce6f84616b4622.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15396));
				}
				finally
				{
					if (fileStream != null)
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
							RuntimeMethodHandle arg_7F_0 = methodof(cee185df2f5f3c50864542569f2a88882.c032cd36437328437887c0ca354f72f86(string)).MethodHandle;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(fileStream);
					}
				}
			}
			catch
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148964), text));
				cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149003), text));
			}
			return result;
		}

		// Token: 0x0400043B RID: 1083
		public static uint c4eb77ace09b96073d5e6e6091de26f5d;

		// Token: 0x0400043C RID: 1084
		public static uint cbb4896f9b1d39dddcb0a1ae9ace49284;

		// Token: 0x0400043D RID: 1085
		private uint c86b174cf7d9ad07093c9d044a3c41dc8;

		// Token: 0x0400043E RID: 1086
		private uint c5bdc1aea506f1efad1f829403048e239;

		// Token: 0x0400043F RID: 1087
		private uint[] cd7bdaa236a9b93ab33cd64f58848594e;

		// Token: 0x04000440 RID: 1088
		private static uint[] cb10e7fcc56d2ccc601d76fead12935ef;
	}
}
