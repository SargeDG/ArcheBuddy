using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000BC RID: 188
	public class SqlItem : MarshalProxy
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x000306BC File Offset: 0x0002E8BC
		internal SqlItem()
		{
			cf7bbf13613c6dc60218865329edd9975.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			cb539af252e517b000f0b468b37a4817c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10156));
			ccde32370b82edb913ce9583cd4f9849a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10160));
			c46852496e812bd18f3d456011ebbec43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10164));
			ccc9fec53da7bea1c62b7a3f4a79dd9ef.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10168));
			c9a250471e503e373fa69bed8b96f8182.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10172));
			ce5f923fed6dd92ea822ee042f7da4661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10176));
			cb735243e5cd4a655bad96c07e2686931.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SqlItemCategorie());
			c8ed8b6f71f7ba2186df2e0c90da6eafa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SqlHoldable());
			cc47389c3cc59c21597837e68378c98ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SqlSkill());
			c18cedd6eb9cc7dc248909c5b5d3660aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new SqlHousing());
			cce07df0796e9137ee5e872b6478c158e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlUnitModifier>());
			cafece4675ea2279acb61e62bde9038c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSpecialtyBundle>());
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0003077C File Offset: 0x0002E97C
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00030790 File Offset: 0x0002E990
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x000307A4 File Offset: 0x0002E9A4
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x000307B8 File Offset: 0x0002E9B8
		public int itemLevel
		{
			get;
			internal set;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000307CC File Offset: 0x0002E9CC
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x000307E0 File Offset: 0x0002E9E0
		public uint useSkillId
		{
			get;
			internal set;
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x000307F4 File Offset: 0x0002E9F4
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00030808 File Offset: 0x0002EA08
		public int requirementLevel
		{
			get;
			internal set;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0003081C File Offset: 0x0002EA1C
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00030830 File Offset: 0x0002EA30
		public uint categoryId
		{
			get;
			internal set;
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00030844 File Offset: 0x0002EA44
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00030858 File Offset: 0x0002EA58
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0003086C File Offset: 0x0002EA6C
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00030880 File Offset: 0x0002EA80
		public uint doodadAlmightyId
		{
			get;
			internal set;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00030894 File Offset: 0x0002EA94
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x000308A8 File Offset: 0x0002EAA8
		public int implId
		{
			get;
			internal set;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000308BC File Offset: 0x0002EABC
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000308D0 File Offset: 0x0002EAD0
		public uint armorSlotTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000308E4 File Offset: 0x0002EAE4
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x000308F8 File Offset: 0x0002EAF8
		public uint armorTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0003090C File Offset: 0x0002EB0C
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00030920 File Offset: 0x0002EB20
		public uint weaponTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00030934 File Offset: 0x0002EB34
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00030948 File Offset: 0x0002EB48
		public uint accessoryTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0003095C File Offset: 0x0002EB5C
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00030970 File Offset: 0x0002EB70
		public uint accessorySlotTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00030984 File Offset: 0x0002EB84
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00030998 File Offset: 0x0002EB98
		public uint armorModSetId
		{
			get;
			internal set;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000309AC File Offset: 0x0002EBAC
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000309C0 File Offset: 0x0002EBC0
		public uint weaponModSetId
		{
			get;
			internal set;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000309D4 File Offset: 0x0002EBD4
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000309E8 File Offset: 0x0002EBE8
		public uint accessoryModSetId
		{
			get;
			internal set;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000309FC File Offset: 0x0002EBFC
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00030A10 File Offset: 0x0002EC10
		public bool disenchantable
		{
			get;
			internal set;
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00030A24 File Offset: 0x0002EC24
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00030A38 File Offset: 0x0002EC38
		public byte fixedGrade
		{
			get;
			internal set;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00030A4C File Offset: 0x0002EC4C
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00030A60 File Offset: 0x0002EC60
		public int livingPointPrice
		{
			get;
			internal set;
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00030A74 File Offset: 0x0002EC74
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00030A88 File Offset: 0x0002EC88
		public int honorPrice
		{
			get;
			internal set;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00030A9C File Offset: 0x0002EC9C
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		public int price
		{
			get;
			internal set;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00030AC4 File Offset: 0x0002ECC4
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00030AD8 File Offset: 0x0002ECD8
		public int refund
		{
			get;
			internal set;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00030AEC File Offset: 0x0002ECEC
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00030B00 File Offset: 0x0002ED00
		public byte bindId
		{
			get;
			internal set;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00030B14 File Offset: 0x0002ED14
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00030B28 File Offset: 0x0002ED28
		public int maxStackSize
		{
			get;
			internal set;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00030B3C File Offset: 0x0002ED3C
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00030B50 File Offset: 0x0002ED50
		public bool sellable
		{
			get;
			internal set;
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00030B64 File Offset: 0x0002ED64
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00030B78 File Offset: 0x0002ED78
		public bool gradable
		{
			get;
			internal set;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00030B8C File Offset: 0x0002ED8C
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		public byte backpackTypeId
		{
			get;
			internal set;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00030BB4 File Offset: 0x0002EDB4
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00030BC8 File Offset: 0x0002EDC8
		public bool isFishBackpack
		{
			get;
			internal set;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00030BDC File Offset: 0x0002EDDC
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00030BF0 File Offset: 0x0002EDF0
		public uint specialtyZoneId
		{
			get;
			internal set;
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00030C04 File Offset: 0x0002EE04
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00030C18 File Offset: 0x0002EE18
		public bool repairable
		{
			get;
			internal set;
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00030C2C File Offset: 0x0002EE2C
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00030C40 File Offset: 0x0002EE40
		public int expAbsLifetime
		{
			get;
			internal set;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00030C54 File Offset: 0x0002EE54
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00030C68 File Offset: 0x0002EE68
		public List<SqlUnitModifier> unitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00030C7C File Offset: 0x0002EE7C
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00030C90 File Offset: 0x0002EE90
		public SqlItemCategorie itemCategorie
		{
			get;
			internal set;
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00030CA4 File Offset: 0x0002EEA4
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00030CB8 File Offset: 0x0002EEB8
		public SqlHoldable itemHoldable
		{
			get;
			internal set;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00030CCC File Offset: 0x0002EECC
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00030CE0 File Offset: 0x0002EEE0
		public SqlSkill useSkill
		{
			get;
			internal set;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00030CF4 File Offset: 0x0002EEF4
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00030D08 File Offset: 0x0002EF08
		public SqlEquipItemSet equipItemSet
		{
			get;
			internal set;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00030D1C File Offset: 0x0002EF1C
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00030D30 File Offset: 0x0002EF30
		public SqlHousing housingDb
		{
			get;
			internal set;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00030D44 File Offset: 0x0002EF44
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00030D58 File Offset: 0x0002EF58
		public List<SqlSpecialtyBundle> specialtyBundles
		{
			get;
			internal set;
		}

		// Token: 0x040002B7 RID: 695
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040002B8 RID: 696
		[CompilerGenerated]
		private int c7065f8eb2142d5c238661b0da06133ab;

		// Token: 0x040002B9 RID: 697
		[CompilerGenerated]
		private uint ce1ebde9dbd5b61885a85fead07ba1938;

		// Token: 0x040002BA RID: 698
		[CompilerGenerated]
		private int c994e29eaefe1dc590254c6b15e45962a;

		// Token: 0x040002BB RID: 699
		[CompilerGenerated]
		private uint c3aa55c4c3c25be631442b35a66e6472b;

		// Token: 0x040002BC RID: 700
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x040002BD RID: 701
		[CompilerGenerated]
		private uint c4cc4ded3078e5487057c96fdfe4fd555;

		// Token: 0x040002BE RID: 702
		[CompilerGenerated]
		private int c08936473cb33f8391ae86417d4c88321;

		// Token: 0x040002BF RID: 703
		[CompilerGenerated]
		private uint c4664dfe2a4133511e21b0b0e0d8b79cf;

		// Token: 0x040002C0 RID: 704
		[CompilerGenerated]
		private uint cc7ea134b5944ca305c92dd13df20c96c;

		// Token: 0x040002C1 RID: 705
		[CompilerGenerated]
		private uint c4ac15b2b5cda4eb9affa9ed4a0cc4a4d;

		// Token: 0x040002C2 RID: 706
		[CompilerGenerated]
		private uint ca23af53ecd10b299bc3d4c7c495a5108;

		// Token: 0x040002C3 RID: 707
		[CompilerGenerated]
		private uint c24999e3b349ba77f4dd7f17c51cf54e8;

		// Token: 0x040002C4 RID: 708
		[CompilerGenerated]
		private uint cde48ae8d517be5b80c578bcdbeca501d;

		// Token: 0x040002C5 RID: 709
		[CompilerGenerated]
		private uint c76c6f60d6faa323fd7024573a04ceada;

		// Token: 0x040002C6 RID: 710
		[CompilerGenerated]
		private uint c8103138e3cf11cde0eae30c96f7f0653;

		// Token: 0x040002C7 RID: 711
		[CompilerGenerated]
		private bool c8607ca65d32a31d1b8c3b8f003a798b9;

		// Token: 0x040002C8 RID: 712
		[CompilerGenerated]
		private byte c916724aa5655ea3bc054d8081b272194;

		// Token: 0x040002C9 RID: 713
		[CompilerGenerated]
		private int c3d6da489b36921e32c0baed7b8fd2ece;

		// Token: 0x040002CA RID: 714
		[CompilerGenerated]
		private int cb64e0b1c99cf3b0a1290be617da34ae6;

		// Token: 0x040002CB RID: 715
		[CompilerGenerated]
		private int cd2fee4930cdda67a8b09bd9a4a3a0be4;

		// Token: 0x040002CC RID: 716
		[CompilerGenerated]
		private int c7394fabbf92f35e5b3a9160ca04b7eb6;

		// Token: 0x040002CD RID: 717
		[CompilerGenerated]
		private byte c9cfd61994e3f5f7671b3d0c248198879;

		// Token: 0x040002CE RID: 718
		[CompilerGenerated]
		private int cb23de80bee02c952288afd5b45fb182b;

		// Token: 0x040002CF RID: 719
		[CompilerGenerated]
		private bool c39ea31ab35b15d79c51f794e47788d13;

		// Token: 0x040002D0 RID: 720
		[CompilerGenerated]
		private bool c6d981b0e81e4c9ac478df6279073b446;

		// Token: 0x040002D1 RID: 721
		[CompilerGenerated]
		private byte c794a0e8ffb7e6701eeede0043b1b3573;

		// Token: 0x040002D2 RID: 722
		[CompilerGenerated]
		private bool c8c8d151d667b7a112150f35a51265ce4;

		// Token: 0x040002D3 RID: 723
		[CompilerGenerated]
		private uint c8cc8a18fd021adc98b391cc1b6bcabe8;

		// Token: 0x040002D4 RID: 724
		[CompilerGenerated]
		private bool cef4045e9970722468067a5643ba4dd24;

		// Token: 0x040002D5 RID: 725
		[CompilerGenerated]
		private int c22159a9919db85feacd2fc46e8b68410;

		// Token: 0x040002D6 RID: 726
		[CompilerGenerated]
		private List<SqlUnitModifier> c5357f6dc560843abe275cbafaa99a570;

		// Token: 0x040002D7 RID: 727
		[CompilerGenerated]
		private SqlItemCategorie cd23aea295aba3d1d6e1ccb1c6c03024c;

		// Token: 0x040002D8 RID: 728
		[CompilerGenerated]
		private SqlHoldable cb6c7bd651bf835c8ffdb8c021e51d6a1;

		// Token: 0x040002D9 RID: 729
		[CompilerGenerated]
		private SqlSkill c89c7a467ccb50546f0a3d0c9cb8fefe5;

		// Token: 0x040002DA RID: 730
		[CompilerGenerated]
		private SqlEquipItemSet c71f82b81d5b961d2a8308d80b43c2202;

		// Token: 0x040002DB RID: 731
		[CompilerGenerated]
		private SqlHousing ca5a0f9807ef72d6297de7c5ab7084bec;

		// Token: 0x040002DC RID: 732
		[CompilerGenerated]
		private List<SqlSpecialtyBundle> c05150173bbbe729a4669924b940af3c6;
	}
}
