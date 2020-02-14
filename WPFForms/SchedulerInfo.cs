using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using A;

namespace ArcheBuddy.WPFForms
{
	// Token: 0x02000126 RID: 294
	public class SchedulerInfo : INotifyPropertyChanged
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00054BC4 File Offset: 0x00052DC4
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x00054BD8 File Offset: 0x00052DD8
		internal cc401045b2d3a107c5397ce08b50b21f0 db
		{
			get;
			set;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x00054BEC File Offset: 0x00052DEC
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x00054C00 File Offset: 0x00052E00
		internal ca0c9ecd43ccad62ae7ac89ac45149827 sqlAccManager
		{
			get;
			set;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00054C14 File Offset: 0x00052E14
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00054C28 File Offset: 0x00052E28
		public bool needUpdate
		{
			get
			{
				return this.cfd4d0c8dd690c7cf44e3a534c44c1e8d;
			}
			set
			{
				if (value != this.cfd4d0c8dd690c7cf44e3a534c44c1e8d)
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
						RuntimeMethodHandle arg_1B_0 = methodof(SchedulerInfo.set_needUpdate(bool)).MethodHandle;
					}
					this.cfd4d0c8dd690c7cf44e3a534c44c1e8d = value;
					if (this.cfd4d0c8dd690c7cf44e3a534c44c1e8d)
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
						using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c88bb72e11f2edffb262d6c1220a86abe))
						{
							c8e74ad459269e0ce9b01801c1d97fcf0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).c3ca2eac53f79219b523473338b50b5e3(c7853f01ea94b40c4eb896ced9491f244.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
							this.cfd4d0c8dd690c7cf44e3a534c44c1e8d = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18076) != 0);
						}
					}
				}
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00054CC0 File Offset: 0x00052EC0
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00054CD4 File Offset: 0x00052ED4
		public bool enabled
		{
			get
			{
				return this.cc19067b544bb83df1f41859b6b1dd828;
			}
			set
			{
				if (value != this.cc19067b544bb83df1f41859b6b1dd828)
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
						RuntimeMethodHandle arg_1B_0 = methodof(SchedulerInfo.set_enabled(bool)).MethodHandle;
					}
					this.cc19067b544bb83df1f41859b6b1dd828 = value;
					c7853f01ea94b40c4eb896ced9491f244.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this).c60c0eb2e26a4f9af0ed98ae796effea1 = value;
					this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152587));
					c8161a528556ca1d1883ca15bd98c545a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(18080) != 0);
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00054D34 File Offset: 0x00052F34
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00054D48 File Offset: 0x00052F48
		public string day
		{
			get
			{
				return this.cb2fbda9a5f57189e88ca2c01718b4074;
			}
			set
			{
				if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(value, this.cb2fbda9a5f57189e88ca2c01718b4074))
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
						RuntimeMethodHandle arg_22_0 = methodof(SchedulerInfo.set_day(string)).MethodHandle;
					}
					this.cb2fbda9a5f57189e88ca2c01718b4074 = value;
					this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153581));
				}
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00054D94 File Offset: 0x00052F94
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00054DA8 File Offset: 0x00052FA8
		public string workTime
		{
			get
			{
				return this.cb88abb246b92b77a857bb37799f71d44;
			}
			set
			{
				if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(value, this.cb88abb246b92b77a857bb37799f71d44))
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
						RuntimeMethodHandle arg_22_0 = methodof(SchedulerInfo.set_workTime(string)).MethodHandle;
					}
					this.cb88abb246b92b77a857bb37799f71d44 = value;
					this.c80d9066c32dd4117d011f35e604328cd(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(153588));
				}
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000A06 RID: 2566 RVA: 0x00054DF4 File Offset: 0x00052FF4
		// (remove) Token: 0x06000A07 RID: 2567 RVA: 0x00054E44 File Offset: 0x00053044
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
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_40_0 = methodof(SchedulerInfo.add_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
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
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_40_0 = methodof(SchedulerInfo.remove_PropertyChanged(PropertyChangedEventHandler)).MethodHandle;
				}
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00054E94 File Offset: 0x00053094
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
					RuntimeMethodHandle arg_1A_0 = methodof(SchedulerInfo.c80d9066c32dd4117d011f35e604328cd(string)).MethodHandle;
				}
				c1f77d3d1b6b6a1f9b2daed6750ad058d.c30767ddca1f9c207888833aea5b5fc61(this.c9cc4c6525a1deeb4b41a42108a961a8c, this, c399838ea944bd862153cae875399aeb1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text));
			}
		}

		// Token: 0x040005AC RID: 1452
		private bool cc19067b544bb83df1f41859b6b1dd828;

		// Token: 0x040005AD RID: 1453
		private string cb2fbda9a5f57189e88ca2c01718b4074 = "";

		// Token: 0x040005AE RID: 1454
		private string cb88abb246b92b77a857bb37799f71d44 = "";

		// Token: 0x040005AF RID: 1455
		internal bool cfd4d0c8dd690c7cf44e3a534c44c1e8d;

		// Token: 0x040005B0 RID: 1456
		internal object c88bb72e11f2edffb262d6c1220a86abe = new object();

		// Token: 0x040005B1 RID: 1457
		private PropertyChangedEventHandler c9cc4c6525a1deeb4b41a42108a961a8c;

		// Token: 0x040005B2 RID: 1458
		[CompilerGenerated]
		private cc401045b2d3a107c5397ce08b50b21f0 cc2bcffe3af6b9ca90f5a2b25172010a9;

		// Token: 0x040005B3 RID: 1459
		[CompilerGenerated]
		private ca0c9ecd43ccad62ae7ac89ac45149827 c8e67c0f7522a604c140d087442b4eafc;
	}
}
