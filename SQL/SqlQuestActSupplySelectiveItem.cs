using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000D5 RID: 213
	public class SqlQuestActSupplySelectiveItem : MarshalProxy
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x00032C34 File Offset: 0x00030E34
		internal SqlQuestActSupplySelectiveItem()
		{
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00032C48 File Offset: 0x00030E48
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00032C5C File Offset: 0x00030E5C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00032C70 File Offset: 0x00030E70
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00032C84 File Offset: 0x00030E84
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00032C98 File Offset: 0x00030E98
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00032CAC File Offset: 0x00030EAC
		public int count
		{
			get;
			internal set;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00032CC0 File Offset: 0x00030EC0
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00032CD4 File Offset: 0x00030ED4
		public byte grade
		{
			get;
			internal set;
		}

		// Token: 0x0400038C RID: 908
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400038D RID: 909
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;

		// Token: 0x0400038E RID: 910
		[CompilerGenerated]
		private int c6621bffb628c518f8c4b4c8f86047ee4;

		// Token: 0x0400038F RID: 911
		[CompilerGenerated]
		private byte c6ec90c43376ad73d515e7843992dcc36;
	}
}
