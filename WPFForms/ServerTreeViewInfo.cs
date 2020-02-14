using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows;
using A;

namespace ArcheBuddy.WPFForms
{
	// Token: 0x02000124 RID: 292
	[DataContract(Name = "ServerTreeViewInfo")]
	internal sealed class ServerTreeViewInfo : INotifyPropertyChanged
	{
		// Token: 0x060009E5 RID: 2533 RVA: 0x00054824 File Offset: 0x00052A24
		public ServerTreeViewInfo(string text, byte b)
		{
			c625b0baf237911420a99da08b58443d5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, text);
			this.cb5905b594e11dea2f73932df05981674 = b;
			c18be52117135d780892993abcc9082dd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18068));
			c23f147665e3d2c349eebb798e9d05381.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new ObservableCollection<AccTreeViewInfo>());
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00054860 File Offset: 0x00052A60
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00054874 File Offset: 0x00052A74
		public ObservableCollection<AccTreeViewInfo> Accounts
		{
			get;
			set;
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00054888 File Offset: 0x00052A88
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x0005489C File Offset: 0x00052A9C
		public Visibility visibility
		{
			get
			{
				return this.c9ead4f98de0d6d543180a174b98103b1;
			}
			set
			{
				this.c9ead4f98de0d6d543180a174b98103b1 = value;
				this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153508));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000548C4 File Offset: 0x00052AC4
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x000548D8 File Offset: 0x00052AD8
		public string name
		{
			get
			{
				return this.c104d74d1f30766e5028718658e5fa7e1;
			}
			set
			{
				this.c104d74d1f30766e5028718658e5fa7e1 = value;
				this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153499));
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060009EC RID: 2540 RVA: 0x00054900 File Offset: 0x00052B00
		// (remove) Token: 0x060009ED RID: 2541 RVA: 0x00054950 File Offset: 0x00052B50
		public event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.c9cc4c6525a1deeb4b41a42108a961a8c;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = c929553a749cdecf936bb542ed13971ca.c9963fcf210a214a3206d6500f3b9397b(c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(propertyChangedEventHandler2, value));
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.c9cc4c6525a1deeb4b41a42108a961a8c, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
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
					RuntimeMethodHandle arg_40_0 = methodof(ServerTreeViewInfo.add_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
				}
			}
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.c9cc4c6525a1deeb4b41a42108a961a8c;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = c929553a749cdecf936bb542ed13971ca.c9963fcf210a214a3206d6500f3b9397b(cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(propertyChangedEventHandler2, value));
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.c9cc4c6525a1deeb4b41a42108a961a8c, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
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
					RuntimeMethodHandle arg_40_0 = methodof(ServerTreeViewInfo.remove_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000549A0 File Offset: 0x00052BA0
		private void c80d9066c32dd4117d011f35e604328cd([CallerMemberName] string text = "")
		{
			if (this.c9cc4c6525a1deeb4b41a42108a961a8c != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(ServerTreeViewInfo.c80d9066c32dd4117d011f35e604328cd(string)).MethodHandle;
				}
				c1f77d3d1b6b6a1f9b2daed6750ad058d.c30767ddca1f9c207888833aea5b5fc61(this.c9cc4c6525a1deeb4b41a42108a961a8c, this, c399838ea944bd862153cae875399aeb1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text));
			}
		}

		// Token: 0x040005A3 RID: 1443
		private string c104d74d1f30766e5028718658e5fa7e1;

		// Token: 0x040005A4 RID: 1444
		public byte cb5905b594e11dea2f73932df05981674;

		// Token: 0x040005A5 RID: 1445
		private Visibility c9ead4f98de0d6d543180a174b98103b1;

		// Token: 0x040005A6 RID: 1446
		private PropertyChangedEventHandler c9cc4c6525a1deeb4b41a42108a961a8c;

		// Token: 0x040005A7 RID: 1447
		[CompilerGenerated]
		private ObservableCollection<AccTreeViewInfo> cdcd46f19d3f8756ca6785a6f331881ff;
	}
}
