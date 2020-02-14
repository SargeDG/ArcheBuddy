using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ArcheBuddy.Bot.Classes;

namespace A
{
	// Token: 0x02000565 RID: 1381
	internal sealed class c4334d1ba6df601ff9de67c621943eaad : PictureBox
	{
		// Token: 0x06001ED3 RID: 7891 RVA: 0x0013B438 File Offset: 0x00139638
		public c4334d1ba6df601ff9de67c621943eaad(string text, CoreInternal coreInternal, c6bdd46ef9f05485f6b69f34bf6920a88 c6bdd46ef9f05485f6b69f34bf6920a, c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c341c057025cd8aff0e5f8e9a)
		{
			this.c99cc8d41a90783cea4e7845c839dcc98();
			c1b9d9b66fd308184b9018f4db9b35264.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (ControlStyles)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95048), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95052) != 0);
			this.cb5cc6fce1d5e448f1036e9fe27b02d90 = this.cb5cc6fce1d5e448f1036e9fe27b02d90;
			this.ca124a9f406cda69b904f2eb04d553ab9 = coreInternal;
			this.c6c72c029a273123a083e76d610205020 = c6bdd46ef9f05485f6b69f34bf6920a;
			this.c1fe92e2401f269fe36c670041bacd9cd = text;
			this.c604af4f78488b9c3915d89a621cfa0f6 = c341c057025cd8aff0e5f8e9a;
			this.c666740ad7424db16861975829f5c23e7 = new Bitmap(c53ebb13e3b6977be4476897c01ccf9c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c8f6aceba27dae71aec2dc82e5a8aeac5 = new Bitmap(c11d4483ad77b6be93d064744d58eb524.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c591f5d7f8d4b2bf5ba63aebdacf51028 = new Bitmap(c03ab7ead8eb4236a5140804c941b7a9d.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c376e992a489cfb9ac5f90f0bc42fbbc7 = new Bitmap(c3b97a0f6811c9c5a6c1dabf2cdc80769.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c2548bd61d152501f30bd65704319a1f7 = new Bitmap(c6fbbd61bbb103e7cec67d2f10fc284aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.c7ede301d656db38bd7608261a7c18fa0 = new Bitmap(c441f9c04812e4c31c46e858a34bd09e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.ce9c5f54ff85507e20cd4b3174fb552bf = new Bitmap(c2fc4e495b6d78781454f13f0904d8c92.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.ca154c0c4de083e54d079b26c3a5debc2 = cb7d56d27be8902bd8f36528a9c76d799.c8a754f5f2ca4adde825691a9c31a0e83;
			this.ca6ebfc4b58b41e787978fe76e056ae95 = new c3c97afbc65912b49bda637249f073570(cac1b41306e7d2608ecd8c0dff9b5e027.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c78ded31d645d514653d83df43fcbcbb0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cdf6e7c9dd265bc486d194e65301f3224.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), cad901e49ab29eb821555008080f5b669.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c681049ceae8a60cea081e248b66dc6b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), c55dc7131d594e2b491d0564ba10d74ec.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			c8207d980b519c6c591f1f569ec84a55e.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95, new MouseEventHandler(this.cba3cdbdb392fc4d9a25627597efc71b7));
			cbe1179006eb1aa557641868bbf213b9b.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95, new MouseEventHandler(this.cba3cdbdb392fc4d9a25627597efc71b7));
			this.ca6ebfc4b58b41e787978fe76e056ae95.c4133f594a82980efa774a1f80ec2e7d6 = c341c057025cd8aff0e5f8e9a.c4133f594a82980efa774a1f80ec2e7d6;
			this.ca6ebfc4b58b41e787978fe76e056ae95.c597c92b18ba10a11c9e0bdc36e9238d9 = ce4b690c48bfe4f7f579c8033c9b610b5.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(coreInternal), cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201524), this.ca6ebfc4b58b41e787978fe76e056ae95.c4133f594a82980efa774a1f80ec2e7d6), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95056) != 0);
			object arg_1C5_0 = this.ca6ebfc4b58b41e787978fe76e056ae95;
			Size size = ce53b70fd758e055639733d2cfc8ff56a.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95));
			c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(arg_1C5_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size));
			object arg_1EE_0 = this.ca6ebfc4b58b41e787978fe76e056ae95;
			Size size2 = ce53b70fd758e055639733d2cfc8ff56a.c30767ddca1f9c207888833aea5b5fc61(ce40342571005ee0517994e7eb7c2d519.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95));
			c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(arg_1EE_0, cd732e615dba6a4c4c5707fa7b770a160.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size2));
			c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95060));
			c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95064));
			this.ca6ebfc4b58b41e787978fe76e056ae95.c2dd3a90fe102fd5fa4cd1950c06c6465();
			c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), this.ca6ebfc4b58b41e787978fe76e056ae95);
			this.ca56117bd7a22712111d34d4bd3aa8642 = new Label();
			c00a0a8880cc403c0e7f6f0f080a622c6.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, c341c057025cd8aff0e5f8e9a.cd4e00ad3d769e8634db871a069991a75);
			c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, c341c057025cd8aff0e5f8e9a.ca56117bd7a22712111d34d4bd3aa8642);
			c48ae41fb9da6c75de61d7b5efe29dda4.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, c6bdd46ef9f05485f6b69f34bf6920a.cf5edb3102b5e847917b6c6b02b64cf2f);
			int arg_2BC_0 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95068);
			Size size3 = c5f597425cd847ba7251ed7121db28df6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c341c057025cd8aff0e5f8e9a.ca56117bd7a22712111d34d4bd3aa8642, cf3e76658314ffe6840f1326b31b84d62.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642));
			int num = c5873f32e26186c23557a8f8798239941.c0cf59c3e67a46fd4edb3040c5ab0bbfb(arg_2BC_0, c3057d1341f994be9fa1e5360fb9db154.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref size3));
			this.cb5cc6fce1d5e448f1036e9fe27b02d90 = num + c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95);
			c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95072));
			c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, num);
			c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95076));
			c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(this.ca56117bd7a22712111d34d4bd3aa8642, c22c2ccd3a1b5cf0fd393ce0898dd6661.c30767ddca1f9c207888833aea5b5fc61(this.ca6ebfc4b58b41e787978fe76e056ae95) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95080));
			c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), this.ca56117bd7a22712111d34d4bd3aa8642);
			this.c07859168338f0ebeee9322c831797337 = new Label();
			c00a0a8880cc403c0e7f6f0f080a622c6.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, c341c057025cd8aff0e5f8e9a.cd4e00ad3d769e8634db871a069991a75);
			c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138673));
			cafcf435350e545e308b9f2632d1e4156.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, (ContentAlignment)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95084));
			c48ae41fb9da6c75de61d7b5efe29dda4.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, c6bdd46ef9f05485f6b69f34bf6920a.cf5edb3102b5e847917b6c6b02b64cf2f);
			c8d11bd632485509323291cb481183b0f.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95088));
			c92e960b5df0a96b818ce3d9e18456c1c.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95092));
			c2a65a7ade96df8276df8968ce7e0c908.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95096));
			c9fba8ec5615475ea6c87f2b00d223ecc.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, this.cb5cc6fce1d5e448f1036e9fe27b02d90 + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c591f5d7f8d4b2bf5ba63aebdacf51028) + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c376e992a489cfb9ac5f90f0bc42fbbc7) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95100));
			c28f548086d6b05de8d3a3b47621a2479.c30767ddca1f9c207888833aea5b5fc61(cc1427fec38c2a93719945ef8a21ca4b9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), this.c07859168338f0ebeee9322c831797337);
			c92e960b5df0a96b818ce3d9e18456c1c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.cb5cc6fce1d5e448f1036e9fe27b02d90 + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c591f5d7f8d4b2bf5ba63aebdacf51028) + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c376e992a489cfb9ac5f90f0bc42fbbc7) + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c2548bd61d152501f30bd65704319a1f7) + ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.ce9c5f54ff85507e20cd4b3174fb552bf));
			c8d11bd632485509323291cb481183b0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c591f5d7f8d4b2bf5ba63aebdacf51028));
			c57e74a6fc52d16ae52205674e0b5cb3b.c30767ddca1f9c207888833aea5b5fc61(this, c13dd1c2ef9532ee9ae1a07ea7997c23e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			this.cfe50bfa25649541afa0ea62ceaabc269 = new Bitmap(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95104));
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0013B90C File Offset: 0x00139B0C
		public bool get_c597c92b18ba10a11c9e0bdc36e9238d9()
		{
			return this.ca6ebfc4b58b41e787978fe76e056ae95.c597c92b18ba10a11c9e0bdc36e9238d9;
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0013B924 File Offset: 0x00139B24
		public void set_c597c92b18ba10a11c9e0bdc36e9238d9(bool flag)
		{
			this.ca6ebfc4b58b41e787978fe76e056ae95.c3c4daeaab18f75ec4a7f9569abfb3812(flag);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0013B940 File Offset: 0x00139B40
		private void cba3cdbdb392fc4d9a25627597efc71b7(object obj, MouseEventArgs mouseEventArgs)
		{
			c3c97afbc65912b49bda637249f073570 c3c97afbc65912b49bda637249f = c56f53106562254ce17267a6363b19def.c9963fcf210a214a3206d6500f3b9397b(obj);
			ce80a8f11a094afd0d5bf433721eb097d.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(201524), c3c97afbc65912b49bda637249f.c4133f594a82980efa774a1f80ec2e7d6), c3c97afbc65912b49bda637249f.c597c92b18ba10a11c9e0bdc36e9238d9);
			c2f1d46695287fd958a385b8806e6c67f.c30767ddca1f9c207888833aea5b5fc61(c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94808) != 0);
			this.ca124a9f406cda69b904f2eb04d553ab9.cfb682e4b708675aa7f37e33cdeea345b(c3c97afbc65912b49bda637249f.c4133f594a82980efa774a1f80ec2e7d6, c3c97afbc65912b49bda637249f.c597c92b18ba10a11c9e0bdc36e9238d9);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0013B9C0 File Offset: 0x00139BC0
		public void c5967a60cb00e90852f37cceb20e67b9e()
		{
			if (this.c49b341b53a17a09605d48fdf06878941 == c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0.c283c658038b24137c71b96099a0ab95a)
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
					RuntimeMethodHandle arg_1A_0 = methodof(c4334d1ba6df601ff9de67c621943eaad.c5967a60cb00e90852f37cceb20e67b9e()).MethodHandle;
				}
				this.c7045317c6b42cab313b3aa2f333159b4 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94812);
				return;
			}
			if (this.c49b341b53a17a09605d48fdf06878941 == (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94816))
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
				this.c7045317c6b42cab313b3aa2f333159b4 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94820);
				return;
			}
			if (this.c49b341b53a17a09605d48fdf06878941 == (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94824))
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
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94828));
				this.c7045317c6b42cab313b3aa2f333159b4 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94832);
				this.ca154c0c4de083e54d079b26c3a5debc2 = this.c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(this.ce9c5f54ff85507e20cd4b3174fb552bf, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)this.c7045317c6b42cab313b3aa2f333159b4, (int)c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75)));
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94836); i > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94856); i -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94852))
				{
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94840));
					this.c7045317c6b42cab313b3aa2f333159b4 = (byte)((int)this.c7045317c6b42cab313b3aa2f333159b4 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94844));
					if ((int)this.c7045317c6b42cab313b3aa2f333159b4 > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94848))
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
						this.ca154c0c4de083e54d079b26c3a5debc2 = this.c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(this.ce9c5f54ff85507e20cd4b3174fb552bf, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)this.c7045317c6b42cab313b3aa2f333159b4, (int)c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75)));
					}
					else
					{
						this.ca154c0c4de083e54d079b26c3a5debc2 = cb7d56d27be8902bd8f36528a9c76d799.c8a754f5f2ca4adde825691a9c31a0e83;
					}
					c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
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
				this.c49b341b53a17a09605d48fdf06878941 = (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94860);
				return;
			}
			if (this.c49b341b53a17a09605d48fdf06878941 == (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94864))
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
				for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94868); j < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94904); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94900))
				{
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94872));
					this.c7045317c6b42cab313b3aa2f333159b4 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94876);
					this.ca154c0c4de083e54d079b26c3a5debc2 = this.c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(this.ce9c5f54ff85507e20cd4b3174fb552bf, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)this.c7045317c6b42cab313b3aa2f333159b4, (int)c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75)));
					c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
					for (int k = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94880); k > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94896); k -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94892))
					{
						c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94884));
						this.c7045317c6b42cab313b3aa2f333159b4 = (byte)((int)this.c7045317c6b42cab313b3aa2f333159b4 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94888));
						this.ca154c0c4de083e54d079b26c3a5debc2 = this.c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(this.ce9c5f54ff85507e20cd4b3174fb552bf, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)this.c7045317c6b42cab313b3aa2f333159b4, (int)c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75)));
						c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
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
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94908));
				this.c7045317c6b42cab313b3aa2f333159b4 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94912);
				this.ca154c0c4de083e54d079b26c3a5debc2 = this.c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(this.ce9c5f54ff85507e20cd4b3174fb552bf, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)this.c7045317c6b42cab313b3aa2f333159b4, (int)c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75)));
				c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				for (int l = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94916); l > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94932); l -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94928))
				{
					c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94920));
					this.c7045317c6b42cab313b3aa2f333159b4 = (byte)((int)this.c7045317c6b42cab313b3aa2f333159b4 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94924));
					this.ca154c0c4de083e54d079b26c3a5debc2 = this.c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(this.ce9c5f54ff85507e20cd4b3174fb552bf, c36a2bcf90e7a18f8ffa0faee1c965a93.c0cf59c3e67a46fd4edb3040c5ab0bbfb((int)this.c7045317c6b42cab313b3aa2f333159b4, (int)c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75), (int)ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c604af4f78488b9c3915d89a621cfa0f6.cd4e00ad3d769e8634db871a069991a75)));
					c97f49d2657861be131c291c4792bd0f3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
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
				this.c49b341b53a17a09605d48fdf06878941 = (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94936);
			}
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0013BE8C File Offset: 0x0013A08C
		public void ce97b6ac0d04d9ecb4293cefc259f2630(int num)
		{
			Action action = c2cffb0c8c347f2a1edaa1274b624dbd1.c8a754f5f2ca4adde825691a9c31a0e83;
			Action action2 = c2cffb0c8c347f2a1edaa1274b624dbd1.c8a754f5f2ca4adde825691a9c31a0e83;
			if (this.c3ad2d85bc90415614e233f0ce8cd9d6d != num)
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
					RuntimeMethodHandle arg_2A_0 = methodof(c4334d1ba6df601ff9de67c621943eaad.ce97b6ac0d04d9ecb4293cefc259f2630(int)).MethodHandle;
				}
				if (this.c3ad2d85bc90415614e233f0ce8cd9d6d == 0)
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
					if (num > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94940))
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
						if (this.c49b341b53a17a09605d48fdf06878941 != (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94944))
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
							this.c49b341b53a17a09605d48fdf06878941 = (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94948);
							if (action == null)
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
								action = new Action(this.c461371bb85609591f80494c2e23778cc);
							}
							Action action3 = action;
							ce5294de89bcbe05a0f3d36a6419aa130.c30767ddca1f9c207888833aea5b5fc61(action3, null, c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
							goto IL_13F;
						}
					}
				}
			}
			if (this.c3ad2d85bc90415614e233f0ce8cd9d6d != num)
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
				if (this.c3ad2d85bc90415614e233f0ce8cd9d6d > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94952))
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
					if (num == 0)
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
						if (this.c49b341b53a17a09605d48fdf06878941 != c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0.c283c658038b24137c71b96099a0ab95a)
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
							this.c49b341b53a17a09605d48fdf06878941 = (c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94956);
							if (action2 == null)
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
								action2 = new Action(this.c465c22c6bf9dadcd611bd1069c0c032f);
							}
							Action action4 = action2;
							ce5294de89bcbe05a0f3d36a6419aa130.c30767ddca1f9c207888833aea5b5fc61(action4, null, c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83);
						}
					}
				}
			}
			IL_13F:
			c923ad44ef23dbc3674d39cda4caa8a76.c30767ddca1f9c207888833aea5b5fc61(this.c07859168338f0ebeee9322c831797337, cbc9183c627c83d98e9d0e1129ba449da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num));
			this.c3ad2d85bc90415614e233f0ce8cd9d6d = num;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0013BFF4 File Offset: 0x0013A1F4
		private Bitmap c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(Bitmap bitmap, Color color)
		{
			try
			{
				Bitmap bitmap2 = cc969e44ebb59bde219b92d227f2c59ab.c0cf59c3e67a46fd4edb3040c5ab0bbfb(bitmap);
				Color color2 = cf8bf257b1deffdf7e52666ac3ef9fb6e.c30767ddca1f9c207888833aea5b5fc61(bitmap2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94960), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94964));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94968); i < ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(bitmap2); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94980))
				{
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94972); j < ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(bitmap2); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94976))
					{
						if (ca8e795bdb00816e8573df8fac1d9d7e2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf8bf257b1deffdf7e52666ac3ef9fb6e.c30767ddca1f9c207888833aea5b5fc61(bitmap2, i, j), color2))
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
								RuntimeMethodHandle arg_66_0 = methodof(c4334d1ba6df601ff9de67c621943eaad.c9682ee6c25cf0dcf8cfbcd63cbf0d9a1(Bitmap, Color)).MethodHandle;
							}
							cb6336b61166c5f876c2924d64d0df3d8.c30767ddca1f9c207888833aea5b5fc61(bitmap2, i, j, color);
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
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				return bitmap2;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return bitmap;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0013C0E0 File Offset: 0x0013A2E0
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
					RuntimeMethodHandle arg_1A_0 = methodof(c4334d1ba6df601ff9de67c621943eaad.c5e16a22ce552ea42587b7f00b68f813a()).MethodHandle;
				}
				c762855a9636b81dcb4ffe699b8e25cf6.c30767ddca1f9c207888833aea5b5fc61(this.cfe50bfa25649541afa0ea62ceaabc269);
			}
			this.cfe50bfa25649541afa0ea62ceaabc269 = cd95844e7d60a0b489c7b00a0c65c04de.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c22c2ccd3a1b5cf0fd393ce0898dd6661.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca2b5349dc1ed2819b0b204a14992cec0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), (PixelFormat)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94984));
			this.cb54c8f763e2d317b255ccf337530bbaf = c613052e8bee42d8583d5b4036f4d2d57.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cfe50bfa25649541afa0ea62ceaabc269);
			c01754b2d6a3b058e32220a8f00201bb0.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (CompositingQuality)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94988));
			c6ed28ebb38d8ca3aaf3d48c8cf38fb72.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (PixelOffsetMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94992));
			c3c459109318902adc631375e1d797d04.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (SmoothingMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(94996));
			cf59ab6facb97c8f8e7c575d492fabed6.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, (InterpolationMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95000));
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x0013C1A4 File Offset: 0x0013A3A4
		public void c17e5273089bd594a7b1bbc60fa832361()
		{
			cb4574e6b4047b9a82cc9b02bc0f33b6e.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0013C1BC File Offset: 0x0013A3BC
		public void cf775278d656f9b5ea96f712328da8eb9()
		{
			c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c591f5d7f8d4b2bf5ba63aebdacf51028, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95004), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95008), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c591f5d7f8d4b2bf5ba63aebdacf51028), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c591f5d7f8d4b2bf5ba63aebdacf51028));
			int num = ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c591f5d7f8d4b2bf5ba63aebdacf51028) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95012);
			TextureBrush textureBrush = c343e68bc035fb5e495ad9dba5874c67d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c666740ad7424db16861975829f5c23e7);
			try
			{
				cc87e0258744f06b7ed54939ba5c6eb39.c30767ddca1f9c207888833aea5b5fc61(textureBrush, (WrapMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95016));
				c0f13d95f6c502a3a21c31070a3bc1f9d.c30767ddca1f9c207888833aea5b5fc61(textureBrush, (float)num, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(95020));
				c67e5d86d93e1f62ae94663048b8e6e8f.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, textureBrush, num, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95024), this.cb5cc6fce1d5e448f1036e9fe27b02d90, ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c666740ad7424db16861975829f5c23e7));
			}
			finally
			{
				if (textureBrush != null)
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
						RuntimeMethodHandle arg_CB_0 = methodof(c4334d1ba6df601ff9de67c621943eaad.cf775278d656f9b5ea96f712328da8eb9()).MethodHandle;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(textureBrush);
				}
			}
			num += this.cb5cc6fce1d5e448f1036e9fe27b02d90 - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95028);
			c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c376e992a489cfb9ac5f90f0bc42fbbc7, num, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95032), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c376e992a489cfb9ac5f90f0bc42fbbc7), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c376e992a489cfb9ac5f90f0bc42fbbc7));
			num += ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c376e992a489cfb9ac5f90f0bc42fbbc7) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95036);
			c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.c7ede301d656db38bd7608261a7c18fa0, num, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95040), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.c7ede301d656db38bd7608261a7c18fa0));
			if (this.ca154c0c4de083e54d079b26c3a5debc2 != null)
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
				c6620458a630f3f7af22a821f55b87a8e.c30767ddca1f9c207888833aea5b5fc61(this.cb54c8f763e2d317b255ccf337530bbaf, this.ca154c0c4de083e54d079b26c3a5debc2, num, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(95044), ca57bd632f70140d3212563a3b4a59cfe.c30767ddca1f9c207888833aea5b5fc61(this.ca154c0c4de083e54d079b26c3a5debc2), ce1323a7315cb61041472171e7033ea84.c30767ddca1f9c207888833aea5b5fc61(this.ca154c0c4de083e54d079b26c3a5debc2));
			}
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x0013C390 File Offset: 0x0013A590
		protected override void OnPaint(PaintEventArgs e)
		{
			cef56a9fede40546d087138fbc8ff851a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, e);
			this.c5e16a22ce552ea42587b7f00b68f813a();
			this.cf775278d656f9b5ea96f712328da8eb9();
			this.c17e5273089bd594a7b1bbc60fa832361();
			cddeefb9a4e967a5de56a10bc3d73ada7.c30767ddca1f9c207888833aea5b5fc61(c1055f231da15d9d37e8844c6135439cf.c30767ddca1f9c207888833aea5b5fc61(e), this.cfe50bfa25649541afa0ea62ceaabc269, Point.Empty);
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0013C3D0 File Offset: 0x0013A5D0
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
					RuntimeMethodHandle arg_15_0 = methodof(c4334d1ba6df601ff9de67c621943eaad.Dispose(bool)).MethodHandle;
				}
				if (this.ce3753db2789ff7c885165e389c0b762f != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(this.ce3753db2789ff7c885165e389c0b762f);
				}
			}
			c88a8f596ef73f10ee2a9cc8467376000.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x0013C418 File Offset: 0x0013A618
		private void c99cc8d41a90783cea4e7845c839dcc98()
		{
			this.ce3753db2789ff7c885165e389c0b762f = ce5d9f7cdcdd93dceb594ff3b777c5df3.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0013C434 File Offset: 0x0013A634
		[CompilerGenerated]
		private void c461371bb85609591f80494c2e23778cc()
		{
			this.c5967a60cb00e90852f37cceb20e67b9e();
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0013C448 File Offset: 0x0013A648
		[CompilerGenerated]
		private void c465c22c6bf9dadcd611bd1069c0c032f()
		{
			this.c5967a60cb00e90852f37cceb20e67b9e();
		}

		// Token: 0x040013F0 RID: 5104
		private c3c97afbc65912b49bda637249f073570 ca6ebfc4b58b41e787978fe76e056ae95;

		// Token: 0x040013F1 RID: 5105
		private Label ca56117bd7a22712111d34d4bd3aa8642;

		// Token: 0x040013F2 RID: 5106
		private Label c07859168338f0ebeee9322c831797337;

		// Token: 0x040013F3 RID: 5107
		private Bitmap c666740ad7424db16861975829f5c23e7;

		// Token: 0x040013F4 RID: 5108
		private Bitmap c8f6aceba27dae71aec2dc82e5a8aeac5;

		// Token: 0x040013F5 RID: 5109
		private Bitmap c591f5d7f8d4b2bf5ba63aebdacf51028;

		// Token: 0x040013F6 RID: 5110
		private Bitmap c376e992a489cfb9ac5f90f0bc42fbbc7;

		// Token: 0x040013F7 RID: 5111
		private Bitmap c2548bd61d152501f30bd65704319a1f7;

		// Token: 0x040013F8 RID: 5112
		private Bitmap c7ede301d656db38bd7608261a7c18fa0;

		// Token: 0x040013F9 RID: 5113
		private Bitmap ca154c0c4de083e54d079b26c3a5debc2;

		// Token: 0x040013FA RID: 5114
		private Bitmap ce9c5f54ff85507e20cd4b3174fb552bf;

		// Token: 0x040013FB RID: 5115
		private CoreInternal ca124a9f406cda69b904f2eb04d553ab9;

		// Token: 0x040013FC RID: 5116
		private c6bdd46ef9f05485f6b69f34bf6920a88 c6c72c029a273123a083e76d610205020;

		// Token: 0x040013FD RID: 5117
		private string c1fe92e2401f269fe36c670041bacd9cd;

		// Token: 0x040013FE RID: 5118
		private Bitmap cfe50bfa25649541afa0ea62ceaabc269;

		// Token: 0x040013FF RID: 5119
		private Graphics cb54c8f763e2d317b255ccf337530bbaf;

		// Token: 0x04001400 RID: 5120
		private int cb5cc6fce1d5e448f1036e9fe27b02d90;

		// Token: 0x04001401 RID: 5121
		private c49a205a8d962eedc10d0ad1e8ae458d7.c341c057025cd8aff0e5f8e9a16049073 c604af4f78488b9c3915d89a621cfa0f6;

		// Token: 0x04001402 RID: 5122
		private c4334d1ba6df601ff9de67c621943eaad.caab7e47234a24098c6e0bd33ac307ff0 c49b341b53a17a09605d48fdf06878941;

		// Token: 0x04001403 RID: 5123
		private byte c7045317c6b42cab313b3aa2f333159b4;

		// Token: 0x04001404 RID: 5124
		private int c3ad2d85bc90415614e233f0ce8cd9d6d;

		// Token: 0x04001405 RID: 5125
		private IContainer ce3753db2789ff7c885165e389c0b762f;

		// Token: 0x02000566 RID: 1382
		private enum caab7e47234a24098c6e0bd33ac307ff0
		{
			// Token: 0x04001407 RID: 5127
			c283c658038b24137c71b96099a0ab95a,
			// Token: 0x04001408 RID: 5128
			c0cd83ef4f16de34ea4a322d99bf1a00a,
			// Token: 0x04001409 RID: 5129
			cd81cded01f09834bf5bbe94b34794b9d,
			// Token: 0x0400140A RID: 5130
			c298b1eff01fc54fe7e4421ac28106222
		}
	}
}
