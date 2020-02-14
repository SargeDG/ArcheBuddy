using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E1 RID: 225
	public class SqlQuestComponent : MarshalProxy
	{
		// Token: 0x06000667 RID: 1639 RVA: 0x0003324C File Offset: 0x0003144C
		internal SqlQuestComponent()
		{
			c2b87bb8ba3d5baee104a3ca810aa4fa1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			cce875052afcb9728d983850df47bb7ed.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10200) != 0);
			c592c41e7534bc24b385c45df1ee3aad3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActConAcceptNpc>());
			c0c7ec3fcf009524b9e9df01134da88a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActConAcceptDoodad>());
			c5141dfcb183a06608b855aefc9425598.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActConReportNpc>());
			c49a4948f8315c4a9981052f6cdbcc6db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActConReportDoodad>());
			caa7208b994ac295e10d735409c4779a3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActObjInteraction>());
			c0edb7ba573a7cdeddb259400df6b6fd4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActObjTalk>());
			ca84a2cfa1e68037718590bae8933e44d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActSupplySelectiveItem>());
			c297c60df13c8deb6c175f21cea10b6f6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActObjMonsterGroupHunt>());
			ce783af41ea4961702442e9490a406ce7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActObjMonsterHunt>());
			cb82ef577689e2980182b27ddc53871cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActObjItemGroupGather>());
			c0805ca116594ba89ca9fea877baee1ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlQuestActObjItemGather>());
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x000332F4 File Offset: 0x000314F4
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00033308 File Offset: 0x00031508
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0003331C File Offset: 0x0003151C
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00033330 File Offset: 0x00031530
		public byte kindId
		{
			get;
			internal set;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00033344 File Offset: 0x00031544
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00033358 File Offset: 0x00031558
		public uint nextComponent
		{
			get;
			internal set;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0003336C File Offset: 0x0003156C
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00033380 File Offset: 0x00031580
		public int npcAiId
		{
			get;
			internal set;
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00033394 File Offset: 0x00031594
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000333A8 File Offset: 0x000315A8
		public uint npcId
		{
			get;
			internal set;
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x000333BC File Offset: 0x000315BC
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x000333D0 File Offset: 0x000315D0
		public uint skillId
		{
			get;
			internal set;
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000333E4 File Offset: 0x000315E4
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x000333F8 File Offset: 0x000315F8
		public string desc
		{
			get;
			internal set;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x0003340C File Offset: 0x0003160C
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00033420 File Offset: 0x00031620
		public List<SqlQuestActConAcceptNpc> actsConAcceptNpc
		{
			get;
			internal set;
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00033434 File Offset: 0x00031634
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00033448 File Offset: 0x00031648
		public List<SqlQuestActConAcceptDoodad> actsConAcceptDoodads
		{
			get;
			internal set;
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0003345C File Offset: 0x0003165C
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00033470 File Offset: 0x00031670
		public List<SqlQuestActConReportNpc> actsConReportNpc
		{
			get;
			internal set;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00033484 File Offset: 0x00031684
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00033498 File Offset: 0x00031698
		public List<SqlQuestActConReportDoodad> actsConReportDoodads
		{
			get;
			internal set;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000334AC File Offset: 0x000316AC
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x000334C0 File Offset: 0x000316C0
		public bool isHiddenAutoComplete
		{
			get;
			internal set;
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x000334D4 File Offset: 0x000316D4
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x000334E8 File Offset: 0x000316E8
		public List<SqlQuestActObjInteraction> actsObjInteractions
		{
			get;
			internal set;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000334FC File Offset: 0x000316FC
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00033510 File Offset: 0x00031710
		public List<SqlQuestActObjTalk> actsObjTalk
		{
			get;
			internal set;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00033524 File Offset: 0x00031724
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00033538 File Offset: 0x00031738
		public List<SqlQuestActSupplySelectiveItem> actsSupplySelectiveItem
		{
			get;
			internal set;
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0003354C File Offset: 0x0003174C
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00033560 File Offset: 0x00031760
		public List<SqlQuestActObjMonsterGroupHunt> actsObjMonsterGroupHunt
		{
			get;
			internal set;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00033574 File Offset: 0x00031774
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00033588 File Offset: 0x00031788
		public List<SqlQuestActObjMonsterHunt> actsObjMonsterHunt
		{
			get;
			internal set;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0003359C File Offset: 0x0003179C
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x000335B0 File Offset: 0x000317B0
		public List<SqlQuestActObjItemGroupGather> actsObjItemGroupGather
		{
			get;
			internal set;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x000335C4 File Offset: 0x000317C4
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x000335D8 File Offset: 0x000317D8
		public List<SqlQuestActObjItemGather> actsObjItemGather
		{
			get;
			internal set;
		}

		// Token: 0x040003AD RID: 941
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040003AE RID: 942
		[CompilerGenerated]
		private byte c75371bad8576903afd612bf8194e92c8;

		// Token: 0x040003AF RID: 943
		[CompilerGenerated]
		private uint ccb489ef2d939c8016e7b873493c2c16b;

		// Token: 0x040003B0 RID: 944
		[CompilerGenerated]
		private int ce299e84b91ad471f3b56914d96b660f4;

		// Token: 0x040003B1 RID: 945
		[CompilerGenerated]
		private uint c553d7b181381fb7529fb9f426e0c2007;

		// Token: 0x040003B2 RID: 946
		[CompilerGenerated]
		private uint c3f815d54f78fd887f01f754f70c3882f;

		// Token: 0x040003B3 RID: 947
		[CompilerGenerated]
		private string c8abc8a6f62831832fb7aa32e4ed7440b;

		// Token: 0x040003B4 RID: 948
		[CompilerGenerated]
		private List<SqlQuestActConAcceptNpc> c209361f1d6b1a71b367780a27ef85987;

		// Token: 0x040003B5 RID: 949
		[CompilerGenerated]
		private List<SqlQuestActConAcceptDoodad> c7e44c591170a078fb0d68560371cd614;

		// Token: 0x040003B6 RID: 950
		[CompilerGenerated]
		private List<SqlQuestActConReportNpc> cdc3be9da00727b7bad16ea74e321dd38;

		// Token: 0x040003B7 RID: 951
		[CompilerGenerated]
		private List<SqlQuestActConReportDoodad> c50a5c745ca9ca8a1f155d42aad5d3f0d;

		// Token: 0x040003B8 RID: 952
		[CompilerGenerated]
		private bool c1e3990c06915756f7ec63826ec90eb0a;

		// Token: 0x040003B9 RID: 953
		[CompilerGenerated]
		private List<SqlQuestActObjInteraction> cb2201efb0632ad8bc6c7d76337c17ad0;

		// Token: 0x040003BA RID: 954
		[CompilerGenerated]
		private List<SqlQuestActObjTalk> c0e2506a11f7dbbe6470c9a019c909665;

		// Token: 0x040003BB RID: 955
		[CompilerGenerated]
		private List<SqlQuestActSupplySelectiveItem> cb8fe6d46dd905f5a19304a5dea8e99e3;

		// Token: 0x040003BC RID: 956
		[CompilerGenerated]
		private List<SqlQuestActObjMonsterGroupHunt> cb727957c5cd45f5a7c80c7049fab02c4;

		// Token: 0x040003BD RID: 957
		[CompilerGenerated]
		private List<SqlQuestActObjMonsterHunt> c0ce96a726bc355b562263b70555005b0;

		// Token: 0x040003BE RID: 958
		[CompilerGenerated]
		private List<SqlQuestActObjItemGroupGather> c680684a3d6cf9a34407d4b947ef0a5b9;

		// Token: 0x040003BF RID: 959
		[CompilerGenerated]
		private List<SqlQuestActObjItemGather> c732dd1306f976a839fde368df18a5fdb;
	}
}
