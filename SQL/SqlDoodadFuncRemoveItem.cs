using System;
using System.Runtime.CompilerServices;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x0200009B RID: 155
	public class SqlDoodadFuncRemoveItem : MarshalProxy
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		internal SqlDoodadFuncRemoveItem()
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0002EA08 File Offset: 0x0002CC08
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0002EA1C File Offset: 0x0002CC1C
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0002EA30 File Offset: 0x0002CC30
		public SqlItem item
		{
			get;
			internal set;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0002EA44 File Offset: 0x0002CC44
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0002EA58 File Offset: 0x0002CC58
		public SqlSkill skill
		{
			get;
			internal set;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0002EA80 File Offset: 0x0002CC80
		public int count
		{
			get;
			internal set;
		}

		// Token: 0x0400021B RID: 539
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		private SqlItem c2cf978f090052177d0b89a4cbcb61685;

		// Token: 0x0400021D RID: 541
		[CompilerGenerated]
		private SqlSkill c52f70b53561b4aabff3b19e11226701c;

		// Token: 0x0400021E RID: 542
		[CompilerGenerated]
		private int c6621bffb628c518f8c4b4c8f86047ee4;
	}
}
