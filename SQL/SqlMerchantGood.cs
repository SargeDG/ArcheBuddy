using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A0 RID: 160
	public class SqlMerchantGood : MarshalProxy
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0002ECD8 File Offset: 0x0002CED8
		internal SqlMerchantGood()
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0002ED00 File Offset: 0x0002CF00
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0002ED14 File Offset: 0x0002CF14
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0002ED28 File Offset: 0x0002CF28
		public SqlMerchantPack merchantPack
		{
			get;
			internal set;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0002ED50 File Offset: 0x0002CF50
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0002ED64 File Offset: 0x0002CF64
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0002ED78 File Offset: 0x0002CF78
		public byte gradeId
		{
			get;
			internal set;
		}

		// Token: 0x0400022A RID: 554
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400022B RID: 555
		[CompilerGenerated]
		private SqlMerchantPack cdab4c76708f4259c8e6d63aef59657ef;

		// Token: 0x0400022C RID: 556
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;

		// Token: 0x0400022D RID: 557
		[CompilerGenerated]
		private byte c5d1619bf58c7ae64e2f79a8cfa54a2de;
	}
}
