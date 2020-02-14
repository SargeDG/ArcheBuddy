using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000C6 RID: 198
	public class SqlSkillReagent : MarshalProxy
	{
		// Token: 0x06000536 RID: 1334 RVA: 0x00031930 File Offset: 0x0002FB30
		internal SqlSkillReagent()
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00031944 File Offset: 0x0002FB44
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00031958 File Offset: 0x0002FB58
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0003196C File Offset: 0x0002FB6C
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00031980 File Offset: 0x0002FB80
		public uint skillId
		{
			get;
			internal set;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00031994 File Offset: 0x0002FB94
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x000319A8 File Offset: 0x0002FBA8
		public uint itemId
		{
			get;
			internal set;
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x000319BC File Offset: 0x0002FBBC
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x000319D0 File Offset: 0x0002FBD0
		public int count
		{
			get;
			internal set;
		}

		// Token: 0x04000321 RID: 801
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000322 RID: 802
		[CompilerGenerated]
		private uint c3f815d54f78fd887f01f754f70c3882f;

		// Token: 0x04000323 RID: 803
		[CompilerGenerated]
		private uint cc1a89b11db2b53a33b1a3065e996fe11;

		// Token: 0x04000324 RID: 804
		[CompilerGenerated]
		private int c6621bffb628c518f8c4b4c8f86047ee4;
	}
}
