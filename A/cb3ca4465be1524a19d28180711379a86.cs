using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace A
{
	// Token: 0x02000016 RID: 22
	internal sealed class cb3ca4465be1524a19d28180711379a86
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00010A90 File Offset: 0x0000EC90
		private static string c14327673310ab548c2f3a4844cac492b(Assembly assembly)
		{
			string text = cd9f22ffc68dc829b44502ae8f2d5af52.c30767ddca1f9c207888833aea5b5fc61(assembly);
			int num = ce070b78455c079dcb7aeee34519da889.c30767ddca1f9c207888833aea5b5fc61(text, ',');
			if (num >= 0)
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
					RuntimeMethodHandle arg_2A_0 = methodof(cb3ca4465be1524a19d28180711379a86.c14327673310ab548c2f3a4844cac492b(Assembly)).MethodHandle;
				}
				text = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, 0, num);
			}
			return text;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		private static byte[] c54b83c31b4ba6c424011dbeae3bf2579(Assembly assembly)
		{
			try
			{
				string text = cd9f22ffc68dc829b44502ae8f2d5af52.c30767ddca1f9c207888833aea5b5fc61(assembly);
				int num = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, "PublicKeyToken=");
				if (num < 0)
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
						RuntimeMethodHandle arg_2D_0 = methodof(cb3ca4465be1524a19d28180711379a86.c54b83c31b4ba6c424011dbeae3bf2579(Assembly)).MethodHandle;
					}
					num = cd5795dcce0f09f98c1a01bf8b9bf6a2d.c30767ddca1f9c207888833aea5b5fc61(text, "publickeytoken=");
				}
				byte[] result;
				if (num < 0)
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
					result = c7d19159535b8ba95efe224e27f4d871a.c8a754f5f2ca4adde825691a9c31a0e83;
					return result;
				}
				num += 15;
				if (c23ddf164d9a749977276969d2ff00afa.c30767ddca1f9c207888833aea5b5fc61(text, num) != 'n')
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
					if (c23ddf164d9a749977276969d2ff00afa.c30767ddca1f9c207888833aea5b5fc61(text, num) != 'N')
					{
						string text2 = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, num, 16);
						long num2 = c8dd4d7b0fcbcbfbc7ce6f4e418512b7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text2, NumberStyles.HexNumber);
						byte[] array = c6f443db75f880bf749031aa549897119.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2);
						c8d3130b0ba7026350cc1cdcdf4513913.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
						result = array;
						return result;
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
				}
				result = c7d19159535b8ba95efe224e27f4d871a.c8a754f5f2ca4adde825691a9c31a0e83;
				return result;
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00010BBC File Offset: 0x0000EDBC
		internal static byte[] c87a33ceab45f278bdf33dbf10a5bcd52(Stream stream)
		{
			object obj;
			cebe18f2b82a3f331aeb9a653b770bd94.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj = cb3ca4465be1524a19d28180711379a86.c939fc80af0af3a9ad3e79430a5846e8c);
			byte[] result;
			try
			{
				result = cb3ca4465be1524a19d28180711379a86.cb517f5d98e85d20f1d3d8b2631995961(97L, stream);
			}
			finally
			{
				c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00010BFC File Offset: 0x0000EDFC
		internal static byte[] c2752f94e7a118d91ea4022638efa05ca(long num, Stream stream)
		{
			byte[] result;
			try
			{
				result = cb3ca4465be1524a19d28180711379a86.c87a33ceab45f278bdf33dbf10a5bcd52(stream);
			}
			catch (HostProtectionException)
			{
				result = cb3ca4465be1524a19d28180711379a86.cb517f5d98e85d20f1d3d8b2631995961(97L, stream);
			}
			return result;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00010C34 File Offset: 0x0000EE34
		internal static byte[] cb517f5d98e85d20f1d3d8b2631995961(long num, Stream stream)
		{
			Stream stream2 = stream;
			MemoryStream c8a754f5f2ca4adde825691a9c31a0e = c2bbb2f6ea2089c9a6c6867e4b8998911.c8a754f5f2ca4adde825691a9c31a0e83;
			for (int i = 1; i < 4; i++)
			{
				cae578f6e2ca1767c0a670ffe731ad893.c30767ddca1f9c207888833aea5b5fc61(stream);
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
				RuntimeMethodHandle arg_2F_0 = methodof(cb3ca4465be1524a19d28180711379a86.cb517f5d98e85d20f1d3d8b2631995961(long, Stream)).MethodHandle;
			}
			ushort num2 = (ushort)cae578f6e2ca1767c0a670ffe731ad893.c30767ddca1f9c207888833aea5b5fc61(stream);
			num2 = ~num2;
			if ((num2 & 2) != 0)
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
				DESCryptoServiceProvider dESCryptoServiceProvider = ca5f199690a5c37f41762df492744db94.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(8);
				c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(stream, array, 0, 8);
				ca162d70135835b090f53b8b74b3e0f52.c30767ddca1f9c207888833aea5b5fc61(dESCryptoServiceProvider, array);
				byte[] array2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(8);
				c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(stream, array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				for (int j = 0; j < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3); j++)
				{
					byte b = array3[j];
					if (b != 0)
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
						flag = false;
						IL_D4:
						if (flag)
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
							array2 = cb3ca4465be1524a19d28180711379a86.c54b83c31b4ba6c424011dbeae3bf2579(c754697b33257f3a031d7cfbdf39d9824.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						}
						cd4c4976261040bc52662cf932bbe2d07.c30767ddca1f9c207888833aea5b5fc61(dESCryptoServiceProvider, array2);
						if (cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff == null)
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
							if (cb3ca4465be1524a19d28180711379a86.cd4a5675b2cb6bf8214395fe145771c56 == 2147483647)
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
								c82481fcd0e32a30218f9629258cdde35.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff, (int)c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(stream));
							}
							else
							{
								c82481fcd0e32a30218f9629258cdde35.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff, cb3ca4465be1524a19d28180711379a86.cd4a5675b2cb6bf8214395fe145771c56);
							}
						}
						cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff, 0L);
						ICryptoTransform cryptoTransform = c7ea32d2334ebb4466bcdd74ed2d295c8.c30767ddca1f9c207888833aea5b5fc61(dESCryptoServiceProvider);
						int num3 = c4c32fe99c0d5d234f82193cfea7bd770.c30767ddca1f9c207888833aea5b5fc61(cryptoTransform);
						cfdba0709feab135d2d556e7a7c3f55e9.c30767ddca1f9c207888833aea5b5fc61(cryptoTransform);
						byte[] array4 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(cfdba0709feab135d2d556e7a7c3f55e9.c30767ddca1f9c207888833aea5b5fc61(cryptoTransform));
						byte[] array5 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4c32fe99c0d5d234f82193cfea7bd770.c30767ddca1f9c207888833aea5b5fc61(cryptoTransform));
						int num4 = (int)c2489d314f83872a0f087a9d9ad04d52c.c30767ddca1f9c207888833aea5b5fc61(stream);
						while ((long)(num4 + num3) < c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(stream))
						{
							c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(stream, array5, 0, num3);
							int num5 = cad365fa672dcfebdbd5fec82980fd14c.c30767ddca1f9c207888833aea5b5fc61(cryptoTransform, array5, 0, num3, array4, 0);
							c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff, array4, 0, num5);
							num4 += num3;
						}
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(stream, array5, 0, (int)(c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(stream) - (long)num4));
						byte[] array6 = c2ff3082a9839ba1fae1b695027016b6c.c30767ddca1f9c207888833aea5b5fc61(cryptoTransform, array5, 0, (int)(c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(stream) - (long)num4));
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff, array6, 0, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array6));
						stream2 = cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff;
						cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(stream2, 0L);
						c8a754f5f2ca4adde825691a9c31a0e = cb3ca4465be1524a19d28180711379a86.c1b60a12b80c1a98976ba5e843c02d7ff;
						goto IL_253;
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					goto IL_D4;
				}
			}
			IL_253:
			if ((num2 & 8) != 0)
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
				if (cb3ca4465be1524a19d28180711379a86.c3e1f9f4607f4868087c57b473bc5103c == null)
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
					if (cb3ca4465be1524a19d28180711379a86.c8a315799b9b2bab6ed24a91b55502a7e == -2147483648)
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
						c82481fcd0e32a30218f9629258cdde35.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c3e1f9f4607f4868087c57b473bc5103c, (int)c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(stream2) * 2);
					}
					else
					{
						c82481fcd0e32a30218f9629258cdde35.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c3e1f9f4607f4868087c57b473bc5103c, cb3ca4465be1524a19d28180711379a86.c8a315799b9b2bab6ed24a91b55502a7e);
					}
				}
				cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c3e1f9f4607f4868087c57b473bc5103c, 0L);
				DeflateStream deflateStream = c919c9647310842dd2e7a5cf4ac2df78b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(stream2, CompressionMode.Decompress);
				int num6 = 1000;
				byte[] array7 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num6);
				int num7;
				do
				{
					num7 = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(deflateStream, array7, 0, num6);
					if (num7 > 0)
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
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(cb3ca4465be1524a19d28180711379a86.c3e1f9f4607f4868087c57b473bc5103c, array7, 0, num7);
					}
				}
				while (num7 >= num6);
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				c8a754f5f2ca4adde825691a9c31a0e = cb3ca4465be1524a19d28180711379a86.c3e1f9f4607f4868087c57b473bc5103c;
			}
			if (c8a754f5f2ca4adde825691a9c31a0e != null)
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
				return cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(c8a754f5f2ca4adde825691a9c31a0e);
			}
			byte[] array8 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)(checked((IntPtr)(unchecked(c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(stream) - c2489d314f83872a0f087a9d9ad04d52c.c30767ddca1f9c207888833aea5b5fc61(stream))))));
			c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(stream, array8, 0, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array8));
			return array8;
		}

		// Token: 0x04000038 RID: 56
		private static readonly object c939fc80af0af3a9ad3e79430a5846e8c = c46a368fc91355bfa5f52397538782def.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x04000039 RID: 57
		private static readonly int cd4a5675b2cb6bf8214395fe145771c56 = 2147483647;

		// Token: 0x0400003A RID: 58
		private static readonly int c8a315799b9b2bab6ed24a91b55502a7e = 1724416;

		// Token: 0x0400003B RID: 59
		private static readonly MemoryStream c1b60a12b80c1a98976ba5e843c02d7ff = c7b2f5fdcca4edaf6852d90032d9d2e56.c0cf59c3e67a46fd4edb3040c5ab0bbfb(0);

		// Token: 0x0400003C RID: 60
		private static readonly MemoryStream c3e1f9f4607f4868087c57b473bc5103c = c7b2f5fdcca4edaf6852d90032d9d2e56.c0cf59c3e67a46fd4edb3040c5ab0bbfb(0);

		// Token: 0x0400003D RID: 61
		private static readonly byte c0ba91563d7e6b49e54723de1b4ab42db;
	}
}
