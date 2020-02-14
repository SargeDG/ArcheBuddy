using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E5 RID: 229
	public class SqlSlave : MarshalProxy
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x00033988 File Offset: 0x00031B88
		internal SqlSlave()
		{
			ce76f0d1b7eb0f73283f7aaf1c4279e90.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c7b9e3e5e298edceed079f0aef9bd5246.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlUnitModifier>());
			cb2fe27820b4b380b77020dd20b252766.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlMountSkill>());
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x000339BC File Offset: 0x00031BBC
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x000339D0 File Offset: 0x00031BD0
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x000339E4 File Offset: 0x00031BE4
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x000339F8 File Offset: 0x00031BF8
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00033A0C File Offset: 0x00031C0C
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00033A20 File Offset: 0x00031C20
		public bool mountable
		{
			get;
			internal set;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00033A34 File Offset: 0x00031C34
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00033A48 File Offset: 0x00031C48
		public int level
		{
			get;
			internal set;
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00033A5C File Offset: 0x00031C5C
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00033A70 File Offset: 0x00031C70
		public byte slaveKindId
		{
			get;
			internal set;
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00033A84 File Offset: 0x00031C84
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00033A98 File Offset: 0x00031C98
		public List<SqlUnitModifier> unitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00033AAC File Offset: 0x00031CAC
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00033AC0 File Offset: 0x00031CC0
		public List<SqlMountSkill> mountSkills
		{
			get;
			internal set;
		}

		// Token: 0x040003D5 RID: 981
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003D6 RID: 982
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x040003D7 RID: 983
		[CompilerGenerated]
		private bool c4589324b9a06fc59790c310203b0a48e;

		// Token: 0x040003D8 RID: 984
		[CompilerGenerated]
		private int cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x040003D9 RID: 985
		[CompilerGenerated]
		private byte c72338a16e351d6cca7fb165006f45c17;

		// Token: 0x040003DA RID: 986
		[CompilerGenerated]
		private List<SqlUnitModifier> c5357f6dc560843abe275cbafaa99a570;

		// Token: 0x040003DB RID: 987
		[CompilerGenerated]
		private List<SqlMountSkill> cefb2c089fe7387eab36c31474af8ef24;
	}
}
