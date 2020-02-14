using System;
using System.Runtime.CompilerServices;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000557 RID: 1367
	public abstract class Zone : MarshalProxy
	{
		// Token: 0x06001E7D RID: 7805 RVA: 0x00133D24 File Offset: 0x00131F24
		internal Zone()
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00133D38 File Offset: 0x00131F38
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x00133D4C File Offset: 0x00131F4C
		public BotTypes type
		{
			get;
			internal set;
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x00133D60 File Offset: 0x00131F60
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x00133D74 File Offset: 0x00131F74
		public ZoneType zoneType
		{
			get;
			internal set;
		}

		// Token: 0x06001E82 RID: 7810
		public abstract bool PointInZone(double x, double y);

		// Token: 0x06001E83 RID: 7811
		public abstract bool ObjInZone(SpawnObject obj);

		// Token: 0x04001375 RID: 4981
		[CompilerGenerated]
		private BotTypes c0425b2249a00a072c3294192bc80f538;

		// Token: 0x04001376 RID: 4982
		[CompilerGenerated]
		private ZoneType c31974d2bd89d8ad7e0dd1fac0fdea4c8;
	}
}
