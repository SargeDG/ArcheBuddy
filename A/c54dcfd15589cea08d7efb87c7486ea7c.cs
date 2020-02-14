using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using ArcheBuddy;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x0200055C RID: 1372
	internal sealed class c54dcfd15589cea08d7efb87c7486ea7c : c6bdd46ef9f05485f6b69f34bf6920a88
	{
		// Token: 0x06001EAE RID: 7854 RVA: 0x001356DC File Offset: 0x001338DC
		public c54dcfd15589cea08d7efb87c7486ea7c(CoreInternal coreInternal, string text) : base(coreInternal, text)
		{
			this.c99cc8d41a90783cea4e7845c839dcc98();
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94704), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94708) != 0);
			this.cf5edb3102b5e847917b6c6b02b64cf2f = new Font(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200389), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(94712), (FontStyle)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94716));
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0013575C File Offset: 0x0013395C
		private void cbb8ed322f87ea151cd27bda804d1318f(object obj, MouseEventArgs mouseEventArgs)
		{
			if (cf6e557dac7e4bcf41dfeb444ad6d7e6d.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs) == (MouseButtons)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93612))
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
					RuntimeMethodHandle arg_29_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.cbb8ed322f87ea151cd27bda804d1318f(object, MouseEventArgs)).MethodHandle;
				}
				int num = -cc9cf5c2a7a84876f073b374e67926f6e.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs);
				int num2 = -c45a096d3e1a00147ef841f0d197c79da.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs);
				if (obj != this)
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
					num -= c351bad3224715f8329782ad3b9e78480.c30767ddca1f9c207888833aea5b5fc61(c18ef82a2421279e61cbd21089bc8663f.c9963fcf210a214a3206d6500f3b9397b(obj));
					num2 -= cc500d7b0ca260f1917afec57791f981d.c30767ddca1f9c207888833aea5b5fc61(c18ef82a2421279e61cbd21089bc8663f.c9963fcf210a214a3206d6500f3b9397b(obj));
				}
				this.c8c5414b562ffc5f03d50cc6289b2da64 = new Point(num, num2);
				this.cb179921ce00edd86777a92673e025965 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93616) != 0);
				this.c3c189044840e0a7915e3524bd8332813 = cbdf42eccfa05c4923ac82fb235c5c177.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00135804 File Offset: 0x00133A04
		private void c80dbaf993981ae0b5531c78ff2f597ef(object obj, MouseEventArgs mouseEventArgs)
		{
			if (cf6e557dac7e4bcf41dfeb444ad6d7e6d.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs) == (MouseButtons)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93620))
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
					RuntimeMethodHandle arg_29_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c80dbaf993981ae0b5531c78ff2f597ef(object, MouseEventArgs)).MethodHandle;
				}
				this.cb179921ce00edd86777a92673e025965 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93624) != 0);
				c14a60d533efff2f5dd1357fed00fdcbd.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199288), this.cd4e069901d15225b536d61f3de2f799d, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199297)), c351bad3224715f8329782ad3b9e78480.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				c14a60d533efff2f5dd1357fed00fdcbd.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199288), this.cd4e069901d15225b536d61f3de2f799d, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199300)), cc500d7b0ca260f1917afec57791f981d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				c2f1d46695287fd958a385b8806e6c67f.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93628) != 0);
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x001358F0 File Offset: 0x00133AF0
		private void c52c27523398b9388ebea1a702656e4ce(object obj, MouseEventArgs mouseEventArgs)
		{
			if (this.cb179921ce00edd86777a92673e025965)
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
					RuntimeMethodHandle arg_1D_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c52c27523398b9388ebea1a702656e4ce(object, MouseEventArgs)).MethodHandle;
				}
				Point point = c9983dbc7d03c4ccdda9298c44a7e9540.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				Screen screen = c48e6a12427a318e9dd4e433531c4105d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(point);
				Rectangle rectangle = cc58cfbd2c0c08988f9ce20fce8995fb9.c30767ddca1f9c207888833aea5b5fc61(screen);
				if (!ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, point))
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
					int expr_5C = cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point);
					Rectangle rectangle2 = cc58cfbd2c0c08988f9ce20fce8995fb9.c30767ddca1f9c207888833aea5b5fc61(screen);
					int expr_6F = c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2);
					Rectangle rectangle3 = cc58cfbd2c0c08988f9ce20fce8995fb9.c30767ddca1f9c207888833aea5b5fc61(screen);
					c36e8176374c59a71dba35d79d2265998.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point, this.cbb50e54510dbc09e6fa5760666a8ce60(expr_5C, expr_6F, ca8fa466c259f42f0e9d6fa16f995efe7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle3)));
					int expr_9A = cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point);
					Rectangle rectangle4 = cc58cfbd2c0c08988f9ce20fce8995fb9.c30767ddca1f9c207888833aea5b5fc61(screen);
					int expr_AD = c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle4);
					Rectangle rectangle5 = cc58cfbd2c0c08988f9ce20fce8995fb9.c30767ddca1f9c207888833aea5b5fc61(screen);
					c36c1d8220370f74d68d2aa648693ab7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point, this.cbb50e54510dbc09e6fa5760666a8ce60(expr_9A, expr_AD, c65d1d2ff133320d2e1cce6cfa56a2e63.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle5)));
				}
				c1d9b5b8f3cd34c57b629677eff227ce3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point, cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c8c5414b562ffc5f03d50cc6289b2da64), cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c8c5414b562ffc5f03d50cc6289b2da64));
				c532c2dca3598bd5e266c994e8b2ff1f5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813, point);
				c36e8176374c59a71dba35d79d2265998.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, this.c75cf2c9b9ff80f4f01a7c93e922a4b11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93632));
				c36c1d8220370f74d68d2aa648693ab7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, this.c75cf2c9b9ff80f4f01a7c93e922a4b11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93636));
				this.c0244ea39de403a9dae460d5de243799d(cc58cfbd2c0c08988f9ce20fce8995fb9.c30767ddca1f9c207888833aea5b5fc61(screen), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93640) != 0);
				List<CoreInternal>.Enumerator enumerator = c3198a680416cc64e113da4c16f344b9f.c30767ddca1f9c207888833aea5b5fc61(cebf5cf86e0a97e0af962eaacad5c29f2.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
				try
				{
					while (cde96bb4edb6513000d41efb8b1f2cf3b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
					{
						CoreInternal coreInternal = c2e63f168cd07e56a4074a6bfc965abe3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
						List<c6bdd46ef9f05485f6b69f34bf6920a88>.Enumerator enumerator2 = c6db869dc720a296d6436877fc6038006.c30767ddca1f9c207888833aea5b5fc61(coreInternal.cb9213ffba9d183be8ba376e0677c9488);
						try
						{
							while (cc0c0e5206fa0bd9fbc48103d2a9d32b0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2))
							{
								c6bdd46ef9f05485f6b69f34bf6920a88 c6bdd46ef9f05485f6b69f34bf6920a = cf6234b09690116f4a2a0213e5bae23e8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2);
								if (c6bdd46ef9f05485f6b69f34bf6920a != this)
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
									this.c0244ea39de403a9dae460d5de243799d(cbdf42eccfa05c4923ac82fb235c5c177.c30767ddca1f9c207888833aea5b5fc61(c6bdd46ef9f05485f6b69f34bf6920a), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93644) != 0);
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
						finally
						{
							((IDisposable)enumerator2).Dispose();
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
					((IDisposable)enumerator).Dispose();
				}
				if (cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757) == this.c75cf2c9b9ff80f4f01a7c93e922a4b11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93648))
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
					c36e8176374c59a71dba35d79d2265998.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93652));
				}
				if (cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757) == this.c75cf2c9b9ff80f4f01a7c93e922a4b11 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93656))
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
					c36c1d8220370f74d68d2aa648693ab7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93660));
				}
				c1174d4411dcf34815d67e373b6e28b4f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813, this.c458fe22c85def03fa488ceebdd8e0757);
				cff3cb797806ebcce32747bf9816b8477.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.c3c189044840e0a7915e3524bd8332813);
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00135BA8 File Offset: 0x00133DA8
		private void c0244ea39de403a9dae460d5de243799d(Rectangle rectangle, bool flag)
		{
			if (c65d1d2ff133320d2e1cce6cfa56a2e63.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) >= c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - this.c75cf2c9b9ff80f4f01a7c93e922a4b11)
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
					RuntimeMethodHandle arg_34_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c0244ea39de403a9dae460d5de243799d(Rectangle, bool)).MethodHandle;
				}
				if (c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) <= c65d1d2ff133320d2e1cce6cfa56a2e63.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + this.c75cf2c9b9ff80f4f01a7c93e922a4b11)
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
					if (flag)
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
						if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - ca8fa466c259f42f0e9d6fa16f995efe7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
							c36e8176374c59a71dba35d79d2265998.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, ca8fa466c259f42f0e9d6fa16f995efe7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
						}
						if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) + c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
							c36e8176374c59a71dba35d79d2265998.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
						}
					}
					if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
						c36e8176374c59a71dba35d79d2265998.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
					}
					if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) + c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
						c36e8176374c59a71dba35d79d2265998.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
					}
				}
			}
			if (ca8fa466c259f42f0e9d6fa16f995efe7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) >= c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - this.c75cf2c9b9ff80f4f01a7c93e922a4b11)
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
				if (c6505df1a3fd1b5d4b962c8ce61feebd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) <= ca8fa466c259f42f0e9d6fa16f995efe7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + this.c75cf2c9b9ff80f4f01a7c93e922a4b11)
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
					if (flag)
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
						if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c65d1d2ff133320d2e1cce6cfa56a2e63.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
							if (flag)
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
								c36c1d8220370f74d68d2aa648693ab7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c65d1d2ff133320d2e1cce6cfa56a2e63.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
							}
						}
						if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) + c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
							if (flag)
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
								c36c1d8220370f74d68d2aa648693ab7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
							}
						}
					}
					if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
						c36c1d8220370f74d68d2aa648693ab7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
					}
					if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) + c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle)) <= c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757)))
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
						c36c1d8220370f74d68d2aa648693ab7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c458fe22c85def03fa488ceebdd8e0757, c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813) - c5549839a6fd667ecce32d10b63061ebc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c3c189044840e0a7915e3524bd8332813));
					}
				}
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00136040 File Offset: 0x00134240
		private int cbb50e54510dbc09e6fa5760666a8ce60(int num, int num2, int num3)
		{
			if (num <= num2)
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
					RuntimeMethodHandle arg_16_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.cbb50e54510dbc09e6fa5760666a8ce60(int, int, int)).MethodHandle;
				}
				return num2;
			}
			if (num >= num3)
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
				return num3;
			}
			return num;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00136078 File Offset: 0x00134278
		public override void c6aaa269d2096b01cd251b439ebc8a30b(string text)
		{
			try
			{
				base.c6aaa269d2096b01cd251b439ebc8a30b(text);
				XmlDocument xmlDocument = c9f82e4bb62a30adfeebbde96dfbe0d00.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				string text2 = "";
				StreamReader streamReader = cabd9e99d1a4d0fe8517fb0bb036174b1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text);
				try
				{
					text2 = c826b756047d7eec56cd86b5698fcdad2.c30767ddca1f9c207888833aea5b5fc61(streamReader);
				}
				finally
				{
					if (streamReader != null)
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
							RuntimeMethodHandle arg_3E_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c6aaa269d2096b01cd251b439ebc8a30b(string)).MethodHandle;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(streamReader);
					}
				}
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199303), "");
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199322), "");
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199329), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199344));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199377), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199394));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199417), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199432));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199465), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199482));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199505), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199518));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199549), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199564));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199585), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199604));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199641), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199662));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199689), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199718));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199765), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199796));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199833), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199864));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199913), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199946));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199985), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200006));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200045), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200068));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200097), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200116));
				text2 = cb3c26ef73772c06b34d67ef986bea5c2.c30767ddca1f9c207888833aea5b5fc61(text2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200153), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200174));
				ccb1bc1547a95f7cf279c560bd8c10f2e.c30767ddca1f9c207888833aea5b5fc61(xmlDocument, text2);
				if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(xmlDocument) == null)
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
					XmlElement xmlElement = c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(xmlDocument);
					string text3 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200201));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3, ""))
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
						cd2a376b66fd2a71880a1af1eeca07226.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c14c0f17babb92a1c6aa257769b5fe9a3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text3, c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb()));
					}
					string text4 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200216));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text4, ""))
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
						c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(this, c20089aee343859621a422147c9e74704.cc6a9c540a2ed5763275f32ba91c9e97b(c2d80901c7e2d859fd1e7f8071d4a2631.c30767ddca1f9c207888833aea5b5fc61(c87bd5f9deb1da3b3487ca0e0cd55c165.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3f89d031473e9835f49722bcf8b50b5c.c30767ddca1f9c207888833aea5b5fc61(this)), text4)));
					}
					string text5 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200235));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text5, ""))
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
						c00a0a8880cc403c0e7f6f0f080a622c6.c30767ddca1f9c207888833aea5b5fc61(this, c20089aee343859621a422147c9e74704.cc6a9c540a2ed5763275f32ba91c9e97b(c2d80901c7e2d859fd1e7f8071d4a2631.c30767ddca1f9c207888833aea5b5fc61(c87bd5f9deb1da3b3487ca0e0cd55c165.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbc53e7e13bfc180a6ff2d31b7b804378.c30767ddca1f9c207888833aea5b5fc61(this)), text5)));
					}
					string text6 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200254));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text6, ""))
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
						this.cf5edb3102b5e847917b6c6b02b64cf2f = caa8f8abfffd817a510f738dd1a1e927a.cea69e7c4d1a729bd5783221de1566e79(c2fe47102cb51d35b99db3bf83c3bb3a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c906d4be99aecc419eae88388f4910434.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), null, c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text6));
					}
					string text7 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200263));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text7, ""))
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
						object arg_463_0 = text7;
						char[] array = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93664));
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93668)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93672);
						string[] array2 = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_463_0, array);
						c3064eedb4468ff0cdd24e296fd6a43ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Size(c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93676)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93680)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb())));
					}
					bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93684) != 0;
					bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93688) != 0;
					bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93692) != 0;
					bool flag4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93696) != 0;
					bool flag5 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93700) != 0;
					string text8 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200272));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text8, ""))
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
						c0de76a5de42bab4d7e51d5ceb37bf3c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text8, ref flag);
					}
					string text9 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200297));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text9, ""))
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
						c0de76a5de42bab4d7e51d5ceb37bf3c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text9, ref flag2);
					}
					string text10 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200322));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text10, ""))
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
						c0de76a5de42bab4d7e51d5ceb37bf3c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text10, ref flag3);
					}
					string text11 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200347));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text11, ""))
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
						c0de76a5de42bab4d7e51d5ceb37bf3c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text11, ref flag4);
					}
					string text12 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200366));
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text12, ""))
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
						c0de76a5de42bab4d7e51d5ceb37bf3c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text12, ref flag5);
					}
					this.cfcf963d78e4d86bc8e79dd99361e64d9 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c82e483177d9e6cfcfa4bd296cd6b00e8.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.c4fd64b0e652a9d526a239f7c8660874a = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c36e46043aff8a54d9d4810b919adf6f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.cb75a81151b52709aacb67b9f2a45f0c2 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c143ddb88150dad679e4a567c4127fc29.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.c1ea99d8aa04c7d0b47865162f7e10bb0 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c8ab069e01925c3c4b3f8ca34cc28b055.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.cd43056a47e49717f580065b7a1704046 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c8355173fe4deb2c6db14fbfd3d6b541d.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.c3c0337d09f5a296f71a3424a155ecd30 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca7b84fe4906a340a8d2517df2f0cc502.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.c36f05f91e1d5566565206b8d2528365e = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb50f2c53b92e18a3832da938c5113e4b.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.c6cc5446bc2b1b068fc58fb7db3b327e5 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c94a58da32732f0e6cfbd908c2627e3db.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.c179c218866adc84baeadfa06c857a2c6 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca91b51bb4366fcab3f18325eabeefd62.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					this.c085dec529dabe69214ebd3da5f50de15();
					ccd41247b03e8b4bed610878a51518399.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new EventHandler(this.c5efbc7b2cb9ad7fe0a6290c0bda27cc1));
					c5e3e508c552725df2a17e7896ab055f2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.cbb8ed322f87ea151cd27bda804d1318f));
					cb1c098ec9d6709418039f720bd0378bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c52c27523398b9388ebea1a702656e4ce));
					cd25997f0a1375a46ae408c2a1098179f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c80dbaf993981ae0b5531c78ff2f597ef));
					ca40711f57158ad07727e6d307578f042 ca40711f57158ad07727e6d307578f = new ca40711f57158ad07727e6d307578f042(c0ff50e24ea3a71f4d9bb000d0847e1d7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c422c0ba63a251d277f724947f92a2871.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cab1e09e5e6537ab7b0362e0bdfb03d38.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cdb848bfecc0e068792a6bbf91a162c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f)));
					c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f)));
					c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93704) - c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f));
					c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93708));
					c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f, new MouseEventHandler(this.c6fa7ae2c118de2e4a5bbd4b2067457fb));
					cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f, new MouseEventHandler(this.c6fa7ae2c118de2e4a5bbd4b2067457fb));
					c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca40711f57158ad07727e6d307578f);
					cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f);
					int num = c351bad3224715f8329782ad3b9e78480.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f);
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
						c3c97afbc65912b49bda637249f073570 c3c97afbc65912b49bda637249f = new c3c97afbc65912b49bda637249f073570(c2172ca1fa6997dad8d8eca1e17af926e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c0eaaef3e037ad2d76ec71de9b71dcc6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c2172ca1fa6997dad8d8eca1e17af926e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), ce847919cd14184fee8effb6ca5e88ec9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c6468eaf68f0d5471cd271b2d6b65f42c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c0eaaef3e037ad2d76ec71de9b71dcc6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c6d309c45f7452ff4cf24c840c3fa28be.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c9303ba2de3557471fabffbb9e6d190a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f)));
						c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f)));
						c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f, num - c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93712));
						c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93716));
						c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f, new MouseEventHandler(this.c17183f256e26c9026e0b9f1c94597b2b));
						cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f, new MouseEventHandler(this.c17183f256e26c9026e0b9f1c94597b2b));
						c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c3c97afbc65912b49bda637249f);
						cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f);
						num = c351bad3224715f8329782ad3b9e78480.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f);
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
						ca40711f57158ad07727e6d307578f042 ca40711f57158ad07727e6d307578f2 = new ca40711f57158ad07727e6d307578f042(ce847919cd14184fee8effb6ca5e88ec9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c6468eaf68f0d5471cd271b2d6b65f42c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c0eaaef3e037ad2d76ec71de9b71dcc6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c190a91cc9176ca05631c140f6dc9632b.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2)));
						c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2)));
						c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2, num - c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93720));
						c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93724));
						c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2, new MouseEventHandler(this.c41d486199181cc261e0d3563b3ca3517));
						cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2, new MouseEventHandler(this.c41d486199181cc261e0d3563b3ca3517));
						c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca40711f57158ad07727e6d307578f2);
						cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2);
						num = c351bad3224715f8329782ad3b9e78480.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f2);
					}
					if (flag3)
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
						ca40711f57158ad07727e6d307578f042 ca40711f57158ad07727e6d307578f3 = new ca40711f57158ad07727e6d307578f042(ce847919cd14184fee8effb6ca5e88ec9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c6468eaf68f0d5471cd271b2d6b65f42c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c0eaaef3e037ad2d76ec71de9b71dcc6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), ca982705ad929aef55110a1e41407da62.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3)));
						c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3)));
						c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3, num - c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93728));
						c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93732));
						c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3, new MouseEventHandler(this.ce425ca254acb2c0748d06c3dd385c1e0));
						cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3, new MouseEventHandler(this.ce425ca254acb2c0748d06c3dd385c1e0));
						c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca40711f57158ad07727e6d307578f3);
						cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3);
						num = c351bad3224715f8329782ad3b9e78480.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f3);
					}
					if (flag4)
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
						ca40711f57158ad07727e6d307578f042 ca40711f57158ad07727e6d307578f4 = new ca40711f57158ad07727e6d307578f042(ce847919cd14184fee8effb6ca5e88ec9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c6468eaf68f0d5471cd271b2d6b65f42c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c0eaaef3e037ad2d76ec71de9b71dcc6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c060c4da3e9117168734f4faa248a4420.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4)));
						c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4)));
						c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4, num - c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93736));
						c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93740));
						c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4, new MouseEventHandler(this.cafe2d2f1bd0942bfeb0a2733aa5d6ab5));
						cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4, new MouseEventHandler(this.cafe2d2f1bd0942bfeb0a2733aa5d6ab5));
						c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca40711f57158ad07727e6d307578f4);
						cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4);
						num = c351bad3224715f8329782ad3b9e78480.c30767ddca1f9c207888833aea5b5fc61(ca40711f57158ad07727e6d307578f4);
					}
					if (flag5)
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
						c3c97afbc65912b49bda637249f073570 c3c97afbc65912b49bda637249f2 = new c3c97afbc65912b49bda637249f073570(c2172ca1fa6997dad8d8eca1e17af926e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c0eaaef3e037ad2d76ec71de9b71dcc6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c2172ca1fa6997dad8d8eca1e17af926e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), ce847919cd14184fee8effb6ca5e88ec9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c6468eaf68f0d5471cd271b2d6b65f42c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c0eaaef3e037ad2d76ec71de9b71dcc6c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cc160196b19ca5933d22a4b7e25145deb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cc160196b19ca5933d22a4b7e25145deb.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2)));
						c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2)));
						c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2, num - c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93744));
						c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93748));
						c3c97afbc65912b49bda637249f2.c3c4daeaab18f75ec4a7f9569abfb3812(c490d30743924216b4140dc9e0668c03c.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)));
						c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
						c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2, new MouseEventHandler(this.ca3987523fe5c630c95516ed8f08da42d));
						cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2, new MouseEventHandler(this.ca3987523fe5c630c95516ed8f08da42d));
						c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c3c97afbc65912b49bda637249f2);
						cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2);
						num = c351bad3224715f8329782ad3b9e78480.c30767ddca1f9c207888833aea5b5fc61(c3c97afbc65912b49bda637249f2);
					}
					this.c30f179f0ab09ef759665961d9fec82cd = ca6e587126d99e4befd586e4acc482275.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93752));
					c00a0a8880cc403c0e7f6f0f080a622c6.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, c21d5868d08c9e8b8ddd91f6b3afd5763.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93756), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93760), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93764)));
					c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93768));
					c1181f5b56ccc914dcfd9e398aef24d85.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93772) != 0);
					c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					c5e3e508c552725df2a17e7896ab055f2.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, new MouseEventHandler(this.cbb8ed322f87ea151cd27bda804d1318f));
					cb1c098ec9d6709418039f720bd0378bc.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, new MouseEventHandler(this.c52c27523398b9388ebea1a702656e4ce));
					cd25997f0a1375a46ae408c2a1098179f.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, new MouseEventHandler(this.c80dbaf993981ae0b5531c78ff2f597ef));
					c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, "");
					c48ae41fb9da6c75de61d7b5efe29dda4.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, cdaac64fdc1adce72e32c94d9503d2167.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200389), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(93776), (FontStyle)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93780)));
					c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), this.c30f179f0ab09ef759665961d9fec82cd);
					cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd);
					IEnumerator enumerator = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(xmlDocument)));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							XmlElement xmlElement2 = c1b0af8f7146d0456d3de8cdd833dcace.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator));
							if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlElement2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200402), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93784) != 0) == 0)
							{
								goto IL_E8E;
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
							if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlElement2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200429), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93788) != 0) == 0)
							{
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									goto IL_E8E;
								}
							}
							IL_1131:
							if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlElement2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200912), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93812) != 0) != 0)
							{
								continue;
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
							c3868c260cbcbd410f8d406152ebc69de c3868c260cbcbd410f8d406152ebc69de = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93816);
							c49a205a8d962eedc10d0ad1e8ae458d7 c49a205a8d962eedc10d0ad1e8ae458d = new c49a205a8d962eedc10d0ad1e8ae458d7();
							Control control = c3464c619452e93f87bc4ef75a5d2127d.c8a754f5f2ca4adde825691a9c31a0e83;
							string text13 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200927));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text13, ""))
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
								if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text13, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200936), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93820) != 0) == 0)
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
									control = new ccb03096c087e83e4a76df9ede18d50ed(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200949), c45c050550444f91eaa102a0f5f3964b4.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))), this.ca124a9f406cda69b904f2eb04d553ab9, this, c49a205a8d962eedc10d0ad1e8ae458d);
									c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da = control;
									c49a205a8d962eedc10d0ad1e8ae458d.c94adb236938861a7e3d6aa41b463a207 = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93824);
									c3868c260cbcbd410f8d406152ebc69de = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93828);
								}
								if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text13, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200962), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93832) != 0) == 0)
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
									control = new cccadf1bd3f3fd046f6781bd340f5c020(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200949), c45c050550444f91eaa102a0f5f3964b4.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))), this.ca124a9f406cda69b904f2eb04d553ab9, this);
									c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da = control;
									c49a205a8d962eedc10d0ad1e8ae458d.c94adb236938861a7e3d6aa41b463a207 = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93836);
									c3868c260cbcbd410f8d406152ebc69de = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93840);
								}
								if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text13, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200969), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93844) != 0) == 0)
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
									control = cfd64be547ead1c90780ca2b9fea68096.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(control, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
									c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da = control;
									c49a205a8d962eedc10d0ad1e8ae458d.c94adb236938861a7e3d6aa41b463a207 = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93848);
									c3868c260cbcbd410f8d406152ebc69de = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93852);
								}
							}
							string text14 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200982));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text14, ""))
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
								object obj = c2d80901c7e2d859fd1e7f8071d4a2631.c30767ddca1f9c207888833aea5b5fc61(c87bd5f9deb1da3b3487ca0e0cd55c165.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3f89d031473e9835f49722bcf8b50b5c.c30767ddca1f9c207888833aea5b5fc61(this)), text14);
								if (obj != null)
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
									c49a205a8d962eedc10d0ad1e8ae458d.c183c7527f3d2f16e014b2653a28f28bf = c20089aee343859621a422147c9e74704.cc6a9c540a2ed5763275f32ba91c9e97b(obj);
								}
								c49a205a8d962eedc10d0ad1e8ae458d.c847db3e0c8000d2e8c299776452bd50f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93856) != 0);
							}
							string text15 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201013));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text15, ""))
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
								object obj2 = c2d80901c7e2d859fd1e7f8071d4a2631.c30767ddca1f9c207888833aea5b5fc61(c87bd5f9deb1da3b3487ca0e0cd55c165.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3f89d031473e9835f49722bcf8b50b5c.c30767ddca1f9c207888833aea5b5fc61(this)), text15);
								if (obj2 != null)
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
									c49a205a8d962eedc10d0ad1e8ae458d.c40f949633d92c538693a28a2c1e4b04b = c20089aee343859621a422147c9e74704.cc6a9c540a2ed5763275f32ba91c9e97b(obj2);
								}
							}
							string text16 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201032));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text16, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(36724)))
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
								c49a205a8d962eedc10d0ad1e8ae458d.ccb7894a0d118692edc77b0a63e622b07 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93860) != 0);
								try
								{
									ca995b00ff29efcdc4c0002bd4d52919b.cea69e7c4d1a729bd5783221de1566e79(control).c46a0b5b2ada2a15babcf24b557cddde6();
								}
								catch
								{
								}
								try
								{
									c686cade0e370d76b3712c7486b1359e0.cea69e7c4d1a729bd5783221de1566e79(control).c46a0b5b2ada2a15babcf24b557cddde6();
								}
								catch
								{
								}
							}
							text7 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200263));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text7, ""))
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
								object arg_14E8_0 = text7;
								char[] array = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93864));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93868)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93872);
								string[] array3 = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_14E8_0, array);
								c43051ab26be2e9c460ed111b8bed8712.c30767ddca1f9c207888833aea5b5fc61(control, new Size(c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93876)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93880)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb())));
								c49a205a8d962eedc10d0ad1e8ae458d.cb5cc6fce1d5e448f1036e9fe27b02d90 = c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93884)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
								c49a205a8d962eedc10d0ad1e8ae458d.c15fbc486ff1db75d26e24a819e161fcd = c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93888)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
								c49a205a8d962eedc10d0ad1e8ae458d.c7638c303ac8d153fac42249270d9a295 = c49a205a8d962eedc10d0ad1e8ae458d.cb5cc6fce1d5e448f1036e9fe27b02d90 / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93892);
								if (c49a205a8d962eedc10d0ad1e8ae458d.c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93896))
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
									cec4dc845e772c3e699a057c528837cac.cac24a5ae511699bc10212b0ef953aef1(c1414876a177bda94ce1dab11328e1cb0.c30767ddca1f9c207888833aea5b5fc61(control), cec4dc845e772c3e699a057c528837cac.cecbe8b99e02bb7b9aa0b2fea312e6dbf(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93900), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93904), c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(control), ca2b5349dc1ed2819b0b204a14992cec0.c30767ddca1f9c207888833aea5b5fc61(control), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93908), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93912)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93916) != 0);
								}
							}
							string text17 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201059));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text17, ""))
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
								object arg_166B_0 = text17;
								char[] array = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93920));
								array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93924)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93928);
								string[] array4 = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_166B_0, array);
								cb763fdd7e20ce13abd0ad53996b806c7.c30767ddca1f9c207888833aea5b5fc61(control, new Point(c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93932)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c52ec833ef654aa96309a9bbde369310a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93936)], c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb())));
							}
							string text18 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153499));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text18, ""))
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
								c49a205a8d962eedc10d0ad1e8ae458d.c4133f594a82980efa774a1f80ec2e7d6 = text18;
							}
							string text19 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201066));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text19, ""))
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
								cff10e91f405c4a6edf6321236a76cf57.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c500a89699949e115c0f0e256b7c36177(c5a306d326b76dd39284beb71555f24fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text19));
							}
							string text20 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201079));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text20, ""))
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
								cff10e91f405c4a6edf6321236a76cf57.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).cb527ca759fe44554316019934585505f(c5a306d326b76dd39284beb71555f24fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text20));
							}
							string text21 = cd8ea3dcb508a361af9a0def212167f4c.c30767ddca1f9c207888833aea5b5fc61(xmlElement2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201090));
							if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text21, ""))
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
								cff10e91f405c4a6edf6321236a76cf57.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c2873a973fc476d44b68aec7455385ba4(c5a306d326b76dd39284beb71555f24fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text21));
							}
							IEnumerator enumerator2 = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(xmlElement2));
							try
							{
								while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
								{
									XmlElement xmlElement3 = c1b0af8f7146d0456d3de8cdd833dcace.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator2));
									if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlElement3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201111), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93940) != 0) == 0)
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
										c49a205a8d962eedc10d0ad1e8ae458d.c9f49c0f8031bd8d77090b6288b12e3af = c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlElement3);
									}
									if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlElement3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(163909), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93944) != 0) == 0)
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
										c49a205a8d962eedc10d0ad1e8ae458d.c520a716d720e4fa3864a395fc5f5449d = c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlElement3);
									}
									if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlElement3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201126), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93948) != 0) == 0)
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
										c49a205a8d962eedc10d0ad1e8ae458d.c2997cf47688460d03e4dcf343cc9646f = c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlElement3);
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
								IDisposable disposable = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator2);
								if (disposable != null)
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
									cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable);
								}
							}
							if (c3868c260cbcbd410f8d406152ebc69de == c3868c260cbcbd410f8d406152ebc69de.c5d1f82e4a69c8c5b03513685e289c8d9)
							{
								continue;
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
							bool flag6 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93952) != 0;
							string[] array5;
							if (c3868c260cbcbd410f8d406152ebc69de == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93956))
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
								if (c49a205a8d962eedc10d0ad1e8ae458d.c2997cf47688460d03e4dcf343cc9646f != null)
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
									if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c49a205a8d962eedc10d0ad1e8ae458d.c2997cf47688460d03e4dcf343cc9646f, ""))
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
										CodeDomProvider codeDomProvider = cdf8c06dcdb78dd244b4d649b61062021.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161096));
										CompilerParameters compilerParameters = c443fc667c056d6563379b053c75569af.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161109));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161130));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161161));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161229));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161258));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters), cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149342)));
										c5f7d6eb034b299ab30f1193f7c4fcede.c30767ddca1f9c207888833aea5b5fc61(compilerParameters, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161348));
										c267a3e70812cad9ecac69e1a5cb88b27.c30767ddca1f9c207888833aea5b5fc61(compilerParameters, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93960) != 0);
										string text22 = c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200454), c49a205a8d962eedc10d0ad1e8ae458d.c2997cf47688460d03e4dcf343cc9646f, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200828));
										object arg_1AC6_0 = codeDomProvider;
										CompilerParameters arg_1AC6_1 = compilerParameters;
										array5 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93964));
										array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93968)] = text22;
										CompilerResults compilerResults = c5e7c645060b7e65cedf0821b94475401.c30767ddca1f9c207888833aea5b5fc61(arg_1AC6_0, arg_1AC6_1, array5);
										try
										{
											c49a205a8d962eedc10d0ad1e8ae458d.c7255591bb4284c258315ca36f510bf4f = c2468513addba377280c3d6a66e5510f7.c30767ddca1f9c207888833aea5b5fc61(compilerResults);
											c49a205a8d962eedc10d0ad1e8ae458d.cbdf630d2c7f4ea70618744da07c506ad = c09c79b4052ce6ba73ed5c9a5c0b64ce3.c30767ddca1f9c207888833aea5b5fc61(c2468513addba377280c3d6a66e5510f7.c30767ddca1f9c207888833aea5b5fc61(compilerResults), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861));
											FieldInfo fieldInfo = c8b4a95b41d61ef932e4f044bbf757864.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(c49a205a8d962eedc10d0ad1e8ae458d.c7255591bb4284c258315ca36f510bf4f, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196862));
											c5d47a46a016d663f75ac2091c279674f.c30767ddca1f9c207888833aea5b5fc61(fieldInfo, c49a205a8d962eedc10d0ad1e8ae458d.cbdf630d2c7f4ea70618744da07c506ad, this.ca124a9f406cda69b904f2eb04d553ab9);
										}
										catch (Exception ex)
										{
											cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
										}
										if (ce72c5032da3fe6b4c206d48d9f6cb1d8.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults)))
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
											for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93972); i < c1ca823bb8ef8aa4e5e512508568be567.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93976))
											{
												cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c1087ea864419c8ba47e1d72ead8f1a2b.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults), i)));
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
								}
								if (c49a205a8d962eedc10d0ad1e8ae458d.c520a716d720e4fa3864a395fc5f5449d != null)
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
									if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c49a205a8d962eedc10d0ad1e8ae458d.c520a716d720e4fa3864a395fc5f5449d, ""))
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
										CodeDomProvider codeDomProvider2 = cdf8c06dcdb78dd244b4d649b61062021.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161096));
										CompilerParameters compilerParameters2 = c443fc667c056d6563379b053c75569af.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161109));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161130));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161161));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161229));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161258));
										c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2), cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149342)));
										c5f7d6eb034b299ab30f1193f7c4fcede.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161348));
										c267a3e70812cad9ecac69e1a5cb88b27.c30767ddca1f9c207888833aea5b5fc61(compilerParameters2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93980) != 0);
										string text23 = c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201135), c49a205a8d962eedc10d0ad1e8ae458d.c520a716d720e4fa3864a395fc5f5449d, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201513));
										object arg_1D5B_0 = codeDomProvider2;
										CompilerParameters arg_1D5B_1 = compilerParameters2;
										array5 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93984));
										array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93988)] = text23;
										CompilerResults compilerResults2 = c5e7c645060b7e65cedf0821b94475401.c30767ddca1f9c207888833aea5b5fc61(arg_1D5B_0, arg_1D5B_1, array5);
										try
										{
											c49a205a8d962eedc10d0ad1e8ae458d.c810c4cee02339a35f874033e0d16c270 = c2468513addba377280c3d6a66e5510f7.c30767ddca1f9c207888833aea5b5fc61(compilerResults2);
											c49a205a8d962eedc10d0ad1e8ae458d.c21f15184a9580869b800bd9d9151ca01 = c09c79b4052ce6ba73ed5c9a5c0b64ce3.c30767ddca1f9c207888833aea5b5fc61(c2468513addba377280c3d6a66e5510f7.c30767ddca1f9c207888833aea5b5fc61(compilerResults2), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861));
											FieldInfo fieldInfo2 = c8b4a95b41d61ef932e4f044bbf757864.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(c49a205a8d962eedc10d0ad1e8ae458d.c810c4cee02339a35f874033e0d16c270, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196862));
											c5d47a46a016d663f75ac2091c279674f.c30767ddca1f9c207888833aea5b5fc61(fieldInfo2, c49a205a8d962eedc10d0ad1e8ae458d.c21f15184a9580869b800bd9d9151ca01, this.ca124a9f406cda69b904f2eb04d553ab9);
										}
										catch (Exception ex2)
										{
											cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
										}
										if (ce72c5032da3fe6b4c206d48d9f6cb1d8.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults2)))
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
											for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93992); j < c1ca823bb8ef8aa4e5e512508568be567.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults2)); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93996))
											{
												cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c1087ea864419c8ba47e1d72ead8f1a2b.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults2), j)));
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
								}
							}
							if (flag6)
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
								c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), control);
								c9bac634601637552b3dcca2e60e3ec94.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, c49a205a8d962eedc10d0ad1e8ae458d);
								continue;
							}
							continue;
							IL_E8E:
							c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(this, c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlElement2));
							if (c479b9881540f92612803d53f2e7d39d0.c30767ddca1f9c207888833aea5b5fc61(this) == null)
							{
								goto IL_1131;
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
							if (!c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c479b9881540f92612803d53f2e7d39d0.c30767ddca1f9c207888833aea5b5fc61(this), ""))
							{
								goto IL_1131;
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
							CodeDomProvider codeDomProvider3 = cdf8c06dcdb78dd244b4d649b61062021.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161096));
							CompilerParameters compilerParameters3 = c443fc667c056d6563379b053c75569af.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161109));
							c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161130));
							c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161161));
							c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161229));
							c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161258));
							c7f4b84326d4c6424129fb11237b50272.c30767ddca1f9c207888833aea5b5fc61(c38a88d71adcdaba3bccf516e9a23ccd0.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3), cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(149342)));
							c5f7d6eb034b299ab30f1193f7c4fcede.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(161348));
							c267a3e70812cad9ecac69e1a5cb88b27.c30767ddca1f9c207888833aea5b5fc61(compilerParameters3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93792) != 0);
							string text24 = c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200454), c479b9881540f92612803d53f2e7d39d0.c30767ddca1f9c207888833aea5b5fc61(this), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200828));
							object arg_102D_0 = codeDomProvider3;
							CompilerParameters arg_102D_1 = compilerParameters3;
							array5 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93796));
							array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93800)] = text24;
							CompilerResults compilerResults3 = c5e7c645060b7e65cedf0821b94475401.c30767ddca1f9c207888833aea5b5fc61(arg_102D_0, arg_102D_1, array5);
							try
							{
								this.c7255591bb4284c258315ca36f510bf4f = c2468513addba377280c3d6a66e5510f7.c30767ddca1f9c207888833aea5b5fc61(compilerResults3);
								this.cbdf630d2c7f4ea70618744da07c506ad = c09c79b4052ce6ba73ed5c9a5c0b64ce3.c30767ddca1f9c207888833aea5b5fc61(c2468513addba377280c3d6a66e5510f7.c30767ddca1f9c207888833aea5b5fc61(compilerResults3), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861));
								FieldInfo fieldInfo3 = c8b4a95b41d61ef932e4f044bbf757864.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(this.c7255591bb4284c258315ca36f510bf4f, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196862));
								c5d47a46a016d663f75ac2091c279674f.c30767ddca1f9c207888833aea5b5fc61(fieldInfo3, this.cbdf630d2c7f4ea70618744da07c506ad, this.ca124a9f406cda69b904f2eb04d553ab9);
							}
							catch (Exception ex3)
							{
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex3));
							}
							if (!ce72c5032da3fe6b4c206d48d9f6cb1d8.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults3)))
							{
								goto IL_1131;
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
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93804); k < c1ca823bb8ef8aa4e5e512508568be567.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults3)); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93808))
							{
								cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c1087ea864419c8ba47e1d72ead8f1a2b.c30767ddca1f9c207888833aea5b5fc61(c5c53473e0a217f85d7660f9d62aac463.c30767ddca1f9c207888833aea5b5fc61(compilerResults3), k)));
							}
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								goto IL_1131;
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
					cec4dc845e772c3e699a057c528837cac.cac24a5ae511699bc10212b0ef953aef1(c1414876a177bda94ce1dab11328e1cb0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cec4dc845e772c3e699a057c528837cac.cecbe8b99e02bb7b9aa0b2fea312e6dbf(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94000), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94004), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94008), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94012)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94016) != 0);
					c191e536a5b4cc2c555931beda099e4fc.c30767ddca1f9c207888833aea5b5fc61(this.cd7a4d3b8444ed083ea87ee6de2a86248);
				}
			}
			catch (Exception ex4)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex4));
				cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(64993)));
			}
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x001380C0 File Offset: 0x001362C0
		private void c53b6d8b245c76ac324b2c35751ddfd49(object obj, MouseEventArgs mouseEventArgs)
		{
			c3c97afbc65912b49bda637249f073570 c3c97afbc65912b49bda637249f = c56f53106562254ce17267a6363b19def.c9963fcf210a214a3206d6500f3b9397b(obj);
			ce80a8f11a094afd0d5bf433721eb097d.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201524), c3c97afbc65912b49bda637249f.c4133f594a82980efa774a1f80ec2e7d6), c3c97afbc65912b49bda637249f.c597c92b18ba10a11c9e0bdc36e9238d9);
			c2f1d46695287fd958a385b8806e6c67f.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94020) != 0);
			this.ca124a9f406cda69b904f2eb04d553ab9.cfb682e4b708675aa7f37e33cdeea345b(c3c97afbc65912b49bda637249f.c4133f594a82980efa774a1f80ec2e7d6, c3c97afbc65912b49bda637249f.c597c92b18ba10a11c9e0bdc36e9238d9);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00138140 File Offset: 0x00136340
		private void ca7c23a9759e119e87b110c3329b0d095(c49a205a8d962eedc10d0ad1e8ae458d7 c49a205a8d962eedc10d0ad1e8ae458d)
		{
			try
			{
				if (c49a205a8d962eedc10d0ad1e8ae458d == null)
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
						RuntimeMethodHandle arg_15_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.ca7c23a9759e119e87b110c3329b0d095(c49a205a8d962eedc10d0ad1e8ae458d7)).MethodHandle;
					}
				}
				else
				{
					ca4f4f103955f0d59cd709641200185fc.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c5e16a22ce552ea42587b7f00b68f813a();
					ca4f4f103955f0d59cd709641200185fc.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).cf775278d656f9b5ea96f712328da8eb9();
					List<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073> list = c6d1b97639ee41059b16668b485f03a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94024); i < cdda965d097d78f56a084238cf236b10e.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94040))
					{
						if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, i).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94028))
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
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94032); j < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, i).c62e5e513abb5063974acc31b79637541); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94036))
							{
								c07cf9618017a455135befb129d695b99.c30767ddca1f9c207888833aea5b5fc61(list, cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, i).c62e5e513abb5063974acc31b79637541, j));
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
					object arg_134_0 = list;
					if (c54dcfd15589cea08d7efb87c7486ea7c.c3444fefa19358f4a5e6d401dacac9dc8 == null)
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
						c54dcfd15589cea08d7efb87c7486ea7c.c3444fefa19358f4a5e6d401dacac9dc8 = new Comparison<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073>(c54dcfd15589cea08d7efb87c7486ea7c.cd1a00367e88c4e4687911d8fbe8ad56f);
					}
					ccd55622ccb38c1e57335fd11cf3e197c.c30767ddca1f9c207888833aea5b5fc61(arg_134_0, c54dcfd15589cea08d7efb87c7486ea7c.c3444fefa19358f4a5e6d401dacac9dc8);
					List<c54dcfd15589cea08d7efb87c7486ea7c.c3918949819a5b6aaa54d7a4073954472> list2 = cc5f497bec7efa4a44bb23a3258ea9170.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94044);
					while (k < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(list))
					{
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c44ed1f0a62af7c5221be8a67d0f1514f)
						{
							goto IL_190;
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
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).ce6c00421af254c6db10d7dff44e28b07.c597c92b18ba10a11c9e0bdc36e9238d9)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								goto IL_190;
							}
						}
						IL_35B:
						k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94068);
						continue;
						IL_190:
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c44ed1f0a62af7c5221be8a67d0f1514f)
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
							if (!cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c51318d34047ba16be6801b9bc04f9e67.get_c597c92b18ba10a11c9e0bdc36e9238d9())
							{
								goto IL_35B;
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
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77 == null)
						{
							goto IL_35B;
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
						List<SpawnObject> list3 = c7abb1f50c668c71e1c8f2da342b828fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						MethodInfo methodInfo = c1de0a6423204725d1d8e4dab4ae56fd1.c8a754f5f2ca4adde825691a9c31a0e83;
						if (!c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c49a205a8d962eedc10d0ad1e8ae458d.c9f49c0f8031bd8d77090b6288b12e3af, ""))
						{
							goto IL_2D0;
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
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77 == null)
						{
							goto IL_2D0;
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
						methodInfo = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(c49a205a8d962eedc10d0ad1e8ae458d.c8afb385ec3cd6a1a272d6c8b598e450d, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201539));
						object arg_2BE_0 = methodInfo;
						object arg_2BE_1 = c49a205a8d962eedc10d0ad1e8ae458d.c070221483a03e30b41847ae8c9e91b73;
						object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94048));
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94052)] = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77;
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94056)] = this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0();
						list3 = c97090cb0a26f616e51b51e3e4ae571a8.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(arg_2BE_0, arg_2BE_1, array));
						IL_2FC:
						for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94060); l < c4414e47d4d649cc862e3e53cd6856853.c30767ddca1f9c207888833aea5b5fc61(list3); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94064))
						{
							c54dcfd15589cea08d7efb87c7486ea7c.c3918949819a5b6aaa54d7a4073954472 c3918949819a5b6aaa54d7a4073954472;
							c3918949819a5b6aaa54d7a4073954472.c60958cc55162377476d7d7bef4bae994 = c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(list3, l);
							c3918949819a5b6aaa54d7a4073954472.c6febd09dfe7f1b928b0a7c8c1def55b0 = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k);
							c3ebc3685f7955a812afbac7e2d80d02c.c30767ddca1f9c207888833aea5b5fc61(list2, c3918949819a5b6aaa54d7a4073954472);
						}
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							goto IL_35B;
						}
						IL_2D0:
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77 != null)
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
							list3 = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77;
							goto IL_2FC;
						}
						goto IL_2FC;
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
					ca4f4f103955f0d59cd709641200185fc.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c69a4717af9c85a10d23191eb2bdb02c0(cb6f13e0b3edc56d2dab894af58141844.c30767ddca1f9c207888833aea5b5fc61(list2));
					for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94072); m < cb6f13e0b3edc56d2dab894af58141844.c30767ddca1f9c207888833aea5b5fc61(list2); m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94076))
					{
						ca4f4f103955f0d59cd709641200185fc.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).cfa195f4dd59fd471e4e51d899d151dbe(c45ff7364634b5b525a35c588991fc1ec.c30767ddca1f9c207888833aea5b5fc61(list2, m).c60958cc55162377476d7d7bef4bae994, c45ff7364634b5b525a35c588991fc1ec.c30767ddca1f9c207888833aea5b5fc61(list2, m).c6febd09dfe7f1b928b0a7c8c1def55b0);
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
					ca4f4f103955f0d59cd709641200185fc.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c17e5273089bd594a7b1bbc60fa832361();
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201550), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
			}
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x001385A4 File Offset: 0x001367A4
		private void cbc3ec31260030cf796b908ec11301399(c49a205a8d962eedc10d0ad1e8ae458d7 c49a205a8d962eedc10d0ad1e8ae458d)
		{
			try
			{
				if (c49a205a8d962eedc10d0ad1e8ae458d == null)
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
						RuntimeMethodHandle arg_15_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.cbc3ec31260030cf796b908ec11301399(c49a205a8d962eedc10d0ad1e8ae458d7)).MethodHandle;
					}
				}
				else
				{
					ca995b00ff29efcdc4c0002bd4d52919b.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c5e16a22ce552ea42587b7f00b68f813a();
					ca995b00ff29efcdc4c0002bd4d52919b.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).cf775278d656f9b5ea96f712328da8eb9();
					List<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073> list = c6d1b97639ee41059b16668b485f03a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94080); i < cdda965d097d78f56a084238cf236b10e.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94096))
					{
						if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, i).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94084))
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
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94088); j < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, i).c62e5e513abb5063974acc31b79637541); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94092))
							{
								c07cf9618017a455135befb129d695b99.c30767ddca1f9c207888833aea5b5fc61(list, cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, i).c62e5e513abb5063974acc31b79637541, j));
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
					object arg_134_0 = list;
					if (c54dcfd15589cea08d7efb87c7486ea7c.cb221befa05b69c1af6798edd547ee3ac == null)
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
						c54dcfd15589cea08d7efb87c7486ea7c.cb221befa05b69c1af6798edd547ee3ac = new Comparison<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073>(c54dcfd15589cea08d7efb87c7486ea7c.cfb97c82c4751f837996554f42e22c0d2);
					}
					ccd55622ccb38c1e57335fd11cf3e197c.c30767ddca1f9c207888833aea5b5fc61(arg_134_0, c54dcfd15589cea08d7efb87c7486ea7c.cb221befa05b69c1af6798edd547ee3ac);
					int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94100);
					while (k < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(list))
					{
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c44ed1f0a62af7c5221be8a67d0f1514f)
						{
							goto IL_185;
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
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).ce6c00421af254c6db10d7dff44e28b07.c597c92b18ba10a11c9e0bdc36e9238d9)
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								goto IL_185;
							}
						}
						IL_3D7:
						k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94132);
						continue;
						IL_185:
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c44ed1f0a62af7c5221be8a67d0f1514f)
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
							if (!cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c51318d34047ba16be6801b9bc04f9e67.get_c597c92b18ba10a11c9e0bdc36e9238d9())
							{
								goto IL_3D7;
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
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77 == null)
						{
							goto IL_3D7;
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
						List<SpawnObject> list2 = c7abb1f50c668c71e1c8f2da342b828fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						MethodInfo methodInfo = c1de0a6423204725d1d8e4dab4ae56fd1.c8a754f5f2ca4adde825691a9c31a0e83;
						if (!c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c49a205a8d962eedc10d0ad1e8ae458d.c9f49c0f8031bd8d77090b6288b12e3af, ""))
						{
							goto IL_2C0;
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
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77 == null)
						{
							goto IL_2C0;
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
						methodInfo = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(c49a205a8d962eedc10d0ad1e8ae458d.c8afb385ec3cd6a1a272d6c8b598e450d, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201539));
						object arg_2AE_0 = methodInfo;
						object arg_2AE_1 = c49a205a8d962eedc10d0ad1e8ae458d.c070221483a03e30b41847ae8c9e91b73;
						object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94104));
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94108)] = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77;
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94112)] = this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0();
						list2 = c97090cb0a26f616e51b51e3e4ae571a8.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(arg_2AE_0, arg_2AE_1, array));
						IL_2EA:
						for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94116); l < c4414e47d4d649cc862e3e53cd6856853.c30767ddca1f9c207888833aea5b5fc61(list2); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94128))
						{
							bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94120) != 0;
							if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(list2, l)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94124))
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
								flag = ce46b1853bd52bf8adb56dc34a5cab677.cea69e7c4d1a729bd5783221de1566e79(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(list2, l)).cefcee864f727805ea140f2a57228015e;
							}
							ca995b00ff29efcdc4c0002bd4d52919b.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).cfa195f4dd59fd471e4e51d899d151dbe(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(list2, l), cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k), flag);
							if (c2409235dcdd3a0955b5d5c44853e591b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) == c2ddbe454b04d472c2b341c527f3d1e04.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(list2, l)))
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
								c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(list2, l);
							}
						}
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							goto IL_3D7;
						}
						IL_2C0:
						if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77 != null)
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
							list2 = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list, k).c93bc4c1e0a82610433d5389276a1ae77;
							goto IL_2EA;
						}
						goto IL_2EA;
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
					ca995b00ff29efcdc4c0002bd4d52919b.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c43b33c80aed8470d69fd335c69e35a6c();
					ca995b00ff29efcdc4c0002bd4d52919b.cea69e7c4d1a729bd5783221de1566e79(c49a205a8d962eedc10d0ad1e8ae458d.ca53c5b83901742f3960c4c2f6f8db8da).c17e5273089bd594a7b1bbc60fa832361();
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201627), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00138A14 File Offset: 0x00136C14
		private void c41d486199181cc261e0d3563b3ca3517(object obj, MouseEventArgs mouseEventArgs)
		{
			if (AppMain.c1a2627f895092b3cf57a9486ed72ee32 != null)
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
					RuntimeMethodHandle arg_1C_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c41d486199181cc261e0d3563b3ca3517(object, MouseEventArgs)).MethodHandle;
				}
				if (!ccb3a37e39f5cb9245628b004349eac73.c30767ddca1f9c207888833aea5b5fc61(AppMain.c1a2627f895092b3cf57a9486ed72ee32))
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
					cd42d36dd6f379099183ebe4983e29d89.c30767ddca1f9c207888833aea5b5fc61(AppMain.c1a2627f895092b3cf57a9486ed72ee32);
				}
				c87e60912a770e037fc3394d900687990.c30767ddca1f9c207888833aea5b5fc61(AppMain.c1a2627f895092b3cf57a9486ed72ee32);
				c50f016c3da50f8713e241c231dc5b6d9.c30767ddca1f9c207888833aea5b5fc61(AppMain.c1a2627f895092b3cf57a9486ed72ee32);
				cec4dc845e772c3e699a057c528837cac.c79b099664bdd394100d439c28a842382(cc407bb486a8d65f462b338876fc5c7cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce64323d058548d8fd92d9948f4c51dfa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c1a2627f895092b3cf57a9486ed72ee32)));
				if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ca124a9f406cda69b904f2eb04d553ab9.c9e60c04d8f9c06f98c7605c375d95674, ""))
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
						AppMain.c1a2627f895092b3cf57a9486ed72ee32.cb710af11132b60678101971150b2dfb7(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ca124a9f406cda69b904f2eb04d553ab9.c9e60c04d8f9c06f98c7605c375d95674, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358), this.ca124a9f406cda69b904f2eb04d553ab9.cfa90a3bdf33f49645acdaf139e821d39(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152310)));
					}
				}
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00138B0C File Offset: 0x00136D0C
		private void ce425ca254acb2c0748d06c3dd385c1e0(object obj, MouseEventArgs mouseEventArgs)
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00138B1C File Offset: 0x00136D1C
		private void ca3987523fe5c630c95516ed8f08da42d(object obj, MouseEventArgs mouseEventArgs)
		{
			if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.ca3987523fe5c630c95516ed8f08da42d(object, MouseEventArgs)).MethodHandle;
				}
				c59a8c740d0a3c61561108ecbbdc014f5.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), c4ef337c3311c047de500a91a27a92bbf.cea69e7c4d1a729bd5783221de1566e79(obj).c597c92b18ba10a11c9e0bdc36e9238d9);
			}
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00138B64 File Offset: 0x00136D64
		private void cafe2d2f1bd0942bfeb0a2733aa5d6ab5(object obj, MouseEventArgs mouseEventArgs)
		{
			if (AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8 != null)
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
					RuntimeMethodHandle arg_19_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.cafe2d2f1bd0942bfeb0a2733aa5d6ab5(object, MouseEventArgs)).MethodHandle;
				}
				if (!ccb3a37e39f5cb9245628b004349eac73.c30767ddca1f9c207888833aea5b5fc61(AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8))
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
					cd42d36dd6f379099183ebe4983e29d89.c30767ddca1f9c207888833aea5b5fc61(AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8);
				}
				c87e60912a770e037fc3394d900687990.c30767ddca1f9c207888833aea5b5fc61(AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8);
				c50f016c3da50f8713e241c231dc5b6d9.c30767ddca1f9c207888833aea5b5fc61(AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8);
				cec4dc845e772c3e699a057c528837cac.c79b099664bdd394100d439c28a842382(cc407bb486a8d65f462b338876fc5c7cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce64323d058548d8fd92d9948f4c51dfa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8)));
			}
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00138BE4 File Offset: 0x00136DE4
		private void c17183f256e26c9026e0b9f1c94597b2b(object obj, MouseEventArgs mouseEventArgs)
		{
			if (c4ef337c3311c047de500a91a27a92bbf.cea69e7c4d1a729bd5783221de1566e79(obj).c597c92b18ba10a11c9e0bdc36e9238d9)
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
					RuntimeMethodHandle arg_21_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c17183f256e26c9026e0b9f1c94597b2b(object, MouseEventArgs)).MethodHandle;
				}
				this.cd15f03051e4babe718fb9b8be570b918 = ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				c8d11bd632485509323291cb481183b0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94136));
				this.c8169d16347c917787d8f24178a7ce4a0 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94140) != 0);
			}
			else
			{
				c8d11bd632485509323291cb481183b0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.cd15f03051e4babe718fb9b8be570b918);
				this.c8169d16347c917787d8f24178a7ce4a0 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94144) != 0);
			}
			cec4dc845e772c3e699a057c528837cac.cac24a5ae511699bc10212b0ef953aef1(c1414876a177bda94ce1dab11328e1cb0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cec4dc845e772c3e699a057c528837cac.cecbe8b99e02bb7b9aa0b2fea312e6dbf(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94148), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94152), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94156), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94160)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94164) != 0);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00138CB8 File Offset: 0x00136EB8
		private void c6fa7ae2c118de2e4a5bbd4b2067457fb(object obj, MouseEventArgs mouseEventArgs)
		{
			cab9686d12cbb27fe9a0d132009d8b6de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00138CCC File Offset: 0x00136ECC
		private void cca726b1e80f2d5bc84b44abf7dfb5031(object obj, FormClosingEventArgs formClosingEventArgs)
		{
			cab9686d12cbb27fe9a0d132009d8b6de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			cafe74e9c22dd716d03dec340fa88fddb.c30767ddca1f9c207888833aea5b5fc61(formClosingEventArgs, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94168) != 0);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00138CF0 File Offset: 0x00136EF0
		protected override void OnPaint(PaintEventArgs e)
		{
			c228e108dd10a95e042f10ed34086ee74.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
			c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cfe50bfa25649541afa0ea62ceaabc269, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94172), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94176), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cfe50bfa25649541afa0ea62ceaabc269), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cfe50bfa25649541afa0ea62ceaabc269));
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00138D48 File Offset: 0x00136F48
		private void c5efbc7b2cb9ad7fe0a6290c0bda27cc1(object obj, EventArgs eventArgs)
		{
			this.c085dec529dabe69214ebd3da5f50de15();
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00138D5C File Offset: 0x00136F5C
		private void c0b4d857a586a2ef93900d36697c453af(object obj, MouseEventArgs mouseEventArgs)
		{
			c3c97afbc65912b49bda637249f073570 c3c97afbc65912b49bda637249f = c56f53106562254ce17267a6363b19def.c9963fcf210a214a3206d6500f3b9397b(obj);
			List<CoreInternal.ca97729d9470bd2653e9679199030e70e> list = caabc9847259f6f7dcd214d7de717137b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca124a9f406cda69b904f2eb04d553ab9.get_ca1cc9328182b27c8b88f87c1e5e1dbeb()))
			{
				list = this.ca124a9f406cda69b904f2eb04d553ab9.get_ca1cc9328182b27c8b88f87c1e5e1dbeb().ToList<CoreInternal.ca97729d9470bd2653e9679199030e70e>();
			}
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94180); i < c5c0678185c134f9fe571a597fcfe5c4a.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94184))
			{
				if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list, i).c4133f594a82980efa774a1f80ec2e7d6, c3c97afbc65912b49bda637249f.c4133f594a82980efa774a1f80ec2e7d6))
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
						RuntimeMethodHandle arg_87_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c0b4d857a586a2ef93900d36697c453af(object, MouseEventArgs)).MethodHandle;
					}
					c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list, i).cf151d4c97b3009a81ead14c8828f914c = c3c97afbc65912b49bda637249f.c597c92b18ba10a11c9e0bdc36e9238d9;
					this.ca124a9f406cda69b904f2eb04d553ab9.c361082d20cd7711fc2eb97c492d9aaa7(c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list, i).c4133f594a82980efa774a1f80ec2e7d6, c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list, i).cf151d4c97b3009a81ead14c8828f914c);
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

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00138E64 File Offset: 0x00137064
		private void c72d9a1c4e7234a476e38fcaf2de398bb(object obj, EventArgs eventArgs)
		{
			if (c4dd477f1d2a75b89b7650280f35a2c0d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					RuntimeMethodHandle arg_1C_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c72d9a1c4e7234a476e38fcaf2de398bb(object, EventArgs)).MethodHandle;
				}
				if (!this.c8169d16347c917787d8f24178a7ce4a0)
				{
					if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
						if (this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0() != null)
						{
							long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
							try
							{
								bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94188) != 0;
								for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94192); i < cdda965d097d78f56a084238cf236b10e.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94204))
								{
									if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, i).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94196))
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
										flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94200) != 0);
										IL_D9:
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
											if (this.cf778c5673ad04a5e26e81bf5a4c6a9aa + (long)c0d2d02f1f272d67c55df698e5f8403c9.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)) < num)
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
												this.cf778c5673ad04a5e26e81bf5a4c6a9aa = num;
												List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
												List<DoodadObject> list2 = this.ca124a9f406cda69b904f2eb04d553ab9.ce3c461fef78e0c8cd8106d4f286e1a07();
												List<SpawnObject> list3 = c7abb1f50c668c71e1c8f2da342b828fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
												for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94208); j < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94212))
												{
													ca1848c4b627d2432f3f6a0371289c5a9.c30767ddca1f9c207888833aea5b5fc61(list3, cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, j));
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
												for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94216); k < cc7be13b57fb3393b0017c0b8c7f88167.c30767ddca1f9c207888833aea5b5fc61(list2); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94220))
												{
													ca1848c4b627d2432f3f6a0371289c5a9.c30767ddca1f9c207888833aea5b5fc61(list3, cfd66ba291892adc6212910185c8d7351.c30767ddca1f9c207888833aea5b5fc61(list2, k));
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
												List<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073> list4 = c6d1b97639ee41059b16668b485f03a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
												for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94224); l < cdda965d097d78f56a084238cf236b10e.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94240))
												{
													if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, l).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94228))
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
														for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94232); m < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, l).c62e5e513abb5063974acc31b79637541); m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94236))
														{
															c07cf9618017a455135befb129d695b99.c30767ddca1f9c207888833aea5b5fc61(list4, cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, l).c62e5e513abb5063974acc31b79637541, m));
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
												while (true)
												{
													switch (3)
													{
													case 0:
														continue;
													}
													break;
												}
												object arg_2D0_0 = list4;
												if (c54dcfd15589cea08d7efb87c7486ea7c.c483ce1f0f41b9d66ce5e0236e46a6be7 == null)
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
													c54dcfd15589cea08d7efb87c7486ea7c.c483ce1f0f41b9d66ce5e0236e46a6be7 = new Comparison<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073>(c54dcfd15589cea08d7efb87c7486ea7c.c5471a6b8c5d56357c3a49e26df903ea5);
												}
												ccd55622ccb38c1e57335fd11cf3e197c.c30767ddca1f9c207888833aea5b5fc61(arg_2D0_0, c54dcfd15589cea08d7efb87c7486ea7c.c483ce1f0f41b9d66ce5e0236e46a6be7);
												for (int n = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94244); n < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(list4); n += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94332))
												{
													MethodInfo methodInfo = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c8afb385ec3cd6a1a272d6c8b598e450d, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201539));
													c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 expr_327 = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n);
													object arg_379_0 = methodInfo;
													object arg_379_1 = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c070221483a03e30b41847ae8c9e91b73;
													object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94248));
													array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94252)] = list3;
													array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94256)] = this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0();
													expr_327.c93bc4c1e0a82610433d5389276a1ae77 = c97090cb0a26f616e51b51e3e4ae571a8.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(arg_379_0, arg_379_1, array));
													if (c1edf7124bd49e13856886e69bde6ea6d.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94260))
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
														for (int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94264); num2 < c4414e47d4d649cc862e3e53cd6856853.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77); num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94276))
														{
															c42b9cd2dabb5ae5f8ca748e944dafe52.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num2), (double)((int)(c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num2), this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(94268))));
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
													else if (c1edf7124bd49e13856886e69bde6ea6d.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94280))
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
														for (int num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94284); num3 < c4414e47d4d649cc862e3e53cd6856853.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77); num3 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94300))
														{
															if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num3)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94288))
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
																c42b9cd2dabb5ae5f8ca748e944dafe52.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num3), (double)c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num3)).cae0c176f7eac0b48a506b3abdb7830ad(c296853733f0b17cc1b95bb3c141c41ec.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))));
															}
															else
															{
																c42b9cd2dabb5ae5f8ca748e944dafe52.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num3), (double)((int)(c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num3), this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(94292))));
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
													c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 expr_5C7 = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n);
													IEnumerable<SpawnObject> arg_600_0 = cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77;
													if (c54dcfd15589cea08d7efb87c7486ea7c.c4e0eb70c40be12e2c1900de571f128f7 == null)
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
														c54dcfd15589cea08d7efb87c7486ea7c.c4e0eb70c40be12e2c1900de571f128f7 = new Func<SpawnObject, double>(c54dcfd15589cea08d7efb87c7486ea7c.cf611fa53425be331b0bd19351d71d0a2);
													}
													expr_5C7.c93bc4c1e0a82610433d5389276a1ae77 = arg_600_0.OrderBy(c54dcfd15589cea08d7efb87c7486ea7c.c4e0eb70c40be12e2c1900de571f128f7).ToList<SpawnObject>();
													for (int num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94304); num4 < c4414e47d4d649cc862e3e53cd6856853.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77); num4 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94328))
													{
														if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num4)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94308))
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
															ce46b1853bd52bf8adb56dc34a5cab677.cea69e7c4d1a729bd5783221de1566e79(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num4)).cefcee864f727805ea140f2a57228015e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94312) != 0);
															for (int num5 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94316); num5 < (int)c50fabdd16787b4182d6ecfd09d9fc226.cc0906fa561b9c6076f6cb6643cecb5e3(c87bfd7a785f49bca15fc04009f5d5975.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))); num5 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94324))
															{
																if (c87bfd7a785f49bca15fc04009f5d5975.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))[num5] == c3a858267554561856092c9bf595cc4ca.c30767ddca1f9c207888833aea5b5fc61(ce46b1853bd52bf8adb56dc34a5cab677.cea69e7c4d1a729bd5783221de1566e79(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num4))))
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
																	ce46b1853bd52bf8adb56dc34a5cab677.cea69e7c4d1a729bd5783221de1566e79(c89d9d07e441b4fd3ab71ff962d2bade7.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(list4, n).c93bc4c1e0a82610433d5389276a1ae77, num4)).cefcee864f727805ea140f2a57228015e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94320) != 0);
																	goto IL_754;
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
														IL_754:;
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
											}
										}
										if (c036a8194774f5a7426074fc0940d0401.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c7255591bb4284c258315ca36f510bf4f, cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83))
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
											if (this.cbdf630d2c7f4ea70618744da07c506ad != null)
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
												MethodInfo methodInfo2 = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(this.c7255591bb4284c258315ca36f510bf4f, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201539));
												object arg_84F_0 = methodInfo2;
												object arg_84F_1 = this.cbdf630d2c7f4ea70618744da07c506ad;
												object[] array2 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94336));
												array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94340)] = this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0();
												string text = c5bdadb216ff81200f68025e2298d040e.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(arg_84F_0, arg_84F_1, array2));
												if (text != null)
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
													c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, text);
												}
												else
												{
													c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(this.c30f179f0ab09ef759665961d9fec82cd, "");
												}
											}
										}
										this.ca2fdf498e4a4957f7a25b9226c258490 = c55979e64ed92c0332c9cd25a31759b4a.c8a754f5f2ca4adde825691a9c31a0e83;
										for (int num6 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94344); num6 < cdda965d097d78f56a084238cf236b10e.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05); num6 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94572))
										{
											if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94348))
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
												for (int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94352); num7 < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541); num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94356))
												{
													if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).c93bc4c1e0a82610433d5389276a1ae77 != null)
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
														if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).c1f281a3e2463722c4175a1fced6212ab != null)
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
															c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).c1f281a3e2463722c4175a1fced6212ab, cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).ca56117bd7a22712111d34d4bd3aa8642, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150361), cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).c93bc4c1e0a82610433d5389276a1ae77.Count<SpawnObject>()));
														}
														else if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).c51318d34047ba16be6801b9bc04f9e67 != null)
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
															cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).c51318d34047ba16be6801b9bc04f9e67.ce97b6ac0d04d9ecb4293cefc259f2630(c4414e47d4d649cc862e3e53cd6856853.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c62e5e513abb5063974acc31b79637541, num7).c93bc4c1e0a82610433d5389276a1ae77));
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
													break;
												}
											}
											else if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94360))
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
												this.ca7c23a9759e119e87b110c3329b0d095(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6));
											}
											else if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94364))
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
												c686cade0e370d76b3712c7486b1359e0.cea69e7c4d1a729bd5783221de1566e79(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da).c43b33c80aed8470d69fd335c69e35a6c();
											}
											else if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94368))
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
												List<CoreInternal.ca97729d9470bd2653e9679199030e70e> list5 = caabc9847259f6f7dcd214d7de717137b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
												using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca124a9f406cda69b904f2eb04d553ab9.get_ca1cc9328182b27c8b88f87c1e5e1dbeb()))
												{
													list5 = this.ca124a9f406cda69b904f2eb04d553ab9.get_ca1cc9328182b27c8b88f87c1e5e1dbeb().ToList<CoreInternal.ca97729d9470bd2653e9679199030e70e>();
												}
												for (int num8 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94372); num8 < c1a94006e6d7f1401e29c6985c93e3521.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54); num8 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94380))
												{
													cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, num8).c6febd09dfe7f1b928b0a7c8c1def55b0.c915b235e4632dd76a9f93609a87bc640 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94376) != 0);
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
												for (int num9 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94384); num9 < c5c0678185c134f9fe571a597fcfe5c4a.c30767ddca1f9c207888833aea5b5fc61(list5); num9 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94440))
												{
													bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94388) != 0;
													for (int num10 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94392); num10 < c1a94006e6d7f1401e29c6985c93e3521.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54); num10 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94404))
													{
														if (cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, num10).c6febd09dfe7f1b928b0a7c8c1def55b0 == c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list5, num9))
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
															cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, num10).c6febd09dfe7f1b928b0a7c8c1def55b0.c915b235e4632dd76a9f93609a87bc640 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94396) != 0);
															flag2 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94400) != 0);
															if (cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, num10).ce6c00421af254c6db10d7dff44e28b07.c597c92b18ba10a11c9e0bdc36e9238d9 != c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list5, num9).cf151d4c97b3009a81ead14c8828f914c)
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
																cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, num10).ce6c00421af254c6db10d7dff44e28b07.c597c92b18ba10a11c9e0bdc36e9238d9 = c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list5, num9).cf151d4c97b3009a81ead14c8828f914c;
																cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, num10).ce6c00421af254c6db10d7dff44e28b07.c2dd3a90fe102fd5fa4cd1950c06c6465();
															}
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
													if (!flag2)
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
														c49a205a8d962eedc10d0ad1e8ae458d7.c788d1c53fd6e7f5eb9c346e54085f0a9 c788d1c53fd6e7f5eb9c346e54085f0a = new c49a205a8d962eedc10d0ad1e8ae458d7.c788d1c53fd6e7f5eb9c346e54085f0a9();
														c788d1c53fd6e7f5eb9c346e54085f0a.c6febd09dfe7f1b928b0a7c8c1def55b0 = c0a83b00b8b998dd70e1b8afccde57666.c30767ddca1f9c207888833aea5b5fc61(list5, num9);
														c788d1c53fd6e7f5eb9c346e54085f0a.c6febd09dfe7f1b928b0a7c8c1def55b0.c915b235e4632dd76a9f93609a87bc640 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94408) != 0);
														c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07 = new c3c97afbc65912b49bda637249f073570(cac1b41306e7d2608ecd8c0dff9b5e027.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c78ded31d645d514653d83df43fcbcbb0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cdf6e7c9dd265bc486d194e65301f3224.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cad901e49ab29eb821555008080f5b669.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c681049ceae8a60cea081e248b66dc6b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c55dc7131d594e2b491d0564ba10d74ec.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
														c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
														c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07, new MouseEventHandler(this.c0b4d857a586a2ef93900d36697c453af));
														cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07, new MouseEventHandler(this.c0b4d857a586a2ef93900d36697c453af));
														c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07.c4133f594a82980efa774a1f80ec2e7d6 = c788d1c53fd6e7f5eb9c346e54085f0a.c6febd09dfe7f1b928b0a7c8c1def55b0.c4133f594a82980efa774a1f80ec2e7d6;
														c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07.c597c92b18ba10a11c9e0bdc36e9238d9 = c788d1c53fd6e7f5eb9c346e54085f0a.c6febd09dfe7f1b928b0a7c8c1def55b0.cf151d4c97b3009a81ead14c8828f914c;
														object arg_EA4_0 = c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07;
														Size size = ce53b70fd758e055639733d2cfc8ff56a.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07));
														c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(arg_EA4_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size));
														object arg_ED0_0 = c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07;
														Size size2 = ce53b70fd758e055639733d2cfc8ff56a.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07));
														c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(arg_ED0_0, cd732e615dba6a4c4c5707fa7b770a160.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size2));
														c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07.c2dd3a90fe102fd5fa4cd1950c06c6465();
														c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab = ca6e587126d99e4befd586e4acc482275.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
														c00a0a8880cc403c0e7f6f0f080a622c6.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, c20089aee343859621a422147c9e74704.cc6a9c540a2ed5763275f32ba91c9e97b(c2d80901c7e2d859fd1e7f8071d4a2631.c30767ddca1f9c207888833aea5b5fc61(c87bd5f9deb1da3b3487ca0e0cd55c165.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbc53e7e13bfc180a6ff2d31b7b804378.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201704))));
														c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
														c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, c788d1c53fd6e7f5eb9c346e54085f0a.c6febd09dfe7f1b928b0a7c8c1def55b0.c4133f594a82980efa774a1f80ec2e7d6);
														c48ae41fb9da6c75de61d7b5efe29dda4.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, this.cf5edb3102b5e847917b6c6b02b64cf2f);
														int arg_FB7_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94412);
														Size size3 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c479b9881540f92612803d53f2e7d39d0.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201719)), cf3e76658314ffe6840f1326b31b84d62.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab));
														int num11 = c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_FB7_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size3));
														c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94416));
														c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, num11);
														if (c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da) - c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cc4933387b7398585e4ac7c2736397eaa < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94420) + c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07) + c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab))
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
															c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cf62a06241405cafeceff1f6f7ef2f6a0 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94424);
															c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cc4933387b7398585e4ac7c2736397eaa = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94428);
														}
														c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07, c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cc4933387b7398585e4ac7c2736397eaa);
														c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07, c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cf62a06241405cafeceff1f6f7ef2f6a0);
														c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cc4933387b7398585e4ac7c2736397eaa += c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94432);
														c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cc4933387b7398585e4ac7c2736397eaa);
														c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab, c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cf62a06241405cafeceff1f6f7ef2f6a0);
														c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cc4933387b7398585e4ac7c2736397eaa += c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94436);
														c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da), c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07);
														c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da), c788d1c53fd6e7f5eb9c346e54085f0a.c1f281a3e2463722c4175a1fced6212ab);
														c34adf89b724a966968964b153f4e8a02.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, c788d1c53fd6e7f5eb9c346e54085f0a);
														cacf8aa8294d29ee7460a6e8f415115b4.c30767ddca1f9c207888833aea5b5fc61(c788d1c53fd6e7f5eb9c346e54085f0a.ce6c00421af254c6db10d7dff44e28b07);
													}
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
												bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94444) != 0;
												List<c49a205a8d962eedc10d0ad1e8ae458d7.c788d1c53fd6e7f5eb9c346e54085f0a9> list6 = c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54.ToList<c49a205a8d962eedc10d0ad1e8ae458d7.c788d1c53fd6e7f5eb9c346e54085f0a9>();
												for (int num12 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94448); num12 < c1a94006e6d7f1401e29c6985c93e3521.c30767ddca1f9c207888833aea5b5fc61(list6); num12 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94456))
												{
													if (!cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num12).c6febd09dfe7f1b928b0a7c8c1def55b0.c915b235e4632dd76a9f93609a87bc640)
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
														try
														{
															c0571d404854344a06afc3a2e3a9802cc.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da), cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num12).ce6c00421af254c6db10d7dff44e28b07);
															c0571d404854344a06afc3a2e3a9802cc.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da), cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num12).c1f281a3e2463722c4175a1fced6212ab);
															c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num12).ce6c00421af254c6db10d7dff44e28b07);
															c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num12).c1f281a3e2463722c4175a1fced6212ab);
															c96ae7118d77233aa0d66dbcc1beb88f6.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num12));
														}
														catch
														{
														}
														flag3 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94452) != 0);
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
												list6 = c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54.ToList<c49a205a8d962eedc10d0ad1e8ae458d7.c788d1c53fd6e7f5eb9c346e54085f0a9>();
												if (flag3)
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
													for (int num13 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94460); num13 < c1a94006e6d7f1401e29c6985c93e3521.c30767ddca1f9c207888833aea5b5fc61(list6); num13 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94464))
													{
														c0571d404854344a06afc3a2e3a9802cc.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da), cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num13).ce6c00421af254c6db10d7dff44e28b07);
														c0571d404854344a06afc3a2e3a9802cc.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da), cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num13).c1f281a3e2463722c4175a1fced6212ab);
														c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num13).ce6c00421af254c6db10d7dff44e28b07);
														c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num13).c1f281a3e2463722c4175a1fced6212ab);
														c96ae7118d77233aa0d66dbcc1beb88f6.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c033ec32542a62ff7bb333ca5d79d7a54, cf5b4e767c32943373d044ed244b018c8.c30767ddca1f9c207888833aea5b5fc61(list6, num13));
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
													c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cc4933387b7398585e4ac7c2736397eaa = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94468);
													c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cf62a06241405cafeceff1f6f7ef2f6a0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94472);
												}
											}
											else if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94476))
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
												try
												{
													cccadf1bd3f3fd046f6781bd340f5c020 cccadf1bd3f3fd046f6781bd340f5c = c0e04854103783c4f4afc5bd8e316e82c.c9963fcf210a214a3206d6500f3b9397b(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).ca53c5b83901742f3960c4c2f6f8db8da);
													if (c036a8194774f5a7426074fc0940d0401.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c810c4cee02339a35f874033e0d16c270, cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83))
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
														if (c036a8194774f5a7426074fc0940d0401.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c7255591bb4284c258315ca36f510bf4f, cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83))
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
															int num14 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94480);
															string c195a54fbdf960ff8ef1ef331acb79a1a = "";
															try
															{
																if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c520a716d720e4fa3864a395fc5f5449d, ""))
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
																	MethodInfo methodInfo3 = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c810c4cee02339a35f874033e0d16c270, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201539));
																	object arg_161F_0 = methodInfo3;
																	object arg_161F_1 = c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c21f15184a9580869b800bd9d9151ca01;
																	object[] array3 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94484));
																	array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94488)] = this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0();
																	num14 = c2d92d063805d3e402573723b0c01f89e.cc6a9c540a2ed5763275f32ba91c9e97b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(arg_161F_0, arg_161F_1, array3));
																	if (num14 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94492))
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
																		num14 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94496);
																	}
																	if (num14 > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94500))
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
																		num14 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94504);
																	}
																}
																if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c2997cf47688460d03e4dcf343cc9646f, ""))
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
																	MethodInfo methodInfo4 = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(c2facb148e668e8b13bd6e91913827001.c30767ddca1f9c207888833aea5b5fc61(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).c7255591bb4284c258315ca36f510bf4f, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(200861)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201539));
																	object arg_1727_0 = methodInfo4;
																	object arg_1727_1 = c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num6).cbdf630d2c7f4ea70618744da07c506ad;
																	object[] array4 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94508));
																	array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94512)] = this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0();
																	c195a54fbdf960ff8ef1ef331acb79a1a = c5bdadb216ff81200f68025e2298d040e.c9963fcf210a214a3206d6500f3b9397b(c92e7a996a6c251fd4825d06c32029762.c30767ddca1f9c207888833aea5b5fc61(arg_1727_0, arg_1727_1, array4));
																}
																cccadf1bd3f3fd046f6781bd340f5c.c052c778d5c09788ff94bdadaaba342a0 = num14;
																cccadf1bd3f3fd046f6781bd340f5c.c195a54fbdf960ff8ef1ef331acb79a1a = c195a54fbdf960ff8ef1ef331acb79a1a;
															}
															catch (Exception ex)
															{
																cccadf1bd3f3fd046f6781bd340f5c.c052c778d5c09788ff94bdadaaba342a0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94516);
																cccadf1bd3f3fd046f6781bd340f5c.c195a54fbdf960ff8ef1ef331acb79a1a = "";
																cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c18f6ba72050e99390eb8663a138b87fa.c30767ddca1f9c207888833aea5b5fc61(ex)));
															}
															c97f49d2657861be131c291c4792bd0f3.c30767ddca1f9c207888833aea5b5fc61(cccadf1bd3f3fd046f6781bd340f5c);
															goto IL_18B9;
														}
													}
													int c052c778d5c09788ff94bdadaaba342a = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94520);
													string c195a54fbdf960ff8ef1ef331acb79a1a2 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201730);
													double num15 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(94524);
													double num16 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(94532);
													Creature creature = this.ca124a9f406cda69b904f2eb04d553ab9.cdc32f0d9e795bf98b2e0e2ccd02e57bb(c2409235dcdd3a0955b5d5c44853e591b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()));
													if (creature != null)
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
														num15 = (double)ce7a2a2bd5a314372d9c4632e238ba81a.c30767ddca1f9c207888833aea5b5fc61(creature);
														num16 = (double)c4cc0c9b7884352beee20bc8f20093aaa.c30767ddca1f9c207888833aea5b5fc61(creature);
														int num17 = (int)(num15 / (num16 + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(94540)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(94548));
														if (num17 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94556))
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
															num17 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94560);
														}
														if (num17 > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94564))
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
															num17 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94568);
														}
														c052c778d5c09788ff94bdadaaba342a = num17;
														c195a54fbdf960ff8ef1ef331acb79a1a2 = cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num15, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201749), num16);
													}
													cccadf1bd3f3fd046f6781bd340f5c.c052c778d5c09788ff94bdadaaba342a0 = c052c778d5c09788ff94bdadaaba342a;
													cccadf1bd3f3fd046f6781bd340f5c.c195a54fbdf960ff8ef1ef331acb79a1a = c195a54fbdf960ff8ef1ef331acb79a1a2;
													c97f49d2657861be131c291c4792bd0f3.c30767ddca1f9c207888833aea5b5fc61(cccadf1bd3f3fd046f6781bd340f5c);
													IL_18B9:;
												}
												catch (Exception ex2)
												{
													cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201752), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
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
										for (int num18 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94576); num18 < cdda965d097d78f56a084238cf236b10e.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05); num18 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94584))
										{
											if (c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num18).c94adb236938861a7e3d6aa41b463a207 == (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94580))
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
												this.cbc3ec31260030cf796b908ec11301399(c04839a9947bbe44b20151e55e76d48f3.c30767ddca1f9c207888833aea5b5fc61(this.c411364f37013078611afa59f645dcb05, num18));
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
										return;
									}
								}
								while (true)
								{
									switch (1)
									{
									case 0:
										continue;
									}
									goto IL_D9;
								}
							}
							catch (Exception ex3)
							{
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex3));
							}
							return;
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
					return;
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

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0013A888 File Offset: 0x00138A88
		private void c085dec529dabe69214ebd3da5f50de15()
		{
			if (this.cfe50bfa25649541afa0ea62ceaabc269 != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.c085dec529dabe69214ebd3da5f50de15()).MethodHandle;
				}
				c762855a9636b81dcb4ffe699b8e25cf6.c30767ddca1f9c207888833aea5b5fc61(this.cfe50bfa25649541afa0ea62ceaabc269);
			}
			this.cfe50bfa25649541afa0ea62ceaabc269 = cd95844e7d60a0b489c7b00a0c65c04de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94588));
			int num = c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			int num2 = ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			Graphics graphics = c613052e8bee42d8583d5b4036f4d2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cfe50bfa25649541afa0ea62ceaabc269);
			try
			{
				c01754b2d6a3b058e32220a8f00201bb0.c30767ddca1f9c207888833aea5b5fc61(graphics, (CompositingQuality)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94592));
				c6ed28ebb38d8ca3aaf3d48c8cf38fb72.c30767ddca1f9c207888833aea5b5fc61(graphics, (PixelOffsetMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94596));
				c3c459109318902adc631375e1d797d04.c30767ddca1f9c207888833aea5b5fc61(graphics, (SmoothingMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94600));
				cf59ab6facb97c8f8e7c575d492fabed6.c30767ddca1f9c207888833aea5b5fc61(graphics, (InterpolationMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94604));
				TextureBrush textureBrush = c343e68bc035fb5e495ad9dba5874c67d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cfcf963d78e4d86bc8e79dd99361e64d9);
				try
				{
					cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(textureBrush, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94608));
					c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(textureBrush, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(94612), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(94616));
					c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(graphics, textureBrush, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94620), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94624), num, num2);
				}
				finally
				{
					if (textureBrush != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(textureBrush);
					}
				}
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.c4fd64b0e652a9d526a239f7c8660874a, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94628), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94632), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a));
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.cb75a81151b52709aacb67b9f2a45f0c2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94636), num2 - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cb75a81151b52709aacb67b9f2a45f0c2), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cb75a81151b52709aacb67b9f2a45f0c2), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cb75a81151b52709aacb67b9f2a45f0c2));
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.c1ea99d8aa04c7d0b47865162f7e10bb0, num - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1ea99d8aa04c7d0b47865162f7e10bb0), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94640), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1ea99d8aa04c7d0b47865162f7e10bb0), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1ea99d8aa04c7d0b47865162f7e10bb0));
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.cd43056a47e49717f580065b7a1704046, num - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cd43056a47e49717f580065b7a1704046), num2 - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cd43056a47e49717f580065b7a1704046), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cd43056a47e49717f580065b7a1704046), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cd43056a47e49717f580065b7a1704046));
				TextureBrush textureBrush2 = c343e68bc035fb5e495ad9dba5874c67d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3c0337d09f5a296f71a3424a155ecd30);
				try
				{
					cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(textureBrush2, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94644));
					c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(textureBrush2, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(94648), (float)ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a));
					c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(graphics, textureBrush2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94652), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c3c0337d09f5a296f71a3424a155ecd30), num2 - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a) - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cb75a81151b52709aacb67b9f2a45f0c2));
				}
				finally
				{
					if (textureBrush2 != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(textureBrush2);
					}
				}
				TextureBrush textureBrush3 = c343e68bc035fb5e495ad9dba5874c67d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c36f05f91e1d5566565206b8d2528365e);
				try
				{
					cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(textureBrush3, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94656));
					c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(textureBrush3, (float)(num - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c36f05f91e1d5566565206b8d2528365e)), (float)ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1ea99d8aa04c7d0b47865162f7e10bb0));
					c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(graphics, textureBrush3, num - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c36f05f91e1d5566565206b8d2528365e), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1ea99d8aa04c7d0b47865162f7e10bb0), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c36f05f91e1d5566565206b8d2528365e), num2 - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1ea99d8aa04c7d0b47865162f7e10bb0) - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cd43056a47e49717f580065b7a1704046));
				}
				finally
				{
					if (textureBrush3 != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(textureBrush3);
					}
				}
				TextureBrush textureBrush4 = c343e68bc035fb5e495ad9dba5874c67d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c6cc5446bc2b1b068fc58fb7db3b327e5);
				try
				{
					cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(textureBrush4, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94660));
					c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(textureBrush4, (float)ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(94664));
					c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(graphics, textureBrush4, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94668), num - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c4fd64b0e652a9d526a239f7c8660874a) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1ea99d8aa04c7d0b47865162f7e10bb0), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c6cc5446bc2b1b068fc58fb7db3b327e5));
				}
				finally
				{
					if (textureBrush4 != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(textureBrush4);
					}
				}
				TextureBrush textureBrush5 = c343e68bc035fb5e495ad9dba5874c67d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c179c218866adc84baeadfa06c857a2c6);
				try
				{
					cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(textureBrush5, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94672));
					c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(textureBrush5, (float)ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cb75a81151b52709aacb67b9f2a45f0c2), (float)(num2 - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c179c218866adc84baeadfa06c857a2c6)));
					c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(graphics, textureBrush5, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cb75a81151b52709aacb67b9f2a45f0c2), num2 - ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c179c218866adc84baeadfa06c857a2c6), num - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cb75a81151b52709aacb67b9f2a45f0c2) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cd43056a47e49717f580065b7a1704046), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c179c218866adc84baeadfa06c857a2c6));
				}
				finally
				{
					if (textureBrush5 != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(textureBrush5);
					}
				}
			}
			finally
			{
				if (graphics != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(graphics);
				}
			}
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0013ADF8 File Offset: 0x00138FF8
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle arg_15_0 = methodof(c54dcfd15589cea08d7efb87c7486ea7c.Dispose(bool)).MethodHandle;
				}
				if (this.ce3753db2789ff7c885165e389c0b762f != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(this.ce3753db2789ff7c885165e389c0b762f);
				}
			}
			ca711552215861f50c9d5242183c2e71b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x0013AE40 File Offset: 0x00139040
		private void c99cc8d41a90783cea4e7845c839dcc98()
		{
			this.ce3753db2789ff7c885165e389c0b762f = ce5d9f7cdcdd93dceb594ff3b777c5df3.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			this.cd7a4d3b8444ed083ea87ee6de2a86248 = c7cbebe58b3632e95118f0f252aa4b931.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce3753db2789ff7c885165e389c0b762f);
			c07e182c3a79740dae49caa58c0bfd645.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			c6cb00ef0a1679611fdec318370c99174.c30767ddca1f9c207888833aea5b5fc61(this.cd7a4d3b8444ed083ea87ee6de2a86248, new EventHandler(this.c72d9a1c4e7234a476e38fcaf2de398bb));
			c2ac834e6bfb97cfdfe6394e4839112d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SizeF(c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(94676), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(94680)));
			c26a5c52ab871909e619dd9ad2000e72c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (AutoScaleMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94684));
			c3064eedb4468ff0cdd24e296fd6a43ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Size(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94688), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94692)));
			ca70c1bccddd70119155bb01d7824c790.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(199275));
			c3829f7317d9cc284ab524b9ea3bcbd9a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new FormClosingEventHandler(this.cca726b1e80f2d5bc84b44abf7dfb5031));
			c19bd56dc0527281fcc0f77c1738d75e8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94696) != 0);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0013AF10 File Offset: 0x00139110
		[CompilerGenerated]
		private static int cd1a00367e88c4e4687911d8fbe8ad56f(c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a2)
		{
			return c341c057025cd8aff0e5f8e9a.c8ab6ed63b1c75b721fdeba398424d22b - c341c057025cd8aff0e5f8e9a2.c8ab6ed63b1c75b721fdeba398424d22b;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0013AF2C File Offset: 0x0013912C
		[CompilerGenerated]
		private static int cfb97c82c4751f837996554f42e22c0d2(c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a2)
		{
			return c341c057025cd8aff0e5f8e9a2.c8ab6ed63b1c75b721fdeba398424d22b - c341c057025cd8aff0e5f8e9a.c8ab6ed63b1c75b721fdeba398424d22b;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0013AF48 File Offset: 0x00139148
		[CompilerGenerated]
		private static int c5471a6b8c5d56357c3a49e26df903ea5(c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a2)
		{
			return c341c057025cd8aff0e5f8e9a.c8ab6ed63b1c75b721fdeba398424d22b - c341c057025cd8aff0e5f8e9a2.c8ab6ed63b1c75b721fdeba398424d22b;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0013AF64 File Offset: 0x00139164
		[CompilerGenerated]
		private static double cf611fa53425be331b0bd19351d71d0a2(SpawnObject spawnObject)
		{
			return c58999409206d2ae4ca522a5df8207099.c30767ddca1f9c207888833aea5b5fc61(spawnObject);
		}

		// Token: 0x0400138B RID: 5003
		private Bitmap cfe50bfa25649541afa0ea62ceaabc269;

		// Token: 0x0400138C RID: 5004
		private Bitmap cfcf963d78e4d86bc8e79dd99361e64d9;

		// Token: 0x0400138D RID: 5005
		private Bitmap c4fd64b0e652a9d526a239f7c8660874a;

		// Token: 0x0400138E RID: 5006
		private Bitmap cb75a81151b52709aacb67b9f2a45f0c2;

		// Token: 0x0400138F RID: 5007
		private Bitmap c1ea99d8aa04c7d0b47865162f7e10bb0;

		// Token: 0x04001390 RID: 5008
		private Bitmap cd43056a47e49717f580065b7a1704046;

		// Token: 0x04001391 RID: 5009
		private Bitmap c3c0337d09f5a296f71a3424a155ecd30;

		// Token: 0x04001392 RID: 5010
		private Bitmap c36f05f91e1d5566565206b8d2528365e;

		// Token: 0x04001393 RID: 5011
		private Bitmap c6cc5446bc2b1b068fc58fb7db3b327e5;

		// Token: 0x04001394 RID: 5012
		private Bitmap c179c218866adc84baeadfa06c857a2c6;

		// Token: 0x04001395 RID: 5013
		private object cbdf630d2c7f4ea70618744da07c506ad;

		// Token: 0x04001396 RID: 5014
		private Assembly c7255591bb4284c258315ca36f510bf4f;

		// Token: 0x04001397 RID: 5015
		private int c75cf2c9b9ff80f4f01a7c93e922a4b11 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94700);

		// Token: 0x04001398 RID: 5016
		private Rectangle c3c189044840e0a7915e3524bd8332813;

		// Token: 0x04001399 RID: 5017
		private Point c458fe22c85def03fa488ceebdd8e0757;

		// Token: 0x0400139A RID: 5018
		private int cd15f03051e4babe718fb9b8be570b918;

		// Token: 0x0400139B RID: 5019
		private bool c8169d16347c917787d8f24178a7ce4a0;

		// Token: 0x0400139C RID: 5020
		private long cf778c5673ad04a5e26e81bf5a4c6a9aa = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();

		// Token: 0x0400139D RID: 5021
		private IContainer ce3753db2789ff7c885165e389c0b762f;

		// Token: 0x0400139E RID: 5022
		public Timer cd7a4d3b8444ed083ea87ee6de2a86248;

		// Token: 0x0400139F RID: 5023
		[CompilerGenerated]
		private static Comparison<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073> c3444fefa19358f4a5e6d401dacac9dc8;

		// Token: 0x040013A0 RID: 5024
		[CompilerGenerated]
		private static Comparison<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073> cb221befa05b69c1af6798edd547ee3ac;

		// Token: 0x040013A1 RID: 5025
		[CompilerGenerated]
		private static Comparison<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073> c483ce1f0f41b9d66ce5e0236e46a6be7;

		// Token: 0x040013A2 RID: 5026
		[CompilerGenerated]
		private static Func<SpawnObject, double> c4e0eb70c40be12e2c1900de571f128f7;

		// Token: 0x0200055D RID: 1373
		private struct c3918949819a5b6aaa54d7a4073954472
		{
			// Token: 0x040013A3 RID: 5027
			public SpawnObject c60958cc55162377476d7d7bef4bae994;

			// Token: 0x040013A4 RID: 5028
			public c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c6febd09dfe7f1b928b0a7c8c1def55b0;
		}
	}
}
