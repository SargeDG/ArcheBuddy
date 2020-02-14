using System;
using ArcheBuddy.Bot.Classes;
using ArcheBuddy.SQL;

namespace A
{
	// Token: 0x02000CC6 RID: 3270
	internal sealed class c58406fbe44429c9e53d092923661637b : MulticastDelegate
	{
		// Token: 0x060039B3 RID: 14771
		public extern c58406fbe44429c9e53d092923661637b(object, IntPtr);

		// Token: 0x060039B4 RID: 14772 RVA: 0x00159D5C File Offset: 0x00157F5C
		static c58406fbe44429c9e53d092923661637b()
		{
			cd5aa90fcd18d567023aad9e474c9d012.c28f89b549b0721b6db43243f02d3be65(33557702, 100665067, 16777215);
		}

		// Token: 0x060039B5 RID: 14773
		public virtual extern SqlCore Invoke(string path, ClientVersion version);

		// Token: 0x060039B6 RID: 14774 RVA: 0x00159D74 File Offset: 0x00157F74
		public static SqlCore c0cf59c3e67a46fd4edb3040c5ab0bbfb(string path, ClientVersion version)
		{
			return c58406fbe44429c9e53d092923661637b.ce40437fe80b3e10ff2a821d820b80a37(path, version);
		}

		// Token: 0x04001C9C RID: 7324
		internal static readonly c58406fbe44429c9e53d092923661637b ce40437fe80b3e10ff2a821d820b80a37;
	}
}
