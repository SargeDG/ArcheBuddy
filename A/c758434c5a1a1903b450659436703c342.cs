using System;
using System.Text.RegularExpressions;
using FastColoredTextBoxNS;

namespace A
{
	// Token: 0x02000130 RID: 304
	internal sealed class c758434c5a1a1903b450659436703c342 : AutocompleteItem
	{
		// Token: 0x06000AEC RID: 2796 RVA: 0x0006C240 File Offset: 0x0006A440
		public c758434c5a1a1903b450659436703c342(string text) : base("")
		{
			this.c6598b066316a3b8a7e4b7e7c77cd7d78 = text;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0006C260 File Offset: 0x0006A460
		public c758434c5a1a1903b450659436703c342() : this(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(165941))
		{
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0006C280 File Offset: 0x0006A480
		public override CompareResult Compare(string fragmentText)
		{
			if (c319d7f1441ea34401488fc55137b495a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(fragmentText, this.c6598b066316a3b8a7e4b7e7c77cd7d78))
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
					RuntimeMethodHandle arg_22_0 = methodof(c758434c5a1a1903b450659436703c342.Compare(string)).MethodHandle;
				}
				this.Text = this.cebe0aff1b03d86958b9012bb61f8ab1b(fragmentText);
				if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.Text, fragmentText))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24048);
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24052);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0006C2F0 File Offset: 0x0006A4F0
		private string cebe0aff1b03d86958b9012bb61f8ab1b(string text)
		{
			Match match = c0552b94b3c23c344c8898288f7eec80b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, this.c6598b066316a3b8a7e4b7e7c77cd7d78);
			if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfda553cff481e97d036fc4c1225ba738.c30767ddca1f9c207888833aea5b5fc61(c950558e928238065d27f1c27426da555.c30767ddca1f9c207888833aea5b5fc61(c14ca9ffb9192bbbcebb62cc8aa0631f5.c30767ddca1f9c207888833aea5b5fc61(match), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24056))), ""))
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
					RuntimeMethodHandle arg_4F_0 = methodof(c758434c5a1a1903b450659436703c342.cebe0aff1b03d86958b9012bb61f8ab1b(string)).MethodHandle;
				}
				if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfda553cff481e97d036fc4c1225ba738.c30767ddca1f9c207888833aea5b5fc61(c950558e928238065d27f1c27426da555.c30767ddca1f9c207888833aea5b5fc61(c14ca9ffb9192bbbcebb62cc8aa0631f5.c30767ddca1f9c207888833aea5b5fc61(match), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24060))), ""))
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
					return text;
				}
			}
			string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24064));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24068)] = cfda553cff481e97d036fc4c1225ba738.c30767ddca1f9c207888833aea5b5fc61(c950558e928238065d27f1c27426da555.c30767ddca1f9c207888833aea5b5fc61(c14ca9ffb9192bbbcebb62cc8aa0631f5.c30767ddca1f9c207888833aea5b5fc61(match), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24072)));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24076)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792);
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24080)] = cfda553cff481e97d036fc4c1225ba738.c30767ddca1f9c207888833aea5b5fc61(c950558e928238065d27f1c27426da555.c30767ddca1f9c207888833aea5b5fc61(c14ca9ffb9192bbbcebb62cc8aa0631f5.c30767ddca1f9c207888833aea5b5fc61(match), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24084)));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24088)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792);
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24092)] = cfda553cff481e97d036fc4c1225ba738.c30767ddca1f9c207888833aea5b5fc61(c950558e928238065d27f1c27426da555.c30767ddca1f9c207888833aea5b5fc61(c14ca9ffb9192bbbcebb62cc8aa0631f5.c30767ddca1f9c207888833aea5b5fc61(match), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24096)));
			return c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array));
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0006C45C File Offset: 0x0006A65C
		public override string get_ToolTipTitle()
		{
			return this.Text;
		}

		// Token: 0x0400066F RID: 1647
		private string c6598b066316a3b8a7e4b7e7c77cd7d78;
	}
}
