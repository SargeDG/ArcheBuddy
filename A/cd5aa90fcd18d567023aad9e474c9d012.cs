using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A
{
	// Token: 0x02000030 RID: 48
	internal sealed class cd5aa90fcd18d567023aad9e474c9d012
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00013564 File Offset: 0x00011764
		static cd5aa90fcd18d567023aad9e474c9d012()
		{
			if (Type.GetTypeFromHandle(cc06e16fcf33c774e3924dcb0efc3ebff.cbac80c0356856482e0a93eed1c1fdf4f()) != null)
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
					RuntimeMethodHandle arg_22_0 = methodof(cd5aa90fcd18d567023aad9e474c9d012..cctor()).MethodHandle;
				}
				cd5aa90fcd18d567023aad9e474c9d012.c0481708c89bfd8966846e99396f607e5 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000135C4 File Offset: 0x000117C4
		public static void c28f89b549b0721b6db43243f02d3be65(int typeToken, int methodToken, int num)
		{
			Type typeFromHandle;
			ConstructorInfo constructorInfo;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(cd5aa90fcd18d567023aad9e474c9d012.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(typeToken));
				object methodFromHandle;
				if (num == 16777215)
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
						RuntimeMethodHandle arg_33_0 = methodof(cd5aa90fcd18d567023aad9e474c9d012.c28f89b549b0721b6db43243f02d3be65(int, int, int)).MethodHandle;
					}
					methodFromHandle = MethodBase.GetMethodFromHandle(cd5aa90fcd18d567023aad9e474c9d012.c0481708c89bfd8966846e99396f607e5.ResolveMethodHandle(methodToken));
				}
				else
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(cd5aa90fcd18d567023aad9e474c9d012.c0481708c89bfd8966846e99396f607e5.ResolveMethodHandle(methodToken), cd5aa90fcd18d567023aad9e474c9d012.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(num));
				}
				constructorInfo = ca0a8184c901e5fd4c94dc7a3b5cc3c22.c9963fcf210a214a3206d6500f3b9397b(methodFromHandle);
			}
			catch (Exception)
			{
				throw;
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int i = 0; i < (int)ce91cd4fecc4cea65e47c19367da31ed1.cc0906fa561b9c6076f6cb6643cecb5e3(fields); i++)
			{
				FieldInfo fieldInfo = fields[i];
				try
				{
					ParameterInfo[] parameters = constructorInfo.GetParameters();
					int num2 = (int)c005455c72e24757e06ee7dc118e1e8db.cc0906fa561b9c6076f6cb6643cecb5e3(parameters);
					Type[] array = cb2313226132631ae148a589a6055fc83.ce8915750eb2dc86a075214c6cf229baa(num2);
					for (int j = 0; j < num2; j++)
					{
						array[j] = parameters[j].ParameterType;
					}
					while (true)
					{
						switch (1)
						{
						case 0:
							continue;
						}
						break;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, constructorInfo.DeclaringType, array, typeFromHandle, true);
					ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
					if (num2 > 0)
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
						iLGenerator.Emit(OpCodes.Ldarg_0);
					}
					if (num2 > 1)
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
						iLGenerator.Emit(OpCodes.Ldarg_1);
					}
					if (num2 > 2)
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
						iLGenerator.Emit(OpCodes.Ldarg_2);
					}
					if (num2 > 3)
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
						iLGenerator.Emit(OpCodes.Ldarg_3);
					}
					if (num2 > 4)
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
						for (int k = 4; k < num2; k++)
						{
							iLGenerator.Emit(OpCodes.Ldarg_S, k);
						}
						while (true)
						{
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Newobj, constructorInfo);
					iLGenerator.Emit(OpCodes.Ret);
					Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
			}
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
		}

		// Token: 0x04000088 RID: 136
		private static readonly int c0ba91563d7e6b49e54723de1b4ab42db;

		// Token: 0x04000089 RID: 137
		private static readonly int c854250af14a375ca2fed9dcbffcc18b0;

		// Token: 0x0400008A RID: 138
		private static readonly int cdc714272c788679c6f6ef0c67d1b9266;

		// Token: 0x0400008B RID: 139
		private static readonly int c049d60d5b5c3a4a6f3a9cdce87e38d45;

		// Token: 0x0400008C RID: 140
		private static readonly int ce1823a14e23f029ffec8f9579b9334bd;

		// Token: 0x0400008D RID: 141
		private static readonly int caf0a71476df9a52ccadd0f46292a1a7d;

		// Token: 0x0400008E RID: 142
		private static readonly int ccec18ad15d38fac5d2eef5b317da0433;

		// Token: 0x0400008F RID: 143
		private static readonly int cab5f1cefb0f5afda5fc2266d8a61b0f1;

		// Token: 0x04000090 RID: 144
		private static readonly int c8c77df07950d4a06dd6f3fe55429aa16;

		// Token: 0x04000091 RID: 145
		private static readonly int c7ddb6a09b04ad4e17e328bbbeeb25386;

		// Token: 0x04000092 RID: 146
		private static readonly int c2d96ec6124714e816dc5ba7997d0bed0;

		// Token: 0x04000093 RID: 147
		private static readonly int c50c2b08dd6851d0f063c61d5f3cb9399;

		// Token: 0x04000094 RID: 148
		private static readonly int c4772961882315d57b8f4e56ab5885294;

		// Token: 0x04000095 RID: 149
		private static readonly int c021c01bb3eb4bd26505e931df8c61a0e;

		// Token: 0x04000096 RID: 150
		private static readonly int cf20ad1b714a80c44f0081ebd9e107f60;

		// Token: 0x04000097 RID: 151
		private static readonly int c3dfe258aabc0b40bbbcb0078b3f844b9;

		// Token: 0x04000098 RID: 152
		private static readonly int cdfb70c6886c8d6bd08a95a64437aea9c;

		// Token: 0x04000099 RID: 153
		private static readonly int c3781a336d8aea43aae979372fffdd4d8;

		// Token: 0x0400009A RID: 154
		private static readonly int c43c9cd3c4d4d51233229c7dba82ea91d;

		// Token: 0x0400009B RID: 155
		private static readonly int c42065e5d82f8294274c1366748811874;

		// Token: 0x0400009C RID: 156
		private static readonly ModuleHandle c0481708c89bfd8966846e99396f607e5;
	}
}
