using System;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200055A RID: 1370
	public class RoundZone : Zone
	{
		// Token: 0x06001E9C RID: 7836 RVA: 0x00134510 File Offset: 0x00132710
		public RoundZone(double x, double y, double radius)
		{
			c309d7a54c77465b0e5c98e1ef1839d9a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93232));
			c37483a5610d8c31161389071fa992c7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ZoneType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93236));
			c67107c5f4117775e2a2e5e6519f0b510.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x);
			caeb37f9abfa2e2d6808f92c05978bc3f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, y);
			c65e2b2ca408714ba2726d5a549df0ca8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, radius);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00134558 File Offset: 0x00132758
		public override bool PointInZone(double x, double y)
		{
			if (c68797f8377ad21802dc165c1cbf88a2f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93164), cdfe9014d02101a49c91049e7d709b638.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c29c8debd962a299895a14d05212c03f9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - x, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93172)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c09edc5ede83b0fc15cf66db72384a13a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - y, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93180)))) <= c5b18997be8a691ec7d0a2c1029c42302.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_71_0 = methodof(RoundZone.PointInZone(double, double)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93188) != 0;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93192) != 0;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x001345EC File Offset: 0x001327EC
		public override bool ObjInZone(SpawnObject obj)
		{
			if (obj == null)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_15_0 = methodof(RoundZone.ObjInZone(SpawnObject)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93196) != 0;
			}
			if (c68797f8377ad21802dc165c1cbf88a2f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93200), cdfe9014d02101a49c91049e7d709b638.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c29c8debd962a299895a14d05212c03f9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(obj), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93208)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c09edc5ede83b0fc15cf66db72384a13a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(obj), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93216)))) <= c5b18997be8a691ec7d0a2c1029c42302.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93224) != 0;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93228) != 0;
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x001346A8 File Offset: 0x001328A8
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x001346BC File Offset: 0x001328BC
		public double X
		{
			get;
			internal set;
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x001346D0 File Offset: 0x001328D0
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x001346E4 File Offset: 0x001328E4
		public double Y
		{
			get;
			internal set;
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x001346F8 File Offset: 0x001328F8
		// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x0013470C File Offset: 0x0013290C
		public double radius
		{
			get;
			internal set;
		}

		// Token: 0x0400137E RID: 4990
		[CompilerGenerated]
		private double c4e1d1d0caa6a804f4989545e0d5f9f5f;

		// Token: 0x0400137F RID: 4991
		[CompilerGenerated]
		private double ca9ac1684d7c60158fa9bdbd1d337b57b;

		// Token: 0x04001380 RID: 4992
		[CompilerGenerated]
		private double c8331fdc3a0edec5f6e011f6065da11ac;
	}
}
