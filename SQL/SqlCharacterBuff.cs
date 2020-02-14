using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000B1 RID: 177
	public class SqlCharacterBuff : MarshalProxy
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x0002FE0C File Offset: 0x0002E00C
		internal SqlCharacterBuff()
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0002FE20 File Offset: 0x0002E020
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0002FE34 File Offset: 0x0002E034
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0002FE48 File Offset: 0x0002E048
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0002FE5C File Offset: 0x0002E05C
		public SqlCharacter character
		{
			get;
			internal set;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0002FE70 File Offset: 0x0002E070
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0002FE84 File Offset: 0x0002E084
		public int buffId
		{
			get;
			internal set;
		}

		// Token: 0x0400028A RID: 650
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400028B RID: 651
		[CompilerGenerated]
		private SqlCharacter ce1ceb39c0dafb8f0291a113fee0b2d6b;

		// Token: 0x0400028C RID: 652
		[CompilerGenerated]
		private int cf2769573844ae5774dc3b5cdece2565f;
	}
}
