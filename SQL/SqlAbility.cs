using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C9 RID: 201
	public class SqlAbility : MarshalProxy
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00032040 File Offset: 0x00030240
		internal SqlAbility()
		{
			c235a73dd28945ff2a09e187d0024ec4a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c8887449990f22b7af0633ec2a9f6f75f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkill>());
			c99fd0e9bae1d1b656fc720c792a807a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlPassiveBuff>());
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00032074 File Offset: 0x00030274
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00032088 File Offset: 0x00030288
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0003209C File Offset: 0x0003029C
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x000320B0 File Offset: 0x000302B0
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x000320C4 File Offset: 0x000302C4
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x000320D8 File Offset: 0x000302D8
		public List<SqlSkill> abilitySkills
		{
			get;
			internal set;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x000320EC File Offset: 0x000302EC
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00032100 File Offset: 0x00030300
		public List<SqlPassiveBuff> abilityBuffs
		{
			get;
			internal set;
		}

		// Token: 0x0400034B RID: 843
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400034C RID: 844
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x0400034D RID: 845
		[CompilerGenerated]
		private List<SqlSkill> c85997d8c498857c02962ac0e823c7ebf;

		// Token: 0x0400034E RID: 846
		[CompilerGenerated]
		private List<SqlPassiveBuff> cea7e8a22b0b88ab213280f63119867ff;
	}
}
