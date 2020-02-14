using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000558 RID: 1368
	public class PolygonZone : Zone
	{
		// Token: 0x06001E84 RID: 7812 RVA: 0x00133D88 File Offset: 0x00131F88
		public PolygonZone(List<ZonePoint> points)
		{
			c309d7a54c77465b0e5c98e1ef1839d9a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93128));
			c37483a5610d8c31161389071fa992c7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ZoneType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93132));
			c11518bcfda82f4cbb3587aef48953cad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, points);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00133DC4 File Offset: 0x00131FC4
		public override bool PointInZone(double x, double y)
		{
			return this.c6067f704044676ee8ae0d38ba4d488eb(cd9aaa5b8e0a6a60835e14bee50ae4cdd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(x, y));
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00133DE4 File Offset: 0x00131FE4
		public override bool ObjInZone(SpawnObject obj)
		{
			if (obj == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(PolygonZone.ObjInZone(SpawnObject)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93024) != 0;
			}
			return this.c6067f704044676ee8ae0d38ba4d488eb(cd9aaa5b8e0a6a60835e14bee50ae4cdd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(obj), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(obj)));
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x00133E34 File Offset: 0x00132034
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x00133E48 File Offset: 0x00132048
		public List<ZonePoint> points
		{
			get;
			internal set;
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00133E5C File Offset: 0x0013205C
		private int c6c1ca5d7e01bc5b65a20c3946a2fe7f6(List<ZonePoint> list)
		{
			ZonePoint zonePoint = cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93028));
			int result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93032);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93036); i < c765c7c8d225d7a9b1c13d980263852d0.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93040))
			{
				if (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, i)) > c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint))
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
						RuntimeMethodHandle arg_57_0 = methodof(PolygonZone.c6c1ca5d7e01bc5b65a20c3946a2fe7f6(List<ZonePoint>)).MethodHandle;
					}
					zonePoint = cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, i);
					result = i;
				}
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
			return result;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00133EF0 File Offset: 0x001320F0
		private int cbe9d53729108e9c07867042f66ef2a58(ZonePoint zonePoint, ZonePoint zonePoint2, ZonePoint zonePoint3, ZonePoint zonePoint4)
		{
			double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93044);
			double num2 = (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint2)) * (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint4) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint3)) - (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint2)) * (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint4) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint3));
			double num3 = (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint3)) * (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint4) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint3)) - (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint3)) * (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint4) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint3));
			double num4 = (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint2)) * (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint3)) - (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint2)) * (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint3));
			if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2) < num)
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
					RuntimeMethodHandle arg_106_0 = methodof(PolygonZone.cbe9d53729108e9c07867042f66ef2a58(ZonePoint, ZonePoint, ZonePoint, ZonePoint)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93052);
			}
			double num5 = num3 / num2;
			double num6 = num4 / num2;
			if (c325e71c0324cd2fc7e4ace4c554061e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num5) < num)
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
				if (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93056) <= num6)
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
					if (num6 <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93064))
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
						return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93072);
					}
				}
			}
			if (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93076) <= num5)
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
				if (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93084) <= num6)
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
					if (num6 <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93092))
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
						return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93100);
					}
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93104);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x001340D4 File Offset: 0x001322D4
		private bool c20a70c852d1dd6adc25b4d8fe38e70dc(List<ZonePoint> list, ZonePoint zonePoint)
		{
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93108) != 0;
			int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93112);
			int num = c765c7c8d225d7a9b1c13d980263852d0.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93116);
			while (i < c765c7c8d225d7a9b1c13d980263852d0.c30767ddca1f9c207888833aea5b5fc61(list))
			{
				if (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, i)) > c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint) != c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, num)) > c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint))
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
					if (!true)
					{
						RuntimeMethodHandle arg_7A_0 = methodof(PolygonZone.c20a70c852d1dd6adc25b4d8fe38e70dc(List<ZonePoint>, ZonePoint)).MethodHandle;
					}
					if (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(zonePoint) < (c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, num)) - c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, i))) * (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(zonePoint) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, i))) / (c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, num)) - c4eb04a6efac7f393048b914cc139abdf.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, i))) + c64f5ad476bfeb3db9c55ef1832ef01b7.c30767ddca1f9c207888833aea5b5fc61(cd97590cda008122b9b709fe057520e50.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
						flag = ((flag ? 1 : 0) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93120));
					}
				}
				int expr_10C = i;
				i = expr_10C + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93124);
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

		// Token: 0x06001E8C RID: 7820 RVA: 0x00134214 File Offset: 0x00132414
		private bool c6067f704044676ee8ae0d38ba4d488eb(ZonePoint zonePoint)
		{
			return this.c20a70c852d1dd6adc25b4d8fe38e70dc(c7d6f329efc9dccf270acba99f1f91dea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), zonePoint);
		}

		// Token: 0x04001377 RID: 4983
		[CompilerGenerated]
		private List<ZonePoint> c7f041dfd1071d836ea7721e1669ed231;
	}
}
