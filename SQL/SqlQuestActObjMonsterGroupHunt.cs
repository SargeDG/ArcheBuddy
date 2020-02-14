using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E0 RID: 224
	public class SqlQuestActObjMonsterGroupHunt : MarshalProxy
	{
		// Token: 0x06000660 RID: 1632 RVA: 0x000331C0 File Offset: 0x000313C0
		internal SqlQuestActObjMonsterGroupHunt()
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x000331D4 File Offset: 0x000313D4
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x000331E8 File Offset: 0x000313E8
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000331FC File Offset: 0x000313FC
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00033210 File Offset: 0x00031410
		public uint npcGroupId
		{
			get;
			internal set;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00033224 File Offset: 0x00031424
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00033238 File Offset: 0x00031438
		public uint count
		{
			get;
			internal set;
		}

		// Token: 0x040003AA RID: 938
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003AB RID: 939
		[CompilerGenerated]
		private uint c1b2f83c0ce4a623faffe89eca72c0682;

		// Token: 0x040003AC RID: 940
		[CompilerGenerated]
		private uint c6621bffb628c518f8c4b4c8f86047ee4;
	}
}
