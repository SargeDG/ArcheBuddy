using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000D2 RID: 210
	public class SqlDoodadFuncGroup : MarshalProxy
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x0003290C File Offset: 0x00030B0C
		internal SqlDoodadFuncGroup()
		{
			c8cf0dd2a0607e6beec9ab2ed277167c3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c9949fc8c6f216e0c1e99f3a92b31c567.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ceae0bf15a98a7dd0ade446b6a664a8f9.c8a754f5f2ca4adde825691a9c31a0e83);
			c5e510b6e67e2fc69aee9761dde685e3c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10196) != 0);
			c1d8cb473dc0e3a74cc5a81b99f22259e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkill>());
			c131fa0e2f829bab8e429c51a20a81a19.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SqlDoodadAlmighty());
			c4f33b3520c72c542f4598577311749a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkill>());
			cea7e0462adcf02c9d83a5320a2095c3f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlDoodadFuncRemoveItem>());
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00032974 File Offset: 0x00030B74
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00032988 File Offset: 0x00030B88
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0003299C File Offset: 0x00030B9C
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x000329B0 File Offset: 0x00030BB0
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000329C4 File Offset: 0x00030BC4
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x000329D8 File Offset: 0x00030BD8
		public bool isMailBox
		{
			get;
			internal set;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000329EC File Offset: 0x00030BEC
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00032A00 File Offset: 0x00030C00
		public SqlDoodadAlmighty doodadAlmighty
		{
			get;
			internal set;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00032A14 File Offset: 0x00030C14
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00032A28 File Offset: 0x00030C28
		public SqlCraftPack craftPack
		{
			get;
			internal set;
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00032A3C File Offset: 0x00030C3C
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00032A50 File Offset: 0x00030C50
		public SqlDoodadFuncPurchase funcPurchase
		{
			get;
			internal set;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00032A64 File Offset: 0x00030C64
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00032A78 File Offset: 0x00030C78
		public List<SqlSkill> useSkills
		{
			get;
			internal set;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00032A8C File Offset: 0x00030C8C
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00032AA0 File Offset: 0x00030CA0
		public List<SqlSkill> useAttachSkills
		{
			get;
			internal set;
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00032AB4 File Offset: 0x00030CB4
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00032AC8 File Offset: 0x00030CC8
		public List<SqlDoodadFuncRemoveItem> useRemoveItemSkills
		{
			get;
			internal set;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00032ADC File Offset: 0x00030CDC
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00032AF0 File Offset: 0x00030CF0
		public SqlDoodadFuncOpenPaper doodadFuncOpenPaper
		{
			get;
			internal set;
		}

		// Token: 0x0400037B RID: 891
		public uint fishBuySkillId;

		// Token: 0x0400037C RID: 892
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400037D RID: 893
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x0400037E RID: 894
		[CompilerGenerated]
		private bool c710f1d7abe35c2afd452f6e229cf5f24;

		// Token: 0x0400037F RID: 895
		[CompilerGenerated]
		private SqlDoodadAlmighty c2d197e24ae7ab4ee03a10e277cfe4d9d;

		// Token: 0x04000380 RID: 896
		[CompilerGenerated]
		private SqlCraftPack c9a0b12ac5ecf49800b102693463f46ab;

		// Token: 0x04000381 RID: 897
		[CompilerGenerated]
		private SqlDoodadFuncPurchase c4fbf916c7b81c019e79d7e21d81b219e;

		// Token: 0x04000382 RID: 898
		[CompilerGenerated]
		private List<SqlSkill> c7a8b069ccac3a215a72ab56bda163fc8;

		// Token: 0x04000383 RID: 899
		[CompilerGenerated]
		private List<SqlSkill> ce81131ef80b976430a50ab33de8b16d6;

		// Token: 0x04000384 RID: 900
		[CompilerGenerated]
		private List<SqlDoodadFuncRemoveItem> cf67c955c0ccebefe057fafd75e176210;

		// Token: 0x04000385 RID: 901
		[CompilerGenerated]
		private SqlDoodadFuncOpenPaper c746da84049332d36017ce393fe0c3c2f;
	}
}
