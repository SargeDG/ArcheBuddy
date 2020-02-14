using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200000F RID: 15
	public class BackpackInfo : BaseObject
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000F918 File Offset: 0x0000DB18
		internal BackpackInfo()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1952));
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000F93C File Offset: 0x0000DB3C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000F950 File Offset: 0x0000DB50
		public int percentPrice
		{
			get;
			internal set;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000F964 File Offset: 0x0000DB64
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000F978 File Offset: 0x0000DB78
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x04000025 RID: 37
		[CompilerGenerated]
		private int c1ed5947e04bfea301f2b39bfb005ab92;

		// Token: 0x04000026 RID: 38
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;
	}
}
