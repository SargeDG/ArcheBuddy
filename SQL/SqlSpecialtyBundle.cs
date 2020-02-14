using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x02000095 RID: 149
	public class SqlSpecialtyBundle : MarshalProxy
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0002E6C8 File Offset: 0x0002C8C8
		// (set) Token: 0x060002DB RID: 731 RVA: 0x0002E6DC File Offset: 0x0002C8DC
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0002E6F0 File Offset: 0x0002C8F0
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0002E704 File Offset: 0x0002C904
		public uint ratio
		{
			get;
			internal set;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0002E718 File Offset: 0x0002C918
		// (set) Token: 0x060002DF RID: 735 RVA: 0x0002E72C File Offset: 0x0002C92C
		public uint profit
		{
			get;
			internal set;
		}

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400020B RID: 523
		[CompilerGenerated]
		private uint c33f358c2d39a47cd7c683d0fe402aff4;

		// Token: 0x0400020C RID: 524
		[CompilerGenerated]
		private uint c2333b3d33de625934173c84007f80e64;
	}
}
