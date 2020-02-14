using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004C5 RID: 1221
	public class PortalBook : BaseObject
	{
		// Token: 0x060012C5 RID: 4805 RVA: 0x000AD864 File Offset: 0x000ABA64
		internal PortalBook(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44640));
			c31f145c7b9e2d6000d93f637436d8b7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<District>());
			ce95e922a01e644bc9f9cbe691a80d26b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c8b9ec7c31a176a0384f15dc8d4a2901b.c8a754f5f2ca4adde825691a9c31a0e83);
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000AD8A4 File Offset: 0x000ABAA4
		public List<District> getDistricts()
		{
			List<District> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c526efa2d5d86b5e8296ff926fbaa78ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c526efa2d5d86b5e8296ff926fbaa78ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<District>();
			}
			return result;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x000AD8F4 File Offset: 0x000ABAF4
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x000AD908 File Offset: 0x000ABB08
		internal List<District> _districts
		{
			get;
			set;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000AD91C File Offset: 0x000ABB1C
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x000AD930 File Offset: 0x000ABB30
		public District defaultReturnDistrict
		{
			get;
			internal set;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000AD944 File Offset: 0x000ABB44
		public bool OpenPortal(string districtName)
		{
			if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(districtName))
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
					RuntimeMethodHandle arg_1C_0 = methodof(PortalBook.OpenPortal(string)).MethodHandle;
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44608));
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44612) != 0;
			}
			List<District> list = ce81accde65989e3757285f25c9ee6156.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44616); i < cde0da3cf40e9bbef02b914d1d24bc3a1.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44624))
			{
				if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(districtName, cbf93b7f324a2ca2259e29d39458eba43.c30767ddca1f9c207888833aea5b5fc61(c3048128bcee590059871c0d98739d4e3.c30767ddca1f9c207888833aea5b5fc61(list, i)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44620) != 0) == 0)
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
					return c8c85aade89409a7abc3b9e8a38d46d99.c30767ddca1f9c207888833aea5b5fc61(c3048128bcee590059871c0d98739d4e3.c30767ddca1f9c207888833aea5b5fc61(list, i));
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44628) != 0;
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000ADA10 File Offset: 0x000ABC10
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(PortalBook.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c526efa2d5d86b5e8296ff926fbaa78ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44632); i < cde0da3cf40e9bbef02b914d1d24bc3a1.c30767ddca1f9c207888833aea5b5fc61(c526efa2d5d86b5e8296ff926fbaa78ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44636))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c3048128bcee590059871c0d98739d4e3.c30767ddca1f9c207888833aea5b5fc61(c526efa2d5d86b5e8296ff926fbaa78ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i));
								cd5ae1348f177a5cda1d8827b25a11817.c30767ddca1f9c207888833aea5b5fc61(c526efa2d5d86b5e8296ff926fbaa78ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i, c8b9ec7c31a176a0384f15dc8d4a2901b.c8a754f5f2ca4adde825691a9c31a0e83);
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
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000E08 RID: 3592
		[CompilerGenerated]
		private List<District> c22286cf2c9e78577b65e5209d25e269f;

		// Token: 0x04000E09 RID: 3593
		[CompilerGenerated]
		private District cce62542e658c4f7cc255c6e64568fbfc;
	}
}
