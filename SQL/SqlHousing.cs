using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E8 RID: 232
	public class SqlHousing : MarshalProxy
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x00033C84 File Offset: 0x00031E84
		internal SqlHousing()
		{
			cc1612761ec3697560993c0ed0c9d87f0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlUnitModifier>());
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00033CA4 File Offset: 0x00031EA4
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00033CB8 File Offset: 0x00031EB8
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00033CCC File Offset: 0x00031ECC
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00033CE0 File Offset: 0x00031EE0
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00033CF4 File Offset: 0x00031EF4
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00033D08 File Offset: 0x00031F08
		public double gardenRadius
		{
			get;
			internal set;
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00033D1C File Offset: 0x00031F1C
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00033D30 File Offset: 0x00031F30
		public double alley
		{
			get;
			internal set;
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00033D44 File Offset: 0x00031F44
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00033D58 File Offset: 0x00031F58
		public int hp
		{
			get;
			internal set;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x00033D6C File Offset: 0x00031F6C
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00033D80 File Offset: 0x00031F80
		public List<SqlUnitModifier> unitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x040003E5 RID: 997
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003E6 RID: 998
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x040003E7 RID: 999
		[CompilerGenerated]
		private double c8c95f08725fca1c8d5a12e0a0d7297fb;

		// Token: 0x040003E8 RID: 1000
		[CompilerGenerated]
		private double cb18711af16164d32a1f80d010a94ce7d;

		// Token: 0x040003E9 RID: 1001
		[CompilerGenerated]
		private int c3088e06df58dab81d450f5e3f3488abc;

		// Token: 0x040003EA RID: 1002
		[CompilerGenerated]
		private List<SqlUnitModifier> c5357f6dc560843abe275cbafaa99a570;
	}
}
