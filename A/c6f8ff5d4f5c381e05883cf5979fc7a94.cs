using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ArcheBuddy;
using ArcheBuddy.Bot.Classes;
using ArcheBuddy.WPFForms;
using Buddy.Auth;
using Buddy.Auth.SR;
using Buddy.Store;

namespace A
{
	// Token: 0x02000041 RID: 65
	internal sealed class c6f8ff5d4f5c381e05883cf5979fc7a94
	{
		// Token: 0x06000143 RID: 323 RVA: 0x000158F4 File Offset: 0x00013AF4
		public c6f8ff5d4f5c381e05883cf5979fc7a94()
		{
			cb094716388cdccab11c8b320dc95389e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new EventHandler(this.ca1ab680c0c8c21a532f3887949b471fe));
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0001593C File Offset: 0x00013B3C
		private void ca1ab680c0c8c21a532f3887949b471fe(object obj, EventArgs eventArgs)
		{
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c5aab3caea0c40520688765f5a71a0c1c, c696fb15e900756070cf495fd8d519846.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(3084))))
			{
				try
				{
					List<CoreInternal> list = cebf5cf86e0a97e0af962eaacad5c29f2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					List<CoreInternal>.Enumerator enumerator = c3198a680416cc64e113da4c16f344b9f.c30767ddca1f9c207888833aea5b5fc61(list);
					try
					{
						while (cde96bb4edb6513000d41efb8b1f2cf3b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
						{
							Func<AuthService, bool> func = c7e942c78d99a3a9a7cfee7af55ea7034.c8a754f5f2ca4adde825691a9c31a0e83;
							c6f8ff5d4f5c381e05883cf5979fc7a94.c1f6084e74bb648ebd4fbc207c3813b4a c1f6084e74bb648ebd4fbc207c3813b4a = new c6f8ff5d4f5c381e05883cf5979fc7a94.c1f6084e74bb648ebd4fbc207c3813b4a();
							c1f6084e74bb648ebd4fbc207c3813b4a.ce3df70de321b8392b0460e330fec2219 = c2e63f168cd07e56a4074a6bfc965abe3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
							if (func == null)
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
									RuntimeMethodHandle arg_63_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.ca1ab680c0c8c21a532f3887949b471fe(object, EventArgs)).MethodHandle;
								}
								func = new Func<AuthService, bool>(c1f6084e74bb648ebd4fbc207c3813b4a.c3988e911fc5ceb56ede343aeabb03b73);
							}
							Service.Use<bool>(func);
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
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00015A28 File Offset: 0x00013C28
		internal bool c340572dc48c4179fe931087ad8ccdb71(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			Func<AuthService, bool> func = c7e942c78d99a3a9a7cfee7af55ea7034.c8a754f5f2ca4adde825691a9c31a0e83;
			c6f8ff5d4f5c381e05883cf5979fc7a94.c7cf0459cb1064c32f7e234356af19643 c7cf0459cb1064c32f7e234356af = new c6f8ff5d4f5c381e05883cf5979fc7a94.c7cf0459cb1064c32f7e234356af19643();
			c7cf0459cb1064c32f7e234356af.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			bool result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c5aab3caea0c40520688765f5a71a0c1c, c696fb15e900756070cf495fd8d519846.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(3092))))
			{
				try
				{
					if (func == null)
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
							RuntimeMethodHandle arg_4A_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.c340572dc48c4179fe931087ad8ccdb71(CoreInternal)).MethodHandle;
						}
						func = new Func<AuthService, bool>(c7cf0459cb1064c32f7e234356af.c121ac0dc34c4e6dceefe1943c7884ac4);
					}
					object obj = Service.Use<bool>(func);
					if (obj != null)
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
						c9d2b1209aa31568f202b6352fc1e1f97.cc6a9c540a2ed5763275f32ba91c9e97b(obj);
					}
					if (obj != null)
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
						c9d2b1209aa31568f202b6352fc1e1f97.cc6a9c540a2ed5763275f32ba91c9e97b(obj);
					}
					if (obj != null)
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
						result = c9d2b1209aa31568f202b6352fc1e1f97.cc6a9c540a2ed5763275f32ba91c9e97b(obj);
						return result;
					}
				}
				catch (Exception)
				{
				}
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3100) != 0);
			}
			return result;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00015B1C File Offset: 0x00013D1C
		internal bool cddf96bb4adba56e1add6a5032d57e0d0(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			Func<AuthService, bool> func = c7e942c78d99a3a9a7cfee7af55ea7034.c8a754f5f2ca4adde825691a9c31a0e83;
			c6f8ff5d4f5c381e05883cf5979fc7a94.c6e812442ed3949264fd463efb8aca681 c6e812442ed3949264fd463efb8aca = new c6f8ff5d4f5c381e05883cf5979fc7a94.c6e812442ed3949264fd463efb8aca681();
			c6e812442ed3949264fd463efb8aca.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			bool result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c5aab3caea0c40520688765f5a71a0c1c, c696fb15e900756070cf495fd8d519846.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(3104))))
			{
				try
				{
					if (func == null)
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
							RuntimeMethodHandle arg_4C_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.cddf96bb4adba56e1add6a5032d57e0d0(CoreInternal)).MethodHandle;
						}
						func = new Func<AuthService, bool>(c6e812442ed3949264fd463efb8aca.c7814549b8933750a59a04da73a4e3b88);
					}
					bool? flag;
					c44f37907d51d3c2b581b3207fc33b93d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag, Service.Use<bool>(func));
					if (c6a36111b31aa365ae9ab932db51725ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
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
						if (cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
						{
							if (c6a36111b31aa365ae9ab932db51725ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
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
								if (cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
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
									result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3116) != 0);
									return result;
								}
							}
							result = cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag);
							return result;
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
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3112) != 0);
					return result;
				}
				catch (Exception)
				{
				}
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3120) != 0);
			}
			return result;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00015C48 File Offset: 0x00013E48
		internal bool c4b7def4dc3ae9ca90c99e01c2e042f99(string c03f8978984671fce959e74a1d566ffa, CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			Func<AuthService, bool> func = c7e942c78d99a3a9a7cfee7af55ea7034.c8a754f5f2ca4adde825691a9c31a0e83;
			c6f8ff5d4f5c381e05883cf5979fc7a94.cd702cb789cfab322dd253f4765c5aa8c cd702cb789cfab322dd253f4765c5aa8c = new c6f8ff5d4f5c381e05883cf5979fc7a94.cd702cb789cfab322dd253f4765c5aa8c();
			cd702cb789cfab322dd253f4765c5aa8c.c03f8978984671fce959e74a1d566ffa6 = c03f8978984671fce959e74a1d566ffa;
			cd702cb789cfab322dd253f4765c5aa8c.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			bool result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c5aab3caea0c40520688765f5a71a0c1c, c696fb15e900756070cf495fd8d519846.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(3124))))
			{
				try
				{
					if (func == null)
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
							RuntimeMethodHandle arg_53_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.c4b7def4dc3ae9ca90c99e01c2e042f99(string, CoreInternal)).MethodHandle;
						}
						func = new Func<AuthService, bool>(cd702cb789cfab322dd253f4765c5aa8c.c896c5ee6ff34d8fbf1b077f755b933e3);
					}
					bool? flag;
					c44f37907d51d3c2b581b3207fc33b93d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag, Service.Use<bool>(func));
					if (c6a36111b31aa365ae9ab932db51725ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
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
						if (cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
						{
							if (c6a36111b31aa365ae9ab932db51725ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
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
								if (cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag))
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
									result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3136) != 0);
									return result;
								}
							}
							result = cb808a1eb5a617f9ace6c890a86afa660.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref flag);
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
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3132) != 0);
					return result;
				}
				catch (Exception)
				{
				}
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3140) != 0);
			}
			return result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00015D78 File Offset: 0x00013F78
		internal CoreInternal c8212c323cbad2bba6c6c5da4ae324873(int num, int num2, c9dc78792fcb683123688a66f4d248388 c8a12ec6aaaa9d79fcdc7c5dabdc3e, bool cb050160a072148ba779287efae9f, byte c01583b115b2c38d680d8628dd9d34b, byte c232e043fbb3f37dbea5513509f, string c020ee1f739dff0414faa6ff0d491a, AccTreeViewInfo accTreeViewInfo, string text)
		{
			Action action = c2cffb0c8c347f2a1edaa1274b624dbd1.c8a754f5f2ca4adde825691a9c31a0e83;
			c6f8ff5d4f5c381e05883cf5979fc7a94.c5625d06068c6c3b42d438bb01826b615 c5625d06068c6c3b42d438bb01826b = new c6f8ff5d4f5c381e05883cf5979fc7a94.c5625d06068c6c3b42d438bb01826b615();
			c5625d06068c6c3b42d438bb01826b.c8a12ec6aaaa9d79fcdc7c5dabdc3e283 = c8a12ec6aaaa9d79fcdc7c5dabdc3e;
			c5625d06068c6c3b42d438bb01826b.cb050160a072148ba779287efae9f1533 = cb050160a072148ba779287efae9f;
			c5625d06068c6c3b42d438bb01826b.c020ee1f739dff0414faa6ff0d491a861 = c020ee1f739dff0414faa6ff0d491a;
			c5625d06068c6c3b42d438bb01826b.cb6ea3d298d68be569f5410cc290458d5 = this;
			c5625d06068c6c3b42d438bb01826b.ca124a9f406cda69b904f2eb04d553ab9 = c49603cd9629f69a6585d48b4afcaf58c.c8a754f5f2ca4adde825691a9c31a0e83;
			try
			{
				c5625d06068c6c3b42d438bb01826b.ca124a9f406cda69b904f2eb04d553ab9 = ce134848f05740e50339ae53807076295.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num, num2, text);
				c5625d06068c6c3b42d438bb01826b.ca124a9f406cda69b904f2eb04d553ab9.c01583b115b2c38d680d8628dd9d34b15 = c01583b115b2c38d680d8628dd9d34b;
				c5625d06068c6c3b42d438bb01826b.ca124a9f406cda69b904f2eb04d553ab9.c232e043fbb3f37dbea5513509f830718 = c232e043fbb3f37dbea5513509f;
				c86bbacac65e66a0f30c5cb9ef966ab6c.c30767ddca1f9c207888833aea5b5fc61(c5625d06068c6c3b42d438bb01826b.ca124a9f406cda69b904f2eb04d553ab9, accTreeViewInfo);
				if (action == null)
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
						RuntimeMethodHandle arg_82_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.c8212c323cbad2bba6c6c5da4ae324873(int, int, c9dc78792fcb683123688a66f4d248388, bool, byte, byte, string, AccTreeViewInfo, string)).MethodHandle;
					}
					action = new Action(c5625d06068c6c3b42d438bb01826b.cec6ac64b656148ca436254c37769554d);
				}
				c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(action));
				return c5625d06068c6c3b42d438bb01826b.ca124a9f406cda69b904f2eb04d553ab9;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00015E50 File Offset: 0x00014050
		internal void c5b8a8ab26ef0e29e7173cb4e2915e2d6(Process c661432020c9835bb6d4eb0d9816118c, bool flag)
		{
			c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99 cc08badc360e35ed991884dc83e8bcb = new c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99();
			cc08badc360e35ed991884dc83e8bcb.c661432020c9835bb6d4eb0d9816118c7 = c661432020c9835bb6d4eb0d9816118c;
			cc08badc360e35ed991884dc83e8bcb.c3f6e2cc486ab04cee90a0dbede2165c7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3144) != 0);
			c754bf7e7df154d4ce2e2765ae3844997.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e, cc08badc360e35ed991884dc83e8bcb);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00015E88 File Offset: 0x00014088
		internal void ca7267f77f694da9c94d7c38cba79cd64(object obj, EventArgs eventArgs)
		{
			try
			{
				c6f8ff5d4f5c381e05883cf5979fc7a94.ca05a96fae46495300d09dbbfabc704ba ca05a96fae46495300d09dbbfabc704ba = new c6f8ff5d4f5c381e05883cf5979fc7a94.ca05a96fae46495300d09dbbfabc704ba();
				ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481 = c63ddbf7693d1919e0bc77777da0727ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				try
				{
					Predicate<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99> predicate = c8a9926bf78d21e05a88fc52c6273db34.c8a754f5f2ca4adde825691a9c31a0e83;
					c6f8ff5d4f5c381e05883cf5979fc7a94.c17ec3456233b988039e13d82ed692a62 c17ec3456233b988039e13d82ed692a = new c6f8ff5d4f5c381e05883cf5979fc7a94.c17ec3456233b988039e13d82ed692a62();
					c17ec3456233b988039e13d82ed692a.c4f736900843dca678d65905b7c78c141 = ca05a96fae46495300d09dbbfabc704ba;
					c17ec3456233b988039e13d82ed692a.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3148);
					while (c17ec3456233b988039e13d82ed692a.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < (int)cb8c4aaa0c7b5c7060bef909242775e05.cc0906fa561b9c6076f6cb6643cecb5e3(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481))
					{
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c960481416fed68a0583768a5f2f273a8.c30767ddca1f9c207888833aea5b5fc61(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[c17ec3456233b988039e13d82ed692a.c6a39a3a73f94d8ccf49d40d0ffdd32e3]), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33810)))
						{
							goto IL_B2;
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
							RuntimeMethodHandle arg_7A_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.ca7267f77f694da9c94d7c38cba79cd64(object, EventArgs)).MethodHandle;
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c960481416fed68a0583768a5f2f273a8.c30767ddca1f9c207888833aea5b5fc61(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[c17ec3456233b988039e13d82ed692a.c6a39a3a73f94d8ccf49d40d0ffdd32e3]), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33825)))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									continue;
								}
								goto IL_B2;
							}
						}
						IL_156:
						c17ec3456233b988039e13d82ed692a.c6a39a3a73f94d8ccf49d40d0ffdd32e3 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3164);
						continue;
						IL_B2:
						object arg_D3_0 = this.c1e347ba2f15228ebe1c7428e3805746e;
						if (predicate == null)
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
							predicate = new Predicate<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99>(c17ec3456233b988039e13d82ed692a.c64676ab6fc7b8f3c3adab5c3fad18a7e);
						}
						int num = c2b83ddf4e9dcf235f60597d29992056c.c30767ddca1f9c207888833aea5b5fc61(arg_D3_0, predicate);
						if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3152))
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
							c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99 cc08badc360e35ed991884dc83e8bcb = new c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99();
							cc08badc360e35ed991884dc83e8bcb.c661432020c9835bb6d4eb0d9816118c7 = ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[c17ec3456233b988039e13d82ed692a.c6a39a3a73f94d8ccf49d40d0ffdd32e3];
							cc08badc360e35ed991884dc83e8bcb.c3f6e2cc486ab04cee90a0dbede2165c7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3156) != 0);
							c754bf7e7df154d4ce2e2765ae3844997.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e, cc08badc360e35ed991884dc83e8bcb);
							ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[c17ec3456233b988039e13d82ed692a.c6a39a3a73f94d8ccf49d40d0ffdd32e3] = null;
							goto IL_156;
						}
						c07a80a17a69096a593b53d2a808c2640.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e, num).c3f6e2cc486ab04cee90a0dbede2165c7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3160) != 0);
						goto IL_156;
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
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33848), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
				}
				finally
				{
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3168); i < (int)cb8c4aaa0c7b5c7060bef909242775e05.cc0906fa561b9c6076f6cb6643cecb5e3(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3172))
					{
						if (ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[i] != null)
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
							c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[i]);
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
					ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481 = ccf7efb9d3c09954db54589a458426d08.c8a754f5f2ca4adde825691a9c31a0e83;
				}
				while (true)
				{
					using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c688486d1a0a6459b5dd3db4ad6e7cebd))
					{
						try
						{
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3176); j < cc63566118149b59cac036d79a4a85789.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3184))
							{
								c07a80a17a69096a593b53d2a808c2640.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e, j).c3f6e2cc486ab04cee90a0dbede2165c7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3180) != 0);
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
							ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481 = c63ddbf7693d1919e0bc77777da0727ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							Predicate<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99> predicate2 = c8a9926bf78d21e05a88fc52c6273db34.c8a754f5f2ca4adde825691a9c31a0e83;
							c6f8ff5d4f5c381e05883cf5979fc7a94.ca6fd50779c01adc521487e25edbb4305 ca6fd50779c01adc521487e25edbb = new c6f8ff5d4f5c381e05883cf5979fc7a94.ca6fd50779c01adc521487e25edbb4305();
							ca6fd50779c01adc521487e25edbb.c4f736900843dca678d65905b7c78c141 = ca05a96fae46495300d09dbbfabc704ba;
							ca6fd50779c01adc521487e25edbb.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3188);
							while (ca6fd50779c01adc521487e25edbb.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < (int)cb8c4aaa0c7b5c7060bef909242775e05.cc0906fa561b9c6076f6cb6643cecb5e3(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481))
							{
								if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c960481416fed68a0583768a5f2f273a8.c30767ddca1f9c207888833aea5b5fc61(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[ca6fd50779c01adc521487e25edbb.c6a39a3a73f94d8ccf49d40d0ffdd32e3]), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33810)))
								{
									goto IL_333;
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
								if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c960481416fed68a0583768a5f2f273a8.c30767ddca1f9c207888833aea5b5fc61(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[ca6fd50779c01adc521487e25edbb.c6a39a3a73f94d8ccf49d40d0ffdd32e3]), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33825)))
								{
									while (true)
									{
										switch (5)
										{
										case 0:
											continue;
										}
										goto IL_333;
									}
								}
								IL_43D:
								ca6fd50779c01adc521487e25edbb.c6a39a3a73f94d8ccf49d40d0ffdd32e3 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3208);
								continue;
								IL_333:
								object arg_358_0 = this.c1e347ba2f15228ebe1c7428e3805746e;
								if (predicate2 == null)
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
									predicate2 = new Predicate<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99>(ca6fd50779c01adc521487e25edbb.c73ab43912151c270e0cb69ad3c7d68ed);
								}
								int num2 = c2b83ddf4e9dcf235f60597d29992056c.c30767ddca1f9c207888833aea5b5fc61(arg_358_0, predicate2);
								if (num2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3192))
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
									c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99 cc08badc360e35ed991884dc83e8bcb2 = new c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99();
									cc08badc360e35ed991884dc83e8bcb2.c661432020c9835bb6d4eb0d9816118c7 = ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[ca6fd50779c01adc521487e25edbb.c6a39a3a73f94d8ccf49d40d0ffdd32e3];
									cc08badc360e35ed991884dc83e8bcb2.c3f6e2cc486ab04cee90a0dbede2165c7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3196) != 0);
									c754bf7e7df154d4ce2e2765ae3844997.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e, cc08badc360e35ed991884dc83e8bcb2);
									ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[ca6fd50779c01adc521487e25edbb.c6a39a3a73f94d8ccf49d40d0ffdd32e3] = null;
									cec4dc845e772c3e699a057c528837cac.cffd79ab4d11be7165b8ae2b8a2588d93(cc530920b063b5d4fab405e1a07a0e00d.c30767ddca1f9c207888833aea5b5fc61(cc08badc360e35ed991884dc83e8bcb2.c661432020c9835bb6d4eb0d9816118c7), cd5d90d893c19637830fff5738e49367b.c30767ddca1f9c207888833aea5b5fc61(c6e250c748248b8f982c21ceb750281fd.c30767ddca1f9c207888833aea5b5fc61(c75328730d9d035b19c95759b8ee3212f.c30767ddca1f9c207888833aea5b5fc61(cc08badc360e35ed991884dc83e8bcb2.c661432020c9835bb6d4eb0d9816118c7), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3200))), c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), AppMain.ca691be15ac02d2fd13604941dfb1f495.get_c31e608ebd80ebdfff13b06d363a147ca());
									goto IL_43D;
								}
								c07a80a17a69096a593b53d2a808c2640.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e, num2).c3f6e2cc486ab04cee90a0dbede2165c7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3204) != 0);
								goto IL_43D;
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
							List<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99> list = this.c1e347ba2f15228ebe1c7428e3805746e.ToList<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99>();
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3212); k < cc63566118149b59cac036d79a4a85789.c30767ddca1f9c207888833aea5b5fc61(list); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3216))
							{
								if (!c07a80a17a69096a593b53d2a808c2640.c30767ddca1f9c207888833aea5b5fc61(list, k).c3f6e2cc486ab04cee90a0dbede2165c7)
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
									cbc1737f2f01189874eb91d96bf2c656a.c30767ddca1f9c207888833aea5b5fc61(this.c1e347ba2f15228ebe1c7428e3805746e, c07a80a17a69096a593b53d2a808c2640.c30767ddca1f9c207888833aea5b5fc61(list, k));
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
							c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3220));
						}
						catch (Exception ex2)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33848), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
						}
						finally
						{
							for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3224); l < (int)cb8c4aaa0c7b5c7060bef909242775e05.cc0906fa561b9c6076f6cb6643cecb5e3(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3228))
							{
								if (ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[l] != null)
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
									c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481[l]);
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
							ca05a96fae46495300d09dbbfabc704ba.c0997f5e2cce7379c4a480a5b85e7f481 = ccf7efb9d3c09954db54589a458426d08.c8a754f5f2ca4adde825691a9c31a0e83;
						}
					}
				}
			}
			catch (Exception ex3)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex3));
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000164E4 File Offset: 0x000146E4
		private unsafe void c40d01c6bd93d073870260dc0bdbad9a1(ref caa89d1e25f87c042482dcdcc09d37dbf ptr)
		{
			try
			{
				long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				while (num + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3244) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
				{
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3232));
					if (c3c52b590d5a6b81701ec601ef7e60c96.c30767ddca1f9c207888833aea5b5fc61(ptr))
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
							RuntimeMethodHandle arg_3A_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.c40d01c6bd93d073870260dc0bdbad9a1(caa89d1e25f87c042482dcdcc09d37dbf*)).MethodHandle;
						}
						num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
						while (num + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3240) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
						{
							c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3236));
							if (c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(ptr) != null)
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
								if (ce2c10522257f52114f38d47f845c1f9d.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(ptr)) != null)
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
									if (cdc8da9c7988b5ce9e6e2bf9a434f5338.c30767ddca1f9c207888833aea5b5fc61(ce2c10522257f52114f38d47f845c1f9d.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(ptr))) != 0)
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
										return;
									}
								}
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
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33925)));
				if (c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(ptr) != null)
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
					c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(ptr).c5e071fc90b6534e9e9071f415f5b7deb();
					if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(ptr)) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3248))
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
						IntPtr intPtr = cec4dc845e772c3e699a057c528837cac.ca84c9f7cd19983827150d2a88e125ce0((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3252), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3256), c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(ptr).cbcddc98bc608c531a1e08a77c2239014);
						if (c9b5db1f9452c42953cc648331810e0f7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, IntPtr.Zero))
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
							cec4dc845e772c3e699a057c528837cac.c5115425f2678e87547ed98d77f8aae32(intPtr, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3260));
						}
					}
				}
				if (c419207587ea5691d50d094df0cf8aeff.c30767ddca1f9c207888833aea5b5fc61(ptr) != null)
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
					c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(c419207587ea5691d50d094df0cf8aeff.c30767ddca1f9c207888833aea5b5fc61(ptr));
					c1d5104217b6952dfbe28a42b9b61952b.c30767ddca1f9c207888833aea5b5fc61(ptr, c3c22863565c125025a9c20f2fe463576.c8a754f5f2ca4adde825691a9c31a0e83);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00016700 File Offset: 0x00014900
		internal int cfd2a49c8778edc1af5a75028ae740e1a(CoreInternal coreInternal)
		{
			try
			{
				int result;
				if (!AppMain.stealthMode)
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
						RuntimeMethodHandle arg_1C_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.cfd2a49c8778edc1af5a75028ae740e1a(CoreInternal)).MethodHandle;
					}
					IntPtr intPtr = IntPtr.Zero;
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
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cffe2a8bb255aec1bd7efa50993853ce5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), ""))
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
							intPtr = cec4dc845e772c3e699a057c528837cac.c9655457401bec4c230615b85106e8ee7((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3264), IntPtr.Zero, (cec4dc845e772c3e699a057c528837cac.c948b0b453a5258059923cd545e75b290)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3268), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3272), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3276), cc4987d6a853db77954f21abe4e42946a.ca3131fe15e516b754d104bfe252f57d2(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cffe2a8bb255aec1bd7efa50993853ce5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33968), coreInternal.cbcddc98bc608c531a1e08a77c2239014)));
						}
						else
						{
							intPtr = cec4dc845e772c3e699a057c528837cac.c9655457401bec4c230615b85106e8ee7((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3280), IntPtr.Zero, (cec4dc845e772c3e699a057c528837cac.c948b0b453a5258059923cd545e75b290)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3284), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3288), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3292), cc4987d6a853db77954f21abe4e42946a.ca3131fe15e516b754d104bfe252f57d2(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33971), coreInternal.cbcddc98bc608c531a1e08a77c2239014)));
						}
					}
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
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33988));
						result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3296);
						return result;
					}
					IntPtr intPtr2 = cec4dc845e772c3e699a057c528837cac.c58836b2e1b25a85a75d9ce58408d6f60(intPtr, (cec4dc845e772c3e699a057c528837cac.c7d4b163fc6177d542dedf0bdbefac9e6)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3300), (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3304), (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3308), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3312));
					if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, IntPtr.Zero))
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
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34065));
						cec4dc845e772c3e699a057c528837cac.c996ecac411fc1bd70c8a73a503084eb1(intPtr);
						result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3316);
						return result;
					}
					cec4dc845e772c3e699a057c528837cac.c62c1df01c86325f30ed5f2649102feb0(intPtr2, ca85af1a479278cbee078f4e63b881d88.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3320)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3324));
					if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(coreInternal) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3328))
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
						cec4dc845e772c3e699a057c528837cac.c62c1df01c86325f30ed5f2649102feb0(cfdaf95033f542349edfafd4db09dfaf4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3332)), ca85af1a479278cbee078f4e63b881d88.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3336)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3340));
					}
					else if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(coreInternal) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3344))
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
						cec4dc845e772c3e699a057c528837cac.c62c1df01c86325f30ed5f2649102feb0(cfdaf95033f542349edfafd4db09dfaf4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3348)), ca85af1a479278cbee078f4e63b881d88.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3352)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3356));
					}
					else if (c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(coreInternal) == ClientVersion.NorthAmericaTrion)
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
						cec4dc845e772c3e699a057c528837cac.c62c1df01c86325f30ed5f2649102feb0(cfdaf95033f542349edfafd4db09dfaf4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3360)), ca85af1a479278cbee078f4e63b881d88.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3364)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3368));
					}
					int num = cec4dc845e772c3e699a057c528837cac.c0980fb152fc5b59c2f25679154714dd4(coreInternal.cbcddc98bc608c531a1e08a77c2239014, coreInternal.cdf5e08fadc218be7a68210704950a74c, coreInternal.cc21548a787787628744dfd6185ad16b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3372) != 0);
					if (num != 0)
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
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34142));
						cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34219)));
						result = num;
						return result;
					}
				}
				else
				{
					List<c3588145757b357d2914eb656b313ecae> list = AppMain.c184a42a74d25a49281e3c84092602419.c39c4123f5a98f990da5c03fbbe3eb316();
					if (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3376))
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
						bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3380) != 0;
						try
						{
							object ce7afbb9027bf2feb71f836f6a31f2d;
							cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3384)).ce7afbb9027bf2feb71f836f6a31f2d37, ref flag);
							c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3388)).c7c85ffa725f6bd0c310451137c8fc1b9 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3392);
							c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3396)).c43aac719d0149f545731db556e73774d = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3400) != 0);
							ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3404)).cc2cf678c05af30b3d1766fa545d867c1, new ccf8f2c8a6195ba89977c9a0243c10717(coreInternal.cbcddc98bc608c531a1e08a77c2239014, coreInternal.cdf5e08fadc218be7a68210704950a74c, coreInternal.cc21548a787787628744dfd6185ad16b2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3408) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3412) != 0).c442e09b1de2262d3a3a28826b3ea696f());
							long num2 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
							while (num2 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3424) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
							{
								c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3416));
								if (!c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3420)).c43aac719d0149f545731db556e73774d)
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
								}
								else
								{
									IL_48C:
									int num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3428);
									int num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3432);
									for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3436); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(coreInternal.cc21548a787787628744dfd6185ad16b2); i += num3)
									{
										num3 = num4;
										if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(coreInternal.cc21548a787787628744dfd6185ad16b2) - i < num4)
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
											num3 = (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(coreInternal.cc21548a787787628744dfd6185ad16b2) - i;
										}
										byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num3);
										cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(coreInternal.cc21548a787787628744dfd6185ad16b2, i, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3440), num3);
										ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3444)).cc2cf678c05af30b3d1766fa545d867c1, array);
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
									num2 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
									while (num2 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3460) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
									{
										c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3448));
										if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3452)).c7c85ffa725f6bd0c310451137c8fc1b9 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3456))
										{
											IL_5BD:
											result = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3464)).c7c85ffa725f6bd0c310451137c8fc1b9;
											return result;
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
									while (true)
									{
										switch (1)
										{
										case 0:
											continue;
										}
										goto IL_5BD;
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
								goto IL_48C;
							}
						}
						finally
						{
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
								object ce7afbb9027bf2feb71f836f6a31f2d;
								c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d);
							}
						}
					}
				}
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3468);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3472);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00016D5C File Offset: 0x00014F5C
		private void c87ead7afdc0005d3f3118253a66f9b82(CoreInternal coreInternal)
		{
			coreInternal.cc4ef9c5f8d2214270f53724194ca4ecc = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3476);
			coreInternal.cc27932479f48be0748f7d446f48f0f07 = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3480);
			coreInternal.c829c7209565df5f9063f3b57d042d9d8 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3484);
			c80cc460507e67629167e1f53916021d4.c30767ddca1f9c207888833aea5b5fc61(coreInternal, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3488));
			while (true)
			{
				coreInternal.cbfab0f98d5b8be994481d3ffac887574 = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3492);
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3496));
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00016DCC File Offset: 0x00014FCC
		private void ce62a153dc2ea41d9a4bf43bec4671473(CoreInternal ca124a9f406cda69b904f2eb04d553ab, c9dc78792fcb683123688a66f4d248388 c9dc78792fcb683123688a66f4d, string c020ee1f739dff0414faa6ff0d491a, bool flag = false)
		{
			Action action = c2cffb0c8c347f2a1edaa1274b624dbd1.c8a754f5f2ca4adde825691a9c31a0e83;
			c6f8ff5d4f5c381e05883cf5979fc7a94.c168f66beae98b93843d66f3c0edb9a7e c168f66beae98b93843d66f3c0edb9a7e = new c6f8ff5d4f5c381e05883cf5979fc7a94.c168f66beae98b93843d66f3c0edb9a7e();
			c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			c168f66beae98b93843d66f3c0edb9a7e.cb6ea3d298d68be569f5410cc290458d5 = this;
			try
			{
				Action action2 = c2cffb0c8c347f2a1edaa1274b624dbd1.c8a754f5f2ca4adde825691a9c31a0e83;
				c6f8ff5d4f5c381e05883cf5979fc7a94.c85ad9bc26a65c854377a8394961442de c85ad9bc26a65c854377a8394961442de = new c6f8ff5d4f5c381e05883cf5979fc7a94.c85ad9bc26a65c854377a8394961442de();
				c85ad9bc26a65c854377a8394961442de.ca13ea5b8c0547750c97040d78e7249d1 = c168f66beae98b93843d66f3c0edb9a7e;
				c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1 = new caa89d1e25f87c042482dcdcc09d37dbf();
				ConcurrentQueue<byte[]> concurrentQueue = cf29c9d6e10922dc54de12806c52119c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				cab29bf9fa0a696fa7c7de68b008df4f7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9);
				Socket socket = c3c22863565c125025a9c20f2fe463576.c8a754f5f2ca4adde825691a9c31a0e83;
				try
				{
					try
					{
						if (c9dc78792fcb683123688a66f4d != null)
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
								RuntimeMethodHandle arg_70_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.ce62a153dc2ea41d9a4bf43bec4671473(CoreInternal, c9dc78792fcb683123688a66f4d248388, string, bool)).MethodHandle;
							}
							c5a6d53b142acfaeeecc26ae4d9e1abec.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9, c9dc78792fcb683123688a66f4d.cde98427214599064c58cb5a4de8ecc6b);
							caa0c865bb90e07152fb827dd6be7e3e4.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9, c9dc78792fcb683123688a66f4d.cadb0be687ce11e2be1869999f35a7141);
							cf1e69052de7d68e1d5f5e026527baad5.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9, c9dc78792fcb683123688a66f4d.cb5466a044809fda944eb67b4c5d2c8f6);
							ca06e3c577d09113d9d5067148278e4d5.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9, c9dc78792fcb683123688a66f4d.caee1e47a08a4ecec009fb2516f979104);
						}
						c9f9a0ce68f56e6d990c4dc55cc3fa684.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9, flag);
						c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c788468c0f1361a00c09677914a79d73b = concurrentQueue;
						if (action == null)
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
							action = new Action(c168f66beae98b93843d66f3c0edb9a7e.c8c9ab598f85283f644085b45a07004a3);
						}
						c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(action));
						try
						{
							cee185df2f5f3c50864542569f2a88882 cee185df2f5f3c50864542569f2a = new cee185df2f5f3c50864542569f2a88882();
							try
							{
								c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c7471c18db8249d8432f95be3c73ee3e4 = cc4987d6a853db77954f21abe4e42946a.c44404630230d632cc1782fa6b9646782(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfc1e8c78928ad9777e22eb776ca6f8ac.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34252)));
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34287), c9cfd598d1712a6220818729a2a2659e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c7471c18db8249d8432f95be3c73ee3e4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364))));
							}
							finally
							{
								if (cee185df2f5f3c50864542569f2a != null)
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
									cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(cee185df2f5f3c50864542569f2a);
								}
							}
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
						}
						c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c020ee1f739dff0414faa6ff0d491a861 = c020ee1f739dff0414faa6ff0d491a;
						if (!c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.cb9bee7ab2befff3f328e33fff595f928())
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
						}
						else
						{
							if (!AppMain.stealthMode)
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
								c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c38f3d3e5357d7fc2e018511436727f39();
							}
							bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3500) != 0;
							List<string>.Enumerator enumerator = cbd7f5eb574999eafdd8a5b63a44cc710.c30767ddca1f9c207888833aea5b5fc61(AppMain.c171d18a06650cc6b347444a27380b664);
							try
							{
								while (c1bb6cc98796d8d4181cc6bba94633365.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
								{
									string text = c2dc720158dc10f45ac968d21a22604ce.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
									flag2 = this.c4b7def4dc3ae9ca90c99e01c2e042f99(text, c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9);
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
										cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34369)));
										ca9da53c53cd9394538731aadfa8ff8bd.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.get_c6d3245f73bf863e367279ca41e9306c2(), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3504));
										ca2a5993eaf85d7ae6e06538abb8a3d02.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9, c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.get_c6d3245f73bf863e367279ca41e9306c2().GetProductInstances<Core>());
										cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34392)), ceacd362cb3e25acef568623449d63594.c30767ddca1f9c207888833aea5b5fc61(c0d3f140a9df6c454307f702ba69fbb7f.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9)), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34421))));
										IEnumerable<ProductInstance<Core>> expr_2EC = c0d3f140a9df6c454307f702ba69fbb7f.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9);
										if (c6f8ff5d4f5c381e05883cf5979fc7a94.ce9ee8537ea58b20c573a53b55d1db676 == null)
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
											c6f8ff5d4f5c381e05883cf5979fc7a94.ce9ee8537ea58b20c573a53b55d1db676 = new Func<ProductInstance<Core>, bool>(c6f8ff5d4f5c381e05883cf5979fc7a94.cbc66e81668e346f5fad784588f06715e);
										}
										IEnumerator<ProductInstance<Core>> enumerator2 = c3f100db771752e4840890652d84a99a0.c30767ddca1f9c207888833aea5b5fc61(expr_2EC.Where(c6f8ff5d4f5c381e05883cf5979fc7a94.ce9ee8537ea58b20c573a53b55d1db676));
										try
										{
											while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
											{
												ProductInstance<Core> productInstance = c2386c0395d83a534bfdfc80cf930174a.c30767ddca1f9c207888833aea5b5fc61(enumerator2);
												cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c21dc4f26741bed7d05cf42a99cd66fc3.c30767ddca1f9c207888833aea5b5fc61(productInstance), AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34450))));
												IEnumerator<string> enumerator3 = c1b3fa2093b700e8c8c4cb50ba38621ae.c30767ddca1f9c207888833aea5b5fc61(c9c100ac6deb5a4ee196b577839e453d5.c30767ddca1f9c207888833aea5b5fc61(productInstance));
												try
												{
													while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator3))
													{
														string text2 = cb92b7a954b61829047746aaa25104d33.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
														cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(text2);
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
													if (enumerator3 != null)
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
														cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator3);
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
											goto IL_3FD;
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
										continue;
										IL_3FD:
										goto IL_40D;
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
							}
							finally
							{
								((IDisposable)enumerator).Dispose();
							}
							IL_40D:
							if (flag2)
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
								if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.ce0cb7d52f0a504108194936ffb0071d5, ""))
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
								}
								else
								{
									c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c64fe08857caae6ddbb3d2571b99849b2 = c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1;
									CoreInternal expr_4B8 = c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9;
									expr_4B8.cafe8b34078feded66d7676075b1d5cd2 = (short)((int)expr_4B8.cafe8b34078feded66d7676075b1d5cd2 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3520));
									c35dc7e206815e39931520a6d9841a6cf.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c3c22863565c125025a9c20f2fe463576.c8a754f5f2ca4adde825691a9c31a0e83);
									socket = cfd8d6ed5f17bd7f35ffd8cc7a436e956.c0cf59c3e67a46fd4edb3040c5ab0bbfb((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3524), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3528), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3532));
									IPEndPoint iPEndPoint;
									if (AppMain.stealthMode)
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
										iPEndPoint = c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c8356eb01945238ea2828cd429765eba8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c85435ac0da2a74e097537acfaf6abaa8), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3536));
									}
									else
									{
										iPEndPoint = c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c8356eb01945238ea2828cd429765eba8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c1713506da7330ce4279cfbade77b3c25), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3540));
									}
									c4fdbb5f9678e390877ab4423d27cca08.c30767ddca1f9c207888833aea5b5fc61(socket, iPEndPoint);
									IPEndPoint iPEndPoint2 = c34ef5f360ebd2b82bfce469249378171.cea69e7c4d1a729bd5783221de1566e79(c35450ffc0b84ef5b46a49533433e3f85.c30767ddca1f9c207888833aea5b5fc61(socket));
									IntPtr intPtr = IntPtr.Zero;
									string text3 = cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c4c3b2cc97bbc75d47b79ebf5d860bcac.c30767ddca1f9c207888833aea5b5fc61(iPEndPoint2));
									c96553709655a1c6339284d2c20ca0272.c30767ddca1f9c207888833aea5b5fc61(socket, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3544));
									c8eacb4315a560252f29ee4d6685a796a.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9);
									c1d5104217b6952dfbe28a42b9b61952b.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, socket);
									cb30deed457a98c4fa44096a1470f5c02.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3548) != 0);
									if (!AppMain.stealthMode)
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
										if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cffe2a8bb255aec1bd7efa50993853ce5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), ""))
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
											intPtr = cec4dc845e772c3e699a057c528837cac.c9655457401bec4c230615b85106e8ee7((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3552), IntPtr.Zero, (cec4dc845e772c3e699a057c528837cac.c948b0b453a5258059923cd545e75b290)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3556), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3560), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3564), cc4987d6a853db77954f21abe4e42946a.ca3131fe15e516b754d104bfe252f57d2(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cffe2a8bb255aec1bd7efa50993853ce5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34504))));
										}
										else
										{
											intPtr = cec4dc845e772c3e699a057c528837cac.c9655457401bec4c230615b85106e8ee7((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3568), IntPtr.Zero, (cec4dc845e772c3e699a057c528837cac.c948b0b453a5258059923cd545e75b290)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3572), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3576), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3580), cc4987d6a853db77954f21abe4e42946a.ca3131fe15e516b754d104bfe252f57d2(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34507)));
										}
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
											cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34524));
											return;
										}
										IntPtr intPtr2 = cec4dc845e772c3e699a057c528837cac.c58836b2e1b25a85a75d9ce58408d6f60(intPtr, (cec4dc845e772c3e699a057c528837cac.c7d4b163fc6177d542dedf0bdbefac9e6)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3584), (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3588), (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3592), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3596));
										if (c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, IntPtr.Zero))
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
											cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34065));
											cec4dc845e772c3e699a057c528837cac.c996ecac411fc1bd70c8a73a503084eb1(intPtr);
											return;
										}
										cec4dc845e772c3e699a057c528837cac.c62c1df01c86325f30ed5f2649102feb0(intPtr2, ca85af1a479278cbee078f4e63b881d88.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c2eb881e38377e1beea3199655fe8ba0e.c30767ddca1f9c207888833aea5b5fc61(iPEndPoint2)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3600));
										cec4dc845e772c3e699a057c528837cac.c62c1df01c86325f30ed5f2649102feb0(cfdaf95033f542349edfafd4db09dfaf4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3604)), cf131990a85633b75f8cef825cda9b558.c0cf59c3e67a46fd4edb3040c5ab0bbfb((short)((byte)c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text3))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3608));
										cec4dc845e772c3e699a057c528837cac.c62c1df01c86325f30ed5f2649102feb0(cfdaf95033f542349edfafd4db09dfaf4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3612)), cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(c36524408369b1f168b4cc1966a1fdde1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text3), c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text3));
									}
									else
									{
										List<c3588145757b357d2914eb656b313ecae> list = AppMain.c184a42a74d25a49281e3c84092602419.c39c4123f5a98f990da5c03fbbe3eb316();
										if (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3616))
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
											int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3620);
											if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3624))
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
												num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3628);
											}
											else if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3632))
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
												num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3636);
											}
											else if (c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9) == ClientVersion.NorthAmericaTrion)
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
												num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3640);
											}
											bool flag3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3644) != 0;
											try
											{
												object ce7afbb9027bf2feb71f836f6a31f2d;
												cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3648)).ce7afbb9027bf2feb71f836f6a31f2d37, ref flag3);
												ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3652)).cc2cf678c05af30b3d1766fa545d867c1, new c33c514ac714014bd83df8e3e99a0cdfc(c2eb881e38377e1beea3199655fe8ba0e.c30767ddca1f9c207888833aea5b5fc61(iPEndPoint2), text3, num, c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1).cbcddc98bc608c531a1e08a77c2239014).c442e09b1de2262d3a3a28826b3ea696f());
											}
											finally
											{
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
													object ce7afbb9027bf2feb71f836f6a31f2d;
													c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d);
												}
											}
										}
									}
									if (!c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.cef934a093220ae1da6e85bd74b805c28())
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
										cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34601), c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.cb79ab8e60f9f8d878ce8227a47de8165, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34642)));
										return;
									}
									if ((int)c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3656))
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
										if (!c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c679783d328425ab0237d84fb567e6a96())
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
											cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34645), c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.ca0436972bc325dce0f1e8bfcb5a4c84c, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34642)));
											return;
										}
									}
									if (c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != cdddb0b97541c52448b8f0b50995b8c8e.c5d1f82e4a69c8c5b03513685e289c8d9)
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
										int num2 = this.cfd2a49c8778edc1af5a75028ae740e1a(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9);
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
											cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34601), num2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34642)));
											return;
										}
									}
									if (action2 == null)
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
										action2 = new Action(c85ad9bc26a65c854377a8394961442de.c24adf12c18dcda26600bf549c962236d);
									}
									c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9e571ec0f4e7f99b5c7531c72bd1849b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(action2, (TaskCreationOptions)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3660)));
									c35dc7e206815e39931520a6d9841a6cf.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, cf238c4c864cf841ef0a5cc21081d5caf.c30767ddca1f9c207888833aea5b5fc61(socket));
									c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34692));
									cb30deed457a98c4fa44096a1470f5c02.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3664) != 0);
									byte[] expr_ADC = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3668));
									c21512aadbc438e0c34236fbd1c52da3b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_ADC, fieldof(cecebbe15a82731eb2f8453f1b7665d70.c6919dc958c14d648d7f9d296752be465).FieldHandle);
									byte[] array = expr_ADC;
									byte[] array2 = ca85af1a479278cbee078f4e63b881d88.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c2eb881e38377e1beea3199655fe8ba0e.c30767ddca1f9c207888833aea5b5fc61(AppMain.cefaf2377ddae43302a659b50e17da74a.c6a083c1145e013bc4ecca22c69f09584));
									cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3672), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3676), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3680));
									ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(concurrentQueue, array);
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34735), c2eb881e38377e1beea3199655fe8ba0e.c30767ddca1f9c207888833aea5b5fc61(AppMain.cefaf2377ddae43302a659b50e17da74a.c6a083c1145e013bc4ecca22c69f09584)));
									cb5941ec5aec6a35ce954a38e3118d51f.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3684) != 0);
									c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1), c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3688), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3692), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3696), new AsyncCallback(this.cd00415385725c74f8189835af191ebc7), c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1);
									if (!AppMain.stealthMode)
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
										cec4dc845e772c3e699a057c528837cac.c996ecac411fc1bd70c8a73a503084eb1(intPtr);
									}
									while (ce4127ff4562044e7653b9b6a17098b79.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1))
									{
										if (cf964d045e4379ba37f86ea5d2267af59.c30767ddca1f9c207888833aea5b5fc61(concurrentQueue) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3700))
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
											byte[] array3;
											if (!c5a18bac908512210d39308d605ae7073.c30767ddca1f9c207888833aea5b5fc61(concurrentQueue, ref array3))
											{
												continue;
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
											try
											{
												cac6b8c3b1ea48900349fbec519fe3e12.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1), array3);
												continue;
											}
											catch (Exception)
											{
												this.cdecf9d73ed6132077497efbc3dfbd4d5(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1);
												continue;
											}
										}
										c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3704));
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
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34812));
									goto IL_CBE;
								}
							}
							cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34483)));
							IntPtr intPtr3 = cec4dc845e772c3e699a057c528837cac.ca84c9f7cd19983827150d2a88e125ce0((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3508), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3512), c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.cbcddc98bc608c531a1e08a77c2239014);
							cec4dc845e772c3e699a057c528837cac.c5115425f2678e87547ed98d77f8aae32(intPtr3, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3516));
						}
					}
					catch (Exception ex2)
					{
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34889), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
						cb5941ec5aec6a35ce954a38e3118d51f.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3708) != 0);
					}
					IL_CBE:;
				}
				finally
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34966));
					if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3712))
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
						IntPtr intPtr4 = cec4dc845e772c3e699a057c528837cac.ca84c9f7cd19983827150d2a88e125ce0((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3716), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3720), c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.cbcddc98bc608c531a1e08a77c2239014);
						cec4dc845e772c3e699a057c528837cac.c5115425f2678e87547ed98d77f8aae32(intPtr4, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3724));
					}
					if (c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1) != null)
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
						c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1).c5e071fc90b6534e9e9071f415f5b7deb();
						c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3728));
					}
					try
					{
						if (c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
							if (c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9) != null)
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
								if (!c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9.c620fb7b8de910fd4b3080680f9c6ef1f)
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
									if (c177a686ad55f295d802bff78dbce3bcd.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3732))
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
										if (c944a27236c2efb01defe04ac32bbd0a6.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3736))))
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
											if (c490d30743924216b4140dc9e0668c03c.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9)))
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
												if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd2981219d9304634dc490316aa4695c0.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3740))), ""))
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
													AppMain.cf90e986fccc09efa49b9af3c2b42eb24.c8025f5cbdb8e3f7cc9a20e987bf536cc(cd2981219d9304634dc490316aa4695c0.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3744))), c76f4323760dfa197639d83bafbcac26f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5ed5eb6cfb3fdbfb944a0f27e016d2a5.c30767ddca1f9c207888833aea5b5fc61(c03c5f5b17f92c655f4f782610387a873.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9).c2f1e2e68ec46be47d05255e6932cba19, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3748)))));
												}
											}
										}
									}
								}
							}
						}
					}
					catch (Exception ex3)
					{
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex3));
					}
					if (c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
						caadd57139a0d14fe78749f1138395ea3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9);
						c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9);
					}
					c1d5104217b6952dfbe28a42b9b61952b.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c3c22863565c125025a9c20f2fe463576.c8a754f5f2ca4adde825691a9c31a0e83);
					c8eacb4315a560252f29ee4d6685a796a.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1, c49603cd9629f69a6585d48b4afcaf58c.c8a754f5f2ca4adde825691a9c31a0e83);
					c168f66beae98b93843d66f3c0edb9a7e.ca124a9f406cda69b904f2eb04d553ab9 = c49603cd9629f69a6585d48b4afcaf58c.c8a754f5f2ca4adde825691a9c31a0e83;
					if (c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1) != null)
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
							c06acd1de5b9bd9dd5c62573b3618ebe1.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1), (SocketShutdown)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3752));
						}
						catch
						{
						}
						try
						{
							c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(c85ad9bc26a65c854377a8394961442de.c061584329e98296ca83f13da7fe2c5c1));
						}
						catch
						{
						}
					}
					if (socket != null)
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
						c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(socket);
					}
				}
			}
			catch (Exception ex4)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex4));
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00017EFC File Offset: 0x000160FC
		private void cd00415385725c74f8189835af191ebc7(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3756);
			caa89d1e25f87c042482dcdcc09d37dbf caa89d1e25f87c042482dcdcc09d37dbf = ce486d8a7d28fd1a18690cd5de39df563.c9963fcf210a214a3206d6500f3b9397b(ca90a62187262fc9162ce77328fee1c8c.c30767ddca1f9c207888833aea5b5fc61(asyncResult));
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf), asyncResult);
				caa89d1e25f87c042482dcdcc09d37dbf expr_2D = caa89d1e25f87c042482dcdcc09d37dbf;
				expr_2D.c6bab70b8125f6af8a7a3089cae33a5e1 += (ushort)num;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35043));
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
				return;
			}
			if ((int)caa89d1e25f87c042482dcdcc09d37dbf.c6bab70b8125f6af8a7a3089cae33a5e1 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3760))
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
					RuntimeMethodHandle arg_90_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.cd00415385725c74f8189835af191ebc7(IAsyncResult)).MethodHandle;
				}
				try
				{
					caa89d1e25f87c042482dcdcc09d37dbf.c4aa766a148d8699c681b84ca2c51a28a = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(caa89d1e25f87c042482dcdcc09d37dbf.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3764));
					caa89d1e25f87c042482dcdcc09d37dbf.c09689fc25739533f05afa6e0d105defb = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3768);
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf), caa89d1e25f87c042482dcdcc09d37dbf.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3772), (int)caa89d1e25f87c042482dcdcc09d37dbf.c4aa766a148d8699c681b84ca2c51a28a, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3776), new AsyncCallback(this.c5e0be7254ef3d5c76770db4724213053), caa89d1e25f87c042482dcdcc09d37dbf);
					return;
				}
				catch (Exception ex2)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35120), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
					this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
					return;
				}
			}
			if ((int)caa89d1e25f87c042482dcdcc09d37dbf.c6bab70b8125f6af8a7a3089cae33a5e1 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3780))
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
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf), caa89d1e25f87c042482dcdcc09d37dbf.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3784), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3788), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3792), new AsyncCallback(this.cd00415385725c74f8189835af191ebc7), caa89d1e25f87c042482dcdcc09d37dbf);
					return;
				}
				catch (Exception ex3)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35120), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex3)));
					this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
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
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35197));
				this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00018110 File Offset: 0x00016310
		private void c5e0be7254ef3d5c76770db4724213053(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3796);
			caa89d1e25f87c042482dcdcc09d37dbf caa89d1e25f87c042482dcdcc09d37dbf = ce486d8a7d28fd1a18690cd5de39df563.c9963fcf210a214a3206d6500f3b9397b(ca90a62187262fc9162ce77328fee1c8c.c30767ddca1f9c207888833aea5b5fc61(asyncResult));
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf), asyncResult);
				caa89d1e25f87c042482dcdcc09d37dbf expr_2D = caa89d1e25f87c042482dcdcc09d37dbf;
				expr_2D.c09689fc25739533f05afa6e0d105defb += (ushort)num;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35274));
				this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
				return;
			}
			if (caa89d1e25f87c042482dcdcc09d37dbf.c09689fc25739533f05afa6e0d105defb == caa89d1e25f87c042482dcdcc09d37dbf.c4aa766a148d8699c681b84ca2c51a28a)
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
					RuntimeMethodHandle arg_8C_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.c5e0be7254ef3d5c76770db4724213053(IAsyncResult)).MethodHandle;
				}
				try
				{
					ushort num2 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(caa89d1e25f87c042482dcdcc09d37dbf.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3800));
					caa89d1e25f87c042482dcdcc09d37dbf.c6bab70b8125f6af8a7a3089cae33a5e1 = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3804);
					byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)caa89d1e25f87c042482dcdcc09d37dbf.c09689fc25739533f05afa6e0d105defb + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3808));
					cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(caa89d1e25f87c042482dcdcc09d37dbf.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3812), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3816), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
					this.cbf7a4962b3c0aaf1a574a0a08705cbab(num2, array, caa89d1e25f87c042482dcdcc09d37dbf);
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf), caa89d1e25f87c042482dcdcc09d37dbf.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3820), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3824), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3828), new AsyncCallback(this.cd00415385725c74f8189835af191ebc7), caa89d1e25f87c042482dcdcc09d37dbf);
					return;
				}
				catch (Exception ex2)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35351), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2)));
					this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
					return;
				}
			}
			if (num == 0)
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
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35428));
				this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
				return;
			}
			try
			{
				c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf), caa89d1e25f87c042482dcdcc09d37dbf.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3832) + (int)caa89d1e25f87c042482dcdcc09d37dbf.c09689fc25739533f05afa6e0d105defb, (int)(caa89d1e25f87c042482dcdcc09d37dbf.c4aa766a148d8699c681b84ca2c51a28a - caa89d1e25f87c042482dcdcc09d37dbf.c09689fc25739533f05afa6e0d105defb), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3836), new AsyncCallback(this.c5e0be7254ef3d5c76770db4724213053), caa89d1e25f87c042482dcdcc09d37dbf);
			}
			catch (Exception ex3)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35351), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex3)));
				this.cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf);
				return;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001835C File Offset: 0x0001655C
		private void cdecf9d73ed6132077497efbc3dfbd4d5(caa89d1e25f87c042482dcdcc09d37dbf caa89d1e25f87c042482dcdcc09d37dbf)
		{
			try
			{
				c06acd1de5b9bd9dd5c62573b3618ebe1.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf), (SocketShutdown)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3840));
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			try
			{
				c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(c318dc0f265f384a1a9068e6a44440428.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf));
			}
			catch (Exception ex2)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
			}
			cb5941ec5aec6a35ce954a38e3118d51f.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3844) != 0);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000183E0 File Offset: 0x000165E0
		public void c69149edd5a14bc7b105744098d403c6f(caa89d1e25f87c042482dcdcc09d37dbf c061584329e98296ca83f13da7fe2c5c, ushort cadb0be687ce11e2be1869999f35a, int cf67a4f448dbe9371adbccafc36628cee, string c390f90d3aefa173b3ae20d82ed431f)
		{
			c6f8ff5d4f5c381e05883cf5979fc7a94.cd8cff14f232f3ba5c59cdf1698197481 cd8cff14f232f3ba5c59cdf = new c6f8ff5d4f5c381e05883cf5979fc7a94.cd8cff14f232f3ba5c59cdf1698197481();
			cd8cff14f232f3ba5c59cdf.c061584329e98296ca83f13da7fe2c5c1 = c061584329e98296ca83f13da7fe2c5c;
			cd8cff14f232f3ba5c59cdf.cadb0be687ce11e2be1869999f35a7141 = cadb0be687ce11e2be1869999f35a;
			cd8cff14f232f3ba5c59cdf.cf67a4f448dbe9371adbccafc36628cee = cf67a4f448dbe9371adbccafc36628cee;
			cd8cff14f232f3ba5c59cdf.c390f90d3aefa173b3ae20d82ed431f43 = c390f90d3aefa173b3ae20d82ed431f;
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(cd8cff14f232f3ba5c59cdf.ca6f02e5bde710c49304874c9a5c355a1)));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00018428 File Offset: 0x00016628
		public void cbf7a4962b3c0aaf1a574a0a08705cbab(ushort num, byte[] array, caa89d1e25f87c042482dcdcc09d37dbf caa89d1e25f87c042482dcdcc09d37dbf)
		{
			if ((int)num <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3848))
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
					RuntimeMethodHandle arg_23_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.cbf7a4962b3c0aaf1a574a0a08705cbab(ushort, byte[], caa89d1e25f87c042482dcdcc09d37dbf)).MethodHandle;
				}
				switch ((int)num - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3852))
				{
				case 0:
				{
					int num2 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3876));
					int num3 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3880));
					int num4 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3884));
					int num5 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3888));
					int num6 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3892));
					string[] array2 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3896));
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3900)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35505);
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3904)] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3908)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35582);
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3912)] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3916)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35582);
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3920)] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num4, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3924)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35582);
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3928)] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num5, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3932)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35582);
					array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3936)] = cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num6, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364));
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2));
					return;
				}
				case 1:
					break;
				default:
					if ((int)num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3856))
					{
						byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3940));
						byte[] array4 = c7d19159535b8ba95efe224e27f4d871a.c8a754f5f2ca4adde825691a9c31a0e83;
						int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3944);
						uint num8 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3948);
						try
						{
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3952), array3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3956), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3960));
							num7 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3964));
							array4 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num7 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3968));
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3972), array4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3976), num7);
							cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cdd41d119be5c074974c21453ee1166ad.c0cf59c3e67a46fd4edb3040c5ab0bbfb((ushort)num7), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3980), array4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3984), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3988));
							num8 = c961357f9cc9cb93480ce6f84616b4622.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3992) + num7);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
						}
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3996); i < cea2caa8b48d4f0a6077a0e54ae189dff.c30767ddca1f9c207888833aea5b5fc61(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4012))
						{
							if (c3bd2124cef7326e395f7b11a317304f8.c30767ddca1f9c207888833aea5b5fc61(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf)), i).c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4000))
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
								c2a0bb8d20168111c233ee12ca7af9c8b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3, c3bd2124cef7326e395f7b11a317304f8.c30767ddca1f9c207888833aea5b5fc61(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf)), i).c47dc3a0f13384bdb971697c22b6b0dce, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4004));
								if (num8 != 0u)
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
									c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).c25707350e53809d65a8adce01953824b = num8;
								}
								c3bd2124cef7326e395f7b11a317304f8.c30767ddca1f9c207888833aea5b5fc61(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf)), i).c6b2434d29371283846a5de37a7f8783c(array4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4008) != 0);
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
					if ((int)num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3860))
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
						return;
					}
					c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).cf97cfca00aedbb73f89dc3850d2bdc9b = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4016));
					return;
				}
			}
			else if ((int)num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3864))
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
				if ((int)num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3868))
				{
					ushort num9 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4020));
					c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4024));
					int num10 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4028));
					int num11 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4032));
					string text = c37e74a116004bd81dbe9680059f95c31.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4036), num11);
					this.c69149edd5a14bc7b105744098d403c6f(caa89d1e25f87c042482dcdcc09d37dbf, num9, num10, text);
					return;
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
				if ((int)num != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(3872))
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
					return;
				}
				int num12 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4040));
				if (num12 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4044))
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
					if (num12 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4048))
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
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35585), cfaf3396824bdd0fa2d0f5c106f484bc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num12, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34364))));
						c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).c5e071fc90b6534e9e9071f415f5b7deb();
						return;
					}
				}
			}
			else if (!AppMain.stealthMode)
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
				int num13 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4052));
				int num14 = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4056));
				c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).c068bd40f65fd3f4bb12aa4844cbfd5be = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4060) != 0);
				if (num13 == 0)
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
					if (num14 == 0)
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
						Process[] array5 = c63ddbf7693d1919e0bc77777da0727ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4064); j < (int)cb8c4aaa0c7b5c7060bef909242775e05.cc0906fa561b9c6076f6cb6643cecb5e3(array5); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4076))
						{
							if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c960481416fed68a0583768a5f2f273a8.c30767ddca1f9c207888833aea5b5fc61(array5[j]), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33825), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4068) != 0) == 0)
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
								num14 = cd5d90d893c19637830fff5738e49367b.c30767ddca1f9c207888833aea5b5fc61(c6e250c748248b8f982c21ceb750281fd.c30767ddca1f9c207888833aea5b5fc61(c75328730d9d035b19c95759b8ee3212f.c30767ddca1f9c207888833aea5b5fc61(array5[j]), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4072)));
								num13 = cc530920b063b5d4fab405e1a07a0e00d.c30767ddca1f9c207888833aea5b5fc61(array5[j]);
								IL_69F:
								for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4080); k < (int)cb8c4aaa0c7b5c7060bef909242775e05.cc0906fa561b9c6076f6cb6643cecb5e3(array5); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4084))
								{
									if (array5[k] != null)
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
										c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(array5[k]);
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
								array5 = ccf7efb9d3c09954db54589a458426d08.c8a754f5f2ca4adde825691a9c31a0e83;
								goto IL_6F6;
							}
						}
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							goto IL_69F;
						}
					}
				}
				IL_6F6:
				int num15 = cec4dc845e772c3e699a057c528837cac.c0980fb152fc5b59c2f25679154714dd4(num13, num14, c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).cd97167f3ac5c3dcbdb3359a66bff828f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4088) != 0);
				if (num15 != 0)
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
					cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35662), num15));
					return;
				}
			}
			else
			{
				List<c3588145757b357d2914eb656b313ecae> list = AppMain.c184a42a74d25a49281e3c84092602419.c39c4123f5a98f990da5c03fbbe3eb316();
				if (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4092))
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
					bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4096) != 0;
					try
					{
						object ce7afbb9027bf2feb71f836f6a31f2d;
						cc24c4df755c2998e53400f211804f8b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d = c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4100)).ce7afbb9027bf2feb71f836f6a31f2d37, ref flag);
						c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4104)).c7c85ffa725f6bd0c310451137c8fc1b9 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4108);
						c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4112)).c43aac719d0149f545731db556e73774d = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4116) != 0);
						ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4120)).cc2cf678c05af30b3d1766fa545d867c1, new ccf8f2c8a6195ba89977c9a0243c10717(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4124), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4128), c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).cd97167f3ac5c3dcbdb3359a66bff828f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4132) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4136) != 0).c442e09b1de2262d3a3a28826b3ea696f());
						long num16 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
						while (num16 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4148) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
						{
							c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4140));
							if (!c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4144)).c43aac719d0149f545731db556e73774d)
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
								IL_8AA:
								int num17 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4152);
								int num18 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4156);
								for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4160); l < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).cd97167f3ac5c3dcbdb3359a66bff828f); l += num17)
								{
									num17 = num18;
									if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).cd97167f3ac5c3dcbdb3359a66bff828f) - l < num18)
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
										num17 = (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).cd97167f3ac5c3dcbdb3359a66bff828f) - l;
									}
									byte[] array6 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num17);
									cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(caa89d1e25f87c042482dcdcc09d37dbf).cd97167f3ac5c3dcbdb3359a66bff828f, l, array6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4164), num17);
									ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4168)).cc2cf678c05af30b3d1766fa545d867c1, array6);
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
								num16 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
								while (num16 + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4184) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
								{
									c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4172));
									if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4176)).c7c85ffa725f6bd0c310451137c8fc1b9 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4180))
									{
										IL_9F9:
										if (c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4188)).c7c85ffa725f6bd0c310451137c8fc1b9 != 0)
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
											cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(35662), c4537458bfc0d05065d9b6dfe171c7a5b.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(4192)).c7c85ffa725f6bd0c310451137c8fc1b9));
										}
										return;
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
									switch (5)
									{
									case 0:
										continue;
									}
									goto IL_9F9;
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
							goto IL_8AA;
						}
					}
					finally
					{
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
							object ce7afbb9027bf2feb71f836f6a31f2d;
							c42ebf842bef2de52a05a728849437b48.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce7afbb9027bf2feb71f836f6a31f2d);
						}
					}
				}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00018ED4 File Offset: 0x000170D4
		[CompilerGenerated]
		private static bool cbc66e81668e346f5fad784588f06715e(ProductInstance<Core> productInstance)
		{
			return c5643ddf65713dd727df093959d31bf43.c30767ddca1f9c207888833aea5b5fc61(productInstance);
		}

		// Token: 0x040000ED RID: 237
		internal object c5aab3caea0c40520688765f5a71a0c1c = new object();

		// Token: 0x040000EE RID: 238
		internal object c688486d1a0a6459b5dd3db4ad6e7cebd = new object();

		// Token: 0x040000EF RID: 239
		private List<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99> c1e347ba2f15228ebe1c7428e3805746e = new List<c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99>();

		// Token: 0x040000F0 RID: 240
		[CompilerGenerated]
		private static Func<ProductInstance<Core>, bool> ce9ee8537ea58b20c573a53b55d1db676;

		// Token: 0x02000042 RID: 66
		private sealed class cc08badc360e35ed991884dc83e8bcb99
		{
			// Token: 0x040000F1 RID: 241
			public Process c661432020c9835bb6d4eb0d9816118c7;

			// Token: 0x040000F2 RID: 242
			public bool c3f6e2cc486ab04cee90a0dbede2165c7;
		}

		// Token: 0x02000574 RID: 1396
		[CompilerGenerated]
		private sealed class c1f6084e74bb648ebd4fbc207c3813b4a
		{
			// Token: 0x06001F6D RID: 8045 RVA: 0x001435C8 File Offset: 0x001417C8
			public bool c3988e911fc5ceb56ede343aeabb03b73(AuthService authService)
			{
				bool result;
				try
				{
					c36e701a421193c878ae80797454731f7.c30767ddca1f9c207888833aea5b5fc61(authService, this.ce3df70de321b8392b0460e330fec2219.ce0cb7d52f0a504108194936ffb0071d5);
					c8f212332cda7e3c464627b416320df0a.c30767ddca1f9c207888833aea5b5fc61(authService);
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97528) != 0);
				}
				catch (Exception)
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97532) != 0);
				}
				return result;
			}

			// Token: 0x040014C5 RID: 5317
			public CoreInternal ce3df70de321b8392b0460e330fec2219;
		}

		// Token: 0x02000575 RID: 1397
		[CompilerGenerated]
		private sealed class c7cf0459cb1064c32f7e234356af19643
		{
			// Token: 0x06001F6F RID: 8047 RVA: 0x00143630 File Offset: 0x00141830
			public bool c121ac0dc34c4e6dceefe1943c7884ac4(AuthService authService)
			{
				c36e701a421193c878ae80797454731f7.c30767ddca1f9c207888833aea5b5fc61(authService, this.ca124a9f406cda69b904f2eb04d553ab9.ce0cb7d52f0a504108194936ffb0071d5);
				r0 r = cb26432ef80654ee8e1f1f34ff6fc6358.c30767ddca1f9c207888833aea5b5fc61(authService, c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97536)));
				if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c6a7d7de06389ca0c2bd1b860eabc93e2.c30767ddca1f9c207888833aea5b5fc61(r), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201962)))
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
						RuntimeMethodHandle arg_5A_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.c7cf0459cb1064c32f7e234356af19643.c121ac0dc34c4e6dceefe1943c7884ac4(AuthService)).MethodHandle;
					}
					if (!c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(c35684689f284b0dfa046ebcdcbc9fc5f.c30767ddca1f9c207888833aea5b5fc61(c6a7d7de06389ca0c2bd1b860eabc93e2.c30767ddca1f9c207888833aea5b5fc61(r)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201995)))
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
						if (c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(c35684689f284b0dfa046ebcdcbc9fc5f.c30767ddca1f9c207888833aea5b5fc61(c6a7d7de06389ca0c2bd1b860eabc93e2.c30767ddca1f9c207888833aea5b5fc61(r)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202034)))
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
						}
						else
						{
							if (!ccb95e28a5a6007c8883f459c9143d066.c30767ddca1f9c207888833aea5b5fc61(r))
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
								c8f212332cda7e3c464627b416320df0a.c30767ddca1f9c207888833aea5b5fc61(authService);
								return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97544) != 0;
							}
							this.ca124a9f406cda69b904f2eb04d553ab9.cc55838d9da9186fb9f5c1551b2c5b591 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
							return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97548) != 0;
						}
					}
				}
				cd5ccdafabd22ea92453fb2ea9ecb201c.c30767ddca1f9c207888833aea5b5fc61(authService);
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97540) != 0;
			}

			// Token: 0x040014C6 RID: 5318
			public CoreInternal ca124a9f406cda69b904f2eb04d553ab9;
		}

		// Token: 0x02000576 RID: 1398
		[CompilerGenerated]
		private sealed class c6e812442ed3949264fd463efb8aca681
		{
			// Token: 0x06001F71 RID: 8049 RVA: 0x00143760 File Offset: 0x00141960
			public bool c7814549b8933750a59a04da73a4e3b88(AuthService authService)
			{
				c36e701a421193c878ae80797454731f7.c30767ddca1f9c207888833aea5b5fc61(authService, this.ca124a9f406cda69b904f2eb04d553ab9.ce0cb7d52f0a504108194936ffb0071d5);
				c8f212332cda7e3c464627b416320df0a.c30767ddca1f9c207888833aea5b5fc61(authService);
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97552) != 0;
			}

			// Token: 0x040014C7 RID: 5319
			public CoreInternal ca124a9f406cda69b904f2eb04d553ab9;
		}

		// Token: 0x02000577 RID: 1399
		[CompilerGenerated]
		private sealed class cd702cb789cfab322dd253f4765c5aa8c
		{
			// Token: 0x06001F73 RID: 8051 RVA: 0x001437A8 File Offset: 0x001419A8
			public bool c896c5ee6ff34d8fbf1b077f755b933e3(AuthService authService)
			{
				bool result;
				try
				{
					c36e701a421193c878ae80797454731f7.c30767ddca1f9c207888833aea5b5fc61(authService, c3bf89ead22b49e97ceac77f0e22314a3.c8a754f5f2ca4adde825691a9c31a0e83);
					c8f212332cda7e3c464627b416320df0a.c30767ddca1f9c207888833aea5b5fc61(authService);
					d0 d = c1f3c32f13befeb27e89909e356aef5d3.c30767ddca1f9c207888833aea5b5fc61(authService, this.c03f8978984671fce959e74a1d566ffa6, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97556), (long)this.ca124a9f406cda69b904f2eb04d553ab9.c383ed460f57ab72ac577b10e96b0a731);
					if (ccb95e28a5a6007c8883f459c9143d066.c30767ddca1f9c207888833aea5b5fc61(d))
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
							RuntimeMethodHandle arg_55_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.cd702cb789cfab322dd253f4765c5aa8c.c896c5ee6ff34d8fbf1b077f755b933e3(AuthService)).MethodHandle;
						}
						c36e701a421193c878ae80797454731f7.c30767ddca1f9c207888833aea5b5fc61(authService, cb104ab32545b9a4f3a225d48cc06ba69.c30767ddca1f9c207888833aea5b5fc61(c36524408369b1f168b4cc1966a1fdde1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cf0118d6709f1ba702d9d453ff77f2024.c30767ddca1f9c207888833aea5b5fc61(d)));
						this.ca124a9f406cda69b904f2eb04d553ab9.ce0cb7d52f0a504108194936ffb0071d5 = cb104ab32545b9a4f3a225d48cc06ba69.c30767ddca1f9c207888833aea5b5fc61(c36524408369b1f168b4cc1966a1fdde1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cf0118d6709f1ba702d9d453ff77f2024.c30767ddca1f9c207888833aea5b5fc61(d));
						this.ca124a9f406cda69b904f2eb04d553ab9.cc55838d9da9186fb9f5c1551b2c5b591 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97560) != 0);
					}
					else
					{
						c8f212332cda7e3c464627b416320df0a.c30767ddca1f9c207888833aea5b5fc61(authService);
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97564) != 0);
					}
				}
				catch (Exception)
				{
					c36e701a421193c878ae80797454731f7.c30767ddca1f9c207888833aea5b5fc61(authService, c3bf89ead22b49e97ceac77f0e22314a3.c8a754f5f2ca4adde825691a9c31a0e83);
					c8f212332cda7e3c464627b416320df0a.c30767ddca1f9c207888833aea5b5fc61(authService);
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97568) != 0);
				}
				return result;
			}

			// Token: 0x040014C8 RID: 5320
			public string c03f8978984671fce959e74a1d566ffa6;

			// Token: 0x040014C9 RID: 5321
			public CoreInternal ca124a9f406cda69b904f2eb04d553ab9;
		}

		// Token: 0x02000578 RID: 1400
		[CompilerGenerated]
		private sealed class c5625d06068c6c3b42d438bb01826b615
		{
			// Token: 0x06001F75 RID: 8053 RVA: 0x001438C4 File Offset: 0x00141AC4
			public void cec6ac64b656148ca436254c37769554d()
			{
				this.cb6ea3d298d68be569f5410cc290458d5.ce62a153dc2ea41d9a4bf43bec4671473(this.ca124a9f406cda69b904f2eb04d553ab9, this.c8a12ec6aaaa9d79fcdc7c5dabdc3e283, this.c020ee1f739dff0414faa6ff0d491a861, this.cb050160a072148ba779287efae9f1533);
			}

			// Token: 0x040014CA RID: 5322
			public CoreInternal ca124a9f406cda69b904f2eb04d553ab9;

			// Token: 0x040014CB RID: 5323
			public c6f8ff5d4f5c381e05883cf5979fc7a94 cb6ea3d298d68be569f5410cc290458d5;

			// Token: 0x040014CC RID: 5324
			public c9dc78792fcb683123688a66f4d248388 c8a12ec6aaaa9d79fcdc7c5dabdc3e283;

			// Token: 0x040014CD RID: 5325
			public bool cb050160a072148ba779287efae9f1533;

			// Token: 0x040014CE RID: 5326
			public string c020ee1f739dff0414faa6ff0d491a861;
		}

		// Token: 0x02000579 RID: 1401
		[CompilerGenerated]
		private sealed class ca05a96fae46495300d09dbbfabc704ba
		{
			// Token: 0x040014CF RID: 5327
			public Process[] c0997f5e2cce7379c4a480a5b85e7f481;
		}

		// Token: 0x0200057A RID: 1402
		[CompilerGenerated]
		private sealed class c17ec3456233b988039e13d82ed692a62
		{
			// Token: 0x06001F78 RID: 8056 RVA: 0x0014391C File Offset: 0x00141B1C
			public bool c64676ab6fc7b8f3c3adab5c3fad18a7e(c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99 cc08badc360e35ed991884dc83e8bcb)
			{
				return cc530920b063b5d4fab405e1a07a0e00d.c30767ddca1f9c207888833aea5b5fc61(cc08badc360e35ed991884dc83e8bcb.c661432020c9835bb6d4eb0d9816118c7) == cc530920b063b5d4fab405e1a07a0e00d.c30767ddca1f9c207888833aea5b5fc61(this.c4f736900843dca678d65905b7c78c141.c0997f5e2cce7379c4a480a5b85e7f481[this.c6a39a3a73f94d8ccf49d40d0ffdd32e3]);
			}

			// Token: 0x040014D0 RID: 5328
			public c6f8ff5d4f5c381e05883cf5979fc7a94.ca05a96fae46495300d09dbbfabc704ba c4f736900843dca678d65905b7c78c141;

			// Token: 0x040014D1 RID: 5329
			public int c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x0200057B RID: 1403
		[CompilerGenerated]
		private sealed class ca6fd50779c01adc521487e25edbb4305
		{
			// Token: 0x06001F7A RID: 8058 RVA: 0x00143968 File Offset: 0x00141B68
			public bool c73ab43912151c270e0cb69ad3c7d68ed(c6f8ff5d4f5c381e05883cf5979fc7a94.cc08badc360e35ed991884dc83e8bcb99 cc08badc360e35ed991884dc83e8bcb)
			{
				return cc530920b063b5d4fab405e1a07a0e00d.c30767ddca1f9c207888833aea5b5fc61(cc08badc360e35ed991884dc83e8bcb.c661432020c9835bb6d4eb0d9816118c7) == cc530920b063b5d4fab405e1a07a0e00d.c30767ddca1f9c207888833aea5b5fc61(this.c4f736900843dca678d65905b7c78c141.c0997f5e2cce7379c4a480a5b85e7f481[this.c6a39a3a73f94d8ccf49d40d0ffdd32e3]);
			}

			// Token: 0x040014D2 RID: 5330
			public c6f8ff5d4f5c381e05883cf5979fc7a94.ca05a96fae46495300d09dbbfabc704ba c4f736900843dca678d65905b7c78c141;

			// Token: 0x040014D3 RID: 5331
			public int c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x0200057C RID: 1404
		[CompilerGenerated]
		private sealed class c168f66beae98b93843d66f3c0edb9a7e
		{
			// Token: 0x06001F7C RID: 8060 RVA: 0x001439B4 File Offset: 0x00141BB4
			public void c8c9ab598f85283f644085b45a07004a3()
			{
				this.cb6ea3d298d68be569f5410cc290458d5.c87ead7afdc0005d3f3118253a66f9b82(this.ca124a9f406cda69b904f2eb04d553ab9);
			}

			// Token: 0x040014D4 RID: 5332
			public c6f8ff5d4f5c381e05883cf5979fc7a94 cb6ea3d298d68be569f5410cc290458d5;

			// Token: 0x040014D5 RID: 5333
			public CoreInternal ca124a9f406cda69b904f2eb04d553ab9;
		}

		// Token: 0x0200057D RID: 1405
		[CompilerGenerated]
		private sealed class c85ad9bc26a65c854377a8394961442de
		{
			// Token: 0x06001F7E RID: 8062 RVA: 0x001439E8 File Offset: 0x00141BE8
			public void c24adf12c18dcda26600bf549c962236d()
			{
				this.ca13ea5b8c0547750c97040d78e7249d1.cb6ea3d298d68be569f5410cc290458d5.c40d01c6bd93d073870260dc0bdbad9a1(ref this.c061584329e98296ca83f13da7fe2c5c1);
			}

			// Token: 0x040014D6 RID: 5334
			public c6f8ff5d4f5c381e05883cf5979fc7a94.c168f66beae98b93843d66f3c0edb9a7e ca13ea5b8c0547750c97040d78e7249d1;

			// Token: 0x040014D7 RID: 5335
			public caa89d1e25f87c042482dcdcc09d37dbf c061584329e98296ca83f13da7fe2c5c1;
		}

		// Token: 0x0200057F RID: 1407
		[CompilerGenerated]
		private sealed class cd8cff14f232f3ba5c59cdf1698197481
		{
			// Token: 0x06001F80 RID: 8064 RVA: 0x00143A20 File Offset: 0x00141C20
			public void ca6f02e5bde710c49304874c9a5c355a1()
			{
				ce2273b18037425a98b6298f82c7a60d4 ce2273b18037425a98b6298f82c7a60d = c5b5ff9a98a44d1dd81ecc4dcd5df438e.c8a754f5f2ca4adde825691a9c31a0e83;
				long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202075), this.cf67a4f448dbe9371adbccafc36628cee));
				IL_10C:
				while (num + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97584) > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
				{
					List<ce2273b18037425a98b6298f82c7a60d4> list = AppMain.cefaf2377ddae43302a659b50e17da74a.c39c4123f5a98f990da5c03fbbe3eb316();
					int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97572);
					while (i < cea2caa8b48d4f0a6077a0e54ae189dff.c30767ddca1f9c207888833aea5b5fc61(list))
					{
						try
						{
							if (c3bd2124cef7326e395f7b11a317304f8.c30767ddca1f9c207888833aea5b5fc61(list, i).ceff49fbc891446de9ca39b0e1111edc9 != null)
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
									RuntimeMethodHandle arg_75_0 = methodof(c6f8ff5d4f5c381e05883cf5979fc7a94.cd8cff14f232f3ba5c59cdf1698197481.ca6f02e5bde710c49304874c9a5c355a1()).MethodHandle;
								}
								if (this.cf67a4f448dbe9371adbccafc36628cee == c2eb881e38377e1beea3199655fe8ba0e.c30767ddca1f9c207888833aea5b5fc61(c34ef5f360ebd2b82bfce469249378171.cea69e7c4d1a729bd5783221de1566e79(cd7633c7e55019bb6cf8408ac5d417e1f.c30767ddca1f9c207888833aea5b5fc61(c3bd2124cef7326e395f7b11a317304f8.c30767ddca1f9c207888833aea5b5fc61(list, i).ceff49fbc891446de9ca39b0e1111edc9))))
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
									ce2273b18037425a98b6298f82c7a60d = c3bd2124cef7326e395f7b11a317304f8.c30767ddca1f9c207888833aea5b5fc61(list, i);
									goto IL_F0;
								}
							}
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
						}
						i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97576);
						continue;
						IL_F0:
						if (ce2273b18037425a98b6298f82c7a60d == null)
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
							c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97580));
							goto IL_10C;
						}
						goto IL_12F;
					}
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						goto IL_F0;
					}
					IL_12F:
					if (ce2273b18037425a98b6298f82c7a60d != null)
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
						cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202152));
						ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8 = this.cadb0be687ce11e2be1869999f35a7141;
						ce2273b18037425a98b6298f82c7a60d.c322d8db8e16fc088c7def3e10c67f59d = this.c390f90d3aefa173b3ae20d82ed431f43;
						if ((int)ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97588))
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
							ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 = (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97592);
						}
						else if ((int)ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97596))
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
							ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 = (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97600);
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ce2273b18037425a98b6298f82c7a60d.c322d8db8e16fc088c7def3e10c67f59d, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202229)))
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
								ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 = (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97604);
							}
						}
						else if ((int)ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97608))
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
							ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 = (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97612);
						}
						else
						{
							ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 = (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97616);
						}
						if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7e997c70fc1ae8d838f7c0e1ea365962.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1)), ""))
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
								ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51.set_c2e96ff56abcd3d7f7073d3a369aaeb2f((c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97620));
								IPAddress[] array = c286dcc59ed3cd1f2607fb8fb05f634fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7e997c70fc1ae8d838f7c0e1ea365962.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1)));
								if ((int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array) == 0)
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
									return;
								}
								c1ed5474087b1d7ca8d3449a42b8e0dd5.c30767ddca1f9c207888833aea5b5fc61(ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97624)], (int)c515d9e3439e844de697a0eea205e0adb.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1))));
								ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51.set_c77f6d5110881e0ded8ecd7133324227a(c094bfa873a289c79f42929790afa2c84.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1)));
								ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51.set_c451994856b7e775630c666d59938ad1c(cd21169fa34289edb80c1e32649a207b6.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1)));
								if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97628))
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
									if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97632))
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
										if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97636))
										{
											goto IL_424;
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
								object[] array2 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97640));
								array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97644)] = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(71171));
								array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97648)] = c7e997c70fc1ae8d838f7c0e1ea365962.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1));
								array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97652)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
								array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97656)] = c515d9e3439e844de697a0eea205e0adb.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1));
								cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2));
								IL_424:;
							}
							catch
							{
								if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97660))
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
									if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97664))
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
										if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97668))
										{
											goto IL_49B;
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
								cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(71348)));
								IL_49B:;
							}
						}
						try
						{
							bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97672) != 0;
							int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97676);
							IL_75C:
							while (!flag)
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
								if (num2 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97788))
								{
									while (true)
									{
										switch (3)
										{
										case 0:
											continue;
										}
										goto IL_785;
									}
								}
								else
								{
									object[] array3 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97680));
									array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97684)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202254);
									array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97688)] = ce2273b18037425a98b6298f82c7a60d.c322d8db8e16fc088c7def3e10c67f59d;
									array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97692)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
									array3[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97696)] = ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8;
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array3));
									ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51.c963205f48624dc045b80d2b8b74f89b9(ce2273b18037425a98b6298f82c7a60d.c322d8db8e16fc088c7def3e10c67f59d, (int)ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8);
									for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97700); j < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97716); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97712))
									{
										if (cf8341a4434a0e70bba1373cee9cd19d6.c30767ddca1f9c207888833aea5b5fc61(ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51))
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
											flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97704) != 0);
											IL_5BA:
											if (!flag)
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
												c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51);
												ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51 = new c7726724dac34cb3ce4268099f7ee4ca1((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97720), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97724), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97728));
												c62eeeda7511b89b0e89a32f8bdb1a63c.c30767ddca1f9c207888833aea5b5fc61(ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97732) != 0);
											}
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
												object[] array4 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97736));
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97740)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202331);
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97744)] = num2;
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97748)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202408);
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97752)] = this.c390f90d3aefa173b3ae20d82ed431f43;
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97756)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
												array4[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97760)] = this.cadb0be687ce11e2be1869999f35a7141;
												cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array4));
											}
											else
											{
												object[] array5 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97764));
												array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97768)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202485);
												array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97772)] = ce2273b18037425a98b6298f82c7a60d.c322d8db8e16fc088c7def3e10c67f59d;
												array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97776)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
												array5[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97780)] = ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8;
												cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array5));
											}
											num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97784);
											goto IL_75C;
										}
										c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97708));
									}
									while (true)
									{
										switch (4)
										{
										case 0:
											continue;
										}
										goto IL_5BA;
									}
								}
							}
							IL_785:
							if (!flag)
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
								if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97792))
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
									if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97796))
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
										if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97800))
										{
											goto IL_877;
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
								object[] array6 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97804));
								array6[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97808)] = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(71868));
								array6[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97812)] = this.c390f90d3aefa173b3ae20d82ed431f43;
								array6[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97816)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
								array6[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97820)] = this.cadb0be687ce11e2be1869999f35a7141;
								cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array6));
								IL_877:
								ce2273b18037425a98b6298f82c7a60d.c40c3ae6fb0c8718ec3856e7758595db4();
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
								if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97824))
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
									if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97828))
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
										if (ce2273b18037425a98b6298f82c7a60d.c68326be62adc96106ff21f9b228e0b16 != (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97832))
										{
											goto IL_96F;
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
								object[] array7 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97836));
								array7[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97840)] = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(72356));
								array7[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97844)] = ce2273b18037425a98b6298f82c7a60d.c322d8db8e16fc088c7def3e10c67f59d;
								array7[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97848)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
								array7[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97852)] = ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8;
								cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array7));
							}
							IL_96F:
							ce2273b18037425a98b6298f82c7a60d.ca124a9f406cda69b904f2eb04d553ab9 = c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1);
							using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1))))
							{
								c1de064a1e9229c0c40a2c085d90eb919.c30767ddca1f9c207888833aea5b5fc61(cef7101bd90eb8d2a596f1be60002cc5b.c30767ddca1f9c207888833aea5b5fc61(c493bce537d8b79a5342f4c37046d1674.c30767ddca1f9c207888833aea5b5fc61(this.c061584329e98296ca83f13da7fe2c5c1)), ce2273b18037425a98b6298f82c7a60d);
							}
							ce2273b18037425a98b6298f82c7a60d.c9925b7e3d2d5a9f55e20eb9d66e48b84 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97856) != 0);
							object[] array8 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97860));
							array8[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97864)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202562);
							array8[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97868)] = this.c390f90d3aefa173b3ae20d82ed431f43;
							array8[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97872)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
							array8[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97876)] = this.cadb0be687ce11e2be1869999f35a7141;
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array8));
							if (cf8341a4434a0e70bba1373cee9cd19d6.c30767ddca1f9c207888833aea5b5fc61(ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51))
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
								if (ce2273b18037425a98b6298f82c7a60d.cb4f0837f50a1892690ece677ffb37154 > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97880))
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
									int num3 = cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(ce2273b18037425a98b6298f82c7a60d.cf75e98cf853fd7155fa03e958b4d2f51, ce2273b18037425a98b6298f82c7a60d.cab67fc397bacec5b4a9e250ac92ec169, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97884), ce2273b18037425a98b6298f82c7a60d.cb4f0837f50a1892690ece677ffb37154, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97888));
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202639), num3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202716)));
									cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cc4987d6a853db77954f21abe4e42946a.c833052bfbdfe807c941a746864ac7a34(ce2273b18037425a98b6298f82c7a60d.cab67fc397bacec5b4a9e250ac92ec169, ce2273b18037425a98b6298f82c7a60d.cb4f0837f50a1892690ece677ffb37154));
									ce2273b18037425a98b6298f82c7a60d.cb4f0837f50a1892690ece677ffb37154 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97892);
								}
							}
							else
							{
								cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202793));
							}
							return;
						}
						catch (Exception ex2)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
							object[] array9 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97896));
							array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97900)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202870);
							array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97904)] = this.c390f90d3aefa173b3ae20d82ed431f43;
							array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97908)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
							array9[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97912)] = this.cadb0be687ce11e2be1869999f35a7141;
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array9));
							if ((int)ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97916))
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
								if ((int)ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97920))
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
									if ((int)ce2273b18037425a98b6298f82c7a60d.ca96b616148cfd62622c216532bda8fa8 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97924))
									{
										goto IL_C9B;
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
							object[] array10 = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97928));
							array10[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97932)] = AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(71868));
							array10[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97936)] = this.c390f90d3aefa173b3ae20d82ed431f43;
							array10[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97940)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119054);
							array10[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97944)] = this.cadb0be687ce11e2be1869999f35a7141;
							cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array10));
							IL_C9B:
							ce2273b18037425a98b6298f82c7a60d.c40c3ae6fb0c8718ec3856e7758595db4();
							return;
						}
					}
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(202947));
					return;
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					goto IL_12F;
				}
			}

			// Token: 0x04001506 RID: 5382
			public caa89d1e25f87c042482dcdcc09d37dbf c061584329e98296ca83f13da7fe2c5c1;

			// Token: 0x04001507 RID: 5383
			public ushort cadb0be687ce11e2be1869999f35a7141;

			// Token: 0x04001508 RID: 5384
			public int cf67a4f448dbe9371adbccafc36628cee;

			// Token: 0x04001509 RID: 5385
			public string c390f90d3aefa173b3ae20d82ed431f43;
		}
	}
}
