using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004C3 RID: 1219
	public class PartyMember : BaseObject
	{
		// Token: 0x0600128D RID: 4749 RVA: 0x000ACD38 File Offset: 0x000AAF38
		internal PartyMember()
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44492));
			this.set_c05ebd1bb5f7a79e49cc11ffb772f8dea(new List<Abilities>());
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44496); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44504); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44500))
			{
				Abilities abilities = new Abilities();
				c44f29b89cb35ef62490d177807eea79b.c30767ddca1f9c207888833aea5b5fc61(this.get_c05ebd1bb5f7a79e49cc11ffb772f8dea(), abilities);
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
			if (!true)
			{
				RuntimeMethodHandle arg_6E_0 = methodof(PartyMember..ctor()).MethodHandle;
			}
			c57da0e990691485945b2a3e14fab6872.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44508));
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x000ACDC4 File Offset: 0x000AAFC4
		// (set) Token: 0x0600128F RID: 4751 RVA: 0x000ACDD8 File Offset: 0x000AAFD8
		public byte partyPlace
		{
			get;
			internal set;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000ACDEC File Offset: 0x000AAFEC
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
						RuntimeMethodHandle arg_1D_0 = methodof(PartyMember.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						c6c955eafac6a7e3f15c3ed72c5ffa95b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83);
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c62eddc2978dfd76cb081363610dd3fc1))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44476); i < c71a3a88e227aeea734e6175a33b2b61d.c30767ddca1f9c207888833aea5b5fc61(this.c62eddc2978dfd76cb081363610dd3fc1); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44480))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cbb1bb58d2cdc8d0eb0557b8560082b22.c30767ddca1f9c207888833aea5b5fc61(this.c62eddc2978dfd76cb081363610dd3fc1, i));
								c137f2252f303032c887f5c092016424c.c30767ddca1f9c207888833aea5b5fc61(this.c62eddc2978dfd76cb081363610dd3fc1, i, c1e3d44ac1410ba5973d971539d0f10b5.c8a754f5f2ca4adde825691a9c31a0e83);
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
							cc932430373f2a76d69cedbc27fbaf08b.c30767ddca1f9c207888833aea5b5fc61(this.c62eddc2978dfd76cb081363610dd3fc1);
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

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x000ACEE8 File Offset: 0x000AB0E8
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000ACF28 File Offset: 0x000AB128
		public int curhp
		{
			get
			{
				if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(PartyMember.get_curhp()).MethodHandle;
					}
					return ce7a2a2bd5a314372d9c4632e238ba81a.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return this.cd7cee882bd60db2c0a4cda86e342297a;
			}
			internal set
			{
				this.cd7cee882bd60db2c0a4cda86e342297a = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x000ACF3C File Offset: 0x000AB13C
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x000ACF7C File Offset: 0x000AB17C
		public int maxhp
		{
			get
			{
				if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(PartyMember.get_maxhp()).MethodHandle;
					}
					return c4cc0c9b7884352beee20bc8f20093aaa.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return this.c8fc44a233a165e0aa988e0760ad57421;
			}
			internal set
			{
				this.c8fc44a233a165e0aa988e0760ad57421 = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x000ACF90 File Offset: 0x000AB190
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x000ACFD0 File Offset: 0x000AB1D0
		public int curmp
		{
			get
			{
				if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(PartyMember.get_curmp()).MethodHandle;
					}
					return c31a7b3589587718d27e8e32c7ae0f0a5.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return this.c8fdf9d80dcdeb301707f8ed540e7301d;
			}
			internal set
			{
				this.c8fdf9d80dcdeb301707f8ed540e7301d = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000ACFE4 File Offset: 0x000AB1E4
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x000AD024 File Offset: 0x000AB224
		public int maxmp
		{
			get
			{
				if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(PartyMember.get_maxmp()).MethodHandle;
					}
					return c7e7fe1019de81b009ee79cb812c44372.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return this.c6ff6bd5f5cd2baf214218b3e314f0544;
			}
			internal set
			{
				this.c6ff6bd5f5cd2baf214218b3e314f0544 = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000AD038 File Offset: 0x000AB238
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x000AD078 File Offset: 0x000AB278
		public double X
		{
			get
			{
				if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(PartyMember.get_X()).MethodHandle;
					}
					return c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return this.c8eb4555110e1a9211d6f4b73fb18c2cd;
			}
			internal set
			{
				this.c8eb4555110e1a9211d6f4b73fb18c2cd = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x000AD08C File Offset: 0x000AB28C
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x000AD0CC File Offset: 0x000AB2CC
		public double Y
		{
			get
			{
				if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(PartyMember.get_Y()).MethodHandle;
					}
					return cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return this.c4c5de93b6101f484965cdf715301c901;
			}
			internal set
			{
				this.c4c5de93b6101f484965cdf715301c901 = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000AD0E0 File Offset: 0x000AB2E0
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x000AD120 File Offset: 0x000AB320
		public double Z
		{
			get
			{
				if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(PartyMember.get_Z()).MethodHandle;
					}
					return cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return this.c05b0165bf8a9dca1eb67570794948c84;
			}
			internal set
			{
				this.c05b0165bf8a9dca1eb67570794948c84 = value;
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000AD134 File Offset: 0x000AB334
		public List<Abilities> getAbilitys()
		{
			List<Abilities> result;
			if (cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
					RuntimeMethodHandle arg_1F_0 = methodof(PartyMember.getAbilitys()).MethodHandle;
				}
				if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44484))
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
					return c6b460014edf1da01cf75ba96c7369c4c.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
				}
				if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44488))
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
					return c6b460014edf1da01cf75ba96c7369c4c.c30767ddca1f9c207888833aea5b5fc61(c32a20c29d0cfb51bae292edebd3a45ab.c9963fcf210a214a3206d6500f3b9397b(cd3abc7b4833a1142035083b938da1e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
				}
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c62eddc2978dfd76cb081363610dd3fc1))
				{
					result = this.c62eddc2978dfd76cb081363610dd3fc1.ToList<Abilities>();
					return result;
				}
			}
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c62eddc2978dfd76cb081363610dd3fc1))
			{
				result = this.c62eddc2978dfd76cb081363610dd3fc1.ToList<Abilities>();
			}
			return result;
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000AD250 File Offset: 0x000AB450
		internal List<Abilities> get_c05ebd1bb5f7a79e49cc11ffb772f8dea()
		{
			return this.c62eddc2978dfd76cb081363610dd3fc1;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000AD264 File Offset: 0x000AB464
		internal void set_c05ebd1bb5f7a79e49cc11ffb772f8dea(List<Abilities> list)
		{
			this.c62eddc2978dfd76cb081363610dd3fc1 = list;
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x000AD278 File Offset: 0x000AB478
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x000AD28C File Offset: 0x000AB48C
		public Creature obj
		{
			get;
			internal set;
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000AD2A0 File Offset: 0x000AB4A0
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x000AD2B4 File Offset: 0x000AB4B4
		internal uint uniqCharId
		{
			get;
			set;
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x000AD2C8 File Offset: 0x000AB4C8
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x000AD2DC File Offset: 0x000AB4DC
		public PartyRole partyRole
		{
			get;
			internal set;
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000AD2F0 File Offset: 0x000AB4F0
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x000AD304 File Offset: 0x000AB504
		public byte level
		{
			get;
			internal set;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000AD318 File Offset: 0x000AB518
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x000AD32C File Offset: 0x000AB52C
		internal uint objId
		{
			get;
			set;
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x000AD340 File Offset: 0x000AB540
		// (set) Token: 0x060012AD RID: 4781 RVA: 0x000AD354 File Offset: 0x000AB554
		public CharGender gender
		{
			get;
			internal set;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000AD368 File Offset: 0x000AB568
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x000AD37C File Offset: 0x000AB57C
		public CharRace race
		{
			get;
			internal set;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000AD390 File Offset: 0x000AB590
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x000AD3A4 File Offset: 0x000AB5A4
		public bool isOnline
		{
			get;
			internal set;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000AD3B8 File Offset: 0x000AB5B8
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x000AD3CC File Offset: 0x000AB5CC
		public string nick
		{
			get;
			internal set;
		}

		// Token: 0x04000DEF RID: 3567
		private int cd7cee882bd60db2c0a4cda86e342297a;

		// Token: 0x04000DF0 RID: 3568
		private int c8fc44a233a165e0aa988e0760ad57421;

		// Token: 0x04000DF1 RID: 3569
		private int c8fdf9d80dcdeb301707f8ed540e7301d;

		// Token: 0x04000DF2 RID: 3570
		private int c6ff6bd5f5cd2baf214218b3e314f0544;

		// Token: 0x04000DF3 RID: 3571
		private double c8eb4555110e1a9211d6f4b73fb18c2cd;

		// Token: 0x04000DF4 RID: 3572
		private double c4c5de93b6101f484965cdf715301c901;

		// Token: 0x04000DF5 RID: 3573
		private double c05b0165bf8a9dca1eb67570794948c84;

		// Token: 0x04000DF6 RID: 3574
		private List<Abilities> c62eddc2978dfd76cb081363610dd3fc1;

		// Token: 0x04000DF7 RID: 3575
		[CompilerGenerated]
		private byte c08d46aca41e320956107ffe5c330565c;

		// Token: 0x04000DF8 RID: 3576
		[CompilerGenerated]
		private Creature ce913c2dfec58303831760e235a3546d4;

		// Token: 0x04000DF9 RID: 3577
		[CompilerGenerated]
		private uint c625a56d6474d5247c1b9f475f0d4b328;

		// Token: 0x04000DFA RID: 3578
		[CompilerGenerated]
		private PartyRole ca798b5ffee482e333ae42f2ba228af36;

		// Token: 0x04000DFB RID: 3579
		[CompilerGenerated]
		private byte cc4a38369e47d9089c8806b5b60567b5b;

		// Token: 0x04000DFC RID: 3580
		[CompilerGenerated]
		private uint c18f2deceeb1d83c10a27a7f6c996998c;

		// Token: 0x04000DFD RID: 3581
		[CompilerGenerated]
		private CharGender c1c23b482d095e7f28b3fae963929dda3;

		// Token: 0x04000DFE RID: 3582
		[CompilerGenerated]
		private CharRace c98a5aa19db7700c073d27ff9bf750914;

		// Token: 0x04000DFF RID: 3583
		[CompilerGenerated]
		private bool c75e3dd7d3b3bcb2661782e7158a2e144;

		// Token: 0x04000E00 RID: 3584
		[CompilerGenerated]
		private string c984aeaa5591c594312d32fce1c3fe920;
	}
}
