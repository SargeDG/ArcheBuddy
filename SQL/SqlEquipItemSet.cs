using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x02000098 RID: 152
	public class SqlEquipItemSet : MarshalProxy
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x0002E880 File Offset: 0x0002CA80
		internal SqlEquipItemSet()
		{
			ce827115bd4683b8eaa407761f11eb6e2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlItem>());
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x0002E8A0 File Offset: 0x0002CAA0
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x0002E8B4 File Offset: 0x0002CAB4
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0002E8C8 File Offset: 0x0002CAC8
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x0002E8DC File Offset: 0x0002CADC
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0002E8F0 File Offset: 0x0002CAF0
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0002E904 File Offset: 0x0002CB04
		public List<SqlItem> itemsInSet
		{
			get;
			internal set;
		}

		// Token: 0x04000214 RID: 532
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000215 RID: 533
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000216 RID: 534
		[CompilerGenerated]
		private List<SqlItem> cb0a6c041a9d9f38c3b45c80890672087;
	}
}
