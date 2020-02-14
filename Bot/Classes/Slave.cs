using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004DB RID: 1243
	public class Slave : Creature
	{
		// Token: 0x060014F0 RID: 5360 RVA: 0x000B82F0 File Offset: 0x000B64F0
		internal Slave(CoreInternal coreInternal) : base(coreInternal)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48252));
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000B831C File Offset: 0x000B651C
		// (set) Token: 0x060014F2 RID: 5362 RVA: 0x000B8330 File Offset: 0x000B6530
		public uint slaveId
		{
			get;
			internal set;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x000B8344 File Offset: 0x000B6544
		// (set) Token: 0x060014F4 RID: 5364 RVA: 0x000B8358 File Offset: 0x000B6558
		public SqlSlave slaveDb
		{
			get;
			internal set;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000B836C File Offset: 0x000B656C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Slave.Dispose(bool)).MethodHandle;
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
						cded19473ef07fffdbb69b9afea18fb93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4d31853742cf9c465cece0f821841480.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c064406586f024f64cd7a842e6df41011.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000B83D8 File Offset: 0x000B65D8
		internal void cfa839ca3efd3f7cff12b0ba761057930()
		{
			cded19473ef07fffdbb69b9afea18fb93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c574048b644741740aff3d3304ed0e571.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (ccdc1150ab96263831b365f97b441169c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48248))
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
					RuntimeMethodHandle arg_36_0 = methodof(Slave.cfa839ca3efd3f7cff12b0ba761057930()).MethodHandle;
				}
				try
				{
					if (c60410ca0f1f5f22a8ee59b6630fd8b2c.c30767ddca1f9c207888833aea5b5fc61(c16c4f5bd1c2c59a0ee3ff4d79746903c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), ccdc1150ab96263831b365f97b441169c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						cded19473ef07fffdbb69b9afea18fb93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c211bd68403336f07c3228b30f62972b0.c30767ddca1f9c207888833aea5b5fc61(c16c4f5bd1c2c59a0ee3ff4d79746903c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), ccdc1150ab96263831b365f97b441169c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}
		}

		// Token: 0x04000F09 RID: 3849
		[CompilerGenerated]
		private uint ca35ac92612cfe4f2e55f35153a7a1b86;

		// Token: 0x04000F0A RID: 3850
		[CompilerGenerated]
		private SqlSlave cf9bc2f0db5ab7d76a3fb626a39351c59;
	}
}
