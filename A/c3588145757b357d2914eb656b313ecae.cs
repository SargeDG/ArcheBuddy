using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using ArcheBuddy;

namespace A
{
	// Token: 0x0200002D RID: 45
	internal sealed class c3588145757b357d2914eb656b313ecae
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00012804 File Offset: 0x00010A04
		public c3588145757b357d2914eb656b313ecae()
		{
			this.cfc905479a6dc36526c0438c907b4f5a0 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2684) != 0);
			this.ce62827a7a529d6203b0c3addc89cb3c9 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2688));
			this.cc2cf678c05af30b3d1766fa545d867c1 = new ConcurrentQueue<byte[]>();
			this.ce7afbb9027bf2feb71f836f6a31f2d37 = new object();
			this.c93bbaff4707e96bcaa3115033ce14a96 = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2692);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00012864 File Offset: 0x00010A64
		internal void c43a910514984b239ba45a3a1a212b439()
		{
			this.cfc905479a6dc36526c0438c907b4f5a0 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2552) != 0);
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(this.c3658f6041330f1160240f5709e7d6779)));
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(this.c4b33ba2cc9c2952d62e8a23c909d4fe9)));
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000128B4 File Offset: 0x00010AB4
		private void ce038fd96cae5402e856db57ddd30b515()
		{
			cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
			c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2556), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2560), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2564), new AsyncCallback(this.cd00415385725c74f8189835af191ebc7), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001290C File Offset: 0x00010B0C
		public void cd00415385725c74f8189835af191ebc7(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2568);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, asyncResult);
				this.c6bab70b8125f6af8a7a3089cae33a5e1 += (ushort)num;
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				this.cdecf9d73ed6132077497efbc3dfbd4d5();
				return;
			}
			if ((int)this.c6bab70b8125f6af8a7a3089cae33a5e1 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2572))
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
					RuntimeMethodHandle arg_6C_0 = methodof(c3588145757b357d2914eb656b313ecae.cd00415385725c74f8189835af191ebc7(IAsyncResult)).MethodHandle;
				}
				try
				{
					this.c4aa766a148d8699c681b84ca2c51a28a = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2576));
					this.c09689fc25739533f05afa6e0d105defb = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2580);
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2584), (int)this.c4aa766a148d8699c681b84ca2c51a28a, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2588), new AsyncCallback(this.c5e0be7254ef3d5c76770db4724213053), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception)
				{
					this.cdecf9d73ed6132077497efbc3dfbd4d5();
					return;
				}
			}
			if ((int)this.c6bab70b8125f6af8a7a3089cae33a5e1 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2592))
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
				try
				{
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2596), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2600), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2604), new AsyncCallback(this.cd00415385725c74f8189835af191ebc7), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception)
				{
					this.cdecf9d73ed6132077497efbc3dfbd4d5();
					return;
				}
			}
			if (num == 0)
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
				this.cdecf9d73ed6132077497efbc3dfbd4d5();
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00012AA8 File Offset: 0x00010CA8
		public void c5e0be7254ef3d5c76770db4724213053(IAsyncResult asyncResult)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2608);
			try
			{
				num = caeeeedb1e276ebf36315572bf77a0c1f.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, asyncResult);
				this.c09689fc25739533f05afa6e0d105defb += (ushort)num;
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				this.cdecf9d73ed6132077497efbc3dfbd4d5();
				return;
			}
			if (this.c09689fc25739533f05afa6e0d105defb == this.c4aa766a148d8699c681b84ca2c51a28a)
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
					RuntimeMethodHandle arg_68_0 = methodof(c3588145757b357d2914eb656b313ecae.c5e0be7254ef3d5c76770db4724213053(IAsyncResult)).MethodHandle;
				}
				try
				{
					ushort num2 = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2612));
					this.c6bab70b8125f6af8a7a3089cae33a5e1 = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2616);
					byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)this.c09689fc25739533f05afa6e0d105defb + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2620));
					cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2624), array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2628), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
					this.cbf7a4962b3c0aaf1a574a0a08705cbab(num2, array);
					c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2632), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2636), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2640), new AsyncCallback(this.cd00415385725c74f8189835af191ebc7), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					return;
				}
				catch (Exception)
				{
					this.cdecf9d73ed6132077497efbc3dfbd4d5();
					return;
				}
			}
			if (num == 0)
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
				this.cdecf9d73ed6132077497efbc3dfbd4d5();
				return;
			}
			try
			{
				c1fbe82c39f286b6e6925fbd6e5b4f8fa.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, this.ce62827a7a529d6203b0c3addc89cb3c9, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2644) + (int)this.c09689fc25739533f05afa6e0d105defb, (int)(this.c4aa766a148d8699c681b84ca2c51a28a - this.c09689fc25739533f05afa6e0d105defb), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2648), new AsyncCallback(this.c5e0be7254ef3d5c76770db4724213053), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
			}
			catch (Exception)
			{
				this.cdecf9d73ed6132077497efbc3dfbd4d5();
				return;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00012C78 File Offset: 0x00010E78
		public void cbf7a4962b3c0aaf1a574a0a08705cbab(ushort num, byte[] array)
		{
			switch ((int)num - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2652))
			{
			case 0:
			{
				c6ed3edee80938ffa71a502a4ad42bf98 c6ed3edee80938ffa71a502a4ad42bf = new c6ed3edee80938ffa71a502a4ad42bf98(array);
				this.ce0db3e4869f83e785fd6b3f882c2ad50 = c6ed3edee80938ffa71a502a4ad42bf.ce0db3e4869f83e785fd6b3f882c2ad50;
				this.ca8123d02877c101ca9d6878779e5867f = c6ed3edee80938ffa71a502a4ad42bf.ca8123d02877c101ca9d6878779e5867f;
				return;
			}
			case 1:
				break;
			case 2:
			{
				c53778a5e37513f1e9b5e818742d4d5e4 c53778a5e37513f1e9b5e818742d4d5e = new c53778a5e37513f1e9b5e818742d4d5e4(array);
				this.c93bbaff4707e96bcaa3115033ce14a96 = c53778a5e37513f1e9b5e818742d4d5e.c74032a42c884fbe4bf7c85d8d9877350;
				return;
			}
			case 3:
			{
				c29ec9770fc53a456bb51e505c15d64ca c29ec9770fc53a456bb51e505c15d64ca = new c29ec9770fc53a456bb51e505c15d64ca(array);
				this.c43aac719d0149f545731db556e73774d = c29ec9770fc53a456bb51e505c15d64ca.c534b6b1aa9ece9c07587919c1355f353;
				return;
			}
			case 4:
			{
				c1ce38c89aae6f69c4d2c2dc892eb97e7 c1ce38c89aae6f69c4d2c2dc892eb97e = new c1ce38c89aae6f69c4d2c2dc892eb97e7(array);
				this.c7c85ffa725f6bd0c310451137c8fc1b9 = c1ce38c89aae6f69c4d2c2dc892eb97e.cefb7f7dffeefa360548cd796e471d285;
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00012D0C File Offset: 0x00010F0C
		public void c1ed0d9195e96125f123e84c095059c53()
		{
			c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2656));
			while (this.cfc905479a6dc36526c0438c907b4f5a0)
			{
				try
				{
					cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
					if (cf964d045e4379ba37f86ea5d2267af59.c30767ddca1f9c207888833aea5b5fc61(this.cc2cf678c05af30b3d1766fa545d867c1) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2660))
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
							RuntimeMethodHandle arg_45_0 = methodof(c3588145757b357d2914eb656b313ecae.c1ed0d9195e96125f123e84c095059c53()).MethodHandle;
						}
						byte[] c8a754f5f2ca4adde825691a9c31a0e = c7d19159535b8ba95efe224e27f4d871a.c8a754f5f2ca4adde825691a9c31a0e83;
						if (c5a18bac908512210d39308d605ae7073.c30767ddca1f9c207888833aea5b5fc61(this.cc2cf678c05af30b3d1766fa545d867c1, ref c8a754f5f2ca4adde825691a9c31a0e))
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
							if (c8a754f5f2ca4adde825691a9c31a0e != null)
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
								cfda98247af3db7faeda8fb7ed004a7cb.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, c8a754f5f2ca4adde825691a9c31a0e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2664), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(c8a754f5f2ca4adde825691a9c31a0e), (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2668));
							}
						}
					}
				}
				catch (Exception ex)
				{
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
					this.cdecf9d73ed6132077497efbc3dfbd4d5();
				}
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2672));
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
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00012E08 File Offset: 0x00011008
		private void cdecf9d73ed6132077497efbc3dfbd4d5()
		{
			this.cfc905479a6dc36526c0438c907b4f5a0 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2676) != 0);
			c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33724));
			try
			{
				c06acd1de5b9bd9dd5c62573b3618ebe1.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24, (SocketShutdown)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2680));
			}
			catch
			{
			}
			try
			{
				c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(this.c3654d1a1a1a1ab7be541bf32ea27fa24);
			}
			catch
			{
			}
			AppMain.c184a42a74d25a49281e3c84092602419.cfe50e8c3d4f67ae83b64a8c1b1aa6257(this);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00012E88 File Offset: 0x00011088
		[CompilerGenerated]
		private void c3658f6041330f1160240f5709e7d6779()
		{
			this.c1ed0d9195e96125f123e84c095059c53();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00012E9C File Offset: 0x0001109C
		[CompilerGenerated]
		private void c4b33ba2cc9c2952d62e8a23c909d4fe9()
		{
			this.ce038fd96cae5402e856db57ddd30b515();
		}

		// Token: 0x04000062 RID: 98
		internal Socket c3654d1a1a1a1ab7be541bf32ea27fa24;

		// Token: 0x04000063 RID: 99
		internal bool cfc905479a6dc36526c0438c907b4f5a0;

		// Token: 0x04000064 RID: 100
		public ConcurrentQueue<byte[]> cc2cf678c05af30b3d1766fa545d867c1;

		// Token: 0x04000065 RID: 101
		public byte[] ce62827a7a529d6203b0c3addc89cb3c9;

		// Token: 0x04000066 RID: 102
		public ushort c4aa766a148d8699c681b84ca2c51a28a;

		// Token: 0x04000067 RID: 103
		public ushort c09689fc25739533f05afa6e0d105defb;

		// Token: 0x04000068 RID: 104
		public ushort c6bab70b8125f6af8a7a3089cae33a5e1;

		// Token: 0x04000069 RID: 105
		public object ce7afbb9027bf2feb71f836f6a31f2d37;

		// Token: 0x0400006A RID: 106
		public int ce0db3e4869f83e785fd6b3f882c2ad50;

		// Token: 0x0400006B RID: 107
		public int ca8123d02877c101ca9d6878779e5867f;

		// Token: 0x0400006C RID: 108
		public int c7c85ffa725f6bd0c310451137c8fc1b9;

		// Token: 0x0400006D RID: 109
		public uint c93bbaff4707e96bcaa3115033ce14a96;

		// Token: 0x0400006E RID: 110
		public bool c43aac719d0149f545731db556e73774d;
	}
}
