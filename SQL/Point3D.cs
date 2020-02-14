using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C3 RID: 195
	public class Point3D : MarshalProxy
	{
		// Token: 0x060004EF RID: 1263 RVA: 0x00031334 File Offset: 0x0002F534
		internal Point3D(float num, float num2, float num3)
		{
			cc6fe36af784f46b34017a08178212beb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num);
			c6f6c4371c24c3b5e6ad75b556ea58a91.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num2);
			c85f598d2b148e3fe2c9717f01ca59414.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num3);
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x0003135C File Offset: 0x0002F55C
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00031370 File Offset: 0x0002F570
		public float X
		{
			get;
			internal set;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00031384 File Offset: 0x0002F584
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00031398 File Offset: 0x0002F598
		public float Y
		{
			get;
			internal set;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x000313AC File Offset: 0x0002F5AC
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x000313C0 File Offset: 0x0002F5C0
		public float Z
		{
			get;
			internal set;
		}

		// Token: 0x040002FF RID: 767
		[CompilerGenerated]
		private float c4e1d1d0caa6a804f4989545e0d5f9f5f;

		// Token: 0x04000300 RID: 768
		[CompilerGenerated]
		private float ca9ac1684d7c60158fa9bdbd1d337b57b;

		// Token: 0x04000301 RID: 769
		[CompilerGenerated]
		private float c4810739f49f8dec1960e013b60a21005;
	}
}
