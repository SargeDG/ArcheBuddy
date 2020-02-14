using System;
using System.Runtime.CompilerServices;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004BA RID: 1210
	public class ClanRole : MarshalProxy
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x000A3340 File Offset: 0x000A1540
		// (set) Token: 0x060011CA RID: 4554 RVA: 0x000A3354 File Offset: 0x000A1554
		public byte id
		{
			get;
			internal set;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x000A3368 File Offset: 0x000A1568
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x000A337C File Offset: 0x000A157C
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x000A3390 File Offset: 0x000A1590
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x000A33A4 File Offset: 0x000A15A4
		public bool dominionDeclare
		{
			get;
			internal set;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x000A33B8 File Offset: 0x000A15B8
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x000A33CC File Offset: 0x000A15CC
		public bool invite
		{
			get;
			internal set;
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000A33E0 File Offset: 0x000A15E0
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x000A33F4 File Offset: 0x000A15F4
		public bool promote
		{
			get;
			internal set;
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000A3408 File Offset: 0x000A1608
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x000A341C File Offset: 0x000A161C
		public bool expel
		{
			get;
			internal set;
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000A3430 File Offset: 0x000A1630
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x000A3444 File Offset: 0x000A1644
		public bool dismiss
		{
			get;
			internal set;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x000A3458 File Offset: 0x000A1658
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x000A346C File Offset: 0x000A166C
		public bool chat
		{
			get;
			internal set;
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000A3480 File Offset: 0x000A1680
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x000A3494 File Offset: 0x000A1694
		public bool managerChat
		{
			get;
			internal set;
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x000A34A8 File Offset: 0x000A16A8
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x000A34BC File Offset: 0x000A16BC
		public bool siegeMaster
		{
			get;
			internal set;
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x000A34D0 File Offset: 0x000A16D0
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x000A34E4 File Offset: 0x000A16E4
		public bool joinSiege
		{
			get;
			internal set;
		}

		// Token: 0x04000D95 RID: 3477
		[CompilerGenerated]
		private byte c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000D96 RID: 3478
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000D97 RID: 3479
		[CompilerGenerated]
		private bool c9124cfe93249ed55556b70e7e9fb810f;

		// Token: 0x04000D98 RID: 3480
		[CompilerGenerated]
		private bool cb90dad53e9a1edbfc06ab483a5391c06;

		// Token: 0x04000D99 RID: 3481
		[CompilerGenerated]
		private bool c4b01a8e6ad1a2e773f6c6e30ad9b7c71;

		// Token: 0x04000D9A RID: 3482
		[CompilerGenerated]
		private bool cdd9cc105333097af9df301adc45fe9bd;

		// Token: 0x04000D9B RID: 3483
		[CompilerGenerated]
		private bool c24b1c48f8144baf2142abd88694257af;

		// Token: 0x04000D9C RID: 3484
		[CompilerGenerated]
		private bool caf0bb74d52b9c9fa84706da69cf2751b;

		// Token: 0x04000D9D RID: 3485
		[CompilerGenerated]
		private bool c0ab54f32193d54d6ae8d6994a4c737e9;

		// Token: 0x04000D9E RID: 3486
		[CompilerGenerated]
		private bool c52360116f7d4d90a00946c2e164869f3;

		// Token: 0x04000D9F RID: 3487
		[CompilerGenerated]
		private bool c068cabff9180130e47999780fb393498;
	}
}
