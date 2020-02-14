using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000AA RID: 170
	public class SqlActorModel : MarshalProxy
	{
		// Token: 0x060003B8 RID: 952 RVA: 0x0002F914 File Offset: 0x0002DB14
		internal SqlActorModel()
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0002F928 File Offset: 0x0002DB28
		// (set) Token: 0x060003BA RID: 954 RVA: 0x0002F93C File Offset: 0x0002DB3C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0002F950 File Offset: 0x0002DB50
		// (set) Token: 0x060003BC RID: 956 RVA: 0x0002F964 File Offset: 0x0002DB64
		public double radius
		{
			get;
			internal set;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0002F978 File Offset: 0x0002DB78
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0002F98C File Offset: 0x0002DB8C
		public double height
		{
			get;
			internal set;
		}

		// Token: 0x0400026F RID: 623
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000270 RID: 624
		[CompilerGenerated]
		private double c8331fdc3a0edec5f6e011f6065da11ac;

		// Token: 0x04000271 RID: 625
		[CompilerGenerated]
		private double cdf1b09c2be7182825834fb94b404d3ad;
	}
}
