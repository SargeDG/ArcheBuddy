using System;
using System.IO;

namespace A
{
	// Token: 0x02000019 RID: 25
	internal abstract class c20d0ee5e94d9784dc0803fe3a4628e16
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000115D4 File Offset: 0x0000F7D4
		protected c20d0ee5e94d9784dc0803fe3a4628e16(int num, cdddb0b97541c52448b8f0b50995b8c8e cdddb0b97541c52448b8f0b50995b8c8e, c920c2912e29f42e690b5d188b10e15ce c920c2912e29f42e690b5d188b10e15ce, bool flag = true)
		{
			this.cfffa987bb40f5a52a78d3ae7981ae443 = cdddb0b97541c52448b8f0b50995b8c8e;
			this.c405cfb38b75f3addff4cb333bde448e0 = num;
			this.c702e42a48f326ceb5ec8130187522f8f = new MemoryStream();
			this.c1931c382e0fefaae84b9654d92e1461e = new BinaryWriter(this.c702e42a48f326ceb5ec8130187522f8f);
			this.c477ab70ef7d8f68848e774639e1f1924 = flag;
			this.c68326be62adc96106ff21f9b228e0b16 = c920c2912e29f42e690b5d188b10e15ce;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00011620 File Offset: 0x0000F820
		protected c20d0ee5e94d9784dc0803fe3a4628e16(int num, cdddb0b97541c52448b8f0b50995b8c8e cdddb0b97541c52448b8f0b50995b8c8e, byte b, c920c2912e29f42e690b5d188b10e15ce c920c2912e29f42e690b5d188b10e15ce, byte b2 = 0)
		{
			this.cfffa987bb40f5a52a78d3ae7981ae443 = cdddb0b97541c52448b8f0b50995b8c8e;
			this.c405cfb38b75f3addff4cb333bde448e0 = num;
			this.c4196d4f1f84ad4f2e6aec391f233acdd = b;
			this.c477ab70ef7d8f68848e774639e1f1924 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2372) != 0);
			this.c68326be62adc96106ff21f9b228e0b16 = c920c2912e29f42e690b5d188b10e15ce;
			this.c8608b719788295efe96d3448fb11700d = b2;
			this.c702e42a48f326ceb5ec8130187522f8f = new MemoryStream();
			this.c1931c382e0fefaae84b9654d92e1461e = new BinaryWriter(this.c702e42a48f326ceb5ec8130187522f8f);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00011684 File Offset: 0x0000F884
		public void cedd090b61873ec1b7f2dc5423cec2105(string empty)
		{
			if (empty == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c20d0ee5e94d9784dc0803fe3a4628e16.cedd090b61873ec1b7f2dc5423cec2105(string)).MethodHandle;
				}
				empty = string.Empty;
			}
			int num = c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), empty);
			this.c861311b52a7b91706a6296ca8355496c((short)num);
			byte[] array = cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), empty);
			this.c861311b52a7b91706a6296ca8355496c(array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2280), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000116F4 File Offset: 0x0000F8F4
		public void c861311b52a7b91706a6296ca8355496c(bool flag)
		{
			c005211c2f0f6b5f611b5535dae0e5f0d.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, flag);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00011710 File Offset: 0x0000F910
		public void c861311b52a7b91706a6296ca8355496c(byte b)
		{
			c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, b);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0001172C File Offset: 0x0000F92C
		public void c861311b52a7b91706a6296ca8355496c(byte[] array)
		{
			ca36a55fde7e5a04eec5680dc3efae15b.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, array);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00011748 File Offset: 0x0000F948
		public void c861311b52a7b91706a6296ca8355496c(char c)
		{
			c3621b619ee49c1a9f36bc4735d3e22a1.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, c);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00011764 File Offset: 0x0000F964
		public void c861311b52a7b91706a6296ca8355496c(char[] array)
		{
			c0d5ae1eced29057e95a13cfd20cd872e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, array);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00011780 File Offset: 0x0000F980
		public void c861311b52a7b91706a6296ca8355496c(decimal num)
		{
			cff1b3c1e68196445d3990eab09b9cfa1.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0001179C File Offset: 0x0000F99C
		public void c861311b52a7b91706a6296ca8355496c(double num)
		{
			c0e8c848c2a9a16ec958ac33fa5698ab9.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000117B8 File Offset: 0x0000F9B8
		public void c861311b52a7b91706a6296ca8355496c(float num)
		{
			c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000117D4 File Offset: 0x0000F9D4
		public void c861311b52a7b91706a6296ca8355496c(int num)
		{
			ca7d22a7a1042600fe3a2e5ce18a64fa9.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000117F0 File Offset: 0x0000F9F0
		public void c861311b52a7b91706a6296ca8355496c(long num)
		{
			c1b8e6622cf5bb534895ccfb0a85e0e28.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0001180C File Offset: 0x0000FA0C
		public void c861311b52a7b91706a6296ca8355496c(sbyte b)
		{
			c7115429cefd2170d8bfd9c8c2c458518.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, b);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00011828 File Offset: 0x0000FA28
		public void c861311b52a7b91706a6296ca8355496c(short num)
		{
			c6a09a81ccd1d166cdaa5a9eb42b5057c.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00011844 File Offset: 0x0000FA44
		public void c861311b52a7b91706a6296ca8355496c(uint num)
		{
			c3cf10fc3a2a8c5199ec950aa3b0ca820.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00011860 File Offset: 0x0000FA60
		public void c861311b52a7b91706a6296ca8355496c(ulong num)
		{
			c638b3f54887515edcf39a6ca596f9ca7.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0001187C File Offset: 0x0000FA7C
		public void c861311b52a7b91706a6296ca8355496c(ushort num)
		{
			cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, num);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00011898 File Offset: 0x0000FA98
		public void c861311b52a7b91706a6296ca8355496c(byte[] array, int num, int num2)
		{
			c532dbffc51af9c93aebe56d73cf1bb4b.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, array, num, num2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000118B4 File Offset: 0x0000FAB4
		public void c861311b52a7b91706a6296ca8355496c(char[] array, int num, int num2)
		{
			c55d82b6f65f82661c1fe6c1c87535ede.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, array, num, num2);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000118D0 File Offset: 0x0000FAD0
		public void c56f4ec0f8afb12405c147a59ff84ed00(uint num)
		{
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2284));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2288)] = (byte)(num >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2292));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2296)] = (byte)(num >> c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2300));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2304)] = (byte)num;
			c532dbffc51af9c93aebe56d73cf1bb4b.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2308), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2312));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00011950 File Offset: 0x0000FB50
		public byte[] c442e09b1de2262d3a3a28826b3ea696f()
		{
			try
			{
				c219da346a9155b5a7db89195b66c1d46.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e);
				MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				try
				{
					BinaryWriter binaryWriter = c71fa6f0b097935929087ccc2b8f2a944.c0cf59c3e67a46fd4edb3040c5ab0bbfb(memoryStream);
					try
					{
						if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2316))
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
								RuntimeMethodHandle arg_40_0 = methodof(c20d0ee5e94d9784dc0803fe3a4628e16.c442e09b1de2262d3a3a28826b3ea696f()).MethodHandle;
							}
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)(c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e)) + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2320)));
						}
						else
						{
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)(c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e)) + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2324)));
						}
						if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2328))
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
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, this.c8608b719788295efe96d3448fb11700d);
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, this.c4196d4f1f84ad4f2e6aec391f233acdd);
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2332));
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2336));
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)this.c405cfb38b75f3addff4cb333bde448e0);
						}
						else
						{
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)this.c405cfb38b75f3addff4cb333bde448e0);
						}
						byte[] array = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(c5bbcd8e235b11d319550ab4c61ab8047.cea69e7c4d1a729bd5783221de1566e79(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e)));
						c532dbffc51af9c93aebe56d73cf1bb4b.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2340), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						cae7648f0695094758e98e714f4c5d532.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e);
						cd6f2d0264fa0ded80e22dc98ffdf38a1.c30767ddca1f9c207888833aea5b5fc61(this.c702e42a48f326ceb5ec8130187522f8f);
						return cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(c5bbcd8e235b11d319550ab4c61ab8047.cea69e7c4d1a729bd5783221de1566e79(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter)));
					}
					finally
					{
						if (binaryWriter != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(binaryWriter);
						}
					}
				}
				finally
				{
					if (memoryStream != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00011B44 File Offset: 0x0000FD44
		public byte[] c0ee7581762ff6557c07841174e39cbfd()
		{
			try
			{
				c219da346a9155b5a7db89195b66c1d46.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e);
				MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				try
				{
					BinaryWriter binaryWriter = c71fa6f0b097935929087ccc2b8f2a944.c0cf59c3e67a46fd4edb3040c5ab0bbfb(memoryStream);
					try
					{
						if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2344))
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
								RuntimeMethodHandle arg_40_0 = methodof(c20d0ee5e94d9784dc0803fe3a4628e16.c0ee7581762ff6557c07841174e39cbfd()).MethodHandle;
							}
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)(c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e)) + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2348)));
						}
						else
						{
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)(c3b45b7e91d9b93445332ed6504dfee00.c30767ddca1f9c207888833aea5b5fc61(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e)) + (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2352)));
						}
						if (this.c68326be62adc96106ff21f9b228e0b16 == (c920c2912e29f42e690b5d188b10e15ce)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2356))
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
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, this.c8608b719788295efe96d3448fb11700d);
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, this.c4196d4f1f84ad4f2e6aec391f233acdd);
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2360));
							c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2364));
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)this.c405cfb38b75f3addff4cb333bde448e0);
						}
						else
						{
							cb658730f79b14e883812818d6e577a25.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (ushort)this.c405cfb38b75f3addff4cb333bde448e0);
						}
						byte[] array = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(c5bbcd8e235b11d319550ab4c61ab8047.cea69e7c4d1a729bd5783221de1566e79(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(this.c1931c382e0fefaae84b9654d92e1461e)));
						c532dbffc51af9c93aebe56d73cf1bb4b.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2368), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
						return cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(c5bbcd8e235b11d319550ab4c61ab8047.cea69e7c4d1a729bd5783221de1566e79(c3490c2e1f13580fda8bf8151f5c8e72e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter)));
					}
					finally
					{
						if (binaryWriter != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(binaryWriter);
						}
					}
				}
				finally
				{
					if (memoryStream != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
					}
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x04000044 RID: 68
		protected BinaryWriter c1931c382e0fefaae84b9654d92e1461e;

		// Token: 0x04000045 RID: 69
		private MemoryStream c702e42a48f326ceb5ec8130187522f8f;

		// Token: 0x04000046 RID: 70
		public int c405cfb38b75f3addff4cb333bde448e0;

		// Token: 0x04000047 RID: 71
		public bool c477ab70ef7d8f68848e774639e1f1924;

		// Token: 0x04000048 RID: 72
		public c920c2912e29f42e690b5d188b10e15ce c68326be62adc96106ff21f9b228e0b16;

		// Token: 0x04000049 RID: 73
		public cdddb0b97541c52448b8f0b50995b8c8e cfffa987bb40f5a52a78d3ae7981ae443;

		// Token: 0x0400004A RID: 74
		public byte c4196d4f1f84ad4f2e6aec391f233acdd;

		// Token: 0x0400004B RID: 75
		public byte c8608b719788295efe96d3448fb11700d;
	}
}
