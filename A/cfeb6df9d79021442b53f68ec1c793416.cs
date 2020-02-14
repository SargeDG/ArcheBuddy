using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x02000567 RID: 1383
	internal sealed class cfeb6df9d79021442b53f68ec1c793416 : PictureBox
	{
		// Token: 0x06001EE2 RID: 7906 RVA: 0x0013C45C File Offset: 0x0013A65C
		public cfeb6df9d79021442b53f68ec1c793416(CoreInternal coreInternal, c6bdd46ef9f05485f6b69f34bf6920a88 c6bdd46ef9f05485f6b69f34bf6920a)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			this.c6c72c029a273123a083e76d610205020 = c6bdd46ef9f05485f6b69f34bf6920a;
			this.c99cc8d41a90783cea4e7845c839dcc98();
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95212), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95216) != 0);
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95220), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95224) != 0);
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95228), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95232) != 0);
			c4f52fbd7a977302279ff2b52d7038e24.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c21d5868d08c9e8b8ddd91f6b3afd5763.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95236), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95240), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95244)));
			caeb3bfb4bd8e1da3cebb25e70fc63907.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c21d5868d08c9e8b8ddd91f6b3afd5763.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95248), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95252), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95256)));
			cf1d54351daaba9d3030052460a81dace.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c21d5868d08c9e8b8ddd91f6b3afd5763.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95260), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95264), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95268)));
			cca17ec00daccfd1487df80f47f595cfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c21d5868d08c9e8b8ddd91f6b3afd5763.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95272), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95276), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95280)));
			this.cf253281ae0909c0ce12b95dbef7c99a4 = c21d5868d08c9e8b8ddd91f6b3afd5763.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95284), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95288), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95292));
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0013C5DC File Offset: 0x0013A7DC
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x0013C5F0 File Offset: 0x0013A7F0
		public Color topBright
		{
			get;
			set;
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x0013C604 File Offset: 0x0013A804
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x0013C618 File Offset: 0x0013A818
		public Color bottomBright
		{
			get;
			set;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x0013C62C File Offset: 0x0013A82C
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x0013C640 File Offset: 0x0013A840
		public Color topFaded
		{
			get;
			set;
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x0013C654 File Offset: 0x0013A854
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x0013C668 File Offset: 0x0013A868
		public Color bottomFaded
		{
			get;
			set;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0013C67C File Offset: 0x0013A87C
		protected override void OnPaint(PaintEventArgs e)
		{
			cef56a9fede40546d087138fbc8ff851a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
			Brush brush = cf4295bc0c5ee1d0cf7912e1ed365a288.c8a754f5f2ca4adde825691a9c31a0e83;
			int num = (int)((double)c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * ((double)this.c052c778d5c09788ff94bdadaaba342a0 / (double)this.cc6ef55540754bd2aaa4ae65ab8c0644f));
			if (num > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95108))
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
					RuntimeMethodHandle arg_4A_0 = methodof(cfeb6df9d79021442b53f68ec1c793416.OnPaint(PaintEventArgs)).MethodHandle;
				}
				brush = ccf478989f045101a815f66a35432d31e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Rectangle(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95112), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95116), num, ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), cec3e591e37e912c5347e493fcd22bd3d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cab57248a304e118f9170dacfdf721139.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (LinearGradientMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95120));
				c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), brush, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95124), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95128), num, ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				c3b76f6c1bde20349c8aed4180c80b15e.c30767ddca1f9c207888833aea5b5fc61(brush);
			}
			if (c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95132))
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
				brush = ccf478989f045101a815f66a35432d31e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Rectangle(num, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95136), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num, ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c8dcbe18cefd9a64cc8625103758099f6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c58dd3a6c0182154d273acb9cd8e265a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (LinearGradientMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95140));
				c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), brush, num, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95144), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num, ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				c3b76f6c1bde20349c8aed4180c80b15e.c30767ddca1f9c207888833aea5b5fc61(brush);
			}
			new Rectangle(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95148), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95152), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			Pen pen = c2d484ca0b28dd06391815d44372919c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf253281ae0909c0ce12b95dbef7c99a4);
			cff4284ab76029a39cd7248149ca6b18f.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), pen, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95156), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95160), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95164), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95168));
			if (pen != null)
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
				caae7f13aa68fd0adb2ac60da5991288b.c30767ddca1f9c207888833aea5b5fc61(pen);
			}
			c984a13d358f02c3823e16a014a6b3534.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), (TextRenderingHint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95172));
			cbc0dae595877f31b464441b941d8259a.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c195a54fbdf960ff8ef1ef331acb79a1a, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, c83b44165d3605f1b8ac978e9108efabc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new PointF((float)c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) / c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(95176) - c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(95180) - (float)((double)((float)c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(this.c195a54fbdf960ff8ef1ef331acb79a1a) / c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(95184)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(95188)), (float)(ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95196) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95200))));
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0013C920 File Offset: 0x0013AB20
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle arg_15_0 = methodof(cfeb6df9d79021442b53f68ec1c793416.Dispose(bool)).MethodHandle;
				}
				if (this.ce3753db2789ff7c885165e389c0b762f != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(this.ce3753db2789ff7c885165e389c0b762f);
				}
			}
			c88a8f596ef73f10ee2a9cc8467376000.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0013C968 File Offset: 0x0013AB68
		private void c99cc8d41a90783cea4e7845c839dcc98()
		{
			this.ce3753db2789ff7c885165e389c0b762f = ce5d9f7cdcdd93dceb594ff3b777c5df3.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x0400140B RID: 5131
		public Color cf253281ae0909c0ce12b95dbef7c99a4;

		// Token: 0x0400140C RID: 5132
		public string c195a54fbdf960ff8ef1ef331acb79a1a = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201829);

		// Token: 0x0400140D RID: 5133
		private CoreInternal ca124a9f406cda69b904f2eb04d553ab9;

		// Token: 0x0400140E RID: 5134
		private c6bdd46ef9f05485f6b69f34bf6920a88 c6c72c029a273123a083e76d610205020;

		// Token: 0x0400140F RID: 5135
		public int cc6ef55540754bd2aaa4ae65ab8c0644f = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95204);

		// Token: 0x04001410 RID: 5136
		public int c052c778d5c09788ff94bdadaaba342a0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95208);

		// Token: 0x04001411 RID: 5137
		private IContainer ce3753db2789ff7c885165e389c0b762f;

		// Token: 0x04001412 RID: 5138
		[CompilerGenerated]
		private Color c8e10ddde87303767642ec3f656ef4f37;

		// Token: 0x04001413 RID: 5139
		[CompilerGenerated]
		private Color cb5eb7ce5e039072ec05b69b943fd0151;

		// Token: 0x04001414 RID: 5140
		[CompilerGenerated]
		private Color ca4a8b2a18ee48e55f840753e662aebad;

		// Token: 0x04001415 RID: 5141
		[CompilerGenerated]
		private Color c06ff9f96afbf65cfd19ba711c1245013;
	}
}
