using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.IO;
using System.Media;

namespace A
{
	// Token: 0x0200008E RID: 142
	internal sealed class cc491258979d33afecac6b4f5b9461a9a
	{
		// Token: 0x06000299 RID: 665 RVA: 0x0002B860 File Offset: 0x00029A60
		public cc491258979d33afecac6b4f5b9461a9a()
		{
			SoundPlayer soundPlayer = new SoundPlayer();
			DirectoryInfo directoryInfo = new DirectoryInfo(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121745));
			this.cf02cc9cecd12b1052d4bc032370632d9 = ce2d34613c9bdd0c50f0d2c2fc14994cc.c30767ddca1f9c207888833aea5b5fc61(directoryInfo, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121758));
			this.c1ae02be6561ccd3238aa3ae7e751ae28 = new ConcurrentQueue<string>();
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			cd7427d1d0277f7e30125d5a18842a90b.c30767ddca1f9c207888833aea5b5fc61(backgroundWorker, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9144) != 0);
			c560bea62229257a2466d6f89a0878b7e.c30767ddca1f9c207888833aea5b5fc61(backgroundWorker, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9148) != 0);
			c696109bb9c96bef32cc5439d7b767092.c30767ddca1f9c207888833aea5b5fc61(backgroundWorker, new DoWorkEventHandler(this.c2d0051b443f2211fa523826b5046d10e));
			cc267f1202a76193373c6e05d8ce8f822.c30767ddca1f9c207888833aea5b5fc61(backgroundWorker, soundPlayer);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0002B8F0 File Offset: 0x00029AF0
		private void c2d0051b443f2211fa523826b5046d10e(object obj, DoWorkEventArgs doWorkEventArgs)
		{
			SoundPlayer soundPlayer = cdd112713e1daf02a4b4be9fcbab7c1ba.c9963fcf210a214a3206d6500f3b9397b(c57339562542ce24d82944c3374621776.c30767ddca1f9c207888833aea5b5fc61(doWorkEventArgs));
			try
			{
				while (true)
				{
					IL_10:
					if (c23b8b711a5a1a7cd4ad0b61709f0581e.c30767ddca1f9c207888833aea5b5fc61(this.c1ae02be6561ccd3238aa3ae7e751ae28) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9116))
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
							RuntimeMethodHandle arg_3B_0 = methodof(cc491258979d33afecac6b4f5b9461a9a.c2d0051b443f2211fa523826b5046d10e(object, DoWorkEventArgs)).MethodHandle;
						}
						string text;
						if (c4c49a78788c181523cbad8071797b8d9.c30767ddca1f9c207888833aea5b5fc61(this.c1ae02be6561ccd3238aa3ae7e751ae28, ref text))
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
							if (!cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
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
								cd0ca29d9e3a4ac3a5ec4778061be73bb.c30767ddca1f9c207888833aea5b5fc61(soundPlayer, text);
								c8a1ad691db94a664dc90093be08eb908.c30767ddca1f9c207888833aea5b5fc61(soundPlayer);
							}
						}
					}
					else
					{
						c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9120));
					}
				}
			}
			catch
			{
				goto IL_10;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0002B9A0 File Offset: 0x00029BA0
		public bool c8025f5cbdb8e3f7cc9a20e987bf536cc(string text, uint num = 0u)
		{
			if (num > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9124))
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
					RuntimeMethodHandle arg_1F_0 = methodof(cc491258979d33afecac6b4f5b9461a9a.c8025f5cbdb8e3f7cc9a20e987bf536cc(string, uint)).MethodHandle;
				}
				if (cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede() < (long)((ulong)num + (ulong)this.c704e71728a6a4d9831719fab69c3d765))
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
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9128) != 0;
				}
			}
			try
			{
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
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
					this.c704e71728a6a4d9831719fab69c3d765 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
					cc5f67515db8001500508324d5827fe73.c30767ddca1f9c207888833aea5b5fc61(this.c1ae02be6561ccd3238aa3ae7e751ae28, text);
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9132) != 0;
					return result;
				}
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121728), text)))
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
					this.c704e71728a6a4d9831719fab69c3d765 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
					cc5f67515db8001500508324d5827fe73.c30767ddca1f9c207888833aea5b5fc61(this.c1ae02be6561ccd3238aa3ae7e751ae28, c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121728), text));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9136) != 0;
					return result;
				}
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(9140) != 0;
		}

		// Token: 0x040001D8 RID: 472
		private ConcurrentQueue<string> c1ae02be6561ccd3238aa3ae7e751ae28;

		// Token: 0x040001D9 RID: 473
		public FileInfo[] cf02cc9cecd12b1052d4bc032370632d9;

		// Token: 0x040001DA RID: 474
		internal long c704e71728a6a4d9831719fab69c3d765;
	}
}
