using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000DA RID: 218
	public class SqlQuestActConAcceptDoodad : MarshalProxy
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x00032EF0 File Offset: 0x000310F0
		internal SqlQuestActConAcceptDoodad()
		{
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00032F04 File Offset: 0x00031104
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00032F18 File Offset: 0x00031118
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00032F2C File Offset: 0x0003112C
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00032F40 File Offset: 0x00031140
		public SqlDoodadAlmighty doodad
		{
			get;
			internal set;
		}

		// Token: 0x0400039B RID: 923
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400039C RID: 924
		[CompilerGenerated]
		private SqlDoodadAlmighty cc303398ded91a2636827d2651822084f;
	}
}
