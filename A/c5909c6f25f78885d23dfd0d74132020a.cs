using System;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x02000CE0 RID: 3296
	internal sealed class c5909c6f25f78885d23dfd0d74132020a : MulticastDelegate
	{
		// Token: 0x06003A16 RID: 14870
		public extern c5909c6f25f78885d23dfd0d74132020a(object, IntPtr);

		// Token: 0x06003A17 RID: 14871 RVA: 0x0015A130 File Offset: 0x00158330
		static c5909c6f25f78885d23dfd0d74132020a()
		{
			cd5aa90fcd18d567023aad9e474c9d012.c28f89b549b0721b6db43243f02d3be65(33557728, 100671068, 16777215);
		}

		// Token: 0x06003A18 RID: 14872
		public virtual extern GpsPoint Invoke(uint id, double _x, double _y, double _z, double _radius = 0.0, string _name = "");

		// Token: 0x06003A19 RID: 14873 RVA: 0x0015A148 File Offset: 0x00158348
		public static GpsPoint c0cf59c3e67a46fd4edb3040c5ab0bbfb(uint id, double x, double y, double z, double radius = 0.0, string name = "")
		{
			return c5909c6f25f78885d23dfd0d74132020a.ce40437fe80b3e10ff2a821d820b80a37(id, x, y, z, radius, name);
		}

		// Token: 0x04001CB5 RID: 7349
		internal static readonly c5909c6f25f78885d23dfd0d74132020a ce40437fe80b3e10ff2a821d820b80a37;
	}
}
