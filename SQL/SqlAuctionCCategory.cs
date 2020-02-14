using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x0200009F RID: 159
	public class SqlAuctionCCategory : MarshalProxy
	{
		// Token: 0x0600031D RID: 797 RVA: 0x0002EC40 File Offset: 0x0002CE40
		internal SqlAuctionCCategory()
		{
			c62b170d99013461c618e0e33980a5cac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0002EC60 File Offset: 0x0002CE60
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0002EC74 File Offset: 0x0002CE74
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0002EC88 File Offset: 0x0002CE88
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0002EC9C File Offset: 0x0002CE9C
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0002ECC4 File Offset: 0x0002CEC4
		public SqlAuctionBCategory parent
		{
			get;
			internal set;
		}

		// Token: 0x04000227 RID: 551
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000228 RID: 552
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000229 RID: 553
		[CompilerGenerated]
		private SqlAuctionBCategory ce705553a9a279921ac66441c36552d76;
	}
}
