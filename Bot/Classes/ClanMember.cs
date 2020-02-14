using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004B9 RID: 1209
	public class ClanMember : MarshalProxy
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x000A3064 File Offset: 0x000A1264
		internal ClanMember()
		{
			this.ce33a7efdb8a3e9afcb96a0f5458403cb = new List<Ability>();
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x000A3084 File Offset: 0x000A1284
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x000A3098 File Offset: 0x000A1298
		public uint uniqId
		{
			get;
			internal set;
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x000A30AC File Offset: 0x000A12AC
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x000A30C0 File Offset: 0x000A12C0
		public bool inParty
		{
			get;
			internal set;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x000A30D4 File Offset: 0x000A12D4
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x000A30E8 File Offset: 0x000A12E8
		public bool isOnline
		{
			get;
			internal set;
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x000A30FC File Offset: 0x000A12FC
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x000A3110 File Offset: 0x000A1310
		public ulong lastWorldLeaveTime
		{
			get;
			internal set;
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x000A3124 File Offset: 0x000A1324
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x000A3138 File Offset: 0x000A1338
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x000A314C File Offset: 0x000A134C
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x000A3160 File Offset: 0x000A1360
		public byte level
		{
			get;
			internal set;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000A3174 File Offset: 0x000A1374
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x000A3188 File Offset: 0x000A1388
		public ClanRole role
		{
			get;
			internal set;
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000A319C File Offset: 0x000A139C
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x000A31B0 File Offset: 0x000A13B0
		public double X
		{
			get;
			internal set;
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000A31C4 File Offset: 0x000A13C4
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x000A31D8 File Offset: 0x000A13D8
		public double Y
		{
			get;
			internal set;
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000A31EC File Offset: 0x000A13EC
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x000A3200 File Offset: 0x000A1400
		public double Z
		{
			get;
			internal set;
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x000A3214 File Offset: 0x000A1414
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x000A3228 File Offset: 0x000A1428
		public SqlSubZone subZone
		{
			get;
			internal set;
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x000A323C File Offset: 0x000A143C
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x000A3250 File Offset: 0x000A1450
		public SqlZone zone
		{
			get;
			internal set;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000A3264 File Offset: 0x000A1464
		public List<Ability> getAbilities()
		{
			List<Ability> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ce33a7efdb8a3e9afcb96a0f5458403cb))
			{
				result = this.ce33a7efdb8a3e9afcb96a0f5458403cb.ToList<Ability>();
			}
			return result;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000A32B0 File Offset: 0x000A14B0
		internal List<Ability> get_c1f33b4de07ecab5e57658871886d926f()
		{
			return this.ce33a7efdb8a3e9afcb96a0f5458403cb;
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x000A32C4 File Offset: 0x000A14C4
		internal void set_c1f33b4de07ecab5e57658871886d926f(List<Ability> list)
		{
			this.ce33a7efdb8a3e9afcb96a0f5458403cb = list;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x000A32D8 File Offset: 0x000A14D8
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
						RuntimeMethodHandle arg_1A_0 = methodof(ClanMember.Dispose(bool)).MethodHandle;
					}
					ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000D88 RID: 3464
		internal List<Ability> ce33a7efdb8a3e9afcb96a0f5458403cb;

		// Token: 0x04000D89 RID: 3465
		[CompilerGenerated]
		private uint c1f042b599e757f7d30e4be9756bd3cb4;

		// Token: 0x04000D8A RID: 3466
		[CompilerGenerated]
		private bool c997c74c81de1901aa9ce3dcf11d80b1d;

		// Token: 0x04000D8B RID: 3467
		[CompilerGenerated]
		private bool c75e3dd7d3b3bcb2661782e7158a2e144;

		// Token: 0x04000D8C RID: 3468
		[CompilerGenerated]
		private ulong c0c044a77813311f57d06cd50fa8c9268;

		// Token: 0x04000D8D RID: 3469
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000D8E RID: 3470
		[CompilerGenerated]
		private byte cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x04000D8F RID: 3471
		[CompilerGenerated]
		private ClanRole cc84fe6a87b1d01269424c669989e2c63;

		// Token: 0x04000D90 RID: 3472
		[CompilerGenerated]
		private double c4e1d1d0caa6a804f4989545e0d5f9f5f;

		// Token: 0x04000D91 RID: 3473
		[CompilerGenerated]
		private double ca9ac1684d7c60158fa9bdbd1d337b57b;

		// Token: 0x04000D92 RID: 3474
		[CompilerGenerated]
		private double c4810739f49f8dec1960e013b60a21005;

		// Token: 0x04000D93 RID: 3475
		[CompilerGenerated]
		private SqlSubZone c269853c94bbea7bb525cb19c13413472;

		// Token: 0x04000D94 RID: 3476
		[CompilerGenerated]
		private SqlZone c7ccca5a44d7e02ee2947104e0245ab0a;
	}
}
