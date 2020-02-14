using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000D8 RID: 216
	public class SqlQuestActConReportDoodad : MarshalProxy
	{
		// Token: 0x06000634 RID: 1588 RVA: 0x00032E50 File Offset: 0x00031050
		internal SqlQuestActConReportDoodad()
		{
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00032E64 File Offset: 0x00031064
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00032E78 File Offset: 0x00031078
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00032E8C File Offset: 0x0003108C
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00032EA0 File Offset: 0x000310A0
		public SqlDoodadAlmighty doodad
		{
			get;
			internal set;
		}

		// Token: 0x04000398 RID: 920
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000399 RID: 921
		[CompilerGenerated]
		private SqlDoodadAlmighty cc303398ded91a2636827d2651822084f;
	}
}
