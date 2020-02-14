using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000D3 RID: 211
	public class SqlActabilityCategorie : MarshalProxy
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x00032B04 File Offset: 0x00030D04
		internal SqlActabilityCategorie()
		{
			c23df77290d721ae3333343f1191af9e7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00032B24 File Offset: 0x00030D24
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x00032B38 File Offset: 0x00030D38
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00032B4C File Offset: 0x00030D4C
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x00032B60 File Offset: 0x00030D60
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00032B74 File Offset: 0x00030D74
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x00032B88 File Offset: 0x00030D88
		public SqlActabilityGroup group
		{
			get;
			internal set;
		}

		// Token: 0x04000386 RID: 902
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000387 RID: 903
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000388 RID: 904
		[CompilerGenerated]
		private SqlActabilityGroup ce9f2ca2a2c9cbc26ab72a633caadacf6;
	}
}
