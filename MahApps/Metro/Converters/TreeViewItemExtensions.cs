using System;
using System.Windows;
using System.Windows.Controls;
using A;

namespace MahApps.Metro.Converters
{
	// Token: 0x02000033 RID: 51
	public static class TreeViewItemExtensions
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00013BA8 File Offset: 0x00011DA8
		public static int gGetDepth(this TreeViewItem item)
		{
			TreeViewItem treeViewItem;
			if ((treeViewItem = c7a9fad8c93eece1da47dcc61f1f272da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(item)) == null)
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
					RuntimeMethodHandle arg_34_0 = methodof(TreeViewItem.gGetDepth()).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2768);
			}
			return c3fc77641ada1486d90cb5c0584f8daaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(treeViewItem) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2764);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00013BF4 File Offset: 0x00011DF4
		private static TreeViewItem GetParent(TreeViewItem item)
		{
			DependencyObject arg_25_0;
			if (item == null)
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
					RuntimeMethodHandle arg_15_0 = methodof(TreeViewItemExtensions.GetParent(TreeViewItem)).MethodHandle;
				}
				arg_25_0 = c41720594aedc46453c257a6fd4d94b08.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			else
			{
				arg_25_0 = cd215bf7f948ab89e9131c53379901862.c0cf59c3e67a46fd4edb3040c5ab0bbfb(item);
			}
			DependencyObject dependencyObject = arg_25_0;
			while (dependencyObject != null)
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
				if (c274e44e167d08d0d3dfa42dda0d4bd62.cea69e7c4d1a729bd5783221de1566e79(dependencyObject) != null)
				{
					break;
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
				if (c6b33c6e01ee41bdabc53ae19b9a4047c.cea69e7c4d1a729bd5783221de1566e79(dependencyObject) != null)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						goto IL_66;
					}
				}
				else
				{
					dependencyObject = cd215bf7f948ab89e9131c53379901862.c0cf59c3e67a46fd4edb3040c5ab0bbfb(dependencyObject);
				}
			}
			IL_66:
			return c274e44e167d08d0d3dfa42dda0d4bd62.cea69e7c4d1a729bd5783221de1566e79(dependencyObject);
		}
	}
}
