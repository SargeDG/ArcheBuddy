using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Media.Imaging;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.WPFForms
{
	// Token: 0x02000127 RID: 295
	[DataContract(Name = "PluginInfoDataGrid")]
	internal sealed class PluginInfoDataGrid : INotifyPropertyChanged
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00054EF0 File Offset: 0x000530F0
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00054F04 File Offset: 0x00053104
		public BitmapImage CellImage
		{
			get
			{
				return this.c6db656cbf80d920b58c784ac53b581f3;
			}
			set
			{
				this.c6db656cbf80d920b58c784ac53b581f3 = value;
				this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153605));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00054F2C File Offset: 0x0005312C
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x00054F40 File Offset: 0x00053140
		public byte run
		{
			get
			{
				return this.ce935b8f23933d7856b99ad66e2c8d702;
			}
			set
			{
				this.ce935b8f23933d7856b99ad66e2c8d702 = value;
				if (this.ce935b8f23933d7856b99ad66e2c8d702 == 0)
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
						RuntimeMethodHandle arg_21_0 = methodof(PluginInfoDataGrid.set_run(byte)).MethodHandle;
					}
					c9de436feac322977f7b34a7e95f2ee22.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8.cd3c715e925438a82244546a84bd24ade);
				}
				else if ((int)this.ce935b8f23933d7856b99ad66e2c8d702 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18084))
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
					c9de436feac322977f7b34a7e95f2ee22.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8.c07a8d858e311edb907a0f502c43ccf29);
				}
				else if ((int)this.ce935b8f23933d7856b99ad66e2c8d702 == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18088))
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
					c9de436feac322977f7b34a7e95f2ee22.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, AppMain.c412a548ff3bd17cecd4b5e4aef5db3c8.ce89a1360461e96761b4795a70dac68e0);
				}
				this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153624));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00054FF0 File Offset: 0x000531F0
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x00055004 File Offset: 0x00053204
		[DataMember(Name = "pluginPath")]
		public string pluginPath
		{
			get
			{
				return this.c3b2428e366a7d45d91d47cfbea6e82ac;
			}
			set
			{
				if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(value, this.c3b2428e366a7d45d91d47cfbea6e82ac))
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
						RuntimeMethodHandle arg_22_0 = methodof(PluginInfoDataGrid.set_pluginPath(string)).MethodHandle;
					}
					this.c3b2428e366a7d45d91d47cfbea6e82ac = value;
					this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153631));
				}
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00055050 File Offset: 0x00053250
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x00055064 File Offset: 0x00053264
		[DataMember(Name = "autoRun")]
		public bool autoRun
		{
			get
			{
				return this.c3d25de7239e9a03c1b192afbef31ce87;
			}
			set
			{
				if (value != this.c3d25de7239e9a03c1b192afbef31ce87)
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
						RuntimeMethodHandle arg_1B_0 = methodof(PluginInfoDataGrid.set_autoRun(bool)).MethodHandle;
					}
					this.c3d25de7239e9a03c1b192afbef31ce87 = value;
					this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153652));
				}
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000A12 RID: 2578 RVA: 0x000550A8 File Offset: 0x000532A8
		// (remove) Token: 0x06000A13 RID: 2579 RVA: 0x000550F8 File Offset: 0x000532F8
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
					RuntimeMethodHandle arg_40_0 = methodof(PluginInfoDataGrid.add_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
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
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_40_0 = methodof(PluginInfoDataGrid.remove_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00055148 File Offset: 0x00053348
		private void c80d9066c32dd4117d011f35e604328cd([CallerMemberName] string text = "")
		{
			if (this.c9cc4c6525a1deeb4b41a42108a961a8c != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(PluginInfoDataGrid.c80d9066c32dd4117d011f35e604328cd(string)).MethodHandle;
				}
				c1f77d3d1b6b6a1f9b2daed6750ad058d.c30767ddca1f9c207888833aea5b5fc61(this.c9cc4c6525a1deeb4b41a42108a961a8c, this, c399838ea944bd862153cae875399aeb1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text));
				if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153652), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18092) != 0) == 0)
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
					if (this.caa24630339480a12d11d102ecf4aa8a6 != null)
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
						this.caa24630339480a12d11d102ecf4aa8a6.c2e6a8924747457b14da4160e19501954(this.c74e98237df2c01aebcb58e62b7657a32);
					}
				}
			}
		}

		// Token: 0x040005B4 RID: 1460
		private BitmapImage c6db656cbf80d920b58c784ac53b581f3;

		// Token: 0x040005B5 RID: 1461
		private byte ce935b8f23933d7856b99ad66e2c8d702;

		// Token: 0x040005B6 RID: 1462
		private string c3b2428e366a7d45d91d47cfbea6e82ac = string.Empty;

		// Token: 0x040005B7 RID: 1463
		private bool c3d25de7239e9a03c1b192afbef31ce87;

		// Token: 0x040005B8 RID: 1464
		internal c7dc17732552df75e0d5ae7c3a0073a40 caa24630339480a12d11d102ecf4aa8a6;

		// Token: 0x040005B9 RID: 1465
		internal bool c120a76db91f7ca7eaf3a592702bd8b58;

		// Token: 0x040005BA RID: 1466
		internal Core c9dfc5b53e96e74107a360b871efedc7f;

		// Token: 0x040005BB RID: 1467
		internal ObservableCollection<PluginInfoDataGrid> c74e98237df2c01aebcb58e62b7657a32;

		// Token: 0x040005BC RID: 1468
		private PropertyChangedEventHandler c9cc4c6525a1deeb4b41a42108a961a8c;
	}
}
