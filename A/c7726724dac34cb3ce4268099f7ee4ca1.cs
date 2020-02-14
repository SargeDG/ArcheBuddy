using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace A
{
	// Token: 0x02000089 RID: 137
	internal sealed class c7726724dac34cb3ce4268099f7ee4ca1 : Socket
	{
		// Token: 0x06000245 RID: 581 RVA: 0x000295F8 File Offset: 0x000277F8
		public c7726724dac34cb3ce4268099f7ee4ca1(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) : this(addressFamily, socketType, protocolType, "")
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00029614 File Offset: 0x00027814
		public c7726724dac34cb3ce4268099f7ee4ca1(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType, string text) : this(addressFamily, socketType, protocolType, text, "")
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00029634 File Offset: 0x00027834
		public c7726724dac34cb3ce4268099f7ee4ca1(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType, string c77f6d5110881e0ded8ecd7133324227a, string c451994856b7e775630c666d59938ad1c) : base(addressFamily, socketType, protocolType)
		{
			this.set_c77f6d5110881e0ded8ecd7133324227a(c77f6d5110881e0ded8ecd7133324227a);
			this.set_c451994856b7e775630c666d59938ad1c(c451994856b7e775630c666d59938ad1c);
			c5e266cc1e685c7ff1ec98950d01c8089.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8484) != 0);
			c92d5a9c2671becd5716e097ff19a4ba3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new InvalidOperationException());
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00029678 File Offset: 0x00027878
		public void c963205f48624dc045b80d2b8b74f89b9(EndPoint endPoint)
		{
			if (endPoint == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.c963205f48624dc045b80d2b8b74f89b9(EndPoint)).MethodHandle;
				}
				throw c87c52bce13e3dd762332e3e3768d7eaf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121567));
			}
			if (c8d4530f55adb5b0670463518fe43b3e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8408))
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
				if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() != c882f3b0699eaac7477188b091750fe2a.c7a61c1b30e70203e3374fa38663aaa3c)
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
					if (c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
					}
					else
					{
						cbe9739bb0e6433d390ce8b139b40c99e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
						if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8412))
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
							new c25c9a615aab3c4013a4de9a4e45ed608(this, this.get_c77f6d5110881e0ded8ecd7133324227a()).cd4984a3f0068c136ed45d994c481ffa0(c4f7e3ba1edcd072564c39ea82103e82a.c9963fcf210a214a3206d6500f3b9397b(endPoint));
							return;
						}
						if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8416))
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
							c5e266cc1e685c7ff1ec98950d01c8089.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new cdaae38d2556ce6423b6dd19748acc421(this, this.get_c77f6d5110881e0ded8ecd7133324227a(), this.get_c451994856b7e775630c666d59938ad1c()).cd4984a3f0068c136ed45d994c481ffa0(c4f7e3ba1edcd072564c39ea82103e82a.c9963fcf210a214a3206d6500f3b9397b(endPoint)));
						}
						return;
					}
				}
			}
			cbe9739bb0e6433d390ce8b139b40c99e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, endPoint);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00029794 File Offset: 0x00027994
		public void c963205f48624dc045b80d2b8b74f89b9(string text, int num)
		{
			if (text == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.c963205f48624dc045b80d2b8b74f89b9(string, int)).MethodHandle;
				}
				throw c87c52bce13e3dd762332e3e3768d7eaf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121584));
			}
			if (num > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8420))
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
				if (num <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8424))
				{
					if (c8d4530f55adb5b0670463518fe43b3e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8428))
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
						if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() != c882f3b0699eaac7477188b091750fe2a.c7a61c1b30e70203e3374fa38663aaa3c)
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
							if (c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
							}
							else
							{
								cbe9739bb0e6433d390ce8b139b40c99e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
								if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8436))
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
									new c25c9a615aab3c4013a4de9a4e45ed608(this, this.get_c77f6d5110881e0ded8ecd7133324227a()).cd4984a3f0068c136ed45d994c481ffa0(text, num);
									return;
								}
								if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8440))
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
									c5e266cc1e685c7ff1ec98950d01c8089.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new cdaae38d2556ce6423b6dd19748acc421(this, this.get_c77f6d5110881e0ded8ecd7133324227a(), this.get_c451994856b7e775630c666d59938ad1c()).cd4984a3f0068c136ed45d994c481ffa0(text, num));
								}
								return;
							}
						}
					}
					c1e2762fea90bb83aa6e2362671979760.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, text, num);
					c5e266cc1e685c7ff1ec98950d01c8089.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8432) != 0);
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
			throw c9be00d1882fafe4ecf4aceba59056acf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(121593));
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000298F4 File Offset: 0x00027AF4
		public IAsyncResult ca0ba2e8b206a94f286a1176975372ba2(EndPoint endPoint, AsyncCallback asyncCallback, object obj)
		{
			if (endPoint != null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.ca0ba2e8b206a94f286a1176975372ba2(EndPoint, AsyncCallback, object)).MethodHandle;
				}
				if (asyncCallback != null)
				{
					if (c8d4530f55adb5b0670463518fe43b3e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8444))
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
						if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() != c882f3b0699eaac7477188b091750fe2a.c7a61c1b30e70203e3374fa38663aaa3c)
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
							if (c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
							}
							else
							{
								this.c8316c586a4cbd9c847c16ac59cbdf495 = asyncCallback;
								if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8448))
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
									c21a8cb1e7531519e532497a3cca95626.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new c25c9a615aab3c4013a4de9a4e45ed608(this, this.get_c77f6d5110881e0ded8ecd7133324227a()).c5134a32ff91da1d642775a47f5f2eb0f(c4f7e3ba1edcd072564c39ea82103e82a.c9963fcf210a214a3206d6500f3b9397b(endPoint), new ccfeb8f0395778415ab1abeaad031a1f6(this.c1034e8ceb37afb857e0344feb2b37836), c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
									return c46266131422728c89b48484b713c8a92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
								}
								if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8452))
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
									c21a8cb1e7531519e532497a3cca95626.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new cdaae38d2556ce6423b6dd19748acc421(this, this.get_c77f6d5110881e0ded8ecd7133324227a(), this.get_c451994856b7e775630c666d59938ad1c()).c5134a32ff91da1d642775a47f5f2eb0f(c4f7e3ba1edcd072564c39ea82103e82a.c9963fcf210a214a3206d6500f3b9397b(endPoint), new ccfeb8f0395778415ab1abeaad031a1f6(this.c1034e8ceb37afb857e0344feb2b37836), c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
									return c46266131422728c89b48484b713c8a92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
								}
								return null;
							}
						}
					}
					return cddf35256d936fde44d0e2b1b857dc7fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, endPoint, asyncCallback, obj);
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
			throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00029A4C File Offset: 0x00027C4C
		public IAsyncResult ca0ba2e8b206a94f286a1176975372ba2(string text, int num, AsyncCallback asyncCallback)
		{
			if (text == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.ca0ba2e8b206a94f286a1176975372ba2(string, int, AsyncCallback)).MethodHandle;
				}
				throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			if (num > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8456))
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
				if (num <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8460))
				{
					this.c8316c586a4cbd9c847c16ac59cbdf495 = asyncCallback;
					if (c8d4530f55adb5b0670463518fe43b3e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == (ProtocolType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8464))
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
						if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() != c882f3b0699eaac7477188b091750fe2a.c7a61c1b30e70203e3374fa38663aaa3c)
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
							if (c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == null)
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
							}
							else
							{
								if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8468))
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
									c21a8cb1e7531519e532497a3cca95626.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new c25c9a615aab3c4013a4de9a4e45ed608(this, this.get_c77f6d5110881e0ded8ecd7133324227a()).c5134a32ff91da1d642775a47f5f2eb0f(text, num, new ccfeb8f0395778415ab1abeaad031a1f6(this.c1034e8ceb37afb857e0344feb2b37836), c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
									return c46266131422728c89b48484b713c8a92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
								}
								if (this.get_c2e96ff56abcd3d7f7073d3a369aaeb2f() == (c882f3b0699eaac7477188b091750fe2a)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8472))
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
									c21a8cb1e7531519e532497a3cca95626.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new cdaae38d2556ce6423b6dd19748acc421(this, this.get_c77f6d5110881e0ded8ecd7133324227a(), this.get_c451994856b7e775630c666d59938ad1c()).c5134a32ff91da1d642775a47f5f2eb0f(text, num, new ccfeb8f0395778415ab1abeaad031a1f6(this.c1034e8ceb37afb857e0344feb2b37836), c88a1a0bbc3da045166f84915609944bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)));
									return c46266131422728c89b48484b713c8a92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
								}
								return null;
							}
						}
					}
					c99ceac9bb91cb2adc09ad30e4e7658fd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, num);
					c21a8cb1e7531519e532497a3cca95626.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, this.c8d9c8ec3a7a77b48b4f72216c42ab4b6(text, new ccfeb8f0395778415ab1abeaad031a1f6(this.c1034e8ceb37afb857e0344feb2b37836)));
					return c46266131422728c89b48484b713c8a92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
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
			throw c30a8897a7b5a0d9dd30232bf3c7c946b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00029BE0 File Offset: 0x00027DE0
		public void cb95473bbb474afc5f816e4409275ea72(IAsyncResult asyncResult)
		{
			if (asyncResult == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.cb95473bbb474afc5f816e4409275ea72(IAsyncResult)).MethodHandle;
				}
				throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			if (!cfd46665664c8fc68f4f74fc1c029bcaf.c30767ddca1f9c207888833aea5b5fc61(asyncResult))
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
				throw c30a8897a7b5a0d9dd30232bf3c7c946b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			if (c46680ee34a3bdd70c5ae2695c616653b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != null)
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
				throw c46680ee34a3bdd70c5ae2695c616653b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00029C44 File Offset: 0x00027E44
		internal c1f315ef57f53b9718c486d2471a987ab c8d9c8ec3a7a77b48b4f72216c42ab4b6(string text, ccfeb8f0395778415ab1abeaad031a1f6 ccfeb8f0395778415ab1abeaad031a1f)
		{
			c1f315ef57f53b9718c486d2471a987ab result;
			try
			{
				ca4e6df96f2267e4cd3c685fae546c047.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, new AsyncCallback(this.c31008565e59038b2b7c5ea5efca5b29c), this);
				result = new c1f315ef57f53b9718c486d2471a987ab();
			}
			catch
			{
				throw c1b2e2f399b9266c06572de82d283e70c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00029C8C File Offset: 0x00027E8C
		private void c31008565e59038b2b7c5ea5efca5b29c(IAsyncResult asyncResult)
		{
			try
			{
				IPHostEntry iPHostEntry = c25cd09bffd9a194239b9bb26039144fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(asyncResult);
				cddf35256d936fde44d0e2b1b857dc7fb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c9444007d8a85af25b75fe2c379384add.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cd0ab4c6ab161c8829c7394d3d3015801.c30767ddca1f9c207888833aea5b5fc61(iPHostEntry)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8476)], c627d82742079edb03d6f871f0344100f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)), new AsyncCallback(this.ca8688ccd5e4aacd36d3d4a907ec12e67), cc2b48619a95b3fb1dffbf3d4aed948ce.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
			catch (Exception ex)
			{
				this.c1034e8ceb37afb857e0344feb2b37836(ex);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00029D00 File Offset: 0x00027F00
		private void ca8688ccd5e4aacd36d3d4a907ec12e67(IAsyncResult asyncResult)
		{
			try
			{
				c06733ec0ae40ec4faa1426bea9aec0c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, asyncResult);
				this.c1034e8ceb37afb857e0344feb2b37836(c61b824992954ddc010dd17ba1d9b3c8d.c8a754f5f2ca4adde825691a9c31a0e83);
			}
			catch (Exception ex)
			{
				this.c1034e8ceb37afb857e0344feb2b37836(ex);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00029D3C File Offset: 0x00027F3C
		private void c1034e8ceb37afb857e0344feb2b37836(Exception ex)
		{
			if (ex != null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.c1034e8ceb37afb857e0344feb2b37836(Exception)).MethodHandle;
				}
				c4a69eb809830c0a7691e3f40cd2bff6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}
			c92d5a9c2671becd5716e097ff19a4ba3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ex);
			c5e266cc1e685c7ff1ec98950d01c8089.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(8480) != 0);
			c46266131422728c89b48484b713c8a92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).c1c3ee78352ffb5c52d0096365bac8d8c();
			if (this.c8316c586a4cbd9c847c16ac59cbdf495 != null)
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
				c9eda84b4feba9cea2b8f7478a3bc1fcc.c30767ddca1f9c207888833aea5b5fc61(this.c8316c586a4cbd9c847c16ac59cbdf495, c46266131422728c89b48484b713c8a92.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00029DB0 File Offset: 0x00027FB0
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00029DC4 File Offset: 0x00027FC4
		public IPEndPoint ProxyEndPoint
		{
			get;
			set;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00029DD8 File Offset: 0x00027FD8
		internal c882f3b0699eaac7477188b091750fe2a get_c2e96ff56abcd3d7f7073d3a369aaeb2f()
		{
			return this.c2292fe1fa1e163122013099f5983d9af;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00029DEC File Offset: 0x00027FEC
		internal void set_c2e96ff56abcd3d7f7073d3a369aaeb2f(c882f3b0699eaac7477188b091750fe2a c882f3b0699eaac7477188b091750fe2a)
		{
			this.c2292fe1fa1e163122013099f5983d9af = c882f3b0699eaac7477188b091750fe2a;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00029E00 File Offset: 0x00028000
		// (set) Token: 0x06000256 RID: 598 RVA: 0x00029E14 File Offset: 0x00028014
		private object State
		{
			get;
			set;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00029E28 File Offset: 0x00028028
		public string get_c77f6d5110881e0ded8ecd7133324227a()
		{
			return this.c07abf216dd5777e974de5c8f3efcfef5;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00029E3C File Offset: 0x0002803C
		public void set_c77f6d5110881e0ded8ecd7133324227a(string text)
		{
			if (text == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.set_c77f6d5110881e0ded8ecd7133324227a(string)).MethodHandle;
				}
				throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			this.c07abf216dd5777e974de5c8f3efcfef5 = text;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00029E70 File Offset: 0x00028070
		public string get_c451994856b7e775630c666d59938ad1c()
		{
			return this.cc3e6e3b4bad9c7e35c86e27842d475ac;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00029E84 File Offset: 0x00028084
		public void set_c451994856b7e775630c666d59938ad1c(string text)
		{
			if (text == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(c7726724dac34cb3ce4268099f7ee4ca1.set_c451994856b7e775630c666d59938ad1c(string)).MethodHandle;
				}
				throw c68243244a75739c09774fdeee5fa14fa.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			this.cc3e6e3b4bad9c7e35c86e27842d475ac = text;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00029EB8 File Offset: 0x000280B8
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00029ECC File Offset: 0x000280CC
		private c1f315ef57f53b9718c486d2471a987ab AsyncResult
		{
			get;
			set;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00029EE0 File Offset: 0x000280E0
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00029EF4 File Offset: 0x000280F4
		private Exception ToThrow
		{
			get;
			set;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00029F08 File Offset: 0x00028108
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00029F1C File Offset: 0x0002811C
		private int RemotePort
		{
			get;
			set;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00029F30 File Offset: 0x00028130
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00029F44 File Offset: 0x00028144
		public bool connectEstablished
		{
			get;
			set;
		}

		// Token: 0x040001C6 RID: 454
		private c882f3b0699eaac7477188b091750fe2a c2292fe1fa1e163122013099f5983d9af;

		// Token: 0x040001C7 RID: 455
		private string c07abf216dd5777e974de5c8f3efcfef5;

		// Token: 0x040001C8 RID: 456
		private string cc3e6e3b4bad9c7e35c86e27842d475ac;

		// Token: 0x040001C9 RID: 457
		private AsyncCallback c8316c586a4cbd9c847c16ac59cbdf495;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private IPEndPoint cbb71be93f619544a57a9e4c5a6020fa8;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private object c61254fa3112ea416840f874d04ff51fb;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private c1f315ef57f53b9718c486d2471a987ab c56b8497afadfd403b284ad7effe9cdcc;

		// Token: 0x040001CD RID: 461
		[CompilerGenerated]
		private Exception cadb2081c10152585fcfb1cf324ad7761;

		// Token: 0x040001CE RID: 462
		[CompilerGenerated]
		private int c4e5d5062d16d964232d1b1b7bc67810b;

		// Token: 0x040001CF RID: 463
		[CompilerGenerated]
		private bool c09dbd7ff5b29449dd0ba89d5214048ed;
	}
}
