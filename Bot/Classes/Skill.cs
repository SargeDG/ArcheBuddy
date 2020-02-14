using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004B7 RID: 1207
	public class Skill : Effect
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x000A2998 File Offset: 0x000A0B98
		internal Skill(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39460));
			c94cee31ba2339d664e8fa75771b0843e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39464));
			c8052d8fa1ffc041334dae2cf04071e12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39468) != 0);
			this.c84c98da26e9a7d4caaef889396b07caf = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39472) != 0);
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x000A29F4 File Offset: 0x000A0BF4
		internal void c4aaf7619a600d569451f27c0b2b78918()
		{
			c366c6a81db1686d6763c14461855ccde.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc8e8d76b9ed2573ec35ab88ac344b2f8.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (c8ad9d9060d683c7a1500f3f46770cad2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39432))
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
					RuntimeMethodHandle arg_33_0 = methodof(Skill.c4aaf7619a600d569451f27c0b2b78918()).MethodHandle;
				}
				try
				{
					if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8ad9d9060d683c7a1500f3f46770cad2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						c366c6a81db1686d6763c14461855ccde.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8ad9d9060d683c7a1500f3f46770cad2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x000A2AA4 File Offset: 0x000A0CA4
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
						RuntimeMethodHandle arg_1A_0 = methodof(Skill.Dispose(bool)).MethodHandle;
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
						c366c6a81db1686d6763c14461855ccde.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4e0314a28ad20bf05090a7b9d90a1ec9.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x000A2B10 File Offset: 0x000A0D10
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x000A2B24 File Offset: 0x000A0D24
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x000A2B38 File Offset: 0x000A0D38
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x000A2B4C File Offset: 0x000A0D4C
		public int skillBookCategoryId
		{
			get;
			internal set;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x000A2B60 File Offset: 0x000A0D60
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x000A2B74 File Offset: 0x000A0D74
		public byte level
		{
			get;
			internal set;
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x000A2B88 File Offset: 0x000A0D88
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x000A2B9C File Offset: 0x000A0D9C
		public SqlSkill db
		{
			get;
			internal set;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000A2BB0 File Offset: 0x000A0DB0
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x000A2BC4 File Offset: 0x000A0DC4
		internal bool learned
		{
			get;
			set;
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000A2BD8 File Offset: 0x000A0DD8
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x000A2BEC File Offset: 0x000A0DEC
		internal bool isBattleGroundSkill
		{
			get;
			set;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000A2C00 File Offset: 0x000A0E00
		public string name
		{
			get
			{
				if (c47cb93bc7d2bbf0ebb2f14df36fc7e95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Skill.get_name()).MethodHandle;
					}
					return "";
				}
				return c03fe19dbb520ec1257bb4051bcd04aeb.c30767ddca1f9c207888833aea5b5fc61(c47cb93bc7d2bbf0ebb2f14df36fc7e95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x000A2C40 File Offset: 0x000A0E40
		public string desc
		{
			get
			{
				if (c47cb93bc7d2bbf0ebb2f14df36fc7e95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Skill.get_desc()).MethodHandle;
					}
					return "";
				}
				return c8b1c2d38b06ee5a2f2299a240afe74eb.c30767ddca1f9c207888833aea5b5fc61(c47cb93bc7d2bbf0ebb2f14df36fc7e95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000A2C80 File Offset: 0x000A0E80
		public bool AddToActionPanel(uint cellNum)
		{
			if (cellNum != 0u)
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
					RuntimeMethodHandle arg_15_0 = methodof(Skill.AddToActionPanel(uint)).MethodHandle;
				}
				if (cellNum <= (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39436))
				{
					c172b4d4ed0f35d37a974971a13e5aa99 c172b4d4ed0f35d37a974971a13e5aa = new c172b4d4ed0f35d37a974971a13e5aa99(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (byte)cellNum, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39448), (ulong)c4e5798155f7a355098632ea8907b4289.c30767ddca1f9c207888833aea5b5fc61(c47cb93bc7d2bbf0ebb2f14df36fc7e95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c172b4d4ed0f35d37a974971a13e5aa, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39452) != 0);
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39456) != 0;
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
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39440));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39444) != 0;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000A2D28 File Offset: 0x000A0F28
		public bool UseSkill(bool autoCome = false, bool selfTarget = false)
		{
			return this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
			{
				cbe5fb745fb9d18c1a122f67582a2fc76 = c8ad9d9060d683c7a1500f3f46770cad2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this),
				cb6b52efde3ab22e0b644905e40f0efbc = autoCome,
				c2a5b19e90236f2d1186742950805e303 = selfTarget
			});
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000A2D68 File Offset: 0x000A0F68
		public bool UseSkill(int mpCost, bool autoCome = false, bool selfTarget = false)
		{
			return this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
			{
				cbe5fb745fb9d18c1a122f67582a2fc76 = c8ad9d9060d683c7a1500f3f46770cad2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this),
				cb6b52efde3ab22e0b644905e40f0efbc = autoCome,
				c2a5b19e90236f2d1186742950805e303 = selfTarget,
				c91c55a4a1e3f353b30fc28b3501926a2 = mpCost
			});
		}

		// Token: 0x04000D7F RID: 3455
		internal bool c84c98da26e9a7d4caaef889396b07caf;

		// Token: 0x04000D80 RID: 3456
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000D81 RID: 3457
		[CompilerGenerated]
		private int c5435a97d6f80154b0ba0b5d0165b5991;

		// Token: 0x04000D82 RID: 3458
		[CompilerGenerated]
		private byte cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x04000D83 RID: 3459
		[CompilerGenerated]
		private SqlSkill cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x04000D84 RID: 3460
		[CompilerGenerated]
		private bool cf8eaccfee5a06ac1672bd59c1097f70b;

		// Token: 0x04000D85 RID: 3461
		[CompilerGenerated]
		private bool c4e22f34765a88c04069a031342e20cb1;
	}
}
