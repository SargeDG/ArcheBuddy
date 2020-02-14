using System;
using System.Threading;

namespace A
{
	// Token: 0x02000086 RID: 134
	internal sealed class c1f315ef57f53b9718c486d2471a987ab : IAsyncResult
	{
		// Token: 0x0600023B RID: 571 RVA: 0x000293C4 File Offset: 0x000275C4
		internal void c6c9a6f07edc27011d83bc50fc1382300(object obj)
		{
			this.c41c047ecfbc1e451a48e3c798385f238 = obj;
			this.c963393677ec3cc93625e618aa9543282 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8388) != 0);
			if (this.c39b54c4bf9580376592609fb76fa69df != null)
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
					RuntimeMethodHandle arg_31_0 = methodof(c1f315ef57f53b9718c486d2471a987ab.c6c9a6f07edc27011d83bc50fc1382300(object)).MethodHandle;
				}
				c032afe3d58d18d870d19651ec22dbfab.c30767ddca1f9c207888833aea5b5fc61(this.c39b54c4bf9580376592609fb76fa69df);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00029414 File Offset: 0x00027614
		internal void c1c3ee78352ffb5c52d0096365bac8d8c()
		{
			this.c41c047ecfbc1e451a48e3c798385f238 = c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83;
			this.c963393677ec3cc93625e618aa9543282 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8392) != 0);
			if (this.c39b54c4bf9580376592609fb76fa69df != null)
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
					RuntimeMethodHandle arg_35_0 = methodof(c1f315ef57f53b9718c486d2471a987ab.c1c3ee78352ffb5c52d0096365bac8d8c()).MethodHandle;
				}
				c264d1fcae864f49479a34111fa59b3f3.c30767ddca1f9c207888833aea5b5fc61(this.c39b54c4bf9580376592609fb76fa69df);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00029468 File Offset: 0x00027668
		public bool IsCompleted
		{
			get
			{
				return this.c963393677ec3cc93625e618aa9543282;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0002947C File Offset: 0x0002767C
		public bool CompletedSynchronously
		{
			get
			{
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8396) != 0;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00029494 File Offset: 0x00027694
		public object AsyncState
		{
			get
			{
				return this.c41c047ecfbc1e451a48e3c798385f238;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000240 RID: 576 RVA: 0x000294A8 File Offset: 0x000276A8
		public WaitHandle AsyncWaitHandle
		{
			get
			{
				ManualResetEvent arg_37_0;
				if ((arg_37_0 = this.c39b54c4bf9580376592609fb76fa69df) == null)
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
						RuntimeMethodHandle arg_1B_0 = methodof(c1f315ef57f53b9718c486d2471a987ab.get_AsyncWaitHandle()).MethodHandle;
					}
					arg_37_0 = (this.c39b54c4bf9580376592609fb76fa69df = caabe51f782f409cc88b8c4a3324ef361.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8400) != 0));
				}
				return arg_37_0;
			}
		}

		// Token: 0x040001BF RID: 447
		internal bool c963393677ec3cc93625e618aa9543282 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8404) != 0;

		// Token: 0x040001C0 RID: 448
		private object c41c047ecfbc1e451a48e3c798385f238;

		// Token: 0x040001C1 RID: 449
		private ManualResetEvent c39b54c4bf9580376592609fb76fa69df;
	}
}
