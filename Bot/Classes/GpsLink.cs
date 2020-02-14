using System;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000554 RID: 1364
	public class GpsLink : MarshalProxy
	{
		// Token: 0x06001E51 RID: 7761 RVA: 0x00133688 File Offset: 0x00131888
		internal GpsLink(GpsPoint gpsPoint, GpsPoint gpsPoint2)
		{
			cf01553d955654bdd86953ee97129b264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, gpsPoint);
			ce59df0886011685714b816f159cd8d3c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, gpsPoint2);
			c2d5d2fdf59b2b93ee49ff747dbe4b8ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca56628ddda016a93ae638833c1e554c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			c89c50887790026e7d2d36659aaa6a4b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (GpsLinkType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92968));
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x001336D8 File Offset: 0x001318D8
		internal GpsLink(GpsPoint gpsPoint, GpsPoint gpsPoint2, byte b)
		{
			cf01553d955654bdd86953ee97129b264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, gpsPoint);
			ce59df0886011685714b816f159cd8d3c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, gpsPoint2);
			c2d5d2fdf59b2b93ee49ff747dbe4b8ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca56628ddda016a93ae638833c1e554c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			c89c50887790026e7d2d36659aaa6a4b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (GpsLinkType)b);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00133720 File Offset: 0x00131920
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
					if (!true)
					{
						RuntimeMethodHandle arg_1D_0 = methodof(GpsLink.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						if (c2960a7a79b0fdbcc08a7e032cdb02037.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							cf01553d955654bdd86953ee97129b264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83);
						}
						if (ca56628ddda016a93ae638833c1e554c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							ce59df0886011685714b816f159cd8d3c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83);
						}
					}
					ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x001337DC File Offset: 0x001319DC
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x001337F0 File Offset: 0x001319F0
		public GpsLinkType linkType
		{
			get;
			set;
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00133804 File Offset: 0x00131A04
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00133818 File Offset: 0x00131A18
		public GpsPoint firstPoint
		{
			get;
			set;
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0013382C File Offset: 0x00131A2C
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00133840 File Offset: 0x00131A40
		public GpsPoint secondPoint
		{
			get;
			set;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00133854 File Offset: 0x00131A54
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00133868 File Offset: 0x00131A68
		public double weight
		{
			get;
			set;
		}

		// Token: 0x04001365 RID: 4965
		[CompilerGenerated]
		private GpsLinkType c6ec21b58eb5970ba8dc80534b40dfe1a;

		// Token: 0x04001366 RID: 4966
		[CompilerGenerated]
		private GpsPoint cb788a164297cd22f7c3047441f7f9ce2;

		// Token: 0x04001367 RID: 4967
		[CompilerGenerated]
		private GpsPoint c5c9449b05c96f13b97babbde2ab148bb;

		// Token: 0x04001368 RID: 4968
		[CompilerGenerated]
		private double ca2014cf6b612db2d955f0c1ebd680463;
	}
}
