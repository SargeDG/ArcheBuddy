using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x0200055E RID: 1374
	internal sealed class c49a205a8d962eedc10d0ad1e8ae458d7 : IDisposable
	{
		// Token: 0x06001ECA RID: 7882 RVA: 0x0013AF7C File Offset: 0x0013917C
		public c49a205a8d962eedc10d0ad1e8ae458d7()
		{
			this.cc4933387b7398585e4ac7c2736397eaa = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94748);
			this.cce16cf6331b22aef15107891bdf57eca = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94752);
			this.cf62a06241405cafeceff1f6f7ef2f6a0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94756);
			this.cbac639dc2b6ae345dea54e81d63aaeba = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94760);
			this.c6aa6f3f9369ea4394738a6a63bec71df = new List<Creature>();
			this.c033ec32542a62ff7bb333ca5d79d7a54 = new List<c49a205a8d962eedc10d0ad1e8ae458d7.c788d1c53fd6e7f5eb9c346e54085f0a9>();
			this.c62e5e513abb5063974acc31b79637541 = new List<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073>();
			this.c421fb20deb3493b7354efc883436c236 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
			this.ca53c5b83901742f3960c4c2f6f8db8da = c3464c619452e93f87bc4ef75a5d2127d.c8a754f5f2ca4adde825691a9c31a0e83;
			this.c070221483a03e30b41847ae8c9e91b73 = c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83;
			this.c8afb385ec3cd6a1a272d6c8b598e450d = cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83;
			this.c9f49c0f8031bd8d77090b6288b12e3af = "";
			this.c4133f594a82980efa774a1f80ec2e7d6 = "";
			this.cb5cc6fce1d5e448f1036e9fe27b02d90 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94764);
			this.c5141f2afeb0658864fbb726b9b39019c = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94768) != 0);
			this.c15fbc486ff1db75d26e24a819e161fcd = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94772);
			this.cf97a3a4af47c09e794d9f87473b3c207 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94776);
			this.c6ec35cf408882bb2d811448e8370e6eb = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94780);
			this.c7638c303ac8d153fac42249270d9a295 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94784);
			this.c94adb236938861a7e3d6aa41b463a207 = (c3868c260cbcbd410f8d406152ebc69de)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94788);
			this.c3d616526648fdcf0698e47042a66c10e = (short)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94792);
			this.cc4b4558d560ab3e630ce5a26ee66d972 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94796);
			this.c65d04bd6bca9df7aa5403ab9407bcfcf = new List<c49a205a8d962eedc10d0ad1e8ae458d7.c01cf1002d5d02c191da9e03d18de4f93>();
			this.c93d36da52406e10ce418b0fb04e937f2 = new List<c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6>();
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0013B0F4 File Offset: 0x001392F4
		public void Dispose()
		{
			this.ce9469897e949300f7173f73753387ef9(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94720) != 0);
			c2406ad1b267333a3a3eb5c5254809f89.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0013B118 File Offset: 0x00139318
		protected override void Finalize()
		{
			try
			{
				this.ce9469897e949300f7173f73753387ef9(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94724) != 0);
			}
			finally
			{
				cea01677aa5a0fc5ad215e2391fbeb4d7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0013B150 File Offset: 0x00139350
		protected virtual void ce9469897e949300f7173f73753387ef9(bool flag)
		{
			try
			{
				if (!this.cc3bee16b81d51bea12e1e52f129f2941)
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
						RuntimeMethodHandle arg_1D_0 = methodof(c49a205a8d962eedc10d0ad1e8ae458d7.ce9469897e949300f7173f73753387ef9(bool)).MethodHandle;
					}
					if (flag)
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
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94728); i < c360fbaf2593658489c76c52e8a858def.c30767ddca1f9c207888833aea5b5fc61(this.c93d36da52406e10ce418b0fb04e937f2); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94732))
						{
							cb9c358038bc00bbea940c4d1e6541cb7.c30767ddca1f9c207888833aea5b5fc61(this.c93d36da52406e10ce418b0fb04e937f2, i).c60958cc55162377476d7d7bef4bae994 = c55979e64ed92c0332c9cd25a31759b4a.c8a754f5f2ca4adde825691a9c31a0e83;
							c24fdf3b808811dcd9ff0ed96d630398e.c30767ddca1f9c207888833aea5b5fc61(cb9c358038bc00bbea940c4d1e6541cb7.c30767ddca1f9c207888833aea5b5fc61(this.c93d36da52406e10ce418b0fb04e937f2, i).c4133f594a82980efa774a1f80ec2e7d6);
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
						for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94736); j < cc8ac91c4563b641ba9983a1cc6eb0aed.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94740))
						{
							if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).ce6c00421af254c6db10d7dff44e28b07 != null)
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
								c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).ce6c00421af254c6db10d7dff44e28b07);
							}
							if (cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).c1f281a3e2463722c4175a1fced6212ab != null)
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
								c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).c1f281a3e2463722c4175a1fced6212ab);
							}
							c24fdf3b808811dcd9ff0ed96d630398e.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).c853ac4dc5a4ebc1f368bca44ec315f27);
							c24fdf3b808811dcd9ff0ed96d630398e.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).c420fce48164d5b865ad42e614cfe582f);
							cadac0fba7141cfa15e9859a008a795a5.c30767ddca1f9c207888833aea5b5fc61(cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).c93bc4c1e0a82610433d5389276a1ae77);
							cbab4f52e6671fc2362ecfc72373ac240.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541, j).c8afb385ec3cd6a1a272d6c8b598e450d = cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83;
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
						c18d49d085fb6cf862d998b2650630a06.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf);
						c789e5f1178f3499d769eef50fc6a8d3b.c30767ddca1f9c207888833aea5b5fc61(this.c93d36da52406e10ce418b0fb04e937f2);
						ccf57ae5259d25c6b107c454d66f754d2.c30767ddca1f9c207888833aea5b5fc61(this.c6aa6f3f9369ea4394738a6a63bec71df);
						c10831642e2b6b62b5e6f167283426a92.c30767ddca1f9c207888833aea5b5fc61(this.c033ec32542a62ff7bb333ca5d79d7a54);
						c19c9f83dcaad2310ef3892d52f4a98a1.c30767ddca1f9c207888833aea5b5fc61(this.c62e5e513abb5063974acc31b79637541);
						this.c7255591bb4284c258315ca36f510bf4f = cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83;
						this.c810c4cee02339a35f874033e0d16c270 = cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83;
						this.c8afb385ec3cd6a1a272d6c8b598e450d = cbc61f9f337479d2ed2613b3d794b58c8.c8a754f5f2ca4adde825691a9c31a0e83;
						if (this.ca53c5b83901742f3960c4c2f6f8db8da != null)
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
							c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(this.ca53c5b83901742f3960c4c2f6f8db8da);
							this.ca53c5b83901742f3960c4c2f6f8db8da = c3464c619452e93f87bc4ef75a5d2127d.c8a754f5f2ca4adde825691a9c31a0e83;
						}
						this.cc3bee16b81d51bea12e1e52f129f2941 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94744) != 0);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x040013A5 RID: 5029
		public Control ca53c5b83901742f3960c4c2f6f8db8da;

		// Token: 0x040013A6 RID: 5030
		public c3868c260cbcbd410f8d406152ebc69de c94adb236938861a7e3d6aa41b463a207;

		// Token: 0x040013A7 RID: 5031
		public string c4133f594a82980efa774a1f80ec2e7d6;

		// Token: 0x040013A8 RID: 5032
		public string c9f49c0f8031bd8d77090b6288b12e3af;

		// Token: 0x040013A9 RID: 5033
		public object c070221483a03e30b41847ae8c9e91b73;

		// Token: 0x040013AA RID: 5034
		public Assembly c8afb385ec3cd6a1a272d6c8b598e450d;

		// Token: 0x040013AB RID: 5035
		public string c520a716d720e4fa3864a395fc5f5449d;

		// Token: 0x040013AC RID: 5036
		public object c21f15184a9580869b800bd9d9151ca01;

		// Token: 0x040013AD RID: 5037
		public Assembly c810c4cee02339a35f874033e0d16c270;

		// Token: 0x040013AE RID: 5038
		public string c2997cf47688460d03e4dcf343cc9646f;

		// Token: 0x040013AF RID: 5039
		public object cbdf630d2c7f4ea70618744da07c506ad;

		// Token: 0x040013B0 RID: 5040
		public Assembly c7255591bb4284c258315ca36f510bf4f;

		// Token: 0x040013B1 RID: 5041
		public int cb5cc6fce1d5e448f1036e9fe27b02d90;

		// Token: 0x040013B2 RID: 5042
		public int c15fbc486ff1db75d26e24a819e161fcd;

		// Token: 0x040013B3 RID: 5043
		public int c7638c303ac8d153fac42249270d9a295;

		// Token: 0x040013B4 RID: 5044
		public short c3d616526648fdcf0698e47042a66c10e;

		// Token: 0x040013B5 RID: 5045
		public int cc4b4558d560ab3e630ce5a26ee66d972;

		// Token: 0x040013B6 RID: 5046
		public int cf97a3a4af47c09e794d9f87473b3c207;

		// Token: 0x040013B7 RID: 5047
		public int c6ec35cf408882bb2d811448e8370e6eb;

		// Token: 0x040013B8 RID: 5048
		public bool c5141f2afeb0658864fbb726b9b39019c;

		// Token: 0x040013B9 RID: 5049
		public long c421fb20deb3493b7354efc883436c236;

		// Token: 0x040013BA RID: 5050
		public List<c49a205a8d962eedc10d0ad1e8ae458d7.c01cf1002d5d02c191da9e03d18de4f93> c65d04bd6bca9df7aa5403ab9407bcfcf;

		// Token: 0x040013BB RID: 5051
		public List<c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6> c93d36da52406e10ce418b0fb04e937f2;

		// Token: 0x040013BC RID: 5052
		public List<c49a205a8d962eedc10d0ad1e8ae458d7.c788d1c53fd6e7f5eb9c346e54085f0a9> c033ec32542a62ff7bb333ca5d79d7a54;

		// Token: 0x040013BD RID: 5053
		public List<c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073> c62e5e513abb5063974acc31b79637541;

		// Token: 0x040013BE RID: 5054
		public int cce16cf6331b22aef15107891bdf57eca;

		// Token: 0x040013BF RID: 5055
		public int cbac639dc2b6ae345dea54e81d63aaeba;

		// Token: 0x040013C0 RID: 5056
		public int cc4933387b7398585e4ac7c2736397eaa;

		// Token: 0x040013C1 RID: 5057
		public int cf62a06241405cafeceff1f6f7ef2f6a0;

		// Token: 0x040013C2 RID: 5058
		private bool cc3bee16b81d51bea12e1e52f129f2941;

		// Token: 0x040013C3 RID: 5059
		public List<Creature> c6aa6f3f9369ea4394738a6a63bec71df;

		// Token: 0x040013C4 RID: 5060
		public Color c40f949633d92c538693a28a2c1e4b04b = cc969743c0ab8f9567c6a5e6a2057f78a.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x040013C5 RID: 5061
		public bool ccb7894a0d118692edc77b0a63e622b07;

		// Token: 0x040013C6 RID: 5062
		public Color c183c7527f3d2f16e014b2653a28f28bf = c4c0b673e148fe4b47b4f78cc30aa79ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x040013C7 RID: 5063
		public bool c847db3e0c8000d2e8c299776452bd50f;

		// Token: 0x0200055F RID: 1375
		public enum cca4dea8bea2ad5e730f6f34e764c4772
		{
			// Token: 0x040013C9 RID: 5065
			c2102da7b6db76c3364991b80daa8bbbc,
			// Token: 0x040013CA RID: 5066
			ce8fb586f094bd10d8b3e125d95782038
		}

		// Token: 0x02000560 RID: 1376
		public sealed class cbd5125d3aa74a532e14855793a65bcb4
		{
			// Token: 0x040013CB RID: 5067
			public c49a205a8d962eedc10d0ad1e8ae458d7.cca4dea8bea2ad5e730f6f34e764c4772 c3df3e1aa56d5069f3165b3670176f0eb;

			// Token: 0x040013CC RID: 5068
			public string cd303aa7cdeb26810eecbb01225743ef6;

			// Token: 0x040013CD RID: 5069
			public string c65646bc8c5a1d3105b628176798bb72a;

			// Token: 0x040013CE RID: 5070
			public int c6313f2a4b7337fc78e75a94a21750a84;
		}

		// Token: 0x02000561 RID: 1377
		public sealed class c01cf1002d5d02c191da9e03d18de4f93
		{
			// Token: 0x06001ECF RID: 7887 RVA: 0x0013B3BC File Offset: 0x001395BC
			public c01cf1002d5d02c191da9e03d18de4f93()
			{
				this.c9d0b81af0b4d9ec454b66f1b3d12988f = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94800);
				this.c8097b5a21e35cb5bef745ad4e1b0b798 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94804);
			}

			// Token: 0x040013CF RID: 5071
			public uint c9d0b81af0b4d9ec454b66f1b3d12988f;

			// Token: 0x040013D0 RID: 5072
			public int c8097b5a21e35cb5bef745ad4e1b0b798;

			// Token: 0x040013D1 RID: 5073
			public int ca2a418584ab037e91a69eed38f8fbc34;

			// Token: 0x040013D2 RID: 5074
			public int cb2aca578c04d3a7d5f290c03b0fa72f9;

			// Token: 0x040013D3 RID: 5075
			public int c2fd9b81890a681af60edcd4d871aeaca;

			// Token: 0x040013D4 RID: 5076
			public int c08da3373491724302570d635a0f22a90;
		}

		// Token: 0x02000562 RID: 1378
		public sealed class c49ebde4355c27864d83fce5f465f60d6
		{
			// Token: 0x06001ED0 RID: 7888 RVA: 0x0013B3F0 File Offset: 0x001395F0
			public c49ebde4355c27864d83fce5f465f60d6()
			{
				this.c4133f594a82980efa774a1f80ec2e7d6 = new List<c49a205a8d962eedc10d0ad1e8ae458d7.cbd5125d3aa74a532e14855793a65bcb4>();
			}

			// Token: 0x040013D5 RID: 5077
			public uint c9d0b81af0b4d9ec454b66f1b3d12988f;

			// Token: 0x040013D6 RID: 5078
			public List<c49a205a8d962eedc10d0ad1e8ae458d7.cbd5125d3aa74a532e14855793a65bcb4> c4133f594a82980efa774a1f80ec2e7d6;

			// Token: 0x040013D7 RID: 5079
			public int c5ed806d2bb2197e7a4cc678385a2e6a1;

			// Token: 0x040013D8 RID: 5080
			public int ce3da4123359df388eefe0c5b68072b14;

			// Token: 0x040013D9 RID: 5081
			public SpawnObject c60958cc55162377476d7d7bef4bae994;

			// Token: 0x040013DA RID: 5082
			public BotTypes c96e0afa0fd0c9f57fd713a6a69274ee1;
		}

		// Token: 0x02000563 RID: 1379
		public sealed class c788d1c53fd6e7f5eb9c346e54085f0a9
		{
			// Token: 0x040013DB RID: 5083
			public CoreInternal.ca97729d9470bd2653e9679199030e70e c6febd09dfe7f1b928b0a7c8c1def55b0;

			// Token: 0x040013DC RID: 5084
			public c3c97afbc65912b49bda637249f073570 ce6c00421af254c6db10d7dff44e28b07;

			// Token: 0x040013DD RID: 5085
			public Label c1f281a3e2463722c4175a1fced6212ab;
		}

		// Token: 0x02000564 RID: 1380
		public sealed class c341c057025cd8aff0e5f8e9a16049073
		{
			// Token: 0x040013DE RID: 5086
			public string c4133f594a82980efa774a1f80ec2e7d6;

			// Token: 0x040013DF RID: 5087
			public string ca56117bd7a22712111d34d4bd3aa8642;

			// Token: 0x040013E0 RID: 5088
			public string c9f49c0f8031bd8d77090b6288b12e3af;

			// Token: 0x040013E1 RID: 5089
			public Color cd4e00ad3d769e8634db871a069991a75;

			// Token: 0x040013E2 RID: 5090
			public bool c44ed1f0a62af7c5221be8a67d0f1514f;

			// Token: 0x040013E3 RID: 5091
			public int c8ab6ed63b1c75b721fdeba398424d22b;

			// Token: 0x040013E4 RID: 5092
			public string c54d8dc450fc5c72ccd7a5bc5adb46506;

			// Token: 0x040013E5 RID: 5093
			public string cb2b67de0c3d6051e76c6254ced9efce4;

			// Token: 0x040013E6 RID: 5094
			public c3c97afbc65912b49bda637249f073570 ce6c00421af254c6db10d7dff44e28b07;

			// Token: 0x040013E7 RID: 5095
			public Label c1f281a3e2463722c4175a1fced6212ab;

			// Token: 0x040013E8 RID: 5096
			public c4334d1ba6df601ff9de67c621943eaad c51318d34047ba16be6801b9bc04f9e67;

			// Token: 0x040013E9 RID: 5097
			public object c070221483a03e30b41847ae8c9e91b73;

			// Token: 0x040013EA RID: 5098
			public Assembly c8afb385ec3cd6a1a272d6c8b598e450d;

			// Token: 0x040013EB RID: 5099
			public List<c49a205a8d962eedc10d0ad1e8ae458d7.cbd5125d3aa74a532e14855793a65bcb4> c853ac4dc5a4ebc1f368bca44ec315f27;

			// Token: 0x040013EC RID: 5100
			public List<c49a205a8d962eedc10d0ad1e8ae458d7.cbd5125d3aa74a532e14855793a65bcb4> c420fce48164d5b865ad42e614cfe582f;

			// Token: 0x040013ED RID: 5101
			public Point c4537e7e4f0525300135b26662a8d3802;

			// Token: 0x040013EE RID: 5102
			public List<SpawnObject> c93bc4c1e0a82610433d5389276a1ae77;

			// Token: 0x040013EF RID: 5103
			public Bitmap cb46d33e5c53239009b507805254d6c69;
		}
	}
}
