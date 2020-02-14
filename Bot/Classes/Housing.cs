using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004CC RID: 1228
	public class Housing : Creature
	{
		// Token: 0x060013E4 RID: 5092 RVA: 0x000B4540 File Offset: 0x000B2740
		internal Housing(CoreInternal coreInternal) : base(coreInternal)
		{
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47332));
			c9690ab6fc12df62bc3e4f5764cd93b08.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ce5966072808127e61e7ce33a59ba515c.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47336)));
			c882f82b73a381fc14c5a9214c6ccd6b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ce5966072808127e61e7ce33a59ba515c.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47340)));
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x000B459C File Offset: 0x000B279C
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
						RuntimeMethodHandle arg_1A_0 = methodof(Housing.Dispose(bool)).MethodHandle;
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
						c4857f4440dc6faacfec268c6676f0982.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c2bbb743413aa97c40712d9f03b5ecfa2.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c064406586f024f64cd7a842e6df41011.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000B4608 File Offset: 0x000B2808
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x000B461C File Offset: 0x000B281C
		public uint plantZoneId
		{
			get;
			internal set;
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x000B4630 File Offset: 0x000B2830
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x000B4644 File Offset: 0x000B2844
		public SqlHousing housingDb
		{
			get;
			internal set;
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x000B4658 File Offset: 0x000B2858
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x000B466C File Offset: 0x000B286C
		public uint uniqHousingId
		{
			get;
			internal set;
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x000B4680 File Offset: 0x000B2880
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x000B4694 File Offset: 0x000B2894
		public string ownerName
		{
			get;
			internal set;
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x000B46A8 File Offset: 0x000B28A8
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x000B46BC File Offset: 0x000B28BC
		public HouseAccess access
		{
			get;
			internal set;
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000B46D0 File Offset: 0x000B28D0
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x000B46E4 File Offset: 0x000B28E4
		public uint housingId
		{
			get;
			internal set;
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000B46F8 File Offset: 0x000B28F8
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x000B470C File Offset: 0x000B290C
		public uint dominionTaxRate
		{
			get;
			internal set;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x000B4720 File Offset: 0x000B2920
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x000B4734 File Offset: 0x000B2934
		public uint taxRate
		{
			get;
			internal set;
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000B4748 File Offset: 0x000B2948
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x000B475C File Offset: 0x000B295C
		public ulong taxPayedTime
		{
			get;
			internal set;
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000B4770 File Offset: 0x000B2970
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x000B4784 File Offset: 0x000B2984
		public byte weeksWithoutPay
		{
			get;
			internal set;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x000B4798 File Offset: 0x000B2998
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x000B47AC File Offset: 0x000B29AC
		public byte weeksPrepay
		{
			get;
			internal set;
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x000B47C0 File Offset: 0x000B29C0
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x000B47D4 File Offset: 0x000B29D4
		public bool isAlreadyPaid
		{
			get;
			internal set;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x000B47E8 File Offset: 0x000B29E8
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x000B47FC File Offset: 0x000B29FC
		internal bool[] windowsStatus
		{
			get;
			set;
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x000B4810 File Offset: 0x000B2A10
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x000B4824 File Offset: 0x000B2A24
		internal bool[] doorsStatus
		{
			get;
			set;
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x000B4838 File Offset: 0x000B2A38
		public bool UpdateTaxInfo()
		{
			if (c547e170e4233b6a69ca14a7ecac0885e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0(), this) > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(47292))
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
					RuntimeMethodHandle arg_35_0 = methodof(Housing.UpdateTaxInfo()).MethodHandle;
				}
				this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47300));
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47304) != 0;
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47308), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47312));
			this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(new ccc08696ed01dc93a7902f1fe71923b23(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, (ushort)c9c772137bafe8ff99dbd90ebc261f23c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47316) != 0);
			return this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47320), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47324));
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x000B4910 File Offset: 0x000B2B10
		internal void c2c783a7bc512844767ea9869d3169bbe()
		{
			c4857f4440dc6faacfec268c6676f0982.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c2c63853873279de86efda97c86edd08e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (cf61b867443806a03d336b9101acbfa64.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47328))
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
					RuntimeMethodHandle arg_36_0 = methodof(Housing.c2c783a7bc512844767ea9869d3169bbe()).MethodHandle;
				}
				try
				{
					if (c70c4cecf449a99317d56daab248a55d1.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cf61b867443806a03d336b9101acbfa64.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						c4857f4440dc6faacfec268c6676f0982.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c17c43bc0d3fbee21a6ef8c0de88b4544.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cf61b867443806a03d336b9101acbfa64.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}
		}

		// Token: 0x04000E81 RID: 3713
		[CompilerGenerated]
		private uint ccb43981feaf1240504ca49b88c6efddf;

		// Token: 0x04000E82 RID: 3714
		[CompilerGenerated]
		private SqlHousing ca5a0f9807ef72d6297de7c5ab7084bec;

		// Token: 0x04000E83 RID: 3715
		[CompilerGenerated]
		private uint cf18014bf1f28b3ea28c8af1c0191518f;

		// Token: 0x04000E84 RID: 3716
		[CompilerGenerated]
		private string ce9205d63ae9a120ae73cf16536879717;

		// Token: 0x04000E85 RID: 3717
		[CompilerGenerated]
		private HouseAccess c71c2dfd3121fd7aece308cc80ef05447;

		// Token: 0x04000E86 RID: 3718
		[CompilerGenerated]
		private uint cac66a8432179ccdc47f4a4fe7d7159aa;

		// Token: 0x04000E87 RID: 3719
		[CompilerGenerated]
		private uint c14a3f83119440b09799448febf7718c6;

		// Token: 0x04000E88 RID: 3720
		[CompilerGenerated]
		private uint cb1405e2b55b3c08eb3b1336ffbf0a86c;

		// Token: 0x04000E89 RID: 3721
		[CompilerGenerated]
		private ulong c2348002f7af6848be84deeb490d4f630;

		// Token: 0x04000E8A RID: 3722
		[CompilerGenerated]
		private byte c296f8bd94260d9eb403e7c8d869629d2;

		// Token: 0x04000E8B RID: 3723
		[CompilerGenerated]
		private byte c1518650466176077b45a38b77e081e65;

		// Token: 0x04000E8C RID: 3724
		[CompilerGenerated]
		private bool c0926a393c2ebc476089e17737b574453;

		// Token: 0x04000E8D RID: 3725
		[CompilerGenerated]
		private bool[] c296938697814ec95b46d9f896ac8075d;

		// Token: 0x04000E8E RID: 3726
		[CompilerGenerated]
		private bool[] c3206523c645cb74d36c53e784beda825;
	}
}
