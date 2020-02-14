using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000DD RID: 221
	public class SqlQuestActObjItemGather : MarshalProxy
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x0003301C File Offset: 0x0003121C
		internal SqlQuestActObjItemGather()
		{
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00033030 File Offset: 0x00031230
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00033044 File Offset: 0x00031244
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00033058 File Offset: 0x00031258
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x0003306C File Offset: 0x0003126C
		public uint itemId
		{
			get;
			internal set;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00033080 File Offset: 0x00031280
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00033094 File Offset: 0x00031294
		public uint count
		{
			get;
			internal set;
		}

		// Token: 0x040003A1 RID: 929
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003A2 RID: 930
		[CompilerGenerated]
		private uint cc1a89b11db2b53a33b1a3065e996fe11;

		// Token: 0x040003A3 RID: 931
		[CompilerGenerated]
		private uint c6621bffb628c518f8c4b4c8f86047ee4;
	}
}
