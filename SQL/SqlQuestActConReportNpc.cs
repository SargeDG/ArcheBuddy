using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000DB RID: 219
	public class SqlQuestActConReportNpc : MarshalProxy
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x00032F54 File Offset: 0x00031154
		internal SqlQuestActConReportNpc()
		{
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00032F68 File Offset: 0x00031168
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00032F7C File Offset: 0x0003117C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00032F90 File Offset: 0x00031190
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00032FA4 File Offset: 0x000311A4
		public SqlNpc npc
		{
			get;
			internal set;
		}

		// Token: 0x0400039D RID: 925
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400039E RID: 926
		[CompilerGenerated]
		private SqlNpc c6ee6e2dc140bcb16453a29672895d5ef;
	}
}
