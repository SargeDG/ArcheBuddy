using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using A;

namespace ArcheBuddy.WPFForms
{
	// Token: 0x0200012E RID: 302
	public class MyScrollBar : Control
	{
		// Token: 0x06000AD6 RID: 2774 RVA: 0x0006BC28 File Offset: 0x00069E28
		public MyScrollBar()
		{
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24028), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24032) != 0);
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0006BC90 File Offset: 0x00069E90
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0006BCA4 File Offset: 0x00069EA4
		public int Value
		{
			get
			{
				return this.c520a716d720e4fa3864a395fc5f5449d;
			}
			set
			{
				if (this.c520a716d720e4fa3864a395fc5f5449d == value)
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
						RuntimeMethodHandle arg_1B_0 = methodof(MyScrollBar.set_Value(int)).MethodHandle;
					}
					return;
				}
				this.c520a716d720e4fa3864a395fc5f5449d = value;
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				c239d23ab0eb19cfcabf8dee99d90d427.c30767ddca1f9c207888833aea5b5fc61(this, (ScrollEventType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23956));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0006BCEC File Offset: 0x00069EEC
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0006BD00 File Offset: 0x00069F00
		public int Maximum
		{
			get
			{
				return this.c47097413430740065c47c633eefc2557;
			}
			set
			{
				this.c47097413430740065c47c633eefc2557 = value;
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0006BD1C File Offset: 0x00069F1C
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0006BD30 File Offset: 0x00069F30
		public int ThumbSize
		{
			get
			{
				return this.c39274c2ed6cd68e7f59b1ab089b4062f;
			}
			set
			{
				this.c39274c2ed6cd68e7f59b1ab089b4062f = value;
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0006BD4C File Offset: 0x00069F4C
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0006BD60 File Offset: 0x00069F60
		public Color ThumbColor
		{
			get
			{
				return this.c5f5d194158abdc122995974851df3dac;
			}
			set
			{
				this.c5f5d194158abdc122995974851df3dac = value;
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0006BD7C File Offset: 0x00069F7C
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0006BD90 File Offset: 0x00069F90
		public Color BorderColor
		{
			get
			{
				return this.cf253281ae0909c0ce12b95dbef7c99a4;
			}
			set
			{
				this.cf253281ae0909c0ce12b95dbef7c99a4 = value;
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0006BDAC File Offset: 0x00069FAC
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0006BDC0 File Offset: 0x00069FC0
		public ScrollOrientation Orientation
		{
			get
			{
				return this.c312f77dda5f856a83ec103cb9ac50a41;
			}
			set
			{
				this.c312f77dda5f856a83ec103cb9ac50a41 = value;
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000AE3 RID: 2787 RVA: 0x0006BDDC File Offset: 0x00069FDC
		// (remove) Token: 0x06000AE4 RID: 2788 RVA: 0x0006BE2C File Offset: 0x0006A02C
		public event ScrollEventHandler Scroll
		{
			add
			{
				ScrollEventHandler scrollEventHandler = this.c84dc6e3547ea72e5d7ec9ed5db585630;
				ScrollEventHandler scrollEventHandler2;
				do
				{
					scrollEventHandler2 = scrollEventHandler;
					ScrollEventHandler value2 = cdd416a95b7fea196c34bda14b5442069.c9963fcf210a214a3206d6500f3b9397b(c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(scrollEventHandler2, value));
					scrollEventHandler = Interlocked.CompareExchange<ScrollEventHandler>(ref this.c84dc6e3547ea72e5d7ec9ed5db585630, value2, scrollEventHandler2);
				}
				while (scrollEventHandler != scrollEventHandler2);
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
					RuntimeMethodHandle arg_40_0 = methodof(MyScrollBar.add_Scroll(ScrollEventHandler)).MethodHandle;
				}
			}
			remove
			{
				ScrollEventHandler scrollEventHandler = this.c84dc6e3547ea72e5d7ec9ed5db585630;
				ScrollEventHandler scrollEventHandler2;
				do
				{
					scrollEventHandler2 = scrollEventHandler;
					ScrollEventHandler value2 = cdd416a95b7fea196c34bda14b5442069.c9963fcf210a214a3206d6500f3b9397b(cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(scrollEventHandler2, value));
					scrollEventHandler = Interlocked.CompareExchange<ScrollEventHandler>(ref this.c84dc6e3547ea72e5d7ec9ed5db585630, value2, scrollEventHandler2);
				}
				while (scrollEventHandler != scrollEventHandler2);
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
					RuntimeMethodHandle arg_40_0 = methodof(MyScrollBar.remove_Scroll(ScrollEventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0006BE7C File Offset: 0x0006A07C
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (cf6e557dac7e4bcf41dfeb444ad6d7e6d.c30767ddca1f9c207888833aea5b5fc61(e) == (MouseButtons)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23960))
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
					RuntimeMethodHandle arg_26_0 = methodof(MyScrollBar.OnMouseDown(MouseEventArgs)).MethodHandle;
				}
				this.c0a72f6d379dc1bc8441d8fa2e749fe85(e);
			}
			cf072978d34c8f7341469fd421a0737bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0006BEC0 File Offset: 0x0006A0C0
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (cf6e557dac7e4bcf41dfeb444ad6d7e6d.c30767ddca1f9c207888833aea5b5fc61(e) == (MouseButtons)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23964))
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
					RuntimeMethodHandle arg_26_0 = methodof(MyScrollBar.OnMouseMove(MouseEventArgs)).MethodHandle;
				}
				this.c0a72f6d379dc1bc8441d8fa2e749fe85(e);
			}
			c7723fc964b929f5f56ebfcca123ffe12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0006BF04 File Offset: 0x0006A104
		private void c0a72f6d379dc1bc8441d8fa2e749fe85(MouseEventArgs mouseEventArgs)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23968);
			switch (cabc8d623f4802100ff2184d97a9157a9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case ScrollOrientation.HorizontalScroll:
				num = c99c4f90838957947e8d5f349d07f6504.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * (cc9cf5c2a7a84876f073b374e67926f6e.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs) - this.c39274c2ed6cd68e7f59b1ab089b4062f / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23976)) / (c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - this.c39274c2ed6cd68e7f59b1ab089b4062f);
				break;
			case ScrollOrientation.VerticalScroll:
				num = c99c4f90838957947e8d5f349d07f6504.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * (c45a096d3e1a00147ef841f0d197c79da.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs) - this.c39274c2ed6cd68e7f59b1ab089b4062f / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23972)) / (ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - this.c39274c2ed6cd68e7f59b1ab089b4062f);
				break;
			}
			c7ef86f48c99636dae0c13fd588cc0a31.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23980), c34f0f68932ceb7756e2775a73f05347d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c99c4f90838957947e8d5f349d07f6504.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)));
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0006BFC8 File Offset: 0x0006A1C8
		public virtual void OnScroll(ScrollEventType type = ScrollEventType.ThumbPosition)
		{
			if (this.c84dc6e3547ea72e5d7ec9ed5db585630 != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(MyScrollBar.OnScroll(ScrollEventType)).MethodHandle;
				}
				c597f8e1a70448c433db6e4b5e554f728.c30767ddca1f9c207888833aea5b5fc61(this.c84dc6e3547ea72e5d7ec9ed5db585630, this, cec95c98890c1509212535b9fa37006ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(type, cc41de092acc35698caf655f59a0dfe57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cabc8d623f4802100ff2184d97a9157a9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			}
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0006C014 File Offset: 0x0006A214
		protected override void OnPaint(PaintEventArgs e)
		{
			if (c99c4f90838957947e8d5f349d07f6504.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23984))
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
					RuntimeMethodHandle arg_26_0 = methodof(MyScrollBar.OnPaint(PaintEventArgs)).MethodHandle;
				}
				return;
			}
			Rectangle empty = Rectangle.Empty;
			switch (cabc8d623f4802100ff2184d97a9157a9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case ScrollOrientation.HorizontalScroll:
				c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref empty, this.c520a716d720e4fa3864a395fc5f5449d * (c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - this.c39274c2ed6cd68e7f59b1ab089b4062f) / c99c4f90838957947e8d5f349d07f6504.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23988), this.c39274c2ed6cd68e7f59b1ab089b4062f, ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23992));
				break;
			case ScrollOrientation.VerticalScroll:
				c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref empty, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(23996), this.c520a716d720e4fa3864a395fc5f5449d * (ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - this.c39274c2ed6cd68e7f59b1ab089b4062f) / c99c4f90838957947e8d5f349d07f6504.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24000), this.c39274c2ed6cd68e7f59b1ab089b4062f);
				break;
			}
			SolidBrush solidBrush = c97029713e71fa272f7b9333658c1803b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c5f5d194158abdc122995974851df3dac);
			try
			{
				c0e9706ab4bed38a637ab806a844ccb15.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), solidBrush, empty);
			}
			finally
			{
				if (solidBrush != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(solidBrush);
				}
			}
			Pen pen = c2d484ca0b28dd06391815d44372919c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf253281ae0909c0ce12b95dbef7c99a4);
			try
			{
				cd42e772429a5ac47fa447a05fef388eb.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), pen, new Rectangle(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24004), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24008), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24012), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24016)));
			}
			finally
			{
				if (pen != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(pen);
				}
			}
		}

		// Token: 0x04000668 RID: 1640
		private int c520a716d720e4fa3864a395fc5f5449d;

		// Token: 0x04000669 RID: 1641
		private int c47097413430740065c47c633eefc2557 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24020);

		// Token: 0x0400066A RID: 1642
		private int c39274c2ed6cd68e7f59b1ab089b4062f = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24024);

		// Token: 0x0400066B RID: 1643
		private Color c5f5d194158abdc122995974851df3dac = c41a9a23964757241c5bc59cb110cbff2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x0400066C RID: 1644
		private Color cf253281ae0909c0ce12b95dbef7c99a4 = cf0d92837735f203f79d4b683266cf14a.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x0400066D RID: 1645
		private ScrollOrientation c312f77dda5f856a83ec103cb9ac50a41;

		// Token: 0x0400066E RID: 1646
		private ScrollEventHandler c84dc6e3547ea72e5d7ec9ed5db585630;
	}
}
