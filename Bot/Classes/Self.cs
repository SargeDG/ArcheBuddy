using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004D1 RID: 1233
	public class Self : Player
	{
		// Token: 0x0600141B RID: 5147 RVA: 0x000B4DF8 File Offset: 0x000B2FF8
		internal Self(CoreInternal coreInternal) : base(coreInternal)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47560));
			this.c9d644110f29e43331584dc674eff2e06 = new Clan();
			c3421544427d715c29836985a118c5bfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<Effect>());
			c7d5eaed5d1d76e31e3b39b24c691f7c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Family());
			c85d812331416cf4d70cc2263ffc299d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<FriendListMember>());
			ca08ecb9d454988367042243784b0e2e1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<BlockListMember>());
			c5db410a47fe37e069e310e4609518d0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<ActionSlot>());
			c3f774928b6c66cd787b56ea332f6a78d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new TradeInfo());
			c4939ad385cf034b4135f9bba1437d82d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<Mail>());
			ca2bc81534110ecce498dbd962c94930b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Raid());
			this.c92cea0def27d92ffeb84b22de07c00b1 = new List<Actability>();
			c23105372aa49af241062418098113b2f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<Appellation>());
			this.cb092cebcbed5af0f75512c7e2c347434();
			this.ce61a1750791fff4f73682c9f3a06ea35 = ce7e7ae12475423e84339aabf31d2b566.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47564));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47568); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47576); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47572))
			{
				this.ce61a1750791fff4f73682c9f3a06ea35[i] = new Mark();
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
				RuntimeMethodHandle arg_FA_0 = methodof(Self..ctor(CoreInternal)).MethodHandle;
			}
			c6ba8d1252e17638cf2f752d5a686df20.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new PortalBook(coreInternal));
			ce2abf852f4bb43287e168684e4676b51.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, null);
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x000B4F14 File Offset: 0x000B3114
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x000B4F28 File Offset: 0x000B3128
		public bool isInsideBattleField
		{
			get;
			internal set;
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x000B4F3C File Offset: 0x000B313C
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x000B4F50 File Offset: 0x000B3150
		public bool isRegisteredToBattleField
		{
			get;
			internal set;
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001420 RID: 5152 RVA: 0x000B4F64 File Offset: 0x000B3164
		// (set) Token: 0x06001421 RID: 5153 RVA: 0x000B4F78 File Offset: 0x000B3178
		public List<Appellation> appellations
		{
			get;
			internal set;
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x000B4F8C File Offset: 0x000B318C
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x000B4FA0 File Offset: 0x000B31A0
		internal List<ActionSlot> actionSlots
		{
			get;
			set;
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000B4FB4 File Offset: 0x000B31B4
		public Clan clan
		{
			get
			{
				if (cf1ff46f536b59cae2118ceb3f4f4090a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47416))
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
						RuntimeMethodHandle arg_26_0 = methodof(Self.get_clan()).MethodHandle;
					}
					return this.c9d644110f29e43331584dc674eff2e06;
				}
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001425 RID: 5157 RVA: 0x000B4FF0 File Offset: 0x000B31F0
		// (set) Token: 0x06001426 RID: 5158 RVA: 0x000B5004 File Offset: 0x000B3204
		public PortalBook portalBook
		{
			get;
			internal set;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x000B5018 File Offset: 0x000B3218
		internal void cb092cebcbed5af0f75512c7e2c347434()
		{
			List<SqlActabilityGroup> list = c97d6da3c08b504717855963b47de2855.c30767ddca1f9c207888833aea5b5fc61(ce1622078ba1a7fcddcb7d938aa45a312.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))).ToList<SqlActabilityGroup>();
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47420); i < ce06680ef205aa698b7a6d2be7266c0dc.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47432))
			{
				Actability actability = cb66dc50686d1f139a4f0949b6b66fb65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ca124a9f406cda69b904f2eb04d553ab9);
				c453c75fa8f5e9d3f44880fd8c5a8f6ea.c30767ddca1f9c207888833aea5b5fc61(actability, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47424));
				c0fc1ef967e0a848d2a95913077e0b37b.c30767ddca1f9c207888833aea5b5fc61(actability, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47428));
				actability.cb5905b594e11dea2f73932df05981674 = cb54dd6b94569096a2987de2055acd7bc.c30767ddca1f9c207888833aea5b5fc61(c06f440b29f3be664308dcdc438e26711.c30767ddca1f9c207888833aea5b5fc61(list, i));
				cee72f66c463ed6062ca51b782999a969.c30767ddca1f9c207888833aea5b5fc61(actability, c06f440b29f3be664308dcdc438e26711.c30767ddca1f9c207888833aea5b5fc61(list, i));
				c4ab72c4588925b7f02e71494461de4d2.c30767ddca1f9c207888833aea5b5fc61(this.c92cea0def27d92ffeb84b22de07c00b1, actability);
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
				RuntimeMethodHandle arg_B9_0 = methodof(Self.cb092cebcbed5af0f75512c7e2c347434()).MethodHandle;
			}
			list = cd2483b9aa06ef341a22512f46bb11b1e.c8a754f5f2ca4adde825691a9c31a0e83;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x000B50E8 File Offset: 0x000B32E8
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(Self.Dispose(bool)).MethodHandle;
					}
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
						c46a0a2615ff0d1a7ba02f9cd3423de3b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						if (c0856f4f231c5c91c3238708747cdcf91.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c0856f4f231c5c91c3238708747cdcf91.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							c7d5eaed5d1d76e31e3b39b24c691f7c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c047bf448c4ce263242c3856f4a833ea9.c8a754f5f2ca4adde825691a9c31a0e83);
						}
						if (c3022233ebc78ec922795c3a909e410ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c3022233ebc78ec922795c3a909e410ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							ca2bc81534110ecce498dbd962c94930b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c9fb82f255012480277d598f1515de21c.c8a754f5f2ca4adde825691a9c31a0e83);
						}
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47436); i < (int)cd4f7f366764c99abbd9bcf20ca355238.cc0906fa561b9c6076f6cb6643cecb5e3(this.ce61a1750791fff4f73682c9f3a06ea35); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47440))
						{
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(this.ce61a1750791fff4f73682c9f3a06ea35[i]);
							this.ce61a1750791fff4f73682c9f3a06ea35[i] = null;
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
						this.ce61a1750791fff4f73682c9f3a06ea35 = cbe7c42145a27ed07a94448254256bfe9.c8a754f5f2ca4adde825691a9c31a0e83;
						if (cc1e84e833a5a920e672bfc88c3c058ba.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cc1e84e833a5a920e672bfc88c3c058ba.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							c3f774928b6c66cd787b56ea332f6a78d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c5e0d5078671181073a003e3d677a9fba.c8a754f5f2ca4adde825691a9c31a0e83);
						}
						if (this.c9d644110f29e43331584dc674eff2e06 != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(this.c9d644110f29e43331584dc674eff2e06);
							this.c9d644110f29e43331584dc674eff2e06 = cbc68910eba32ac9e219534b0b63d1250.c8a754f5f2ca4adde825691a9c31a0e83;
						}
						if (c1402060a23b4361cfd1357fcbf7300a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c1402060a23b4361cfd1357fcbf7300a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							c6ba8d1252e17638cf2f752d5a686df20.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc8073b459a091d12c4723907a96be917.c8a754f5f2ca4adde825691a9c31a0e83);
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47444); j < c563081ddd36a5d71294a34ee587fb2b1.c30767ddca1f9c207888833aea5b5fc61(cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47448))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), j));
								c6dc573021d6967bc4de90ab9797b4286.c30767ddca1f9c207888833aea5b5fc61(cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), j, c64531f9ec041059e4b1853253b769a77.c8a754f5f2ca4adde825691a9c31a0e83);
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
							ce333088a43d2cd19670144f1444e40b3.c30767ddca1f9c207888833aea5b5fc61(cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cbeaaa67ca03bca064239e2f34dd6b7c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47452); k < c310be8c5f51859819759aaa8faa0c8f5.c30767ddca1f9c207888833aea5b5fc61(cbeaaa67ca03bca064239e2f34dd6b7c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47456))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cd269254b277d98eff03f9faa39276e81.c30767ddca1f9c207888833aea5b5fc61(cbeaaa67ca03bca064239e2f34dd6b7c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), k));
								cc2267abf2221e10272c7b0c563b15042.c30767ddca1f9c207888833aea5b5fc61(cbeaaa67ca03bca064239e2f34dd6b7c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), k, c6bd4d07b35cae6bbe59a18acdec3aa90.c8a754f5f2ca4adde825691a9c31a0e83);
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
							c4e0a0d17de01553bf644ca0d30c2e98f.c30767ddca1f9c207888833aea5b5fc61(cbeaaa67ca03bca064239e2f34dd6b7c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c4c1e8191a3bfe01de1b562a687f4d53e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47460); l < c3fb3ea622d0cdad1ae32a22005a8344b.c30767ddca1f9c207888833aea5b5fc61(c4c1e8191a3bfe01de1b562a687f4d53e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47464))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(ca931355bf7671f43352fe91e4c9a21f7.c30767ddca1f9c207888833aea5b5fc61(c4c1e8191a3bfe01de1b562a687f4d53e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), l));
								c0b864c3a57a5f1cf6e0028344eb9afc9.c30767ddca1f9c207888833aea5b5fc61(c4c1e8191a3bfe01de1b562a687f4d53e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), l, c3b5975428610909f405d4f31e6faad1a.c8a754f5f2ca4adde825691a9c31a0e83);
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
							cc9f7ac79ce0e86800077f54f5386d31b.c30767ddca1f9c207888833aea5b5fc61(c4c1e8191a3bfe01de1b562a687f4d53e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c29dfc1438c2cd654e2238f0666d4a21c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47468); m < c2273fe1c036fed7496d6727215894855.c30767ddca1f9c207888833aea5b5fc61(c29dfc1438c2cd654e2238f0666d4a21c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47472))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c4e77c6d66056bb995d4997704b581167.c30767ddca1f9c207888833aea5b5fc61(c29dfc1438c2cd654e2238f0666d4a21c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), m));
								c8a62875a2895e052748905a047cfd560.c30767ddca1f9c207888833aea5b5fc61(c29dfc1438c2cd654e2238f0666d4a21c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), m, c0cd8fcae4e8f8456887cef9dacc3cf32.c8a754f5f2ca4adde825691a9c31a0e83);
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
							c6664dddcfcc982c0952fc412ee63c8e1.c30767ddca1f9c207888833aea5b5fc61(c29dfc1438c2cd654e2238f0666d4a21c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c92cea0def27d92ffeb84b22de07c00b1))
						{
							for (int n = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47476); n < ce7742d1314483d479031762884a7da6e.c30767ddca1f9c207888833aea5b5fc61(this.c92cea0def27d92ffeb84b22de07c00b1); n += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47480))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cc20269b9af0cd54e065ceab259612e8e.c30767ddca1f9c207888833aea5b5fc61(this.c92cea0def27d92ffeb84b22de07c00b1, n));
								c8250d22facbba325408673cdd30a7c7d.c30767ddca1f9c207888833aea5b5fc61(this.c92cea0def27d92ffeb84b22de07c00b1, n, c9af90d96b75c64b32dbc4092cc5ff0f2.c8a754f5f2ca4adde825691a9c31a0e83);
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
							c12aa9b611abe66ca2bcaf2b69a94b2b4.c30767ddca1f9c207888833aea5b5fc61(this.c92cea0def27d92ffeb84b22de07c00b1);
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c2a8dd73c0eab40882907c9a544fdb1f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47484); num < c63176035b33a6f6752792ad663988c54.c30767ddca1f9c207888833aea5b5fc61(c2a8dd73c0eab40882907c9a544fdb1f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47488))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c251c296d98ec7aeb94b094d21c4c4156.c30767ddca1f9c207888833aea5b5fc61(c2a8dd73c0eab40882907c9a544fdb1f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num));
								c3b41ec5b0f0d8eaf2c3ec2ee09f6e59d.c30767ddca1f9c207888833aea5b5fc61(c2a8dd73c0eab40882907c9a544fdb1f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, cfe769fa96287fb4643a98772fec52e85.c8a754f5f2ca4adde825691a9c31a0e83);
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
							c6a1129ee860d68334615edcc8beae381.c30767ddca1f9c207888833aea5b5fc61(c2a8dd73c0eab40882907c9a544fdb1f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						}
					}
					c57dc9e1efb3f9f06bdc5d549aab4d3d8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x000B5674 File Offset: 0x000B3874
		// (set) Token: 0x0600142A RID: 5162 RVA: 0x000B5688 File Offset: 0x000B3888
		internal Self.c3d162452038ed075c6b0d5ba9bf462e2 openedCofferInfo
		{
			get;
			set;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x000B569C File Offset: 0x000B389C
		public List<Actability> getActabilities()
		{
			List<Actability> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c92cea0def27d92ffeb84b22de07c00b1))
			{
				result = this.c92cea0def27d92ffeb84b22de07c00b1.ToList<Actability>();
			}
			return result;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x000B56E8 File Offset: 0x000B38E8
		internal List<Actability> get_ce96c25a251c2b0ccdcb2c2b402cf5772()
		{
			return this.c92cea0def27d92ffeb84b22de07c00b1;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x000B56FC File Offset: 0x000B38FC
		internal void set_ce96c25a251c2b0ccdcb2c2b402cf5772(List<Actability> list)
		{
			this.c92cea0def27d92ffeb84b22de07c00b1 = list;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000B5710 File Offset: 0x000B3910
		internal List<Mail> cff834df6b2bd4a24385268fd8936fc9d()
		{
			List<Mail> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c29dfc1438c2cd654e2238f0666d4a21c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c29dfc1438c2cd654e2238f0666d4a21c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<Mail>();
			}
			return result;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000B5760 File Offset: 0x000B3960
		public List<ActionSlot> getActionSlots()
		{
			List<ActionSlot> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c2a8dd73c0eab40882907c9a544fdb1f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c2a8dd73c0eab40882907c9a544fdb1f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<ActionSlot>();
			}
			return result;
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x000B57B0 File Offset: 0x000B39B0
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x000B57C4 File Offset: 0x000B39C4
		internal List<Mail> mails
		{
			get;
			set;
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x000B57D8 File Offset: 0x000B39D8
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x000B57EC File Offset: 0x000B39EC
		public int sentUnreadMailsCount
		{
			get;
			internal set;
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x000B5800 File Offset: 0x000B3A00
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x000B5814 File Offset: 0x000B3A14
		public int receivedUnreadMailsCount
		{
			get;
			internal set;
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x000B5828 File Offset: 0x000B3A28
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x000B583C File Offset: 0x000B3A3C
		public int miaReceivedUnreadMailsCount
		{
			get;
			internal set;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x000B5850 File Offset: 0x000B3A50
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x000B5864 File Offset: 0x000B3A64
		public int commercialReceivedUnreadMailsCount
		{
			get;
			internal set;
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000B5878 File Offset: 0x000B3A78
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x000B588C File Offset: 0x000B3A8C
		internal int sentMailsCount
		{
			get;
			set;
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x000B58A0 File Offset: 0x000B3AA0
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		internal int receivedMailsCount
		{
			get;
			set;
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x000B58C8 File Offset: 0x000B3AC8
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x000B58DC File Offset: 0x000B3ADC
		internal int miaReceivedMailsCount
		{
			get;
			set;
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x000B58F0 File Offset: 0x000B3AF0
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x000B5904 File Offset: 0x000B3B04
		internal int commercialReceivedMailsCount
		{
			get;
			set;
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x000B5918 File Offset: 0x000B3B18
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x000B592C File Offset: 0x000B3B2C
		public TradeInfo tradeInfo
		{
			get;
			internal set;
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x000B5940 File Offset: 0x000B3B40
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x000B5954 File Offset: 0x000B3B54
		public int laborPoints
		{
			get;
			internal set;
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x000B5968 File Offset: 0x000B3B68
		public int opPoints
		{
			get
			{
				return c6fedc4467e28345e91885c5bc94bab7b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x000B5980 File Offset: 0x000B3B80
		// (set) Token: 0x06001448 RID: 5192 RVA: 0x000B5994 File Offset: 0x000B3B94
		public double underWaterBreathTime
		{
			get;
			internal set;
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x000B59A8 File Offset: 0x000B3BA8
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x000B59BC File Offset: 0x000B3BBC
		public bool isUnderWaterBreath
		{
			get;
			internal set;
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x000B59D0 File Offset: 0x000B3BD0
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x000B59E4 File Offset: 0x000B3BE4
		internal Creature duelEnemyObj
		{
			get;
			set;
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x000B59F8 File Offset: 0x000B3BF8
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x000B5A0C File Offset: 0x000B3C0C
		public ushort zoneId
		{
			get;
			internal set;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000B5A20 File Offset: 0x000B3C20
		internal Mark[] get_c472a459ac00a3e0510ffbd7e66a2a952()
		{
			return this.ce61a1750791fff4f73682c9f3a06ea35;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000B5A34 File Offset: 0x000B3C34
		internal void set_c472a459ac00a3e0510ffbd7e66a2a952(Mark[] array)
		{
			this.ce61a1750791fff4f73682c9f3a06ea35 = array;
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x000B5A48 File Offset: 0x000B3C48
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x000B5A5C File Offset: 0x000B3C5C
		public Raid raid
		{
			get;
			internal set;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x000B5A70 File Offset: 0x000B3C70
		internal List<FriendListMember> c410b28965f78db4f6b1654c9081f6938()
		{
			List<FriendListMember> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c4c1e8191a3bfe01de1b562a687f4d53e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c4c1e8191a3bfe01de1b562a687f4d53e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<FriendListMember>();
			}
			return result;
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x000B5AC0 File Offset: 0x000B3CC0
		// (set) Token: 0x06001455 RID: 5205 RVA: 0x000B5AD4 File Offset: 0x000B3CD4
		internal List<FriendListMember> friendListMembers
		{
			get;
			set;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x000B5AE8 File Offset: 0x000B3CE8
		internal List<BlockListMember> c6d71204f83ab3bb0375ed0472436ec51()
		{
			List<BlockListMember> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cbeaaa67ca03bca064239e2f34dd6b7c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = cbeaaa67ca03bca064239e2f34dd6b7c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<BlockListMember>();
			}
			return result;
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x000B5B38 File Offset: 0x000B3D38
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x000B5B4C File Offset: 0x000B3D4C
		internal List<BlockListMember> blockListMembers
		{
			get;
			set;
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x000B5B60 File Offset: 0x000B3D60
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x000B5B74 File Offset: 0x000B3D74
		public string requesterName
		{
			get;
			internal set;
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x000B5B88 File Offset: 0x000B3D88
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x000B5B9C File Offset: 0x000B3D9C
		public RequestDialog requestDialog
		{
			get;
			internal set;
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x000B5BB0 File Offset: 0x000B3DB0
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x000B5BC4 File Offset: 0x000B3DC4
		public ulong partyRequestDialogLogEventId
		{
			get;
			internal set;
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x000B5BD8 File Offset: 0x000B3DD8
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x000B5BEC File Offset: 0x000B3DEC
		public bool partyRequestisRadiusInvite
		{
			get;
			internal set;
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001461 RID: 5217 RVA: 0x000B5C00 File Offset: 0x000B3E00
		// (set) Token: 0x06001462 RID: 5218 RVA: 0x000B5C14 File Offset: 0x000B3E14
		public Family family
		{
			get;
			internal set;
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001463 RID: 5219 RVA: 0x000B5C28 File Offset: 0x000B3E28
		// (set) Token: 0x06001464 RID: 5220 RVA: 0x000B5C3C File Offset: 0x000B3E3C
		public long enterGameTime
		{
			get;
			internal set;
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001465 RID: 5221 RVA: 0x000B5C50 File Offset: 0x000B3E50
		// (set) Token: 0x06001466 RID: 5222 RVA: 0x000B5C64 File Offset: 0x000B3E64
		public long lastTimeWeDie
		{
			get;
			internal set;
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x000B5C78 File Offset: 0x000B3E78
		// (set) Token: 0x06001468 RID: 5224 RVA: 0x000B5C8C File Offset: 0x000B3E8C
		public long resurrectionWaitingTime
		{
			get;
			internal set;
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x000B5CA0 File Offset: 0x000B3EA0
		// (set) Token: 0x0600146A RID: 5226 RVA: 0x000B5CB4 File Offset: 0x000B3EB4
		public long lastTimeWeGetExp
		{
			get;
			internal set;
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x000B5CC8 File Offset: 0x000B3EC8
		// (set) Token: 0x0600146C RID: 5228 RVA: 0x000B5CDC File Offset: 0x000B3EDC
		public int totalExp
		{
			get;
			internal set;
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x000B5CF0 File Offset: 0x000B3EF0
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x000B5D04 File Offset: 0x000B3F04
		public int whCells
		{
			get;
			internal set;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x000B5D18 File Offset: 0x000B3F18
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x000B5D2C File Offset: 0x000B3F2C
		public int bagCells
		{
			get;
			internal set;
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x000B5D40 File Offset: 0x000B3F40
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x000B5D54 File Offset: 0x000B3F54
		public int honorPoints
		{
			get;
			internal set;
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x000B5D68 File Offset: 0x000B3F68
		// (set) Token: 0x06001474 RID: 5236 RVA: 0x000B5D7C File Offset: 0x000B3F7C
		public int livingPoints
		{
			get;
			internal set;
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x000B5D90 File Offset: 0x000B3F90
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x000B5DA4 File Offset: 0x000B3FA4
		public int judgCount
		{
			get;
			internal set;
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x000B5DB8 File Offset: 0x000B3FB8
		public bool isGlobalCooldown
		{
			get
			{
				return ((this.c78121bfbe900c7406148fe81f78a0a61 - cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede() < (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47492)) ? 1 : 0) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47496);
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x000B5DEC File Offset: 0x000B3FEC
		public long globalCooldown
		{
			get
			{
				return c4af3755d22827d7132c867daade9dc20.c0cf59c3e67a46fd4edb3040c5ab0bbfb((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47500), this.c78121bfbe900c7406148fe81f78a0a61 - cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede());
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x000B5E1C File Offset: 0x000B401C
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x000B5E30 File Offset: 0x000B4030
		public long goldCount
		{
			get;
			internal set;
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x000B5E44 File Offset: 0x000B4044
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x000B5E58 File Offset: 0x000B4058
		public long goldCountInWh
		{
			get;
			internal set;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x000B5E6C File Offset: 0x000B406C
		// (set) Token: 0x0600147E RID: 5246 RVA: 0x000B5E80 File Offset: 0x000B4080
		internal List<Effect> skillsCanBeLearned
		{
			get;
			set;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x000B5E94 File Offset: 0x000B4094
		public byte skillPoints
		{
			get
			{
				return (byte)(ccd630e38ba60a533e65138f45506e131.c30767ddca1f9c207888833aea5b5fc61(c9274d8459c3c6ad925050bf891992775.c30767ddca1f9c207888833aea5b5fc61(ccc3e419615259a6d394934110192cd27.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) - this.c1b81150f8295a5d2abe14f553d2d7ba6);
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x000B5ED4 File Offset: 0x000B40D4
		internal List<Effect> c910c37772c7e1ef0d075a71ff73974f0()
		{
			List<Effect> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<Effect>();
			}
			return result;
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x000B5F24 File Offset: 0x000B4124
		public List<Effect> getSkillsCanBeLearned()
		{
			List<Effect> list = cfe50bd84cfff85e74e339632fd48e0fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				List<Buff> list2 = cefa095602a5eea2cce770db89c7aade1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				List<Skill> list3 = c07f945cbd125752e35f4fbd8e9ff4b5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				List<Effect> list4 = ca23b594ee1c7f0776f7942d4372bd0f3.c8a754f5f2ca4adde825691a9c31a0e83;
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
				{
					list4 = cde5829b0c659dbf44a238276cbef41a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<Effect>();
				}
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47504); i < c563081ddd36a5d71294a34ee587fb2b1.c30767ddca1f9c207888833aea5b5fc61(list4); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47556))
				{
					byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47508);
					if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47512))
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
							RuntimeMethodHandle arg_A0_0 = methodof(Self.getSkillsCanBeLearned()).MethodHandle;
						}
						int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47516);
						b = (byte)cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(c852922628bcb33890ae16f824ebac3cd.c30767ddca1f9c207888833aea5b5fc61(c9b00e198bf1830a2601c44954a8e1361.c9963fcf210a214a3206d6500f3b9397b(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i))));
						if (b != 0)
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
							if (cf571782289635c1521477ae7181fa55e.c30767ddca1f9c207888833aea5b5fc61(base.get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[(int)b - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47520)]))
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
								if ((ulong)this.ca124a9f406cda69b904f2eb04d553ab9.c78eb6f19dc695177d00c3345ef1e0c32((uint)b) >= (ulong)((long)cfdcc077a53e4b8f4504de89a99c433d4.c30767ddca1f9c207888833aea5b5fc61(c852922628bcb33890ae16f824ebac3cd.c30767ddca1f9c207888833aea5b5fc61(c9b00e198bf1830a2601c44954a8e1361.c9963fcf210a214a3206d6500f3b9397b(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i))))))
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
									if (ccd630e38ba60a533e65138f45506e131.c30767ddca1f9c207888833aea5b5fc61(c9274d8459c3c6ad925050bf891992775.c30767ddca1f9c207888833aea5b5fc61(ccc3e419615259a6d394934110192cd27.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) > this.c1b81150f8295a5d2abe14f553d2d7ba6)
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
										for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47524); j < c0ce5ac6ea366633aaf6d960fb8dbde46.c30767ddca1f9c207888833aea5b5fc61(list2); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47532))
										{
											if ((int)b == cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(c852922628bcb33890ae16f824ebac3cd.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(list2, j))))
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
												num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47528);
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
										for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47536); k < cd76bd05d82b141b0544cd21df6dcb6a0.c30767ddca1f9c207888833aea5b5fc61(list3); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47544))
										{
											if ((int)b == cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(c47cb93bc7d2bbf0ebb2f14df36fc7e95.c30767ddca1f9c207888833aea5b5fc61(c5cac1bec31f0d74685de039f19d81dc0.c30767ddca1f9c207888833aea5b5fc61(list3, k))))
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
												num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47540);
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
										if (num >= c36ecdd843c865142a4634ee2e752ad84.c30767ddca1f9c207888833aea5b5fc61(c852922628bcb33890ae16f824ebac3cd.c30767ddca1f9c207888833aea5b5fc61(c9b00e198bf1830a2601c44954a8e1361.c9963fcf210a214a3206d6500f3b9397b(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i)))))
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
											c831ae07a3dd78bfde3b2f02e0c3b7310.c30767ddca1f9c207888833aea5b5fc61(list, cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i));
										}
									}
								}
							}
						}
					}
					else if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47548))
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
						b = (byte)cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(c47cb93bc7d2bbf0ebb2f14df36fc7e95.c30767ddca1f9c207888833aea5b5fc61(c48d73eab529b6f855bfe2f2956339c4a.c9963fcf210a214a3206d6500f3b9397b(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i))));
						if (b != 0)
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
							if (cf571782289635c1521477ae7181fa55e.c30767ddca1f9c207888833aea5b5fc61(base.get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[(int)b - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47552)]))
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
								if ((ulong)this.ca124a9f406cda69b904f2eb04d553ab9.c78eb6f19dc695177d00c3345ef1e0c32((uint)b) >= (ulong)((long)c2d680f3b4587b8d900838e2d07aea9e7.c30767ddca1f9c207888833aea5b5fc61(c47cb93bc7d2bbf0ebb2f14df36fc7e95.c30767ddca1f9c207888833aea5b5fc61(c48d73eab529b6f855bfe2f2956339c4a.c9963fcf210a214a3206d6500f3b9397b(cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i))))))
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
									if (ccd630e38ba60a533e65138f45506e131.c30767ddca1f9c207888833aea5b5fc61(c9274d8459c3c6ad925050bf891992775.c30767ddca1f9c207888833aea5b5fc61(ccc3e419615259a6d394934110192cd27.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) > this.c1b81150f8295a5d2abe14f553d2d7ba6)
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
										c831ae07a3dd78bfde3b2f02e0c3b7310.c30767ddca1f9c207888833aea5b5fc61(list, cb064590803f78a4cb8aa89fbece7c83f.c30767ddca1f9c207888833aea5b5fc61(list4, i));
									}
								}
							}
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
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return list;
		}

		// Token: 0x04000E98 RID: 3736
		internal int c8c187aa4fda6713e2eb1151d28265773;

		// Token: 0x04000E99 RID: 3737
		internal int c5e2c62675ea8b026eba6faaa217225bb;

		// Token: 0x04000E9A RID: 3738
		internal int c7a157766ac52d22f9767a4dfcd694d10;

		// Token: 0x04000E9B RID: 3739
		internal bool cff44e1cc397e6822736193fe23c6af6b;

		// Token: 0x04000E9C RID: 3740
		private List<Actability> c92cea0def27d92ffeb84b22de07c00b1;

		// Token: 0x04000E9D RID: 3741
		internal bool c347e1fe3c8f8f03c44e26a201602467b;

		// Token: 0x04000E9E RID: 3742
		internal uint c9c8b89a4275e8e01172d0a170e327957;

		// Token: 0x04000E9F RID: 3743
		internal string cfce771ec4396525ed738f80db5e3a49f;

		// Token: 0x04000EA0 RID: 3744
		internal uint c2b6241ecb1ed0814f287097d89c11662;

		// Token: 0x04000EA1 RID: 3745
		internal uint c9f1c38f8bd0601b7dfe2362990beb261;

		// Token: 0x04000EA2 RID: 3746
		internal long cf5ae6c04f753e6c2d485bf6bc29a51e0;

		// Token: 0x04000EA3 RID: 3747
		internal long c78121bfbe900c7406148fe81f78a0a61;

		// Token: 0x04000EA4 RID: 3748
		internal ushort c528195ab2760dd3958b1e20a0a33abf5;

		// Token: 0x04000EA5 RID: 3749
		internal ushort c959aaf88fdea3803a736d0b022d46818;

		// Token: 0x04000EA6 RID: 3750
		private Mark[] ce61a1750791fff4f73682c9f3a06ea35;

		// Token: 0x04000EA7 RID: 3751
		internal Clan c9d644110f29e43331584dc674eff2e06;

		// Token: 0x04000EA8 RID: 3752
		internal ulong c2083845d48e9cc57e3e75299a2431db3;

		// Token: 0x04000EA9 RID: 3753
		[CompilerGenerated]
		private bool ce55d5c327ddd29982de8a64f530330b1;

		// Token: 0x04000EAA RID: 3754
		[CompilerGenerated]
		private bool c12bbf627055d5db199c60c073b1358f9;

		// Token: 0x04000EAB RID: 3755
		[CompilerGenerated]
		private List<Appellation> c4b406f3f7afdbe95089bb168638c78cb;

		// Token: 0x04000EAC RID: 3756
		[CompilerGenerated]
		private List<ActionSlot> cb7dadda2ea94fccccf796b4cfe2bb4ac;

		// Token: 0x04000EAD RID: 3757
		[CompilerGenerated]
		private PortalBook c4542d5604d2db6bfa3897548aaadb0ff;

		// Token: 0x04000EAE RID: 3758
		[CompilerGenerated]
		private Self.c3d162452038ed075c6b0d5ba9bf462e2 c2cae755273fbe25cb0bfbc8d3b07aaa5;

		// Token: 0x04000EAF RID: 3759
		[CompilerGenerated]
		private List<Mail> c9a6ed05ce2351d2ba942cb5c2b2bc74a;

		// Token: 0x04000EB0 RID: 3760
		[CompilerGenerated]
		private int c4b61b78d7df7a1f9cc5a92e43d609627;

		// Token: 0x04000EB1 RID: 3761
		[CompilerGenerated]
		private int c8467b6e85196af229dfde215796107dd;

		// Token: 0x04000EB2 RID: 3762
		[CompilerGenerated]
		private int c668cb27dba4b467da3f6c5e0c244da6c;

		// Token: 0x04000EB3 RID: 3763
		[CompilerGenerated]
		private int c06dbbe27b311c0287ab0fb78ec5996d2;

		// Token: 0x04000EB4 RID: 3764
		[CompilerGenerated]
		private int c0f052a28c384187184c1e2855efdc253;

		// Token: 0x04000EB5 RID: 3765
		[CompilerGenerated]
		private int c46c017b8100819fdd79ec6f8f8adf4d6;

		// Token: 0x04000EB6 RID: 3766
		[CompilerGenerated]
		private int c4de12bdb928d40029b46ee3543d19bd5;

		// Token: 0x04000EB7 RID: 3767
		[CompilerGenerated]
		private int c6b19b740c7828b490a5b7a88fc83316d;

		// Token: 0x04000EB8 RID: 3768
		[CompilerGenerated]
		private TradeInfo cb2bb05c4569d37907d73a020f99cc3e8;

		// Token: 0x04000EB9 RID: 3769
		[CompilerGenerated]
		private int c204c6741e526cfb442e8bb322970a23d;

		// Token: 0x04000EBA RID: 3770
		[CompilerGenerated]
		private double cf2b124cc51ceb447113ebf8e7ad60646;

		// Token: 0x04000EBB RID: 3771
		[CompilerGenerated]
		private bool c217fb7f6f3d8dd2bb4d1d50e958a0525;

		// Token: 0x04000EBC RID: 3772
		[CompilerGenerated]
		private Creature c5fc9e9e96b020abd15dd68d444d6ad3b;

		// Token: 0x04000EBD RID: 3773
		[CompilerGenerated]
		private ushort cf8d76cb03307f91725d606bd77780a9e;

		// Token: 0x04000EBE RID: 3774
		[CompilerGenerated]
		private Raid cf498e3a38d6d6d5d4b33e3dee54b1c8d;

		// Token: 0x04000EBF RID: 3775
		[CompilerGenerated]
		private List<FriendListMember> c8cf887f04eabb693c0b7cf91edf48784;

		// Token: 0x04000EC0 RID: 3776
		[CompilerGenerated]
		private List<BlockListMember> c612bbb422b26f4a337f53f2679256747;

		// Token: 0x04000EC1 RID: 3777
		[CompilerGenerated]
		private string c8fc1d6fd0f23e2f5f1e6d7b5f3b4e189;

		// Token: 0x04000EC2 RID: 3778
		[CompilerGenerated]
		private RequestDialog cdafd84967e7600ed9034d504bb701f60;

		// Token: 0x04000EC3 RID: 3779
		[CompilerGenerated]
		private ulong c89298b5096181fd5c37dfdf8f2ef7485;

		// Token: 0x04000EC4 RID: 3780
		[CompilerGenerated]
		private bool c55551240d043acd01c2d451080ff744d;

		// Token: 0x04000EC5 RID: 3781
		[CompilerGenerated]
		private Family cf9e0b9ddce17ddd7961108fd0457dffd;

		// Token: 0x04000EC6 RID: 3782
		[CompilerGenerated]
		private long cc70e053515647b404e63221f049db2e6;

		// Token: 0x04000EC7 RID: 3783
		[CompilerGenerated]
		private long cc3794cd7510adcd7693937dba89f48b1;

		// Token: 0x04000EC8 RID: 3784
		[CompilerGenerated]
		private long cd320ccff2f726c6453774ae193069de8;

		// Token: 0x04000EC9 RID: 3785
		[CompilerGenerated]
		private long c4ecfc70e3c3f59e906408168a8995f4b;

		// Token: 0x04000ECA RID: 3786
		[CompilerGenerated]
		private int c08e600eb8b112406607f473b82870b60;

		// Token: 0x04000ECB RID: 3787
		[CompilerGenerated]
		private int c8cfdba27e84a9ebdb4f11313a530c670;

		// Token: 0x04000ECC RID: 3788
		[CompilerGenerated]
		private int c1533541d92d77157371db4045eec18a4;

		// Token: 0x04000ECD RID: 3789
		[CompilerGenerated]
		private int c7ea510920d63371f7d4df93f23df8dc7;

		// Token: 0x04000ECE RID: 3790
		[CompilerGenerated]
		private int c68dba9ba320095683c88dcc05d197fcb;

		// Token: 0x04000ECF RID: 3791
		[CompilerGenerated]
		private int c6042a193aee7405a527de4c1eec7817c;

		// Token: 0x04000ED0 RID: 3792
		[CompilerGenerated]
		private long c9114ba2117515dbd588dca5244164954;

		// Token: 0x04000ED1 RID: 3793
		[CompilerGenerated]
		private long c06eae2becf08b922d6120284799c0608;

		// Token: 0x04000ED2 RID: 3794
		[CompilerGenerated]
		private List<Effect> cdc3b01881ec6f038f8f9456800cc1ca5;

		// Token: 0x020004D2 RID: 1234
		internal sealed class c3d162452038ed075c6b0d5ba9bf462e2
		{
			// Token: 0x04000ED3 RID: 3795
			public uint c43b9524fd9dcf5d8d1d449c8b39bbfed;

			// Token: 0x04000ED4 RID: 3796
			public ulong cadab02f2f80fd2ebe9b14ca573098990;

			// Token: 0x04000ED5 RID: 3797
			public byte cbf8c204be233e5a9dd42f9d96af0a351;
		}
	}
}
