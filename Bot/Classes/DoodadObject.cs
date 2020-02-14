using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004DD RID: 1245
	public class DoodadObject : SpawnObject
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x000B84C4 File Offset: 0x000B66C4
		internal DoodadObject(CoreInternal coreInternal) : base(coreInternal)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48420));
			c29a933ee6aeb8c5b175541e14775040e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede());
			this.c75d3102bfe93d831b8bfbf438c1177f4 = new List<Skill>();
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000B8508 File Offset: 0x000B6708
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(DoodadObject.Dispose(bool)).MethodHandle;
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c75d3102bfe93d831b8bfbf438c1177f4))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48260); i < cd76bd05d82b141b0544cd21df6dcb6a0.c30767ddca1f9c207888833aea5b5fc61(this.c75d3102bfe93d831b8bfbf438c1177f4); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48268))
							{
								this.ca124a9f406cda69b904f2eb04d553ab9.c90df767ef7fe39c08d7aecfb5bffe66c(c5cac1bec31f0d74685de039f19d81dc0.c30767ddca1f9c207888833aea5b5fc61(this.c75d3102bfe93d831b8bfbf438c1177f4, i), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48264));
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
						cda4822de1bbd6abfeba5e3a010a22309.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cf5d2d2aefe7e4e7fa2df2122921a4771.c8a754f5f2ca4adde825691a9c31a0e83);
						cc6c7f2296db6f2908c7ef8bdad2e38ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c2b067e4220a1120902b231166f01ae09.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					cc772cb612abb65e47a5ee7ac6a23da5c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x000B8604 File Offset: 0x000B6804
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x000B8618 File Offset: 0x000B6818
		internal long lastUpdateTime
		{
			get;
			set;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000B862C File Offset: 0x000B682C
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x000B8640 File Offset: 0x000B6840
		public uint commonFarmId
		{
			get;
			internal set;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x000B8654 File Offset: 0x000B6854
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x000B8668 File Offset: 0x000B6868
		internal byte plantZoneType
		{
			get;
			set;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000B867C File Offset: 0x000B687C
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x000B8690 File Offset: 0x000B6890
		public uint plantZoneId
		{
			get;
			internal set;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000B86A4 File Offset: 0x000B68A4
		public uint id
		{
			get
			{
				if (c79053bd96887d68d3b70b9f8be69d634.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(DoodadObject.get_id()).MethodHandle;
					}
					return c1fc7d32a2b582dbc82c78a6da72227e0.c30767ddca1f9c207888833aea5b5fc61(c79053bd96887d68d3b70b9f8be69d634.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48272);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000B86E8 File Offset: 0x000B68E8
		public uint phaseId
		{
			get
			{
				if (c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(DoodadObject.get_phaseId()).MethodHandle;
					}
					return c65b0c535c9829535e44f09e1d13d7815.c30767ddca1f9c207888833aea5b5fc61(c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48276);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000B872C File Offset: 0x000B692C
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x000B8740 File Offset: 0x000B6940
		public SqlDoodadAlmighty dbAlmighty
		{
			get;
			internal set;
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000B8754 File Offset: 0x000B6954
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x000B8768 File Offset: 0x000B6968
		public SqlDoodadFuncGroup dbFuncGroup
		{
			get
			{
				return this.c311eb86a4a20c44674dacf4036d7eeed;
			}
			internal set
			{
				this.c311eb86a4a20c44674dacf4036d7eeed = value;
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c75d3102bfe93d831b8bfbf438c1177f4))
				{
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48280); i < cd76bd05d82b141b0544cd21df6dcb6a0.c30767ddca1f9c207888833aea5b5fc61(this.c75d3102bfe93d831b8bfbf438c1177f4); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48288))
					{
						this.ca124a9f406cda69b904f2eb04d553ab9.c90df767ef7fe39c08d7aecfb5bffe66c(c5cac1bec31f0d74685de039f19d81dc0.c30767ddca1f9c207888833aea5b5fc61(this.c75d3102bfe93d831b8bfbf438c1177f4, i), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48284));
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
					if (!true)
					{
						RuntimeMethodHandle arg_75_0 = methodof(DoodadObject.set_dbFuncGroup(SqlDoodadFuncGroup)).MethodHandle;
					}
				}
				this.c75d3102bfe93d831b8bfbf438c1177f4 = c6e0d327cf375fabb5b5c81f83ea70ad7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				if (this.c311eb86a4a20c44674dacf4036d7eeed == null)
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
					return;
				}
				try
				{
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48292); j < cde54a87791a3f1ed011f2c89732e9c7c.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(this.c311eb86a4a20c44674dacf4036d7eeed)); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48304))
					{
						Skill skill = c753a7b0430d3c8fbe8b8252a309654b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ca124a9f406cda69b904f2eb04d553ab9);
						c2323af68038122949e1a63ea57f63893.c30767ddca1f9c207888833aea5b5fc61(skill, c4e5798155f7a355098632ea8907b4289.c30767ddca1f9c207888833aea5b5fc61(c2be19745b3de7ebcfa2088253907e0e7.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(this.c311eb86a4a20c44674dacf4036d7eeed), j)));
						skill.c4aaf7619a600d569451f27c0b2b78918();
						c8052d8fa1ffc041334dae2cf04071e12.c30767ddca1f9c207888833aea5b5fc61(skill, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48296) != 0);
						cfe62260af809b6412aad0b1c3d372df9.c30767ddca1f9c207888833aea5b5fc61(skill, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48300));
						c94af5ff9e0927d4b75d9d141ff1dd611.c30767ddca1f9c207888833aea5b5fc61(this.c75d3102bfe93d831b8bfbf438c1177f4, skill);
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
					for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48308); k < cde54a87791a3f1ed011f2c89732e9c7c.c30767ddca1f9c207888833aea5b5fc61(c6624fb0ac089f18d26b62aff578973a0.c30767ddca1f9c207888833aea5b5fc61(this.c311eb86a4a20c44674dacf4036d7eeed)); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48320))
					{
						Skill skill2 = c753a7b0430d3c8fbe8b8252a309654b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ca124a9f406cda69b904f2eb04d553ab9);
						c2323af68038122949e1a63ea57f63893.c30767ddca1f9c207888833aea5b5fc61(skill2, c4e5798155f7a355098632ea8907b4289.c30767ddca1f9c207888833aea5b5fc61(c2be19745b3de7ebcfa2088253907e0e7.c30767ddca1f9c207888833aea5b5fc61(c6624fb0ac089f18d26b62aff578973a0.c30767ddca1f9c207888833aea5b5fc61(this.c311eb86a4a20c44674dacf4036d7eeed), k)));
						skill2.c4aaf7619a600d569451f27c0b2b78918();
						c8052d8fa1ffc041334dae2cf04071e12.c30767ddca1f9c207888833aea5b5fc61(skill2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48312) != 0);
						cfe62260af809b6412aad0b1c3d372df9.c30767ddca1f9c207888833aea5b5fc61(skill2, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48316));
						c94af5ff9e0927d4b75d9d141ff1dd611.c30767ddca1f9c207888833aea5b5fc61(this.c75d3102bfe93d831b8bfbf438c1177f4, skill2);
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
					for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48324); l < c03c09af2da8033df8d37041e758a3005.c30767ddca1f9c207888833aea5b5fc61(cb6a16d6da73e081da72abcfc62c8166e.c30767ddca1f9c207888833aea5b5fc61(this.c311eb86a4a20c44674dacf4036d7eeed)); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48336))
					{
						if (cc20c8c4cb957eff6d0d2809a1ccc5531.c30767ddca1f9c207888833aea5b5fc61(cd7f88efd78a737c6ea6e3741ba18cff7.c30767ddca1f9c207888833aea5b5fc61(cb6a16d6da73e081da72abcfc62c8166e.c30767ddca1f9c207888833aea5b5fc61(this.c311eb86a4a20c44674dacf4036d7eeed), l)) != null)
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
							Skill skill3 = c753a7b0430d3c8fbe8b8252a309654b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ca124a9f406cda69b904f2eb04d553ab9);
							c2323af68038122949e1a63ea57f63893.c30767ddca1f9c207888833aea5b5fc61(skill3, c4e5798155f7a355098632ea8907b4289.c30767ddca1f9c207888833aea5b5fc61(cc20c8c4cb957eff6d0d2809a1ccc5531.c30767ddca1f9c207888833aea5b5fc61(cd7f88efd78a737c6ea6e3741ba18cff7.c30767ddca1f9c207888833aea5b5fc61(cb6a16d6da73e081da72abcfc62c8166e.c30767ddca1f9c207888833aea5b5fc61(this.c311eb86a4a20c44674dacf4036d7eeed), l))));
							skill3.c4aaf7619a600d569451f27c0b2b78918();
							c8052d8fa1ffc041334dae2cf04071e12.c30767ddca1f9c207888833aea5b5fc61(skill3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48328) != 0);
							cfe62260af809b6412aad0b1c3d372df9.c30767ddca1f9c207888833aea5b5fc61(skill3, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48332));
							c94af5ff9e0927d4b75d9d141ff1dd611.c30767ddca1f9c207888833aea5b5fc61(this.c75d3102bfe93d831b8bfbf438c1177f4, skill3);
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
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000B8A88 File Offset: 0x000B6C88
		public string name
		{
			get
			{
				if (c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(DoodadObject.get_name()).MethodHandle;
					}
					return "";
				}
				return cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000B8AC8 File Offset: 0x000B6CC8
		public List<Skill> getUseSkills()
		{
			List<Skill> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c75d3102bfe93d831b8bfbf438c1177f4))
			{
				result = this.c75d3102bfe93d831b8bfbf438c1177f4.ToList<Skill>();
			}
			return result;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000B8B14 File Offset: 0x000B6D14
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x000B8B28 File Offset: 0x000B6D28
		public int tempGrowthTime
		{
			get;
			internal set;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000B8B3C File Offset: 0x000B6D3C
		public bool OpenPaper()
		{
			try
			{
				bool result;
				if (cf759ff9d97a71f768f1605e15ff52468.c30767ddca1f9c207888833aea5b5fc61(c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == null)
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
						RuntimeMethodHandle arg_23_0 = methodof(DoodadObject.OpenPaper()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48340));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48344) != 0);
					return result;
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48348), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48352));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new c45922c4a6d0cec9d7ad55f14c1d229e2(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c2ddbe454b04d472c2b341c527f3d1e04.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c0cbe21ad36a47caedea68002cb868b5a.c30767ddca1f9c207888833aea5b5fc61(cf759ff9d97a71f768f1605e15ff52468.c30767ddca1f9c207888833aea5b5fc61(c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), c4f13fb310f3f7f7c4a854619433b3789.c30767ddca1f9c207888833aea5b5fc61(cf759ff9d97a71f768f1605e15ff52468.c30767ddca1f9c207888833aea5b5fc61(c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))), ca972240c497fdae00fc85cd58fe2c6b5.c30767ddca1f9c207888833aea5b5fc61(cf759ff9d97a71f768f1605e15ff52468.c30767ddca1f9c207888833aea5b5fc61(c1ece7fbdcf5236ded06368fd0fda9391.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48356) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48360), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48364));
				return result;
			}
			catch
			{
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48368));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48372) != 0;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x000B8C7C File Offset: 0x000B6E7C
		public int growthTime
		{
			get
			{
				if (c79053bd96887d68d3b70b9f8be69d634.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1F_0 = methodof(DoodadObject.get_growthTime()).MethodHandle;
					}
					double num = (double)cca57d5c504443643d741447516a3a348.c30767ddca1f9c207888833aea5b5fc61(c79053bd96887d68d3b70b9f8be69d634.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(48376);
					if (cd544300c51f0308afc858bcd5ca1f7e5.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.ccdac7546f70c9f32c43902745dd4953a, (uint)cb2d17d87d79f2554bea1a249062e743e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())))
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
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48384); i < cb669e670ce9373d95ec3bd656a525036.c30767ddca1f9c207888833aea5b5fc61(cfa5a5140d3c074c8e6abb0081cce011e.c30767ddca1f9c207888833aea5b5fc61(cea649b1d3d443c9000658eda02ffdcdb.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.ccdac7546f70c9f32c43902745dd4953a, (uint)cb2d17d87d79f2554bea1a249062e743e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48404))
						{
							if (cfa9af0fe952ba2b924662439d825ab34.c30767ddca1f9c207888833aea5b5fc61(c79053bd96887d68d3b70b9f8be69d634.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == (int)c48efa50962dcfd5450744f0cea7757ae.c30767ddca1f9c207888833aea5b5fc61(cfa5a5140d3c074c8e6abb0081cce011e.c30767ddca1f9c207888833aea5b5fc61(cea649b1d3d443c9000658eda02ffdcdb.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.ccdac7546f70c9f32c43902745dd4953a, (uint)cb2d17d87d79f2554bea1a249062e743e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))), i))
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
								num = num / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(48388) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(48396);
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
					return (int)cf55a5900294dd47345b760f1091c9534.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c68797f8377ad21802dc165c1cbf88a2f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(48408), num - (double)((long)cc4987d6a853db77954f21abe4e42946a.cc6aa98c842d31c331ac756905a26d823() - c6cd1de017e5c30ad8d193b0c3a83cfcf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))));
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48416);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000B8E00 File Offset: 0x000B7000
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x000B8E14 File Offset: 0x000B7014
		public long plantTime
		{
			get;
			internal set;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x000B8E28 File Offset: 0x000B7028
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x000B8E3C File Offset: 0x000B703C
		public uint uniqOwnerId
		{
			get;
			internal set;
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x000B8E50 File Offset: 0x000B7050
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x000B8E64 File Offset: 0x000B7064
		public uint ownerObjId
		{
			get;
			internal set;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x000B8E78 File Offset: 0x000B7078
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x000B8E8C File Offset: 0x000B708C
		public uint boundObjId
		{
			get;
			internal set;
		}

		// Token: 0x04000F0B RID: 3851
		private List<Skill> c75d3102bfe93d831b8bfbf438c1177f4;

		// Token: 0x04000F0C RID: 3852
		internal bool cefcee864f727805ea140f2a57228015e;

		// Token: 0x04000F0D RID: 3853
		private SqlDoodadFuncGroup c311eb86a4a20c44674dacf4036d7eeed;

		// Token: 0x04000F0E RID: 3854
		[CompilerGenerated]
		private long cbe491440ed6eff0f4e5a65844c4fe47b;

		// Token: 0x04000F0F RID: 3855
		[CompilerGenerated]
		private uint c81be0c7d350b9cad489aec15a912f4b6;

		// Token: 0x04000F10 RID: 3856
		[CompilerGenerated]
		private byte c629bbe3b066e69205b44167240493ee4;

		// Token: 0x04000F11 RID: 3857
		[CompilerGenerated]
		private uint ccb43981feaf1240504ca49b88c6efddf;

		// Token: 0x04000F12 RID: 3858
		[CompilerGenerated]
		private SqlDoodadAlmighty c94aef9888023b2f64f087e4a4c54d310;

		// Token: 0x04000F13 RID: 3859
		[CompilerGenerated]
		private int c441b56988d54cef7930ba2d7bd056bb1;

		// Token: 0x04000F14 RID: 3860
		[CompilerGenerated]
		private long c0a6eecb793cba704c27359613dd67b96;

		// Token: 0x04000F15 RID: 3861
		[CompilerGenerated]
		private uint cad292465c9aa1da5b5f3cfd3dd5757cc;

		// Token: 0x04000F16 RID: 3862
		[CompilerGenerated]
		private uint c07a595af13511659eedad9a64aea3a7d;

		// Token: 0x04000F17 RID: 3863
		[CompilerGenerated]
		private uint c507cd74296bcf4e48e61a7b8af19c971;
	}
}
