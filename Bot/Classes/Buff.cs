using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004B6 RID: 1206
	public class Buff : Effect
	{
		// Token: 0x06001173 RID: 4467 RVA: 0x000A24F4 File Offset: 0x000A06F4
		internal Buff(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39420));
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			c7f0c0ed1dcdfab31f88846b041ce201b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SqlPassiveBuff());
			cf8a7faaeda74ee1adfaba004e94163a9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39424) != 0);
			this.cfa1b727722147a9517233e775214bceb = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39428);
			this.c421fb20deb3493b7354efc883436c236 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000A2558 File Offset: 0x000A0758
		internal void c4aaf7619a600d569451f27c0b2b78918()
		{
			c58eee13440be7ab7d92d4e3503f33924.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c49133ee635fa22b97b5aa956e3e528d6.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (caee422a0f78e3ccef39aacfa7a2d5f6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39380))
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
					RuntimeMethodHandle arg_33_0 = methodof(Buff.c4aaf7619a600d569451f27c0b2b78918()).MethodHandle;
				}
				try
				{
					if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), caee422a0f78e3ccef39aacfa7a2d5f6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						c58eee13440be7ab7d92d4e3503f33924.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), caee422a0f78e3ccef39aacfa7a2d5f6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x000A2608 File Offset: 0x000A0808
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Buff.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						c58eee13440be7ab7d92d4e3503f33924.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ceb34869bd44eec3a6e0e716ea622822f.c8a754f5f2ca4adde825691a9c31a0e83);
						c7f0c0ed1dcdfab31f88846b041ce201b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c9b24addd7be9ba1d6a0bbf04a18d17ae.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x000A267C File Offset: 0x000A087C
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x000A2690 File Offset: 0x000A0890
		public SqlPassiveBuff dbPassiveBuff
		{
			get;
			internal set;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x000A26A4 File Offset: 0x000A08A4
		public long buffTime()
		{
			if (cf4d174e661ef4b1ee9a19690800f9ac5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39384))
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
					RuntimeMethodHandle arg_27_0 = methodof(Buff.buffTime()).MethodHandle;
				}
				return (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39388);
			}
			return c3e113f934d4e854abddda6af5ffd87cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000A26F0 File Offset: 0x000A08F0
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x000A2704 File Offset: 0x000A0904
		public SqlBuff db
		{
			get;
			internal set;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x000A2718 File Offset: 0x000A0918
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x000A272C File Offset: 0x000A092C
		public bool isPassive
		{
			get;
			internal set;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000A2740 File Offset: 0x000A0940
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x000A2754 File Offset: 0x000A0954
		internal int buffType
		{
			get;
			set;
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000A2768 File Offset: 0x000A0968
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x000A277C File Offset: 0x000A097C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000A2790 File Offset: 0x000A0990
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x000A27A4 File Offset: 0x000A09A4
		public long duration
		{
			get;
			internal set;
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x000A27B8 File Offset: 0x000A09B8
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x000A27CC File Offset: 0x000A09CC
		public long maxDuration
		{
			get;
			internal set;
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x000A27E0 File Offset: 0x000A09E0
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x000A27F4 File Offset: 0x000A09F4
		public int charge
		{
			get;
			internal set;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x000A2808 File Offset: 0x000A0A08
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x000A281C File Offset: 0x000A0A1C
		public int stack
		{
			get;
			internal set;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x000A2830 File Offset: 0x000A0A30
		public string name
		{
			get
			{
				if (c5d9078af416e003e3ae50fb9d1550cb8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Buff.get_name()).MethodHandle;
					}
					return "";
				}
				return c51bacd72fd295eb6f8efbeeaf531c1f3.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x000A2870 File Offset: 0x000A0A70
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x000A2884 File Offset: 0x000A0A84
		internal uint tick
		{
			get;
			set;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x000A2898 File Offset: 0x000A0A98
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x000A28AC File Offset: 0x000A0AAC
		internal int maxCharge
		{
			get;
			set;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000A28C0 File Offset: 0x000A0AC0
		public bool CancelBuff()
		{
			try
			{
				c63388af3ed6138acfab0a9f83ba092f5 c63388af3ed6138acfab0a9f83ba092f = new c63388af3ed6138acfab0a9f83ba092f5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.cc0a4bf9facb0939a4d64d81a1df9680c, c2ddbe454b04d472c2b341c527f3d1e04.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39392), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39396));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c63388af3ed6138acfab0a9f83ba092f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39400) != 0);
				return this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39404), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39408));
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39412));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39416) != 0;
		}

		// Token: 0x04000D72 RID: 3442
		internal uint cc0a4bf9facb0939a4d64d81a1df9680c;

		// Token: 0x04000D73 RID: 3443
		internal uint cfa1b727722147a9517233e775214bceb;

		// Token: 0x04000D74 RID: 3444
		[CompilerGenerated]
		private SqlPassiveBuff ca1613e898bdc2949d7876af34cd36a05;

		// Token: 0x04000D75 RID: 3445
		[CompilerGenerated]
		private SqlBuff cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x04000D76 RID: 3446
		[CompilerGenerated]
		private bool c697d1f900fba0b4966142bd84b547981;

		// Token: 0x04000D77 RID: 3447
		[CompilerGenerated]
		private int c6c11bd2092ef5c1fe5fbc9bb4aa5f6ff;

		// Token: 0x04000D78 RID: 3448
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000D79 RID: 3449
		[CompilerGenerated]
		private long cc74dd5859f10a629b2a1cbac6c1e2f7f;

		// Token: 0x04000D7A RID: 3450
		[CompilerGenerated]
		private long c5aabb3575ac6c477f99949c76656c1e5;

		// Token: 0x04000D7B RID: 3451
		[CompilerGenerated]
		private int c8ff1e52a1cbc3f52ff99ae6d62f927a2;

		// Token: 0x04000D7C RID: 3452
		[CompilerGenerated]
		private int cfa8773a6329ae0a3daef77607e5a4da9;

		// Token: 0x04000D7D RID: 3453
		[CompilerGenerated]
		private uint c1875097b28d9faaf26275ddd3eb682e2;

		// Token: 0x04000D7E RID: 3454
		[CompilerGenerated]
		private int c20e476c6b9f991d41fdbf1e56b15710d;
	}
}
