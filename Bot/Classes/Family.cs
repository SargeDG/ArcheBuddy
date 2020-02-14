using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004BD RID: 1213
	public class Family : BaseObject
	{
		// Token: 0x060011EC RID: 4588 RVA: 0x000A3930 File Offset: 0x000A1B30
		internal Family()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39568));
			c1f9d0d2fe96bda83d97a77dca033eb19.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<FamilyMember>());
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000A3960 File Offset: 0x000A1B60
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(Family.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cc575d6e00d8064423a840ca45804515e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39560); i < c4f49e83f081eccbd2ebc88381e0e31dc.c30767ddca1f9c207888833aea5b5fc61(cc575d6e00d8064423a840ca45804515e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39564))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c3e95a8ba5ef08c3868b5bf7fb86f1c34.c30767ddca1f9c207888833aea5b5fc61(cc575d6e00d8064423a840ca45804515e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i));
								cca1de8046688423412118b127853e724.c30767ddca1f9c207888833aea5b5fc61(cc575d6e00d8064423a840ca45804515e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i, c1de936cd89a56a74ac00af170c9aad1f.c8a754f5f2ca4adde825691a9c31a0e83);
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
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x000A3A50 File Offset: 0x000A1C50
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x000A3A64 File Offset: 0x000A1C64
		internal uint id
		{
			get;
			set;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000A3A78 File Offset: 0x000A1C78
		public List<FamilyMember> getMembers()
		{
			List<FamilyMember> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cc575d6e00d8064423a840ca45804515e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = cc575d6e00d8064423a840ca45804515e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<FamilyMember>();
			}
			return result;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000A3AC8 File Offset: 0x000A1CC8
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x000A3ADC File Offset: 0x000A1CDC
		internal List<FamilyMember> members
		{
			get;
			set;
		}

		// Token: 0x04000DAA RID: 3498
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000DAB RID: 3499
		[CompilerGenerated]
		private List<FamilyMember> c4faf4a0a233a6f34e16e87285831d034;
	}
}
