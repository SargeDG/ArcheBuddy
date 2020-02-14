using System;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004C6 RID: 1222
	public class Quest : BaseObject
	{
		// Token: 0x060012CD RID: 4813 RVA: 0x000ADB00 File Offset: 0x000ABD00
		internal Quest(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44652));
			cfcfa90f8428fe031079a24daa37c0c45.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c5a37f4875ca7804ff197382920518c92.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44656)));
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000ADB44 File Offset: 0x000ABD44
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Quest.Dispose(bool)).MethodHandle;
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
						cf2486dcbb96fd90d5fc81fd07ff251fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c497348a63f93535efac4d8f83dee64ae.c8a754f5f2ca4adde825691a9c31a0e83);
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000ADBB0 File Offset: 0x000ABDB0
		internal void c4aaf7619a600d569451f27c0b2b78918()
		{
			cf2486dcbb96fd90d5fc81fd07ff251fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c760a532bbf5afd46b011700365795715.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			if (c6b48777b089f59ac5f05e2aef7a96a46.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44644))
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
					RuntimeMethodHandle arg_36_0 = methodof(Quest.c4aaf7619a600d569451f27c0b2b78918()).MethodHandle;
				}
				try
				{
					if (c27a39f0226ab6b49132f65c0d76d1cbd.c30767ddca1f9c207888833aea5b5fc61(c72b36d7f64bdf8d3728860bc21df275f.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c6b48777b089f59ac5f05e2aef7a96a46.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)))
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
						cf2486dcbb96fd90d5fc81fd07ff251fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c9ed96188c1e1a53107b3ff091ee4aeff.c30767ddca1f9c207888833aea5b5fc61(c72b36d7f64bdf8d3728860bc21df275f.c30767ddca1f9c207888833aea5b5fc61(c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c6b48777b089f59ac5f05e2aef7a96a46.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
					}
				}
				catch (Exception ex)
				{
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000ADC70 File Offset: 0x000ABE70
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x000ADC84 File Offset: 0x000ABE84
		public SqlQuestContext db
		{
			get;
			internal set;
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000ADC98 File Offset: 0x000ABE98
		// (set) Token: 0x060012D3 RID: 4819 RVA: 0x000ADCAC File Offset: 0x000ABEAC
		internal ulong uniqId
		{
			get;
			set;
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000ADCC0 File Offset: 0x000ABEC0
		public QuestType questType
		{
			get
			{
				if (c2a6a0f6d371e9f5ab3a4aa22f1ed9dd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Quest.get_questType()).MethodHandle;
					}
					return (QuestType)ce32743105968988840aed70f69944411.c30767ddca1f9c207888833aea5b5fc61(c2a6a0f6d371e9f5ab3a4aa22f1ed9dd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				}
				return (QuestType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(44648);
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000ADD04 File Offset: 0x000ABF04
		public string name
		{
			get
			{
				if (c2a6a0f6d371e9f5ab3a4aa22f1ed9dd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
						RuntimeMethodHandle arg_1C_0 = methodof(Quest.get_name()).MethodHandle;
					}
					return "";
				}
				return cf74746d102d1e0ab449d4271739770b1.c30767ddca1f9c207888833aea5b5fc61(c2a6a0f6d371e9f5ab3a4aa22f1ed9dd8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x000ADD44 File Offset: 0x000ABF44
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x000ADD58 File Offset: 0x000ABF58
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x000ADD6C File Offset: 0x000ABF6C
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x000ADD80 File Offset: 0x000ABF80
		public QuestStatus status
		{
			get;
			internal set;
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000ADD94 File Offset: 0x000ABF94
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x000ADDA8 File Offset: 0x000ABFA8
		public int[] steps
		{
			get;
			internal set;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x000ADDBC File Offset: 0x000ABFBC
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x000ADDD0 File Offset: 0x000ABFD0
		internal bool isCheckSet
		{
			get;
			set;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x000ADDE4 File Offset: 0x000ABFE4
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x000ADDF8 File Offset: 0x000ABFF8
		public int leftTime
		{
			get;
			internal set;
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000ADE0C File Offset: 0x000AC00C
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x000ADE20 File Offset: 0x000AC020
		public uint сomponentId
		{
			get;
			internal set;
		}

		// Token: 0x04000E0A RID: 3594
		[CompilerGenerated]
		private SqlQuestContext cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x04000E0B RID: 3595
		[CompilerGenerated]
		private ulong c1f042b599e757f7d30e4be9756bd3cb4;

		// Token: 0x04000E0C RID: 3596
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000E0D RID: 3597
		[CompilerGenerated]
		private QuestStatus c1bc4192eba7d21a2474bb06faea0632b;

		// Token: 0x04000E0E RID: 3598
		[CompilerGenerated]
		private int[] c566b8d98a0f40764bd586a4ba28c2c4d;

		// Token: 0x04000E0F RID: 3599
		[CompilerGenerated]
		private bool c84b699b5e08ea7d2df441d786566928d;

		// Token: 0x04000E10 RID: 3600
		[CompilerGenerated]
		private int c20a6ef2a4735dcd087822f88adc6a5c9;

		// Token: 0x04000E11 RID: 3601
		[CompilerGenerated]
		private uint cb9066dd095a15dcaf744227c77d137ac;
	}
}
