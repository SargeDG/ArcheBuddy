using System;
using System.Reflection;
using System.Reflection.Emit;

namespace A
{
	// Token: 0x0200002E RID: 46
	internal sealed class cb83df6c3c9db33fada2dab55c55b461a
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00012EB0 File Offset: 0x000110B0
		static cb83df6c3c9db33fada2dab55c55b461a()
		{
			if (Type.GetTypeFromHandle(cc06e16fcf33c774e3924dcb0efc3ebff.cbac80c0356856482e0a93eed1c1fdf4f()) != null)
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
					RuntimeMethodHandle arg_22_0 = methodof(cb83df6c3c9db33fada2dab55c55b461a..cctor()).MethodHandle;
				}
				cb83df6c3c9db33fada2dab55c55b461a.c0481708c89bfd8966846e99396f607e5 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00012F10 File Offset: 0x00011110
		private int get_c31299c080141c0dd3b4f7564d8c30200()
		{
			return 1;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00012F20 File Offset: 0x00011120
		public static void c28f89b549b0721b6db43243f02d3be65(int typeToken, int methodToken, int num)
		{
			Type typeFromHandle;
			MethodInfo methodInfo;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(cb83df6c3c9db33fada2dab55c55b461a.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(typeToken));
				object methodFromHandle;
				if (num == 16777215)
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
						RuntimeMethodHandle arg_33_0 = methodof(cb83df6c3c9db33fada2dab55c55b461a.c28f89b549b0721b6db43243f02d3be65(int, int, int)).MethodHandle;
					}
					methodFromHandle = MethodBase.GetMethodFromHandle(cb83df6c3c9db33fada2dab55c55b461a.c0481708c89bfd8966846e99396f607e5.ResolveMethodHandle(methodToken));
				}
				else
				{
					methodFromHandle = MethodBase.GetMethodFromHandle(cb83df6c3c9db33fada2dab55c55b461a.c0481708c89bfd8966846e99396f607e5.ResolveMethodHandle(methodToken), cb83df6c3c9db33fada2dab55c55b461a.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(num));
				}
				methodInfo = c315731d63bb007ca14353142b8436b10.c9963fcf210a214a3206d6500f3b9397b(methodFromHandle);
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
					Delegate value;
					if (methodInfo.IsStatic)
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
						value = Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo);
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num2 = (int)c005455c72e24757e06ee7dc118e1e8db.cc0906fa561b9c6076f6cb6643cecb5e3(parameters) + 1;
						Type[] array = cb2313226132631ae148a589a6055fc83.ce8915750eb2dc86a075214c6cf229baa(num2);
						if (methodInfo.DeclaringType.IsValueType)
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
							array[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array[0] = Type.GetTypeFromHandle(c7322a7fe4250b9d30d1362edab51b5ff.cbac80c0356856482e0a93eed1c1fdf4f());
						}
						for (int j = 1; j < num2; j++)
						{
							array[j] = parameters[j - 1].ParameterType;
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
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array, typeFromHandle, true);
						ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
						iLGenerator.Emit(OpCodes.Ldarg_0);
						if (num2 > 1)
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
								switch (1)
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
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						ILGenerator arg_23D_0 = iLGenerator;
						OpCode arg_23D_1;
						if (!fieldInfo.IsFamilyOrAssembly)
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
							arg_23D_1 = OpCodes.Call;
						}
						else
						{
							arg_23D_1 = OpCodes.Callvirt;
						}
						arg_23D_0.Emit(arg_23D_1, methodInfo);
						iLGenerator.Emit(OpCodes.Ret);
						value = dynamicMethod.CreateDelegate(typeFromHandle);
					}
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
			}
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly int c0ba91563d7e6b49e54723de1b4ab42db;

		// Token: 0x04000070 RID: 112
		private static readonly int c854250af14a375ca2fed9dcbffcc18b0;

		// Token: 0x04000071 RID: 113
		private static readonly int cdc714272c788679c6f6ef0c67d1b9266;

		// Token: 0x04000072 RID: 114
		private static readonly int c049d60d5b5c3a4a6f3a9cdce87e38d45;

		// Token: 0x04000073 RID: 115
		private static readonly int ce1823a14e23f029ffec8f9579b9334bd;

		// Token: 0x04000074 RID: 116
		private static readonly int caf0a71476df9a52ccadd0f46292a1a7d;

		// Token: 0x04000075 RID: 117
		private static readonly int ccec18ad15d38fac5d2eef5b317da0433;

		// Token: 0x04000076 RID: 118
		private static readonly int cab5f1cefb0f5afda5fc2266d8a61b0f1;

		// Token: 0x04000077 RID: 119
		private static readonly int c8c77df07950d4a06dd6f3fe55429aa16;

		// Token: 0x04000078 RID: 120
		private static readonly int c7ddb6a09b04ad4e17e328bbbeeb25386;

		// Token: 0x04000079 RID: 121
		private static readonly int c2d96ec6124714e816dc5ba7997d0bed0;

		// Token: 0x0400007A RID: 122
		private static readonly int c50c2b08dd6851d0f063c61d5f3cb9399;

		// Token: 0x0400007B RID: 123
		private static readonly int c4772961882315d57b8f4e56ab5885294;

		// Token: 0x0400007C RID: 124
		private static readonly int c021c01bb3eb4bd26505e931df8c61a0e;

		// Token: 0x0400007D RID: 125
		private static readonly int cf20ad1b714a80c44f0081ebd9e107f60;

		// Token: 0x0400007E RID: 126
		private static readonly int c3dfe258aabc0b40bbbcb0078b3f844b9;

		// Token: 0x0400007F RID: 127
		private static readonly int cdfb70c6886c8d6bd08a95a64437aea9c;

		// Token: 0x04000080 RID: 128
		private static readonly int c3781a336d8aea43aae979372fffdd4d8;

		// Token: 0x04000081 RID: 129
		private static readonly int c43c9cd3c4d4d51233229c7dba82ea91d;

		// Token: 0x04000082 RID: 130
		private static readonly int c42065e5d82f8294274c1366748811874;

		// Token: 0x04000083 RID: 131
		private static readonly ModuleHandle c0481708c89bfd8966846e99396f607e5;
	}
}
