using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000A6 RID: 166
	public class SqlSkillModifier : MarshalProxy
	{
		// Token: 0x06000384 RID: 900 RVA: 0x0002F4E0 File Offset: 0x0002D6E0
		internal SqlSkillModifier()
		{
			c79e676e44bc917dd32bfe13b30b485df.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c29e9a39c203ba209c33971a36bcc28b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSkill>());
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0002F50C File Offset: 0x0002D70C
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0002F520 File Offset: 0x0002D720
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0002F534 File Offset: 0x0002D734
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0002F548 File Offset: 0x0002D748
		public uint ownerId
		{
			get;
			internal set;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0002F55C File Offset: 0x0002D75C
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0002F570 File Offset: 0x0002D770
		public string ownerType
		{
			get;
			internal set;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0002F584 File Offset: 0x0002D784
		// (set) Token: 0x0600038C RID: 908 RVA: 0x0002F598 File Offset: 0x0002D798
		public uint tagId
		{
			get;
			internal set;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0002F5AC File Offset: 0x0002D7AC
		// (set) Token: 0x0600038E RID: 910 RVA: 0x0002F5C0 File Offset: 0x0002D7C0
		public int skillAttributeId
		{
			get;
			internal set;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0002F5D4 File Offset: 0x0002D7D4
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0002F5E8 File Offset: 0x0002D7E8
		public int unitModifierTypeId
		{
			get;
			internal set;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0002F5FC File Offset: 0x0002D7FC
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0002F610 File Offset: 0x0002D810
		public int value
		{
			get;
			internal set;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0002F624 File Offset: 0x0002D824
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0002F638 File Offset: 0x0002D838
		public List<SqlSkill> skills
		{
			get;
			internal set;
		}

		// Token: 0x04000257 RID: 599
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000258 RID: 600
		[CompilerGenerated]
		private uint c1a7152412000d4e63a86ad02175a32e2;

		// Token: 0x04000259 RID: 601
		[CompilerGenerated]
		private string c521b4cc9003c3022f17c26528b3a2d86;

		// Token: 0x0400025A RID: 602
		[CompilerGenerated]
		private uint cb7bb4c155c11c6426e959d8f7e55549f;

		// Token: 0x0400025B RID: 603
		[CompilerGenerated]
		private int c6e541dbbd35c3755cf131af9aac5edc4;

		// Token: 0x0400025C RID: 604
		[CompilerGenerated]
		private int cbb4793fb5d1a1b5aa267174a8d2f87fc;

		// Token: 0x0400025D RID: 605
		[CompilerGenerated]
		private int c0b972c0a6fd42f9045235c08ef4ba754;

		// Token: 0x0400025E RID: 606
		[CompilerGenerated]
		private List<SqlSkill> cd75886f46b62363d48b37a46236e0b2d;
	}
}
