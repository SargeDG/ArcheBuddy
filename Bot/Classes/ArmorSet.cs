using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004BF RID: 1215
	public class ArmorSet : BaseObject
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x000A3BDC File Offset: 0x000A1DDC
		internal ArmorSet()
		{
			ce0e7b6a22c54ae715fca2162b7f14d96.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<ArmorSetItem>());
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x000A3BFC File Offset: 0x000A1DFC
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x000A3C10 File Offset: 0x000A1E10
		public List<ArmorSetItem> items
		{
			get;
			internal set;
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x000A3C24 File Offset: 0x000A1E24
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x000A3C38 File Offset: 0x000A1E38
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000A3C4C File Offset: 0x000A1E4C
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x000A3C60 File Offset: 0x000A1E60
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x000A3C74 File Offset: 0x000A1E74
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
						RuntimeMethodHandle arg_1D_0 = methodof(ArmorSet.Dispose(bool)).MethodHandle;
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
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39576); i < c18f027ea9c54be87e1ff9343db2a8bf0.c30767ddca1f9c207888833aea5b5fc61(cf0d9d9d1a89f66154c75473a599456c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39580))
						{
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c9309ba9b994ccc276ebf27ac1000558a.c30767ddca1f9c207888833aea5b5fc61(cf0d9d9d1a89f66154c75473a599456c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i));
							cc8aefa33d2008ecddb8c9e1f4ca2c062.c30767ddca1f9c207888833aea5b5fc61(cf0d9d9d1a89f66154c75473a599456c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i, c78b9b334ed0f713cb7495b1caec53c6c.c8a754f5f2ca4adde825691a9c31a0e83);
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
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000DB1 RID: 3505
		[CompilerGenerated]
		private List<ArmorSetItem> c7a6f1b4f2bbc14917328c6cbc9693811;

		// Token: 0x04000DB2 RID: 3506
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000DB3 RID: 3507
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;
	}
}
