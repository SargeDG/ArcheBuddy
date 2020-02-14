using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C8 RID: 200
	public class SqlSkill : MarshalProxy
	{
		// Token: 0x06000546 RID: 1350 RVA: 0x00031A70 File Offset: 0x0002FC70
		internal SqlSkill()
		{
			c2ae06275d93cef213a10cac2489c3cca.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c91806b29288ac6407d342b7a32cb2d04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			ce0b7f934660d257760fad7e92a3bd6ca.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkillReagent>());
			cf6fd4b2f7d38d09d714cb8afec92b1bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkillEffect>());
			c3e1fe36fc18e04fc6d034f9706f62af3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSpecialEffect>());
			c0994fee12e8e1c3e71931e04a08fad8b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlUnitReq>());
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00031AC8 File Offset: 0x0002FCC8
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00031ADC File Offset: 0x0002FCDC
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00031AF0 File Offset: 0x0002FCF0
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00031B04 File Offset: 0x0002FD04
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00031B18 File Offset: 0x0002FD18
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00031B2C File Offset: 0x0002FD2C
		public string desc
		{
			get;
			internal set;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x00031B40 File Offset: 0x0002FD40
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00031B54 File Offset: 0x0002FD54
		public int cost
		{
			get;
			internal set;
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00031B68 File Offset: 0x0002FD68
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00031B7C File Offset: 0x0002FD7C
		public int iconId
		{
			get;
			internal set;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x00031B90 File Offset: 0x0002FD90
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00031BA4 File Offset: 0x0002FDA4
		public int abilityId
		{
			get;
			internal set;
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00031BB8 File Offset: 0x0002FDB8
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00031BCC File Offset: 0x0002FDCC
		public long cooldownTime
		{
			get;
			internal set;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00031BE0 File Offset: 0x0002FDE0
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00031BF4 File Offset: 0x0002FDF4
		public bool show
		{
			get;
			internal set;
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00031C08 File Offset: 0x0002FE08
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00031C1C File Offset: 0x0002FE1C
		public int castingTime
		{
			get;
			internal set;
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00031C30 File Offset: 0x0002FE30
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00031C44 File Offset: 0x0002FE44
		public bool ignoreGlobalCooldown
		{
			get;
			internal set;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00031C58 File Offset: 0x0002FE58
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00031C6C File Offset: 0x0002FE6C
		public bool defaultGcd
		{
			get;
			internal set;
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00031C80 File Offset: 0x0002FE80
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00031C94 File Offset: 0x0002FE94
		public int customGcd
		{
			get;
			internal set;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00031CA8 File Offset: 0x0002FEA8
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00031CBC File Offset: 0x0002FEBC
		public int consumeLp
		{
			get;
			internal set;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00031CD0 File Offset: 0x0002FED0
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		public int abilityLevel
		{
			get;
			internal set;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00031CF8 File Offset: 0x0002FEF8
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00031D0C File Offset: 0x0002FF0C
		public int minRange
		{
			get;
			internal set;
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00031D20 File Offset: 0x0002FF20
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00031D34 File Offset: 0x0002FF34
		public int maxRange
		{
			get;
			internal set;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00031D48 File Offset: 0x0002FF48
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00031D5C File Offset: 0x0002FF5C
		public int targetAngle
		{
			get;
			internal set;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00031D70 File Offset: 0x0002FF70
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00031D84 File Offset: 0x0002FF84
		public int cooldownTagId
		{
			get;
			internal set;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00031D98 File Offset: 0x0002FF98
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00031DAC File Offset: 0x0002FFAC
		public bool keepManaRegen
		{
			get;
			internal set;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00031DC0 File Offset: 0x0002FFC0
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00031DD4 File Offset: 0x0002FFD4
		public bool sourceStun
		{
			get;
			internal set;
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00031DE8 File Offset: 0x0002FFE8
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00031DFC File Offset: 0x0002FFFC
		public bool targetDead
		{
			get;
			internal set;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00031E10 File Offset: 0x00030010
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00031E24 File Offset: 0x00030024
		public int targetSelectionId
		{
			get;
			internal set;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00031E38 File Offset: 0x00030038
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00031E4C File Offset: 0x0003004C
		public int targetTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00031E60 File Offset: 0x00030060
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00031E74 File Offset: 0x00030074
		public int activeWeaponId
		{
			get;
			internal set;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00031E88 File Offset: 0x00030088
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00031E9C File Offset: 0x0003009C
		public int actabilityGroupId
		{
			get;
			internal set;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00031EB0 File Offset: 0x000300B0
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00031EC4 File Offset: 0x000300C4
		public bool sourceMount
		{
			get;
			internal set;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00031ED8 File Offset: 0x000300D8
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00031EEC File Offset: 0x000300EC
		public bool allowToPrisoner
		{
			get;
			internal set;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00031F00 File Offset: 0x00030100
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00031F14 File Offset: 0x00030114
		public bool sourceDead
		{
			get;
			internal set;
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00031F28 File Offset: 0x00030128
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00031F3C File Offset: 0x0003013C
		public byte damageTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00031F50 File Offset: 0x00030150
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00031F64 File Offset: 0x00030164
		public uint mountSkillId
		{
			get;
			internal set;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00031F78 File Offset: 0x00030178
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00031F8C File Offset: 0x0003018C
		public sbyte linkEquipSlotId
		{
			get;
			internal set;
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00031FA0 File Offset: 0x000301A0
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00031FB4 File Offset: 0x000301B4
		public List<SqlSkillReagent> skillReagents
		{
			get;
			internal set;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00031FC8 File Offset: 0x000301C8
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00031FDC File Offset: 0x000301DC
		public List<SqlSkillEffect> sqlSkillEffects
		{
			get;
			internal set;
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00031FF0 File Offset: 0x000301F0
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00032004 File Offset: 0x00030204
		public List<SqlSpecialEffect> sqlSpecialEffects
		{
			get;
			internal set;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00032018 File Offset: 0x00030218
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0003202C File Offset: 0x0003022C
		public List<SqlUnitReq> sqlUnitReqs
		{
			get;
			internal set;
		}

		// Token: 0x04000328 RID: 808
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000329 RID: 809
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x0400032A RID: 810
		[CompilerGenerated]
		private string c8abc8a6f62831832fb7aa32e4ed7440b;

		// Token: 0x0400032B RID: 811
		[CompilerGenerated]
		private int cff56c17adb126b4b7dc7d048d0d7abe8;

		// Token: 0x0400032C RID: 812
		[CompilerGenerated]
		private int cca507434a2b526904b63acabbe7bb9f5;

		// Token: 0x0400032D RID: 813
		[CompilerGenerated]
		private int c91234f8fabeb8a15f754fc7cbd7f11d9;

		// Token: 0x0400032E RID: 814
		[CompilerGenerated]
		private long cbc0b79b047c8f8b7cf35f0ba6ba70c37;

		// Token: 0x0400032F RID: 815
		[CompilerGenerated]
		private bool c24f9730908f07f328c89f11a3d208fb3;

		// Token: 0x04000330 RID: 816
		[CompilerGenerated]
		private int c0ab625a89cd0c715cbb41d8cb3e9a1ef;

		// Token: 0x04000331 RID: 817
		[CompilerGenerated]
		private bool caf4de6f97bc0a4cf02ce98f06612b5f6;

		// Token: 0x04000332 RID: 818
		[CompilerGenerated]
		private bool c9f300044f41420b0642bcea221e63d15;

		// Token: 0x04000333 RID: 819
		[CompilerGenerated]
		private int cebce3b857a4d5fd718ca3e4a3b6c97f3;

		// Token: 0x04000334 RID: 820
		[CompilerGenerated]
		private int c0c714dfdeafafb2506b73fd90914028c;

		// Token: 0x04000335 RID: 821
		[CompilerGenerated]
		private int ca485e4455b0f955ea271880bd8115216;

		// Token: 0x04000336 RID: 822
		[CompilerGenerated]
		private int c91c24afe78ee4ec25a5c9ef8a99f4235;

		// Token: 0x04000337 RID: 823
		[CompilerGenerated]
		private int c816c6ae99ca96a806a3c1de3daa2f935;

		// Token: 0x04000338 RID: 824
		[CompilerGenerated]
		private int c3fd847b97b05f0e42570bfc63f7648dd;

		// Token: 0x04000339 RID: 825
		[CompilerGenerated]
		private int c63d6aae89e9f5cb93b53ac9274bd6675;

		// Token: 0x0400033A RID: 826
		[CompilerGenerated]
		private bool c300ffd5cb1b05eef7e49703773c95a1b;

		// Token: 0x0400033B RID: 827
		[CompilerGenerated]
		private bool cf377ca4c9ba0c3916dc37491c1b44754;

		// Token: 0x0400033C RID: 828
		[CompilerGenerated]
		private bool cb12f2aad501dc9120097ebbe37a840ea;

		// Token: 0x0400033D RID: 829
		[CompilerGenerated]
		private int c16ed12cbdf5daf5e7074b84fcf36b539;

		// Token: 0x0400033E RID: 830
		[CompilerGenerated]
		private int c9c679e0558cac058fccf09acd8474f5d;

		// Token: 0x0400033F RID: 831
		[CompilerGenerated]
		private int c9e6d1c9dc9232c743e3007215dd10519;

		// Token: 0x04000340 RID: 832
		[CompilerGenerated]
		private int c2ebd2d32fbd4c06ab756a2fd75805b47;

		// Token: 0x04000341 RID: 833
		[CompilerGenerated]
		private bool c6fb639bef83987f648cb0611c83b7309;

		// Token: 0x04000342 RID: 834
		[CompilerGenerated]
		private bool c8076427c03c11af62386b6eafaa39b29;

		// Token: 0x04000343 RID: 835
		[CompilerGenerated]
		private bool c2954f8c25a814d3af485bb1b34e76d38;

		// Token: 0x04000344 RID: 836
		[CompilerGenerated]
		private byte c3c182d346d5a23e5b75f90789d1bc87a;

		// Token: 0x04000345 RID: 837
		[CompilerGenerated]
		private uint c15ea8dab025f9983ca69ca37e8b8c951;

		// Token: 0x04000346 RID: 838
		[CompilerGenerated]
		private sbyte c61400156dfdedcc0d9993efd30cbceea;

		// Token: 0x04000347 RID: 839
		[CompilerGenerated]
		private List<SqlSkillReagent> c4d9c1fcd6498eedd8a418aa01fddabfe;

		// Token: 0x04000348 RID: 840
		[CompilerGenerated]
		private List<SqlSkillEffect> c0f1add5d941084aab0e39d1533f32626;

		// Token: 0x04000349 RID: 841
		[CompilerGenerated]
		private List<SqlSpecialEffect> ca1672b84720e7240997d71583b18e917;

		// Token: 0x0400034A RID: 842
		[CompilerGenerated]
		private List<SqlUnitReq> cd4a43f50708745ad17a94999d835ee4b;
	}
}
