using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x02000099 RID: 153
	public class SqlDoodadFuncFakeUse : MarshalProxy
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x0002E918 File Offset: 0x0002CB18
		internal SqlDoodadFuncFakeUse()
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0002E92C File Offset: 0x0002CB2C
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0002E940 File Offset: 0x0002CB40
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0002E954 File Offset: 0x0002CB54
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0002E968 File Offset: 0x0002CB68
		public SqlSkill fakeSkill
		{
			get;
			internal set;
		}

		// Token: 0x04000217 RID: 535
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000218 RID: 536
		[CompilerGenerated]
		private SqlSkill ca6dbe0c2b7cf64dfd5f8490f19821fcd;
	}
}
