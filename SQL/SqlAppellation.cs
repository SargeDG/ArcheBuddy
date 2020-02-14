using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x02000092 RID: 146
	public class SqlAppellation : MarshalProxy
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0002E40C File Offset: 0x0002C60C
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0002E420 File Offset: 0x0002C620
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0002E434 File Offset: 0x0002C634
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0002E448 File Offset: 0x0002C648
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0002E45C File Offset: 0x0002C65C
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0002E470 File Offset: 0x0002C670
		public uint buffId
		{
			get;
			internal set;
		}

		// Token: 0x040001FA RID: 506
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040001FB RID: 507
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x040001FC RID: 508
		[CompilerGenerated]
		private uint cf2769573844ae5774dc3b5cdece2565f;
	}
}
