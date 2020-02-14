using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using ArcheBuddy;
using ArcheBuddy.Bot.Classes;
using ICSharpCode.SharpZipLib.Zip.Compression;

namespace A
{
	// Token: 0x02000073 RID: 115
	internal sealed class ce2273b18037425a98b6298f82c7a60d4
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00022A54 File Offset: 0x00020C54
		public ce2273b18037425a98b6298f82c7a60d4()
		{
			byte[] expr_28 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7788));
			c21512aadbc438e0c34236fbd1c52da3b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_28, fieldof(cecebbe15a82731eb2f8453f1b7665d70.c9d588f45f5afb9f889c41ca703ad5a93).FieldHandle);
			this.c47dc3a0f13384bdb971697c22b6b0dce = expr_28;
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7792));
			this.c192a70e6f34cd3af8217355928167acd = array;
			base..ctor();
			this.ce62827a7a529d6203b0c3addc89cb3c9 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7796));
			this.ce24591e2c428d42b939da42d322320b2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7800));
			this.cab67fc397bacec5b4a9e250ac92ec169 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7804));
			this.cb4f0837f50a1892690ece677ffb37154 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7808);
			this.c2c83eb25e15b37778119bb672a226b9e = new Inflater(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7812) != 0);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00022B24 File Offset: 0x00020D24
		internal void c6b2434d29371283846a5de37a7f8783c(byte[] array, bool flag = false)
		{
			try
			{
				ushort num = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5672);
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5676);
				if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5680))
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
						RuntimeMethodHandle arg_3A_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c6b2434d29371283846a5de37a7f8783c(byte[], bool)).MethodHandle;
					}
					b = array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5684)];
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5688))
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
						num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5692));
					}
					else
					{
						num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5696));
					}
				}
				else
				{
					num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5700));
				}
				byte[] array2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
				cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5704), array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5708), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
				bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5712) != 0;
				if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5716))
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
					if (!flag)
					{
						return;
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
					flag2 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5720) != 0);
					b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5724);
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5728)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5732);
					this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cdb173d910aba955ff8a5328f6a40894f = array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5736)];
				}
				if (c47774715547fa4d21d9ee2d6178cfb98.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51))
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
					if (cf8341a4434a0e70bba1373cee9cd19d6.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.ca687954b984e98f8b05817fdbc7b3e80(this.ca124a9f406cda69b904f2eb04d553ab9.c62a66d83e04d8e17c7822d0b73bef44b.cd5a845cc56523740cc6a8712be239372(array2, b, num, this.c68326be62adc96106ff21f9b228e0b16, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5740) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5744) != 0));
						if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5748))
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
							if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5752))
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
								if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
									string text = this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.ceff404c2f7909840fbd879360cdc99f8(num, (cee3fcb2d242b419d70276909e3146947)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5756));
									if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(22)))
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
										if (text != null)
										{
											goto IL_2A5;
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
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118599), cbac25a89355762298d86ae521b752b41.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118638)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118643), cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(array2)));
								}
							}
						}
						IL_2A5:
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c56d562e38c594389d24e3a3d8e87987c))
						{
							bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5760) != 0;
							if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5764))
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
								if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5768))
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
									if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
										if (num == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(29817)))
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
											flag3 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5772) != 0);
										}
									}
								}
							}
							if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5776))
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
								if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5780))
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
									if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
										if (num == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(27396)))
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
											flag3 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5784) != 0);
										}
									}
								}
							}
							if (flag2)
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
								if (flag3)
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
										if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
											int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5788);
											IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.cc6bae94a01c553d8e57ae84e540f6bcf(array2, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2), ref this.c6262a8a99f187e586b3b346f71acbdd1, ref this.cf394246474aecf5a8b1a98a19662b7c4, this.ca124a9f406cda69b904f2eb04d553ab9.c25707350e53809d65a8adce01953824b, (byte)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443, ref num2, this.c47dc3a0f13384bdb971697c22b6b0dce, this.c192a70e6f34cd3af8217355928167acd);
											array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num2);
											c57e4e9b98508f27ccf87d25f7471ed6b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5792), num2);
										}
									}
								}
							}
							if (flag3)
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
								cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5796), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5800));
							}
							goto IL_561;
						}
					}
				}
				cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5804), this.cab67fc397bacec5b4a9e250ac92ec169, this.cb4f0837f50a1892690ece677ffb37154, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
				this.cb4f0837f50a1892690ece677ffb37154 += (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array);
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118650));
				this.ca124a9f406cda69b904f2eb04d553ab9.ca687954b984e98f8b05817fdbc7b3e80(this.ca124a9f406cda69b904f2eb04d553ab9.c62a66d83e04d8e17c7822d0b73bef44b.cd5a845cc56523740cc6a8712be239372(array2, b, num, this.c68326be62adc96106ff21f9b228e0b16, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5808) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5812) != 0));
				IL_561:;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000230DC File Offset: 0x000212DC
		private double c5341234400d21ddc29ef95fd7322f2e5(double num, double num2, double num3, double num4, double num5, double num6)
		{
			return cdfe9014d02101a49c91049e7d709b638.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num - num4, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5816)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2 - num5, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5824)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num3 - num6, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5832)));
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00023138 File Offset: 0x00021338
		private bool c983ae19ded141cd05676e00a9f2a32a6(uint num, int num2, int num3, int num4)
		{
			if (AppMain.hideLibraryDoors)
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
					RuntimeMethodHandle arg_19_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c983ae19ded141cd05676e00a9f2a32a6(uint, int, int, int)).MethodHandle;
				}
				if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5840))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5844) != 0;
				}
			}
			double num5 = (double)num2 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5848);
			double num6 = (double)num3 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5856);
			double num7 = (double)num4 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5864) - c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5872);
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5880))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5884), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5892), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5900)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5908))
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
					if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5916), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5924), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5932)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5940))
					{
						goto IL_12D;
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
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5948) != 0;
			}
			IL_12D:
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5952))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5956), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5964), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5972)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5980))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5988) != 0;
				}
			}
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(5992))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(5996), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6004), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6012)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6020))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6028) != 0;
				}
			}
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6032))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6036), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6044), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6052)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6060))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6068) != 0;
				}
			}
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6072))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6076), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6084), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6092)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6100))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6108) != 0;
				}
			}
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6112))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6116), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6124), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6132)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6140))
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
					if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6148), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6156), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6164)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6172))
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
						if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6180), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6188), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6196)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6204))
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
							if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6212), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6220), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6228)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6236))
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
								if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6244), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6252), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6260)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6268))
								{
									goto IL_462;
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
							}
						}
					}
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6276) != 0;
			}
			IL_462:
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6280))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6284), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6292), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6300)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6308))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6316) != 0;
				}
			}
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6320))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6324), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6332), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6340)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6348))
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
					if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6356), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6364), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6372)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6380))
					{
						goto IL_57E;
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
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6388) != 0;
			}
			IL_57E:
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6392))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6396), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6404), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6412)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6420))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6428) != 0;
				}
			}
			if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6432))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6436), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6444), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6452)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6460))
				{
					goto IL_84B;
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6468), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6476), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6484)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6492))
				{
					goto IL_84B;
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6500), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6508), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6516)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6524))
				{
					goto IL_84B;
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6532), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6540), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6548)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6556))
				{
					goto IL_84B;
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6564), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6572), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6580)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6588))
				{
					goto IL_84B;
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6596), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6604), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6612)) < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6620))
				{
					goto IL_84B;
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
			if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6628), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6636), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6644)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6652))
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
				if (this.c5341234400d21ddc29ef95fd7322f2e5(num5, num6, num7, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6660), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6668), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6676)) >= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(6684))
				{
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6696) != 0;
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
			IL_84B:
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6692) != 0;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000239A8 File Offset: 0x00021BA8
		private void c31e3f50cd03f0e42d32349305658d47c(byte[] array)
		{
			try
			{
				ushort num = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6700);
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6704);
				if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6708))
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
						RuntimeMethodHandle arg_3D_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c31e3f50cd03f0e42d32349305658d47c(byte[])).MethodHandle;
					}
					b = array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6712)];
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6716))
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
						num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6720));
					}
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6724))
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
						num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6728));
					}
				}
				else
				{
					num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6732));
				}
				if (c47774715547fa4d21d9ee2d6178cfb98.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9))
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
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6736))
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
						byte[] array2 = c7d19159535b8ba95efe224e27f4d871a.c8a754f5f2ca4adde825691a9c31a0e83;
						try
						{
							cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6740), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6744));
							byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6748));
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6752), array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6756), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6760));
							array2 = this.ca809f6fcde4cf26241c3926f77f876c3(array3);
							ushort num2 = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6764);
							num2 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6768));
							byte[] array4 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6772), array4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6776), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
							while ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array4) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6832))
							{
								c156d13823d81cd4a7425f2cf5b6230f3 c156d13823d81cd4a7425f2cf5b6230f = this.ca124a9f406cda69b904f2eb04d553ab9.c62a66d83e04d8e17c7822d0b73bef44b.cd5a845cc56523740cc6a8712be239372(array4, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6780), num2, (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6784), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6788) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6792) != 0);
								if (c156d13823d81cd4a7425f2cf5b6230f != null)
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
									if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
										if (num2 == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(6435)))
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
											byte[] array5 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c156d13823d81cd4a7425f2cf5b6230f.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a());
											cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6796), array5, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6800), c156d13823d81cd4a7425f2cf5b6230f.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a());
											this.ca124a9f406cda69b904f2eb04d553ab9.ce35a64bb999e1b3c5b6bb3b89651e26b(this.ca124a9f406cda69b904f2eb04d553ab9.c62a66d83e04d8e17c7822d0b73bef44b.cd5a845cc56523740cc6a8712be239372(array5, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6804), num2, this.c68326be62adc96106ff21f9b228e0b16, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6808) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6812) != 0));
											if (c156d13823d81cd4a7425f2cf5b6230f.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a() < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array4))
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
												num2 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array4, c156d13823d81cd4a7425f2cf5b6230f.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a() + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6816));
												byte[] array6 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array4) - c156d13823d81cd4a7425f2cf5b6230f.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a());
												cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array4, c156d13823d81cd4a7425f2cf5b6230f.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a(), array6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6820), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array6));
												array4 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array6));
												cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6824), array4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6828), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array6));
												continue;
											}
											goto IL_413;
										}
									}
								}
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118727), cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(array2)));
								IL_413:
								goto IL_149A;
							}
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								goto IL_413;
							}
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex), cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(array2)));
							goto IL_149A;
						}
					}
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6836))
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
						bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6840) != 0;
						try
						{
							byte[] array7 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6844));
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6848), array7, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6852), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6856));
							byte[] array8 = c7d19159535b8ba95efe224e27f4d871a.c8a754f5f2ca4adde825691a9c31a0e83;
							try
							{
								array8 = ce2273b18037425a98b6298f82c7a60d4.cb2c609ef435cef3c61d85e55317f9335(array7);
								ushort num3 = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6860);
								num3 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array8, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6864));
								int num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6868);
								byte[] array9 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array8));
								cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array8, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6872), array9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6876), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array8));
								while ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array9) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7040))
								{
									c156d13823d81cd4a7425f2cf5b6230f3 c156d13823d81cd4a7425f2cf5b6230f2 = this.ca124a9f406cda69b904f2eb04d553ab9.c62a66d83e04d8e17c7822d0b73bef44b.cd5a845cc56523740cc6a8712be239372(array9, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6880), num3, (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6884), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6888) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6892) != 0);
									if (c156d13823d81cd4a7425f2cf5b6230f2 != null)
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
										if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
											if (num3 != this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(2544)))
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
												byte[] array10 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c156d13823d81cd4a7425f2cf5b6230f2.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a());
												cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6896), array10, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6900), c156d13823d81cd4a7425f2cf5b6230f2.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a());
												c156d13823d81cd4a7425f2cf5b6230f3 c156d13823d81cd4a7425f2cf5b6230f3 = this.ca124a9f406cda69b904f2eb04d553ab9.c62a66d83e04d8e17c7822d0b73bef44b.cd5a845cc56523740cc6a8712be239372(array10, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6904), num3, this.c68326be62adc96106ff21f9b228e0b16, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6908) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6912) != 0);
												if (num3 == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(11840)))
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
													c9f7959569216d390ea9833f6ad8e4b9d c9f7959569216d390ea9833f6ad8e4b9d = cb292a38d9871c74b2c5e2b4b9339f9a5.c9963fcf210a214a3206d6500f3b9397b(c156d13823d81cd4a7425f2cf5b6230f3);
													for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6916); i < (int)c9f7959569216d390ea9833f6ad8e4b9d.cb617f0dc25d7afaebd973bcc6b16faa9; i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6952))
													{
														if (this.c983ae19ded141cd05676e00a9f2a32a6(c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].cf58ff21c7366c3cd3f5603ba762bf21d, c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].c5ed806d2bb2197e7a4cc678385a2e6a1, c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].ce3da4123359df388eefe0c5b68072b14, c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].c15aa95c996f022a57045b8c635aa8e1e))
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
															array8[num4 + c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].c857567437b70f622159ed19a86f4cd7d] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6920);
															array8[num4 + c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6924)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6928);
															array8[num4 + c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6932)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6936);
															array8[num4 + c9f7959569216d390ea9833f6ad8e4b9d.c236f5af15cac248733f0a58fccbe502a[i].c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6940)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6944);
															flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6948) != 0);
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
												if (num3 == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(11628)))
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
													cf27f52c427c2f1299a80fbf195bb0688 cf27f52c427c2f1299a80fbf195bb = ccb98f5e2396c9cd78639d5432c703067.c9963fcf210a214a3206d6500f3b9397b(c156d13823d81cd4a7425f2cf5b6230f3);
													if (this.c983ae19ded141cd05676e00a9f2a32a6(cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.cf58ff21c7366c3cd3f5603ba762bf21d, cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.c5ed806d2bb2197e7a4cc678385a2e6a1, cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.ce3da4123359df388eefe0c5b68072b14, cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.c15aa95c996f022a57045b8c635aa8e1e))
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
														array8[num4 + cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6956);
														array8[num4 + cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6960)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6964);
														array8[num4 + cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6968)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6972);
														array8[num4 + cf27f52c427c2f1299a80fbf195bb.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6976)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6980);
														flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6984) != 0);
													}
												}
												this.ca124a9f406cda69b904f2eb04d553ab9.ce35a64bb999e1b3c5b6bb3b89651e26b(c156d13823d81cd4a7425f2cf5b6230f3);
												if (c156d13823d81cd4a7425f2cf5b6230f2.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a() < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array9))
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
													num4 += c156d13823d81cd4a7425f2cf5b6230f2.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a();
													num3 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array9, c156d13823d81cd4a7425f2cf5b6230f2.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a() + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6988));
													byte[] array11 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array9) - c156d13823d81cd4a7425f2cf5b6230f2.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a());
													cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array9, c156d13823d81cd4a7425f2cf5b6230f2.c1931c382e0fefaae84b9654d92e1461e.get_c77f4e29c6db6b64ea890a0795840d76a(), array11, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6992), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11));
													array9 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11));
													cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array11, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(6996), array9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7000), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array11));
													continue;
												}
												goto IL_AF3;
											}
										}
									}
									object[] array12 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7004));
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7008)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118727);
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7012)] = cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7016)] = cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(array8);
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7020)] = cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7024)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118804);
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7028)] = (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array);
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7032)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118823);
									array12[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7036)] = cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(array);
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array12));
									IL_AF3:
									goto IL_B1E;
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
							catch (Exception ex2)
							{
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2), cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(array8)));
							}
							IL_B1E:
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
								byte[] array13 = ce2273b18037425a98b6298f82c7a60d4.cdd99d9cfe6cac00a42443fc79ba0e19e(array8);
								ushort num5 = (ushort)((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array13) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7044));
								byte[] array14 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7048) + (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array13));
								cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array13, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7052), array14, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7056), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array13));
								cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7060), array14, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7064), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7068));
								array14[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7072)] = (byte)(num5 >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7076));
								array14[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7080)] = (byte)num5;
								cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array14, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7084), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array14), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7088));
							}
							else
							{
								cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7092), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7096));
							}
							goto IL_149A;
						}
						catch (Exception ex3)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex3));
							goto IL_149A;
						}
					}
					byte[] array15 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
					cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7100), array15, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7104), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
					bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7108) != 0;
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7112))
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
						if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
							array15 = this.ca124a9f406cda69b904f2eb04d553ab9.c48eeee108da295438c1d7f42f97b0f30(array);
							flag2 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7116) != 0);
							b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7120);
							num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array15, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7124));
						}
					}
					c156d13823d81cd4a7425f2cf5b6230f3 c156d13823d81cd4a7425f2cf5b6230f4 = this.ca124a9f406cda69b904f2eb04d553ab9.c62a66d83e04d8e17c7822d0b73bef44b.cd5a845cc56523740cc6a8712be239372(array15, b, num, this.c68326be62adc96106ff21f9b228e0b16, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7128) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7132) != 0);
					this.ca124a9f406cda69b904f2eb04d553ab9.ce35a64bb999e1b3c5b6bb3b89651e26b(c156d13823d81cd4a7425f2cf5b6230f4);
					if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7136))
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
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7140))
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
							if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
								string text = this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.ceff404c2f7909840fbd879360cdc99f8(num, (cee3fcb2d242b419d70276909e3146947)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7144));
								if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(22)))
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
									if (text != null)
									{
										goto IL_E33;
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
								}
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118828), cbac25a89355762298d86ae521b752b41.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118638)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118643), cc4987d6a853db77954f21abe4e42946a.c259f9807fcd8ed1942f1ae11922e4b13(array15)));
							}
						}
					}
					IL_E33:
					using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c7a5c891257b5bc7881a86e0b9fd10d7b))
					{
						if (num == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(11840)))
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
							c9f7959569216d390ea9833f6ad8e4b9d c9f7959569216d390ea9833f6ad8e4b9d2 = cb292a38d9871c74b2c5e2b4b9339f9a5.c9963fcf210a214a3206d6500f3b9397b(c156d13823d81cd4a7425f2cf5b6230f4);
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7148); j < (int)c9f7959569216d390ea9833f6ad8e4b9d2.cb617f0dc25d7afaebd973bcc6b16faa9; j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7180))
							{
								if (this.c983ae19ded141cd05676e00a9f2a32a6(c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].cf58ff21c7366c3cd3f5603ba762bf21d, c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].c5ed806d2bb2197e7a4cc678385a2e6a1, c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].ce3da4123359df388eefe0c5b68072b14, c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].c15aa95c996f022a57045b8c635aa8e1e))
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
									array15[c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].c857567437b70f622159ed19a86f4cd7d] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7152);
									array15[c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7156)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7160);
									array15[c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7164)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7168);
									array15[c9f7959569216d390ea9833f6ad8e4b9d2.c236f5af15cac248733f0a58fccbe502a[j].c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7172)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7176);
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
						else if (num == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(11628)))
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
							cf27f52c427c2f1299a80fbf195bb0688 cf27f52c427c2f1299a80fbf195bb2 = ccb98f5e2396c9cd78639d5432c703067.c9963fcf210a214a3206d6500f3b9397b(c156d13823d81cd4a7425f2cf5b6230f4);
							if (this.c983ae19ded141cd05676e00a9f2a32a6(cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.cf58ff21c7366c3cd3f5603ba762bf21d, cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.c5ed806d2bb2197e7a4cc678385a2e6a1, cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.ce3da4123359df388eefe0c5b68072b14, cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.c15aa95c996f022a57045b8c635aa8e1e))
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
								array15[cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7184);
								array15[cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7188)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7192);
								array15[cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7196)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7200);
								array15[cf27f52c427c2f1299a80fbf195bb2.c9a483ab5e5c03cd8901525a130c3282d.c857567437b70f622159ed19a86f4cd7d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7204)] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7208);
							}
						}
						if (flag2)
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
							if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
								array15[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7212)] = this.cb856fff54a9296ab4768adec7ad3b87d;
								array15[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7216)] = this.ca124a9f406cda69b904f2eb04d553ab9.c67c8ca81ef6c6c039e857a49ef7e0ada(array15, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7220));
								this.cb856fff54a9296ab4768adec7ad3b87d = (byte)((int)this.cb856fff54a9296ab4768adec7ad3b87d + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7224));
								array = this.ca124a9f406cda69b904f2eb04d553ab9.c46b2ab6f490fd5f3e4660f298450a886(array15);
							}
						}
						if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7228))
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
							cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7232), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7236));
						}
						else
						{
							if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7240))
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
								if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7244))
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
									if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
										if (num == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(11192)))
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
											if (!cfe50d767ea57042986511efc8e3eab3e.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)))
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
												cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7248), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7252));
												goto IL_1473;
											}
											this.cb856fff54a9296ab4768adec7ad3b87d = (byte)((int)this.cb856fff54a9296ab4768adec7ad3b87d - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7256));
											goto IL_1473;
										}
									}
									if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
										if (num == this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.c51a7ab6aca8a6a4e15619311f6c5c0df(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(9473)))
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
											cfac9f72c85501c518322ac01b3d50a18 cfac9f72c85501c518322ac01b3d50a = new cfac9f72c85501c518322ac01b3d50a18(array15, this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7260) != 0);
											bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7264) != 0;
											if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
												if (c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) != null)
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
													for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7268); k < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(AppMain.ca691be15ac02d2fd13604941dfb1f495.cc30738f39bcd1c48a5b6914207ea439a); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7284))
													{
														if (c37b4235599f9d92161031a1eac62fc9d.c30767ddca1f9c207888833aea5b5fc61(cfac9f72c85501c518322ac01b3d50a.c2997cf47688460d03e4dcf343cc9646f, AppMain.ca691be15ac02d2fd13604941dfb1f495.cc30738f39bcd1c48a5b6914207ea439a[k], (StringComparison)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7272)) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7276))
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
															flag3 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7280) != 0);
															goto IL_13C3;
														}
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
											}
											IL_13C3:
											if (flag3)
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
												cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7288), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7292));
												goto IL_1473;
											}
											this.cb856fff54a9296ab4768adec7ad3b87d = (byte)((int)this.cb856fff54a9296ab4768adec7ad3b87d - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7296));
											goto IL_1473;
										}
									}
									cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7300), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7304));
									goto IL_1473;
								}
							}
							cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7308), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7312));
						}
						IL_1473:
						goto IL_149A;
					}
				}
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118867));
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				IL_149A:;
			}
			catch
			{
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00024ED0 File Offset: 0x000230D0
		private byte[] ca809f6fcde4cf26241c3926f77f876c3(byte[] array)
		{
			MemoryStream memoryStream = c83b68828ffed0499b11deecf4ddc11de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
			byte[] result;
			try
			{
				MemoryStream memoryStream2 = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				try
				{
					byte[] array2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7316));
					byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7320));
					IL_EF:
					while (c2489d314f83872a0f087a9d9ad04d52c.c30767ddca1f9c207888833aea5b5fc61(memoryStream) < (long)((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array)))
					{
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(memoryStream, array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7324), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
						c8e0e027b31cd4ec82bb6d0805780c89e.c30767ddca1f9c207888833aea5b5fc61(this.c2c83eb25e15b37778119bb672a226b9e, array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7328), num);
						while (!c01fa6f4d64911276cdbff37e7081e1e3.c30767ddca1f9c207888833aea5b5fc61(this.c2c83eb25e15b37778119bb672a226b9e))
						{
							int num2 = ca50ebe8c5dc35f5d50ca78c7d73d3581.c30767ddca1f9c207888833aea5b5fc61(this.c2c83eb25e15b37778119bb672a226b9e, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7332), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
							if (num2 != 0)
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
									RuntimeMethodHandle arg_A9_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.ca809f6fcde4cf26241c3926f77f876c3(byte[])).MethodHandle;
								}
								c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(memoryStream2, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7336), num2);
							}
							else
							{
								IL_D6:
								if (c41ec1ff697b0e530aff73b33b28da04e.c30767ddca1f9c207888833aea5b5fc61(this.c2c83eb25e15b37778119bb672a226b9e))
								{
									goto IL_110;
								}
								while (true)
								{
									switch (5)
									{
									case 0:
										continue;
									}
									goto IL_EF;
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
							goto IL_D6;
						}
						IL_110:
						result = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(memoryStream2);
						return result;
					}
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						goto IL_110;
					}
				}
				finally
				{
					if (memoryStream2 != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream2);
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
			return result;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00025058 File Offset: 0x00023258
		internal static byte[] cb2c609ef435cef3c61d85e55317f9335(byte[] array)
		{
			Inflater inflater = cf329ce9819e6554584deb99a666723ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7340) != 0);
			MemoryStream memoryStream = c83b68828ffed0499b11deecf4ddc11de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
			byte[] result;
			try
			{
				MemoryStream memoryStream2 = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				try
				{
					byte[] array2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7344));
					byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7348));
					IL_F1:
					while (c2489d314f83872a0f087a9d9ad04d52c.c30767ddca1f9c207888833aea5b5fc61(memoryStream) < (long)((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array)))
					{
						int num = c4e399203bfbba5c85b0e837fc63618ec.c30767ddca1f9c207888833aea5b5fc61(memoryStream, array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7352), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
						c8e0e027b31cd4ec82bb6d0805780c89e.c30767ddca1f9c207888833aea5b5fc61(inflater, array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7356), num);
						while (!c01fa6f4d64911276cdbff37e7081e1e3.c30767ddca1f9c207888833aea5b5fc61(inflater))
						{
							int num2 = ca50ebe8c5dc35f5d50ca78c7d73d3581.c30767ddca1f9c207888833aea5b5fc61(inflater, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7360), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3));
							if (num2 != 0)
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
									RuntimeMethodHandle arg_B4_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.cb2c609ef435cef3c61d85e55317f9335(byte[])).MethodHandle;
								}
								c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(memoryStream2, array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7364), num2);
							}
							else
							{
								IL_DD:
								if (c41ec1ff697b0e530aff73b33b28da04e.c30767ddca1f9c207888833aea5b5fc61(inflater))
								{
									goto IL_112;
								}
								while (true)
								{
									switch (7)
									{
									case 0:
										continue;
									}
									goto IL_F1;
								}
							}
						}
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							goto IL_DD;
						}
						IL_112:
						cba526e943c668298c53cc4ed0df46085.c30767ddca1f9c207888833aea5b5fc61(inflater);
						result = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(memoryStream2);
						return result;
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						goto IL_112;
					}
				}
				finally
				{
					if (memoryStream2 != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream2);
					}
				}
			}
			finally
			{
				if (memoryStream != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
				}
			}
			return result;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000251E8 File Offset: 0x000233E8
		internal static byte[] cdd99d9cfe6cac00a42443fc79ba0e19e(byte[] array)
		{
			Deflater deflater = cdbffdbde5346d041dc5aa893f6ba9d8e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7368), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7372) != 0);
			cba33a0bf3ec6323c7cd02a9605165972.c30767ddca1f9c207888833aea5b5fc61(deflater, array);
			c3c6d8b521ddb9110c6c13f9057ffcf26.c30767ddca1f9c207888833aea5b5fc61(deflater);
			MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			byte[] result;
			try
			{
				byte[] array2 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7376));
				while (!ca0a8313889a0b925f66a0d7ad1e9f1eb.c30767ddca1f9c207888833aea5b5fc61(deflater))
				{
					int num = cfe256031495323fec6488b02b572c69a.c30767ddca1f9c207888833aea5b5fc61(deflater, array2);
					c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(memoryStream, array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7380), num);
					if (c30de7db990688050078b0392c6b79f6b.c30767ddca1f9c207888833aea5b5fc61(deflater))
					{
						IL_92:
						cf69b120f892320b9a1a269f82fe3f6d8.c30767ddca1f9c207888833aea5b5fc61(deflater);
						result = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
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
					if (!true)
					{
						RuntimeMethodHandle arg_7D_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.cdd99d9cfe6cac00a42443fc79ba0e19e(byte[])).MethodHandle;
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					goto IL_92;
				}
			}
			finally
			{
				if (memoryStream != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
				}
			}
			return result;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000252C0 File Offset: 0x000234C0
		internal void c43a910514984b239ba45a3a1a212b439()
		{
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(this.c3658f6041330f1160240f5709e7d6779)));
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(this.c4b33ba2cc9c2952d62e8a23c909d4fe9)));
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00025300 File Offset: 0x00023500
		private void c4a311f3b248e4567fab1dc57e38eaff0()
		{
			long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
			while (num + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7424) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
			{
				if (!this.c6750467b93b12242363b7e4afe9895f7)
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
						RuntimeMethodHandle arg_2A_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c4a311f3b248e4567fab1dc57e38eaff0()).MethodHandle;
					}
					if (c47774715547fa4d21d9ee2d6178cfb98.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9))
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
						if (cf8341a4434a0e70bba1373cee9cd19d6.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51))
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
							if (c47774715547fa4d21d9ee2d6178cfb98.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51))
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
								if (this.c9925b7e3d2d5a9f55e20eb9d66e48b84)
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
									try
									{
										if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7384))
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
											if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7388))
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
												if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7392))
												{
													if (this.c68326be62adc96106ff21f9b228e0b16 != c920c2912e29f42e690b5d188b10e15ce.c5d1f82e4a69c8c5b03513685e289c8d9)
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
														if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7408))
														{
															goto IL_1A2;
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
													c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7412), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(this.ce62827a7a529d6203b0c3addc89cb3c9), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7416), new AsyncCallback(this.cacae9a8affae472b7b999d352989a57f), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
													goto IL_1A2;
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
										}
										c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7396), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7400), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7404), new AsyncCallback(this.cad8146fc0d37c69e54ee97f437e81db0), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
										IL_1A2:;
									}
									catch
									{
									}
									return;
								}
							}
						}
					}
				}
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7420));
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

		// Token: 0x060001B0 RID: 432 RVA: 0x00025504 File Offset: 0x00023704
		private void c2fca309407b34741ddca708c0b0d3d13()
		{
			long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
			while (!this.c6750467b93b12242363b7e4afe9895f7)
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
				if (num + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7468) <= cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						return;
					}
				}
				else
				{
					if (cf8341a4434a0e70bba1373cee9cd19d6.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51))
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
							RuntimeMethodHandle arg_31_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c2fca309407b34741ddca708c0b0d3d13()).MethodHandle;
						}
						try
						{
							if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7428))
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
								if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7432))
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
									if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7436))
									{
										if (this.c68326be62adc96106ff21f9b228e0b16 != c920c2912e29f42e690b5d188b10e15ce.c5d1f82e4a69c8c5b03513685e289c8d9)
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
											if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7452))
											{
												goto IL_140;
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
										c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7456), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(this.ce24591e2c428d42b939da42d322320b2), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7460), new AsyncCallback(this.c74b2824162fb7d332006aa50af6748df), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
										goto IL_140;
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
							c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7440), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7444), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7448), new AsyncCallback(this.c0a037ec96c0324c49a9bed02317effec), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
							IL_140:;
						}
						catch
						{
						}
						return;
					}
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7464));
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000256B8 File Offset: 0x000238B8
		public void cacae9a8affae472b7b999d352989a57f(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7472);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, asyncResult);
				if (num == 0)
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
						RuntimeMethodHandle arg_2F_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.cacae9a8affae472b7b999d352989a57f(IAsyncResult)).MethodHandle;
					}
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			catch (Exception)
			{
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			try
			{
				cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7476), num, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7480));
				c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7484), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(this.ce62827a7a529d6203b0c3addc89cb3c9), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7488), new AsyncCallback(this.cacae9a8affae472b7b999d352989a57f), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118944), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
				this.c40c3ae6fb0c8718ec3856e7758595db4();
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000257C8 File Offset: 0x000239C8
		public void c74b2824162fb7d332006aa50af6748df(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7492);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, asyncResult);
				if (num == 0)
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
						RuntimeMethodHandle arg_2F_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c74b2824162fb7d332006aa50af6748df(IAsyncResult)).MethodHandle;
					}
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			catch (Exception)
			{
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			try
			{
				cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7496), num, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7500));
				c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7504), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(this.ce24591e2c428d42b939da42d322320b2), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7508), new AsyncCallback(this.c74b2824162fb7d332006aa50af6748df), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(118944), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
				this.c40c3ae6fb0c8718ec3856e7758595db4();
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000258D8 File Offset: 0x00023AD8
		public void cad8146fc0d37c69e54ee97f437e81db0(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7512);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, asyncResult);
				this.c6bab70b8125f6af8a7a3089cae33a5e1 += (ushort)num;
			}
			catch (Exception)
			{
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			if ((int)this.c6bab70b8125f6af8a7a3089cae33a5e1 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7516))
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
					RuntimeMethodHandle arg_5F_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.cad8146fc0d37c69e54ee97f437e81db0(IAsyncResult)).MethodHandle;
				}
				try
				{
					this.c4aa766a148d8699c681b84ca2c51a28a = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7520));
					this.c09689fc25739533f05afa6e0d105defb = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7524);
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7528), (int)this.c4aa766a148d8699c681b84ca2c51a28a, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7532), new AsyncCallback(this.c794ab55723eb40a6fc7f694533fa15d1), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35120), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			if ((int)this.c6bab70b8125f6af8a7a3089cae33a5e1 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7536))
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
				try
				{
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7540), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7544), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7548), new AsyncCallback(this.cad8146fc0d37c69e54ee97f437e81db0), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception ex2)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35120), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			if (num == 0)
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
				this.c40c3ae6fb0c8718ec3856e7758595db4();
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00025AA8 File Offset: 0x00023CA8
		public void c794ab55723eb40a6fc7f694533fa15d1(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7552);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, asyncResult);
				this.c09689fc25739533f05afa6e0d105defb += (ushort)num;
			}
			catch (Exception)
			{
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			if (this.c09689fc25739533f05afa6e0d105defb == this.c4aa766a148d8699c681b84ca2c51a28a)
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
					RuntimeMethodHandle arg_5B_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c794ab55723eb40a6fc7f694533fa15d1(IAsyncResult)).MethodHandle;
				}
				try
				{
					this.c6bab70b8125f6af8a7a3089cae33a5e1 = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7556);
					byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)this.c09689fc25739533f05afa6e0d105defb + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7560));
					cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7564), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7568), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
					if (cf4532cdecf10dac62616430e01818250.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == 0u)
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
						if (this.ca124a9f406cda69b904f2eb04d553ab9.c829c7209565df5f9063f3b57d042d9d8 == 0u)
						{
							goto IL_FA;
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
					if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
					{
						this.c6b2434d29371283846a5de37a7f8783c(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7580) != 0);
						goto IL_139;
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
					IL_FA:
					cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7572), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7576));
					IL_139:
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7584), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7588), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7592), new AsyncCallback(this.cad8146fc0d37c69e54ee97f437e81db0), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35993), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			if (num == 0)
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
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			try
			{
				c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7596) + (int)this.c09689fc25739533f05afa6e0d105defb, (int)(this.c4aa766a148d8699c681b84ca2c51a28a - this.c09689fc25739533f05afa6e0d105defb), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7600), new AsyncCallback(this.c794ab55723eb40a6fc7f694533fa15d1), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
			}
			catch (Exception ex2)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35993), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00025D38 File Offset: 0x00023F38
		public void c0a037ec96c0324c49a9bed02317effec(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7604);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, asyncResult);
				this.c8296bae3cfc2ef2e0a205e675ef34cde += (ushort)num;
			}
			catch (Exception)
			{
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			if ((int)this.c8296bae3cfc2ef2e0a205e675ef34cde == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7608))
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
					RuntimeMethodHandle arg_5F_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c0a037ec96c0324c49a9bed02317effec(IAsyncResult)).MethodHandle;
				}
				try
				{
					this.cba881740afe6683a116d8217127e7e80 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7612));
					this.c0ec7c1c8d725ccaee028bdf898084506 = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7616);
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7620), (int)this.cba881740afe6683a116d8217127e7e80, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7624), new AsyncCallback(this.cd632d3bc8c10e72b847961358a710b10), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35120), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			if ((int)this.c8296bae3cfc2ef2e0a205e675ef34cde == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7628))
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
				try
				{
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7632), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7636), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7640), new AsyncCallback(this.c0a037ec96c0324c49a9bed02317effec), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception ex2)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35120), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			if (num == 0)
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
				this.c40c3ae6fb0c8718ec3856e7758595db4();
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00025F08 File Offset: 0x00024108
		public void cd632d3bc8c10e72b847961358a710b10(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7644);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, asyncResult);
				this.c0ec7c1c8d725ccaee028bdf898084506 += (ushort)num;
			}
			catch (Exception)
			{
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			if (this.c0ec7c1c8d725ccaee028bdf898084506 == this.cba881740afe6683a116d8217127e7e80)
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
					RuntimeMethodHandle arg_5B_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.cd632d3bc8c10e72b847961358a710b10(IAsyncResult)).MethodHandle;
				}
				try
				{
					this.c8296bae3cfc2ef2e0a205e675ef34cde = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7648);
					byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)this.c0ec7c1c8d725ccaee028bdf898084506 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7652));
					cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7656), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7660), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
					if (cf4532cdecf10dac62616430e01818250.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == 0u)
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
						if (this.ca124a9f406cda69b904f2eb04d553ab9.c829c7209565df5f9063f3b57d042d9d8 == 0u)
						{
							goto IL_FA;
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
					}
					if (this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
					{
						this.c31e3f50cd03f0e42d32349305658d47c(array);
						goto IL_12F;
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
					IL_FA:
					cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7664), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7668));
					IL_12F:
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7672), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7676), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7680), new AsyncCallback(this.c0a037ec96c0324c49a9bed02317effec), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35351), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
					this.c40c3ae6fb0c8718ec3856e7758595db4();
					return;
				}
			}
			if (num == 0)
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
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
			try
			{
				c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, this.ce24591e2c428d42b939da42d322320b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7684) + (int)this.c0ec7c1c8d725ccaee028bdf898084506, (int)(this.cba881740afe6683a116d8217127e7e80 - this.c0ec7c1c8d725ccaee028bdf898084506), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7688), new AsyncCallback(this.cd632d3bc8c10e72b847961358a710b10), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
			}
			catch (Exception ex2)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35351), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
				this.c40c3ae6fb0c8718ec3856e7758595db4();
				return;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00026190 File Offset: 0x00024390
		internal void c40c3ae6fb0c8718ec3856e7758595db4()
		{
			if (this.c6750467b93b12242363b7e4afe9895f7)
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
					RuntimeMethodHandle arg_1A_0 = methodof(ce2273b18037425a98b6298f82c7a60d4.c40c3ae6fb0c8718ec3856e7758595db4()).MethodHandle;
				}
				return;
			}
			this.c6750467b93b12242363b7e4afe9895f7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7692) != 0);
			object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7696));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7700)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119021);
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7704)] = this.c322d8db8e16fc088c7def3e10c67f59d;
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7708)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7712)] = this.ca96b616148cfd62622c216532bda8fa8;
			cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array));
			if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7716))
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
				if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7720))
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
					if (this.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7724))
					{
						goto IL_17F;
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
			}
			object[] array2 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7728));
			array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7732)] = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(70558));
			array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7736)] = this.c322d8db8e16fc088c7def3e10c67f59d;
			array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7740)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
			array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7744)] = this.ca96b616148cfd62622c216532bda8fa8;
			cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2));
			try
			{
				IL_17F:
				c06acd1de5b9bd9dd5c62573b3618ebe1.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51, (SocketShutdown)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7748));
			}
			catch
			{
			}
			try
			{
				c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(this.cf75e98cf853fd7155fa03e958b4d2f51);
			}
			catch
			{
			}
			try
			{
				c06acd1de5b9bd9dd5c62573b3618ebe1.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9, (SocketShutdown)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7752));
			}
			catch
			{
			}
			try
			{
				c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(this.ceff49fbc891446de9ca39b0e1111edc9);
			}
			catch
			{
			}
			AppMain.cefaf2377ddae43302a659b50e17da74a.cfe50e8c3d4f67ae83b64a8c1b1aa6257(this);
			if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)))
				{
					c3ed21e26773d500f1e594cdc45aae925.c30767ddca1f9c207888833aea5b5fc61(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), this);
				}
				try
				{
					if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7756))
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
						if (!this.ca124a9f406cda69b904f2eb04d553ab9.c620fb7b8de910fd4b3080680f9c6ef1f)
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
							if (c177a686ad55f295d802bff78dbce3bcd.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7760))
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
								if (c944a27236c2efb01defe04ac32bbd0a6.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7764))))
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
									if (c490d30743924216b4140dc9e0668c03c.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)))
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
										if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd2981219d9304634dc490316aa4695c0.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7768))), ""))
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
											AppMain.cf90e986fccc09efa49b9af3c2b42eb24.c8025f5cbdb8e3f7cc9a20e987bf536cc(cd2981219d9304634dc490316aa4695c0.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7772))), c76f4323760dfa197639d83bafbcac26f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5ed5eb6cfb3fdbfb944a0f27e016d2a5.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7776)))));
										}
									}
								}
							}
						}
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7780); i < cfd30495e2c83c4fc92aab74de4947944.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.cb9213ffba9d183be8ba376e0677c9488); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7784))
						{
							this.ca124a9f406cda69b904f2eb04d553ab9.cd0e3f8519ed1acc5120006f861b7f440(cea543c08a3688c6aa98762252763bbc1.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.cb9213ffba9d183be8ba376e0677c9488, i));
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
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0002663C File Offset: 0x0002483C
		[CompilerGenerated]
		private void c3658f6041330f1160240f5709e7d6779()
		{
			this.c4a311f3b248e4567fab1dc57e38eaff0();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00026650 File Offset: 0x00024850
		[CompilerGenerated]
		private void c4b33ba2cc9c2952d62e8a23c909d4fe9()
		{
			this.c2fca309407b34741ddca708c0b0d3d13();
		}

		// Token: 0x0400016B RID: 363
		private byte[] ce62827a7a529d6203b0c3addc89cb3c9;

		// Token: 0x0400016C RID: 364
		public ushort c4aa766a148d8699c681b84ca2c51a28a;

		// Token: 0x0400016D RID: 365
		public ushort c09689fc25739533f05afa6e0d105defb;

		// Token: 0x0400016E RID: 366
		public ushort c6bab70b8125f6af8a7a3089cae33a5e1;

		// Token: 0x0400016F RID: 367
		internal int cb4f0837f50a1892690ece677ffb37154;

		// Token: 0x04000170 RID: 368
		internal byte[] cab67fc397bacec5b4a9e250ac92ec169;

		// Token: 0x04000171 RID: 369
		private byte[] ce24591e2c428d42b939da42d322320b2;

		// Token: 0x04000172 RID: 370
		public ushort cba881740afe6683a116d8217127e7e80;

		// Token: 0x04000173 RID: 371
		public ushort c0ec7c1c8d725ccaee028bdf898084506;

		// Token: 0x04000174 RID: 372
		public ushort c8296bae3cfc2ef2e0a205e675ef34cde;

		// Token: 0x04000175 RID: 373
		internal Socket ceff49fbc891446de9ca39b0e1111edc9;

		// Token: 0x04000176 RID: 374
		internal c7726724dac34cb3ce4268099f7ee4ca1 cf75e98cf853fd7155fa03e958b4d2f51;

		// Token: 0x04000177 RID: 375
		internal bool c9925b7e3d2d5a9f55e20eb9d66e48b84;

		// Token: 0x04000178 RID: 376
		internal ushort ca96b616148cfd62622c216532bda8fa8;

		// Token: 0x04000179 RID: 377
		internal string c322d8db8e16fc088c7def3e10c67f59d;

		// Token: 0x0400017A RID: 378
		internal byte cb856fff54a9296ab4768adec7ad3b87d;

		// Token: 0x0400017B RID: 379
		internal object c56d562e38c594389d24e3a3d8e87987c = new object();

		// Token: 0x0400017C RID: 380
		internal object c7a5c891257b5bc7881a86e0b9fd10d7b = new object();

		// Token: 0x0400017D RID: 381
		internal byte c6262a8a99f187e586b3b346f71acbdd1;

		// Token: 0x0400017E RID: 382
		internal uint cf394246474aecf5a8b1a98a19662b7c4;

		// Token: 0x0400017F RID: 383
		internal byte[] c47dc3a0f13384bdb971697c22b6b0dce;

		// Token: 0x04000180 RID: 384
		internal byte[] c192a70e6f34cd3af8217355928167acd;

		// Token: 0x04000181 RID: 385
		private bool c6750467b93b12242363b7e4afe9895f7;

		// Token: 0x04000182 RID: 386
		internal c920c2912e29f42e690b5d188b10e15ce c68326be62adc96106ff21f9b228e0b16;

		// Token: 0x04000183 RID: 387
		internal CoreInternal ca124a9f406cda69b904f2eb04d553ab9;

		// Token: 0x04000184 RID: 388
		private Inflater c2c83eb25e15b37778119bb672a226b9e;
	}
}
