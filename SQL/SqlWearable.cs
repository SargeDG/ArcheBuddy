using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C1 RID: 193
	public class SqlWearable : MarshalProxy
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x000311F4 File Offset: 0x0002F3F4
		internal SqlWearable()
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00031208 File Offset: 0x0002F408
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x0003121C File Offset: 0x0002F41C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00031230 File Offset: 0x0002F430
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00031244 File Offset: 0x0002F444
		public int armorTypeId
		{
			get;
			internal set;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00031258 File Offset: 0x0002F458
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0003126C File Offset: 0x0002F46C
		public int slotTypeId
		{
			get;
			internal set;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00031280 File Offset: 0x0002F480
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00031294 File Offset: 0x0002F494
		public int armorBp
		{
			get;
			internal set;
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x000312A8 File Offset: 0x0002F4A8
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x000312BC File Offset: 0x0002F4BC
		public int magicResistanceBp
		{
			get;
			internal set;
		}

		// Token: 0x040002F8 RID: 760
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040002F9 RID: 761
		[CompilerGenerated]
		private int cc7ea134b5944ca305c92dd13df20c96c;

		// Token: 0x040002FA RID: 762
		[CompilerGenerated]
		private int c23f4e9f7f8080368afea3a11738a4849;

		// Token: 0x040002FB RID: 763
		[CompilerGenerated]
		private int c4584b064ecb0c82d36f5c109f85f9a84;

		// Token: 0x040002FC RID: 764
		[CompilerGenerated]
		private int c1846d2ab2db6b0eb9430767f93275bad;
	}
}
