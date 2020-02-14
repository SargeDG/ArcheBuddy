using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000011 RID: 17
	public class ScheduleItem : BaseObject
	{
		// Token: 0x06000055 RID: 85 RVA: 0x0000FB5C File Offset: 0x0000DD5C
		internal ScheduleItem(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2004));
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000FB88 File Offset: 0x0000DD88
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public SqlScheduleItem db
		{
			get;
			internal set;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000FBB0 File Offset: 0x0000DDB0
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000FBD8 File Offset: 0x0000DDD8
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000FBEC File Offset: 0x0000DDEC
		public uint totalReceivedCount
		{
			get;
			internal set;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000FC00 File Offset: 0x0000DE00
		public int remainTime
		{
			get
			{
				return c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c422c6b434d92535f188b44514dbd265e.c30767ddca1f9c207888833aea5b5fc61(ccdaa937f9606d3a60b8a4e8d29249774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1956) - c07fd0b8533d8a6a45199e6b08fc382b1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1960));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000FC44 File Offset: 0x0000DE44
		// (set) Token: 0x0600005E RID: 94 RVA: 0x0000FC58 File Offset: 0x0000DE58
		internal int cumulated
		{
			get;
			set;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000FC6C File Offset: 0x0000DE6C
		// (set) Token: 0x06000060 RID: 96 RVA: 0x0000FC80 File Offset: 0x0000DE80
		public ulong updated
		{
			get;
			internal set;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000FC94 File Offset: 0x0000DE94
		public bool Claim()
		{
			try
			{
				bool result;
				if (c5931fdba119ff9867c9dd2aeb30ac730.c30767ddca1f9c207888833aea5b5fc61(ccdaa937f9606d3a60b8a4e8d29249774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						RuntimeMethodHandle arg_23_0 = methodof(ScheduleItem.Claim()).MethodHandle;
					}
					if (ceea83eca486bcb38524b84cda8358a95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1964))
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
						if (cb527d66ea0a7a33c86b09739c269fa5b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) < c6e218d690addef57c3b1b75218e4b3a9.c30767ddca1f9c207888833aea5b5fc61(ccdaa937f9606d3a60b8a4e8d29249774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
						{
							c9d0fe03b9e9483eececc2c038559c0eb c9d0fe03b9e9483eececc2c038559c0eb = new c9d0fe03b9e9483eececc2c038559c0eb(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c8fbef0d97c2ef31cb4e5090362c04f52.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1976), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1980));
							this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c9d0fe03b9e9483eececc2c038559c0eb, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1984) != 0);
							result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1988), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1992));
							return result;
						}
						while (true)
						{
							switch (5)
							{
							case 0:
								continue;
							}
							break;
						}
					}
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1968));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1972) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1996) != 0;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000FDDC File Offset: 0x0000DFDC
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
						RuntimeMethodHandle arg_1A_0 = methodof(ScheduleItem.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						cb0f4d4cb058ebdb4a0254dffb6ad3a39.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c53853ff373da9f3ab6905937b2260798.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000FE48 File Offset: 0x0000E048
		internal void c4aaf7619a600d569451f27c0b2b78918()
		{
			cb0f4d4cb058ebdb4a0254dffb6ad3a39.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4bc1bc34906045fe5d0f9a4ef6fa7fb2.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (c8fbef0d97c2ef31cb4e5090362c04f52.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2000))
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
					RuntimeMethodHandle arg_33_0 = methodof(ScheduleItem.c4aaf7619a600d569451f27c0b2b78918()).MethodHandle;
				}
				try
				{
					if (c8eedbee294b530e7fd40d3c04158b360.c30767ddca1f9c207888833aea5b5fc61(c06f20c1a7657eb5a3a9f11f669f6e257.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fbef0d97c2ef31cb4e5090362c04f52.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						cb0f4d4cb058ebdb4a0254dffb6ad3a39.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c8ddf1024fb4eb6ab92d1dd7e24d5f887.c30767ddca1f9c207888833aea5b5fc61(c06f20c1a7657eb5a3a9f11f669f6e257.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fbef0d97c2ef31cb4e5090362c04f52.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x04000029 RID: 41
		[CompilerGenerated]
		private SqlScheduleItem cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x0400002A RID: 42
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400002B RID: 43
		[CompilerGenerated]
		private uint cc503025eec1c655399de6f37844a3550;

		// Token: 0x0400002C RID: 44
		[CompilerGenerated]
		private int c0e663be748015a2adaf1def6c5ff3b9f;

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		private ulong c8ab46fad70406ed682f3f32195694f77;
	}
}
