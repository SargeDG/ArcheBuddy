using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000AE RID: 174
	public class SqlDynamicUnitModifier : MarshalProxy
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x0002FB6C File Offset: 0x0002DD6C
		internal SqlDynamicUnitModifier()
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0002FB80 File Offset: 0x0002DD80
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0002FB94 File Offset: 0x0002DD94
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0002FBA8 File Offset: 0x0002DDA8
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x0002FBBC File Offset: 0x0002DDBC
		public int unitAttributeId
		{
			get;
			internal set;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
		// (set) Token: 0x060003DA RID: 986 RVA: 0x0002FBE4 File Offset: 0x0002DDE4
		public int unitModifierTypeId
		{
			get;
			internal set;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003DB RID: 987 RVA: 0x0002FBF8 File Offset: 0x0002DDF8
		// (set) Token: 0x060003DC RID: 988 RVA: 0x0002FC0C File Offset: 0x0002DE0C
		public string funcType
		{
			get;
			internal set;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0002FC20 File Offset: 0x0002DE20
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0002FC34 File Offset: 0x0002DE34
		public SqlLinearFunc linearFunc
		{
			get;
			internal set;
		}

		// Token: 0x0400027B RID: 635
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400027C RID: 636
		[CompilerGenerated]
		private int c6762d0fea082ef1d52affe2f90e902f9;

		// Token: 0x0400027D RID: 637
		[CompilerGenerated]
		private int cbb4793fb5d1a1b5aa267174a8d2f87fc;

		// Token: 0x0400027E RID: 638
		[CompilerGenerated]
		private string ce678c9d6f8ac3b1891a4f802465b066c;

		// Token: 0x0400027F RID: 639
		[CompilerGenerated]
		private SqlLinearFunc c4ec28f49033f75c386c976f81d4fabf8;
	}
}
