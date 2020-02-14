using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B7 RID: 183
	public class SqlLevel : MarshalProxy
	{
		// Token: 0x06000421 RID: 1057 RVA: 0x000301E0 File Offset: 0x0002E3E0
		internal SqlLevel()
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000301F4 File Offset: 0x0002E3F4
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00030208 File Offset: 0x0002E408
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0003021C File Offset: 0x0002E41C
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00030230 File Offset: 0x0002E430
		public int totalExp
		{
			get;
			internal set;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00030244 File Offset: 0x0002E444
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00030258 File Offset: 0x0002E458
		public int totalMateExp
		{
			get;
			internal set;
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0003026C File Offset: 0x0002E46C
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00030280 File Offset: 0x0002E480
		public int skillPoints
		{
			get;
			internal set;
		}

		// Token: 0x0400029E RID: 670
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400029F RID: 671
		[CompilerGenerated]
		private int c08e600eb8b112406607f473b82870b60;

		// Token: 0x040002A0 RID: 672
		[CompilerGenerated]
		private int cd04d45d72de83920e84a8f524f05b940;

		// Token: 0x040002A1 RID: 673
		[CompilerGenerated]
		private int c27972e40caf57796c8ac2405507b46d3;
	}
}
