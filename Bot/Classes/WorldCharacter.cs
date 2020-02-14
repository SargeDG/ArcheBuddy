using System;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004E0 RID: 1248
	public class WorldCharacter : BaseObject
	{
		// Token: 0x0600153B RID: 5435 RVA: 0x000B9408 File Offset: 0x000B7608
		internal WorldCharacter(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			c1d20d531d7b2202220d5963ab8d205fd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000B9430 File Offset: 0x000B7630
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x000B9444 File Offset: 0x000B7644
		public uint uniqId
		{
			get;
			internal set;
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000B9458 File Offset: 0x000B7658
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x000B946C File Offset: 0x000B766C
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000B9480 File Offset: 0x000B7680
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x000B9494 File Offset: 0x000B7694
		public byte worldId
		{
			get;
			internal set;
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x000B94A8 File Offset: 0x000B76A8
		// (set) Token: 0x06001543 RID: 5443 RVA: 0x000B94BC File Offset: 0x000B76BC
		public CharRace race
		{
			get;
			internal set;
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x000B94D0 File Offset: 0x000B76D0
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x000B94E4 File Offset: 0x000B76E4
		public CharGender gender
		{
			get;
			internal set;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x000B94F8 File Offset: 0x000B76F8
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x000B950C File Offset: 0x000B770C
		public ulong deleteDelay
		{
			get;
			internal set;
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x000B9520 File Offset: 0x000B7720
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x000B9534 File Offset: 0x000B7734
		public ulong deleteRequestedTime
		{
			get;
			internal set;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000B9548 File Offset: 0x000B7748
		public bool EnterGame()
		{
			try
			{
				bool result;
				if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.get_c6132b87d3ee6952aced554ae8aeed8be() != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48492))
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
						RuntimeMethodHandle arg_2B_0 = methodof(WorldCharacter.EnterGame()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48496));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48500) != 0);
					return result;
				}
				if (ce993c23143c2ea71acbaf9a4ba3ea556.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) <= (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48504)))
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
					if (ce1c4722a18993df8d61ae6c23f89b1d9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) <= (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48508)))
					{
						ccae945613558c46627a5f81856c635fd ccae945613558c46627a5f81856c635fd = new ccae945613558c46627a5f81856c635fd(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c86f980a523a9f0a92c8941911a06db3c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48520), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48524));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(ccae945613558c46627a5f81856c635fd, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48528) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48532), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48536));
						return result;
					}
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48512));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48516) != 0);
				return result;
			}
			catch
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48540));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48544) != 0;
		}

		// Token: 0x04000F29 RID: 3881
		[CompilerGenerated]
		private uint c1f042b599e757f7d30e4be9756bd3cb4;

		// Token: 0x04000F2A RID: 3882
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000F2B RID: 3883
		[CompilerGenerated]
		private byte c269380ff6dba00a374c055e8f8de67e2;

		// Token: 0x04000F2C RID: 3884
		[CompilerGenerated]
		private CharRace c98a5aa19db7700c073d27ff9bf750914;

		// Token: 0x04000F2D RID: 3885
		[CompilerGenerated]
		private CharGender c1c23b482d095e7f28b3fae963929dda3;

		// Token: 0x04000F2E RID: 3886
		[CompilerGenerated]
		private ulong c5a4c924936e8660126fb953ccca37cf1;

		// Token: 0x04000F2F RID: 3887
		[CompilerGenerated]
		private ulong c66db11760bcbbbc16857ea592e42bc22;
	}
}
