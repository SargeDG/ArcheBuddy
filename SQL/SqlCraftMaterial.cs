using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000CE RID: 206
	public class SqlCraftMaterial : MarshalProxy
	{
		// Token: 0x060005CA RID: 1482 RVA: 0x00032578 File Offset: 0x00030778
		internal SqlCraftMaterial()
		{
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0003258C File Offset: 0x0003078C
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000325A0 File Offset: 0x000307A0
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x000325B4 File Offset: 0x000307B4
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x000325C8 File Offset: 0x000307C8
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x000325DC File Offset: 0x000307DC
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000325F0 File Offset: 0x000307F0
		public int amount
		{
			get;
			internal set;
		}

		// Token: 0x04000367 RID: 871
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000368 RID: 872
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;

		// Token: 0x04000369 RID: 873
		[CompilerGenerated]
		private int c270e8a2d309d2d2091f535f990b7bfc5;
	}
}
