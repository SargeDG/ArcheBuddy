using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000AD RID: 173
	public class SqlLinearFunc : MarshalProxy
	{
		// Token: 0x060003CD RID: 973 RVA: 0x0002FAE0 File Offset: 0x0002DCE0
		internal SqlLinearFunc()
		{
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0002FAF4 File Offset: 0x0002DCF4
		// (set) Token: 0x060003CF RID: 975 RVA: 0x0002FB08 File Offset: 0x0002DD08
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0002FB30 File Offset: 0x0002DD30
		public int startValue
		{
			get;
			internal set;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0002FB44 File Offset: 0x0002DD44
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0002FB58 File Offset: 0x0002DD58
		public int endValue
		{
			get;
			internal set;
		}

		// Token: 0x04000278 RID: 632
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000279 RID: 633
		[CompilerGenerated]
		private int c8e87a0988c60756b8451ec01ceda07b0;

		// Token: 0x0400027A RID: 634
		[CompilerGenerated]
		private int c37e1a5fb2c7e007636763a24c9c318f4;
	}
}
