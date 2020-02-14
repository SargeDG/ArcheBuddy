using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x02000097 RID: 151
	public class SqlZoneClimateElem : MarshalProxy
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x0002E7F4 File Offset: 0x0002C9F4
		internal SqlZoneClimateElem()
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0002E808 File Offset: 0x0002CA08
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0002E81C File Offset: 0x0002CA1C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0002E830 File Offset: 0x0002CA30
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0002E844 File Offset: 0x0002CA44
		public uint zoneClimateId
		{
			get;
			internal set;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0002E858 File Offset: 0x0002CA58
		// (set) Token: 0x060002EF RID: 751 RVA: 0x0002E86C File Offset: 0x0002CA6C
		public uint climateId
		{
			get;
			internal set;
		}

		// Token: 0x04000211 RID: 529
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000212 RID: 530
		[CompilerGenerated]
		private uint c255ec6e20d6904fe47a760b03d227469;

		// Token: 0x04000213 RID: 531
		[CompilerGenerated]
		private uint cf418d570901059896ba420b85f665b8b;
	}
}
