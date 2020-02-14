using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace A
{
	// Token: 0x02000034 RID: 52
	internal sealed class c93401a73c95f915c05188889b03363ac
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00013C70 File Offset: 0x00011E70
		static c93401a73c95f915c05188889b03363ac()
		{
			if (c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc == null)
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
					RuntimeMethodHandle arg_1C_0 = methodof(c93401a73c95f915c05188889b03363ac..cctor()).MethodHandle;
				}
				string text = "QXJjaGVCdWRkeSo=";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array));
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc = cb3ca4465be1524a19d28180711379a86.c2752f94e7a118d91ea4022638efa05ca(97L, manifestResourceStream);
				c93401a73c95f915c05188889b03363ac.c969743ce62e21e8131dc7dfa1a1b0b7f = new Dictionary<int, int>();
				BinaryReader binaryReader = new BinaryReader(new MemoryStream(c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc, false));
				try
				{
					int num = binaryReader.ReadInt32();
					for (int i = 0; i < num; i++)
					{
						int key = binaryReader.ReadInt32();
						int value = binaryReader.ReadInt32();
						c93401a73c95f915c05188889b03363ac.c969743ce62e21e8131dc7dfa1a1b0b7f[key] = value;
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
				}
				finally
				{
					if (binaryReader != null)
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
						((IDisposable)binaryReader).Dispose();
					}
				}
			}
			if (Type.GetTypeFromHandle(cc06e16fcf33c774e3924dcb0efc3ebff.cbac80c0356856482e0a93eed1c1fdf4f()) != null)
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
				c93401a73c95f915c05188889b03363ac.c0481708c89bfd8966846e99396f607e5 = Assembly.GetExecutingAssembly().GetModules()[0].ModuleHandle;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00013DB4 File Offset: 0x00011FB4
		internal static void c83b3ed8c5dd56cf78d4ea20eef272e30(int num, int methodToken, int typeToken)
		{
			Type typeFromHandle;
			MethodBase methodBase;
			try
			{
				typeFromHandle = Type.GetTypeFromHandle(c93401a73c95f915c05188889b03363ac.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(num));
				object methodFromHandle = MethodBase.GetMethodFromHandle(c93401a73c95f915c05188889b03363ac.c0481708c89bfd8966846e99396f607e5.ResolveMethodHandle(methodToken), c93401a73c95f915c05188889b03363ac.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(typeToken));
				methodBase = cc0420ad0cad0421e8f7a4b239f83fc08.c9963fcf210a214a3206d6500f3b9397b(methodFromHandle);
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
					DynamicMethod dynamicMethod = cc505388c2c44a8939fae62f2d4845671.c8a754f5f2ca4adde825691a9c31a0e83;
					MethodBody methodBody = methodBase.GetMethodBody();
					Type[] parameterTypes = c93401a73c95f915c05188889b03363ac.cc15946ad6be801fd5c149cb6e98117e3(methodBase);
					string expr_AF = cdee8693f35ffe72735c191b0e984d715.c1d628ed73c671e8c973543bf826ce40f(methodBase.DeclaringType.FullName, ".", methodBase.Name, "_Encrypted$");
					Type arg_EB_1;
					if (cf5cb492aed4950b03275abe28377bae1.cea69e7c4d1a729bd5783221de1566e79(methodBase) == null)
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
							RuntimeMethodHandle arg_CD_0 = methodof(c93401a73c95f915c05188889b03363ac.c83b3ed8c5dd56cf78d4ea20eef272e30(int, int, int)).MethodHandle;
						}
						arg_EB_1 = c315731d63bb007ca14353142b8436b10.c9963fcf210a214a3206d6500f3b9397b(methodBase).ReturnType;
					}
					else
					{
						arg_EB_1 = null;
					}
					dynamicMethod = new DynamicMethod(expr_AF, arg_EB_1, parameterTypes, methodBase.DeclaringType, true);
					int num2;
					c93401a73c95f915c05188889b03363ac.c969743ce62e21e8131dc7dfa1a1b0b7f.TryGetValue(num, out num2);
					DynamicILInfo dynamicILInfo = dynamicMethod.GetDynamicILInfo();
					c93401a73c95f915c05188889b03363ac.cce88b9ab87e7e9c8e180cb26ab839327(methodBody, dynamicILInfo);
					c93401a73c95f915c05188889b03363ac.cf739b1f8a971b6b05efc66ef9cdd5660(ref num2, methodBase, dynamicILInfo);
					c93401a73c95f915c05188889b03363ac.c0a34c926f875aa80a4ff821f016d5713(ref num2, dynamicILInfo);
					Delegate value = dynamicMethod.CreateDelegate(typeFromHandle);
					fieldInfo.SetValue(null, value);
				}
				catch (Exception)
				{
				}
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

		// Token: 0x0600010E RID: 270 RVA: 0x00013F44 File Offset: 0x00012144
		private static void cf739b1f8a971b6b05efc66ef9cdd5660(ref int ptr, MethodBase methodBase, DynamicILInfo dynamicILInfo)
		{
			int maxStackSize = BitConverter.ToInt32(c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc, ptr);
			ptr += 4;
			int num = BitConverter.ToInt32(c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc, ptr);
			ptr += 4;
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num);
			Buffer.BlockCopy(c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc, ptr, array, 0, num);
			c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db c14ddebb17c4a3c614c6b233fe83968db = new c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db(methodBase, array, dynamicILInfo);
			c14ddebb17c4a3c614c6b233fe83968db.c57f1ff56cc9b6e6baf69f2740559b9c6();
			dynamicILInfo.SetCode(array, maxStackSize);
			ptr += num;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00013FB0 File Offset: 0x000121B0
		private static void cce88b9ab87e7e9c8e180cb26ab839327(MethodBody methodBody, DynamicILInfo dynamicILInfo)
		{
			SignatureHelper localVarSigHelper = SignatureHelper.GetLocalVarSigHelper();
			IEnumerator<LocalVariableInfo> enumerator = methodBody.LocalVariables.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					LocalVariableInfo current = enumerator.Current;
					localVarSigHelper.AddArgument(current.LocalType, current.IsPinned);
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
				if (!true)
				{
					RuntimeMethodHandle arg_55_0 = methodof(c93401a73c95f915c05188889b03363ac.cce88b9ab87e7e9c8e180cb26ab839327(MethodBody, DynamicILInfo)).MethodHandle;
				}
			}
			finally
			{
				if (enumerator != null)
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
					enumerator.Dispose();
				}
			}
			dynamicILInfo.SetLocalSignature(localVarSigHelper.GetSignature());
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00014048 File Offset: 0x00012248
		private unsafe static void c0a34c926f875aa80a4ff821f016d5713(ref int ptr, DynamicILInfo dynamicILInfo)
		{
			int num = BitConverter.ToInt32(c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc, ptr);
			ptr += 4;
			if (num == 0)
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
					RuntimeMethodHandle arg_2A_0 = methodof(c93401a73c95f915c05188889b03363ac.c0a34c926f875aa80a4ff821f016d5713(int*, DynamicILInfo)).MethodHandle;
				}
				return;
			}
			byte[] array = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(num);
			Buffer.BlockCopy(c93401a73c95f915c05188889b03363ac.cf6ccee63d7818e1c2f45e9413f0466fc, ptr, array, 0, num);
			int num2 = 4;
			int num3 = (num - 4) / 24;
			for (int i = 0; i < num3; i++)
			{
				ExceptionHandlingClauseOptions exceptionHandlingClauseOptions = (ExceptionHandlingClauseOptions)BitConverter.ToInt32(array, num2);
				num2 += 20;
				switch (exceptionHandlingClauseOptions)
				{
				case ExceptionHandlingClauseOptions.Clause:
				{
					RuntimeTypeHandle type = c93401a73c95f915c05188889b03363ac.c0481708c89bfd8966846e99396f607e5.ResolveTypeHandle(BitConverter.ToInt32(array, num2));
					int tokenFor = dynamicILInfo.GetTokenFor(type);
					c93401a73c95f915c05188889b03363ac.ca35bff35696682007baad0f8b3f7bf2c(tokenFor, num2, array);
					break;
				}
				case ExceptionHandlingClauseOptions.Fault:
					throw new NotSupportedException("dynamic method does not support fault clause");
				}
				num2 += 4;
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
			dynamicILInfo.SetExceptions(array);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00014138 File Offset: 0x00012338
		public static void ca35bff35696682007baad0f8b3f7bf2c(int num, int num2, byte[] array)
		{
			array[num2++] = (byte)num;
			array[num2++] = (byte)(num >> 8);
			array[num2++] = (byte)(num >> 16);
			array[num2++] = (byte)(num >> 24);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00014180 File Offset: 0x00012380
		private static Type[] cc15946ad6be801fd5c149cb6e98117e3(MethodBase methodBase)
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			int num = (int)c005455c72e24757e06ee7dc118e1e8db.cc0906fa561b9c6076f6cb6643cecb5e3(parameters);
			if (!methodBase.IsStatic)
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
					RuntimeMethodHandle arg_2F_0 = methodof(c93401a73c95f915c05188889b03363ac.cc15946ad6be801fd5c149cb6e98117e3(MethodBase)).MethodHandle;
				}
				num++;
			}
			Type[] array = cb2313226132631ae148a589a6055fc83.ce8915750eb2dc86a075214c6cf229baa(num);
			int num2 = 0;
			if (!methodBase.IsStatic)
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
				if (methodBase.DeclaringType.IsValueType)
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
					array[0] = methodBase.DeclaringType.MakeByRefType();
				}
				else
				{
					array[0] = methodBase.DeclaringType;
				}
				num2++;
			}
			int i = 0;
			while (i < (int)c005455c72e24757e06ee7dc118e1e8db.cc0906fa561b9c6076f6cb6643cecb5e3(parameters))
			{
				array[num2] = parameters[i].ParameterType;
				i++;
				num2++;
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
			return array;
		}

		// Token: 0x040000B3 RID: 179
		internal static readonly byte[] cf6ccee63d7818e1c2f45e9413f0466fc;

		// Token: 0x040000B4 RID: 180
		internal static readonly Dictionary<int, int> c969743ce62e21e8131dc7dfa1a1b0b7f;

		// Token: 0x040000B5 RID: 181
		private static readonly ModuleHandle c0481708c89bfd8966846e99396f607e5;

		// Token: 0x02000036 RID: 54
		public sealed class c14ddebb17c4a3c614c6b233fe83968db
		{
			// Token: 0x0600011C RID: 284 RVA: 0x000145BC File Offset: 0x000127BC
			static c14ddebb17c4a3c614c6b233fe83968db()
			{
				FieldInfo[] fields = Type.GetTypeFromHandle(ced79417e0d176a34b092cdfc242ff44f.cbac80c0356856482e0a93eed1c1fdf4f()).GetFields(BindingFlags.Static | BindingFlags.Public);
				for (int i = 0; i < (int)ce91cd4fecc4cea65e47c19367da31ed1.cc0906fa561b9c6076f6cb6643cecb5e3(fields); i++)
				{
					FieldInfo fieldInfo = fields[i];
					OpCode opCode = c7a89dc66c51932840c1011a305f3feb1.cc6a9c540a2ed5763275f32ba91c9e97b(fieldInfo.GetValue(c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83));
					ushort num = (ushort)opCode.Value;
					if (num < 256)
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
							RuntimeMethodHandle arg_81_0 = methodof(c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db..cctor()).MethodHandle;
						}
						c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db.c0d435321035a69ba320e1a553eee1e59[(int)num] = opCode;
					}
					else if ((num & 65280) == 65024)
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
						c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db.cbb7e000b1b709aba5ff4ed1f1a89ef79[(int)(num & 255)] = opCode;
					}
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

			// Token: 0x0600011D RID: 285 RVA: 0x000146B0 File Offset: 0x000128B0
			public c14ddebb17c4a3c614c6b233fe83968db(MethodBase methodBase, byte[] array, DynamicILInfo dynamicILInfo)
			{
				this.ce42f541fb7e4f17d7bf74493ea51238f = dynamicILInfo;
				this.c1fd8d83dacbe9fe9088d3182748776d6 = array;
				this.c40c435f501d00429f7eca16d891c010a = 0;
				this.c99d82ff51f0b0194bc395dfe90d9be8f = methodBase.Module;
				Type[] arg_56_1;
				if (cf5cb492aed4950b03275abe28377bae1.cea69e7c4d1a729bd5783221de1566e79(methodBase) == null)
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
						RuntimeMethodHandle arg_46_0 = methodof(c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db..ctor(MethodBase, byte[], DynamicILInfo)).MethodHandle;
					}
					arg_56_1 = methodBase.GetGenericArguments();
				}
				else
				{
					arg_56_1 = ce5623082444f6021369dcae96d6927d9.c8a754f5f2ca4adde825691a9c31a0e83;
				}
				this.ccd50034aa84ea046971dbf0fac671977 = arg_56_1;
				Type[] arg_86_1;
				if (methodBase.DeclaringType != null)
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
					arg_86_1 = methodBase.DeclaringType.GetGenericArguments();
				}
				else
				{
					arg_86_1 = ce5623082444f6021369dcae96d6927d9.c8a754f5f2ca4adde825691a9c31a0e83;
				}
				this.c9898d0a9017ca14381dcd8219f301620 = arg_86_1;
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00014748 File Offset: 0x00012948
			internal void c57f1ff56cc9b6e6baf69f2740559b9c6()
			{
				while (this.c40c435f501d00429f7eca16d891c010a < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(this.c1fd8d83dacbe9fe9088d3182748776d6))
				{
					this.c46eacde638e6353a319f650e190389a7();
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
				if (!true)
				{
					RuntimeMethodHandle arg_33_0 = methodof(c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db.c57f1ff56cc9b6e6baf69f2740559b9c6()).MethodHandle;
				}
			}

			// Token: 0x0600011F RID: 287 RVA: 0x0001478C File Offset: 0x0001298C
			private object c46eacde638e6353a319f650e190389a7()
			{
				int num = this.c40c435f501d00429f7eca16d891c010a;
				OpCode opCode = OpCodes.Nop;
				byte b = this.cd4680c2f8d52ae1cff439c41b4bb3571();
				if (b != 254)
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
						RuntimeMethodHandle arg_32_0 = methodof(c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db.c46eacde638e6353a319f650e190389a7()).MethodHandle;
					}
					opCode = c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db.c0d435321035a69ba320e1a553eee1e59[(int)b];
				}
				else
				{
					b = this.cd4680c2f8d52ae1cff439c41b4bb3571();
					opCode = c93401a73c95f915c05188889b03363ac.c14ddebb17c4a3c614c6b233fe83968db.cbb7e000b1b709aba5ff4ed1f1a89ef79[(int)b];
				}
				switch (opCode.OperandType)
				{
				case OperandType.InlineBrTarget:
					this.c76023c39698a624f1d83ca5988dacb39(4);
					return null;
				case OperandType.InlineField:
				{
					int num2 = this.cee0f8969f433e5e572dad0b2044a6140();
					FieldInfo fieldInfo = this.c99d82ff51f0b0194bc395dfe90d9be8f.ResolveField(num2, this.c9898d0a9017ca14381dcd8219f301620, this.ccd50034aa84ea046971dbf0fac671977);
					this.ca35bff35696682007baad0f8b3f7bf2c(this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(fieldInfo.FieldHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineI:
					this.c76023c39698a624f1d83ca5988dacb39(4);
					return null;
				case OperandType.InlineI8:
					this.c76023c39698a624f1d83ca5988dacb39(8);
					return null;
				case OperandType.InlineMethod:
				{
					int num2 = this.cee0f8969f433e5e572dad0b2044a6140();
					MethodBase methodBase = this.c99d82ff51f0b0194bc395dfe90d9be8f.ResolveMethod(num2, this.c9898d0a9017ca14381dcd8219f301620, this.ccd50034aa84ea046971dbf0fac671977);
					this.ca35bff35696682007baad0f8b3f7bf2c(this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(methodBase.MethodHandle, methodBase.DeclaringType.TypeHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineNone:
					return null;
				case OperandType.InlineR:
					this.c76023c39698a624f1d83ca5988dacb39(8);
					return null;
				case OperandType.InlineSig:
				{
					int num2 = this.cee0f8969f433e5e572dad0b2044a6140();
					this.ca35bff35696682007baad0f8b3f7bf2c(this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(this.c99d82ff51f0b0194bc395dfe90d9be8f.ResolveSignature(num2)), num + opCode.Size);
					return null;
				}
				case OperandType.InlineString:
				{
					int num2 = this.cee0f8969f433e5e572dad0b2044a6140();
					this.ca35bff35696682007baad0f8b3f7bf2c(this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(this.c99d82ff51f0b0194bc395dfe90d9be8f.ResolveString(num2)), num + opCode.Size);
					return null;
				}
				case OperandType.InlineSwitch:
				{
					int num3 = this.cee0f8969f433e5e572dad0b2044a6140();
					this.c76023c39698a624f1d83ca5988dacb39(num3 * 4);
					return null;
				}
				case OperandType.InlineTok:
				{
					int num2 = this.cee0f8969f433e5e572dad0b2044a6140();
					MemberInfo memberInfo = this.c99d82ff51f0b0194bc395dfe90d9be8f.ResolveMember(num2, this.c9898d0a9017ca14381dcd8219f301620, this.ccd50034aa84ea046971dbf0fac671977);
					if (memberInfo.MemberType != MemberTypes.TypeInfo)
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
						if (memberInfo.MemberType != MemberTypes.NestedType)
						{
							if (memberInfo.MemberType != MemberTypes.Method)
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
								if (memberInfo.MemberType == MemberTypes.Constructor)
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
								}
								else
								{
									if (memberInfo.MemberType == MemberTypes.Field)
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
										FieldInfo fieldInfo2 = cc149ddb6386d21b965cd11f6f647e507.cea69e7c4d1a729bd5783221de1566e79(memberInfo);
										num2 = this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(fieldInfo2.FieldHandle);
										goto IL_393;
									}
									goto IL_393;
								}
							}
							MethodBase methodBase2 = c7ad98f4ed44a1feee4733b46aa07295c.cea69e7c4d1a729bd5783221de1566e79(memberInfo);
							num2 = this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(methodBase2.MethodHandle, methodBase2.DeclaringType.TypeHandle);
							goto IL_393;
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
					Type type = c84f77b2504c11ba8e0b3b4ae1b43773c.cea69e7c4d1a729bd5783221de1566e79(memberInfo);
					num2 = this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(type.TypeHandle);
					IL_393:
					this.ca35bff35696682007baad0f8b3f7bf2c(num2, num + opCode.Size);
					return null;
				}
				case OperandType.InlineType:
				{
					int num2 = this.cee0f8969f433e5e572dad0b2044a6140();
					Type type2 = this.c99d82ff51f0b0194bc395dfe90d9be8f.ResolveType(num2, this.c9898d0a9017ca14381dcd8219f301620, this.ccd50034aa84ea046971dbf0fac671977);
					this.ca35bff35696682007baad0f8b3f7bf2c(this.ce42f541fb7e4f17d7bf74493ea51238f.GetTokenFor(type2.TypeHandle), num + opCode.Size);
					return null;
				}
				case OperandType.InlineVar:
					this.c76023c39698a624f1d83ca5988dacb39(2);
					return null;
				case OperandType.ShortInlineBrTarget:
					this.c76023c39698a624f1d83ca5988dacb39(1);
					return null;
				case OperandType.ShortInlineI:
					this.c76023c39698a624f1d83ca5988dacb39(1);
					return null;
				case OperandType.ShortInlineR:
					this.c76023c39698a624f1d83ca5988dacb39(4);
					return null;
				case OperandType.ShortInlineVar:
					this.c76023c39698a624f1d83ca5988dacb39(1);
					return null;
				}
				throw new BadImageFormatException(c9fa10d86eb9bdcf9b2c32a8c43ba15e1.c1d628ed73c671e8c973543bf826ce40f("unexpected OperandType ", opCode.OperandType));
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00014B78 File Offset: 0x00012D78
			private void c76023c39698a624f1d83ca5988dacb39(int num)
			{
				this.c40c435f501d00429f7eca16d891c010a += num;
			}

			// Token: 0x06000121 RID: 289 RVA: 0x00014B94 File Offset: 0x00012D94
			private byte cd4680c2f8d52ae1cff439c41b4bb3571()
			{
				return this.c1fd8d83dacbe9fe9088d3182748776d6[this.c40c435f501d00429f7eca16d891c010a++];
			}

			// Token: 0x06000122 RID: 290 RVA: 0x00014BBC File Offset: 0x00012DBC
			private int cee0f8969f433e5e572dad0b2044a6140()
			{
				int startIndex = this.c40c435f501d00429f7eca16d891c010a;
				this.c40c435f501d00429f7eca16d891c010a += 4;
				return BitConverter.ToInt32(this.c1fd8d83dacbe9fe9088d3182748776d6, startIndex);
			}

			// Token: 0x06000123 RID: 291 RVA: 0x00014BEC File Offset: 0x00012DEC
			private void ca35bff35696682007baad0f8b3f7bf2c(int num, int num2)
			{
				this.c1fd8d83dacbe9fe9088d3182748776d6[num2++] = (byte)num;
				this.c1fd8d83dacbe9fe9088d3182748776d6[num2++] = (byte)(num >> 8);
				this.c1fd8d83dacbe9fe9088d3182748776d6[num2++] = (byte)(num >> 16);
				this.c1fd8d83dacbe9fe9088d3182748776d6[num2++] = (byte)(num >> 24);
			}

			// Token: 0x040000BD RID: 189
			private static OpCode[] c0d435321035a69ba320e1a553eee1e59 = c22d9e9919b80d12264068b466bf7f3b9.ce8915750eb2dc86a075214c6cf229baa(256);

			// Token: 0x040000BE RID: 190
			private static OpCode[] cbb7e000b1b709aba5ff4ed1f1a89ef79 = c22d9e9919b80d12264068b466bf7f3b9.ce8915750eb2dc86a075214c6cf229baa(256);

			// Token: 0x040000BF RID: 191
			private int c40c435f501d00429f7eca16d891c010a;

			// Token: 0x040000C0 RID: 192
			private byte[] c1fd8d83dacbe9fe9088d3182748776d6;

			// Token: 0x040000C1 RID: 193
			private DynamicILInfo ce42f541fb7e4f17d7bf74493ea51238f;

			// Token: 0x040000C2 RID: 194
			private Module c99d82ff51f0b0194bc395dfe90d9be8f;

			// Token: 0x040000C3 RID: 195
			private Type[] ccd50034aa84ea046971dbf0fac671977;

			// Token: 0x040000C4 RID: 196
			private Type[] c9898d0a9017ca14381dcd8219f301620;
		}
	}
}
