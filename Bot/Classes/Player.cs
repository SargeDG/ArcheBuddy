using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004CF RID: 1231
	public class Player : Creature
	{
		// Token: 0x06001406 RID: 5126 RVA: 0x000B4A28 File Offset: 0x000B2C28
		internal Player(CoreInternal coreInternal) : base(coreInternal)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			this.set_c05ebd1bb5f7a79e49cc11ffb772f8dea(c8885b18ae9dda3c44f2163ce62626034.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47380)));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47384); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47392); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47388))
			{
				this.get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[i] = new Abilities();
			}
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
				RuntimeMethodHandle arg_6D_0 = methodof(Player..ctor(CoreInternal)).MethodHandle;
			}
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47396));
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000B4AB4 File Offset: 0x000B2CB4
		internal int cae0c176f7eac0b48a506b3abdb7830ad(byte[] array)
		{
			int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47352);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47356); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47364); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47360))
			{
				if (cf571782289635c1521477ae7181fa55e.c30767ddca1f9c207888833aea5b5fc61(this.c62eddc2978dfd76cb081363610dd3fc1[i]))
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
						RuntimeMethodHandle arg_3B_0 = methodof(Player.cae0c176f7eac0b48a506b3abdb7830ad(byte[])).MethodHandle;
					}
					num += (int)array[i];
				}
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				break;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47368) - num;
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x000B4B34 File Offset: 0x000B2D34
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x000B4B48 File Offset: 0x000B2D48
		public bool pkMode
		{
			get;
			internal set;
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000B4B5C File Offset: 0x000B2D5C
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x000B4B70 File Offset: 0x000B2D70
		public bool isAfk
		{
			get;
			internal set;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x000B4B84 File Offset: 0x000B2D84
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x000B4B98 File Offset: 0x000B2D98
		public bool isPartyMember
		{
			get;
			internal set;
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x000B4BAC File Offset: 0x000B2DAC
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x000B4BC0 File Offset: 0x000B2DC0
		public string title
		{
			get;
			internal set;
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x000B4BD4 File Offset: 0x000B2DD4
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(Player.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c62eddc2978dfd76cb081363610dd3fc1))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47372); i < (int)ceea22faf0723072c0f14025fedb11d51.cc0906fa561b9c6076f6cb6643cecb5e3(this.c62eddc2978dfd76cb081363610dd3fc1); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47376))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(this.c62eddc2978dfd76cb081363610dd3fc1[i]);
								this.c62eddc2978dfd76cb081363610dd3fc1[i] = null;
							}
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							this.c62eddc2978dfd76cb081363610dd3fc1 = ca8ae0000d5dc5e59e1603c53d18165fa.c8a754f5f2ca4adde825691a9c31a0e83;
						}
					}
					c064406586f024f64cd7a842e6df41011.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x000B4CB8 File Offset: 0x000B2EB8
		public List<Abilities> getAbilities()
		{
			List<Abilities> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c62eddc2978dfd76cb081363610dd3fc1))
			{
				result = this.c62eddc2978dfd76cb081363610dd3fc1.ToList<Abilities>();
			}
			return result;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x000B4D04 File Offset: 0x000B2F04
		internal Abilities[] get_c05ebd1bb5f7a79e49cc11ffb772f8dea()
		{
			return this.c62eddc2978dfd76cb081363610dd3fc1;
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x000B4D18 File Offset: 0x000B2F18
		internal void set_c05ebd1bb5f7a79e49cc11ffb772f8dea(Abilities[] array)
		{
			this.c62eddc2978dfd76cb081363610dd3fc1 = array;
		}

		// Token: 0x04000E8F RID: 3727
		private Abilities[] c62eddc2978dfd76cb081363610dd3fc1;

		// Token: 0x04000E90 RID: 3728
		internal uint ca3e764e142ba0b187040da3d0813be4e;

		// Token: 0x04000E91 RID: 3729
		[CompilerGenerated]
		private bool c4a07211cc9850dc9603056965ccbe35b;

		// Token: 0x04000E92 RID: 3730
		[CompilerGenerated]
		private bool c29e0a5f2c372aa749db7ad0a04697eb1;

		// Token: 0x04000E93 RID: 3731
		[CompilerGenerated]
		private bool c6d27476b4367d86fc8218e279c910a8b;

		// Token: 0x04000E94 RID: 3732
		[CompilerGenerated]
		private string c49f7729bf7992fd4eb7e41612d3817b5;
	}
}
