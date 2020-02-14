using System;
using System.Runtime.InteropServices;
using System.Text;

namespace A
{
	// Token: 0x0200001B RID: 27
	internal sealed class c91014fa1beb143c83995203b0e30b98f
	{
		// Token: 0x060000AE RID: 174
		[DllImport("kernel32.dll", EntryPoint = "SetLastError", ExactSpelling = true)]
		internal static extern void c46ecf2e8a4044502d8dec2676b718b4d(uint);

		// Token: 0x060000AF RID: 175
		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", ExactSpelling = true)]
		internal static extern int c996ecac411fc1bd70c8a73a503084eb1(IntPtr);

		// Token: 0x060000B0 RID: 176
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess", ExactSpelling = true)]
		internal static extern IntPtr ca84c9f7cd19983827150d2a88e125ce0(uint, int, uint);

		// Token: 0x060000B1 RID: 177
		[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcessId", ExactSpelling = true)]
		internal static extern uint c40c67f58ccf285df95285dfcaf715b91();

		// Token: 0x060000B2 RID: 178
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "LoadLibrary", SetLastError = true)]
		internal static extern IntPtr c06cbb9ffba9f1f61c3573c51aebaa202(string);

		// Token: 0x060000B3 RID: 179
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern c91014fa1beb143c83995203b0e30b98f.c047df68bba8f9070677192b477cb715d c4232d574428c6990f1a1f28de215dbdc(IntPtr, string);

		// Token: 0x060000B4 RID: 180
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern c91014fa1beb143c83995203b0e30b98f.c266e93f33a3b5039b02f7b49577fd3c5 c7b16b700848ef173855864084afcdd65(IntPtr, string);

		// Token: 0x060000B5 RID: 181
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern c91014fa1beb143c83995203b0e30b98f.cb20ab3c74dfd29a648c8dbfd3f5e0e92 c40370594dd2fcedbcb4ceaa1d1ee697f(IntPtr, string);

		// Token: 0x060000B6 RID: 182
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern c91014fa1beb143c83995203b0e30b98f.c8e8c6fc6530003120d869f104e8bc5d8 c90c5ff29da71e836b5816b62ab458e1e(IntPtr, string);

		// Token: 0x060000B7 RID: 183
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern c91014fa1beb143c83995203b0e30b98f.cc7e7079025a323b5f09f6da69b096a31 c20af7293077b9ef1caa6987e821626ad(IntPtr, string);

		// Token: 0x060000B8 RID: 184
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true)]
		internal static extern c91014fa1beb143c83995203b0e30b98f.ce01fee8826282759a5312121debb1c07 ccc2f776f4a734d51db829ae2edf29616(IntPtr, string);

		// Token: 0x060000B9 RID: 185 RVA: 0x00011D9C File Offset: 0x0000FF9C
		private static int c2f81b73e7411464da5317a7067f738b4(IntPtr intPtr, IntPtr intPtr2)
		{
			string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99212));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99216)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206379);
			string[] array2 = array;
			string text = c91014fa1beb143c83995203b0e30b98f.c409ab4b1ddde515dea36adb351faa7d4(intPtr);
			string[] array3 = array2;
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99220); i < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array3); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99236))
			{
				string text2 = array3[i];
				if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, text2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99224) != 0) == 0)
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
						RuntimeMethodHandle arg_76_0 = methodof(c91014fa1beb143c83995203b0e30b98f.c2f81b73e7411464da5317a7067f738b4(IntPtr, IntPtr)).MethodHandle;
					}
					c91014fa1beb143c83995203b0e30b98f.cde767e9bbcc66c89181641af1c66ee1e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99228) != 0);
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99232);
				}
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99240);
		}

		// Token: 0x060000BA RID: 186
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetClassName")]
		internal static extern int cb3d1dd39c4a7cd975eba0f9c3e63a13c(IntPtr, StringBuilder, int);

		// Token: 0x060000BB RID: 187 RVA: 0x00011E70 File Offset: 0x00010070
		internal static string c409ab4b1ddde515dea36adb351faa7d4(IntPtr intPtr)
		{
			StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99244));
			c91014fa1beb143c83995203b0e30b98f.cb3d1dd39c4a7cd975eba0f9c3e63a13c(intPtr, stringBuilder, c6e6474cdf720039785b8b4e32535f454.c30767ddca1f9c207888833aea5b5fc61(stringBuilder));
			return cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00011EAC File Offset: 0x000100AC
		internal static void c38e6ec302a389f894bad35dd136f6028()
		{
			if (c91014fa1beb143c83995203b0e30b98f.c0b82c007224c68fe7e1857e6c4aaded4())
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
					RuntimeMethodHandle arg_1B_0 = methodof(c91014fa1beb143c83995203b0e30b98f.c38e6ec302a389f894bad35dd136f6028()).MethodHandle;
				}
				string text = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206394);
				throw cfe57259e155b3115961b66a3522b0c60.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c322cfc80b06a8da3f6791b681a9ed1de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206411), text));
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00011F00 File Offset: 0x00010100
		internal static bool c0b82c007224c68fe7e1857e6c4aaded4()
		{
			try
			{
				if (ca38a5b70cdac475fc761fb7050404faf.c0cf59c3e67a46fd4edb3040c5ab0bbfb())
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
						RuntimeMethodHandle arg_19_0 = methodof(c91014fa1beb143c83995203b0e30b98f.c0b82c007224c68fe7e1857e6c4aaded4()).MethodHandle;
					}
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99248) != 0;
					return result;
				}
				IntPtr intPtr = c91014fa1beb143c83995203b0e30b98f.c06cbb9ffba9f1f61c3573c51aebaa202(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206538));
				c91014fa1beb143c83995203b0e30b98f.c8e8c6fc6530003120d869f104e8bc5d8 c8e8c6fc6530003120d869f104e8bc5d = c91014fa1beb143c83995203b0e30b98f.c90c5ff29da71e836b5816b62ab458e1e(intPtr, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206563));
				if (c8e8c6fc6530003120d869f104e8bc5d != null)
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
					if (c2235ff76f7cdd5fec1cdef7237ee4efb.c30767ddca1f9c207888833aea5b5fc61(c8e8c6fc6530003120d869f104e8bc5d) != 0)
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
						bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99252) != 0;
						return result;
					}
				}
				uint num = c91014fa1beb143c83995203b0e30b98f.c40c67f58ccf285df95285dfcaf715b91();
				IntPtr intPtr2 = c91014fa1beb143c83995203b0e30b98f.ca84c9f7cd19983827150d2a88e125ce0((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99256), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99260), num);
				if (c9b5db1f9452c42953cc648331810e0f7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, IntPtr.Zero))
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
					try
					{
						c91014fa1beb143c83995203b0e30b98f.cb20ab3c74dfd29a648c8dbfd3f5e0e92 cb20ab3c74dfd29a648c8dbfd3f5e0e = c91014fa1beb143c83995203b0e30b98f.c40370594dd2fcedbcb4ceaa1d1ee697f(intPtr, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206598));
						if (cb20ab3c74dfd29a648c8dbfd3f5e0e != null)
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
							int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99264);
							if (c06c639ba35e863c84bc5c87ab9a0c9cf.c30767ddca1f9c207888833aea5b5fc61(cb20ab3c74dfd29a648c8dbfd3f5e0e, intPtr2, ref num2) != 0)
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
								if (num2 != 0)
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
									bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99268) != 0;
									return result;
								}
							}
						}
					}
					finally
					{
						c91014fa1beb143c83995203b0e30b98f.c996ecac411fc1bd70c8a73a503084eb1(intPtr2);
					}
				}
				bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99272) != 0;
				try
				{
					c91014fa1beb143c83995203b0e30b98f.c996ecac411fc1bd70c8a73a503084eb1(new IntPtr(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99276)));
				}
				catch
				{
					flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99280) != 0);
				}
				if (flag)
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
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99284) != 0;
					return result;
				}
				try
				{
					IntPtr intPtr3 = c91014fa1beb143c83995203b0e30b98f.c06cbb9ffba9f1f61c3573c51aebaa202(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206651));
					c91014fa1beb143c83995203b0e30b98f.ce01fee8826282759a5312121debb1c07 ce01fee8826282759a5312121debb1c = c91014fa1beb143c83995203b0e30b98f.ccc2f776f4a734d51db829ae2edf29616(intPtr3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(206672));
					if (ce01fee8826282759a5312121debb1c != null)
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
						c91014fa1beb143c83995203b0e30b98f.cde767e9bbcc66c89181641af1c66ee1e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99288) != 0);
						ca7c3d3bc88f76be2385516fee8caf0da.c30767ddca1f9c207888833aea5b5fc61(ce01fee8826282759a5312121debb1c, new c91014fa1beb143c83995203b0e30b98f.c10479c62edd270ae5b7a77eff8d0ae97(c91014fa1beb143c83995203b0e30b98f.c2f81b73e7411464da5317a7067f738b4), IntPtr.Zero);
						if (c91014fa1beb143c83995203b0e30b98f.cde767e9bbcc66c89181641af1c66ee1e)
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
							bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99292) != 0;
							return result;
						}
					}
				}
				catch
				{
				}
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99296) != 0;
		}

		// Token: 0x0400004C RID: 76
		internal static uint c0f59cb47a82b02f6541185d71f78e406;

		// Token: 0x0400004D RID: 77
		internal static uint c2f17dc554d2734a2f0c7bdc663802583;

		// Token: 0x0400004E RID: 78
		internal static int c5580adfa09ccaaf358aee0599ca4eefb;

		// Token: 0x0400004F RID: 79
		private static bool cde767e9bbcc66c89181641af1c66ee1e;

		// Token: 0x0200001E RID: 30
		[StructLayout(LayoutKind.Sequential)]
		internal sealed class c191d9e88b809e39c00bb58222f59f85d
		{
			// Token: 0x04000050 RID: 80
			internal IntPtr c26266c15b03377168b09de83ce78573b;

			// Token: 0x04000051 RID: 81
			internal IntPtr ceeaceae3109c1efdbdd927c485cff048;

			// Token: 0x04000052 RID: 82
			internal IntPtr cc37393116b9d0fe82c557ff0abea8822;

			// Token: 0x04000053 RID: 83
			internal IntPtr ca111ba57dad779731c395ef9a0e20f1c;

			// Token: 0x04000054 RID: 84
			internal IntPtr ce1d46d603f8fc0c910ebcb7dbf64d86f;

			// Token: 0x04000055 RID: 85
			internal IntPtr c16968e591c97c814b88aed602b9f773a;
		}

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000C2 RID: 194
		internal delegate int c047df68bba8f9070677192b477cb715d(IntPtr ProcessHandle, int ProcessInformationClass, c91014fa1beb143c83995203b0e30b98f.c191d9e88b809e39c00bb58222f59f85d ProcessInformation, uint ProcessInformationLength, out uint ReturnLength);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000C7 RID: 199
		internal delegate int c266e93f33a3b5039b02f7b49577fd3c5(IntPtr ProcessHandle, int ProcessInformationClass, out uint debugPort, uint ProcessInformationLength, out uint ReturnLength);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000CC RID: 204
		internal delegate int c8e8c6fc6530003120d869f104e8bc5d8();

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x060000D4 RID: 212
		internal delegate void cc7e7079025a323b5f09f6da69b096a31([MarshalAs(UnmanagedType.LPStr)] string lpOutputString);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x060000D9 RID: 217
		internal delegate int cb20ab3c74dfd29a648c8dbfd3f5e0e92(IntPtr hProcess, ref int pbDebuggerPresent);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x060000DE RID: 222
		internal delegate int c10479c62edd270ae5b7a77eff8d0ae97(IntPtr wnd, IntPtr lParam);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060000E3 RID: 227
		internal delegate int ce01fee8826282759a5312121debb1c07(c91014fa1beb143c83995203b0e30b98f.c10479c62edd270ae5b7a77eff8d0ae97 lpEnumFunc, IntPtr lParam);
	}
}
