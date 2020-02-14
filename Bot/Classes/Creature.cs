using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004CA RID: 1226
	public class Creature : SpawnObject
	{
		// Token: 0x0600132E RID: 4910 RVA: 0x000AF38C File Offset: 0x000AD58C
		internal Creature(CoreInternal coreInternal) : base(coreInternal)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			this.cafa84aeaea8fd7a2b65f512a13886696 = new Creature.c6b328e74ab177ee259d96b3c213301d0[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47228)];
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47232));
			this.set_cb8ab3d693dd5ddd3256aa3952287f96a(new List<Buff>());
			this.set_cacbaa35d25d410d86c30b4ae8a318175(new List<Item>());
			this.set_ca36edb52d2337b0f805af0fdcd6d0930(new List<Item>());
			this.set_cbf5f28a0000c02be65b0b89d7dbf0deb(new List<Skill>());
			this.cff2d4228c170b27c10672d632f77e7c9 = new List<DoodadObject>();
			this.set_c9f995816220d4f9d0544ed890fe69db8(new List<Creature>());
			c810ca830cdf2321f4000eb5c727b55ca.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47236) != 0);
			c7b72d07afcaa0e8e78bb632519ffff35.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47240));
			this.castingDelayTime = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47244);
			this.c37c8636b5b3f4af1257c9fe443d75b76 = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47248);
			c60b8885750f616501c14f78ba54ac5a3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede());
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000AF460 File Offset: 0x000AD660
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000AF474 File Offset: 0x000AD674
		internal Creature mount
		{
			get;
			set;
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000AF488 File Offset: 0x000AD688
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000AF49C File Offset: 0x000AD69C
		internal Creature slave
		{
			get;
			set;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000AF4B0 File Offset: 0x000AD6B0
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
						RuntimeMethodHandle arg_1D_0 = methodof(Creature.Dispose(bool)).MethodHandle;
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
						this.cafa84aeaea8fd7a2b65f512a13886696 = cb9a56942e0baa937d6fa5edf92c59a38.c8a754f5f2ca4adde825691a9c31a0e83;
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c3ac6bbd7104005c350b3c9078326354b))
						{
							ccf57ae5259d25c6b107c454d66f754d2.c30767ddca1f9c207888833aea5b5fc61(this.c3ac6bbd7104005c350b3c9078326354b);
						}
						cd0f65843e77af57c32805cad1d925301.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c3e88e3f1784da1d5be7d00de46dd83b0.c8a754f5f2ca4adde825691a9c31a0e83);
						c8a0e544612a79621bed4977ce969f97d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						c5b319932eef6f50426efc63cb0a723fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						ccf4e580bf66db2b49936c6128507d6ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						c6f3a409486ddcc4fcde7781aba806e76.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						c3a43c1daae6f6c8f0ffaf5a4fd455f03.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						c9fbd22ee1acf40a37b49d218165d4423.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cec343138c4b29fac5a95db99a723ccd3.c8a754f5f2ca4adde825691a9c31a0e83);
						c7f378c9cfb83e78c391c765512272dee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						cf2427c1dce41d600619c35f711e00201.c30767ddca1f9c207888833aea5b5fc61(this.cff2d4228c170b27c10672d632f77e7c9);
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c844e78704e072a4cebca640ae7d68952))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45116); i < c0ce5ac6ea366633aaf6d960fb8dbde46.c30767ddca1f9c207888833aea5b5fc61(this.c844e78704e072a4cebca640ae7d68952); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45120))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.c844e78704e072a4cebca640ae7d68952, i));
								cb92b1168bd18a019f423b4db67a65433.c30767ddca1f9c207888833aea5b5fc61(this.c844e78704e072a4cebca640ae7d68952, i, c6ab480d99ecdacae3cea18d3de76b06c.c8a754f5f2ca4adde825691a9c31a0e83);
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
							c9808f57395f63fe4e01e10ea4b9886f0.c30767ddca1f9c207888833aea5b5fc61(this.c844e78704e072a4cebca640ae7d68952);
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd))
						{
							for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45124); j < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45128))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd, j));
								c85eddde945202b0ca0a5ffd332a26f3a.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd, j, cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83);
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
							ce94d42ee9d1f4e52d9a322d2b923d01c.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd);
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca128f9da78af63f9367bbe64bfc375fc))
						{
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45132); k < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.ca128f9da78af63f9367bbe64bfc375fc); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45136))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.ca128f9da78af63f9367bbe64bfc375fc, k));
								c85eddde945202b0ca0a5ffd332a26f3a.c30767ddca1f9c207888833aea5b5fc61(this.ca128f9da78af63f9367bbe64bfc375fc, k, cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83);
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
							ce94d42ee9d1f4e52d9a322d2b923d01c.c30767ddca1f9c207888833aea5b5fc61(this.ca128f9da78af63f9367bbe64bfc375fc);
						}
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.cdac6622759dddc6399c15f0e0489fdb7))
						{
							for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45140); l < cd76bd05d82b141b0544cd21df6dcb6a0.c30767ddca1f9c207888833aea5b5fc61(this.cdac6622759dddc6399c15f0e0489fdb7); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45144))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c5cac1bec31f0d74685de039f19d81dc0.c30767ddca1f9c207888833aea5b5fc61(this.cdac6622759dddc6399c15f0e0489fdb7, l));
								c60b21a95302b35bd32b4a7546ccaae60.c30767ddca1f9c207888833aea5b5fc61(this.cdac6622759dddc6399c15f0e0489fdb7, l, c9c262e4433f457b77c7ae336478ac6e2.c8a754f5f2ca4adde825691a9c31a0e83);
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
							cb877e9bef4d9516fc3af53b0bc2c4ffa.c30767ddca1f9c207888833aea5b5fc61(this.cdac6622759dddc6399c15f0e0489fdb7);
						}
					}
					cc772cb612abb65e47a5ee7ac6a23da5c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000AF83C File Offset: 0x000ADA3C
		public double calcSkillMaxRange(uint skillId)
		{
			return this.ca124a9f406cda69b904f2eb04d553ab9.c8d4d88fa1f0df93f6e26916e716b7ae5(skillId, this);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000AF858 File Offset: 0x000ADA58
		public List<Item> getAllEquipedItems()
		{
			List<Item> list = c1ef349e2bf9e54bf0fef5229dbddddfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.get_cacbaa35d25d410d86c30b4ae8a318175()))
				{
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45148); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175()); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45156))
					{
						if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45152))
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
								RuntimeMethodHandle arg_5A_0 = methodof(Creature.getAllEquipedItems()).MethodHandle;
							}
							c8541b26c29b7f14ee59c4feca5be3c90.c30767ddca1f9c207888833aea5b5fc61(list, c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), i));
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
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return list;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x000AF940 File Offset: 0x000ADB40
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x000AF954 File Offset: 0x000ADB54
		public bool dropAvailable
		{
			get;
			internal set;
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x000AF968 File Offset: 0x000ADB68
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x000AF97C File Offset: 0x000ADB7C
		public int recoverableExp
		{
			get;
			internal set;
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x000AF990 File Offset: 0x000ADB90
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x000AF9A4 File Offset: 0x000ADBA4
		public Appellation appellation
		{
			get;
			internal set;
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000AF9B8 File Offset: 0x000ADBB8
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x000AF9CC File Offset: 0x000ADBCC
		internal long lastMpUpdate
		{
			get;
			set;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000AF9E0 File Offset: 0x000ADBE0
		internal void cc158b078e73ae68611a7ee606dfb5ec5()
		{
			try
			{
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45160); i < (int)cf662d9442428c22606e007bb16b3633a.cc0906fa561b9c6076f6cb6643cecb5e3(this.cafa84aeaea8fd7a2b65f512a13886696); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45164))
				{
					this.cafa84aeaea8fd7a2b65f512a13886696[i].cfc4265a0bc048786ecb6e2d1e173a736();
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
				if (!true)
				{
					RuntimeMethodHandle arg_4E_0 = methodof(Creature.cc158b078e73ae68611a7ee606dfb5ec5()).MethodHandle;
				}
				this.ce7b8a6129fa89b57f02e9ca45211a994();
				this.c49d347b384d1a00c784183dc204a0cf4();
				c60b8885750f616501c14f78ba54ac5a3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede());
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000AFA78 File Offset: 0x000ADC78
		private void ce7b8a6129fa89b57f02e9ca45211a994()
		{
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45168); i < c71eecb9ed481a4bf9bdab756fe08a684.c30767ddca1f9c207888833aea5b5fc61(c6d2c8529a486dd4f0da9ca45110de9cc.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45180))
			{
				if (c1135d65e19f724b00978bd8511fde432.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c6d2c8529a486dd4f0da9ca45110de9cc.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), i)) == 0)
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
						RuntimeMethodHandle arg_42_0 = methodof(Creature.ce7b8a6129fa89b57f02e9ca45211a994()).MethodHandle;
					}
					Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_6C_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
					int expr_6C_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c6d2c8529a486dd4f0da9ca45110de9cc.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), i));
					expr_6C_cp_0[expr_6C_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_6C_cp_0[expr_6C_cp_1].c22db3a4124e20f4086b50415686d7ca3 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c6d2c8529a486dd4f0da9ca45110de9cc.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), i));
				}
				else
				{
					Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_C2_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
					int expr_C2_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c6d2c8529a486dd4f0da9ca45110de9cc.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), i));
					expr_C2_cp_0[expr_C2_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_C2_cp_0[expr_C2_cp_1].cbe5cdb7247bab90c29da820d631002c6 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c6d2c8529a486dd4f0da9ca45110de9cc.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), i)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45172);
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
			for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45184); j < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175()); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45292))
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45188))
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
					if (ca7f08083d0c234ebff9658f4f6c72db6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45192))
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
						if ((int)c5e968691ce29e9a9da6c873f87d8826b.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45196))
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
							Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_1D3_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
							int expr_1D3_cp_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45200);
							expr_1D3_cp_0[expr_1D3_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_1D3_cp_0[expr_1D3_cp_1].c22db3a4124e20f4086b50415686d7ca3 + cf05db1121d091ed9bea22174152a9e17.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j));
							Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_20B_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
							int expr_20B_cp_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45204);
							expr_20B_cp_0[expr_20B_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_20B_cp_0[expr_20B_cp_1].c22db3a4124e20f4086b50415686d7ca3 + c59c09126221db4b3c2fefb31e2af5379.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j));
							Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_243_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
							int expr_243_cp_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45208);
							expr_243_cp_0[expr_243_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_243_cp_0[expr_243_cp_1].c22db3a4124e20f4086b50415686d7ca3 + cb6079f277932101e639ce308003a3518.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j));
							Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_27B_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
							int expr_27B_cp_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45212);
							expr_27B_cp_0[expr_27B_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_27B_cp_0[expr_27B_cp_1].c22db3a4124e20f4086b50415686d7ca3 + ce702af73df2fc2a923f439711fd68088.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j));
							Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_2B3_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
							int expr_2B3_cp_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45216);
							expr_2B3_cp_0[expr_2B3_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_2B3_cp_0[expr_2B3_cp_1].c22db3a4124e20f4086b50415686d7ca3 + cb0f11927234a52c2af70fddf9229c92f.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j));
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45220); k < c5d15e4a112d50d8c1b5c63de7e4e549f.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j))); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45244))
							{
								if (c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), k) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45224))
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
									for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45228); l < c71eecb9ed481a4bf9bdab756fe08a684.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), k)))); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45240))
									{
										if (c1135d65e19f724b00978bd8511fde432.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), k))), l)) == 0)
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
											Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_3E8_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
											int expr_3E8_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), k))), l));
											expr_3E8_cp_0[expr_3E8_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_3E8_cp_0[expr_3E8_cp_1].c22db3a4124e20f4086b50415686d7ca3 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), k))), l));
										}
										else
										{
											Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_4A5_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
											int expr_4A5_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), k))), l));
											expr_4A5_cp_0[expr_4A5_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_4A5_cp_0[expr_4A5_cp_1].cbe5cdb7247bab90c29da820d631002c6 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c6f42b061d7177bafc79e5673bae30f80.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), k))), l)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45232);
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
							for (int m = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45248); m < c5d15e4a112d50d8c1b5c63de7e4e549f.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j))); m += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45272))
							{
								if (c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), m) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45252))
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
									for (int n = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45256); n < c71eecb9ed481a4bf9bdab756fe08a684.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), m)))); n += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45268))
									{
										if (c1135d65e19f724b00978bd8511fde432.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), m))), n)) == 0)
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
											Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_6C8_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
											int expr_6C8_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), m))), n));
											expr_6C8_cp_0[expr_6C8_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_6C8_cp_0[expr_6C8_cp_1].c22db3a4124e20f4086b50415686d7ca3 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), m))), n));
										}
										else
										{
											Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_789_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
											int expr_789_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), m))), n));
											expr_789_cp_0[expr_789_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_789_cp_0[expr_789_cp_1].cbe5cdb7247bab90c29da820d631002c6 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c45d13e325a54f1f99017c2b738c0d8ef.c30767ddca1f9c207888833aea5b5fc61(c51ede6fefc52f0f5558903e6552b83e6.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)), m))), n)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45260);
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
							for (int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45276); num < c71eecb9ed481a4bf9bdab756fe08a684.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j)))); num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45288))
							{
								if (c1135d65e19f724b00978bd8511fde432.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j))), num)) == 0)
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
									Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_923_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
									int expr_923_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j))), num));
									expr_923_cp_0[expr_923_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_923_cp_0[expr_923_cp_1].c22db3a4124e20f4086b50415686d7ca3 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j))), num));
								}
								else
								{
									Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_99C_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
									int expr_99C_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j))), num));
									expr_99C_cp_0[expr_99C_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_99C_cp_0[expr_99C_cp_1].cbe5cdb7247bab90c29da820d631002c6 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175(), j))), num)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45280);
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
			int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45296);
			while (num2 < c0ce5ac6ea366633aaf6d960fb8dbde46.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a()))
			{
				double num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45300);
				if (cff0e4cd7642c3ffa12e11e4714007ca4.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45308))
				{
					goto IL_ADE;
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
				if (cff0e4cd7642c3ffa12e11e4714007ca4.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45312))
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						goto IL_ADE;
					}
				}
				IL_AF9:
				for (int num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45316); num4 < c9587deddd00e5bbfc31d8df9679847b3.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2)))); num4 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45348))
				{
					if (cf4d174e661ef4b1ee9a19690800f9ac5.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2)) != (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45320))
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
						if (cc46e82b888691e0bd2d524c75b5ac7ab.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4)) == 0)
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
							Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_BB4_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
							int expr_BB4_cp_1 = c1f920192c9941aaaa54a6264718bdbdc.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4));
							expr_BB4_cp_0[expr_BB4_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_BB4_cp_0[expr_BB4_cp_1].c22db3a4124e20f4086b50415686d7ca3 + num3 * c7a064c4f8482612c752397a39bb916c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)cb2002ed4c20839dd7c7dd203b41eef6c.c30767ddca1f9c207888833aea5b5fc61(c1b9ac3287af0f4b373d9917c6378c528.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4))) + ((double)cff8e80ed9c4cc839036c9da6f6afd85c.c30767ddca1f9c207888833aea5b5fc61(c1b9ac3287af0f4b373d9917c6378c528.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4))) - (double)cb2002ed4c20839dd7c7dd203b41eef6c.c30767ddca1f9c207888833aea5b5fc61(c1b9ac3287af0f4b373d9917c6378c528.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4)))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45324) * (double)c3e113f934d4e854abddda6af5ffd87cd.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2)) / ((double)cf4d174e661ef4b1ee9a19690800f9ac5.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45332)));
						}
						else
						{
							Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_CFE_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
							int expr_CFE_cp_1 = c1f920192c9941aaaa54a6264718bdbdc.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4));
							expr_CFE_cp_0[expr_CFE_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_CFE_cp_0[expr_CFE_cp_1].cbe5cdb7247bab90c29da820d631002c6 + num3 * ((double)cb2002ed4c20839dd7c7dd203b41eef6c.c30767ddca1f9c207888833aea5b5fc61(c1b9ac3287af0f4b373d9917c6378c528.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4))) + ((double)cff8e80ed9c4cc839036c9da6f6afd85c.c30767ddca1f9c207888833aea5b5fc61(c1b9ac3287af0f4b373d9917c6378c528.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4))) - (double)cb2002ed4c20839dd7c7dd203b41eef6c.c30767ddca1f9c207888833aea5b5fc61(c1b9ac3287af0f4b373d9917c6378c528.c30767ddca1f9c207888833aea5b5fc61(c5fb3103e35ee1529a1a42927776d373e.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num4)))) * ((double)c3e113f934d4e854abddda6af5ffd87cd.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2)) / (double)cf4d174e661ef4b1ee9a19690800f9ac5.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2)))) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45340);
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
				for (int num5 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45352); num5 < c71eecb9ed481a4bf9bdab756fe08a684.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2)))); num5 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45380))
				{
					if (c1135d65e19f724b00978bd8511fde432.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num5)) == 0)
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
						Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_EC4_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
						int expr_EC4_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num5));
						expr_EC4_cp_0[expr_EC4_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_EC4_cp_0[expr_EC4_cp_1].c22db3a4124e20f4086b50415686d7ca3 + num3 * c7a064c4f8482612c752397a39bb916c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num5)) + c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2).cfa1b727722147a9517233e775214bceb * (double)cd246012f978fdd2dcafe49e1da0b6288.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num5)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45356));
					}
					else
					{
						Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_FA0_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
						int expr_FA0_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num5));
						expr_FA0_cp_0[expr_FA0_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_FA0_cp_0[expr_FA0_cp_1].cbe5cdb7247bab90c29da820d631002c6 + num3 * (((double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num5)) + c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2).cfa1b727722147a9517233e775214bceb * (double)cd246012f978fdd2dcafe49e1da0b6288.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c5d9078af416e003e3ae50fb9d1550cb8.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2))), num5)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45364)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45372));
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
				num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45384);
				continue;
				IL_ADE:
				num3 = (double)cc950b6d8a93b96512f866d8f8971a55a.c30767ddca1f9c207888833aea5b5fc61(c841d370d1a8ba5edc4683bf7a2278ef7.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a(), num2));
				goto IL_AF9;
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
			if ((int)cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45388))
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
				for (int num6 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45392); num6 < c71eecb9ed481a4bf9bdab756fe08a684.c30767ddca1f9c207888833aea5b5fc61(c5a7c8f887bc7cdc8a833a04530874141.c30767ddca1f9c207888833aea5b5fc61(cb9ee233c0ca1b3354dd4a13a624d1096.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this)))); num6 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45404))
				{
					if (c1135d65e19f724b00978bd8511fde432.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c5a7c8f887bc7cdc8a833a04530874141.c30767ddca1f9c207888833aea5b5fc61(cb9ee233c0ca1b3354dd4a13a624d1096.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this))), num6)) == 0)
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
						Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_114D_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
						int expr_114D_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c5a7c8f887bc7cdc8a833a04530874141.c30767ddca1f9c207888833aea5b5fc61(cb9ee233c0ca1b3354dd4a13a624d1096.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this))), num6));
						expr_114D_cp_0[expr_114D_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_114D_cp_0[expr_114D_cp_1].c22db3a4124e20f4086b50415686d7ca3 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c5a7c8f887bc7cdc8a833a04530874141.c30767ddca1f9c207888833aea5b5fc61(cb9ee233c0ca1b3354dd4a13a624d1096.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this))), num6));
					}
					else
					{
						Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_11B3_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
						int expr_11B3_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c5a7c8f887bc7cdc8a833a04530874141.c30767ddca1f9c207888833aea5b5fc61(cb9ee233c0ca1b3354dd4a13a624d1096.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this))), num6));
						expr_11B3_cp_0[expr_11B3_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_11B3_cp_0[expr_11B3_cp_1].cbe5cdb7247bab90c29da820d631002c6 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(c5a7c8f887bc7cdc8a833a04530874141.c30767ddca1f9c207888833aea5b5fc61(cb9ee233c0ca1b3354dd4a13a624d1096.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this))), num6)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45396);
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
			}
			if ((int)cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45408))
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
				for (int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45412); num7 < c71eecb9ed481a4bf9bdab756fe08a684.c30767ddca1f9c207888833aea5b5fc61(cbc6918d421008a30d898d7f80fce2155.c30767ddca1f9c207888833aea5b5fc61(c514f8651ce743b60150c0e606f32a3d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c1d2adb54f573d9804ba36832bd46e0.c9963fcf210a214a3206d6500f3b9397b(this)))); num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45424))
				{
					if (c1135d65e19f724b00978bd8511fde432.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cbc6918d421008a30d898d7f80fce2155.c30767ddca1f9c207888833aea5b5fc61(c514f8651ce743b60150c0e606f32a3d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c1d2adb54f573d9804ba36832bd46e0.c9963fcf210a214a3206d6500f3b9397b(this))), num7)) == 0)
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
						Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_12C5_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
						int expr_12C5_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cbc6918d421008a30d898d7f80fce2155.c30767ddca1f9c207888833aea5b5fc61(c514f8651ce743b60150c0e606f32a3d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c1d2adb54f573d9804ba36832bd46e0.c9963fcf210a214a3206d6500f3b9397b(this))), num7));
						expr_12C5_cp_0[expr_12C5_cp_1].c22db3a4124e20f4086b50415686d7ca3 = expr_12C5_cp_0[expr_12C5_cp_1].c22db3a4124e20f4086b50415686d7ca3 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cbc6918d421008a30d898d7f80fce2155.c30767ddca1f9c207888833aea5b5fc61(c514f8651ce743b60150c0e606f32a3d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c1d2adb54f573d9804ba36832bd46e0.c9963fcf210a214a3206d6500f3b9397b(this))), num7));
					}
					else
					{
						Creature.c6b328e74ab177ee259d96b3c213301d0[] expr_132B_cp_0 = this.cafa84aeaea8fd7a2b65f512a13886696;
						int expr_132B_cp_1 = c641a7adf268061c2abfb7d71b27ff6e6.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cbc6918d421008a30d898d7f80fce2155.c30767ddca1f9c207888833aea5b5fc61(c514f8651ce743b60150c0e606f32a3d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c1d2adb54f573d9804ba36832bd46e0.c9963fcf210a214a3206d6500f3b9397b(this))), num7));
						expr_132B_cp_0[expr_132B_cp_1].cbe5cdb7247bab90c29da820d631002c6 = expr_132B_cp_0[expr_132B_cp_1].cbe5cdb7247bab90c29da820d631002c6 + (double)cda61daa5c19867e39a5d31c859db1f4f.c30767ddca1f9c207888833aea5b5fc61(cc7ad953358580d589f96a4fecc7d0b54.c30767ddca1f9c207888833aea5b5fc61(cbc6918d421008a30d898d7f80fce2155.c30767ddca1f9c207888833aea5b5fc61(c514f8651ce743b60150c0e606f32a3d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c1d2adb54f573d9804ba36832bd46e0.c9963fcf210a214a3206d6500f3b9397b(this))), num7)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45416);
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
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000B0E30 File Offset: 0x000AF030
		private void c49d347b384d1a00c784183dc204a0cf4()
		{
			if ((int)cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45428))
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
					RuntimeMethodHandle arg_29_0 = methodof(Creature.c49d347b384d1a00c784183dc204a0cf4()).MethodHandle;
				}
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45432)].c644dcb409c6527970e516e7c53e3eef1 = this.c8c9c9b54fa9cdbe48840d5606d4114ea();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45436)].c644dcb409c6527970e516e7c53e3eef1 = this.cbfaf4acd81f62e4a67a1f665f6072e76();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45440)].c644dcb409c6527970e516e7c53e3eef1 = this.ca135215b0e3781fb7d6ddd66789da09b();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45444)].c644dcb409c6527970e516e7c53e3eef1 = this.c18df426904eeec60278d0601dfe0ad2f();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45448)].c644dcb409c6527970e516e7c53e3eef1 = this.c6b7ad28ded65568146ce4f37dc4920ad();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45452); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45460); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45456))
				{
					this.cafa84aeaea8fd7a2b65f512a13886696[i].c11546181b1262acba2edb5e5d103f097();
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
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45464)].c644dcb409c6527970e516e7c53e3eef1 = this.c74aa2611c27b7712aa9484e2de5b22af();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45468)].c644dcb409c6527970e516e7c53e3eef1 = this.c435d7c7f2353458b9733282884fa65d9();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45472)].c644dcb409c6527970e516e7c53e3eef1 = this.c80cdd1e3b55ac4f77c8cb2218d201821();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45476)].c644dcb409c6527970e516e7c53e3eef1 = this.c902543b9d5a9e6a3416914f8d5f03989();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45480)].c644dcb409c6527970e516e7c53e3eef1 = this.cf80da5c422c0a67472d6da198047e764();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45484)].c644dcb409c6527970e516e7c53e3eef1 = this.c96b4b368cf98e05c31ecf761f63bd767();
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45488)].c644dcb409c6527970e516e7c53e3eef1 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45492);
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45500)].c644dcb409c6527970e516e7c53e3eef1 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45504);
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45512)].c644dcb409c6527970e516e7c53e3eef1 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45516);
				this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45524)].c644dcb409c6527970e516e7c53e3eef1 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45528);
				for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45536); j < (int)cf662d9442428c22606e007bb16b3633a.cc0906fa561b9c6076f6cb6643cecb5e3(this.cafa84aeaea8fd7a2b65f512a13886696); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45540))
				{
					this.cafa84aeaea8fd7a2b65f512a13886696[j].c11546181b1262acba2edb5e5d103f097();
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
				cbc379200ce73003fbdc0b52e7a455b27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45544)].c80f9fe22c7cf5267e78663d40cd4bd23);
				ca3c42e173379e089409f7f8327f3b511.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45548)].c80f9fe22c7cf5267e78663d40cd4bd23);
				cfaa7f739ccb33a3051d02824cf550537.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45552)].c80f9fe22c7cf5267e78663d40cd4bd23);
				cfd617cdc5ae6a2010aae0a3e08eb27b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45556)].c80f9fe22c7cf5267e78663d40cd4bd23);
				c90c803a6cdb2d59cf0708de6309b45cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45560)].c80f9fe22c7cf5267e78663d40cd4bd23);
				cb90fbce75b5f55333749519309900bc9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45564)].c80f9fe22c7cf5267e78663d40cd4bd23);
				c99aefb3fd39d3897577a241600d00285.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45568)].c80f9fe22c7cf5267e78663d40cd4bd23);
				c320e7a126325ba4fb1c7f1f4bc4e19f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45572)].c80f9fe22c7cf5267e78663d40cd4bd23);
				cc0f4789f988e093af94479228b77e7fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45576)].c80f9fe22c7cf5267e78663d40cd4bd23);
				c53c80ea18ea421818178ffa53a32454f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45580)].c80f9fe22c7cf5267e78663d40cd4bd23 / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45584));
				c3f2ed06e31613288b9456db45906630d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45588)].c80f9fe22c7cf5267e78663d40cd4bd23 / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45592));
				c06754edaa1e49b5f9316835bb25faec8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (int)this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45596)].c80f9fe22c7cf5267e78663d40cd4bd23);
				this.castingDelayTime = (long)(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45600) * (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45608) / (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45616) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45624)].c80f9fe22c7cf5267e78663d40cd4bd23)));
				c320e7a126325ba4fb1c7f1f4bc4e19f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c355090e9c233c40bb51526ff9fcbe741.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) + c1e7301891e9c13f334f766784d239327.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				cc0f4789f988e093af94479228b77e7fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c6d952a8d0f6a23ac7ae6433ce7377f5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) + cee4077e0df7deb474a1bf74828b2f1f5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				return;
			}
			if ((int)cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45628))
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
				if (c70c4cecf449a99317d56daab248a55d1.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cf61b867443806a03d336b9101acbfa64.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this))))
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
					cb90fbce75b5f55333749519309900bc9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca953719bcb64df45ef112334ef1f1c46.c30767ddca1f9c207888833aea5b5fc61(c17c43bc0d3fbee21a6ef8c0de88b4544.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cf61b867443806a03d336b9101acbfa64.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c9f762755ad4e3c609dfaeaabe891d228.c9963fcf210a214a3206d6500f3b9397b(this)))));
				}
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x000B13A4 File Offset: 0x000AF5A4
		internal double c8c9c9b54fa9cdbe48840d5606d4114ea()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45632) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45636)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45640));
			case 1:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45644) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45648)) * this.cd36ac36e8d9767350ea3a91d8a30b728(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45652), c592a520c0a343927147a65be302087f6.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			case 2:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45656) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45660)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45664));
			case 3:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45668) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45672)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45676));
			case 4:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45680) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45684)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45688));
			case 5:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45692) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45696)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45700));
			case 6:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45704) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45708)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45712));
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45716);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000B1534 File Offset: 0x000AF734
		internal double cbfaf4acd81f62e4a67a1f665f6072e76()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45724) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45728)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45732));
			case 1:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45736) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45740)) * this.cd36ac36e8d9767350ea3a91d8a30b728(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45744), c592a520c0a343927147a65be302087f6.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			case 2:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45748) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45752)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45756));
			case 3:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45760) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45764)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45768));
			case 4:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45772) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45776)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45780));
			case 5:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45784) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45788)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45792));
			case 6:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45796) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45800)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45804));
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45808);
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000B16C4 File Offset: 0x000AF8C4
		internal double ca135215b0e3781fb7d6ddd66789da09b()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45816) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45820)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45824));
			case 1:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45828) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45832)) * this.cd36ac36e8d9767350ea3a91d8a30b728(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45836), c592a520c0a343927147a65be302087f6.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			case 2:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45840) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45844)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45848));
			case 3:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45852) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45856)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45860));
			case 4:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45864) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45868)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45872));
			case 5:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45876) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45880)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45884));
			case 6:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45888) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45892)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45896));
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45900);
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x000B1854 File Offset: 0x000AFA54
		internal double c18df426904eeec60278d0601dfe0ad2f()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45908) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45912)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45916));
			case 1:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45920) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45924)) * this.cd36ac36e8d9767350ea3a91d8a30b728(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45928), c592a520c0a343927147a65be302087f6.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			case 2:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45932) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45936)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45940));
			case 3:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45944) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45948)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45952));
			case 4:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45956) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45960)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45964));
			case 5:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45968) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45972)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45976));
			case 6:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45980) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45984)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(45988));
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(45992);
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000B19E4 File Offset: 0x000AFBE4
		internal double c6b7ad28ded65568146ce4f37dc4920ad()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46000) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46004)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46008));
			case 1:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46012) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46016)) * this.cd36ac36e8d9767350ea3a91d8a30b728(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46020), c592a520c0a343927147a65be302087f6.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			case 2:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46024) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46028)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46032));
			case 3:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46036) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46040)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46044));
			case 4:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46048) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46052)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46056));
			case 5:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46060) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46064)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46068));
			case 6:
				return (double)(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46072) + ((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46076)) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46080));
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46084);
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000B1B74 File Offset: 0x000AFD74
		internal double c74aa2611c27b7712aa9484e2de5b22af()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46092)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46096)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46100) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46108);
			case 1:
				return (c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46116) * ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46124)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46132)].c80f9fe22c7cf5267e78663d40cd4bd23, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46136)) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46144)) * (this.cd36ac36e8d9767350ea3a91d8a30b728(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46152), c592a520c0a343927147a65be302087f6.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) * this.c1cb34d0254e6bb0bbc68f0d524c50135(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46156), c4c0365ac8aad5b438b0716edcf514ad5.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) * this.c0323eb5ed3d35058d7f1f0402b7f0016(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46160), c5bc05beac1fa28efbbf67ebd29433dcd.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46164);
			case 2:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46172)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46176)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46180);
			case 3:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46188)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46192)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46196);
			case 4:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46204)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46208)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46212);
			case 5:
				return ((double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46220)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46224)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46228)) * this.c9df49b24399b3fdc2502b49320208e5f(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46236), cd6642f44359393ff59dcd9f18f27ab10.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			case 6:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46240);
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46248);
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000B1E04 File Offset: 0x000B0004
		internal double c435d7c7f2353458b9733282884fa65d9()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46256)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46260)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46264) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46272);
			case 1:
				return ((double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46280)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46284)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46288) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46296)) * (this.c1cb34d0254e6bb0bbc68f0d524c50135(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46304), c4c0365ac8aad5b438b0716edcf514ad5.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))) * this.c0323eb5ed3d35058d7f1f0402b7f0016(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46308), c5bc05beac1fa28efbbf67ebd29433dcd.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
			case 2:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46312)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46316)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46320);
			case 3:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46328)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46332)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46336);
			case 4:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46344)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46348)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46352);
			case 5:
				return (double)((int)c1ff51920b6c6ebf6ba641ffd73637719.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46360)) + this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46364)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46368) * this.c9df49b24399b3fdc2502b49320208e5f(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46376), cd6642f44359393ff59dcd9f18f27ab10.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
			case 6:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46380);
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46388);
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x000B2048 File Offset: 0x000B0248
		internal double c80cdd1e3b55ac4f77c8cb2218d201821()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46396)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46400) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46408);
			case 1:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46416)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46420) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46428);
			case 2:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46436);
			case 3:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46444);
			case 4:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46452)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46456) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46464) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46472);
			case 5:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46480)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46484) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46492);
			case 6:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46500);
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46508);
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000B219C File Offset: 0x000B039C
		internal double c902543b9d5a9e6a3416914f8d5f03989()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46516)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46520) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46528);
			case 1:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46536)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46540) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46548);
			case 2:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46556)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46560) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46568);
			case 3:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46576)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46580) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46588);
			case 4:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46596)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46600) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46608);
			case 5:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46616)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46620) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46628);
			case 6:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46636);
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46644);
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000B2330 File Offset: 0x000B0530
		internal double cf80da5c422c0a67472d6da198047e764()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46652);
			case 1:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46660);
			case 2:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46668);
			case 3:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46676);
			case 4:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46684);
			case 5:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46692)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46696) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46704);
			case 6:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46712);
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46720);
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000B23FC File Offset: 0x000B05FC
		internal double c96b4b368cf98e05c31ecf761f63bd767()
		{
			switch (cdf53f1e3a599950cecb69a9d4a634276.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
			{
			case 0:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46728);
			case 1:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46736);
			case 2:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46744);
			case 3:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46752);
			case 4:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46760);
			case 5:
				return this.cafa84aeaea8fd7a2b65f512a13886696[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46768)].c80f9fe22c7cf5267e78663d40cd4bd23 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46772) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46780);
			case 6:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46788);
			default:
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46796);
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x000B24C8 File Offset: 0x000B06C8
		internal void c4aaf7619a600d569451f27c0b2b78918()
		{
			cd0f65843e77af57c32805cad1d925301.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c423dc45b27ca6bd6b37ad65999574726.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (ce990233970344a34280d6afdb0593ea2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46804))
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
					RuntimeMethodHandle arg_36_0 = methodof(Creature.c4aaf7619a600d569451f27c0b2b78918()).MethodHandle;
				}
				try
				{
					if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), ce990233970344a34280d6afdb0593ea2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						cd0f65843e77af57c32805cad1d925301.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), ce990233970344a34280d6afdb0593ea2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000B2588 File Offset: 0x000B0788
		internal double cfc684c6859f8960a21220f6b8d05b2a1(int num, int num2)
		{
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46808); i < c97dc5baa36bfc5993a10d17f227fda03.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46816))
			{
				if (ca4ccb45e260392e09c229ac077c359f7.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46812))
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
						RuntimeMethodHandle arg_54_0 = methodof(Creature.cfc684c6859f8960a21220f6b8d05b2a1(int, int)).MethodHandle;
					}
					if (c066c552f598741a0e8638fe736103c8c.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num)
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
						if (c2502337db3305e4a9f448adcddb46bd0.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num2)
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
							return cbac2660930b10c2d84fff448232d51f9.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i));
						}
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46820);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x000B26B4 File Offset: 0x000B08B4
		internal double cd36ac36e8d9767350ea3a91d8a30b728(int num, int num2)
		{
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46828); i < c97dc5baa36bfc5993a10d17f227fda03.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46836))
			{
				if (ca4ccb45e260392e09c229ac077c359f7.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46832))
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
						RuntimeMethodHandle arg_54_0 = methodof(Creature.cd36ac36e8d9767350ea3a91d8a30b728(int, int)).MethodHandle;
					}
					if (c066c552f598741a0e8638fe736103c8c.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num)
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
						if (c2502337db3305e4a9f448adcddb46bd0.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num2)
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
							return cbac2660930b10c2d84fff448232d51f9.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i));
						}
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46840);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x000B27E0 File Offset: 0x000B09E0
		internal double c1cb34d0254e6bb0bbc68f0d524c50135(int num, int num2)
		{
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46848); i < c97dc5baa36bfc5993a10d17f227fda03.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46856))
			{
				if (ca4ccb45e260392e09c229ac077c359f7.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46852))
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
						RuntimeMethodHandle arg_54_0 = methodof(Creature.c1cb34d0254e6bb0bbc68f0d524c50135(int, int)).MethodHandle;
					}
					if (c066c552f598741a0e8638fe736103c8c.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num)
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
						if (c2502337db3305e4a9f448adcddb46bd0.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num2)
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
							return cbac2660930b10c2d84fff448232d51f9.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i));
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46860);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000B290C File Offset: 0x000B0B0C
		internal double c0323eb5ed3d35058d7f1f0402b7f0016(int num, int num2)
		{
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46868); i < c97dc5baa36bfc5993a10d17f227fda03.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46876))
			{
				if (ca4ccb45e260392e09c229ac077c359f7.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46872))
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
						RuntimeMethodHandle arg_54_0 = methodof(Creature.c0323eb5ed3d35058d7f1f0402b7f0016(int, int)).MethodHandle;
					}
					if (c066c552f598741a0e8638fe736103c8c.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num)
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
						if (c2502337db3305e4a9f448adcddb46bd0.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num2)
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
							return cbac2660930b10c2d84fff448232d51f9.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i));
						}
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46880);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000B2A38 File Offset: 0x000B0C38
		internal double c9df49b24399b3fdc2502b49320208e5f(int num, int num2)
		{
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46888); i < c97dc5baa36bfc5993a10d17f227fda03.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46896))
			{
				if (ca4ccb45e260392e09c229ac077c359f7.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46892))
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
						RuntimeMethodHandle arg_54_0 = methodof(Creature.c9df49b24399b3fdc2502b49320208e5f(int, int)).MethodHandle;
					}
					if (c066c552f598741a0e8638fe736103c8c.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num)
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
						if (c2502337db3305e4a9f448adcddb46bd0.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i)) == num2)
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
							return cbac2660930b10c2d84fff448232d51f9.c30767ddca1f9c207888833aea5b5fc61(c19eb820948fe142634f01fe26d67e524.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), i));
						}
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46900);
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x000B2B64 File Offset: 0x000B0D64
		public string name
		{
			get
			{
				try
				{
					if (ce990233970344a34280d6afdb0593ea2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == 0u)
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
							RuntimeMethodHandle arg_1C_0 = methodof(Creature.get_name()).MethodHandle;
						}
						string result = ccee71b5f426d96b55fbc710d66688b7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
						return result;
					}
					if (c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						string result = c1b5cabce52905b1cef78921808edaf89.c30767ddca1f9c207888833aea5b5fc61(c10a980b1c713120a533d0e3eeaa210e9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						return result;
					}
				}
				catch
				{
				}
				return "";
			}
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x000B2BDC File Offset: 0x000B0DDC
		public List<Creature> getSittingOnMe()
		{
			List<Creature> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c3ac6bbd7104005c350b3c9078326354b))
			{
				result = this.c3ac6bbd7104005c350b3c9078326354b.ToList<Creature>();
			}
			return result;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x000B2C28 File Offset: 0x000B0E28
		internal List<Creature> get_c9f995816220d4f9d0544ed890fe69db8()
		{
			return this.c3ac6bbd7104005c350b3c9078326354b;
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000B2C3C File Offset: 0x000B0E3C
		internal void set_c9f995816220d4f9d0544ed890fe69db8(List<Creature> list)
		{
			this.c3ac6bbd7104005c350b3c9078326354b = list;
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x000B2C50 File Offset: 0x000B0E50
		// (set) Token: 0x06001357 RID: 4951 RVA: 0x000B2C64 File Offset: 0x000B0E64
		public Creature firstHitter
		{
			get;
			internal set;
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x000B2C78 File Offset: 0x000B0E78
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x000B2C8C File Offset: 0x000B0E8C
		public uint firstHitterObjId
		{
			get;
			internal set;
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x000B2CA0 File Offset: 0x000B0EA0
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x000B2CB4 File Offset: 0x000B0EB4
		internal uint firstHitterRaidId
		{
			get;
			set;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000B2CC8 File Offset: 0x000B0EC8
		public int buffsCount()
		{
			return c0ce5ac6ea366633aaf6d960fb8dbde46.c30767ddca1f9c207888833aea5b5fc61(this.get_cb8ab3d693dd5ddd3256aa3952287f96a());
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000B2CE4 File Offset: 0x000B0EE4
		public bool isAlive()
		{
			if (ce58821487ae4575ad408348e39848b06.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					RuntimeMethodHandle arg_1C_0 = methodof(Creature.isAlive()).MethodHandle;
				}
				if (ce7a2a2bd5a314372d9c4632e238ba81a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != 0)
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
					if (ca7f08083d0c234ebff9658f4f6c72db6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46908))
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
						if (ce7a2a2bd5a314372d9c4632e238ba81a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46912))
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								goto IL_6D;
							}
						}
					}
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46920) != 0;
				}
			}
			IL_6D:
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46916) != 0;
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x000B2D74 File Offset: 0x000B0F74
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x000B2D88 File Offset: 0x000B0F88
		internal bool alive
		{
			get;
			set;
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x000B2D9C File Offset: 0x000B0F9C
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x000B2DB0 File Offset: 0x000B0FB0
		public bool sitOnMount
		{
			get;
			internal set;
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x000B2DC4 File Offset: 0x000B0FC4
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x000B2DD8 File Offset: 0x000B0FD8
		internal uint sitMountObjid
		{
			get;
			set;
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x000B2DEC File Offset: 0x000B0FEC
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x000B2E00 File Offset: 0x000B1000
		public Creature sitMountObj
		{
			get;
			internal set;
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x000B2E14 File Offset: 0x000B1014
		public int angle(Creature obj)
		{
			double num = (double)c693351d775647b6dede1f7d4c1e9b009.c30767ddca1f9c207888833aea5b5fc61(obj) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46924);
			double num2 = cc0584be127ed049ff283cd2d1a4f284a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cac47f7f7557afe4776ec97f5dda1c910.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(obj), c6fb106c4a050cb4c0de6f0e1e1744d58.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(obj) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46932)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46940) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46948);
			double num3 = num - num2;
			for (num3 -= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46956); num3 > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46972); num3 -= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46964))
			{
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
				RuntimeMethodHandle arg_AD_0 = methodof(Creature.angle(Creature)).MethodHandle;
			}
			while (num3 < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46988))
			{
				num3 += c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(46980);
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
			return (int)c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num3);
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x000B2F04 File Offset: 0x000B1104
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x000B2F18 File Offset: 0x000B1118
		public uint uniqId
		{
			get;
			internal set;
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x000B2F2C File Offset: 0x000B112C
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x000B2F40 File Offset: 0x000B1140
		public uint lastAttackObjId
		{
			get;
			internal set;
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x000B2F54 File Offset: 0x000B1154
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x000B2F68 File Offset: 0x000B1168
		public long lastAttackObjTime
		{
			get;
			internal set;
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x000B2F7C File Offset: 0x000B117C
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x000B2F90 File Offset: 0x000B1190
		public uint lastAttackedByObjId
		{
			get;
			internal set;
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x000B2FA4 File Offset: 0x000B11A4
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x000B2FB8 File Offset: 0x000B11B8
		public Creature target
		{
			get;
			internal set;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x000B2FCC File Offset: 0x000B11CC
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x000B2FE0 File Offset: 0x000B11E0
		public bool inFight
		{
			get;
			internal set;
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x000B2FF4 File Offset: 0x000B11F4
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x000B3008 File Offset: 0x000B1208
		internal ushort lastEventUniqCastId
		{
			get;
			set;
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x000B301C File Offset: 0x000B121C
		public bool isCasting
		{
			get
			{
				if (!this.c1386b37302cbc97bdb0c11014f918906())
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
						RuntimeMethodHandle arg_1C_0 = methodof(Creature.get_isCasting()).MethodHandle;
					}
					return this.cd39c552a6d0098c2c626d5bb98b449e1();
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(46996) != 0;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x000B305C File Offset: 0x000B125C
		public uint castSkillId
		{
			get
			{
				try
				{
					long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
					List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47000); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47004))
					{
						if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
								RuntimeMethodHandle arg_4E_0 = methodof(Creature.get_castSkillId()).MethodHandle;
							}
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 <= num)
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
								if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a <= num)
								{
									goto IL_96;
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
							return cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).cbe5fb745fb9d18c1a122f67582a2fc76;
						}
						IL_96:;
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
				catch
				{
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47008);
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000B3148 File Offset: 0x000B1348
		internal uint cc9abf175e4820b234eb2fb1b7cc3232e()
		{
			try
			{
				long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47012); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47016))
				{
					if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							RuntimeMethodHandle arg_4E_0 = methodof(Creature.cc9abf175e4820b234eb2fb1b7cc3232e()).MethodHandle;
						}
						if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 <= num)
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
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a <= num)
							{
								goto IL_96;
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
						return cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).cbe5fb745fb9d18c1a122f67582a2fc76;
					}
					IL_96:;
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
			catch
			{
			}
			return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47020);
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x000B3234 File Offset: 0x000B1434
		public long castEndTime
		{
			get
			{
				try
				{
					long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
					List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47024); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47036))
					{
						if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
								RuntimeMethodHandle arg_51_0 = methodof(Creature.get_castEndTime()).MethodHandle;
							}
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 > num)
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
								long result = c4af3755d22827d7132c867daade9dc20.c0cf59c3e67a46fd4edb3040c5ab0bbfb((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47028), cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 - cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede());
								return result;
							}
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a > num)
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
								long result = c4af3755d22827d7132c867daade9dc20.c0cf59c3e67a46fd4edb3040c5ab0bbfb((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47032), cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a - cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede());
								return result;
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
				catch
				{
				}
				return (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47040);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x000B3378 File Offset: 0x000B1578
		public SpawnObject castObject
		{
			get
			{
				try
				{
					long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
					List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47044); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47048))
					{
						if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
								RuntimeMethodHandle arg_51_0 = methodof(Creature.get_castObject()).MethodHandle;
							}
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 <= num)
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
								if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a <= num)
								{
									goto IL_D2;
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
							SpawnObject spawnObject = this.ca124a9f406cda69b904f2eb04d553ab9.cdc32f0d9e795bf98b2e0e2ccd02e57bb(cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c1bee5b31c1a4b31ee2e79f073f4753d4);
							if (spawnObject == null)
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
								spawnObject = this.ca124a9f406cda69b904f2eb04d553ab9.ce64964bdcc2e6140704544a39f43a337(cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c1bee5b31c1a4b31ee2e79f073f4753d4);
							}
							return spawnObject;
						}
						IL_D2:;
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
				catch
				{
				}
				return null;
			}
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x000B3498 File Offset: 0x000B1698
		internal bool c1386b37302cbc97bdb0c11014f918906()
		{
			try
			{
				long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47052); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47060))
				{
					if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							RuntimeMethodHandle arg_4E_0 = methodof(Creature.c1386b37302cbc97bdb0c11014f918906()).MethodHandle;
						}
						if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c4adfe2cdd155fa8cb3ea25515325bb07)
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
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 <= num)
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
								if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a <= num)
								{
									goto IL_AC;
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
							return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47056) != 0;
						}
					}
					IL_AC:;
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
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47064) != 0;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000B3598 File Offset: 0x000B1798
		internal bool cd39c552a6d0098c2c626d5bb98b449e1()
		{
			try
			{
				long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47068); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47076))
				{
					if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							RuntimeMethodHandle arg_4E_0 = methodof(Creature.cd39c552a6d0098c2c626d5bb98b449e1()).MethodHandle;
						}
						if (!cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c4adfe2cdd155fa8cb3ea25515325bb07)
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
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 <= num)
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
								if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a <= num)
								{
									goto IL_AC;
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
							return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47072) != 0;
						}
					}
					IL_AC:;
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
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47080) != 0;
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000B3698 File Offset: 0x000B1898
		internal ushort c3304f848cbd54aa72b9cd7c06930ec09()
		{
			try
			{
				long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47084); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47088))
				{
					if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							RuntimeMethodHandle arg_51_0 = methodof(Creature.c3304f848cbd54aa72b9cd7c06930ec09()).MethodHandle;
						}
						if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c4adfe2cdd155fa8cb3ea25515325bb07)
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
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 <= num)
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
								if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a <= num)
								{
									goto IL_B3;
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
							return cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c7c75833f5adadc3c7dc1d41cd11f4cac;
						}
					}
					IL_B3:;
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
			catch
			{
			}
			return (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47092);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000B37A0 File Offset: 0x000B19A0
		internal ushort c9e798afb605ab0d1f7e5351aa39da3e7()
		{
			try
			{
				long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
				List<CoreInternal.c2f7469171728f66367bcce1a97b277a2> list = this.ca124a9f406cda69b904f2eb04d553ab9.c7183147a80567c2f6f58c7fa329f9821();
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47096); i < c0d5f999167488e53c02d310fa305152c.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47100))
				{
					if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f == c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
							RuntimeMethodHandle arg_51_0 = methodof(Creature.c9e798afb605ab0d1f7e5351aa39da3e7()).MethodHandle;
						}
						if (!cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c4adfe2cdd155fa8cb3ea25515325bb07)
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
							if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).ce67e54ff1cdd733405b22582cac1e4a0 <= num)
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
								if (cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c2a0a1eff88ecda6dbc92ecef574b068a <= num)
								{
									goto IL_B3;
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
							return cc24f05a19fd4989e0bc9a2c31116fc9d.c30767ddca1f9c207888833aea5b5fc61(list, i).c7c75833f5adadc3c7dc1d41cd11f4cac;
						}
					}
					IL_B3:;
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
			catch
			{
			}
			return (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47104);
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x000B38A8 File Offset: 0x000B1AA8
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x000B38BC File Offset: 0x000B1ABC
		public bool isMoving
		{
			get;
			internal set;
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x000B38D0 File Offset: 0x000B1AD0
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x000B38E4 File Offset: 0x000B1AE4
		public int hpRegen
		{
			get;
			internal set;
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x000B38F8 File Offset: 0x000B1AF8
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x000B390C File Offset: 0x000B1B0C
		public int battleHpRegen
		{
			get;
			internal set;
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x000B3920 File Offset: 0x000B1B20
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x000B3934 File Offset: 0x000B1B34
		public int mpRegen
		{
			get;
			internal set;
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x000B3948 File Offset: 0x000B1B48
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x000B395C File Offset: 0x000B1B5C
		public int lungCapacity
		{
			get;
			internal set;
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x000B3970 File Offset: 0x000B1B70
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x000B3984 File Offset: 0x000B1B84
		public int battleMpRegen
		{
			get;
			internal set;
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000B3998 File Offset: 0x000B1B98
		public int hpp
		{
			get
			{
				return c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47108), c34f0f68932ceb7756e2775a73f05347d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47112), (int)cf55a5900294dd47345b760f1091c9534.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)this.cd4d0fbd503c4ba09d5154765fd76e3a4 / (((double)this.ca254a779a943442d6af20a6e09fc3da2 + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47116)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47124)) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47132))));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x000B3A0C File Offset: 0x000B1C0C
		public int mpp
		{
			get
			{
				return c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47140), c34f0f68932ceb7756e2775a73f05347d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47144), (int)cf55a5900294dd47345b760f1091c9534.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)this.c6b9617bd74847c0419f852a0bf61b80e / (((double)this.c5822a8e7fe49988ae2e6c7c2268e683e + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47148)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47156)) + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47164))));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x000B3A80 File Offset: 0x000B1C80
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x000B3A98 File Offset: 0x000B1C98
		public int maxHp
		{
			get
			{
				return this.ca254a779a943442d6af20a6e09fc3da2;
			}
			internal set
			{
				this.ca254a779a943442d6af20a6e09fc3da2 = value;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x000B3AB0 File Offset: 0x000B1CB0
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x000B3AC8 File Offset: 0x000B1CC8
		public int maxMp
		{
			get
			{
				return this.c5822a8e7fe49988ae2e6c7c2268e683e;
			}
			internal set
			{
				this.c5822a8e7fe49988ae2e6c7c2268e683e = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001390 RID: 5008 RVA: 0x000B3AE0 File Offset: 0x000B1CE0
		// (set) Token: 0x06001391 RID: 5009 RVA: 0x000B3AF4 File Offset: 0x000B1CF4
		internal double pattack
		{
			get;
			set;
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x000B3B08 File Offset: 0x000B1D08
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x000B3B1C File Offset: 0x000B1D1C
		internal double rattack
		{
			get;
			set;
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x000B3B30 File Offset: 0x000B1D30
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x000B3B44 File Offset: 0x000B1D44
		internal double mattack
		{
			get;
			set;
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x000B3B58 File Offset: 0x000B1D58
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x000B3B6C File Offset: 0x000B1D6C
		internal double attackSpeed
		{
			get;
			set;
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x000B3B80 File Offset: 0x000B1D80
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x000B3B94 File Offset: 0x000B1D94
		internal double movespeed
		{
			get;
			set;
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x000B3BA8 File Offset: 0x000B1DA8
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x000B3BBC File Offset: 0x000B1DBC
		internal double mdef
		{
			get;
			set;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000B3BD0 File Offset: 0x000B1DD0
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x000B3BE4 File Offset: 0x000B1DE4
		internal double pdef
		{
			get;
			set;
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000B3BF8 File Offset: 0x000B1DF8
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x000B3C0C File Offset: 0x000B1E0C
		internal double castSpeed
		{
			get;
			set;
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x000B3C20 File Offset: 0x000B1E20
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x000B3C34 File Offset: 0x000B1E34
		public bool isSwim
		{
			get;
			internal set;
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x000B3C48 File Offset: 0x000B1E48
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x000B3C60 File Offset: 0x000B1E60
		public int hp
		{
			get
			{
				return this.cd4d0fbd503c4ba09d5154765fd76e3a4;
			}
			internal set
			{
				this.cd4d0fbd503c4ba09d5154765fd76e3a4 = value;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x000B3C78 File Offset: 0x000B1E78
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x000B3C90 File Offset: 0x000B1E90
		public int mp
		{
			get
			{
				return this.c6b9617bd74847c0419f852a0bf61b80e;
			}
			internal set
			{
				this.c6b9617bd74847c0419f852a0bf61b80e = value;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x000B3CA8 File Offset: 0x000B1EA8
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x000B3CBC File Offset: 0x000B1EBC
		public int statStr
		{
			get;
			internal set;
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x000B3CD0 File Offset: 0x000B1ED0
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x000B3CE4 File Offset: 0x000B1EE4
		public int statInt
		{
			get;
			internal set;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x000B3CF8 File Offset: 0x000B1EF8
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x000B3D0C File Offset: 0x000B1F0C
		public int statDex
		{
			get;
			internal set;
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x000B3D20 File Offset: 0x000B1F20
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x000B3D34 File Offset: 0x000B1F34
		public int statWit
		{
			get;
			internal set;
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x000B3D48 File Offset: 0x000B1F48
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x000B3D5C File Offset: 0x000B1F5C
		public int statCon
		{
			get;
			internal set;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x000B3D70 File Offset: 0x000B1F70
		public List<Buff> getBuffs()
		{
			List<Buff> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c844e78704e072a4cebca640ae7d68952))
			{
				result = this.c844e78704e072a4cebca640ae7d68952.ToList<Buff>();
			}
			return result;
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x000B3DBC File Offset: 0x000B1FBC
		internal List<Buff> get_cb8ab3d693dd5ddd3256aa3952287f96a()
		{
			return this.c844e78704e072a4cebca640ae7d68952;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x000B3DD0 File Offset: 0x000B1FD0
		internal void set_cb8ab3d693dd5ddd3256aa3952287f96a(List<Buff> list)
		{
			this.c844e78704e072a4cebca640ae7d68952 = list;
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000B3DE4 File Offset: 0x000B1FE4
		public List<Item> getItems()
		{
			List<Item> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd))
			{
				result = this.ca39f2e8ca6dda4ec17f3e6ceb08873cd.ToList<Item>();
			}
			return result;
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x000B3E30 File Offset: 0x000B2030
		public List<Item> getDiceItems()
		{
			List<Item> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca128f9da78af63f9367bbe64bfc375fc))
			{
				result = this.ca128f9da78af63f9367bbe64bfc375fc.ToList<Item>();
			}
			return result;
		}

		// Token: 0x060013B5 RID: 5045 RVA: 0x000B3E7C File Offset: 0x000B207C
		public Item getEquipedItem(uint id)
		{
			List<Item> list = cb4899d5da4f101706c00e34b82878943.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47172); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47180))
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47176))
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
						RuntimeMethodHandle arg_44_0 = methodof(Creature.getEquipedItem(uint)).MethodHandle;
					}
					if (cd729ec847ff80bc33029eca3bd963a73.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == id)
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
						return c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i);
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
			return null;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x000B3F18 File Offset: 0x000B2118
		public Item getEquipedItem(string name)
		{
			List<Item> list = cb4899d5da4f101706c00e34b82878943.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47184); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47196))
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47188))
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
						RuntimeMethodHandle arg_44_0 = methodof(Creature.getEquipedItem(string)).MethodHandle;
					}
					if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c30271afd2bef338756d16f99f3ae6a38.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)), name, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47192) != 0) == 0)
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
						return c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i);
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
			return null;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x000B3FC8 File Offset: 0x000B21C8
		public Item getInvItem(uint id)
		{
			List<Item> list = cb4899d5da4f101706c00e34b82878943.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47200); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47208))
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47204))
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
						RuntimeMethodHandle arg_44_0 = methodof(Creature.getInvItem(uint)).MethodHandle;
					}
					if (cd729ec847ff80bc33029eca3bd963a73.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == id)
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
						return c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i);
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
			return null;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x000B4064 File Offset: 0x000B2264
		public Item getInvItem(string name)
		{
			List<Item> list = cb4899d5da4f101706c00e34b82878943.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47212); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47224))
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47216))
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
						RuntimeMethodHandle arg_44_0 = methodof(Creature.getInvItem(string)).MethodHandle;
					}
					if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c30271afd2bef338756d16f99f3ae6a38.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)), name, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47220) != 0) == 0)
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
						return c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i);
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
			return null;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x000B4114 File Offset: 0x000B2314
		internal List<Item> get_cacbaa35d25d410d86c30b4ae8a318175()
		{
			return this.ca39f2e8ca6dda4ec17f3e6ceb08873cd;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000B4128 File Offset: 0x000B2328
		internal void set_cacbaa35d25d410d86c30b4ae8a318175(List<Item> list)
		{
			this.ca39f2e8ca6dda4ec17f3e6ceb08873cd = list;
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000B413C File Offset: 0x000B233C
		internal List<Item> get_ca36edb52d2337b0f805af0fdcd6d0930()
		{
			return this.ca128f9da78af63f9367bbe64bfc375fc;
		}

		// Token: 0x060013BC RID: 5052 RVA: 0x000B4150 File Offset: 0x000B2350
		internal void set_ca36edb52d2337b0f805af0fdcd6d0930(List<Item> list)
		{
			this.ca128f9da78af63f9367bbe64bfc375fc = list;
		}

		// Token: 0x060013BD RID: 5053 RVA: 0x000B4164 File Offset: 0x000B2364
		public List<Skill> getSkills()
		{
			List<Skill> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.cdac6622759dddc6399c15f0e0489fdb7))
			{
				result = this.cdac6622759dddc6399c15f0e0489fdb7.ToList<Skill>();
			}
			return result;
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x000B41B0 File Offset: 0x000B23B0
		internal List<Skill> get_cbf5f28a0000c02be65b0b89d7dbf0deb()
		{
			return this.cdac6622759dddc6399c15f0e0489fdb7;
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x000B41C4 File Offset: 0x000B23C4
		internal void set_cbf5f28a0000c02be65b0b89d7dbf0deb(List<Skill> list)
		{
			this.cdac6622759dddc6399c15f0e0489fdb7 = list;
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060013C0 RID: 5056 RVA: 0x000B41D8 File Offset: 0x000B23D8
		// (set) Token: 0x060013C1 RID: 5057 RVA: 0x000B41EC File Offset: 0x000B23EC
		public byte level
		{
			get;
			internal set;
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x000B4200 File Offset: 0x000B2400
		// (set) Token: 0x060013C3 RID: 5059 RVA: 0x000B4214 File Offset: 0x000B2414
		internal string nick
		{
			get;
			set;
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060013C4 RID: 5060 RVA: 0x000B4228 File Offset: 0x000B2428
		// (set) Token: 0x060013C5 RID: 5061 RVA: 0x000B423C File Offset: 0x000B243C
		public bool isClimb
		{
			get;
			internal set;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x000B4250 File Offset: 0x000B2450
		// (set) Token: 0x060013C7 RID: 5063 RVA: 0x000B4264 File Offset: 0x000B2464
		public bool isBound
		{
			get;
			internal set;
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x000B4278 File Offset: 0x000B2478
		// (set) Token: 0x060013C9 RID: 5065 RVA: 0x000B428C File Offset: 0x000B248C
		public DoodadObject boundObj
		{
			get;
			internal set;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x000B42A0 File Offset: 0x000B24A0
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x000B42B4 File Offset: 0x000B24B4
		public Creature aggroTarget
		{
			get;
			internal set;
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060013CC RID: 5068 RVA: 0x000B42C8 File Offset: 0x000B24C8
		// (set) Token: 0x060013CD RID: 5069 RVA: 0x000B42DC File Offset: 0x000B24DC
		internal uint targetObjId
		{
			get;
			set;
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060013CE RID: 5070 RVA: 0x000B42F0 File Offset: 0x000B24F0
		// (set) Token: 0x060013CF RID: 5071 RVA: 0x000B4304 File Offset: 0x000B2504
		public uint creatureId
		{
			get;
			internal set;
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060013D0 RID: 5072 RVA: 0x000B4318 File Offset: 0x000B2518
		// (set) Token: 0x060013D1 RID: 5073 RVA: 0x000B432C File Offset: 0x000B252C
		public CharRace charRace
		{
			get;
			internal set;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x000B4340 File Offset: 0x000B2540
		// (set) Token: 0x060013D3 RID: 5075 RVA: 0x000B4354 File Offset: 0x000B2554
		public CharGender charGender
		{
			get;
			internal set;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x000B4368 File Offset: 0x000B2568
		// (set) Token: 0x060013D5 RID: 5077 RVA: 0x000B437C File Offset: 0x000B257C
		public SqlNpc db
		{
			get;
			internal set;
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x000B4390 File Offset: 0x000B2590
		// (set) Token: 0x060013D7 RID: 5079 RVA: 0x000B43A4 File Offset: 0x000B25A4
		internal byte creatureType
		{
			get;
			set;
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x000B43B8 File Offset: 0x000B25B8
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x000B43CC File Offset: 0x000B25CC
		public uint factionId
		{
			get;
			internal set;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x000B43E0 File Offset: 0x000B25E0
		// (set) Token: 0x060013DB RID: 5083 RVA: 0x000B43F4 File Offset: 0x000B25F4
		public uint familiId
		{
			get;
			internal set;
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x000B4408 File Offset: 0x000B2608
		// (set) Token: 0x060013DD RID: 5085 RVA: 0x000B441C File Offset: 0x000B261C
		public uint clanId
		{
			get;
			internal set;
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x000B4430 File Offset: 0x000B2630
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x000B4444 File Offset: 0x000B2644
		internal byte relationToMe
		{
			get;
			set;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x000B4458 File Offset: 0x000B2658
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x000B446C File Offset: 0x000B266C
		public uint ownerUniqId
		{
			get;
			internal set;
		}

		// Token: 0x04000E36 RID: 3638
		private Creature.c6b328e74ab177ee259d96b3c213301d0[] cafa84aeaea8fd7a2b65f512a13886696;

		// Token: 0x04000E37 RID: 3639
		private List<Creature> c3ac6bbd7104005c350b3c9078326354b;

		// Token: 0x04000E38 RID: 3640
		internal int c1b81150f8295a5d2abe14f553d2d7ba6;

		// Token: 0x04000E39 RID: 3641
		private volatile int ca254a779a943442d6af20a6e09fc3da2;

		// Token: 0x04000E3A RID: 3642
		private volatile int c5822a8e7fe49988ae2e6c7c2268e683e;

		// Token: 0x04000E3B RID: 3643
		private volatile int cd4d0fbd503c4ba09d5154765fd76e3a4;

		// Token: 0x04000E3C RID: 3644
		private volatile int c6b9617bd74847c0419f852a0bf61b80e;

		// Token: 0x04000E3D RID: 3645
		public long castingDelayTime;

		// Token: 0x04000E3E RID: 3646
		internal long c37c8636b5b3f4af1257c9fe443d75b76;

		// Token: 0x04000E3F RID: 3647
		private List<Buff> c844e78704e072a4cebca640ae7d68952;

		// Token: 0x04000E40 RID: 3648
		private List<Item> ca39f2e8ca6dda4ec17f3e6ceb08873cd;

		// Token: 0x04000E41 RID: 3649
		private List<Item> ca128f9da78af63f9367bbe64bfc375fc;

		// Token: 0x04000E42 RID: 3650
		private List<Skill> cdac6622759dddc6399c15f0e0489fdb7;

		// Token: 0x04000E43 RID: 3651
		internal List<DoodadObject> cff2d4228c170b27c10672d632f77e7c9;

		// Token: 0x04000E44 RID: 3652
		[CompilerGenerated]
		private Creature cf1fd03fe582c29bbb3f9c006b4d29c94;

		// Token: 0x04000E45 RID: 3653
		[CompilerGenerated]
		private Creature c9a33fc798b71652a95c5be62be538e16;

		// Token: 0x04000E46 RID: 3654
		[CompilerGenerated]
		private bool c547d1a3a054bb5394dc55ac0a09f0d67;

		// Token: 0x04000E47 RID: 3655
		[CompilerGenerated]
		private int c4b34300aaab4e72cf347ec82b08ba6a8;

		// Token: 0x04000E48 RID: 3656
		[CompilerGenerated]
		private Appellation c00f760666426b04ab9b80bb9a5b745e8;

		// Token: 0x04000E49 RID: 3657
		[CompilerGenerated]
		private long c979036abb3f1fc0e6da8cf1e101e3a3f;

		// Token: 0x04000E4A RID: 3658
		[CompilerGenerated]
		private Creature cfc011af5e099411897f6a6d39eec5df6;

		// Token: 0x04000E4B RID: 3659
		[CompilerGenerated]
		private uint c6bd50c007d6d106bb5570f1dd9d0ae46;

		// Token: 0x04000E4C RID: 3660
		[CompilerGenerated]
		private uint c82b76bf73d1174f22fc825fe10626d45;

		// Token: 0x04000E4D RID: 3661
		[CompilerGenerated]
		private bool c06ed903ac284c880bc6c225b4b9f2645;

		// Token: 0x04000E4E RID: 3662
		[CompilerGenerated]
		private bool c834c1ee927d836a5ea38c21e67cc1e33;

		// Token: 0x04000E4F RID: 3663
		[CompilerGenerated]
		private uint ce958d7b493d446cb531bfcb50c12f9b0;

		// Token: 0x04000E50 RID: 3664
		[CompilerGenerated]
		private Creature c9ba1d53d6e20f12f628ba037f308586c;

		// Token: 0x04000E51 RID: 3665
		[CompilerGenerated]
		private uint c1f042b599e757f7d30e4be9756bd3cb4;

		// Token: 0x04000E52 RID: 3666
		[CompilerGenerated]
		private uint c74dc6d87ff0c775eb1112abbc08b8e80;

		// Token: 0x04000E53 RID: 3667
		[CompilerGenerated]
		private long c0051486df31c46810a49125d1d11f053;

		// Token: 0x04000E54 RID: 3668
		[CompilerGenerated]
		private uint c9cc15c171cdc2e4aa92f47c3da58282a;

		// Token: 0x04000E55 RID: 3669
		[CompilerGenerated]
		private Creature c20a751968410f35051b7e8dd973a5128;

		// Token: 0x04000E56 RID: 3670
		[CompilerGenerated]
		private bool cba97bc8841d2fdfff6b1f512ee863de0;

		// Token: 0x04000E57 RID: 3671
		[CompilerGenerated]
		private ushort c6e1f4fcc4ed2a06ccd510b05f2aebf9d;

		// Token: 0x04000E58 RID: 3672
		[CompilerGenerated]
		private bool cad5f2cbd57f1e44e9df62f0de6802298;

		// Token: 0x04000E59 RID: 3673
		[CompilerGenerated]
		private int cee61a3b3452d928680801fcf8d5ff416;

		// Token: 0x04000E5A RID: 3674
		[CompilerGenerated]
		private int cd5aa0f23a12d047b7058dced309c4377;

		// Token: 0x04000E5B RID: 3675
		[CompilerGenerated]
		private int c5d64dbda6db90986a63c4c481c03e48a;

		// Token: 0x04000E5C RID: 3676
		[CompilerGenerated]
		private int cbb689305cf06a3eebbccabd1fcc0246a;

		// Token: 0x04000E5D RID: 3677
		[CompilerGenerated]
		private int cfd709f452c73086c8e4f2dc1b72b3cc1;

		// Token: 0x04000E5E RID: 3678
		[CompilerGenerated]
		private double cc3cadd8a5a59e5f90ac8d2a8ebb3ed4d;

		// Token: 0x04000E5F RID: 3679
		[CompilerGenerated]
		private double c66e71e7be9a1f4a4839ff2cbc181f517;

		// Token: 0x04000E60 RID: 3680
		[CompilerGenerated]
		private double c9ec268fbfe7754ea158b231c813309ed;

		// Token: 0x04000E61 RID: 3681
		[CompilerGenerated]
		private double ce37231f2a4f00ad7865ac2439a7be9e2;

		// Token: 0x04000E62 RID: 3682
		[CompilerGenerated]
		private double ccdbf218b4168aca7fa2d6ea15e192354;

		// Token: 0x04000E63 RID: 3683
		[CompilerGenerated]
		private double c98c908b8177804da8b8e212d39b40a1e;

		// Token: 0x04000E64 RID: 3684
		[CompilerGenerated]
		private double c7fb4e9c69c5cc3e3cb6f8ee8817c98d2;

		// Token: 0x04000E65 RID: 3685
		[CompilerGenerated]
		private double c560f39086f224387bb8380db72e6630f;

		// Token: 0x04000E66 RID: 3686
		[CompilerGenerated]
		private bool cd5ecc74c90865127786d57b53a930094;

		// Token: 0x04000E67 RID: 3687
		[CompilerGenerated]
		private int cc6f9d811478a319068246c593cad1bd1;

		// Token: 0x04000E68 RID: 3688
		[CompilerGenerated]
		private int cc0634feba6dc0decfc2fbe554d97e792;

		// Token: 0x04000E69 RID: 3689
		[CompilerGenerated]
		private int c5cdfcffbc2da5f389dd8c35b9be1a9a1;

		// Token: 0x04000E6A RID: 3690
		[CompilerGenerated]
		private int c554792414442459a0eb441aec6c3d694;

		// Token: 0x04000E6B RID: 3691
		[CompilerGenerated]
		private int c670ea6f59cfa71a131f5c86d2515295f;

		// Token: 0x04000E6C RID: 3692
		[CompilerGenerated]
		private byte cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x04000E6D RID: 3693
		[CompilerGenerated]
		private string c984aeaa5591c594312d32fce1c3fe920;

		// Token: 0x04000E6E RID: 3694
		[CompilerGenerated]
		private bool cf46dc988f10158e17eeca2db19753d12;

		// Token: 0x04000E6F RID: 3695
		[CompilerGenerated]
		private bool c53d84672b16be797a066ea153a8d1140;

		// Token: 0x04000E70 RID: 3696
		[CompilerGenerated]
		private DoodadObject c39c43032656d3879570086bda3ce5fc8;

		// Token: 0x04000E71 RID: 3697
		[CompilerGenerated]
		private Creature c8e0598b98cf50fb739ec6cd8b3611d82;

		// Token: 0x04000E72 RID: 3698
		[CompilerGenerated]
		private uint c19069e1b0f10c1fa594e8b22c54dc304;

		// Token: 0x04000E73 RID: 3699
		[CompilerGenerated]
		private uint ce0bf7c58df5da0e8fb6e054784269e83;

		// Token: 0x04000E74 RID: 3700
		[CompilerGenerated]
		private CharRace c2995110f05b437ddf67d00dcf4279ddc;

		// Token: 0x04000E75 RID: 3701
		[CompilerGenerated]
		private CharGender ca2f7c82fb6a542d968fab8d2cb7fe22b;

		// Token: 0x04000E76 RID: 3702
		[CompilerGenerated]
		private SqlNpc cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x04000E77 RID: 3703
		[CompilerGenerated]
		private byte c6ad9865cbce82d8aaa4f26ac01fffe27;

		// Token: 0x04000E78 RID: 3704
		[CompilerGenerated]
		private uint cae402fd5e3b416143b2944d730e17f9b;

		// Token: 0x04000E79 RID: 3705
		[CompilerGenerated]
		private uint ccb1a09d9ffd9db22577326a59f224a3f;

		// Token: 0x04000E7A RID: 3706
		[CompilerGenerated]
		private uint c614d6c6b7667a38b221a9c10f59c86bf;

		// Token: 0x04000E7B RID: 3707
		[CompilerGenerated]
		private byte c9be3e601cb9a14f4f54e6e8b7e5a6d77;

		// Token: 0x04000E7C RID: 3708
		[CompilerGenerated]
		private uint cea30d41c9afe904703df9a19caf6c940;

		// Token: 0x020004CB RID: 1227
		private struct c6b328e74ab177ee259d96b3c213301d0
		{
			// Token: 0x060013E2 RID: 5090 RVA: 0x000B4480 File Offset: 0x000B2680
			public void cfc4265a0bc048786ecb6e2d1e173a736()
			{
				this.c644dcb409c6527970e516e7c53e3eef1 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47252);
				this.c22db3a4124e20f4086b50415686d7ca3 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47260);
				this.cbe5cdb7247bab90c29da820d631002c6 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47268);
				this.c80f9fe22c7cf5267e78663d40cd4bd23 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47276);
			}

			// Token: 0x060013E3 RID: 5091 RVA: 0x000B44D8 File Offset: 0x000B26D8
			public void c11546181b1262acba2edb5e5d103f097()
			{
				if (this.cbe5cdb7247bab90c29da820d631002c6 < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47284))
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
						RuntimeMethodHandle arg_26_0 = methodof(Creature.c6b328e74ab177ee259d96b3c213301d0.c11546181b1262acba2edb5e5d103f097()).MethodHandle;
					}
					cc4987d6a853db77954f21abe4e42946a.c49e6f431917e06939cb9b64b69d2938e(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(192266));
				}
				this.c80f9fe22c7cf5267e78663d40cd4bd23 = c3dae4afdba118d64ec6293e657258fb4.c0cf59c3e67a46fd4edb3040c5ab0bbfb((this.c644dcb409c6527970e516e7c53e3eef1 + this.c22db3a4124e20f4086b50415686d7ca3) * this.cbe5cdb7247bab90c29da820d631002c6);
			}

			// Token: 0x04000E7D RID: 3709
			public double c644dcb409c6527970e516e7c53e3eef1;

			// Token: 0x04000E7E RID: 3710
			public double c22db3a4124e20f4086b50415686d7ca3;

			// Token: 0x04000E7F RID: 3711
			public double cbe5cdb7247bab90c29da820d631002c6;

			// Token: 0x04000E80 RID: 3712
			public double c80f9fe22c7cf5267e78663d40cd4bd23;
		}
	}
}
