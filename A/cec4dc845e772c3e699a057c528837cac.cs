using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ArcheBuddy;

namespace A
{
	// Token: 0x020000FB RID: 251
	internal static class cec4dc845e772c3e699a057c528837cac
	{
		// Token: 0x0600086C RID: 2156
		[DllImport("user32.dll", EntryPoint = "ShowWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool c4495727acb05dc03d637e80f93529881(IntPtr, cec4dc845e772c3e699a057c528837cac.cca9309395208b743ce90568e6c4e72e8);

		// Token: 0x0600086D RID: 2157
		[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
		public static extern bool c79b099664bdd394100d439c28a842382(IntPtr);

		// Token: 0x0600086E RID: 2158
		[DllImport("user32.dll", EntryPoint = "EnumThreadWindows")]
		private static extern bool c69735d7fc3cda8dbebec843234e41128(int, cec4dc845e772c3e699a057c528837cac.cffdd430954a10b4fae6e743845bc76a7, IntPtr);

		// Token: 0x0600086F RID: 2159 RVA: 0x000495A0 File Offset: 0x000477A0
		public static List<IntPtr> c3aea438308c872f22b3053c2160a2915(int num)
		{
			cec4dc845e772c3e699a057c528837cac.cffdd430954a10b4fae6e743845bc76a7 cffdd430954a10b4fae6e743845bc76a = null;
			cec4dc845e772c3e699a057c528837cac.c942c7e331d7a43646b83c9b87dfcfa93 c942c7e331d7a43646b83c9b87dfcfa = new cec4dc845e772c3e699a057c528837cac.c942c7e331d7a43646b83c9b87dfcfa93();
			c942c7e331d7a43646b83c9b87dfcfa.cc57e44e7aca169e97fcbd10e1860585d = c60b8d9df171d95ca246f53664b7ee5a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			IEnumerator enumerator = c0ff66ce1d9f0d03be3614231295e3d07.c30767ddca1f9c207888833aea5b5fc61(c75328730d9d035b19c95759b8ee3212f.c30767ddca1f9c207888833aea5b5fc61(c591b3807e3508f06381b8edb380d1130.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num)));
			try
			{
				while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
				{
					ProcessThread processThread = c4234d4ef4ad829678eb9991a0153e91b.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator));
					int expr_44 = cd5d90d893c19637830fff5738e49367b.c30767ddca1f9c207888833aea5b5fc61(processThread);
					if (cffdd430954a10b4fae6e743845bc76a == null)
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
							RuntimeMethodHandle arg_5B_0 = methodof(cec4dc845e772c3e699a057c528837cac.c3aea438308c872f22b3053c2160a2915(int)).MethodHandle;
						}
						cffdd430954a10b4fae6e743845bc76a = new cec4dc845e772c3e699a057c528837cac.cffdd430954a10b4fae6e743845bc76a7(c942c7e331d7a43646b83c9b87dfcfa.cb34664b77e1cae303ca1d96e32304f83);
					}
					cec4dc845e772c3e699a057c528837cac.c69735d7fc3cda8dbebec843234e41128(expr_44, cffdd430954a10b4fae6e743845bc76a, IntPtr.Zero);
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
			}
			finally
			{
				IDisposable disposable = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator);
				if (disposable != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable);
				}
			}
			return c942c7e331d7a43646b83c9b87dfcfa.cc57e44e7aca169e97fcbd10e1860585d;
		}

		// Token: 0x06000870 RID: 2160
		[DllImport("kernel32.dll", EntryPoint = "CreateProcess", SetLastError = true)]
		public static extern bool c5cc8ff7c3c829e04a02c2ea76624fe34(string, string, ref cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918, ref cec4dc845e772c3e699a057c528837cac.c108a12d25724974b0833fde890082918, bool, uint, IntPtr, string, [In] ref cec4dc845e772c3e699a057c528837cac.cca57fc0ef865e600cc3c5551dbbb1b49, out cec4dc845e772c3e699a057c528837cac.c36f14603976d7f8bddf05cfac99c0409);

		// Token: 0x06000871 RID: 2161
		[DllImport("mscoree.dll", CharSet = CharSet.Unicode, EntryPoint = "GetFileVersion")]
		private static extern int c50cc04f675e04dc3e6e989f9d86748fb(string, StringBuilder, int, out int);

		// Token: 0x06000872 RID: 2162 RVA: 0x00049670 File Offset: 0x00047870
		public static bool ca3fcbef988d3bc491e0701c009debb36(string text)
		{
			StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16408));
			int num2;
			int num = cec4dc845e772c3e699a057c528837cac.c50cc04f675e04dc3e6e989f9d86748fb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33558), text), stringBuilder, c6e6474cdf720039785b8b4e32535f454.c30767ddca1f9c207888833aea5b5fc61(stringBuilder), out num2);
			return num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16412);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000496C8 File Offset: 0x000478C8
		public unsafe static bool c1180306331ddd735ad689ef1af309751(byte[] array, out byte[] ptr)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.c1180306331ddd735ad689ef1af309751(byte[], byte[]*)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.c2cafe7d5d48973d98f9790d424d7c045 == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150457));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.c2cafe7d5d48973d98f9790d424d7c045 = (cec4dc845e772c3e699a057c528837cac.c3e575c676f64fb30583e77b4af5997e3)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c3e575c676f64fb30583e77b4af5997e3).TypeHandle));
			}
			return ceeb3d270fec4c5834847d0824a623368.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.c2cafe7d5d48973d98f9790d424d7c045, array, out ptr);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000497C0 File Offset: 0x000479C0
		public unsafe static IntPtr cb908b18f3e777ab90214af7f20069152(byte[] array, int num, ref int ptr)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.cb908b18f3e777ab90214af7f20069152(byte[], int, int*)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.cfa0195997e8053b647e1d06605c26862 == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150486));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.cfa0195997e8053b647e1d06605c26862 = (cec4dc845e772c3e699a057c528837cac.cbddac31b3c4c3993b8a1ca4371d7ead0)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.cbddac31b3c4c3993b8a1ca4371d7ead0).TypeHandle));
			}
			return c7222831793f512e07b0c45ccfd539b72.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.cfa0195997e8053b647e1d06605c26862, array, num, ref ptr);
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x000498BC File Offset: 0x00047ABC
		public unsafe static IntPtr cf4d2a4fe2029acb1fa15e71f8425aec6(byte[] array, int num, ref int ptr)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.cf4d2a4fe2029acb1fa15e71f8425aec6(byte[], int, int*)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.c529f7befbed793e0eac41de54c108afb == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150525));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.c529f7befbed793e0eac41de54c108afb = (cec4dc845e772c3e699a057c528837cac.c510ebf7daf15b8e12f46c9854a9b2e9f)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c510ebf7daf15b8e12f46c9854a9b2e9f).TypeHandle));
			}
			return cf61d448634b947f14e5ae97f500977ba.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.c529f7befbed793e0eac41de54c108afb, array, num, ref ptr);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x000499B8 File Offset: 0x00047BB8
		public static bool ce02e55a17a7ddc0548475bc781aa5673(IntPtr intPtr, IntPtr intPtr2, IntPtr intPtr3, IntPtr intPtr4, IntPtr intPtr5, IntPtr intPtr6, IntPtr intPtr7)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.ce02e55a17a7ddc0548475bc781aa5673(IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.cc0d0ad3a377dd83182c147b411599f38 == null)
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
				IntPtr intPtr8 = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150564));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr8, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.cc0d0ad3a377dd83182c147b411599f38 = (cec4dc845e772c3e699a057c528837cac.ccfb6bf0911ded71fcb5d90ad5ff1a414)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr8, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.ccfb6bf0911ded71fcb5d90ad5ff1a414).TypeHandle));
			}
			return cf94e9b96c68f96847291f9983c032276.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.cc0d0ad3a377dd83182c147b411599f38, intPtr, intPtr2, intPtr3, intPtr4, intPtr5, intPtr6, intPtr7);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00049AB8 File Offset: 0x00047CB8
		public unsafe static IntPtr c8bbd4cd2e747b667461df4a3108d72f8(byte[] array, int num, ref int ptr)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.c8bbd4cd2e747b667461df4a3108d72f8(byte[], int, int*)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.c6fadae029436558e9c29ea4dd11600ca == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150603));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.c6fadae029436558e9c29ea4dd11600ca = (cec4dc845e772c3e699a057c528837cac.ca8be397da2e8bce3773192af9514f85d)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.ca8be397da2e8bce3773192af9514f85d).TypeHandle));
			}
			return cf9ce30fd1bd52e0c2b84e13ebd9be57d.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.c6fadae029436558e9c29ea4dd11600ca, array, num, ref ptr);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00049BB4 File Offset: 0x00047DB4
		public unsafe static IntPtr cc1e8b1627cb670102e38af50edc3eeeb(byte[] array, int num, ref int ptr, byte b, byte b2)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
				if (!true)
				{
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.cc1e8b1627cb670102e38af50edc3eeeb(byte[], int, int*, byte, byte)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.ca6eb172f8633a2df81019e650418989d == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150642));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.ca6eb172f8633a2df81019e650418989d = (cec4dc845e772c3e699a057c528837cac.c481d231b086b7300f4a53d66e2aa365a)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c481d231b086b7300f4a53d66e2aa365a).TypeHandle));
			}
			return c25d35eba5d2b7078536ccd76ec7bb2ec.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.ca6eb172f8633a2df81019e650418989d, array, num, ref ptr, b, b2);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00049CB0 File Offset: 0x00047EB0
		public unsafe static IntPtr c98c869ae53e76c4796a45886143e908b(byte[] array, int num, ref byte ptr, ref uint ptr2, uint num2, byte b, ref int ptr3, byte[] array2, byte[] array3)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.c98c869ae53e76c4796a45886143e908b(byte[], int, byte*, uint*, uint, byte, int*, byte[], byte[])).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.cb8db56f2774ef0900224e515826fcb8b == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150685));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.cb8db56f2774ef0900224e515826fcb8b = (cec4dc845e772c3e699a057c528837cac.c5fd18f9d4da67dad3dd23e407462f207)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c5fd18f9d4da67dad3dd23e407462f207).TypeHandle));
			}
			return cfaa3e3618c59219dd1bf6da81c98c5b9.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.cb8db56f2774ef0900224e515826fcb8b, array, num, ref ptr, ref ptr2, num2, b, ref ptr3, array2, array3);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00049DB4 File Offset: 0x00047FB4
		public static IntPtr cc6bae94a01c553d8e57ae84e540f6bcf(byte[] array, int num, ref byte ptr, ref uint ptr2, uint num2, byte b, ref int ptr3, byte[] array2, byte[] array3)
		{
			IntPtr result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cec4dc845e772c3e699a057c528837cac.ce3837c20658a55a8b2b96f4662f7a950))
			{
				result = cec4dc845e772c3e699a057c528837cac.c98c869ae53e76c4796a45886143e908b(array, num, ref ptr, ref ptr2, num2, b, ref ptr3, array2, array3);
			}
			return result;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00049E08 File Offset: 0x00048008
		public static int c0980fb152fc5b59c2f25679154714dd4(int num, int num2, byte[] array, bool flag)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.c0980fb152fc5b59c2f25679154714dd4(int, int, byte[], bool)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.ca67f5347fe07adb275a759d84dd7c419 == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150742));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.ca67f5347fe07adb275a759d84dd7c419 = (cec4dc845e772c3e699a057c528837cac.cb7843bf32776baf4d9dce86651b204d7)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.cb7843bf32776baf4d9dce86651b204d7).TypeHandle));
			}
			return c26a4a67f5d6f623c9f8ae3d309de843e.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.ca67f5347fe07adb275a759d84dd7c419, num, num2, array, flag);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00049F04 File Offset: 0x00048104
		public static bool cf778e523c3f1e7e2c03277c40ae59efa(int num, int num2, string text, byte b)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.cf778e523c3f1e7e2c03277c40ae59efa(int, int, string, byte)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.c91409878df87b24d8a8e1f5718de0ef8 == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150779));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.c91409878df87b24d8a8e1f5718de0ef8 = (cec4dc845e772c3e699a057c528837cac.c6d31fedcc4d5bc66840c91fdaee03d8c)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c6d31fedcc4d5bc66840c91fdaee03d8c).TypeHandle));
			}
			return c73fb6f94164feaf91d199e0c5ca00d75.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.c91409878df87b24d8a8e1f5718de0ef8, num, num2, text, b);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0004A000 File Offset: 0x00048200
		public static bool cffd79ab4d11be7165b8ae2b8a2588d93(int num, int num2, string text, byte b)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.cffd79ab4d11be7165b8ae2b8a2588d93(int, int, string, byte)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.cfeff59d73f7cf8264d1e534b84d1fba5 == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150816));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.cfeff59d73f7cf8264d1e534b84d1fba5 = (cec4dc845e772c3e699a057c528837cac.c7fa317a50d96849094d88f4bb70a22cd)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c7fa317a50d96849094d88f4bb70a22cd).TypeHandle));
			}
			return ca29cbc731bf659ef6b24537918c61d2a.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.cfeff59d73f7cf8264d1e534b84d1fba5, num, num2, text, b);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0004A0FC File Offset: 0x000482FC
		public unsafe static bool c60dea235214869c7c4752ed5d1e1579b(byte[] array, int num, byte[] array2, int num2, ref uint ptr, ref uint ptr2)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.c60dea235214869c7c4752ed5d1e1579b(byte[], int, byte[], int, uint*, uint*)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.cb97663e996c9d73e099718709e0dc0f2 == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150853));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.cb97663e996c9d73e099718709e0dc0f2 = (cec4dc845e772c3e699a057c528837cac.c22610d98a17944393f16de78d3bc3c75)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c22610d98a17944393f16de78d3bc3c75).TypeHandle));
			}
			return cd6b3fcc1295521868d39bf736197ba5b.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.cb97663e996c9d73e099718709e0dc0f2, array, num, array2, num2, ref ptr, ref ptr2);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0004A1FC File Offset: 0x000483FC
		public static IntPtr ccde044939136b2826f7836f4b7884d53(byte[] array, int num)
		{
			if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.ccde044939136b2826f7836f4b7884d53(byte[], int)).MethodHandle;
				}
				cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4 = cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
			}
			if (cec4dc845e772c3e699a057c528837cac.c585fbf4936ec5b471c5a4cc5f882da5d == null)
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
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cf76bea2b846d77178c5cbf71da9015df(cec4dc845e772c3e699a057c528837cac.cf219706cc23736eb85bdcecbb5dba1c4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150902));
				if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
					throw cdfcde8ab4b6bc09c3c626fec48f13804.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				cec4dc845e772c3e699a057c528837cac.c585fbf4936ec5b471c5a4cc5f882da5d = (cec4dc845e772c3e699a057c528837cac.c2bc8b7248e9b9f36dc0e08d1feb56b4f)cc6457fc81d27366b161b2d4f55c85470.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(cec4dc845e772c3e699a057c528837cac.c2bc8b7248e9b9f36dc0e08d1feb56b4f).TypeHandle));
			}
			return c8e3470229c8d00173350ab5e3788873b.c30767ddca1f9c207888833aea5b5fc61(cec4dc845e772c3e699a057c528837cac.c585fbf4936ec5b471c5a4cc5f882da5d, array, num);
		}

		// Token: 0x06000880 RID: 2176
		[DllImport("kernel32.dll", EntryPoint = "GetFinalPathNameByHandle", SetLastError = true)]
		public static extern int cecbe7d85fc8cbd623e6e32125314b477(IntPtr, [In] [Out] StringBuilder, int, int);

		// Token: 0x06000881 RID: 2177
		[DllImport("kernel32.dll", EntryPoint = "TerminateProcess", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool c5115425f2678e87547ed98d77f8aae32(IntPtr, uint);

		// Token: 0x06000882 RID: 2178
		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
		public static extern IntPtr c9cc521d3448d182457075922f5b7432f();

		// Token: 0x06000883 RID: 2179
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
		public static extern uint c497f7db396249e0552769a37b0294081(IntPtr, out int);

		// Token: 0x06000884 RID: 2180
		[DllImport("user32.dll", EntryPoint = "SetWindowsHookEx", SetLastError = true)]
		public static extern IntPtr cea9bfd938a0dd33c107df14ede1ba4fa(int, cec4dc845e772c3e699a057c528837cac.c252f4b4af21193be44ea005e6b67b1a8, IntPtr, int);

		// Token: 0x06000885 RID: 2181
		[DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
		public static extern bool c824b67144e1dffbe41d0c6982a68cf7d(IntPtr);

		// Token: 0x06000886 RID: 2182
		[DllImport("Kernel32.dll", EntryPoint = "GetModuleHandle", SetLastError = true)]
		public static extern IntPtr ca0fdf3f1c9a3b0e34c11be6535d9db84(IntPtr);

		// Token: 0x06000887 RID: 2183
		[DllImport("user32.dll", EntryPoint = "CallNextHookEx", SetLastError = true)]
		public static extern IntPtr cb8ac0bf3b4657af93b7cd909a729d72d(IntPtr, int, IntPtr, IntPtr);

		// Token: 0x06000888 RID: 2184
		[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
		public static extern IntPtr c06cbb9ffba9f1f61c3573c51aebaa202(string);

		// Token: 0x06000889 RID: 2185
		[DllImport("kernel32.dll", EntryPoint = "AllocConsole")]
		public static extern bool c3df8515fbb43a568cb129304bfc9bb84();

		// Token: 0x0600088A RID: 2186
		[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
		public static extern IntPtr ca84c9f7cd19983827150d2a88e125ce0(uint, int, int);

		// Token: 0x0600088B RID: 2187
		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
		public static extern int c996ecac411fc1bd70c8a73a503084eb1(IntPtr);

		// Token: 0x0600088C RID: 2188
		[DllImport("kernel32.dll", EntryPoint = "GetProcAddress", SetLastError = true)]
		public static extern IntPtr cf76bea2b846d77178c5cbf71da9015df(IntPtr, string);

		// Token: 0x0600088D RID: 2189
		[DllImport("user32.dll", EntryPoint = "SetWindowRgn")]
		public static extern int cac24a5ae511699bc10212b0ef953aef1(IntPtr, IntPtr, bool);

		// Token: 0x0600088E RID: 2190
		[DllImport("kernel32.dll", EntryPoint = "CreateEvent")]
		public static extern IntPtr c2a57d7359a9ff108ccca63970c40b3bc(IntPtr, bool, bool, string);

		// Token: 0x0600088F RID: 2191
		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public static extern IntPtr c5226f502892f8a52f2a5eae43938f0ec(IntPtr, int, IntPtr, IntPtr);

		// Token: 0x06000890 RID: 2192
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowLong")]
		public static extern IntPtr cb3a8c0dc1aad1ae62c7b0f23d7cab064(IntPtr, int);

		// Token: 0x06000891 RID: 2193
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowLongPtr")]
		public static extern IntPtr c972050d9d21484f18318488b44f5232a(IntPtr, int);

		// Token: 0x06000892 RID: 2194
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLong")]
		public static extern IntPtr ccee6c614401a5d098d9231af026d3d62(IntPtr, int, int);

		// Token: 0x06000893 RID: 2195
		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLongPtr")]
		public static extern IntPtr cb9ca057087fc1ef0dfdbf6f7dbc6ecdf(IntPtr, int, int);

		// Token: 0x06000894 RID: 2196
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
		public static extern IntPtr c9655457401bec4c230615b85106e8ee7(uint, IntPtr, cec4dc845e772c3e699a057c528837cac.c948b0b453a5258059923cd545e75b290, int, int, string);

		// Token: 0x06000895 RID: 2197
		[DllImport("kernel32.dll", EntryPoint = "MapViewOfFile", SetLastError = true)]
		public static extern IntPtr c58836b2e1b25a85a75d9ce58408d6f60(IntPtr, cec4dc845e772c3e699a057c528837cac.c7d4b163fc6177d542dedf0bdbefac9e6, uint, uint, int);

		// Token: 0x06000896 RID: 2198
		[DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
		public static extern void c62c1df01c86325f30ed5f2649102feb0(IntPtr, byte[], int);

		// Token: 0x06000897 RID: 2199
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		public static extern IntPtr cecbe8b99e02bb7b9aa0b2fea312e6dbf(int, int, int, int, int, int);

		// Token: 0x06000898 RID: 2200 RVA: 0x0004A2F4 File Offset: 0x000484F4
		public static int c0f289e073512b997e554ef046292995a(IntPtr intPtr, int num)
		{
			if (c142cc1c454e83622ebabf290532e9be3.c0cf59c3e67a46fd4edb3040c5ab0bbfb() == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16416))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.c0f289e073512b997e554ef046292995a(IntPtr, int)).MethodHandle;
				}
				return c91eec2bbf515b751e547219b29815cda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cb3a8c0dc1aad1ae62c7b0f23d7cab064(intPtr, num));
			}
			return (int)c4fb387287aefd5626075a75609a9c5f0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.c972050d9d21484f18318488b44f5232a(intPtr, num));
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0004A34C File Offset: 0x0004854C
		public static int c7cf35217c8a0e6813f538a4a26699d2e(IntPtr intPtr, int num, int num2)
		{
			if (c142cc1c454e83622ebabf290532e9be3.c0cf59c3e67a46fd4edb3040c5ab0bbfb() == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16420))
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
					RuntimeMethodHandle arg_25_0 = methodof(cec4dc845e772c3e699a057c528837cac.c7cf35217c8a0e6813f538a4a26699d2e(IntPtr, int, int)).MethodHandle;
				}
				return c91eec2bbf515b751e547219b29815cda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.ccee6c614401a5d098d9231af026d3d62(intPtr, num, num2));
			}
			return (int)c4fb387287aefd5626075a75609a9c5f0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cec4dc845e772c3e699a057c528837cac.cb9ca057087fc1ef0dfdbf6f7dbc6ecdf(intPtr, num, num2));
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0004A3A4 File Offset: 0x000485A4
		public static ushort c71b96ae62763feec478c9a741943227c(IntPtr intPtr)
		{
			return (ushort)(c4fb387287aefd5626075a75609a9c5f0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr) >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16424) & (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16428));
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0004A3D4 File Offset: 0x000485D4
		public static int c9ef4b093e36731585f488280d8e87426(IntPtr intPtr)
		{
			return (int)((short)cec4dc845e772c3e699a057c528837cac.c71b96ae62763feec478c9a741943227c(intPtr));
		}

		// Token: 0x0400046A RID: 1130
		public static int cfb9af27c2eb255de5ea52f11303ebb7f;

		// Token: 0x0400046B RID: 1131
		public static int c3a137454fce7e686ab22f5a2783edbaa;

		// Token: 0x0400046C RID: 1132
		public static int c30ba4f698a8724482a783ba278f4cf28;

		// Token: 0x0400046D RID: 1133
		public static int cd782c8dfa031642dd9a47b2824ab8f12;

		// Token: 0x0400046E RID: 1134
		public static int ce35b54891f38268f4e34680370fd9481;

		// Token: 0x0400046F RID: 1135
		public static int c4b65b40f053b49e1a49a12a771b7891f;

		// Token: 0x04000470 RID: 1136
		public static int cb55b1ed8e1eabed944d56249993fbc6a;

		// Token: 0x04000471 RID: 1137
		public static int c3128adf4448229aa86c96e8d5e3316eb;

		// Token: 0x04000472 RID: 1138
		public static int c5e34aab32c9e67bd772ba835dfd84216;

		// Token: 0x04000473 RID: 1139
		public static int cbfe790fb5e8db9da65b91edaa6d47686;

		// Token: 0x04000474 RID: 1140
		public static int c69a4d9b4d22978925086c7a6f13234c2;

		// Token: 0x04000475 RID: 1141
		public static int c4551cda1cc73ee8847fc059f966195ad;

		// Token: 0x04000476 RID: 1142
		public static int ce027ba928e9486da7eba80bfb50bc2b4;

		// Token: 0x04000477 RID: 1143
		public static int c674848377cb59459fc565eab4f99ae37;

		// Token: 0x04000478 RID: 1144
		public static int ce3a3618cb0eafd510d31bfff1dca8d66;

		// Token: 0x04000479 RID: 1145
		public static int cef327129c93bc406259411ebb944b195;

		// Token: 0x0400047A RID: 1146
		public static int cd9945995b1d408c3b96b4ebd06456c3d;

		// Token: 0x0400047B RID: 1147
		public static int c10898fa99be0b285f6c1ef84ca8927cd;

		// Token: 0x0400047C RID: 1148
		public static int c38d26e2314df6269514b58da4b792328;

		// Token: 0x0400047D RID: 1149
		public static int cae2aa9596b758f85057a8d3076490200;

		// Token: 0x0400047E RID: 1150
		public static int c3a4d3fcdbf09a1b6eba70b8c2cd599c4;

		// Token: 0x0400047F RID: 1151
		public static int cf4031034e45e621c8524d69db5abfc71;

		// Token: 0x04000480 RID: 1152
		public static int c36a4703d754cfbb18391c755919fa3a3;

		// Token: 0x04000481 RID: 1153
		public static int cc2d43024b6270e26e16f16505b204235;

		// Token: 0x04000482 RID: 1154
		public static int c3abc09f82288e1653a0fe42b5700fbf0;

		// Token: 0x04000483 RID: 1155
		public static int c1663e8e22dc132e3edd77c3a2318784c;

		// Token: 0x04000484 RID: 1156
		public static int cb7a91f9a7f7acb2d110a3c5724b7481e;

		// Token: 0x04000485 RID: 1157
		public static int c36efdb67029a04684218b25c7579cf5f;

		// Token: 0x04000486 RID: 1158
		private static object ce3837c20658a55a8b2b96f4662f7a950 = c46a368fc91355bfa5f52397538782def.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x04000487 RID: 1159
		private static IntPtr cf219706cc23736eb85bdcecbb5dba1c4;

		// Token: 0x04000488 RID: 1160
		private static cec4dc845e772c3e699a057c528837cac.c3e575c676f64fb30583e77b4af5997e3 c2cafe7d5d48973d98f9790d424d7c045 = null;

		// Token: 0x04000489 RID: 1161
		private static cec4dc845e772c3e699a057c528837cac.cbddac31b3c4c3993b8a1ca4371d7ead0 cfa0195997e8053b647e1d06605c26862 = null;

		// Token: 0x0400048A RID: 1162
		private static cec4dc845e772c3e699a057c528837cac.c510ebf7daf15b8e12f46c9854a9b2e9f c529f7befbed793e0eac41de54c108afb = null;

		// Token: 0x0400048B RID: 1163
		private static cec4dc845e772c3e699a057c528837cac.ccfb6bf0911ded71fcb5d90ad5ff1a414 cc0d0ad3a377dd83182c147b411599f38 = null;

		// Token: 0x0400048C RID: 1164
		private static cec4dc845e772c3e699a057c528837cac.ca8be397da2e8bce3773192af9514f85d c6fadae029436558e9c29ea4dd11600ca = null;

		// Token: 0x0400048D RID: 1165
		private static cec4dc845e772c3e699a057c528837cac.c481d231b086b7300f4a53d66e2aa365a ca6eb172f8633a2df81019e650418989d = null;

		// Token: 0x0400048E RID: 1166
		private static cec4dc845e772c3e699a057c528837cac.c5fd18f9d4da67dad3dd23e407462f207 cb8db56f2774ef0900224e515826fcb8b = null;

		// Token: 0x0400048F RID: 1167
		private static cec4dc845e772c3e699a057c528837cac.cb7843bf32776baf4d9dce86651b204d7 ca67f5347fe07adb275a759d84dd7c419 = null;

		// Token: 0x04000490 RID: 1168
		private static cec4dc845e772c3e699a057c528837cac.c6d31fedcc4d5bc66840c91fdaee03d8c c91409878df87b24d8a8e1f5718de0ef8 = null;

		// Token: 0x04000491 RID: 1169
		private static cec4dc845e772c3e699a057c528837cac.c7fa317a50d96849094d88f4bb70a22cd cfeff59d73f7cf8264d1e534b84d1fba5 = null;

		// Token: 0x04000492 RID: 1170
		private static cec4dc845e772c3e699a057c528837cac.c22610d98a17944393f16de78d3bc3c75 cb97663e996c9d73e099718709e0dc0f2 = null;

		// Token: 0x04000493 RID: 1171
		private static cec4dc845e772c3e699a057c528837cac.c2bc8b7248e9b9f36dc0e08d1feb56b4f c585fbf4936ec5b471c5a4cc5f882da5d = null;

		// Token: 0x020000FC RID: 252
		// (Invoke) Token: 0x0600089D RID: 2205
		private delegate bool cffdd430954a10b4fae6e743845bc76a7(IntPtr hWnd, IntPtr lParam);

		// Token: 0x020000FD RID: 253
		public enum cca9309395208b743ce90568e6c4e72e8
		{
			// Token: 0x04000495 RID: 1173
			c450615ea4a070e6b31778b0abcddeff8,
			// Token: 0x04000496 RID: 1174
			c46644604d63cbae4ebe2390f17f6d22f,
			// Token: 0x04000497 RID: 1175
			c9f38a02f76d1a50e1810941fce9ee905,
			// Token: 0x04000498 RID: 1176
			c24cc0d743e3a6d325daa3577f9b1f795,
			// Token: 0x04000499 RID: 1177
			c331b688802dac4af6c305aa4a304f3e5 = 3,
			// Token: 0x0400049A RID: 1178
			c148246160392be58211dfce08ee389cf,
			// Token: 0x0400049B RID: 1179
			c78dcab8d90b65b1daec53919229254da,
			// Token: 0x0400049C RID: 1180
			c77ea2e67b6bb3ff19d587f7c68e7c896,
			// Token: 0x0400049D RID: 1181
			cb035463e5bd471c4cbc41e772670bc79,
			// Token: 0x0400049E RID: 1182
			c1a205842b87e1d1c0180a0c858c43d94,
			// Token: 0x0400049F RID: 1183
			cc963e9c98da75d267b88f2d654fe69e2,
			// Token: 0x040004A0 RID: 1184
			c33beb7d337ff347fbfc6ae3e670d5249,
			// Token: 0x040004A1 RID: 1185
			c8ae9a7b1e04c5be1957a719955187d2e
		}

		// Token: 0x020000FE RID: 254
		public struct c2638a9d5e52f76bbeb463fda6b9e8d38
		{
			// Token: 0x060008A0 RID: 2208 RVA: 0x0004A3EC File Offset: 0x000485EC
			public c2638a9d5e52f76bbeb463fda6b9e8d38(int num, int num2, int num3, int num4)
			{
				this.c6136cee27c070a7969126a5c6909d713 = num;
				this.c5255870915de5f160ad416d9eb6091e4 = num2;
				this.c03fc8ed899405c9583e6aa55defc81d6 = num3;
				this.c7be4a33b333089b777d9a41e97211ee0 = num4;
			}

			// Token: 0x060008A1 RID: 2209 RVA: 0x0004A418 File Offset: 0x00048618
			public c2638a9d5e52f76bbeb463fda6b9e8d38(Rectangle rectangle)
			{
				this = new cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38(c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle), c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle), ca8fa466c259f42f0e9d6fa16f995efe7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle), c65d1d2ff133320d2e1cce6cfa56a2e63.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle));
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x0004A450 File Offset: 0x00048650
			public int get_c3071642cc772d7d0223fbcc438c3ff3e()
			{
				return this.c6136cee27c070a7969126a5c6909d713;
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x0004A464 File Offset: 0x00048664
			public void set_c3071642cc772d7d0223fbcc438c3ff3e(int num)
			{
				this.c03fc8ed899405c9583e6aa55defc81d6 -= this.c6136cee27c070a7969126a5c6909d713 - num;
				this.c6136cee27c070a7969126a5c6909d713 = num;
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x0004A490 File Offset: 0x00048690
			public int get_c039bd5f7ee0b10e3324f3380089087ec()
			{
				return this.c5255870915de5f160ad416d9eb6091e4;
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x0004A4A4 File Offset: 0x000486A4
			public void set_c039bd5f7ee0b10e3324f3380089087ec(int num)
			{
				this.c7be4a33b333089b777d9a41e97211ee0 -= this.c5255870915de5f160ad416d9eb6091e4 - num;
				this.c5255870915de5f160ad416d9eb6091e4 = num;
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x0004A4D0 File Offset: 0x000486D0
			public int get_c0684337f52ba0e61a2010cd34d0ab9a5()
			{
				return this.c7be4a33b333089b777d9a41e97211ee0 - this.c5255870915de5f160ad416d9eb6091e4;
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x0004A4EC File Offset: 0x000486EC
			public void set_c0684337f52ba0e61a2010cd34d0ab9a5(int num)
			{
				this.c7be4a33b333089b777d9a41e97211ee0 = num + this.c5255870915de5f160ad416d9eb6091e4;
			}

			// Token: 0x060008A8 RID: 2216 RVA: 0x0004A508 File Offset: 0x00048708
			public int get_c1e4bc44408903339fe1a48fecf0cf3e9()
			{
				return this.c03fc8ed899405c9583e6aa55defc81d6 - this.c6136cee27c070a7969126a5c6909d713;
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x0004A524 File Offset: 0x00048724
			public void set_c1e4bc44408903339fe1a48fecf0cf3e9(int num)
			{
				this.c03fc8ed899405c9583e6aa55defc81d6 = num + this.c6136cee27c070a7969126a5c6909d713;
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x0004A540 File Offset: 0x00048740
			public Point get_c47bd857f531dedcf63ca1d4075d13b32()
			{
				return new Point(this.c6136cee27c070a7969126a5c6909d713, this.c5255870915de5f160ad416d9eb6091e4);
			}

			// Token: 0x060008AB RID: 2219 RVA: 0x0004A560 File Offset: 0x00048760
			public void set_c47bd857f531dedcf63ca1d4075d13b32(Point point)
			{
				this.set_c3071642cc772d7d0223fbcc438c3ff3e(cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point));
				this.set_c039bd5f7ee0b10e3324f3380089087ec(cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point));
			}

			// Token: 0x060008AC RID: 2220 RVA: 0x0004A58C File Offset: 0x0004878C
			public Size get_ce6df75c044fed0e8e7b650c38ff897cb()
			{
				return new Size(this.get_c1e4bc44408903339fe1a48fecf0cf3e9(), this.get_c0684337f52ba0e61a2010cd34d0ab9a5());
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x0004A5B0 File Offset: 0x000487B0
			public void set_ce6df75c044fed0e8e7b650c38ff897cb(Size size)
			{
				this.set_c1e4bc44408903339fe1a48fecf0cf3e9(c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size));
				this.set_c0684337f52ba0e61a2010cd34d0ab9a5(cd732e615dba6a4c4c5707fa7b770a160.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size));
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x0004A5DC File Offset: 0x000487DC
			public static Rectangle c7475ca745e3b3a964aca29d47d0d09bc(cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38 c2638a9d5e52f76bbeb463fda6b9e8d)
			{
				return new Rectangle(c2638a9d5e52f76bbeb463fda6b9e8d.c6136cee27c070a7969126a5c6909d713, c2638a9d5e52f76bbeb463fda6b9e8d.c5255870915de5f160ad416d9eb6091e4, c2638a9d5e52f76bbeb463fda6b9e8d.get_c1e4bc44408903339fe1a48fecf0cf3e9(), c2638a9d5e52f76bbeb463fda6b9e8d.get_c0684337f52ba0e61a2010cd34d0ab9a5());
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x0004A610 File Offset: 0x00048810
			public static cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38 c7475ca745e3b3a964aca29d47d0d09bc(Rectangle rectangle)
			{
				return new cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38(rectangle);
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x0004A624 File Offset: 0x00048824
			public static bool c9dfe27a44d67c0e563cd206c4241873e(cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38 c2638a9d5e52f76bbeb463fda6b9e8d, cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38 c2638a9d5e52f76bbeb463fda6b9e8d2)
			{
				return c2638a9d5e52f76bbeb463fda6b9e8d.c574a369d0cbd2f0b2c7adc81d5eb1bdf(c2638a9d5e52f76bbeb463fda6b9e8d2);
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x0004A63C File Offset: 0x0004883C
			public static bool cc5340be84f23cc1f8b9f85af89f0feb5(cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38 c2638a9d5e52f76bbeb463fda6b9e8d, cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38 c2638a9d5e52f76bbeb463fda6b9e8d2)
			{
				return (c2638a9d5e52f76bbeb463fda6b9e8d.c574a369d0cbd2f0b2c7adc81d5eb1bdf(c2638a9d5e52f76bbeb463fda6b9e8d2) ? 1 : 0) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16432);
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x0004A660 File Offset: 0x00048860
			public bool c574a369d0cbd2f0b2c7adc81d5eb1bdf(cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38 c2638a9d5e52f76bbeb463fda6b9e8d)
			{
				if (c2638a9d5e52f76bbeb463fda6b9e8d.c6136cee27c070a7969126a5c6909d713 == this.c6136cee27c070a7969126a5c6909d713)
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
					if (!true)
					{
						RuntimeMethodHandle arg_21_0 = methodof(cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38.c574a369d0cbd2f0b2c7adc81d5eb1bdf(cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38)).MethodHandle;
					}
					if (c2638a9d5e52f76bbeb463fda6b9e8d.c5255870915de5f160ad416d9eb6091e4 == this.c5255870915de5f160ad416d9eb6091e4)
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
						if (c2638a9d5e52f76bbeb463fda6b9e8d.c03fc8ed899405c9583e6aa55defc81d6 == this.c03fc8ed899405c9583e6aa55defc81d6)
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
							return c2638a9d5e52f76bbeb463fda6b9e8d.c7be4a33b333089b777d9a41e97211ee0 == this.c7be4a33b333089b777d9a41e97211ee0;
						}
					}
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16436) != 0;
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x0004A6DC File Offset: 0x000488DC
			public override bool Equals(object obj)
			{
				if (obj is cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38)
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
						RuntimeMethodHandle arg_1A_0 = methodof(cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38.Equals(object)).MethodHandle;
					}
					return this.c574a369d0cbd2f0b2c7adc81d5eb1bdf((cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38)obj);
				}
				if (cd815dd24e64d29b1db4659beebb81afa.cea69e7c4d1a729bd5783221de1566e79(obj) != null)
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
					return this.c574a369d0cbd2f0b2c7adc81d5eb1bdf(new cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38(ce5c14738efd8aff994d6be506aaffd74.cc6a9c540a2ed5763275f32ba91c9e97b(obj)));
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16440) != 0;
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x0004A748 File Offset: 0x00048948
			public override int GetHashCode()
			{
				return cec4dc845e772c3e699a057c528837cac.c2638a9d5e52f76bbeb463fda6b9e8d38.c7475ca745e3b3a964aca29d47d0d09bc(this).GetHashCode();
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x0004A774 File Offset: 0x00048974
			public override string ToString()
			{
				IFormatProvider expr_05 = cd09b182534ea55ce5432bb3b51a79b51.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				string expr_11 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150937);
				object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16444));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16448)] = this.c6136cee27c070a7969126a5c6909d713;
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16452)] = this.c5255870915de5f160ad416d9eb6091e4;
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16456)] = this.c03fc8ed899405c9583e6aa55defc81d6;
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16460)] = this.c7be4a33b333089b777d9a41e97211ee0;
				return c5d59a1bffafecb1b9982bce1fc79e349.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_05, expr_11, array);
			}

			// Token: 0x040004A2 RID: 1186
			public int c6136cee27c070a7969126a5c6909d713;

			// Token: 0x040004A3 RID: 1187
			public int c5255870915de5f160ad416d9eb6091e4;

			// Token: 0x040004A4 RID: 1188
			public int c03fc8ed899405c9583e6aa55defc81d6;

			// Token: 0x040004A5 RID: 1189
			public int c7be4a33b333089b777d9a41e97211ee0;
		}

		// Token: 0x020000FF RID: 255
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct cca57fc0ef865e600cc3c5551dbbb1b49
		{
			// Token: 0x040004A6 RID: 1190
			public int c57fe51813897d73c7edda89499385c11;

			// Token: 0x040004A7 RID: 1191
			public string cef13096879fe181d747a6c63785fd1db;

			// Token: 0x040004A8 RID: 1192
			public string cb7577fed59e08e553921aee522785490;

			// Token: 0x040004A9 RID: 1193
			public string c9db3539da5c46f2e7d89dc3946d6695e;

			// Token: 0x040004AA RID: 1194
			public int c8bd2fc698da5af794f057ed9cc71f143;

			// Token: 0x040004AB RID: 1195
			public int c6721aa2475cc87accc7e26f4dceb5744;

			// Token: 0x040004AC RID: 1196
			public int cdfc6fa88f450872cae78e18f9d6002b2;

			// Token: 0x040004AD RID: 1197
			public int c11b14b6f9d5013987b1dbf1bbc6a3187;

			// Token: 0x040004AE RID: 1198
			public int c7155d526926796aa9577805d92c8dab5;

			// Token: 0x040004AF RID: 1199
			public int c1b8d4b7efbd4e60f1c5bacab1f0e7dc3;

			// Token: 0x040004B0 RID: 1200
			public int c7321f7622822ee988689b95aa1cff480;

			// Token: 0x040004B1 RID: 1201
			public int ca454189d5a2c20a689cc7ef5f5e6702e;

			// Token: 0x040004B2 RID: 1202
			public short ca0e10f3da44c51d0b196382221e3daa3;

			// Token: 0x040004B3 RID: 1203
			public short ca2c96e85b743f7b0ded85c51f5e8bbc3;

			// Token: 0x040004B4 RID: 1204
			public IntPtr c30d3c32eeef0c506ddfbce9d57487d9f;

			// Token: 0x040004B5 RID: 1205
			public IntPtr c55e8bed2386884ebac981f8bcbd112d3;

			// Token: 0x040004B6 RID: 1206
			public IntPtr c11eba69dded8ff70308a5978bc08590c;

			// Token: 0x040004B7 RID: 1207
			public IntPtr c53aea05dc39d95754ceccd863cb6d269;
		}

		// Token: 0x02000100 RID: 256
		internal struct c36f14603976d7f8bddf05cfac99c0409
		{
			// Token: 0x040004B8 RID: 1208
			public IntPtr c504ff350b137786951e0c514968a4f2d;

			// Token: 0x040004B9 RID: 1209
			public IntPtr c934f6dd57c365a1c25665cae5b1f4c2f;

			// Token: 0x040004BA RID: 1210
			public int ccc1b6474af18a76c36a3ba11d663bf35;

			// Token: 0x040004BB RID: 1211
			public int c46f2a4ad19b1705266ba99a93e7f5e6b;
		}

		// Token: 0x02000101 RID: 257
		public struct c108a12d25724974b0833fde890082918
		{
			// Token: 0x040004BC RID: 1212
			public int c58fa9f2670ab99f3e9f95f527de60cb5;

			// Token: 0x040004BD RID: 1213
			public IntPtr c5b210e0de3ebfd43c975f815429be2b9;

			// Token: 0x040004BE RID: 1214
			public int c3ba11146210211cd98a55462fe0f7501;
		}

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060008B7 RID: 2231
		public delegate IntPtr c252f4b4af21193be44ea005e6b67b1a8(int nCode, IntPtr wParam, IntPtr lParam);

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x060008BB RID: 2235
		public delegate void cec86aba4005b6110968562316deef5e1(uint code);

		// Token: 0x02000104 RID: 260
		// (Invoke) Token: 0x060008BF RID: 2239
		public delegate void c0593cff77c3229d16609947d8b92a4d1();

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060008C3 RID: 2243
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool c3e575c676f64fb30583e77b4af5997e3(byte[] _in, out byte[] _out);

		// Token: 0x02000106 RID: 262
		// (Invoke) Token: 0x060008C7 RID: 2247
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr cbddac31b3c4c3993b8a1ca4371d7ead0(byte[] _in, int inSize, ref int size);

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060008CB RID: 2251
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr c510ebf7daf15b8e12f46c9854a9b2e9f(byte[] _in, int inSize, ref int size);

		// Token: 0x02000108 RID: 264
		// (Invoke) Token: 0x060008CF RID: 2255
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool ccfb6bf0911ded71fcb5d90ad5ff1a414(IntPtr addr1, IntPtr addr2, IntPtr addr3, IntPtr addr4, IntPtr addr5, IntPtr addr6, IntPtr addr7);

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060008D3 RID: 2259
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr ca8be397da2e8bce3773192af9514f85d(byte[] _in, int inSize, ref int size);

		// Token: 0x0200010A RID: 266
		// (Invoke) Token: 0x060008D7 RID: 2263
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr c481d231b086b7300f4a53d66e2aa365a(byte[] _in, int inSize, ref int size, byte key, byte iv);

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060008DB RID: 2267
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr c5fd18f9d4da67dad3dd23e407462f207(byte[] _in, int inSize, ref byte coreMagicValue, ref uint cryptValue, uint cryptoKey, byte clientVersion, ref int outputLen, byte[] cryptedArray, byte[] cryptedArray2);

		// Token: 0x0200010C RID: 268
		// (Invoke) Token: 0x060008DF RID: 2271
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int cb7843bf32776baf4d9dce86651b204d7(int processId, int threadId, byte[] data, bool inj);

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060008E3 RID: 2275
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool c6d31fedcc4d5bc66840c91fdaee03d8c(int processId, int threadId, string basePath, byte injMethod);

		// Token: 0x0200010E RID: 270
		// (Invoke) Token: 0x060008E7 RID: 2279
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool c7fa317a50d96849094d88f4bb70a22cd(int processId, int threadId, string basePath, byte injMethod);

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060008EB RID: 2283
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate bool c22610d98a17944393f16de78d3bc3c75(byte[] authTiket, int sizeOfAuthTiken, byte[] signature, int sizeOfSignature, ref uint mappingResult, ref uint eventResult);

		// Token: 0x02000110 RID: 272
		// (Invoke) Token: 0x060008EF RID: 2287
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr c2bc8b7248e9b9f36dc0e08d1feb56b4f(byte[] input, int inputLen);

		// Token: 0x02000111 RID: 273
		[Flags]
		public enum c948b0b453a5258059923cd545e75b290 : uint
		{
			// Token: 0x040004C0 RID: 1216
			c4ec227658285ad23af3d2a47c7ab0ce0 = 2u,
			// Token: 0x040004C1 RID: 1217
			ccff165b432de7526679c9df9097cd01a = 4u,
			// Token: 0x040004C2 RID: 1218
			c763281eaa7fe64a26d81316354973009 = 8u,
			// Token: 0x040004C3 RID: 1219
			c09afa5ccbaf90e1ab3f5b1c1c2ce0028 = 32u,
			// Token: 0x040004C4 RID: 1220
			c23a9cfb8204b08356dfa67a8cfa93b13 = 64u,
			// Token: 0x040004C5 RID: 1221
			c1585d4d5c000981a8506e97275a73c70 = 134217728u,
			// Token: 0x040004C6 RID: 1222
			c1bd64a2d96eae901b183d3bb6d53424b = 16777216u,
			// Token: 0x040004C7 RID: 1223
			c081a277074c5448e62a36eb3a8794715 = 268435456u,
			// Token: 0x040004C8 RID: 1224
			cf80af2fcdd29aa9b443cb763684eee18 = 67108864u
		}

		// Token: 0x02000112 RID: 274
		[Flags]
		public enum c7d4b163fc6177d542dedf0bdbefac9e6 : uint
		{
			// Token: 0x040004CA RID: 1226
			c281484d73ccbf0f83e6834b8868d35ad = 1u,
			// Token: 0x040004CB RID: 1227
			c2795e74841d3ec1caf45d3b8a8829c56 = 2u,
			// Token: 0x040004CC RID: 1228
			c81268c1555aec6eab5bdf62a23eb2f2e = 4u,
			// Token: 0x040004CD RID: 1229
			cf8f6e859d077b93707776cf470051ada = 31u,
			// Token: 0x040004CE RID: 1230
			c63a9e992ba90dcc8092e93bdd2e10bcc = 32u
		}

		// Token: 0x02000583 RID: 1411
		[CompilerGenerated]
		private sealed class c942c7e331d7a43646b83c9b87dfcfa93
		{
			// Token: 0x06001F85 RID: 8069 RVA: 0x001447C8 File Offset: 0x001429C8
			public bool cb34664b77e1cae303ca1d96e32304f83(IntPtr intPtr, IntPtr intPtr2)
			{
				cd6484cc9b2db535bf618f0a8420124ce.c30767ddca1f9c207888833aea5b5fc61(this.cc57e44e7aca169e97fcbd10e1860585d, intPtr);
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97948) != 0;
			}

			// Token: 0x0400150B RID: 5387
			public List<IntPtr> cc57e44e7aca169e97fcbd10e1860585d;
		}
	}
}
