using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004D3 RID: 1235
	public class Actability : BaseObject
	{
		// Token: 0x06001483 RID: 5251 RVA: 0x000B6368 File Offset: 0x000B4568
		internal Actability(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47692));
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x000B6394 File Offset: 0x000B4594
		// (set) Token: 0x06001485 RID: 5253 RVA: 0x000B63A8 File Offset: 0x000B45A8
		public SqlActabilityGroup db
		{
			get;
			internal set;
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000B63BC File Offset: 0x000B45BC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Actability.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						cee72f66c463ed6062ca51b782999a969.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c6e606a80e2e64185aa5c1402f78a1928.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x000B6428 File Offset: 0x000B4628
		public string name
		{
			get
			{
				if (c883a6eaa2939010f336278c7f3fa9e50.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Actability.get_name()).MethodHandle;
					}
					return cc20ac998c469b5d47731b46b9bf229d6.c30767ddca1f9c207888833aea5b5fc61(c883a6eaa2939010f336278c7f3fa9e50.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return "";
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x000B6468 File Offset: 0x000B4668
		// (set) Token: 0x06001489 RID: 5257 RVA: 0x000B647C File Offset: 0x000B467C
		public byte level
		{
			get;
			internal set;
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x000B6490 File Offset: 0x000B4690
		// (set) Token: 0x0600148B RID: 5259 RVA: 0x000B64A4 File Offset: 0x000B46A4
		public int points
		{
			get;
			internal set;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x000B64B8 File Offset: 0x000B46B8
		public bool IncreaseLevel()
		{
			try
			{
				SqlExpertLimit sqlExpertLimit = cdca37e99e16d605c4f2e3085b40e550b.c8a754f5f2ca4adde825691a9c31a0e83;
				if (cf029236eb849e390e675c8d4c56483fc.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						RuntimeMethodHandle arg_3D_0 = methodof(Actability.IncreaseLevel()).MethodHandle;
					}
					sqlExpertLimit = c56d1c5b42a29849df77fb353ab2c1b30.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				SqlExpertLimit sqlExpertLimit2 = cdca37e99e16d605c4f2e3085b40e550b.c8a754f5f2ca4adde825691a9c31a0e83;
				if (cf029236eb849e390e675c8d4c56483fc.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)((int)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47580))))
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
					sqlExpertLimit2 = c56d1c5b42a29849df77fb353ab2c1b30.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)((int)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47584)));
				}
				bool result;
				if (sqlExpertLimit != null)
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
					if (sqlExpertLimit2 == null)
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
					}
					else
					{
						if (!ca75719424c660378a6f403f9fdf178ab.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit2))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47596));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47600) != 0);
							return result;
						}
						if (c46bc942d82c871260c595f545ca02b21.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) < cb8eb717d9cc5dfda6d23fa615e2a21da.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47604));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47608) != 0);
							return result;
						}
						c195847fb70111a04e3b477f160da0f3b c195847fb70111a04e3b477f160da0f3b = new c195847fb70111a04e3b477f160da0f3b(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47612), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47616));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c195847fb70111a04e3b477f160da0f3b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47620) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47624), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47628));
						return result;
					}
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47588));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47592) != 0);
				return result;
			}
			catch (Exception)
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47632));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47636) != 0;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x000B6700 File Offset: 0x000B4900
		public bool ReduceLevel()
		{
			try
			{
				bool result;
				if (ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == 0)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Actability.ReduceLevel()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47640));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47644) != 0);
					return result;
				}
				SqlExpertLimit sqlExpertLimit = cdca37e99e16d605c4f2e3085b40e550b.c8a754f5f2ca4adde825691a9c31a0e83;
				if (cf029236eb849e390e675c8d4c56483fc.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
					sqlExpertLimit = c56d1c5b42a29849df77fb353ab2c1b30.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				SqlExpertLimit sqlExpertLimit2 = cdca37e99e16d605c4f2e3085b40e550b.c8a754f5f2ca4adde825691a9c31a0e83;
				if (cf029236eb849e390e675c8d4c56483fc.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)((int)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47648))))
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
					sqlExpertLimit2 = c56d1c5b42a29849df77fb353ab2c1b30.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)((int)ccd7297aa5886d056211bdbbd520f4fc0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47652)));
				}
				if (sqlExpertLimit != null)
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
					if (sqlExpertLimit2 != null)
					{
						c047a0a17c70d0ced088c4d031127714b c047a0a17c70d0ced088c4d031127714b = new c047a0a17c70d0ced088c4d031127714b(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47664), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47668));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c047a0a17c70d0ced088c4d031127714b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47672) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47676), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47680));
						return result;
					}
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47656));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47660) != 0);
				return result;
			}
			catch (Exception)
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47684));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47688) != 0;
		}

		// Token: 0x04000ED6 RID: 3798
		internal uint cb5905b594e11dea2f73932df05981674;

		// Token: 0x04000ED7 RID: 3799
		[CompilerGenerated]
		private SqlActabilityGroup cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x04000ED8 RID: 3800
		[CompilerGenerated]
		private byte cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x04000ED9 RID: 3801
		[CompilerGenerated]
		private int c7f041dfd1071d836ea7721e1669ed231;
	}
}
