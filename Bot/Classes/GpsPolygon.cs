using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000013 RID: 19
	public class GpsPolygon : MarshalProxy
	{
		// Token: 0x06000067 RID: 103 RVA: 0x0001006C File Offset: 0x0000E26C
		internal GpsPolygon()
		{
			c4d42a8b73bae35b135832f08cfcec166.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			cbff0580bab13700eebbacb7cb4d64fc2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<GpsPoint>());
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00010098 File Offset: 0x0000E298
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(GpsPolygon.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						c3ac5ee8476f1433f374864c9f480b89a.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					}
					ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00010104 File Offset: 0x0000E304
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00010118 File Offset: 0x0000E318
		public List<GpsPoint> points
		{
			get;
			internal set;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0001012C File Offset: 0x0000E32C
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00010140 File Offset: 0x0000E340
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00010154 File Offset: 0x0000E354
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00010168 File Offset: 0x0000E368
		public int type
		{
			get;
			internal set;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0001017C File Offset: 0x0000E37C
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00010190 File Offset: 0x0000E390
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000101A4 File Offset: 0x0000E3A4
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public int zOrder
		{
			get;
			internal set;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000101CC File Offset: 0x0000E3CC
		public bool PointInZone(double x, double y)
		{
			return this.c20a70c852d1dd6adc25b4d8fe38e70dc(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2008), x, y, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2012), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2020), ""));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0001021C File Offset: 0x0000E41C
		private bool c20a70c852d1dd6adc25b4d8fe38e70dc(List<GpsPoint> list, GpsPoint gpsPoint)
		{
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2028) != 0;
			int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2032);
			int num = c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2036);
			while (i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list))
			{
				if (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i)) > cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) != cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, num)) > cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint))
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
						RuntimeMethodHandle arg_7A_0 = methodof(GpsPolygon.c20a70c852d1dd6adc25b4d8fe38e70dc(List<GpsPoint>, GpsPoint)).MethodHandle;
					}
					if (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) < (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, num)) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i))) * (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i))) / (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, num)) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i))) + c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
						flag = ((flag ? 1 : 0) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2040));
					}
				}
				int expr_10C = i;
				i = expr_10C + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2044);
				num = expr_10C;
			}
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			return flag;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0001035C File Offset: 0x0000E55C
		private bool c6067f704044676ee8ae0d38ba4d488eb(GpsPoint gpsPoint)
		{
			GpsPoint gpsPoint2 = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2048), c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) + c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), this.c6c1ca5d7e01bc5b65a20c3946a2fe7f6(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))), cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2052), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2060), "");
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2068);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2072); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2104))
			{
				int num2 = i;
				int num3 = i + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2076);
				if (i == c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2080))
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
						RuntimeMethodHandle arg_C3_0 = methodof(GpsPolygon.c6067f704044676ee8ae0d38ba4d488eb(GpsPoint)).MethodHandle;
					}
					num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2084);
				}
				int num4 = this.cbe9d53729108e9c07867042f66ef2a58(gpsPoint, gpsPoint2, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
				if (num4 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2088))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2092) != 0;
				}
				if (num4 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2096))
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
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33416), i));
					num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2100) - num;
				}
			}
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			if (num == 0)
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
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2108) != 0;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2112) != 0;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0001051C File Offset: 0x0000E71C
		private int c6c1ca5d7e01bc5b65a20c3946a2fe7f6(List<GpsPoint> list)
		{
			GpsPoint gpsPoint = cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2116));
			int result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2120);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2124); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2128))
			{
				if (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i)) > c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint))
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
					if (!true)
					{
						RuntimeMethodHandle arg_57_0 = methodof(GpsPolygon.c6c1ca5d7e01bc5b65a20c3946a2fe7f6(List<GpsPoint>)).MethodHandle;
					}
					gpsPoint = cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i);
					result = i;
				}
			}
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			return result;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000105B0 File Offset: 0x0000E7B0
		private int cbe9d53729108e9c07867042f66ef2a58(GpsPoint gpsPoint, GpsPoint gpsPoint2, GpsPoint gpsPoint3, GpsPoint gpsPoint4)
		{
			double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2132);
			double num2 = (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2)) * (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint4) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3)) - (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2)) * (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint4) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3));
			double num3 = (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3)) * (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint4) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3)) - (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3)) * (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint4) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3));
			double num4 = (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2)) * (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3)) - (cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2)) * (c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3));
			if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2) < num)
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
				if (!true)
				{
					RuntimeMethodHandle arg_106_0 = methodof(GpsPolygon.cbe9d53729108e9c07867042f66ef2a58(GpsPoint, GpsPoint, GpsPoint, GpsPoint)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2140);
			}
			double num5 = num3 / num2;
			double num6 = num4 / num2;
			if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num5) < num)
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
				if (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2144) <= num6)
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
					if (num6 <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2152))
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
						return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2160);
					}
				}
			}
			if (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2164) <= num5)
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
				if (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2172) <= num6)
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
					if (num6 <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2180))
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
						return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2188);
					}
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2192);
		}

		// Token: 0x0400002F RID: 47
		[CompilerGenerated]
		private List<GpsPoint> c7f041dfd1071d836ea7721e1669ed231;

		// Token: 0x04000030 RID: 48
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000031 RID: 49
		[CompilerGenerated]
		private int c0425b2249a00a072c3294192bc80f538;

		// Token: 0x04000032 RID: 50
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000033 RID: 51
		[CompilerGenerated]
		private int c77314d0ba71b665827ebbdc4badfb179;
	}
}
