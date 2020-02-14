using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A4 RID: 164
	public class SqlSpecialtyItemZone : MarshalProxy
	{
		// Token: 0x0600034A RID: 842 RVA: 0x0002F000 File Offset: 0x0002D200
		internal SqlSpecialtyItemZone()
		{
			c559716591018ba4beaaef9de2edd5b4c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlItem>());
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0002F020 File Offset: 0x0002D220
		// (set) Token: 0x0600034C RID: 844 RVA: 0x0002F034 File Offset: 0x0002D234
		public List<SqlItem> items
		{
			get;
			internal set;
		}

		// Token: 0x0400023B RID: 571
		[CompilerGenerated]
		private List<SqlItem> c7a6f1b4f2bbc14917328c6cbc9693811;
	}
}
