using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000BD RID: 189
	public class SqlItemGrade : MarshalProxy
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x00030D6C File Offset: 0x0002EF6C
		internal SqlItemGrade()
		{
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00030D80 File Offset: 0x0002EF80
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00030D94 File Offset: 0x0002EF94
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00030DA8 File Offset: 0x0002EFA8
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00030DBC File Offset: 0x0002EFBC
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00030DD0 File Offset: 0x0002EFD0
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00030DE4 File Offset: 0x0002EFE4
		public int gradeOrder
		{
			get;
			internal set;
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00030DF8 File Offset: 0x0002EFF8
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00030E0C File Offset: 0x0002F00C
		public double varHoldableDps
		{
			get;
			internal set;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00030E20 File Offset: 0x0002F020
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00030E34 File Offset: 0x0002F034
		public double varHoldableArmor
		{
			get;
			internal set;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00030E48 File Offset: 0x0002F048
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00030E5C File Offset: 0x0002F05C
		public double varHoldableMagicDps
		{
			get;
			internal set;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00030E70 File Offset: 0x0002F070
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00030E84 File Offset: 0x0002F084
		public double varWearableArmor
		{
			get;
			internal set;
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00030E98 File Offset: 0x0002F098
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00030EAC File Offset: 0x0002F0AC
		public double varWearableMagicResistance
		{
			get;
			internal set;
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00030EC0 File Offset: 0x0002F0C0
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00030ED4 File Offset: 0x0002F0D4
		public string colorArgb
		{
			get;
			internal set;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00030EE8 File Offset: 0x0002F0E8
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00030EFC File Offset: 0x0002F0FC
		public int statMultiplier
		{
			get;
			internal set;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00030F10 File Offset: 0x0002F110
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00030F24 File Offset: 0x0002F124
		public int refundMultiplier
		{
			get;
			internal set;
		}

		// Token: 0x040002DD RID: 733
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x040002DE RID: 734
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x040002DF RID: 735
		[CompilerGenerated]
		private int c9a046ea750be23663ac186c96375ac6f;

		// Token: 0x040002E0 RID: 736
		[CompilerGenerated]
		private double ca4deabdc4501caae1975aec962f5c601;

		// Token: 0x040002E1 RID: 737
		[CompilerGenerated]
		private double cbd47487575f4f79abd2bdf3b459e6e68;

		// Token: 0x040002E2 RID: 738
		[CompilerGenerated]
		private double cdd7c07543a9f1ec0abcfc0bbdc4b66a9;

		// Token: 0x040002E3 RID: 739
		[CompilerGenerated]
		private double c8ce320daa1f04e4895f118c866160be2;

		// Token: 0x040002E4 RID: 740
		[CompilerGenerated]
		private double cc5f7fea6ea94e9e2c985ad464eb1e5ca;

		// Token: 0x040002E5 RID: 741
		[CompilerGenerated]
		private string cc973b1d802808c5d86bdc0645f9f9e17;

		// Token: 0x040002E6 RID: 742
		[CompilerGenerated]
		private int c3acf9ad3d73143cb2d9ad78879dfd6ed;

		// Token: 0x040002E7 RID: 743
		[CompilerGenerated]
		private int cc7ce05ff7e8ea8e007baf4bf64517ef2;
	}
}
