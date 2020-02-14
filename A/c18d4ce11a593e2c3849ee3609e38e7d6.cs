using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace A
{
	// Token: 0x02000035 RID: 53
	internal abstract class c18d4ce11a593e2c3849ee3609e38e7d6 : DataGridViewButtonCell
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00014254 File Offset: 0x00012454
		protected c18d4ce11a593e2c3849ee3609e38e7d6()
		{
			this.cc19067b544bb83df1f41859b6b1dd828 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2816) != 0);
			this.c550a818f3d8ccfb5c913facef474b167 = (PushButtonState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2820);
			this.cca3f04a43661d90e8275f2601c1aa392 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2824);
			this.c13222a4d86de4ece0bc478b1f590dfe8();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000142A0 File Offset: 0x000124A0
		public bool get_ca96242084dbfbae91e06218e491b79ca()
		{
			return this.cc19067b544bb83df1f41859b6b1dd828;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000142B4 File Offset: 0x000124B4
		public void set_ca96242084dbfbae91e06218e491b79ca(bool flag)
		{
			this.cc19067b544bb83df1f41859b6b1dd828 = flag;
			PushButtonState arg_34_1;
			if (!flag)
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
					RuntimeMethodHandle arg_1D_0 = methodof(c18d4ce11a593e2c3849ee3609e38e7d6.set_ca96242084dbfbae91e06218e491b79ca(bool)).MethodHandle;
				}
				arg_34_1 = (PushButtonState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2772);
			}
			else
			{
				arg_34_1 = (PushButtonState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2776);
			}
			this.c550a818f3d8ccfb5c913facef474b167 = arg_34_1;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000142FC File Offset: 0x000124FC
		protected override void Dispose(bool disposing)
		{
			if (!this.cc3bee16b81d51bea12e1e52f129f2941)
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
					RuntimeMethodHandle arg_1D_0 = methodof(c18d4ce11a593e2c3849ee3609e38e7d6.Dispose(bool)).MethodHandle;
				}
				if (disposing)
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
					this.cc3bee16b81d51bea12e1e52f129f2941 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2780) != 0);
				}
				ce8679b8c1aa649c831fa5e0c52cc3d56.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				try
				{
					if (this.c6815a24fe4b9db6a4abacb6cc31c9cb7 != null)
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
						c762855a9636b81dcb4ffe699b8e25cf6.c30767ddca1f9c207888833aea5b5fc61(this.c6815a24fe4b9db6a4abacb6cc31c9cb7);
						this.c6815a24fe4b9db6a4abacb6cc31c9cb7 = cc7b603655a9de1239fed9c45bfe7c6d9.c8a754f5f2ca4adde825691a9c31a0e83;
					}
					if (this.ce051df4467fd83c7dd16816620009375 != null)
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
						c762855a9636b81dcb4ffe699b8e25cf6.c30767ddca1f9c207888833aea5b5fc61(this.ce051df4467fd83c7dd16816620009375);
						this.ce051df4467fd83c7dd16816620009375 = cc7b603655a9de1239fed9c45bfe7c6d9.c8a754f5f2ca4adde825691a9c31a0e83;
					}
					if (this.c02dc987e6fbafdd52ca00593e940081a != null)
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
						this.c02dc987e6fbafdd52ca00593e940081a = cc7b603655a9de1239fed9c45bfe7c6d9.c8a754f5f2ca4adde825691a9c31a0e83;
						c762855a9636b81dcb4ffe699b8e25cf6.c30767ddca1f9c207888833aea5b5fc61(this.c02dc987e6fbafdd52ca00593e940081a);
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000143D8 File Offset: 0x000125D8
		public PushButtonState get_cd558120869837b8bdbefb2276367355c()
		{
			return this.c550a818f3d8ccfb5c913facef474b167;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000143EC File Offset: 0x000125EC
		public void set_cd558120869837b8bdbefb2276367355c(PushButtonState pushButtonState)
		{
			this.c550a818f3d8ccfb5c913facef474b167 = pushButtonState;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00014400 File Offset: 0x00012600
		public Image get_cdbf5148c23c1f6deeef2eee02b89fef5()
		{
			switch (this.c550a818f3d8ccfb5c913facef474b167 - (PushButtonState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2784))
			{
			case 0:
				return this.ce051df4467fd83c7dd16816620009375;
			case 1:
				return this.c6815a24fe4b9db6a4abacb6cc31c9cb7;
			case 2:
				return this.ce051df4467fd83c7dd16816620009375;
			case 3:
				return this.c02dc987e6fbafdd52ca00593e940081a;
			case 4:
				return this.ce051df4467fd83c7dd16816620009375;
			default:
				return this.ce051df4467fd83c7dd16816620009375;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00014464 File Offset: 0x00012664
		protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
		{
			if ((paintParts & (DataGridViewPaintParts)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2788)) == (DataGridViewPaintParts)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2792))
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
					RuntimeMethodHandle arg_2B_0 = methodof(c18d4ce11a593e2c3849ee3609e38e7d6.Paint(Graphics, Rectangle, Rectangle, int, DataGridViewElementStates, object, object, string, DataGridViewCellStyle, DataGridViewAdvancedBorderStyle, DataGridViewPaintParts)).MethodHandle;
				}
				SolidBrush solidBrush = c97029713e71fa272f7b9333658c1803b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c0e3ced1dffca8577b5c04c03681e1b35.c30767ddca1f9c207888833aea5b5fc61(cellStyle));
				c0e9706ab4bed38a637ab806a844ccb15.c30767ddca1f9c207888833aea5b5fc61(graphics, solidBrush, cellBounds);
				c3b76f6c1bde20349c8aed4180c80b15e.c30767ddca1f9c207888833aea5b5fc61(solidBrush);
			}
			if ((paintParts & (DataGridViewPaintParts)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2796)) == (DataGridViewPaintParts)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2800))
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
				c50ae81522a33aba0e501a91c2f78a42f.c30767ddca1f9c207888833aea5b5fc61(this, graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
			}
			Rectangle rectangle = cellBounds;
			Rectangle rectangle2 = cfb2c14ca568bddbbfe70550ce807f34a.c30767ddca1f9c207888833aea5b5fc61(this, advancedBorderStyle);
			c2c85b6869c150a04c3d94a96b45bb73d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, cfac539844b84a01a0a0533a56b535827.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + cfac539844b84a01a0a0533a56b535827.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2));
			ca0ba7c3315580e344e52243672434fe7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, cb7943e92136442a4a1588340704fb2cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + cb7943e92136442a4a1588340704fb2cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2));
			cc90b72faa5c6b689cb90546646f5116c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c2b318e6d6ab76cf080966a63c1deabe9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2));
			c9c141ef9ae4da6f26a6d59524c02233f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) - c7565079d14fd34dda05aff7c0e5d1e82.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2));
			Rectangle rectangle3;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle3, cfac539844b84a01a0a0533a56b535827.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + this.cca3f04a43661d90e8275f2601c1aa392, cb7943e92136442a4a1588340704fb2cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle) + this.cca3f04a43661d90e8275f2601c1aa392, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2804), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2808));
			c3e73b0d96f9d7908b6f9bef618c5cbd6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(graphics, rectangle, this.get_cdbf5148c23c1f6deeef2eee02b89fef5(), rectangle3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2812) != 0, this.get_cd558120869837b8bdbefb2276367355c());
		}

		// Token: 0x0600011B RID: 283
		public abstract void c13222a4d86de4ece0bc478b1f590dfe8();

		// Token: 0x040000B6 RID: 182
		private bool cc19067b544bb83df1f41859b6b1dd828;

		// Token: 0x040000B7 RID: 183
		private PushButtonState c550a818f3d8ccfb5c913facef474b167;

		// Token: 0x040000B8 RID: 184
		protected Image c6815a24fe4b9db6a4abacb6cc31c9cb7;

		// Token: 0x040000B9 RID: 185
		protected Image ce051df4467fd83c7dd16816620009375;

		// Token: 0x040000BA RID: 186
		protected Image c02dc987e6fbafdd52ca00593e940081a;

		// Token: 0x040000BB RID: 187
		private int cca3f04a43661d90e8275f2601c1aa392;

		// Token: 0x040000BC RID: 188
		private bool cc3bee16b81d51bea12e1e52f129f2941;
	}
}
