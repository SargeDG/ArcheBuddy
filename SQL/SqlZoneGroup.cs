using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000CA RID: 202
	public class SqlZoneGroup : MarshalProxy
	{
		// Token: 0x06000596 RID: 1430 RVA: 0x00032114 File Offset: 0x00030314
		internal SqlZoneGroup()
		{
			cc6e16faf67be9b10d1faa8e240a6d5f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c4a4db68996217058c42f117fc498b88e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, "");
			c62e405c975ef3a92bad14c43fd465b41.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10192));
			c989c1829db91c653652558f87f1f9fde.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new List<SqlSpecialty>());
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00032158 File Offset: 0x00030358
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x0003216C File Offset: 0x0003036C
		public uint id
		{
			get;
			internal set;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00032180 File Offset: 0x00030380
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00032194 File Offset: 0x00030394
		public string name
		{
			get;
			internal set;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x000321A8 File Offset: 0x000303A8
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x000321BC File Offset: 0x000303BC
		public string displayText
		{
			get;
			internal set;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x000321D0 File Offset: 0x000303D0
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x000321E4 File Offset: 0x000303E4
		public double x
		{
			get;
			internal set;
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x000321F8 File Offset: 0x000303F8
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0003220C File Offset: 0x0003040C
		public double y
		{
			get;
			internal set;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00032220 File Offset: 0x00030420
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00032234 File Offset: 0x00030434
		public double w
		{
			get;
			internal set;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00032248 File Offset: 0x00030448
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0003225C File Offset: 0x0003045C
		public double h
		{
			get;
			internal set;
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00032270 File Offset: 0x00030470
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00032284 File Offset: 0x00030484
		public int targetId
		{
			get;
			internal set;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00032298 File Offset: 0x00030498
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000322AC File Offset: 0x000304AC
		public bool isPvpEnabled
		{
			get;
			internal set;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000322C0 File Offset: 0x000304C0
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x000322D4 File Offset: 0x000304D4
		public uint climateId
		{
			get;
			internal set;
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000322E8 File Offset: 0x000304E8
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x000322FC File Offset: 0x000304FC
		public List<SqlSpecialty> specialties
		{
			get;
			internal set;
		}

		// Token: 0x0400034F RID: 847
		[CompilerGenerated]
		private uint c06eb51b0ecfb8a5ac17ac0b2b12fc031;

		// Token: 0x04000350 RID: 848
		[CompilerGenerated]
		private string ccb8e68e2ab5b7cecddd5b20660d6735b;

		// Token: 0x04000351 RID: 849
		[CompilerGenerated]
		private string c151cbb3ed29bf330d4147e58a2986fe7;

		// Token: 0x04000352 RID: 850
		[CompilerGenerated]
		private double ca7fad13c316e809c89069ffdb5ba59d8;

		// Token: 0x04000353 RID: 851
		[CompilerGenerated]
		private double c9cdc89109d0276c13fa87317f2c2f379;

		// Token: 0x04000354 RID: 852
		[CompilerGenerated]
		private double ced33fa7d10b04a4fa20ed51326ea0783;

		// Token: 0x04000355 RID: 853
		[CompilerGenerated]
		private double cfe3f1c12c46b9b6b42dffec9ccc79506;

		// Token: 0x04000356 RID: 854
		[CompilerGenerated]
		private int cfc170bf94ffc7e0cbeb51b3c96d31b0d;

		// Token: 0x04000357 RID: 855
		[CompilerGenerated]
		private bool cf4d5f87cf68561b5d0f500674c4d9d0a;

		// Token: 0x04000358 RID: 856
		[CompilerGenerated]
		private uint cf418d570901059896ba420b85f665b8b;

		// Token: 0x04000359 RID: 857
		[CompilerGenerated]
		private List<SqlSpecialty> cae109a668f3a633f55bfa17aa17fd666;
	}
}
