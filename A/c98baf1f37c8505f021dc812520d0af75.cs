using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ICSharpCode.SharpZipLib.Zip;

namespace A
{
	// Token: 0x02000136 RID: 310
	internal sealed class c98baf1f37c8505f021dc812520d0af75
	{
		// Token: 0x06000B00 RID: 2816 RVA: 0x0006C90C File Offset: 0x0006AB0C
		internal c98baf1f37c8505f021dc812520d0af75()
		{
			this.c2dd581ae45fb30a049578f61a9ce5b2d = new WebClient();
			this.c539772140852dae7c433494e7c4ab872 = new List<c98baf1f37c8505f021dc812520d0af75.ca2b71cc95f6cef4d4b465e05a4628c7e>();
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0006C938 File Offset: 0x0006AB38
		internal double c4bd79c4eee1f710a5baab5851951f9ac(int num, int num2, int num3, int num4)
		{
			try
			{
				double result;
				if (num3 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24164))
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
						RuntimeMethodHandle arg_1F_0 = methodof(c98baf1f37c8505f021dc812520d0af75.c4bd79c4eee1f710a5baab5851951f9ac(int, int, int, int)).MethodHandle;
					}
					if (num3 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24168))
					{
						if (num4 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24180))
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
							if (num4 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24184))
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
							}
							else
							{
								bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24196) != 0;
								for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24200); i < c550d77bb22e33e00192bef4dea6cd65b.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24208))
								{
									if (c09e27dcc49b68f3f1fc0144051166706.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872, i).c01f5bd909cf249efea5f261060593de7 == num)
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
										if (c09e27dcc49b68f3f1fc0144051166706.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872, i).c0c5cb1cb9f1e58245e93f42d3efac96f == num2)
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
											flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24204) != 0);
											IL_119:
											if (!flag)
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
												if (!this.c295b089019bed10e63ae6313c6d47343(num, num2))
												{
													result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24216);
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
												flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24212) != 0);
											}
											if (flag)
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
												for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24224); j < c550d77bb22e33e00192bef4dea6cd65b.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24228))
												{
													if (c09e27dcc49b68f3f1fc0144051166706.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872, j).c01f5bd909cf249efea5f261060593de7 == num)
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
														if (c09e27dcc49b68f3f1fc0144051166706.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872, j).c0c5cb1cb9f1e58245e93f42d3efac96f == num2)
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
															result = (double)cf0bd4f4b5cfa9b23bd5b763a903c4336.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c09e27dcc49b68f3f1fc0144051166706.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872, j).cde5dacab992100e51d54413498f48ab6, num3, num4) / c09e27dcc49b68f3f1fc0144051166706.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872, j).cf918ac3448a7abfcc6e154ee95f8f8ff;
															return result;
														}
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
											}
											goto IL_23C;
										}
									}
								}
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									goto IL_119;
								}
							}
						}
						result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24188);
						return result;
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
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24172);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				double result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24232);
				return result;
			}
			IL_23C:
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24240);
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0006CBAC File Offset: 0x0006ADAC
		internal double c5e65d0e07e462745b38767d763554dca(int num, int num2, double num3, double num4)
		{
			double result;
			try
			{
				double num5 = num3 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24248);
				double num6 = num4 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24256);
				int num7 = num;
				int num8 = num2;
				int num9 = (int)num5;
				int num10 = (int)num6;
				int num11 = num9;
				int num12 = num10;
				int num13 = num9 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24264);
				int num14 = num10 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24268);
				double num15 = num5 - (double)num9;
				double num16 = num6 - (double)num10;
				double num17 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24272);
				double num18 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24280);
				double num19 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24288);
				double num20 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24296);
				if (num11 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24304))
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
						RuntimeMethodHandle arg_B7_0 = methodof(c98baf1f37c8505f021dc812520d0af75.c5e65d0e07e462745b38767d763554dca(int, int, double, double)).MethodHandle;
					}
					num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24308);
					num11 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24312);
				}
				if (num12 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24316))
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
					num8 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24320);
					num12 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24324);
				}
				num17 = this.c4bd79c4eee1f710a5baab5851951f9ac(num7, num8, num11, num12);
				num7 = num;
				num8 = num2;
				num12 = num10;
				num13 = num9 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24328);
				num14 = num10 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24332);
				if (num13 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24336))
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
					num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24340);
					num13 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24344);
				}
				if (num12 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24348))
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
					num8 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24352);
					num12 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24356);
				}
				num18 = this.c4bd79c4eee1f710a5baab5851951f9ac(num7, num8, num13, num12);
				num7 = num;
				num8 = num2;
				num11 = num9;
				num13 = num9 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24360);
				num14 = num10 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24364);
				if (num11 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24368))
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
					num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24372);
					num11 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24376);
				}
				if (num14 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24380))
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
					num8 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24384);
					num14 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24388);
				}
				num19 = this.c4bd79c4eee1f710a5baab5851951f9ac(num7, num8, num11, num14);
				num7 = num;
				num8 = num2;
				num13 = num9 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24392);
				num14 = num10 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24396);
				if (num13 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24400))
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
					num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24404);
					num13 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24408);
				}
				if (num14 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24412))
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
					num8 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24416);
					num14 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24420);
				}
				num20 = this.c4bd79c4eee1f710a5baab5851951f9ac(num7, num8, num13, num14);
				double num21 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24424);
				if (num15 + num16 < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24432))
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
					num21 = num17;
					num21 += (num18 - num17) * num15;
					num21 += (num19 - num17) * num16;
				}
				else
				{
					num21 = num20;
					num21 += (num18 - num20) * (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24440) - num16);
					num21 += (num19 - num20) * (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24448) - num15);
				}
				result = num21;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24456);
			}
			return result;
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0006CF80 File Offset: 0x0006B180
		private string cedb7dc066481dba6ce06ac57d60e9973(XAttribute xAttribute)
		{
			if (xAttribute == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c98baf1f37c8505f021dc812520d0af75.cedb7dc066481dba6ce06ac57d60e9973(XAttribute)).MethodHandle;
				}
				return string.Empty;
			}
			return cd5d7393ab0dc290fe1642ec029c175ac.c30767ddca1f9c207888833aea5b5fc61(xAttribute);
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0006CFB4 File Offset: 0x0006B1B4
		public byte[] c7eebb32e6cbd79b0e9184596a53db657(string text)
		{
			return cfbf33bd49a154b467c72e7cd1689ae03.c30767ddca1f9c207888833aea5b5fc61(this.c2dd581ae45fb30a049578f61a9ce5b2d, text);
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0006CFD0 File Offset: 0x0006B1D0
		public MemoryStream c5bd28cd0ec44dbfdf761bcb50cbc52db(string text)
		{
			return c83b68828ffed0499b11deecf4ddc11de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfbf33bd49a154b467c72e7cd1689ae03.c30767ddca1f9c207888833aea5b5fc61(this.c2dd581ae45fb30a049578f61a9ce5b2d, text));
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0006CFF4 File Offset: 0x0006B1F4
		public static byte[] c590719b4891bc3c253149a7c147539a8(Stream stream)
		{
			cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(stream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24464));
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24468));
			MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			byte[] result;
			try
			{
				int num;
				while ((num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(stream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24476), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24480))
				{
					c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(memoryStream, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24472), num);
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
					RuntimeMethodHandle arg_7B_0 = methodof(c98baf1f37c8505f021dc812520d0af75.c590719b4891bc3c253149a7c147539a8(Stream)).MethodHandle;
				}
				result = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
			}
			finally
			{
				if (memoryStream != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
				}
			}
			return result;
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0006D0B0 File Offset: 0x0006B2B0
		internal bool c295b089019bed10e63ae6313c6d47343(int num, int num2)
		{
			try
			{
				string text;
				if (num < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24484))
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
						RuntimeMethodHandle arg_1F_0 = methodof(c98baf1f37c8505f021dc812520d0af75.c295b089019bed10e63ae6313c6d47343(int, int)).MethodHandle;
					}
					text = cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121794), num);
				}
				else
				{
					text = cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138673), num);
				}
				string text2;
				if (num2 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24488))
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
					text2 = cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121794), num2);
				}
				else
				{
					text2 = cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138673), num2);
				}
				int num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24492);
				string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24496));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24500)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166165);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24504)] = text;
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24508)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166262);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24512)] = text2;
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24516)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166265);
				byte[] array2 = this.c7eebb32e6cbd79b0e9184596a53db657(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array));
				if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24520))
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
					ZipFile zipFile = c481de7d699d76aa6e3fb3789df9a1ef9.c8a754f5f2ca4adde825691a9c31a0e83;
					MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					try
					{
						zipFile = c7518cddb6b634ef47476b352abf7467f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c83b68828ffed0499b11deecf4ddc11de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2));
						byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24524));
						Stream stream = cfa9a1bea8a1478847925079f95a15bdf.c30767ddca1f9c207888833aea5b5fc61(zipFile, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24528));
						cced4f6414919f813e38fe5c1bbc24b73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(stream, memoryStream, array3);
					}
					finally
					{
						if (zipFile != null)
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
							c602ca2a11af0f67fdcf77633c77fe70e.c30767ddca1f9c207888833aea5b5fc61(zipFile, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24532) != 0);
							c6cad1982250434e70110070d0e8b8699.c30767ddca1f9c207888833aea5b5fc61(zipFile);
						}
					}
					byte[] array4 = c98baf1f37c8505f021dc812520d0af75.c590719b4891bc3c253149a7c147539a8(memoryStream);
					XDocument xDocument = c203d08dd7dff1ab79e06c51a74ec193c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb104ab32545b9a4f3a225d48cc06ba69.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array4));
					if (c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument) != null)
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
						IEnumerable<XNode> expr_224 = c3704b0459e1c05a34afd55f43805053b.c30767ddca1f9c207888833aea5b5fc61(c36e6bb54474f5a07cce73d5594e7796b.c30767ddca1f9c207888833aea5b5fc61(xDocument));
						if (c98baf1f37c8505f021dc812520d0af75.c4a4798b2465a7e03d4b880040d4129e1 == null)
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
							c98baf1f37c8505f021dc812520d0af75.c4a4798b2465a7e03d4b880040d4129e1 = new Func<XNode, XNode>(c98baf1f37c8505f021dc812520d0af75.c20f21336ad23a57989ebcef0436e9898);
						}
						IEnumerable<XNode> enumerable = expr_224.Select(c98baf1f37c8505f021dc812520d0af75.c4a4798b2465a7e03d4b880040d4129e1);
						IEnumerator<XNode> enumerator = c8ea7a6bffc7e58d721e35ef8f319195f.c30767ddca1f9c207888833aea5b5fc61(enumerable);
						try
						{
							while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
							{
								XNode xNode = cc82f8c5574732038b66b126bac815325.c30767ddca1f9c207888833aea5b5fc61(enumerator);
								XElement xElement = c032508c7c99ab8cd925db82ebf3efd5b.c9963fcf210a214a3206d6500f3b9397b(xNode);
								IEnumerable<XAttribute> expr_283 = cbe3891a7b189d8144b3f6a058dd5065b.c30767ddca1f9c207888833aea5b5fc61(xElement);
								if (c98baf1f37c8505f021dc812520d0af75.cd0ce29ba73b6785d27b07f3236ade229 == null)
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
									c98baf1f37c8505f021dc812520d0af75.cd0ce29ba73b6785d27b07f3236ade229 = new Func<XAttribute, XAttribute>(c98baf1f37c8505f021dc812520d0af75.c26643d880ca01b80db92342c472c563d);
								}
								IEnumerable<XAttribute> enumerable2 = expr_283.Select(c98baf1f37c8505f021dc812520d0af75.cd0ce29ba73b6785d27b07f3236ade229);
								IEnumerator<XAttribute> enumerator2 = cf0fca259b2b3f0bb8fbe15636b16ee7f.c30767ddca1f9c207888833aea5b5fc61(enumerable2);
								try
								{
									while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
									{
										XAttribute xAttribute = ce22a0331c6b91deeec28eef334ff0658.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
										if (cbf21f7f421a4b7271cb67c1df9173ec5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca88e7247adffec08eddbc40fe8b235c5.c30767ddca1f9c207888833aea5b5fc61(xAttribute), ced9412af9f666216565288b87e52f576.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166282))))
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
											c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd5d7393ab0dc290fe1642ec029c175ac.c30767ddca1f9c207888833aea5b5fc61(xAttribute), ref num3);
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
								}
								finally
								{
									if (enumerator2 != null)
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
										cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
									}
								}
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
							if (enumerator != null)
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
								cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							}
						}
					}
					cbbab5f2269bdc6ca72f760a43fe96b62.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
				}
				double num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24536) / ((double)num3 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24544));
				string[] array5 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24552));
				array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24556)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166319);
				array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24560)] = text;
				array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24564)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166262);
				array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24568)] = text2;
				array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24572)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166416);
				byte[] array6 = this.c7eebb32e6cbd79b0e9184596a53db657(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array5));
				bool result;
				if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array6) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24576))
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
					ZipFile zipFile2 = c481de7d699d76aa6e3fb3789df9a1ef9.c8a754f5f2ca4adde825691a9c31a0e83;
					MemoryStream memoryStream2 = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					try
					{
						zipFile2 = c7518cddb6b634ef47476b352abf7467f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c83b68828ffed0499b11deecf4ddc11de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array6));
						byte[] array7 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24580));
						Stream stream2 = cfa9a1bea8a1478847925079f95a15bdf.c30767ddca1f9c207888833aea5b5fc61(zipFile2, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24584));
						cced4f6414919f813e38fe5c1bbc24b73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(stream2, memoryStream2, array7);
					}
					finally
					{
						if (zipFile2 != null)
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
							c602ca2a11af0f67fdcf77633c77fe70e.c30767ddca1f9c207888833aea5b5fc61(zipFile2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24588) != 0);
							c6cad1982250434e70110070d0e8b8699.c30767ddca1f9c207888833aea5b5fc61(zipFile2);
						}
					}
					c98baf1f37c8505f021dc812520d0af75.ca2b71cc95f6cef4d4b465e05a4628c7e ca2b71cc95f6cef4d4b465e05a4628c7e = new c98baf1f37c8505f021dc812520d0af75.ca2b71cc95f6cef4d4b465e05a4628c7e();
					ca2b71cc95f6cef4d4b465e05a4628c7e.c01f5bd909cf249efea5f261060593de7 = num;
					ca2b71cc95f6cef4d4b465e05a4628c7e.c0c5cb1cb9f1e58245e93f42d3efac96f = num2;
					ca2b71cc95f6cef4d4b465e05a4628c7e.c397710716c3b8874db48d1cdd2e0e2df = num3;
					ca2b71cc95f6cef4d4b465e05a4628c7e.cf918ac3448a7abfcc6e154ee95f8f8ff = num4;
					cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(memoryStream2, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24592));
					BinaryReader binaryReader = cfac2195754625ad0ec56c780f8e3819e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(memoryStream2);
					c98baf1f37c8505f021dc812520d0af75.cfe9bce026ecdae2426ce239d7a9d16e6 cfe9bce026ecdae2426ce239d7a9d16e = default(c98baf1f37c8505f021dc812520d0af75.cfe9bce026ecdae2426ce239d7a9d16e6);
					List<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f> list = c98f034c35b37645e17325908f9d09206.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					cfe9bce026ecdae2426ce239d7a9d16e.cadd293276238eee2e48403ccc39109ea = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.c632ec60c3ddadfb6d53f1b750a0bb83b = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.c47d392c8bf5779b9cf0b12c439f9fac3 = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.cf773a0573df3e93abe9ce0200f79ba9a = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.c42dbfe81218dcad842b76f5f44653609 = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.ca822836475feb8fe69ef97ad9c05e1c7 = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.c64652cb84aafa0fa1d0701b0dff9de16 = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.c1ceb850d84947218e7fe943a6964c5d1 = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
					cfe9bce026ecdae2426ce239d7a9d16e.c9651f497c283969d221c4a485ae7ed28 = cabad7e3df3841c97f7c5aa47c5c3c2a1.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24596));
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24600); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24608); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24604))
					{
						cfe9bce026ecdae2426ce239d7a9d16e.c9651f497c283969d221c4a485ae7ed28[i] = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
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
					try
					{
						while (c2489d314f83872a0f087a9d9ad04d52c.c30767ddca1f9c207888833aea5b5fc61(ced6612bd4c7b9f338a556ad42d393e1a.c30767ddca1f9c207888833aea5b5fc61(binaryReader)) != c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(ced6612bd4c7b9f338a556ad42d393e1a.c30767ddca1f9c207888833aea5b5fc61(binaryReader)))
						{
							c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f c07df639a61b808411fb6ad7b1feb602f = new c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f();
							c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c07df639a61b808411fb6ad7b1feb602f.ca2a418584ab037e91a69eed38f8fbc34 = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c07df639a61b808411fb6ad7b1feb602f.cb2aca578c04d3a7d5f290c03b0fa72f9 = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c07df639a61b808411fb6ad7b1feb602f.c2e56130257501825953f9f91ada58ca5 = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c07df639a61b808411fb6ad7b1feb602f.c2fd9b81890a681af60edcd4d871aeaca = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c07df639a61b808411fb6ad7b1feb602f.c08da3373491724302570d635a0f22a90 = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c07df639a61b808411fb6ad7b1feb602f.cd9f9263f1200841a1076832acd5334e0 = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c9673d0dca919453510bdf0ddc6809155.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							c07df639a61b808411fb6ad7b1feb602f.cdc6aa1820fadc93cce6fdfb47135e535 = (double)(caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader) * c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(24612));
							c07df639a61b808411fb6ad7b1feb602f.c154ce6b58c33fff3a65032b5d27adc2b = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							uint num5 = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							int num6 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24616);
							while ((long)num6 < (long)((ulong)c07df639a61b808411fb6ad7b1feb602f.c154ce6b58c33fff3a65032b5d27adc2b))
							{
								int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24620);
								while ((long)num7 < (long)((ulong)c07df639a61b808411fb6ad7b1feb602f.c154ce6b58c33fff3a65032b5d27adc2b))
								{
									cd11190de655fcccc5d067931cf1d32b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c07df639a61b808411fb6ad7b1feb602f.cde5dacab992100e51d54413498f48ab6, num7, num6, c45ffa3c24436c7ba2ae8ef0641875ecb.c30767ddca1f9c207888833aea5b5fc61(binaryReader));
									num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24624);
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
								num6 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24628);
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
							if (c07df639a61b808411fb6ad7b1feb602f.c154ce6b58c33fff3a65032b5d27adc2b > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24632))
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
								c65bfed0229493cef60f739de7b9bebef.c30767ddca1f9c207888833aea5b5fc61(list, c07df639a61b808411fb6ad7b1feb602f);
							}
							c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
							float[] array8 = c54ceceb6ad141fcb2d96667414cdb1ba.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24636));
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24640); j < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24648); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24644))
							{
								array8[j] = caa551ad15bc5fe283a6d462d945cc225.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
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
							byte[] array9 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)((UIntPtr)num5));
							int num8 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24652);
							while ((long)num8 < (long)((ulong)num5))
							{
								array9[num8] = c9673d0dca919453510bdf0ddc6809155.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
								num8 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24656);
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
							uint[] array10 = cabad7e3df3841c97f7c5aa47c5c3c2a1.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24660));
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24664); k < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24672); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24668))
							{
								array10[k] = c3514e909204f4a7ce3be74a0d59950ff.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
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
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						IEnumerable<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f> arg_8B7_0 = list;
						if (c98baf1f37c8505f021dc812520d0af75.c483ce1f0f41b9d66ce5e0236e46a6be7 == null)
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
							c98baf1f37c8505f021dc812520d0af75.c483ce1f0f41b9d66ce5e0236e46a6be7 = new Func<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f, float>(c98baf1f37c8505f021dc812520d0af75.c2e0aa23f6114ffb414c7b0a60dbd1be0);
						}
						IOrderedEnumerable<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f> expr_8BC = arg_8B7_0.OrderBy(c98baf1f37c8505f021dc812520d0af75.c483ce1f0f41b9d66ce5e0236e46a6be7);
						if (c98baf1f37c8505f021dc812520d0af75.c4e0eb70c40be12e2c1900de571f128f7 == null)
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
							c98baf1f37c8505f021dc812520d0af75.c4e0eb70c40be12e2c1900de571f128f7 = new Func<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f, float>(c98baf1f37c8505f021dc812520d0af75.ca0b73317e737fbb90c0015c4f8d62b36);
						}
						list = expr_8BC.ThenBy(c98baf1f37c8505f021dc812520d0af75.c4e0eb70c40be12e2c1900de571f128f7).ToList<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f>();
						for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24676); l < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24936); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24932))
						{
							for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24680); m < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24928); m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24924))
							{
								for (int n = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24684); n < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24920); n += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24916))
								{
									for (int num9 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24688); num9 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24912); num9 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24908))
									{
										if (cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24692) + m).c154ce6b58c33fff3a65032b5d27adc2b != (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24696))
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
											double num10 = (cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24700) + m).c154ce6b58c33fff3a65032b5d27adc2b - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24704)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24708);
											int num11 = (int)(num10 * (double)n);
											int num12 = (int)(num10 * (double)num9);
											double num13 = num10 * (double)n - (double)num11;
											double num14 = num10 * (double)num9 - (double)num12;
											ushort num15 = cf0bd4f4b5cfa9b23bd5b763a903c4336.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24716) + m).cde5dacab992100e51d54413498f48ab6, num12, num11);
											ushort num16 = num15;
											ushort num17 = num15;
											ushort num18 = num15;
											if ((long)(num11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24720)) < (long)((ulong)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24724) + m).c154ce6b58c33fff3a65032b5d27adc2b))
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
												num16 = cf0bd4f4b5cfa9b23bd5b763a903c4336.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24728) + m).cde5dacab992100e51d54413498f48ab6, num12, num11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24732));
											}
											if ((long)(num12 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24736)) < (long)((ulong)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24740) + m).c154ce6b58c33fff3a65032b5d27adc2b))
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
												num17 = cf0bd4f4b5cfa9b23bd5b763a903c4336.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24744) + m).cde5dacab992100e51d54413498f48ab6, num12 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24748), num11);
											}
											if ((long)(num11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24752)) < (long)((ulong)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24756) + m).c154ce6b58c33fff3a65032b5d27adc2b))
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
												if ((long)(num12 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24760)) < (long)((ulong)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24764) + m).c154ce6b58c33fff3a65032b5d27adc2b))
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
													num18 = cf0bd4f4b5cfa9b23bd5b763a903c4336.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24768) + m).cde5dacab992100e51d54413498f48ab6, num12 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24772), num11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24776));
												}
											}
											double num19 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24780);
											if (num13 + num14 < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24788))
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
												num19 = (double)num15;
												num19 += (double)(num16 - num15) * num13;
												num19 += (double)(num17 - num15) * num14;
											}
											else
											{
												num19 = (double)num18;
												num19 += (double)(num16 - num18) * (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24796) - num14);
												num19 += (double)(num17 - num18) * (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24804) - num13);
											}
											ushort num20 = (ushort)num19;
											num20 = (ushort)((cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24812) + m).cdc6aa1820fadc93cce6fdfb47135e535 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24816) + (double)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24824) + m).c2e56130257501825953f9f91ada58ca5 - (double)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24828) + m).c2e56130257501825953f9f91ada58ca5) * num4 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24832) * (double)num20 + (double)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24840) + m).c2e56130257501825953f9f91ada58ca5 * num4);
											cd11190de655fcccc5d067931cf1d32b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca2b71cc95f6cef4d4b465e05a4628c7e.cde5dacab992100e51d54413498f48ab6, n + l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24844), num9 + m * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24848), num20);
										}
										else
										{
											double num21 = cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24852) + m).c154ce6b58c33fff3a65032b5d27adc2b / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24856);
											ushort num22 = cf0bd4f4b5cfa9b23bd5b763a903c4336.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24864) + m).cde5dacab992100e51d54413498f48ab6, (int)(num21 * (double)num9), (int)(num21 * (double)n));
											num22 = (ushort)((cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24868) + m).cdc6aa1820fadc93cce6fdfb47135e535 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24872) + (double)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24880) + m).c2e56130257501825953f9f91ada58ca5 - (double)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24884) + m).c2e56130257501825953f9f91ada58ca5) * num4 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(24888) * (double)num22 + (double)cfefec3950e904c3b6c50416a24086fa4.c30767ddca1f9c207888833aea5b5fc61(list, l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24896) + m).c2e56130257501825953f9f91ada58ca5 * num4);
											cd11190de655fcccc5d067931cf1d32b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca2b71cc95f6cef4d4b465e05a4628c7e.cde5dacab992100e51d54413498f48ab6, n + l * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24900), num9 + m * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24904), num22);
										}
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
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						c88d672c524f7125edf14396c2cf548d1.c30767ddca1f9c207888833aea5b5fc61(this.c539772140852dae7c433494e7c4ab872, ca2b71cc95f6cef4d4b465e05a4628c7e);
						cbbab5f2269bdc6ca72f760a43fe96b62.c30767ddca1f9c207888833aea5b5fc61(memoryStream2);
						cab3e10b630fc62f60a5d01256e871850.c30767ddca1f9c207888833aea5b5fc61(binaryReader);
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24940) != 0);
						return result;
					}
					catch (Exception ex)
					{
						c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
						goto IL_F33;
					}
					goto IL_F22;
					IL_F33:
					goto IL_FC3;
				}
				IL_F22:
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24944) != 0);
				return result;
			}
			catch (Exception ex2)
			{
				object[] array11 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24948));
				array11[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24952)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166433);
				array11[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24956)] = num;
				array11[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24960)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792);
				array11[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24964)] = num2;
				cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array11));
				cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
			}
			IL_FC3:
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24968) != 0;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0006E124 File Offset: 0x0006C324
		[CompilerGenerated]
		private static XNode c20f21336ad23a57989ebcef0436e9898(XNode result)
		{
			return result;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0006E134 File Offset: 0x0006C334
		[CompilerGenerated]
		private static XAttribute c26643d880ca01b80db92342c472c563d(XAttribute result)
		{
			return result;
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0006E144 File Offset: 0x0006C344
		[CompilerGenerated]
		private static float c2e0aa23f6114ffb414c7b0a60dbd1be0(c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f c07df639a61b808411fb6ad7b1feb602f)
		{
			return c07df639a61b808411fb6ad7b1feb602f.ca2a418584ab037e91a69eed38f8fbc34;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0006E158 File Offset: 0x0006C358
		[CompilerGenerated]
		private static float ca0b73317e737fbb90c0015c4f8d62b36(c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f c07df639a61b808411fb6ad7b1feb602f)
		{
			return c07df639a61b808411fb6ad7b1feb602f.cb2aca578c04d3a7d5f290c03b0fa72f9;
		}

		// Token: 0x0400067B RID: 1659
		private WebClient c2dd581ae45fb30a049578f61a9ce5b2d;

		// Token: 0x0400067C RID: 1660
		private List<c98baf1f37c8505f021dc812520d0af75.ca2b71cc95f6cef4d4b465e05a4628c7e> c539772140852dae7c433494e7c4ab872;

		// Token: 0x0400067D RID: 1661
		[CompilerGenerated]
		private static Func<XNode, XNode> c4a4798b2465a7e03d4b880040d4129e1;

		// Token: 0x0400067E RID: 1662
		[CompilerGenerated]
		private static Func<XAttribute, XAttribute> cd0ce29ba73b6785d27b07f3236ade229;

		// Token: 0x0400067F RID: 1663
		[CompilerGenerated]
		private static Func<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f, float> c483ce1f0f41b9d66ce5e0236e46a6be7;

		// Token: 0x04000680 RID: 1664
		[CompilerGenerated]
		private static Func<c98baf1f37c8505f021dc812520d0af75.c07df639a61b808411fb6ad7b1feb602f, float> c4e0eb70c40be12e2c1900de571f128f7;

		// Token: 0x02000137 RID: 311
		private struct cfe9bce026ecdae2426ce239d7a9d16e6
		{
			// Token: 0x04000681 RID: 1665
			public uint cadd293276238eee2e48403ccc39109ea;

			// Token: 0x04000682 RID: 1666
			public uint c632ec60c3ddadfb6d53f1b750a0bb83b;

			// Token: 0x04000683 RID: 1667
			public uint c47d392c8bf5779b9cf0b12c439f9fac3;

			// Token: 0x04000684 RID: 1668
			public uint cf773a0573df3e93abe9ce0200f79ba9a;

			// Token: 0x04000685 RID: 1669
			public uint c42dbfe81218dcad842b76f5f44653609;

			// Token: 0x04000686 RID: 1670
			public uint ca822836475feb8fe69ef97ad9c05e1c7;

			// Token: 0x04000687 RID: 1671
			public float c64652cb84aafa0fa1d0701b0dff9de16;

			// Token: 0x04000688 RID: 1672
			public float c1ceb850d84947218e7fe943a6964c5d1;

			// Token: 0x04000689 RID: 1673
			public uint[] c9651f497c283969d221c4a485ae7ed28;
		}

		// Token: 0x02000138 RID: 312
		private sealed class c07df639a61b808411fb6ad7b1feb602f
		{
			// Token: 0x06000B0C RID: 2828 RVA: 0x0006E16C File Offset: 0x0006C36C
			public c07df639a61b808411fb6ad7b1feb602f()
			{
				this.cde5dacab992100e51d54413498f48ab6 = new ushort[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24972), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24976)];
			}

			// Token: 0x0400068A RID: 1674
			public ushort[,] cde5dacab992100e51d54413498f48ab6;

			// Token: 0x0400068B RID: 1675
			public float ca2a418584ab037e91a69eed38f8fbc34;

			// Token: 0x0400068C RID: 1676
			public float cb2aca578c04d3a7d5f290c03b0fa72f9;

			// Token: 0x0400068D RID: 1677
			public float c2fd9b81890a681af60edcd4d871aeaca;

			// Token: 0x0400068E RID: 1678
			public float c08da3373491724302570d635a0f22a90;

			// Token: 0x0400068F RID: 1679
			public float cd9f9263f1200841a1076832acd5334e0;

			// Token: 0x04000690 RID: 1680
			public float c2e56130257501825953f9f91ada58ca5;

			// Token: 0x04000691 RID: 1681
			public double cdc6aa1820fadc93cce6fdfb47135e535;

			// Token: 0x04000692 RID: 1682
			public uint c154ce6b58c33fff3a65032b5d27adc2b;
		}

		// Token: 0x02000139 RID: 313
		private sealed class ca2b71cc95f6cef4d4b465e05a4628c7e
		{
			// Token: 0x06000B0D RID: 2829 RVA: 0x0006E1A0 File Offset: 0x0006C3A0
			public ca2b71cc95f6cef4d4b465e05a4628c7e()
			{
				this.cde5dacab992100e51d54413498f48ab6 = new ushort[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24980), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24984)];
			}

			// Token: 0x04000693 RID: 1683
			public int c01f5bd909cf249efea5f261060593de7;

			// Token: 0x04000694 RID: 1684
			public int c0c5cb1cb9f1e58245e93f42d3efac96f;

			// Token: 0x04000695 RID: 1685
			public int c397710716c3b8874db48d1cdd2e0e2df;

			// Token: 0x04000696 RID: 1686
			public double cf918ac3448a7abfcc6e154ee95f8f8ff;

			// Token: 0x04000697 RID: 1687
			public ushort[,] cde5dacab992100e51d54413498f48ab6;
		}
	}
}
