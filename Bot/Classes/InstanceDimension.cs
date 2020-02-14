using System;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200000E RID: 14
	public class InstanceDimension : BaseObject
	{
		// Token: 0x0600003C RID: 60 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		internal InstanceDimension(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1948));
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000F71C File Offset: 0x0000D91C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000F730 File Offset: 0x0000D930
		internal uint doodadObjId
		{
			get;
			set;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000F744 File Offset: 0x0000D944
		// (set) Token: 0x06000040 RID: 64 RVA: 0x0000F758 File Offset: 0x0000D958
		public int index
		{
			get;
			internal set;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000F76C File Offset: 0x0000D96C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000F780 File Offset: 0x0000D980
		public uint uniqId
		{
			get;
			internal set;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000043 RID: 67 RVA: 0x0000F794 File Offset: 0x0000D994
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		public int currentOnline
		{
			get;
			internal set;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000F7BC File Offset: 0x0000D9BC
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000F7D0 File Offset: 0x0000D9D0
		public int maximumOnline
		{
			get;
			internal set;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000F7E4 File Offset: 0x0000D9E4
		public bool Enter()
		{
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1920) != 0;
			try
			{
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1924), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1928));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new c64b16c63feb0232f737d3b6bb2956ea1(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c4b6f0af8fca51c54f8d13c0e13dfcdae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cfde56d247e6653247bcbb720c3cba3cb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1932) != 0);
				flag = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1936), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1940));
				if (flag)
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
						RuntimeMethodHandle arg_9A_0 = methodof(InstanceDimension.Enter()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.cb619750f0d1490f1bb119a7cec3b7d40((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1944));
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return flag;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000F8C4 File Offset: 0x0000DAC4
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(InstanceDimension.Dispose(bool)).MethodHandle;
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000020 RID: 32
		[CompilerGenerated]
		private uint cef224c3e943518edcc8712e949c9da1f;

		// Token: 0x04000021 RID: 33
		[CompilerGenerated]
		private int c88560fff2dc3d96ef1e4314c22933afd;

		// Token: 0x04000022 RID: 34
		[CompilerGenerated]
		private uint c1f042b599e757f7d30e4be9756bd3cb4;

		// Token: 0x04000023 RID: 35
		[CompilerGenerated]
		private int cdb25b6a030c96acee36841b67f8bb769;

		// Token: 0x04000024 RID: 36
		[CompilerGenerated]
		private int c0562ff9919609cada272e2b4e95bdd5f;
	}
}
