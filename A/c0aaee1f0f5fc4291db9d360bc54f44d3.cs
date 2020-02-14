using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A
{
	// Token: 0x02000032 RID: 50
	internal sealed class c0aaee1f0f5fc4291db9d360bc54f44d3
	{
		// Token: 0x06000106 RID: 262 RVA: 0x000138E8 File Offset: 0x00011AE8
		static c0aaee1f0f5fc4291db9d360bc54f44d3()
		{
			if (Type.GetTypeFromHandle(cc06e16fcf33c774e3924dcb0efc3ebff.cbac80c0356856482e0a93eed1c1fdf4f()) != null)
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
					RuntimeMethodHandle arg_22_0 = methodof(c0aaee1f0f5fc4291db9d360bc54f44d3..cctor()).MethodHandle;
				}
				c0aaee1f0f5fc4291db9d360bc54f44d3.c0481708c89bfd8966846e99396f607e5 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00013948 File Offset: 0x00011B48
		public static void c28f89b549b0721b6db43243f02d3be65(int typeToken, int methodToken, int num)
		{
			Type typeFromHandle;
			ConstructorInfo constructorInfo;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(c0aaee1f0f5fc4291db9d360bc54f44d3.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(typeToken));
				object methodFromHandle;
				if (num == 16777215)
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
						RuntimeMethodHandle arg_33_0 = methodof(c0aaee1f0f5fc4291db9d360bc54f44d3.c28f89b549b0721b6db43243f02d3be65(int, int, int)).MethodHandle;
					}
					methodFromHandle = MethodBase.GetMethodFromHandle(c0aaee1f0f5fc4291db9d360bc54f44d3.c0481708c89bfd8966846e99396f607e5.ResolveMethodHandle(methodToken));
				}
				else
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(c0aaee1f0f5fc4291db9d360bc54f44d3.c0481708c89bfd8966846e99396f607e5.ResolveMethodHandle(methodToken), c0aaee1f0f5fc4291db9d360bc54f44d3.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(num));
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
					int num2 = (int)c005455c72e24757e06ee7dc118e1e8db.cc0906fa561b9c6076f6cb6643cecb5e3(parameters) + 1;
					Type[] array = cb2313226132631ae148a589a6055fc83.ce8915750eb2dc86a075214c6cf229baa(num2);
					array[0] = constructorInfo.DeclaringType.MakeByRefType();
					for (int j = 1; j < num2; j++)
					{
						array[j] = parameters[j - 1].ParameterType;
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
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, null, array, typeFromHandle, true);
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
							switch (3)
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
							switch (4)
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
							switch (6)
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
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					iLGenerator.Emit(OpCodes.Call, constructorInfo);
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
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
		}

		// Token: 0x0400009E RID: 158
		private static readonly int c0ba91563d7e6b49e54723de1b4ab42db;

		// Token: 0x0400009F RID: 159
		private static readonly int c854250af14a375ca2fed9dcbffcc18b0;

		// Token: 0x040000A0 RID: 160
		private static readonly int cdc714272c788679c6f6ef0c67d1b9266;

		// Token: 0x040000A1 RID: 161
		private static readonly int c049d60d5b5c3a4a6f3a9cdce87e38d45;

		// Token: 0x040000A2 RID: 162
		private static readonly int ce1823a14e23f029ffec8f9579b9334bd;

		// Token: 0x040000A3 RID: 163
		private static readonly int caf0a71476df9a52ccadd0f46292a1a7d;

		// Token: 0x040000A4 RID: 164
		private static readonly int ccec18ad15d38fac5d2eef5b317da0433;

		// Token: 0x040000A5 RID: 165
		private static readonly int cab5f1cefb0f5afda5fc2266d8a61b0f1;

		// Token: 0x040000A6 RID: 166
		private static readonly int c8c77df07950d4a06dd6f3fe55429aa16;

		// Token: 0x040000A7 RID: 167
		private static readonly int c7ddb6a09b04ad4e17e328bbbeeb25386;

		// Token: 0x040000A8 RID: 168
		private static readonly int c2d96ec6124714e816dc5ba7997d0bed0;

		// Token: 0x040000A9 RID: 169
		private static readonly int c50c2b08dd6851d0f063c61d5f3cb9399;

		// Token: 0x040000AA RID: 170
		private static readonly int c4772961882315d57b8f4e56ab5885294;

		// Token: 0x040000AB RID: 171
		private static readonly int c021c01bb3eb4bd26505e931df8c61a0e;

		// Token: 0x040000AC RID: 172
		private static readonly int cf20ad1b714a80c44f0081ebd9e107f60;

		// Token: 0x040000AD RID: 173
		private static readonly int c3dfe258aabc0b40bbbcb0078b3f844b9;

		// Token: 0x040000AE RID: 174
		private static readonly int cdfb70c6886c8d6bd08a95a64437aea9c;

		// Token: 0x040000AF RID: 175
		private static readonly int c3781a336d8aea43aae979372fffdd4d8;

		// Token: 0x040000B0 RID: 176
		private static readonly int c43c9cd3c4d4d51233229c7dba82ea91d;

		// Token: 0x040000B1 RID: 177
		private static readonly int c42065e5d82f8294274c1366748811874;

		// Token: 0x040000B2 RID: 178
		private static readonly ModuleHandle c0481708c89bfd8966846e99396f607e5;
	}
}
