using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace A
{
	// Token: 0x020000EB RID: 235
	internal sealed class c72d05654ae79127928b430fb7dd5aae2
	{
		// Token: 0x0600080A RID: 2058 RVA: 0x00046120 File Offset: 0x00044320
		public c72d05654ae79127928b430fb7dd5aae2()
		{
			try
			{
				if (!c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc3b429e07ec182ec45833c46546fba89))
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
						RuntimeMethodHandle arg_59_0 = methodof(c72d05654ae79127928b430fb7dd5aae2..ctor()).MethodHandle;
					}
					this.c7461d8fabe1ec2b1beb63dc24f1126df();
				}
				this.c36a16ad4abd4ed5c011e89985dba7523();
			}
			catch (Exception ex)
			{
				c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000461B8 File Offset: 0x000443B8
		private void c7461d8fabe1ec2b1beb63dc24f1126df()
		{
			try
			{
				FileStream fileStream = c102125ea596104aeccacc2a9793b846a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc3b429e07ec182ec45833c46546fba89, (FileMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15408));
				try
				{
					BinaryWriter binaryWriter = c71fa6f0b097935929087ccc2b8f2a944.c0cf59c3e67a46fd4edb3040c5ab0bbfb(fileStream);
					try
					{
						c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15412));
						c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15416));
						c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15420));
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15424); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15456); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15452))
						{
							string text = c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(c72d05654ae79127928b430fb7dd5aae2.ca3131fe15e516b754d104bfe252f57d2(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cffe2a8bb255aec1bd7efa50993853ce5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref i), ca29dc795f6c67a1fb61ec4d4f9e8275f.c0cf59c3e67a46fd4edb3040c5ab0bbfb())), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15428), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15432));
							byte[] array = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(c36524408369b1f168b4cc1966a1fdde1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text);
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15436); j < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15448); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15444))
							{
								byte[] expr_CA_cp_0 = array;
								int expr_CA_cp_1 = j;
								expr_CA_cp_0[expr_CA_cp_1] ^= (byte)(j + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15440));
							}
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
								RuntimeMethodHandle arg_114_0 = methodof(c72d05654ae79127928b430fb7dd5aae2.c7461d8fabe1ec2b1beb63dc24f1126df()).MethodHandle;
							}
							ca36a55fde7e5a04eec5680dc3efae15b.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, array);
						}
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						if (binaryWriter != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(binaryWriter);
						}
					}
				}
				finally
				{
					if (fileStream != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(fileStream);
					}
				}
			}
			catch (Exception ex)
			{
				c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00046398 File Offset: 0x00044598
		private string c8d74f687b301f54c8561ecdc8242f60a(byte[] array, int num, string text = ".dat")
		{
			try
			{
				byte[] array2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15460));
				cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, num, array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15464), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15468));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15472); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15484); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15480))
				{
					byte[] expr_42_cp_0 = array2;
					int expr_42_cp_1 = i;
					expr_42_cp_0[expr_42_cp_1] ^= (byte)(i + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15476));
				}
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
					RuntimeMethodHandle arg_88_0 = methodof(c72d05654ae79127928b430fb7dd5aae2.c8d74f687b301f54c8561ecdc8242f60a(byte[], int, string)).MethodHandle;
				}
				return cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c126a6eb92dcd9d2ab6b76c5ba6144800.c30767ddca1f9c207888833aea5b5fc61(c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(c36524408369b1f168b4cc1966a1fdde1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15488), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15492))), text);
			}
			catch (Exception ex)
			{
				c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return "";
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00046490 File Offset: 0x00044690
		public void c0617e617db47a845e9919db3883a175a()
		{
			try
			{
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149034))))
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
						RuntimeMethodHandle arg_3A_0 = methodof(c72d05654ae79127928b430fb7dd5aae2.c0617e617db47a845e9919db3883a175a()).MethodHandle;
					}
					cd9c8e6d13f1c2f0be820ee4661fad169.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149034)), c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148842), c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893))));
				}
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149057))))
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
					cd9c8e6d13f1c2f0be820ee4661fad169.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149057)), c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148842), c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(120059))));
				}
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149088))))
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
					cd9c8e6d13f1c2f0be820ee4661fad169.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149088)), c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148842), c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149101))));
				}
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149112))))
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
					cd9c8e6d13f1c2f0be820ee4661fad169.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149112)), c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148842), c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149125))));
				}
				if (!c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148842), c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149136)))))
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
					if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149159))))
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
						cd03cfa5a4cbad0787bf61561d7d6187f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149159)), c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148842), c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149136))));
					}
				}
			}
			catch (Exception ex)
			{
				c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0004680C File Offset: 0x00044A0C
		private void c36a16ad4abd4ed5c011e89985dba7523()
		{
			try
			{
				byte[] array = c287db6fad60c56b7095a990074f2ea8f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc3b429e07ec182ec45833c46546fba89);
				if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15496))
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
						RuntimeMethodHandle arg_38_0 = methodof(c72d05654ae79127928b430fb7dd5aae2.c36a16ad4abd4ed5c011e89985dba7523()).MethodHandle;
					}
					if ((int)array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15500)] == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15504))
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
						if ((int)array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15508)] == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15512))
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
							if ((int)array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15516)] == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15520))
							{
								goto IL_A5;
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
					}
				}
				this.c7461d8fabe1ec2b1beb63dc24f1126df();
				IL_A5:
				cbfd54b2671ed0e1fea6f0915ed5d52b1.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893), this.c8d74f687b301f54c8561ecdc8242f60a(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15524), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149184)));
				cbfd54b2671ed0e1fea6f0915ed5d52b1.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149136), this.c8d74f687b301f54c8561ecdc8242f60a(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15528), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149193)));
				cbfd54b2671ed0e1fea6f0915ed5d52b1.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(120059), this.c8d74f687b301f54c8561ecdc8242f60a(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15532), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149184)));
				cbfd54b2671ed0e1fea6f0915ed5d52b1.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149101), this.c8d74f687b301f54c8561ecdc8242f60a(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15536), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149184)));
				cbfd54b2671ed0e1fea6f0915ed5d52b1.c30767ddca1f9c207888833aea5b5fc61(this.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149125), this.c8d74f687b301f54c8561ecdc8242f60a(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15540), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149184)));
				this.c0617e617db47a845e9919db3883a175a();
			}
			catch (Exception ex)
			{
				c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00046A04 File Offset: 0x00044C04
		internal static string ca3131fe15e516b754d104bfe252f57d2(string text)
		{
			string result = "";
			MD5 mD = c58c0b8e76e63dabf6d6ef5c5324526cb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				byte[] array = c93c360f2c384fde6410099bca6700118.c30767ddca1f9c207888833aea5b5fc61(mD, cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(c9cad5749dd0b4a1daf2e7c71e471d9ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15544)), text));
				result = c72d05654ae79127928b430fb7dd5aae2.c3ec8becb664badcad36e7b993a03948a(array);
			}
			finally
			{
				if (mD != null)
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
						RuntimeMethodHandle arg_50_0 = methodof(c72d05654ae79127928b430fb7dd5aae2.ca3131fe15e516b754d104bfe252f57d2(string)).MethodHandle;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(mD);
				}
			}
			return result;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00046A7C File Offset: 0x00044C7C
		public static string c3ec8becb664badcad36e7b993a03948a(byte[] array)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15548));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15552); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15556))
				{
					byte b = array[i];
					ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149202), b);
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
				if (!true)
				{
					RuntimeMethodHandle arg_7A_0 = methodof(c72d05654ae79127928b430fb7dd5aae2.c3ec8becb664badcad36e7b993a03948a(byte[])).MethodHandle;
				}
				result = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x04000441 RID: 1089
		public Dictionary<string, string> c6a8c962f987c65c57f616b33871be6bc = new Dictionary<string, string>();

		// Token: 0x04000442 RID: 1090
		private string cc3b429e07ec182ec45833c46546fba89 = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149215));
	}
}
