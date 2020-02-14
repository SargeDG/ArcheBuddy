using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

namespace A
{
	// Token: 0x0200056E RID: 1390
	internal sealed class c64ccaaf6d5a246ba67c5be36873f757f : Control
	{
		// Token: 0x06001F3D RID: 7997 RVA: 0x00141D58 File Offset: 0x0013FF58
		public c64ccaaf6d5a246ba67c5be36873f757f(string text)
		{
			this.c99cc8d41a90783cea4e7845c839dcc98();
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97432), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97436) != 0);
			this.c1fe92e2401f269fe36c670041bacd9cd = text;
			c2aec0161107408048d59eaaf47fee916.c30767ddca1f9c207888833aea5b5fc61(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97440) != 0);
			this.set_cc5d7fedafe18e8f1f28bec0e300f7579(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97444));
			c8207d980b519c6c591f1f569ec84a55e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.cfef110ad089c5181323f9fac66e059f8));
			c5e3e508c552725df2a17e7896ab055f2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c9e9a65aef0e15e22d8313419a097f508));
			cb1c098ec9d6709418039f720bd0378bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c6e5f5a3ab849010a5d8914b904da3508));
			cd25997f0a1375a46ae408c2a1098179f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.cd7bc5f1195000bfffacaaa3788fb9ea2));
			c44eab5d838175c2f6c60064402e4f2c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new EventHandler(this.cf5d09d175ae9caa043277d6851e378ce));
			this.cfcf963d78e4d86bc8e79dd99361e64d9 = new Bitmap(c82e483177d9e6cfcfa4bd296cd6b00e8.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c533670535977d3c71546a2f44c69dc2b = new Bitmap(c871df08e2f7d45be65ae8acb3b63e770.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c4e5844592b0b35991689bd0f8a6ae459 = new Bitmap(c4e657d59885050b439e26475600758fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c84eb6112236b155eff4a0e21fc42b362 = new Bitmap(c4c65620d42bc5510ba293b24e9a518b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c1af0a0109f24fc4232285bdabd4ab786 = new Bitmap(c5809b7665f9e976ee132fa6e8302d892.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cd5043de22790aa4537f61cd5a62358b4 = new Bitmap(cd5a16c6366c89c90d29cbfc91ae83b94.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c1cd825228b1f0218723c009a640edad6 = new Bitmap(c2a793087b7389212da82ae52ab80a69c.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c97ec6acf2f9ab3e9a6665575f8b225b6 = new Bitmap(c07deeb9ab3c12d901d4e3934e6250422.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c4047eeb422c75a6ff410ae209741eb08 = new Bitmap(cde49844a7dff6b1c32d0e41b4905203f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c9141d53110987177494db5918a5338cc = new Bitmap(c24c23ea6af7e5bc36b1a912335922985.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c5356bda49a73a9bc2b73886364a8bc65 = new Bitmap(cd6799fd1208116bc1912702f9f8ddb5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c0c93c1b7b14fed999a6526d5a2353b31 = new Bitmap(cb982429548cf749493894359fc2c0793.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c014ab7e4d6857ef94b6b0ad126103f36 = new Bitmap(cd8e1f8d342b99412aa5467f3f6b4816c.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c115f132aa6b3fe1ad0083092e3b8d6ee = new Bitmap(cbd3cf5e442894631fd9cc9a1278eb14f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c7ede301d656db38bd7608261a7c18fa0 = new Bitmap(c16e41dd48eda84c8f6a48199a646e617.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cb796363afbd74839ce7117d3c570d1bf = new Bitmap(c0ea82be697147aba39078a114c368ae4.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c2dee754ae18233cf038dd1eb1a74c903 = new TextureBrush(this.cfcf963d78e4d86bc8e79dd99361e64d9);
			cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(this.c2dee754ae18233cf038dd1eb1a74c903, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97448));
			this.ccce0fbdb10b71323d8673c4863ae9c14 = new TextureBrush(this.c5356bda49a73a9bc2b73886364a8bc65);
			cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(this.ccce0fbdb10b71323d8673c4863ae9c14, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97452));
			this.c24422c3bc97b46a7a34e1a896db72e90 = new TextureBrush(this.c0c93c1b7b14fed999a6526d5a2353b31);
			cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(this.c24422c3bc97b46a7a34e1a896db72e90, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97456));
			this.cacd2f81e71ba8edca38b5fb31c9eee33 = new Pen(ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.set_c052c778d5c09788ff94bdadaaba342a0(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97460));
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00141FF0 File Offset: 0x001401F0
		public void add_ce269e701b801878917c6d30d49303009(MethodInvoker methodInvoker)
		{
			MethodInvoker methodInvoker2 = this.ce269e701b801878917c6d30d49303009;
			MethodInvoker methodInvoker3;
			do
			{
				methodInvoker3 = methodInvoker2;
				MethodInvoker value = c075b71e7e7c407ae57110033e9a0cd9b.c9963fcf210a214a3206d6500f3b9397b(c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(methodInvoker3, methodInvoker));
				methodInvoker2 = Interlocked.CompareExchange<MethodInvoker>(ref this.ce269e701b801878917c6d30d49303009, value, methodInvoker3);
			}
			while (methodInvoker2 != methodInvoker3);
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
				RuntimeMethodHandle arg_40_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.add_ce269e701b801878917c6d30d49303009(MethodInvoker)).MethodHandle;
			}
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00142040 File Offset: 0x00140240
		public void remove_ce269e701b801878917c6d30d49303009(MethodInvoker methodInvoker)
		{
			MethodInvoker methodInvoker2 = this.ce269e701b801878917c6d30d49303009;
			MethodInvoker methodInvoker3;
			do
			{
				methodInvoker3 = methodInvoker2;
				MethodInvoker value = c075b71e7e7c407ae57110033e9a0cd9b.c9963fcf210a214a3206d6500f3b9397b(cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(methodInvoker3, methodInvoker));
				methodInvoker2 = Interlocked.CompareExchange<MethodInvoker>(ref this.ce269e701b801878917c6d30d49303009, value, methodInvoker3);
			}
			while (methodInvoker2 != methodInvoker3);
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
				RuntimeMethodHandle arg_40_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.remove_ce269e701b801878917c6d30d49303009(MethodInvoker)).MethodHandle;
			}
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00142090 File Offset: 0x00140290
		public int cb0ea22fa9694847af08141c1b333f28b()
		{
			return this.get_c052c778d5c09788ff94bdadaaba342a0() + this.c1443e6922feb4e27e650973ed5be25da;
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x001420AC File Offset: 0x001402AC
		public int get_c052c778d5c09788ff94bdadaaba342a0()
		{
			return this.c13e49bd9d0049b70055fbb1883648de0;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x001420C0 File Offset: 0x001402C0
		public void set_c052c778d5c09788ff94bdadaaba342a0(int num)
		{
			if (num > this.cc6ef55540754bd2aaa4ae65ab8c0644f - this.c1443e6922feb4e27e650973ed5be25da)
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
					RuntimeMethodHandle arg_22_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.set_c052c778d5c09788ff94bdadaaba342a0(int)).MethodHandle;
				}
				this.c13e49bd9d0049b70055fbb1883648de0 = this.cc6ef55540754bd2aaa4ae65ab8c0644f - this.c1443e6922feb4e27e650973ed5be25da;
				return;
			}
			if (num < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97028))
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
				this.c13e49bd9d0049b70055fbb1883648de0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97032);
				return;
			}
			this.c13e49bd9d0049b70055fbb1883648de0 = num;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00142134 File Offset: 0x00140334
		private int get_cc5d7fedafe18e8f1f28bec0e300f7579()
		{
			return this.c392c1b8a5a024b13d6ed58158993717c;
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00142148 File Offset: 0x00140348
		private void set_cc5d7fedafe18e8f1f28bec0e300f7579(int num)
		{
			if (num < this.c71240c50a87720723e6e7deadba9f2ff)
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
					RuntimeMethodHandle arg_1B_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.set_cc5d7fedafe18e8f1f28bec0e300f7579(int)).MethodHandle;
				}
				this.c392c1b8a5a024b13d6ed58158993717c = this.c71240c50a87720723e6e7deadba9f2ff;
				return;
			}
			if (num < this.ccb4685c4c2d6a26d4cc90c2207c674ad)
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
				this.c392c1b8a5a024b13d6ed58158993717c = this.ccb4685c4c2d6a26d4cc90c2207c674ad;
				return;
			}
			this.c392c1b8a5a024b13d6ed58158993717c = num;
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x001421A8 File Offset: 0x001403A8
		private void cf5d09d175ae9caa043277d6851e378ce(object obj, EventArgs eventArgs)
		{
			this.cf593693f1353bc7f6b0e4d974b086f33 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97036);
			this.c52b4addb4c00aaba35b0ad88a6a35369 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97040);
			this.cfc65457fc046da75a2169169e4fd38b2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97044);
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x001421EC File Offset: 0x001403EC
		private void cfef110ad089c5181323f9fac66e059f8(object obj, MouseEventArgs mouseEventArgs)
		{
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x001421FC File Offset: 0x001403FC
		private void c9e9a65aef0e15e22d8313419a097f508(object obj, MouseEventArgs mouseEventArgs)
		{
			Point point = c5555b05a5d4ad8f9133c01e1aa6689ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4d6f42b61df810e9853b38eb86ea7034.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			Rectangle rectangle;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97048), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			Rectangle rectangle2;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2, this.c05db6b42bd69501f1bac24cf8d7e5421, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97052), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			Rectangle rectangle3;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97056), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97060), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786));
			Rectangle rectangle4;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle4, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97064), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6));
			if (ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, point))
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
					RuntimeMethodHandle arg_11F_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.c9e9a65aef0e15e22d8313419a097f508(object, MouseEventArgs)).MethodHandle;
				}
				this.c4d3094e26296b1a1c0a18a40d0938adf = cd547a3bdcf58a0113d773ab1a4a625fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref point) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97068);
				this.c7eb1fd8854898eb840fb7ddb81b84647 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97072) != 0);
				this.cd127d93356c62aaa0eca4382c5c96449(this.c4d3094e26296b1a1c0a18a40d0938adf);
			}
			if (ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2, point))
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
				this.cf593693f1353bc7f6b0e4d974b086f33 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97076);
			}
			if (ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle3, point))
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
				this.c52b4addb4c00aaba35b0ad88a6a35369 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97080);
				this.set_c052c778d5c09788ff94bdadaaba342a0(this.get_c052c778d5c09788ff94bdadaaba342a0() - this.cfdead512c8936fb6ed37200c86c14734);
				if (this.ce269e701b801878917c6d30d49303009 != null)
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
					c101653520fc02810eeb04365e67876c2.c30767ddca1f9c207888833aea5b5fc61(this.ce269e701b801878917c6d30d49303009);
				}
			}
			if (ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle4, point))
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
				this.cfc65457fc046da75a2169169e4fd38b2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97084);
				this.set_c052c778d5c09788ff94bdadaaba342a0(this.get_c052c778d5c09788ff94bdadaaba342a0() + this.cfdead512c8936fb6ed37200c86c14734);
				if (this.ce269e701b801878917c6d30d49303009 != null)
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
					c101653520fc02810eeb04365e67876c2.c30767ddca1f9c207888833aea5b5fc61(this.ce269e701b801878917c6d30d49303009);
				}
			}
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0014244C File Offset: 0x0014064C
		private void c6e5f5a3ab849010a5d8914b904da3508(object obj, MouseEventArgs mouseEventArgs)
		{
			if (this.c7eb1fd8854898eb840fb7ddb81b84647)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.c6e5f5a3ab849010a5d8914b904da3508(object, MouseEventArgs)).MethodHandle;
				}
				this.cafb597304fe77de93821a8f8d8e62348 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97088) != 0);
			}
			if (this.cafb597304fe77de93821a8f8d8e62348)
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
				this.cd127d93356c62aaa0eca4382c5c96449(cc9cf5c2a7a84876f073b374e67926f6e.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97092));
			}
			Point point = c5555b05a5d4ad8f9133c01e1aa6689ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4d6f42b61df810e9853b38eb86ea7034.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			new Rectangle(ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97096), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			Rectangle rectangle;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, this.c05db6b42bd69501f1bac24cf8d7e5421, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97100), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			Rectangle rectangle2;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97104), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97108), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786));
			Rectangle rectangle3;
			c255911bb7e6564e4257c0187ff737b92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle3, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97112), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6));
			if (ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle, point))
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
				if (this.cf593693f1353bc7f6b0e4d974b086f33 == 0)
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
					this.cf593693f1353bc7f6b0e4d974b086f33 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97116);
					c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				}
			}
			else if (this.cf593693f1353bc7f6b0e4d974b086f33 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97120))
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
				this.cf593693f1353bc7f6b0e4d974b086f33 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97124);
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
			if (ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle2, point))
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
				if (this.c52b4addb4c00aaba35b0ad88a6a35369 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97128))
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
					this.c52b4addb4c00aaba35b0ad88a6a35369 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97132);
					c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				}
			}
			else if (this.c52b4addb4c00aaba35b0ad88a6a35369 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97136))
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
				this.c52b4addb4c00aaba35b0ad88a6a35369 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97140);
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
			if (ce81ea9f8b73c8753ea5525942cd35bbe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref rectangle3, point))
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
				if (this.cfc65457fc046da75a2169169e4fd38b2 != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97144))
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
					this.cfc65457fc046da75a2169169e4fd38b2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97148);
					c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
					return;
				}
			}
			else if (this.cfc65457fc046da75a2169169e4fd38b2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97152))
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
				this.cfc65457fc046da75a2169169e4fd38b2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97156);
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x00142728 File Offset: 0x00140928
		private void cd127d93356c62aaa0eca4382c5c96449(int num)
		{
			int num2 = c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - (ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			if (num > num2)
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
				if (!true)
				{
					RuntimeMethodHandle arg_3B_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.cd127d93356c62aaa0eca4382c5c96449(int)).MethodHandle;
				}
				num = num2;
			}
			if (num < this.c71240c50a87720723e6e7deadba9f2ff)
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
				num = this.c71240c50a87720723e6e7deadba9f2ff;
			}
			this.set_cc5d7fedafe18e8f1f28bec0e300f7579(num);
			this.set_c052c778d5c09788ff94bdadaaba342a0((int)c57ddb40ae7598044d0a3835e4ef27300.c0cf59c3e67a46fd4edb3040c5ab0bbfb((double)(this.cc6ef55540754bd2aaa4ae65ab8c0644f - this.c1443e6922feb4e27e650973ed5be25da) / (double)(num2 - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97160)) * (double)(this.get_cc5d7fedafe18e8f1f28bec0e300f7579() - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97164))));
			if (this.ce269e701b801878917c6d30d49303009 != null)
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
				c101653520fc02810eeb04365e67876c2.c30767ddca1f9c207888833aea5b5fc61(this.ce269e701b801878917c6d30d49303009);
			}
			ce2d69929f3b99bd181f5b02dd509914f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x00142820 File Offset: 0x00140A20
		private void cd7bc5f1195000bfffacaaa3788fb9ea2(object obj, MouseEventArgs mouseEventArgs)
		{
			this.c7eb1fd8854898eb840fb7ddb81b84647 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97168) != 0);
			this.cafb597304fe77de93821a8f8d8e62348 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97172) != 0);
			if (this.c52b4addb4c00aaba35b0ad88a6a35369 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97176))
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
					RuntimeMethodHandle arg_44_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.cd7bc5f1195000bfffacaaa3788fb9ea2(object, MouseEventArgs)).MethodHandle;
				}
				this.c52b4addb4c00aaba35b0ad88a6a35369 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97180);
			}
			if (this.cfc65457fc046da75a2169169e4fd38b2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97184))
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
				this.cfc65457fc046da75a2169169e4fd38b2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97188);
			}
			if (this.cf593693f1353bc7f6b0e4d974b086f33 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97192))
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
				this.cf593693f1353bc7f6b0e4d974b086f33 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97196);
			}
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x001428E0 File Offset: 0x00140AE0
		public void c7d627a773e463f8f27e1a72ddd221618(int num, int num2)
		{
			c92e960b5df0a96b818ce3d9e18456c1c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num);
			c8d11bd632485509323291cb481183b0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num2);
			this.c71240c50a87720723e6e7deadba9f2ff = ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97200);
			this.ccb4685c4c2d6a26d4cc90c2207c674ad = ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97204);
			int num3 = c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - (ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			this.c87f5b1bc90f1e0d1da1dd9f8e8263e14 = (num3 - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b)) / (this.cc6ef55540754bd2aaa4ae65ab8c0644f - this.c1443e6922feb4e27e650973ed5be25da);
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0014299C File Offset: 0x00140B9C
		protected override void OnPaint(PaintEventArgs e)
		{
			ca4101afdd490d4f1fc552889ce1f807a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
			int num = c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - (ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			this.c05db6b42bd69501f1bac24cf8d7e5421 = ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786) + (int)((double)(num - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786)) / (double)(this.cc6ef55540754bd2aaa4ae65ab8c0644f - this.c1443e6922feb4e27e650973ed5be25da) * (double)this.get_c052c778d5c09788ff94bdadaaba342a0());
			c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(this.c2dee754ae18233cf038dd1eb1a74c903, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(97208), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(97212));
			c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c2dee754ae18233cf038dd1eb1a74c903, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97216), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97220), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c014ab7e4d6857ef94b6b0ad126103f36, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97224), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97228), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36));
			c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(this.ccce0fbdb10b71323d8673c4863ae9c14, (float)ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(97232));
			c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.ccce0fbdb10b71323d8673c4863ae9c14, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97236), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c5356bda49a73a9bc2b73886364a8bc65));
			c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(this.c24422c3bc97b46a7a34e1a896db72e90, (float)ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(97240));
			c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c24422c3bc97b46a7a34e1a896db72e90, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97244), this.c05db6b42bd69501f1bac24cf8d7e5421, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c0c93c1b7b14fed999a6526d5a2353b31));
			c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c7ede301d656db38bd7608261a7c18fa0, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97248), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0));
			cf59ab6facb97c8f8e7c575d492fabed6.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), (InterpolationMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97252));
			if (this.c52b4addb4c00aaba35b0ad88a6a35369 == 0)
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
				if (!true)
				{
					RuntimeMethodHandle arg_265_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.OnPaint(PaintEventArgs)).MethodHandle;
				}
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c1af0a0109f24fc4232285bdabd4ab786, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97256), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97260), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786));
			}
			else if (this.c52b4addb4c00aaba35b0ad88a6a35369 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97264))
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cd5043de22790aa4537f61cd5a62358b4, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97268), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97272), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786));
			}
			else if (this.c52b4addb4c00aaba35b0ad88a6a35369 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97276))
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c1cd825228b1f0218723c009a640edad6, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97280), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97284), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c1af0a0109f24fc4232285bdabd4ab786));
			}
			if (this.cfc65457fc046da75a2169169e4fd38b2 == 0)
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c97ec6acf2f9ab3e9a6665575f8b225b6, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97288), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6));
			}
			else if (this.cfc65457fc046da75a2169169e4fd38b2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97292))
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c4047eeb422c75a6ff410ae209741eb08, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97296), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6));
			}
			else if (this.cfc65457fc046da75a2169169e4fd38b2 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97300))
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c9141d53110987177494db5918a5338cc, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97304), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c97ec6acf2f9ab3e9a6665575f8b225b6));
			}
			if (this.cf593693f1353bc7f6b0e4d974b086f33 == 0)
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c533670535977d3c71546a2f44c69dc2b, this.c05db6b42bd69501f1bac24cf8d7e5421, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97308), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			}
			else if (this.cf593693f1353bc7f6b0e4d974b086f33 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97312))
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c4e5844592b0b35991689bd0f8a6ae459, this.c05db6b42bd69501f1bac24cf8d7e5421, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97316), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			}
			else if (this.cf593693f1353bc7f6b0e4d974b086f33 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97320))
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.c84eb6112236b155eff4a0e21fc42b362, this.c05db6b42bd69501f1bac24cf8d7e5421, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97324), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c533670535977d3c71546a2f44c69dc2b));
			}
			ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.cacd2f81e71ba8edca38b5fb31c9eee33, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97328), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97332), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97336), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97340)));
			c16ba3b2db1c61b11e1a66a7be3e7e54a.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cacd2f81e71ba8edca38b5fb31c9eee33, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97344), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97348), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97352), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97356));
			ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.cacd2f81e71ba8edca38b5fb31c9eee33, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97360), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97364), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97368), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97372)));
			c16ba3b2db1c61b11e1a66a7be3e7e54a.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cacd2f81e71ba8edca38b5fb31c9eee33, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97376), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97380), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97384), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97388));
			ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.cacd2f81e71ba8edca38b5fb31c9eee33, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97392), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97396), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97400), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97404)));
			c16ba3b2db1c61b11e1a66a7be3e7e54a.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cacd2f81e71ba8edca38b5fb31c9eee33, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97408), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97412), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97416));
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x001430F8 File Offset: 0x001412F8
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
				if (!true)
				{
					RuntimeMethodHandle arg_15_0 = methodof(c64ccaaf6d5a246ba67c5be36873f757f.Dispose(bool)).MethodHandle;
				}
				if (this.ce3753db2789ff7c885165e389c0b762f != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(this.ce3753db2789ff7c885165e389c0b762f);
				}
			}
			cfbd1b5a3b0323d7f7d188827fde43ffc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00143140 File Offset: 0x00141340
		private void c99cc8d41a90783cea4e7845c839dcc98()
		{
			this.ce3753db2789ff7c885165e389c0b762f = ce5d9f7cdcdd93dceb594ff3b777c5df3.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x04001498 RID: 5272
		private Bitmap cfcf963d78e4d86bc8e79dd99361e64d9;

		// Token: 0x04001499 RID: 5273
		private Bitmap c1af0a0109f24fc4232285bdabd4ab786;

		// Token: 0x0400149A RID: 5274
		private Bitmap cd5043de22790aa4537f61cd5a62358b4;

		// Token: 0x0400149B RID: 5275
		private Bitmap c1cd825228b1f0218723c009a640edad6;

		// Token: 0x0400149C RID: 5276
		private Bitmap c97ec6acf2f9ab3e9a6665575f8b225b6;

		// Token: 0x0400149D RID: 5277
		private Bitmap c4047eeb422c75a6ff410ae209741eb08;

		// Token: 0x0400149E RID: 5278
		private Bitmap c9141d53110987177494db5918a5338cc;

		// Token: 0x0400149F RID: 5279
		private Bitmap c533670535977d3c71546a2f44c69dc2b;

		// Token: 0x040014A0 RID: 5280
		private Bitmap c4e5844592b0b35991689bd0f8a6ae459;

		// Token: 0x040014A1 RID: 5281
		private Bitmap c84eb6112236b155eff4a0e21fc42b362;

		// Token: 0x040014A2 RID: 5282
		private Bitmap c5356bda49a73a9bc2b73886364a8bc65;

		// Token: 0x040014A3 RID: 5283
		private Bitmap c0c93c1b7b14fed999a6526d5a2353b31;

		// Token: 0x040014A4 RID: 5284
		private Bitmap c014ab7e4d6857ef94b6b0ad126103f36;

		// Token: 0x040014A5 RID: 5285
		private Bitmap c115f132aa6b3fe1ad0083092e3b8d6ee;

		// Token: 0x040014A6 RID: 5286
		private Bitmap c7ede301d656db38bd7608261a7c18fa0;

		// Token: 0x040014A7 RID: 5287
		private Bitmap cb796363afbd74839ce7117d3c570d1bf;

		// Token: 0x040014A8 RID: 5288
		private int c52b4addb4c00aaba35b0ad88a6a35369;

		// Token: 0x040014A9 RID: 5289
		private int cfc65457fc046da75a2169169e4fd38b2;

		// Token: 0x040014AA RID: 5290
		private int cf593693f1353bc7f6b0e4d974b086f33;

		// Token: 0x040014AB RID: 5291
		private int c05db6b42bd69501f1bac24cf8d7e5421;

		// Token: 0x040014AC RID: 5292
		private int cc6ef55540754bd2aaa4ae65ab8c0644f = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97420);

		// Token: 0x040014AD RID: 5293
		private int c1443e6922feb4e27e650973ed5be25da = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97424);

		// Token: 0x040014AE RID: 5294
		private int cfdead512c8936fb6ed37200c86c14734 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97428);

		// Token: 0x040014AF RID: 5295
		private int c13e49bd9d0049b70055fbb1883648de0;

		// Token: 0x040014B0 RID: 5296
		private string c1fe92e2401f269fe36c670041bacd9cd;

		// Token: 0x040014B1 RID: 5297
		private MethodInvoker ce269e701b801878917c6d30d49303009;

		// Token: 0x040014B2 RID: 5298
		private TextureBrush c2dee754ae18233cf038dd1eb1a74c903;

		// Token: 0x040014B3 RID: 5299
		private TextureBrush ccce0fbdb10b71323d8673c4863ae9c14;

		// Token: 0x040014B4 RID: 5300
		private TextureBrush c24422c3bc97b46a7a34e1a896db72e90;

		// Token: 0x040014B5 RID: 5301
		private Pen cacd2f81e71ba8edca38b5fb31c9eee33;

		// Token: 0x040014B6 RID: 5302
		private bool c7eb1fd8854898eb840fb7ddb81b84647;

		// Token: 0x040014B7 RID: 5303
		private bool cafb597304fe77de93821a8f8d8e62348;

		// Token: 0x040014B8 RID: 5304
		private int c4d3094e26296b1a1c0a18a40d0938adf;

		// Token: 0x040014B9 RID: 5305
		private int c392c1b8a5a024b13d6ed58158993717c;

		// Token: 0x040014BA RID: 5306
		private int c71240c50a87720723e6e7deadba9f2ff;

		// Token: 0x040014BB RID: 5307
		private int ccb4685c4c2d6a26d4cc90c2207c674ad;

		// Token: 0x040014BC RID: 5308
		private int c87f5b1bc90f1e0d1da1dd9f8e8263e14;

		// Token: 0x040014BD RID: 5309
		private IContainer ce3753db2789ff7c885165e389c0b762f;
	}
}
