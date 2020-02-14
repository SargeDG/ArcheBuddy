using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A2 RID: 162
	public class SqlPlotEvent : MarshalProxy
	{
		// Token: 0x06000336 RID: 822 RVA: 0x0002EE4C File Offset: 0x0002D04C
		internal SqlPlotEvent()
		{
			c414391f82adc8fe4bbf75ddd79221b3a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSpecialEffect>());
			c0747568a47c2768cf900d25e8139ae83.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlPlotEvent>());
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0002EE78 File Offset: 0x0002D078
		// (set) Token: 0x06000338 RID: 824 RVA: 0x0002EE8C File Offset: 0x0002D08C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0002EEA0 File Offset: 0x0002D0A0
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		public uint plotId
		{
			get;
			internal set;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0002EEC8 File Offset: 0x0002D0C8
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		public List<SqlSpecialEffect> specialEffects
		{
			get;
			internal set;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0002EF04 File Offset: 0x0002D104
		public List<SqlPlotEvent> nextEvents
		{
			get;
			internal set;
		}

		// Token: 0x04000232 RID: 562
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000233 RID: 563
		[CompilerGenerated]
		private uint c6105729fe038171a43f0d79b5e835fc4;

		// Token: 0x04000234 RID: 564
		[CompilerGenerated]
		private List<SqlSpecialEffect> ce2d76e4a57b1d6bac22adace9a5a2119;

		// Token: 0x04000235 RID: 565
		[CompilerGenerated]
		private List<SqlPlotEvent> ce9d1774b63bceeff558424e5a418a757;
	}
}
