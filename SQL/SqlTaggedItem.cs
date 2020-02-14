using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B3 RID: 179
	public class SqlTaggedItem : MarshalProxy
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x0002FF08 File Offset: 0x0002E108
		internal SqlTaggedItem()
		{
			ce9fed92dd5bc785d317658ce964c6881.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlItem>());
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0002FF28 File Offset: 0x0002E128
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0002FF3C File Offset: 0x0002E13C
		public uint tagId
		{
			get;
			internal set;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0002FF50 File Offset: 0x0002E150
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0002FF64 File Offset: 0x0002E164
		public List<SqlItem> items
		{
			get;
			internal set;
		}

		// Token: 0x0400028F RID: 655
		[CompilerGenerated]
		private uint cb7bb4c155c11c6426e959d8f7e55549f;

		// Token: 0x04000290 RID: 656
		[CompilerGenerated]
		private List<SqlItem> c7a6f1b4f2bbc14917328c6cbc9693811;
	}
}
