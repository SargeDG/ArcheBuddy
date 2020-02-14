using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C2 RID: 194
	public class SqlMountSkill : MarshalProxy
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x000312D0 File Offset: 0x0002F4D0
		internal SqlMountSkill()
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x000312E4 File Offset: 0x0002F4E4
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x000312F8 File Offset: 0x0002F4F8
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0003130C File Offset: 0x0002F50C
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00031320 File Offset: 0x0002F520
		public SqlSkill skill
		{
			get;
			internal set;
		}

		// Token: 0x040002FD RID: 765
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040002FE RID: 766
		[CompilerGenerated]
		private SqlSkill c52f70b53561b4aabff3b19e11226701c;
	}
}
