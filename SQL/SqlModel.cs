using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000AB RID: 171
	public class SqlModel : MarshalProxy
	{
		// Token: 0x060003BF RID: 959 RVA: 0x0002F9A0 File Offset: 0x0002DBA0
		internal SqlModel()
		{
			cf9d06326e1b6a64ed7e93e5a129c3bbb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlModelAttachPointString>());
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0002F9C0 File Offset: 0x0002DBC0
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0002F9E8 File Offset: 0x0002DBE8
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x0002F9FC File Offset: 0x0002DBFC
		public SqlActorModel actorModel
		{
			get;
			internal set;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0002FA10 File Offset: 0x0002DC10
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x0002FA24 File Offset: 0x0002DC24
		public SqlVehicleModel vehicleModel
		{
			get;
			internal set;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0002FA38 File Offset: 0x0002DC38
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x0002FA4C File Offset: 0x0002DC4C
		public List<SqlModelAttachPointString> attachPoints
		{
			get;
			internal set;
		}

		// Token: 0x04000272 RID: 626
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000273 RID: 627
		[CompilerGenerated]
		private SqlActorModel cd04d6b394e977f6266253e7c60c65978;

		// Token: 0x04000274 RID: 628
		[CompilerGenerated]
		private SqlVehicleModel c331b1f2aa96ba5946172cccc5ba2c589;

		// Token: 0x04000275 RID: 629
		[CompilerGenerated]
		private List<SqlModelAttachPointString> c0b17c6227e57d856efb134a833bfd9ce;
	}
}
