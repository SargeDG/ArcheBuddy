using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004C7 RID: 1223
	public class Raid : BaseObject
	{
		// Token: 0x060012E2 RID: 4834 RVA: 0x000ADE34 File Offset: 0x000AC034
		internal Raid()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44716));
			ca41c124dc8e36a2c042d3f844081c176.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Dictionary<uint, PartyMember>());
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000ADE64 File Offset: 0x000AC064
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(Raid.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							List<PartyMember> list = c236863d6013600b1c38154c072385c8b.c30767ddca1f9c207888833aea5b5fc61(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)).ToList<PartyMember>();
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44660); i < c73cd36356c918db494be7e2db29ccd40.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44664))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c0cf9da17852f0365645b15a64c1d988f.c30767ddca1f9c207888833aea5b5fc61(list, i));
								cb34ebdb539bb1da891e9b912d8386e1d.c30767ddca1f9c207888833aea5b5fc61(list, i, cbd2159f9d2808fab749d24056a9a16b8.c8a754f5f2ca4adde825691a9c31a0e83);
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
							cfe3d324da2f3ba7f1c48d8c6876d46a4.c30767ddca1f9c207888833aea5b5fc61(list);
							cf8e402513731d6846beb400ddcfbb4d3.c30767ddca1f9c207888833aea5b5fc61(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							list = cded4e0f7fddb4757a74c77e497bade21.c8a754f5f2ca4adde825691a9c31a0e83;
						}
						ca41c124dc8e36a2c042d3f844081c176.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c5234eb54dbde243599c8dc83b7a94ced.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x000ADF78 File Offset: 0x000AC178
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x000ADF8C File Offset: 0x000AC18C
		internal uint itemsDistributorUniqId
		{
			get;
			set;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x000ADFA0 File Offset: 0x000AC1A0
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x000ADFB4 File Offset: 0x000AC1B4
		internal Dictionary<uint, PartyMember> members
		{
			get;
			set;
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x000ADFC8 File Offset: 0x000AC1C8
		internal PartyMember c546d0e6e0863a20e1407539999ece151(uint num)
		{
			PartyMember result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				if (c2496fcd78786a9322329b71c1c70fac5.c30767ddca1f9c207888833aea5b5fc61(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
						RuntimeMethodHandle arg_34_0 = methodof(Raid.c546d0e6e0863a20e1407539999ece151(uint)).MethodHandle;
					}
					result = c4172ae7431d23d8dd888152a93a45af0.c30767ddca1f9c207888833aea5b5fc61(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num);
				}
				else
				{
					result = cbd2159f9d2808fab749d24056a9a16b8.c8a754f5f2ca4adde825691a9c31a0e83;
				}
			}
			return result;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000AE044 File Offset: 0x000AC244
		internal byte c6453779dc051ad983b019a8c1957c5c7()
		{
			List<PartyMember> list = c3597132158f73b56094e8a191790540b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			bool[] array = ce5966072808127e61e7ce33a59ba515c.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44668));
			byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44672);
			while ((int)b < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44684))
			{
				array[(int)b] = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44676) != 0);
				b = (byte)((int)b + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44680));
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
			if (!true)
			{
				RuntimeMethodHandle arg_62_0 = methodof(Raid.c6453779dc051ad983b019a8c1957c5c7()).MethodHandle;
			}
			byte b2 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44688);
			while ((int)b2 < c73cd36356c918db494be7e2db29ccd40.c30767ddca1f9c207888833aea5b5fc61(list))
			{
				array[(int)c30cf954611cfdc1b527c0d87428757e3.c30767ddca1f9c207888833aea5b5fc61(c0cf9da17852f0365645b15a64c1d988f.c30767ddca1f9c207888833aea5b5fc61(list, (int)b2))] = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44692) != 0);
				b2 = (byte)((int)b2 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44696));
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
			byte b3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44700);
			while ((int)b3 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44708))
			{
				if (array[(int)b3])
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
					return b3;
				}
				b3 = (byte)((int)b3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44704));
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
			return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44712);
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x000AE154 File Offset: 0x000AC354
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x000AE168 File Offset: 0x000AC368
		public PartyItemDistribution itemsDistribution
		{
			get;
			internal set;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000AE17C File Offset: 0x000AC37C
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x000AE190 File Offset: 0x000AC390
		public PartyPersonalItemsDrawing personalItemsDrawing
		{
			get;
			internal set;
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000AE1A4 File Offset: 0x000AC3A4
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x000AE1B8 File Offset: 0x000AC3B8
		public ItemGrade rollOfDiceDrawing
		{
			get;
			internal set;
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000AE1CC File Offset: 0x000AC3CC
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x000AE1E0 File Offset: 0x000AC3E0
		internal uint id
		{
			get;
			set;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000AE1F4 File Offset: 0x000AC3F4
		public List<PartyMember> getMembers()
		{
			List<PartyMember> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c236863d6013600b1c38154c072385c8b.c30767ddca1f9c207888833aea5b5fc61(cb35502ff1bda6bb39de5c9b24edb5478.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)).ToList<PartyMember>();
			}
			return result;
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000AE24C File Offset: 0x000AC44C
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x000AE260 File Offset: 0x000AC460
		public bool isRaid
		{
			get;
			internal set;
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000AE274 File Offset: 0x000AC474
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x000AE288 File Offset: 0x000AC488
		internal uint raidLeaderUniqObjId
		{
			get;
			set;
		}

		// Token: 0x04000E12 RID: 3602
		[CompilerGenerated]
		private uint c3312f445b524f25fcc0a809d0cc2fa3d;

		// Token: 0x04000E13 RID: 3603
		[CompilerGenerated]
		private Dictionary<uint, PartyMember> c4faf4a0a233a6f34e16e87285831d034;

		// Token: 0x04000E14 RID: 3604
		[CompilerGenerated]
		private PartyItemDistribution c30aacb4fa35b66317a744ccdaf4099a7;

		// Token: 0x04000E15 RID: 3605
		[CompilerGenerated]
		private PartyPersonalItemsDrawing cd981d28c694fb105a1139111d904ba39;

		// Token: 0x04000E16 RID: 3606
		[CompilerGenerated]
		private ItemGrade c94a720a497c2736ad58c9d3e3afb649f;

		// Token: 0x04000E17 RID: 3607
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000E18 RID: 3608
		[CompilerGenerated]
		private bool ce59d9a6fb01d771c3f49d7f722c0dcc3;

		// Token: 0x04000E19 RID: 3609
		[CompilerGenerated]
		private uint cbcbd462262b04938ff274c0e197855c7;
	}
}
