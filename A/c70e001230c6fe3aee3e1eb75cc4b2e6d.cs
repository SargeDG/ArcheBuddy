using System;
using System.Collections.Generic;
using System.Drawing;
using FastColoredTextBoxNS;

namespace A
{
	// Token: 0x0200012D RID: 301
	internal sealed class c70e001230c6fe3aee3e1eb75cc4b2e6d : Style
	{
		// Token: 0x06000AD4 RID: 2772 RVA: 0x0006BA00 File Offset: 0x00069C00
		public c70e001230c6fe3aee3e1eb75cc4b2e6d(Pen pen)
		{
			this.c0a7d32ed5b5f41f7c05ea4ad528481ba = pen;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0006BA1C File Offset: 0x00069C1C
		public override void Draw(Graphics gr, Point position, Range range)
		{
			try
			{
				FastColoredTextBox tb = range.tb;
				Brush brush = c97029713e71fa272f7b9333658c1803b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3d8030281ae75f98f8d6b1e4456f5ad0.c30767ddca1f9c207888833aea5b5fc61(this.c0a7d32ed5b5f41f7c05ea4ad528481ba));
				try
				{
					IEnumerator<Place> enumerator = c8bb8c08bce46868d7bfc3746d8416d5e.c30767ddca1f9c207888833aea5b5fc61(range);
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							Place place = cde2a68dccddb00b237644a15df6c3265.c30767ddca1f9c207888833aea5b5fc61(enumerator);
							char c = c7f1be0d1a8311338905a0276f329ddd7.c30767ddca1f9c207888833aea5b5fc61(tb, place).c;
							if ((int)c == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23932))
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
									RuntimeMethodHandle arg_68_0 = methodof(c70e001230c6fe3aee3e1eb75cc4b2e6d.Draw(Graphics, Point, Range)).MethodHandle;
								}
								Point point = cc129d01e1d88e0a4a43c3313647106a5.c30767ddca1f9c207888833aea5b5fc61(tb, place);
								c1d9b5b8f3cd34c57b629677eff227ce3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point, ca4d953679f84fe3ad7a3310b6dd96d14.c30767ddca1f9c207888833aea5b5fc61(tb) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23936), ca8c03d564793a19357a52eede98013e8.c30767ddca1f9c207888833aea5b5fc61(tb) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23940));
								c16ba3b2db1c61b11e1a66a7be3e7e54a.c30767ddca1f9c207888833aea5b5fc61(gr, this.c0a7d32ed5b5f41f7c05ea4ad528481ba, cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point), cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point), cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23944), cd2736605f031bad0fcc6593b621e8a9f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point));
							}
							if (c8897deeef7a9192f80c5412625876648.c30767ddca1f9c207888833aea5b5fc61(caff872bc05b15dee677152558d8d2053.c30767ddca1f9c207888833aea5b5fc61(tb, place.iLine)) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23948) == place.iChar)
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
								Point point2 = cc129d01e1d88e0a4a43c3313647106a5.c30767ddca1f9c207888833aea5b5fc61(tb, place);
								c1d9b5b8f3cd34c57b629677eff227ce3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point2, ca4d953679f84fe3ad7a3310b6dd96d14.c30767ddca1f9c207888833aea5b5fc61(tb), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23952));
								cbc0dae595877f31b464441b941d8259a.c30767ddca1f9c207888833aea5b5fc61(gr, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(165938), cf3e76658314ffe6840f1326b31b84d62.c30767ddca1f9c207888833aea5b5fc61(tb), brush, c1bb7fd1a2f0ead78bce2a879da0517e0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(point2));
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
					}
					finally
					{
						if (enumerator != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
						}
					}
				}
				finally
				{
					if (brush != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(brush);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000667 RID: 1639
		private Pen c0a7d32ed5b5f41f7c05ea4ad528481ba;
	}
}
