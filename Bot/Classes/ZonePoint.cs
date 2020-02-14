using System;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000556 RID: 1366
	public class ZonePoint : MarshalProxy
	{
		// Token: 0x06001E72 RID: 7794 RVA: 0x00133B7C File Offset: 0x00131D7C
		public ZonePoint()
		{
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00133B90 File Offset: 0x00131D90
		public ZonePoint(double x, double y)
		{
			c06164568340c42891c0eafe2b787b5f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x);
			c545d7e72e40c97df9255264c941645ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, y);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00133BB4 File Offset: 0x00131DB4
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x00133BC8 File Offset: 0x00131DC8
		public double x
		{
			get;
			set;
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00133BDC File Offset: 0x00131DDC
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00133BF0 File Offset: 0x00131DF0
		public double y
		{
			get;
			set;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00133C04 File Offset: 0x00131E04
		public double LengthSquared()
		{
			return c64f5ad476bfeb3db9c55ef1832ef01b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c64f5ad476bfeb3db9c55ef1832ef01b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) + c4eb04a6efac7f393048b914cc139abdf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4eb04a6efac7f393048b914cc139abdf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00133C34 File Offset: 0x00131E34
		public static ZonePoint operator +(ZonePoint a, ZonePoint b)
		{
			ZonePoint zonePoint = c61aaa216bda660d1edf44f7c79b3a70c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			c06164568340c42891c0eafe2b787b5f4.c30767ddca1f9c207888833aea5b5fc61(zonePoint, c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(a) + c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(b));
			c545d7e72e40c97df9255264c941645ff.c30767ddca1f9c207888833aea5b5fc61(zonePoint, c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(a) + c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(b));
			return zonePoint;
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00133C78 File Offset: 0x00131E78
		public static ZonePoint operator -(ZonePoint a, ZonePoint b)
		{
			ZonePoint zonePoint = c61aaa216bda660d1edf44f7c79b3a70c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			c06164568340c42891c0eafe2b787b5f4.c30767ddca1f9c207888833aea5b5fc61(zonePoint, c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(a) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(b));
			c545d7e72e40c97df9255264c941645ff.c30767ddca1f9c207888833aea5b5fc61(zonePoint, c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(a) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(b));
			return zonePoint;
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00133CBC File Offset: 0x00131EBC
		public static ZonePoint operator *(double s, ZonePoint v)
		{
			ZonePoint zonePoint = c61aaa216bda660d1edf44f7c79b3a70c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			c06164568340c42891c0eafe2b787b5f4.c30767ddca1f9c207888833aea5b5fc61(zonePoint, c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(v) * s);
			c545d7e72e40c97df9255264c941645ff.c30767ddca1f9c207888833aea5b5fc61(zonePoint, c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(v) * s);
			return zonePoint;
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x00133CF4 File Offset: 0x00131EF4
		public double Dot(ZonePoint v)
		{
			return c64f5ad476bfeb3db9c55ef1832ef01b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(v) + c4eb04a6efac7f393048b914cc139abdf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(v);
		}

		// Token: 0x04001373 RID: 4979
		[CompilerGenerated]
		private double ca7fad13c316e809c89069ffdb5ba59d8;

		// Token: 0x04001374 RID: 4980
		[CompilerGenerated]
		private double c9cdc89109d0276c13fa87317f2c2f379;
	}
}
