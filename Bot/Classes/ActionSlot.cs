using System;
using System.Runtime.CompilerServices;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004D4 RID: 1236
	public class ActionSlot : BaseObject
	{
		// Token: 0x0600148E RID: 5262 RVA: 0x000B6908 File Offset: 0x000B4B08
		internal ActionSlot()
		{
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x000B691C File Offset: 0x000B4B1C
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x000B6930 File Offset: 0x000B4B30
		public uint slotId
		{
			get;
			internal set;
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x000B6944 File Offset: 0x000B4B44
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x000B6958 File Offset: 0x000B4B58
		public new ActionSlotType type
		{
			get;
			internal set;
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x000B696C File Offset: 0x000B4B6C
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x000B6980 File Offset: 0x000B4B80
		public ulong actionId
		{
			get;
			internal set;
		}

		// Token: 0x04000EDA RID: 3802
		[CompilerGenerated]
		private uint c5d14846241e764724b0745827fcbd7b3;

		// Token: 0x04000EDB RID: 3803
		[CompilerGenerated]
		private ActionSlotType c0425b2249a00a072c3294192bc80f538;

		// Token: 0x04000EDC RID: 3804
		[CompilerGenerated]
		private ulong c8f88a9c020f79535c705c559c9e0867b;
	}
}
