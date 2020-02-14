using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x0200009E RID: 158
	public class SqlAuctionBCategory : MarshalProxy
	{
		// Token: 0x06000316 RID: 790 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
		internal SqlAuctionBCategory()
		{
			c985117a94f38d56cfb6616251424b26e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0002EBC8 File Offset: 0x0002CDC8
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0002EBDC File Offset: 0x0002CDDC
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0002EBF0 File Offset: 0x0002CDF0
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0002EC04 File Offset: 0x0002CE04
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0002EC18 File Offset: 0x0002CE18
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0002EC2C File Offset: 0x0002CE2C
		public SqlAuctionACategory parent
		{
			get;
			internal set;
		}

		// Token: 0x04000224 RID: 548
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000225 RID: 549
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000226 RID: 550
		[CompilerGenerated]
		private SqlAuctionACategory ce705553a9a279921ac66441c36552d76;
	}
}
