using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000DC RID: 220
	public class SqlQuestActConAcceptNpc : MarshalProxy
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x00032FB8 File Offset: 0x000311B8
		internal SqlQuestActConAcceptNpc()
		{
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00032FCC File Offset: 0x000311CC
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00032FE0 File Offset: 0x000311E0
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00032FF4 File Offset: 0x000311F4
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00033008 File Offset: 0x00031208
		public SqlNpc npc
		{
			get;
			internal set;
		}

		// Token: 0x0400039F RID: 927
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003A0 RID: 928
		[CompilerGenerated]
		private SqlNpc c6ee6e2dc140bcb16453a29672895d5ef;
	}
}
