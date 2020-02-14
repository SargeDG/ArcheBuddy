using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000BE RID: 190
	public class SqlWearableSlot : MarshalProxy
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x00030F38 File Offset: 0x0002F138
		internal SqlWearableSlot()
		{
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00030F4C File Offset: 0x0002F14C
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x00030F60 File Offset: 0x0002F160
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00030F74 File Offset: 0x0002F174
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x00030F88 File Offset: 0x0002F188
		public int slotTypeId
		{
			get;
			internal set;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00030F9C File Offset: 0x0002F19C
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00030FB0 File Offset: 0x0002F1B0
		public int value
		{
			get;
			internal set;
		}

		// Token: 0x040002E8 RID: 744
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040002E9 RID: 745
		[CompilerGenerated]
		private int c23f4e9f7f8080368afea3a11738a4849;

		// Token: 0x040002EA RID: 746
		[CompilerGenerated]
		private int c0b972c0a6fd42f9045235c08ef4ba754;
	}
}
