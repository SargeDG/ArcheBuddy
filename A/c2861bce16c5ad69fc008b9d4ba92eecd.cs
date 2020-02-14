using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x02000568 RID: 1384
	internal sealed class c2861bce16c5ad69fc008b9d4ba92eecd : PictureBox
	{
		// Token: 0x06001EEE RID: 7918 RVA: 0x0013C984 File Offset: 0x0013AB84
		public c2861bce16c5ad69fc008b9d4ba92eecd(string text, CoreInternal coreInternal, c6bdd46ef9f05485f6b69f34bf6920a88 c6bdd46ef9f05485f6b69f34bf6920a)
		{
			this.c99cc8d41a90783cea4e7845c839dcc98();
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95632), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95636) != 0);
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			this.c6c72c029a273123a083e76d610205020 = c6bdd46ef9f05485f6b69f34bf6920a;
			this.c1fe92e2401f269fe36c670041bacd9cd = text;
			this.cfe50bfa25649541afa0ea62ceaabc269 = new Bitmap(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95640));
			this.cfcf963d78e4d86bc8e79dd99361e64d9 = new Bitmap(cb506aeb6fd5b9989fac33975a6c3b24a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			c1e10b66cae27ebcd2ac6eb21885d5816.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new EventHandler(this.cdb40b777a1b3dd82519a74851240505d));
			c44eab5d838175c2f6c60064402e4f2c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new EventHandler(this.cd58f01985331195f8009f3d556154cdc));
			cb1c098ec9d6709418039f720bd0378bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c83642424d0556855503c89a4df437a56));
			c8207d980b519c6c591f1f569ec84a55e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c61d715ec70a21fe3d4d27c3473ee92cf));
			this.c65d04bd6bca9df7aa5403ab9407bcfcf = new List<c49a205a8d962eedc10d0ad1e8ae458d7.c01cf1002d5d02c191da9e03d18de4f93>();
			this.c32e86a607835575fdfc47e35a00ad4a0 = new Pen(ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cfa1355bd75c103e16c58052eddb4eaf9 = new Pen(ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c45a14f1aa9be42464930c00601df4571 = new SolidBrush(ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cf377420a5fad5d12a85b30a62bec6eaa = new SolidBrush(ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cfef4cd2de6c3aba8f69cca10c2c5bd08 = new SolidBrush(c41a9a23964757241c5bc59cb110cbff2.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cee0775c873bd023679e0dc4a6904cd59 = new SolidBrush(cf80a678ac92bf25fd94b3bfa616b527e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			c4de756e1b35c29fe7b9dfaec634643c3.c30767ddca1f9c207888833aea5b5fc61(this.cfef4cd2de6c3aba8f69cca10c2c5bd08, cc4987d6a853db77954f21abe4e42946a.cd3f37936749e1f97ba2302c000ed0a41(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95644), c876305bed405018c75885a926b9c523b.c30767ddca1f9c207888833aea5b5fc61(this.cfef4cd2de6c3aba8f69cca10c2c5bd08)));
			c4de756e1b35c29fe7b9dfaec634643c3.c30767ddca1f9c207888833aea5b5fc61(this.cee0775c873bd023679e0dc4a6904cd59, cc4987d6a853db77954f21abe4e42946a.cd3f37936749e1f97ba2302c000ed0a41(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95648), c876305bed405018c75885a926b9c523b.c30767ddca1f9c207888833aea5b5fc61(this.cee0775c873bd023679e0dc4a6904cd59)));
			this.c2dee754ae18233cf038dd1eb1a74c903 = new TextureBrush(this.cfcf963d78e4d86bc8e79dd99361e64d9);
			cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(this.c2dee754ae18233cf038dd1eb1a74c903, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95652));
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0013CB4C File Offset: 0x0013AD4C
		private int get_c7e07f8d0a0bd0b7c31b4dc1008312488()
		{
			return this.cb464a0c03d66f8a2be54167335a14b15;
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0013CB60 File Offset: 0x0013AD60
		private void set_c7e07f8d0a0bd0b7c31b4dc1008312488(int num)
		{
			if (num > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95296))
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
					RuntimeMethodHandle arg_1F_0 = methodof(c2861bce16c5ad69fc008b9d4ba92eecd.set_c7e07f8d0a0bd0b7c31b4dc1008312488(int)).MethodHandle;
				}
				this.cb464a0c03d66f8a2be54167335a14b15 = num;
				return;
			}
			this.cb464a0c03d66f8a2be54167335a14b15 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95300);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0013CBA8 File Offset: 0x0013ADA8
		private void c61d715ec70a21fe3d4d27c3473ee92cf(object obj, MouseEventArgs mouseEventArgs)
		{
			try
			{
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95304); i < c066741d6a6acc28aae6ec608852c18ed.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95308))
				{
					if (ca895d146b5bb9ded101bc0e6d9973e62.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf, i).ca2a418584ab037e91a69eed38f8fbc34 <= this.cf97a3a4af47c09e794d9f87473b3c207)
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
							RuntimeMethodHandle arg_40_0 = methodof(c2861bce16c5ad69fc008b9d4ba92eecd.c61d715ec70a21fe3d4d27c3473ee92cf(object, MouseEventArgs)).MethodHandle;
						}
						if (ca895d146b5bb9ded101bc0e6d9973e62.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf, i).c2fd9b81890a681af60edcd4d871aeaca >= this.cf97a3a4af47c09e794d9f87473b3c207)
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
							if (ca895d146b5bb9ded101bc0e6d9973e62.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf, i).cb2aca578c04d3a7d5f290c03b0fa72f9 <= this.c6ec35cf408882bb2d811448e8370e6eb)
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
								if (ca895d146b5bb9ded101bc0e6d9973e62.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf, i).c08da3373491724302570d635a0f22a90 >= this.c6ec35cf408882bb2d811448e8370e6eb)
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
									this.ca124a9f406cda69b904f2eb04d553ab9.c2a01ec29bd94e09a986cf5dea26b4cc9(ca895d146b5bb9ded101bc0e6d9973e62.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf, i).c9d0b81af0b4d9ec454b66f1b3d12988f);
									return;
								}
							}
						}
					}
				}
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x0013CCE4 File Offset: 0x0013AEE4
		private void c83642424d0556855503c89a4df437a56(object obj, MouseEventArgs mouseEventArgs)
		{
			if ((c2281e05e1e4df6800d999af50ddae88e.c0cf59c3e67a46fd4edb3040c5ab0bbfb() & (Keys)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95312)) != Keys.None)
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
					RuntimeMethodHandle arg_26_0 = methodof(c2861bce16c5ad69fc008b9d4ba92eecd.c83642424d0556855503c89a4df437a56(object, MouseEventArgs)).MethodHandle;
				}
				this.cc28cf04c56d7af637a88bf536fba0a56 += c45a096d3e1a00147ef841f0d197c79da.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs) - this.c6ec35cf408882bb2d811448e8370e6eb;
			}
			if (this.cc28cf04c56d7af637a88bf536fba0a56 > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95316))
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
				this.set_c7e07f8d0a0bd0b7c31b4dc1008312488(this.get_c7e07f8d0a0bd0b7c31b4dc1008312488() + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95320));
				this.cc28cf04c56d7af637a88bf536fba0a56 -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95324);
			}
			if (this.cc28cf04c56d7af637a88bf536fba0a56 < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95328))
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
				this.set_c7e07f8d0a0bd0b7c31b4dc1008312488(this.get_c7e07f8d0a0bd0b7c31b4dc1008312488() - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95332));
				this.cc28cf04c56d7af637a88bf536fba0a56 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95336);
			}
			this.cf97a3a4af47c09e794d9f87473b3c207 = cc9cf5c2a7a84876f073b374e67926f6e.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs);
			this.c6ec35cf408882bb2d811448e8370e6eb = c45a096d3e1a00147ef841f0d197c79da.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs);
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x0013CDE8 File Offset: 0x0013AFE8
		private void cd58f01985331195f8009f3d556154cdc(object obj, EventArgs eventArgs)
		{
			this.c5594670fef20cb29eccac8c1f04faf9f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95340) != 0);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x0013CE08 File Offset: 0x0013B008
		private void cdb40b777a1b3dd82519a74851240505d(object obj, EventArgs eventArgs)
		{
			this.c5594670fef20cb29eccac8c1f04faf9f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95344) != 0);
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x0013CE28 File Offset: 0x0013B028
		protected override void OnPaint(PaintEventArgs e)
		{
			cef56a9fede40546d087138fbc8ff851a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
			cddeefb9a4e967a5de56a10bc3d73ada7.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cfe50bfa25649541afa0ea62ceaabc269, Point.Empty);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0013CE54 File Offset: 0x0013B054
		public void c5e16a22ce552ea42587b7f00b68f813a()
		{
			if (this.cfe50bfa25649541afa0ea62ceaabc269 != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c2861bce16c5ad69fc008b9d4ba92eecd.c5e16a22ce552ea42587b7f00b68f813a()).MethodHandle;
				}
				c762855a9636b81dcb4ffe699b8e25cf6.c30767ddca1f9c207888833aea5b5fc61(this.cfe50bfa25649541afa0ea62ceaabc269);
			}
			this.cfe50bfa25649541afa0ea62ceaabc269 = cd95844e7d60a0b489c7b00a0c65c04de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95348));
			this.cb54c8f763e2d317b255ccf337530bbaf = c613052e8bee42d8583d5b4036f4d2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cfe50bfa25649541afa0ea62ceaabc269);
			c01754b2d6a3b058e32220a8f00201bb0.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (CompositingQuality)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95352));
			c6ed28ebb38d8ca3aaf3d48c8cf38fb72.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (PixelOffsetMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95356));
			c3c459109318902adc631375e1d797d04.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (SmoothingMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95360));
			cf59ab6facb97c8f8e7c575d492fabed6.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (InterpolationMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95364));
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x0013CF18 File Offset: 0x0013B118
		public void c17e5273089bd594a7b1bbc60fa832361()
		{
			cb4574e6b4047b9a82cc9b02bc0f33b6e.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf);
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x0013CF38 File Offset: 0x0013B138
		public void cf775278d656f9b5ea96f712328da8eb9()
		{
			c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(this.c2dee754ae18233cf038dd1eb1a74c903, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(95368), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(95372));
			c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c2dee754ae18233cf038dd1eb1a74c903, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95376), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95380), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			this.c19a39cbc57643a1f28ece1da96138d0b = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95384);
			this.c68aa75ac4412312061bdcd09510a25f8 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95388);
			this.c69c29600a4f201ec1f7d4b0986f71c68 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95392);
			this.c48f1d2a1be3b66b887007da62045b6f1 = (int)((double)ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) / (double)(c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95396)));
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c65d04bd6bca9df7aa5403ab9407bcfcf))
			{
				c18d49d085fb6cf862d998b2650630a06.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf);
			}
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x0013D038 File Offset: 0x0013B238
		public void c69a4717af9c85a10d23191eb2bdb02c0(int num)
		{
			this.c3968b2c6fa396939106a9ada179c9c96 = num;
			int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95400);
			if (this.c3968b2c6fa396939106a9ada179c9c96 > this.c48f1d2a1be3b66b887007da62045b6f1)
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
					RuntimeMethodHandle arg_32_0 = methodof(c2861bce16c5ad69fc008b9d4ba92eecd.c69a4717af9c85a10d23191eb2bdb02c0(int)).MethodHandle;
				}
				num2 = this.c3968b2c6fa396939106a9ada179c9c96 - this.c48f1d2a1be3b66b887007da62045b6f1;
			}
			if (this.get_c7e07f8d0a0bd0b7c31b4dc1008312488() > num2)
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
				this.set_c7e07f8d0a0bd0b7c31b4dc1008312488(num2);
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0013D0A4 File Offset: 0x0013B2A4
		public void cfa195f4dd59fd471e4e51d899d151dbe(SpawnObject spawnObject, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a)
		{
			this.c69c29600a4f201ec1f7d4b0986f71c68 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95404);
			if (this.get_c7e07f8d0a0bd0b7c31b4dc1008312488() >= this.c69c29600a4f201ec1f7d4b0986f71c68)
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
					RuntimeMethodHandle arg_39_0 = methodof(c2861bce16c5ad69fc008b9d4ba92eecd.cfa195f4dd59fd471e4e51d899d151dbe(SpawnObject, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073)).MethodHandle;
				}
				return;
			}
			if (this.c68aa75ac4412312061bdcd09510a25f8 >= this.c48f1d2a1be3b66b887007da62045b6f1)
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
				return;
			}
			int num = c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95408);
			int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95412) + this.c68aa75ac4412312061bdcd09510a25f8 * num;
			int num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95416);
			ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0, c341c057025cd8aff0e5f8e9a.cd4e00ad3d769e8634db871a069991a75);
			c4de756e1b35c29fe7b9dfaec634643c3.c30767ddca1f9c207888833aea5b5fc61(this.c45a14f1aa9be42464930c00601df4571, c341c057025cd8aff0e5f8e9a.cd4e00ad3d769e8634db871a069991a75);
			bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95420) != 0;
			if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(spawnObject) != (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95424))
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
				flag = this.ca124a9f406cda69b904f2eb04d553ab9.c101f23aeac1c42556c49eda79303ea59(cbdc50b515ed67c077176f4019de463d7.c9963fcf210a214a3206d6500f3b9397b(spawnObject));
				ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.cfa1355bd75c103e16c58052eddb4eaf9, cc4987d6a853db77954f21abe4e42946a.cd3f37936749e1f97ba2302c000ed0a41(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95428), c3d8030281ae75f98f8d6b1e4456f5ad0.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0)));
				c4de756e1b35c29fe7b9dfaec634643c3.c30767ddca1f9c207888833aea5b5fc61(this.cf377420a5fad5d12a85b30a62bec6eaa, cc4987d6a853db77954f21abe4e42946a.cd3f37936749e1f97ba2302c000ed0a41(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95432), c876305bed405018c75885a926b9c523b.c30767ddca1f9c207888833aea5b5fc61(this.c45a14f1aa9be42464930c00601df4571)));
			}
			c984a13d358f02c3823e16a014a6b3534.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (TextRenderingHint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95436));
			if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(spawnObject) != (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95440))
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
				if (this.ca124a9f406cda69b904f2eb04d553ab9.ce33364a8a1a051ed436217ae91e90305(c35d95f2c662f806376a6c229795e531d.cea69e7c4d1a729bd5783221de1566e79(spawnObject)))
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
					if (c30c5d14c749cb1b8960db653c104dc90.c30767ddca1f9c207888833aea5b5fc61(c35d95f2c662f806376a6c229795e531d.cea69e7c4d1a729bd5783221de1566e79(spawnObject)) == c2ddbe454b04d472c2b341c527f3d1e04.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
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
						if (cd64d45be59c2550429d19f6b7bc9d609.c30767ddca1f9c207888833aea5b5fc61(c35d95f2c662f806376a6c229795e531d.cea69e7c4d1a729bd5783221de1566e79(spawnObject)) + (long)this.c762367a6eb4f42044bb44124037bee47 > cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede())
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
							c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.cee0775c873bd023679e0dc4a6904cd59, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95444), num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95448), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95452));
							goto IL_2E0;
						}
					}
				}
			}
			if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(spawnObject) != (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95456))
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
				if (c54659af927b794cf96ad8e5686795cef.c30767ddca1f9c207888833aea5b5fc61(c35d95f2c662f806376a6c229795e531d.cea69e7c4d1a729bd5783221de1566e79(spawnObject)) == this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())
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
					c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.cfef4cd2de6c3aba8f69cca10c2c5bd08, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95460), num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95464), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95468));
				}
			}
			IL_2E0:
			if (c54659af927b794cf96ad8e5686795cef.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) == spawnObject)
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
				cff4284ab76029a39cd7248149ca6b18f.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c32e86a607835575fdfc47e35a00ad4a0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95472), num2 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95476), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95480), c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95484) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95488));
			}
			else if (this.c5594670fef20cb29eccac8c1f04faf9f)
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
				if (this.c6ec35cf408882bb2d811448e8370e6eb >= num2)
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
					if (this.c6ec35cf408882bb2d811448e8370e6eb <= num2 + num)
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
						cbc0dae595877f31b464441b941d8259a.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150358), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c45a14f1aa9be42464930c00601df4571, new PointF(c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(95492), (float)num2));
						cbc0dae595877f31b464441b941d8259a.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152310), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c45a14f1aa9be42464930c00601df4571, new PointF((float)(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95496)), (float)num2));
						this.c6c72c029a273123a083e76d610205020.ca2fdf498e4a4957f7a25b9226c258490 = spawnObject;
					}
				}
			}
			int num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95500);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95504); i < ccdfe29813305833908e32a43b57880ee.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95524))
			{
				if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, i).c3df3e1aa56d5069f3165b3670176f0eb == c49a205a8d962eedc10d0ad1e8ae458d7.cca4dea8bea2ad5e730f6f34e764c4772.c2102da7b6db76c3364991b80daa8bbbc)
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
					int arg_4C1_0 = num4;
					int arg_4BA_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95508);
					Size size = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, i).cd303aa7cdeb26810eecbb01225743ef6, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
					num4 = arg_4C1_0 + c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_4BA_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95512));
				}
				else if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, i).c6313f2a4b7337fc78e75a94a21750a84 == 0)
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
					int arg_546_0 = num4;
					int arg_53F_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95516);
					Size size2 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(spawnObject, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, i).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
					num4 = arg_546_0 + c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_53F_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size2) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95520));
				}
				else
				{
					num4 += c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, i).c6313f2a4b7337fc78e75a94a21750a84;
				}
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
			for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95528); j < ccdfe29813305833908e32a43b57880ee.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95600))
			{
				if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c3df3e1aa56d5069f3165b3670176f0eb == c49a205a8d962eedc10d0ad1e8ae458d7.cca4dea8bea2ad5e730f6f34e764c4772.c2102da7b6db76c3364991b80daa8bbbc)
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
					int arg_60B_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95532);
					Size size3 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).cd303aa7cdeb26810eecbb01225743ef6, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
					int num5 = c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_60B_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size3) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95536));
					if (!flag)
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
						cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).cd303aa7cdeb26810eecbb01225743ef6, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c45a14f1aa9be42464930c00601df4571, new RectangleF((float)num3, (float)num2, (float)num5, (float)num));
					}
					else
					{
						cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).cd303aa7cdeb26810eecbb01225743ef6, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.cf377420a5fad5d12a85b30a62bec6eaa, new RectangleF((float)num3, (float)num2, (float)num5, (float)num));
					}
					num3 += num5;
				}
				else if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c6313f2a4b7337fc78e75a94a21750a84 == 0)
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
					if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c65646bc8c5a1d3105b628176798bb72a, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(162889)))
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
						if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(spawnObject) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95540))
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
							for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95544); k < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95560); k += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95556))
							{
								if (cf571782289635c1521477ae7181fa55e.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[k]))
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
									cdf32115803dde3a00f356063509b8968.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c2d349497c5c02a8685a83784291c3dea[(int)c7456bcc8ded0ed506e81eca78934b7b1.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[k])], new Rectangle(num3, num2 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95548), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.c2d349497c5c02a8685a83784291c3dea[(int)c7456bcc8ded0ed506e81eca78934b7b1.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[k])]), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.c2d349497c5c02a8685a83784291c3dea[(int)c7456bcc8ded0ed506e81eca78934b7b1.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[k])])));
									num3 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95552);
								}
							}
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
						}
					}
					else
					{
						int arg_886_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95564);
						Size size4 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(spawnObject, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
						int num6 = c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_886_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size4) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95568));
						if (!flag)
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
							cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(spawnObject, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c45a14f1aa9be42464930c00601df4571, new RectangleF((float)num3, (float)num2, (float)num6, (float)num));
						}
						else
						{
							cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(spawnObject, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.cf377420a5fad5d12a85b30a62bec6eaa, new RectangleF((float)num3, (float)num2, (float)num6, (float)num));
						}
						num3 += num4;
					}
				}
				else if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c65646bc8c5a1d3105b628176798bb72a, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(162889)))
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
					int c6313f2a4b7337fc78e75a94a21750a = c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c6313f2a4b7337fc78e75a94a21750a84;
					if (ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(spawnObject) == (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95572))
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
						int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95576);
						for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95580); l < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95596); l += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95592))
						{
							if (cf571782289635c1521477ae7181fa55e.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[l]))
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
								cdf32115803dde3a00f356063509b8968.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c2d349497c5c02a8685a83784291c3dea[(int)c7456bcc8ded0ed506e81eca78934b7b1.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[l])], new Rectangle(num3 + num7, num2 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95584), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.c2d349497c5c02a8685a83784291c3dea[(int)c7456bcc8ded0ed506e81eca78934b7b1.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[l])]), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.c2d349497c5c02a8685a83784291c3dea[(int)c7456bcc8ded0ed506e81eca78934b7b1.c30767ddca1f9c207888833aea5b5fc61(c480c13cf8dcfd3d9d6f46a1ba7b1ed7d.c9963fcf210a214a3206d6500f3b9397b(spawnObject).get_c05ebd1bb5f7a79e49cc11ffb772f8dea()[l])])));
								num7 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95588);
							}
						}
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					num3 += c6313f2a4b7337fc78e75a94a21750a;
				}
				else
				{
					int c6313f2a4b7337fc78e75a94a21750a2 = c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c6313f2a4b7337fc78e75a94a21750a84;
					if (!flag)
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
						cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(spawnObject, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c45a14f1aa9be42464930c00601df4571, new RectangleF((float)num3, (float)num2, (float)c6313f2a4b7337fc78e75a94a21750a2, (float)num));
					}
					else
					{
						cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(spawnObject, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(c341c057025cd8aff0e5f8e9a.c420fce48164d5b865ad42e614cfe582f, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.cf377420a5fad5d12a85b30a62bec6eaa, new RectangleF((float)num3, (float)num2, (float)c6313f2a4b7337fc78e75a94a21750a2, (float)num));
					}
					num3 += c6313f2a4b7337fc78e75a94a21750a2;
				}
			}
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			c49a205a8d962eedc10d0ad1e8ae458d7.c01cf1002d5d02c191da9e03d18de4f93 c01cf1002d5d02c191da9e03d18de4f = new c49a205a8d962eedc10d0ad1e8ae458d7.c01cf1002d5d02c191da9e03d18de4f93();
			c01cf1002d5d02c191da9e03d18de4f.ca2a418584ab037e91a69eed38f8fbc34 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95604);
			c01cf1002d5d02c191da9e03d18de4f.c2fd9b81890a681af60edcd4d871aeaca = c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95608);
			c01cf1002d5d02c191da9e03d18de4f.cb2aca578c04d3a7d5f290c03b0fa72f9 = num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95612);
			c01cf1002d5d02c191da9e03d18de4f.c08da3373491724302570d635a0f22a90 = num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95616) + c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95620);
			c01cf1002d5d02c191da9e03d18de4f.c9d0b81af0b4d9ec454b66f1b3d12988f = c2ddbe454b04d472c2b341c527f3d1e04.c30767ddca1f9c207888833aea5b5fc61(spawnObject);
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c65d04bd6bca9df7aa5403ab9407bcfcf))
			{
				c0027248f7ceeef216c113a7dedc7a7ab.c30767ddca1f9c207888833aea5b5fc61(this.c65d04bd6bca9df7aa5403ab9407bcfcf, c01cf1002d5d02c191da9e03d18de4f);
			}
			this.c68aa75ac4412312061bdcd09510a25f8 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95624);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0013DD4C File Offset: 0x0013BF4C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
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
					RuntimeMethodHandle arg_15_0 = methodof(c2861bce16c5ad69fc008b9d4ba92eecd.Dispose(bool)).MethodHandle;
				}
				if (this.ce3753db2789ff7c885165e389c0b762f != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(this.ce3753db2789ff7c885165e389c0b762f);
				}
			}
			c88a8f596ef73f10ee2a9cc8467376000.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0013DD94 File Offset: 0x0013BF94
		private void c99cc8d41a90783cea4e7845c839dcc98()
		{
			this.ce3753db2789ff7c885165e389c0b762f = ce5d9f7cdcdd93dceb594ff3b777c5df3.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x04001416 RID: 5142
		private string c1fe92e2401f269fe36c670041bacd9cd;

		// Token: 0x04001417 RID: 5143
		private CoreInternal ca124a9f406cda69b904f2eb04d553ab9;

		// Token: 0x04001418 RID: 5144
		private c6bdd46ef9f05485f6b69f34bf6920a88 c6c72c029a273123a083e76d610205020;

		// Token: 0x04001419 RID: 5145
		private Graphics cb54c8f763e2d317b255ccf337530bbaf;

		// Token: 0x0400141A RID: 5146
		private Bitmap cfe50bfa25649541afa0ea62ceaabc269;

		// Token: 0x0400141B RID: 5147
		private Bitmap cfcf963d78e4d86bc8e79dd99361e64d9;

		// Token: 0x0400141C RID: 5148
		private Pen c32e86a607835575fdfc47e35a00ad4a0;

		// Token: 0x0400141D RID: 5149
		private SolidBrush c45a14f1aa9be42464930c00601df4571;

		// Token: 0x0400141E RID: 5150
		private SolidBrush cfef4cd2de6c3aba8f69cca10c2c5bd08;

		// Token: 0x0400141F RID: 5151
		private SolidBrush cee0775c873bd023679e0dc4a6904cd59;

		// Token: 0x04001420 RID: 5152
		private Pen cfa1355bd75c103e16c58052eddb4eaf9;

		// Token: 0x04001421 RID: 5153
		private SolidBrush cf377420a5fad5d12a85b30a62bec6eaa;

		// Token: 0x04001422 RID: 5154
		private int cf97a3a4af47c09e794d9f87473b3c207;

		// Token: 0x04001423 RID: 5155
		private int c6ec35cf408882bb2d811448e8370e6eb;

		// Token: 0x04001424 RID: 5156
		private bool c5594670fef20cb29eccac8c1f04faf9f;

		// Token: 0x04001425 RID: 5157
		private int c19a39cbc57643a1f28ece1da96138d0b;

		// Token: 0x04001426 RID: 5158
		private int c856c1205f4c19c1cc89a061a33768ce4;

		// Token: 0x04001427 RID: 5159
		private int c762367a6eb4f42044bb44124037bee47 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95628);

		// Token: 0x04001428 RID: 5160
		private int c68aa75ac4412312061bdcd09510a25f8;

		// Token: 0x04001429 RID: 5161
		private int c48f1d2a1be3b66b887007da62045b6f1;

		// Token: 0x0400142A RID: 5162
		private int c3968b2c6fa396939106a9ada179c9c96;

		// Token: 0x0400142B RID: 5163
		private int c69c29600a4f201ec1f7d4b0986f71c68;

		// Token: 0x0400142C RID: 5164
		private int cb464a0c03d66f8a2be54167335a14b15;

		// Token: 0x0400142D RID: 5165
		public List<c49a205a8d962eedc10d0ad1e8ae458d7.c01cf1002d5d02c191da9e03d18de4f93> c65d04bd6bca9df7aa5403ab9407bcfcf;

		// Token: 0x0400142E RID: 5166
		private TextureBrush c2dee754ae18233cf038dd1eb1a74c903;

		// Token: 0x0400142F RID: 5167
		private int cc28cf04c56d7af637a88bf536fba0a56;

		// Token: 0x04001430 RID: 5168
		private IContainer ce3753db2789ff7c885165e389c0b762f;
	}
}
