using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace A
{
	// Token: 0x0200002F RID: 47
	internal sealed class c75a8318049f6cd045bfd43b14b535f2c
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x000131EC File Offset: 0x000113EC
		public c75a8318049f6cd045bfd43b14b535f2c(IPEndPoint iPEndPoint)
		{
			this.c6a083c1145e013bc4ecca22c69f09584 = iPEndPoint;
			this.c2234fa507c9d3f46a24af8932f79f607 = new ManualResetEvent(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2728) != 0);
			cbc8adeb611689a492bf97b06c39bec9b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<c3588145757b357d2914eb656b313ecae>());
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00013228 File Offset: 0x00011428
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0001323C File Offset: 0x0001143C
		private List<c3588145757b357d2914eb656b313ecae> clients
		{
			get;
			set;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00013250 File Offset: 0x00011450
		public void c6c51bb82d80e7e091b5bf962ae384605()
		{
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Action(this.c36470deafd9caeb67c0c6076eaaa4969)));
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00013278 File Offset: 0x00011478
		internal void c3f6c62826fa2dec469b6b18fb6f82a85(c3588145757b357d2914eb656b313ecae c3588145757b357d2914eb656b313ecae)
		{
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c0759edbb3941f9d9be51ee9e0d5d6d7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				ce1520227402456c6d069c34e46385848.c30767ddca1f9c207888833aea5b5fc61(c0759edbb3941f9d9be51ee9e0d5d6d7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c3588145757b357d2914eb656b313ecae);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000132C4 File Offset: 0x000114C4
		internal void cfe50e8c3d4f67ae83b64a8c1b1aa6257(c3588145757b357d2914eb656b313ecae c3588145757b357d2914eb656b313ecae)
		{
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c0759edbb3941f9d9be51ee9e0d5d6d7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				cb5ce3654bb35709b105df852619bb9d5.c30767ddca1f9c207888833aea5b5fc61(c0759edbb3941f9d9be51ee9e0d5d6d7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c3588145757b357d2914eb656b313ecae);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00013314 File Offset: 0x00011514
		internal List<c3588145757b357d2914eb656b313ecae> c39c4123f5a98f990da5c03fbbe3eb316()
		{
			List<c3588145757b357d2914eb656b313ecae> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c0759edbb3941f9d9be51ee9e0d5d6d7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c0759edbb3941f9d9be51ee9e0d5d6d7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<c3588145757b357d2914eb656b313ecae>();
			}
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00013364 File Offset: 0x00011564
		private void c2e4efbc0beda36b8d201d4715eb6659c()
		{
			if (this.c6a083c1145e013bc4ecca22c69f09584 == null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c75a8318049f6cd045bfd43b14b535f2c.c2e4efbc0beda36b8d201d4715eb6659c()).MethodHandle;
				}
				return;
			}
			this.ce52eefb6031371b072f305ee20f02e94 = cfd8d6ed5f17bd7f35ffd8cc7a436e956.c0cf59c3e67a46fd4edb3040c5ab0bbfb((AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2696), (SocketType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2700), (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2704));
			try
			{
				c4fdbb5f9678e390877ab4423d27cca08.c30767ddca1f9c207888833aea5b5fc61(this.ce52eefb6031371b072f305ee20f02e94, this.c6a083c1145e013bc4ecca22c69f09584);
				this.c6a083c1145e013bc4ecca22c69f09584 = c34ef5f360ebd2b82bfce469249378171.cea69e7c4d1a729bd5783221de1566e79(c35450ffc0b84ef5b46a49533433e3f85.c30767ddca1f9c207888833aea5b5fc61(this.ce52eefb6031371b072f305ee20f02e94));
				c96553709655a1c6339284d2c20ca0272.c30767ddca1f9c207888833aea5b5fc61(this.ce52eefb6031371b072f305ee20f02e94, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2708));
				while (true)
				{
					c032afe3d58d18d870d19651ec22dbfab.c30767ddca1f9c207888833aea5b5fc61(this.c2234fa507c9d3f46a24af8932f79f607);
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2712));
					c8b56ad90512779f269cb33ee138ce76d.c30767ddca1f9c207888833aea5b5fc61(this.ce52eefb6031371b072f305ee20f02e94, new AsyncCallback(this.c7ea3d7138de54bb22083fc5fc5393b70), c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
					c7d8848bc529c05e2b45df56bbbdfcebd.c30767ddca1f9c207888833aea5b5fc61(this.c2234fa507c9d3f46a24af8932f79f607);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			c4a69eb809830c0a7691e3f40cd2bff6d.c30767ddca1f9c207888833aea5b5fc61(this.ce52eefb6031371b072f305ee20f02e94);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00013470 File Offset: 0x00011670
		private void c7ea3d7138de54bb22083fc5fc5393b70(IAsyncResult asyncResult)
		{
			c3588145757b357d2914eb656b313ecae c3588145757b357d2914eb656b313ecae = new c3588145757b357d2914eb656b313ecae();
			try
			{
				c3588145757b357d2914eb656b313ecae.c3654d1a1a1a1ab7be541bf32ea27fa24 = c51a3f9422bd8499197cd08929710ee51.c30767ddca1f9c207888833aea5b5fc61(this.ce52eefb6031371b072f305ee20f02e94, asyncResult);
				c62eeeda7511b89b0e89a32f8bdb1a63c.c30767ddca1f9c207888833aea5b5fc61(c3588145757b357d2914eb656b313ecae.c3654d1a1a1a1ab7be541bf32ea27fa24, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2716) != 0);
				this.c3f6c62826fa2dec469b6b18fb6f82a85(c3588145757b357d2914eb656b313ecae);
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33763), cd7633c7e55019bb6cf8408ac5d417e1f.c30767ddca1f9c207888833aea5b5fc61(c3588145757b357d2914eb656b313ecae.c3654d1a1a1a1ab7be541bf32ea27fa24)));
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			c3588145757b357d2914eb656b313ecae.c43a910514984b239ba45a3a1a212b439();
			while (cb60f82a4d3832ddd94abec4b7cb495ce.c30767ddca1f9c207888833aea5b5fc61(c0759edbb3941f9d9be51ee9e0d5d6d7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2724))
			{
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2720));
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
			if (!true)
			{
				RuntimeMethodHandle arg_B1_0 = methodof(c75a8318049f6cd045bfd43b14b535f2c.c7ea3d7138de54bb22083fc5fc5393b70(IAsyncResult)).MethodHandle;
			}
			c264d1fcae864f49479a34111fa59b3f3.c30767ddca1f9c207888833aea5b5fc61(this.c2234fa507c9d3f46a24af8932f79f607);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00013550 File Offset: 0x00011750
		[CompilerGenerated]
		private void c36470deafd9caeb67c0c6076eaaa4969()
		{
			this.c2e4efbc0beda36b8d201d4715eb6659c();
		}

		// Token: 0x04000084 RID: 132
		private ManualResetEvent c2234fa507c9d3f46a24af8932f79f607;

		// Token: 0x04000085 RID: 133
		private Socket ce52eefb6031371b072f305ee20f02e94;

		// Token: 0x04000086 RID: 134
		internal IPEndPoint c6a083c1145e013bc4ecca22c69f09584;

		// Token: 0x04000087 RID: 135
		[CompilerGenerated]
		private List<c3588145757b357d2914eb656b313ecae> c7cf5088cbc513ad1644a11403dbb70ad;
	}
}
