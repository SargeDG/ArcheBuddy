using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E2 RID: 226
	public class SqlQuestContext : MarshalProxy
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x000335EC File Offset: 0x000317EC
		internal SqlQuestContext()
		{
			c3f1c6a9b60bc8eebd886a8c2665565cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c20eaf9bfcc076c5b3048169d6b9d5389.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestComponent>());
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00033618 File Offset: 0x00031818
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x0003362C File Offset: 0x0003182C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00033640 File Offset: 0x00031840
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00033654 File Offset: 0x00031854
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00033668 File Offset: 0x00031868
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x0003367C File Offset: 0x0003187C
		public int categoryId
		{
			get;
			internal set;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00033690 File Offset: 0x00031890
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x000336A4 File Offset: 0x000318A4
		public bool repeatable
		{
			get;
			internal set;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000336B8 File Offset: 0x000318B8
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x000336CC File Offset: 0x000318CC
		public bool letItDone
		{
			get;
			internal set;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000336E0 File Offset: 0x000318E0
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x000336F4 File Offset: 0x000318F4
		public int level
		{
			get;
			internal set;
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00033708 File Offset: 0x00031908
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0003371C File Offset: 0x0003191C
		public int detailId
		{
			get;
			internal set;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00033730 File Offset: 0x00031930
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00033744 File Offset: 0x00031944
		public int zoneId
		{
			get;
			internal set;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00033758 File Offset: 0x00031958
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x0003376C File Offset: 0x0003196C
		public int degree
		{
			get;
			internal set;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00033780 File Offset: 0x00031980
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00033794 File Offset: 0x00031994
		public int score
		{
			get;
			internal set;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x000337A8 File Offset: 0x000319A8
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x000337BC File Offset: 0x000319BC
		public int gradeId
		{
			get;
			internal set;
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x000337D0 File Offset: 0x000319D0
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x000337E4 File Offset: 0x000319E4
		public List<SqlQuestComponent> components
		{
			get;
			internal set;
		}

		// Token: 0x040003C0 RID: 960
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003C1 RID: 961
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x040003C2 RID: 962
		[CompilerGenerated]
		private int c3aa55c4c3c25be631442b35a66e6472b;

		// Token: 0x040003C3 RID: 963
		[CompilerGenerated]
		private bool cbda22df91dbfc611c803028418dd7191;

		// Token: 0x040003C4 RID: 964
		[CompilerGenerated]
		private bool c938b490c6d8689f8a5c8c21f5cc53849;

		// Token: 0x040003C5 RID: 965
		[CompilerGenerated]
		private int cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x040003C6 RID: 966
		[CompilerGenerated]
		private int c250f3efda6ab2a3f34e8a495b16b6595;

		// Token: 0x040003C7 RID: 967
		[CompilerGenerated]
		private int cf8d76cb03307f91725d606bd77780a9e;

		// Token: 0x040003C8 RID: 968
		[CompilerGenerated]
		private int c8fc83cf6a957a9076659fed7cd1808f6;

		// Token: 0x040003C9 RID: 969
		[CompilerGenerated]
		private int c1688417b90ab12ba2d1b4c01c2d4c967;

		// Token: 0x040003CA RID: 970
		[CompilerGenerated]
		private int c5d1619bf58c7ae64e2f79a8cfa54a2de;

		// Token: 0x040003CB RID: 971
		[CompilerGenerated]
		private List<SqlQuestComponent> cd5e1e47ffa6d794bc3b4309095f3aa74;
	}
}
