using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.Xml;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.Bot
{
	// Token: 0x02000520 RID: 1312
	public class UserConfig : MarshalProxy
	{
		// Token: 0x06001B05 RID: 6917 RVA: 0x0011FFB8 File Offset: 0x0011E1B8
		internal UserConfig()
		{
			this.c50c70abbd13e5e460737ca8a34a5c3ef = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89572);
			this.c1daffd904de9135f5bf9fc885acb1487 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89576) != 0);
			this.c890fa772eb9ca4447b23e7078bdfdef8 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89580) != 0);
			this.c94ba0baf74614fb9b15ef7efcb5caebe = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89584);
			this.ca9444d23738ab81f33764c7e00abd7b1 = "";
			this.cc4705653bfce38f50acc8bcd9846ca8a = cabad7e3df3841c97f7c5aa47c5c3c2a1.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89588));
			this.c4acc318064facd12775e3989205b792e = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89592));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89596); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89608); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89604))
			{
				this.c4acc318064facd12775e3989205b792e[i] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89600);
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
				RuntimeMethodHandle arg_CA_0 = methodof(UserConfig..ctor()).MethodHandle;
			}
			this.c8594a1747ab9f31496f69767a3ac1aae = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89612) != 0);
			this.cfb66dbf82ef66dd92ab4fd6b6cec76a7 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89616) != 0);
			this.ca63cb6a314ddc85ec736985d44097823 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89620) != 0);
			this.c36d5ed8511b1b6fd12139623fb5cf0cc = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89624) != 0);
			this.c48ee0f01970d0ad05b4e8a00761a5980 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89628);
			this.ca41982f2c9edc8d06d1b216c67ee4f79 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89632);
			this.cce51e1e17f88dce193d6ac876fa89e7b = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89636);
			this.cac886a5981e22a94552b5a57d322cfe7 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89640);
			this.cfca2d9641710273e823d086244c6b4b3 = "";
			this.cee59da9bdeb9bc29a96223ba7a3483ad = "";
			this.c443aed8c1b749d92bf4dd7cbcd81127c = "";
			this.cd46f888da06603ee30a18f2c4a03da6a = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89644));
			this.c20746e758e988ea72543203553ef1693 = c2635cd22c5224fc276f4664f85b0ef33.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89648));
			this.ce29721088a97d949eba86df421305c2e = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89652) != 0);
			this.c923a6b1f691e0b9b61b319238f7a8217 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152126);
			this.c9a883e1927531b5b45e5345de0188dad = "";
			this.c00ead75cbac9bbb7a6a80755f93eb81c = "";
			this.c10438d4098b9b0be8c5a94b699c17cfd = "";
			this.ce83d806bb4da41fc51e567f3580d24d7 = "";
			this.ca04e9093b82ae8981ee6b195c76465d0 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89656) != 0);
			this.cf8ff1914a97b93eefee3b56ce74e13f1 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196830);
			this.ccc57a7d7c0c0475019c8090dd209e8b3 = new List<UserConfig.ccc09619acd8fa4a0f4ef6d508ecf6e99>();
			this.c2f1e2e68ec46be47d05255e6932cba19 = new List<c13e70d9270a291d056ea0a754d36c2e6.EventDataGrid>();
			this.cc29963b3be7f870cc7840611d7f8568c = new List<Keys>();
			this.ca3be991a9a268bda904de4f0283187da = new List<Keys>();
			this.cc5fc910fcdb381b37d5aaf4542adf45d = new List<Keys>();
			this.cc82b8e60d71512788b0f77640d9c9b2c = c574281c197ab86504307125f2ae59383.c8a754f5f2ca4adde825691a9c31a0e83;
			this.c08aafffd5b7b13202e30b47e2b79bab2 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196634);
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x00120224 File Offset: 0x0011E424
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x00120238 File Offset: 0x0011E438
		internal bool blockClientDice
		{
			get;
			set;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0012024C File Offset: 0x0011E44C
		internal bool ce6ac48f87055a93676ab57d33bf288af(string text)
		{
			bool result;
			try
			{
				if (c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196761), text)))
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
						RuntimeMethodHandle arg_2F_0 = methodof(UserConfig.ce6ac48f87055a93676ab57d33bf288af(string)).MethodHandle;
					}
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89072) != 0);
				}
				else
				{
					this.cc82b8e60d71512788b0f77640d9c9b2c = c9f82e4bb62a30adfeebbde96dfbe0d00.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
					XmlTextWriter xmlTextWriter = cabd8f9bcbced0e85776b2e43384b96e1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196761), text), cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
					ce5199f905338ab0fd8f0ea13c9f6423b.c30767ddca1f9c207888833aea5b5fc61(xmlTextWriter, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89076) != 0);
					c4cbf962806d8d64350430c1b58794d26.c30767ddca1f9c207888833aea5b5fc61(xmlTextWriter, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(195385));
					c5a5098f0ff9e22401a9919d489aa679b.c30767ddca1f9c207888833aea5b5fc61(xmlTextWriter);
					ca02fc4281d911f1579a7ab3b5ab12610.c30767ddca1f9c207888833aea5b5fc61(xmlTextWriter);
					c51e78b96551abc4c88bda9d393ff5ac8.c30767ddca1f9c207888833aea5b5fc61(xmlTextWriter);
					this.c08aafffd5b7b13202e30b47e2b79bab2 = text;
					cfe8c73c0be5a7465348bb886182be6df.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196761), text));
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196778), c490d30743924216b4140dc9e0668c03c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152055), c1edf7124bd49e13856886e69bde6ea6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c4be3bde0cd5517f62d968fecf5d1561c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152072), this.c4acc318064facd12775e3989205b792e);
					c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151981), this.c94ba0baf74614fb9b15ef7efcb5caebe);
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152107), this.c923a6b1f691e0b9b61b319238f7a8217);
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151646), c1d8f08fbffaab3733777f4e74f97fc1f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151665), c75c2305886e6515cc728d007a268e880.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151680), c176d8f23210700c3c3ea89aae6affda5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151713), cd211715134cbee68eeb50b0a05abbe65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151742), c4fcf5026f102d44094c896ccc22046d3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151771), c8c893c1fb921769e529d455b8b6bd55b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152024), c5845845b2d4e170eb555f97330e989e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151280), c20b4b8f7b5dda6add6b63962ed1c13a3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151309), c7c499d10c71da64aefbbcf73b9044d40.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151328), c40db1b4d0d0aac3cf3a0abcb2b75e64d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151349), c9844a63c98c04b7798750299e8cf9a97.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151370), cb966f8a03b43b622221b90531776ce6e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151399), c10afd60a8b0b9535406ce969f2146a80.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151434), cc022f0b541f12df2cc3428d56f5edb89.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151512), c9f9019a62b898779f4b22a0efd3ad1c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151541), cb7d0f89e6319ac971ebc7695424e4a30.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151572), c605e6753fa27972f89ae3b298894dc70.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151469), c051bc299216034481950649d9198ccb0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151611), c3156def56d28363c1932b0985bba6351.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this));
					c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89080) != 0);
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89084) != 0);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89088) != 0);
			}
			return result;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00120630 File Offset: 0x0011E830
		internal bool c58a45b639b317e0e0bf83cd56193185a(string text)
		{
			bool result;
			try
			{
				this.c7ab306e0e1e6c9703226eb763eccdda2(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151271)));
				this.c890fa772eb9ca4447b23e7078bdfdef8 = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196778), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89092) != 0);
				this.c50c70abbd13e5e460737ca8a34a5c3ef = cd392b37df0ebf4e9cbc55ab654e37d59.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152055));
				this.c1daffd904de9135f5bf9fc885acb1487 = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151646), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89096) != 0);
				this.c923a6b1f691e0b9b61b319238f7a8217 = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152107), "");
				this.c4acc318064facd12775e3989205b792e = ce8c2bcbc8b3cc2baa9779b6d4f344ba0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152072));
				this.c9a883e1927531b5b45e5345de0188dad = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151665), "");
				this.c00ead75cbac9bbb7a6a80755f93eb81c = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151680), "");
				this.c10438d4098b9b0be8c5a94b699c17cfd = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151713), "");
				this.ce83d806bb4da41fc51e567f3580d24d7 = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151742), "");
				this.ca04e9093b82ae8981ee6b195c76465d0 = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151771), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89100) != 0);
				this.cf8ff1914a97b93eefee3b56ce74e13f1 = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196805), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196830));
				this.c7f80967c615f40b070c9de2ba5c4ae42(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152313), ref this.ccc57a7d7c0c0475019c8090dd209e8b3);
				this.cf62a590b4c8ddfcedb549d51c3a39845(ref this.c2f1e2e68ec46be47d05255e6932cba19);
				this.c94ba0baf74614fb9b15ef7efcb5caebe = cd392b37df0ebf4e9cbc55ab654e37d59.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151981));
				this.c8594a1747ab9f31496f69767a3ac1aae = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151280), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89104) != 0);
				this.cfb66dbf82ef66dd92ab4fd6b6cec76a7 = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151309), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89108) != 0);
				this.ca63cb6a314ddc85ec736985d44097823 = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151328), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89112) != 0);
				this.c36d5ed8511b1b6fd12139623fb5cf0cc = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151349), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89116) != 0);
				this.ce29721088a97d949eba86df421305c2e = ce4b690c48bfe4f7f579c8033c9b610b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151611), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89120) != 0);
				this.c48ee0f01970d0ad05b4e8a00761a5980 = cd392b37df0ebf4e9cbc55ab654e37d59.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151370));
				this.ca41982f2c9edc8d06d1b216c67ee4f79 = cd392b37df0ebf4e9cbc55ab654e37d59.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151399));
				this.cce51e1e17f88dce193d6ac876fa89e7b = cd392b37df0ebf4e9cbc55ab654e37d59.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151434));
				this.cac886a5981e22a94552b5a57d322cfe7 = cd392b37df0ebf4e9cbc55ab654e37d59.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151469));
				this.cfca2d9641710273e823d086244c6b4b3 = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151512), "");
				this.cee59da9bdeb9bc29a96223ba7a3483ad = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151541), "");
				this.c443aed8c1b749d92bf4dd7cbcd81127c = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151572), "");
				this.ca9444d23738ab81f33764c7e00abd7b1 = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152024), "");
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89124) != 0);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89128) != 0);
			}
			return result;
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x001209DC File Offset: 0x0011EBDC
		internal string get_c4768564dc9326cb2835f42a40deec63d()
		{
			if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c923a6b1f691e0b9b61b319238f7a8217))
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
					RuntimeMethodHandle arg_21_0 = methodof(UserConfig.get_c4768564dc9326cb2835f42a40deec63d()).MethodHandle;
				}
				this.c923a6b1f691e0b9b61b319238f7a8217 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152126);
			}
			return this.c923a6b1f691e0b9b61b319238f7a8217;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00120A24 File Offset: 0x0011EC24
		internal void set_c4768564dc9326cb2835f42a40deec63d(string text)
		{
			if (cc865cad49cf73a84d3ce3b9625d04030.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text))
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
					RuntimeMethodHandle arg_1C_0 = methodof(UserConfig.set_c4768564dc9326cb2835f42a40deec63d(string)).MethodHandle;
				}
				this.c923a6b1f691e0b9b61b319238f7a8217 = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152126);
			}
			else
			{
				this.c923a6b1f691e0b9b61b319238f7a8217 = text;
			}
			c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152107), text);
			c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89132) != 0);
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00120A94 File Offset: 0x0011EC94
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x00120AA8 File Offset: 0x0011ECA8
		public bool inviteOnlyOneTime
		{
			get
			{
				return this.ce29721088a97d949eba86df421305c2e;
			}
			internal set
			{
				this.ce29721088a97d949eba86df421305c2e = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151611), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89136) != 0);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00120AE8 File Offset: 0x0011ECE8
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x00120AFC File Offset: 0x0011ECFC
		public int sendInviteMinInterval
		{
			get
			{
				return this.cac886a5981e22a94552b5a57d322cfe7;
			}
			internal set
			{
				int arg_2E_1;
				if (value >= c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89140))
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
						RuntimeMethodHandle arg_20_0 = methodof(UserConfig.set_sendInviteMinInterval(int)).MethodHandle;
					}
					arg_2E_1 = value;
				}
				else
				{
					arg_2E_1 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89144);
				}
				this.cac886a5981e22a94552b5a57d322cfe7 = arg_2E_1;
				c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151469), this.cac886a5981e22a94552b5a57d322cfe7);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89148) != 0);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x00120B6C File Offset: 0x0011ED6C
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x00120B80 File Offset: 0x0011ED80
		public bool autoSendInvite
		{
			get
			{
				return this.c8594a1747ab9f31496f69767a3ac1aae;
			}
			internal set
			{
				this.c8594a1747ab9f31496f69767a3ac1aae = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151280), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89152) != 0);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x00120BC0 File Offset: 0x0011EDC0
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x00120BD4 File Offset: 0x0011EDD4
		public bool LeaveOnPl
		{
			get
			{
				return this.cfb66dbf82ef66dd92ab4fd6b6cec76a7;
			}
			internal set
			{
				this.cfb66dbf82ef66dd92ab4fd6b6cec76a7 = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151309), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89156) != 0);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x00120C14 File Offset: 0x0011EE14
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x00120C28 File Offset: 0x0011EE28
		public bool autoInvite
		{
			get
			{
				return this.ca63cb6a314ddc85ec736985d44097823;
			}
			internal set
			{
				this.ca63cb6a314ddc85ec736985d44097823 = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151328), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89160) != 0);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x00120C68 File Offset: 0x0011EE68
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x00120C7C File Offset: 0x0011EE7C
		public int widgetUpdateFrequency
		{
			get
			{
				return this.c94ba0baf74614fb9b15ef7efcb5caebe;
			}
			internal set
			{
				this.c94ba0baf74614fb9b15ef7efcb5caebe = value;
				c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151981), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89164) != 0);
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x00120CBC File Offset: 0x0011EEBC
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x00120CD0 File Offset: 0x0011EED0
		public bool autoFollow
		{
			get
			{
				return this.c36d5ed8511b1b6fd12139623fb5cf0cc;
			}
			internal set
			{
				this.c36d5ed8511b1b6fd12139623fb5cf0cc = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151349), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89168) != 0);
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x00120D10 File Offset: 0x0011EF10
		// (set) Token: 0x06001B1B RID: 6939 RVA: 0x00120D24 File Offset: 0x0011EF24
		public string autoFollowNick
		{
			get
			{
				return this.cfca2d9641710273e823d086244c6b4b3;
			}
			internal set
			{
				this.cfca2d9641710273e823d086244c6b4b3 = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151512), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89172) != 0);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001B1C RID: 6940 RVA: 0x00120D64 File Offset: 0x0011EF64
		// (set) Token: 0x06001B1D RID: 6941 RVA: 0x00120D78 File Offset: 0x0011EF78
		public string autoInviteNicks
		{
			get
			{
				return this.cee59da9bdeb9bc29a96223ba7a3483ad;
			}
			internal set
			{
				this.cee59da9bdeb9bc29a96223ba7a3483ad = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151541), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89176) != 0);
				object arg_60_0 = this.cee59da9bdeb9bc29a96223ba7a3483ad;
				char[] array = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89180));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89184)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89188);
				this.cd46f888da06603ee30a18f2c4a03da6a = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_60_0, array);
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89192); i < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(this.cd46f888da06603ee30a18f2c4a03da6a); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89196))
				{
					this.cd46f888da06603ee30a18f2c4a03da6a[i] = c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(this.cd46f888da06603ee30a18f2c4a03da6a[i]);
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
					RuntimeMethodHandle arg_C0_0 = methodof(UserConfig.set_autoInviteNicks(string)).MethodHandle;
				}
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001B1E RID: 6942 RVA: 0x00120E48 File Offset: 0x0011F048
		// (set) Token: 0x06001B1F RID: 6943 RVA: 0x00120E5C File Offset: 0x0011F05C
		public string autoSendInviteNicks
		{
			get
			{
				return this.c443aed8c1b749d92bf4dd7cbcd81127c;
			}
			internal set
			{
				this.c443aed8c1b749d92bf4dd7cbcd81127c = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151572), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89200) != 0);
				object arg_60_0 = this.c443aed8c1b749d92bf4dd7cbcd81127c;
				char[] array = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89204));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89208)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89212);
				this.c20746e758e988ea72543203553ef1693 = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_60_0, array);
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89216); i < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(this.c20746e758e988ea72543203553ef1693); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89220))
				{
					this.c20746e758e988ea72543203553ef1693[i] = c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(this.c20746e758e988ea72543203553ef1693[i]);
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
				if (!true)
				{
					RuntimeMethodHandle arg_C0_0 = methodof(UserConfig.set_autoSendInviteNicks(string)).MethodHandle;
				}
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001B20 RID: 6944 RVA: 0x00120F2C File Offset: 0x0011F12C
		// (set) Token: 0x06001B21 RID: 6945 RVA: 0x00120F40 File Offset: 0x0011F140
		public string[] autoInviteNick
		{
			get
			{
				return this.cd46f888da06603ee30a18f2c4a03da6a;
			}
			internal set
			{
				this.cd46f888da06603ee30a18f2c4a03da6a = value;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001B22 RID: 6946 RVA: 0x00120F54 File Offset: 0x0011F154
		// (set) Token: 0x06001B23 RID: 6947 RVA: 0x00120F68 File Offset: 0x0011F168
		public string[] autoSendInviteNick
		{
			get
			{
				return this.c20746e758e988ea72543203553ef1693;
			}
			internal set
			{
				this.c20746e758e988ea72543203553ef1693 = value;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x00120F7C File Offset: 0x0011F17C
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x00120F90 File Offset: 0x0011F190
		public int autoInviteKind
		{
			get
			{
				return this.c48ee0f01970d0ad05b4e8a00761a5980;
			}
			internal set
			{
				this.c48ee0f01970d0ad05b4e8a00761a5980 = value;
				c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151370), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89224) != 0);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00120FD0 File Offset: 0x0011F1D0
		// (set) Token: 0x06001B27 RID: 6951 RVA: 0x00120FE4 File Offset: 0x0011F1E4
		public int autoFollowMinDist
		{
			get
			{
				return this.ca41982f2c9edc8d06d1b216c67ee4f79;
			}
			internal set
			{
				this.ca41982f2c9edc8d06d1b216c67ee4f79 = value;
				c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151399), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89228) != 0);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00121024 File Offset: 0x0011F224
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x00121038 File Offset: 0x0011F238
		public int autoFollowMaxDist
		{
			get
			{
				return this.cce51e1e17f88dce193d6ac876fa89e7b;
			}
			internal set
			{
				this.cce51e1e17f88dce193d6ac876fa89e7b = value;
				c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151434), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89232) != 0);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x00121078 File Offset: 0x0011F278
		// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0012108C File Offset: 0x0011F28C
		public uint[] doodadHighLights
		{
			get
			{
				return this.cc4705653bfce38f50acc8bcd9846ca8a;
			}
			internal set
			{
				this.cc4705653bfce38f50acc8bcd9846ca8a = value;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x001210A0 File Offset: 0x0011F2A0
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x001210B4 File Offset: 0x0011F2B4
		public string doodadHighLight
		{
			get
			{
				return this.ca9444d23738ab81f33764c7e00abd7b1;
			}
			internal set
			{
				this.ca9444d23738ab81f33764c7e00abd7b1 = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152024), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89236) != 0);
				object arg_5F_0 = this.ca9444d23738ab81f33764c7e00abd7b1;
				char[] array = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89240));
				array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89244)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89248);
				string[] array2 = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_5F_0, array);
				this.cc4705653bfce38f50acc8bcd9846ca8a = cabad7e3df3841c97f7c5aa47c5c3c2a1.ce8915750eb2dc86a075214c6cf229baa((int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89252); i < (int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89260))
				{
					uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89256);
					if (c36decbc8507be8d3740bacf239883c0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c359af69556ed29c26d038f41f9b5b13d.c30767ddca1f9c207888833aea5b5fc61(array2[i]), ref num))
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
							RuntimeMethodHandle arg_BC_0 = methodof(UserConfig.set_doodadHighLight(string)).MethodHandle;
						}
						this.cc4705653bfce38f50acc8bcd9846ca8a[i] = num;
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
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x001211AC File Offset: 0x0011F3AC
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x001211C0 File Offset: 0x0011F3C0
		public string autoAssistHotkey
		{
			get
			{
				return this.c00ead75cbac9bbb7a6a80755f93eb81c;
			}
			internal set
			{
				this.c00ead75cbac9bbb7a6a80755f93eb81c = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151680), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89264) != 0);
				this.cc29963b3be7f870cc7840611d7f8568c = this.c030fd1d73695d52859ffddcb152425b4(this.c00ead75cbac9bbb7a6a80755f93eb81c);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x00121214 File Offset: 0x0011F414
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x00121228 File Offset: 0x0011F428
		public string changeMaHotkey
		{
			get
			{
				return this.c10438d4098b9b0be8c5a94b699c17cfd;
			}
			internal set
			{
				this.c10438d4098b9b0be8c5a94b699c17cfd = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151713), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89268) != 0);
				this.ca3be991a9a268bda904de4f0283187da = this.c030fd1d73695d52859ffddcb152425b4(this.c10438d4098b9b0be8c5a94b699c17cfd);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0012127C File Offset: 0x0011F47C
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x00121290 File Offset: 0x0011F490
		public string assistMaHotkey
		{
			get
			{
				return this.ce83d806bb4da41fc51e567f3580d24d7;
			}
			internal set
			{
				this.ce83d806bb4da41fc51e567f3580d24d7 = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151742), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89272) != 0);
				this.cc5fc910fcdb381b37d5aaf4542adf45d = this.c030fd1d73695d52859ffddcb152425b4(this.ce83d806bb4da41fc51e567f3580d24d7);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x001212E4 File Offset: 0x0011F4E4
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x001212F8 File Offset: 0x0011F4F8
		public string MaNick
		{
			get
			{
				return this.c9a883e1927531b5b45e5345de0188dad;
			}
			internal set
			{
				this.c9a883e1927531b5b45e5345de0188dad = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151665), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89276) != 0);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x00121338 File Offset: 0x0011F538
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0012134C File Offset: 0x0011F54C
		public bool autoAssist
		{
			get
			{
				return this.ca04e9093b82ae8981ee6b195c76465d0;
			}
			internal set
			{
				this.ca04e9093b82ae8981ee6b195c76465d0 = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151771), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89280) != 0);
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0012138C File Offset: 0x0011F58C
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x001213A0 File Offset: 0x0011F5A0
		public string widgetDesign
		{
			get
			{
				return this.cf8ff1914a97b93eefee3b56ce74e13f1;
			}
			internal set
			{
				this.cf8ff1914a97b93eefee3b56ce74e13f1 = value;
				c189b63d0631a2d6206bc20dbb2dee8c9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196805), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89284) != 0);
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x001213E0 File Offset: 0x0011F5E0
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x001213F4 File Offset: 0x0011F5F4
		public byte[] classPriority
		{
			get
			{
				return this.c4acc318064facd12775e3989205b792e;
			}
			internal set
			{
				this.c4acc318064facd12775e3989205b792e = value;
				c4be3bde0cd5517f62d968fecf5d1561c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152072), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89288) != 0);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x00121434 File Offset: 0x0011F634
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x00121448 File Offset: 0x0011F648
		public int sortKind
		{
			get
			{
				return this.c50c70abbd13e5e460737ca8a34a5c3ef;
			}
			internal set
			{
				this.c50c70abbd13e5e460737ca8a34a5c3ef = value;
				c14a60d533efff2f5dd1357fed00fdcbd.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152055), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89292) != 0);
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00121488 File Offset: 0x0011F688
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0012149C File Offset: 0x0011F69C
		public bool soundsEnabled
		{
			get
			{
				return this.c890fa772eb9ca4447b23e7078bdfdef8;
			}
			internal set
			{
				this.c890fa772eb9ca4447b23e7078bdfdef8 = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196778), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89296) != 0);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x001214DC File Offset: 0x0011F6DC
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x001214F0 File Offset: 0x0011F6F0
		public bool afkNotify
		{
			get
			{
				return this.c1daffd904de9135f5bf9fc885acb1487;
			}
			internal set
			{
				this.c1daffd904de9135f5bf9fc885acb1487 = value;
				ce80a8f11a094afd0d5bf433721eb097d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151646), value);
				c2f1d46695287fd958a385b8806e6c67f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89300) != 0);
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00121530 File Offset: 0x0011F730
		private List<Keys> c030fd1d73695d52859ffddcb152425b4(string text)
		{
			List<Keys> result;
			try
			{
				List<Keys> list = c778c8f1d34abd6521911988a02e19349.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				if (c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152171)))
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
						RuntimeMethodHandle arg_31_0 = methodof(UserConfig.c030fd1d73695d52859ffddcb152425b4(string)).MethodHandle;
					}
					c4f5b8a3fb898ace271f93f2e1b3f7825.c30767ddca1f9c207888833aea5b5fc61(list, (Keys)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89304));
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89308), c37b4235599f9d92161031a1eac62fc9d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152171), (StringComparison)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89312))), cdea27b7a0e0cc37081ac21c078bcf552.c30767ddca1f9c207888833aea5b5fc61(text, c37b4235599f9d92161031a1eac62fc9d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152171), (StringComparison)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89316)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89320)));
				}
				if (c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152162)))
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
					c4f5b8a3fb898ace271f93f2e1b3f7825.c30767ddca1f9c207888833aea5b5fc61(list, (Keys)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89324));
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89328), c37b4235599f9d92161031a1eac62fc9d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152162), (StringComparison)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89332))), cdea27b7a0e0cc37081ac21c078bcf552.c30767ddca1f9c207888833aea5b5fc61(text, c37b4235599f9d92161031a1eac62fc9d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152162), (StringComparison)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89336)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89340)));
				}
				if (c49b76edf1940c188fa37efd6d026df37.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152182)))
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
					c4f5b8a3fb898ace271f93f2e1b3f7825.c30767ddca1f9c207888833aea5b5fc61(list, (Keys)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89344));
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c886ce3363b1407a1cdf5f2aa45f4eb5d.c30767ddca1f9c207888833aea5b5fc61(text, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89348), c37b4235599f9d92161031a1eac62fc9d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152182), (StringComparison)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89352))), cdea27b7a0e0cc37081ac21c078bcf552.c30767ddca1f9c207888833aea5b5fc61(text, c37b4235599f9d92161031a1eac62fc9d.c30767ddca1f9c207888833aea5b5fc61(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152182), (StringComparison)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89356)) + c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89360)));
				}
				Keys keys = cf064cbec453790c2bfc01fca6741c9e2.cc6a9c540a2ed5763275f32ba91c9e97b(cac56b179db8f498723c1914300099616.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c2d481f8c5b8856a452a5a9d4039c1cfe.cbac80c0356856482e0a93eed1c1fdf4f()), text));
				c4f5b8a3fb898ace271f93f2e1b3f7825.c30767ddca1f9c207888833aea5b5fc61(list, keys);
				result = list;
			}
			catch
			{
				result = c778c8f1d34abd6521911988a02e19349.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0012177C File Offset: 0x0011F97C
		internal bool c7ab306e0e1e6c9703226eb763eccdda2(string text)
		{
			try
			{
				this.cc82b8e60d71512788b0f77640d9c9b2c = c9f82e4bb62a30adfeebbde96dfbe0d00.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				this.c08aafffd5b7b13202e30b47e2b79bab2 = text;
				if (!c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196761), text)))
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
						RuntimeMethodHandle arg_43_0 = methodof(UserConfig.c7ab306e0e1e6c9703226eb763eccdda2(string)).MethodHandle;
					}
					this.ce6ac48f87055a93676ab57d33bf288af(text);
				}
				try
				{
					cfe8c73c0be5a7465348bb886182be6df.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196761), text));
					this.ce90f2207bb4eaaea2488e91715b6c817 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89364) != 0);
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(67930)), text));
					cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196684), text));
					this.ce90f2207bb4eaaea2488e91715b6c817 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89368) != 0);
					bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89372) != 0;
					return result;
				}
			}
			catch (Exception ex2)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex2));
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196684), text));
				this.ce90f2207bb4eaaea2488e91715b6c817 = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89376) != 0);
				bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89380) != 0;
				return result;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89384) != 0;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x001218E0 File Offset: 0x0011FAE0
		public bool saveToFile(bool forseSave = false)
		{
			try
			{
				if (!this.ce90f2207bb4eaaea2488e91715b6c817)
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
						RuntimeMethodHandle arg_1A_0 = methodof(UserConfig.saveToFile(bool)).MethodHandle;
					}
					if (!forseSave)
					{
						cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(68579)), this.c08aafffd5b7b13202e30b47e2b79bab2));
						goto IL_78;
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
				cea7e74f4172c5068d73f25d743056f54.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c, cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196761), this.c08aafffd5b7b13202e30b47e2b79bab2));
				IL_78:;
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(AppMain.c607d5034b3f779d08b4b54e06143a574.cb4fe8b0c2b6511855aedb754a6b4ced0(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(68579)), this.c08aafffd5b7b13202e30b47e2b79bab2));
				cc4987d6a853db77954f21abe4e42946a.c8299fa31317d146976f1ea9cd623369b(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89388) != 0;
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89392) != 0;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x001219D8 File Offset: 0x0011FBD8
		public bool writeItem(string itemName, byte[] value)
		{
			string text = "";
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89396); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(value); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89404))
			{
				text = cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, value[i]);
				if ((int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(value) - i > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89400))
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
						RuntimeMethodHandle arg_4D_0 = methodof(UserConfig.writeItem(string, byte[])).MethodHandle;
					}
					text = cf03d0425361ef77d0ecded028e94df12.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(122007));
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
			return this.cfeb55890dec9dbb26f9adcfdbe496072(itemName, text);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00121A78 File Offset: 0x0011FC78
		public bool writeItem(string itemName, bool value)
		{
			return this.cfeb55890dec9dbb26f9adcfdbe496072(itemName, cc40b4e18429aeef7acb9e6ca16950b9b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref value));
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00121A98 File Offset: 0x0011FC98
		public bool writeItem(string itemName, int value)
		{
			return this.cfeb55890dec9dbb26f9adcfdbe496072(itemName, c822657c777d7f777c85cd0d3bd0e56c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref value, c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb()));
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00121AC0 File Offset: 0x0011FCC0
		public bool writeItem(string itemName, string value)
		{
			return this.cfeb55890dec9dbb26f9adcfdbe496072(itemName, value);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00121AD8 File Offset: 0x0011FCD8
		public bool writeItem(string itemName, double value)
		{
			return this.cfeb55890dec9dbb26f9adcfdbe496072(itemName, cc39b00cb314c0342595d7eb15d681c6a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref value, c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb()));
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00121B00 File Offset: 0x0011FD00
		internal unsafe bool cf62a590b4c8ddfcedb549d51c3a39845(ref List<c13e70d9270a291d056ea0a754d36c2e6.EventDataGrid> ptr)
		{
			ptr = c97beb816e0f1858e2d361de41f9355be.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			try
			{
				DataContractJsonSerializer dataContractJsonSerializer = c18f795c03ee7b0e7c51759a7c35c5749.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c761ca7d0932aec9bada39f5181205ad1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(typeof(c13e70d9270a291d056ea0a754d36c2e6.EventDataGrid).TypeHandle));
				for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89408); i < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89424); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89420))
				{
					string text = c2ac894df27e895b5528b13b798e836e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(151941), i), "");
					if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ""))
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
							RuntimeMethodHandle arg_75_0 = methodof(UserConfig.cf62a590b4c8ddfcedb549d51c3a39845(List<c13e70d9270a291d056ea0a754d36c2e6.EventDataGrid>*)).MethodHandle;
						}
						MemoryStream memoryStream = cb0ad0c20f9d91798a2cdba9cf90ba0a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c36d7e1836540e255ff7614b4a2f58d86.c30767ddca1f9c207888833aea5b5fc61(memoryStream, cfcc035847803a84b2bc318fec93e4aa1.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89412), c3111dbd73271125c26adeed3dddb6f2f.c30767ddca1f9c207888833aea5b5fc61(cdd222cd0fcf86fe44da6144810595d26.c0cf59c3e67a46fd4edb3040c5ab0bbfb(), text));
						cece621ea1589cc0c72148b25cde74f51.c30767ddca1f9c207888833aea5b5fc61(memoryStream, (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89416));
						c02ca88e8dfe0109af4bd0a8e16b98df7.c30767ddca1f9c207888833aea5b5fc61(ptr, (c13e70d9270a291d056ea0a754d36c2e6.EventDataGrid)c8d871b7da42b19e432346220bcc023e0.c30767ddca1f9c207888833aea5b5fc61(dataContractJsonSerializer, memoryStream));
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
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89428); j < c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89436); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89432))
				{
					c02ca88e8dfe0109af4bd0a8e16b98df7.c30767ddca1f9c207888833aea5b5fc61(ptr, c310ae2b393612b9fed91ca19247a6d3f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
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
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89440) != 0;
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00121C78 File Offset: 0x0011FE78
		internal unsafe bool c7f80967c615f40b070c9de2ba5c4ae42(string text, ref List<UserConfig.ccc09619acd8fa4a0f4ef6d508ecf6e99> ptr)
		{
			try
			{
				ptr = cd181613c768c9f8ac8ca465f64d3d43e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
				if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c) != null)
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
						RuntimeMethodHandle arg_2D_0 = methodof(UserConfig.c7f80967c615f40b070c9de2ba5c4ae42(string, List<UserConfig.ccc09619acd8fa4a0f4ef6d508ecf6e99>*)).MethodHandle;
					}
					IEnumerator enumerator = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c)));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							XmlNode xmlNode = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlNode), text))
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
								IEnumerator enumerator2 = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(xmlNode));
								try
								{
									while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
									{
										XmlNode xmlNode2 = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator2));
										UserConfig.ccc09619acd8fa4a0f4ef6d508ecf6e99 ccc09619acd8fa4a0f4ef6d508ecf6e = new UserConfig.ccc09619acd8fa4a0f4ef6d508ecf6e99();
										int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89444);
										IEnumerator enumerator3 = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(xmlNode2));
										try
										{
											while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator3))
											{
												XmlNode xmlNode3 = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator3));
												if (num == 0)
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
													ccc09619acd8fa4a0f4ef6d508ecf6e.c54d8dc450fc5c72ccd7a5bc5adb46506 = c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlNode3);
												}
												else if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89448))
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
													int cdca4e8a46e2e4c91fdcf2d7fef4199be = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89452);
													c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlNode3), ref cdca4e8a46e2e4c91fdcf2d7fef4199be);
													ccc09619acd8fa4a0f4ef6d508ecf6e.cdca4e8a46e2e4c91fdcf2d7fef4199be = cdca4e8a46e2e4c91fdcf2d7fef4199be;
												}
												else if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89456))
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
													ccc09619acd8fa4a0f4ef6d508ecf6e.c80d2a938371a17e3918b0b10ff49533c = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89460);
												}
												else if (num == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89464))
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
													ccc09619acd8fa4a0f4ef6d508ecf6e.c2ce089ae5170b0ee21b67c186134ace1 = c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlNode3);
													ccc09619acd8fa4a0f4ef6d508ecf6e.cb9b7af559176fe81ef41a736ec4bf0a6 = this.c030fd1d73695d52859ffddcb152425b4(ccc09619acd8fa4a0f4ef6d508ecf6e.c2ce089ae5170b0ee21b67c186134ace1);
												}
												num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89468);
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
											IDisposable disposable = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator3);
											if (disposable != null)
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
												cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable);
											}
										}
										ce3c50eda87ac699a9ad3f1a7f903fba7.c30767ddca1f9c207888833aea5b5fc61(ptr, ccc09619acd8fa4a0f4ef6d508ecf6e);
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
									IDisposable disposable2 = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator2);
									if (disposable2 != null)
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
										cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable2);
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
					}
					finally
					{
						IDisposable disposable3 = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator);
						if (disposable3 != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable3);
						}
					}
				}
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89472) != 0;
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00121F64 File Offset: 0x00120164
		internal unsafe bool c881530d5ff9d541f6ed7b8f5f235ca24(string text, ref c9fbcf0c128921c78b2636713420a4eee ptr, sbyte b = -1)
		{
			try
			{
				if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c) != null)
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
						RuntimeMethodHandle arg_24_0 = methodof(UserConfig.c881530d5ff9d541f6ed7b8f5f235ca24(string, c9fbcf0c128921c78b2636713420a4eee*, sbyte)).MethodHandle;
					}
					IEnumerator enumerator = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c)));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							XmlNode xmlNode = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlNode), text))
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
								int num = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89476);
								IEnumerator enumerator2 = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(xmlNode));
								try
								{
									while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator2))
									{
										XmlNode xmlNode2 = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator2));
										int num2 = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89480);
										IEnumerator enumerator3 = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(xmlNode2));
										try
										{
											while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator3))
											{
												XmlNode xmlNode3 = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator3));
												Color color = ce71a411b84e23c61834e6ce31775edd9.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
												bool flag = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89484) != 0;
												try
												{
													if ((int)b == num2)
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
														color = c5a306d326b76dd39284beb71555f24fe.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlNode3));
														flag = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89488) != 0);
													}
												}
												catch
												{
												}
												if (flag)
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
													cf453af46f3ff0bd3cabbdc10971dd509.c30767ddca1f9c207888833aea5b5fc61(c555dd5f3be2d1b5820c924fec1d293fa.c30767ddca1f9c207888833aea5b5fc61(c5eac99452a21f861ae5ac485550b8328.c30767ddca1f9c207888833aea5b5fc61(cee608d12de49309266e4b3531667a20b.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(ptr), num)), num2), color);
												}
												else
												{
													cf453af46f3ff0bd3cabbdc10971dd509.c30767ddca1f9c207888833aea5b5fc61(c555dd5f3be2d1b5820c924fec1d293fa.c30767ddca1f9c207888833aea5b5fc61(c5eac99452a21f861ae5ac485550b8328.c30767ddca1f9c207888833aea5b5fc61(cee608d12de49309266e4b3531667a20b.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(ptr), num)), num2), c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlNode3));
												}
												num2 += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89492);
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
											IDisposable disposable = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator3);
											if (disposable != null)
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
												cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable);
											}
										}
										num += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89496);
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
									IDisposable disposable2 = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator2);
									if (disposable2 != null)
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
										cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable2);
									}
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
						IDisposable disposable3 = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator);
						if (disposable3 != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable3);
						}
					}
				}
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89500) != 0;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00122254 File Offset: 0x00120454
		private static string cd114905666c5af5bc223a8c9689a5cd2(Color color)
		{
			string expr_0A = c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152099);
			byte b = c25aeab9571d22cd49646c565442c6a27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref color);
			string expr_29 = c67113268fa3f902dc77c79207987f0e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref b, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
			byte b2 = caad2c1d302e3ce2d7275439e77f61494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref color);
			string expr_48 = c67113268fa3f902dc77c79207987f0e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref b2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102));
			byte b3 = ce5de72fdd04e5cd615611d8889b41953.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref color);
			return c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_0A, expr_29, expr_48, c67113268fa3f902dc77c79207987f0e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref b3, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(152102)));
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x001222D4 File Offset: 0x001204D4
		internal bool c31e8e5c475b3b3a19f0dbd4a8ebfe775(string text, DataGridView dataGridView)
		{
			bool result;
			try
			{
				if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c) != null)
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
						RuntimeMethodHandle arg_24_0 = methodof(UserConfig.c31e8e5c475b3b3a19f0dbd4a8ebfe775(string, DataGridView)).MethodHandle;
					}
					IEnumerator enumerator = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c)));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							XmlNode xmlNode = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlNode), text))
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
								if (c9b7bd2f3c38bdb940b855371a7f6a512.c30767ddca1f9c207888833aea5b5fc61(xmlNode) != null)
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
									ce8ac3edcc1f30db5756e66a91e791bcc.c30767ddca1f9c207888833aea5b5fc61(c9b7bd2f3c38bdb940b855371a7f6a512.c30767ddca1f9c207888833aea5b5fc61(xmlNode), xmlNode);
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
						IDisposable disposable = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator);
						if (disposable != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable);
						}
					}
					XmlNode xmlNode2 = c728954990873edd586ef2d129c6ce10b.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c, text);
					for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89504); i < c9b127c0418f8dbb80f0a235b6cc6c3de.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(dataGridView)); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89516))
					{
						XmlNode xmlNode3 = c728954990873edd586ef2d129c6ce10b.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196837));
						c17f9a85ece3bb747c854a3f603a65d57.c30767ddca1f9c207888833aea5b5fc61(xmlNode2, xmlNode3);
						for (int j = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89508); j < c1a960fcc708c9c367dcc05ca1d3141ae.c30767ddca1f9c207888833aea5b5fc61(c5eac99452a21f861ae5ac485550b8328.c30767ddca1f9c207888833aea5b5fc61(cee608d12de49309266e4b3531667a20b.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(dataGridView), i))); j += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89512))
						{
							XmlNode xmlNode4 = c728954990873edd586ef2d129c6ce10b.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c, cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196844), j));
							if (c555dd5f3be2d1b5820c924fec1d293fa.c30767ddca1f9c207888833aea5b5fc61(c5eac99452a21f861ae5ac485550b8328.c30767ddca1f9c207888833aea5b5fc61(cee608d12de49309266e4b3531667a20b.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(dataGridView), i)), j) != null)
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
								if (c6ddabdb78d5b1c258c4e7049afa29f93.c30767ddca1f9c207888833aea5b5fc61(c555dd5f3be2d1b5820c924fec1d293fa.c30767ddca1f9c207888833aea5b5fc61(c5eac99452a21f861ae5ac485550b8328.c30767ddca1f9c207888833aea5b5fc61(cee608d12de49309266e4b3531667a20b.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(dataGridView), i)), j)) != null)
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
									if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c6ddabdb78d5b1c258c4e7049afa29f93.c30767ddca1f9c207888833aea5b5fc61(c555dd5f3be2d1b5820c924fec1d293fa.c30767ddca1f9c207888833aea5b5fc61(c5eac99452a21f861ae5ac485550b8328.c30767ddca1f9c207888833aea5b5fc61(cee608d12de49309266e4b3531667a20b.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(dataGridView), i)), j))), ""))
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
										c72509e42ec29299bc15947dd639c30dd.c30767ddca1f9c207888833aea5b5fc61(xmlNode4, cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(c6ddabdb78d5b1c258c4e7049afa29f93.c30767ddca1f9c207888833aea5b5fc61(c555dd5f3be2d1b5820c924fec1d293fa.c30767ddca1f9c207888833aea5b5fc61(c5eac99452a21f861ae5ac485550b8328.c30767ddca1f9c207888833aea5b5fc61(cee608d12de49309266e4b3531667a20b.c30767ddca1f9c207888833aea5b5fc61(c10b7ba2ac8e9caa345ba07717d92b797.c30767ddca1f9c207888833aea5b5fc61(dataGridView), i)), j))));
									}
								}
							}
							c17f9a85ece3bb747c854a3f603a65d57.c30767ddca1f9c207888833aea5b5fc61(xmlNode3, xmlNode4);
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
					while (true)
					{
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c) != null)
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
						c17f9a85ece3bb747c854a3f603a65d57.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c), xmlNode2);
					}
				}
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89520) != 0);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89524) != 0);
			}
			return result;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00122614 File Offset: 0x00120814
		internal bool cfeb55890dec9dbb26f9adcfdbe496072(string text, string text2)
		{
			bool result;
			try
			{
				if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c) != null)
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
						RuntimeMethodHandle arg_24_0 = methodof(UserConfig.cfeb55890dec9dbb26f9adcfdbe496072(string, string)).MethodHandle;
					}
					IEnumerator enumerator = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c)));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							XmlNode xmlNode = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlNode), text))
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
								c72509e42ec29299bc15947dd639c30dd.c30767ddca1f9c207888833aea5b5fc61(xmlNode, text2);
								result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89528) != 0);
								return result;
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
						IDisposable disposable = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator);
						if (disposable != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable);
						}
					}
					XmlNode xmlNode2 = c728954990873edd586ef2d129c6ce10b.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c, text);
					c72509e42ec29299bc15947dd639c30dd.c30767ddca1f9c207888833aea5b5fc61(xmlNode2, text2);
					if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c) != null)
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
						c17f9a85ece3bb747c854a3f603a65d57.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c), xmlNode2);
					}
				}
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89532) != 0);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89536) != 0);
			}
			return result;
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00122784 File Offset: 0x00120984
		public bool readBool(string itemName, bool def = false)
		{
			string text = this.cc343cdfe8a6e7910eaa8e3ad823470cb(itemName);
			if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ""))
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
					RuntimeMethodHandle arg_2B_0 = methodof(UserConfig.readBool(string, bool)).MethodHandle;
				}
				bool result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89540) != 0;
				c0de76a5de42bab4d7e51d5ceb37bf3c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ref result);
				return result;
			}
			return def;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x001227D8 File Offset: 0x001209D8
		public string readString(string itemName, string def = "")
		{
			string text = this.cc343cdfe8a6e7910eaa8e3ad823470cb(itemName);
			if (c9876a0af62872ae649d1af124fa9f849.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, ""))
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
					RuntimeMethodHandle arg_2B_0 = methodof(UserConfig.readString(string, string)).MethodHandle;
				}
				return text;
			}
			return def;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00122814 File Offset: 0x00120A14
		public byte[] readByteArray(string itemName)
		{
			string text = this.cc343cdfe8a6e7910eaa8e3ad823470cb(itemName);
			object arg_37_0 = text;
			char[] array = ce711c40a529b8c0cc2cbe69b29c59ef6.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89544));
			array[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89548)] = (char)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89552);
			string[] array2 = c4941596200247b41d263f9080fbacd34.c30767ddca1f9c207888833aea5b5fc61(arg_37_0, array);
			byte[] array3 = c37c689447867dc9ce98d904b70a83290.ce8915750eb2dc86a075214c6cf229baa((int)c6e2ffc166fca36cf294f4e49168186f9.cc0906fa561b9c6076f6cb6643cecb5e3(array2));
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89556); i < (int)c75bc793c5a8e6d79211b8893c06f3b76.cc0906fa561b9c6076f6cb6643cecb5e3(array3); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89564))
			{
				array3[i] = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89560);
				cd2f204b3667bc0717b94bda70a19099a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(array2[i], ref array3[i]);
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
			if (!true)
			{
				RuntimeMethodHandle arg_A7_0 = methodof(UserConfig.readByteArray(string)).MethodHandle;
			}
			return array3;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x001228CC File Offset: 0x00120ACC
		public int readInt(string itemName)
		{
			int result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89568);
			c0bd9bfa39d3154ae8a97d4b439b3ed36.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.cc343cdfe8a6e7910eaa8e3ad823470cb(itemName), ref result);
			return result;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x001228F8 File Offset: 0x00120AF8
		internal string cc343cdfe8a6e7910eaa8e3ad823470cb(string text)
		{
			try
			{
				if (c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c) != null)
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
						RuntimeMethodHandle arg_24_0 = methodof(UserConfig.cc343cdfe8a6e7910eaa8e3ad823470cb(string)).MethodHandle;
					}
					IEnumerator enumerator = ca130811849fc1dcb2d808b02133b95e4.c30767ddca1f9c207888833aea5b5fc61(c5404f43d5a9d5a94d904d9729da51001.c30767ddca1f9c207888833aea5b5fc61(c42ffaf9df7c985ad67f26cc80a105b06.c30767ddca1f9c207888833aea5b5fc61(this.cc82b8e60d71512788b0f77640d9c9b2c)));
					try
					{
						while (c54f57f7a5fa9b25c15a62e13c2ed296f.c30767ddca1f9c207888833aea5b5fc61(enumerator))
						{
							XmlNode xmlNode = c5501d3b4f69d55e588937a7df43858a4.c9963fcf210a214a3206d6500f3b9397b(c8d3c5f346369741083514107319e6483.c30767ddca1f9c207888833aea5b5fc61(enumerator));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c7446bd1c383fc475d910d5116ca29314.c30767ddca1f9c207888833aea5b5fc61(xmlNode), text))
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
								string result = c4eb10402ea442262c2feffe9068aa40d.c30767ddca1f9c207888833aea5b5fc61(xmlNode);
								return result;
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
						IDisposable disposable = c2b7569eaaf7b9c72c312de7bd1d2000e.cea69e7c4d1a729bd5783221de1566e79(enumerator);
						if (disposable != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(disposable);
						}
					}
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				string result = "";
				return result;
			}
			return "";
		}

		// Token: 0x04001058 RID: 4184
		private bool ce90f2207bb4eaaea2488e91715b6c817;

		// Token: 0x04001059 RID: 4185
		private bool c1daffd904de9135f5bf9fc885acb1487;

		// Token: 0x0400105A RID: 4186
		private int c50c70abbd13e5e460737ca8a34a5c3ef;

		// Token: 0x0400105B RID: 4187
		private int c94ba0baf74614fb9b15ef7efcb5caebe;

		// Token: 0x0400105C RID: 4188
		private bool c890fa772eb9ca4447b23e7078bdfdef8;

		// Token: 0x0400105D RID: 4189
		private string ca9444d23738ab81f33764c7e00abd7b1;

		// Token: 0x0400105E RID: 4190
		private uint[] cc4705653bfce38f50acc8bcd9846ca8a;

		// Token: 0x0400105F RID: 4191
		private bool c8594a1747ab9f31496f69767a3ac1aae;

		// Token: 0x04001060 RID: 4192
		private bool cfb66dbf82ef66dd92ab4fd6b6cec76a7;

		// Token: 0x04001061 RID: 4193
		private bool ca63cb6a314ddc85ec736985d44097823;

		// Token: 0x04001062 RID: 4194
		private bool c36d5ed8511b1b6fd12139623fb5cf0cc;

		// Token: 0x04001063 RID: 4195
		private bool ce29721088a97d949eba86df421305c2e;

		// Token: 0x04001064 RID: 4196
		private int c48ee0f01970d0ad05b4e8a00761a5980;

		// Token: 0x04001065 RID: 4197
		private int ca41982f2c9edc8d06d1b216c67ee4f79;

		// Token: 0x04001066 RID: 4198
		private int cce51e1e17f88dce193d6ac876fa89e7b;

		// Token: 0x04001067 RID: 4199
		private int cac886a5981e22a94552b5a57d322cfe7;

		// Token: 0x04001068 RID: 4200
		private string cfca2d9641710273e823d086244c6b4b3;

		// Token: 0x04001069 RID: 4201
		private string cee59da9bdeb9bc29a96223ba7a3483ad;

		// Token: 0x0400106A RID: 4202
		private string c443aed8c1b749d92bf4dd7cbcd81127c;

		// Token: 0x0400106B RID: 4203
		private string[] cd46f888da06603ee30a18f2c4a03da6a;

		// Token: 0x0400106C RID: 4204
		private string[] c20746e758e988ea72543203553ef1693;

		// Token: 0x0400106D RID: 4205
		private string c923a6b1f691e0b9b61b319238f7a8217;

		// Token: 0x0400106E RID: 4206
		private string c9a883e1927531b5b45e5345de0188dad;

		// Token: 0x0400106F RID: 4207
		private string c00ead75cbac9bbb7a6a80755f93eb81c;

		// Token: 0x04001070 RID: 4208
		private string c10438d4098b9b0be8c5a94b699c17cfd;

		// Token: 0x04001071 RID: 4209
		private string ce83d806bb4da41fc51e567f3580d24d7;

		// Token: 0x04001072 RID: 4210
		private bool ca04e9093b82ae8981ee6b195c76465d0;

		// Token: 0x04001073 RID: 4211
		private string cf8ff1914a97b93eefee3b56ce74e13f1;

		// Token: 0x04001074 RID: 4212
		private byte[] c4acc318064facd12775e3989205b792e;

		// Token: 0x04001075 RID: 4213
		internal List<Keys> cc29963b3be7f870cc7840611d7f8568c;

		// Token: 0x04001076 RID: 4214
		internal List<Keys> ca3be991a9a268bda904de4f0283187da;

		// Token: 0x04001077 RID: 4215
		internal List<Keys> cc5fc910fcdb381b37d5aaf4542adf45d;

		// Token: 0x04001078 RID: 4216
		internal List<UserConfig.ccc09619acd8fa4a0f4ef6d508ecf6e99> ccc57a7d7c0c0475019c8090dd209e8b3;

		// Token: 0x04001079 RID: 4217
		internal List<c13e70d9270a291d056ea0a754d36c2e6.EventDataGrid> c2f1e2e68ec46be47d05255e6932cba19;

		// Token: 0x0400107A RID: 4218
		private XmlDocument cc82b8e60d71512788b0f77640d9c9b2c;

		// Token: 0x0400107B RID: 4219
		private string c08aafffd5b7b13202e30b47e2b79bab2;

		// Token: 0x0400107C RID: 4220
		[CompilerGenerated]
		private bool ce3a68ae6b9a6ee5d7f1eb5f5b923c2e4;

		// Token: 0x02000521 RID: 1313
		internal sealed class ccc09619acd8fa4a0f4ef6d508ecf6e99
		{
			// Token: 0x06001B55 RID: 6997 RVA: 0x001229F0 File Offset: 0x00120BF0
			public ccc09619acd8fa4a0f4ef6d508ecf6e99()
			{
				this.cb9b7af559176fe81ef41a736ec4bf0a6 = new List<Keys>();
			}

			// Token: 0x0400107D RID: 4221
			public string c54d8dc450fc5c72ccd7a5bc5adb46506;

			// Token: 0x0400107E RID: 4222
			public int cdca4e8a46e2e4c91fdcf2d7fef4199be;

			// Token: 0x0400107F RID: 4223
			public int c80d2a938371a17e3918b0b10ff49533c;

			// Token: 0x04001080 RID: 4224
			public string c2ce089ae5170b0ee21b67c186134ace1;

			// Token: 0x04001081 RID: 4225
			public List<Keys> cb9b7af559176fe81ef41a736ec4bf0a6;
		}
	}
}
