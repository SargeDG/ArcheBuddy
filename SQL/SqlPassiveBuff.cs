using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B8 RID: 184
	public class SqlPassiveBuff : MarshalProxy
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x00030294 File Offset: 0x0002E494
		internal SqlPassiveBuff()
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x000302A8 File Offset: 0x0002E4A8
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x000302BC File Offset: 0x0002E4BC
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x000302D0 File Offset: 0x0002E4D0
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x000302E4 File Offset: 0x0002E4E4
		public int abilityId
		{
			get;
			internal set;
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x000302F8 File Offset: 0x0002E4F8
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0003030C File Offset: 0x0002E50C
		public int level
		{
			get;
			internal set;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x00030320 File Offset: 0x0002E520
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00030334 File Offset: 0x0002E534
		public int buffId
		{
			get;
			internal set;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x00030348 File Offset: 0x0002E548
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0003035C File Offset: 0x0002E55C
		public int reqPoints
		{
			get;
			internal set;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x00030370 File Offset: 0x0002E570
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00030384 File Offset: 0x0002E584
		public bool active
		{
			get;
			internal set;
		}

		// Token: 0x040002A2 RID: 674
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040002A3 RID: 675
		[CompilerGenerated]
		private int c91234f8fabeb8a15f754fc7cbd7f11d9;

		// Token: 0x040002A4 RID: 676
		[CompilerGenerated]
		private int cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x040002A5 RID: 677
		[CompilerGenerated]
		private int cf2769573844ae5774dc3b5cdece2565f;

		// Token: 0x040002A6 RID: 678
		[CompilerGenerated]
		private int cc1f93d3a466ee690ffece992a9c38f50;

		// Token: 0x040002A7 RID: 679
		[CompilerGenerated]
		private bool c746a07773b3ba06248df4d2594ad364e;
	}
}
