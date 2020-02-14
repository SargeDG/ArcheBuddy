using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004C2 RID: 1218
	public class Item : BaseObject
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x000A47F4 File Offset: 0x000A29F4
		internal Item(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44412));
			c4799c8862cb462ff4f4d925687cd61b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ItemPlace)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44416));
			cdecbb78a2b2cb68f1f0df7f7c05453bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ItemGrade)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44420));
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			c545cc5095bd0c4312f17f7998bbbc567.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(44424));
			c1b36d6feab367ba212a4f110dbc6ebc8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(44432));
			cba2e7e431288928da06f6d43c89f336c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(44440));
			c915a5e11fc3dbaeb434d2e54e2b5f9f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(44448));
			ca45edddd042402edeedc5df743b5e686.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(44456));
			cf7a3f9e1ee09627a14bbd8bd78b20259.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44464));
			c24fe6ec9ce169edf3ff46f9946764288.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<uint>());
			ca949c16fcd713bd9afc66344e08dc726.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<uint>());
			c7544e2876fdb4fefb6d57c39cf2bf611.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44468));
			this.c95fcf4e5a5d90a94bd0a5cc677860a82 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44472));
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000A48E8 File Offset: 0x000A2AE8
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
						RuntimeMethodHandle arg_1A_0 = methodof(Item.Dispose(bool)).MethodHandle;
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
						cc75ce56813e6a7df59a894dc6460bf22.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c59d6ab4df9881dfe71682c58bee604a9.c8a754f5f2ca4adde825691a9c31a0e83);
						if (cd503892e6ceb9c7133e781ce245626e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
							c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cd503892e6ceb9c7133e781ce245626e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							c1fbef82ae32d23f2c32b82649424305f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c26827f1c8dcb9a2ae635a582593c882e.c8a754f5f2ca4adde825691a9c31a0e83);
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

		// Token: 0x06001229 RID: 4649 RVA: 0x000A4980 File Offset: 0x000A2B80
		internal void c4aaf7619a600d569451f27c0b2b78918()
		{
			cc75ce56813e6a7df59a894dc6460bf22.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c619afe9b8a528fd33b35d82ca93ca415.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (cd729ec847ff80bc33029eca3bd963a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39840))
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
					RuntimeMethodHandle arg_36_0 = methodof(Item.c4aaf7619a600d569451f27c0b2b78918()).MethodHandle;
				}
				try
				{
					if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd729ec847ff80bc33029eca3bd963a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						cc75ce56813e6a7df59a894dc6460bf22.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd729ec847ff80bc33029eca3bd963a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						if (cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39844))
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
							if (c16aea759f1a27989c3d5013363031f65.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != null)
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
								c1fbef82ae32d23f2c32b82649424305f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c7eab392e9e3cb93407f1fb799e66bdb8.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
								c9b15ea1df0c0a16b5b3ef032b94a295e.c30767ddca1f9c207888833aea5b5fc61(cd503892e6ceb9c7133e781ce245626e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c602a73ff0ff79bab162c670bf16dfeb1.c30767ddca1f9c207888833aea5b5fc61(c16aea759f1a27989c3d5013363031f65.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
								ccf7d4fbe6d2a79a5894244800b2c25c5.c30767ddca1f9c207888833aea5b5fc61(cd503892e6ceb9c7133e781ce245626e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c8d5c2e1c60e7ab3dd311aae8777d2b47.c30767ddca1f9c207888833aea5b5fc61(c16aea759f1a27989c3d5013363031f65.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
								for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39848); i < c7ee08e997a7c27879ad5c4342a71fa10.c30767ddca1f9c207888833aea5b5fc61(c7e97cb3356537956eee053ca060db2f6.c30767ddca1f9c207888833aea5b5fc61(c16aea759f1a27989c3d5013363031f65.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39852))
								{
									ArmorSetItem armorSetItem = c4c5929c3bcdf11e0198f1ca48da0af36.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									cc3240babe9ac410483e24653ff353d41.c30767ddca1f9c207888833aea5b5fc61(armorSetItem, cb3a6afc9e523a62c6a2d8819cfb30ed4.c30767ddca1f9c207888833aea5b5fc61(cadbeccdb8c6d3d32930010228e117d4c.c30767ddca1f9c207888833aea5b5fc61(c7e97cb3356537956eee053ca060db2f6.c30767ddca1f9c207888833aea5b5fc61(c16aea759f1a27989c3d5013363031f65.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), i)));
									c1931049f7a974126fcdc5ab5599ce754.c30767ddca1f9c207888833aea5b5fc61(armorSetItem, c56978532265d3fc3778bd619810176d7.c30767ddca1f9c207888833aea5b5fc61(cadbeccdb8c6d3d32930010228e117d4c.c30767ddca1f9c207888833aea5b5fc61(c7e97cb3356537956eee053ca060db2f6.c30767ddca1f9c207888833aea5b5fc61(c16aea759f1a27989c3d5013363031f65.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), i)));
									c80527ac5040d359ef79995302b18eadb.c30767ddca1f9c207888833aea5b5fc61(cf0d9d9d1a89f66154c75473a599456c8.c30767ddca1f9c207888833aea5b5fc61(cd503892e6ceb9c7133e781ce245626e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), armorSetItem);
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
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600122A RID: 4650 RVA: 0x000A4B98 File Offset: 0x000A2D98
		// (set) Token: 0x0600122B RID: 4651 RVA: 0x000A4BAC File Offset: 0x000A2DAC
		public long lastUseTime
		{
			get;
			internal set;
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600122C RID: 4652 RVA: 0x000A4BC0 File Offset: 0x000A2DC0
		// (set) Token: 0x0600122D RID: 4653 RVA: 0x000A4BD4 File Offset: 0x000A2DD4
		public ushort durability
		{
			get;
			internal set;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x000A4BE8 File Offset: 0x000A2DE8
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x000A4BFC File Offset: 0x000A2DFC
		public double pAttackPower
		{
			get;
			internal set;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x000A4C10 File Offset: 0x000A2E10
		// (set) Token: 0x06001231 RID: 4657 RVA: 0x000A4C24 File Offset: 0x000A2E24
		public double mAttackPower
		{
			get;
			internal set;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x000A4C38 File Offset: 0x000A2E38
		// (set) Token: 0x06001233 RID: 4659 RVA: 0x000A4C4C File Offset: 0x000A2E4C
		public double mDef
		{
			get;
			internal set;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x000A4C60 File Offset: 0x000A2E60
		// (set) Token: 0x06001235 RID: 4661 RVA: 0x000A4C74 File Offset: 0x000A2E74
		public double pDef
		{
			get;
			internal set;
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x000A4C88 File Offset: 0x000A2E88
		public string name
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_name()).MethodHandle;
					}
					return "";
				}
				return c56978532265d3fc3778bd619810176d7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x000A4CC8 File Offset: 0x000A2EC8
		public ArmorType armorType
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
					if (!true)
					{
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_armorType()).MethodHandle;
					}
					return (ArmorType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39856);
				}
				return (ArmorType)c7526a8d5977cf37d52ab10b022a9296e.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000A4D10 File Offset: 0x000A2F10
		public WeaponType weaponType
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_weaponType()).MethodHandle;
					}
					return (WeaponType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39860);
				}
				return (WeaponType)cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000A4D58 File Offset: 0x000A2F58
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x000A4D6C File Offset: 0x000A2F6C
		public double mapX
		{
			get;
			internal set;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000A4D80 File Offset: 0x000A2F80
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x000A4D94 File Offset: 0x000A2F94
		public double mapY
		{
			get;
			internal set;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x000A4DBC File Offset: 0x000A2FBC
		public float mapZ
		{
			get;
			internal set;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000A4DD0 File Offset: 0x000A2FD0
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x000A4DE4 File Offset: 0x000A2FE4
		public bool mountAlive
		{
			get;
			internal set;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000A4DF8 File Offset: 0x000A2FF8
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x000A4E0C File Offset: 0x000A300C
		public byte mountLevel
		{
			get;
			internal set;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x000A4E20 File Offset: 0x000A3020
		public int price
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_price()).MethodHandle;
					}
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39864);
				}
				return c5651a1fb179c934be59444c33c46ca02.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000A4E64 File Offset: 0x000A3064
		public int reqLevel
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_reqLevel()).MethodHandle;
					}
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39868);
				}
				return ccd0385901c6a80512eb25fb00a1ec34d.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000A4EA8 File Offset: 0x000A30A8
		public int maxStackSize
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_maxStackSize()).MethodHandle;
					}
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39872);
				}
				return c9ae7090d3da364ca19dfcaf29e6e93eb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x000A4EEC File Offset: 0x000A30EC
		public int refund
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_refund()).MethodHandle;
					}
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39876);
				}
				return cb08bd88877f002b868e84df694abadf5.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x000A4F30 File Offset: 0x000A3130
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x000A4F44 File Offset: 0x000A3144
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000A4F58 File Offset: 0x000A3158
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x000A4F6C File Offset: 0x000A316C
		public ItemGrade grade
		{
			get;
			internal set;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000A4F80 File Offset: 0x000A3180
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x000A4F94 File Offset: 0x000A3194
		public List<uint> dyeItemIds
		{
			get;
			internal set;
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000A4FA8 File Offset: 0x000A31A8
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x000A4FBC File Offset: 0x000A31BC
		public List<uint> engravesItemIds
		{
			get;
			internal set;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x000A4FD0 File Offset: 0x000A31D0
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x000A4FE4 File Offset: 0x000A31E4
		public int count
		{
			get;
			internal set;
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000A4FF8 File Offset: 0x000A31F8
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x000A500C File Offset: 0x000A320C
		public ItemPlace place
		{
			get;
			internal set;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x000A5020 File Offset: 0x000A3220
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x000A5034 File Offset: 0x000A3234
		public byte cell
		{
			get;
			internal set;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x000A5048 File Offset: 0x000A3248
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x000A505C File Offset: 0x000A325C
		internal double statTotal
		{
			get;
			set;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000A5070 File Offset: 0x000A3270
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x000A5084 File Offset: 0x000A3284
		public double statStr
		{
			get;
			internal set;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000A5098 File Offset: 0x000A3298
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x000A50AC File Offset: 0x000A32AC
		public double statDex
		{
			get;
			internal set;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000A50C0 File Offset: 0x000A32C0
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x000A50D4 File Offset: 0x000A32D4
		public double statInt
		{
			get;
			internal set;
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000A50E8 File Offset: 0x000A32E8
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x000A50FC File Offset: 0x000A32FC
		public double statCon
		{
			get;
			internal set;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x000A5110 File Offset: 0x000A3310
		// (set) Token: 0x06001260 RID: 4704 RVA: 0x000A5124 File Offset: 0x000A3324
		public double statWit
		{
			get;
			internal set;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x000A5138 File Offset: 0x000A3338
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x000A514C File Offset: 0x000A334C
		public SqlItem db
		{
			get;
			internal set;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000A5160 File Offset: 0x000A3360
		public bool AddToActionPanel(uint cellNum)
		{
			if (cellNum != 0u)
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
					RuntimeMethodHandle arg_15_0 = methodof(Item.AddToActionPanel(uint)).MethodHandle;
				}
				if (cellNum <= (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39880))
				{
					if (c9ae7090d3da364ca19dfcaf29e6e93eb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39892))
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
						c172b4d4ed0f35d37a974971a13e5aa99 c172b4d4ed0f35d37a974971a13e5aa = new c172b4d4ed0f35d37a974971a13e5aa99(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (byte)cellNum, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39896), this.c5e7f3c8a8196fc5311cde44e510f31f5);
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c172b4d4ed0f35d37a974971a13e5aa, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39900) != 0);
					}
					else
					{
						c172b4d4ed0f35d37a974971a13e5aa99 c172b4d4ed0f35d37a974971a13e5aa2 = new c172b4d4ed0f35d37a974971a13e5aa99(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (byte)cellNum, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39904), (ulong)cb3a6afc9e523a62c6a2d8819cfb30ed4.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c172b4d4ed0f35d37a974971a13e5aa2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39908) != 0);
					}
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39912) != 0;
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
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39884));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39888) != 0;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000A5268 File Offset: 0x000A3468
		internal double cf0b4f90ae4bfc487b16e01e5f6f7af1d()
		{
			if (c97fffca4057b0acd832bee8d616d59fb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != null)
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
					RuntimeMethodHandle arg_26_0 = methodof(Item.cf0b4f90ae4bfc487b16e01e5f6f7af1d()).MethodHandle;
				}
				try
				{
					double result;
					switch (ca2cdc1ed82ad653c8e9d3f10b1aa5556.c30767ddca1f9c207888833aea5b5fc61(c97fffca4057b0acd832bee8d616d59fb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39916))
					{
					case 0u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39920) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39928) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39936), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39944) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39952))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 1u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39960) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39968) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39976), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39984) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(39992))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 2u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40000) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40008) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40016), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40024) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40032))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40040) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 3u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40048) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40056) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40064), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40072) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40080))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 4u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40088) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40096) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40104), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40112) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40120))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 5u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40128) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40136) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40144), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40152) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40160))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 6u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40168) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40176) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40184), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40192) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40200))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 7u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40208) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40216) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40224), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40232) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40240))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40248) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 8u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40256) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40264) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40272), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40280) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40288))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 9u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40296) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40304) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40312), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40320) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40328))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 10u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40336) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40344) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40352), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40360) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40368))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40376) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 11u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40384) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40392) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40400), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40408) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40416))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40424) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 12u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40432) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40440) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40448), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40456) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40464))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40472) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 13u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40480) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40488) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40496), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40504) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40512))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40520) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 14u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40528) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40536) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40544), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40552) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40560))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 15u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40568) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40576) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40584), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40592) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40600))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40608) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 16u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40616) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40624) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40632), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40640) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40648))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40656) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 17u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40664) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40672) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40680), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40688) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40696))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40704) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 18u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40712) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40720) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40728), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40736) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40744))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40752) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 19u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40760) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40768) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40776), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40784) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40792))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40800) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 24u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40808) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40816) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40824), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40832) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40840))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 25u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40848) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40856) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40864), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40872) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40880))) * c81b6d4067cb71f0f5a8f03bbc2dd0ac0.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					}
					result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40888);
					return result;
				}
				catch
				{
					double result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40896);
					return result;
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40904);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000A62A4 File Offset: 0x000A44A4
		internal double c940d7db56791c7ad7cc3e645a4d6384c()
		{
			if (cb54c4b1ad9e558e2d77d9581d7430570.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(40912))
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
					RuntimeMethodHandle arg_30_0 = methodof(Item.c940d7db56791c7ad7cc3e645a4d6384c()).MethodHandle;
				}
				if (c97fffca4057b0acd832bee8d616d59fb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != null)
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
					return c3dae4afdba118d64ec6293e657258fb4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40916)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40924) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40932)) * ccfbd2cf16e03670801431708dbe88ca2.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40940);
				}
			}
			if (cb54c4b1ad9e558e2d77d9581d7430570.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(40948))
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
				if (cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(40952))
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
					double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40956);
					List<SqlWearable> list = c291d7645ab7d6a624a274cf5b489e9a3.c30767ddca1f9c207888833aea5b5fc61(ca1545833045485e7e1aaf72dd8285b93.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))).ToList<SqlWearable>();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(40964); i < c25bc672c630a8a2069239968b2830a1a.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(40968))
					{
						if ((long)cafc498df12ef91bdca6bd921c2979c86.c30767ddca1f9c207888833aea5b5fc61(cd11d75c49f45fd9136fda9ba1a927741.c30767ddca1f9c207888833aea5b5fc61(list, i)) == (long)((ulong)c7526a8d5977cf37d52ab10b022a9296e.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))
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
							if ((long)c2841805a856fc67717536ae154db6ac5.c30767ddca1f9c207888833aea5b5fc61(cd11d75c49f45fd9136fda9ba1a927741.c30767ddca1f9c207888833aea5b5fc61(list, i)) == (long)((ulong)cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))
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
								num = (double)c25f0f6cae56aa7a4a3798c0297ccd453.c30767ddca1f9c207888833aea5b5fc61(cd11d75c49f45fd9136fda9ba1a927741.c30767ddca1f9c207888833aea5b5fc61(list, i));
							}
						}
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
					return c3dae4afdba118d64ec6293e657258fb4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40972)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40980) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40988)) * ca2b4c3a31c32647434ecefc35195fa9e.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(40996) * num;
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41004);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000A6528 File Offset: 0x000A4728
		internal double cd892f771d08dab9c1e06ebb8f84e4872()
		{
			if (cb54c4b1ad9e558e2d77d9581d7430570.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41012))
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
					RuntimeMethodHandle arg_30_0 = methodof(Item.cd892f771d08dab9c1e06ebb8f84e4872()).MethodHandle;
				}
				if (cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41016))
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
					double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41020);
					List<SqlWearable> list = c291d7645ab7d6a624a274cf5b489e9a3.c30767ddca1f9c207888833aea5b5fc61(ca1545833045485e7e1aaf72dd8285b93.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))).ToList<SqlWearable>();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41028); i < c25bc672c630a8a2069239968b2830a1a.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41032))
					{
						if ((long)cafc498df12ef91bdca6bd921c2979c86.c30767ddca1f9c207888833aea5b5fc61(cd11d75c49f45fd9136fda9ba1a927741.c30767ddca1f9c207888833aea5b5fc61(list, i)) == (long)((ulong)c7526a8d5977cf37d52ab10b022a9296e.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))
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
							if ((long)c2841805a856fc67717536ae154db6ac5.c30767ddca1f9c207888833aea5b5fc61(cd11d75c49f45fd9136fda9ba1a927741.c30767ddca1f9c207888833aea5b5fc61(list, i)) == (long)((ulong)cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))
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
								num = (double)c72d02916c47de43c59fdb55a09e1b19d.c30767ddca1f9c207888833aea5b5fc61(cd11d75c49f45fd9136fda9ba1a927741.c30767ddca1f9c207888833aea5b5fc61(list, i));
							}
						}
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
					return c3dae4afdba118d64ec6293e657258fb4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41036)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41044) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41052)) * ce2f1cf8cda1c1b40956d4ef4b8b52d1d.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41060) * num;
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41068);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000A66E8 File Offset: 0x000A48E8
		internal double cdf88fd9c908dacc4f180b0d4021b4607()
		{
			if (c97fffca4057b0acd832bee8d616d59fb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != null)
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
					RuntimeMethodHandle arg_26_0 = methodof(Item.cdf88fd9c908dacc4f180b0d4021b4607()).MethodHandle;
				}
				try
				{
					uint num = ca2cdc1ed82ad653c8e9d3f10b1aa5556.c30767ddca1f9c207888833aea5b5fc61(c97fffca4057b0acd832bee8d616d59fb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					double result;
					switch (num - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41076))
					{
					case 0u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41084) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41092) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41100), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41108) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41116))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41124) * c4b3e60af839156bfdbf51af39b7d762e.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 1u:
					case 2u:
						break;
					case 3u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41132) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41140) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41148), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41156) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41164))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41172) * c4b3e60af839156bfdbf51af39b7d762e.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					case 4u:
						result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41180) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41188) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41196), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41204) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41212))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41220) * c4b3e60af839156bfdbf51af39b7d762e.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
						return result;
					default:
						if (num == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41080))
						{
							result = ((double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41228) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41236) + (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41244), (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41252) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41260))) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41268) * c4b3e60af839156bfdbf51af39b7d762e.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
							return result;
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
						break;
					}
					result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41276);
					return result;
				}
				catch
				{
					double result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41284);
					return result;
				}
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41292);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x000A6A9C File Offset: 0x000A4C9C
		internal void c11546181b1262acba2edb5e5d103f097()
		{
			c4a9e5a0ee18ebfd8a0e51b0592615687.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.cf0b4f90ae4bfc487b16e01e5f6f7af1d());
			c92194b76d0f456a2211153012d3f8446.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.cdf88fd9c908dacc4f180b0d4021b4607());
			c8cc57275bef0f75a4ee85aa45cc610cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.c940d7db56791c7ad7cc3e645a4d6384c());
			c6c16413f50a3188a8944e6132384f50e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.cd892f771d08dab9c1e06ebb8f84e4872());
			if (cb54c4b1ad9e558e2d77d9581d7430570.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41300))
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
					RuntimeMethodHandle arg_68_0 = methodof(Item.c11546181b1262acba2edb5e5d103f097()).MethodHandle;
				}
				if (c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41304))
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
					if (c6a3c374e5d4e639251c4bdd195fe1dbe.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))
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
						int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41308);
						int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41312);
						double num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41316);
						if (cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41324))
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
							num += cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41328);
						}
						if (cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41332))
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
							num += cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41336);
						}
						if (cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41340))
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
							num += cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41344);
						}
						if (cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41348))
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
							num += cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41352);
						}
						if (c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41356))
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
							num += c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41360);
						}
						if (num2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41364))
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
							num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41368);
						}
						else if (num2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41376))
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
							num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41380);
						}
						else if (num2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41388))
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
							num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41392);
						}
						double num4 = (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * num3 * (double)cf2e75964606540869e8285c0b1b67143.c30767ddca1f9c207888833aea5b5fc61(cbcf04927ee927d76d9a019803b981136.c30767ddca1f9c207888833aea5b5fc61(cabda6a183494e6e5ea3246ed0b954a6f.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41400);
						double num5 = num4 * ((double)c8f3787422eeefa41ff6a9fb45713f3f3.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41408));
						ccd381d55959e0291591520897ccb9154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num5);
						c545cc5095bd0c4312f17f7998bbbc567.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num5 / (double)num * (double)cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						c1b36d6feab367ba212a4f110dbc6ebc8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num5 / (double)num * (double)cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						ca45edddd042402edeedc5df743b5e686.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num5 / (double)num * (double)c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						c915a5e11fc3dbaeb434d2e54e2b5f9f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num5 / (double)num * (double)cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						cba2e7e431288928da06f6d43c89f336c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num5 / (double)num * (double)cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c1602bbe58f668b846091b51e2a3e2cd7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
					}
				}
			}
			if (cb54c4b1ad9e558e2d77d9581d7430570.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41416))
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
				if (c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41420))
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
					if (c6a3c374e5d4e639251c4bdd195fe1dbe.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))
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
						int num6 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41424);
						int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41428);
						double num8 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41432);
						if (cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41440))
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
							num6 += cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41444);
						}
						if (cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41448))
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
							num6 += cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41452);
						}
						if (cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41456))
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
							num6 += cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41460);
						}
						if (cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41464))
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
							num6 += cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41468);
						}
						if (c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41472))
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
							num6 += c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41476);
						}
						if (num7 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41480))
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
							num8 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41484);
						}
						else if (num7 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41492))
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
							num8 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41496);
						}
						else if (num7 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41504))
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
							num8 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41508);
						}
						double num9 = (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * num8 * (double)cc003fdf984f501930ff98712c1e8f6c8.c30767ddca1f9c207888833aea5b5fc61(c7e09eeb039b2bc4a890ea65f0dff329e.c30767ddca1f9c207888833aea5b5fc61(c6c9ceed50cee492f304fa50147fb5185.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41516);
						double num10 = num9 * ((double)c8f3787422eeefa41ff6a9fb45713f3f3.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41524));
						ccd381d55959e0291591520897ccb9154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num10);
						c545cc5095bd0c4312f17f7998bbbc567.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num10 / (double)num6 * (double)cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						c1b36d6feab367ba212a4f110dbc6ebc8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num10 / (double)num6 * (double)cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						ca45edddd042402edeedc5df743b5e686.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num10 / (double)num6 * (double)c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						c915a5e11fc3dbaeb434d2e54e2b5f9f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num10 / (double)num6 * (double)cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						cba2e7e431288928da06f6d43c89f336c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num10 / (double)num6 * (double)cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c5bbdabac4e8ca2c888076515f4762215.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						return;
					}
				}
			}
			else if (cb54c4b1ad9e558e2d77d9581d7430570.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41532))
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
				if (c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41536))
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
					if (c6a3c374e5d4e639251c4bdd195fe1dbe.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))
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
						int num11 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41540);
						int num12 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41544);
						double num13 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41548);
						if (cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41556))
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
							num11 += cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num12 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41560);
						}
						if (cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41564))
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
							num11 += cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num12 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41568);
						}
						if (cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41572))
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
							num11 += cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num12 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41576);
						}
						if (cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41580))
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
							num11 += cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num12 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41584);
						}
						if (c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41588))
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
							num11 += c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
							num12 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41592);
						}
						if (num12 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41596))
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
							num13 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41600);
						}
						else if (num12 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41608))
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
							num13 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41612);
						}
						else if (num12 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41620))
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
							num13 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41624);
						}
						double num14 = (double)c296db85d50a2f859ab57170e71136039.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) * num13 * (double)cc003fdf984f501930ff98712c1e8f6c8.c30767ddca1f9c207888833aea5b5fc61(c7e09eeb039b2bc4a890ea65f0dff329e.c30767ddca1f9c207888833aea5b5fc61(c6c9ceed50cee492f304fa50147fb5185.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cb90f31a9dd3759b0261d3999b5da3d35.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41632);
						double num15 = num14 * ((double)c8f3787422eeefa41ff6a9fb45713f3f3.c30767ddca1f9c207888833aea5b5fc61(cda050d368a2498c737a0db5eee22c844.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), (uint)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41640));
						ccd381d55959e0291591520897ccb9154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num15);
						c545cc5095bd0c4312f17f7998bbbc567.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num15 / (double)num11 * (double)cedad6b2171f479bb0f29b5c483f2aa61.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						c1b36d6feab367ba212a4f110dbc6ebc8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num15 / (double)num11 * (double)cd47e3d5f26285debf7501fa920211d16.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						ca45edddd042402edeedc5df743b5e686.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num15 / (double)num11 * (double)c34024617bcb1eaf97906bdcd9b00470d.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						c915a5e11fc3dbaeb434d2e54e2b5f9f1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num15 / (double)num11 * (double)cf2dc1e75e1672e16aa4a9ee631ae4141.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
						cba2e7e431288928da06f6d43c89f336c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num15 / (double)num11 * (double)cd92804ea3bf0ca69becf3eb494b04b6a.c30767ddca1f9c207888833aea5b5fc61(c50f5d6612fc2b3a6905f34a1de3bab64.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c8fee1bc6ec80b311fb267cc96e4d1122.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))))));
					}
				}
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x000A7C54 File Offset: 0x000A5E54
		public bool weCanPlantHere(double x, double y, double z)
		{
			try
			{
				List<DoodadObject> list = this.ca124a9f406cda69b904f2eb04d553ab9.ce3c461fef78e0c8cd8106d4f286e1a07();
				bool result;
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41648); i < cc7be13b57fb3393b0017c0b8c7f88167.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41680))
				{
					if (c2cb2f77cbe4e6ad880196340e1f49172.c30767ddca1f9c207888833aea5b5fc61(c79053bd96887d68d3b70b9f8be69d634.c30767ddca1f9c207888833aea5b5fc61(cfd66ba291892adc6212910185c8d7351.c30767ddca1f9c207888833aea5b5fc61(list, i))) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41652))
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
							RuntimeMethodHandle arg_56_0 = methodof(Item.weCanPlantHere(double, double, double)).MethodHandle;
						}
						double num = (double)c2cb2f77cbe4e6ad880196340e1f49172.c30767ddca1f9c207888833aea5b5fc61(c79053bd96887d68d3b70b9f8be69d634.c30767ddca1f9c207888833aea5b5fc61(cfd66ba291892adc6212910185c8d7351.c30767ddca1f9c207888833aea5b5fc61(list, i))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41656);
						if (cd4efd55c46df3a504730012fdf82a7c9.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41664))
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
							num += (double)c2cb2f77cbe4e6ad880196340e1f49172.c30767ddca1f9c207888833aea5b5fc61(c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd4efd55c46df3a504730012fdf82a7c9.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41668);
						}
						if (cfd66ba291892adc6212910185c8d7351.c30767ddca1f9c207888833aea5b5fc61(list, i).cc81d2f6c202254bbe1c9ec2702acd5eb(x, y) < num)
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
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41676) != 0);
							return result;
						}
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
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41684) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41688) != 0;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000A7DE0 File Offset: 0x000A5FE0
		public bool RepairEquipment()
		{
			try
			{
				bool result;
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41692))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.RepairEquipment()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41696));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41700) != 0);
					return result;
				}
				if (!c3043acfc32f587e4d13ef14c3973532a.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41704));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41708) != 0);
					return result;
				}
				if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41712))
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
					if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41716))
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
						if (!this.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3())
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								goto IL_F3;
							}
						}
					}
					if ((int)c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41816))
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
						if (c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) != ClientVersion.NorthAmericaTrion)
						{
							goto IL_440;
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
					if (this.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3())
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
						c75c19c7e3eb9ac06afb85cee94cf7851 c75c19c7e3eb9ac06afb85cee94cf = new c75c19c7e3eb9ac06afb85cee94cf7851(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41820), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41824) != 0);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41828), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41832));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c75c19c7e3eb9ac06afb85cee94cf, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41836) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41840), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41844));
						return result;
					}
					IL_440:
					goto IL_454;
				}
				IL_F3:
				Creature creature = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
				double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41720);
				List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41728); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41732))
				{
					if (c0d664bd446affa09259f62233268c79c.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i))))
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
						if (num > c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
							num = c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i));
							creature = cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i);
						}
					}
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
				if (creature == null)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41736));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41740) != 0);
					return result;
				}
				if (c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), creature) > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41744))
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
					if (!this.ca124a9f406cda69b904f2eb04d553ab9.c80d205e01c504d154a7b60400b29b347(c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(creature), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(creature), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(creature), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41752), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(41760), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41768) != 0))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41772));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41776) != 0);
						return result;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c107d51f3d67e18d973a4cae3d327c111(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41780));
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c2a01ec29bd94e09a986cf5dea26b4cc9(creature, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41784) != 0);
				c75c19c7e3eb9ac06afb85cee94cf7851 c75c19c7e3eb9ac06afb85cee94cf2 = new c75c19c7e3eb9ac06afb85cee94cf7851(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41788), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41792) != 0);
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41796), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41800));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c75c19c7e3eb9ac06afb85cee94cf2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41804) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41808), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41812));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			IL_454:
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41848));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41852) != 0;
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000A8280 File Offset: 0x000A6480
		public bool RemoveItemFromTrade()
		{
			try
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41856))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.RemoveItemFromTrade()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41860));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41864) != 0;
					return result;
				}
				List<Item> list = c8ac2bbe38910692e72b05d874554dd1e.c30767ddca1f9c207888833aea5b5fc61(cc1e84e833a5a920e672bfc88c3c058ba.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41868); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41892))
				{
					if (c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i).c5e7f3c8a8196fc5311cde44e510f31f5 == this.c5e7f3c8a8196fc5311cde44e510f31f5)
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
						cd4b1436e146645525997385ec8ee5584 cd4b1436e146645525997385ec8ee = new cd4b1436e146645525997385ec8ee5584(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41872), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41876));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cd4b1436e146645525997385ec8ee, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41880) != 0);
						bool result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41884), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41888));
						return result;
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
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41896));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41900) != 0;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000A8418 File Offset: 0x000A6618
		public bool PutItemInTrade(int itemCount = 0)
		{
			try
			{
				bool result;
				if (itemCount < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41904))
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
						RuntimeMethodHandle arg_1F_0 = methodof(Item.PutItemInTrade(int)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41908));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41912) != 0);
					return result;
				}
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41916))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41920));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41924) != 0);
					return result;
				}
				if (c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(cc1e84e833a5a920e672bfc88c3c058ba.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).get_cacbaa35d25d410d86c30b4ae8a318175()) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41928))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41932));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41936) != 0);
					return result;
				}
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41940); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(cc1e84e833a5a920e672bfc88c3c058ba.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).get_cacbaa35d25d410d86c30b4ae8a318175()); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41952))
				{
					if (c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(cc1e84e833a5a920e672bfc88c3c058ba.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).get_cacbaa35d25d410d86c30b4ae8a318175(), i).c5e7f3c8a8196fc5311cde44e510f31f5 == this.c5e7f3c8a8196fc5311cde44e510f31f5)
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41944));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41948) != 0);
						return result;
					}
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
				if (itemCount > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41956))
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
					if (itemCount > cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41960));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41964) != 0);
						return result;
					}
				}
				if (itemCount == cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					itemCount = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41968);
				}
				c303fe4e8160746927664f90879a64bd2 c303fe4e8160746927664f90879a64bd = new c303fe4e8160746927664f90879a64bd2(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), itemCount);
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41972), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41976));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c303fe4e8160746927664f90879a64bd, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41980) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41984), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41988));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41992));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(41996) != 0;
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000A86F0 File Offset: 0x000A68F0
		public bool MoveItemFromCoffer()
		{
			try
			{
				if (c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) == null)
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
						RuntimeMethodHandle arg_28_0 = methodof(Item.MoveItemFromCoffer()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42000));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42004) != 0;
					return result;
				}
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42008))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42012));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42016) != 0;
					return result;
				}
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42020);
				List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
				Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
				Item.ce14266bfc174f8ef900ac89c247005e8 ce14266bfc174f8ef900ac89c247005e = new Item.ce14266bfc174f8ef900ac89c247005e8();
				ce14266bfc174f8ef900ac89c247005e.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42024);
				while ((int)ce14266bfc174f8ef900ac89c247005e.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < c7f0652385ef8939093fc0a0d1bc36723.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
				{
					object arg_ED_0 = list;
					if (predicate == null)
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
						predicate = new Predicate<Item>(ce14266bfc174f8ef900ac89c247005e.c13edf63d3828edf07234e53c5c3f292b);
					}
					if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_ED_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42028))
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
						b = ce14266bfc174f8ef900ac89c247005e.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
						IL_151:
						bool result;
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42036))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42040));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42044) != 0);
							return result;
						}
						c4e99e712d80f98376a400af8df1967c4 c4e99e712d80f98376a400af8df1967c = new c4e99e712d80f98376a400af8df1967c4(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42048)), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42052), b, c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).cadab02f2f80fd2ebe9b14ca573098990);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42056), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42060));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c4e99e712d80f98376a400af8df1967c, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42064) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42068), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42072));
						return result;
					}
					else
					{
						Item.ce14266bfc174f8ef900ac89c247005e8 expr_114 = ce14266bfc174f8ef900ac89c247005e;
						expr_114.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_114.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42032));
					}
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					goto IL_151;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42076));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42080) != 0;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000A8994 File Offset: 0x000A6B94
		public bool MoveItemToCoffer()
		{
			try
			{
				if (c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) == null)
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
						RuntimeMethodHandle arg_28_0 = methodof(Item.MoveItemToCoffer()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42084));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42088) != 0;
					return result;
				}
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42092))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42096));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42100) != 0;
					return result;
				}
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42104);
				List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
				Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
				Item.c6699ea3178e1dc4a893559c0715bcc96 c6699ea3178e1dc4a893559c0715bcc = new Item.c6699ea3178e1dc4a893559c0715bcc96();
				c6699ea3178e1dc4a893559c0715bcc.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42108);
				while (c6699ea3178e1dc4a893559c0715bcc.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).cbf8c204be233e5a9dd42f9d96af0a351)
				{
					object arg_ED_0 = list;
					if (predicate == null)
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
						predicate = new Predicate<Item>(c6699ea3178e1dc4a893559c0715bcc.c51a30f3809fee2b9e169257ecb86a0b1);
					}
					if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_ED_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42112))
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
						b = c6699ea3178e1dc4a893559c0715bcc.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
						IL_156:
						bool result;
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42120))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42124));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42128) != 0);
							return result;
						}
						c4e99e712d80f98376a400af8df1967c4 c4e99e712d80f98376a400af8df1967c = new c4e99e712d80f98376a400af8df1967c4(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42132)), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42136), b, c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).cadab02f2f80fd2ebe9b14ca573098990);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42140), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42144));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c4e99e712d80f98376a400af8df1967c, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42148) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42152), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42156));
						return result;
					}
					else
					{
						Item.c6699ea3178e1dc4a893559c0715bcc96 expr_114 = c6699ea3178e1dc4a893559c0715bcc;
						expr_114.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_114.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42116));
					}
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					goto IL_156;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42160));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42164) != 0;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000A8C3C File Offset: 0x000A6E3C
		public bool MoveItemFromWh()
		{
			try
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42168))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.MoveItemFromWh()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42172));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42176) != 0;
					return result;
				}
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42180);
				List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
				Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
				Item.c0dd06b5b5030a93cd96b9ce168100230 c0dd06b5b5030a93cd96b9ce = new Item.c0dd06b5b5030a93cd96b9ce168100230();
				c0dd06b5b5030a93cd96b9ce.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42184);
				while ((int)c0dd06b5b5030a93cd96b9ce.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < c7f0652385ef8939093fc0a0d1bc36723.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
				{
					object arg_A7_0 = list;
					if (predicate == null)
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
						predicate = new Predicate<Item>(c0dd06b5b5030a93cd96b9ce.c5bc05e5cd4898bc83898fbb9cc213e3f);
					}
					if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_A7_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42188))
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
						b = c0dd06b5b5030a93cd96b9ce.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
						IL_10B:
						bool result;
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42196))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42200));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42204) != 0);
							return result;
						}
						cc5e73a99e59a37c7d0d271a0e30237b5 cc5e73a99e59a37c7d0d271a0e30237b = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42208)), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42212), b);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42216), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42220));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cc5e73a99e59a37c7d0d271a0e30237b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42224) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42228), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42232));
						return result;
					}
					else
					{
						Item.c0dd06b5b5030a93cd96b9ce168100230 expr_CE = c0dd06b5b5030a93cd96b9ce;
						expr_CE.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_CE.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42192));
					}
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					goto IL_10B;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42236));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42240) != 0;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x000A8E80 File Offset: 0x000A7080
		public bool MoveItemToWh()
		{
			try
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42244))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.MoveItemToWh()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42248));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42252) != 0;
					return result;
				}
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42256);
				List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
				Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
				Item.c515cdc3ad0a192be6c6c1d608c85b45d c515cdc3ad0a192be6c6c1d608c85b45d = new Item.c515cdc3ad0a192be6c6c1d608c85b45d();
				c515cdc3ad0a192be6c6c1d608c85b45d.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42260);
				while ((int)c515cdc3ad0a192be6c6c1d608c85b45d.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < cf58a902797976183bb13fd4d7c924ce7.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
				{
					object arg_A7_0 = list;
					if (predicate == null)
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
						predicate = new Predicate<Item>(c515cdc3ad0a192be6c6c1d608c85b45d.cddcb817ff5a52be26d79d813f91741b7);
					}
					if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_A7_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42264))
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
						b = c515cdc3ad0a192be6c6c1d608c85b45d.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
						IL_10B:
						bool result;
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42272))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42276));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42280) != 0);
							return result;
						}
						cc5e73a99e59a37c7d0d271a0e30237b5 cc5e73a99e59a37c7d0d271a0e30237b = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42284)), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42288), b);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42292), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42296));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cc5e73a99e59a37c7d0d271a0e30237b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42300) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42304), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42308));
						return result;
					}
					else
					{
						Item.c515cdc3ad0a192be6c6c1d608c85b45d expr_CE = c515cdc3ad0a192be6c6c1d608c85b45d;
						expr_CE.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_CE.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42268));
					}
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					goto IL_10B;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42312));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42316) != 0;
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x000A90C4 File Offset: 0x000A72C4
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x000A90D8 File Offset: 0x000A72D8
		public ArmorSet armorSet
		{
			get;
			internal set;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001273 RID: 4723 RVA: 0x000A90EC File Offset: 0x000A72EC
		public uint skillId
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_skillId()).MethodHandle;
					}
					return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42320);
				}
				return cef937c4179bbad602e3f4568533301c4.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x000A9130 File Offset: 0x000A7330
		public bool DeleteItem(int itemCount = 0)
		{
			try
			{
				bool result;
				if (itemCount < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42324))
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
					if (!true)
					{
						RuntimeMethodHandle arg_1F_0 = methodof(Item.DeleteItem(int)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42328));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42332) != 0);
					return result;
				}
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42336))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42340));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42344) != 0);
					return result;
				}
				if (itemCount > cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42348));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42352) != 0);
					return result;
				}
				if (itemCount == 0)
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
					itemCount = cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				}
				cec0686ba1601dfb5ba11151856e6b09a cec0686ba1601dfb5ba11151856e6b09a = new cec0686ba1601dfb5ba11151856e6b09a(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), itemCount);
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42356), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42360));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cec0686ba1601dfb5ba11151856e6b09a, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42364) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42368), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42372));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42376) != 0;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000A92D0 File Offset: 0x000A74D0
		public bool UseItem(bool autoCome = false)
		{
			return this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
			{
				cbe5fb745fb9d18c1a122f67582a2fc76 = c4e5798155f7a355098632ea8907b4289.c30767ddca1f9c207888833aea5b5fc61(c53e6f1810c9e3e5902969b300bae016b.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))),
				ca77899f30642d168d6dec950678a16c8 = this,
				cb6b52efde3ab22e0b644905e40f0efbc = autoCome
			});
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x000A931C File Offset: 0x000A751C
		public bool UseItem(int mpCost, bool autoCome = false)
		{
			return this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
			{
				cbe5fb745fb9d18c1a122f67582a2fc76 = c4e5798155f7a355098632ea8907b4289.c30767ddca1f9c207888833aea5b5fc61(c53e6f1810c9e3e5902969b300bae016b.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))),
				ca77899f30642d168d6dec950678a16c8 = this,
				cb6b52efde3ab22e0b644905e40f0efbc = autoCome,
				c91c55a4a1e3f353b30fc28b3501926a2 = mpCost
			});
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x000A9370 File Offset: 0x000A7570
		public bool UseItem(double x, double y, double z, int mpCost, bool autoCome, double rot)
		{
			return this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
			{
				cbe5fb745fb9d18c1a122f67582a2fc76 = c4e5798155f7a355098632ea8907b4289.c30767ddca1f9c207888833aea5b5fc61(c53e6f1810c9e3e5902969b300bae016b.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))),
				ca77899f30642d168d6dec950678a16c8 = this,
				c5ed806d2bb2197e7a4cc678385a2e6a1 = x,
				ce3da4123359df388eefe0c5b68072b14 = y,
				c15aa95c996f022a57045b8c635aa8e1e = z,
				c4c0828b517d80d5dbfd1137fa5d4cd6e = rot,
				cb6b52efde3ab22e0b644905e40f0efbc = autoCome,
				c91c55a4a1e3f353b30fc28b3501926a2 = mpCost
			});
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000A93E4 File Offset: 0x000A75E4
		public bool UpdateConstructTax(double x, double y)
		{
			try
			{
				if (c13f5fd77c292da83c587ccbe3fd3df75.c30767ddca1f9c207888833aea5b5fc61(cbe870f7a7297586dfaffa21aae57a577.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) == 0u)
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
						RuntimeMethodHandle arg_2A_0 = methodof(Item.UpdateConstructTax(double, double)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42380));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42384) != 0;
					return result;
				}
				if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42388) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42396))
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
					if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42404) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42412))
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
						x -= x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42420);
					}
					else
					{
						x = x + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42428) - x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42436);
					}
				}
				if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42444) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42452))
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
					if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42460) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42468))
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
						y -= y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42476);
					}
					else
					{
						y = y + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42484) - y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42492);
					}
				}
				double num = this.ca124a9f406cda69b904f2eb04d553ab9.c990fa03d9af00d4b27bdc6363821a689(x, y);
				if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42500))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42508));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42512) != 0;
					return result;
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42516), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42520));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new cec1c2b8a79571ec797a48a9ff22b959e(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c13f5fd77c292da83c587ccbe3fd3df75.c30767ddca1f9c207888833aea5b5fc61(cbe870f7a7297586dfaffa21aae57a577.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), x, y, num), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42524) != 0);
				if (this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42528), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42532)))
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
					this.c61bc5e8f62c5d6fafe2c279819422ee0 = this.ca124a9f406cda69b904f2eb04d553ab9.c224c73cb9a0b8250b0cc391502207a0e;
					this.ced32a28d6a75b3d35484c81ca8368150 = x;
					this.cf462ae70b14e8ef41780dbe346523942 = y;
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42536) != 0;
					return result;
				}
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42540) != 0;
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000A967C File Offset: 0x000A787C
		public bool ConstructHouse(double x, double y, bool checkAnotherBuildings = true)
		{
			try
			{
				if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42544) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42552))
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
					if (!true)
					{
						RuntimeMethodHandle arg_2E_0 = methodof(Item.ConstructHouse(double, double, bool)).MethodHandle;
					}
					if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42560) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42568))
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
						x -= x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42576);
					}
					else
					{
						x = x + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42584) - x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42592);
					}
				}
				if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42600) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42608))
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
					if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42616) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42624))
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
						y -= y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42632);
					}
					else
					{
						y = y + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42640) - y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42648);
					}
				}
				double num = this.ca124a9f406cda69b904f2eb04d553ab9.c990fa03d9af00d4b27bdc6363821a689(x, y);
				bool result;
				if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42656))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42664));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42668) != 0);
					return result;
				}
				result = c0456fb3c6d941be4dd134514f13aa3ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x, y, num, checkAnotherBuildings);
				return result;
			}
			catch
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42672));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42676) != 0;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000A9834 File Offset: 0x000A7A34
		public bool ConstructHouse(double x, double y, double z, bool checkAnotherBuildings = true)
		{
			try
			{
				if (c13f5fd77c292da83c587ccbe3fd3df75.c30767ddca1f9c207888833aea5b5fc61(cbe870f7a7297586dfaffa21aae57a577.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) == 0u)
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
						RuntimeMethodHandle arg_2A_0 = methodof(Item.ConstructHouse(double, double, double, bool)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42680));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42684) != 0;
					return result;
				}
				if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42688) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42696))
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
					if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42704) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42712))
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
						x -= x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42720);
					}
					else
					{
						x = x + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42728) - x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42736);
					}
				}
				if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42744) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42752))
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
					if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42760) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42768))
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
						y -= y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42776);
					}
					else
					{
						y = y + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42784) - y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42792);
					}
				}
				if (checkAnotherBuildings)
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
					List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42800); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42816))
					{
						if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42804))
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
							if (c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)) == x)
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
								if (cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)) == y)
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
									this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42808));
									bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42812) != 0;
									return result;
								}
							}
						}
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
				if (this.c61bc5e8f62c5d6fafe2c279819422ee0 != 0u)
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
					if (this.ced32a28d6a75b3d35484c81ca8368150 == x)
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
						if (this.cf462ae70b14e8ef41780dbe346523942 == y)
						{
							goto IL_272;
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
				}
				c92210b2d3131091c11f3f5cb6b6e5970.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x, y);
				IL_272:
				if (this.c61bc5e8f62c5d6fafe2c279819422ee0 != 0u)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42820), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42824));
					this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new cfcf52276b9b06d6c03f76b9c1fc6ed51(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c13f5fd77c292da83c587ccbe3fd3df75.c30767ddca1f9c207888833aea5b5fc61(cbe870f7a7297586dfaffa21aae57a577.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), x, y, z, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42828), this.c5e7f3c8a8196fc5311cde44e510f31f5, this.c61bc5e8f62c5d6fafe2c279819422ee0), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42836) != 0);
					bool result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42840), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42844));
					return result;
				}
			}
			catch
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42848));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42852) != 0;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000A9BA8 File Offset: 0x000A7DA8
		public bool ConstructHouse(double x, double y, double z, double angle, bool checkAnotherBuildings = true)
		{
			try
			{
				if (c13f5fd77c292da83c587ccbe3fd3df75.c30767ddca1f9c207888833aea5b5fc61(cbe870f7a7297586dfaffa21aae57a577.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) == 0u)
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
						RuntimeMethodHandle arg_2A_0 = methodof(Item.ConstructHouse(double, double, double, double, bool)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42856));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42860) != 0;
					return result;
				}
				if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42864) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42872))
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
					if (x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42880) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42888))
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
						x -= x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42896);
					}
					else
					{
						x = x + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42904) - x % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42912);
					}
				}
				if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42920) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42928))
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
					if (y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42936) <= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42944))
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
						y -= y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42952);
					}
					else
					{
						y = y + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42960) - y % c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(42968);
					}
				}
				if (checkAnotherBuildings)
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
					List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42976); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42992))
					{
						if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42980))
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
							if (c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)) == x)
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
								if (cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)) == y)
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
									this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42984));
									bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42988) != 0;
									return result;
								}
							}
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
				}
				if (this.c61bc5e8f62c5d6fafe2c279819422ee0 != 0u)
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
					if (this.ced32a28d6a75b3d35484c81ca8368150 == x)
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
						if (this.cf462ae70b14e8ef41780dbe346523942 == y)
						{
							goto IL_272;
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
				}
				c92210b2d3131091c11f3f5cb6b6e5970.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, x, y);
				IL_272:
				if (this.c61bc5e8f62c5d6fafe2c279819422ee0 != 0u)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(42996), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43000));
					this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new cfcf52276b9b06d6c03f76b9c1fc6ed51(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c13f5fd77c292da83c587ccbe3fd3df75.c30767ddca1f9c207888833aea5b5fc61(cbe870f7a7297586dfaffa21aae57a577.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), x, y, z, angle, this.c5e7f3c8a8196fc5311cde44e510f31f5, this.c61bc5e8f62c5d6fafe2c279819422ee0), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43004) != 0);
					bool result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43008), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43012));
					return result;
				}
			}
			catch
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43016));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43020) != 0;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000A9F14 File Offset: 0x000A8114
		public bool SplitCofferItem(int newCount)
		{
			try
			{
				if (c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) == null)
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
						RuntimeMethodHandle arg_28_0 = methodof(Item.SplitCofferItem(int)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43024));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43028) != 0;
					return result;
				}
				if (cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43032))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43036));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43040) != 0;
					return result;
				}
				if (newCount == 0)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43044));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43048) != 0;
					return result;
				}
				if (newCount >= cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43052));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43056) != 0;
					return result;
				}
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43060))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43064));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43068) != 0;
					return result;
				}
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43072);
				List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
				Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
				Item.c4153aa1952a004ac640215cd42a2716a c4153aa1952a004ac640215cd42a2716a = new Item.c4153aa1952a004ac640215cd42a2716a();
				c4153aa1952a004ac640215cd42a2716a.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43076);
				while (c4153aa1952a004ac640215cd42a2716a.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).cbf8c204be233e5a9dd42f9d96af0a351)
				{
					object arg_19F_0 = list;
					if (predicate == null)
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
						predicate = new Predicate<Item>(c4153aa1952a004ac640215cd42a2716a.c73179ce1b74e4c10da416628cf8af0e1);
					}
					if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_19F_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43080))
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
						b = c4153aa1952a004ac640215cd42a2716a.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
						IL_208:
						bool result;
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43088))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43092));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43096) != 0);
							return result;
						}
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43100), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43104));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new ce413cc7a0cd3fbd8c1502d16a12b24a5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43108)), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), b, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43112), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43116), newCount, c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).cadab02f2f80fd2ebe9b14ca573098990), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43120) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43124), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43128));
						return result;
					}
					else
					{
						Item.c4153aa1952a004ac640215cd42a2716a expr_1C6 = c4153aa1952a004ac640215cd42a2716a;
						expr_1C6.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_1C6.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43084));
					}
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					goto IL_208;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43132));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43136) != 0;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x000AA26C File Offset: 0x000A846C
		public bool SplitItem(int newCount)
		{
			try
			{
				if (cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43140))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.SplitItem(int)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43144));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43148) != 0;
					return result;
				}
				if (newCount == 0)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43152));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43156) != 0;
					return result;
				}
				if (newCount >= cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43160));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43164) != 0;
					return result;
				}
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43168))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43172));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43176) != 0;
					return result;
				}
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43180);
				List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
				Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
				Item.c4dd61e6d21e7ea66f95c917a6413cf78 c4dd61e6d21e7ea66f95c917a6413cf = new Item.c4dd61e6d21e7ea66f95c917a6413cf78();
				c4dd61e6d21e7ea66f95c917a6413cf.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43184);
				while ((int)c4dd61e6d21e7ea66f95c917a6413cf.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < c7f0652385ef8939093fc0a0d1bc36723.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
				{
					object arg_159_0 = list;
					if (predicate == null)
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
						predicate = new Predicate<Item>(c4dd61e6d21e7ea66f95c917a6413cf.c7df2cb9e6da47ec81cc4de8e06a068cd);
					}
					if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_159_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43188))
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
						b = c4dd61e6d21e7ea66f95c917a6413cf.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
						IL_1BD:
						bool result;
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43196))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43200));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43204) != 0);
							return result;
						}
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43208), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43212));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new c2b457856823ca1886140faec87998fd0(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43216)), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), b, newCount), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43220) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43224), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43228));
						return result;
					}
					else
					{
						Item.c4dd61e6d21e7ea66f95c917a6413cf78 expr_180 = c4dd61e6d21e7ea66f95c917a6413cf;
						expr_180.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_180.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43192));
					}
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					goto IL_1BD;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43232));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43236) != 0;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000AA55C File Offset: 0x000A875C
		public bool Enchant(Item itemToEnchant)
		{
			try
			{
				bool result;
				if (itemToEnchant == null)
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
						RuntimeMethodHandle arg_15_0 = methodof(Item.Enchant(Item)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43240));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43244) != 0);
					return result;
				}
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43248))
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
					if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(itemToEnchant) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43252))
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
						if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(itemToEnchant) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43256))
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								goto IL_95;
							}
						}
					}
					if (c6d8c1d114b637ce836465b5698ac47d0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43268))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43272));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43276) != 0);
						return result;
					}
					if (cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(itemToEnchant)) == 0u)
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
						if (cb90f31a9dd3759b0261d3999b5da3d35.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(itemToEnchant)) == 0u)
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
							if (cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(itemToEnchant)) == 0u)
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
								this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43280));
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43284) != 0);
								return result;
							}
						}
					}
					result = this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
					{
						cbe5fb745fb9d18c1a122f67582a2fc76 = cef937c4179bbad602e3f4568533301c4.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)),
						ca77899f30642d168d6dec950678a16c8 = this,
						cc8ee36ad358f5576a598ffd9bcefe33c = itemToEnchant
					});
					return result;
				}
				IL_95:
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43260));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43264) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43288));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43292) != 0;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000AA768 File Offset: 0x000A8968
		public bool Disenchant()
		{
			try
			{
				bool result;
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43296))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.Disenchant()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43300));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43304) != 0);
					return result;
				}
				Item item = this.ca124a9f406cda69b904f2eb04d553ab9.c3a894800d31711fe060ffb224e6b66c1((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43308));
				if (item != null)
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
					if (cf47e13f19dc1dbecd5ede317687ea47f.c30767ddca1f9c207888833aea5b5fc61(item) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43312))
					{
						if (cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == 0u)
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
							if (cb90f31a9dd3759b0261d3999b5da3d35.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == 0u)
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
								if (cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == 0u)
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
									if (c6d8c1d114b637ce836465b5698ac47d0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43324))
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
										this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43328));
										result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43332) != 0);
										return result;
									}
								}
							}
						}
						if (c6d8c1d114b637ce836465b5698ac47d0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43336))
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
							if ((int)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43340))
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
								this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43344));
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43348) != 0);
								return result;
							}
						}
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c7442f77211d3dbe22267a27df00a49c3(new CoreInternal.c34ff932234b747b64f134f2f2a962e2c
						{
							cbe5fb745fb9d18c1a122f67582a2fc76 = cef937c4179bbad602e3f4568533301c4.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(item)),
							ca77899f30642d168d6dec950678a16c8 = item,
							cc8ee36ad358f5576a598ffd9bcefe33c = this
						});
						return result;
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
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43316));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43320) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43352));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43356) != 0;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		public bool SellItem()
		{
			try
			{
				bool result;
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43360))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.SellItem()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43364));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43368) != 0);
					return result;
				}
				Creature creature = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
				double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43372);
				List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43380); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43392))
				{
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43384); j < c373aa5c92f8137221210e5e355b1de40.c30767ddca1f9c207888833aea5b5fc61(cba2a1e4a94b01ef0567bb700a55d1090.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)))); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43388))
					{
						if (c07f911c05c72ccb0e9dfde40c003a708.c30767ddca1f9c207888833aea5b5fc61(cba2a1e4a94b01ef0567bb700a55d1090.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i))), j) != null)
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
							if (c79d3f0f98a99548c93495da1039a0d35.c30767ddca1f9c207888833aea5b5fc61(c07f911c05c72ccb0e9dfde40c003a708.c30767ddca1f9c207888833aea5b5fc61(cba2a1e4a94b01ef0567bb700a55d1090.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i))), j)) == 0)
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
								if (num > c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
									num = c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i));
									creature = cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i);
								}
							}
						}
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
				while (true)
				{
					switch (1)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43396));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43400) != 0);
					return result;
				}
				if (c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), creature) > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43404))
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
					if (!this.ca124a9f406cda69b904f2eb04d553ab9.c80d205e01c504d154a7b60400b29b347(c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(creature), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(creature), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(creature), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43412), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43420), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43428) != 0))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43432));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43436) != 0);
						return result;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c107d51f3d67e18d973a4cae3d327c111(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43440));
				}
				List<Item> list2 = c1ef349e2bf9e54bf0fef5229dbddddfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				c8541b26c29b7f14ee59c4feca5be3c90.c30767ddca1f9c207888833aea5b5fc61(list2, this);
				c4e579c1d55e3d1bcff54b3afa6099e38 c4e579c1d55e3d1bcff54b3afa6099e = new c4e579c1d55e3d1bcff54b3afa6099e38(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c9c772137bafe8ff99dbd90ebc261f23c.c30767ddca1f9c207888833aea5b5fc61(creature), list2);
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43444), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43448));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c4e579c1d55e3d1bcff54b3afa6099e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43452) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43456), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43460));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43464));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43468) != 0;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000AAD34 File Offset: 0x000A8F34
		public bool Unpack()
		{
			try
			{
				bool result;
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43472))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.Unpack()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43476));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43480) != 0);
					return result;
				}
				byte b = this.cf5a17939fa4c8da194e4e957b689c81b();
				if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43484))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43488));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43492) != 0);
					return result;
				}
				if ((int)b != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43496))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43500));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43504) != 0);
					return result;
				}
				if (c64145809384a756120cb409483a3a943.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) != 0)
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
					if (this.unpackDateTime <= (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43508)))
					{
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43520), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43524));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new cf7f9a6fd7d13db476ba2bc1fb748c6d0(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), this.c5e7f3c8a8196fc5311cde44e510f31f5), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43528) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43532), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43536));
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
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43512));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43516) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43540));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43544) != 0;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000AAF3C File Offset: 0x000A913C
		public bool Equip()
		{
			try
			{
				bool result;
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43548))
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
					if (!true)
					{
						RuntimeMethodHandle arg_26_0 = methodof(Item.Equip()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43552));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43556) != 0);
					return result;
				}
				cc5e73a99e59a37c7d0d271a0e30237b5 cc5e73a99e59a37c7d0d271a0e30237b = cbd2c4d4f9d4633a8a5e863012d00758c.c8a754f5f2ca4adde825691a9c31a0e83;
				switch (ccd57fed770a9c6c7c05995622f01179a.c30767ddca1f9c207888833aea5b5fc61(c5ad6f8b033ed38c785016109b84317ba.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43560))
				{
				case 0u:
				case 1u:
				case 2u:
				case 3u:
				case 4u:
				case 7u:
				{
					Item item = cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83;
					byte b = this.cf5a17939fa4c8da194e4e957b689c81b();
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43564))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43568));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43572) != 0);
						return result;
					}
					List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43576); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43584))
					{
						if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43580))
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
							if (ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == b)
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
								item = c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i);
							}
						}
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
					bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43588) != 0;
					if (item != null)
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
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43592))
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
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43596); j < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43612))
							{
								if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, j)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43600))
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
									if ((int)ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, j)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43604))
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
										flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43608) != 0);
										goto IL_24B;
									}
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
						}
					}
					IL_24B:
					if (item != null)
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
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43616))
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
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43620); k < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43636))
							{
								if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, k)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43624))
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
									if ((int)ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, k)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43628))
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
										flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43632) != 0);
										goto IL_304;
									}
								}
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
					}
					IL_304:
					if (item != null)
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
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43640))
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
							for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43644); l < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43660))
							{
								if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, l)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43648))
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
									if ((int)ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, l)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43652))
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
										flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43656) != 0);
										goto IL_3BD;
									}
								}
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
					IL_3BD:
					if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43664))
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
						if ((int)this.flags != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43668))
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
							if (this.unpackDateTime == (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43672)))
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
								if (c64145809384a756120cb409483a3a943.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43676))
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
									if (!ca43df4fd83ff82804609ff6061e906ba.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
										this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43680));
										result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43684) != 0);
										return result;
									}
								}
							}
						}
					}
					if ((int)b != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43688))
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
						if ((int)b != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43692))
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
							if ((int)b != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43696))
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
								cc5e73a99e59a37c7d0d271a0e30237b5 arg_550_0;
								if (item != null)
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
									arg_550_0 = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, item.c5e7f3c8a8196fc5311cde44e510f31f5, this.c5e7f3c8a8196fc5311cde44e510f31f5, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43700), this.cf5a17939fa4c8da194e4e957b689c81b(), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
								}
								else
								{
									arg_550_0 = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43704)), this.c5e7f3c8a8196fc5311cde44e510f31f5, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43708), this.cf5a17939fa4c8da194e4e957b689c81b(), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
								}
								cc5e73a99e59a37c7d0d271a0e30237b = arg_550_0;
								goto IL_70D;
							}
						}
					}
					if (item == null)
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
						cc5e73a99e59a37c7d0d271a0e30237b = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43712)), this.c5e7f3c8a8196fc5311cde44e510f31f5, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43716), this.cf5a17939fa4c8da194e4e957b689c81b(), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					}
					else
					{
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43720))
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
							if ((int)cba99a35f08ed344afde5565d978ef5b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43724))
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
								if ((int)cba99a35f08ed344afde5565d978ef5b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43728))
								{
									goto IL_646;
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
							cc5e73a99e59a37c7d0d271a0e30237b = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, item.c5e7f3c8a8196fc5311cde44e510f31f5, this.c5e7f3c8a8196fc5311cde44e510f31f5, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43732), this.cf5a17939fa4c8da194e4e957b689c81b(), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							goto IL_70D;
						}
						IL_646:
						if (flag)
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
							cc5e73a99e59a37c7d0d271a0e30237b = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, item.c5e7f3c8a8196fc5311cde44e510f31f5, this.c5e7f3c8a8196fc5311cde44e510f31f5, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43736), this.cf5a17939fa4c8da194e4e957b689c81b(), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						}
						else
						{
							cc5e73a99e59a37c7d0d271a0e30237b = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43740)), this.c5e7f3c8a8196fc5311cde44e510f31f5, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43744), (byte)((int)this.cf5a17939fa4c8da194e4e957b689c81b() + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43748)), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						}
					}
					IL_70D:
					if (cc5e73a99e59a37c7d0d271a0e30237b != null)
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43760), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43764));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cc5e73a99e59a37c7d0d271a0e30237b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43768) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43772), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43776));
						return result;
					}
					goto IL_78C;
				}
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43752));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43756) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			IL_78C:
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43780));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43784) != 0;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000AB714 File Offset: 0x000A9914
		public bool MakeAuctionLot(int baseSellPrice, int buyBackPrice, AuctionSellTime sellTime)
		{
			try
			{
				bool result;
				if (baseSellPrice <= cb08bd88877f002b868e84df694abadf5.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						RuntimeMethodHandle arg_24_0 = methodof(Item.MakeAuctionLot(int, int, AuctionSellTime)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43788));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43792) != 0);
					return result;
				}
				if (buyBackPrice <= cb08bd88877f002b868e84df694abadf5.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43796));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43800) != 0);
					return result;
				}
				if (buyBackPrice <= baseSellPrice)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43804));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43808) != 0);
					return result;
				}
				if (!c2a275b2b1f45365971b09c9d11afcaac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7bb3430f993bab4d3a837662a64b155b.cbac80c0356856482e0a93eed1c1fdf4f()), sellTime))
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
					sellTime = (AuctionSellTime)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43812);
				}
				uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43816);
				if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43820))
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
					if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43824))
					{
						goto IL_324;
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
				}
				if (!this.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3())
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
					Creature creature = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
					double num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43828);
					List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43836); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43840))
					{
						if (cdd801fc7821415c99b25805be8750c0a.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c30767ddca1f9c207888833aea5b5fc61(cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i))))
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
							if (num2 > c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), cda111d505683660162074f5b9c2d45e8.c30767ddca1f9c207888833aea5b5fc61(list, i)))
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
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43844));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43848) != 0);
						return result;
					}
					if (c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), creature) > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43852))
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
						if (!this.ca124a9f406cda69b904f2eb04d553ab9.c80d205e01c504d154a7b60400b29b347(c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(creature), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(creature), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(creature), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43860), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43868), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43876) != 0))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43880));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43884) != 0);
							return result;
						}
					}
					num = c9c772137bafe8ff99dbd90ebc261f23c.c30767ddca1f9c207888833aea5b5fc61(creature);
				}
				IL_324:
				c651a18215469b819dc06977377aa9018 c651a18215469b819dc06977377aa = new c651a18215469b819dc06977377aa9018(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, num, this.c5e7f3c8a8196fc5311cde44e510f31f5, baseSellPrice * cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), buyBackPrice * cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)sellTime, this.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3());
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43888), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43892));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c651a18215469b819dc06977377aa, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43896) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43900), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43904));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43908));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43912) != 0;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000ABB30 File Offset: 0x000A9D30
		public bool Dice(bool confirm)
		{
			try
			{
				bool result;
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43916))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.Dice(bool)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43920));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43924) != 0);
					return result;
				}
				c743932467ea12a6d35a8ccdeebaa63b5 c743932467ea12a6d35a8ccdeebaa63b = new c743932467ea12a6d35a8ccdeebaa63b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, confirm);
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43928), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43932));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c743932467ea12a6d35a8ccdeebaa63b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43936) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43940), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43944));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43948));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43952) != 0;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000ABC40 File Offset: 0x000A9E40
		public int auctionItemPrice()
		{
			try
			{
				uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43956);
				if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43960))
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
					if (!true)
					{
						RuntimeMethodHandle arg_39_0 = methodof(Item.auctionItemPrice()).MethodHandle;
					}
					if ((int)this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1.cfffa987bb40f5a52a78d3ae7981ae443 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43964))
					{
						goto IL_237;
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
				int result;
				if (!this.ca124a9f406cda69b904f2eb04d553ab9.c64bef5a9adcd4e1241713da72257eda3())
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
					Creature creature = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
					double num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43968);
					List<Creature> list = this.ca124a9f406cda69b904f2eb04d553ab9.c053aa2d381971d1eae89227aa4a141c5();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43976); i < cff70b3411f8759975a673e0a7c7a228e.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43980))
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
									switch (1)
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
						switch (1)
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
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43984));
						result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(43988);
						return result;
					}
					if (c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), creature) > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(43992))
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
						if (!this.ca124a9f406cda69b904f2eb04d553ab9.c80d205e01c504d154a7b60400b29b347(c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(creature), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(creature), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(creature), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(44000), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(44008), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44016) != 0))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44020));
							result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44024);
							return result;
						}
					}
					num = c9c772137bafe8ff99dbd90ebc261f23c.c30767ddca1f9c207888833aea5b5fc61(creature);
				}
				IL_237:
				ceba8edc0666ff6f7ef20b1b568150513 ceba8edc0666ff6f7ef20b1b = new ceba8edc0666ff6f7ef20b1b568150513(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, num, cd729ec847ff80bc33029eca3bd963a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)c6c84a44e73055d81bdf16c36f33dd84b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44028), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44032));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(ceba8edc0666ff6f7ef20b1b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44036) != 0);
				if (!this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44040), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44044)))
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
					result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44048);
					return result;
				}
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c2e2099ce4b34e4af5f660acb9584ab0d;
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44052));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44056);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000ABF7C File Offset: 0x000AA17C
		public bool UnEquip()
		{
			try
			{
				bool result;
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44060))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.UnEquip()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44064));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44068) != 0);
					return result;
				}
				cc5e73a99e59a37c7d0d271a0e30237b5 cc5e73a99e59a37c7d0d271a0e30237b = cbd2c4d4f9d4633a8a5e863012d00758c.c8a754f5f2ca4adde825691a9c31a0e83;
				switch (ccd57fed770a9c6c7c05995622f01179a.c30767ddca1f9c207888833aea5b5fc61(c5ad6f8b033ed38c785016109b84317ba.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44072))
				{
				case 0u:
				case 1u:
				case 2u:
				case 3u:
				case 7u:
				{
					byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44076);
					List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
					Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
					Item.c15e66fbb5c2e5ea5498569004c65e9ed c15e66fbb5c2e5ea5498569004c65e9ed = new Item.c15e66fbb5c2e5ea5498569004c65e9ed();
					c15e66fbb5c2e5ea5498569004c65e9ed.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44080);
					while ((int)c15e66fbb5c2e5ea5498569004c65e9ed.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < c7f0652385ef8939093fc0a0d1bc36723.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
					{
						object arg_FF_0 = list;
						if (predicate == null)
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
							predicate = new Predicate<Item>(c15e66fbb5c2e5ea5498569004c65e9ed.c603b3a963212677fad8856eb2a637e9e);
						}
						if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_FF_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44084))
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
							b = c15e66fbb5c2e5ea5498569004c65e9ed.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
							IL_166:
							if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44092))
							{
								this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44104));
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44108) != 0);
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
							cc5e73a99e59a37c7d0d271a0e30237b = new cc5e73a99e59a37c7d0d271a0e30237b5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44096)), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44100), b);
							if (cc5e73a99e59a37c7d0d271a0e30237b != null)
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
								this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44120), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44124));
								this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cc5e73a99e59a37c7d0d271a0e30237b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44128) != 0);
								result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44132), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44136));
								return result;
							}
							goto IL_287;
						}
						else
						{
							Item.c15e66fbb5c2e5ea5498569004c65e9ed expr_128 = c15e66fbb5c2e5ea5498569004c65e9ed;
							expr_128.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_128.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44088));
						}
					}
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						goto IL_166;
					}
					break;
				}
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44112));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44116) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			IL_287:
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44140));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44144) != 0;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000AC250 File Offset: 0x000AA450
		public bool CofferMerge(Item anotherItem)
		{
			try
			{
				bool result;
				if (anotherItem != null)
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
						RuntimeMethodHandle arg_15_0 = methodof(Item.CofferMerge(Item)).MethodHandle;
					}
					if (c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) == null)
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
					}
					else
					{
						if (cd729ec847ff80bc33029eca3bd963a73.c30767ddca1f9c207888833aea5b5fc61(anotherItem) != cd729ec847ff80bc33029eca3bd963a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44156));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44160) != 0);
							return result;
						}
						if (c2ba3edfe4b9c4b0318ffde8f873ca34d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							if (c2ba3edfe4b9c4b0318ffde8f873ca34d.c30767ddca1f9c207888833aea5b5fc61(anotherItem) != cf47e13f19dc1dbecd5ede317687ea47f.c30767ddca1f9c207888833aea5b5fc61(anotherItem))
							{
								if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(anotherItem) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44172))
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
									if ((int)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44176))
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
										this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44180));
										result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44184) != 0);
										return result;
									}
								}
								this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44188), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44192));
								this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new ce413cc7a0cd3fbd8c1502d16a12b24a5(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, anotherItem.c5e7f3c8a8196fc5311cde44e510f31f5, ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(anotherItem), (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(anotherItem), c34f0f68932ceb7756e2775a73f05347d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c2ba3edfe4b9c4b0318ffde8f873ca34d.c30767ddca1f9c207888833aea5b5fc61(anotherItem) - cf47e13f19dc1dbecd5ede317687ea47f.c30767ddca1f9c207888833aea5b5fc61(anotherItem), cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c100701ce96fc862a17d04c8608db429b.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()).cadab02f2f80fd2ebe9b14ca573098990), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44196) != 0);
								result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44200), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44204));
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44164));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44168) != 0);
						return result;
					}
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44148));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44152) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44208));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44212) != 0;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000AC4D8 File Offset: 0x000AA6D8
		public bool Merge(Item anotherItem)
		{
			try
			{
				bool result;
				if (anotherItem == null)
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
						RuntimeMethodHandle arg_15_0 = methodof(Item.Merge(Item)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44216));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44220) != 0);
					return result;
				}
				if (cd729ec847ff80bc33029eca3bd963a73.c30767ddca1f9c207888833aea5b5fc61(anotherItem) != cd729ec847ff80bc33029eca3bd963a73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44224));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44228) != 0);
					return result;
				}
				if (c2ba3edfe4b9c4b0318ffde8f873ca34d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					if (c2ba3edfe4b9c4b0318ffde8f873ca34d.c30767ddca1f9c207888833aea5b5fc61(anotherItem) != cf47e13f19dc1dbecd5ede317687ea47f.c30767ddca1f9c207888833aea5b5fc61(anotherItem))
					{
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44240), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44244));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new c2b457856823ca1886140faec87998fd0(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, this.c5e7f3c8a8196fc5311cde44e510f31f5, anotherItem.c5e7f3c8a8196fc5311cde44e510f31f5, (byte)cf8438396b9ff16695611b7ce5da482cd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccc55533c89d44981b0bc2fce18a011d2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (byte)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(anotherItem), ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(anotherItem), c34f0f68932ceb7756e2775a73f05347d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c2ba3edfe4b9c4b0318ffde8f873ca34d.c30767ddca1f9c207888833aea5b5fc61(anotherItem) - cf47e13f19dc1dbecd5ede317687ea47f.c30767ddca1f9c207888833aea5b5fc61(anotherItem), cf47e13f19dc1dbecd5ede317687ea47f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44248) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44252), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44256));
						return result;
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
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44232));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44236) != 0);
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44260));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44264) != 0;
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x000AC6C4 File Offset: 0x000AA8C4
		public uint categoryId
		{
			get
			{
				if (c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Item.get_categoryId()).MethodHandle;
					}
					return c6d8c1d114b637ce836465b5698ac47d0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44268);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000AC708 File Offset: 0x000AA908
		internal string c30a40b15f50066326ad53010777fb040()
		{
			switch (cb54c4b1ad9e558e2d77d9581d7430570.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
			{
			case 0:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191686);
			case 1:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191695);
			case 2:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191708);
			case 3:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191719);
			case 4:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191728);
			case 5:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191735);
			case 6:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191750);
			case 7:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191787);
			case 8:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191796);
			case 9:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191821);
			case 10:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191846);
			case 11:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191871);
			case 12:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191894);
			case 13:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191907);
			case 14:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191924);
			case 15:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191937);
			case 16:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191966);
			case 17:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(191991);
			case 18:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192016);
			case 19:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192031);
			case 20:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192060);
			case 21:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192077);
			case 22:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192090);
			case 23:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192107);
			case 24:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192128);
			case 25:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192147);
			case 26:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192164);
			case 27:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192187);
			case 28:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192200);
			default:
				return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192231);
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x000AC92C File Offset: 0x000AAB2C
		public EquipItemPlace equipCell
		{
			get
			{
				uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44272);
				if (cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44276))
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
						RuntimeMethodHandle arg_38_0 = methodof(Item.get_equipCell()).MethodHandle;
					}
					num = cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				else if (cb90f31a9dd3759b0261d3999b5da3d35.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44280))
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
					num = cb90f31a9dd3759b0261d3999b5da3d35.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				else if (cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44284))
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
					num = c9f70965e52327e6d9f6d7dca5fb93081.c30767ddca1f9c207888833aea5b5fc61(c97fffca4057b0acd832bee8d616d59fb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
				}
				if (num == 0u)
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
					return (EquipItemPlace)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44288);
				}
				switch (num - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44292))
				{
				case 0u:
				case 1u:
				case 2u:
				case 3u:
				case 4u:
				case 5u:
				case 6u:
				case 7u:
				case 8u:
				case 9u:
				case 10u:
				case 11u:
				case 12u:
				case 13u:
				case 14u:
				case 15u:
				case 16u:
				case 17u:
				case 18u:
				case 19u:
				case 20u:
				case 21u:
				case 22u:
				case 23u:
				case 24u:
				case 26u:
				case 27u:
				case 28u:
				case 29u:
				case 30u:
					return (EquipItemPlace)num;
				}
				return (EquipItemPlace)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44296);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000ACAB0 File Offset: 0x000AACB0
		internal byte cf5a17939fa4c8da194e4e957b689c81b()
		{
			uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44300);
			if (cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44304))
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
					RuntimeMethodHandle arg_38_0 = methodof(Item.cf5a17939fa4c8da194e4e957b689c81b()).MethodHandle;
				}
				num = cb2d3b916c0a0ffd162e2762681852f84.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
			else if (cb90f31a9dd3759b0261d3999b5da3d35.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44308))
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
				num = cb90f31a9dd3759b0261d3999b5da3d35.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
			else if (cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44312))
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
				num = c9f70965e52327e6d9f6d7dca5fb93081.c30767ddca1f9c207888833aea5b5fc61(c97fffca4057b0acd832bee8d616d59fb.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			}
			else if ((int)c9bdc4ead862301b704f033eaea2334f5.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44316))
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
				num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44320);
			}
			if (num == 0u)
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
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44324);
			}
			switch (num - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44328))
			{
			case 0u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44332);
			case 1u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44336);
			case 2u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44340);
			case 3u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44344);
			case 4u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44348);
			case 5u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44352);
			case 6u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44356);
			case 7u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44360);
			case 8u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44364);
			case 9u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44368);
			case 10u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44372);
			case 13u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44376);
			case 15u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44380);
			case 16u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44384);
			case 17u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44388);
			case 19u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44392);
			case 20u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44396);
			case 29u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44400);
			case 30u:
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44404);
			}
			return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44408);
		}

		// Token: 0x04000DC7 RID: 3527
		internal ulong c5e7f3c8a8196fc5311cde44e510f31f5;

		// Token: 0x04000DC8 RID: 3528
		public byte flags;

		// Token: 0x04000DC9 RID: 3529
		public long creationTime;

		// Token: 0x04000DCA RID: 3530
		public int lifespanMins;

		// Token: 0x04000DCB RID: 3531
		internal int c00ba7721e675d85491fb47b1da510770;

		// Token: 0x04000DCC RID: 3532
		internal byte cf7f9dd41b0e6b39e2c5be23b31594c5c;

		// Token: 0x04000DCD RID: 3533
		public ulong unsecureDateTime;

		// Token: 0x04000DCE RID: 3534
		public ulong unpackDateTime;

		// Token: 0x04000DCF RID: 3535
		public ulong chargeUseSkillTime;

		// Token: 0x04000DD0 RID: 3536
		internal byte caa4ea5102947e21fbeed63ea8d80ffaf;

		// Token: 0x04000DD1 RID: 3537
		internal byte[] c95fcf4e5a5d90a94bd0a5cc677860a82;

		// Token: 0x04000DD2 RID: 3538
		private uint c61bc5e8f62c5d6fafe2c279819422ee0;

		// Token: 0x04000DD3 RID: 3539
		private double ced32a28d6a75b3d35484c81ca8368150;

		// Token: 0x04000DD4 RID: 3540
		private double cf462ae70b14e8ef41780dbe346523942;

		// Token: 0x04000DD5 RID: 3541
		[CompilerGenerated]
		private long c7495caa10f599eb5562f3730d338b153;

		// Token: 0x04000DD6 RID: 3542
		[CompilerGenerated]
		private ushort caef1fa4f995cf1c58426e701a29923e8;

		// Token: 0x04000DD7 RID: 3543
		[CompilerGenerated]
		private double c5438c1652096ac52fb58655175b8b3bd;

		// Token: 0x04000DD8 RID: 3544
		[CompilerGenerated]
		private double cc4cbadf5dc5487429910387dbaee05e7;

		// Token: 0x04000DD9 RID: 3545
		[CompilerGenerated]
		private double cd6c17d169d896afe8b6fbff7e8523a81;

		// Token: 0x04000DDA RID: 3546
		[CompilerGenerated]
		private double cd584e1e0977d19635be65e7c6a216051;

		// Token: 0x04000DDB RID: 3547
		[CompilerGenerated]
		private double c04d7c95d11e35568b74e0c7cff4774eb;

		// Token: 0x04000DDC RID: 3548
		[CompilerGenerated]
		private double cf2bed8ccda2964f286672fb6bf3b7d66;

		// Token: 0x04000DDD RID: 3549
		[CompilerGenerated]
		private float c3b50d9d86a62f05784cc0317f6fd8609;

		// Token: 0x04000DDE RID: 3550
		[CompilerGenerated]
		private bool c295a65b0a6a3fe8f58e298fbccdb8514;

		// Token: 0x04000DDF RID: 3551
		[CompilerGenerated]
		private byte c6d44529d0e6764d0d35f209c58b64fcb;

		// Token: 0x04000DE0 RID: 3552
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000DE1 RID: 3553
		[CompilerGenerated]
		private ItemGrade c6ec90c43376ad73d515e7843992dcc36;

		// Token: 0x04000DE2 RID: 3554
		[CompilerGenerated]
		private List<uint> cc3227d10105d5434c07621fb3cc1925c;

		// Token: 0x04000DE3 RID: 3555
		[CompilerGenerated]
		private List<uint> ce2bd68fc1012565c7119697ab8d8e3cd;

		// Token: 0x04000DE4 RID: 3556
		[CompilerGenerated]
		private int c6621bffb628c518f8c4b4c8f86047ee4;

		// Token: 0x04000DE5 RID: 3557
		[CompilerGenerated]
		private ItemPlace c93d9e6a457fa582574acb8df75ed24ff;

		// Token: 0x04000DE6 RID: 3558
		[CompilerGenerated]
		private byte ca1a8f3551c98c6d96e005f2655e91b78;

		// Token: 0x04000DE7 RID: 3559
		[CompilerGenerated]
		private double c599fbb9df2db86b9c95761f1bf684fc1;

		// Token: 0x04000DE8 RID: 3560
		[CompilerGenerated]
		private double cc6f9d811478a319068246c593cad1bd1;

		// Token: 0x04000DE9 RID: 3561
		[CompilerGenerated]
		private double c5cdfcffbc2da5f389dd8c35b9be1a9a1;

		// Token: 0x04000DEA RID: 3562
		[CompilerGenerated]
		private double cc0634feba6dc0decfc2fbe554d97e792;

		// Token: 0x04000DEB RID: 3563
		[CompilerGenerated]
		private double c670ea6f59cfa71a131f5c86d2515295f;

		// Token: 0x04000DEC RID: 3564
		[CompilerGenerated]
		private double c554792414442459a0eb441aec6c3d694;

		// Token: 0x04000DED RID: 3565
		[CompilerGenerated]
		private SqlItem cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x04000DEE RID: 3566
		[CompilerGenerated]
		private ArmorSet c4eb2294f34e18564078da1a2cb455945;

		// Token: 0x0200059B RID: 1435
		[CompilerGenerated]
		private sealed class ce14266bfc174f8ef900ac89c247005e8
		{
			// Token: 0x06001FB9 RID: 8121 RVA: 0x00148958 File Offset: 0x00146B58
			public bool c13edf63d3828edf07234e53c5c3f292b(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99048))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.ce14266bfc174f8ef900ac89c247005e8.c13edf63d3828edf07234e53c5c3f292b(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99052) != 0;
			}

			// Token: 0x0400153C RID: 5436
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x0200059C RID: 1436
		[CompilerGenerated]
		private sealed class c6699ea3178e1dc4a893559c0715bcc96
		{
			// Token: 0x06001FBB RID: 8123 RVA: 0x001489BC File Offset: 0x00146BBC
			public bool c51a30f3809fee2b9e169257ecb86a0b1(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99056))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.c6699ea3178e1dc4a893559c0715bcc96.c51a30f3809fee2b9e169257ecb86a0b1(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99060) != 0;
			}

			// Token: 0x0400153D RID: 5437
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x0200059D RID: 1437
		[CompilerGenerated]
		private sealed class c0dd06b5b5030a93cd96b9ce168100230
		{
			// Token: 0x06001FBD RID: 8125 RVA: 0x00148A20 File Offset: 0x00146C20
			public bool c5bc05e5cd4898bc83898fbb9cc213e3f(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99064))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.c0dd06b5b5030a93cd96b9ce168100230.c5bc05e5cd4898bc83898fbb9cc213e3f(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99068) != 0;
			}

			// Token: 0x0400153E RID: 5438
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x0200059E RID: 1438
		[CompilerGenerated]
		private sealed class c515cdc3ad0a192be6c6c1d608c85b45d
		{
			// Token: 0x06001FBF RID: 8127 RVA: 0x00148A84 File Offset: 0x00146C84
			public bool cddcb817ff5a52be26d79d813f91741b7(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99072))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.c515cdc3ad0a192be6c6c1d608c85b45d.cddcb817ff5a52be26d79d813f91741b7(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99076) != 0;
			}

			// Token: 0x0400153F RID: 5439
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x0200059F RID: 1439
		[CompilerGenerated]
		private sealed class c4153aa1952a004ac640215cd42a2716a
		{
			// Token: 0x06001FC1 RID: 8129 RVA: 0x00148AE8 File Offset: 0x00146CE8
			public bool c73179ce1b74e4c10da416628cf8af0e1(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99080))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.c4153aa1952a004ac640215cd42a2716a.c73179ce1b74e4c10da416628cf8af0e1(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99084) != 0;
			}

			// Token: 0x04001540 RID: 5440
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x020005A0 RID: 1440
		[CompilerGenerated]
		private sealed class c4dd61e6d21e7ea66f95c917a6413cf78
		{
			// Token: 0x06001FC3 RID: 8131 RVA: 0x00148B4C File Offset: 0x00146D4C
			public bool c7df2cb9e6da47ec81cc4de8e06a068cd(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99088))
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
						RuntimeMethodHandle arg_26_0 = methodof(Item.c4dd61e6d21e7ea66f95c917a6413cf78.c7df2cb9e6da47ec81cc4de8e06a068cd(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99092) != 0;
			}

			// Token: 0x04001541 RID: 5441
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}

		// Token: 0x020005A1 RID: 1441
		[CompilerGenerated]
		private sealed class c15e66fbb5c2e5ea5498569004c65e9ed
		{
			// Token: 0x06001FC5 RID: 8133 RVA: 0x00148BB0 File Offset: 0x00146DB0
			public bool c603b3a963212677fad8856eb2a637e9e(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99096))
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
					if (!true)
					{
						RuntimeMethodHandle arg_26_0 = methodof(Item.c15e66fbb5c2e5ea5498569004c65e9ed.c603b3a963212677fad8856eb2a637e9e(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99100) != 0;
			}

			// Token: 0x04001542 RID: 5442
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}
	}
}
