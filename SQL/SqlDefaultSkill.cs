using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C7 RID: 199
	public class SqlDefaultSkill : MarshalProxy
	{
		// Token: 0x0600053F RID: 1343 RVA: 0x000319E4 File Offset: 0x0002FBE4
		internal SqlDefaultSkill()
		{
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x000319F8 File Offset: 0x0002FBF8
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00031A0C File Offset: 0x0002FC0C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00031A20 File Offset: 0x0002FC20
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00031A34 File Offset: 0x0002FC34
		public uint skillId
		{
			get;
			internal set;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00031A48 File Offset: 0x0002FC48
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00031A5C File Offset: 0x0002FC5C
		public int skillBookCategoryId
		{
			get;
			internal set;
		}

		// Token: 0x04000325 RID: 805
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000326 RID: 806
		[CompilerGenerated]
		private uint c3f815d54f78fd887f01f754f70c3882f;

		// Token: 0x04000327 RID: 807
		[CompilerGenerated]
		private int c5435a97d6f80154b0ba0b5d0165b5991;
	}
}
