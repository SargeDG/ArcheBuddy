using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x02000096 RID: 150
	public class SqlSpecialty : MarshalProxy
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0002E740 File Offset: 0x0002C940
		internal SqlSpecialty()
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0002E754 File Offset: 0x0002C954
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0002E768 File Offset: 0x0002C968
		public uint rowZoneGroupId
		{
			get;
			internal set;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0002E77C File Offset: 0x0002C97C
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0002E790 File Offset: 0x0002C990
		public uint colZoneGroupId
		{
			get;
			internal set;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0002E7A4 File Offset: 0x0002C9A4
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0002E7B8 File Offset: 0x0002C9B8
		public uint ratio
		{
			get;
			internal set;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x0002E7CC File Offset: 0x0002C9CC
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
		public uint profit
		{
			get;
			internal set;
		}

		// Token: 0x0400020D RID: 525
		[CompilerGenerated]
		private uint c2a581903235b95bcc2c4fa6f7d9bfb76;

		// Token: 0x0400020E RID: 526
		[CompilerGenerated]
		private uint c769d12843c90193b84ed9f0a051b4046;

		// Token: 0x0400020F RID: 527
		[CompilerGenerated]
		private uint c33f358c2d39a47cd7c683d0fe402aff4;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		private uint c2333b3d33de625934173c84007f80e64;
	}
}
