using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E4 RID: 228
	public class SqlDoodadFuncPurchase : MarshalProxy
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x0003385C File Offset: 0x00031A5C
		internal SqlDoodadFuncPurchase()
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00033870 File Offset: 0x00031A70
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00033884 File Offset: 0x00031A84
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00033898 File Offset: 0x00031A98
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000338AC File Offset: 0x00031AAC
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x000338C0 File Offset: 0x00031AC0
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x000338D4 File Offset: 0x00031AD4
		public int itemCount
		{
			get;
			internal set;
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000338E8 File Offset: 0x00031AE8
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x000338FC File Offset: 0x00031AFC
		public SqlItem coinItem
		{
			get;
			internal set;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x00033910 File Offset: 0x00031B10
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00033924 File Offset: 0x00031B24
		public int coinItemCount
		{
			get;
			internal set;
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x00033938 File Offset: 0x00031B38
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0003394C File Offset: 0x00031B4C
		public int currencyId
		{
			get;
			internal set;
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00033960 File Offset: 0x00031B60
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00033974 File Offset: 0x00031B74
		public uint actualDoodadFuncId
		{
			get;
			internal set;
		}

		// Token: 0x040003CE RID: 974
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003CF RID: 975
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;

		// Token: 0x040003D0 RID: 976
		[CompilerGenerated]
		private int cc5e85b79755a5e91be36193720968de1;

		// Token: 0x040003D1 RID: 977
		[CompilerGenerated]
		private SqlItem cb93d0756c749dfed329562fd132d6290;

		// Token: 0x040003D2 RID: 978
		[CompilerGenerated]
		private int c2af3469de4aedbe5ffc464833885ccfa;

		// Token: 0x040003D3 RID: 979
		[CompilerGenerated]
		private int c9ce40ab9a60a0005a73803a1a1cfbbae;

		// Token: 0x040003D4 RID: 980
		[CompilerGenerated]
		private uint c381c1cada441e641d931187b97448c11;
	}
}
