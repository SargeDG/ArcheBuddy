using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004BC RID: 1212
	public class Faction : BaseObject
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x000A352C File Offset: 0x000A172C
		internal Faction()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39556));
			this.c128ba3ab99e15f5da050396ad89d2c02 = new List<c8e859d5941fddc0258f0666c5c40d341>();
			c36edeaec007e4da9eb31aa6f1af94f2e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c9065fc0e47963db23282fea2f0c7054a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x000A3570 File Offset: 0x000A1770
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
						RuntimeMethodHandle arg_1D_0 = methodof(Faction.Dispose(bool)).MethodHandle;
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c128ba3ab99e15f5da050396ad89d2c02))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39500); i < c1a59d0c319b59357a0308c140bc926c0.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39504))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(ce51995a42bdd1538dc3ae803160299a9.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02, i));
								cd0f932097e693a595cec9bc08a4c86fa.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02, i, c918c7d5cd17085bf4fb8deeb4d9fdca0.c8a754f5f2ca4adde825691a9c31a0e83);
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
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000A3658 File Offset: 0x000A1858
		internal byte ccb7030161d29d6219f665fd95f38ce45(Faction faction)
		{
			if (faction == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(Faction.ccb7030161d29d6219f665fd95f38ce45(Faction)).MethodHandle;
				}
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39508);
			}
			if (c8781b615d84fd4b2190e27330b9f6df2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == c8781b615d84fd4b2190e27330b9f6df2.c30767ddca1f9c207888833aea5b5fc61(faction))
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
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39512);
			}
			if (c8781b615d84fd4b2190e27330b9f6df2.c30767ddca1f9c207888833aea5b5fc61(faction) != (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39516))
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
				if (c8781b615d84fd4b2190e27330b9f6df2.c30767ddca1f9c207888833aea5b5fc61(faction) == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39520))
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
				}
				else
				{
					if (c8781b615d84fd4b2190e27330b9f6df2.c30767ddca1f9c207888833aea5b5fc61(faction) == (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39528))
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
						return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39532);
					}
					byte result;
					using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c128ba3ab99e15f5da050396ad89d2c02))
					{
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39536); i < c1a59d0c319b59357a0308c140bc926c0.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39540))
						{
							if (ce51995a42bdd1538dc3ae803160299a9.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02, i).c70444a246e42110b1f35f405adb0d7cd == c8781b615d84fd4b2190e27330b9f6df2.c30767ddca1f9c207888833aea5b5fc61(faction))
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
								result = ce51995a42bdd1538dc3ae803160299a9.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02, i).cd62b5a6a2d2a94d7ff359c9ba9ee79c9;
								return result;
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
						result = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39544);
					}
					return result;
				}
			}
			return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39524);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000A37C8 File Offset: 0x000A19C8
		internal c8e859d5941fddc0258f0666c5c40d341 cf9a599f6df82d59405a1b9dadbcf8e32(Faction faction)
		{
			if (faction == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(Faction.cf9a599f6df82d59405a1b9dadbcf8e32(Faction)).MethodHandle;
				}
				return null;
			}
			c8e859d5941fddc0258f0666c5c40d341 result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c128ba3ab99e15f5da050396ad89d2c02))
			{
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39548); i < c1a59d0c319b59357a0308c140bc926c0.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(39552))
				{
					if (ce51995a42bdd1538dc3ae803160299a9.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02, i).c70444a246e42110b1f35f405adb0d7cd == c8781b615d84fd4b2190e27330b9f6df2.c30767ddca1f9c207888833aea5b5fc61(faction))
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
						result = ce51995a42bdd1538dc3ae803160299a9.c30767ddca1f9c207888833aea5b5fc61(this.c128ba3ab99e15f5da050396ad89d2c02, i);
						return result;
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
				result = c918c7d5cd17085bf4fb8deeb4d9fdca0.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x000A3890 File Offset: 0x000A1A90
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x000A38A4 File Offset: 0x000A1AA4
		internal uint id
		{
			get;
			set;
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x000A38B8 File Offset: 0x000A1AB8
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x000A38CC File Offset: 0x000A1ACC
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x000A38E0 File Offset: 0x000A1AE0
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x000A38F4 File Offset: 0x000A1AF4
		public string leaderName
		{
			get;
			internal set;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x000A3908 File Offset: 0x000A1B08
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x000A391C File Offset: 0x000A1B1C
		internal uint motherId
		{
			get;
			set;
		}

		// Token: 0x04000DA2 RID: 3490
		internal List<c8e859d5941fddc0258f0666c5c40d341> c128ba3ab99e15f5da050396ad89d2c02;

		// Token: 0x04000DA3 RID: 3491
		internal byte c7dcaefb03cb7b614baae37710b472ed0;

		// Token: 0x04000DA4 RID: 3492
		internal byte c2a1bb60fd1c038198cea57346936f72d;

		// Token: 0x04000DA5 RID: 3493
		internal uint cdd242441367759d8bb887f723e7e7e60;

		// Token: 0x04000DA6 RID: 3494
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000DA7 RID: 3495
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000DA8 RID: 3496
		[CompilerGenerated]
		private string cf30306e1976cbd428e7534d89a8bdefb;

		// Token: 0x04000DA9 RID: 3497
		[CompilerGenerated]
		private uint c588ff1daf070b96b9d6a9ed833758102;
	}
}
