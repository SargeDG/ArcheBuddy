using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004D9 RID: 1241
	public class TradeInfo : BaseObject
	{
		// Token: 0x060014D7 RID: 5335 RVA: 0x000B7E98 File Offset: 0x000B6098
		internal TradeInfo()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48236));
			this.ca39f2e8ca6dda4ec17f3e6ceb08873cd = new List<Item>();
			this.c3cdc58a8f9c17e5be30f9e5bdcee1020 = new List<Item>();
			cd81c551e03b02210b7ab88dcaa802d33.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
			c5ff7668a513885c641b2ffe50c285b84.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48240) != 0);
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000B7EEC File Offset: 0x000B60EC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(TradeInfo.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48220); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48224))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd, i));
								c85eddde945202b0ca0a5ffd332a26f3a.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd, i, cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83);
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
							ce94d42ee9d1f4e52d9a322d2b923d01c.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd);
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c3cdc58a8f9c17e5be30f9e5bdcee1020))
						{
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48228); j < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.c3cdc58a8f9c17e5be30f9e5bdcee1020); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48232))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.c3cdc58a8f9c17e5be30f9e5bdcee1020, j));
								c85eddde945202b0ca0a5ffd332a26f3a.c30767ddca1f9c207888833aea5b5fc61(this.c3cdc58a8f9c17e5be30f9e5bdcee1020, j, cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83);
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
							ce94d42ee9d1f4e52d9a322d2b923d01c.c30767ddca1f9c207888833aea5b5fc61(this.c3cdc58a8f9c17e5be30f9e5bdcee1020);
						}
						cd81c551e03b02210b7ab88dcaa802d33.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x000B809C File Offset: 0x000B629C
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x000B80B0 File Offset: 0x000B62B0
		public Creature obj
		{
			get;
			internal set;
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000B80C4 File Offset: 0x000B62C4
		public List<Item> getItems()
		{
			List<Item> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd))
			{
				result = this.ca39f2e8ca6dda4ec17f3e6ceb08873cd.ToList<Item>();
			}
			return result;
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x000B8110 File Offset: 0x000B6310
		internal List<Item> get_cacbaa35d25d410d86c30b4ae8a318175()
		{
			return this.ca39f2e8ca6dda4ec17f3e6ceb08873cd;
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x000B8124 File Offset: 0x000B6324
		internal void set_cacbaa35d25d410d86c30b4ae8a318175(List<Item> list)
		{
			this.ca39f2e8ca6dda4ec17f3e6ceb08873cd = list;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x000B8138 File Offset: 0x000B6338
		public List<Item> getOtherItems()
		{
			List<Item> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c3cdc58a8f9c17e5be30f9e5bdcee1020))
			{
				result = this.c3cdc58a8f9c17e5be30f9e5bdcee1020.ToList<Item>();
			}
			return result;
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000B8184 File Offset: 0x000B6384
		internal List<Item> get_cb23cd2d1e607fd2e18cf6e25fd6038b4()
		{
			return this.c3cdc58a8f9c17e5be30f9e5bdcee1020;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000B8198 File Offset: 0x000B6398
		internal void set_cb23cd2d1e607fd2e18cf6e25fd6038b4(List<Item> list)
		{
			this.c3cdc58a8f9c17e5be30f9e5bdcee1020 = list;
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x000B81AC File Offset: 0x000B63AC
		// (set) Token: 0x060014E2 RID: 5346 RVA: 0x000B81C0 File Offset: 0x000B63C0
		public int goldCount
		{
			get;
			internal set;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060014E3 RID: 5347 RVA: 0x000B81D4 File Offset: 0x000B63D4
		// (set) Token: 0x060014E4 RID: 5348 RVA: 0x000B81E8 File Offset: 0x000B63E8
		public int otherGoldCount
		{
			get;
			internal set;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060014E5 RID: 5349 RVA: 0x000B81FC File Offset: 0x000B63FC
		// (set) Token: 0x060014E6 RID: 5350 RVA: 0x000B8210 File Offset: 0x000B6410
		public bool isOpened
		{
			get;
			internal set;
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060014E7 RID: 5351 RVA: 0x000B8224 File Offset: 0x000B6424
		// (set) Token: 0x060014E8 RID: 5352 RVA: 0x000B8238 File Offset: 0x000B6438
		public bool isLocked
		{
			get;
			internal set;
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x000B824C File Offset: 0x000B644C
		// (set) Token: 0x060014EA RID: 5354 RVA: 0x000B8260 File Offset: 0x000B6460
		public bool isOtherLocked
		{
			get;
			internal set;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x000B8274 File Offset: 0x000B6474
		// (set) Token: 0x060014EC RID: 5356 RVA: 0x000B8288 File Offset: 0x000B6488
		public bool IsTradeOk
		{
			get;
			internal set;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x000B829C File Offset: 0x000B649C
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x000B82B0 File Offset: 0x000B64B0
		public bool IsOtherTradeOk
		{
			get;
			internal set;
		}

		// Token: 0x04000EFE RID: 3838
		internal uint c9d0b81af0b4d9ec454b66f1b3d12988f;

		// Token: 0x04000EFF RID: 3839
		private List<Item> ca39f2e8ca6dda4ec17f3e6ceb08873cd;

		// Token: 0x04000F00 RID: 3840
		private List<Item> c3cdc58a8f9c17e5be30f9e5bdcee1020;

		// Token: 0x04000F01 RID: 3841
		[CompilerGenerated]
		private Creature ce913c2dfec58303831760e235a3546d4;

		// Token: 0x04000F02 RID: 3842
		[CompilerGenerated]
		private int c9114ba2117515dbd588dca5244164954;

		// Token: 0x04000F03 RID: 3843
		[CompilerGenerated]
		private int c35d8146699215d2f4195339a2117bd93;

		// Token: 0x04000F04 RID: 3844
		[CompilerGenerated]
		private bool c9d0e869ac9bcc9599b6ce6d4807e086b;

		// Token: 0x04000F05 RID: 3845
		[CompilerGenerated]
		private bool c590f2383e0f38549c95f5a4f6768aa3c;

		// Token: 0x04000F06 RID: 3846
		[CompilerGenerated]
		private bool ccaae5cb04c5f49aa3378e547fb4b7236;

		// Token: 0x04000F07 RID: 3847
		[CompilerGenerated]
		private bool c30be59367a9fefdb8fe6faecf3ca964a;

		// Token: 0x04000F08 RID: 3848
		[CompilerGenerated]
		private bool c7aec9237c11757f175247fff1f618628;
	}
}
