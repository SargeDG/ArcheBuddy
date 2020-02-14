using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x02000552 RID: 1362
	internal sealed class c284733691b3d2cd74400c62784ae6d62 : MarshalProxy
	{
		// Token: 0x06001E44 RID: 7748 RVA: 0x00132D78 File Offset: 0x00130F78
		public c284733691b3d2cd74400c62784ae6d62(List<GpsPoint> source, double num)
		{
			c77d4b31b7c116c90faf6227cdb01affb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, source.ToList<GpsPoint>());
			this.cccb4f64fffffb69979ec7c06ac6903b4 = num;
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x00132DB4 File Offset: 0x00130FB4
		// (set) Token: 0x06001E46 RID: 7750 RVA: 0x00132DC8 File Offset: 0x00130FC8
		public List<GpsPoint> points
		{
			get;
			set;
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x00132DDC File Offset: 0x00130FDC
		// (set) Token: 0x06001E48 RID: 7752 RVA: 0x00132DF0 File Offset: 0x00130FF0
		public GpsPoint startPoint
		{
			get;
			set;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00132E04 File Offset: 0x00131004
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(c284733691b3d2cd74400c62784ae6d62.Dispose(bool)).MethodHandle;
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
						if (c254a4e237e6905bbaf96e2adb7848e30.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c254a4e237e6905bbaf96e2adb7848e30.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							c8f7198d38ea3e143a65ca0d33ce53975.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83);
						}
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92872); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92876))
						{
							if (cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i) != null)
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
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i));
								ccec314a808f32a6281a5dae445d72964.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i, ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83);
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
						c3ac5ee8476f1433f374864c9f480b89a.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					}
					ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00132F1C File Offset: 0x0013111C
		public GpsPoint ceb3897aea985ced8d780ac5d0256285a(string text)
		{
			try
			{
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
				{
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92880); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92884))
					{
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf1a3d916b3076cfc5853a7fc3a0c02da.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i)), text))
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
								RuntimeMethodHandle arg_50_0 = methodof(c284733691b3d2cd74400c62784ae6d62.ceb3897aea985ced8d780ac5d0256285a(string)).MethodHandle;
							}
							return cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i);
						}
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return null;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00132FF8 File Offset: 0x001311F8
		public GpsPoint cc7e6a8da0639bc08863964a84afc1eee(GpsPoint gpsPoint)
		{
			GpsPoint result = ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83;
			try
			{
				double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92888);
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
				{
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92896); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92900))
					{
						double num2 = c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i), gpsPoint);
						if (num2 < num)
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
								RuntimeMethodHandle arg_63_0 = methodof(c284733691b3d2cd74400c62784ae6d62.cc7e6a8da0639bc08863964a84afc1eee(GpsPoint)).MethodHandle;
							}
							if (num2 < this.cccb4f64fffffb69979ec7c06ac6903b4)
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
								num = c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i), gpsPoint);
								result = cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i);
							}
						}
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return result;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00133114 File Offset: 0x00131314
		public void c64f5b80ea817e1e3940b224801a7944b(GpsPoint gpsPoint)
		{
			try
			{
				if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == 0)
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
						RuntimeMethodHandle arg_23_0 = methodof(c284733691b3d2cd74400c62784ae6d62.c64f5b80ea817e1e3940b224801a7944b(GpsPoint)).MethodHandle;
					}
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198858));
				}
				else
				{
					c8f7198d38ea3e143a65ca0d33ce53975.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, gpsPoint);
					this.c000cb67b2399904c8bf1f82f1e304767(gpsPoint);
					List<GpsPoint> list = cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<GpsPoint>();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92904); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92908))
					{
						GpsPoint gpsPoint2 = this.c5375dcc84586b906106581cc782a209b(list);
						if (gpsPoint2 == null)
						{
							return;
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
						this.c000cb67b2399904c8bf1f82f1e304767(gpsPoint2);
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
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x001331F0 File Offset: 0x001313F0
		public void c000cb67b2399904c8bf1f82f1e304767(GpsPoint gpsPoint)
		{
			try
			{
				List<GpsPoint> list = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92912);
				while (i < c2fd38130edb0742b9ffe13363e4fd91a.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint)))
				{
					if (c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i)) != gpsPoint)
					{
						goto IL_8F;
					}
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
						RuntimeMethodHandle arg_42_0 = methodof(c284733691b3d2cd74400c62784ae6d62.c000cb67b2399904c8bf1f82f1e304767(GpsPoint)).MethodHandle;
					}
					if (c4e6dfcc1eee4abf2c21e50a0991cb6ab.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i))))
					{
						goto IL_8F;
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
					c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i)));
					IL_11D:
					i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92916);
					continue;
					IL_8F:
					if (ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i)) != gpsPoint)
					{
						goto IL_11D;
					}
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					if (c0d2ebe7f4c7918e76f0d02967c2c9e49.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i)) != GpsLinkType.DoubleLinked)
					{
						goto IL_11D;
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					if (!c4e6dfcc1eee4abf2c21e50a0991cb6ab.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i))))
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
						c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i)));
						goto IL_11D;
					}
					goto IL_11D;
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
				for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92920); j < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92924))
				{
					double num = c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(gpsPoint) + c3a2551a2e57bda1102073f0ed435c3f1.c30767ddca1f9c207888833aea5b5fc61(this.c345f8ca7891ae8b77187ac88dfc9c0aa(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, j), gpsPoint));
					if (c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, j)) > num)
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
						ca3c745e20b491326fcd00d15903d9ccd.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, j), num);
						c734d926013a240e2d7dbbe12fc19f291.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, j), gpsPoint);
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				c63ab114c39d7254304b05dfa8da2e51b.c30767ddca1f9c207888833aea5b5fc61(gpsPoint, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92928) != 0);
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00133414 File Offset: 0x00131614
		private GpsLink c345f8ca7891ae8b77187ac88dfc9c0aa(GpsPoint gpsPoint, GpsPoint gpsPoint2)
		{
			try
			{
				int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92932);
				while (i < c2fd38130edb0742b9ffe13363e4fd91a.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint)))
				{
					if (c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i)) != gpsPoint2)
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
							RuntimeMethodHandle arg_39_0 = methodof(c284733691b3d2cd74400c62784ae6d62.c345f8ca7891ae8b77187ac88dfc9c0aa(GpsPoint, GpsPoint)).MethodHandle;
						}
						if (ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i)) != gpsPoint2)
						{
							i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92936);
							continue;
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
					}
					return cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(gpsPoint), i);
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return null;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x001334E4 File Offset: 0x001316E4
		private GpsPoint c5375dcc84586b906106581cc782a209b(List<GpsPoint> list)
		{
			GpsPoint gpsPoint = ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83;
			double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92940);
			try
			{
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92948); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92952))
				{
					if (!c4e6dfcc1eee4abf2c21e50a0991cb6ab.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
							RuntimeMethodHandle arg_44_0 = methodof(c284733691b3d2cd74400c62784ae6d62.c5375dcc84586b906106581cc782a209b(List<GpsPoint>)).MethodHandle;
						}
						if (c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i)) < num)
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
							num = c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
							gpsPoint = cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i);
						}
					}
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (gpsPoint != null)
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
					c42c090f6a8405436ece53d0739b5fdd9.c30767ddca1f9c207888833aea5b5fc61(list, gpsPoint);
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return gpsPoint;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x001335CC File Offset: 0x001317CC
		public List<GpsPoint> c016b45b05fad36ad7cdb9f8529693609(GpsPoint gpsPoint, Core core)
		{
			List<GpsPoint> list = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				for (GpsPoint gpsPoint2 = gpsPoint; gpsPoint2 != c254a4e237e6905bbaf96e2adb7848e30.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this); gpsPoint2 = c9d388bab18ad0238b20062c22994bc2c.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2))
				{
					c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, gpsPoint2);
					if (c9d388bab18ad0238b20062c22994bc2c.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2) == null)
					{
						IL_4E:
						c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, gpsPoint2);
						return list;
					}
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
						RuntimeMethodHandle arg_2F_0 = methodof(c284733691b3d2cd74400c62784ae6d62.c016b45b05fad36ad7cdb9f8529693609(GpsPoint, Core)).MethodHandle;
					}
				}
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					goto IL_4E;
				}
			}
			catch (Exception ex)
			{
				c0fc332513b6df6f2dafebf2a49d1ec65.c30767ddca1f9c207888833aea5b5fc61(core, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198935), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92956) != 0);
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				return c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return list;
		}

		// Token: 0x0400135D RID: 4957
		private double cccb4f64fffffb69979ec7c06ac6903b4 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92960);

		// Token: 0x0400135E RID: 4958
		[CompilerGenerated]
		private List<GpsPoint> c7f041dfd1071d836ea7721e1669ed231;

		// Token: 0x0400135F RID: 4959
		[CompilerGenerated]
		private GpsPoint c57ffe146fde674237e1395a2b73c4368;
	}
}
