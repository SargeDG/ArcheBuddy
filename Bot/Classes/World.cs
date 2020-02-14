using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004DF RID: 1247
	public class World : BaseObject
	{
		// Token: 0x0600152B RID: 5419 RVA: 0x000B9094 File Offset: 0x000B7294
		internal World(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			c1a7725809de3f80481ba0fbfb1152175.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c63891d6a97a56fee538b1c7070308cba.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48488)));
			c774542031f5fcc785d35e6eb8e0ec72d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<WorldCharacter>());
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x000B90DC File Offset: 0x000B72DC
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x000B90F0 File Offset: 0x000B72F0
		public byte id
		{
			get;
			internal set;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x000B9104 File Offset: 0x000B7304
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x000B9118 File Offset: 0x000B7318
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x000B912C File Offset: 0x000B732C
		// (set) Token: 0x06001531 RID: 5425 RVA: 0x000B9140 File Offset: 0x000B7340
		public bool isEnabled
		{
			get;
			internal set;
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x000B9154 File Offset: 0x000B7354
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x000B9168 File Offset: 0x000B7368
		public byte[] raceCreation
		{
			get;
			internal set;
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x000B917C File Offset: 0x000B737C
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x000B9190 File Offset: 0x000B7390
		internal List<WorldCharacter> characters
		{
			get;
			set;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000B91A4 File Offset: 0x000B73A4
		public List<WorldCharacter> getCharacters()
		{
			List<WorldCharacter> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c77af76a9970e6eeec88950ef3773208a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
				result = c77af76a9970e6eeec88950ef3773208a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).ToList<WorldCharacter>();
			}
			return result;
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000B91F4 File Offset: 0x000B73F4
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x000B9208 File Offset: 0x000B7408
		public byte load
		{
			get;
			internal set;
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x000B921C File Offset: 0x000B741C
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
						RuntimeMethodHandle arg_1D_0 = methodof(World.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48436); i < c19bf433a42a46d0be4d0263f06a4fec0.c30767ddca1f9c207888833aea5b5fc61(c77af76a9970e6eeec88950ef3773208a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48440))
						{
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c8798c3a2d44d1b0ad263abde7fb8371c.c30767ddca1f9c207888833aea5b5fc61(c77af76a9970e6eeec88950ef3773208a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i));
							ccf0bc10cc23888fab19585e24c4e34c8.c30767ddca1f9c207888833aea5b5fc61(c77af76a9970e6eeec88950ef3773208a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), i, c6e3e5c2c5e319981d9af1797da037610.c8a754f5f2ca4adde825691a9c31a0e83);
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
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000B92DC File Offset: 0x000B74DC
		public bool EnterGameServer()
		{
			try
			{
				bool result;
				if (!c7d195943cffcee82cc622d0dda7a5baa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
				{
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48472));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48476) != 0);
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
				if (!true)
				{
					RuntimeMethodHandle arg_1F_0 = methodof(World.EnterGameServer()).MethodHandle;
				}
				if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.get_c6132b87d3ee6952aced554ae8aeed8be() != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48444))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48448));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48452) != 0);
					return result;
				}
				byte[] expr_79 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48456));
				c21512aadbc438e0c34236fbd1c52da3b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_79, fieldof(cecebbe15a82731eb2f8453f1b7665d70.cb404e0ed66066002836fb8ae1c4d0e5a).FieldHandle);
				byte[] array = expr_79;
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48460)] = cc512b8e464b05cc58e78b1d017e50ae9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				byte[] array2 = array;
				ca081a66cee3bf2dcb0f3ee208852b645.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.c788468c0f1361a00c09677914a79d73b, array2);
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48464));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48468) != 0);
				return result;
			}
			catch
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48480));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48484) != 0;
		}

		// Token: 0x04000F23 RID: 3875
		[CompilerGenerated]
		private byte c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000F24 RID: 3876
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000F25 RID: 3877
		[CompilerGenerated]
		private bool cc5b3383b91c3f7511bc1db5cd989a481;

		// Token: 0x04000F26 RID: 3878
		[CompilerGenerated]
		private byte[] caae100a2d6f9a3abd165bfa6e722698a;

		// Token: 0x04000F27 RID: 3879
		[CompilerGenerated]
		private List<WorldCharacter> ce58ae154f15b4dfa3a32c6f754ce2e69;

		// Token: 0x04000F28 RID: 3880
		[CompilerGenerated]
		private byte cb15a561459abcd535a45d2f2e0e8b2eb;
	}
}
