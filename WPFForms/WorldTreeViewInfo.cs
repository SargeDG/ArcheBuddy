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
	// Token: 0x02000125 RID: 293
	[DataContract(Name = "WorldTreeViewInfo")]
	internal sealed class WorldTreeViewInfo : INotifyPropertyChanged
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x000549DC File Offset: 0x00052BDC
		public WorldTreeViewInfo(string text)
		{
			c86f0e959b11bc14e21d234c46cc4e522.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, text);
			c0645beedb7d8c786fff306e018947516.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, (Visibility)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18072));
			c35d7f64d79944ff0613988579a1e43c7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new ObservableCollection<ServerTreeViewInfo>());
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00054A14 File Offset: 0x00052C14
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00054A28 File Offset: 0x00052C28
		public ObservableCollection<ServerTreeViewInfo> Servers
		{
			get;
			set;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00054A3C File Offset: 0x00052C3C
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00054A50 File Offset: 0x00052C50
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

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00054A78 File Offset: 0x00052C78
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00054A8C File Offset: 0x00052C8C
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

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060009F6 RID: 2550 RVA: 0x00054AB4 File Offset: 0x00052CB4
		// (remove) Token: 0x060009F7 RID: 2551 RVA: 0x00054B04 File Offset: 0x00052D04
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
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_40_0 = methodof(WorldTreeViewInfo.add_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
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
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_40_0 = methodof(WorldTreeViewInfo.remove_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00054B54 File Offset: 0x00052D54
		private void c80d9066c32dd4117d011f35e604328cd([CallerMemberName] string text = "")
		{
			if (this.c9cc4c6525a1deeb4b41a42108a961a8c != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(WorldTreeViewInfo.c80d9066c32dd4117d011f35e604328cd(string)).MethodHandle;
				}
				c1f77d3d1b6b6a1f9b2daed6750ad058d.c30767ddca1f9c207888833aea5b5fc61(this.c9cc4c6525a1deeb4b41a42108a961a8c, this, c399838ea944bd862153cae875399aeb1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text));
			}
		}

		// Token: 0x040005A8 RID: 1448
		private string c104d74d1f30766e5028718658e5fa7e1;

		// Token: 0x040005A9 RID: 1449
		private Visibility c9ead4f98de0d6d543180a174b98103b1;

		// Token: 0x040005AA RID: 1450
		private PropertyChangedEventHandler c9cc4c6525a1deeb4b41a42108a961a8c;

		// Token: 0x040005AB RID: 1451
		[CompilerGenerated]
		private ObservableCollection<ServerTreeViewInfo> c8c51ce2ea97d7469f4b87445f1134759;
	}
}
