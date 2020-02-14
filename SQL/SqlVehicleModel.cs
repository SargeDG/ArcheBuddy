using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A9 RID: 169
	public class SqlVehicleModel : MarshalProxy
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		internal SqlVehicleModel()
		{
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0002F7D4 File Offset: 0x0002D9D4
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0002F7FC File Offset: 0x0002D9FC
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0002F810 File Offset: 0x0002DA10
		public double linearInertia
		{
			get;
			internal set;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0002F824 File Offset: 0x0002DA24
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0002F838 File Offset: 0x0002DA38
		public double linearDeaccelInertia
		{
			get;
			internal set;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0002F84C File Offset: 0x0002DA4C
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0002F860 File Offset: 0x0002DA60
		public double rotationInertia
		{
			get;
			internal set;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0002F874 File Offset: 0x0002DA74
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0002F888 File Offset: 0x0002DA88
		public double rotationDeaccelInertia
		{
			get;
			internal set;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0002F89C File Offset: 0x0002DA9C
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
		public double velocity
		{
			get;
			internal set;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0002F8C4 File Offset: 0x0002DAC4
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0002F8D8 File Offset: 0x0002DAD8
		public double angleVelocity
		{
			get;
			internal set;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0002F8EC File Offset: 0x0002DAEC
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0002F900 File Offset: 0x0002DB00
		public double maxClimbAngle
		{
			get;
			internal set;
		}

		// Token: 0x04000267 RID: 615
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000268 RID: 616
		[CompilerGenerated]
		private double c5ff51c73b70a806fa4870d04511002b4;

		// Token: 0x04000269 RID: 617
		[CompilerGenerated]
		private double c14363efa1a9cde819af45ebbf76b368e;

		// Token: 0x0400026A RID: 618
		[CompilerGenerated]
		private double cc2c9822dda49812a5f901985ba1ee773;

		// Token: 0x0400026B RID: 619
		[CompilerGenerated]
		private double c3bd76f7ea55914e773db3396712440b4;

		// Token: 0x0400026C RID: 620
		[CompilerGenerated]
		private double c293e085dc947fe83b87cfdfc0fe62922;

		// Token: 0x0400026D RID: 621
		[CompilerGenerated]
		private double c6649b278fafabd6245d668b4870749cc;

		// Token: 0x0400026E RID: 622
		[CompilerGenerated]
		private double cae045317c03ec978708d312c6b271c2d;
	}
}
