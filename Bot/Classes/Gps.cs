using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000550 RID: 1360
	public class Gps : MarshalProxy
	{
		// Token: 0x06001E04 RID: 7684 RVA: 0x0012F7B8 File Offset: 0x0012D9B8
		public Gps(Core c)
		{
			this.c322d2adbf9066ebe7e92167104f39cf6 = new List<GpsLink>();
			this.c6b913e516dd22e54f305f59243f0f251 = new Dictionary<uint, GpsPolygon>();
			this.c95a098eee16f9571540081368c35a50b = new Dictionary<uint, GpsPoint>();
			c1dde21e07e0adf1efc505e93a3118ecd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92688));
			this.ca124a9f406cda69b904f2eb04d553ab9 = c;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0012F808 File Offset: 0x0012DA08
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0012F81C File Offset: 0x0012DA1C
		public bool gpsMoveSuspended
		{
			get;
			private set;
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0012F830 File Offset: 0x0012DA30
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0012F844 File Offset: 0x0012DA44
		public double maxSearchDistance
		{
			get;
			set;
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x0012F858 File Offset: 0x0012DA58
		internal byte[] c471f6147fda59d9222a24bf77caf9a0e()
		{
			byte[] result = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91832));
			MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				BinaryWriter binaryWriter = c71fa6f0b097935929087ccc2b8f2a944.c0cf59c3e67a46fd4edb3040c5ab0bbfb(memoryStream);
				try
				{
					List<GpsPoint> list = c839dd262b35bc04e05d1459c346c2d8b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
					ca7d22a7a1042600fe3a2e5ce18a64fa9.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list));
					List<GpsPoint>.Enumerator enumerator = c6cf7a7b994fef50740f898924b71c374.c30767ddca1f9c207888833aea5b5fc61(list);
					try
					{
						while (cdd2430fc8704825cc9e7d3556d0eabd2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
						{
							GpsPoint gpsPoint = c54aaf40bc4009bd70415fee5a608dee5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
							c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(gpsPoint));
							c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(gpsPoint));
							c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(gpsPoint));
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
							RuntimeMethodHandle arg_9E_0 = methodof(Gps.c471f6147fda59d9222a24bf77caf9a0e()).MethodHandle;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					List<GpsLink> list2 = c5dbc7632c17b1f26b92c2ba807ccda6b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
					int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91836);
					List<GpsLink>.Enumerator enumerator2 = ca4d9f58342fee4f291d82063360ffaed.c30767ddca1f9c207888833aea5b5fc61(list2);
					try
					{
						while (c553bc043c34a302cf8a8785ae5795da0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2))
						{
							GpsLink gpsLink = c9dfa71b4dc6c96f0d9b43c92e7c45454.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator2);
							if (c0d2ebe7f4c7918e76f0d02967c2c9e49.c30767ddca1f9c207888833aea5b5fc61(gpsLink) != (GpsLinkType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91840))
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
								if (c0d2ebe7f4c7918e76f0d02967c2c9e49.c30767ddca1f9c207888833aea5b5fc61(gpsLink) != (GpsLinkType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91844))
								{
									continue;
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
							num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91848);
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
						((IDisposable)enumerator2).Dispose();
					}
					ca7d22a7a1042600fe3a2e5ce18a64fa9.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, num);
					List<GpsLink>.Enumerator enumerator3 = ca4d9f58342fee4f291d82063360ffaed.c30767ddca1f9c207888833aea5b5fc61(list2);
					try
					{
						while (c553bc043c34a302cf8a8785ae5795da0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator3))
						{
							GpsLink gpsLink2 = c9dfa71b4dc6c96f0d9b43c92e7c45454.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator3);
							if (c0d2ebe7f4c7918e76f0d02967c2c9e49.c30767ddca1f9c207888833aea5b5fc61(gpsLink2) == (GpsLinkType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91852))
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
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(91856));
								c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91860));
								c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91864));
								c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91868));
							}
							if (c0d2ebe7f4c7918e76f0d02967c2c9e49.c30767ddca1f9c207888833aea5b5fc61(gpsLink2) == (GpsLinkType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91872))
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
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(c2960a7a79b0fdbcc08a7e032cdb02037.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (float)cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(ca56628ddda016a93ae638833c1e554c6.c30767ddca1f9c207888833aea5b5fc61(gpsLink2)));
								c589a0b37acb6bef5677a345d8b337231.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(91876));
								c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91880));
								c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91884));
								c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91888));
							}
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
					finally
					{
						((IDisposable)enumerator3).Dispose();
					}
					List<GpsPolygon> list3 = c647995fea28da477cb088f325e52f466.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
					num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91892);
					List<GpsPolygon>.Enumerator enumerator4 = ccd68480994b1e8da6aa42e25db7eff92.c30767ddca1f9c207888833aea5b5fc61(list3);
					try
					{
						while (c72905a67b0d9f65470c2ee3f3a1c85b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator4))
						{
							GpsPolygon gpsPolygon = c3c1c7aa71168505158d0488f79ed4383.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator4);
							if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91896))
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
								num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91900);
							}
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
					finally
					{
						((IDisposable)enumerator4).Dispose();
					}
					ca7d22a7a1042600fe3a2e5ce18a64fa9.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, num);
					List<GpsPolygon>.Enumerator enumerator5 = ccd68480994b1e8da6aa42e25db7eff92.c30767ddca1f9c207888833aea5b5fc61(list3);
					try
					{
						while (c72905a67b0d9f65470c2ee3f3a1c85b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator5))
						{
							GpsPolygon gpsPolygon2 = c3c1c7aa71168505158d0488f79ed4383.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator5);
							if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2)) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91904))
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
								Gps.c03bf2d133a4ae9bb56cb05a7615328f8[] array = new Gps.c03bf2d133a4ae9bb56cb05a7615328f8[c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2))];
								double num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91908);
								double num3 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91916);
								double num4 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91924);
								for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91932); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91936))
								{
									array[i] = new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2), i)), cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2), i)), cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2), i)));
									array[i].cb5905b594e11dea2f73932df05981674 = c1e6b3fbc070822b755377c8ac0023d76.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2), i));
									num2 += array[i].get_c3071642cc772d7d0223fbcc438c3ff3e();
									num3 += array[i].get_c039bd5f7ee0b10e3324f3380089087ec();
									num4 += array[i].get_c3d23e1cbcae9438226f42183a707c914();
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
								num2 /= (double)c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2));
								num3 /= (double)c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2));
								num4 /= (double)c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2));
								Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f = new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(num2, num3, num4);
								for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91940); j < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2)); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91944))
								{
									array[j].c342e51a09e3b7933934f9dd072ac3722 = cc0584be127ed049ff283cd2d1a4f284a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array[j].get_c039bd5f7ee0b10e3324f3380089087ec() - c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec(), array[j].get_c3071642cc772d7d0223fbcc438c3ff3e() - c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e());
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
								IEnumerable<Gps.c03bf2d133a4ae9bb56cb05a7615328f8> arg_667_0 = array;
								if (Gps.c3444fefa19358f4a5e6d401dacac9dc8 == null)
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
									Gps.c3444fefa19358f4a5e6d401dacac9dc8 = new Func<Gps.c03bf2d133a4ae9bb56cb05a7615328f8, double>(Gps.ccb135a86d7c38e7b89a6ee9999fbcb36);
								}
								List<Gps.c03bf2d133a4ae9bb56cb05a7615328f8> list4 = arg_667_0.OrderBy(Gps.c3444fefa19358f4a5e6d401dacac9dc8).ToList<Gps.c03bf2d133a4ae9bb56cb05a7615328f8>();
								for (int k = c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2)) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91948); k >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91960); k -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91956))
								{
									ca7d22a7a1042600fe3a2e5ce18a64fa9.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (int)(c779b11334253e84ae79150a4f1b3e413.c30767ddca1f9c207888833aea5b5fc61(list4, k).cb5905b594e11dea2f73932df05981674 - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91952)));
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
								c80a235f76f15e44d4f4f732fa911285e.c30767ddca1f9c207888833aea5b5fc61(binaryWriter, (byte)ceef51808cf0974b6f13d04005e0e8c57.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon2));
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
					finally
					{
						((IDisposable)enumerator5).Dispose();
					}
					c219da346a9155b5a7db89195b66c1d46.c30767ddca1f9c207888833aea5b5fc61(binaryWriter);
					cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
					result = cf3744162c2510b61a0e593fe770de523.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
				}
				finally
				{
					if (binaryWriter != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(binaryWriter);
					}
				}
			}
			finally
			{
				if (memoryStream != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(memoryStream);
				}
			}
			return result;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x0013006C File Offset: 0x0012E26C
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
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
						RuntimeMethodHandle arg_1D_0 = methodof(Gps.Dispose(bool)).MethodHandle;
					}
					if (disposing)
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
						if (this.c3e76590440c7f603f07fda2f71aada9b != null)
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
							c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b);
							this.c3e76590440c7f603f07fda2f71aada9b = c83edf3a472c287a4efcee3f717cb49fa.c8a754f5f2ca4adde825691a9c31a0e83;
							this.ca124a9f406cda69b904f2eb04d553ab9 = c6113e3646ca6e36063b06a87d0993100.c8a754f5f2ca4adde825691a9c31a0e83;
						}
						List<GpsPoint> list = c42426b546c2648e2711f225c541a34be.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b).ToList<GpsPoint>();
						for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91964); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91968))
						{
							if (cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i) != null)
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
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
								ccec314a808f32a6281a5dae445d72964.c30767ddca1f9c207888833aea5b5fc61(list, i, ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83);
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
						c3ac5ee8476f1433f374864c9f480b89a.c30767ddca1f9c207888833aea5b5fc61(list);
						c3d2d5626eb7b488b2ec63f860838a9bc.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b);
						for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91972); j < c2fd38130edb0742b9ffe13363e4fd91a.c30767ddca1f9c207888833aea5b5fc61(this.c322d2adbf9066ebe7e92167104f39cf6); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91976))
						{
							if (cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(this.c322d2adbf9066ebe7e92167104f39cf6, j) != null)
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
								c6acbaf0ad3d6b30f02a73b8372b99753.c30767ddca1f9c207888833aea5b5fc61(cc6a9395b293842b6341d5bcbc0bddec1.c30767ddca1f9c207888833aea5b5fc61(this.c322d2adbf9066ebe7e92167104f39cf6, j));
								ce8ec02e0bdb2159dfdadd642e4dc5b3d.c30767ddca1f9c207888833aea5b5fc61(this.c322d2adbf9066ebe7e92167104f39cf6, j, c6e36aa1dad573a01bfbb14e1f15cb4de.c8a754f5f2ca4adde825691a9c31a0e83);
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
						c59aa94a96596a8d0afca9df5abf98f68.c30767ddca1f9c207888833aea5b5fc61(this.c322d2adbf9066ebe7e92167104f39cf6);
					}
					ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06001E0B RID: 7691 RVA: 0x00130210 File Offset: 0x0012E410
		// (remove) Token: 0x06001E0C RID: 7692 RVA: 0x0013025C File Offset: 0x0012E45C
		public event CoreInternal.GpsPreMove onGpsPreMove
		{
			add
			{
				CoreInternal.GpsPreMove gpsPreMove = this.ce778f81f0bb27af81ac145937c3b96db;
				CoreInternal.GpsPreMove gpsPreMove2;
				do
				{
					gpsPreMove2 = gpsPreMove;
					CoreInternal.GpsPreMove value2 = (CoreInternal.GpsPreMove)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(gpsPreMove2, value);
					gpsPreMove = Interlocked.CompareExchange<CoreInternal.GpsPreMove>(ref this.ce778f81f0bb27af81ac145937c3b96db, value2, gpsPreMove2);
				}
				while (gpsPreMove != gpsPreMove2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Gps.add_onGpsPreMove(CoreInternal.GpsPreMove)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.GpsPreMove gpsPreMove = this.ce778f81f0bb27af81ac145937c3b96db;
				CoreInternal.GpsPreMove gpsPreMove2;
				do
				{
					gpsPreMove2 = gpsPreMove;
					CoreInternal.GpsPreMove value2 = (CoreInternal.GpsPreMove)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(gpsPreMove2, value);
					gpsPreMove = Interlocked.CompareExchange<CoreInternal.GpsPreMove>(ref this.ce778f81f0bb27af81ac145937c3b96db, value2, gpsPreMove2);
				}
				while (gpsPreMove != gpsPreMove2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Gps.remove_onGpsPreMove(CoreInternal.GpsPreMove)).MethodHandle;
				}
			}
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06001E0D RID: 7693 RVA: 0x001302A8 File Offset: 0x0012E4A8
		// (remove) Token: 0x06001E0E RID: 7694 RVA: 0x001302F4 File Offset: 0x0012E4F4
		public event CoreInternal.GpsPostMove onGpsPostMove
		{
			add
			{
				CoreInternal.GpsPostMove gpsPostMove = this.c68fbfec6e0d561d4fd3485de9ed542d7;
				CoreInternal.GpsPostMove gpsPostMove2;
				do
				{
					gpsPostMove2 = gpsPostMove;
					CoreInternal.GpsPostMove value2 = (CoreInternal.GpsPostMove)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(gpsPostMove2, value);
					gpsPostMove = Interlocked.CompareExchange<CoreInternal.GpsPostMove>(ref this.c68fbfec6e0d561d4fd3485de9ed542d7, value2, gpsPostMove2);
				}
				while (gpsPostMove != gpsPostMove2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Gps.add_onGpsPostMove(CoreInternal.GpsPostMove)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.GpsPostMove gpsPostMove = this.c68fbfec6e0d561d4fd3485de9ed542d7;
				CoreInternal.GpsPostMove gpsPostMove2;
				do
				{
					gpsPostMove2 = gpsPostMove;
					CoreInternal.GpsPostMove value2 = (CoreInternal.GpsPostMove)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(gpsPostMove2, value);
					gpsPostMove = Interlocked.CompareExchange<CoreInternal.GpsPostMove>(ref this.c68fbfec6e0d561d4fd3485de9ed542d7, value2, gpsPostMove2);
				}
				while (gpsPostMove != gpsPostMove2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Gps.remove_onGpsPostMove(CoreInternal.GpsPostMove)).MethodHandle;
				}
			}
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00130340 File Offset: 0x0012E540
		private void ca013267df427bd5c25268779f5aea657()
		{
			this.c6b913e516dd22e54f305f59243f0f251 = cdfba881e4bdafccd6f439b655fd34b04.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				try
				{
					c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198103));
					cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91980));
					c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							GpsPolygon gpsPolygon = c55d60860a508f38e71393b5d686e6cdb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							cc3941ae8772bf00ca313c6346318f6b1.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91984))));
							c4d42a8b73bae35b135832f08cfcec166.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91988))));
							ccbaad24f8d756062f2d5dc06cde2f375.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91992))));
							c599f36768461c4dcbfbbbfa0c0907343.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91996))));
							c592ce50e38a768ec1ad9a218b6bd7425.c30767ddca1f9c207888833aea5b5fc61(this.c6b913e516dd22e54f305f59243f0f251, cedcf6e123024d5d1c651a60ee69571a8.c30767ddca1f9c207888833aea5b5fc61(gpsPolygon), gpsPolygon);
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
							RuntimeMethodHandle arg_130_0 = methodof(Gps.ca013267df427bd5c25268779f5aea657()).MethodHandle;
						}
					}
					finally
					{
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
			SQLiteCommand sQLiteCommand2 = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				try
				{
					c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198182));
					cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand2, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92000));
					c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand2);
					SQLiteDataReader sQLiteDataReader2 = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand2);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92004)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92008)));
							if (c961d992ba314b60d16cc1320914e7292.c30767ddca1f9c207888833aea5b5fc61(this.c6b913e516dd22e54f305f59243f0f251, num))
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
								if (c38c74c75cc1e33080a47f87b8e58b1c6.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num2))
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
									c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(cf963fb4c591204e1dc55d996e6b008c2.c30767ddca1f9c207888833aea5b5fc61(c54136f8799d63c4cef7066ce8adcf919.c30767ddca1f9c207888833aea5b5fc61(this.c6b913e516dd22e54f305f59243f0f251, num)), c8cc868d04e1dfd4c2cc63cba0bf97d5e.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num2));
								}
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
					finally
					{
						if (sQLiteDataReader2 != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader2);
						}
					}
				}
				catch (Exception ex2)
				{
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand2);
			}
			finally
			{
				if (sQLiteCommand2 != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand2);
				}
			}
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x001306B0 File Offset: 0x0012E8B0
		private void cde8c51a32ce0c90710437faa0621b06c()
		{
			this.c322d2adbf9066ebe7e92167104f39cf6 = c18074a99a8200dd5fc207134694a2875.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				try
				{
					c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198261));
					cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92012));
					c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92016)));
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92020)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92024)));
							byte b = SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92028)));
							if (c38c74c75cc1e33080a47f87b8e58b1c6.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num))
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
									RuntimeMethodHandle arg_101_0 = methodof(Gps.cde8c51a32ce0c90710437faa0621b06c()).MethodHandle;
								}
								if (c38c74c75cc1e33080a47f87b8e58b1c6.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num2))
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
									GpsLink gpsLink = c191eb51d5e7a8e5cb44349bc37a21eed.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c8cc868d04e1dfd4c2cc63cba0bf97d5e.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num), c8cc868d04e1dfd4c2cc63cba0bf97d5e.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num2), b);
									c326b89bd66701e3c8652f899e093fe21.c30767ddca1f9c207888833aea5b5fc61(this.c322d2adbf9066ebe7e92167104f39cf6, gpsLink);
									c326b89bd66701e3c8652f899e093fe21.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(c8cc868d04e1dfd4c2cc63cba0bf97d5e.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num)), gpsLink);
									c326b89bd66701e3c8652f899e093fe21.c30767ddca1f9c207888833aea5b5fc61(c276defd7de4fd818ee1f011f0efd09c4.c30767ddca1f9c207888833aea5b5fc61(c8cc868d04e1dfd4c2cc63cba0bf97d5e.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num2)), gpsLink);
								}
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
					finally
					{
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x001308F4 File Offset: 0x0012EAF4
		private void c6b8d25a9e428d53871f6b871f1249647()
		{
			this.c95a098eee16f9571540081368c35a50b = c727f943c0cc73dd1b63e8ba6e48cbc4a.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				try
				{
					c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198378));
					cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92032));
					c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92036)));
							double num2 = SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92040)));
							double num3 = SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92044)));
							double num4 = SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92048)));
							if (num4 == c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92052))
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
									RuntimeMethodHandle arg_FF_0 = methodof(Gps.c6b8d25a9e428d53871f6b871f1249647()).MethodHandle;
								}
								num4 = c1d38c2ea2f9a2466bd539cf9d0a91fd5.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9, num2, num3);
							}
							string text = SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92060)));
							double num5 = SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92064)));
							c7abffbbb4ad451a5c98b5ae0087e8dea.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b, num, c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num, num2, num3, num4, num5, text));
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00130B20 File Offset: 0x0012ED20
		public bool LoadDataBase(byte[] dbArray)
		{
			FileInfo fileInfo = c0f2ef7569395ef9f3430d5bbbd9ee915.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc3530daca963402a2da97c2a7e831f7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			cd4a87541367a696341e5efa2753171c6.c30767ddca1f9c207888833aea5b5fc61(fileInfo, (FileAttributes)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92068));
			FileStream fileStream = c4de88fc237fdd806c5566641bd5659a2.c30767ddca1f9c207888833aea5b5fc61(fileInfo, (FileMode)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92072), (FileAccess)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92076), (FileShare)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92080));
			try
			{
				c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(fileStream, dbArray, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92084), (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(dbArray));
				cd681a68a6a3ae526e081c7396934ab7a.c30767ddca1f9c207888833aea5b5fc61(fileStream);
			}
			finally
			{
				if (fileStream != null)
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
						RuntimeMethodHandle arg_7D_0 = methodof(Gps.LoadDataBase(byte[])).MethodHandle;
					}
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(fileStream);
				}
			}
			this.cda516c7c62459624bd3c5ebb45c6c07c = cd4a77092a514a90c6c6e193fa9d9610d.c30767ddca1f9c207888833aea5b5fc61(fileInfo);
			try
			{
				this.c3e76590440c7f603f07fda2f71aada9b = ca5df9d0a1226b87a84f42db9aeea1de2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				c518617644be08d27fac23e9d2d4dfcb8.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148886), this.cda516c7c62459624bd3c5ebb45c6c07c));
				c033e704b3c5a39a78bce01524463c50d.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b);
				this.c6b8d25a9e428d53871f6b871f1249647();
				this.cde8c51a32ce0c90710437faa0621b06c();
				this.ca013267df427bd5c25268779f5aea657();
				object arg_1CE_0 = this.ca124a9f406cda69b904f2eb04d553ab9;
				object[] array = c29725f8e0c43ce70a2859299f9d7ff49.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92088));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92092)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198465);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92096)] = c1471de9f177c5dc6011bf5c1e03d9d54.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92100)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198492);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92104)] = c2fd38130edb0742b9ffe13363e4fd91a.c30767ddca1f9c207888833aea5b5fc61(this.c322d2adbf9066ebe7e92167104f39cf6);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92108)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198517);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92112)] = c13a86cec2c28a9336df29e9686e25125.c30767ddca1f9c207888833aea5b5fc61(this.c6b913e516dd22e54f305f59243f0f251);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92116)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198540);
				c0fc332513b6df6f2dafebf2a49d1ec65.c30767ddca1f9c207888833aea5b5fc61(arg_1CE_0, c151cd8533ca5d3ae14400ca77d65e1b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92120) != 0);
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				c0fc332513b6df6f2dafebf2a49d1ec65.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198561), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92124) != 0);
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92128) != 0;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92132) != 0;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00130D80 File Offset: 0x0012EF80
		public bool LoadDataBase(string dbPath)
		{
			this.cda516c7c62459624bd3c5ebb45c6c07c = dbPath;
			try
			{
				this.c3e76590440c7f603f07fda2f71aada9b = ca5df9d0a1226b87a84f42db9aeea1de2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				c518617644be08d27fac23e9d2d4dfcb8.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148886), dbPath));
				c033e704b3c5a39a78bce01524463c50d.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b);
				this.c6b8d25a9e428d53871f6b871f1249647();
				this.cde8c51a32ce0c90710437faa0621b06c();
				this.ca013267df427bd5c25268779f5aea657();
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92136) != 0;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92140) != 0;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00130E18 File Offset: 0x0012F018
		public List<GpsPoint> GetAllGpsPoints()
		{
			if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Gps.GetAllGpsPoints()).MethodHandle;
				}
				return c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return c42426b546c2648e2711f225c541a34be.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b).ToList<GpsPoint>();
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00130E5C File Offset: 0x0012F05C
		public List<GpsLink> GetAllGpsLinks()
		{
			if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Gps.GetAllGpsLinks()).MethodHandle;
				}
				return c18074a99a8200dd5fc207134694a2875.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return this.c322d2adbf9066ebe7e92167104f39cf6.ToList<GpsLink>();
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00130E9C File Offset: 0x0012F09C
		public List<GpsPolygon> GetAllGpsPolygons()
		{
			if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Gps.GetAllGpsPolygons()).MethodHandle;
				}
				return c2097eee27c38c94e30fd508816914fa6.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return c8cf25128c5b61557b2d8dbc3ce6e7e8d.c30767ddca1f9c207888833aea5b5fc61(this.c6b913e516dd22e54f305f59243f0f251).ToList<GpsPolygon>();
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00130EE0 File Offset: 0x0012F0E0
		public GpsPoint GetNearestPoint(double X, double Y, double Z)
		{
			if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Gps.GetNearestPoint(double, double, double)).MethodHandle;
				}
				return null;
			}
			if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
				return null;
			}
			GpsPoint result = ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83;
			GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92144), X, Y, Z, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92148), "");
			try
			{
				double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92156);
				List<GpsPoint> list = c7d54c40fce0315e3ef6e577297913836.c8a754f5f2ca4adde825691a9c31a0e83;
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c95a098eee16f9571540081368c35a50b))
				{
					list = c42426b546c2648e2711f225c541a34be.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b).ToList<GpsPoint>();
				}
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92164); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92168))
				{
					double num2 = c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i), gpsPoint);
					if (num2 < num)
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
						num = c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i), gpsPoint);
						result = cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i);
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
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return result;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00131040 File Offset: 0x0012F240
		public GpsPoint GetNearestPoint()
		{
			if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Gps.GetNearestPoint()).MethodHandle;
				}
				return null;
			}
			if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
				return null;
			}
			GpsPoint result = ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83;
			GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92172), c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92176), "");
			try
			{
				double num = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92184);
				List<GpsPoint> list = c7d54c40fce0315e3ef6e577297913836.c8a754f5f2ca4adde825691a9c31a0e83;
				using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c95a098eee16f9571540081368c35a50b))
				{
					list = c42426b546c2648e2711f225c541a34be.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b).ToList<GpsPoint>();
				}
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92192); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92196))
				{
					double num2 = c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i), gpsPoint);
					if (num2 < num)
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
						num = c0362232c491ca58bdb99608e43e2b0d7.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i), gpsPoint);
						result = cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i);
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
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return result;
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x001311D8 File Offset: 0x0012F3D8
		public GpsPoint GetPoint(string pointName)
		{
			if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Gps.GetPoint(string)).MethodHandle;
				}
				return null;
			}
			if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
				return null;
			}
			List<GpsPoint> list = c7d54c40fce0315e3ef6e577297913836.c8a754f5f2ca4adde825691a9c31a0e83;
			using (c510eb9572ed0b37f92189c7bf3956f0c.c4396d6bd45e9d8b753ca9a31011506a7(this.c95a098eee16f9571540081368c35a50b))
			{
				list = c42426b546c2648e2711f225c541a34be.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b).ToList<GpsPoint>();
			}
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92200); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92208))
			{
				if (c9ac89a7ed7b586a49cb760e57a07f8c5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf1a3d916b3076cfc5853a7fc3a0c02da.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i)), pointName, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92204) != 0) == 0)
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
					return cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i);
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
			return null;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x001312D0 File Offset: 0x0012F4D0
		public List<GpsPoint> GpsGetPath(double X, double Y, double Z)
		{
			try
			{
				List<GpsPoint> result;
				if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Gps.GpsGetPath(double, double, double)).MethodHandle;
					}
					result = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					return result;
				}
				if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
					result = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					return result;
				}
				GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92212), c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92216), "");
				GpsPoint gpsPoint2 = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92224), X, Y, Z, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92228), "");
				result = this.ca161ffc91a2f558a6ede844b40467830(gpsPoint, gpsPoint2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92236) != 0);
				return result;
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x001313F0 File Offset: 0x0012F5F0
		public List<GpsPoint> GpsGetPath(GpsPoint endPoint)
		{
			try
			{
				List<GpsPoint> result;
				if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Gps.GpsGetPath(GpsPoint)).MethodHandle;
					}
					result = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					return result;
				}
				if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
					result = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					return result;
				}
				GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92240), c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92244), "");
				result = this.ca161ffc91a2f558a6ede844b40467830(gpsPoint, endPoint, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92252) != 0);
				return result;
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x001314E8 File Offset: 0x0012F6E8
		public List<GpsPoint> GpsGetPath(GpsPoint startPoint, GpsPoint endPoint)
		{
			try
			{
				List<GpsPoint> result;
				if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Gps.GpsGetPath(GpsPoint, GpsPoint)).MethodHandle;
					}
					if (startPoint != null)
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
						if (endPoint != null)
						{
							result = this.ca161ffc91a2f558a6ede844b40467830(startPoint, endPoint, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92256) != 0);
							return result;
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
				}
				result = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				return result;
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00131574 File Offset: 0x0012F774
		public List<GpsPoint> GpsGetPath(string endPointName)
		{
			try
			{
				List<GpsPoint> result;
				if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Gps.GpsGetPath(string)).MethodHandle;
					}
					result = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					return result;
				}
				if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
					result = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					return result;
				}
				GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92260), c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92264), "");
				result = this.ca161ffc91a2f558a6ede844b40467830(gpsPoint, endPointName);
				return result;
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00131664 File Offset: 0x0012F864
		public void SuspendGpsMove()
		{
			if (!cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					RuntimeMethodHandle arg_1C_0 = methodof(Gps.SuspendGpsMove()).MethodHandle;
				}
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198620));
			}
			c7ca59606856badba986257cf130abbac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92272) != 0);
			c577dd13a3f94eb68c02a5016ff34100e.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9);
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x001316BC File Offset: 0x0012F8BC
		public void ResumeGpsMove()
		{
			if (cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
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
					RuntimeMethodHandle arg_1C_0 = methodof(Gps.ResumeGpsMove()).MethodHandle;
				}
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198675));
			}
			c7ca59606856badba986257cf130abbac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92276) != 0);
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00131708 File Offset: 0x0012F908
		public bool GpsMove(double X, double Y, double Z, double doneDist = 0.0)
		{
			try
			{
				if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Gps.GpsMove(double, double, double, double)).MethodHandle;
					}
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92280) != 0;
					return result;
				}
				if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92284) != 0;
					return result;
				}
				GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92288), c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92292), "");
				GpsPoint gpsPoint2 = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92300), X, Y, Z, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92304), "");
				List<GpsPoint> list = this.ca161ffc91a2f558a6ede844b40467830(gpsPoint, gpsPoint2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92312) != 0);
				if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92316))
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
					bool result;
					for (int i = c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92320); i >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92368); i -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92364))
					{
						if (this.ce778f81f0bb27af81ac145937c3b96db != null)
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
							c8894b632c8e44658e714d8efcf47057a.c30767ddca1f9c207888833aea5b5fc61(this.ce778f81f0bb27af81ac145937c3b96db, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						}
						if (this.gpsMoveCancelRequested)
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
							this.gpsMoveCancelRequested = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92324) != 0);
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92328) != 0);
							return result;
						}
						object arg_1EF_0 = this.ca124a9f406cda69b904f2eb04d553ab9;
						double expr_197 = c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						double expr_1A7 = cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						double expr_1B7 = cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						double arg_1EF_5;
						if (i <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92332))
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
							arg_1EF_5 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92336);
						}
						else
						{
							arg_1EF_5 = doneDist + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92344);
						}
						if (!c9eaec6907d10515a4af1074e506ca65e.c30767ddca1f9c207888833aea5b5fc61(arg_1EF_0, expr_197, expr_1A7, expr_1B7, doneDist, arg_1EF_5))
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
							if (!cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
							{
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92360) != 0);
								return result;
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
							while (cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
							{
								c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92352));
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
							if (this.c68fbfec6e0d561d4fd3485de9ed542d7 != null)
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
								ce62ddbab8002443bf5ae216f015ee815.c30767ddca1f9c207888833aea5b5fc61(this.c68fbfec6e0d561d4fd3485de9ed542d7, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
							}
							i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92356);
						}
						else if (this.c68fbfec6e0d561d4fd3485de9ed542d7 != null)
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
							ce62ddbab8002443bf5ae216f015ee815.c30767ddca1f9c207888833aea5b5fc61(this.c68fbfec6e0d561d4fd3485de9ed542d7, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
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
					cfc24b42d613b819e8339efdf9efb650a.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9, X, Y, Z);
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92372) != 0);
					return result;
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92376) != 0;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00131A44 File Offset: 0x0012FC44
		public bool GpsMove(GpsPoint endPoint, double doneDist = 0.0)
		{
			try
			{
				bool result;
				if (this.ca124a9f406cda69b904f2eb04d553ab9 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Gps.GpsMove(GpsPoint, double)).MethodHandle;
					}
					if (endPoint == null)
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
						if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92384) != 0);
							return result;
						}
						GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92388), c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92392), "");
						List<GpsPoint> list = this.ca161ffc91a2f558a6ede844b40467830(gpsPoint, endPoint, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92400) != 0);
						if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92404))
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
							for (int i = c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92408); i >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92456); i -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92452))
							{
								if (this.ce778f81f0bb27af81ac145937c3b96db != null)
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
									c8894b632c8e44658e714d8efcf47057a.c30767ddca1f9c207888833aea5b5fc61(this.ce778f81f0bb27af81ac145937c3b96db, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
								}
								if (this.gpsMoveCancelRequested)
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
									this.gpsMoveCancelRequested = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92412) != 0);
									result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92416) != 0);
									return result;
								}
								object arg_1D4_0 = this.ca124a9f406cda69b904f2eb04d553ab9;
								double expr_17E = c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
								double expr_18E = cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
								double expr_19E = cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
								double arg_1D4_5;
								if (i <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92420))
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
									arg_1D4_5 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92424);
								}
								else
								{
									arg_1D4_5 = doneDist + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92432);
								}
								if (!c9eaec6907d10515a4af1074e506ca65e.c30767ddca1f9c207888833aea5b5fc61(arg_1D4_0, expr_17E, expr_18E, expr_19E, doneDist, arg_1D4_5))
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
									if (!cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
									{
										result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92448) != 0);
										return result;
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
									while (cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
									{
										c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92440));
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
									if (this.c68fbfec6e0d561d4fd3485de9ed542d7 != null)
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
										ce62ddbab8002443bf5ae216f015ee815.c30767ddca1f9c207888833aea5b5fc61(this.c68fbfec6e0d561d4fd3485de9ed542d7, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
									}
									i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92444);
								}
								else if (this.c68fbfec6e0d561d4fd3485de9ed542d7 != null)
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
									ce62ddbab8002443bf5ae216f015ee815.c30767ddca1f9c207888833aea5b5fc61(this.c68fbfec6e0d561d4fd3485de9ed542d7, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
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
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92460) != 0);
							return result;
						}
						goto IL_2D6;
					}
				}
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92380) != 0);
				return result;
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			IL_2D6:
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92464) != 0;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00131D50 File Offset: 0x0012FF50
		public bool GpsMove(string endPointName, double doneDist = 0.0)
		{
			try
			{
				if (this.ca124a9f406cda69b904f2eb04d553ab9 == null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Gps.GpsMove(string, double)).MethodHandle;
					}
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92468) != 0;
					return result;
				}
				if (cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9) == null)
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
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92472) != 0;
					return result;
				}
				GpsPoint gpsPoint = c5909c6f25f78885d23dfd0d74132020a.c0cf59c3e67a46fd4edb3040c5ab0bbfb((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92476), c6fb106c4a050cb4c0de6f0e1e1744d58.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cac47f7f7557afe4776ec97f5dda1c910.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), cd3e41a1312c8f9afc0411c366b617616.c30767ddca1f9c207888833aea5b5fc61(cef4019025578102d86b53db9916b8bbe.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9)), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92480), "");
				List<GpsPoint> list = this.ca161ffc91a2f558a6ede844b40467830(gpsPoint, endPointName);
				if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92488))
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
					bool result;
					for (int i = c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list) - c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92492); i >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92540); i -= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92536))
					{
						if (this.ce778f81f0bb27af81ac145937c3b96db != null)
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
							c8894b632c8e44658e714d8efcf47057a.c30767ddca1f9c207888833aea5b5fc61(this.ce778f81f0bb27af81ac145937c3b96db, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						}
						if (this.gpsMoveCancelRequested)
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
							this.gpsMoveCancelRequested = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92496) != 0);
							result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92500) != 0);
							return result;
						}
						object arg_1BD_0 = this.ca124a9f406cda69b904f2eb04d553ab9;
						double expr_167 = c320ca58d53ded23deb9158a3051f3103.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						double expr_177 = cbc3fa3988b958b1b3e95702aeeb2287d.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						double expr_187 = cfdc1cb8002f3f417502586add62b2dde.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						double arg_1BD_5;
						if (i <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92504))
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
							arg_1BD_5 = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92508);
						}
						else
						{
							arg_1BD_5 = doneDist + c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92516);
						}
						if (!c9eaec6907d10515a4af1074e506ca65e.c30767ddca1f9c207888833aea5b5fc61(arg_1BD_0, expr_167, expr_177, expr_187, doneDist, arg_1BD_5))
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
							if (!cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
							{
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92532) != 0);
								return result;
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
							while (cd0895628739b4eb0e23ec6d1407e09c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this))
							{
								c8d5abdf6ddb3bfdef1d6f761aaf72e7f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92524));
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
							if (this.c68fbfec6e0d561d4fd3485de9ed542d7 != null)
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
								ce62ddbab8002443bf5ae216f015ee815.c30767ddca1f9c207888833aea5b5fc61(this.c68fbfec6e0d561d4fd3485de9ed542d7, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
							}
							i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92528);
						}
						else if (this.c68fbfec6e0d561d4fd3485de9ed542d7 != null)
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
							ce62ddbab8002443bf5ae216f015ee815.c30767ddca1f9c207888833aea5b5fc61(this.c68fbfec6e0d561d4fd3485de9ed542d7, cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list, i));
						}
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
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92544) != 0);
					return result;
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92548) != 0;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00132048 File Offset: 0x00130248
		private List<GpsPoint> ca161ffc91a2f558a6ede844b40467830(GpsPoint gpsPoint, GpsPoint gpsPoint2, bool flag)
		{
			List<GpsPoint> list = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				GpsPoint gpsPoint3 = ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83;
				c284733691b3d2cd74400c62784ae6d62 c284733691b3d2cd74400c62784ae6d = new c284733691b3d2cd74400c62784ae6d62(c42426b546c2648e2711f225c541a34be.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b).ToList<GpsPoint>(), c658c34c9d02186b9d267798f9fb247b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				while (true)
				{
					list = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					gpsPoint3 = c284733691b3d2cd74400c62784ae6d.cc7e6a8da0639bc08863964a84afc1eee(gpsPoint);
					if (flag)
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
							RuntimeMethodHandle arg_57_0 = methodof(Gps.ca161ffc91a2f558a6ede844b40467830(GpsPoint, GpsPoint, bool)).MethodHandle;
						}
						gpsPoint2 = c284733691b3d2cd74400c62784ae6d.cc7e6a8da0639bc08863964a84afc1eee(gpsPoint2);
					}
					if (gpsPoint3 == null)
					{
						break;
					}
					if (gpsPoint2 == null)
					{
						goto IL_92;
					}
					if (gpsPoint3 == gpsPoint2)
					{
						goto IL_BD;
					}
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92560); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92576))
					{
						ca3c745e20b491326fcd00d15903d9ccd.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d), i), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92564));
						c63ab114c39d7254304b05dfa8da2e51b.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d), i), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92572) != 0);
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
					ca3c745e20b491326fcd00d15903d9ccd.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92580));
					c63ab114c39d7254304b05dfa8da2e51b.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92588) != 0);
					c284733691b3d2cd74400c62784ae6d.c64f5b80ea817e1e3940b224801a7944b(gpsPoint3);
					List<GpsPoint>.Enumerator enumerator = c6cf7a7b994fef50740f898924b71c374.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d.c016b45b05fad36ad7cdb9f8529693609(gpsPoint2, this.ca124a9f406cda69b904f2eb04d553ab9));
					try
					{
						while (cdd2430fc8704825cc9e7d3556d0eabd2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
						{
							GpsPoint gpsPoint4 = c54aaf40bc4009bd70415fee5a608dee5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
							c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, gpsPoint4);
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
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					if (c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92592))
					{
						goto IL_1DD;
					}
					List<GpsPoint> list2 = cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d).ToList<GpsPoint>();
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92600); j < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list2); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92612))
					{
						if (c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list2, j)) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92604))
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
							c42c090f6a8405436ece53d0739b5fdd9.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d), cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list2, j));
						}
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
					if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d)) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92616))
					{
						goto IL_297;
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
				c63e934aa9995114bc733a24223e4b54d.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9, (LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92552));
				List<GpsPoint> result = list;
				return result;
				while (true)
				{
					IL_92:
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				c63e934aa9995114bc733a24223e4b54d.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9, (LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92556));
				result = list;
				return result;
				while (true)
				{
					IL_BD:
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, gpsPoint2);
				result = list;
				return result;
				while (true)
				{
					IL_1DD:
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				result = list;
				return result;
				while (true)
				{
					IL_297:
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return list;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00132344 File Offset: 0x00130544
		private List<GpsPoint> ca161ffc91a2f558a6ede844b40467830(GpsPoint gpsPoint, string text)
		{
			List<GpsPoint> list = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				GpsPoint gpsPoint2 = ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83;
				GpsPoint gpsPoint3 = ccbe2f10e31f551d5f5208faac5f1cb0c.c8a754f5f2ca4adde825691a9c31a0e83;
				c284733691b3d2cd74400c62784ae6d62 c284733691b3d2cd74400c62784ae6d = new c284733691b3d2cd74400c62784ae6d62(c42426b546c2648e2711f225c541a34be.c30767ddca1f9c207888833aea5b5fc61(this.c95a098eee16f9571540081368c35a50b).ToList<GpsPoint>(), c658c34c9d02186b9d267798f9fb247b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
				while (true)
				{
					list = c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					gpsPoint2 = c284733691b3d2cd74400c62784ae6d.cc7e6a8da0639bc08863964a84afc1eee(gpsPoint);
					gpsPoint3 = c284733691b3d2cd74400c62784ae6d.ceb3897aea985ced8d780ac5d0256285a(text);
					if (gpsPoint2 == null)
					{
						break;
					}
					if (gpsPoint3 == null)
					{
						goto IL_88;
					}
					if (gpsPoint2 == gpsPoint3)
					{
						goto IL_B3;
					}
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92628); i < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92644))
					{
						ca3c745e20b491326fcd00d15903d9ccd.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d), i), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92632));
						c63ab114c39d7254304b05dfa8da2e51b.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d), i), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92640) != 0);
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
					ca3c745e20b491326fcd00d15903d9ccd.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92648));
					c63ab114c39d7254304b05dfa8da2e51b.c30767ddca1f9c207888833aea5b5fc61(gpsPoint2, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92656) != 0);
					c284733691b3d2cd74400c62784ae6d.c64f5b80ea817e1e3940b224801a7944b(gpsPoint2);
					List<GpsPoint>.Enumerator enumerator = c6cf7a7b994fef50740f898924b71c374.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d.c016b45b05fad36ad7cdb9f8529693609(gpsPoint3, this.ca124a9f406cda69b904f2eb04d553ab9));
					try
					{
						while (cdd2430fc8704825cc9e7d3556d0eabd2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator))
						{
							GpsPoint gpsPoint4 = c54aaf40bc4009bd70415fee5a608dee5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref enumerator);
							c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, gpsPoint4);
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
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					if (c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(gpsPoint3) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92660))
					{
						goto IL_1D9;
					}
					List<GpsPoint> list2 = cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d).ToList<GpsPoint>();
					for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92668); j < c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(list2); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92680))
					{
						if (c8ea079f8a6797b6ffe96dd6a45bf83a3.c30767ddca1f9c207888833aea5b5fc61(cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list2, j)) != c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92672))
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
							c42c090f6a8405436ece53d0739b5fdd9.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d), cf6b22f62eef8054bf9e738af4caf6782.c30767ddca1f9c207888833aea5b5fc61(list2, j));
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
					if (c0775236ea46dbb67ef79246956fcf667.c30767ddca1f9c207888833aea5b5fc61(cde7399d789393ba59de2f063c452b993.c30767ddca1f9c207888833aea5b5fc61(c284733691b3d2cd74400c62784ae6d)) <= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92684))
					{
						goto IL_293;
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
				if (!true)
				{
					RuntimeMethodHandle arg_67_0 = methodof(Gps.ca161ffc91a2f558a6ede844b40467830(GpsPoint, string)).MethodHandle;
				}
				c63e934aa9995114bc733a24223e4b54d.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9, (LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92620));
				List<GpsPoint> result = list;
				return result;
				while (true)
				{
					IL_88:
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				c63e934aa9995114bc733a24223e4b54d.c30767ddca1f9c207888833aea5b5fc61(this.ca124a9f406cda69b904f2eb04d553ab9, (LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92624));
				result = list;
				return result;
				while (true)
				{
					IL_B3:
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				c2692faffed11a59a137c2738a6327d08.c30767ddca1f9c207888833aea5b5fc61(list, gpsPoint3);
				result = list;
				return result;
				while (true)
				{
					IL_1D9:
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				result = list;
				return result;
				while (true)
				{
					IL_293:
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			catch (Exception ex)
			{
				c6fae2e4884eaf730c061e96bdc45ddaa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
			}
			return list;
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0013263C File Offset: 0x0013083C
		private List<GpsPoint> cc7322060e5884bbdab7724d920d2d9a0(GpsPoint gpsPoint, GpsPoint gpsPoint2)
		{
			return c1462e794a80d606a8564e1572251cfff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00132654 File Offset: 0x00130854
		[CompilerGenerated]
		private static double ccb135a86d7c38e7b89a6ee9999fbcb36(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f)
		{
			return c03bf2d133a4ae9bb56cb05a7615328f.c342e51a09e3b7933934f9dd072ac3722;
		}

		// Token: 0x0400134A RID: 4938
		private List<GpsLink> c322d2adbf9066ebe7e92167104f39cf6;

		// Token: 0x0400134B RID: 4939
		private Dictionary<uint, GpsPolygon> c6b913e516dd22e54f305f59243f0f251;

		// Token: 0x0400134C RID: 4940
		private Dictionary<uint, GpsPoint> c95a098eee16f9571540081368c35a50b;

		// Token: 0x0400134D RID: 4941
		private Core ca124a9f406cda69b904f2eb04d553ab9;

		// Token: 0x0400134E RID: 4942
		private string cda516c7c62459624bd3c5ebb45c6c07c;

		// Token: 0x0400134F RID: 4943
		private SQLiteConnection c3e76590440c7f603f07fda2f71aada9b;

		// Token: 0x04001350 RID: 4944
		private SQLiteDataReader c00f66411c697a0fd0527c2c113d211f0;

		// Token: 0x04001351 RID: 4945
		private CoreInternal.GpsPreMove ce778f81f0bb27af81ac145937c3b96db;

		// Token: 0x04001352 RID: 4946
		private CoreInternal.GpsPostMove c68fbfec6e0d561d4fd3485de9ed542d7;

		// Token: 0x04001353 RID: 4947
		public bool gpsMoveCancelRequested;

		// Token: 0x04001354 RID: 4948
		[CompilerGenerated]
		private bool c23c489d4dda23dd68c46343b020763a5;

		// Token: 0x04001355 RID: 4949
		[CompilerGenerated]
		private double c2b4e15fd0a8eb70939bc874e56bd2526;

		// Token: 0x04001356 RID: 4950
		[CompilerGenerated]
		private static Func<Gps.c03bf2d133a4ae9bb56cb05a7615328f8, double> c3444fefa19358f4a5e6d401dacac9dc8;

		// Token: 0x02000551 RID: 1361
		[DefaultMember("Item")]
		private sealed class c03bf2d133a4ae9bb56cb05a7615328f8
		{
			// Token: 0x06001E27 RID: 7719 RVA: 0x00132668 File Offset: 0x00130868
			public c03bf2d133a4ae9bb56cb05a7615328f8(double num, double num2, double num3)
			{
				this.c5ed806d2bb2197e7a4cc678385a2e6a1 = num;
				this.ce3da4123359df388eefe0c5b68072b14 = num2;
				this.c15aa95c996f022a57045b8c635aa8e1e = num3;
				this.ca60926422c211bd767ddfdcc177d9ba7();
			}

			// Token: 0x06001E28 RID: 7720 RVA: 0x00132698 File Offset: 0x00130898
			public c03bf2d133a4ae9bb56cb05a7615328f8() : this(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92848), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92856), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92864))
			{
			}

			// Token: 0x06001E29 RID: 7721 RVA: 0x001326D0 File Offset: 0x001308D0
			public c03bf2d133a4ae9bb56cb05a7615328f8(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f) : this(c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e(), c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec(), c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914())
			{
			}

			// Token: 0x06001E2A RID: 7722 RVA: 0x001326FC File Offset: 0x001308FC
			public double get_c3071642cc772d7d0223fbcc438c3ff3e()
			{
				return this.c5ed806d2bb2197e7a4cc678385a2e6a1;
			}

			// Token: 0x06001E2B RID: 7723 RVA: 0x00132710 File Offset: 0x00130910
			public void set_c3071642cc772d7d0223fbcc438c3ff3e(double num)
			{
				this.c5ed806d2bb2197e7a4cc678385a2e6a1 = num;
				this.ca60926422c211bd767ddfdcc177d9ba7();
			}

			// Token: 0x06001E2C RID: 7724 RVA: 0x0013272C File Offset: 0x0013092C
			public double get_c039bd5f7ee0b10e3324f3380089087ec()
			{
				return this.ce3da4123359df388eefe0c5b68072b14;
			}

			// Token: 0x06001E2D RID: 7725 RVA: 0x00132740 File Offset: 0x00130940
			public void set_c039bd5f7ee0b10e3324f3380089087ec(double num)
			{
				this.ce3da4123359df388eefe0c5b68072b14 = num;
				this.ca60926422c211bd767ddfdcc177d9ba7();
			}

			// Token: 0x06001E2E RID: 7726 RVA: 0x0013275C File Offset: 0x0013095C
			public double get_c3d23e1cbcae9438226f42183a707c914()
			{
				return this.c15aa95c996f022a57045b8c635aa8e1e;
			}

			// Token: 0x06001E2F RID: 7727 RVA: 0x00132770 File Offset: 0x00130970
			public void set_c3d23e1cbcae9438226f42183a707c914(double num)
			{
				this.c15aa95c996f022a57045b8c635aa8e1e = num;
				this.ca60926422c211bd767ddfdcc177d9ba7();
			}

			// Token: 0x06001E30 RID: 7728 RVA: 0x0013278C File Offset: 0x0013098C
			public double get_cdda15bc781996658cf11df53e21a484f()
			{
				return this.c609cc75d756ceea3a2171b37a72d2727;
			}

			// Token: 0x06001E31 RID: 7729 RVA: 0x001327A0 File Offset: 0x001309A0
			private void ca60926422c211bd767ddfdcc177d9ba7()
			{
				this.c609cc75d756ceea3a2171b37a72d2727 = cdfe9014d02101a49c91049e7d709b638.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c5ed806d2bb2197e7a4cc678385a2e6a1, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92696)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.ce3da4123359df388eefe0c5b68072b14, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92704)) + ca04344691cbff0e94221693e81b4c43a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c15aa95c996f022a57045b8c635aa8e1e, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92712)));
			}

			// Token: 0x06001E32 RID: 7730 RVA: 0x00132808 File Offset: 0x00130A08
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 cfe268acd3e87e425ce1fab39528ad51c(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f, Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f2)
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() + c03bf2d133a4ae9bb56cb05a7615328f2.get_c3071642cc772d7d0223fbcc438c3ff3e(), c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() + c03bf2d133a4ae9bb56cb05a7615328f2.get_c039bd5f7ee0b10e3324f3380089087ec(), c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() + c03bf2d133a4ae9bb56cb05a7615328f2.get_c3d23e1cbcae9438226f42183a707c914());
			}

			// Token: 0x06001E33 RID: 7731 RVA: 0x00132850 File Offset: 0x00130A50
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c0f66cd4e32688f3d39db1af012622e8b(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f, Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f2)
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() - c03bf2d133a4ae9bb56cb05a7615328f2.get_c3071642cc772d7d0223fbcc438c3ff3e(), c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() - c03bf2d133a4ae9bb56cb05a7615328f2.get_c039bd5f7ee0b10e3324f3380089087ec(), c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() - c03bf2d133a4ae9bb56cb05a7615328f2.get_c3d23e1cbcae9438226f42183a707c914());
			}

			// Token: 0x06001E34 RID: 7732 RVA: 0x00132898 File Offset: 0x00130A98
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c7ab060b24c303508e207f7efe340e497(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f)
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c03bf2d133a4ae9bb56cb05a7615328f);
			}

			// Token: 0x06001E35 RID: 7733 RVA: 0x001328AC File Offset: 0x00130AAC
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 cfba61c26193a42f78cb22b892696fb54(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f)
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(-c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e(), -c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec(), -c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914());
			}

			// Token: 0x06001E36 RID: 7734 RVA: 0x001328DC File Offset: 0x00130ADC
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 cd63ef2644230482b49a6f6524d18ca00(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f, double num)
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() * num, c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() * num, c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() * num);
			}

			// Token: 0x06001E37 RID: 7735 RVA: 0x0013290C File Offset: 0x00130B0C
			public static bool c9dfe27a44d67c0e563cd206c4241873e(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f, Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f2)
			{
				if (c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() == c03bf2d133a4ae9bb56cb05a7615328f2.get_c3071642cc772d7d0223fbcc438c3ff3e())
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
						RuntimeMethodHandle arg_24_0 = methodof(Gps.c03bf2d133a4ae9bb56cb05a7615328f8.c9dfe27a44d67c0e563cd206c4241873e(Gps.c03bf2d133a4ae9bb56cb05a7615328f8, Gps.c03bf2d133a4ae9bb56cb05a7615328f8)).MethodHandle;
					}
					if (c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() == c03bf2d133a4ae9bb56cb05a7615328f2.get_c039bd5f7ee0b10e3324f3380089087ec())
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
						if (c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() == c03bf2d133a4ae9bb56cb05a7615328f2.get_c3d23e1cbcae9438226f42183a707c914())
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
							return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92720) != 0;
						}
					}
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92724) != 0;
			}

			// Token: 0x06001E38 RID: 7736 RVA: 0x0013298C File Offset: 0x00130B8C
			public override bool Equals(object obj)
			{
				return Gps.c03bf2d133a4ae9bb56cb05a7615328f8.c9dfe27a44d67c0e563cd206c4241873e(this, (Gps.c03bf2d133a4ae9bb56cb05a7615328f8)obj);
			}

			// Token: 0x06001E39 RID: 7737 RVA: 0x001329A8 File Offset: 0x00130BA8
			public override int GetHashCode()
			{
				return c3d7f01bd1ce1f2ce9a99c7dbf9532eff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this);
			}

			// Token: 0x06001E3A RID: 7738 RVA: 0x001329C0 File Offset: 0x00130BC0
			public static bool cc5340be84f23cc1f8b9f85af89f0feb5(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f, Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f2)
			{
				if (!Gps.c03bf2d133a4ae9bb56cb05a7615328f8.c9dfe27a44d67c0e563cd206c4241873e(c03bf2d133a4ae9bb56cb05a7615328f, c03bf2d133a4ae9bb56cb05a7615328f2))
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
						RuntimeMethodHandle arg_1D_0 = methodof(Gps.c03bf2d133a4ae9bb56cb05a7615328f8.cc5340be84f23cc1f8b9f85af89f0feb5(Gps.c03bf2d133a4ae9bb56cb05a7615328f8, Gps.c03bf2d133a4ae9bb56cb05a7615328f8)).MethodHandle;
					}
					return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92728) != 0;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92732) != 0;
			}

			// Token: 0x06001E3B RID: 7739 RVA: 0x00132A00 File Offset: 0x00130C00
			public static double cc26287f00b796a08e51cd03c10be11b5(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f, Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f2)
			{
				return c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c3071642cc772d7d0223fbcc438c3ff3e() + c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c039bd5f7ee0b10e3324f3380089087ec() + c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c3d23e1cbcae9438226f42183a707c914();
			}

			// Token: 0x06001E3C RID: 7740 RVA: 0x00132A44 File Offset: 0x00130C44
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 cd63ef2644230482b49a6f6524d18ca00(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f, Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f2)
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c3d23e1cbcae9438226f42183a707c914() - c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c039bd5f7ee0b10e3324f3380089087ec(), c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c3d23e1cbcae9438226f42183a707c914() - c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c3071642cc772d7d0223fbcc438c3ff3e(), c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c039bd5f7ee0b10e3324f3380089087ec() - c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() * c03bf2d133a4ae9bb56cb05a7615328f2.get_c3071642cc772d7d0223fbcc438c3ff3e());
			}

			// Token: 0x06001E3D RID: 7741 RVA: 0x00132AC0 File Offset: 0x00130CC0
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 ce94d2e177e8bcf152c2159e15c66ff1e(Gps.c03bf2d133a4ae9bb56cb05a7615328f8 c03bf2d133a4ae9bb56cb05a7615328f)
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c03bf2d133a4ae9bb56cb05a7615328f.get_c3071642cc772d7d0223fbcc438c3ff3e() / c03bf2d133a4ae9bb56cb05a7615328f.get_cdda15bc781996658cf11df53e21a484f(), c03bf2d133a4ae9bb56cb05a7615328f.get_c039bd5f7ee0b10e3324f3380089087ec() / c03bf2d133a4ae9bb56cb05a7615328f.get_cdda15bc781996658cf11df53e21a484f(), c03bf2d133a4ae9bb56cb05a7615328f.get_c3d23e1cbcae9438226f42183a707c914() / c03bf2d133a4ae9bb56cb05a7615328f.get_cdda15bc781996658cf11df53e21a484f());
			}

			// Token: 0x06001E3E RID: 7742 RVA: 0x00132B08 File Offset: 0x00130D08
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 get_cee191eac90746c8bbe54b91739e39bd7()
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92736), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92744), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92752));
			}

			// Token: 0x06001E3F RID: 7743 RVA: 0x00132B40 File Offset: 0x00130D40
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 get_c3d3d8a21e4731b3e052dcdff7b4d5d3d()
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92760), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92768), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92776));
			}

			// Token: 0x06001E40 RID: 7744 RVA: 0x00132B78 File Offset: 0x00130D78
			public static Gps.c03bf2d133a4ae9bb56cb05a7615328f8 get_c38b7452dfcc02ba39385302934bec9ac()
			{
				return new Gps.c03bf2d133a4ae9bb56cb05a7615328f8(c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92784), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92792), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(92800));
			}

			// Token: 0x06001E41 RID: 7745 RVA: 0x00132BB0 File Offset: 0x00130DB0
			public double get_cd2ea9ece8c94981464466cc31c4d5bc7(long num)
			{
				if (num <= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92808))
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
						RuntimeMethodHandle arg_22_0 = methodof(Gps.c03bf2d133a4ae9bb56cb05a7615328f8.get_cd2ea9ece8c94981464466cc31c4d5bc7(long)).MethodHandle;
					}
					if (num >= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92812))
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
						switch ((int)num)
						{
						case 0:
							return this.c5ed806d2bb2197e7a4cc678385a2e6a1;
						case 1:
							return this.ce3da4123359df388eefe0c5b68072b14;
						case 2:
							return this.c15aa95c996f022a57045b8c635aa8e1e;
						case 3:
							return this.c609cc75d756ceea3a2171b37a72d2727;
						}
					}
				}
				throw c38be7fb2f7809050ce4393267e0606a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198732));
			}

			// Token: 0x06001E42 RID: 7746 RVA: 0x00132C40 File Offset: 0x00130E40
			public void set_cd2ea9ece8c94981464466cc31c4d5bc7(long num, double num2)
			{
				if (num <= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92816))
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
						RuntimeMethodHandle arg_22_0 = methodof(Gps.c03bf2d133a4ae9bb56cb05a7615328f8.set_cd2ea9ece8c94981464466cc31c4d5bc7(long, double)).MethodHandle;
					}
					if (num >= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92820))
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
						switch ((int)num)
						{
						case 0:
							this.c5ed806d2bb2197e7a4cc678385a2e6a1 = num2;
							break;
						case 1:
							this.ce3da4123359df388eefe0c5b68072b14 = num2;
							break;
						case 2:
							this.c15aa95c996f022a57045b8c635aa8e1e = num2;
							break;
						default:
							goto IL_6B;
						}
						this.ca60926422c211bd767ddfdcc177d9ba7();
						return;
					}
				}
				IL_6B:
				throw c38be7fb2f7809050ce4393267e0606a4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(198795));
			}

			// Token: 0x06001E43 RID: 7747 RVA: 0x00132CD4 File Offset: 0x00130ED4
			public override string ToString()
			{
				string[] array = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92824));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92828)] = cef622fafe28457e2478e70d988b5f66d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c5ed806d2bb2197e7a4cc678385a2e6a1);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92832)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92836)] = cef622fafe28457e2478e70d988b5f66d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.ce3da4123359df388eefe0c5b68072b14);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92840)] = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(119792);
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(92844)] = cef622fafe28457e2478e70d988b5f66d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref this.c15aa95c996f022a57045b8c635aa8e1e);
				return c174b6d61e2761511f6d50f9e09e1fdfe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array);
			}

			// Token: 0x04001357 RID: 4951
			private double c5ed806d2bb2197e7a4cc678385a2e6a1;

			// Token: 0x04001358 RID: 4952
			private double ce3da4123359df388eefe0c5b68072b14;

			// Token: 0x04001359 RID: 4953
			private double c15aa95c996f022a57045b8c635aa8e1e;

			// Token: 0x0400135A RID: 4954
			private double c609cc75d756ceea3a2171b37a72d2727;

			// Token: 0x0400135B RID: 4955
			public double c342e51a09e3b7933934f9dd072ac3722;

			// Token: 0x0400135C RID: 4956
			public uint cb5905b594e11dea2f73932df05981674;
		}
	}
}
