using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A5 RID: 165
	public class SqlBuff : MarshalProxy
	{
		// Token: 0x0600034D RID: 845 RVA: 0x0002F048 File Offset: 0x0002D248
		internal SqlBuff()
		{
			cae199b5cdb97bf076b89ed4f4fe83cc3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			ca2c98b72354a2f3346c13b2582b7ca8b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			cbe84327ee6d3b559ff6e3f2009bf18f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlUnitModifier>());
			c4e8bde31e688cccfa8fa505bf2a4495c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkillModifier>());
			ce5498ddfa8be687a755d1dfe802f015d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlDynamicUnitModifier>());
			c1935916609e5393c6749c9331e848667.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkill>());
			c5d3f1dc4d746dc0350f884a916c1df5c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlMountSkill>());
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0002F0A8 File Offset: 0x0002D2A8
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0002F0BC File Offset: 0x0002D2BC
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0002F0E4 File Offset: 0x0002D2E4
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0002F10C File Offset: 0x0002D30C
		public string desc
		{
			get;
			internal set;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0002F120 File Offset: 0x0002D320
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0002F134 File Offset: 0x0002D334
		public int iconId
		{
			get;
			internal set;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0002F148 File Offset: 0x0002D348
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0002F15C File Offset: 0x0002D35C
		public long duration
		{
			get;
			internal set;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0002F170 File Offset: 0x0002D370
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0002F184 File Offset: 0x0002D384
		public int tick
		{
			get;
			internal set;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0002F198 File Offset: 0x0002D398
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0002F1AC File Offset: 0x0002D3AC
		public bool silense
		{
			get;
			internal set;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0002F1D4 File Offset: 0x0002D3D4
		public bool root
		{
			get;
			internal set;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0002F1E8 File Offset: 0x0002D3E8
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0002F1FC File Offset: 0x0002D3FC
		public bool sleep
		{
			get;
			internal set;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0002F210 File Offset: 0x0002D410
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0002F224 File Offset: 0x0002D424
		public bool stun
		{
			get;
			internal set;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0002F238 File Offset: 0x0002D438
		// (set) Token: 0x06000363 RID: 867 RVA: 0x0002F24C File Offset: 0x0002D44C
		public bool crippled
		{
			get;
			internal set;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0002F260 File Offset: 0x0002D460
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0002F274 File Offset: 0x0002D474
		public bool stealth
		{
			get;
			internal set;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0002F288 File Offset: 0x0002D488
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0002F29C File Offset: 0x0002D49C
		public bool gliding
		{
			get;
			internal set;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0002F2B0 File Offset: 0x0002D4B0
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0002F2C4 File Offset: 0x0002D4C4
		public bool meleeImmune
		{
			get;
			internal set;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0002F2D8 File Offset: 0x0002D4D8
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0002F2EC File Offset: 0x0002D4EC
		public bool spellImmune
		{
			get;
			internal set;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0002F300 File Offset: 0x0002D500
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0002F314 File Offset: 0x0002D514
		public bool rangedImmune
		{
			get;
			internal set;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0002F328 File Offset: 0x0002D528
		// (set) Token: 0x0600036F RID: 879 RVA: 0x0002F33C File Offset: 0x0002D53C
		public bool siegeImmune
		{
			get;
			internal set;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0002F350 File Offset: 0x0002D550
		// (set) Token: 0x06000371 RID: 881 RVA: 0x0002F364 File Offset: 0x0002D564
		public bool knockDown
		{
			get;
			internal set;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0002F378 File Offset: 0x0002D578
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0002F38C File Offset: 0x0002D58C
		public int kindId
		{
			get;
			internal set;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0002F3B4 File Offset: 0x0002D5B4
		public int maxStack
		{
			get;
			internal set;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0002F3C8 File Offset: 0x0002D5C8
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0002F3DC File Offset: 0x0002D5DC
		public int maxCharge
		{
			get;
			internal set;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0002F3F0 File Offset: 0x0002D5F0
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0002F404 File Offset: 0x0002D604
		public int stackRuleId
		{
			get;
			internal set;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0002F418 File Offset: 0x0002D618
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0002F42C File Offset: 0x0002D62C
		public List<SqlUnitModifier> unitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0002F440 File Offset: 0x0002D640
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0002F454 File Offset: 0x0002D654
		public List<SqlSkillModifier> skillModifiers
		{
			get;
			internal set;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0002F468 File Offset: 0x0002D668
		// (set) Token: 0x0600037F RID: 895 RVA: 0x0002F47C File Offset: 0x0002D67C
		public List<SqlDynamicUnitModifier> dynamicUnitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0002F490 File Offset: 0x0002D690
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0002F4A4 File Offset: 0x0002D6A4
		public List<SqlSkill> buffSkills
		{
			get;
			internal set;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0002F4B8 File Offset: 0x0002D6B8
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0002F4CC File Offset: 0x0002D6CC
		public List<SqlMountSkill> buffMountSkills
		{
			get;
			internal set;
		}

		// Token: 0x0400023C RID: 572
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400023D RID: 573
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x0400023E RID: 574
		[CompilerGenerated]
		private string c8abc8a6f62831832fb7aa32e4ed7440b;

		// Token: 0x0400023F RID: 575
		[CompilerGenerated]
		private int cca507434a2b526904b63acabbe7bb9f5;

		// Token: 0x04000240 RID: 576
		[CompilerGenerated]
		private long cc74dd5859f10a629b2a1cbac6c1e2f7f;

		// Token: 0x04000241 RID: 577
		[CompilerGenerated]
		private int c1875097b28d9faaf26275ddd3eb682e2;

		// Token: 0x04000242 RID: 578
		[CompilerGenerated]
		private bool c84b35828c74980d5291e57d18b64cd95;

		// Token: 0x04000243 RID: 579
		[CompilerGenerated]
		private bool c4f04cfc730d2de5bd37f6c60763f9617;

		// Token: 0x04000244 RID: 580
		[CompilerGenerated]
		private bool cad21a3cb967c5a76d9c7a6ca27852204;

		// Token: 0x04000245 RID: 581
		[CompilerGenerated]
		private bool c45a68275d001c7e958516864605855b7;

		// Token: 0x04000246 RID: 582
		[CompilerGenerated]
		private bool c68fdbfd2ab22ae4e8595d9c0c6289180;

		// Token: 0x04000247 RID: 583
		[CompilerGenerated]
		private bool c23e9f5a6333f0c22391115280abff1cf;

		// Token: 0x04000248 RID: 584
		[CompilerGenerated]
		private bool c19cc25b2138a3ae103bf64273506cb67;

		// Token: 0x04000249 RID: 585
		[CompilerGenerated]
		private bool c56c0d921c254bc16961919ffccb8465d;

		// Token: 0x0400024A RID: 586
		[CompilerGenerated]
		private bool cb72d5d8bada30892c899f3d48478e80c;

		// Token: 0x0400024B RID: 587
		[CompilerGenerated]
		private bool c967e55344cee86f50a5a6e22421cbe0e;

		// Token: 0x0400024C RID: 588
		[CompilerGenerated]
		private bool cdc0021156ac2045900403fb1201f3f52;

		// Token: 0x0400024D RID: 589
		[CompilerGenerated]
		private bool cf2cdcfb76dd004f408f7f5b5ce7fce2b;

		// Token: 0x0400024E RID: 590
		[CompilerGenerated]
		private int c75371bad8576903afd612bf8194e92c8;

		// Token: 0x0400024F RID: 591
		[CompilerGenerated]
		private int cadf3231bb76989fb67f5eed789c6a1a3;

		// Token: 0x04000250 RID: 592
		[CompilerGenerated]
		private int c20e476c6b9f991d41fdbf1e56b15710d;

		// Token: 0x04000251 RID: 593
		[CompilerGenerated]
		private int c425486d09f105f4f1224df51f1b663ac;

		// Token: 0x04000252 RID: 594
		[CompilerGenerated]
		private List<SqlUnitModifier> c5357f6dc560843abe275cbafaa99a570;

		// Token: 0x04000253 RID: 595
		[CompilerGenerated]
		private List<SqlSkillModifier> c96515826e214ab50c48e01b4163fc59c;

		// Token: 0x04000254 RID: 596
		[CompilerGenerated]
		private List<SqlDynamicUnitModifier> cc64cc0f2f6bd22ef6cdcc9ed02cf99ce;

		// Token: 0x04000255 RID: 597
		[CompilerGenerated]
		private List<SqlSkill> c4d238322719d5ffd3688e6e95dc66af4;

		// Token: 0x04000256 RID: 598
		[CompilerGenerated]
		private List<SqlMountSkill> c3699028e31c669b33bf7d773531c92fb;
	}
}
