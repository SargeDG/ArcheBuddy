using System;
using System.Windows;
using System.Windows.Controls;
using A;

namespace Selen.Wpf.SystemStyles.Actions
{
	// Token: 0x02000014 RID: 20
	public class MyTabItem : TabItem
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00010840 File Offset: 0x0000EA40
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00010864 File Offset: 0x0000EA64
		public bool CloseButtonEnabled
		{
			get
			{
				return c9d2b1209aa31568f202b6352fc1e1f97.cc6a9c540a2ed5763275f32ba91c9e97b(c5903f3e0d8e5abed6b0f0db6dcb4d928.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, MyTabItem.CloseButtonEnabledProperty));
			}
			set
			{
				ce30c8960dae6730abf46b2b6d7962877.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, MyTabItem.CloseButtonEnabledProperty, value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600007C RID: 124 RVA: 0x00010884 File Offset: 0x0000EA84
		// (remove) Token: 0x0600007D RID: 125 RVA: 0x000108A0 File Offset: 0x0000EAA0
		public event RoutedEventHandler OnClose
		{
			add
			{
				c7d3944cf50c7330c646a0da9b04e4884.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, MyTabItem.OnCloseEvent, value);
			}
			remove
			{
				c6d3bc2eda72795589a8e4a1260ab89ea.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, MyTabItem.OnCloseEvent, value);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000108BC File Offset: 0x0000EABC
		public void RaiseOnClose()
		{
			RoutedEventArgs routedEventArgs = c46084c3ac809b51c2e15074607e18483.c0cf59c3e67a46fd4edb3040c5ab0bbfb(MyTabItem.OnCloseEvent);
			c8c3e5aa158c53a22069493658cab0372.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, routedEventArgs);
		}

		// Token: 0x04000034 RID: 52
		public static readonly DependencyProperty CloseButtonEnabledProperty = c71b74b8efe7633a024c529e6c2dc6536.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33451), c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc6c7c773482a9dec8e5071a0d563f4bc.cbac80c0356856482e0a93eed1c1fdf4f()), c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbafeee3b42f2accb545e183aca59f676.cbac80c0356856482e0a93eed1c1fdf4f()), cd1cf549c29c508f84ec6c13a8e89f2d1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2196) != 0));

		// Token: 0x04000035 RID: 53
		public static readonly RoutedEvent OnCloseEvent = c199db060e3ba10007e12fd91ee15f2e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33488), (RoutingStrategy)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2200), c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c30759205ee68ac1acb5a88d5604275f7.cbac80c0356856482e0a93eed1c1fdf4f()), c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cbafeee3b42f2accb545e183aca59f676.cbac80c0356856482e0a93eed1c1fdf4f()));
	}
}
