using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using ArcheBuddy;
using ArcheBuddy.Bot.Classes;
using Microsoft.Win32;

namespace A
{
	// Token: 0x020000FA RID: 250
	internal static class cc4987d6a853db77954f21abe4e42946a
	{
		// Token: 0x0600084B RID: 2123 RVA: 0x00047AE0 File Offset: 0x00045CE0
		internal static string ce2ae8309527f4c3099509c4f146d28a0(string text)
		{
			FileStream fileStream = c4213b184f42f2ab9b15020e5a1f14340.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, (FileMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15816), (FileAccess)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15820), (FileShare)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15824));
			string result;
			try
			{
				StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15828));
				cec4dc845e772c3e699a057c528837cac.cecbe7d85fc8cbd623e6e32125314b477(c9041cf8c23dbdca54b9d35e33a03bacf.c30767ddca1f9c207888833aea5b5fc61(c6a904c56c88f15813833cbe0aae354ac.c30767ddca1f9c207888833aea5b5fc61(fileStream)), stringBuilder, c6e6474cdf720039785b8b4e32535f454.c30767ddca1f9c207888833aea5b5fc61(stringBuilder), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15832));
				result = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(c35684689f284b0dfa046ebcdcbc9fc5f.c30767ddca1f9c207888833aea5b5fc61(cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149493), "")), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34252), "");
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
						RuntimeMethodHandle arg_BA_0 = methodof(cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(string)).MethodHandle;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(fileStream);
				}
			}
			return result;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00047BC0 File Offset: 0x00045DC0
		internal static uint c44404630230d632cc1782fa6b9646782(string text)
		{
			uint result;
			if (AppMain.stealthMode)
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
					RuntimeMethodHandle arg_1C_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c44404630230d632cc1782fa6b9646782(string)).MethodHandle;
				}
				List<c3588145757b357d2914eb656b313ecae> list = AppMain.c184a42a74d25a49281e3c84092602419.c39c4123f5a98f990da5c03fbbe3eb316();
				if (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15836))
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
					bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15840) != 0;
					try
					{
						object ce7afbb9027bf2feb71f836f6a31f2d;
						cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15844)).ce7afbb9027bf2feb71f836f6a31f2d37, ref flag);
						c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15848)).c93bbaff4707e96bcaa3115033ce14a96 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15852);
						ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15856)).cc2cf678c05af30b3d1766fa545d867c1, new ce2ebb2301152def80a2e8d0e34ade3a5(text).c442e09b1de2262d3a3a28826b3ea696f());
						long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
						while (num + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15868) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
						{
							c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15860));
							if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15864)).c93bbaff4707e96bcaa3115033ce14a96 != 0u)
							{
								IL_11D:
								result = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15872)).c93bbaff4707e96bcaa3115033ce14a96;
								return result;
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
						}
						while (true)
						{
							switch (3)
							{
							case 0:
								continue;
							}
							goto IL_11D;
						}
					}
					finally
					{
						if (flag)
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
							object ce7afbb9027bf2feb71f836f6a31f2d;
							c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d);
						}
					}
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15876);
			}
			cee185df2f5f3c50864542569f2a88882 cee185df2f5f3c50864542569f2a = new cee185df2f5f3c50864542569f2a88882();
			try
			{
				result = cee185df2f5f3c50864542569f2a.c032cd36437328437887c0ca354f72f86(text);
			}
			finally
			{
				if (cee185df2f5f3c50864542569f2a != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(cee185df2f5f3c50864542569f2a);
				}
			}
			return result;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00047D6C File Offset: 0x00045F6C
		internal static bool ca85cf98296ef69d0d4df9e492e1d2df3(ClientVersion clientVersion, string text)
		{
			cee185df2f5f3c50864542569f2a88882 cee185df2f5f3c50864542569f2a = new cee185df2f5f3c50864542569f2a88882();
			try
			{
				uint num = cc4987d6a853db77954f21abe4e42946a.c44404630230d632cc1782fa6b9646782(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34252)));
				if (num == cc4987d6a853db77954f21abe4e42946a.c98aa6a326f7ebdd3f55e6d00714e0f10)
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
						RuntimeMethodHandle arg_3C_0 = methodof(cc4987d6a853db77954f21abe4e42946a.ca85cf98296ef69d0d4df9e492e1d2df3(ClientVersion, string)).MethodHandle;
					}
					if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15880))
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
						bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15884) != 0;
						return result;
					}
				}
				if (num == cc4987d6a853db77954f21abe4e42946a.cad41c2814bc6c59b8b37ca0a24080c74)
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
					if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15888))
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
						bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15892) != 0;
						return result;
					}
				}
				if (num == cc4987d6a853db77954f21abe4e42946a.ca47c6c40bdcb4cad40cc0187834a92f4)
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
					if (clientVersion == ClientVersion.NorthAmericaTrion)
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
						bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15896) != 0;
						return result;
					}
				}
				if (num == cc4987d6a853db77954f21abe4e42946a.c6dfd5e5874e9074fcfd0417be647f0e4)
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
					if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15900))
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
						bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15904) != 0;
						return result;
					}
				}
			}
			finally
			{
				if (cee185df2f5f3c50864542569f2a != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(cee185df2f5f3c50864542569f2a);
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15908) != 0;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00047EAC File Offset: 0x000460AC
		internal static string c2e4607f4d0db70f1d5fccef8022d1220(ClientVersion clientVersion)
		{
			string result = "";
			if (AppMain.stealthMode)
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
					RuntimeMethodHandle arg_1F_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c2e4607f4d0db70f1d5fccef8022d1220(ClientVersion)).MethodHandle;
				}
				return result;
			}
			try
			{
				if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149502)))
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
					cee185df2f5f3c50864542569f2a88882 cee185df2f5f3c50864542569f2a = new cee185df2f5f3c50864542569f2a88882();
					try
					{
						uint num = cc4987d6a853db77954f21abe4e42946a.c44404630230d632cc1782fa6b9646782(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149553));
						if (num == cc4987d6a853db77954f21abe4e42946a.c98aa6a326f7ebdd3f55e6d00714e0f10)
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
							if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15912))
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
								string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149553));
								return result2;
							}
						}
						if (num == cc4987d6a853db77954f21abe4e42946a.cad41c2814bc6c59b8b37ca0a24080c74)
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
							if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15916))
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
								string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149553));
								return result2;
							}
						}
						if (num == cc4987d6a853db77954f21abe4e42946a.ca47c6c40bdcb4cad40cc0187834a92f4)
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
							if (clientVersion == ClientVersion.NorthAmericaTrion)
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
								string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149553));
								return result2;
							}
						}
						if (num == cc4987d6a853db77954f21abe4e42946a.c6dfd5e5874e9074fcfd0417be647f0e4)
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
							if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15920))
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
								string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149553));
								return result2;
							}
						}
					}
					finally
					{
						if (cee185df2f5f3c50864542569f2a != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(cee185df2f5f3c50864542569f2a);
						}
					}
				}
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15924); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15944); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15940))
				{
					if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149626), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149649))))
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
						cee185df2f5f3c50864542569f2a88882 cee185df2f5f3c50864542569f2a2 = new cee185df2f5f3c50864542569f2a88882();
						try
						{
							uint num2 = cc4987d6a853db77954f21abe4e42946a.c44404630230d632cc1782fa6b9646782(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149678), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149701)));
							if (num2 == cc4987d6a853db77954f21abe4e42946a.c98aa6a326f7ebdd3f55e6d00714e0f10)
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
								if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15928))
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
									string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149678), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149701)));
									return result2;
								}
							}
							if (num2 == cc4987d6a853db77954f21abe4e42946a.cad41c2814bc6c59b8b37ca0a24080c74)
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
								if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15932))
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
									string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149678), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149701)));
									return result2;
								}
							}
							if (num2 == cc4987d6a853db77954f21abe4e42946a.ca47c6c40bdcb4cad40cc0187834a92f4)
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
								if (clientVersion == ClientVersion.NorthAmericaTrion)
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
									string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149678), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149701)));
									return result2;
								}
							}
							if (num2 == cc4987d6a853db77954f21abe4e42946a.c6dfd5e5874e9074fcfd0417be647f0e4)
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
								if ((int)clientVersion == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15936))
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
									string result2 = cc4987d6a853db77954f21abe4e42946a.ce2ae8309527f4c3099509c4f146d28a0(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149678), i, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149701)));
									return result2;
								}
							}
						}
						finally
						{
							if (cee185df2f5f3c50864542569f2a2 != null)
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
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(cee185df2f5f3c50864542569f2a2);
							}
						}
					}
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
			catch
			{
			}
			return result;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000482AC File Offset: 0x000464AC
		internal static string ca3131fe15e516b754d104bfe252f57d2(string text)
		{
			string result = "";
			MD5 mD = c58c0b8e76e63dabf6d6ef5c5324526cb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				byte[] array = c93c360f2c384fde6410099bca6700118.c30767ddca1f9c207888833aea5b5fc61(mD, cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(c9cad5749dd0b4a1daf2e7c71e471d9ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15948)), text));
				result = cc4987d6a853db77954f21abe4e42946a.c3ec8becb664badcad36e7b993a03948a(array);
			}
			finally
			{
				if (mD != null)
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
						RuntimeMethodHandle arg_50_0 = methodof(cc4987d6a853db77954f21abe4e42946a.ca3131fe15e516b754d104bfe252f57d2(string)).MethodHandle;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(mD);
				}
			}
			return result;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00048324 File Offset: 0x00046524
		internal static bool c146c48d4799674b826f4a6a570ced794(byte[] array, byte[] array2)
		{
			if (array != null)
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
					RuntimeMethodHandle arg_15_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c146c48d4799674b826f4a6a570ced794(byte[], byte[])).MethodHandle;
				}
				if (array2 == null)
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
				}
				else
				{
					if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) != (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2))
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
						return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15956) != 0;
					}
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15960); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15968))
					{
						if (array[i] != array2[i])
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
							return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15964) != 0;
						}
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15972) != 0;
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15952) != 0;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x000483E0 File Offset: 0x000465E0
		internal static Color cd3f37936749e1f97ba2302c000ed0a41(int num, Color color)
		{
			return c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num, (int)c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref color), (int)caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref color), (int)ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref color));
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00048410 File Offset: 0x00046610
		internal static void cdc13e3890807a63773b061915e2d9bd2()
		{
			RegistryKey registryKey = cba12f91c916965a25580169c1c44ede3.c30767ddca1f9c207888833aea5b5fc61(Registry.LocalMachine, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149752));
			try
			{
				if (registryKey != null)
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
						RuntimeMethodHandle arg_2E_0 = methodof(cc4987d6a853db77954f21abe4e42946a.cdc13e3890807a63773b061915e2d9bd2()).MethodHandle;
					}
					return;
				}
			}
			finally
			{
				if (registryKey != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(registryKey);
				}
			}
			if (c2c0532e878e3e8d918a207e74be4bba1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149841), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150069), (MessageBoxButtons)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15976)) == (DialogResult)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15980))
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
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150096))))
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
					cb717faea04d1154b5b33f9605a7931b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150096)));
					cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15984));
					return;
				}
				cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15988));
				return;
			}
			else
			{
				cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15992));
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00048548 File Offset: 0x00046748
		internal static void c69648ea5c5277378f12f6248b6682f52()
		{
			RegistryKey registryKey = cba12f91c916965a25580169c1c44ede3.c30767ddca1f9c207888833aea5b5fc61(Registry.LocalMachine, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150147));
			try
			{
				if (registryKey != null)
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
						RuntimeMethodHandle arg_2E_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c69648ea5c5277378f12f6248b6682f52()).MethodHandle;
					}
					string text = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(cbdc52d936295bb784c182d29f0ecf078.c30767ddca1f9c207888833aea5b5fc61(registryKey, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150250)));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ""))
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
						return;
					}
				}
			}
			finally
			{
				if (registryKey != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(registryKey);
				}
			}
			cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15996));
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000485F0 File Offset: 0x000467F0
		internal static void c4735049a4440eab94ea362b16eede672()
		{
			try
			{
				WindowsIdentity windowsIdentity = cb8c5e992e1f66271e32f2a5401b3865f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				WindowsPrincipal windowsPrincipal = c277fca6d23465335a2574090f3a025ad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(windowsIdentity);
				if (!cd265424b7172f6c7045380498e73579a.c30767ddca1f9c207888833aea5b5fc61(windowsPrincipal, (WindowsBuiltInRole)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16000)))
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
						RuntimeMethodHandle arg_35_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c4735049a4440eab94ea362b16eede672()).MethodHandle;
					}
					c2e5e290c5e34f024145fe136ad4da993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150265));
					cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16004));
				}
				return;
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
			cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16008));
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0004868C File Offset: 0x0004688C
		public static void c92ef9313fd1cec46e34b841cf0265b90(int num)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0004869C File Offset: 0x0004689C
		public static void c49e6f431917e06939cb9b64b69d2938e(string text)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000486AC File Offset: 0x000468AC
		public static void cc9982884fcd8751391914f88648f21e6(string text)
		{
			try
			{
				object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16012));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16016)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358);
				object[] arg_4F_0 = array;
				int arg_4F_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16020);
				DateTime dateTime = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				arg_4F_0[arg_4F_1] = ca1d69caad6d07bfff4b5cd22eea388bb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16024)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
				object[] arg_8C_0 = array;
				int arg_8C_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16028);
				DateTime dateTime2 = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				arg_8C_0[arg_8C_1] = c927d3cdef746618375a53b89cf22c393.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime2);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16032)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
				object[] arg_C9_0 = array;
				int arg_C9_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16036);
				DateTime dateTime3 = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				arg_C9_0[arg_C9_1] = cf9315336989806c66aa99f34de4d9fc6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime3);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16040)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34642);
				object[] arg_106_0 = array;
				int arg_106_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16044);
				DateTime dateTime4 = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				arg_106_0[arg_106_1] = c0d195af3148f45a198e3af9b1c2154e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime4);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16048)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118643);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16052)] = text;
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16056)] = cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				string text2 = c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cc4987d6a853db77954f21abe4e42946a.cd00a8bbdd1f33ee5e6e10bbee8de8acd))
				{
					byte[] array2 = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text2);
					byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16060));
					IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.ccde044939136b2826f7836f4b7884d53(array2, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
					c57e4e9b98508f27ccf87d25f7471ed6b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16064), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
					FileStream fileStream = c8e2a411a1b821e656502a0d51c312750.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.caf5b572478755944a010f7c71b2242b0, (FileMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16068), (FileAccess)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16072), (FileShare)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16076));
					try
					{
						BinaryWriter binaryWriter = ccbe317ae21dfcf234d72e30b2107c66f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(fileStream, cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16080) != 0);
						try
						{
							ca36a55fde7e5a04eec5680dc3efae15b.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, array3);
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
								if (!true)
								{
									RuntimeMethodHandle arg_218_0 = methodof(cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(string)).MethodHandle;
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
								switch (2)
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
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0004897C File Offset: 0x00046B7C
		public static DateTime cc9ac066cf01d912d638f598a5f7acdcc(double num)
		{
			DateTime result;
			cc3c9417114995b2010d6b6fc5e1aeadc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref result, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16084), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16088), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16092), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16096), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16100), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16104), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16108));
			DateTime dateTime = c2f2066ccd4e7bb485dfdeb6a3e920c6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref result, num);
			result = ce86e58a629e4640f30de6617f4d78437.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime);
			return result;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000489EC File Offset: 0x00046BEC
		public static bool c7ed053f2f7674b3a5b01f9e82e1b9572(int num, CoreInternal coreInternal)
		{
			if (coreInternal == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c7ed053f2f7674b3a5b01f9e82e1b9572(int, CoreInternal)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16112) != 0;
			}
			if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(coreInternal) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16116))
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
				long num2 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				coreInternal.cf97cfca00aedbb73f89dc3850d2bdc9b = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16120);
				if (coreInternal.c788468c0f1361a00c09677914a79d73b != null)
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
					object arg_8E_0 = coreInternal.c788468c0f1361a00c09677914a79d73b;
					byte[] expr_83 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16124));
					c21512aadbc438e0c34236fbd1c52da3b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_83, fieldof(cecebbe15a82731eb2f8453f1b7665d70.c425373ea806041b239addf92d81dad79).FieldHandle);
					ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(arg_8E_0, expr_83);
				}
				while (num2 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16132) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
				{
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16128));
					if (coreInternal.cf97cfca00aedbb73f89dc3850d2bdc9b != 0)
					{
						IL_D6:
						return coreInternal.cf97cfca00aedbb73f89dc3850d2bdc9b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16136);
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
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					goto IL_D6;
				}
			}
			else
			{
				IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.c9cc521d3448d182457075922f5b7432f();
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16140) != 0;
				}
				int num3;
				if (cec4dc845e772c3e699a057c528837cac.c497f7db396249e0552769a37b0294081(intPtr, out num3) == 0u)
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16144) != 0;
				}
				return num3 == num;
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00048B34 File Offset: 0x00046D34
		public static void c8299fa31317d146976f1ea9cd623369b(string text)
		{
			try
			{
				cbf4111912aed594f2b4372828dd95aa3 arg_36_0 = AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8;
				DateTime dateTime = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				arg_36_0.c8299fa31317d146976f1ea9cd623369b(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c0f2a8b99bad07e422b000ecb6327a3f8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), text), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00048BA0 File Offset: 0x00046DA0
		public static void cc8b3de74a1208845f6798f929726f61d()
		{
			try
			{
				AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8.cdec08c245806a34f01c9706eac9a8a1e(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00048BE8 File Offset: 0x00046DE8
		public static int cc6aa98c842d31c331ac756905a26d823()
		{
			TimeSpan timeSpan = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf674f613c2b0023a0ec2404335ed0d5d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new DateTime(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16148), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16152), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16156)));
			return (int)c7909b429f371ae19a1cd6fbf8c0bb1c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00048C34 File Offset: 0x00046E34
		public static long c270f7259dc6c7e6d1950062475294ede()
		{
			TimeSpan timeSpan = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf674f613c2b0023a0ec2404335ed0d5d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new DateTime(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16160), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16164), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16168)));
			return (long)cfe4421bbd9a38d7624066b2af5fe228a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00048C80 File Offset: 0x00046E80
		public static double cf9c31f988e474e440eb72f9c74d173a9(double num)
		{
			int num2 = (int)num;
			return num - (double)num2;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00048C94 File Offset: 0x00046E94
		public static long c8e52f77add442f172d2e228b8659b890()
		{
			TimeSpan timeSpan = c35ed2a6cd5aee97721789937d72dec8d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf674f613c2b0023a0ec2404335ed0d5d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cc4987d6a853db77954f21abe4e42946a.c863c7c9c2ec5c3b38f44d260d267ac0b);
			return (long)cfe4421bbd9a38d7624066b2af5fe228a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref timeSpan);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00048CC0 File Offset: 0x00046EC0
		public static byte[] c1d07721bca9539f79521b3ba0c936b7c(string text)
		{
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16172));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16176); i < c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16196); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16192))
			{
				array[i] = c24b7a74df9c770c2343aa111771833d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, i * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16180), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16184)), (NumberStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16188));
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
				RuntimeMethodHandle arg_8F_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c1d07721bca9539f79521b3ba0c936b7c(string)).MethodHandle;
			}
			return array;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00048D60 File Offset: 0x00046F60
		public static byte[] ce87108cadfa088d87b15003114763281(string text)
		{
			string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16200));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16204)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792);
			string[] array2 = cc19ced84c86a267bd615bafbf2c5917a.c30767ddca1f9c207888833aea5b5fc61(text, array, (StringSplitOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16208));
			byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16212); i < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16220))
			{
				array3[i] = c24b7a74df9c770c2343aa111771833d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[i], (NumberStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16216));
			}
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
				RuntimeMethodHandle arg_9E_0 = methodof(cc4987d6a853db77954f21abe4e42946a.ce87108cadfa088d87b15003114763281(string)).MethodHandle;
			}
			return array3;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00048E10 File Offset: 0x00047010
		public static string c833052bfbdfe807c941a746864ac7a34(byte[] array)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16224));
				int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16228);
				c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150379));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16232); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16244))
				{
					byte b = array[i];
					ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150382), b);
					num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16236);
					if (num % c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16240) == 0)
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
							RuntimeMethodHandle arg_9B_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c833052bfbdfe807c941a746864ac7a34(byte[])).MethodHandle;
						}
						c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150379));
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
				result = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00048F20 File Offset: 0x00047120
		public static string c259f9807fcd8ed1942f1ae11922e4b13(byte[] array)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16248));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16252); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16256))
				{
					byte b = array[i];
					ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150382), b);
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
					RuntimeMethodHandle arg_7A_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(byte[])).MethodHandle;
				}
				result = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00048FD0 File Offset: 0x000471D0
		public static string c259f9807fcd8ed1942f1ae11922e4b13(byte[] array, int num)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16260));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16264); i < num; i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16268))
				{
					ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150382), array[i]);
				}
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
					RuntimeMethodHandle arg_61_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(byte[], int)).MethodHandle;
				}
				result = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00049064 File Offset: 0x00047264
		public static string c3ec8becb664badcad36e7b993a03948a(byte[] array)
		{
			string result;
			try
			{
				StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16272));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16276); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16280))
				{
					byte b = array[i];
					ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149202), b);
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
					RuntimeMethodHandle arg_7A_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c3ec8becb664badcad36e7b993a03948a(byte[])).MethodHandle;
				}
				result = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00049114 File Offset: 0x00047314
		public static string c833052bfbdfe807c941a746864ac7a34(byte[] array, int num)
		{
			StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16284));
			c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150379));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16288); i < num; i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16300))
			{
				ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150382), array[i]);
				if (i % c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16292) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16296))
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
						RuntimeMethodHandle arg_85_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c833052bfbdfe807c941a746864ac7a34(byte[], int)).MethodHandle;
					}
					c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150379));
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
			return cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000491E0 File Offset: 0x000473E0
		public static string cf2f3cd7f902dc854eec813d9ea481755(byte[] array)
		{
			return cb104ab32545b9a4f3a225d48cc06ba69.c30767ddca1f9c207888833aea5b5fc61(c36524408369b1f168b4cc1966a1fdde1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000491FC File Offset: 0x000473FC
		public static string c2b966a2fa1ed81333623c192e7813b12(byte[] array)
		{
			StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16304));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16308); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16312))
			{
				byte b = array[i];
				ccb51fbfd254653fb6825ad08bbf2a7f4.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150397), b);
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
				RuntimeMethodHandle arg_75_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c2b966a2fa1ed81333623c192e7813b12(byte[])).MethodHandle;
			}
			return cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00049288 File Offset: 0x00047488
		public static string c501bb29e0fcd349b7ae24954cc00e4d1(byte[] array)
		{
			StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16316));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16320); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16336))
			{
				byte b = array[i];
				c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c0572ad0b3ae9601e0002a95e7bdb84c3.c30767ddca1f9c207888833aea5b5fc61(c3259d408d5a47ef1c12465998a8f2d84.c0cf59c3e67a46fd4edb3040c5ab0bbfb(b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16324)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16328), (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16332)));
				c6c0d11df3f081377cdb393b9120c3f61.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792));
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
				RuntimeMethodHandle arg_A5_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c501bb29e0fcd349b7ae24954cc00e4d1(byte[])).MethodHandle;
			}
			return cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00049344 File Offset: 0x00047544
		public static byte[] c79f35c54d279cfa925dfe3754935621d(string text, byte[] array, byte[] array2)
		{
			if (text != null)
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
					RuntimeMethodHandle arg_15_0 = methodof(cc4987d6a853db77954f21abe4e42946a.c79f35c54d279cfa925dfe3754935621d(string, byte[], byte[])).MethodHandle;
				}
				if (c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16340))
				{
					if (array != null)
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
						if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16344))
						{
							if (array2 != null)
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
								if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16348))
								{
									RijndaelManaged rijndaelManaged = cbe43071e580bdcffe07e1c7c48bcbf30.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									byte[] result;
									try
									{
										cc77d67f35ecbebe89cb8db1c0946ab5b.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16352));
										cd4c4976261040bc52662cf932bbe2d07.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged, array);
										ca162d70135835b090f53b8b74b3e0f52.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged, array2);
										c5795574475e3be87edd53ee8fe5788c9.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged, (CipherMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16356));
										ICryptoTransform cryptoTransform = c63500b2ee0a8f9a90881c61a7b451004.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged, c3dba7bdc84461630507c89073d3c3cad.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged), c48c383065172724f18484077e941b176.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged));
										MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
										try
										{
											CryptoStream cryptoStream = c396d40309b8141e0c91815f7b5eba15b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(memoryStream, cryptoTransform, (CryptoStreamMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16360));
											try
											{
												StreamWriter streamWriter = c0d316809359d3aceb3cb36ffc3dc2d0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cryptoStream);
												try
												{
													cf5e5b51f256f33203ad9b05eb281b67b.c30767ddca1f9c207888833aea5b5fc61(streamWriter, text);
												}
												finally
												{
													if (streamWriter != null)
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
														cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(streamWriter);
													}
												}
												result = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
											}
											finally
											{
												if (cryptoStream != null)
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
													cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(cryptoStream);
												}
											}
										}
										finally
										{
											if (memoryStream != null)
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
												cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
											}
										}
									}
									finally
									{
										if (rijndaelManaged != null)
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
											cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(rijndaelManaged);
										}
									}
									return result;
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
							}
							throw c87c52bce13e3dd762332e3e3768d7eaf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150429));
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
					}
					throw c87c52bce13e3dd762332e3e3768d7eaf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150429));
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
			}
			throw c87c52bce13e3dd762332e3e3768d7eaf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150410));
		}

		// Token: 0x04000463 RID: 1123
		private static uint c98aa6a326f7ebdd3f55e6d00714e0f10 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16364);

		// Token: 0x04000464 RID: 1124
		private static uint cad41c2814bc6c59b8b37ca0a24080c74 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16368);

		// Token: 0x04000465 RID: 1125
		private static uint ca47c6c40bdcb4cad40cc0187834a92f4 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16372);

		// Token: 0x04000466 RID: 1126
		private static uint c6dfd5e5874e9074fcfd0417be647f0e4 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16376);

		// Token: 0x04000467 RID: 1127
		internal static string c87dc00533dbed281d546bf1a305efa0b = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150436);

		// Token: 0x04000468 RID: 1128
		private static object cd00a8bbdd1f33ee5e6e10bbee8de8acd = c46a368fc91355bfa5f52397538782def.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x04000469 RID: 1129
		private static readonly DateTime c863c7c9c2ec5c3b38f44d260d267ac0b = new DateTime(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16380), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16384), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16388), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16392), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16396), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16400), (DateTimeKind)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(16404));
	}
}
