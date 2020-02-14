using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200000D RID: 13
	public class Appellation : BaseObject
	{
		// Token: 0x06000033 RID: 51 RVA: 0x0000F478 File Offset: 0x0000D678
		internal Appellation(CoreInternal ca124a9f406cda69b904f2eb04d553ab, bool flag)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1916));
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			this.cac2efbf46d6f9bbc7ba081c68667954b = flag;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
		public bool isActive
		{
			get;
			internal set;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0000F4E8 File Offset: 0x0000D6E8
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000F4FC File Offset: 0x0000D6FC
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000F510 File Offset: 0x0000D710
		public SqlAppellation db
		{
			get;
			internal set;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000F524 File Offset: 0x0000D724
		internal void c4aaf7619a600d569451f27c0b2b78918()
		{
			c643650bf7340664d477392cb6e4ad83d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cf3cbcb0364371d5b761b767c1e6f0f5b.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (c5eab7928584a9431e34ba0459f0649e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1872))
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
					RuntimeMethodHandle arg_33_0 = methodof(Appellation.c4aaf7619a600d569451f27c0b2b78918()).MethodHandle;
				}
				try
				{
					if (cf438ca422d26da0f5c32a099b7d8fa1f.c30767ddca1f9c207888833aea5b5fc61(c8b9f6d5795ad46382d8995a207ead655.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5eab7928584a9431e34ba0459f0649e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						c643650bf7340664d477392cb6e4ad83d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cdad113011f5506e483e79c7a98cb83b7.c30767ddca1f9c207888833aea5b5fc61(c8b9f6d5795ad46382d8995a207ead655.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5eab7928584a9431e34ba0459f0649e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		public bool SetActive()
		{
			try
			{
				bool result;
				if (cccceb557596b9d43f49ae1d27c8e2ab7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
						RuntimeMethodHandle arg_1C_0 = methodof(Appellation.SetActive()).MethodHandle;
					}
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1876) != 0);
					return result;
				}
				if (!this.cac2efbf46d6f9bbc7ba081c68667954b)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1880));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1884) != 0);
					return result;
				}
				caa19ae770edc78fb050bef7dcdb3cb2e caa19ae770edc78fb050bef7dcdb3cb2e = new caa19ae770edc78fb050bef7dcdb3cb2e(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c5eab7928584a9431e34ba0459f0649e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1888), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1892));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(caa19ae770edc78fb050bef7dcdb3cb2e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1896) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1900), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1904));
				return result;
			}
			catch
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1908));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1912) != 0;
		}

		// Token: 0x0400001C RID: 28
		private bool cac2efbf46d6f9bbc7ba081c68667954b;

		// Token: 0x0400001D RID: 29
		[CompilerGenerated]
		private bool ca7a6bfefbb220abcde3c1c47f44e4152;

		// Token: 0x0400001E RID: 30
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400001F RID: 31
		[CompilerGenerated]
		private SqlAppellation cc2bcffe3af6b9ca90f5a2b25172010a9;
	}
}
