using System;
using System.IO;
using System.Text;

namespace A
{
	// Token: 0x0200013A RID: 314
	internal sealed class ca0e4eed0bff14244deb1bfa8594857ca
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x0006E1D4 File Offset: 0x0006C3D4
		public ca0e4eed0bff14244deb1bfa8594857ca(byte[] array, int num, bool flag = true)
		{
			this.cf04ca8365b534321dbab07c3f8f11c8f = array;
			this.ce88dac09e768b973c5e53eaa36c84299 = (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array);
			this.c95888aec5e10dcb3364d9302e0dcac09 = num;
			this.c334ef5834b6b898f4e24b07889f4210f = flag;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0006E20C File Offset: 0x0006C40C
		public byte[] get_c4a2e9bca7e475532fd8a216323695871()
		{
			return this.cf04ca8365b534321dbab07c3f8f11c8f;
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0006E220 File Offset: 0x0006C420
		public int get_ce6df75c044fed0e8e7b650c38ff897cb()
		{
			return this.ce88dac09e768b973c5e53eaa36c84299;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0006E234 File Offset: 0x0006C434
		public int get_c77f4e29c6db6b64ea890a0795840d76a()
		{
			return this.c95888aec5e10dcb3364d9302e0dcac09;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0006E248 File Offset: 0x0006C448
		public void set_c77f4e29c6db6b64ea890a0795840d76a(int num)
		{
			this.c95888aec5e10dcb3364d9302e0dcac09 = num;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0006E25C File Offset: 0x0006C45C
		public int get_c153e9e5a97a9a5c2ea857f06c542dd7c()
		{
			return this.ce88dac09e768b973c5e53eaa36c84299 - this.c95888aec5e10dcb3364d9302e0dcac09;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0006E278 File Offset: 0x0006C478
		public byte[] cbcc4dfb3f449d3efb6f8cdf88ff74d56(int num)
		{
			if (num > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_1B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.cbcc4dfb3f449d3efb6f8cdf88ff74d56(int)).MethodHandle;
				}
				return c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24988));
			}
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num);
			cbe95ac16a300b6a866affcb49514a099.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09, array, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24992), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
			this.c95888aec5e10dcb3364d9302e0dcac09 += num;
			return array;
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0006E2F0 File Offset: 0x0006C4F0
		public int cb3f3a1b86212084444d88b49fa917b90(int num, SeekOrigin seekOrigin)
		{
			switch (seekOrigin)
			{
			case SeekOrigin.Begin:
				this.c95888aec5e10dcb3364d9302e0dcac09 = num;
				break;
			case SeekOrigin.Current:
				this.c95888aec5e10dcb3364d9302e0dcac09 += num;
				break;
			case SeekOrigin.End:
				this.c95888aec5e10dcb3364d9302e0dcac09 = this.ce88dac09e768b973c5e53eaa36c84299 - num;
				break;
			}
			return this.c95888aec5e10dcb3364d9302e0dcac09;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0006E340 File Offset: 0x0006C540
		public long c1d7de65a34fa28530030c4294d7b036e()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(24996) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.c1d7de65a34fa28530030c4294d7b036e()).MethodHandle;
				}
				return (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25000);
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_6D_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25004);
				uint arg_9C_0 = arg_6D_0[num];
				byte[] arg_90_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25008);
				uint arg_CB_0 = arg_9C_0 | arg_90_0[num2] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25012);
				byte[] arg_BF_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num3;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num3 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25016);
				uint arg_FA_0 = arg_CB_0 | arg_BF_0[num3] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25020);
				byte[] arg_EE_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num4;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num4 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25024);
				uint num5 = arg_FA_0 | arg_EE_0[num4] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25028);
				byte[] arg_11E_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num6;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num6 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25032);
				uint arg_14D_0 = arg_11E_0[num6];
				byte[] arg_141_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num7;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num7 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25036);
				uint arg_17C_0 = arg_14D_0 | arg_141_0[num7] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25040);
				byte[] arg_170_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num8;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num8 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25044);
				uint arg_1AB_0 = arg_17C_0 | arg_170_0[num8] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25048);
				byte[] arg_19F_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num9;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num9 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25052);
				uint num10 = arg_1AB_0 | arg_19F_0[num9] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25056);
				return (long)((ulong)num10 << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25060) | (ulong)num5);
			}
			long result = cc725ec1a4c19bb353140212ca250bb9e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
			this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25064);
			return result;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0006E538 File Offset: 0x0006C738
		public int cee0f8969f433e5e572dad0b2044a6140()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25068) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.cee0f8969f433e5e572dad0b2044a6140()).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25072);
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_6C_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25076);
				int arg_A4_0 = arg_6C_0[num] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25080);
				byte[] arg_98_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25084);
				int arg_D1_0 = arg_A4_0 | arg_98_0[num2] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25088);
				byte[] arg_C5_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num3;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num3 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25092);
				int arg_F5_0 = arg_D1_0 | arg_C5_0[num3] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25096);
				byte[] arg_F4_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num4;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num4 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25100);
				return arg_F5_0 | arg_F4_0[num4];
			}
			int result = c2e84371e1226c04d8ab0c61fdb3aafcc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
			this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25104);
			return result;
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0006E668 File Offset: 0x0006C868
		public short c9ba1d85307f16d1c50bb54a1719d8ef7()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25108) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.c9ba1d85307f16d1c50bb54a1719d8ef7()).MethodHandle;
				}
				return (short)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25112);
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_69_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25116);
				short arg_96_0 = arg_69_0[num] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25120);
				byte[] arg_95_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25124);
				return arg_96_0 | arg_95_0[num2];
			}
			short result = c54a7166fc748b3789beb44db78400335.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
			this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25128);
			return result;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0006E73C File Offset: 0x0006C93C
		public byte cd4680c2f8d52ae1cff439c41b4bb3571()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25132) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.cd4680c2f8d52ae1cff439c41b4bb3571()).MethodHandle;
				}
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25136);
			}
			byte[] arg_57_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25140);
			return arg_57_0[num];
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
		public uint c825b26848c4efe9789d2c432ff9f7264()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25144) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.c825b26848c4efe9789d2c432ff9f7264()).MethodHandle;
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25148);
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_6C_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25152);
				uint arg_A4_0 = arg_6C_0[num] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25156);
				byte[] arg_98_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25160);
				uint arg_D1_0 = arg_A4_0 | arg_98_0[num2] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25164);
				byte[] arg_C5_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num3;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num3 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25168);
				uint arg_F5_0 = arg_D1_0 | arg_C5_0[num3] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25172);
				byte[] arg_F4_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num4;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num4 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25176);
				return arg_F5_0 | arg_F4_0[num4];
			}
			uint result = c961357f9cc9cb93480ce6f84616b4622.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
			this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25180);
			return result;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0006E8D4 File Offset: 0x0006CAD4
		public ulong c1ddc67f3c5cc6b444d4fb6517a1bf7cb()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25184) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.c1ddc67f3c5cc6b444d4fb6517a1bf7cb()).MethodHandle;
				}
				return (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25188));
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_6D_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25192);
				long arg_A5_0 = arg_6D_0[num] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25196);
				byte[] arg_99_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25200);
				long arg_D2_0 = arg_A5_0 | arg_99_0[num2] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25204);
				byte[] arg_C6_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num3;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num3 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25208);
				long arg_F6_0 = arg_D2_0 | arg_C6_0[num3] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25212);
				byte[] arg_F5_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num4;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num4 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25216);
				long arg_125_0 = arg_F6_0 | arg_F5_0[num4];
				byte[] arg_119_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num5;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num5 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25220);
				long arg_154_0 = arg_125_0 | arg_119_0[num5] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25224);
				byte[] arg_148_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num6;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num6 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25228);
				long arg_183_0 = arg_154_0 | arg_148_0[num6] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25232);
				byte[] arg_177_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num7;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num7 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25236);
				long arg_1A7_0 = arg_183_0 | arg_177_0[num7] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25240);
				byte[] arg_1A6_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num8;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num8 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25244);
				return (ulong)(arg_1A7_0 | arg_1A6_0[num8]);
			}
			ulong result = cb4be14646e7e01c55099bffff105ffb8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
			this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25248);
			return result;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0006EAB8 File Offset: 0x0006CCB8
		public uint cebfbb3b1e49de62b86713de64069e839()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25252) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.cebfbb3b1e49de62b86713de64069e839()).MethodHandle;
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25256);
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_6C_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25260);
				uint arg_A4_0 = arg_6C_0[num] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25264);
				byte[] arg_98_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25268);
				uint arg_C6_0 = arg_A4_0 | arg_98_0[num2] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25272);
				byte[] arg_C5_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num3;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num3 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25276);
				return arg_C6_0 | arg_C5_0[num3];
			}
			byte[] arg_E8_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num4;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num4 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25280);
			uint arg_117_0 = arg_E8_0[num4];
			byte[] arg_10B_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num5;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num5 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25284);
			uint arg_146_0 = arg_117_0 | arg_10B_0[num5] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25288);
			byte[] arg_13A_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num6;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num6 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25292);
			return arg_146_0 | arg_13A_0[num6] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25296);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0006EC0C File Offset: 0x0006CE0C
		public int ca276b93973eea6d99cb667d9e7e48944()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25300) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.ca276b93973eea6d99cb667d9e7e48944()).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25304);
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_6C_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25308);
				int arg_A4_0 = arg_6C_0[num] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25312);
				byte[] arg_98_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25316);
				int arg_C6_0 = arg_A4_0 | arg_98_0[num2] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25320);
				byte[] arg_C5_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num3;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num3 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25324);
				return arg_C6_0 | arg_C5_0[num3];
			}
			byte[] arg_E8_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num4;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num4 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25328);
			int arg_117_0 = arg_E8_0[num4];
			byte[] arg_10B_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num5;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num5 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25332);
			int arg_146_0 = arg_117_0 | arg_10B_0[num5] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25336);
			byte[] arg_13A_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num6;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num6 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25340);
			return arg_146_0 | arg_13A_0[num6] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25344);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0006ED60 File Offset: 0x0006CF60
		public ushort cc5ef9defb876e123f113bc30dbebf4eb()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25348) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.cc5ef9defb876e123f113bc30dbebf4eb()).MethodHandle;
				}
				return (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25352);
			}
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_69_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25356);
				ushort arg_96_0 = arg_69_0[num] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25360);
				byte[] arg_95_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25364);
				return arg_96_0 | arg_95_0[num2];
			}
			ushort result = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
			this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25368);
			return result;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0006EE34 File Offset: 0x0006D034
		public sbyte c2fa861917ef4892dc89e4822f6c18d7a()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25372) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.c2fa861917ef4892dc89e4822f6c18d7a()).MethodHandle;
				}
				return (sbyte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25376);
			}
			byte[] arg_57_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25380);
			return arg_57_0[num];
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0006EE9C File Offset: 0x0006D09C
		public float cd12ac6b3c252047c541c4b93d257956f()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25384) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.cd12ac6b3c252047c541c4b93d257956f()).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(25388);
			}
			float result = c6c2e71f089c6eac1b428678a0c63ec28.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
			this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25392);
			return result;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0006EF10 File Offset: 0x0006D110
		public bool c10977621cab38e37d3151c0a33203f8f()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25396) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.c10977621cab38e37d3151c0a33203f8f()).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25400) != 0;
			}
			byte[] arg_57_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
			int num;
			this.c95888aec5e10dcb3364d9302e0dcac09 = (num = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25404);
			return ((arg_57_0[num] == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25408)) ? 1 : 0) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25412);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0006EF90 File Offset: 0x0006D190
		public bool cdfc5dddc0c1133a15978897f1460e6bf(int num)
		{
			if (num >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25416))
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
					RuntimeMethodHandle arg_1F_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.cdfc5dddc0c1133a15978897f1460e6bf(int)).MethodHandle;
				}
				return num < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25420);
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25424) != 0;
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0006EFD8 File Offset: 0x0006D1D8
		public string c4a64b08025e9d2963db3bdcf9dda8179()
		{
			if (this.c95888aec5e10dcb3364d9302e0dcac09 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25428) > this.ce88dac09e768b973c5e53eaa36c84299)
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
					RuntimeMethodHandle arg_2B_0 = methodof(ca0e4eed0bff14244deb1bfa8594857ca.c4a64b08025e9d2963db3bdcf9dda8179()).MethodHandle;
				}
				return string.Empty;
			}
			ushort num = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25432);
			if (!this.c334ef5834b6b898f4e24b07889f4210f)
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
				byte[] arg_71_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num2;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num2 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25436);
				ushort arg_A0_0 = arg_71_0[num2] << c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25440);
				byte[] arg_9F_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
				int num3;
				this.c95888aec5e10dcb3364d9302e0dcac09 = (num3 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25444);
				num = (arg_A0_0 | arg_9F_0[num3]);
			}
			else
			{
				num = c4450ff070652633705064e5f7cfa93d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cf04ca8365b534321dbab07c3f8f11c8f, this.c95888aec5e10dcb3364d9302e0dcac09);
				this.c95888aec5e10dcb3364d9302e0dcac09 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25448);
			}
			if (this.c95888aec5e10dcb3364d9302e0dcac09 < this.ce88dac09e768b973c5e53eaa36c84299)
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
				}
				else
				{
					int num4 = this.c95888aec5e10dcb3364d9302e0dcac09 + (int)num;
					if (num4 > this.ce88dac09e768b973c5e53eaa36c84299)
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
						num4 = this.ce88dac09e768b973c5e53eaa36c84299;
					}
					int num5 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25452);
					int i = this.c95888aec5e10dcb3364d9302e0dcac09;
					int num6 = this.c95888aec5e10dcb3364d9302e0dcac09;
					while (i < num4)
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
						byte[] arg_177_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
						int expr_16A = i;
						i = expr_16A + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25460);
						if (!arg_177_0[expr_16A])
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								goto IL_184;
							}
						}
						else
						{
							num5 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25456);
						}
					}
					IL_184:
					i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25464);
					byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num5);
					int num7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25468);
					while (this.c95888aec5e10dcb3364d9302e0dcac09 < num4)
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
						byte[] arg_1F0_0 = this.cf04ca8365b534321dbab07c3f8f11c8f;
						int num8;
						this.c95888aec5e10dcb3364d9302e0dcac09 = (num8 = this.c95888aec5e10dcb3364d9302e0dcac09) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25476);
						if ((num7 = arg_1F0_0[num8]) == 0)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								goto IL_200;
							}
						}
						else
						{
							byte[] arg_1BA_0 = array;
							int expr_1AA = i;
							i = expr_1AA + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25472);
							arg_1BA_0[expr_1AA] = (byte)num7;
						}
					}
					IL_200:
					string text = cb104ab32545b9a4f3a225d48cc06ba69.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), array);
					bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25480) != 0;
					int num9 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25484);
					while (flag)
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
						if (num9 >= c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text))
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								goto IL_275;
							}
						}
						else
						{
							flag = this.cdfc5dddc0c1133a15978897f1460e6bf((int)c23ddf164d9a749977276969d2ff00afa.c30767ddca1f9c207888833aea5b5fc61(text, num9));
							num9 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25488);
						}
					}
					IL_275:
					this.c95888aec5e10dcb3364d9302e0dcac09 = num6 + (int)num;
					if (flag)
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
						return text;
					}
					StringBuilder stringBuilder = c09df2f28bd2dad3a9110009e9a06bcad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text));
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25492); j < c0882d45bd906cbf9b75a614dc1eba562.c30767ddca1f9c207888833aea5b5fc61(text); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(25496))
					{
						if (this.cdfc5dddc0c1133a15978897f1460e6bf((int)c23ddf164d9a749977276969d2ff00afa.c30767ddca1f9c207888833aea5b5fc61(text, j)))
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
							cddb2af83f70c2e0429d8788f32e30094.c30767ddca1f9c207888833aea5b5fc61(stringBuilder, c23ddf164d9a749977276969d2ff00afa.c30767ddca1f9c207888833aea5b5fc61(text, j));
						}
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
					return cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(stringBuilder);
				}
			}
			this.c95888aec5e10dcb3364d9302e0dcac09 += (int)num;
			return string.Empty;
		}

		// Token: 0x04000698 RID: 1688
		private byte[] cf04ca8365b534321dbab07c3f8f11c8f;

		// Token: 0x04000699 RID: 1689
		private int ce88dac09e768b973c5e53eaa36c84299;

		// Token: 0x0400069A RID: 1690
		private int c95888aec5e10dcb3364d9302e0dcac09;

		// Token: 0x0400069B RID: 1691
		private bool c334ef5834b6b898f4e24b07889f4210f;
	}
}
