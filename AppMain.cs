using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows;
using System.Windows.Threading;
using A;
using ArcheBuddy.Bot.Classes;
using ArcheBuddy.SQL;

namespace ArcheBuddy
{
	// Token: 0x02000075 RID: 117
	internal static class AppMain
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00026AF0 File Offset: 0x00024CF0
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00026B04 File Offset: 0x00024D04
		internal static SqlCore sqlcoreRu
		{
			get;
			set;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00026B18 File Offset: 0x00024D18
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00026B2C File Offset: 0x00024D2C
		internal static SqlCore sqlcoreEn
		{
			get;
			set;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00026B40 File Offset: 0x00024D40
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00026B54 File Offset: 0x00024D54
		private static List<CoreInternal> cores
		{
			get;
			set;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00026B68 File Offset: 0x00024D68
		internal static string GetLocalIPAddress()
		{
			IPHostEntry iPHostEntry = c0550461bb5c484aa017696f9a835ed29.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfd3495e57cc750800e40d351707e6249.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			IPAddress[] array = cd0ab4c6ab161c8829c7394d3d3015801.c30767ddca1f9c207888833aea5b5fc61(iPHostEntry);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7880); i < (int)cd9198a0e57c16d34c4a4e752572b2fe5.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7888))
			{
				IPAddress iPAddress = array[i];
				if (c01993bf62ede5407ee2d95cf0699ff01.c30767ddca1f9c207888833aea5b5fc61(iPAddress) == (AddressFamily)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7884))
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
						RuntimeMethodHandle arg_51_0 = methodof(AppMain.GetLocalIPAddress()).MethodHandle;
					}
					return cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(iPAddress);
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
			throw cfe57259e155b3115961b66a3522b0c60.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119365));
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00026C10 File Offset: 0x00024E10
		internal static void AddCore(CoreInternal newCore)
		{
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c261dcc0998b51e15d55dc3e841dcd3c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb()))
			{
				c469571097983048e4e2646ddd1de7b81.c30767ddca1f9c207888833aea5b5fc61(c261dcc0998b51e15d55dc3e841dcd3c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), newCore);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00026C58 File Offset: 0x00024E58
		internal static void RemoveCore(CoreInternal newCore)
		{
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c261dcc0998b51e15d55dc3e841dcd3c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb()))
			{
				cd6dad2569ca8ce497d310c09cad6f2ea.c30767ddca1f9c207888833aea5b5fc61(c261dcc0998b51e15d55dc3e841dcd3c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), newCore);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00026CA4 File Offset: 0x00024EA4
		internal static List<CoreInternal> GetAllCores()
		{
			List<CoreInternal> result;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(c261dcc0998b51e15d55dc3e841dcd3c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb()))
			{
				result = c261dcc0998b51e15d55dc3e841dcd3c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb().ToList<CoreInternal>();
			}
			return result;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00026CF0 File Offset: 0x00024EF0
		[STAThread]
		private static void Main(string[] args)
		{
			c73f6f08831b90454c24cbf8c91778d66.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new ThreadExceptionEventHandler(AppMain.Application_ThreadException));
			c7fc132d37775c8d230eaa214f00f2101.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new UnhandledExceptionEventHandler(AppMain.CurrentDomain_UnhandledException));
			cb9674c52e372103b5fc58751c241f021.c30767ddca1f9c207888833aea5b5fc61(c83cfe3bd000aa92222187ba144960d00.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new DispatcherUnhandledExceptionEventHandler(AppMain.Application_DispatcherUnhandledException));
			cbe96f9f6d9bbc586cc15ca8ad532c36c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfbdfec5afc285015d21f34bdea077a13.c8a754f5f2ca4adde825691a9c31a0e83);
			c8807c32b71230516a28978149d6ed972.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cfbdfec5afc285015d21f34bdea077a13.c8a754f5f2ca4adde825691a9c31a0e83);
			cc4987d6a853db77954f21abe4e42946a.cdc13e3890807a63773b061915e2d9bd2();
			cc4987d6a853db77954f21abe4e42946a.c69648ea5c5277378f12f6248b6682f52();
			cc4987d6a853db77954f21abe4e42946a.c4735049a4440eab94ea362b16eede672();
			if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119420))))
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
					RuntimeMethodHandle arg_A0_0 = methodof(AppMain.Main(string[])).MethodHandle;
				}
				c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119420)));
			}
			if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119437))))
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
				c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119437)));
			}
			if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119472))))
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
				c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119472)));
			}
			if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119487))))
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
				c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119487)));
			}
			if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119498))))
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
				c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119498)));
			}
			if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119515))))
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
				c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119515)));
			}
			if (!c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119532))))
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
				c9af1228cdf2eb4a3c82bce956b7a756e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119532)));
			}
			if (!c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119575))))
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
				StreamWriter streamWriter = cd4e026edf1a93e1569479f90d51a67bf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119575)));
				try
				{
					cf5e5b51f256f33203ad9b05eb281b67b.c30767ddca1f9c207888833aea5b5fc61(streamWriter, ce16b62b317c8b5fb4bafbb8a73c94412.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
				}
				finally
				{
					if (streamWriter != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(streamWriter);
					}
				}
			}
			try
			{
				AppMain.c7e6a76ef4b36ac650a5843777b74f6f5 = new c72d05654ae79127928b430fb7dd5aae2();
				AppMain.cdd1757f475d38dea2e5af9e3fac6be8c = new c3079fa87dcba6f4aea62958e1296385d();
				c3d8f967578bf85017895fa84c61f7f5c.c30767ddca1f9c207888833aea5b5fc61(c83cfe3bd000aa92222187ba144960d00.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), new ExitEventHandler(AppMain.Current_Exit));
				string expr_3B0 = c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
				string expr_3BC = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119636);
				DateTime dateTime = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				AppMain.caf5b572478755944a010f7c71b2242b0 = c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_3B0, expr_3BC, c351608443478d0e98739eb7a532088cb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119669)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119706));
				string expr_3FD = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119715);
				DateTime dateTime2 = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				string expr_40E = c3cd10cb3a20fc8bf611150eeda109c0d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime2);
				string expr_41A = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792);
				DateTime dateTime3 = ceb1c36dfd39283ee9d68423420653fd7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_3FD, expr_40E, expr_41A, c0f2a8b99bad07e422b000ecb6327a3f8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref dateTime3)));
				cbc9911e7863799f661d63344d69c2b3d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7892), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7896));
				c4eca9d59f2288fffa8982b8fbec5e115.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				c6405c5f8b024d2a93888c806f980acd4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7900) != 0);
				AppMain.ca691be15ac02d2fd13604941dfb1f495 = new c378bc83c3b0d1bbdd8b156cfa6c703e8();
				AppMain.ca691be15ac02d2fd13604941dfb1f495.ce6ac48f87055a93676ab57d33bf288af(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119795));
				AppMain.ca691be15ac02d2fd13604941dfb1f495.c58a45b639b317e0e0bf83cd56193185a(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119820));
				AppMain.stealthMode = AppMain.ca691be15ac02d2fd13604941dfb1f495.c40f3f16783aa796be025cad108b28059(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119837), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7904) != 0);
				AppMain.hideLibraryDoors = AppMain.ca691be15ac02d2fd13604941dfb1f495.c40f3f16783aa796be025cad108b28059(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119860), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7908) != 0);
				if (AppMain.stealthMode)
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
					AppMain.c85435ac0da2a74e097537acfaf6abaa8 = cd33f85c3ae5fc6f0de5f0261801c0295.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				}
				c2afa76c7a4b4253c4ca8ddb83a40c9f8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c1cc52d7890eea47e28dd20bc90cac8ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
				AppMain.cea08fbd93ec0aa0f881b5a6cb250260e = new c59974fb8178fc4fbd786e2c0e90d0fa4();
				AppMain.cea08fbd93ec0aa0f881b5a6cb250260e.c6d094dd62646f3d83f8d9b51b8ca99ea();
				cec4dc845e772c3e699a057c528837cac.c06cbb9ffba9f1f61c3573c51aebaa202(c444321925b9d2a874f99531ebc8b8d91.c30767ddca1f9c207888833aea5b5fc61(AppMain.c7e6a76ef4b36ac650a5843777b74f6f5.c6a8c962f987c65c57f616b33871be6bc, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119893)));
				AppMain.c72b8278fe51dea77c32c1ce59211def3 = new c98baf1f37c8505f021dc812520d0af75();
				AppMain.cf90e986fccc09efa49b9af3c2b42eb24 = new cc491258979d33afecac6b4f5b9461a9a();
				AppMain.c5b605be7c0e30dd8340c89173dab77ef = new c6ae055ae3b6973d7fd08ea17d0b90bb4();
				AppMain.c5b605be7c0e30dd8340c89173dab77ef.c5802dd289334c2ca6a250580033a259b();
				cd42d36dd6f379099183ebe4983e29d89.c30767ddca1f9c207888833aea5b5fc61(AppMain.c5b605be7c0e30dd8340c89173dab77ef);
			}
			catch (Exception ex)
			{
				c2e5e290c5e34f024145fe136ad4da993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119914), ex));
				cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7912));
				c09f6fadac8a71c045c787a2424b5e800.c30767ddca1f9c207888833aea5b5fc61(c83cfe3bd000aa92222187ba144960d00.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000272F8 File Offset: 0x000254F8
		private static void Current_Exit(object sender, ExitEventArgs e)
		{
			if (AppMain.ca691be15ac02d2fd13604941dfb1f495 == null)
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
					RuntimeMethodHandle arg_19_0 = methodof(AppMain.Current_Exit(object, ExitEventArgs)).MethodHandle;
				}
				return;
			}
			if (AppMain.c5b605be7c0e30dd8340c89173dab77ef != null)
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
				AppMain.c5b605be7c0e30dd8340c89173dab77ef.c221bef9d1954a5589f79562056592081();
			}
			if (AppMain.c268f1b1716725102a4850ddda960c420 != null)
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
				AppMain.c268f1b1716725102a4850ddda960c420.c221bef9d1954a5589f79562056592081();
			}
			if (AppMain.c1a2627f895092b3cf57a9486ed72ee32 != null)
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
				AppMain.c1a2627f895092b3cf57a9486ed72ee32.c221bef9d1954a5589f79562056592081();
			}
			AppMain.cea08fbd93ec0aa0f881b5a6cb250260e.c212ef59b7bb80a34914095ee6a91b9d1();
			cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7916));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0002738C File Offset: 0x0002558C
		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c2bcc85b6c24f6417b2b1bcda3ce6a755.c30767ddca1f9c207888833aea5b5fc61(e)));
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000273B0 File Offset: 0x000255B0
		internal static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c36a4b4f689a99fd49d0b91b5866cdb24.cea69e7c4d1a729bd5783221de1566e79(cf1ec860a9664571925fd6674ddd88461.c30767ddca1f9c207888833aea5b5fc61(e))));
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000273DC File Offset: 0x000255DC
		private static void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			c8761875271fc238365016dcd30db760f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(cab145485b4a9fc6787971c5807a153c1.c30767ddca1f9c207888833aea5b5fc61(e)));
			c39856ced08fa68c93772a5902b20999e.c30767ddca1f9c207888833aea5b5fc61(e, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7920) != 0);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00027410 File Offset: 0x00025610
		internal static bool CheckIsValidGamePath(string path)
		{
			try
			{
				if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c58db301bc2c1473f78842786d08c62e2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(path), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119975), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7924) != 0) == 0)
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
						RuntimeMethodHandle arg_39_0 = methodof(AppMain.CheckIsValidGamePath(string)).MethodHandle;
					}
					if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(path))
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
						bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7928) != 0;
						return result;
					}
				}
				if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c1655f9905df9d2efe7b0b3bc86e8aff2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(path), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119975), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7932) != 0) == 0)
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
					if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(path))
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
						bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7936) != 0;
						return result;
					}
				}
				if (c80ef1f41706bca8f36e7513ba1cdd363.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(path, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119992))))
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
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7940) != 0;
					return result;
				}
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(path, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119992))))
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
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7944) != 0;
					return result;
				}
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7948) != 0;
		}

		// Token: 0x04000189 RID: 393
		public static bool c8ff8d3e6555c4649df6144c4460067ea;

		// Token: 0x0400018A RID: 394
		public static c6ae055ae3b6973d7fd08ea17d0b90bb4 c5b605be7c0e30dd8340c89173dab77ef;

		// Token: 0x0400018B RID: 395
		public static c378bc83c3b0d1bbdd8b156cfa6c703e8 ca691be15ac02d2fd13604941dfb1f495;

		// Token: 0x0400018C RID: 396
		public static cbf4111912aed594f2b4372828dd95aa3 c412a548ff3bd17cecd4b5e4aef5db3c8;

		// Token: 0x0400018D RID: 397
		public static c6f8ff5d4f5c381e05883cf5979fc7a94 cdf464e19f0e36e472601336aa05e5d18;

		// Token: 0x0400018E RID: 398
		public static c32458c7583da42f5e8c7fad73d962ef3 c268f1b1716725102a4850ddda960c420;

		// Token: 0x0400018F RID: 399
		public static c13e70d9270a291d056ea0a754d36c2e6 c1a2627f895092b3cf57a9486ed72ee32;

		// Token: 0x04000190 RID: 400
		public static c98baf1f37c8505f021dc812520d0af75 c72b8278fe51dea77c32c1ce59211def3;

		// Token: 0x04000191 RID: 401
		public static bool c22db4c407f1a87dea696aa537a24571a = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7952) != 0;

		// Token: 0x04000192 RID: 402
		public static bool c1538447428d3f8d583b849b28e8ee072 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7956) != 0;

		// Token: 0x04000193 RID: 403
		public static string c1713506da7330ce4279cfbade77b3c25 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(120011);

		// Token: 0x04000194 RID: 404
		public static string c85435ac0da2a74e097537acfaf6abaa8 = "";

		// Token: 0x04000195 RID: 405
		public static c3f5c31853c5da0b00584a07669071d47 cefaf2377ddae43302a659b50e17da74a;

		// Token: 0x04000196 RID: 406
		public static c75a8318049f6cd045bfd43b14b535f2c c184a42a74d25a49281e3c84092602419;

		// Token: 0x04000197 RID: 407
		public static c72d05654ae79127928b430fb7dd5aae2 c7e6a76ef4b36ac650a5843777b74f6f5;

		// Token: 0x04000198 RID: 408
		internal static BackgroundWorker c30276a30839273922443b41bcf2c1436;

		// Token: 0x04000199 RID: 409
		public static c59974fb8178fc4fbd786e2c0e90d0fa4 cea08fbd93ec0aa0f881b5a6cb250260e;

		// Token: 0x0400019A RID: 410
		public static cc491258979d33afecac6b4f5b9461a9a cf90e986fccc09efa49b9af3c2b42eb24;

		// Token: 0x0400019B RID: 411
		public static c825e8f7c44b49d205379e993e4ffeec8 c98a5aa50504b412676211d18425b205a;

		// Token: 0x0400019C RID: 412
		public static int c04b99bf26bbb95e9e53ab8d63b1ad4d1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7960);

		// Token: 0x0400019D RID: 413
		public static c5722cd6dea93320ce9fb239a8cb201b9 c607d5034b3f779d08b4b54e06143a574;

		// Token: 0x0400019E RID: 414
		public static string c96816147ff4d2617d3c3ffe7abfc7353 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(120030);

		// Token: 0x0400019F RID: 415
		public static List<string> c171d18a06650cc6b347444a27380b664 = cccd9f3c4e4c1cc78ffc861e0c26c66fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb();

		// Token: 0x040001A0 RID: 416
		public static string caf5b572478755944a010f7c71b2242b0;

		// Token: 0x040001A1 RID: 417
		public static c3079fa87dcba6f4aea62958e1296385d cdd1757f475d38dea2e5af9e3fac6be8c;

		// Token: 0x040001A2 RID: 418
		public static bool stealthMode = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7964) != 0;

		// Token: 0x040001A3 RID: 419
		public static bool hideLibraryDoors = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(7968) != 0;
	}
}
