using System;
using System.IO;
using System.Net.Security;

namespace A
{
	// Token: 0x02000F48 RID: 3912
	internal sealed class c76dddf1520614371110b313df8c1ced9 : MulticastDelegate
	{
		// Token: 0x060042E8 RID: 17128
		public extern c76dddf1520614371110b313df8c1ced9(object, IntPtr);

		// Token: 0x060042E9 RID: 17129 RVA: 0x0015F928 File Offset: 0x0015DB28
		static c76dddf1520614371110b313df8c1ced9()
		{
			cd5aa90fcd18d567023aad9e474c9d012.c28f89b549b0721b6db43243f02d3be65(33558344, 167773283, 16777215);
		}

		// Token: 0x060042EA RID: 17130
		public virtual extern SslStream Invoke(Stream, bool, RemoteCertificateValidationCallback, LocalCertificateSelectionCallback);

		// Token: 0x060042EB RID: 17131 RVA: 0x0015F940 File Offset: 0x0015DB40
		public static SslStream c0cf59c3e67a46fd4edb3040c5ab0bbfb(Stream stream, bool flag, RemoteCertificateValidationCallback remoteCertificateValidationCallback, LocalCertificateSelectionCallback localCertificateSelectionCallback)
		{
			return c76dddf1520614371110b313df8c1ced9.ce40437fe80b3e10ff2a821d820b80a37(stream, flag, remoteCertificateValidationCallback, localCertificateSelectionCallback);
		}

		// Token: 0x04001F17 RID: 7959
		internal static readonly c76dddf1520614371110b313df8c1ced9 ce40437fe80b3e10ff2a821d820b80a37;
	}
}
