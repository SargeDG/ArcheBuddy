using System;
using System.Reflection;

namespace A
{
	// Token: 0x02000017 RID: 23
	internal sealed class c8197f8e387fe47b0841dd117793a34b2 : MarshalByRefObject
	{
		// Token: 0x0600008E RID: 142 RVA: 0x00010FC0 File Offset: 0x0000F1C0
		public bool c7497aeac32420824808c0fc300a07006(string text, Type type)
		{
			bool result;
			try
			{
				Assembly assembly = ccdb245cb86430846636589b6c7c76008.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text);
				Type[] array = c66d5244cb2330cee71cf5f779fd627e5.c30767ddca1f9c207888833aea5b5fc61(assembly);
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2204); i < (int)cc1ddd8c8507b7a6252f5a4ae4abe84db.cc0906fa561b9c6076f6cb6643cecb5e3(array); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2212))
				{
					if (!c19a2afc683ac3fb37b9a29b5fef0aa3a.c30767ddca1f9c207888833aea5b5fc61(array[i]))
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
							RuntimeMethodHandle arg_43_0 = methodof(c8197f8e387fe47b0841dd117793a34b2.c7497aeac32420824808c0fc300a07006(string, Type)).MethodHandle;
						}
						if (!cdefce1ad4ecc45041a60b7d288ae36bf.c30767ddca1f9c207888833aea5b5fc61(array[i]))
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
							if (c6fcf65f4d32afb7fca736f2f6a8b182b.c30767ddca1f9c207888833aea5b5fc61(array[i], type))
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
								MethodInfo methodInfo = ca04d7eb394b092826e5a0c49d44009e8.c30767ddca1f9c207888833aea5b5fc61(array[i], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33539));
								if (c8200be59554d5602fa580635c1e81d13.c0cf59c3e67a46fd4edb3040c5ab0bbfb(methodInfo, c1de0a6423204725d1d8e4dab4ae56fd1.c8a754f5f2ca4adde825691a9c31a0e83))
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
									result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2208) != 0);
									return result;
								}
							}
						}
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
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2216) != 0);
			}
			catch (Exception)
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(2220) != 0);
			}
			return result;
		}
	}
}
