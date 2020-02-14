using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C0 RID: 192
	public class SqlHoldable : MarshalProxy
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x000310C8 File Offset: 0x0002F2C8
		internal SqlHoldable()
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x000310DC File Offset: 0x0002F2DC
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x000310F0 File Offset: 0x0002F2F0
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00031104 File Offset: 0x0002F304
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00031118 File Offset: 0x0002F318
		public int speed
		{
			get;
			internal set;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0003112C File Offset: 0x0002F32C
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00031140 File Offset: 0x0002F340
		public int maxRange
		{
			get;
			internal set;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00031154 File Offset: 0x0002F354
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00031168 File Offset: 0x0002F368
		public int angle
		{
			get;
			internal set;
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0003117C File Offset: 0x0002F37C
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00031190 File Offset: 0x0002F390
		public uint slotTypeId
		{
			get;
			internal set;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000311A4 File Offset: 0x0002F3A4
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x000311B8 File Offset: 0x0002F3B8
		public int damageScale
		{
			get;
			internal set;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000311CC File Offset: 0x0002F3CC
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x000311E0 File Offset: 0x0002F3E0
		public int statMultiplier
		{
			get;
			internal set;
		}

		// Token: 0x040002F1 RID: 753
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040002F2 RID: 754
		[CompilerGenerated]
		private int c431a4d3f16791b5d7db3fe10fcbdc58d;

		// Token: 0x040002F3 RID: 755
		[CompilerGenerated]
		private int c816c6ae99ca96a806a3c1de3daa2f935;

		// Token: 0x040002F4 RID: 756
		[CompilerGenerated]
		private int c07da6efec8ffa77b9865318082a7cf5c;

		// Token: 0x040002F5 RID: 757
		[CompilerGenerated]
		private uint c23f4e9f7f8080368afea3a11738a4849;

		// Token: 0x040002F6 RID: 758
		[CompilerGenerated]
		private int cfcd5bc908ae7b9d7e2e5720bf83fc396;

		// Token: 0x040002F7 RID: 759
		[CompilerGenerated]
		private int c3acf9ad3d73143cb2d9ad78879dfd6ed;
	}
}
