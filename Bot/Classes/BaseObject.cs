using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200000C RID: 12
	public class BaseObject : MarshalProxy
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000F384 File Offset: 0x0000D584
		internal BaseObject()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1868));
			this.c9536738bc80596e4d8a280f370d4de41 = new Dictionary<string, object>();
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000F3C8 File Offset: 0x0000D5C8
		public double sortWeight
		{
			get;
			set;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0000F3DC File Offset: 0x0000D5DC
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
		public BotTypes type
		{
			get;
			internal set;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000F404 File Offset: 0x0000D604
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(BaseObject.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						this.ca124a9f406cda69b904f2eb04d553ab9 = c49603cd9629f69a6585d48b4afcaf58c.c8a754f5f2ca4adde825691a9c31a0e83;
						ce90f5993cc2b6f5175652436b47f8a58.c30767ddca1f9c207888833aea5b5fc61(this.c9536738bc80596e4d8a280f370d4de41);
					}
					ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x04000017 RID: 23
		internal Dictionary<string, object> c9536738bc80596e4d8a280f370d4de41;

		// Token: 0x04000018 RID: 24
		internal CoreInternal ca124a9f406cda69b904f2eb04d553ab9;

		// Token: 0x04000019 RID: 25
		internal double c8976c8b1daad5ab3a62db38781db0164;

		// Token: 0x0400001A RID: 26
		[CompilerGenerated]
		private double cc480a5c808051c699364a821bf8cc314;

		// Token: 0x0400001B RID: 27
		[CompilerGenerated]
		private BotTypes c0425b2249a00a072c3294192bc80f538;
	}
}
