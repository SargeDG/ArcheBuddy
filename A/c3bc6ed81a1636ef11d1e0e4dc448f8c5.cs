using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x0200056C RID: 1388
	internal sealed class c3bc6ed81a1636ef11d1e0e4dc448f8c5 : PictureBox
	{
		// Token: 0x06001F26 RID: 7974 RVA: 0x00140350 File Offset: 0x0013E550
		public c3bc6ed81a1636ef11d1e0e4dc448f8c5(string text, CoreInternal coreInternal, c6bdd46ef9f05485f6b69f34bf6920a88 c6bdd46ef9f05485f6b69f34bf6920a, c49a205a8d962eedc10d0ad1e8ae458d7 c49a205a8d962eedc10d0ad1e8ae458d)
		{
			this.c99cc8d41a90783cea4e7845c839dcc98();
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96984), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96988) != 0);
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			this.c6c72c029a273123a083e76d610205020 = c6bdd46ef9f05485f6b69f34bf6920a;
			this.ca78fb1642e480ef8bab8d05b99fdbb90 = c49a205a8d962eedc10d0ad1e8ae458d;
			this.c1fe92e2401f269fe36c670041bacd9cd = text;
			this.cfe50bfa25649541afa0ea62ceaabc269 = new Bitmap(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96992));
			this.cfcf963d78e4d86bc8e79dd99361e64d9 = new Bitmap(cb506aeb6fd5b9989fac33975a6c3b24a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c85dd9fa9c9a0c39fcd32d0676b806d80 = new Bitmap(c87f5b4d9aa53561bdc51bc995b573c7a.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c014ab7e4d6857ef94b6b0ad126103f36 = this.c17eca625e44757cb96b10c80278e66b1(new Bitmap(c006eccbe4162c4867a219faf1a3b8444.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96996));
			this.c7ede301d656db38bd7608261a7c18fa0 = this.c17eca625e44757cb96b10c80278e66b1(new Bitmap(c3680354cacfdff05f27b5a22cbfe88fd.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(97000));
			this.cb8aab05f91b3edc620609511d3d9d542 = this.c17eca625e44757cb96b10c80278e66b1(new Bitmap(c13295dd70d728488bcac584cc9de56eb.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(97004));
			this.c68d23b1a05255861b12a63b1cbe0856a = new Bitmap(ccb3fe8034859c470c0b16b8342958655.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c93d36da52406e10ce418b0fb04e937f2 = new List<c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6>();
			ccd41247b03e8b4bed610878a51518399.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new EventHandler(this.c641834981fd85d633eb55f76de9986b6));
			c1e10b66cae27ebcd2ac6eb21885d5816.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new EventHandler(this.cb380848d17eb73c3f4d018b0070ebe44));
			c44eab5d838175c2f6c60064402e4f2c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new EventHandler(this.c66aecf8f0b265b393e9b65912ec557e9));
			cb1c098ec9d6709418039f720bd0378bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c6cee2d411cdb022f60aa7c7b58d80d7e));
			c8207d980b519c6c591f1f569ec84a55e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new MouseEventHandler(this.c6335716b9a13083831ec6a9556ee35cf));
			this.ccabad97f1554bc97ee601532304ad34a = cb7d56d27be8902bd8f36528a9c76d799.c8a754f5f2ca4adde825691a9c31a0e83;
			this.c32e86a607835575fdfc47e35a00ad4a0 = new Pen(ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c45a14f1aa9be42464930c00601df4571 = new SolidBrush(ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c910f018f868f77048f5a4960fcf8acb1 = new List<c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7>();
			this.c2dee754ae18233cf038dd1eb1a74c903 = new TextureBrush(this.cfcf963d78e4d86bc8e79dd99361e64d9);
			cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(this.c2dee754ae18233cf038dd1eb1a74c903, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97008));
			this.c839a9b20980ab6362a38bb43e278558d = new SolidBrush(c21d5868d08c9e8b8ddd91f6b3afd5763.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97012), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97016), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97020)));
			this.set_c0056084ea1bebf867a88f91033e9d396(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(97024));
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00140580 File Offset: 0x0013E780
		public int get_c0056084ea1bebf867a88f91033e9d396()
		{
			return this.c6add2859454b8feee33dc214abdbb2bc;
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00140594 File Offset: 0x0013E794
		public void set_c0056084ea1bebf867a88f91033e9d396(int num)
		{
			this.c6add2859454b8feee33dc214abdbb2bc = num;
			this.cdc3660952899906853a3cfaafe6b4826();
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x001405B0 File Offset: 0x0013E7B0
		public void cdc3660952899906853a3cfaafe6b4826()
		{
			Action action = new Action(this.ca5a8d5bd4312f53896e2eccce4222094);
			c7db93b9a656b3df21ff0704b0d541b67.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c50727e34948ef9b15203539df949de95.c0cf59c3e67a46fd4edb3040c5ab0bbfb(action));
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x001405D8 File Offset: 0x0013E7D8
		private Bitmap c17eca625e44757cb96b10c80278e66b1(Bitmap bitmap, float num)
		{
			Bitmap result;
			try
			{
				Bitmap bitmap2 = c04b3275ca0ac6cc493f15ea224fdb471.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(bitmap), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(bitmap));
				Graphics graphics = c613052e8bee42d8583d5b4036f4d2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(bitmap2);
				try
				{
					ColorMatrix colorMatrix = c0bf4aa7096ca63bdacb0da5bbdd67e2b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					cf4f8ae8035bed5de9327da9d9ad0e388.c30767ddca1f9c207888833aea5b5fc61(colorMatrix, num);
					ImageAttributes imageAttributes = c29a58b28e12460e0bc5520bf7f2337ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					c8e9daf3a5ae986346b2dd988c98289fe.c30767ddca1f9c207888833aea5b5fc61(imageAttributes, colorMatrix, (ColorMatrixFlag)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96424), (ColorAdjustType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96428));
					cf0e560725a3152a18de59d43ae6b116f.c30767ddca1f9c207888833aea5b5fc61(graphics, bitmap, new Rectangle(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96432), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96436), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(bitmap2), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(bitmap2)), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96440), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96444), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(bitmap), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(bitmap), (GraphicsUnit)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96448), imageAttributes);
				}
				finally
				{
					if (graphics != null)
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
							RuntimeMethodHandle arg_C7_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.c17eca625e44757cb96b10c80278e66b1(Bitmap, float)).MethodHandle;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(graphics);
					}
				}
				result = bitmap2;
			}
			catch (Exception ex)
			{
				c2e5e290c5e34f024145fe136ad4da993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc22a1577e7a419d94dd058c9ab268187.c30767ddca1f9c207888833aea5b5fc61(ex));
				result = cb7d56d27be8902bd8f36528a9c76d799.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x001406F4 File Offset: 0x0013E8F4
		private void c6335716b9a13083831ec6a9556ee35cf(object obj, MouseEventArgs mouseEventArgs)
		{
			Predicate<c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6> predicate = c89a1232ded9de37f2918144200676382.c8a754f5f2ca4adde825691a9c31a0e83;
			List<c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6> list = cf3ba49b83e0f4daa49c67688cda2c748.c8a754f5f2ca4adde825691a9c31a0e83;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c93d36da52406e10ce418b0fb04e937f2))
			{
				object arg_44_0 = this.c93d36da52406e10ce418b0fb04e937f2;
				if (predicate == null)
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
						RuntimeMethodHandle arg_35_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.c6335716b9a13083831ec6a9556ee35cf(object, MouseEventArgs)).MethodHandle;
					}
					predicate = new Predicate<c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6>(this.cfbe47b34feea751e0b6f0c9dc5d8adaf);
				}
				list = c650842bc6120e767d7aaaca60522747d.c30767ddca1f9c207888833aea5b5fc61(arg_44_0, predicate);
			}
			if (list != null)
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
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96452); i < c360fbaf2593658489c76c52e8a858def.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96460))
				{
					if (cb9c358038bc00bbea940c4d1e6541cb7.c30767ddca1f9c207888833aea5b5fc61(list, i).c96e0afa0fd0c9f57fd713a6a69274ee1 != (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96456))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c2a01ec29bd94e09a986cf5dea26b4cc9(cb9c358038bc00bbea940c4d1e6541cb7.c30767ddca1f9c207888833aea5b5fc61(list, i).c9d0b81af0b4d9ec454b66f1b3d12988f);
						return;
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
			}
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x001407F0 File Offset: 0x0013E9F0
		private void c6cee2d411cdb022f60aa7c7b58d80d7e(object obj, MouseEventArgs mouseEventArgs)
		{
			this.cf97a3a4af47c09e794d9f87473b3c207 = cc9cf5c2a7a84876f073b374e67926f6e.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs);
			this.c6ec35cf408882bb2d811448e8370e6eb = c45a096d3e1a00147ef841f0d197c79da.c30767ddca1f9c207888833aea5b5fc61(mouseEventArgs);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x0014081C File Offset: 0x0013EA1C
		private void c66aecf8f0b265b393e9b65912ec557e9(object obj, EventArgs eventArgs)
		{
			this.c5594670fef20cb29eccac8c1f04faf9f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96464) != 0);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x0014083C File Offset: 0x0013EA3C
		private void cb380848d17eb73c3f4d018b0070ebe44(object obj, EventArgs eventArgs)
		{
			this.c5594670fef20cb29eccac8c1f04faf9f = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96468) != 0);
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0014085C File Offset: 0x0013EA5C
		private void c641834981fd85d633eb55f76de9986b6(object obj, EventArgs eventArgs)
		{
			this.c4c876755083cb310512563293b8ccd1d = c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96472);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00140884 File Offset: 0x0013EA84
		public void c5e16a22ce552ea42587b7f00b68f813a()
		{
			if (this.cfe50bfa25649541afa0ea62ceaabc269 != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.c5e16a22ce552ea42587b7f00b68f813a()).MethodHandle;
				}
				c762855a9636b81dcb4ffe699b8e25cf6.c30767ddca1f9c207888833aea5b5fc61(this.cfe50bfa25649541afa0ea62ceaabc269);
			}
			this.cfe50bfa25649541afa0ea62ceaabc269 = cd95844e7d60a0b489c7b00a0c65c04de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96476));
			this.cb54c8f763e2d317b255ccf337530bbaf = c613052e8bee42d8583d5b4036f4d2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cfe50bfa25649541afa0ea62ceaabc269);
			c01754b2d6a3b058e32220a8f00201bb0.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (CompositingQuality)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96480));
			c6ed28ebb38d8ca3aaf3d48c8cf38fb72.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (PixelOffsetMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96484));
			c3c459109318902adc631375e1d797d04.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (SmoothingMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96488));
			cf59ab6facb97c8f8e7c575d492fabed6.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (InterpolationMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96492));
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c93d36da52406e10ce418b0fb04e937f2))
			{
				c789e5f1178f3499d769eef50fc6a8d3b.c30767ddca1f9c207888833aea5b5fc61(this.c93d36da52406e10ce418b0fb04e937f2);
			}
			this.cf1cd061d25d9cd17bf4860d374bdbe70 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96496);
			this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 = (double)c693351d775647b6dede1f7d4c1e9b009.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96500);
			this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 -= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96508);
			while (this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96524))
			{
				this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 -= c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96516);
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
			while (this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 < c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96540))
			{
				this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 += c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96532);
			}
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 = this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9 * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96548) / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96556);
			this.c825c5fdf1685c97fa21016cb15c7bedd = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96564) != 0);
			c2faa11fbbf59734e2e73e96ca89f2af1.c30767ddca1f9c207888833aea5b5fc61(this.c910f018f868f77048f5a4960fcf8acb1);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00140A84 File Offset: 0x0013EC84
		public void c17e5273089bd594a7b1bbc60fa832361()
		{
			cb4574e6b4047b9a82cc9b02bc0f33b6e.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf);
			c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00140AA4 File Offset: 0x0013ECA4
		public void cf775278d656f9b5ea96f712328da8eb9()
		{
			c656d4c13c849107b8c10c9fa2e9f1f79.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.cecef8667b108d05655e821c908171657, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96568), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96572));
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00140AD8 File Offset: 0x0013ECD8
		public void cfa195f4dd59fd471e4e51d899d151dbe(SpawnObject spawnObject, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a, bool flag)
		{
			if (spawnObject != null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.cfa195f4dd59fd471e4e51d899d151dbe(SpawnObject, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073, bool)).MethodHandle;
				}
				if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
				{
					double num = (double)this.get_c0056084ea1bebf867a88f91033e9d396() / (double)this.c4c876755083cb310512563293b8ccd1d;
					int num2 = this.c4c876755083cb310512563293b8ccd1d + (int)(((c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(spawnObject) - c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())) * c67a7597f421bcf7fb944f5fd587899ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9) - (cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(spawnObject) - cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())) * c32bba05c34f0307c2e760b63aba72cbc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9)) / num);
					if (num2 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96576))
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
						if (num2 <= c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
						{
							int num3 = this.c4c876755083cb310512563293b8ccd1d - (int)(((c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(spawnObject) - c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())) * c32bba05c34f0307c2e760b63aba72cbc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9) + (cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(spawnObject) - cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0())) * c67a7597f421bcf7fb944f5fd587899ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc7b1c4d4c7a25ba9d47c982baf0ca6f9)) / num);
							if (num3 >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96580))
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
								if (num3 <= ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
								{
									bool flag2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96584) != 0;
									if (c54659af927b794cf96ad8e5686795cef.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()) == spawnObject)
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
										flag2 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96588) != 0);
									}
									if (c341c057025cd8aff0e5f8e9a.cb46d33e5c53239009b507805254d6c69 == null)
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
										this.c377029c49d171f0247d6a0ac69d43c45(c341c057025cd8aff0e5f8e9a);
									}
									if (!flag2)
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
										if (this.c6c72c029a273123a083e76d610205020.ca2fdf498e4a4957f7a25b9226c258490 != spawnObject)
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
											c656d4c13c849107b8c10c9fa2e9f1f79.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, c341c057025cd8aff0e5f8e9a.cb46d33e5c53239009b507805254d6c69, num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96592), num3 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96596));
											if (!this.c5594670fef20cb29eccac8c1f04faf9f)
											{
												goto IL_2AD;
											}
											while (true)
											{
												switch (5)
												{
												case 0:
													continue;
												}
												break;
											}
											if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2 - this.cf97a3a4af47c09e794d9f87473b3c207) >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96600))
											{
												goto IL_2AD;
											}
											while (true)
											{
												switch (7)
												{
												case 0:
													continue;
												}
												break;
											}
											if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num3 - this.c6ec35cf408882bb2d811448e8370e6eb) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96604))
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
												c9065122ee6f8ace6e4c98e14cec87e8f.c30767ddca1f9c207888833aea5b5fc61(this.c910f018f868f77048f5a4960fcf8acb1, new c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7(spawnObject, c341c057025cd8aff0e5f8e9a, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96608) != 0, num2, num3));
												this.c825c5fdf1685c97fa21016cb15c7bedd = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96612) != 0);
												goto IL_2AD;
											}
											goto IL_2AD;
										}
									}
									c9065122ee6f8ace6e4c98e14cec87e8f.c30767ddca1f9c207888833aea5b5fc61(this.c910f018f868f77048f5a4960fcf8acb1, new c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7(spawnObject, c341c057025cd8aff0e5f8e9a, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96616) != 0, num2, num3));
									IL_2AD:
									if (flag)
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
										if (this.ca78fb1642e480ef8bab8d05b99fdbb90.c847db3e0c8000d2e8c299776452bd50f)
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
											ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0, this.ca78fb1642e480ef8bab8d05b99fdbb90.c183c7527f3d2f16e014b2653a28f28bf);
										}
										else
										{
											ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0, c341c057025cd8aff0e5f8e9a.cd4e00ad3d769e8634db871a069991a75);
										}
										c696c11743e3b6b49dacd49dbabaeb1e0.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c32e86a607835575fdfc47e35a00ad4a0, num2 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96620), num3 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96624), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96628), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96632));
									}
									c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6 c49ebde4355c27864d83fce5f465f60d = new c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6();
									c49ebde4355c27864d83fce5f465f60d.c5ed806d2bb2197e7a4cc678385a2e6a1 = num2;
									c49ebde4355c27864d83fce5f465f60d.ce3da4123359df388eefe0c5b68072b14 = num3;
									c49ebde4355c27864d83fce5f465f60d.c4133f594a82980efa774a1f80ec2e7d6 = c341c057025cd8aff0e5f8e9a.c853ac4dc5a4ebc1f368bca44ec315f27;
									c49ebde4355c27864d83fce5f465f60d.c60958cc55162377476d7d7bef4bae994 = spawnObject;
									c49ebde4355c27864d83fce5f465f60d.c9d0b81af0b4d9ec454b66f1b3d12988f = c2ddbe454b04d472c2b341c527f3d1e04.c30767ddca1f9c207888833aea5b5fc61(spawnObject);
									c49ebde4355c27864d83fce5f465f60d.c96e0afa0fd0c9f57fd713a6a69274ee1 = ca7f08083d0c234ebff9658f4f6c72db6.c30767ddca1f9c207888833aea5b5fc61(spawnObject);
									using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c93d36da52406e10ce418b0fb04e937f2))
									{
										cc34037c1dedf0cdddb730b2ea29824bf.c30767ddca1f9c207888833aea5b5fc61(this.c93d36da52406e10ce418b0fb04e937f2, c49ebde4355c27864d83fce5f465f60d);
									}
									return;
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
							return;
						}
						while (true)
						{
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					return;
				}
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00140EA8 File Offset: 0x0013F0A8
		public void c43b33c80aed8470d69fd335c69e35a6c()
		{
			List<c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7> list = c21a3a0fb892a00dcd37c6e7b2d22e4a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7 cb635eb5661dd98606404f43461356bb = null;
			List<c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7>.Enumerator enumerator = cb2437c937690ed21eeb31ea9aecfdd30.c30767ddca1f9c207888833aea5b5fc61(this.c910f018f868f77048f5a4960fcf8acb1);
			try
			{
				while (c1870dfeb2b6f29f432e9cf68fe40f826.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
				{
					c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7 cb635eb5661dd98606404f43461356bb2 = cf5c56ab38e9a8a344c25ac22c065167b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
					if (cb635eb5661dd98606404f43461356bb2.c63fbf4532d4ba39ee6e597371f6422f6)
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
							RuntimeMethodHandle arg_42_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.c43b33c80aed8470d69fd335c69e35a6c()).MethodHandle;
						}
						c9065122ee6f8ace6e4c98e14cec87e8f.c30767ddca1f9c207888833aea5b5fc61(list, cb635eb5661dd98606404f43461356bb2);
					}
					else
					{
						int num = c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb635eb5661dd98606404f43461356bb2.c3071642cc772d7d0223fbcc438c3ff3e - this.cf97a3a4af47c09e794d9f87473b3c207) + c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb635eb5661dd98606404f43461356bb2.c039bd5f7ee0b10e3324f3380089087ec - this.c6ec35cf408882bb2d811448e8370e6eb);
						if (this.cf1cd061d25d9cd17bf4860d374bdbe70 > num)
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
							this.cf1cd061d25d9cd17bf4860d374bdbe70 = num;
							cb635eb5661dd98606404f43461356bb = cb635eb5661dd98606404f43461356bb2;
						}
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
			}
			if (cb635eb5661dd98606404f43461356bb != null)
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
				c9065122ee6f8ace6e4c98e14cec87e8f.c30767ddca1f9c207888833aea5b5fc61(list, cb635eb5661dd98606404f43461356bb);
			}
			List<c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7>.Enumerator enumerator2 = cb2437c937690ed21eeb31ea9aecfdd30.c30767ddca1f9c207888833aea5b5fc61(list);
			try
			{
				while (c1870dfeb2b6f29f432e9cf68fe40f826.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2))
				{
					c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7 cb635eb5661dd98606404f43461356bb3 = cf5c56ab38e9a8a344c25ac22c065167b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2);
					if (cb635eb5661dd98606404f43461356bb3.c63fbf4532d4ba39ee6e597371f6422f6)
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
						c656d4c13c849107b8c10c9fa2e9f1f79.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.cb46d33e5c53239009b507805254d6c69, cb635eb5661dd98606404f43461356bb3.c3071642cc772d7d0223fbcc438c3ff3e - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96636), cb635eb5661dd98606404f43461356bb3.c039bd5f7ee0b10e3324f3380089087ec - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96640));
						ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96644), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96648), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96652), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96656)));
						c696c11743e3b6b49dacd49dbabaeb1e0.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c32e86a607835575fdfc47e35a00ad4a0, cb635eb5661dd98606404f43461356bb3.c3071642cc772d7d0223fbcc438c3ff3e - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96660), cb635eb5661dd98606404f43461356bb3.c039bd5f7ee0b10e3324f3380089087ec - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96664), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96668), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96672));
						ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96676), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96680), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96684), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96688)));
						c696c11743e3b6b49dacd49dbabaeb1e0.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c32e86a607835575fdfc47e35a00ad4a0, cb635eb5661dd98606404f43461356bb3.c3071642cc772d7d0223fbcc438c3ff3e - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96692), cb635eb5661dd98606404f43461356bb3.c039bd5f7ee0b10e3324f3380089087ec - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96696), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96700), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96704));
					}
					int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96708);
					ce8e8de3e172228c2716c3264e6abdeca.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0, ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96712); i < ccdfe29813305833908e32a43b57880ee.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96732))
					{
						if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, i).c3df3e1aa56d5069f3165b3670176f0eb == c49a205a8d962eedc10d0ad1e8ae458d7.cca4dea8bea2ad5e730f6f34e764c4772.c2102da7b6db76c3364991b80daa8bbbc)
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
							int arg_2E9_0 = num2;
							int arg_2E2_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96716);
							Size size = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, i).cd303aa7cdeb26810eecbb01225743ef6, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
							num2 = arg_2E9_0 + c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_2E2_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96720));
						}
						else if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, i).c6313f2a4b7337fc78e75a94a21750a84 == 0)
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
							int arg_380_0 = num2;
							int arg_379_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96724);
							Size size2 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(cb635eb5661dd98606404f43461356bb3.c60958cc55162377476d7d7bef4bae994, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, i).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
							num2 = arg_380_0 + c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_379_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size2) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96728));
						}
						else
						{
							num2 += c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, i).c6313f2a4b7337fc78e75a94a21750a84;
						}
					}
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
					float num3 = (float)cb635eb5661dd98606404f43461356bb3.c3071642cc772d7d0223fbcc438c3ff3e - (float)(num2 / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96736));
					if (num3 > (float)(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num2))
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
						num3 = (float)c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - (float)num2;
					}
					if (num3 < c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96740))
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
						num3 = c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96744);
					}
					float num4 = (float)(cb635eb5661dd98606404f43461356bb3.c039bd5f7ee0b10e3324f3380089087ec - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96748));
					if (num4 > (float)(ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - (c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96752))))
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
						num4 = (float)(ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - (c819e77e1957504362c0f9c6edb870e49.c30767ddca1f9c207888833aea5b5fc61(this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96756)));
					}
					if (num4 < c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96760))
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
						num4 = c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96764);
					}
					float num5 = num3;
					float num6 = num4;
					c984a13d358f02c3823e16a014a6b3534.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (TextRenderingHint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96768));
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96772); j < ccdfe29813305833908e32a43b57880ee.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96792))
					{
						if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).c3df3e1aa56d5069f3165b3670176f0eb == c49a205a8d962eedc10d0ad1e8ae458d7.cca4dea8bea2ad5e730f6f34e764c4772.c2102da7b6db76c3364991b80daa8bbbc)
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
							cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).cd303aa7cdeb26810eecbb01225743ef6, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c839a9b20980ab6362a38bb43e278558d, new RectangleF(num5, num6, (float)c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num5, (float)ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num6));
							float arg_5E0_0 = num5;
							int arg_5D8_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96776);
							Size size3 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).cd303aa7cdeb26810eecbb01225743ef6, this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
							num5 = arg_5E0_0 + (float)c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_5D8_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size3) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96780));
						}
						else if (c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).c6313f2a4b7337fc78e75a94a21750a84 == 0)
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
							cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(cb635eb5661dd98606404f43461356bb3.c60958cc55162377476d7d7bef4bae994, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c839a9b20980ab6362a38bb43e278558d, new RectangleF(num5, num6, (float)c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num5, (float)ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num6));
							float arg_6E6_0 = num5;
							int arg_6DE_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96784);
							Size size4 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(cb635eb5661dd98606404f43461356bb3.c60958cc55162377476d7d7bef4bae994, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f);
							num5 = arg_6E6_0 + (float)c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_6DE_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size4) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96788));
						}
						else
						{
							cf8dbd529c2c004cb7ec661142babb364.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c6c72c029a273123a083e76d610205020.c70ce6be9d6866e31c8db2469216312a4(cb635eb5661dd98606404f43461356bb3.c60958cc55162377476d7d7bef4bae994, c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).c65646bc8c5a1d3105b628176798bb72a), this.c6c72c029a273123a083e76d610205020.cf5edb3102b5e847917b6c6b02b64cf2f, this.c839a9b20980ab6362a38bb43e278558d, new RectangleF(num5, num6, (float)c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num5, (float)ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - num6));
							num5 += (float)c41874c57d581fe6ef2ec5bed8eaf852b.c30767ddca1f9c207888833aea5b5fc61(cb635eb5661dd98606404f43461356bb3.c6354ae202fd36d61a6cc39c14abd4752.c853ac4dc5a4ebc1f368bca44ec315f27, j).c6313f2a4b7337fc78e75a94a21750a84;
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
			finally
			{
				((IDisposable)enumerator2).Dispose();
			}
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x001416C0 File Offset: 0x0013F8C0
		private unsafe void c377029c49d171f0247d6a0ac69d43c45(Color color, ref Bitmap ptr)
		{
			ptr = cd95844e7d60a0b489c7b00a0c65c04de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96796), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96800), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96804));
			Graphics graphics = c613052e8bee42d8583d5b4036f4d2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ptr);
			try
			{
				GraphicsPath graphicsPath = c2ba8b6861f958289999f75b2e64da841.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				try
				{
					c0672978e9ebb3ef5137a0ae26916f06b.c30767ddca1f9c207888833aea5b5fc61(graphicsPath, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96808), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96812), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96816), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96820));
					PathGradientBrush pathGradientBrush = c74d2171e59d78dc1a97238beba3b66f8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(graphicsPath);
					try
					{
						Color[] array = c13af8f2d3f249609facac532e2cc7c95.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96824));
						array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96828)] = c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96832), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96836), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96840), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96844));
						Color[] array2 = array;
						cca0ebb639ea4ea40eec262b71f7150aa.c30767ddca1f9c207888833aea5b5fc61(pathGradientBrush, array2);
						c39fd92bc212148676e059435659521ff.c30767ddca1f9c207888833aea5b5fc61(pathGradientBrush, color);
						cbf4e4d8fd2364e9d5d808e2ac9e8dc75.c30767ddca1f9c207888833aea5b5fc61(pathGradientBrush, new PointF(c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96848), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96852)));
						cee202933243cfbb0e07bf98f27c9d4fc.c30767ddca1f9c207888833aea5b5fc61(graphics, pathGradientBrush, graphicsPath);
					}
					finally
					{
						if (pathGradientBrush != null)
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
								RuntimeMethodHandle arg_119_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.c377029c49d171f0247d6a0ac69d43c45(Color, Bitmap*)).MethodHandle;
							}
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(pathGradientBrush);
						}
					}
				}
				finally
				{
					if (graphicsPath != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(graphicsPath);
					}
				}
			}
			finally
			{
				if (graphics != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(graphics);
				}
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00141868 File Offset: 0x0013FA68
		private void c377029c49d171f0247d6a0ac69d43c45(c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a)
		{
			this.c377029c49d171f0247d6a0ac69d43c45(c341c057025cd8aff0e5f8e9a.cd4e00ad3d769e8634db871a069991a75, ref c341c057025cd8aff0e5f8e9a.cb46d33e5c53239009b507805254d6c69);
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00141888 File Offset: 0x0013FA88
		protected override void OnPaint(PaintEventArgs e)
		{
			cef56a9fede40546d087138fbc8ff851a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
			cddeefb9a4e967a5de56a10bc3d73ada7.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cfe50bfa25649541afa0ea62ceaabc269, Point.Empty);
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x001418B4 File Offset: 0x0013FAB4
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
					RuntimeMethodHandle arg_15_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.Dispose(bool)).MethodHandle;
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
			if (this.c32e86a607835575fdfc47e35a00ad4a0 != null)
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
				caae7f13aa68fd0adb2ac60da5991288b.c30767ddca1f9c207888833aea5b5fc61(this.c32e86a607835575fdfc47e35a00ad4a0);
			}
			if (this.c45a14f1aa9be42464930c00601df4571 != null)
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
				c3b76f6c1bde20349c8aed4180c80b15e.c30767ddca1f9c207888833aea5b5fc61(this.c45a14f1aa9be42464930c00601df4571);
			}
			c88a8f596ef73f10ee2a9cc8467376000.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00141938 File Offset: 0x0013FB38
		private void c99cc8d41a90783cea4e7845c839dcc98()
		{
			this.ce3753db2789ff7c885165e389c0b762f = ce5d9f7cdcdd93dceb594ff3b777c5df3.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00141954 File Offset: 0x0013FB54
		[CompilerGenerated]
		private void ca5a8d5bd4312f53896e2eccce4222094()
		{
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.cfaca46105b6498f7a04b4c6de3e37183))
			{
				try
				{
					if (c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96856))
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
							RuntimeMethodHandle arg_35_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.ca5a8d5bd4312f53896e2eccce4222094()).MethodHandle;
						}
						c92e960b5df0a96b818ce3d9e18456c1c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96860));
					}
					if (ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96864))
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
						c8d11bd632485509323291cb481183b0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96868));
					}
					this.cecef8667b108d05655e821c908171657 = cd95844e7d60a0b489c7b00a0c65c04de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96872));
					Graphics graphics = c613052e8bee42d8583d5b4036f4d2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cecef8667b108d05655e821c908171657);
					try
					{
						c01754b2d6a3b058e32220a8f00201bb0.c30767ddca1f9c207888833aea5b5fc61(graphics, (CompositingQuality)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96876));
						c6ed28ebb38d8ca3aaf3d48c8cf38fb72.c30767ddca1f9c207888833aea5b5fc61(graphics, (PixelOffsetMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96880));
						c3c459109318902adc631375e1d797d04.c30767ddca1f9c207888833aea5b5fc61(graphics, (SmoothingMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96884));
						cf59ab6facb97c8f8e7c575d492fabed6.c30767ddca1f9c207888833aea5b5fc61(graphics, (InterpolationMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96888));
						c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(this.c2dee754ae18233cf038dd1eb1a74c903, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96892), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(96896));
						c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(graphics, this.c2dee754ae18233cf038dd1eb1a74c903, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96900), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96904), c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96908) / (double)this.get_c0056084ea1bebf867a88f91033e9d396() * c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96916);
						if (num > c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96924))
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
							num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96932);
						}
						int num2 = c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) / c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96940);
						int num3 = (int)((double)num2 / c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(96944) * num);
						int num4 = num2 - num3;
						int num5 = num3 * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96952);
						c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.cb8aab05f91b3edc620609511d3d9d542, num2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96956), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.cb8aab05f91b3edc620609511d3d9d542), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.cb8aab05f91b3edc620609511d3d9d542));
						c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.c014ab7e4d6857ef94b6b0ad126103f36, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96960), num2, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c014ab7e4d6857ef94b6b0ad126103f36));
						c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.c7ede301d656db38bd7608261a7c18fa0, c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) - ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0), num2, ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0));
						c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.c85dd9fa9c9a0c39fcd32d0676b806d80, num4, num4, num5, num5);
						c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(graphics, this.c68d23b1a05255861b12a63b1cbe0856a, num4, num4, num5, num5);
						this.c377029c49d171f0247d6a0ac69d43c45(this.ca78fb1642e480ef8bab8d05b99fdbb90.c40f949633d92c538693a28a2c1e4b04b, ref this.ccabad97f1554bc97ee601532304ad34a);
						c656d4c13c849107b8c10c9fa2e9f1f79.c30767ddca1f9c207888833aea5b5fc61(graphics, this.ccabad97f1554bc97ee601532304ad34a, this.c4c876755083cb310512563293b8ccd1d - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96964), this.c4c876755083cb310512563293b8ccd1d - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96968));
					}
					finally
					{
						if (graphics != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(graphics);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
			}
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00141CB4 File Offset: 0x0013FEB4
		[CompilerGenerated]
		private bool cfbe47b34feea751e0b6f0c9dc5d8adaf(c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6 c49ebde4355c27864d83fce5f465f60d)
		{
			if (c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c49ebde4355c27864d83fce5f465f60d.c5ed806d2bb2197e7a4cc678385a2e6a1 - this.cf97a3a4af47c09e794d9f87473b3c207) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96972))
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
					RuntimeMethodHandle arg_32_0 = methodof(c3bc6ed81a1636ef11d1e0e4dc448f8c5.cfbe47b34feea751e0b6f0c9dc5d8adaf(c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6)).MethodHandle;
				}
				return c007522f24a0abdb0c959224dab8dee0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c49ebde4355c27864d83fce5f465f60d.ce3da4123359df388eefe0c5b68072b14 - this.c6ec35cf408882bb2d811448e8370e6eb) < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96976);
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(96980) != 0;
		}

		// Token: 0x04001475 RID: 5237
		private int c6add2859454b8feee33dc214abdbb2bc;

		// Token: 0x04001476 RID: 5238
		private object cfaca46105b6498f7a04b4c6de3e37183 = new object();

		// Token: 0x04001477 RID: 5239
		private int c4c876755083cb310512563293b8ccd1d;

		// Token: 0x04001478 RID: 5240
		private double cc7b1c4d4c7a25ba9d47c982baf0ca6f9;

		// Token: 0x04001479 RID: 5241
		private Bitmap cfcf963d78e4d86bc8e79dd99361e64d9;

		// Token: 0x0400147A RID: 5242
		private Bitmap c85dd9fa9c9a0c39fcd32d0676b806d80;

		// Token: 0x0400147B RID: 5243
		private Bitmap c014ab7e4d6857ef94b6b0ad126103f36;

		// Token: 0x0400147C RID: 5244
		private Bitmap c7ede301d656db38bd7608261a7c18fa0;

		// Token: 0x0400147D RID: 5245
		private Bitmap cb8aab05f91b3edc620609511d3d9d542;

		// Token: 0x0400147E RID: 5246
		private Bitmap c68d23b1a05255861b12a63b1cbe0856a;

		// Token: 0x0400147F RID: 5247
		private Bitmap cfe50bfa25649541afa0ea62ceaabc269;

		// Token: 0x04001480 RID: 5248
		private Bitmap ccabad97f1554bc97ee601532304ad34a;

		// Token: 0x04001481 RID: 5249
		private Bitmap cecef8667b108d05655e821c908171657;

		// Token: 0x04001482 RID: 5250
		private Graphics cb54c8f763e2d317b255ccf337530bbaf;

		// Token: 0x04001483 RID: 5251
		private string c1fe92e2401f269fe36c670041bacd9cd;

		// Token: 0x04001484 RID: 5252
		private List<c49a205a8d962eedc10d0ad1e8ae458d7.c49ebde4355c27864d83fce5f465f60d6> c93d36da52406e10ce418b0fb04e937f2;

		// Token: 0x04001485 RID: 5253
		private CoreInternal ca124a9f406cda69b904f2eb04d553ab9;

		// Token: 0x04001486 RID: 5254
		private c6bdd46ef9f05485f6b69f34bf6920a88 c6c72c029a273123a083e76d610205020;

		// Token: 0x04001487 RID: 5255
		private Pen c32e86a607835575fdfc47e35a00ad4a0;

		// Token: 0x04001488 RID: 5256
		private SolidBrush c45a14f1aa9be42464930c00601df4571;

		// Token: 0x04001489 RID: 5257
		private int cf97a3a4af47c09e794d9f87473b3c207;

		// Token: 0x0400148A RID: 5258
		private int c6ec35cf408882bb2d811448e8370e6eb;

		// Token: 0x0400148B RID: 5259
		private bool c5594670fef20cb29eccac8c1f04faf9f;

		// Token: 0x0400148C RID: 5260
		private int cf1cd061d25d9cd17bf4860d374bdbe70;

		// Token: 0x0400148D RID: 5261
		private bool c825c5fdf1685c97fa21016cb15c7bedd;

		// Token: 0x0400148E RID: 5262
		private TextureBrush c2dee754ae18233cf038dd1eb1a74c903;

		// Token: 0x0400148F RID: 5263
		private SolidBrush c839a9b20980ab6362a38bb43e278558d;

		// Token: 0x04001490 RID: 5264
		private c49a205a8d962eedc10d0ad1e8ae458d7 ca78fb1642e480ef8bab8d05b99fdbb90;

		// Token: 0x04001491 RID: 5265
		private List<c3bc6ed81a1636ef11d1e0e4dc448f8c5.cb635eb5661dd98606404f43461356bb7> c910f018f868f77048f5a4960fcf8acb1;

		// Token: 0x04001492 RID: 5266
		private IContainer ce3753db2789ff7c885165e389c0b762f;

		// Token: 0x0200056D RID: 1389
		private sealed class cb635eb5661dd98606404f43461356bb7
		{
			// Token: 0x06001F3C RID: 7996 RVA: 0x00141D20 File Offset: 0x0013FF20
			public cb635eb5661dd98606404f43461356bb7(SpawnObject spawnObject, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a, bool flag, int num, int num2)
			{
				this.c60958cc55162377476d7d7bef4bae994 = spawnObject;
				this.c6354ae202fd36d61a6cc39c14abd4752 = c341c057025cd8aff0e5f8e9a;
				this.c63fbf4532d4ba39ee6e597371f6422f6 = flag;
				this.c3071642cc772d7d0223fbcc438c3ff3e = num;
				this.c039bd5f7ee0b10e3324f3380089087ec = num2;
			}

			// Token: 0x04001493 RID: 5267
			public SpawnObject c60958cc55162377476d7d7bef4bae994;

			// Token: 0x04001494 RID: 5268
			public c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c6354ae202fd36d61a6cc39c14abd4752;

			// Token: 0x04001495 RID: 5269
			public bool c63fbf4532d4ba39ee6e597371f6422f6;

			// Token: 0x04001496 RID: 5270
			public int c3071642cc772d7d0223fbcc438c3ff3e;

			// Token: 0x04001497 RID: 5271
			public int c039bd5f7ee0b10e3324f3380089087ec;
		}
	}
}
