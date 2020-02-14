using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004C1 RID: 1217
	public class AuctionItem : BaseObject
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x000A3D98 File Offset: 0x000A1F98
		internal AuctionItem(CoreInternal coreInternal)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39836));
			c387eb75b2ed94781c03054094d7a37b0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Item(coreInternal));
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(AuctionItem.Dispose(bool)).MethodHandle;
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
						if (ce18eb428e08099dd3db41a57d0de2ac9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(ce18eb428e08099dd3db41a57d0de2ac9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							c387eb75b2ed94781c03054094d7a37b0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83);
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

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x000A3E5C File Offset: 0x000A205C
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x000A3E70 File Offset: 0x000A2070
		public byte worldId
		{
			get;
			internal set;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000A3E84 File Offset: 0x000A2084
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x000A3E98 File Offset: 0x000A2098
		public ulong uniqId
		{
			get;
			internal set;
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x000A3EAC File Offset: 0x000A20AC
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x000A3EC0 File Offset: 0x000A20C0
		public Item item
		{
			get;
			internal set;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000A3ED4 File Offset: 0x000A20D4
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x000A3EE8 File Offset: 0x000A20E8
		internal byte timeTypeInternal
		{
			get;
			set;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x000A3EFC File Offset: 0x000A20FC
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x000A3F10 File Offset: 0x000A2110
		public AuctionSellTime timeType
		{
			get;
			internal set;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x000A3F24 File Offset: 0x000A2124
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x000A3F38 File Offset: 0x000A2138
		public string sellerName
		{
			get;
			internal set;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000A3F4C File Offset: 0x000A214C
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x000A3F60 File Offset: 0x000A2160
		public int sellPrice
		{
			get;
			internal set;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x000A3F74 File Offset: 0x000A2174
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x000A3F88 File Offset: 0x000A2188
		public int buyBackPrice
		{
			get;
			internal set;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x000A3F9C File Offset: 0x000A219C
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x000A3FB0 File Offset: 0x000A21B0
		public ulong time
		{
			get;
			internal set;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x000A3FC4 File Offset: 0x000A21C4
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x000A3FD8 File Offset: 0x000A21D8
		internal ulong askedTime
		{
			get;
			set;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000A3FEC File Offset: 0x000A21EC
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x000A4000 File Offset: 0x000A2200
		public string bidderName
		{
			get;
			internal set;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x000A4014 File Offset: 0x000A2214
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x000A4028 File Offset: 0x000A2228
		public int bidMoney
		{
			get;
			internal set;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x000A403C File Offset: 0x000A223C
		public bool MakeAuctionBid(int bet)
		{
			try
			{
				bool result;
				if (bet <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39584))
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
						RuntimeMethodHandle arg_1F_0 = methodof(AuctionItem.MakeAuctionBid(int)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39588));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39592) != 0);
					return result;
				}
				if (bet <= ca7441a6b3150d2a2ec0bd3a4b6aec3f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39596));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39600) != 0);
					return result;
				}
				if (cc2c04721dda2c4464af05e937b98cb8f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39604))
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
					if (bet <= cc2c04721dda2c4464af05e937b98cb8f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39608));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39612) != 0);
						return result;
					}
				}
				if (c8527a3291b42cd32183dfaa5c2f58b5f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39616))
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
					if (bet > c8527a3291b42cd32183dfaa5c2f58b5f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
						bet = c8527a3291b42cd32183dfaa5c2f58b5f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
					}
				}
				if (this.c33afa5997d4663112d40b3c7f8a760af == c9c772137bafe8ff99dbd90ebc261f23c.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39620));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39624) != 0);
					return result;
				}
				uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39628);
				if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39632))
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
					if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39636))
					{
						goto IL_393;
					}
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
				}
				if (!this.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3())
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
					Creature creature = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
					double num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39640);
					List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39648); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39652))
					{
						if (cdd801fc7821415c99b25805be8750c0a.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i))))
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
							if (num2 > c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
								num2 = c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i));
								creature = cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i);
							}
						}
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
					if (creature == null)
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39656));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39660) != 0);
						return result;
					}
					if (c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), creature) > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39664))
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
						if (!this.ca124a9f406cda69b904f2eb04d553ab9.c80d205e01c504d154a7b60400b29b347(c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(creature), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(creature), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(creature), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39672), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39680), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39688) != 0))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39692));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39696) != 0);
							return result;
						}
					}
					num = c9c772137bafe8ff99dbd90ebc261f23c.c30767ddca1f9c207888833aea5b5fc61(creature);
				}
				IL_393:
				cbafaa1d4e6c3d7b5c96995eab11b1e82 cbafaa1d4e6c3d7b5c96995eab11b1e = new cbafaa1d4e6c3d7b5c96995eab11b1e82(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, num, this, bet);
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39700), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39704));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cbafaa1d4e6c3d7b5c96995eab11b1e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39708) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39712), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39716));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39720));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39724) != 0;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000A44A0 File Offset: 0x000A26A0
		public bool CancelAuctionLot()
		{
			try
			{
				bool result;
				if (this.c33afa5997d4663112d40b3c7f8a760af != c9c772137bafe8ff99dbd90ebc261f23c.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
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
						RuntimeMethodHandle arg_2E_0 = methodof(AuctionItem.CancelAuctionLot()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39728));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39732) != 0);
					return result;
				}
				uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39736);
				if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39740))
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
					if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39744))
					{
						goto IL_283;
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
				}
				if (!this.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3())
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
					Creature creature = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
					double num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39748);
					List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39756); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39760))
					{
						if (cdd801fc7821415c99b25805be8750c0a.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i))))
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
							if (num2 > c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
								num2 = c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i));
								creature = cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i);
							}
						}
					}
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					if (creature == null)
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39764));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39768) != 0);
						return result;
					}
					if (c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), creature) > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39772))
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
						if (!this.ca124a9f406cda69b904f2eb04d553ab9.c80d205e01c504d154a7b60400b29b347(c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(creature), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(creature), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(creature), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39780), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39788), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39796) != 0))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39800));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39804) != 0);
							return result;
						}
					}
					num = c9c772137bafe8ff99dbd90ebc261f23c.c30767ddca1f9c207888833aea5b5fc61(creature);
				}
				IL_283:
				c2de57c0732caab50bb91942b5d918063 c2de57c0732caab50bb91942b5d = new c2de57c0732caab50bb91942b5d918063(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, num, this);
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39808), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39812));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c2de57c0732caab50bb91942b5d, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39816) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39820), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39824));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39828));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39832) != 0;
		}

		// Token: 0x04000DB6 RID: 3510
		internal uint c33afa5997d4663112d40b3c7f8a760af;

		// Token: 0x04000DB7 RID: 3511
		internal byte c13faea8eacde66a36b3be4b2e63512f9;

		// Token: 0x04000DB8 RID: 3512
		internal int c1153f895e6ddd0ec12a74915b9ae6054;

		// Token: 0x04000DB9 RID: 3513
		internal uint c6eae09e6226cadf637eacf6db4a1acd9;

		// Token: 0x04000DBA RID: 3514
		internal uint c98757efa57f6f494b2a2a30b7402d26f;

		// Token: 0x04000DBB RID: 3515
		[CompilerGenerated]
		private byte c269380ff6dba00a374c055e8f8de67e2;

		// Token: 0x04000DBC RID: 3516
		[CompilerGenerated]
		private ulong c1f042b599e757f7d30e4be9756bd3cb4;

		// Token: 0x04000DBD RID: 3517
		[CompilerGenerated]
		private Item c2cf978f090052177d0b89a4cbcb61685;

		// Token: 0x04000DBE RID: 3518
		[CompilerGenerated]
		private byte c1727515546bddfc4bf8c00f7fc4c9d33;

		// Token: 0x04000DBF RID: 3519
		[CompilerGenerated]
		private AuctionSellTime c418f8f20c688bbc10b87c5f58089a669;

		// Token: 0x04000DC0 RID: 3520
		[CompilerGenerated]
		private string c66847a42e5450d86f6e6c5983f125ed3;

		// Token: 0x04000DC1 RID: 3521
		[CompilerGenerated]
		private int cc1bf69c8ffa5dd35199523e1a1c27a95;

		// Token: 0x04000DC2 RID: 3522
		[CompilerGenerated]
		private int c5d026fee5182f33c3cc313c679816903;

		// Token: 0x04000DC3 RID: 3523
		[CompilerGenerated]
		private ulong cc7eab308bb41a3bbfa402203e17b418d;

		// Token: 0x04000DC4 RID: 3524
		[CompilerGenerated]
		private ulong c9f606a736ab074a684ba7aedeb5483b9;

		// Token: 0x04000DC5 RID: 3525
		[CompilerGenerated]
		private string cabd7bc44991faee17320df61e4829751;

		// Token: 0x04000DC6 RID: 3526
		[CompilerGenerated]
		private int c6145fb4a17f8f97e0c119295966464c6;
	}
}
