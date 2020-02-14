using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004B8 RID: 1208
	public class Clan : MarshalProxy
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x000A2DAC File Offset: 0x000A0FAC
		internal Clan()
		{
			c5f8071dde3d4daa16cd8e7694661de58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<ClanRole>());
			cd42900aa904108365dbb82a08214ca15.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Dictionary<uint, ClanMember>());
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x000A2DD8 File Offset: 0x000A0FD8
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x000A2DEC File Offset: 0x000A0FEC
		internal List<ClanRole> roles
		{
			get;
			set;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x000A2E00 File Offset: 0x000A1000
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x000A2E14 File Offset: 0x000A1014
		internal Dictionary<uint, ClanMember> members
		{
			get;
			set;
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x000A2E28 File Offset: 0x000A1028
		public List<ClanRole> getRoles()
		{
			List<ClanRole> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c0ff05bac1b4b404d33531301bda266dc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c0ff05bac1b4b404d33531301bda266dc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<ClanRole>();
			}
			return result;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000A2E78 File Offset: 0x000A1078
		public List<ClanMember> getMembers()
		{
			List<ClanMember> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c042468c4ed24fdfbc4e0fa31e45430c3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = ceb4f1543533c53eb9d0c64b38aa70a7a.c30767ddca1f9c207888833aea5b5fc61(c042468c4ed24fdfbc4e0fa31e45430c3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)).ToList<ClanMember>();
			}
			return result;
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x000A2ED0 File Offset: 0x000A10D0
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
						RuntimeMethodHandle arg_1D_0 = methodof(Clan.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c0ff05bac1b4b404d33531301bda266dc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39476); i < c8a8b2939429b796c0667f4b066b6f14c.c30767ddca1f9c207888833aea5b5fc61(c0ff05bac1b4b404d33531301bda266dc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39480))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c038ca42d0f8fbcda4b5ca99e35832a3e.c30767ddca1f9c207888833aea5b5fc61(c0ff05bac1b4b404d33531301bda266dc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i));
								c0163e7855e682cffe8fbd22104336a4b.c30767ddca1f9c207888833aea5b5fc61(c0ff05bac1b4b404d33531301bda266dc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i, c630a599a6e4d846a02fb44cde4d13682.c8a754f5f2ca4adde825691a9c31a0e83);
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c042468c4ed24fdfbc4e0fa31e45430c3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							List<ClanMember> list = cb672377fe4509acd66fec6d8be569ade.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39484); j < cb2795cb8c4e2a9247139abe36e123b97.c30767ddca1f9c207888833aea5b5fc61(list); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39488))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cdf49879e7717f8d37f277abe105e4b08.c30767ddca1f9c207888833aea5b5fc61(list, j));
								c5845a08b7af3254cc3338a43d9610e5d.c30767ddca1f9c207888833aea5b5fc61(list, j, c96444f10bf22d625a56bb62aa0e4ea3e.c8a754f5f2ca4adde825691a9c31a0e83);
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
					ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000D86 RID: 3462
		[CompilerGenerated]
		private List<ClanRole> cbfa776c56f045125324fa759418cd1fe;

		// Token: 0x04000D87 RID: 3463
		[CompilerGenerated]
		private Dictionary<uint, ClanMember> c4faf4a0a233a6f34e16e87285831d034;
	}
}
