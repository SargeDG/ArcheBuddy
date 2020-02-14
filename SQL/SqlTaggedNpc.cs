using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B2 RID: 178
	public class SqlTaggedNpc : MarshalProxy
	{
		// Token: 0x060003FC RID: 1020 RVA: 0x0002FE98 File Offset: 0x0002E098
		internal SqlTaggedNpc()
		{
			c871846d3b91a9d89f9cddae012bd0c15.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlNpc>());
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0002FEB8 File Offset: 0x0002E0B8
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x0002FECC File Offset: 0x0002E0CC
		public uint tagId
		{
			get;
			internal set;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		public List<SqlNpc> npcs
		{
			get;
			internal set;
		}

		// Token: 0x0400028D RID: 653
		[CompilerGenerated]
		private uint cb7bb4c155c11c6426e959d8f7e55549f;

		// Token: 0x0400028E RID: 654
		[CompilerGenerated]
		private List<SqlNpc> c9f2f1bdc80f1490cf1317a0abeed83ad;
	}
}
