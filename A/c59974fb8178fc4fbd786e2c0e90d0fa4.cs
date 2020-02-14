using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace A
{
	// Token: 0x020000EF RID: 239
	internal sealed class c59974fb8178fc4fbd786e2c0e90d0fa4
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x00046E38 File Offset: 0x00045038
		public static bool get_c37706c4c526d71876cbc416d1bd1eb64()
		{
			if (!c4bd5e52092e27938728b1d4fe3316f39.c0cf59c3e67a46fd4edb3040c5ab0bbfb((Key)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15636)))
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_25_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.get_c37706c4c526d71876cbc416d1bd1eb64()).MethodHandle;
				}
				return c4bd5e52092e27938728b1d4fe3316f39.c0cf59c3e67a46fd4edb3040c5ab0bbfb((Key)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15640));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15644) != 0;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00046E88 File Offset: 0x00045088
		public static bool get_ca6e1477730cceaa4c5486192ebb29fc7()
		{
			if (!c4bd5e52092e27938728b1d4fe3316f39.c0cf59c3e67a46fd4edb3040c5ab0bbfb((Key)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15648)))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_25_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.get_ca6e1477730cceaa4c5486192ebb29fc7()).MethodHandle;
				}
				return c4bd5e52092e27938728b1d4fe3316f39.c0cf59c3e67a46fd4edb3040c5ab0bbfb((Key)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15652));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15656) != 0;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00046ED8 File Offset: 0x000450D8
		public static bool get_cdc9904f96f136a56cf038331c4f139e0()
		{
			if (!c4bd5e52092e27938728b1d4fe3316f39.c0cf59c3e67a46fd4edb3040c5ab0bbfb((Key)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15660)))
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_25_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.get_cdc9904f96f136a56cf038331c4f139e0()).MethodHandle;
				}
				return c4bd5e52092e27938728b1d4fe3316f39.c0cf59c3e67a46fd4edb3040c5ab0bbfb((Key)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15664));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15668) != 0;
		}

		// Token: 0x06000820 RID: 2080
		[DllImport("user32.dll", EntryPoint = "ToUnicode")]
		public static extern int c6dbc2b6b0d4fa81c69e6b07258b7f98b(uint, uint, byte[], [MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder, int, uint);

		// Token: 0x06000821 RID: 2081
		[DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
		public static extern bool cc74be4f3b9302aec578cc41e981cf267(byte[]);

		// Token: 0x06000822 RID: 2082
		[DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
		public static extern uint c77ac31171313d7cf7e0b0d2964465e0c(uint, c59974fb8178fc4fbd786e2c0e90d0fa4.c6c2d90b915601924d8edaa57da6ab91a);

		// Token: 0x06000823 RID: 2083 RVA: 0x00046F28 File Offset: 0x00045128
		public static char c60b388e7bc820942b8c4061752d17f6a(Key key)
		{
			char result = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15672);
			int num = c6ea9bc2b4112e2191f3a4fbd7e5714e3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(key);
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15676));
			c59974fb8178fc4fbd786e2c0e90d0fa4.cc74be4f3b9302aec578cc41e981cf267(array);
			uint num2 = c59974fb8178fc4fbd786e2c0e90d0fa4.c77ac31171313d7cf7e0b0d2964465e0c((uint)num, (c59974fb8178fc4fbd786e2c0e90d0fa4.c6c2d90b915601924d8edaa57da6ab91a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15680));
			StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15684));
			switch (c59974fb8178fc4fbd786e2c0e90d0fa4.c6dbc2b6b0d4fa81c69e6b07258b7f98b((uint)num, num2, array, stringBuilder, c6e6474cdf720039785b8b4e32535f454.c30767ddca1f9c207888833aea5b5fc61(stringBuilder), (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15688)) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15692))
			{
			case 0:
			case 1:
				break;
			case 2:
				result = ca573391bcb721ce29d9937d4e433735f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15696));
				break;
			default:
				result = ca573391bcb721ce29d9937d4e433735f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15700));
				break;
			}
			return result;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00046FFC File Offset: 0x000451FC
		public bool c62c1b4e02a24ed37e7272700b8711cba(Keys keys)
		{
			if (c53c5cda7bd68f765baa8599a9977e3ee.c30767ddca1f9c207888833aea5b5fc61(this.cfaf58989e80b6273e3f44b1d674bcef8, keys))
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_22_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.c62c1b4e02a24ed37e7272700b8711cba(Keys)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15704) != 0;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15708) != 0;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00047044 File Offset: 0x00045244
		public void add_cf574af1a97a63e172416ebe997be3619(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f7048165815)
		{
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658152 = this.cf574af1a97a63e172416ebe997be3619;
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658153;
			do
			{
				c4791f5de9b5c3cb4ab591f70481658153 = c4791f5de9b5c3cb4ab591f70481658152;
				c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 value = (c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4791f5de9b5c3cb4ab591f70481658153, c4791f5de9b5c3cb4ab591f7048165815);
				c4791f5de9b5c3cb4ab591f70481658152 = Interlocked.CompareExchange<c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815>(ref this.cf574af1a97a63e172416ebe997be3619, value, c4791f5de9b5c3cb4ab591f70481658153);
			}
			while (c4791f5de9b5c3cb4ab591f70481658152 != c4791f5de9b5c3cb4ab591f70481658153);
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_3E_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.add_cf574af1a97a63e172416ebe997be3619(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)).MethodHandle;
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00047090 File Offset: 0x00045290
		public void remove_cf574af1a97a63e172416ebe997be3619(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f7048165815)
		{
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658152 = this.cf574af1a97a63e172416ebe997be3619;
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658153;
			do
			{
				c4791f5de9b5c3cb4ab591f70481658153 = c4791f5de9b5c3cb4ab591f70481658152;
				c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 value = (c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4791f5de9b5c3cb4ab591f70481658153, c4791f5de9b5c3cb4ab591f7048165815);
				c4791f5de9b5c3cb4ab591f70481658152 = Interlocked.CompareExchange<c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815>(ref this.cf574af1a97a63e172416ebe997be3619, value, c4791f5de9b5c3cb4ab591f70481658153);
			}
			while (c4791f5de9b5c3cb4ab591f70481658152 != c4791f5de9b5c3cb4ab591f70481658153);
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_3E_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.remove_cf574af1a97a63e172416ebe997be3619(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)).MethodHandle;
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000470DC File Offset: 0x000452DC
		public void add_c13258d99fb62aad043d021397994280b(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f7048165815)
		{
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658152 = this.c13258d99fb62aad043d021397994280b;
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658153;
			do
			{
				c4791f5de9b5c3cb4ab591f70481658153 = c4791f5de9b5c3cb4ab591f70481658152;
				c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 value = (c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4791f5de9b5c3cb4ab591f70481658153, c4791f5de9b5c3cb4ab591f7048165815);
				c4791f5de9b5c3cb4ab591f70481658152 = Interlocked.CompareExchange<c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815>(ref this.c13258d99fb62aad043d021397994280b, value, c4791f5de9b5c3cb4ab591f70481658153);
			}
			while (c4791f5de9b5c3cb4ab591f70481658152 != c4791f5de9b5c3cb4ab591f70481658153);
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_3E_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.add_c13258d99fb62aad043d021397994280b(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)).MethodHandle;
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00047128 File Offset: 0x00045328
		public void remove_c13258d99fb62aad043d021397994280b(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f7048165815)
		{
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658152 = this.c13258d99fb62aad043d021397994280b;
			c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c4791f5de9b5c3cb4ab591f70481658153;
			do
			{
				c4791f5de9b5c3cb4ab591f70481658153 = c4791f5de9b5c3cb4ab591f70481658152;
				c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 value = (c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4791f5de9b5c3cb4ab591f70481658153, c4791f5de9b5c3cb4ab591f7048165815);
				c4791f5de9b5c3cb4ab591f70481658152 = Interlocked.CompareExchange<c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815>(ref this.c13258d99fb62aad043d021397994280b, value, c4791f5de9b5c3cb4ab591f70481658153);
			}
			while (c4791f5de9b5c3cb4ab591f70481658152 != c4791f5de9b5c3cb4ab591f70481658153);
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_3E_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.remove_c13258d99fb62aad043d021397994280b(c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815)).MethodHandle;
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00047174 File Offset: 0x00045374
		public void add_c6517c7146f9e385538bacc86230b3a31(c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a c5edd2f5ee93f7a88eb7846ea7935884a)
		{
			c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a c5edd2f5ee93f7a88eb7846ea7935884a2 = this.c6517c7146f9e385538bacc86230b3a31;
			c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a c5edd2f5ee93f7a88eb7846ea7935884a3;
			do
			{
				c5edd2f5ee93f7a88eb7846ea7935884a3 = c5edd2f5ee93f7a88eb7846ea7935884a2;
				c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a value = (c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5edd2f5ee93f7a88eb7846ea7935884a3, c5edd2f5ee93f7a88eb7846ea7935884a);
				c5edd2f5ee93f7a88eb7846ea7935884a2 = Interlocked.CompareExchange<c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a>(ref this.c6517c7146f9e385538bacc86230b3a31, value, c5edd2f5ee93f7a88eb7846ea7935884a3);
			}
			while (c5edd2f5ee93f7a88eb7846ea7935884a2 != c5edd2f5ee93f7a88eb7846ea7935884a3);
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_3E_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.add_c6517c7146f9e385538bacc86230b3a31(c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a)).MethodHandle;
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000471C0 File Offset: 0x000453C0
		public void remove_c6517c7146f9e385538bacc86230b3a31(c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a c5edd2f5ee93f7a88eb7846ea7935884a)
		{
			c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a c5edd2f5ee93f7a88eb7846ea7935884a2 = this.c6517c7146f9e385538bacc86230b3a31;
			c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a c5edd2f5ee93f7a88eb7846ea7935884a3;
			do
			{
				c5edd2f5ee93f7a88eb7846ea7935884a3 = c5edd2f5ee93f7a88eb7846ea7935884a2;
				c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a value = (c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c5edd2f5ee93f7a88eb7846ea7935884a3, c5edd2f5ee93f7a88eb7846ea7935884a);
				c5edd2f5ee93f7a88eb7846ea7935884a2 = Interlocked.CompareExchange<c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a>(ref this.c6517c7146f9e385538bacc86230b3a31, value, c5edd2f5ee93f7a88eb7846ea7935884a3);
			}
			while (c5edd2f5ee93f7a88eb7846ea7935884a2 != c5edd2f5ee93f7a88eb7846ea7935884a3);
			while (true)
			{
				switch (2)
				{
				case 0:
					continue;
				}
				break;
			}
			if (!true)
			{
				RuntimeMethodHandle arg_3E_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.remove_c6517c7146f9e385538bacc86230b3a31(c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a)).MethodHandle;
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0004720C File Offset: 0x0004540C
		public List<Keys> get_ccb71757d6459439d508c12a6a3c20a2e()
		{
			return this.cfaf58989e80b6273e3f44b1d674bcef8;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00047220 File Offset: 0x00045420
		public IntPtr c5427b044874e4b966aaec0e1ddf55d8b(int num, IntPtr intPtr, IntPtr intPtr2)
		{
			if (num < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15712))
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_1F_0 = methodof(c59974fb8178fc4fbd786e2c0e90d0fa4.c5427b044874e4b966aaec0e1ddf55d8b(int, IntPtr, IntPtr)).MethodHandle;
				}
				return cec4dc845e772c3e699a057c528837cac.cb8ac0bf3b4657af93b7cd909a729d72d(this.c27111b8fff6ee72e81832b75dca528f1, num, intPtr, intPtr2);
			}
			int num2 = c738bb4579e2816c3e4d3e8912b9c3fec.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr2);
			if (!c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c103599bc1ed361be6bf503d1dd101d6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15716))))
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c103599bc1ed361be6bf503d1dd101d6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15720))))
				{
					goto IL_F0;
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			if (!c53c5cda7bd68f765baa8599a9977e3ee.c30767ddca1f9c207888833aea5b5fc61(this.cfaf58989e80b6273e3f44b1d674bcef8, (Keys)num2))
			{
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (this.cf574af1a97a63e172416ebe997be3619 != null)
				{
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						break;
					}
					c50a8c4b7906995703256755851cd3002.c30767ddca1f9c207888833aea5b5fc61(this.cf574af1a97a63e172416ebe997be3619, (Keys)num2);
				}
				if (this.c6517c7146f9e385538bacc86230b3a31 != null)
				{
					while (true)
					{
						switch (5)
						{
						case 0:
							continue;
						}
						break;
					}
					c3198114d26b634edf807a3fe4755cd55.c30767ddca1f9c207888833aea5b5fc61(this.c6517c7146f9e385538bacc86230b3a31, (Keys)num2, (c59974fb8178fc4fbd786e2c0e90d0fa4.c0ab14e0534dc5a491e4f11a653cc9935)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15724));
				}
				c4f5b8a3fb898ace271f93f2e1b3f7825.c30767ddca1f9c207888833aea5b5fc61(this.cfaf58989e80b6273e3f44b1d674bcef8, (Keys)num2);
			}
			IL_F0:
			if (!c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c103599bc1ed361be6bf503d1dd101d6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15728))))
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!c29052e2bbd36de4ca2e739e5e8c12bbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(intPtr, c103599bc1ed361be6bf503d1dd101d6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15732))))
				{
					goto IL_18F;
				}
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			if (this.c13258d99fb62aad043d021397994280b != null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				c50a8c4b7906995703256755851cd3002.c30767ddca1f9c207888833aea5b5fc61(this.c13258d99fb62aad043d021397994280b, (Keys)num2);
			}
			if (this.c6517c7146f9e385538bacc86230b3a31 != null)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				c3198114d26b634edf807a3fe4755cd55.c30767ddca1f9c207888833aea5b5fc61(this.c6517c7146f9e385538bacc86230b3a31, (Keys)num2, (c59974fb8178fc4fbd786e2c0e90d0fa4.c0ab14e0534dc5a491e4f11a653cc9935)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15736));
			}
			c9bd257ece5c93f33f389ba2c68f3cc03.c30767ddca1f9c207888833aea5b5fc61(this.cfaf58989e80b6273e3f44b1d674bcef8, (Keys)num2);
			IL_18F:
			return cec4dc845e772c3e699a057c528837cac.cb8ac0bf3b4657af93b7cd909a729d72d(this.c27111b8fff6ee72e81832b75dca528f1, num, intPtr, intPtr2);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000473CC File Offset: 0x000455CC
		public void c6d094dd62646f3d83f8d9b51b8ca99ea()
		{
			this.ca0ca3d4ac257ef03d7e9671a6296abc1 = new cec4dc845e772c3e699a057c528837cac.c252f4b4af21193be44ea005e6b67b1a8(this.c5427b044874e4b966aaec0e1ddf55d8b);
			this.c27111b8fff6ee72e81832b75dca528f1 = cec4dc845e772c3e699a057c528837cac.cea9bfd938a0dd33c107df14ede1ba4fa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15740), this.ca0ca3d4ac257ef03d7e9671a6296abc1, cec4dc845e772c3e699a057c528837cac.ca0fdf3f1c9a3b0e34c11be6535d9db84(IntPtr.Zero), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15744));
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00047420 File Offset: 0x00045620
		public void c212ef59b7bb80a34914095ee6a91b9d1()
		{
			cec4dc845e772c3e699a057c528837cac.c824b67144e1dffbe41d0c6982a68cf7d(this.c27111b8fff6ee72e81832b75dca528f1);
		}

		// Token: 0x04000450 RID: 1104
		private IntPtr c27111b8fff6ee72e81832b75dca528f1;

		// Token: 0x04000451 RID: 1105
		private cec4dc845e772c3e699a057c528837cac.c252f4b4af21193be44ea005e6b67b1a8 ca0ca3d4ac257ef03d7e9671a6296abc1;

		// Token: 0x04000452 RID: 1106
		private c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 cf574af1a97a63e172416ebe997be3619;

		// Token: 0x04000453 RID: 1107
		private c59974fb8178fc4fbd786e2c0e90d0fa4.c4791f5de9b5c3cb4ab591f7048165815 c13258d99fb62aad043d021397994280b;

		// Token: 0x04000454 RID: 1108
		private c59974fb8178fc4fbd786e2c0e90d0fa4.c5edd2f5ee93f7a88eb7846ea7935884a c6517c7146f9e385538bacc86230b3a31;

		// Token: 0x04000455 RID: 1109
		private List<Keys> cfaf58989e80b6273e3f44b1d674bcef8 = new List<Keys>();

		// Token: 0x020000F0 RID: 240
		public enum c0ab14e0534dc5a491e4f11a653cc9935
		{
			// Token: 0x04000457 RID: 1111
			cf574af1a97a63e172416ebe997be3619,
			// Token: 0x04000458 RID: 1112
			c13258d99fb62aad043d021397994280b
		}

		// Token: 0x020000F1 RID: 241
		public enum c6c2d90b915601924d8edaa57da6ab91a : uint
		{
			// Token: 0x0400045A RID: 1114
			cd0116c5b9b45286844e6e3791fae8010,
			// Token: 0x0400045B RID: 1115
			c34c4514fe8586b10a07d8717becad97a,
			// Token: 0x0400045C RID: 1116
			c578e7cacc26284a3f5973c51a64e4755,
			// Token: 0x0400045D RID: 1117
			c2c47b6690acbcf113ced3fb9d5fe5d7f
		}

		// Token: 0x020000F2 RID: 242
		// (Invoke) Token: 0x06000830 RID: 2096
		public delegate void c4791f5de9b5c3cb4ab591f7048165815(Keys key);

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x06000834 RID: 2100
		public delegate void c5edd2f5ee93f7a88eb7846ea7935884a(Keys key, c59974fb8178fc4fbd786e2c0e90d0fa4.c0ab14e0534dc5a491e4f11a653cc9935 state);
	}
}
