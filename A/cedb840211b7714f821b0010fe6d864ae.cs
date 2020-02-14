using System;
using System.Collections;
using System.Collections.Generic;

namespace A
{
	// Token: 0x020003A1 RID: 929
	internal sealed class cedb840211b7714f821b0010fe6d864ae : c156d13823d81cd4a7425f2cf5b6230f3
	{
		// Token: 0x06001063 RID: 4195 RVA: 0x00098F58 File Offset: 0x00097158
		public cedb840211b7714f821b0010fe6d864ae(byte[] array, cdddb0b97541c52448b8f0b50995b8c8e cdddb0b97541c52448b8f0b50995b8c8e, bool flag = false) : base(array, cdddb0b97541c52448b8f0b50995b8c8e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36240), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36244) != 0, flag)
		{
			this.cb617f0dc25d7afaebd973bcc6b16faa9 = this.c1931c382e0fefaae84b9654d92e1461e.cee0f8969f433e5e572dad0b2044a6140();
			this.cf10e48f059fd7a4ad564ef9ea04f8a82 = new List<uint>();
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36248); i < this.cb617f0dc25d7afaebd973bcc6b16faa9; i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36280))
			{
				this.c856c1205f4c19c1cc89a061a33768ce4 = (uint)((int)this.c1931c382e0fefaae84b9654d92e1461e.cc5ef9defb876e123f113bc30dbebf4eb() * c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36252));
				int[] array2 = c5a37f4875ca7804ff197382920518c92.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36256));
				array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36260)] = this.c1931c382e0fefaae84b9654d92e1461e.cee0f8969f433e5e572dad0b2044a6140();
				array2[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36264)] = this.c1931c382e0fefaae84b9654d92e1461e.cee0f8969f433e5e572dad0b2044a6140();
				int[] values = array2;
				BitArray bitArray = new BitArray(values);
				for (uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36268); num < (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36276); num += (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(36272))
				{
					if (cdbeb78a09e8774dc91a4b992ebbc92e4.c30767ddca1f9c207888833aea5b5fc61(bitArray, (int)num))
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
							RuntimeMethodHandle arg_E4_0 = methodof(cedb840211b7714f821b0010fe6d864ae..ctor(byte[], cdddb0b97541c52448b8f0b50995b8c8e, bool)).MethodHandle;
						}
						ca31d1b39e523f59b33c9f0524f6ab57f.c30767ddca1f9c207888833aea5b5fc61(this.cf10e48f059fd7a4ad564ef9ea04f8a82, this.c856c1205f4c19c1cc89a061a33768ce4 + num);
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

		// Token: 0x04000CAD RID: 3245
		public int cb617f0dc25d7afaebd973bcc6b16faa9;

		// Token: 0x04000CAE RID: 3246
		public uint c856c1205f4c19c1cc89a061a33768ce4;

		// Token: 0x04000CAF RID: 3247
		public List<uint> cf10e48f059fd7a4ad564ef9ea04f8a82;
	}
}
