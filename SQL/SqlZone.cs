using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000CB RID: 203
	public class SqlZone : MarshalProxy
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x00032310 File Offset: 0x00030510
		internal SqlZone()
		{
			c7b4bac04cb0fff6a24c18cb8f525c482.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c94301750fdaeb9df84a4c407d1f3297f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0003233C File Offset: 0x0003053C
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x00032350 File Offset: 0x00030550
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00032364 File Offset: 0x00030564
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x00032378 File Offset: 0x00030578
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0003238C File Offset: 0x0003058C
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x000323A0 File Offset: 0x000305A0
		public string displayText
		{
			get;
			internal set;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000323B4 File Offset: 0x000305B4
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x000323C8 File Offset: 0x000305C8
		public bool closed
		{
			get;
			internal set;
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x000323DC File Offset: 0x000305DC
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x000323F0 File Offset: 0x000305F0
		public SqlZoneGroup zoneGroup
		{
			get;
			internal set;
		}

		// Token: 0x0400035A RID: 858
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400035B RID: 859
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x0400035C RID: 860
		[CompilerGenerated]
		private string c151cbb3ed29bf330d4147e58a2986fe7;

		// Token: 0x0400035D RID: 861
		[CompilerGenerated]
		private bool c3b22a38b621e3fd68fc0d9997f263c70;

		// Token: 0x0400035E RID: 862
		[CompilerGenerated]
		private SqlZoneGroup cc3487c8849bc559436aec3339568dd9f;
	}
}
