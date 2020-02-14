using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B0 RID: 176
	public class SqlCharacter : MarshalProxy
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x0002FD80 File Offset: 0x0002DF80
		internal SqlCharacter()
		{
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0002FD94 File Offset: 0x0002DF94
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0002FDA8 File Offset: 0x0002DFA8
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0002FDBC File Offset: 0x0002DFBC
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		public int raceId
		{
			get;
			internal set;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
		public int genderId
		{
			get;
			internal set;
		}

		// Token: 0x04000287 RID: 647
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000288 RID: 648
		[CompilerGenerated]
		private int c2e2bb10c311ded58dd9864597b4a2627;

		// Token: 0x04000289 RID: 649
		[CompilerGenerated]
		private int caa6e5eaf301d267592c37b48610db257;
	}
}
