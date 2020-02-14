using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004DE RID: 1246
	public class Territory : BaseObject
	{
		// Token: 0x06001516 RID: 5398 RVA: 0x000B8EA0 File Offset: 0x000B70A0
		internal Territory()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48424));
			cbf22f6cb1738d4ccbdae904939028d28.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			cc77b2dec0530807180ddf5247cbea64d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c388f7ca1b17c289bd13aa71aeac47cb5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (TerritoryState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48428));
			c71ac2d1480e484d6bd2a0e9df4010651.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<Climate>());
			this.ce59e203faf79a2e5b973f91b58df4955 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48432);
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x000B8F04 File Offset: 0x000B7104
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x000B8F18 File Offset: 0x000B7118
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000B8F2C File Offset: 0x000B712C
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x000B8F40 File Offset: 0x000B7140
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x000B8F54 File Offset: 0x000B7154
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x000B8F68 File Offset: 0x000B7168
		public string displayName
		{
			get;
			internal set;
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x000B8F7C File Offset: 0x000B717C
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x000B8F90 File Offset: 0x000B7190
		public double x
		{
			get;
			internal set;
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x000B8FA4 File Offset: 0x000B71A4
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x000B8FB8 File Offset: 0x000B71B8
		public double y
		{
			get;
			internal set;
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x000B8FCC File Offset: 0x000B71CC
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x000B8FE0 File Offset: 0x000B71E0
		public double width
		{
			get;
			internal set;
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x000B8FF4 File Offset: 0x000B71F4
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x000B9008 File Offset: 0x000B7208
		public double heigth
		{
			get;
			internal set;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x000B901C File Offset: 0x000B721C
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x000B9030 File Offset: 0x000B7230
		public TerritoryState state
		{
			get;
			internal set;
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000B9044 File Offset: 0x000B7244
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x000B9058 File Offset: 0x000B7258
		public long time
		{
			get;
			internal set;
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x000B906C File Offset: 0x000B726C
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x000B9080 File Offset: 0x000B7280
		public List<Climate> climates
		{
			get;
			internal set;
		}

		// Token: 0x04000F18 RID: 3864
		internal int ce59e203faf79a2e5b973f91b58df4955;

		// Token: 0x04000F19 RID: 3865
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000F1A RID: 3866
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000F1B RID: 3867
		[CompilerGenerated]
		private string cf1d3352f96f0b60b54d60936f0fcf170;

		// Token: 0x04000F1C RID: 3868
		[CompilerGenerated]
		private double ca7fad13c316e809c89069ffdb5ba59d8;

		// Token: 0x04000F1D RID: 3869
		[CompilerGenerated]
		private double c9cdc89109d0276c13fa87317f2c2f379;

		// Token: 0x04000F1E RID: 3870
		[CompilerGenerated]
		private double c3487e71162b5e03f72675b6d6c311437;

		// Token: 0x04000F1F RID: 3871
		[CompilerGenerated]
		private double ce0b2dcc1d6dbea228f284975a40c2c6b;

		// Token: 0x04000F20 RID: 3872
		[CompilerGenerated]
		private TerritoryState c75a2f971304d096157a0716671262dd6;

		// Token: 0x04000F21 RID: 3873
		[CompilerGenerated]
		private long cc7eab308bb41a3bbfa402203e17b418d;

		// Token: 0x04000F22 RID: 3874
		[CompilerGenerated]
		private List<Climate> c077dbff4b84c74f55cb743a48c5b5ac4;
	}
}
