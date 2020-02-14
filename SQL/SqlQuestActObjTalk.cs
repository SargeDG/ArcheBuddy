using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000D6 RID: 214
	public class SqlQuestActObjTalk : MarshalProxy
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x00032CE8 File Offset: 0x00030EE8
		internal SqlQuestActObjTalk()
		{
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00032CFC File Offset: 0x00030EFC
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00032D10 File Offset: 0x00030F10
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00032D24 File Offset: 0x00030F24
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00032D38 File Offset: 0x00030F38
		public uint mainActId
		{
			get;
			internal set;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00032D4C File Offset: 0x00030F4C
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00032D60 File Offset: 0x00030F60
		public SqlNpc npc
		{
			get;
			internal set;
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00032D74 File Offset: 0x00030F74
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00032D88 File Offset: 0x00030F88
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x04000390 RID: 912
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000391 RID: 913
		[CompilerGenerated]
		private uint c3d2c4f3306542d383678ffbf9bda4062;

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private SqlNpc c6ee6e2dc140bcb16453a29672895d5ef;

		// Token: 0x04000393 RID: 915
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;
	}
}
