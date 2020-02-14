using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A1 RID: 161
	public class SqlMerchantPack : MarshalProxy
	{
		// Token: 0x0600032D RID: 813 RVA: 0x0002ED8C File Offset: 0x0002CF8C
		internal SqlMerchantPack()
		{
			c25600e6deb835ce741c4e59fba361fd3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlMerchantGood>());
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0002EDAC File Offset: 0x0002CFAC
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0002EDC0 File Offset: 0x0002CFC0
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0002EDD4 File Offset: 0x0002CFD4
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		public SqlNpc ownerNpc
		{
			get;
			internal set;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0002EDFC File Offset: 0x0002CFFC
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0002EE10 File Offset: 0x0002D010
		public byte kindId
		{
			get;
			internal set;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0002EE24 File Offset: 0x0002D024
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0002EE38 File Offset: 0x0002D038
		public List<SqlMerchantGood> goods
		{
			get;
			internal set;
		}

		// Token: 0x0400022E RID: 558
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400022F RID: 559
		[CompilerGenerated]
		private SqlNpc cc9a24ccaa55d5dcc53dd5a0c050207a8;

		// Token: 0x04000230 RID: 560
		[CompilerGenerated]
		private byte c75371bad8576903afd612bf8194e92c8;

		// Token: 0x04000231 RID: 561
		[CompilerGenerated]
		private List<SqlMerchantGood> c66e626be8065766698e3082b6c05f18d;
	}
}
