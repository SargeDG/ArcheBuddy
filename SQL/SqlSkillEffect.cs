using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A8 RID: 168
	public class SqlSkillEffect : MarshalProxy
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0002F750 File Offset: 0x0002D950
		internal SqlSkillEffect()
		{
			c95d642cb613628f2f7ab5f3722199b66.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SqlEffect());
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0002F770 File Offset: 0x0002D970
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x0002F784 File Offset: 0x0002D984
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0002F798 File Offset: 0x0002D998
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x0002F7AC File Offset: 0x0002D9AC
		public SqlEffect effect
		{
			get;
			internal set;
		}

		// Token: 0x04000265 RID: 613
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000266 RID: 614
		[CompilerGenerated]
		private SqlEffect c709a7509ff5ae034c37abe7a0c008b97;
	}
}
