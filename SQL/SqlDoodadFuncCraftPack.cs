using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000CD RID: 205
	public class SqlDoodadFuncCraftPack : MarshalProxy
	{
		// Token: 0x060005C5 RID: 1477 RVA: 0x00032514 File Offset: 0x00030714
		internal SqlDoodadFuncCraftPack()
		{
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00032528 File Offset: 0x00030728
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x0003253C File Offset: 0x0003073C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00032550 File Offset: 0x00030750
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00032564 File Offset: 0x00030764
		public SqlCraftPack craftPack
		{
			get;
			internal set;
		}

		// Token: 0x04000365 RID: 869
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000366 RID: 870
		[CompilerGenerated]
		private SqlCraftPack c9a0b12ac5ecf49800b102693463f46ab;
	}
}
