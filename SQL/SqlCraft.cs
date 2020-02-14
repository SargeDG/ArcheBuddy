using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000D0 RID: 208
	public class SqlCraft : MarshalProxy
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x00032674 File Offset: 0x00030874
		internal SqlCraft()
		{
			c402345412b6eb76d24294261549c7a60.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			cf8c0fca176034298d43ec23245ea911c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlCraftMaterial>());
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x000326A0 File Offset: 0x000308A0
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x000326B4 File Offset: 0x000308B4
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x000326C8 File Offset: 0x000308C8
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x000326DC File Offset: 0x000308DC
		public string title
		{
			get;
			internal set;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000326F0 File Offset: 0x000308F0
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00032704 File Offset: 0x00030904
		public int castDelay
		{
			get;
			internal set;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00032718 File Offset: 0x00030918
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x0003272C File Offset: 0x0003092C
		public SqlSkill skill
		{
			get;
			internal set;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00032740 File Offset: 0x00030940
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00032754 File Offset: 0x00030954
		public uint reqDoodadId
		{
			get;
			internal set;
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00032768 File Offset: 0x00030968
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x0003277C File Offset: 0x0003097C
		public List<SqlCraftMaterial> materials
		{
			get;
			internal set;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00032790 File Offset: 0x00030990
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x000327A4 File Offset: 0x000309A4
		public SqlActabilityCategorie actabilityCategorie
		{
			get;
			internal set;
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x000327B8 File Offset: 0x000309B8
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000327CC File Offset: 0x000309CC
		public int actabilityLimit
		{
			get;
			internal set;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000327E0 File Offset: 0x000309E0
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x000327F4 File Offset: 0x000309F4
		public int recommendLevel
		{
			get;
			internal set;
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00032808 File Offset: 0x00030A08
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0003281C File Offset: 0x00030A1C
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00032830 File Offset: 0x00030A30
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00032844 File Offset: 0x00030A44
		public int amount
		{
			get;
			internal set;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00032858 File Offset: 0x00030A58
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x0003286C File Offset: 0x00030A6C
		public int rate
		{
			get;
			internal set;
		}

		// Token: 0x0400036C RID: 876
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400036D RID: 877
		[CompilerGenerated]
		private string c49f7729bf7992fd4eb7e41612d3817b5;

		// Token: 0x0400036E RID: 878
		[CompilerGenerated]
		private int c355a3ed1ffa6e0a6a678a0f1b4fd9bc9;

		// Token: 0x0400036F RID: 879
		[CompilerGenerated]
		private SqlSkill c52f70b53561b4aabff3b19e11226701c;

		// Token: 0x04000370 RID: 880
		[CompilerGenerated]
		private uint c02db1129c55ca30e1154df70b48eeeb6;

		// Token: 0x04000371 RID: 881
		[CompilerGenerated]
		private List<SqlCraftMaterial> c59c5ec16a6f5fae4bf66bc06f58b2e07;

		// Token: 0x04000372 RID: 882
		[CompilerGenerated]
		private SqlActabilityCategorie c82486fdf90961f16dd15949567be4045;

		// Token: 0x04000373 RID: 883
		[CompilerGenerated]
		private int c0cccb0cc9f98821f501401db26abfd3b;

		// Token: 0x04000374 RID: 884
		[CompilerGenerated]
		private int c8432b899560544c7b0dc255cb590bb01;

		// Token: 0x04000375 RID: 885
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;

		// Token: 0x04000376 RID: 886
		[CompilerGenerated]
		private int c270e8a2d309d2d2091f535f990b7bfc5;

		// Token: 0x04000377 RID: 887
		[CompilerGenerated]
		private int cf229565431d9159ad45a5463baa22e73;
	}
}
