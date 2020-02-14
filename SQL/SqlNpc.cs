using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C4 RID: 196
	public class SqlNpc : MarshalProxy
	{
		// Token: 0x060004F6 RID: 1270 RVA: 0x000313D4 File Offset: 0x0002F5D4
		internal SqlNpc()
		{
			c3afd8c71d7298920076955bd650bbd26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c4b8d94e0e52ccd460c4ea332e2020418.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlUnitModifier>());
			c3df75bc70c5025b621aeb85d31279b9e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlMountSkill>());
			c69cdfee725f5caaf7b3f767a1f87c71d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10180));
			cbf0ade650b527e67b85c8ac3a166b60d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<Point3D>());
			c68e87b7bbe82ec4ac55d7dc5135aabe8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlMerchantPack>());
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00031430 File Offset: 0x0002F630
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00031444 File Offset: 0x0002F644
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00031458 File Offset: 0x0002F658
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x0003146C File Offset: 0x0002F66C
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00031480 File Offset: 0x0002F680
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00031494 File Offset: 0x0002F694
		public int charRaceId
		{
			get;
			internal set;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x000314A8 File Offset: 0x0002F6A8
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x000314BC File Offset: 0x0002F6BC
		public int npcGradeId
		{
			get;
			internal set;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x000314D0 File Offset: 0x0002F6D0
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x000314E4 File Offset: 0x0002F6E4
		public int npcKindId
		{
			get;
			internal set;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x000314F8 File Offset: 0x0002F6F8
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x0003150C File Offset: 0x0002F70C
		public int level
		{
			get;
			internal set;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00031520 File Offset: 0x0002F720
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00031534 File Offset: 0x0002F734
		public int npcTemplateId
		{
			get;
			internal set;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00031548 File Offset: 0x0002F748
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0003155C File Offset: 0x0002F75C
		public int mateKindId
		{
			get;
			internal set;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00031570 File Offset: 0x0002F770
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00031584 File Offset: 0x0002F784
		public int factionId
		{
			get;
			internal set;
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00031598 File Offset: 0x0002F798
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x000315AC File Offset: 0x0002F7AC
		public bool auctioneer
		{
			get;
			internal set;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x000315C0 File Offset: 0x0002F7C0
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x000315D4 File Offset: 0x0002F7D4
		public bool blacksmith
		{
			get;
			internal set;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x000315E8 File Offset: 0x0002F7E8
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x000315FC File Offset: 0x0002F7FC
		public bool priest
		{
			get;
			internal set;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00031610 File Offset: 0x0002F810
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00031624 File Offset: 0x0002F824
		public bool specialty
		{
			get;
			internal set;
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00031638 File Offset: 0x0002F838
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x0003164C File Offset: 0x0002F84C
		public bool trader
		{
			get;
			internal set;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00031660 File Offset: 0x0002F860
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00031674 File Offset: 0x0002F874
		public bool banker
		{
			get;
			internal set;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00031688 File Offset: 0x0002F888
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0003169C File Offset: 0x0002F89C
		public bool stabler
		{
			get;
			internal set;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000316B0 File Offset: 0x0002F8B0
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x000316C4 File Offset: 0x0002F8C4
		public bool aggression
		{
			get;
			internal set;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x000316D8 File Offset: 0x0002F8D8
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x000316EC File Offset: 0x0002F8EC
		public uint specialtyCoinId
		{
			get;
			internal set;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00031700 File Offset: 0x0002F900
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00031714 File Offset: 0x0002F914
		public uint npcInteractionSetId
		{
			get;
			internal set;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00031728 File Offset: 0x0002F928
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0003173C File Offset: 0x0002F93C
		public uint npcNicknameId
		{
			get;
			internal set;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x00031750 File Offset: 0x0002F950
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x00031764 File Offset: 0x0002F964
		public List<SqlUnitModifier> unitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00031778 File Offset: 0x0002F978
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x0003178C File Offset: 0x0002F98C
		public List<SqlMerchantPack> merchantPacks
		{
			get;
			internal set;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x000317A0 File Offset: 0x0002F9A0
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x000317B4 File Offset: 0x0002F9B4
		public List<SqlMountSkill> mountSkills
		{
			get;
			internal set;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x000317C8 File Offset: 0x0002F9C8
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x000317DC File Offset: 0x0002F9DC
		public SqlModel model
		{
			get;
			internal set;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x000317F0 File Offset: 0x0002F9F0
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00031804 File Offset: 0x0002FA04
		public uint specialtyBundleId
		{
			get;
			internal set;
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00031818 File Offset: 0x0002FA18
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x0003182C File Offset: 0x0002FA2C
		public List<Point3D> spawnPoints
		{
			get;
			internal set;
		}

		// Token: 0x04000302 RID: 770
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000303 RID: 771
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000304 RID: 772
		[CompilerGenerated]
		private int c74f99fff607e23453b6fbd53025c8a87;

		// Token: 0x04000305 RID: 773
		[CompilerGenerated]
		private int cc76a028a0658ff495dc48470f37905d1;

		// Token: 0x04000306 RID: 774
		[CompilerGenerated]
		private int c42a43d7948644502698da06d7744d824;

		// Token: 0x04000307 RID: 775
		[CompilerGenerated]
		private int cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x04000308 RID: 776
		[CompilerGenerated]
		private int c365cf0d6d4022564cc518f5719cbed20;

		// Token: 0x04000309 RID: 777
		[CompilerGenerated]
		private int cb5db06e7ce4a6ac93f5d64aa21074c03;

		// Token: 0x0400030A RID: 778
		[CompilerGenerated]
		private int cae402fd5e3b416143b2944d730e17f9b;

		// Token: 0x0400030B RID: 779
		[CompilerGenerated]
		private bool c73fa25706386c2b70f0582a5cd80ad92;

		// Token: 0x0400030C RID: 780
		[CompilerGenerated]
		private bool c702d06b382d9641456e37ef6726f3520;

		// Token: 0x0400030D RID: 781
		[CompilerGenerated]
		private bool ceea3306e794ee75fbcce83baff988eb0;

		// Token: 0x0400030E RID: 782
		[CompilerGenerated]
		private bool c1f1ec336c37ad59b835bdb0f63f8d6ca;

		// Token: 0x0400030F RID: 783
		[CompilerGenerated]
		private bool cabebf8b24f10a6d5b3ca6fa90ab39a06;

		// Token: 0x04000310 RID: 784
		[CompilerGenerated]
		private bool c0334264d31fe62bd3abd05d77901cb0f;

		// Token: 0x04000311 RID: 785
		[CompilerGenerated]
		private bool c9faff2e8340c03f61b0f3f4128b4dcb2;

		// Token: 0x04000312 RID: 786
		[CompilerGenerated]
		private bool c867749c21a61fe9060ae286730ab075a;

		// Token: 0x04000313 RID: 787
		[CompilerGenerated]
		private uint c54f88bd0f73475bacb4f44b6107ac880;

		// Token: 0x04000314 RID: 788
		[CompilerGenerated]
		private uint c24dae3ebbe12768bba0ba1a644c73378;

		// Token: 0x04000315 RID: 789
		[CompilerGenerated]
		private uint cc28934869635a5e5267989f8aa3f2e62;

		// Token: 0x04000316 RID: 790
		[CompilerGenerated]
		private List<SqlUnitModifier> c5357f6dc560843abe275cbafaa99a570;

		// Token: 0x04000317 RID: 791
		[CompilerGenerated]
		private List<SqlMerchantPack> c347ed231206bf9382cb100d92ed18993;

		// Token: 0x04000318 RID: 792
		[CompilerGenerated]
		private List<SqlMountSkill> cefb2c089fe7387eab36c31474af8ef24;

		// Token: 0x04000319 RID: 793
		[CompilerGenerated]
		private SqlModel c92bb9434904f199cea93fba97d747cd0;

		// Token: 0x0400031A RID: 794
		[CompilerGenerated]
		private uint c26f1c87fc66eafd6e1474cfd968b629f;

		// Token: 0x0400031B RID: 795
		[CompilerGenerated]
		private List<Point3D> c7ca6b45afd8b8d9a9d80a6576290945a;
	}
}
