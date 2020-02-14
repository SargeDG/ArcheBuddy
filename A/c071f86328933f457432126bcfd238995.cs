using System;
using FastColoredTextBoxNS;

namespace A
{
	// Token: 0x02000131 RID: 305
	internal sealed class c071f86328933f457432126bcfd238995 : AutocompleteItem
	{
		// Token: 0x06000AF1 RID: 2801 RVA: 0x0006C470 File Offset: 0x0006A670
		public c071f86328933f457432126bcfd238995() : base(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(166045))
		{
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0006C49C File Offset: 0x0006A69C
		public override CompareResult Compare(string fragmentText)
		{
			Range range = c3451175279b02822722083ca48ce9cf1.c30767ddca1f9c207888833aea5b5fc61(c49bf35e402c8ee89adedc178765af5e6.c30767ddca1f9c207888833aea5b5fc61(c6a5c7efcd071127d8e41eae27ec768b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			while (c526c7de65cd7a95fed58c95fae54e193.c30767ddca1f9c207888833aea5b5fc61(range).iChar > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24108))
			{
				if ((int)c6a8d672147d46319205e5d514c3d70a4.c30767ddca1f9c207888833aea5b5fc61(range) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24100))
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
						RuntimeMethodHandle arg_3F_0 = methodof(c071f86328933f457432126bcfd238995.Compare(string)).MethodHandle;
					}
					this.cf185ec4818ca115bb2eee1fdca8af384 = c526c7de65cd7a95fed58c95fae54e193.c30767ddca1f9c207888833aea5b5fc61(range);
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24104);
				}
				c164c04971d5be7d1daea94cc74aa8de6.c30767ddca1f9c207888833aea5b5fc61(range);
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24112);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0006C538 File Offset: 0x0006A738
		public override string GetTextForReplace()
		{
			Range range = c49bf35e402c8ee89adedc178765af5e6.c30767ddca1f9c207888833aea5b5fc61(c6a5c7efcd071127d8e41eae27ec768b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			c03abb79fefd7cbe6e88fdf92a51c6e67.c30767ddca1f9c207888833aea5b5fc61(range, this.cf185ec4818ca115bb2eee1fdca8af384);
			cd31835291c0477065879fc0d69479337.c30767ddca1f9c207888833aea5b5fc61(range, ce616c4f4855e5a6a2d90bc9d5969b558.c30767ddca1f9c207888833aea5b5fc61(range));
			return cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc5738ad72def28ae6b9bc70aa133668e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c5f244a5442577bf834db3e8b573ef38b.c30767ddca1f9c207888833aea5b5fc61(range));
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0006C588 File Offset: 0x0006A788
		public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
		{
			c532c6f7661129569cd4420a7fe627ecb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, popupMenu, e);
			if (c6edf9719999bf848365dfe5bb74b0c72.c30767ddca1f9c207888833aea5b5fc61(c49bf35e402c8ee89adedc178765af5e6.c30767ddca1f9c207888833aea5b5fc61(c6a5c7efcd071127d8e41eae27ec768b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)).tb))
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
					RuntimeMethodHandle arg_37_0 = methodof(c071f86328933f457432126bcfd238995.OnSelected(AutocompleteMenu, SelectedEventArgs)).MethodHandle;
				}
				c60ce72923fa00c24a7d4b27351f36193.c30767ddca1f9c207888833aea5b5fc61(c49bf35e402c8ee89adedc178765af5e6.c30767ddca1f9c207888833aea5b5fc61(c6a5c7efcd071127d8e41eae27ec768b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)).tb);
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0006C5E8 File Offset: 0x0006A7E8
		public override string get_ToolTipTitle()
		{
			return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(165990);
		}

		// Token: 0x04000670 RID: 1648
		private Place cf185ec4818ca115bb2eee1fdca8af384 = c6904d9f07bca50cd4acfaa01eeee68cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
	}
}
