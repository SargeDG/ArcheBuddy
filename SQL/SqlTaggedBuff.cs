using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B4 RID: 180
	public class SqlTaggedBuff : MarshalProxy
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x0002FF78 File Offset: 0x0002E178
		internal SqlTaggedBuff()
		{
			cc45e372cfd735b1e941660e5d3ba7d58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlBuff>());
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0002FF98 File Offset: 0x0002E198
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0002FFAC File Offset: 0x0002E1AC
		public uint tagId
		{
			get;
			internal set;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0002FFC0 File Offset: 0x0002E1C0
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x0002FFD4 File Offset: 0x0002E1D4
		public List<SqlBuff> buffs
		{
			get;
			internal set;
		}

		// Token: 0x04000291 RID: 657
		[CompilerGenerated]
		private uint cb7bb4c155c11c6426e959d8f7e55549f;

		// Token: 0x04000292 RID: 658
		[CompilerGenerated]
		private List<SqlBuff> c2d451600af114c6cbc49bd539f132a09;
	}
}
