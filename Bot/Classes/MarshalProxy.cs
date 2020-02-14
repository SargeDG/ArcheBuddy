using System;
using System.Collections.Generic;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200000B RID: 11
	public class MarshalProxy : MarshalByRefObject, IDisposable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		protected virtual IEnumerable<MarshalByRefObject> NestedMarshalByRefObjects
		{
			get
			{
				MarshalProxy.c751ef1cc2254be5e971d3d04beaf199a c751ef1cc2254be5e971d3d04beaf199a = new MarshalProxy.c751ef1cc2254be5e971d3d04beaf199a(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1852));
				c751ef1cc2254be5e971d3d04beaf199a.cb6ea3d298d68be569f5410cc290458d5 = this;
				return c751ef1cc2254be5e971d3d04beaf199a;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000F200 File Offset: 0x0000D400
		protected override void Finalize()
		{
			try
			{
				ca28425a9d6cfce8454770e0a33769fc5.c30767ddca1f9c207888833aea5b5fc61(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1856) != 0);
			}
			finally
			{
				cea01677aa5a0fc5ad215e2391fbeb4d7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000F238 File Offset: 0x0000D438
		private void c14985a2e92ecf1a8384f754b2b149e10()
		{
			try
			{
				ce9fd46785583096fee8fb02ddda26d18.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				IEnumerator<MarshalByRefObject> enumerator = ca4ad43015a8dbb2900d4ce086c26d340.c30767ddca1f9c207888833aea5b5fc61(cd1e29def0a3690a5c73342ebbe10ed7d.c30767ddca1f9c207888833aea5b5fc61(this));
				try
				{
					while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
					{
						MarshalByRefObject marshalByRefObject = c5a1a15ae0594e4c87eeafc205e29f523.c30767ddca1f9c207888833aea5b5fc61(enumerator);
						ce9fd46785583096fee8fb02ddda26d18.c0cf59c3e67a46fd4edb3040c5ab0bbfb(marshalByRefObject);
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
					if (!true)
					{
						RuntimeMethodHandle arg_49_0 = methodof(MarshalProxy.c14985a2e92ecf1a8384f754b2b149e10()).MethodHandle;
					}
				}
				finally
				{
					if (enumerator != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(enumerator);
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33332), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ca91d21069c5b692ab95faf05f524cf96.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33409), cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex)));
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000F304 File Offset: 0x0000D504
		public sealed override object InitializeLifetimeService()
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000F314 File Offset: 0x0000D514
		public void Dispose()
		{
			ca28425a9d6cfce8454770e0a33769fc5.c30767ddca1f9c207888833aea5b5fc61(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1860) != 0);
			c2406ad1b267333a3a3eb5c5254809f89.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000F338 File Offset: 0x0000D538
		protected virtual void Dispose(bool disposing)
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
					RuntimeMethodHandle arg_1A_0 = methodof(MarshalProxy.Dispose(bool)).MethodHandle;
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
					this.c14985a2e92ecf1a8384f754b2b149e10();
				}
				this._disposed = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(1864) != 0);
			}
		}

		// Token: 0x04000016 RID: 22
		protected bool _disposed;
	}
}
