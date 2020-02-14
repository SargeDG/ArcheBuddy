using System;
using System.Net.Sockets;

namespace A
{
	// Token: 0x02000846 RID: 2118
	internal sealed class c1fbe82c39f286b6e6925fbd6e5b4f8fa : MulticastDelegate
	{
		// Token: 0x0600293F RID: 10559
		public extern c1fbe82c39f286b6e6925fbd6e5b4f8fa(object, IntPtr);

		// Token: 0x06002940 RID: 10560 RVA: 0x0014F940 File Offset: 0x0014DB40
		static c1fbe82c39f286b6e6925fbd6e5b4f8fa()
		{
			cb83df6c3c9db33fada2dab55c55b461a.c28f89b549b0721b6db43243f02d3be65(33556550, 167772487, 16777215);
		}

		// Token: 0x06002941 RID: 10561
		public virtual extern IAsyncResult Invoke(object, byte[], int, int, SocketFlags, AsyncCallback, object);

		// Token: 0x06002942 RID: 10562 RVA: 0x0014F958 File Offset: 0x0014DB58
		public static IAsyncResult c30767ddca1f9c207888833aea5b5fc61(object obj, byte[] array, int num, int num2, SocketFlags socketFlags, AsyncCallback asyncCallback, object obj2)
		{
			return c1fbe82c39f286b6e6925fbd6e5b4f8fa.c61a145840c11cac9e5ad251dc4c04c57(obj, array, num, num2, socketFlags, asyncCallback, obj2);
		}

		// Token: 0x04001845 RID: 6213
		protected internal static readonly c1fbe82c39f286b6e6925fbd6e5b4f8fa c61a145840c11cac9e5ad251dc4c04c57;
	}
}
