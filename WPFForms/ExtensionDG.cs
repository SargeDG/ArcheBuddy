using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using A;

namespace ArcheBuddy.WPFForms
{
	// Token: 0x0200011B RID: 283
	public static class ExtensionDG
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x00052B28 File Offset: 0x00050D28
		public static T GetVisualChild<T>(Visual parent) where T : Visual
		{
			T t = default(T);
			int num = c1c1f951827c43edee977e6d5b2675342.c0cf59c3e67a46fd4edb3040c5ab0bbfb(parent);
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(17804); i < num; i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(17808))
			{
				Visual visual = cadd8f14cc814f435e1bc625bf14599a2.c9963fcf210a214a3206d6500f3b9397b(c45795eb6dc51160b40e21cd8f63243af.c0cf59c3e67a46fd4edb3040c5ab0bbfb(parent, i));
				t = (visual as T);
				if (t == null)
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
						RuntimeMethodHandle arg_55_0 = methodof(ExtensionDG.GetVisualChild(Visual)).MethodHandle;
					}
					t = ExtensionDG.GetVisualChild<T>(visual);
				}
				if (t != null)
				{
					return t;
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
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				return t;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00052BC4 File Offset: 0x00050DC4
		public static DataGridRow GetSelectedRow(this DataGrid grid)
		{
			return cf33cc25e8c499cd10a487193fe86edf7.c9963fcf210a214a3206d6500f3b9397b(cf1f59f8ddbd9b68e9b4b7e04c7205ed1.c30767ddca1f9c207888833aea5b5fc61(cd52fe1f26bde3ce0c936becd51ba7ea4.c30767ddca1f9c207888833aea5b5fc61(grid), c4f494e60fea81956c5b4a29993852625.c30767ddca1f9c207888833aea5b5fc61(grid)));
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00052BF0 File Offset: 0x00050DF0
		public static DataGridRow GetRow(this DataGrid grid, int index)
		{
			DataGridRow dataGridRow = cf33cc25e8c499cd10a487193fe86edf7.c9963fcf210a214a3206d6500f3b9397b(c86222d4a8c1970484385435445758ae1.c30767ddca1f9c207888833aea5b5fc61(cd52fe1f26bde3ce0c936becd51ba7ea4.c30767ddca1f9c207888833aea5b5fc61(grid), index));
			if (dataGridRow == null)
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
					RuntimeMethodHandle arg_2D_0 = methodof(DataGrid.GetRow(int)).MethodHandle;
				}
				cd43d93d3363170b555139e4bf1dfb034.c30767ddca1f9c207888833aea5b5fc61(grid);
				c9e24b436763062a058f0f6b459c588c2.c30767ddca1f9c207888833aea5b5fc61(grid, c3980231756d98f77b332e12a7eea1cf0.c30767ddca1f9c207888833aea5b5fc61(cc89d398df51e08fc62962b4f121f9e19.c30767ddca1f9c207888833aea5b5fc61(grid), index));
				dataGridRow = cf33cc25e8c499cd10a487193fe86edf7.c9963fcf210a214a3206d6500f3b9397b(c86222d4a8c1970484385435445758ae1.c30767ddca1f9c207888833aea5b5fc61(cd52fe1f26bde3ce0c936becd51ba7ea4.c30767ddca1f9c207888833aea5b5fc61(grid), index));
			}
			return dataGridRow;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00052C60 File Offset: 0x00050E60
		public static DataGridCell GetCell(this DataGrid grid, DataGridRow row, int column)
		{
			if (row != null)
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
					RuntimeMethodHandle arg_15_0 = methodof(DataGrid.GetCell(DataGridRow, int)).MethodHandle;
				}
				DataGridCellsPresenter visualChild = ExtensionDG.GetVisualChild<DataGridCellsPresenter>(row);
				if (visualChild == null)
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
					c8ed728abab0f544a7d71127d6bd41017.c30767ddca1f9c207888833aea5b5fc61(grid, row, ccea5383b0830bff3d80514c8a33b810a.c30767ddca1f9c207888833aea5b5fc61(c14392e9b8ba7b1a08be3939f4f92133f.c30767ddca1f9c207888833aea5b5fc61(grid), column));
					visualChild = ExtensionDG.GetVisualChild<DataGridCellsPresenter>(row);
				}
				return c3974ddce3d86e4825fdbccdea67eac74.c9963fcf210a214a3206d6500f3b9397b(c86222d4a8c1970484385435445758ae1.c30767ddca1f9c207888833aea5b5fc61(cd52fe1f26bde3ce0c936becd51ba7ea4.c30767ddca1f9c207888833aea5b5fc61(visualChild), column));
			}
			return null;
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00052CD4 File Offset: 0x00050ED4
		public static DataGridCell GetCell(this DataGrid grid, int row, int column)
		{
			DataGridRow dataGridRow = c1c8257c1429b9085fba1f4bfd72b9da9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(grid, row);
			return c5e07e23461ad6fd47f29f866cc37bd1e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(grid, dataGridRow, column);
		}
	}
}
