using System;
using System.Threading;
using System.Threading.Tasks;

namespace A
{
	// Token: 0x020000EE RID: 238
	internal sealed class c5608b10866fb51d01ed3b370981d5a36
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x00046D3C File Offset: 0x00044F3C
		public c5608b10866fb51d01ed3b370981d5a36(Action action)
		{
			this.cc96fdc36ffda944243be714cbd274747 = new CancellationTokenSource();
			this.c96b9dabde6b09c0ecc8c9f36004aa61f = new Task(action, c3d290efadf86f323aba16be13c1c69c0.c30767ddca1f9c207888833aea5b5fc61(this.cc96fdc36ffda944243be714cbd274747));
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00046D74 File Offset: 0x00044F74
		public CancellationToken get_ca272c82a278446087fe3f9ff0fcaeb36()
		{
			return c3d290efadf86f323aba16be13c1c69c0.c30767ddca1f9c207888833aea5b5fc61(this.cc96fdc36ffda944243be714cbd274747);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00046D90 File Offset: 0x00044F90
		public void c394a455ecb395082a97c96c8bc327668()
		{
			if (this.c96b9dabde6b09c0ecc8c9f36004aa61f != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c5608b10866fb51d01ed3b370981d5a36.c394a455ecb395082a97c96c8bc327668()).MethodHandle;
				}
				c7db93b9a656b3df21ff0704b0d541b67.c30767ddca1f9c207888833aea5b5fc61(this.c96b9dabde6b09c0ecc8c9f36004aa61f);
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00046DC4 File Offset: 0x00044FC4
		public bool c107da2149e44370fff359cf6961b84df()
		{
			try
			{
				cc82c1acaaa4628eed9e07ebcfeca71e3.c30767ddca1f9c207888833aea5b5fc61(this.cc96fdc36ffda944243be714cbd274747);
				return cb0ed54cde4a17c1c8e54f0a0e6ef1391.c30767ddca1f9c207888833aea5b5fc61(this.c96b9dabde6b09c0ecc8c9f36004aa61f, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15628));
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15632) != 0;
		}

		// Token: 0x0400044E RID: 1102
		private Task c96b9dabde6b09c0ecc8c9f36004aa61f;

		// Token: 0x0400044F RID: 1103
		private CancellationTokenSource cc96fdc36ffda944243be714cbd274747;
	}
}
