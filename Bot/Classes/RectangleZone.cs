using System;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000559 RID: 1369
	public class RectangleZone : Zone
	{
		// Token: 0x06001E8D RID: 7821 RVA: 0x00134234 File Offset: 0x00132434
		public RectangleZone(double x1, double y1, double x2, double y2)
		{
			c309d7a54c77465b0e5c98e1ef1839d9a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93156));
			c37483a5610d8c31161389071fa992c7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ZoneType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93160));
			if (x1 <= x2)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3C_0 = methodof(RectangleZone..ctor(double, double, double, double)).MethodHandle;
				}
				c910014814915c6683c652c8fc0351405.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x1);
				cdf65824361583640f5ce4e824b4c323b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x2);
			}
			else
			{
				c910014814915c6683c652c8fc0351405.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x2);
				cdf65824361583640f5ce4e824b4c323b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x1);
			}
			if (y1 <= y2)
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
				c7e5f29f155449faf52040991b5b53b60.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, y1);
				c2c092e0c6317d20e8c60faf467751988.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, y2);
			}
			else
			{
				c7e5f29f155449faf52040991b5b53b60.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, y2);
				c2c092e0c6317d20e8c60faf467751988.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, y1);
			}
			c05c339cb2239486d2eda79aa9f6baae7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(x2 - x1));
			c47d14e142ada21a6e5584c33e2ae81ce.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(y2 - y1));
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x001342EC File Offset: 0x001324EC
		public override bool PointInZone(double x, double y)
		{
			if (x >= cfd82aa6ac7928ed1202cda838807357c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_1D_0 = methodof(RectangleZone.PointInZone(double, double)).MethodHandle;
				}
				if (x <= c59c0c3249a911fe1ba9a8f437ef51eda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
				{
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					if (y >= cf5a6fba2195f9d53ff19bb4221fcc5b2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
						if (y <= ca3d7778cb6752fab32b2615a1cd4fd8c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								break;
							}
							return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93136) != 0;
						}
					}
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93140) != 0;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0013436C File Offset: 0x0013256C
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
					RuntimeMethodHandle arg_15_0 = methodof(RectangleZone.ObjInZone(SpawnObject)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93144) != 0;
			}
			if (c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(obj) >= cfd82aa6ac7928ed1202cda838807357c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
				if (c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(obj) <= c59c0c3249a911fe1ba9a8f437ef51eda.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(obj) >= cf5a6fba2195f9d53ff19bb4221fcc5b2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
					{
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						if (cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(obj) <= ca3d7778cb6752fab32b2615a1cd4fd8c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93148) != 0;
						}
					}
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93152) != 0;
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00134420 File Offset: 0x00132620
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x00134434 File Offset: 0x00132634
		public double X1
		{
			get;
			internal set;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00134448 File Offset: 0x00132648
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0013445C File Offset: 0x0013265C
		public double X2
		{
			get;
			internal set;
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x00134470 File Offset: 0x00132670
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00134484 File Offset: 0x00132684
		public double Y1
		{
			get;
			internal set;
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00134498 File Offset: 0x00132698
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x001344AC File Offset: 0x001326AC
		public double Y2
		{
			get;
			internal set;
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x001344C0 File Offset: 0x001326C0
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x001344D4 File Offset: 0x001326D4
		public double width
		{
			get;
			internal set;
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x001344E8 File Offset: 0x001326E8
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x001344FC File Offset: 0x001326FC
		public double height
		{
			get;
			internal set;
		}

		// Token: 0x04001378 RID: 4984
		[CompilerGenerated]
		private double c5287ed82dcc4a384658662a821e9f4cd;

		// Token: 0x04001379 RID: 4985
		[CompilerGenerated]
		private double c08f752a2a136e783ea8a608e143400cd;

		// Token: 0x0400137A RID: 4986
		[CompilerGenerated]
		private double c6e1daa5a591fc2d39bdf15de2be571e4;

		// Token: 0x0400137B RID: 4987
		[CompilerGenerated]
		private double c843e5f27c4ad363bf8750ec827921302;

		// Token: 0x0400137C RID: 4988
		[CompilerGenerated]
		private double c3487e71162b5e03f72675b6d6c311437;

		// Token: 0x0400137D RID: 4989
		[CompilerGenerated]
		private double cdf1b09c2be7182825834fb94b404d3ad;
	}
}
