using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E7 RID: 231
	public class SqlSkillReq : MarshalProxy
	{
		// Token: 0x060006D1 RID: 1745 RVA: 0x00033B60 File Offset: 0x00031D60
		internal SqlSkillReq()
		{
			cb9a60bb1c560ea1dcd36a17df9a09f6b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c82264c5c0e7b239ab160279396743eca.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlBuff>());
			ce2dcd41cf4e8671ee850da27a6f76405.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkill>());
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00033B94 File Offset: 0x00031D94
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x00033BA8 File Offset: 0x00031DA8
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00033BBC File Offset: 0x00031DBC
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00033BD0 File Offset: 0x00031DD0
		public bool target
		{
			get;
			internal set;
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00033BE4 File Offset: 0x00031DE4
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00033BF8 File Offset: 0x00031DF8
		public List<SqlBuff> buffs
		{
			get;
			internal set;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00033C0C File Offset: 0x00031E0C
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00033C20 File Offset: 0x00031E20
		public List<SqlSkill> skills
		{
			get;
			internal set;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00033C34 File Offset: 0x00031E34
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x00033C48 File Offset: 0x00031E48
		public string message
		{
			get;
			internal set;
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00033C5C File Offset: 0x00031E5C
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00033C70 File Offset: 0x00031E70
		public bool defaultResult
		{
			get;
			internal set;
		}

		// Token: 0x040003DF RID: 991
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003E0 RID: 992
		[CompilerGenerated]
		private bool c20a751968410f35051b7e8dd973a5128;

		// Token: 0x040003E1 RID: 993
		[CompilerGenerated]
		private List<SqlBuff> c2d451600af114c6cbc49bd539f132a09;

		// Token: 0x040003E2 RID: 994
		[CompilerGenerated]
		private List<SqlSkill> cd75886f46b62363d48b37a46236e0b2d;

		// Token: 0x040003E3 RID: 995
		[CompilerGenerated]
		private string c28b961a7e75a317e67bee4b66757a137;

		// Token: 0x040003E4 RID: 996
		[CompilerGenerated]
		private bool c714efcb02f7c13c9377ffa421628400a;
	}
}
