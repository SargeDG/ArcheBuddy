using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E3 RID: 227
	public class SqlBuffUnitModifier : MarshalProxy
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x000337F8 File Offset: 0x000319F8
		internal SqlBuffUnitModifier()
		{
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0003380C File Offset: 0x00031A0C
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x00033820 File Offset: 0x00031A20
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00033834 File Offset: 0x00031A34
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x00033848 File Offset: 0x00031A48
		public SqlBuff buff
		{
			get;
			internal set;
		}

		// Token: 0x040003CC RID: 972
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003CD RID: 973
		[CompilerGenerated]
		private SqlBuff cc2ed1e3d4b2d5088c2ccc12d7b16239e;
	}
}
