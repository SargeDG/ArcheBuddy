using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace A
{
	// Token: 0x02000083 RID: 131
	internal abstract class cf11b4182bc91da8c535513537961c9fd
	{
		// Token: 0x06000224 RID: 548 RVA: 0x00028DD4 File Offset: 0x00026FD4
		protected cf11b4182bc91da8c535513537961c9fd(Socket cf24609f302c8028345e1679d0d)
		{
			this.set_cf24609f302c8028345e1679d0d124681(cf24609f302c8028345e1679d0d);
		}

		// Token: 0x06000225 RID: 549
		public abstract void c224eedeeb961b90223dfc622645db42f();

		// Token: 0x06000226 RID: 550
		public abstract void c9277c8c1007c42aaad42fd57f57814bf(ccfeb8f0395778415ab1abeaad031a1f6);

		// Token: 0x06000227 RID: 551 RVA: 0x00028DF0 File Offset: 0x00026FF0
		protected Socket get_cf24609f302c8028345e1679d0d124681()
		{
			return this.c71e440a47cdcc6113c9b1749463db001;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00028E04 File Offset: 0x00027004
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
					RuntimeMethodHandle arg_15_0 = methodof(cf11b4182bc91da8c535513537961c9fd.set_cf24609f302c8028345e1679d0d124681(Socket)).MethodHandle;
				}
				throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			this.c71e440a47cdcc6113c9b1749463db001 = socket;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00028E38 File Offset: 0x00027038
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00028E4C File Offset: 0x0002704C
		protected byte[] Buffer
		{
			get;
			set;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00028E60 File Offset: 0x00027060
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00028E74 File Offset: 0x00027074
		protected int Received
		{
			get;
			set;
		}

		// Token: 0x040001B9 RID: 441
		private Socket c71e440a47cdcc6113c9b1749463db001;

		// Token: 0x040001BA RID: 442
		protected ccfeb8f0395778415ab1abeaad031a1f6 c8a427066fff9065a0631d741bc1336e7;

		// Token: 0x040001BB RID: 443
		[CompilerGenerated]
		private byte[] c16da14aeab4ff0bf79a15d10d2dc4e19;

		// Token: 0x040001BC RID: 444
		[CompilerGenerated]
		private int cc4f0d357c6c0a2fedc04e4201df100fd;
	}
}
