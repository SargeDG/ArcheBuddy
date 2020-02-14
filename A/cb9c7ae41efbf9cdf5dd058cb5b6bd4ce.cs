using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace A
{
	// Token: 0x0200008A RID: 138
	internal abstract class cb9c7ae41efbf9cdf5dd058cb5b6bd4ce
	{
		// Token: 0x06000263 RID: 611 RVA: 0x00029F58 File Offset: 0x00028158
		protected cb9c7ae41efbf9cdf5dd058cb5b6bd4ce(Socket cf24609f302c8028345e1679d0d, string c705a0f887c825b8469c8e372324d383c)
		{
			this.set_cf24609f302c8028345e1679d0d124681(cf24609f302c8028345e1679d0d);
			this.set_c705a0f887c825b8469c8e372324d383c(c705a0f887c825b8469c8e372324d383c);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00029F7C File Offset: 0x0002817C
		protected byte[] c82c2d11e7da10edaccd52ddb862bd3b1(int num)
		{
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8488));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8492)] = (byte)(num / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8496));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8500)] = (byte)(num % c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8504));
			return array;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00029FD0 File Offset: 0x000281D0
		protected byte[] c624aaec6cace3654e06ed2f7c4abb414(long num)
		{
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8508));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8512)] = (byte)(num % (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8516));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8520)] = (byte)(num / (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8524) % (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8528));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8532)] = (byte)(num / (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8536) % (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8540));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8544)] = (byte)(num / (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8548));
			return array;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0002A070 File Offset: 0x00028270
		protected byte[] c9aadc47cadea665e334dd7fd3c6ed641(int num)
		{
			if (num <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8552))
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
					RuntimeMethodHandle arg_1F_0 = methodof(cb9c7ae41efbf9cdf5dd058cb5b6bd4ce.c9aadc47cadea665e334dd7fd3c6ed641(int)).MethodHandle;
				}
				throw c30a8897a7b5a0d9dd30232bf3c7c946b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num);
			for (int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8556); num2 != num; num2 += ce7dae80d7dd6d760809ee25c9253b059.c30767ddca1f9c207888833aea5b5fc61(this.get_cf24609f302c8028345e1679d0d124681(), array, num2, num - num2, (SocketFlags)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8560)))
			{
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
			return array;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0002A0EC File Offset: 0x000282EC
		protected Socket get_cf24609f302c8028345e1679d0d124681()
		{
			return this.c71e440a47cdcc6113c9b1749463db001;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0002A100 File Offset: 0x00028300
		protected void set_cf24609f302c8028345e1679d0d124681(Socket socket)
		{
			if (socket == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(cb9c7ae41efbf9cdf5dd058cb5b6bd4ce.set_cf24609f302c8028345e1679d0d124681(Socket)).MethodHandle;
				}
				throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			this.c71e440a47cdcc6113c9b1749463db001 = socket;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0002A134 File Offset: 0x00028334
		protected string get_c705a0f887c825b8469c8e372324d383c()
		{
			return this.c021defce2bf7595f305c5d33bd51d47a;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0002A148 File Offset: 0x00028348
		protected void set_c705a0f887c825b8469c8e372324d383c(string text)
		{
			if (text == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(cb9c7ae41efbf9cdf5dd058cb5b6bd4ce.set_c705a0f887c825b8469c8e372324d383c(string)).MethodHandle;
				}
				throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			this.c021defce2bf7595f305c5d33bd51d47a = text;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0002A17C File Offset: 0x0002837C
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0002A190 File Offset: 0x00028390
		protected c1f315ef57f53b9718c486d2471a987ab AsyncResult
		{
			get;
			set;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0002A1A4 File Offset: 0x000283A4
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0002A1B8 File Offset: 0x000283B8
		protected byte[] Buffer
		{
			get;
			set;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0002A1CC File Offset: 0x000283CC
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0002A1E0 File Offset: 0x000283E0
		protected int Received
		{
			get;
			set;
		}

		// Token: 0x06000271 RID: 625
		public abstract bool cd4984a3f0068c136ed45d994c481ffa0(IPEndPoint);

		// Token: 0x06000272 RID: 626
		public abstract c1f315ef57f53b9718c486d2471a987ab c5134a32ff91da1d642775a47f5f2eb0f(IPEndPoint, ccfeb8f0395778415ab1abeaad031a1f6, IPEndPoint);

		// Token: 0x06000273 RID: 627
		public abstract c1f315ef57f53b9718c486d2471a987ab c5134a32ff91da1d642775a47f5f2eb0f(string, int, ccfeb8f0395778415ab1abeaad031a1f6, IPEndPoint);

		// Token: 0x040001D0 RID: 464
		private Socket c71e440a47cdcc6113c9b1749463db001;

		// Token: 0x040001D1 RID: 465
		private string c021defce2bf7595f305c5d33bd51d47a;

		// Token: 0x040001D2 RID: 466
		protected ccfeb8f0395778415ab1abeaad031a1f6 c8f74e795c73594d10e5a874cf1aca7eb;

		// Token: 0x040001D3 RID: 467
		[CompilerGenerated]
		private c1f315ef57f53b9718c486d2471a987ab c56b8497afadfd403b284ad7effe9cdcc;

		// Token: 0x040001D4 RID: 468
		[CompilerGenerated]
		private byte[] c16da14aeab4ff0bf79a15d10d2dc4e19;

		// Token: 0x040001D5 RID: 469
		[CompilerGenerated]
		private int cc4f0d357c6c0a2fedc04e4201df100fd;
	}
}
