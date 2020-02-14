using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x020004D7 RID: 1239
	public class Mail : BaseObject
	{
		// Token: 0x060014A7 RID: 5287 RVA: 0x000B6B1C File Offset: 0x000B4D1C
		internal Mail(CoreInternal ca124a9f406cda69b904f2eb04d553ab)
		{
			cbfa5598b86323c8d4aa8fdb9a358e39a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (BotTypes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48204));
			this.ca39f2e8ca6dda4ec17f3e6ceb08873cd = new List<Item>();
			this.ca124a9f406cda69b904f2eb04d553ab9 = ca124a9f406cda69b904f2eb04d553ab;
			this.c57fd40f31eac42d57504c30ef6f5d3a5 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48208) != 0);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x000B6B64 File Offset: 0x000B4D64
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(Mail.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd))
						{
							for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47704); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47708))
							{
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd, i));
								c85eddde945202b0ca0a5ffd332a26f3a.c30767ddca1f9c207888833aea5b5fc61(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd, i, cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83);
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
					}
					c2898fd4d9360d4db8e864618476ff8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x000B6C4C File Offset: 0x000B4E4C
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x000B6C60 File Offset: 0x000B4E60
		public bool isSent
		{
			get;
			internal set;
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x000B6C74 File Offset: 0x000B4E74
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x000B6C88 File Offset: 0x000B4E88
		public ulong sendDate
		{
			get;
			internal set;
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x000B6C9C File Offset: 0x000B4E9C
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x000B6CB0 File Offset: 0x000B4EB0
		public ulong recvDate
		{
			get;
			internal set;
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x000B6CC4 File Offset: 0x000B4EC4
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x000B6CD8 File Offset: 0x000B4ED8
		public ulong openDate
		{
			get;
			internal set;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x000B6CEC File Offset: 0x000B4EEC
		public List<Item> getItems()
		{
			List<Item> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.ca39f2e8ca6dda4ec17f3e6ceb08873cd))
			{
				result = this.ca39f2e8ca6dda4ec17f3e6ceb08873cd.ToList<Item>();
			}
			return result;
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x000B6D38 File Offset: 0x000B4F38
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x000B6D4C File Offset: 0x000B4F4C
		internal byte mailBoxListKind
		{
			get;
			set;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000B6D60 File Offset: 0x000B4F60
		internal List<Item> get_cacbaa35d25d410d86c30b4ae8a318175()
		{
			return this.ca39f2e8ca6dda4ec17f3e6ceb08873cd;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000B6D74 File Offset: 0x000B4F74
		internal void set_cacbaa35d25d410d86c30b4ae8a318175(List<Item> list)
		{
			this.ca39f2e8ca6dda4ec17f3e6ceb08873cd = list;
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x000B6D88 File Offset: 0x000B4F88
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x000B6D9C File Offset: 0x000B4F9C
		public bool isReturned
		{
			get;
			internal set;
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x000B6DB0 File Offset: 0x000B4FB0
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x000B6DC4 File Offset: 0x000B4FC4
		public byte attachments
		{
			get;
			internal set;
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000B6DD8 File Offset: 0x000B4FD8
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x000B6DEC File Offset: 0x000B4FEC
		public string text
		{
			get;
			internal set;
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x000B6E00 File Offset: 0x000B5000
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x000B6E14 File Offset: 0x000B5014
		public string reciever
		{
			get;
			internal set;
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x000B6E28 File Offset: 0x000B5028
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x000B6E3C File Offset: 0x000B503C
		public long payAmount
		{
			get;
			internal set;
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000B6E50 File Offset: 0x000B5050
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x000B6E64 File Offset: 0x000B5064
		public long goldAmount
		{
			get;
			internal set;
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x000B6E78 File Offset: 0x000B5078
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x000B6E8C File Offset: 0x000B508C
		public string sender
		{
			get;
			internal set;
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000B6EA0 File Offset: 0x000B50A0
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x000B6EB4 File Offset: 0x000B50B4
		public string title
		{
			get;
			internal set;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x000B6EC8 File Offset: 0x000B50C8
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x000B6EDC File Offset: 0x000B50DC
		public byte status
		{
			get;
			internal set;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000B6EF0 File Offset: 0x000B50F0
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x000B6F04 File Offset: 0x000B5104
		public byte mailType
		{
			get;
			internal set;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000B6F18 File Offset: 0x000B5118
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x000B6F2C File Offset: 0x000B512C
		internal ulong uniqMailId
		{
			get;
			set;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000B6F40 File Offset: 0x000B5140
		public bool ReceiveItemFromMail(uint itemId)
		{
			try
			{
				if (itemId == 0u)
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
						RuntimeMethodHandle arg_15_0 = methodof(Mail.ReceiveItemFromMail(uint)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47712));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47716) != 0;
					return result;
				}
				List<Item> list = c0208fd44e7d43d530a2827c7a7d1150b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47720); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47724))
				{
					if (cd729ec847ff80bc33029eca3bd963a73.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i)) == itemId)
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
						bool result = c82384240a488324b72053352bdf724ed.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i));
						return result;
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
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47728));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47732) != 0;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000B7034 File Offset: 0x000B5234
		public bool ReceiveItemFromMail(string itemName)
		{
			try
			{
				if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(itemName))
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
						RuntimeMethodHandle arg_1C_0 = methodof(Mail.ReceiveItemFromMail(string)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47736));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47740) != 0;
					return result;
				}
				List<Item> list = c0208fd44e7d43d530a2827c7a7d1150b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47744); i < c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47752))
				{
					if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c56978532265d3fc3778bd619810176d7.c30767ddca1f9c207888833aea5b5fc61(c418278d5c7b8e9b595f0765c1bc29c43.c30767ddca1f9c207888833aea5b5fc61(c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i))), itemName, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47748) != 0) == 0)
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
						bool result = c82384240a488324b72053352bdf724ed.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c430000d37e0d2a584e8abbc18a26e820.c30767ddca1f9c207888833aea5b5fc61(list, i));
						return result;
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
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47756));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47760) != 0;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000B7148 File Offset: 0x000B5348
		public bool ReceiveItemFromMail(Item item)
		{
			try
			{
				if (item == null)
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
						RuntimeMethodHandle arg_15_0 = methodof(Mail.ReceiveItemFromMail(Item)).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47764));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47768) != 0;
					return result;
				}
				if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47772))
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
					if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47776))
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
						if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47780))
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
							if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47784))
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
								if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47788))
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
									if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47792))
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
										if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47796))
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
											if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47800))
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
												this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47804));
												bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47808) != 0;
												return result;
											}
										}
									}
								}
							}
						}
					}
				}
				if (c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175()) == 0)
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47812));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47816) != 0;
					return result;
				}
				if (c80efb84bd50d5426a024d9bd86574ebe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47820));
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47824) != 0;
					return result;
				}
				byte b = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47828);
				List<Item> list = cb4899d5da4f101706c00e34b82878943.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0());
				Predicate<Item> predicate = c4b3547a7b0fbd7b98187fb4be4551ba8.c8a754f5f2ca4adde825691a9c31a0e83;
				Mail.ccd7efc283c29aab53f870d97b347588f ccd7efc283c29aab53f870d97b347588f = new Mail.ccd7efc283c29aab53f870d97b347588f();
				ccd7efc283c29aab53f870d97b347588f.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47832);
				while ((int)ccd7efc283c29aab53f870d97b347588f.c6a39a3a73f94d8ccf49d40d0ffdd32e3 < c7f0652385ef8939093fc0a0d1bc36723.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
				{
					object arg_236_0 = list;
					if (predicate == null)
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
						predicate = new Predicate<Item>(ccd7efc283c29aab53f870d97b347588f.c04e97eaccc1ae6e9e86d41135cd9c114);
					}
					if (cd774837219cc29e53e06cd2be5f368bb.c30767ddca1f9c207888833aea5b5fc61(arg_236_0, predicate) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47836))
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
						b = ccd7efc283c29aab53f870d97b347588f.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
						IL_29A:
						bool result;
						if ((int)b == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47844))
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
							this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47848));
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47852) != 0);
							return result;
						}
						c9cb6aff8407ea1234ca2cb3f1373a038 c9cb6aff8407ea1234ca2cb3f1373a = new c9cb6aff8407ea1234ca2cb3f1373a038(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c258b58831450321cf2f458005e7e4e21.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), item, b);
						this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47856), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47860));
						this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c9cb6aff8407ea1234ca2cb3f1373a, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47864) != 0);
						result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47868), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47872));
						return result;
					}
					else
					{
						Mail.ccd7efc283c29aab53f870d97b347588f expr_25D = ccd7efc283c29aab53f870d97b347588f;
						expr_25D.c6a39a3a73f94d8ccf49d40d0ffdd32e3 = (byte)((int)expr_25D.c6a39a3a73f94d8ccf49d40d0ffdd32e3 + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47840));
					}
				}
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					goto IL_29A;
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47876));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47880) != 0;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000B74F8 File Offset: 0x000B56F8
		public bool OpenMail()
		{
			try
			{
				bool result;
				if (this.c57fd40f31eac42d57504c30ef6f5d3a5)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Mail.OpenMail()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47884));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47888) != 0);
					return result;
				}
				c5e9894e51bd04887991e70777fe16190 c5e9894e51bd04887991e70777fe = new c5e9894e51bd04887991e70777fe16190(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c258b58831450321cf2f458005e7e4e21.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c80efb84bd50d5426a024d9bd86574ebe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47892), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47896));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c5e9894e51bd04887991e70777fe, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47900) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47904), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47908));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47912));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47916) != 0;
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000B7604 File Offset: 0x000B5804
		public bool ReceiveGoldFromMail()
		{
			try
			{
				bool result;
				if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47920))
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
						RuntimeMethodHandle arg_29_0 = methodof(Mail.ReceiveGoldFromMail()).MethodHandle;
					}
					if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47924))
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
						if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47928))
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
							if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47932))
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
								if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47936))
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
									if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47940))
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
										if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47944))
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
											if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47948))
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
												this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47952));
												result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47956) != 0);
												return result;
											}
										}
									}
								}
							}
						}
					}
				}
				if (cb340687df301e195aba20c00e480a36f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) == (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47960))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47964));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47968) != 0);
					return result;
				}
				if (c80efb84bd50d5426a024d9bd86574ebe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47972));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47976) != 0);
					return result;
				}
				cb79cb357511d0a2f243fb7c29e1f8db8 cb79cb357511d0a2f243fb7c29e1f8db = new cb79cb357511d0a2f243fb7c29e1f8db8(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c258b58831450321cf2f458005e7e4e21.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47980), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47984));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cb79cb357511d0a2f243fb7c29e1f8db, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47988) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47992), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(47996));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48000));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48004) != 0;
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x000B7880 File Offset: 0x000B5A80
		public bool PayMail()
		{
			try
			{
				bool result;
				if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48008))
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
						RuntimeMethodHandle arg_26_0 = methodof(Mail.PayMail()).MethodHandle;
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48012));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48016) != 0);
					return result;
				}
				if (c268112fddd885f910d075011a99622d3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) > c3baabff6530900a0bbfe2871136f9458.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9.get_c7157e643dd9416b76a384422d09d4ab0()))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48020));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48024) != 0);
					return result;
				}
				cf1a6409edd5b47f1521f7c34f8d1e8ec cf1a6409edd5b47f1521f7c34f8d1e8ec = new cf1a6409edd5b47f1521f7c34f8d1e8ec(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c258b58831450321cf2f458005e7e4e21.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48028), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48032));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(cf1a6409edd5b47f1521f7c34f8d1e8ec, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48036) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48040), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48044));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48048));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48052) != 0;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x000B79EC File Offset: 0x000B5BEC
		public bool DeleteMail()
		{
			try
			{
				bool result;
				if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48056))
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
						RuntimeMethodHandle arg_29_0 = methodof(Mail.DeleteMail()).MethodHandle;
					}
					if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48060))
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
						if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48064))
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
							if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48068))
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
								if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48072))
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
									if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48076))
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
										if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48080))
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
											if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48084))
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
												this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48088));
												result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48092) != 0);
												return result;
											}
										}
									}
								}
							}
						}
					}
				}
				if (!c80efb84bd50d5426a024d9bd86574ebe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					if (cb340687df301e195aba20c00e480a36f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) <= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48096))
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
						if (c11c0e341a7e92476498d19dc54a3a399.c30767ddca1f9c207888833aea5b5fc61(this.get_cacbaa35d25d410d86c30b4ae8a318175()) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48100))
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
							if ((int)cb6f2494ffb25b1162fe9bbb63706f1b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48104))
							{
								goto IL_1CB;
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
					}
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48108));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48112) != 0);
					return result;
				}
				IL_1CB:
				c098ba8a79ee94de1948b5b4f3215784b c098ba8a79ee94de1948b5b4f3215784b = new c098ba8a79ee94de1948b5b4f3215784b(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c258b58831450321cf2f458005e7e4e21.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c80efb84bd50d5426a024d9bd86574ebe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48116), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48120));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c098ba8a79ee94de1948b5b4f3215784b, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48124) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48128), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48132));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48136));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48140) != 0;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000B7C90 File Offset: 0x000B5E90
		public bool SendMailBackToSender()
		{
			try
			{
				bool result;
				if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48144))
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
						RuntimeMethodHandle arg_26_0 = methodof(Mail.SendMailBackToSender()).MethodHandle;
					}
					if ((int)ce37e35f86a05ced5306f033a100237f4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) != c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48148))
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
						this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48152));
						result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48156) != 0);
						return result;
					}
				}
				if (cbff4e9ab89f704f019a1f893294f036a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48160));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48164) != 0);
					return result;
				}
				if (c80efb84bd50d5426a024d9bd86574ebe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48168));
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48172) != 0);
					return result;
				}
				c76e911954c30a2b959b4afff726ebbba c76e911954c30a2b959b4afff726ebbba = new c76e911954c30a2b959b4afff726ebbba(this.ca124a9f406cda69b904f2eb04d553ab9.cd958ac3e9f0dffd848ceb278059f50f1, c258b58831450321cf2f458005e7e4e21.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				this.ca124a9f406cda69b904f2eb04d553ab9.c6cbe597a389b63a56e4ea527d70f10c0((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48176), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48180));
				this.ca124a9f406cda69b904f2eb04d553ab9.c61cda994b181065c591c5b765da8c21e(c76e911954c30a2b959b4afff726ebbba, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48184) != 0);
				result = this.ca124a9f406cda69b904f2eb04d553ab9.c031c02051626eec2bd0a7be8c995bc3d((ce348013a8a14a4ee8e9d1fd7158148c0)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48188), (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48192));
				return result;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			this.ca124a9f406cda69b904f2eb04d553ab9.c46ecf2e8a4044502d8dec2676b718b4d((LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48196));
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(48200) != 0;
		}

		// Token: 0x04000EE7 RID: 3815
		internal bool c57fd40f31eac42d57504c30ef6f5d3a5;

		// Token: 0x04000EE8 RID: 3816
		private List<Item> ca39f2e8ca6dda4ec17f3e6ceb08873cd;

		// Token: 0x04000EE9 RID: 3817
		[CompilerGenerated]
		private bool c9aa97f19a227cf0bc875b4ac37ca028b;

		// Token: 0x04000EEA RID: 3818
		[CompilerGenerated]
		private ulong ce364c63865d63db930a6ad51c2666f39;

		// Token: 0x04000EEB RID: 3819
		[CompilerGenerated]
		private ulong c995a8ce4739137868a2371d14ab877b3;

		// Token: 0x04000EEC RID: 3820
		[CompilerGenerated]
		private ulong ca29b82d6883c995dd2fbcd337e1a7a65;

		// Token: 0x04000EED RID: 3821
		[CompilerGenerated]
		private byte cd1003a80dfb360a154ac4c347d0e15b1;

		// Token: 0x04000EEE RID: 3822
		[CompilerGenerated]
		private bool cfbcaf13d310902bb0bf17fb1d14c6c8b;

		// Token: 0x04000EEF RID: 3823
		[CompilerGenerated]
		private byte c8ad178c3ec7a045bdde4b47cb578a632;

		// Token: 0x04000EF0 RID: 3824
		[CompilerGenerated]
		private string ca28abfbf688725510a945f76a5b69880;

		// Token: 0x04000EF1 RID: 3825
		[CompilerGenerated]
		private string cb4b5a979f21752e57d4b2b0a9202f2b7;

		// Token: 0x04000EF2 RID: 3826
		[CompilerGenerated]
		private long c45631f80faf16f17e109958496097e6f;

		// Token: 0x04000EF3 RID: 3827
		[CompilerGenerated]
		private long cc648943962dccb1dd1d617b97da2cd53;

		// Token: 0x04000EF4 RID: 3828
		[CompilerGenerated]
		private string c71f3032e678e6f142efdfb8d89687c88;

		// Token: 0x04000EF5 RID: 3829
		[CompilerGenerated]
		private string c49f7729bf7992fd4eb7e41612d3817b5;

		// Token: 0x04000EF6 RID: 3830
		[CompilerGenerated]
		private byte c1bc4192eba7d21a2474bb06faea0632b;

		// Token: 0x04000EF7 RID: 3831
		[CompilerGenerated]
		private byte c3811e36abe7d765d4d4be899af6a3ec2;

		// Token: 0x04000EF8 RID: 3832
		[CompilerGenerated]
		private ulong c6254229f10526609309cdb049a38b98f;

		// Token: 0x020005A2 RID: 1442
		[CompilerGenerated]
		private sealed class ccd7efc283c29aab53f870d97b347588f
		{
			// Token: 0x06001FC7 RID: 8135 RVA: 0x00148C14 File Offset: 0x00146E14
			public bool c04e97eaccc1ae6e9e86d41135cd9c114(Item item)
			{
				if ((int)cf8438396b9ff16695611b7ce5da482cd.c30767ddca1f9c207888833aea5b5fc61(item) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99104))
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
						RuntimeMethodHandle arg_26_0 = methodof(Mail.ccd7efc283c29aab53f870d97b347588f.c04e97eaccc1ae6e9e86d41135cd9c114(Item)).MethodHandle;
					}
					return ccc55533c89d44981b0bc2fce18a011d2.c30767ddca1f9c207888833aea5b5fc61(item) == this.c6a39a3a73f94d8ccf49d40d0ffdd32e3;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(99108) != 0;
			}

			// Token: 0x04001543 RID: 5443
			public byte c6a39a3a73f94d8ccf49d40d0ffdd32e3;
		}
	}
}
