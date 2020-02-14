using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000555 RID: 1365
	public class GpsPoint : MarshalProxy
	{
		// Token: 0x06001E5C RID: 7772 RVA: 0x0013387C File Offset: 0x00131A7C
		internal GpsPoint(uint num, double num2, double num3, double num4, double num5 = 0.0, string text = "")
		{
			c46c8a6a95eb007a152fdeaac5f28702f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num);
			c5075212735efc6bef42196e9d382ed35.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num2);
			c0d59c676bd4523fb2a4b53aa5e05cab4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num3);
			ca49c44391823f0ab7d484ca5c0b701ce.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num4);
			c32ee88db258bfcead7fb1610aac26198.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num5);
			if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
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
					RuntimeMethodHandle arg_48_0 = methodof(GpsPoint..ctor(uint, double, double, double, double, string)).MethodHandle;
				}
				c294f40a55cc9ec1ac8981dc2f8faf2df.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			}
			else
			{
				c294f40a55cc9ec1ac8981dc2f8faf2df.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, text);
			}
			c63ab114c39d7254304b05dfa8da2e51b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(93012) != 0);
			ca3c745e20b491326fcd00d15903d9ccd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93016));
			ca3cbcff5047b17e948e0409742ccc35e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<GpsLink>());
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00133914 File Offset: 0x00131B14
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x00133928 File Offset: 0x00131B28
		public uint id
		{
			get;
			set;
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x0013393C File Offset: 0x00131B3C
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x00133950 File Offset: 0x00131B50
		public double x
		{
			get;
			set;
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x00133964 File Offset: 0x00131B64
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x00133978 File Offset: 0x00131B78
		public double y
		{
			get;
			set;
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x0013398C File Offset: 0x00131B8C
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x001339A0 File Offset: 0x00131BA0
		public double z
		{
			get;
			set;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x001339B4 File Offset: 0x00131BB4
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x001339C8 File Offset: 0x00131BC8
		public double radius
		{
			get;
			set;
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x001339DC File Offset: 0x00131BDC
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x001339F0 File Offset: 0x00131BF0
		public string name
		{
			get;
			set;
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00133A04 File Offset: 0x00131C04
		// (set) Token: 0x06001E6A RID: 7786 RVA: 0x00133A18 File Offset: 0x00131C18
		internal double value
		{
			get;
			set;
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00133A2C File Offset: 0x00131C2C
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x00133A40 File Offset: 0x00131C40
		internal bool isChecked
		{
			get;
			set;
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x00133A54 File Offset: 0x00131C54
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00133A68 File Offset: 0x00131C68
		internal GpsPoint prevPoint
		{
			get;
			set;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00133A7C File Offset: 0x00131C7C
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x00133A90 File Offset: 0x00131C90
		public List<GpsLink> links
		{
			get;
			set;
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00133AA4 File Offset: 0x00131CA4
		public double dist(GpsPoint anotherPoint)
		{
			if (anotherPoint == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(GpsPoint.dist(GpsPoint)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92972);
			}
			try
			{
				return cdfe9014d02101a49c91049e7d709b638.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c320ca58d53ded23deb9158a3051f3103.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(anotherPoint), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92980)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbc3fa3988b958b1b3e95702aeeb2287d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(anotherPoint), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92988)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfdc1cb8002f3f417502586add62b2dde.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(anotherPoint), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92996)));
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(93004);
		}

		// Token: 0x04001369 RID: 4969
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400136A RID: 4970
		[CompilerGenerated]
		private double ca7fad13c316e809c89069ffdb5ba59d8;

		// Token: 0x0400136B RID: 4971
		[CompilerGenerated]
		private double c9cdc89109d0276c13fa87317f2c2f379;

		// Token: 0x0400136C RID: 4972
		[CompilerGenerated]
		private double c98392c6434c507c020ead57a87fedb81;

		// Token: 0x0400136D RID: 4973
		[CompilerGenerated]
		private double c8331fdc3a0edec5f6e011f6065da11ac;

		// Token: 0x0400136E RID: 4974
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x0400136F RID: 4975
		[CompilerGenerated]
		private double c0b972c0a6fd42f9045235c08ef4ba754;

		// Token: 0x04001370 RID: 4976
		[CompilerGenerated]
		private bool cc579560bdae969f4ae82c8d59f32c357;

		// Token: 0x04001371 RID: 4977
		[CompilerGenerated]
		private GpsPoint ceed6273a9bb6c759155b3e1280485cf0;

		// Token: 0x04001372 RID: 4978
		[CompilerGenerated]
		private List<GpsLink> ccfb34d33468a3389dbdfed1d6e0b6abd;
	}
}
