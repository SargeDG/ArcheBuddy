using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000CF RID: 207
	public class SqlCraftPack : MarshalProxy
	{
		// Token: 0x060005D1 RID: 1489 RVA: 0x00032604 File Offset: 0x00030804
		internal SqlCraftPack()
		{
			cc5e9b76f583df0f5c1e331010b27913e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlCraft>());
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00032624 File Offset: 0x00030824
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00032638 File Offset: 0x00030838
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0003264C File Offset: 0x0003084C
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00032660 File Offset: 0x00030860
		public List<SqlCraft> crafts
		{
			get;
			internal set;
		}

		// Token: 0x0400036A RID: 874
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400036B RID: 875
		[CompilerGenerated]
		private List<SqlCraft> c8465882433d9f584b1441e27e3cb4244;
	}
}
