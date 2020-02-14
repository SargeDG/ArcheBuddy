using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B5 RID: 181
	public class SqlTaggedSkill : MarshalProxy
	{
		// Token: 0x0600040B RID: 1035 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		internal SqlTaggedSkill()
		{
			cc671efc1139806516a33940ecd263f10.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkill>());
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00030008 File Offset: 0x0002E208
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0003001C File Offset: 0x0002E21C
		public uint tagId
		{
			get;
			internal set;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00030030 File Offset: 0x0002E230
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00030044 File Offset: 0x0002E244
		public List<SqlSkill> skills
		{
			get;
			internal set;
		}

		// Token: 0x04000293 RID: 659
		[CompilerGenerated]
		private uint cb7bb4c155c11c6426e959d8f7e55549f;

		// Token: 0x04000294 RID: 660
		[CompilerGenerated]
		private List<SqlSkill> cd75886f46b62363d48b37a46236e0b2d;
	}
}
