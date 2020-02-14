using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000D7 RID: 215
	public class SqlQuestActObjInteraction : MarshalProxy
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00032D9C File Offset: 0x00030F9C
		internal SqlQuestActObjInteraction()
		{
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00032DB0 File Offset: 0x00030FB0
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00032DC4 File Offset: 0x00030FC4
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00032DD8 File Offset: 0x00030FD8
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00032DEC File Offset: 0x00030FEC
		public uint wiId
		{
			get;
			internal set;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00032E00 File Offset: 0x00031000
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00032E14 File Offset: 0x00031014
		public int count
		{
			get;
			internal set;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00032E28 File Offset: 0x00031028
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00032E3C File Offset: 0x0003103C
		public SqlDoodadAlmighty doodad
		{
			get;
			internal set;
		}

		// Token: 0x04000394 RID: 916
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000395 RID: 917
		[CompilerGenerated]
		private uint c578b8298c8c0fc713d1c294c044c7d38;

		// Token: 0x04000396 RID: 918
		[CompilerGenerated]
		private int c6621bffb628c518f8c4b4c8f86047ee4;

		// Token: 0x04000397 RID: 919
		[CompilerGenerated]
		private SqlDoodadAlmighty cc303398ded91a2636827d2651822084f;
	}
}
