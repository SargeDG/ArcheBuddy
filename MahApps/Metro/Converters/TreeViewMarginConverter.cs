using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using A;

namespace MahApps.Metro.Converters
{
	// Token: 0x02000031 RID: 49
	public class TreeViewMarginConverter : IValueConverter
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00013828 File Offset: 0x00011A28
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0001383C File Offset: 0x00011A3C
		public double Length
		{
			get;
			set;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00013850 File Offset: 0x00011A50
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			TreeViewItem treeViewItem = c274e44e167d08d0d3dfa42dda0d4bd62.cea69e7c4d1a729bd5783221de1566e79(value);
			if (treeViewItem == null)
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
					RuntimeMethodHandle arg_1E_0 = methodof(TreeViewMarginConverter.Convert(object, Type, object, CultureInfo)).MethodHandle;
				}
				return new Thickness(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2732));
			}
			return new Thickness(ceb58bfc8a0259b640fa744ea43f1670c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this) * (double)c3fc77641ada1486d90cb5c0584f8daaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(treeViewItem), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2740), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2748), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(2756));
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000138D4 File Offset: 0x00011AD4
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return DependencyProperty.UnsetValue;
		}

		// Token: 0x0400009D RID: 157
		[CompilerGenerated]
		private double c35427a7601b687c2d302511d96de1377;
	}
}
