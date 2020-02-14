using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B6 RID: 182
	public class SqlDoodadAlmighty : MarshalProxy
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00030058 File Offset: 0x0002E258
		internal SqlDoodadAlmighty()
		{
			c808d780aff009b3886d75d12673769b6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			caf5f1346bd82d6502672cc4ff78a1e79.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlDoodadFuncGroup>());
			this.spawnPoints = new List<Point3D>();
			c480d682c2d070e54f9e0a6ff7d31201a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(10128));
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x000300A0 File Offset: 0x0002E2A0
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000300B4 File Offset: 0x0002E2B4
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x000300C8 File Offset: 0x0002E2C8
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x000300DC File Offset: 0x0002E2DC
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000300F0 File Offset: 0x0002E2F0
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00030104 File Offset: 0x0002E304
		public int groupId
		{
			get;
			internal set;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00030118 File Offset: 0x0002E318
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0003012C File Offset: 0x0002E32C
		public int climateId
		{
			get;
			internal set;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00030140 File Offset: 0x0002E340
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00030154 File Offset: 0x0002E354
		public int simRadius
		{
			get;
			internal set;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00030168 File Offset: 0x0002E368
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x0003017C File Offset: 0x0002E37C
		public float navRadius
		{
			get;
			set;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00030190 File Offset: 0x0002E390
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x000301A4 File Offset: 0x0002E3A4
		public int growthTime
		{
			get;
			internal set;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x000301B8 File Offset: 0x0002E3B8
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x000301CC File Offset: 0x0002E3CC
		public List<SqlDoodadFuncGroup> phases
		{
			get;
			internal set;
		}

		// Token: 0x04000295 RID: 661
		public List<Point3D> spawnPoints;

		// Token: 0x04000296 RID: 662
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000297 RID: 663
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000298 RID: 664
		[CompilerGenerated]
		private int cc78ebaac5f1f144e26701c0e01904c57;

		// Token: 0x04000299 RID: 665
		[CompilerGenerated]
		private int cf418d570901059896ba420b85f665b8b;

		// Token: 0x0400029A RID: 666
		[CompilerGenerated]
		private int c5b553d4fcde097ded6324bf1668efd60;

		// Token: 0x0400029B RID: 667
		[CompilerGenerated]
		private float c0b227011ca2feac6a93921be7ae0763b;

		// Token: 0x0400029C RID: 668
		[CompilerGenerated]
		private int c7c25aade8639dc5d7691afac1c67fef4;

		// Token: 0x0400029D RID: 669
		[CompilerGenerated]
		private List<SqlDoodadFuncGroup> c42c6c3a742da0baa5e671d8a2d648ecd;
	}
}
