using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004C4 RID: 1220
	public class District : BaseObject
	{
		// Token: 0x060012B4 RID: 4788 RVA: 0x000AD3E0 File Offset: 0x000AB5E0
		internal District(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44604));
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000AD40C File Offset: 0x000AB60C
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x000AD420 File Offset: 0x000AB620
		public uint uniqId
		{
			get;
			internal set;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000AD434 File Offset: 0x000AB634
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x000AD448 File Offset: 0x000AB648
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x000AD45C File Offset: 0x000AB65C
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x000AD470 File Offset: 0x000AB670
		public uint zoneId
		{
			get;
			internal set;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x000AD484 File Offset: 0x000AB684
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x000AD498 File Offset: 0x000AB698
		public double X
		{
			get;
			internal set;
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x000AD4AC File Offset: 0x000AB6AC
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x000AD4C0 File Offset: 0x000AB6C0
		public double Y
		{
			get;
			internal set;
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x000AD4D4 File Offset: 0x000AB6D4
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x000AD4E8 File Offset: 0x000AB6E8
		public double Z
		{
			get;
			internal set;
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x000AD4FC File Offset: 0x000AB6FC
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x000AD510 File Offset: 0x000AB710
		public bool isPersonalPortal
		{
			get;
			internal set;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000AD524 File Offset: 0x000AB724
		public bool OpenPortal()
		{
			uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44512);
			Territory territory = this.ca124a9f406cda69b904f2eb04d553ab9.c8614ae9b3c42a5a0ee5010d3a9518b26();
			if (territory == null)
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
					RuntimeMethodHandle arg_2E_0 = methodof(District.OpenPortal()).MethodHandle;
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44516));
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44520) != 0;
			}
			SqlZoneGroup sqlZoneGroup = c23b3c3440cd7ac2aab07a99ad2c9a008.c8a754f5f2ca4adde825691a9c31a0e83;
			if (!ce19dc22662b2fe9c07e1808b609c5afe.c30767ddca1f9c207888833aea5b5fc61(c9cb2d039ea85b1f6043d05acb4bc5b10.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), ccb6f9a08bc415be363a83e75a4562280.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44524));
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44528) != 0;
			}
			sqlZoneGroup = c365f8d33e24d650b794e4a16a28ba824.c30767ddca1f9c207888833aea5b5fc61(c25b47c23499763d5fd811e8499348f90.c30767ddca1f9c207888833aea5b5fc61(c9cb2d039ea85b1f6043d05acb4bc5b10.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), ccb6f9a08bc415be363a83e75a4562280.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			if (territory.ce59e203faf79a2e5b973f91b58df4955 == c5e5dbd355cdc0bb0514a3ed7d9906be1.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup))
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
				if (this.ca124a9f406cda69b904f2eb04d553ab9.c1ff4c8b6c8a38d14ad7d822488ae2822((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44532)) < (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44536))
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
					if (this.ca124a9f406cda69b904f2eb04d553ab9.c1ff4c8b6c8a38d14ad7d822488ae2822((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44540)) < (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44544))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44548));
						return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44552) != 0;
					}
				}
			}
			else if (territory.ce59e203faf79a2e5b973f91b58df4955 != c5e5dbd355cdc0bb0514a3ed7d9906be1.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup))
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
				if (this.ca124a9f406cda69b904f2eb04d553ab9.c1ff4c8b6c8a38d14ad7d822488ae2822((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44556)) < (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44560))
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
					if (this.ca124a9f406cda69b904f2eb04d553ab9.c1ff4c8b6c8a38d14ad7d822488ae2822((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44564)) < (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44568))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44572));
						return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44576) != 0;
					}
				}
			}
			Item item = this.ca124a9f406cda69b904f2eb04d553ab9.c3a894800d31711fe060ffb224e6b66c1(num);
			if (item == null)
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
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44580));
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44584) != 0;
			}
			byte cda6cc651158c383f19e450845295ef8d = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44588);
			if (ceb72ba9f1ef2acea955a6f857f0f6ba8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
				cda6cc651158c383f19e450845295ef8d = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44592);
			}
			return this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
			{
				cbe5fb745fb9d18c1a122f67582a2fc76 = cef937c4179bbad602e3f4568533301c4.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(item)),
				ca77899f30642d168d6dec950678a16c8 = item,
				cf7f9495aa2173cd0a4dd3bc637b16531 = c6096e540527a50f5d226b8ed2f7bb1e1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this),
				cda6cc651158c383f19e450845295ef8d = cda6cc651158c383f19e450845295ef8d,
				c2a5b19e90236f2d1186742950805e303 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44596) != 0),
				c91c55a4a1e3f353b30fc28b3501926a2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44600)
			});
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000AD810 File Offset: 0x000ABA10
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
						RuntimeMethodHandle arg_1A_0 = methodof(District.Dispose(bool)).MethodHandle;
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000E01 RID: 3585
		[CompilerGenerated]
		private uint c1f042b599e757f7d30e4be9756bd3cb4;

		// Token: 0x04000E02 RID: 3586
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000E03 RID: 3587
		[CompilerGenerated]
		private uint cf8d76cb03307f91725d606bd77780a9e;

		// Token: 0x04000E04 RID: 3588
		[CompilerGenerated]
		private double c4e1d1d0caa6a804f4989545e0d5f9f5f;

		// Token: 0x04000E05 RID: 3589
		[CompilerGenerated]
		private double ca9ac1684d7c60158fa9bdbd1d337b57b;

		// Token: 0x04000E06 RID: 3590
		[CompilerGenerated]
		private double c4810739f49f8dec1960e013b60a21005;

		// Token: 0x04000E07 RID: 3591
		[CompilerGenerated]
		private bool c951a18f5176f289298258ce1da6ae6ae;
	}
}
