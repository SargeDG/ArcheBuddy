using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using A;
using ArcheBuddy.SQL;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000523 RID: 1315
	public class Core : MarshalProxy
	{
		// Token: 0x06001B5A RID: 7002 RVA: 0x00122A10 File Offset: 0x00120C10
		public Core()
		{
			this.pluginPath = "";
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00122A30 File Offset: 0x00120C30
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Core.Dispose(bool)).MethodHandle;
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
					this.core = c49603cd9629f69a6585d48b4afcaf58c.c8a754f5f2ca4adde825691a9c31a0e83;
				}
				ca28425a9d6cfce8454770e0a33769fc5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, disposing);
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00122A78 File Offset: 0x00120C78
		public void InitEvents(string domainName, string pluginPath)
		{
			if (this.core != null)
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
					RuntimeMethodHandle arg_1D_0 = methodof(Core.InitEvents(string, string)).MethodHandle;
				}
				this.pluginPath = pluginPath;
				this.c18a8d485d27b1dee8dc5b91ae29b7496 = null;
				this.c5079a86ad845a09ad3ee7fca48bec96c = null;
				this.cef0033ad67bb2aa52e1b50622fba0dd7 = null;
				this.cc65fe83eaa7ecfbcc675d77b9e5d6c65 = null;
				this.c43b8e3825a14806b9a3761b45c778de0 = null;
				this.cd3ee183dfcb2a7bfa069084256f350c4 = null;
				this.c1252fd56398f82e6fb8f360193b6be59 = null;
				this.c3ca0e44dc58274cbd86481abf07fbb1c = null;
				this.c0af0ded751c7c1a2c969c92817af8012 = null;
				this.c96b9c1ce38178028633262e404bae2e3 = null;
				this.c6f2443ac19193b27fd26df3addf35869 = null;
				this.c9672d0cacc1487837c7a06935571cd68 = null;
				this.c7a43755b896ef786f7d3267c8e137a5b = null;
				this.cf92373f7bd6549378351b99ef76a1ba4 = null;
				this.caf5faa74fe32f15605124c7ced738f9d = null;
				this.c03639ec18a453618ad6c88ccda0ffc17 = null;
				this.c534cb9e5119a4eb7229a4bdf00346931 = null;
				this.c682f0526195a82f02b53a67f1629806c = null;
				this.cd8835f412e02ee6b68522c11c3f9f636 = null;
				this.ccd3ac50bc5d507a22de8369a181368b5 = null;
				this.c03907515698aafc81f6542211a9c0eb9 = null;
				this.c3963fda1507610b3bbcc76024e8ad4ef = null;
				this.c74868cdb6316e82968dcb34dca68404c = null;
				this.ca833aee3251897821e5642600b79814b = null;
				this.c1b082e70fe282fb43f8862ad1b06aab7 = null;
				this.c5cb001f87ba43f44fe09b11cdd1c8c41 = null;
				this.c2c72e0ad4467fff4a60a9ff579532cdb = null;
				this.c56e38df8ff9da715e30c9b4959d9ac4e = null;
				this.c86265f69293de2a5f4e164341732086b = null;
				this.c5d3c08241889fe0c4c3e1d82ddc1128b = null;
				this.cca3706cd3d8015e21f4b646cb769ccfe = null;
				this.cd63bf3ee97dd46ec1ca95db1386628d8 = null;
				this.cc4e01c8a31335179857aa85d9059b75c = null;
				this.ce3879c9b14b51ca0c13609aa713c696a = null;
				this.c11be0376fcdf893640c7a6c2d4a167df = null;
				this.c7c616f9bd2a3566d496167f9987929f9 = null;
				this.c4d45cbba6e28ff9b4f6369d9ab655c98 = null;
				this.cff347b49df0bab4adba4d31c0f8e5f38 = null;
				this.cfd0c67e4ffb2110df41fe429d4e19cf7 = null;
				this.c57f245808a27d8bafbbadf9452bdafd2 = null;
				this.ce712abb859034bed3f6709b20aea66e7 = null;
				this.c57433036557b00ee5b9d74e1bed86f87 = null;
				this.cd638bddd90add5ada0ff3df9c490735b = null;
				this.cd5494782bb11fc2bc17088c802ac59d1 = null;
				this.c56456b6f25545e940466e8cfa40b31e9 = null;
				this.c1927ca84451be252f40fb28231df0bda = null;
				this.core.c0fd19262661af5d1b8e6774482b3ee6b(new CoreInternal.GameStateChanged(this.c4aa9f79eb7d3b5c32a5e09b9db813b0c), domainName);
				this.core.c57b191f53b3f324d45e1394e0200f6fa(new CoreInternal.KeyboardEvent(this.cb6da906236ba397905de7cfe55f2dae4), domainName);
				this.core.cfde0a62eba3ae70105adee33b14d473b(new CoreInternal.TargetChanged(this.c4b35527680a5eb14e32f2159f1c0098a), domainName);
				this.core.c9c3d94026556aa457e666f745d2b3867(new CoreInternal.NewCreature(this.c98ebdfd23879ebebd17ac1c15dd37bb1), domainName);
				this.core.c397aea437db97e15fb8730e103851a11(new CoreInternal.PartyInvite(this.cbc03a64955bbfab36e1d061438622d5c), domainName);
				this.core.ce503ece9f1221f60f3613c2d71d18985(new CoreInternal.RaidInvite(this.ca1a748f0d8c8c1bc1431079bb4d99aff), domainName);
				this.core.cb61c9b392363c2a0f68292bc6234b931(new CoreInternal.LevelChanged(this.c67917afff0757db5de1ed0aa976d73ba), domainName);
				this.core.ceb05ff74cd22bed53619f1dd30e72842(new CoreInternal.CreatureDied(this.c9e623d318c2cadc9f6df6ee5b771f2ab), domainName);
				this.core.c79ef8ad89ebff18fc726791cec910df8(new CoreInternal.SkillCasting(this.c084f876377fae9f5ac883fd588d638b3), domainName);
				this.core.ce1255fdf3c374c359f51e57c6695cc31(new CoreInternal.TradeStarted(this.c8da8d62b9caa601437bba5f83ea6fecc), domainName);
				this.core.c969aebccb4db82546a5711a702589426(new CoreInternal.TradeDone(this.cae0fb65eb0528d8eee99992bc5a16f46), domainName);
				this.core.cb8f60668c2ce1d2616cf0416cd798ba3(new CoreInternal.ChatMessage(this.c2e85e7c57d9ad08259612167fe936293), domainName);
				this.core.c4505546cb22472ad2042c5bf14a16ed9(new CoreInternal.QuestStarted(this.c6211c0ddcdf9ac883bda4cca0f751664), domainName);
				this.core.c75ee2bb1c045eddf19706728b55f6ef7(new CoreInternal.QuestUpdated(this.c26415d27c9a07c2a753b573e63c8f9f2), domainName);
				this.core.ce4b2030450e437d3401e559c4b91b220(new CoreInternal.QuestCompleted(this.c3031e421b0db4d0e05a2538461abfd75), domainName);
				this.core.c3966ece3609f93e7a4d995007977e8fb(new CoreInternal.NewInvItem(this.c6e8521f4ce01e2af7ab43aaaf2ba8dc6), domainName);
				this.core.cc05f5a495ca0d9127ea63a9ad1036226(new CoreInternal.LootAvailable(this.ca1e10121a3eb73c9d961fee7114e0954), domainName);
				this.core.c1542af52cb192428fd12f899ef0ede00(new CoreInternal.InvItemRemoved(this.ce901484200faa3aad7e4579b93c7ddc9), domainName);
				this.core.ca68dad0972717cc8161295894409b1d5(new CoreInternal.NewMail(this.cc39b76cebd6ab346f00355ad1419c0dd), domainName);
				this.core.c9f22a5fb7893d59bd2a8c7159391895d(new CoreInternal.LotSelled(this.c03e97844326c51622dba3a1a656e5dc4), domainName);
				this.core.ca0f2c41ab5e21c0ee3a918a006a1ca05(new CoreInternal.LootDice(this.c4fe0eb36f8931dd8990cf27da5e06432), domainName);
				this.core.c1b32899597a7a42307180649e527860d(new CoreInternal.UnitDamaged(this.cd91071762f13bb8e0f98f480ea32c532), domainName);
				this.core.cd9894412f22d9395ec30474fce1a4a39(new CoreInternal.UnitHealed(this.c5e51d5502b5210737340918e61ef5f3c), domainName);
				this.core.c817cd6effdb24cf9758c1b64f1684f82(new CoreInternal.NewDoodad(this.cbd7c975f1741b65ce8ba306de3fcf473), domainName);
				this.core.c8172bf0b96c14f30d34e2fc427e2855e(new CoreInternal.DoodadRemoved(this.c85bac4cda347ab45b28ec19283e42855), domainName);
				this.core.c0179bf640ba36a933a86cdb3d5c67bc1(new CoreInternal.CreatureRemoved(this.c58ba083a6aaa875ba02c1fdceb3c49b3), domainName);
				this.core.cf6f52ba50eda57c9df14770f143504a7(new CoreInternal.GoldCountChanged(this.c2b7239323e6d4c0f4b547db2bc2966b8), domainName);
				this.core.c71f60b8cad723e981e0bdc966109ca3f(new CoreInternal.FoundGameMaster(this.ca4d52b9b2a51969573f81f4bad43f3b0), domainName);
				this.core.c41e32d3d4cb8f6435687fd982f8c904e(new CoreInternal.ClientPlantDoodad(this.cd4723f46128f062d33910b9d278b7595), domainName);
				this.core.c5938dde5edbbd57a141c7a734466e522(new CoreInternal.NewBuff(this.c14134a43af1bc2f41e972c42cd117603), domainName);
				this.core.c200e5997a9513de9678b57c6f4895aed(new CoreInternal.BuffRemoved(this.cdfa0c1474efcb7de3cb56a7ed8e43acf), domainName);
				this.core.c8b1ea7af0ae31c44b83804b3d5eef3dd(new CoreInternal.ErrorMessage(this.c219e73b46069458a4d8b36a184d803d5), domainName);
				this.core.c87b2769b90d87dec372f640c0e9cda1f(new CoreInternal.MapPosChanged(this.c3bdb7a5fb6c61281c59a549b881cd162), domainName);
				this.core.c413a25a6c91989b520271e8035dbeda5(new CoreInternal.WidgetFilterStatusChanged(this.cfef9e613bd8a03a35edff93ed64a657e), domainName);
				this.core.c1445b56d80defe95b6e7b7c87fa7d94f(new CoreInternal.WidgetGroupStatusChanged(this.cc0da629a81c51c27524372ecb3e76a36), domainName);
				this.core.c3fcceefb57668c7836a4756c478ea8a4(new CoreInternal.ExpChanged(this.ce0d4082218b573086224f07446a22461), domainName);
				this.core.c04d0cb68710105e6d4544f671e7778f0(new CoreInternal.AbilityExpChanged(this.c8880d257d90b721aee714687dec3c02c), domainName);
				this.core.caf247499b3f6811eae45357f8947dbee(new CoreInternal.LaborAmountChanged(this.c40047bdb0acc3302c40d4a99cbcf975c), domainName);
				this.core.c51518d81d9f9f184a86775a67f2863ff(new CoreInternal.CofferOpened(this.c729020093588b551877aa9b4d0d9b609), domainName);
				this.core.cc196d2b146f8dff22be3aee1d6569391(new CoreInternal.NewSkillLearned(this.c4a024a6088d649ecd7e168a14aebcc0b), domainName);
				this.core.c124ae0d1d8d685f6336b4cc10ed0fdaa(new CoreInternal.NewPartyMember(this.c47b79a436e2ffc556076c32a0a01c74d), domainName);
				this.core.c3a23345207b16998c98bec801f3f50f6(new CoreInternal.PartyMemberLeaves(this.c34a91ffa6517d08df59c566a5baca143), domainName);
				this.core.cfce363fc310f1c029e33c1c687d659f8(new CoreInternal.BattleFieldInvite(this.c5d547a480249d92a6f1b3aa9e6a743c1), domainName);
				this.core.c790296f0e7f96f580557194de40d5a13(new CoreInternal.UserNavMeshPreMove(this.c3a8f5e5aa3b96fdd1f696174a3d1982f), domainName);
				this.core.c5acca25b08802c8f8e6891240b97cebe(new CoreInternal.UserNavMeshPreMoveFull(this.c467d6edbe9fc545738a3d4313578be08), domainName);
				this.core.c1d37b3f2c381ed0ea4bffdf1d847647b(new CoreInternal.UnitImmune(this.cd1e966ed0eb0a1ae67fc8483d14f2b85), domainName);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0012303C File Offset: 0x0012123C
		public int pingToServer
		{
			get
			{
				int result;
				try
				{
					result = c37c070833663ef5016648227c05c95e2.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89660);
				}
				return result;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x00123078 File Offset: 0x00121278
		public bool moveForwardState
		{
			get
			{
				bool result;
				try
				{
					result = c93f7e47893ebaecc8f96d218d0db4b96.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89664) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x001230B4 File Offset: 0x001212B4
		public bool moveBackwardState
		{
			get
			{
				bool result;
				try
				{
					result = c5a4483ec7c9998192fdcc8369ed9c55a.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89668) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x001230F0 File Offset: 0x001212F0
		public bool moveLeftState
		{
			get
			{
				bool result;
				try
				{
					result = c06343a6315763a0562013b28110474df.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89672) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0012312C File Offset: 0x0012132C
		public bool moveRightState
		{
			get
			{
				bool result;
				try
				{
					result = ca00c7b847b03e73a9ccc58baf9f0856e.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89676) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x00123168 File Offset: 0x00121368
		public bool rotateLeftState
		{
			get
			{
				bool result;
				try
				{
					result = c28e1268b286e29eda81eec67effa6e3f.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89680) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x001231A4 File Offset: 0x001213A4
		public bool rotateRightState
		{
			get
			{
				bool result;
				try
				{
					result = c741bddb52d2044256be176807b15282c.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89684) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x001231E0 File Offset: 0x001213E0
		public ulong premiumPayEnd
		{
			get
			{
				ulong result;
				try
				{
					result = c94c1a2de340d4610b15ee7b04dc7f985.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (ulong)((long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89688));
				}
				return result;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00123220 File Offset: 0x00121420
		public bool swimUpState
		{
			get
			{
				bool result;
				try
				{
					result = cd46bfdec40e677d1cf94914847f18ef7.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89692) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0012325C File Offset: 0x0012145C
		public bool swimDownState
		{
			get
			{
				bool result;
				try
				{
					result = cb2404e111226618acea1bf8718849c11.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89696) != 0);
				}
				return result;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00123298 File Offset: 0x00121498
		public bool jumpState
		{
			get
			{
				bool result;
				try
				{
					result = c0db956f8d5cd1d418cdf44009a7a4d77.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89700) != 0);
				}
				return result;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x001232D4 File Offset: 0x001214D4
		public string accountId
		{
			get
			{
				string result;
				try
				{
					result = this.core.get_ccfa6e36189466131affb92cd010aa503();
				}
				catch
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0012330C File Offset: 0x0012150C
		public string proxyLogin
		{
			get
			{
				string result;
				try
				{
					result = c094bfa873a289c79f42929790afa2c84.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x00123344 File Offset: 0x00121544
		public string proxyPassword
		{
			get
			{
				string result;
				try
				{
					result = cd21169fa34289edb80c1e32649a207b6.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0012337C File Offset: 0x0012157C
		public string proxyHost
		{
			get
			{
				string result;
				try
				{
					result = c7e997c70fc1ae8d838f7c0e1ea365962.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = "";
				}
				return result;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x001233B4 File Offset: 0x001215B4
		public ushort proxyPort
		{
			get
			{
				ushort result;
				try
				{
					result = c515d9e3439e844de697a0eea205e0adb.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (ushort)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89704);
				}
				return result;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x001233F0 File Offset: 0x001215F0
		public ClientVersion clientVersion
		{
			get
			{
				ClientVersion result;
				try
				{
					result = c7026baaf422b93c649d40aa6471fdc5c.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (ClientVersion)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89708);
				}
				return result;
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0012342C File Offset: 0x0012162C
		public List<World> getWorlds()
		{
			List<World> result;
			try
			{
				result = ce2c10522257f52114f38d47f845c1f9d.c30767ddca1f9c207888833aea5b5fc61(this.core).ToList<World>();
			}
			catch
			{
				result = c56c39660a75c29c7a5c8ac380f9fe9b7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0012346C File Offset: 0x0012166C
		public List<InstanceDimension> getInstanceDimensions()
		{
			List<InstanceDimension> result;
			try
			{
				result = c396607bbfa4b91e79af6f18ebfa1b59b.c30767ddca1f9c207888833aea5b5fc61(this.core).ToList<InstanceDimension>();
			}
			catch
			{
				result = ca58456c4d867f97d93e64a10b5e8489d.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x001234AC File Offset: 0x001216AC
		public List<DoodadObject> getFishVisibleOnRadar()
		{
			List<DoodadObject> result;
			try
			{
				result = c5ec4b6252cb94e8e1b686a282af09564.c30767ddca1f9c207888833aea5b5fc61(this.core).ToList<DoodadObject>();
			}
			catch
			{
				result = cf30d9403d114bde1964b600852ffa4a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x001234EC File Offset: 0x001216EC
		public List<ScheduleItem> getScheduleItems()
		{
			List<ScheduleItem> result;
			try
			{
				result = cee28eee95b1d600b67bc985ea71e0aa3.c30767ddca1f9c207888833aea5b5fc61(this.core).ToList<ScheduleItem>();
			}
			catch
			{
				result = c6cb45eb4956ae80f8668bfa663738f60.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0012352C File Offset: 0x0012172C
		public World getCurrentWorld()
		{
			World result;
			try
			{
				result = this.core.cb8044c3ebe67c228316ca711cbca4a59();
			}
			catch
			{
				result = cc9ae3c840d27ea4ea490866b7f3a9b21.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00123564 File Offset: 0x00121764
		public List<Quest> getCompletedQuests()
		{
			List<Quest> result;
			try
			{
				result = this.core.cb422f2b463533cda09cd0812a2598cc9();
			}
			catch
			{
				result = cd83acd9310789343e442aa50e4c71072.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x001235A0 File Offset: 0x001217A0
		public List<Quest> getQuests()
		{
			List<Quest> result;
			try
			{
				result = this.core.ce22d7401a2dde609095f6b229331d0ea();
			}
			catch
			{
				result = cd83acd9310789343e442aa50e4c71072.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x001235DC File Offset: 0x001217DC
		public List<Creature> getCreatures()
		{
			List<Creature> result;
			try
			{
				result = this.core.c053aa2d381971d1eae89227aa4a141c5();
			}
			catch
			{
				result = ce8d826fa3f910602bcf4cc0ab204e4bd.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00123618 File Offset: 0x00121818
		public List<DoodadObject> getDoodads()
		{
			List<DoodadObject> result;
			try
			{
				result = this.core.ce3c461fef78e0c8cd8106d4f286e1a07();
			}
			catch
			{
				result = cf30d9403d114bde1964b600852ffa4a1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00123654 File Offset: 0x00121854
		public List<Faction> getFactions()
		{
			List<Faction> result;
			try
			{
				result = this.core.ccdc1fd396fd02818b832a499e6bbd710();
			}
			catch
			{
				result = c53c3c6c18be25c89906fa30587ad82b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00123690 File Offset: 0x00121890
		public List<Mail> getMails()
		{
			List<Mail> result;
			try
			{
				result = this.core.get_c7157e643dd9416b76a384422d09d4ab0().cff834df6b2bd4a24385268fd8936fc9d();
			}
			catch
			{
				result = c0fc96c7ad6d5f6951197c30b058e1c74.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x001236D0 File Offset: 0x001218D0
		public List<FriendListMember> getFriendListMembers()
		{
			List<FriendListMember> result;
			try
			{
				result = this.core.get_c7157e643dd9416b76a384422d09d4ab0().c410b28965f78db4f6b1654c9081f6938();
			}
			catch
			{
				result = ca5cc46c42d2e2525f69fa7addf222826.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00123710 File Offset: 0x00121910
		public List<BlockListMember> getBlockListMembers()
		{
			List<BlockListMember> result;
			try
			{
				result = this.core.get_c7157e643dd9416b76a384422d09d4ab0().c6d71204f83ab3bb0375ed0472436ec51();
			}
			catch
			{
				result = c757a2e6aa13e54f4a5da94330b6fee23.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x00123750 File Offset: 0x00121950
		public UserConfig userConfig
		{
			get
			{
				UserConfig result;
				try
				{
					result = c24155ad151781c76a48af95282ed7f5a.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = c76deaf46afbc1c354ee1313101775796.c8a754f5f2ca4adde825691a9c31a0e83;
				}
				return result;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x00123788 File Offset: 0x00121988
		public Self me
		{
			get
			{
				Self result;
				try
				{
					result = this.core.get_c7157e643dd9416b76a384422d09d4ab0();
				}
				catch
				{
					result = c0faade218cd0142c64c5700cc0e6babb.c8a754f5f2ca4adde825691a9c31a0e83;
				}
				return result;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x001237C0 File Offset: 0x001219C0
		public GameState gameState
		{
			get
			{
				GameState result;
				try
				{
					result = this.core.get_c6132b87d3ee6952aced554ae8aeed8be();
				}
				catch
				{
					result = (GameState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89712);
				}
				return result;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06001B7E RID: 7038 RVA: 0x001237FC File Offset: 0x001219FC
		// (remove) Token: 0x06001B7F RID: 7039 RVA: 0x00123848 File Offset: 0x00121A48
		public event CoreInternal.KeyboardEvent onKeyDown
		{
			add
			{
				CoreInternal.KeyboardEvent keyboardEvent = this.cef0033ad67bb2aa52e1b50622fba0dd7;
				CoreInternal.KeyboardEvent keyboardEvent2;
				do
				{
					keyboardEvent2 = keyboardEvent;
					CoreInternal.KeyboardEvent value2 = (CoreInternal.KeyboardEvent)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(keyboardEvent2, value);
					keyboardEvent = Interlocked.CompareExchange<CoreInternal.KeyboardEvent>(ref this.cef0033ad67bb2aa52e1b50622fba0dd7, value2, keyboardEvent2);
				}
				while (keyboardEvent != keyboardEvent2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onKeyDown(CoreInternal.KeyboardEvent)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.KeyboardEvent keyboardEvent = this.cef0033ad67bb2aa52e1b50622fba0dd7;
				CoreInternal.KeyboardEvent keyboardEvent2;
				do
				{
					keyboardEvent2 = keyboardEvent;
					CoreInternal.KeyboardEvent value2 = (CoreInternal.KeyboardEvent)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(keyboardEvent2, value);
					keyboardEvent = Interlocked.CompareExchange<CoreInternal.KeyboardEvent>(ref this.cef0033ad67bb2aa52e1b50622fba0dd7, value2, keyboardEvent2);
				}
				while (keyboardEvent != keyboardEvent2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onKeyDown(CoreInternal.KeyboardEvent)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x00123894 File Offset: 0x00121A94
		private void cb6da906236ba397905de7cfe55f2dae4(Keys keys, bool flag, bool flag2, bool flag3)
		{
			try
			{
				if (this.cef0033ad67bb2aa52e1b50622fba0dd7 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cb6da906236ba397905de7cfe55f2dae4(Keys, bool, bool, bool)).MethodHandle;
					}
					c9c510c05fdcf3d6c51ec0fed4c53a3a8.c30767ddca1f9c207888833aea5b5fc61(this.cef0033ad67bb2aa52e1b50622fba0dd7, keys, flag, flag2, flag3);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001B81 RID: 7041 RVA: 0x001238E4 File Offset: 0x00121AE4
		// (remove) Token: 0x06001B82 RID: 7042 RVA: 0x00123930 File Offset: 0x00121B30
		public event CoreInternal.UnitImmune onUnitImmune
		{
			add
			{
				CoreInternal.UnitImmune unitImmune = this.c5079a86ad845a09ad3ee7fca48bec96c;
				CoreInternal.UnitImmune unitImmune2;
				do
				{
					unitImmune2 = unitImmune;
					CoreInternal.UnitImmune value2 = (CoreInternal.UnitImmune)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(unitImmune2, value);
					unitImmune = Interlocked.CompareExchange<CoreInternal.UnitImmune>(ref this.c5079a86ad845a09ad3ee7fca48bec96c, value2, unitImmune2);
				}
				while (unitImmune != unitImmune2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onUnitImmune(CoreInternal.UnitImmune)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.UnitImmune unitImmune = this.c5079a86ad845a09ad3ee7fca48bec96c;
				CoreInternal.UnitImmune unitImmune2;
				do
				{
					unitImmune2 = unitImmune;
					CoreInternal.UnitImmune value2 = (CoreInternal.UnitImmune)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(unitImmune2, value);
					unitImmune = Interlocked.CompareExchange<CoreInternal.UnitImmune>(ref this.c5079a86ad845a09ad3ee7fca48bec96c, value2, unitImmune2);
				}
				while (unitImmune != unitImmune2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onUnitImmune(CoreInternal.UnitImmune)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0012397C File Offset: 0x00121B7C
		private void cd1e966ed0eb0a1ae67fc8483d14f2b85(Creature creature)
		{
			try
			{
				if (this.c5079a86ad845a09ad3ee7fca48bec96c != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cd1e966ed0eb0a1ae67fc8483d14f2b85(Creature)).MethodHandle;
					}
					c91a8751feec4af211a16590a1545dc46.c30767ddca1f9c207888833aea5b5fc61(this.c5079a86ad845a09ad3ee7fca48bec96c, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001B84 RID: 7044 RVA: 0x001239C8 File Offset: 0x00121BC8
		// (remove) Token: 0x06001B85 RID: 7045 RVA: 0x00123A14 File Offset: 0x00121C14
		public event CoreInternal.GameStateChanged onGameStateChanged
		{
			add
			{
				CoreInternal.GameStateChanged gameStateChanged = this.c18a8d485d27b1dee8dc5b91ae29b7496;
				CoreInternal.GameStateChanged gameStateChanged2;
				do
				{
					gameStateChanged2 = gameStateChanged;
					CoreInternal.GameStateChanged value2 = (CoreInternal.GameStateChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(gameStateChanged2, value);
					gameStateChanged = Interlocked.CompareExchange<CoreInternal.GameStateChanged>(ref this.c18a8d485d27b1dee8dc5b91ae29b7496, value2, gameStateChanged2);
				}
				while (gameStateChanged != gameStateChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onGameStateChanged(CoreInternal.GameStateChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.GameStateChanged gameStateChanged = this.c18a8d485d27b1dee8dc5b91ae29b7496;
				CoreInternal.GameStateChanged gameStateChanged2;
				do
				{
					gameStateChanged2 = gameStateChanged;
					CoreInternal.GameStateChanged value2 = (CoreInternal.GameStateChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(gameStateChanged2, value);
					gameStateChanged = Interlocked.CompareExchange<CoreInternal.GameStateChanged>(ref this.c18a8d485d27b1dee8dc5b91ae29b7496, value2, gameStateChanged2);
				}
				while (gameStateChanged != gameStateChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onGameStateChanged(CoreInternal.GameStateChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00123A60 File Offset: 0x00121C60
		private void c4aa9f79eb7d3b5c32a5e09b9db813b0c(GameState gameState)
		{
			try
			{
				if (this.c18a8d485d27b1dee8dc5b91ae29b7496 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c4aa9f79eb7d3b5c32a5e09b9db813b0c(GameState)).MethodHandle;
					}
					cdcafe58c1a1dc57b68f6911fae9579a7.c30767ddca1f9c207888833aea5b5fc61(this.c18a8d485d27b1dee8dc5b91ae29b7496, gameState);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06001B87 RID: 7047 RVA: 0x00123AAC File Offset: 0x00121CAC
		// (remove) Token: 0x06001B88 RID: 7048 RVA: 0x00123AF8 File Offset: 0x00121CF8
		public event CoreInternal.TargetChanged onTargetChanged
		{
			add
			{
				CoreInternal.TargetChanged targetChanged = this.cc65fe83eaa7ecfbcc675d77b9e5d6c65;
				CoreInternal.TargetChanged targetChanged2;
				do
				{
					targetChanged2 = targetChanged;
					CoreInternal.TargetChanged value2 = (CoreInternal.TargetChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(targetChanged2, value);
					targetChanged = Interlocked.CompareExchange<CoreInternal.TargetChanged>(ref this.cc65fe83eaa7ecfbcc675d77b9e5d6c65, value2, targetChanged2);
				}
				while (targetChanged != targetChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onTargetChanged(CoreInternal.TargetChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.TargetChanged targetChanged = this.cc65fe83eaa7ecfbcc675d77b9e5d6c65;
				CoreInternal.TargetChanged targetChanged2;
				do
				{
					targetChanged2 = targetChanged;
					CoreInternal.TargetChanged value2 = (CoreInternal.TargetChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(targetChanged2, value);
					targetChanged = Interlocked.CompareExchange<CoreInternal.TargetChanged>(ref this.cc65fe83eaa7ecfbcc675d77b9e5d6c65, value2, targetChanged2);
				}
				while (targetChanged != targetChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onTargetChanged(CoreInternal.TargetChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00123B44 File Offset: 0x00121D44
		private void c4b35527680a5eb14e32f2159f1c0098a(Creature creature, Creature creature2)
		{
			try
			{
				if (this.cc65fe83eaa7ecfbcc675d77b9e5d6c65 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c4b35527680a5eb14e32f2159f1c0098a(Creature, Creature)).MethodHandle;
					}
					c1d54d3c9d12784ca7aeb305ac358c9cb.c30767ddca1f9c207888833aea5b5fc61(this.cc65fe83eaa7ecfbcc675d77b9e5d6c65, creature, creature2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06001B8A RID: 7050 RVA: 0x00123B90 File Offset: 0x00121D90
		// (remove) Token: 0x06001B8B RID: 7051 RVA: 0x00123BDC File Offset: 0x00121DDC
		public event CoreInternal.NewCreature onNewCreature
		{
			add
			{
				CoreInternal.NewCreature newCreature = this.c43b8e3825a14806b9a3761b45c778de0;
				CoreInternal.NewCreature newCreature2;
				do
				{
					newCreature2 = newCreature;
					CoreInternal.NewCreature value2 = (CoreInternal.NewCreature)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newCreature2, value);
					newCreature = Interlocked.CompareExchange<CoreInternal.NewCreature>(ref this.c43b8e3825a14806b9a3761b45c778de0, value2, newCreature2);
				}
				while (newCreature != newCreature2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onNewCreature(CoreInternal.NewCreature)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.NewCreature newCreature = this.c43b8e3825a14806b9a3761b45c778de0;
				CoreInternal.NewCreature newCreature2;
				do
				{
					newCreature2 = newCreature;
					CoreInternal.NewCreature value2 = (CoreInternal.NewCreature)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newCreature2, value);
					newCreature = Interlocked.CompareExchange<CoreInternal.NewCreature>(ref this.c43b8e3825a14806b9a3761b45c778de0, value2, newCreature2);
				}
				while (newCreature != newCreature2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onNewCreature(CoreInternal.NewCreature)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00123C28 File Offset: 0x00121E28
		private void c98ebdfd23879ebebd17ac1c15dd37bb1(Creature creature)
		{
			try
			{
				if (this.c43b8e3825a14806b9a3761b45c778de0 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c98ebdfd23879ebebd17ac1c15dd37bb1(Creature)).MethodHandle;
					}
					ccc02bc23f7c9ef72817e4df725514db7.c30767ddca1f9c207888833aea5b5fc61(this.c43b8e3825a14806b9a3761b45c778de0, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001B8D RID: 7053 RVA: 0x00123C74 File Offset: 0x00121E74
		// (remove) Token: 0x06001B8E RID: 7054 RVA: 0x00123CC0 File Offset: 0x00121EC0
		public event CoreInternal.PartyInvite onPartyInvite
		{
			add
			{
				CoreInternal.PartyInvite partyInvite = this.cd3ee183dfcb2a7bfa069084256f350c4;
				CoreInternal.PartyInvite partyInvite2;
				do
				{
					partyInvite2 = partyInvite;
					CoreInternal.PartyInvite value2 = (CoreInternal.PartyInvite)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(partyInvite2, value);
					partyInvite = Interlocked.CompareExchange<CoreInternal.PartyInvite>(ref this.cd3ee183dfcb2a7bfa069084256f350c4, value2, partyInvite2);
				}
				while (partyInvite != partyInvite2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onPartyInvite(CoreInternal.PartyInvite)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.PartyInvite partyInvite = this.cd3ee183dfcb2a7bfa069084256f350c4;
				CoreInternal.PartyInvite partyInvite2;
				do
				{
					partyInvite2 = partyInvite;
					CoreInternal.PartyInvite value2 = (CoreInternal.PartyInvite)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(partyInvite2, value);
					partyInvite = Interlocked.CompareExchange<CoreInternal.PartyInvite>(ref this.cd3ee183dfcb2a7bfa069084256f350c4, value2, partyInvite2);
				}
				while (partyInvite != partyInvite2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onPartyInvite(CoreInternal.PartyInvite)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00123D0C File Offset: 0x00121F0C
		private void cbc03a64955bbfab36e1d061438622d5c(string text)
		{
			try
			{
				if (this.cd3ee183dfcb2a7bfa069084256f350c4 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cbc03a64955bbfab36e1d061438622d5c(string)).MethodHandle;
					}
					c4e0ba1308a4813138d38b9cc0b7c42d1.c30767ddca1f9c207888833aea5b5fc61(this.cd3ee183dfcb2a7bfa069084256f350c4, text);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001B90 RID: 7056 RVA: 0x00123D58 File Offset: 0x00121F58
		// (remove) Token: 0x06001B91 RID: 7057 RVA: 0x00123DA4 File Offset: 0x00121FA4
		public event CoreInternal.RaidInvite onRaidInvite
		{
			add
			{
				CoreInternal.RaidInvite raidInvite = this.c1252fd56398f82e6fb8f360193b6be59;
				CoreInternal.RaidInvite raidInvite2;
				do
				{
					raidInvite2 = raidInvite;
					CoreInternal.RaidInvite value2 = (CoreInternal.RaidInvite)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(raidInvite2, value);
					raidInvite = Interlocked.CompareExchange<CoreInternal.RaidInvite>(ref this.c1252fd56398f82e6fb8f360193b6be59, value2, raidInvite2);
				}
				while (raidInvite != raidInvite2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onRaidInvite(CoreInternal.RaidInvite)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.RaidInvite raidInvite = this.c1252fd56398f82e6fb8f360193b6be59;
				CoreInternal.RaidInvite raidInvite2;
				do
				{
					raidInvite2 = raidInvite;
					CoreInternal.RaidInvite value2 = (CoreInternal.RaidInvite)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(raidInvite2, value);
					raidInvite = Interlocked.CompareExchange<CoreInternal.RaidInvite>(ref this.c1252fd56398f82e6fb8f360193b6be59, value2, raidInvite2);
				}
				while (raidInvite != raidInvite2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onRaidInvite(CoreInternal.RaidInvite)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00123DF0 File Offset: 0x00121FF0
		private void ca1a748f0d8c8c1bc1431079bb4d99aff(string text)
		{
			try
			{
				if (this.c1252fd56398f82e6fb8f360193b6be59 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.ca1a748f0d8c8c1bc1431079bb4d99aff(string)).MethodHandle;
					}
					cf17d444a29a51b5cbfc4753b20078708.c30767ddca1f9c207888833aea5b5fc61(this.c1252fd56398f82e6fb8f360193b6be59, text);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001B93 RID: 7059 RVA: 0x00123E3C File Offset: 0x0012203C
		// (remove) Token: 0x06001B94 RID: 7060 RVA: 0x00123E88 File Offset: 0x00122088
		public event CoreInternal.LevelChanged onLevelChanged
		{
			add
			{
				CoreInternal.LevelChanged levelChanged = this.c3ca0e44dc58274cbd86481abf07fbb1c;
				CoreInternal.LevelChanged levelChanged2;
				do
				{
					levelChanged2 = levelChanged;
					CoreInternal.LevelChanged value2 = (CoreInternal.LevelChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(levelChanged2, value);
					levelChanged = Interlocked.CompareExchange<CoreInternal.LevelChanged>(ref this.c3ca0e44dc58274cbd86481abf07fbb1c, value2, levelChanged2);
				}
				while (levelChanged != levelChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onLevelChanged(CoreInternal.LevelChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.LevelChanged levelChanged = this.c3ca0e44dc58274cbd86481abf07fbb1c;
				CoreInternal.LevelChanged levelChanged2;
				do
				{
					levelChanged2 = levelChanged;
					CoreInternal.LevelChanged value2 = (CoreInternal.LevelChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(levelChanged2, value);
					levelChanged = Interlocked.CompareExchange<CoreInternal.LevelChanged>(ref this.c3ca0e44dc58274cbd86481abf07fbb1c, value2, levelChanged2);
				}
				while (levelChanged != levelChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onLevelChanged(CoreInternal.LevelChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00123ED4 File Offset: 0x001220D4
		private void c67917afff0757db5de1ed0aa976d73ba(Creature creature, int num)
		{
			try
			{
				if (this.c3ca0e44dc58274cbd86481abf07fbb1c != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c67917afff0757db5de1ed0aa976d73ba(Creature, int)).MethodHandle;
					}
					ce8ab0c27367c104b40da182119dc038c.c30767ddca1f9c207888833aea5b5fc61(this.c3ca0e44dc58274cbd86481abf07fbb1c, creature, num);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001B96 RID: 7062 RVA: 0x00123F20 File Offset: 0x00122120
		// (remove) Token: 0x06001B97 RID: 7063 RVA: 0x00123F6C File Offset: 0x0012216C
		public event CoreInternal.CreatureDied onCreatureDied
		{
			add
			{
				CoreInternal.CreatureDied creatureDied = this.c0af0ded751c7c1a2c969c92817af8012;
				CoreInternal.CreatureDied creatureDied2;
				do
				{
					creatureDied2 = creatureDied;
					CoreInternal.CreatureDied value2 = (CoreInternal.CreatureDied)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(creatureDied2, value);
					creatureDied = Interlocked.CompareExchange<CoreInternal.CreatureDied>(ref this.c0af0ded751c7c1a2c969c92817af8012, value2, creatureDied2);
				}
				while (creatureDied != creatureDied2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onCreatureDied(CoreInternal.CreatureDied)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.CreatureDied creatureDied = this.c0af0ded751c7c1a2c969c92817af8012;
				CoreInternal.CreatureDied creatureDied2;
				do
				{
					creatureDied2 = creatureDied;
					CoreInternal.CreatureDied value2 = (CoreInternal.CreatureDied)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(creatureDied2, value);
					creatureDied = Interlocked.CompareExchange<CoreInternal.CreatureDied>(ref this.c0af0ded751c7c1a2c969c92817af8012, value2, creatureDied2);
				}
				while (creatureDied != creatureDied2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onCreatureDied(CoreInternal.CreatureDied)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x00123FB8 File Offset: 0x001221B8
		private void c9e623d318c2cadc9f6df6ee5b771f2ab(Creature creature)
		{
			try
			{
				if (this.c0af0ded751c7c1a2c969c92817af8012 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c9e623d318c2cadc9f6df6ee5b771f2ab(Creature)).MethodHandle;
					}
					c24ad93369b293ea313276749eb1c6103.c30767ddca1f9c207888833aea5b5fc61(this.c0af0ded751c7c1a2c969c92817af8012, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06001B99 RID: 7065 RVA: 0x00124004 File Offset: 0x00122204
		// (remove) Token: 0x06001B9A RID: 7066 RVA: 0x00124050 File Offset: 0x00122250
		public event CoreInternal.SkillCasting onSkillCasting
		{
			add
			{
				CoreInternal.SkillCasting skillCasting = this.c96b9c1ce38178028633262e404bae2e3;
				CoreInternal.SkillCasting skillCasting2;
				do
				{
					skillCasting2 = skillCasting;
					CoreInternal.SkillCasting value2 = (CoreInternal.SkillCasting)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(skillCasting2, value);
					skillCasting = Interlocked.CompareExchange<CoreInternal.SkillCasting>(ref this.c96b9c1ce38178028633262e404bae2e3, value2, skillCasting2);
				}
				while (skillCasting != skillCasting2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onSkillCasting(CoreInternal.SkillCasting)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.SkillCasting skillCasting = this.c96b9c1ce38178028633262e404bae2e3;
				CoreInternal.SkillCasting skillCasting2;
				do
				{
					skillCasting2 = skillCasting;
					CoreInternal.SkillCasting value2 = (CoreInternal.SkillCasting)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(skillCasting2, value);
					skillCasting = Interlocked.CompareExchange<CoreInternal.SkillCasting>(ref this.c96b9c1ce38178028633262e404bae2e3, value2, skillCasting2);
				}
				while (skillCasting != skillCasting2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onSkillCasting(CoreInternal.SkillCasting)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x0012409C File Offset: 0x0012229C
		private void c084f876377fae9f5ac883fd588d638b3(Creature creature, SpawnObject spawnObject, Skill skill, double num, double num2, double num3)
		{
			try
			{
				if (this.c96b9c1ce38178028633262e404bae2e3 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c084f876377fae9f5ac883fd588d638b3(Creature, SpawnObject, Skill, double, double, double)).MethodHandle;
					}
					c7ca3091037f8371190507a96dadd4b98.c30767ddca1f9c207888833aea5b5fc61(this.c96b9c1ce38178028633262e404bae2e3, creature, spawnObject, skill, num, num2, num3);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06001B9C RID: 7068 RVA: 0x001240F0 File Offset: 0x001222F0
		// (remove) Token: 0x06001B9D RID: 7069 RVA: 0x0012413C File Offset: 0x0012233C
		public event CoreInternal.TradeStarted onTradeStarted
		{
			add
			{
				CoreInternal.TradeStarted tradeStarted = this.c6f2443ac19193b27fd26df3addf35869;
				CoreInternal.TradeStarted tradeStarted2;
				do
				{
					tradeStarted2 = tradeStarted;
					CoreInternal.TradeStarted value2 = (CoreInternal.TradeStarted)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(tradeStarted2, value);
					tradeStarted = Interlocked.CompareExchange<CoreInternal.TradeStarted>(ref this.c6f2443ac19193b27fd26df3addf35869, value2, tradeStarted2);
				}
				while (tradeStarted != tradeStarted2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onTradeStarted(CoreInternal.TradeStarted)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.TradeStarted tradeStarted = this.c6f2443ac19193b27fd26df3addf35869;
				CoreInternal.TradeStarted tradeStarted2;
				do
				{
					tradeStarted2 = tradeStarted;
					CoreInternal.TradeStarted value2 = (CoreInternal.TradeStarted)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(tradeStarted2, value);
					tradeStarted = Interlocked.CompareExchange<CoreInternal.TradeStarted>(ref this.c6f2443ac19193b27fd26df3addf35869, value2, tradeStarted2);
				}
				while (tradeStarted != tradeStarted2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onTradeStarted(CoreInternal.TradeStarted)).MethodHandle;
				}
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00124188 File Offset: 0x00122388
		private void c8da8d62b9caa601437bba5f83ea6fecc(Creature creature)
		{
			try
			{
				if (this.c6f2443ac19193b27fd26df3addf35869 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c8da8d62b9caa601437bba5f83ea6fecc(Creature)).MethodHandle;
					}
					c950cbbe740c5e5feb7b5ee67cadc6f4b.c30767ddca1f9c207888833aea5b5fc61(this.c6f2443ac19193b27fd26df3addf35869, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06001B9F RID: 7071 RVA: 0x001241D4 File Offset: 0x001223D4
		// (remove) Token: 0x06001BA0 RID: 7072 RVA: 0x00124220 File Offset: 0x00122420
		public event CoreInternal.TradeDone onTradeDone
		{
			add
			{
				CoreInternal.TradeDone tradeDone = this.c9672d0cacc1487837c7a06935571cd68;
				CoreInternal.TradeDone tradeDone2;
				do
				{
					tradeDone2 = tradeDone;
					CoreInternal.TradeDone value2 = (CoreInternal.TradeDone)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(tradeDone2, value);
					tradeDone = Interlocked.CompareExchange<CoreInternal.TradeDone>(ref this.c9672d0cacc1487837c7a06935571cd68, value2, tradeDone2);
				}
				while (tradeDone != tradeDone2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onTradeDone(CoreInternal.TradeDone)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.TradeDone tradeDone = this.c9672d0cacc1487837c7a06935571cd68;
				CoreInternal.TradeDone tradeDone2;
				do
				{
					tradeDone2 = tradeDone;
					CoreInternal.TradeDone value2 = (CoreInternal.TradeDone)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(tradeDone2, value);
					tradeDone = Interlocked.CompareExchange<CoreInternal.TradeDone>(ref this.c9672d0cacc1487837c7a06935571cd68, value2, tradeDone2);
				}
				while (tradeDone != tradeDone2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onTradeDone(CoreInternal.TradeDone)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0012426C File Offset: 0x0012246C
		private void cae0fb65eb0528d8eee99992bc5a16f46(Creature creature)
		{
			try
			{
				if (this.c9672d0cacc1487837c7a06935571cd68 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cae0fb65eb0528d8eee99992bc5a16f46(Creature)).MethodHandle;
					}
					c873cd8a43ecfdc97aafc09d34fe354f0.c30767ddca1f9c207888833aea5b5fc61(this.c9672d0cacc1487837c7a06935571cd68, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06001BA2 RID: 7074 RVA: 0x001242B8 File Offset: 0x001224B8
		// (remove) Token: 0x06001BA3 RID: 7075 RVA: 0x00124304 File Offset: 0x00122504
		public event CoreInternal.ChatMessage onChatMessage
		{
			add
			{
				CoreInternal.ChatMessage chatMessage = this.c7a43755b896ef786f7d3267c8e137a5b;
				CoreInternal.ChatMessage chatMessage2;
				do
				{
					chatMessage2 = chatMessage;
					CoreInternal.ChatMessage value2 = (CoreInternal.ChatMessage)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(chatMessage2, value);
					chatMessage = Interlocked.CompareExchange<CoreInternal.ChatMessage>(ref this.c7a43755b896ef786f7d3267c8e137a5b, value2, chatMessage2);
				}
				while (chatMessage != chatMessage2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onChatMessage(CoreInternal.ChatMessage)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.ChatMessage chatMessage = this.c7a43755b896ef786f7d3267c8e137a5b;
				CoreInternal.ChatMessage chatMessage2;
				do
				{
					chatMessage2 = chatMessage;
					CoreInternal.ChatMessage value2 = (CoreInternal.ChatMessage)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(chatMessage2, value);
					chatMessage = Interlocked.CompareExchange<CoreInternal.ChatMessage>(ref this.c7a43755b896ef786f7d3267c8e137a5b, value2, chatMessage2);
				}
				while (chatMessage != chatMessage2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onChatMessage(CoreInternal.ChatMessage)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x00124350 File Offset: 0x00122550
		private void c2e85e7c57d9ad08259612167fe936293(ChatType chatType, string text, string text2)
		{
			try
			{
				if (this.c7a43755b896ef786f7d3267c8e137a5b != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c2e85e7c57d9ad08259612167fe936293(ChatType, string, string)).MethodHandle;
					}
					c7bf11f93aaca63e842f0ec3534bab862.c30767ddca1f9c207888833aea5b5fc61(this.c7a43755b896ef786f7d3267c8e137a5b, chatType, text, text2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06001BA5 RID: 7077 RVA: 0x0012439C File Offset: 0x0012259C
		// (remove) Token: 0x06001BA6 RID: 7078 RVA: 0x001243E8 File Offset: 0x001225E8
		public event CoreInternal.QuestStarted onQuestStarted
		{
			add
			{
				CoreInternal.QuestStarted questStarted = this.cf92373f7bd6549378351b99ef76a1ba4;
				CoreInternal.QuestStarted questStarted2;
				do
				{
					questStarted2 = questStarted;
					CoreInternal.QuestStarted value2 = (CoreInternal.QuestStarted)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(questStarted2, value);
					questStarted = Interlocked.CompareExchange<CoreInternal.QuestStarted>(ref this.cf92373f7bd6549378351b99ef76a1ba4, value2, questStarted2);
				}
				while (questStarted != questStarted2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onQuestStarted(CoreInternal.QuestStarted)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.QuestStarted questStarted = this.cf92373f7bd6549378351b99ef76a1ba4;
				CoreInternal.QuestStarted questStarted2;
				do
				{
					questStarted2 = questStarted;
					CoreInternal.QuestStarted value2 = (CoreInternal.QuestStarted)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(questStarted2, value);
					questStarted = Interlocked.CompareExchange<CoreInternal.QuestStarted>(ref this.cf92373f7bd6549378351b99ef76a1ba4, value2, questStarted2);
				}
				while (questStarted != questStarted2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onQuestStarted(CoreInternal.QuestStarted)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00124434 File Offset: 0x00122634
		private void c6211c0ddcdf9ac883bda4cca0f751664(Quest quest)
		{
			try
			{
				if (this.cf92373f7bd6549378351b99ef76a1ba4 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c6211c0ddcdf9ac883bda4cca0f751664(Quest)).MethodHandle;
					}
					cccf85907c8efe2f86c7eaea9ea76ece7.c30767ddca1f9c207888833aea5b5fc61(this.cf92373f7bd6549378351b99ef76a1ba4, quest);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06001BA8 RID: 7080 RVA: 0x00124480 File Offset: 0x00122680
		// (remove) Token: 0x06001BA9 RID: 7081 RVA: 0x001244CC File Offset: 0x001226CC
		public event CoreInternal.QuestUpdated onQuestUpdated
		{
			add
			{
				CoreInternal.QuestUpdated questUpdated = this.caf5faa74fe32f15605124c7ced738f9d;
				CoreInternal.QuestUpdated questUpdated2;
				do
				{
					questUpdated2 = questUpdated;
					CoreInternal.QuestUpdated value2 = (CoreInternal.QuestUpdated)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(questUpdated2, value);
					questUpdated = Interlocked.CompareExchange<CoreInternal.QuestUpdated>(ref this.caf5faa74fe32f15605124c7ced738f9d, value2, questUpdated2);
				}
				while (questUpdated != questUpdated2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onQuestUpdated(CoreInternal.QuestUpdated)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.QuestUpdated questUpdated = this.caf5faa74fe32f15605124c7ced738f9d;
				CoreInternal.QuestUpdated questUpdated2;
				do
				{
					questUpdated2 = questUpdated;
					CoreInternal.QuestUpdated value2 = (CoreInternal.QuestUpdated)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(questUpdated2, value);
					questUpdated = Interlocked.CompareExchange<CoreInternal.QuestUpdated>(ref this.caf5faa74fe32f15605124c7ced738f9d, value2, questUpdated2);
				}
				while (questUpdated != questUpdated2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onQuestUpdated(CoreInternal.QuestUpdated)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00124518 File Offset: 0x00122718
		private void c26415d27c9a07c2a753b573e63c8f9f2(Quest quest)
		{
			try
			{
				if (this.caf5faa74fe32f15605124c7ced738f9d != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c26415d27c9a07c2a753b573e63c8f9f2(Quest)).MethodHandle;
					}
					c5dd51d8c35967e31ffd2c858df81d0c4.c30767ddca1f9c207888833aea5b5fc61(this.caf5faa74fe32f15605124c7ced738f9d, quest);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06001BAB RID: 7083 RVA: 0x00124564 File Offset: 0x00122764
		// (remove) Token: 0x06001BAC RID: 7084 RVA: 0x001245B0 File Offset: 0x001227B0
		public event CoreInternal.QuestCompleted onQuestCompleted
		{
			add
			{
				CoreInternal.QuestCompleted questCompleted = this.c03639ec18a453618ad6c88ccda0ffc17;
				CoreInternal.QuestCompleted questCompleted2;
				do
				{
					questCompleted2 = questCompleted;
					CoreInternal.QuestCompleted value2 = (CoreInternal.QuestCompleted)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(questCompleted2, value);
					questCompleted = Interlocked.CompareExchange<CoreInternal.QuestCompleted>(ref this.c03639ec18a453618ad6c88ccda0ffc17, value2, questCompleted2);
				}
				while (questCompleted != questCompleted2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onQuestCompleted(CoreInternal.QuestCompleted)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.QuestCompleted questCompleted = this.c03639ec18a453618ad6c88ccda0ffc17;
				CoreInternal.QuestCompleted questCompleted2;
				do
				{
					questCompleted2 = questCompleted;
					CoreInternal.QuestCompleted value2 = (CoreInternal.QuestCompleted)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(questCompleted2, value);
					questCompleted = Interlocked.CompareExchange<CoreInternal.QuestCompleted>(ref this.c03639ec18a453618ad6c88ccda0ffc17, value2, questCompleted2);
				}
				while (questCompleted != questCompleted2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onQuestCompleted(CoreInternal.QuestCompleted)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x001245FC File Offset: 0x001227FC
		private void c3031e421b0db4d0e05a2538461abfd75(Quest quest)
		{
			try
			{
				if (this.c03639ec18a453618ad6c88ccda0ffc17 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c3031e421b0db4d0e05a2538461abfd75(Quest)).MethodHandle;
					}
					ca2546806adb334455676895426b9ee06.c30767ddca1f9c207888833aea5b5fc61(this.c03639ec18a453618ad6c88ccda0ffc17, quest);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06001BAE RID: 7086 RVA: 0x00124648 File Offset: 0x00122848
		// (remove) Token: 0x06001BAF RID: 7087 RVA: 0x00124694 File Offset: 0x00122894
		public event CoreInternal.LootAvailable onLootAvailable
		{
			add
			{
				CoreInternal.LootAvailable lootAvailable = this.c682f0526195a82f02b53a67f1629806c;
				CoreInternal.LootAvailable lootAvailable2;
				do
				{
					lootAvailable2 = lootAvailable;
					CoreInternal.LootAvailable value2 = (CoreInternal.LootAvailable)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(lootAvailable2, value);
					lootAvailable = Interlocked.CompareExchange<CoreInternal.LootAvailable>(ref this.c682f0526195a82f02b53a67f1629806c, value2, lootAvailable2);
				}
				while (lootAvailable != lootAvailable2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onLootAvailable(CoreInternal.LootAvailable)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.LootAvailable lootAvailable = this.c682f0526195a82f02b53a67f1629806c;
				CoreInternal.LootAvailable lootAvailable2;
				do
				{
					lootAvailable2 = lootAvailable;
					CoreInternal.LootAvailable value2 = (CoreInternal.LootAvailable)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(lootAvailable2, value);
					lootAvailable = Interlocked.CompareExchange<CoreInternal.LootAvailable>(ref this.c682f0526195a82f02b53a67f1629806c, value2, lootAvailable2);
				}
				while (lootAvailable != lootAvailable2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onLootAvailable(CoreInternal.LootAvailable)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x001246E0 File Offset: 0x001228E0
		private void ca1e10121a3eb73c9d961fee7114e0954(Creature creature)
		{
			try
			{
				if (this.c682f0526195a82f02b53a67f1629806c != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.ca1e10121a3eb73c9d961fee7114e0954(Creature)).MethodHandle;
					}
					c2c3b005577e858fe2b81bb4595d26bfa.c30767ddca1f9c207888833aea5b5fc61(this.c682f0526195a82f02b53a67f1629806c, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06001BB1 RID: 7089 RVA: 0x0012472C File Offset: 0x0012292C
		// (remove) Token: 0x06001BB2 RID: 7090 RVA: 0x00124778 File Offset: 0x00122978
		public event CoreInternal.NewInvItem onNewInvItem
		{
			add
			{
				CoreInternal.NewInvItem newInvItem = this.c534cb9e5119a4eb7229a4bdf00346931;
				CoreInternal.NewInvItem newInvItem2;
				do
				{
					newInvItem2 = newInvItem;
					CoreInternal.NewInvItem value2 = (CoreInternal.NewInvItem)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newInvItem2, value);
					newInvItem = Interlocked.CompareExchange<CoreInternal.NewInvItem>(ref this.c534cb9e5119a4eb7229a4bdf00346931, value2, newInvItem2);
				}
				while (newInvItem != newInvItem2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onNewInvItem(CoreInternal.NewInvItem)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.NewInvItem newInvItem = this.c534cb9e5119a4eb7229a4bdf00346931;
				CoreInternal.NewInvItem newInvItem2;
				do
				{
					newInvItem2 = newInvItem;
					CoreInternal.NewInvItem value2 = (CoreInternal.NewInvItem)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newInvItem2, value);
					newInvItem = Interlocked.CompareExchange<CoreInternal.NewInvItem>(ref this.c534cb9e5119a4eb7229a4bdf00346931, value2, newInvItem2);
				}
				while (newInvItem != newInvItem2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onNewInvItem(CoreInternal.NewInvItem)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x001247C4 File Offset: 0x001229C4
		private void c6e8521f4ce01e2af7ab43aaaf2ba8dc6(Item item, int num)
		{
			try
			{
				if (this.c534cb9e5119a4eb7229a4bdf00346931 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c6e8521f4ce01e2af7ab43aaaf2ba8dc6(Item, int)).MethodHandle;
					}
					c7ebb811beef2077623df63b0168c50d9.c30767ddca1f9c207888833aea5b5fc61(this.c534cb9e5119a4eb7229a4bdf00346931, item, num);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06001BB4 RID: 7092 RVA: 0x00124810 File Offset: 0x00122A10
		// (remove) Token: 0x06001BB5 RID: 7093 RVA: 0x0012485C File Offset: 0x00122A5C
		public event CoreInternal.InvItemRemoved onInvItemRemoved
		{
			add
			{
				CoreInternal.InvItemRemoved invItemRemoved = this.cd8835f412e02ee6b68522c11c3f9f636;
				CoreInternal.InvItemRemoved invItemRemoved2;
				do
				{
					invItemRemoved2 = invItemRemoved;
					CoreInternal.InvItemRemoved value2 = (CoreInternal.InvItemRemoved)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(invItemRemoved2, value);
					invItemRemoved = Interlocked.CompareExchange<CoreInternal.InvItemRemoved>(ref this.cd8835f412e02ee6b68522c11c3f9f636, value2, invItemRemoved2);
				}
				while (invItemRemoved != invItemRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onInvItemRemoved(CoreInternal.InvItemRemoved)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.InvItemRemoved invItemRemoved = this.cd8835f412e02ee6b68522c11c3f9f636;
				CoreInternal.InvItemRemoved invItemRemoved2;
				do
				{
					invItemRemoved2 = invItemRemoved;
					CoreInternal.InvItemRemoved value2 = (CoreInternal.InvItemRemoved)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(invItemRemoved2, value);
					invItemRemoved = Interlocked.CompareExchange<CoreInternal.InvItemRemoved>(ref this.cd8835f412e02ee6b68522c11c3f9f636, value2, invItemRemoved2);
				}
				while (invItemRemoved != invItemRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onInvItemRemoved(CoreInternal.InvItemRemoved)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x001248A8 File Offset: 0x00122AA8
		private void ce901484200faa3aad7e4579b93c7ddc9(Item item, int num)
		{
			try
			{
				if (this.cd8835f412e02ee6b68522c11c3f9f636 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.ce901484200faa3aad7e4579b93c7ddc9(Item, int)).MethodHandle;
					}
					cef5bde7bf4392c8cd38bc85445956717.c30767ddca1f9c207888833aea5b5fc61(this.cd8835f412e02ee6b68522c11c3f9f636, item, num);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06001BB7 RID: 7095 RVA: 0x001248F4 File Offset: 0x00122AF4
		// (remove) Token: 0x06001BB8 RID: 7096 RVA: 0x00124940 File Offset: 0x00122B40
		public event CoreInternal.NewMail onNewMail
		{
			add
			{
				CoreInternal.NewMail newMail = this.ccd3ac50bc5d507a22de8369a181368b5;
				CoreInternal.NewMail newMail2;
				do
				{
					newMail2 = newMail;
					CoreInternal.NewMail value2 = (CoreInternal.NewMail)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newMail2, value);
					newMail = Interlocked.CompareExchange<CoreInternal.NewMail>(ref this.ccd3ac50bc5d507a22de8369a181368b5, value2, newMail2);
				}
				while (newMail != newMail2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onNewMail(CoreInternal.NewMail)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.NewMail newMail = this.ccd3ac50bc5d507a22de8369a181368b5;
				CoreInternal.NewMail newMail2;
				do
				{
					newMail2 = newMail;
					CoreInternal.NewMail value2 = (CoreInternal.NewMail)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newMail2, value);
					newMail = Interlocked.CompareExchange<CoreInternal.NewMail>(ref this.ccd3ac50bc5d507a22de8369a181368b5, value2, newMail2);
				}
				while (newMail != newMail2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onNewMail(CoreInternal.NewMail)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0012498C File Offset: 0x00122B8C
		private void cc39b76cebd6ab346f00355ad1419c0dd(Mail mail)
		{
			try
			{
				if (this.ccd3ac50bc5d507a22de8369a181368b5 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cc39b76cebd6ab346f00355ad1419c0dd(Mail)).MethodHandle;
					}
					c7702a8255ebc26330a7eec6c6c112c61.c30767ddca1f9c207888833aea5b5fc61(this.ccd3ac50bc5d507a22de8369a181368b5, mail);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06001BBA RID: 7098 RVA: 0x001249D8 File Offset: 0x00122BD8
		// (remove) Token: 0x06001BBB RID: 7099 RVA: 0x00124A24 File Offset: 0x00122C24
		public event CoreInternal.LotSelled onLotSelled
		{
			add
			{
				CoreInternal.LotSelled lotSelled = this.c03907515698aafc81f6542211a9c0eb9;
				CoreInternal.LotSelled lotSelled2;
				do
				{
					lotSelled2 = lotSelled;
					CoreInternal.LotSelled value2 = (CoreInternal.LotSelled)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(lotSelled2, value);
					lotSelled = Interlocked.CompareExchange<CoreInternal.LotSelled>(ref this.c03907515698aafc81f6542211a9c0eb9, value2, lotSelled2);
				}
				while (lotSelled != lotSelled2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onLotSelled(CoreInternal.LotSelled)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.LotSelled lotSelled = this.c03907515698aafc81f6542211a9c0eb9;
				CoreInternal.LotSelled lotSelled2;
				do
				{
					lotSelled2 = lotSelled;
					CoreInternal.LotSelled value2 = (CoreInternal.LotSelled)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(lotSelled2, value);
					lotSelled = Interlocked.CompareExchange<CoreInternal.LotSelled>(ref this.c03907515698aafc81f6542211a9c0eb9, value2, lotSelled2);
				}
				while (lotSelled != lotSelled2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onLotSelled(CoreInternal.LotSelled)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00124A70 File Offset: 0x00122C70
		private void c03e97844326c51622dba3a1a656e5dc4(uint num, int num2)
		{
			try
			{
				if (this.c03907515698aafc81f6542211a9c0eb9 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c03e97844326c51622dba3a1a656e5dc4(uint, int)).MethodHandle;
					}
					c399b886b75e651cc7f92e7617f71bab0.c30767ddca1f9c207888833aea5b5fc61(this.c03907515698aafc81f6542211a9c0eb9, num, num2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06001BBD RID: 7101 RVA: 0x00124ABC File Offset: 0x00122CBC
		// (remove) Token: 0x06001BBE RID: 7102 RVA: 0x00124B08 File Offset: 0x00122D08
		public event CoreInternal.UnitDamaged onUnitDamaged
		{
			add
			{
				CoreInternal.UnitDamaged unitDamaged = this.c74868cdb6316e82968dcb34dca68404c;
				CoreInternal.UnitDamaged unitDamaged2;
				do
				{
					unitDamaged2 = unitDamaged;
					CoreInternal.UnitDamaged value2 = (CoreInternal.UnitDamaged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(unitDamaged2, value);
					unitDamaged = Interlocked.CompareExchange<CoreInternal.UnitDamaged>(ref this.c74868cdb6316e82968dcb34dca68404c, value2, unitDamaged2);
				}
				while (unitDamaged != unitDamaged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onUnitDamaged(CoreInternal.UnitDamaged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.UnitDamaged unitDamaged = this.c74868cdb6316e82968dcb34dca68404c;
				CoreInternal.UnitDamaged unitDamaged2;
				do
				{
					unitDamaged2 = unitDamaged;
					CoreInternal.UnitDamaged value2 = (CoreInternal.UnitDamaged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(unitDamaged2, value);
					unitDamaged = Interlocked.CompareExchange<CoreInternal.UnitDamaged>(ref this.c74868cdb6316e82968dcb34dca68404c, value2, unitDamaged2);
				}
				while (unitDamaged != unitDamaged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onUnitDamaged(CoreInternal.UnitDamaged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00124B54 File Offset: 0x00122D54
		private void cd91071762f13bb8e0f98f480ea32c532(Creature creature, Creature creature2, uint num, uint num2)
		{
			try
			{
				if (this.c74868cdb6316e82968dcb34dca68404c != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cd91071762f13bb8e0f98f480ea32c532(Creature, Creature, uint, uint)).MethodHandle;
					}
					c8c97069af6830f3d3a9fa7db637d48cd.c30767ddca1f9c207888833aea5b5fc61(this.c74868cdb6316e82968dcb34dca68404c, creature, creature2, num, num2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06001BC0 RID: 7104 RVA: 0x00124BA4 File Offset: 0x00122DA4
		// (remove) Token: 0x06001BC1 RID: 7105 RVA: 0x00124BF0 File Offset: 0x00122DF0
		public event CoreInternal.UnitHealed onUnitHealed
		{
			add
			{
				CoreInternal.UnitHealed unitHealed = this.ca833aee3251897821e5642600b79814b;
				CoreInternal.UnitHealed unitHealed2;
				do
				{
					unitHealed2 = unitHealed;
					CoreInternal.UnitHealed value2 = (CoreInternal.UnitHealed)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(unitHealed2, value);
					unitHealed = Interlocked.CompareExchange<CoreInternal.UnitHealed>(ref this.ca833aee3251897821e5642600b79814b, value2, unitHealed2);
				}
				while (unitHealed != unitHealed2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onUnitHealed(CoreInternal.UnitHealed)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.UnitHealed unitHealed = this.ca833aee3251897821e5642600b79814b;
				CoreInternal.UnitHealed unitHealed2;
				do
				{
					unitHealed2 = unitHealed;
					CoreInternal.UnitHealed value2 = (CoreInternal.UnitHealed)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(unitHealed2, value);
					unitHealed = Interlocked.CompareExchange<CoreInternal.UnitHealed>(ref this.ca833aee3251897821e5642600b79814b, value2, unitHealed2);
				}
				while (unitHealed != unitHealed2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onUnitHealed(CoreInternal.UnitHealed)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00124C3C File Offset: 0x00122E3C
		private void c5e51d5502b5210737340918e61ef5f3c(Creature creature, Creature creature2, int num, int num2)
		{
			try
			{
				if (this.ca833aee3251897821e5642600b79814b != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c5e51d5502b5210737340918e61ef5f3c(Creature, Creature, int, int)).MethodHandle;
					}
					c91e675a8f5efce0ee14df9fe29b0e45d.c30767ddca1f9c207888833aea5b5fc61(this.ca833aee3251897821e5642600b79814b, creature, creature2, num, num2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06001BC3 RID: 7107 RVA: 0x00124C8C File Offset: 0x00122E8C
		// (remove) Token: 0x06001BC4 RID: 7108 RVA: 0x00124CD8 File Offset: 0x00122ED8
		public event CoreInternal.LootDice onLootDice
		{
			add
			{
				CoreInternal.LootDice lootDice = this.c3963fda1507610b3bbcc76024e8ad4ef;
				CoreInternal.LootDice lootDice2;
				do
				{
					lootDice2 = lootDice;
					CoreInternal.LootDice value2 = (CoreInternal.LootDice)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(lootDice2, value);
					lootDice = Interlocked.CompareExchange<CoreInternal.LootDice>(ref this.c3963fda1507610b3bbcc76024e8ad4ef, value2, lootDice2);
				}
				while (lootDice != lootDice2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onLootDice(CoreInternal.LootDice)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.LootDice lootDice = this.c3963fda1507610b3bbcc76024e8ad4ef;
				CoreInternal.LootDice lootDice2;
				do
				{
					lootDice2 = lootDice;
					CoreInternal.LootDice value2 = (CoreInternal.LootDice)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(lootDice2, value);
					lootDice = Interlocked.CompareExchange<CoreInternal.LootDice>(ref this.c3963fda1507610b3bbcc76024e8ad4ef, value2, lootDice2);
				}
				while (lootDice != lootDice2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onLootDice(CoreInternal.LootDice)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x00124D24 File Offset: 0x00122F24
		private void c4fe0eb36f8931dd8990cf27da5e06432(Item item)
		{
			try
			{
				if (this.c3963fda1507610b3bbcc76024e8ad4ef != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c4fe0eb36f8931dd8990cf27da5e06432(Item)).MethodHandle;
					}
					cbcc6c6bbf839e7feaa4e14944a435ac7.c30767ddca1f9c207888833aea5b5fc61(this.c3963fda1507610b3bbcc76024e8ad4ef, item);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06001BC6 RID: 7110 RVA: 0x00124D70 File Offset: 0x00122F70
		// (remove) Token: 0x06001BC7 RID: 7111 RVA: 0x00124DBC File Offset: 0x00122FBC
		public event CoreInternal.NewDoodad onNewDoodad
		{
			add
			{
				CoreInternal.NewDoodad newDoodad = this.c1b082e70fe282fb43f8862ad1b06aab7;
				CoreInternal.NewDoodad newDoodad2;
				do
				{
					newDoodad2 = newDoodad;
					CoreInternal.NewDoodad value2 = (CoreInternal.NewDoodad)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newDoodad2, value);
					newDoodad = Interlocked.CompareExchange<CoreInternal.NewDoodad>(ref this.c1b082e70fe282fb43f8862ad1b06aab7, value2, newDoodad2);
				}
				while (newDoodad != newDoodad2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onNewDoodad(CoreInternal.NewDoodad)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.NewDoodad newDoodad = this.c1b082e70fe282fb43f8862ad1b06aab7;
				CoreInternal.NewDoodad newDoodad2;
				do
				{
					newDoodad2 = newDoodad;
					CoreInternal.NewDoodad value2 = (CoreInternal.NewDoodad)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newDoodad2, value);
					newDoodad = Interlocked.CompareExchange<CoreInternal.NewDoodad>(ref this.c1b082e70fe282fb43f8862ad1b06aab7, value2, newDoodad2);
				}
				while (newDoodad != newDoodad2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onNewDoodad(CoreInternal.NewDoodad)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00124E08 File Offset: 0x00123008
		private void cbd7c975f1741b65ce8ba306de3fcf473(DoodadObject doodadObject)
		{
			try
			{
				if (this.c1b082e70fe282fb43f8862ad1b06aab7 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cbd7c975f1741b65ce8ba306de3fcf473(DoodadObject)).MethodHandle;
					}
					c28fab660b375b74f2a2123353bc6eb64.c30767ddca1f9c207888833aea5b5fc61(this.c1b082e70fe282fb43f8862ad1b06aab7, doodadObject);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06001BC9 RID: 7113 RVA: 0x00124E54 File Offset: 0x00123054
		// (remove) Token: 0x06001BCA RID: 7114 RVA: 0x00124EA0 File Offset: 0x001230A0
		public event CoreInternal.DoodadRemoved onDoodadRemoved
		{
			add
			{
				CoreInternal.DoodadRemoved doodadRemoved = this.c5cb001f87ba43f44fe09b11cdd1c8c41;
				CoreInternal.DoodadRemoved doodadRemoved2;
				do
				{
					doodadRemoved2 = doodadRemoved;
					CoreInternal.DoodadRemoved value2 = (CoreInternal.DoodadRemoved)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(doodadRemoved2, value);
					doodadRemoved = Interlocked.CompareExchange<CoreInternal.DoodadRemoved>(ref this.c5cb001f87ba43f44fe09b11cdd1c8c41, value2, doodadRemoved2);
				}
				while (doodadRemoved != doodadRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onDoodadRemoved(CoreInternal.DoodadRemoved)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.DoodadRemoved doodadRemoved = this.c5cb001f87ba43f44fe09b11cdd1c8c41;
				CoreInternal.DoodadRemoved doodadRemoved2;
				do
				{
					doodadRemoved2 = doodadRemoved;
					CoreInternal.DoodadRemoved value2 = (CoreInternal.DoodadRemoved)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(doodadRemoved2, value);
					doodadRemoved = Interlocked.CompareExchange<CoreInternal.DoodadRemoved>(ref this.c5cb001f87ba43f44fe09b11cdd1c8c41, value2, doodadRemoved2);
				}
				while (doodadRemoved != doodadRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onDoodadRemoved(CoreInternal.DoodadRemoved)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00124EEC File Offset: 0x001230EC
		private void c85bac4cda347ab45b28ec19283e42855(DoodadObject doodadObject)
		{
			try
			{
				if (this.c5cb001f87ba43f44fe09b11cdd1c8c41 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c85bac4cda347ab45b28ec19283e42855(DoodadObject)).MethodHandle;
					}
					cef8b265120e391408b66de3fc435aea5.c30767ddca1f9c207888833aea5b5fc61(this.c5cb001f87ba43f44fe09b11cdd1c8c41, doodadObject);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06001BCC RID: 7116 RVA: 0x00124F38 File Offset: 0x00123138
		// (remove) Token: 0x06001BCD RID: 7117 RVA: 0x00124F84 File Offset: 0x00123184
		public event CoreInternal.CreatureRemoved onCreatureRemoved
		{
			add
			{
				CoreInternal.CreatureRemoved creatureRemoved = this.c2c72e0ad4467fff4a60a9ff579532cdb;
				CoreInternal.CreatureRemoved creatureRemoved2;
				do
				{
					creatureRemoved2 = creatureRemoved;
					CoreInternal.CreatureRemoved value2 = (CoreInternal.CreatureRemoved)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(creatureRemoved2, value);
					creatureRemoved = Interlocked.CompareExchange<CoreInternal.CreatureRemoved>(ref this.c2c72e0ad4467fff4a60a9ff579532cdb, value2, creatureRemoved2);
				}
				while (creatureRemoved != creatureRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onCreatureRemoved(CoreInternal.CreatureRemoved)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.CreatureRemoved creatureRemoved = this.c2c72e0ad4467fff4a60a9ff579532cdb;
				CoreInternal.CreatureRemoved creatureRemoved2;
				do
				{
					creatureRemoved2 = creatureRemoved;
					CoreInternal.CreatureRemoved value2 = (CoreInternal.CreatureRemoved)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(creatureRemoved2, value);
					creatureRemoved = Interlocked.CompareExchange<CoreInternal.CreatureRemoved>(ref this.c2c72e0ad4467fff4a60a9ff579532cdb, value2, creatureRemoved2);
				}
				while (creatureRemoved != creatureRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onCreatureRemoved(CoreInternal.CreatureRemoved)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00124FD0 File Offset: 0x001231D0
		private void c58ba083a6aaa875ba02c1fdceb3c49b3(Creature creature)
		{
			try
			{
				if (this.c2c72e0ad4467fff4a60a9ff579532cdb != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c58ba083a6aaa875ba02c1fdceb3c49b3(Creature)).MethodHandle;
					}
					c785aeb6413b2927a2f25670ddbd4df0b.c30767ddca1f9c207888833aea5b5fc61(this.c2c72e0ad4467fff4a60a9ff579532cdb, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06001BCF RID: 7119 RVA: 0x0012501C File Offset: 0x0012321C
		// (remove) Token: 0x06001BD0 RID: 7120 RVA: 0x00125068 File Offset: 0x00123268
		public event CoreInternal.GoldCountChanged onGoldCountChanged
		{
			add
			{
				CoreInternal.GoldCountChanged goldCountChanged = this.c56e38df8ff9da715e30c9b4959d9ac4e;
				CoreInternal.GoldCountChanged goldCountChanged2;
				do
				{
					goldCountChanged2 = goldCountChanged;
					CoreInternal.GoldCountChanged value2 = (CoreInternal.GoldCountChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(goldCountChanged2, value);
					goldCountChanged = Interlocked.CompareExchange<CoreInternal.GoldCountChanged>(ref this.c56e38df8ff9da715e30c9b4959d9ac4e, value2, goldCountChanged2);
				}
				while (goldCountChanged != goldCountChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onGoldCountChanged(CoreInternal.GoldCountChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.GoldCountChanged goldCountChanged = this.c56e38df8ff9da715e30c9b4959d9ac4e;
				CoreInternal.GoldCountChanged goldCountChanged2;
				do
				{
					goldCountChanged2 = goldCountChanged;
					CoreInternal.GoldCountChanged value2 = (CoreInternal.GoldCountChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(goldCountChanged2, value);
					goldCountChanged = Interlocked.CompareExchange<CoreInternal.GoldCountChanged>(ref this.c56e38df8ff9da715e30c9b4959d9ac4e, value2, goldCountChanged2);
				}
				while (goldCountChanged != goldCountChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onGoldCountChanged(CoreInternal.GoldCountChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x001250B4 File Offset: 0x001232B4
		private void c2b7239323e6d4c0f4b547db2bc2966b8(int num, ItemPlace itemPlace)
		{
			try
			{
				if (this.c56e38df8ff9da715e30c9b4959d9ac4e != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c2b7239323e6d4c0f4b547db2bc2966b8(int, ItemPlace)).MethodHandle;
					}
					c39c076b67a41813b7dbd16fe0adccc1d.c30767ddca1f9c207888833aea5b5fc61(this.c56e38df8ff9da715e30c9b4959d9ac4e, num, itemPlace);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06001BD2 RID: 7122 RVA: 0x00125100 File Offset: 0x00123300
		// (remove) Token: 0x06001BD3 RID: 7123 RVA: 0x0012514C File Offset: 0x0012334C
		public event CoreInternal.FoundGameMaster onFoundGameMaster
		{
			add
			{
				CoreInternal.FoundGameMaster foundGameMaster = this.c86265f69293de2a5f4e164341732086b;
				CoreInternal.FoundGameMaster foundGameMaster2;
				do
				{
					foundGameMaster2 = foundGameMaster;
					CoreInternal.FoundGameMaster value2 = (CoreInternal.FoundGameMaster)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(foundGameMaster2, value);
					foundGameMaster = Interlocked.CompareExchange<CoreInternal.FoundGameMaster>(ref this.c86265f69293de2a5f4e164341732086b, value2, foundGameMaster2);
				}
				while (foundGameMaster != foundGameMaster2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onFoundGameMaster(CoreInternal.FoundGameMaster)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.FoundGameMaster foundGameMaster = this.c86265f69293de2a5f4e164341732086b;
				CoreInternal.FoundGameMaster foundGameMaster2;
				do
				{
					foundGameMaster2 = foundGameMaster;
					CoreInternal.FoundGameMaster value2 = (CoreInternal.FoundGameMaster)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(foundGameMaster2, value);
					foundGameMaster = Interlocked.CompareExchange<CoreInternal.FoundGameMaster>(ref this.c86265f69293de2a5f4e164341732086b, value2, foundGameMaster2);
				}
				while (foundGameMaster != foundGameMaster2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onFoundGameMaster(CoreInternal.FoundGameMaster)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00125198 File Offset: 0x00123398
		private void ca4d52b9b2a51969573f81f4bad43f3b0(Creature creature)
		{
			try
			{
				if (this.c86265f69293de2a5f4e164341732086b != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.ca4d52b9b2a51969573f81f4bad43f3b0(Creature)).MethodHandle;
					}
					c68a554a0f77c7804c102020d4215c1ac.c30767ddca1f9c207888833aea5b5fc61(this.c86265f69293de2a5f4e164341732086b, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06001BD5 RID: 7125 RVA: 0x001251E4 File Offset: 0x001233E4
		// (remove) Token: 0x06001BD6 RID: 7126 RVA: 0x00125230 File Offset: 0x00123430
		public event CoreInternal.ClientPlantDoodad onClientPlantDoodad
		{
			add
			{
				CoreInternal.ClientPlantDoodad clientPlantDoodad = this.c5d3c08241889fe0c4c3e1d82ddc1128b;
				CoreInternal.ClientPlantDoodad clientPlantDoodad2;
				do
				{
					clientPlantDoodad2 = clientPlantDoodad;
					CoreInternal.ClientPlantDoodad value2 = (CoreInternal.ClientPlantDoodad)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(clientPlantDoodad2, value);
					clientPlantDoodad = Interlocked.CompareExchange<CoreInternal.ClientPlantDoodad>(ref this.c5d3c08241889fe0c4c3e1d82ddc1128b, value2, clientPlantDoodad2);
				}
				while (clientPlantDoodad != clientPlantDoodad2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onClientPlantDoodad(CoreInternal.ClientPlantDoodad)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.ClientPlantDoodad clientPlantDoodad = this.c5d3c08241889fe0c4c3e1d82ddc1128b;
				CoreInternal.ClientPlantDoodad clientPlantDoodad2;
				do
				{
					clientPlantDoodad2 = clientPlantDoodad;
					CoreInternal.ClientPlantDoodad value2 = (CoreInternal.ClientPlantDoodad)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(clientPlantDoodad2, value);
					clientPlantDoodad = Interlocked.CompareExchange<CoreInternal.ClientPlantDoodad>(ref this.c5d3c08241889fe0c4c3e1d82ddc1128b, value2, clientPlantDoodad2);
				}
				while (clientPlantDoodad != clientPlantDoodad2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onClientPlantDoodad(CoreInternal.ClientPlantDoodad)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0012527C File Offset: 0x0012347C
		private void cd4723f46128f062d33910b9d278b7595(Item item, double num, double num2, double num3)
		{
			try
			{
				if (this.c5d3c08241889fe0c4c3e1d82ddc1128b != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cd4723f46128f062d33910b9d278b7595(Item, double, double, double)).MethodHandle;
					}
					c49690dbe2f9e699963529b7e5c4ac93c.c30767ddca1f9c207888833aea5b5fc61(this.c5d3c08241889fe0c4c3e1d82ddc1128b, item, num, num2, num3);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06001BD8 RID: 7128 RVA: 0x001252CC File Offset: 0x001234CC
		// (remove) Token: 0x06001BD9 RID: 7129 RVA: 0x00125318 File Offset: 0x00123518
		public event CoreInternal.NewBuff onNewBuff
		{
			add
			{
				CoreInternal.NewBuff newBuff = this.cca3706cd3d8015e21f4b646cb769ccfe;
				CoreInternal.NewBuff newBuff2;
				do
				{
					newBuff2 = newBuff;
					CoreInternal.NewBuff value2 = (CoreInternal.NewBuff)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newBuff2, value);
					newBuff = Interlocked.CompareExchange<CoreInternal.NewBuff>(ref this.cca3706cd3d8015e21f4b646cb769ccfe, value2, newBuff2);
				}
				while (newBuff != newBuff2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onNewBuff(CoreInternal.NewBuff)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.NewBuff newBuff = this.cca3706cd3d8015e21f4b646cb769ccfe;
				CoreInternal.NewBuff newBuff2;
				do
				{
					newBuff2 = newBuff;
					CoreInternal.NewBuff value2 = (CoreInternal.NewBuff)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newBuff2, value);
					newBuff = Interlocked.CompareExchange<CoreInternal.NewBuff>(ref this.cca3706cd3d8015e21f4b646cb769ccfe, value2, newBuff2);
				}
				while (newBuff != newBuff2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onNewBuff(CoreInternal.NewBuff)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00125364 File Offset: 0x00123564
		private void c14134a43af1bc2f41e972c42cd117603(Buff buff, Creature creature)
		{
			try
			{
				if (this.cca3706cd3d8015e21f4b646cb769ccfe != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c14134a43af1bc2f41e972c42cd117603(Buff, Creature)).MethodHandle;
					}
					c031ba8868adc70abf9c7fa8182a4ae0f.c30767ddca1f9c207888833aea5b5fc61(this.cca3706cd3d8015e21f4b646cb769ccfe, buff, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06001BDB RID: 7131 RVA: 0x001253B0 File Offset: 0x001235B0
		// (remove) Token: 0x06001BDC RID: 7132 RVA: 0x001253FC File Offset: 0x001235FC
		public event CoreInternal.BuffRemoved onBuffRemoved
		{
			add
			{
				CoreInternal.BuffRemoved buffRemoved = this.cd63bf3ee97dd46ec1ca95db1386628d8;
				CoreInternal.BuffRemoved buffRemoved2;
				do
				{
					buffRemoved2 = buffRemoved;
					CoreInternal.BuffRemoved value2 = (CoreInternal.BuffRemoved)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(buffRemoved2, value);
					buffRemoved = Interlocked.CompareExchange<CoreInternal.BuffRemoved>(ref this.cd63bf3ee97dd46ec1ca95db1386628d8, value2, buffRemoved2);
				}
				while (buffRemoved != buffRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onBuffRemoved(CoreInternal.BuffRemoved)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.BuffRemoved buffRemoved = this.cd63bf3ee97dd46ec1ca95db1386628d8;
				CoreInternal.BuffRemoved buffRemoved2;
				do
				{
					buffRemoved2 = buffRemoved;
					CoreInternal.BuffRemoved value2 = (CoreInternal.BuffRemoved)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(buffRemoved2, value);
					buffRemoved = Interlocked.CompareExchange<CoreInternal.BuffRemoved>(ref this.cd63bf3ee97dd46ec1ca95db1386628d8, value2, buffRemoved2);
				}
				while (buffRemoved != buffRemoved2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onBuffRemoved(CoreInternal.BuffRemoved)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00125448 File Offset: 0x00123648
		private void cdfa0c1474efcb7de3cb56a7ed8e43acf(Buff buff, Creature creature)
		{
			try
			{
				if (this.cd63bf3ee97dd46ec1ca95db1386628d8 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cdfa0c1474efcb7de3cb56a7ed8e43acf(Buff, Creature)).MethodHandle;
					}
					cc8f04634826a0f264577d3733333a2d4.c30767ddca1f9c207888833aea5b5fc61(this.cd63bf3ee97dd46ec1ca95db1386628d8, buff, creature);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06001BDE RID: 7134 RVA: 0x00125494 File Offset: 0x00123694
		// (remove) Token: 0x06001BDF RID: 7135 RVA: 0x001254E0 File Offset: 0x001236E0
		public event CoreInternal.ErrorMessage onErrorMessage
		{
			add
			{
				CoreInternal.ErrorMessage errorMessage = this.cc4e01c8a31335179857aa85d9059b75c;
				CoreInternal.ErrorMessage errorMessage2;
				do
				{
					errorMessage2 = errorMessage;
					CoreInternal.ErrorMessage value2 = (CoreInternal.ErrorMessage)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(errorMessage2, value);
					errorMessage = Interlocked.CompareExchange<CoreInternal.ErrorMessage>(ref this.cc4e01c8a31335179857aa85d9059b75c, value2, errorMessage2);
				}
				while (errorMessage != errorMessage2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onErrorMessage(CoreInternal.ErrorMessage)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.ErrorMessage errorMessage = this.cc4e01c8a31335179857aa85d9059b75c;
				CoreInternal.ErrorMessage errorMessage2;
				do
				{
					errorMessage2 = errorMessage;
					CoreInternal.ErrorMessage value2 = (CoreInternal.ErrorMessage)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(errorMessage2, value);
					errorMessage = Interlocked.CompareExchange<CoreInternal.ErrorMessage>(ref this.cc4e01c8a31335179857aa85d9059b75c, value2, errorMessage2);
				}
				while (errorMessage != errorMessage2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onErrorMessage(CoreInternal.ErrorMessage)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0012552C File Offset: 0x0012372C
		private void c219e73b46069458a4d8b36a184d803d5(ushort num, ushort num2, uint num3, uint num4)
		{
			try
			{
				if (this.cc4e01c8a31335179857aa85d9059b75c != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c219e73b46069458a4d8b36a184d803d5(ushort, ushort, uint, uint)).MethodHandle;
					}
					c342ed7f28e254bec34941d80ad28c365.c30767ddca1f9c207888833aea5b5fc61(this.cc4e01c8a31335179857aa85d9059b75c, num, num2, num3, num4);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06001BE1 RID: 7137 RVA: 0x0012557C File Offset: 0x0012377C
		// (remove) Token: 0x06001BE2 RID: 7138 RVA: 0x001255C8 File Offset: 0x001237C8
		public event CoreInternal.MapPosChanged onMapPosChanged
		{
			add
			{
				CoreInternal.MapPosChanged mapPosChanged = this.ce3879c9b14b51ca0c13609aa713c696a;
				CoreInternal.MapPosChanged mapPosChanged2;
				do
				{
					mapPosChanged2 = mapPosChanged;
					CoreInternal.MapPosChanged value2 = (CoreInternal.MapPosChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(mapPosChanged2, value);
					mapPosChanged = Interlocked.CompareExchange<CoreInternal.MapPosChanged>(ref this.ce3879c9b14b51ca0c13609aa713c696a, value2, mapPosChanged2);
				}
				while (mapPosChanged != mapPosChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onMapPosChanged(CoreInternal.MapPosChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.MapPosChanged mapPosChanged = this.ce3879c9b14b51ca0c13609aa713c696a;
				CoreInternal.MapPosChanged mapPosChanged2;
				do
				{
					mapPosChanged2 = mapPosChanged;
					CoreInternal.MapPosChanged value2 = (CoreInternal.MapPosChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(mapPosChanged2, value);
					mapPosChanged = Interlocked.CompareExchange<CoreInternal.MapPosChanged>(ref this.ce3879c9b14b51ca0c13609aa713c696a, value2, mapPosChanged2);
				}
				while (mapPosChanged != mapPosChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onMapPosChanged(CoreInternal.MapPosChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00125614 File Offset: 0x00123814
		private void c3bdb7a5fb6c61281c59a549b881cd162(double num, double num2, double num3)
		{
			try
			{
				if (this.ce3879c9b14b51ca0c13609aa713c696a != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c3bdb7a5fb6c61281c59a549b881cd162(double, double, double)).MethodHandle;
					}
					cb203d37d0ccd27086eabd6eea714c3b1.c30767ddca1f9c207888833aea5b5fc61(this.ce3879c9b14b51ca0c13609aa713c696a, num, num2, num3);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06001BE4 RID: 7140 RVA: 0x00125660 File Offset: 0x00123860
		// (remove) Token: 0x06001BE5 RID: 7141 RVA: 0x001256AC File Offset: 0x001238AC
		public event CoreInternal.WidgetFilterStatusChanged onWidgetFilterStatusChanged
		{
			add
			{
				CoreInternal.WidgetFilterStatusChanged widgetFilterStatusChanged = this.c11be0376fcdf893640c7a6c2d4a167df;
				CoreInternal.WidgetFilterStatusChanged widgetFilterStatusChanged2;
				do
				{
					widgetFilterStatusChanged2 = widgetFilterStatusChanged;
					CoreInternal.WidgetFilterStatusChanged value2 = (CoreInternal.WidgetFilterStatusChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(widgetFilterStatusChanged2, value);
					widgetFilterStatusChanged = Interlocked.CompareExchange<CoreInternal.WidgetFilterStatusChanged>(ref this.c11be0376fcdf893640c7a6c2d4a167df, value2, widgetFilterStatusChanged2);
				}
				while (widgetFilterStatusChanged != widgetFilterStatusChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onWidgetFilterStatusChanged(CoreInternal.WidgetFilterStatusChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.WidgetFilterStatusChanged widgetFilterStatusChanged = this.c11be0376fcdf893640c7a6c2d4a167df;
				CoreInternal.WidgetFilterStatusChanged widgetFilterStatusChanged2;
				do
				{
					widgetFilterStatusChanged2 = widgetFilterStatusChanged;
					CoreInternal.WidgetFilterStatusChanged value2 = (CoreInternal.WidgetFilterStatusChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(widgetFilterStatusChanged2, value);
					widgetFilterStatusChanged = Interlocked.CompareExchange<CoreInternal.WidgetFilterStatusChanged>(ref this.c11be0376fcdf893640c7a6c2d4a167df, value2, widgetFilterStatusChanged2);
				}
				while (widgetFilterStatusChanged != widgetFilterStatusChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onWidgetFilterStatusChanged(CoreInternal.WidgetFilterStatusChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x001256F8 File Offset: 0x001238F8
		private void cfef9e613bd8a03a35edff93ed64a657e(string text, bool flag)
		{
			try
			{
				if (this.c11be0376fcdf893640c7a6c2d4a167df != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cfef9e613bd8a03a35edff93ed64a657e(string, bool)).MethodHandle;
					}
					c1359e77fe4fbb82d6456b6f29afc68e9.c30767ddca1f9c207888833aea5b5fc61(this.c11be0376fcdf893640c7a6c2d4a167df, text, flag);
				}
			}
			catch
			{
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06001BE7 RID: 7143 RVA: 0x00125744 File Offset: 0x00123944
		// (remove) Token: 0x06001BE8 RID: 7144 RVA: 0x00125790 File Offset: 0x00123990
		public event CoreInternal.WidgetGroupStatusChanged onWidgetGroupStatusChanged
		{
			add
			{
				CoreInternal.WidgetGroupStatusChanged widgetGroupStatusChanged = this.c7c616f9bd2a3566d496167f9987929f9;
				CoreInternal.WidgetGroupStatusChanged widgetGroupStatusChanged2;
				do
				{
					widgetGroupStatusChanged2 = widgetGroupStatusChanged;
					CoreInternal.WidgetGroupStatusChanged value2 = (CoreInternal.WidgetGroupStatusChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(widgetGroupStatusChanged2, value);
					widgetGroupStatusChanged = Interlocked.CompareExchange<CoreInternal.WidgetGroupStatusChanged>(ref this.c7c616f9bd2a3566d496167f9987929f9, value2, widgetGroupStatusChanged2);
				}
				while (widgetGroupStatusChanged != widgetGroupStatusChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onWidgetGroupStatusChanged(CoreInternal.WidgetGroupStatusChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.WidgetGroupStatusChanged widgetGroupStatusChanged = this.c7c616f9bd2a3566d496167f9987929f9;
				CoreInternal.WidgetGroupStatusChanged widgetGroupStatusChanged2;
				do
				{
					widgetGroupStatusChanged2 = widgetGroupStatusChanged;
					CoreInternal.WidgetGroupStatusChanged value2 = (CoreInternal.WidgetGroupStatusChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(widgetGroupStatusChanged2, value);
					widgetGroupStatusChanged = Interlocked.CompareExchange<CoreInternal.WidgetGroupStatusChanged>(ref this.c7c616f9bd2a3566d496167f9987929f9, value2, widgetGroupStatusChanged2);
				}
				while (widgetGroupStatusChanged != widgetGroupStatusChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onWidgetGroupStatusChanged(CoreInternal.WidgetGroupStatusChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x001257DC File Offset: 0x001239DC
		private void cc0da629a81c51c27524372ecb3e76a36(string text, bool flag)
		{
			try
			{
				if (this.c7c616f9bd2a3566d496167f9987929f9 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.cc0da629a81c51c27524372ecb3e76a36(string, bool)).MethodHandle;
					}
					cd668a2c0e163e3317183116c1703f24e.c30767ddca1f9c207888833aea5b5fc61(this.c7c616f9bd2a3566d496167f9987929f9, text, flag);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06001BEA RID: 7146 RVA: 0x00125828 File Offset: 0x00123A28
		// (remove) Token: 0x06001BEB RID: 7147 RVA: 0x00125874 File Offset: 0x00123A74
		public event CoreInternal.ExpChanged onExpChanged
		{
			add
			{
				CoreInternal.ExpChanged expChanged = this.c4d45cbba6e28ff9b4f6369d9ab655c98;
				CoreInternal.ExpChanged expChanged2;
				do
				{
					expChanged2 = expChanged;
					CoreInternal.ExpChanged value2 = (CoreInternal.ExpChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expChanged2, value);
					expChanged = Interlocked.CompareExchange<CoreInternal.ExpChanged>(ref this.c4d45cbba6e28ff9b4f6369d9ab655c98, value2, expChanged2);
				}
				while (expChanged != expChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onExpChanged(CoreInternal.ExpChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.ExpChanged expChanged = this.c4d45cbba6e28ff9b4f6369d9ab655c98;
				CoreInternal.ExpChanged expChanged2;
				do
				{
					expChanged2 = expChanged;
					CoreInternal.ExpChanged value2 = (CoreInternal.ExpChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expChanged2, value);
					expChanged = Interlocked.CompareExchange<CoreInternal.ExpChanged>(ref this.c4d45cbba6e28ff9b4f6369d9ab655c98, value2, expChanged2);
				}
				while (expChanged != expChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onExpChanged(CoreInternal.ExpChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x001258C0 File Offset: 0x00123AC0
		private void ce0d4082218b573086224f07446a22461(Creature creature, int num)
		{
			try
			{
				if (this.c4d45cbba6e28ff9b4f6369d9ab655c98 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.ce0d4082218b573086224f07446a22461(Creature, int)).MethodHandle;
					}
					c4405d3cab24f9542b25ea8b7c36fa882.c30767ddca1f9c207888833aea5b5fc61(this.c4d45cbba6e28ff9b4f6369d9ab655c98, creature, num);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06001BED RID: 7149 RVA: 0x0012590C File Offset: 0x00123B0C
		// (remove) Token: 0x06001BEE RID: 7150 RVA: 0x00125958 File Offset: 0x00123B58
		public event CoreInternal.AbilityExpChanged onAbilityExpChanged
		{
			add
			{
				CoreInternal.AbilityExpChanged abilityExpChanged = this.cff347b49df0bab4adba4d31c0f8e5f38;
				CoreInternal.AbilityExpChanged abilityExpChanged2;
				do
				{
					abilityExpChanged2 = abilityExpChanged;
					CoreInternal.AbilityExpChanged value2 = (CoreInternal.AbilityExpChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(abilityExpChanged2, value);
					abilityExpChanged = Interlocked.CompareExchange<CoreInternal.AbilityExpChanged>(ref this.cff347b49df0bab4adba4d31c0f8e5f38, value2, abilityExpChanged2);
				}
				while (abilityExpChanged != abilityExpChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onAbilityExpChanged(CoreInternal.AbilityExpChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.AbilityExpChanged abilityExpChanged = this.cff347b49df0bab4adba4d31c0f8e5f38;
				CoreInternal.AbilityExpChanged abilityExpChanged2;
				do
				{
					abilityExpChanged2 = abilityExpChanged;
					CoreInternal.AbilityExpChanged value2 = (CoreInternal.AbilityExpChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(abilityExpChanged2, value);
					abilityExpChanged = Interlocked.CompareExchange<CoreInternal.AbilityExpChanged>(ref this.cff347b49df0bab4adba4d31c0f8e5f38, value2, abilityExpChanged2);
				}
				while (abilityExpChanged != abilityExpChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onAbilityExpChanged(CoreInternal.AbilityExpChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x001259A4 File Offset: 0x00123BA4
		private void c8880d257d90b721aee714687dec3c02c(Creature creature, Ability ability, int num)
		{
			try
			{
				if (this.cff347b49df0bab4adba4d31c0f8e5f38 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c8880d257d90b721aee714687dec3c02c(Creature, Ability, int)).MethodHandle;
					}
					cfa86f24e19f57b994440b20868315bd7.c30767ddca1f9c207888833aea5b5fc61(this.cff347b49df0bab4adba4d31c0f8e5f38, creature, ability, num);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06001BF0 RID: 7152 RVA: 0x001259F0 File Offset: 0x00123BF0
		// (remove) Token: 0x06001BF1 RID: 7153 RVA: 0x00125A3C File Offset: 0x00123C3C
		public event CoreInternal.LaborAmountChanged onLaborAmountChanged
		{
			add
			{
				CoreInternal.LaborAmountChanged laborAmountChanged = this.cfd0c67e4ffb2110df41fe429d4e19cf7;
				CoreInternal.LaborAmountChanged laborAmountChanged2;
				do
				{
					laborAmountChanged2 = laborAmountChanged;
					CoreInternal.LaborAmountChanged value2 = (CoreInternal.LaborAmountChanged)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(laborAmountChanged2, value);
					laborAmountChanged = Interlocked.CompareExchange<CoreInternal.LaborAmountChanged>(ref this.cfd0c67e4ffb2110df41fe429d4e19cf7, value2, laborAmountChanged2);
				}
				while (laborAmountChanged != laborAmountChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onLaborAmountChanged(CoreInternal.LaborAmountChanged)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.LaborAmountChanged laborAmountChanged = this.cfd0c67e4ffb2110df41fe429d4e19cf7;
				CoreInternal.LaborAmountChanged laborAmountChanged2;
				do
				{
					laborAmountChanged2 = laborAmountChanged;
					CoreInternal.LaborAmountChanged value2 = (CoreInternal.LaborAmountChanged)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(laborAmountChanged2, value);
					laborAmountChanged = Interlocked.CompareExchange<CoreInternal.LaborAmountChanged>(ref this.cfd0c67e4ffb2110df41fe429d4e19cf7, value2, laborAmountChanged2);
				}
				while (laborAmountChanged != laborAmountChanged2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onLaborAmountChanged(CoreInternal.LaborAmountChanged)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00125A88 File Offset: 0x00123C88
		private void c40047bdb0acc3302c40d4a99cbcf975c(int num)
		{
			try
			{
				if (this.cfd0c67e4ffb2110df41fe429d4e19cf7 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c40047bdb0acc3302c40d4a99cbcf975c(int)).MethodHandle;
					}
					c77d0b130fa500c05d21cef36e4da7259.c30767ddca1f9c207888833aea5b5fc61(this.cfd0c67e4ffb2110df41fe429d4e19cf7, num);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06001BF3 RID: 7155 RVA: 0x00125AD4 File Offset: 0x00123CD4
		// (remove) Token: 0x06001BF4 RID: 7156 RVA: 0x00125B20 File Offset: 0x00123D20
		public event CoreInternal.CofferOpened onCofferOpened
		{
			add
			{
				CoreInternal.CofferOpened cofferOpened = this.c57f245808a27d8bafbbadf9452bdafd2;
				CoreInternal.CofferOpened cofferOpened2;
				do
				{
					cofferOpened2 = cofferOpened;
					CoreInternal.CofferOpened value2 = (CoreInternal.CofferOpened)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cofferOpened2, value);
					cofferOpened = Interlocked.CompareExchange<CoreInternal.CofferOpened>(ref this.c57f245808a27d8bafbbadf9452bdafd2, value2, cofferOpened2);
				}
				while (cofferOpened != cofferOpened2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onCofferOpened(CoreInternal.CofferOpened)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.CofferOpened cofferOpened = this.c57f245808a27d8bafbbadf9452bdafd2;
				CoreInternal.CofferOpened cofferOpened2;
				do
				{
					cofferOpened2 = cofferOpened;
					CoreInternal.CofferOpened value2 = (CoreInternal.CofferOpened)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cofferOpened2, value);
					cofferOpened = Interlocked.CompareExchange<CoreInternal.CofferOpened>(ref this.c57f245808a27d8bafbbadf9452bdafd2, value2, cofferOpened2);
				}
				while (cofferOpened != cofferOpened2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onCofferOpened(CoreInternal.CofferOpened)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00125B6C File Offset: 0x00123D6C
		private void c729020093588b551877aa9b4d0d9b609(DoodadObject doodadObject)
		{
			try
			{
				if (this.c57f245808a27d8bafbbadf9452bdafd2 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c729020093588b551877aa9b4d0d9b609(DoodadObject)).MethodHandle;
					}
					c422c96fcb3e9f291089419b54b0cf9f5.c30767ddca1f9c207888833aea5b5fc61(this.c57f245808a27d8bafbbadf9452bdafd2, doodadObject);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06001BF6 RID: 7158 RVA: 0x00125BB8 File Offset: 0x00123DB8
		// (remove) Token: 0x06001BF7 RID: 7159 RVA: 0x00125C04 File Offset: 0x00123E04
		public event CoreInternal.NewSkillLearned onNewSkillLearned
		{
			add
			{
				CoreInternal.NewSkillLearned newSkillLearned = this.ce712abb859034bed3f6709b20aea66e7;
				CoreInternal.NewSkillLearned newSkillLearned2;
				do
				{
					newSkillLearned2 = newSkillLearned;
					CoreInternal.NewSkillLearned value2 = (CoreInternal.NewSkillLearned)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newSkillLearned2, value);
					newSkillLearned = Interlocked.CompareExchange<CoreInternal.NewSkillLearned>(ref this.ce712abb859034bed3f6709b20aea66e7, value2, newSkillLearned2);
				}
				while (newSkillLearned != newSkillLearned2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onNewSkillLearned(CoreInternal.NewSkillLearned)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.NewSkillLearned newSkillLearned = this.ce712abb859034bed3f6709b20aea66e7;
				CoreInternal.NewSkillLearned newSkillLearned2;
				do
				{
					newSkillLearned2 = newSkillLearned;
					CoreInternal.NewSkillLearned value2 = (CoreInternal.NewSkillLearned)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newSkillLearned2, value);
					newSkillLearned = Interlocked.CompareExchange<CoreInternal.NewSkillLearned>(ref this.ce712abb859034bed3f6709b20aea66e7, value2, newSkillLearned2);
				}
				while (newSkillLearned != newSkillLearned2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onNewSkillLearned(CoreInternal.NewSkillLearned)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00125C50 File Offset: 0x00123E50
		private void c4a024a6088d649ecd7e168a14aebcc0b(Creature creature, Effect effect)
		{
			try
			{
				if (this.ce712abb859034bed3f6709b20aea66e7 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c4a024a6088d649ecd7e168a14aebcc0b(Creature, Effect)).MethodHandle;
					}
					cbf2b6521753cfd62d03f236371db5fe1.c30767ddca1f9c207888833aea5b5fc61(this.ce712abb859034bed3f6709b20aea66e7, creature, effect);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06001BF9 RID: 7161 RVA: 0x00125C9C File Offset: 0x00123E9C
		// (remove) Token: 0x06001BFA RID: 7162 RVA: 0x00125CE8 File Offset: 0x00123EE8
		public event CoreInternal.NewPartyMember onNewPartyMember
		{
			add
			{
				CoreInternal.NewPartyMember newPartyMember = this.c57433036557b00ee5b9d74e1bed86f87;
				CoreInternal.NewPartyMember newPartyMember2;
				do
				{
					newPartyMember2 = newPartyMember;
					CoreInternal.NewPartyMember value2 = (CoreInternal.NewPartyMember)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newPartyMember2, value);
					newPartyMember = Interlocked.CompareExchange<CoreInternal.NewPartyMember>(ref this.c57433036557b00ee5b9d74e1bed86f87, value2, newPartyMember2);
				}
				while (newPartyMember != newPartyMember2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onNewPartyMember(CoreInternal.NewPartyMember)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.NewPartyMember newPartyMember = this.c57433036557b00ee5b9d74e1bed86f87;
				CoreInternal.NewPartyMember newPartyMember2;
				do
				{
					newPartyMember2 = newPartyMember;
					CoreInternal.NewPartyMember value2 = (CoreInternal.NewPartyMember)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(newPartyMember2, value);
					newPartyMember = Interlocked.CompareExchange<CoreInternal.NewPartyMember>(ref this.c57433036557b00ee5b9d74e1bed86f87, value2, newPartyMember2);
				}
				while (newPartyMember != newPartyMember2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onNewPartyMember(CoreInternal.NewPartyMember)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00125D34 File Offset: 0x00123F34
		private void c47b79a436e2ffc556076c32a0a01c74d(PartyMember partyMember)
		{
			try
			{
				if (this.c57433036557b00ee5b9d74e1bed86f87 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c47b79a436e2ffc556076c32a0a01c74d(PartyMember)).MethodHandle;
					}
					c8ec56c61ab9eab8b4eecd1b0f4adf08d.c30767ddca1f9c207888833aea5b5fc61(this.c57433036557b00ee5b9d74e1bed86f87, partyMember);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06001BFC RID: 7164 RVA: 0x00125D80 File Offset: 0x00123F80
		// (remove) Token: 0x06001BFD RID: 7165 RVA: 0x00125DCC File Offset: 0x00123FCC
		public event CoreInternal.PartyMemberLeaves onPartyMemberLeaves
		{
			add
			{
				CoreInternal.PartyMemberLeaves partyMemberLeaves = this.cd638bddd90add5ada0ff3df9c490735b;
				CoreInternal.PartyMemberLeaves partyMemberLeaves2;
				do
				{
					partyMemberLeaves2 = partyMemberLeaves;
					CoreInternal.PartyMemberLeaves value2 = (CoreInternal.PartyMemberLeaves)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(partyMemberLeaves2, value);
					partyMemberLeaves = Interlocked.CompareExchange<CoreInternal.PartyMemberLeaves>(ref this.cd638bddd90add5ada0ff3df9c490735b, value2, partyMemberLeaves2);
				}
				while (partyMemberLeaves != partyMemberLeaves2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onPartyMemberLeaves(CoreInternal.PartyMemberLeaves)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.PartyMemberLeaves partyMemberLeaves = this.cd638bddd90add5ada0ff3df9c490735b;
				CoreInternal.PartyMemberLeaves partyMemberLeaves2;
				do
				{
					partyMemberLeaves2 = partyMemberLeaves;
					CoreInternal.PartyMemberLeaves value2 = (CoreInternal.PartyMemberLeaves)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(partyMemberLeaves2, value);
					partyMemberLeaves = Interlocked.CompareExchange<CoreInternal.PartyMemberLeaves>(ref this.cd638bddd90add5ada0ff3df9c490735b, value2, partyMemberLeaves2);
				}
				while (partyMemberLeaves != partyMemberLeaves2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onPartyMemberLeaves(CoreInternal.PartyMemberLeaves)).MethodHandle;
				}
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00125E18 File Offset: 0x00124018
		private void c34a91ffa6517d08df59c566a5baca143(PartyMember partyMember)
		{
			try
			{
				if (this.cd638bddd90add5ada0ff3df9c490735b != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c34a91ffa6517d08df59c566a5baca143(PartyMember)).MethodHandle;
					}
					c207ec1f04a0ea9b555bfb4bbd43fcb0f.c30767ddca1f9c207888833aea5b5fc61(this.cd638bddd90add5ada0ff3df9c490735b, partyMember);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06001BFF RID: 7167 RVA: 0x00125E64 File Offset: 0x00124064
		// (remove) Token: 0x06001C00 RID: 7168 RVA: 0x00125EB0 File Offset: 0x001240B0
		public event CoreInternal.BattleFieldInvite onBattleFieldInvite
		{
			add
			{
				CoreInternal.BattleFieldInvite battleFieldInvite = this.cd5494782bb11fc2bc17088c802ac59d1;
				CoreInternal.BattleFieldInvite battleFieldInvite2;
				do
				{
					battleFieldInvite2 = battleFieldInvite;
					CoreInternal.BattleFieldInvite value2 = (CoreInternal.BattleFieldInvite)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(battleFieldInvite2, value);
					battleFieldInvite = Interlocked.CompareExchange<CoreInternal.BattleFieldInvite>(ref this.cd5494782bb11fc2bc17088c802ac59d1, value2, battleFieldInvite2);
				}
				while (battleFieldInvite != battleFieldInvite2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onBattleFieldInvite(CoreInternal.BattleFieldInvite)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.BattleFieldInvite battleFieldInvite = this.cd5494782bb11fc2bc17088c802ac59d1;
				CoreInternal.BattleFieldInvite battleFieldInvite2;
				do
				{
					battleFieldInvite2 = battleFieldInvite;
					CoreInternal.BattleFieldInvite value2 = (CoreInternal.BattleFieldInvite)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(battleFieldInvite2, value);
					battleFieldInvite = Interlocked.CompareExchange<CoreInternal.BattleFieldInvite>(ref this.cd5494782bb11fc2bc17088c802ac59d1, value2, battleFieldInvite2);
				}
				while (battleFieldInvite != battleFieldInvite2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onBattleFieldInvite(CoreInternal.BattleFieldInvite)).MethodHandle;
				}
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00125EFC File Offset: 0x001240FC
		private void c5d547a480249d92a6f1b3aa9e6a743c1()
		{
			try
			{
				if (this.cd5494782bb11fc2bc17088c802ac59d1 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c5d547a480249d92a6f1b3aa9e6a743c1()).MethodHandle;
					}
					c63dd1e6ecbd4ed3a1fc22dbff8bded83.c30767ddca1f9c207888833aea5b5fc61(this.cd5494782bb11fc2bc17088c802ac59d1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06001C02 RID: 7170 RVA: 0x00125F44 File Offset: 0x00124144
		// (remove) Token: 0x06001C03 RID: 7171 RVA: 0x00125F90 File Offset: 0x00124190
		public event CoreInternal.UserNavMeshPreMoveFull onUserNavMeshPreMoveFull
		{
			add
			{
				CoreInternal.UserNavMeshPreMoveFull userNavMeshPreMoveFull = this.c1927ca84451be252f40fb28231df0bda;
				CoreInternal.UserNavMeshPreMoveFull userNavMeshPreMoveFull2;
				do
				{
					userNavMeshPreMoveFull2 = userNavMeshPreMoveFull;
					CoreInternal.UserNavMeshPreMoveFull value2 = (CoreInternal.UserNavMeshPreMoveFull)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(userNavMeshPreMoveFull2, value);
					userNavMeshPreMoveFull = Interlocked.CompareExchange<CoreInternal.UserNavMeshPreMoveFull>(ref this.c1927ca84451be252f40fb28231df0bda, value2, userNavMeshPreMoveFull2);
				}
				while (userNavMeshPreMoveFull != userNavMeshPreMoveFull2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onUserNavMeshPreMoveFull(CoreInternal.UserNavMeshPreMoveFull)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.UserNavMeshPreMoveFull userNavMeshPreMoveFull = this.c1927ca84451be252f40fb28231df0bda;
				CoreInternal.UserNavMeshPreMoveFull userNavMeshPreMoveFull2;
				do
				{
					userNavMeshPreMoveFull2 = userNavMeshPreMoveFull;
					CoreInternal.UserNavMeshPreMoveFull value2 = (CoreInternal.UserNavMeshPreMoveFull)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(userNavMeshPreMoveFull2, value);
					userNavMeshPreMoveFull = Interlocked.CompareExchange<CoreInternal.UserNavMeshPreMoveFull>(ref this.c1927ca84451be252f40fb28231df0bda, value2, userNavMeshPreMoveFull2);
				}
				while (userNavMeshPreMoveFull != userNavMeshPreMoveFull2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onUserNavMeshPreMoveFull(CoreInternal.UserNavMeshPreMoveFull)).MethodHandle;
				}
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00125FDC File Offset: 0x001241DC
		private bool c467d6edbe9fc545738a3d4313578be08(float[] array)
		{
			if (this.c1927ca84451be252f40fb28231df0bda != null)
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
					RuntimeMethodHandle arg_1A_0 = methodof(Core.c467d6edbe9fc545738a3d4313578be08(float[])).MethodHandle;
				}
				return c7e6f746c08a1573b19e24c40a3859fe8.c30767ddca1f9c207888833aea5b5fc61(this.c1927ca84451be252f40fb28231df0bda, array);
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89716) != 0;
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06001C05 RID: 7173 RVA: 0x00126020 File Offset: 0x00124220
		// (remove) Token: 0x06001C06 RID: 7174 RVA: 0x0012606C File Offset: 0x0012426C
		public event CoreInternal.UserNavMeshPreMove onUserNavMeshPreMove
		{
			add
			{
				CoreInternal.UserNavMeshPreMove userNavMeshPreMove = this.c56456b6f25545e940466e8cfa40b31e9;
				CoreInternal.UserNavMeshPreMove userNavMeshPreMove2;
				do
				{
					userNavMeshPreMove2 = userNavMeshPreMove;
					CoreInternal.UserNavMeshPreMove value2 = (CoreInternal.UserNavMeshPreMove)c83da8b0488317cf92addd6daf821ee07.c0cf59c3e67a46fd4edb3040c5ab0bbfb(userNavMeshPreMove2, value);
					userNavMeshPreMove = Interlocked.CompareExchange<CoreInternal.UserNavMeshPreMove>(ref this.c56456b6f25545e940466e8cfa40b31e9, value2, userNavMeshPreMove2);
				}
				while (userNavMeshPreMove != userNavMeshPreMove2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.add_onUserNavMeshPreMove(CoreInternal.UserNavMeshPreMove)).MethodHandle;
				}
			}
			remove
			{
				CoreInternal.UserNavMeshPreMove userNavMeshPreMove = this.c56456b6f25545e940466e8cfa40b31e9;
				CoreInternal.UserNavMeshPreMove userNavMeshPreMove2;
				do
				{
					userNavMeshPreMove2 = userNavMeshPreMove;
					CoreInternal.UserNavMeshPreMove value2 = (CoreInternal.UserNavMeshPreMove)cb5c4daa9c59950e500ae9994c68b10b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(userNavMeshPreMove2, value);
					userNavMeshPreMove = Interlocked.CompareExchange<CoreInternal.UserNavMeshPreMove>(ref this.c56456b6f25545e940466e8cfa40b31e9, value2, userNavMeshPreMove2);
				}
				while (userNavMeshPreMove != userNavMeshPreMove2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(Core.remove_onUserNavMeshPreMove(CoreInternal.UserNavMeshPreMove)).MethodHandle;
				}
			}
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x001260B8 File Offset: 0x001242B8
		private bool c3a8f5e5aa3b96fdd1f696174a3d1982f(float num, float num2, float num3)
		{
			try
			{
				if (this.c56456b6f25545e940466e8cfa40b31e9 != null)
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
						RuntimeMethodHandle arg_1A_0 = methodof(Core.c3a8f5e5aa3b96fdd1f696174a3d1982f(float, float, float)).MethodHandle;
					}
					return ca9f50451cf55d392dab6ca533c2a1699.c30767ddca1f9c207888833aea5b5fc61(this.c56456b6f25545e940466e8cfa40b31e9, num, num2, num3);
				}
			}
			catch
			{
			}
			return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89720) != 0;
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00126114 File Offset: 0x00124314
		public SqlCore sqlCore
		{
			get
			{
				try
				{
					if (c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.core) != null)
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
							RuntimeMethodHandle arg_21_0 = methodof(Core.get_sqlCore()).MethodHandle;
						}
						return c39c2cc425a3d639383abd98d1c263a8a.c30767ddca1f9c207888833aea5b5fc61(this.core);
					}
				}
				catch
				{
				}
				return null;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0012616C File Offset: 0x0012436C
		public MateState mateState
		{
			get
			{
				MateState result;
				try
				{
					result = cf35e822a74302069af93ed891c008fc8.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (MateState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89724);
				}
				return result;
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x001261A8 File Offset: 0x001243A8
		public void FlashGameClient()
		{
			try
			{
				this.core.c80a4df5525af6352c7b5ae7200b256dc();
			}
			catch
			{
			}
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x001261D8 File Offset: 0x001243D8
		public List<Creature> getAggroMobs()
		{
			List<Creature> result;
			try
			{
				result = this.core.c1290c7edcae18cf3364423e6394251a6();
			}
			catch
			{
				result = ce8d826fa3f910602bcf4cc0ab204e4bd.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00126214 File Offset: 0x00124414
		public List<Creature> getAggroMobs(string name)
		{
			List<Creature> result;
			try
			{
				result = this.core.c1290c7edcae18cf3364423e6394251a6(name);
			}
			catch
			{
				result = ce8d826fa3f910602bcf4cc0ab204e4bd.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00126250 File Offset: 0x00124450
		public List<Creature> getAggroMobs(Creature obj)
		{
			List<Creature> result;
			try
			{
				result = this.core.c1290c7edcae18cf3364423e6394251a6(obj);
			}
			catch
			{
				result = ce8d826fa3f910602bcf4cc0ab204e4bd.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0012628C File Offset: 0x0012448C
		public uint getAggroMobsCount()
		{
			uint result;
			try
			{
				result = this.core.cbf4f0dd33e74ba0f4e7f31f9bf0f2c6c();
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89728);
			}
			return result;
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x001262C8 File Offset: 0x001244C8
		public uint getAggroMobsCount(string name)
		{
			uint result;
			try
			{
				result = this.core.cbf4f0dd33e74ba0f4e7f31f9bf0f2c6c(name);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89732);
			}
			return result;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00126308 File Offset: 0x00124508
		public uint getAggroMobsCount(Creature obj)
		{
			uint result;
			try
			{
				result = this.core.cbf4f0dd33e74ba0f4e7f31f9bf0f2c6c(obj);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89736);
			}
			return result;
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00126348 File Offset: 0x00124548
		public int backpackPercentPrice()
		{
			int result;
			try
			{
				result = this.core.c163bd7b4aa254b972221e90dc95a7a08();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89740);
			}
			return result;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00126384 File Offset: 0x00124584
		public List<BackpackInfo> backpacksPercentPrice(ushort zoneIdFrom, ushort zoneIdTo)
		{
			List<BackpackInfo> result;
			try
			{
				result = this.core.ca5599d4ae1eccbce02d1fc8013e77cce(zoneIdFrom, zoneIdTo);
			}
			catch
			{
				result = c6f32a769313463be26b45da7fda516c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x001263C0 File Offset: 0x001245C0
		public List<BackpackInfo> backpacksPercentPrice(string zoneNameFrom, string zoneNameTo)
		{
			List<BackpackInfo> result;
			try
			{
				result = this.core.ca5599d4ae1eccbce02d1fc8013e77cce(zoneNameFrom, zoneNameTo);
			}
			catch
			{
				result = c6f32a769313463be26b45da7fda516c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x001263FC File Offset: 0x001245FC
		public int backpackPrice()
		{
			int result;
			try
			{
				result = this.core.c9320c95b9f357f5c2575b1b0a17a8631();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89744);
			}
			return result;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00126438 File Offset: 0x00124638
		public string serverName()
		{
			string result;
			try
			{
				result = this.core.cfa90a3bdf33f49645acdaf139e821d39();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00126470 File Offset: 0x00124670
		public void SetPlantAlgoritm(PlantAlgoritm newAlgoritm)
		{
			try
			{
				this.core.c870a03d9ff7ac0ee19e596f1e13ba592(newAlgoritm);
			}
			catch
			{
			}
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x001264A0 File Offset: 0x001246A0
		public void SetPlantMotionType(PlantMotionType newMotionType)
		{
			try
			{
				this.core.c6eb914099cbd6a415114b80fc369c508(newMotionType);
			}
			catch
			{
			}
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x001264D0 File Offset: 0x001246D0
		public void UpdateNoAfkState()
		{
			try
			{
				this.core.c19b85a253c6bdb98e954c32449cb88e9();
			}
			catch
			{
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00126500 File Offset: 0x00124700
		public Quest getQuest(uint questId)
		{
			Quest result;
			try
			{
				result = this.core.c73f33a7c79c16d06c94d42764e85e92d(questId);
			}
			catch
			{
				result = c89568a03e74369ae8a50f4be7751a6fe.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00126538 File Offset: 0x00124738
		public Quest getCompletedQuest(uint questId)
		{
			Quest result;
			try
			{
				result = this.core.c9bfb5d146e6fb334f8cf71dd99f62f4a(questId);
			}
			catch
			{
				result = c89568a03e74369ae8a50f4be7751a6fe.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00126570 File Offset: 0x00124770
		public int gameTime()
		{
			int result;
			try
			{
				result = this.core.c3f7d324039f584e162d80c752b5e4b33();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89748);
			}
			return result;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x001265AC File Offset: 0x001247AC
		public long itemCount(uint itemId)
		{
			long result;
			try
			{
				result = this.core.c1ff4c8b6c8a38d14ad7d822488ae2822(itemId);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89752);
			}
			return result;
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x001265EC File Offset: 0x001247EC
		public long itemCount(string name)
		{
			long result;
			try
			{
				result = this.core.c1ff4c8b6c8a38d14ad7d822488ae2822(name);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89756);
			}
			return result;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0012662C File Offset: 0x0012482C
		public long skillCooldown(string name)
		{
			long result;
			try
			{
				result = this.core.cb24c3e88eb86116dcc10b86788acb22d(name);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89760);
			}
			return result;
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0012666C File Offset: 0x0012486C
		public long skillCooldown(uint skillId)
		{
			long result;
			try
			{
				result = this.core.cb24c3e88eb86116dcc10b86788acb22d(skillId);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89764);
			}
			return result;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x001266AC File Offset: 0x001248AC
		public long skillCooldown(Skill skill)
		{
			long result;
			try
			{
				result = this.core.cb24c3e88eb86116dcc10b86788acb22d(skill);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89768);
			}
			return result;
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x001266EC File Offset: 0x001248EC
		public long itemCooldown(string name)
		{
			long result;
			try
			{
				result = this.core.cb2c9446fe677549b092c7e11912b542c(name);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89772);
			}
			return result;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0012672C File Offset: 0x0012492C
		public long itemCooldown(uint itemId)
		{
			long result;
			try
			{
				result = this.core.cb2c9446fe677549b092c7e11912b542c(itemId);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89776);
			}
			return result;
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0012676C File Offset: 0x0012496C
		public long itemCooldown(Item item)
		{
			long result;
			try
			{
				result = this.core.cb2c9446fe677549b092c7e11912b542c(item);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89780);
			}
			return result;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x001267AC File Offset: 0x001249AC
		public bool isAlive()
		{
			bool result;
			try
			{
				result = this.core.ce33364a8a1a051ed436217ae91e90305();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89784) != 0);
			}
			return result;
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x001267E8 File Offset: 0x001249E8
		public bool isAlive(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.ce33364a8a1a051ed436217ae91e90305(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89788) != 0);
			}
			return result;
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x00126828 File Offset: 0x00124A28
		public bool isExists(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c343d00d0e3fb7fbd3da3aaa914d93ca8(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89792) != 0);
			}
			return result;
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x00126868 File Offset: 0x00124A68
		public bool isExists(DoodadObject obj)
		{
			bool result;
			try
			{
				result = this.core.c343d00d0e3fb7fbd3da3aaa914d93ca8(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89796) != 0);
			}
			return result;
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x001268A8 File Offset: 0x00124AA8
		public int angle(Creature obj)
		{
			int result;
			try
			{
				result = this.core.c9ca3495519b1622579fa1af94c836cb6(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89800);
			}
			return result;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x001268E8 File Offset: 0x00124AE8
		public int angle(Creature obj1, Creature obj2)
		{
			int result;
			try
			{
				result = this.core.c9ca3495519b1622579fa1af94c836cb6(obj1, obj2);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89804);
			}
			return result;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x00126928 File Offset: 0x00124B28
		public int angle(Creature obj, double x, double y)
		{
			int result;
			try
			{
				result = this.core.c9ca3495519b1622579fa1af94c836cb6(obj, x, y);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89808);
			}
			return result;
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00126968 File Offset: 0x00124B68
		public int angle(double x, double y)
		{
			int result;
			try
			{
				result = this.core.c9ca3495519b1622579fa1af94c836cb6(x, y);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89812);
			}
			return result;
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x001269A8 File Offset: 0x00124BA8
		public bool isAttackable(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c98979dbd9cc38691e07f6a1c1ece56fb(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89816) != 0);
			}
			return result;
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x001269E8 File Offset: 0x00124BE8
		public bool isCasting()
		{
			bool result;
			try
			{
				result = this.core.c12af3546326eba5e5864b7b2d4ca9868();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89820) != 0);
			}
			return result;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00126A24 File Offset: 0x00124C24
		public bool isCasting(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c12af3546326eba5e5864b7b2d4ca9868(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89824) != 0);
			}
			return result;
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00126A64 File Offset: 0x00124C64
		public double dist(SpawnObject obj)
		{
			double result;
			try
			{
				result = this.core.c5341234400d21ddc29ef95fd7322f2e5(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(89828);
			}
			return result;
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00126AA4 File Offset: 0x00124CA4
		public double dist(SpawnObject obj1, SpawnObject obj2)
		{
			double result;
			try
			{
				result = this.core.c5341234400d21ddc29ef95fd7322f2e5(obj1, obj2);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(89836);
			}
			return result;
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00126AE4 File Offset: 0x00124CE4
		public double dist(double tX, double tY, double tZ)
		{
			double result;
			try
			{
				result = this.core.c5341234400d21ddc29ef95fd7322f2e5(tX, tY, tZ);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(89844);
			}
			return result;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00126B28 File Offset: 0x00124D28
		public int alliesInRange(double range, bool countDied)
		{
			int result;
			try
			{
				result = this.core.c8385b6c056afec7c96c4e13fc57035d1(range, countDied);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89852);
			}
			return result;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00126B68 File Offset: 0x00124D68
		public int enemysInRange(double range, bool countDied)
		{
			int result;
			try
			{
				result = this.core.c84d0341683c4297473747599b60044e6(range, countDied);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89856);
			}
			return result;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00126BA8 File Offset: 0x00124DA8
		public int mobsInRange(double range, bool countDied)
		{
			int result;
			try
			{
				result = this.core.cc377c9a653b4d0cf59d3bcfaf8097972(range, countDied);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89860);
			}
			return result;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00126BE8 File Offset: 0x00124DE8
		public int clanMembersInRange(double range, bool countDied)
		{
			int result;
			try
			{
				result = this.core.c72a383528924866032c921204683e473(range, countDied);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89864);
			}
			return result;
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00126C28 File Offset: 0x00124E28
		public int familyInRange(double range, bool countDied)
		{
			int result;
			try
			{
				result = this.core.c5e2f639db4d2f3b9b11fa0104038cbcd(range, countDied);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89868);
			}
			return result;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00126C68 File Offset: 0x00124E68
		public int partyInRange(double range, bool countDied)
		{
			int result;
			try
			{
				result = this.core.c267fcb7778f770249e6300cc89823b28(range, countDied);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89872);
			}
			return result;
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00126CA8 File Offset: 0x00124EA8
		public int hp()
		{
			int result;
			try
			{
				result = this.core.c80744c77663544fd55876f0252fb56f4();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89876);
			}
			return result;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00126CE4 File Offset: 0x00124EE4
		public int hp(Creature obj)
		{
			int result;
			try
			{
				result = this.core.c80744c77663544fd55876f0252fb56f4(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89880);
			}
			return result;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00126D24 File Offset: 0x00124F24
		public int mp()
		{
			int result;
			try
			{
				result = this.core.c84417dd1919dc452fa8610e8c0b24fd5();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89884);
			}
			return result;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00126D60 File Offset: 0x00124F60
		public int mp(Creature obj)
		{
			int result;
			try
			{
				result = this.core.c84417dd1919dc452fa8610e8c0b24fd5(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89888);
			}
			return result;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00126DA0 File Offset: 0x00124FA0
		public int hpp()
		{
			int result;
			try
			{
				result = this.core.ce490ce111a7a6834e7927a291a448bc1();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89892);
			}
			return result;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00126DDC File Offset: 0x00124FDC
		public int hpp(Creature obj)
		{
			int result;
			try
			{
				result = this.core.ce490ce111a7a6834e7927a291a448bc1(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89896);
			}
			return result;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00126E1C File Offset: 0x0012501C
		public int mpp()
		{
			int result;
			try
			{
				result = this.core.c9948a5838389099e036afdde1c5d6939();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89900);
			}
			return result;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00126E58 File Offset: 0x00125058
		public int mpp(Creature obj)
		{
			int result;
			try
			{
				result = this.core.c9948a5838389099e036afdde1c5d6939(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89904);
			}
			return result;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00126E98 File Offset: 0x00125098
		public int maxhp()
		{
			int result;
			try
			{
				result = this.core.cf264f8816b530d431c52d754b6982918();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89908);
			}
			return result;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00126ED4 File Offset: 0x001250D4
		public int maxhp(Creature obj)
		{
			int result;
			try
			{
				result = this.core.cf264f8816b530d431c52d754b6982918(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89912);
			}
			return result;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00126F14 File Offset: 0x00125114
		public int maxmp()
		{
			int result;
			try
			{
				result = this.core.cc944240aa521f910fb95459ae8203a8b();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89916);
			}
			return result;
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00126F50 File Offset: 0x00125150
		public int maxmp(Creature obj)
		{
			int result;
			try
			{
				result = this.core.cc944240aa521f910fb95459ae8203a8b(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89920);
			}
			return result;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00126F90 File Offset: 0x00125190
		public int buffsCount()
		{
			int result;
			try
			{
				result = this.core.cbc74b38c03509fcd7390ef4511a56230();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89924);
			}
			return result;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00126FCC File Offset: 0x001251CC
		public int buffsCount(string name)
		{
			int result;
			try
			{
				result = this.core.cbc74b38c03509fcd7390ef4511a56230(name);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89928);
			}
			return result;
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0012700C File Offset: 0x0012520C
		public int buffsCount(Creature obj)
		{
			int result;
			try
			{
				result = this.core.cbc74b38c03509fcd7390ef4511a56230(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89932);
			}
			return result;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0012704C File Offset: 0x0012524C
		public long buffTime(uint buffId)
		{
			long result;
			try
			{
				result = this.core.c81ecaac9376f15eaf8efa14755851363(buffId);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89936);
			}
			return result;
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0012708C File Offset: 0x0012528C
		public long buffTime(string name)
		{
			long result;
			try
			{
				result = this.core.c81ecaac9376f15eaf8efa14755851363(name);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89940);
			}
			return result;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x001270CC File Offset: 0x001252CC
		public long buffTime(Buff buff)
		{
			long result;
			try
			{
				result = this.core.c81ecaac9376f15eaf8efa14755851363(buff);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89944);
			}
			return result;
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0012710C File Offset: 0x0012530C
		public long buffTime(Creature obj, uint buffId)
		{
			long result;
			try
			{
				result = this.core.c81ecaac9376f15eaf8efa14755851363(obj, buffId);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89948);
			}
			return result;
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x0012714C File Offset: 0x0012534C
		public long buffTime(Creature obj, string buffName)
		{
			long result;
			try
			{
				result = this.core.c81ecaac9376f15eaf8efa14755851363(obj, buffName);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89952);
			}
			return result;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0012718C File Offset: 0x0012538C
		public long buffTime(string name, uint buffId)
		{
			long result;
			try
			{
				result = this.core.c81ecaac9376f15eaf8efa14755851363(name, buffId);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89956);
			}
			return result;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x001271CC File Offset: 0x001253CC
		public long buffTime(string name, string buffName)
		{
			long result;
			try
			{
				result = this.core.c81ecaac9376f15eaf8efa14755851363(name, buffName);
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89960);
			}
			return result;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0012720C File Offset: 0x0012540C
		public Buff getBuff(uint buffId)
		{
			Buff result;
			try
			{
				result = this.core.cfe362f26089f10723d5e3fc7fddb5b56(buffId);
			}
			catch
			{
				result = c6ab480d99ecdacae3cea18d3de76b06c.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00127244 File Offset: 0x00125444
		public Buff getBuff(string buffName)
		{
			Buff result;
			try
			{
				result = this.core.cfe362f26089f10723d5e3fc7fddb5b56(buffName);
			}
			catch
			{
				result = c6ab480d99ecdacae3cea18d3de76b06c.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0012727C File Offset: 0x0012547C
		public Buff getBuff(Creature obj, uint buffId)
		{
			Buff result;
			try
			{
				result = this.core.cfe362f26089f10723d5e3fc7fddb5b56(obj, buffId);
			}
			catch
			{
				result = c6ab480d99ecdacae3cea18d3de76b06c.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x001272B8 File Offset: 0x001254B8
		public Buff getBuff(Creature obj, string buffName)
		{
			Buff result;
			try
			{
				result = this.core.cfe362f26089f10723d5e3fc7fddb5b56(obj, buffName);
			}
			catch
			{
				result = c6ab480d99ecdacae3cea18d3de76b06c.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x001272F4 File Offset: 0x001254F4
		public Buff getBuff(string name, uint buffId)
		{
			Buff result;
			try
			{
				result = this.core.cfe362f26089f10723d5e3fc7fddb5b56(name, buffId);
			}
			catch
			{
				result = c6ab480d99ecdacae3cea18d3de76b06c.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00127330 File Offset: 0x00125530
		public Buff getBuff(string name, string buffName)
		{
			Buff result;
			try
			{
				result = this.core.cfe362f26089f10723d5e3fc7fddb5b56(name, buffName);
			}
			catch
			{
				result = c6ab480d99ecdacae3cea18d3de76b06c.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0012736C File Offset: 0x0012556C
		public long getUnixTime()
		{
			long result;
			try
			{
				result = this.core.c63161eeaf7d89fa146e7a0b877b8e110();
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89964);
			}
			return result;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x001273AC File Offset: 0x001255AC
		public int inventoryItemsCount()
		{
			int result;
			try
			{
				result = this.core.c3e97a1fa2d2f0ca560dc493c2e68dcf4();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89968);
			}
			return result;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x001273E8 File Offset: 0x001255E8
		public int whItemsCount()
		{
			int result;
			try
			{
				result = this.core.cf91f522132080adf84920abeb81a5c49();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89972);
			}
			return result;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00127424 File Offset: 0x00125624
		public int maxInventoryItemsCount()
		{
			int result;
			try
			{
				result = this.core.cc6d0df8f9a91150c12435e66db830627();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89976);
			}
			return result;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00127460 File Offset: 0x00125660
		public int maxWhItemsCount()
		{
			int result;
			try
			{
				result = this.core.cbd206a88f22ff12137cb56ec362791b2();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89980);
			}
			return result;
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0012749C File Offset: 0x0012569C
		public bool isInPeaceZone()
		{
			bool result;
			try
			{
				result = this.core.cc4d1e4d5f9b355330594908a3501c725();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89984) != 0);
			}
			return result;
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x001274D8 File Offset: 0x001256D8
		public bool isInPeaceZone(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cc4d1e4d5f9b355330594908a3501c725(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89988) != 0);
			}
			return result;
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x00127518 File Offset: 0x00125718
		public bool isPrisoner()
		{
			bool result;
			try
			{
				result = this.core.cb72c5b721a5b9d83e166a8fc4bdca00d();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89992) != 0);
			}
			return result;
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x00127554 File Offset: 0x00125754
		public bool isPrisoner(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cb72c5b721a5b9d83e166a8fc4bdca00d(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(89996) != 0);
			}
			return result;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x00127594 File Offset: 0x00125794
		public List<Abilities> getAbilities()
		{
			List<Abilities> result;
			try
			{
				result = this.core.c5485692b69393761dc198c8befdb84c7();
			}
			catch
			{
				result = c895d2d7a1f49d9e0fe995f2ce7b7ac72.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x001275D0 File Offset: 0x001257D0
		public List<Abilities> getAbilities(Player obj)
		{
			List<Abilities> result;
			try
			{
				result = this.core.c5485692b69393761dc198c8befdb84c7(obj);
			}
			catch
			{
				result = c895d2d7a1f49d9e0fe995f2ce7b7ac72.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0012760C File Offset: 0x0012580C
		public Abilities getAbility(Ability abilityId)
		{
			Abilities result;
			try
			{
				result = this.core.c2e0852ce5fbf0c9797d8100790157ab9(abilityId);
			}
			catch
			{
				result = c1e3d44ac1410ba5973d971539d0f10b5.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x00127644 File Offset: 0x00125844
		public Abilities getAbility(Player obj, Ability abilityId)
		{
			Abilities result;
			try
			{
				result = this.core.c2e0852ce5fbf0c9797d8100790157ab9(obj, abilityId);
			}
			catch
			{
				result = c1e3d44ac1410ba5973d971539d0f10b5.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x00127680 File Offset: 0x00125880
		public int mobsCountTargeters()
		{
			int result;
			try
			{
				result = this.core.cd34ece6b92c49897dd2fd5e1fc675265();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90000);
			}
			return result;
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x001276BC File Offset: 0x001258BC
		public int mobsCountTargeters(Creature obj)
		{
			int result;
			try
			{
				result = this.core.cd34ece6b92c49897dd2fd5e1fc675265(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90004);
			}
			return result;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x001276FC File Offset: 0x001258FC
		public int mobsCountTargeters(string name)
		{
			int result;
			try
			{
				result = this.core.cd34ece6b92c49897dd2fd5e1fc675265(name);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90008);
			}
			return result;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0012773C File Offset: 0x0012593C
		public Faction getClan()
		{
			Faction result;
			try
			{
				result = this.core.c0653da3523527de41ce14da44839c2cc();
			}
			catch
			{
				result = c5d3aa50296315fdaa8ad977e5bce0796.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00127774 File Offset: 0x00125974
		public Faction getClan(string clanName)
		{
			Faction result;
			try
			{
				result = this.core.c0653da3523527de41ce14da44839c2cc(clanName);
			}
			catch
			{
				result = c5d3aa50296315fdaa8ad977e5bce0796.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x001277AC File Offset: 0x001259AC
		public Faction getClan(Creature obj)
		{
			Faction result;
			try
			{
				result = this.core.c0653da3523527de41ce14da44839c2cc(obj);
			}
			catch
			{
				result = c5d3aa50296315fdaa8ad977e5bce0796.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x001277E4 File Offset: 0x001259E4
		public string clanName()
		{
			string result;
			try
			{
				result = this.core.c45c3ba244802332217b9a33c20965f94();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0012781C File Offset: 0x00125A1C
		public string clanName(Faction clan)
		{
			string result;
			try
			{
				result = this.core.c45c3ba244802332217b9a33c20965f94(clan);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00127854 File Offset: 0x00125A54
		public string clanName(Creature obj)
		{
			string result;
			try
			{
				result = this.core.c45c3ba244802332217b9a33c20965f94(obj);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0012788C File Offset: 0x00125A8C
		public string clanLeaderName()
		{
			string result;
			try
			{
				result = this.core.cf173e393ed0160466a7cf334c87edb30();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x001278C4 File Offset: 0x00125AC4
		public string clanLeaderName(string clanName)
		{
			string result;
			try
			{
				result = this.core.cf173e393ed0160466a7cf334c87edb30(clanName);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x001278FC File Offset: 0x00125AFC
		public string clanLeaderName(Faction clan)
		{
			string result;
			try
			{
				result = this.core.cf173e393ed0160466a7cf334c87edb30(clan);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00127934 File Offset: 0x00125B34
		public string clanLeaderName(Creature obj)
		{
			string result;
			try
			{
				result = this.core.cf173e393ed0160466a7cf334c87edb30(obj);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0012796C File Offset: 0x00125B6C
		public List<Faction> getAllClans()
		{
			List<Faction> result;
			try
			{
				result = this.core.c005f61a839e2867f390db5d6965d8b77();
			}
			catch
			{
				result = c53c3c6c18be25c89906fa30587ad82b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x001279A8 File Offset: 0x00125BA8
		public bool isEquiped(string name)
		{
			bool result;
			try
			{
				result = this.core.ce7ca92b2802bdd0fa68459a775b8a47e(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90012) != 0);
			}
			return result;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x001279E8 File Offset: 0x00125BE8
		public bool isEqiped(string name)
		{
			bool result;
			try
			{
				result = this.core.ce7ca92b2802bdd0fa68459a775b8a47e(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90016) != 0);
			}
			return result;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00127A28 File Offset: 0x00125C28
		public bool isEquiped(int itemId)
		{
			bool result;
			try
			{
				result = this.core.ce7ca92b2802bdd0fa68459a775b8a47e(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90020) != 0);
			}
			return result;
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00127A68 File Offset: 0x00125C68
		public bool isEquiped(Item item)
		{
			bool result;
			try
			{
				result = this.core.ce7ca92b2802bdd0fa68459a775b8a47e(item);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90024) != 0);
			}
			return result;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00127AA8 File Offset: 0x00125CA8
		public uint npcid(string name)
		{
			uint result;
			try
			{
				result = this.core.cbc8e72c331272f4a166e4e0fb755f133(name);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90028);
			}
			return result;
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00127AE8 File Offset: 0x00125CE8
		public uint npcid(Creature obj)
		{
			uint result;
			try
			{
				result = this.core.cbc8e72c331272f4a166e4e0fb755f133(obj);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90032);
			}
			return result;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00127B28 File Offset: 0x00125D28
		public int level()
		{
			int result;
			try
			{
				result = this.core.c4196d4f1f84ad4f2e6aec391f233acdd();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90036);
			}
			return result;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00127B64 File Offset: 0x00125D64
		public int level(Creature obj)
		{
			int result;
			try
			{
				result = this.core.c4196d4f1f84ad4f2e6aec391f233acdd(obj);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90040);
			}
			return result;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00127BA4 File Offset: 0x00125DA4
		public int level(string name)
		{
			int result;
			try
			{
				result = this.core.c4196d4f1f84ad4f2e6aec391f233acdd(name);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90044);
			}
			return result;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00127BE4 File Offset: 0x00125DE4
		public int totalExp()
		{
			int result;
			try
			{
				result = this.core.ce4563f3bae08ff3f986555ea0827092d();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90048);
			}
			return result;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00127C20 File Offset: 0x00125E20
		public int expOnLevel()
		{
			int result;
			try
			{
				result = this.core.cb0d335afe91600532ee9a9f3c4d67ad8();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90052);
			}
			return result;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00127C5C File Offset: 0x00125E5C
		public int recoverableExp()
		{
			int result;
			try
			{
				result = this.core.c88bdd993100788d0ec3cc397b4ec901d();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90056);
			}
			return result;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00127C98 File Offset: 0x00125E98
		public int abilityTotalExp(Abilities a)
		{
			int result;
			try
			{
				result = this.core.c647724250efe587579bfe97b81d5254c(a);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90060);
			}
			return result;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00127CD8 File Offset: 0x00125ED8
		public int abilityTotalExp(int abilityId)
		{
			int result;
			try
			{
				result = this.core.c647724250efe587579bfe97b81d5254c(abilityId);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90064);
			}
			return result;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00127D18 File Offset: 0x00125F18
		public int abilityTotalExp(Player obj, int abilityId)
		{
			int result;
			try
			{
				result = this.core.c647724250efe587579bfe97b81d5254c(obj, abilityId);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90068);
			}
			return result;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00127D58 File Offset: 0x00125F58
		public uint abilityLevel(Abilities a)
		{
			uint result;
			try
			{
				result = this.core.c78eb6f19dc695177d00c3345ef1e0c32(a);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90072);
			}
			return result;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00127D98 File Offset: 0x00125F98
		public uint abilityLevel(uint abilityId)
		{
			uint result;
			try
			{
				result = this.core.c78eb6f19dc695177d00c3345ef1e0c32(abilityId);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90076);
			}
			return result;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00127DD8 File Offset: 0x00125FD8
		public uint abilityLevel(Player obj, uint abilityId)
		{
			uint result;
			try
			{
				result = this.core.c78eb6f19dc695177d00c3345ef1e0c32(obj, abilityId);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90080);
			}
			return result;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00127E18 File Offset: 0x00126018
		public int abilityExpOnLevel(Abilities a)
		{
			int result;
			try
			{
				result = this.core.cc8a49cbead3bf9e87f5ec109094f0ea0(a);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90084);
			}
			return result;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00127E58 File Offset: 0x00126058
		public int abilityExpOnLevel(int abilityId)
		{
			int result;
			try
			{
				result = this.core.cc8a49cbead3bf9e87f5ec109094f0ea0(abilityId);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90088);
			}
			return result;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00127E98 File Offset: 0x00126098
		public int abilityExpOnLevel(Player obj, int abilityId)
		{
			int result;
			try
			{
				result = this.core.cc8a49cbead3bf9e87f5ec109094f0ea0(obj, abilityId);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90092);
			}
			return result;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00127ED8 File Offset: 0x001260D8
		public bool isStealth()
		{
			bool result;
			try
			{
				result = this.core.c101f23aeac1c42556c49eda79303ea59();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90096) != 0);
			}
			return result;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00127F14 File Offset: 0x00126114
		public bool isStealth(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c101f23aeac1c42556c49eda79303ea59(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90100) != 0);
			}
			return result;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00127F54 File Offset: 0x00126154
		public bool isStealth(string name)
		{
			bool result;
			try
			{
				result = this.core.c101f23aeac1c42556c49eda79303ea59(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90104) != 0);
			}
			return result;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00127F94 File Offset: 0x00126194
		public bool isGliding()
		{
			bool result;
			try
			{
				result = this.core.c2bcd65d2258b801f633a628f46af007e();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90108) != 0);
			}
			return result;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00127FD0 File Offset: 0x001261D0
		public bool isGliding(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c2bcd65d2258b801f633a628f46af007e(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90112) != 0);
			}
			return result;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00128010 File Offset: 0x00126210
		public bool isGliding(string name)
		{
			bool result;
			try
			{
				result = this.core.c2bcd65d2258b801f633a628f46af007e(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90116) != 0);
			}
			return result;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00128050 File Offset: 0x00126250
		public bool isSilense()
		{
			bool result;
			try
			{
				result = this.core.cb915f40ce9c1b1bf1e2f806f86898033();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90120) != 0);
			}
			return result;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0012808C File Offset: 0x0012628C
		public bool isSilense(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cb915f40ce9c1b1bf1e2f806f86898033(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90124) != 0);
			}
			return result;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x001280CC File Offset: 0x001262CC
		public bool isSilense(string name)
		{
			bool result;
			try
			{
				result = this.core.cb915f40ce9c1b1bf1e2f806f86898033(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90128) != 0);
			}
			return result;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0012810C File Offset: 0x0012630C
		public bool isRoot()
		{
			bool result;
			try
			{
				result = this.core.c80fc17d8c61ab5e7985c5f0d1141f095();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90132) != 0);
			}
			return result;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00128148 File Offset: 0x00126348
		public bool isRoot(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c80fc17d8c61ab5e7985c5f0d1141f095(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90136) != 0);
			}
			return result;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00128188 File Offset: 0x00126388
		public bool isRoot(string name)
		{
			bool result;
			try
			{
				result = this.core.c80fc17d8c61ab5e7985c5f0d1141f095(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90140) != 0);
			}
			return result;
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x001281C8 File Offset: 0x001263C8
		public bool isSleep()
		{
			bool result;
			try
			{
				result = this.core.cb4dc534ce65a117c2d5aacdf5e2d4669();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90144) != 0);
			}
			return result;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00128204 File Offset: 0x00126404
		public bool isSleep(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cb4dc534ce65a117c2d5aacdf5e2d4669(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90148) != 0);
			}
			return result;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00128244 File Offset: 0x00126444
		public bool isSleep(string name)
		{
			bool result;
			try
			{
				result = this.core.cb4dc534ce65a117c2d5aacdf5e2d4669(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90152) != 0);
			}
			return result;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00128284 File Offset: 0x00126484
		public bool isInDuel()
		{
			bool result;
			try
			{
				result = this.core.c25e580036434aeb84302641ee4f3eb20();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90156) != 0);
			}
			return result;
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x001282C0 File Offset: 0x001264C0
		public bool isInDuel(string name)
		{
			bool result;
			try
			{
				result = this.core.c25e580036434aeb84302641ee4f3eb20(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90160) != 0);
			}
			return result;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00128300 File Offset: 0x00126500
		public bool isInDuel(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c25e580036434aeb84302641ee4f3eb20(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90164) != 0);
			}
			return result;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00128340 File Offset: 0x00126540
		public bool isKnockedDown()
		{
			bool result;
			try
			{
				result = this.core.c5d08e8402df8610f08d318e8fcad3816();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90168) != 0);
			}
			return result;
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0012837C File Offset: 0x0012657C
		public bool isKnockedDown(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c5d08e8402df8610f08d318e8fcad3816(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90172) != 0);
			}
			return result;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x001283BC File Offset: 0x001265BC
		public bool isKnockedDown(string name)
		{
			bool result;
			try
			{
				result = this.core.c5d08e8402df8610f08d318e8fcad3816(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90176) != 0);
			}
			return result;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x001283FC File Offset: 0x001265FC
		public bool isStun()
		{
			bool result;
			try
			{
				result = this.core.c9e6f057ccd6e645114b909dfb118dacc();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90180) != 0);
			}
			return result;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00128438 File Offset: 0x00126638
		public bool isStun(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c9e6f057ccd6e645114b909dfb118dacc(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90184) != 0);
			}
			return result;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00128478 File Offset: 0x00126678
		public bool isStun(string name)
		{
			bool result;
			try
			{
				result = this.core.c9e6f057ccd6e645114b909dfb118dacc(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90188) != 0);
			}
			return result;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x001284B8 File Offset: 0x001266B8
		public bool isCrippled()
		{
			bool result;
			try
			{
				result = this.core.c9c170ca6ec31c8b21d381f6e9d92a97a();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90192) != 0);
			}
			return result;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x001284F4 File Offset: 0x001266F4
		public bool isCrippled(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c9c170ca6ec31c8b21d381f6e9d92a97a(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90196) != 0);
			}
			return result;
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00128534 File Offset: 0x00126734
		public bool isCrippled(string name)
		{
			bool result;
			try
			{
				result = this.core.c9c170ca6ec31c8b21d381f6e9d92a97a(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90200) != 0);
			}
			return result;
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00128574 File Offset: 0x00126774
		public bool isMeleeImmune()
		{
			bool result;
			try
			{
				result = this.core.c7483ae0662af022e60dc91f80462cde2();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90204) != 0);
			}
			return result;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x001285B0 File Offset: 0x001267B0
		public bool isMeleeImmune(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c7483ae0662af022e60dc91f80462cde2(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90208) != 0);
			}
			return result;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x001285F0 File Offset: 0x001267F0
		public bool isMeleeImmune(string name)
		{
			bool result;
			try
			{
				result = this.core.c7483ae0662af022e60dc91f80462cde2(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90212) != 0);
			}
			return result;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00128630 File Offset: 0x00126830
		public bool isRangedImmune()
		{
			bool result;
			try
			{
				result = this.core.cd2b51beb8947cf9dc5ca13f51c37d45b();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90216) != 0);
			}
			return result;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0012866C File Offset: 0x0012686C
		public bool isRangedImmune(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cd2b51beb8947cf9dc5ca13f51c37d45b(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90220) != 0);
			}
			return result;
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x001286AC File Offset: 0x001268AC
		public bool isRangedImmune(string name)
		{
			bool result;
			try
			{
				result = this.core.cd2b51beb8947cf9dc5ca13f51c37d45b(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90224) != 0);
			}
			return result;
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x001286EC File Offset: 0x001268EC
		public bool isSpellImmune()
		{
			bool result;
			try
			{
				result = this.core.c5eee395ba0996338fb08122c64732eff();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90228) != 0);
			}
			return result;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00128728 File Offset: 0x00126928
		public bool isSpellImmune(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c5eee395ba0996338fb08122c64732eff(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90232) != 0);
			}
			return result;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00128768 File Offset: 0x00126968
		public bool isSpellImmune(string name)
		{
			bool result;
			try
			{
				result = this.core.c5eee395ba0996338fb08122c64732eff(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90236) != 0);
			}
			return result;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x001287A8 File Offset: 0x001269A8
		public bool isSiegeImmune()
		{
			bool result;
			try
			{
				result = this.core.cfd845b1411f39352773af5023f1de04f();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90240) != 0);
			}
			return result;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x001287E4 File Offset: 0x001269E4
		public bool isSiegeImmune(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cfd845b1411f39352773af5023f1de04f(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90244) != 0);
			}
			return result;
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00128824 File Offset: 0x00126A24
		public bool isSiegeImmune(string name)
		{
			bool result;
			try
			{
				result = this.core.cfd845b1411f39352773af5023f1de04f(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90248) != 0);
			}
			return result;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00128864 File Offset: 0x00126A64
		public bool isAlly(string name)
		{
			bool result;
			try
			{
				result = this.core.c06739d9f701b00d3b0ee0f704e4e18e4(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90252) != 0);
			}
			return result;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x001288A4 File Offset: 0x00126AA4
		public bool isAlly(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c06739d9f701b00d3b0ee0f704e4e18e4(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90256) != 0);
			}
			return result;
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x001288E4 File Offset: 0x00126AE4
		public bool isClanMember(string name)
		{
			bool result;
			try
			{
				result = this.core.c10a3bbf795a592bd0be2ce2ecfe7bf7c(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90260) != 0);
			}
			return result;
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00128924 File Offset: 0x00126B24
		public bool isClanMember(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c10a3bbf795a592bd0be2ce2ecfe7bf7c(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90264) != 0);
			}
			return result;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00128964 File Offset: 0x00126B64
		public bool isInMyPartyGroup(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c175bf128c715982f44268bfdc8db4cce(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90268) != 0);
			}
			return result;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x001289A4 File Offset: 0x00126BA4
		public bool isFamilyMember(string name)
		{
			bool result;
			try
			{
				result = this.core.c846d58e3d2d76f6ba6ba3c248acb2ebd(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90272) != 0);
			}
			return result;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x001289E4 File Offset: 0x00126BE4
		public bool isFamilyMember(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c846d58e3d2d76f6ba6ba3c248acb2ebd(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90276) != 0);
			}
			return result;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00128A24 File Offset: 0x00126C24
		public bool isEnemy(string name)
		{
			bool result;
			try
			{
				result = this.core.cd93394abb39713f6d3b31132ca2432fb(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90280) != 0);
			}
			return result;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00128A64 File Offset: 0x00126C64
		public bool isEnemy(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cd93394abb39713f6d3b31132ca2432fb(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90284) != 0);
			}
			return result;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00128AA4 File Offset: 0x00126CA4
		public long timeFromLastGetExp()
		{
			long result;
			try
			{
				result = this.core.c59debe15b5891d89f153fc6121869bc1();
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90288);
			}
			return result;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00128AE4 File Offset: 0x00126CE4
		public long timeFromLastDie()
		{
			long result;
			try
			{
				result = this.core.c1dc6a1c7759d5e5e6d760bc318174503();
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90292);
			}
			return result;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00128B24 File Offset: 0x00126D24
		public string itemName(Item item)
		{
			string result;
			try
			{
				result = this.core.c90bc1bb2a243f2e274e4f71eb88c92ea(item);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00128B5C File Offset: 0x00126D5C
		public string name(Creature obj)
		{
			string result;
			try
			{
				result = this.core.c4133f594a82980efa774a1f80ec2e7d6(obj);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x00128B94 File Offset: 0x00126D94
		public string skillName(Skill skill)
		{
			string result;
			try
			{
				result = this.core.c1369f14f2c3a8b79f759996fef8d7f80(skill);
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00128BCC File Offset: 0x00126DCC
		public bool isFight()
		{
			bool result;
			try
			{
				result = this.core.c80206344ce7e92058eaf2e5bf790ffaa();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90296) != 0);
			}
			return result;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00128C08 File Offset: 0x00126E08
		public bool isFight(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c80206344ce7e92058eaf2e5bf790ffaa(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90300) != 0);
			}
			return result;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00128C48 File Offset: 0x00126E48
		public bool isFight(string name)
		{
			bool result;
			try
			{
				result = this.core.c80206344ce7e92058eaf2e5bf790ffaa(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90304) != 0);
			}
			return result;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00128C88 File Offset: 0x00126E88
		public bool isFlagged()
		{
			bool result;
			try
			{
				result = this.core.cae192faed37d43c8cae3ed19f40210b9();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90308) != 0);
			}
			return result;
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00128CC4 File Offset: 0x00126EC4
		public bool isFlagged(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cae192faed37d43c8cae3ed19f40210b9(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90312) != 0);
			}
			return result;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00128D04 File Offset: 0x00126F04
		public bool isFlagged(string name)
		{
			bool result;
			try
			{
				result = this.core.cae192faed37d43c8cae3ed19f40210b9(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90316) != 0);
			}
			return result;
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00128D44 File Offset: 0x00126F44
		public long timeWePlay()
		{
			long result;
			try
			{
				result = this.core.c9bf219b2eb441d9db18a48f56a640e3b();
			}
			catch
			{
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90320);
			}
			return result;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00128D84 File Offset: 0x00126F84
		public Creature getSlave()
		{
			Creature result;
			try
			{
				result = this.core.ce4c3ee30277ceded98814b3b8e9e16d9();
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00128DBC File Offset: 0x00126FBC
		public Creature getSlave(Creature obj)
		{
			Creature result;
			try
			{
				result = this.core.ce4c3ee30277ceded98814b3b8e9e16d9(obj);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00128DF4 File Offset: 0x00126FF4
		public Creature getSlave(string name)
		{
			Creature result;
			try
			{
				result = this.core.ce4c3ee30277ceded98814b3b8e9e16d9(name);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00128E2C File Offset: 0x0012702C
		public Creature getMount()
		{
			Creature result;
			try
			{
				result = this.core.c627f757ba9897d48d7740de234ec5679();
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00128E64 File Offset: 0x00127064
		public Creature getMount(Creature obj)
		{
			Creature result;
			try
			{
				result = this.core.c627f757ba9897d48d7740de234ec5679(obj);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00128E9C File Offset: 0x0012709C
		public Creature getMount(string name)
		{
			Creature result;
			try
			{
				result = this.core.c627f757ba9897d48d7740de234ec5679(name);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00128ED4 File Offset: 0x001270D4
		public bool isMounted()
		{
			bool result;
			try
			{
				result = this.core.c7eec637389476bd58e6aaf0c57770ebd();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90324) != 0);
			}
			return result;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00128F10 File Offset: 0x00127110
		public bool isMounted(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c7eec637389476bd58e6aaf0c57770ebd(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90328) != 0);
			}
			return result;
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00128F50 File Offset: 0x00127150
		public bool isMounted(string name)
		{
			bool result;
			try
			{
				result = this.core.c7eec637389476bd58e6aaf0c57770ebd(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90332) != 0);
			}
			return result;
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00128F90 File Offset: 0x00127190
		public Creature lastAttacked()
		{
			Creature result;
			try
			{
				result = this.core.c62b26a2847dca8ff715bfc1c74cc0474();
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00128FC8 File Offset: 0x001271C8
		public Creature lastAttacked(Creature obj)
		{
			Creature result;
			try
			{
				result = this.core.c62b26a2847dca8ff715bfc1c74cc0474(obj);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00129000 File Offset: 0x00127200
		public Creature lastAttacked(string name)
		{
			Creature result;
			try
			{
				result = this.core.c62b26a2847dca8ff715bfc1c74cc0474(name);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00129038 File Offset: 0x00127238
		public Creature lastAttacker()
		{
			Creature result;
			try
			{
				result = this.core.cf71025c4091b1f804cbfb0c051136657();
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00129070 File Offset: 0x00127270
		public Creature lastAttacker(Creature obj)
		{
			Creature result;
			try
			{
				result = this.core.cf71025c4091b1f804cbfb0c051136657(obj);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x001290A8 File Offset: 0x001272A8
		public Creature lastAttacker(string name)
		{
			Creature result;
			try
			{
				result = this.core.cf71025c4091b1f804cbfb0c051136657(name);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x001290E0 File Offset: 0x001272E0
		public uint castingSkillId()
		{
			uint result;
			try
			{
				result = this.core.c30e1a37bcb8d79e91f867a5ecd197650();
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90336);
			}
			return result;
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x0012911C File Offset: 0x0012731C
		public uint castingSkillId(Creature obj)
		{
			uint result;
			try
			{
				result = this.core.c30e1a37bcb8d79e91f867a5ecd197650(obj);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90340);
			}
			return result;
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x0012915C File Offset: 0x0012735C
		public uint castingSkillId(string name)
		{
			uint result;
			try
			{
				result = this.core.c30e1a37bcb8d79e91f867a5ecd197650(name);
			}
			catch
			{
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90344);
			}
			return result;
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x0012919C File Offset: 0x0012739C
		public bool isInParty()
		{
			bool result;
			try
			{
				result = this.core.c53531bcead374cc663416ae0aad8e63d();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90348) != 0);
			}
			return result;
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x001291D8 File Offset: 0x001273D8
		public bool isPartyMember(string name)
		{
			bool result;
			try
			{
				result = this.core.cb82af310c623ef7400f2267973923aa4(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90352) != 0);
			}
			return result;
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00129218 File Offset: 0x00127418
		public bool isPartyMember(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cb82af310c623ef7400f2267973923aa4(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90356) != 0);
			}
			return result;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00129258 File Offset: 0x00127458
		public PartyMember getPartyLeader()
		{
			PartyMember result;
			try
			{
				result = this.core.cd9691c6c0f7961e309aa6bd848e6d4db();
			}
			catch
			{
				result = cbd2159f9d2808fab749d24056a9a16b8.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00129290 File Offset: 0x00127490
		public Creature getPartyLeaderObj()
		{
			Creature result;
			try
			{
				result = this.core.caa55f86f7219d9f5e2b4e520b374bd89();
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x001292C8 File Offset: 0x001274C8
		public int partyMembersCount()
		{
			int result;
			try
			{
				result = this.core.c11f41a5979e614784e0bb4a57fac7dd0();
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90360);
			}
			return result;
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00129304 File Offset: 0x00127504
		public Creature mountOwner(Creature obj)
		{
			Creature result;
			try
			{
				result = this.core.c2d9bb18f1c6e828452ce73fe02ced7bb(obj);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0012933C File Offset: 0x0012753C
		public List<Mail> getAllMails()
		{
			List<Mail> result;
			try
			{
				result = this.core.c3fba209653436fae07e4cc080a6946da();
			}
			catch
			{
				result = c0fc96c7ad6d5f6951197c30b058e1c74.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00129378 File Offset: 0x00127578
		public List<Item> getAllInvItems()
		{
			List<Item> result;
			try
			{
				result = this.core.c5e98d41838c3fa6b45040dc6dc991167();
			}
			catch
			{
				result = c1ef349e2bf9e54bf0fef5229dbddddfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x001293B4 File Offset: 0x001275B4
		public List<PartyMember> getPartyMembers()
		{
			List<PartyMember> result;
			try
			{
				result = this.core.cfbbadf531cd886979ad75c0d1ec4a8d4();
			}
			catch
			{
				result = c7e0d40742bc16885a1bf09d522fbac4c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x001293F0 File Offset: 0x001275F0
		public List<Creature> getVisiblePartyMembers()
		{
			List<Creature> result;
			try
			{
				result = this.core.c1cbb93f8f7b6a6877d7ca0a90d800fa3();
			}
			catch
			{
				result = ce8d826fa3f910602bcf4cc0ab204e4bd.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0012942C File Offset: 0x0012762C
		public Creature getPartyItemsDistributorObj()
		{
			Creature result;
			try
			{
				result = this.core.c6394159dce19e827132e601b287c7675();
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00129464 File Offset: 0x00127664
		public PartyMember getPartyItemsDistributor()
		{
			PartyMember result;
			try
			{
				result = this.core.c65c7fa9b3151ef208bcd188655f33f67();
			}
			catch
			{
				result = cbd2159f9d2808fab749d24056a9a16b8.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0012949C File Offset: 0x0012769C
		public GameMark getMark(Creature obj)
		{
			GameMark result;
			try
			{
				result = this.core.cddfecc833964c1f406a7da1a30ae407e(obj);
			}
			catch
			{
				result = (GameMark)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90364);
			}
			return result;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x001294DC File Offset: 0x001276DC
		public Creature getMarkObj(GameMark mark)
		{
			Creature result;
			try
			{
				result = this.core.c4fbbe0ab24ab37585e6a770ccf961d1f(mark);
			}
			catch
			{
				result = c96de8bd44df52d071df09116cbfb67fd.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00129514 File Offset: 0x00127714
		public bool isSkillLearned(uint skillId)
		{
			bool result;
			try
			{
				result = this.core.cf574a9d07a17d377ad1648840f64fcc3(skillId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90368) != 0);
			}
			return result;
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00129554 File Offset: 0x00127754
		public bool isSkillLearned(string skillName)
		{
			bool result;
			try
			{
				result = this.core.cf574a9d07a17d377ad1648840f64fcc3(skillName);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90372) != 0);
			}
			return result;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00129594 File Offset: 0x00127794
		public Skill getSkill(uint skillId)
		{
			Skill result;
			try
			{
				result = this.core.c77244273af7b0871373781fa35885e65(skillId);
			}
			catch
			{
				result = c9c262e4433f457b77c7ae336478ac6e2.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x001295CC File Offset: 0x001277CC
		public Skill getSkill(string skillName)
		{
			Skill result;
			try
			{
				result = this.core.c77244273af7b0871373781fa35885e65(skillName);
			}
			catch
			{
				result = c9c262e4433f457b77c7ae336478ac6e2.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00129604 File Offset: 0x00127804
		public TerritoryState currentTerritoryState()
		{
			TerritoryState result;
			try
			{
				result = this.core.cccc18c8eb31f6edaadd12df23b294395();
			}
			catch
			{
				result = (TerritoryState)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90376);
			}
			return result;
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00129640 File Offset: 0x00127840
		public List<Territory> getAllTerritories()
		{
			List<Territory> result;
			try
			{
				result = this.core.c1932ce56041ee427878e7ba7eb95462d();
			}
			catch
			{
				result = c08fe80752ff855c392e091b4bde9769b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0012967C File Offset: 0x0012787C
		public List<Item> getCofferItems(uint itemId)
		{
			List<Item> result;
			try
			{
				result = this.core.c2b2f12bc2924312698bbc5736c8e1b54(itemId);
			}
			catch
			{
				result = c1ef349e2bf9e54bf0fef5229dbddddfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x001296B8 File Offset: 0x001278B8
		public List<Item> getCofferItems(string name)
		{
			List<Item> result;
			try
			{
				result = this.core.c2b2f12bc2924312698bbc5736c8e1b54(name);
			}
			catch
			{
				result = c1ef349e2bf9e54bf0fef5229dbddddfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x001296F4 File Offset: 0x001278F4
		public Item getCofferItem(uint itemId)
		{
			Item result;
			try
			{
				result = this.core.ca2f019ad74e93d5f50eb2ab5d237031c(itemId);
			}
			catch
			{
				result = cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x0012972C File Offset: 0x0012792C
		public Item getCofferItem(string name)
		{
			Item result;
			try
			{
				result = this.core.ca2f019ad74e93d5f50eb2ab5d237031c(name);
			}
			catch
			{
				result = cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00129764 File Offset: 0x00127964
		public List<Item> getInvItems(uint itemId)
		{
			List<Item> result;
			try
			{
				result = this.core.c1468586a04c61f3144a8d80d337c6d3b(itemId);
			}
			catch
			{
				result = c1ef349e2bf9e54bf0fef5229dbddddfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x001297A0 File Offset: 0x001279A0
		public List<Item> getInvItems(string name)
		{
			List<Item> result;
			try
			{
				result = this.core.c1468586a04c61f3144a8d80d337c6d3b(name);
			}
			catch
			{
				result = c1ef349e2bf9e54bf0fef5229dbddddfb.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x001297DC File Offset: 0x001279DC
		public Item getInvItem(uint itemId)
		{
			Item result;
			try
			{
				result = this.core.c3a894800d31711fe060ffb224e6b66c1(itemId);
			}
			catch
			{
				result = cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00129814 File Offset: 0x00127A14
		public Item getInvItem(string name)
		{
			Item result;
			try
			{
				result = this.core.c3a894800d31711fe060ffb224e6b66c1(name);
			}
			catch
			{
				result = cef5477524addaf293867e566cc6bb666.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0012984C File Offset: 0x00127A4C
		public int maxItemsWeCanPutIntoInventory(uint itemId)
		{
			int result;
			try
			{
				result = this.core.c3bd8ca44c3ab297425809b7b1190d478(itemId);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90380);
			}
			return result;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0012988C File Offset: 0x00127A8C
		public int maxItemsWeCanCraft(uint craftId)
		{
			int result;
			try
			{
				result = this.core.ce566e816b85b0dbd233234fce8a30d0e(craftId);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90384);
			}
			return result;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x001298CC File Offset: 0x00127ACC
		public List<AuctionItem> getAuctionBuyList(AuctionRequestParams requestParams, int maxCount = 0, int delayBetweenPages = 0)
		{
			List<AuctionItem> result;
			try
			{
				result = this.core.c3b3f4f49dd888d69cc1fe8e3f3355a95(requestParams, maxCount, delayBetweenPages);
			}
			catch
			{
				result = c6c307eceea74bd2c9c5f2364c541d76e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00129908 File Offset: 0x00127B08
		public List<AuctionItem> getAuctionSellList(int maxCount = 0, int delayBetweenPages = 0)
		{
			List<AuctionItem> result;
			try
			{
				result = this.core.c051a595dce6fa93dfa99b824c6899e1e(maxCount, delayBetweenPages);
			}
			catch
			{
				result = c6c307eceea74bd2c9c5f2364c541d76e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00129944 File Offset: 0x00127B44
		public List<AuctionItem> getAuctionBetList(int maxCount = 0, int delayBetweenPages = 0)
		{
			List<AuctionItem> result;
			try
			{
				result = this.core.c699eb643257aeab183fbff0e558f3373(maxCount, delayBetweenPages);
			}
			catch
			{
				result = c6c307eceea74bd2c9c5f2364c541d76e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			}
			return result;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00129980 File Offset: 0x00127B80
		public int auctionItemPrice(string itemName)
		{
			int result;
			try
			{
				result = this.core.c20a7bc1eb0908a31a6f9dfd7e171d30a(itemName);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90388);
			}
			return result;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x001299C0 File Offset: 0x00127BC0
		public int auctionItemPrice(uint itemId)
		{
			int result;
			try
			{
				result = this.core.c20a7bc1eb0908a31a6f9dfd7e171d30a(itemId);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90392);
			}
			return result;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00129A00 File Offset: 0x00127C00
		public int auctionItemPrice(uint itemId, ItemGrade itemGrade)
		{
			int result;
			try
			{
				result = this.core.c20a7bc1eb0908a31a6f9dfd7e171d30a(itemId, itemGrade);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90396);
			}
			return result;
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00129A40 File Offset: 0x00127C40
		public DoodadObject getNearestDoodad(uint id)
		{
			DoodadObject result;
			try
			{
				result = this.core.c4ee837b32d71e305733d481608495a1c(id);
			}
			catch
			{
				result = cec343138c4b29fac5a95db99a723ccd3.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00129A78 File Offset: 0x00127C78
		public DoodadObject getNearestDoodad(string name)
		{
			DoodadObject result;
			try
			{
				result = this.core.c4ee837b32d71e305733d481608495a1c(name);
			}
			catch
			{
				result = cec343138c4b29fac5a95db99a723ccd3.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00129AB0 File Offset: 0x00127CB0
		public bool SetVar(BaseObject obj, string varName, object var)
		{
			bool result;
			try
			{
				result = this.core.cea4a706b97624b5f500b6ef14a32cfc4(obj, varName, var);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90400) != 0);
			}
			return result;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00129AF0 File Offset: 0x00127CF0
		public object GetVar(BaseObject obj, string varName)
		{
			object result;
			try
			{
				result = this.core.c64718fa0c29e4b748881a14109039ac6(obj, varName);
			}
			catch
			{
				result = c4e293d07b78c85531b19f1eff22eff73.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00129B2C File Offset: 0x00127D2C
		public bool UseItem(string name, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.cc89b4eb1120c2691cec5e0301885240a(name, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90404) != 0);
			}
			return result;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00129B6C File Offset: 0x00127D6C
		public bool UseItem(string name, int mpCost, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.cc89b4eb1120c2691cec5e0301885240a(name, mpCost, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90408) != 0);
			}
			return result;
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00129BAC File Offset: 0x00127DAC
		public bool UseItem(uint itemId, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.cc89b4eb1120c2691cec5e0301885240a(itemId, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90412) != 0);
			}
			return result;
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00129BEC File Offset: 0x00127DEC
		public bool UseItem(uint itemId, int mpCost, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.cc89b4eb1120c2691cec5e0301885240a(itemId, mpCost, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90416) != 0);
			}
			return result;
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00129C2C File Offset: 0x00127E2C
		public bool UseItem(uint itemId, double x, double y, double z, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.cc89b4eb1120c2691cec5e0301885240a(itemId, x, y, z, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90420) != 0);
			}
			return result;
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00129C70 File Offset: 0x00127E70
		public bool UseItem(uint itemId, double x, double y, double z, int mpCost, bool autoCome, double rot)
		{
			bool result;
			try
			{
				result = this.core.cc89b4eb1120c2691cec5e0301885240a(itemId, x, y, z, mpCost, autoCome, rot);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90424) != 0);
			}
			return result;
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00129CB8 File Offset: 0x00127EB8
		public bool UseItem(uint itemId, double x, double y, double z, int mpCost, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.cc89b4eb1120c2691cec5e0301885240a(itemId, x, y, z, mpCost, autoCome, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(90428));
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90436) != 0);
			}
			return result;
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00129D0C File Offset: 0x00127F0C
		public bool SetTarget(string nick)
		{
			bool result;
			try
			{
				result = this.core.c2a01ec29bd94e09a986cf5dea26b4cc9(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90440) != 0);
			}
			return result;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00129D4C File Offset: 0x00127F4C
		public bool SetTarget(uint objId)
		{
			bool result;
			try
			{
				result = this.core.c2a01ec29bd94e09a986cf5dea26b4cc9(objId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90444) != 0);
			}
			return result;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00129D8C File Offset: 0x00127F8C
		public bool SetTarget(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c2a01ec29bd94e09a986cf5dea26b4cc9(obj, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90448) != 0);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90452) != 0);
			}
			return result;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00129DD4 File Offset: 0x00127FD4
		public bool CancelTarget()
		{
			bool result;
			try
			{
				result = this.core.ccc2af5dc82c1266ae2447ce833f61748();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90456) != 0);
			}
			return result;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00129E10 File Offset: 0x00128010
		public bool ExpandInventory()
		{
			bool result;
			try
			{
				result = this.core.cbd00d56a4c489faab4f7f595b0013393();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90460) != 0);
			}
			return result;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00129E4C File Offset: 0x0012804C
		public bool ExpandWareHouse()
		{
			bool result;
			try
			{
				result = this.core.cbeaadbd78bad51b507268f4548bc17a8();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90464) != 0);
			}
			return result;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00129E88 File Offset: 0x00128088
		public bool UseSkill(string name, double x, double y, double z, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name, x, y, z, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90468) != 0);
			}
			return result;
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00129ECC File Offset: 0x001280CC
		public bool UseSkill(string name, double x, double y, double z, int mpCost, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name, x, y, z, mpCost, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90472) != 0);
			}
			return result;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00129F14 File Offset: 0x00128114
		public void WaitTeleportCompleted(uint maxMillisecondToWait)
		{
			try
			{
				this.core.cb619750f0d1490f1bb119a7cec3b7d40(maxMillisecondToWait);
			}
			catch
			{
			}
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00129F44 File Offset: 0x00128144
		public bool UseSkill(uint skillId, double x, double y, double z, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId, x, y, z, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90476) != 0);
			}
			return result;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00129F88 File Offset: 0x00128188
		public bool UseSkill(uint skillId, double x, double y, double z, int mpCost, bool autoCome = false)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId, x, y, z, mpCost, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90480) != 0);
			}
			return result;
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00129FD0 File Offset: 0x001281D0
		public bool UseSkill(uint skillId)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90484) != 0);
			}
			return result;
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x0012A010 File Offset: 0x00128210
		public bool UseSkill(uint skillId, int mpCost)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId, mpCost);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90488) != 0);
			}
			return result;
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x0012A050 File Offset: 0x00128250
		public bool UseSkill(string name)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90492) != 0);
			}
			return result;
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x0012A090 File Offset: 0x00128290
		public bool UseSkill(string name, int mpCost)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name, mpCost);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90496) != 0);
			}
			return result;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0012A0D0 File Offset: 0x001282D0
		public bool UseSkill(uint skillId, bool autoCome)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90500) != 0);
			}
			return result;
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0012A110 File Offset: 0x00128310
		public bool UseSkill(uint skillId, int mpCost, bool autoCome)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId, mpCost, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90504) != 0);
			}
			return result;
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0012A150 File Offset: 0x00128350
		public bool UseSkill(string name, bool autoCome)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90508) != 0);
			}
			return result;
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0012A190 File Offset: 0x00128390
		public bool UseSkill(string name, int mpCost, bool autoCome)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name, mpCost, autoCome);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90512) != 0);
			}
			return result;
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x0012A1D0 File Offset: 0x001283D0
		public bool UseSkill(string name, bool autoCome, bool selfTarget)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name, autoCome, selfTarget);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90516) != 0);
			}
			return result;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0012A210 File Offset: 0x00128410
		public bool UseSkill(string name, int mpCost, bool autoCome, bool selfTarget)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(name, mpCost, autoCome, selfTarget);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90520) != 0);
			}
			return result;
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0012A254 File Offset: 0x00128454
		public bool UseSkill(uint skillId, bool autoCome, bool selfTarget)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId, autoCome, selfTarget);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90524) != 0);
			}
			return result;
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0012A294 File Offset: 0x00128494
		public bool UseSkill(uint skillId, int mpCost, bool autoCome, bool selfTarget)
		{
			bool result;
			try
			{
				result = this.core.c7442f77211d3dbe22267a27df00a49c3(skillId, mpCost, autoCome, selfTarget);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90528) != 0);
			}
			return result;
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0012A2D8 File Offset: 0x001284D8
		public string сurrentTerritoryName()
		{
			string result;
			try
			{
				result = this.core.c2965b9db626a7f44213f45dc9883f098();
			}
			catch
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0012A310 File Offset: 0x00128510
		public Territory getCurrentTerritory()
		{
			Territory result;
			try
			{
				result = this.core.c8614ae9b3c42a5a0ee5010d3a9518b26();
			}
			catch
			{
				result = c1a3f224ae12b5a387799e5177431d829.c8a754f5f2ca4adde825691a9c31a0e83;
			}
			return result;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0012A348 File Offset: 0x00128548
		public bool UnEquip(string name)
		{
			bool result;
			try
			{
				result = this.core.c9c458eb53206621f07d485e5231c807e(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90532) != 0);
			}
			return result;
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0012A388 File Offset: 0x00128588
		public bool UnEquip(uint itemId)
		{
			bool result;
			try
			{
				result = this.core.c9c458eb53206621f07d485e5231c807e(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90536) != 0);
			}
			return result;
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0012A3C8 File Offset: 0x001285C8
		public bool Equip(string name)
		{
			bool result;
			try
			{
				result = this.core.c1e3bb130504c8f633a7ec8c3a542414d(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90540) != 0);
			}
			return result;
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0012A408 File Offset: 0x00128608
		public bool Equip(uint itemId)
		{
			bool result;
			try
			{
				result = this.core.c1e3bb130504c8f633a7ec8c3a542414d(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90544) != 0);
			}
			return result;
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0012A448 File Offset: 0x00128648
		public bool FamilyInvite(string nick, string title)
		{
			bool result;
			try
			{
				result = this.core.c8c2d9b87b16fdfa16b48c10707193e32(nick, title, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90548) != 0);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90552) != 0);
			}
			return result;
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0012A490 File Offset: 0x00128690
		public bool FamilyMemberDismiss(FamilyMember obj)
		{
			bool result;
			try
			{
				result = this.core.c494aff010effdf6d09b8d816e1a2570c(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90556) != 0);
			}
			return result;
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0012A4D0 File Offset: 0x001286D0
		public bool FamilyMemberDismiss(string nick)
		{
			bool result;
			try
			{
				result = this.core.c494aff010effdf6d09b8d816e1a2570c(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90560) != 0);
			}
			return result;
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0012A510 File Offset: 0x00128710
		public bool ChangeFamilyTitle(string nick, string newTitle)
		{
			bool result;
			try
			{
				result = this.core.ceee1c5bef8cd7f5566d0cf959bf8e4fc(nick, newTitle);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90564) != 0);
			}
			return result;
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0012A550 File Offset: 0x00128750
		public bool ChangeFamilyTitle(FamilyMember obj, string newTitle)
		{
			bool result;
			try
			{
				result = this.core.ceee1c5bef8cd7f5566d0cf959bf8e4fc(obj, newTitle);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90568) != 0);
			}
			return result;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0012A590 File Offset: 0x00128790
		public bool ChangeFamilyLeader(FamilyMember obj)
		{
			bool result;
			try
			{
				result = this.core.c0ac7f10bcbae726fa436d8e8f354babf(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90572) != 0);
			}
			return result;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x0012A5D0 File Offset: 0x001287D0
		public bool ChangeFamilyLeader(string nick)
		{
			bool result;
			try
			{
				result = this.core.c0ac7f10bcbae726fa436d8e8f354babf(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90576) != 0);
			}
			return result;
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0012A610 File Offset: 0x00128810
		public bool FamilyInviteAnswer(bool agree)
		{
			bool result;
			try
			{
				result = this.core.c258aa5ae9b8335a27d1bdfb297a0bebb(agree);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90580) != 0);
			}
			return result;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0012A650 File Offset: 0x00128850
		public bool FamilyLeave()
		{
			bool result;
			try
			{
				result = this.core.ca292b9658fd44e85f0a2cc57725e9c62();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90584) != 0);
			}
			return result;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0012A68C File Offset: 0x0012888C
		public bool DeleteItem(string name, int count = 0)
		{
			bool result;
			try
			{
				result = this.core.c8826ea58b47060576a5b2e9fc7400da4(name, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90588) != 0);
			}
			return result;
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0012A6CC File Offset: 0x001288CC
		public bool DeleteItem(uint itemId, int count = 0)
		{
			bool result;
			try
			{
				result = this.core.c8826ea58b47060576a5b2e9fc7400da4(itemId, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90592) != 0);
			}
			return result;
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x0012A70C File Offset: 0x0012890C
		public bool MoveItemToWh(string name)
		{
			bool result;
			try
			{
				result = this.core.c00e2d65a6e19287040c2b393d1566828(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90596) != 0);
			}
			return result;
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x0012A74C File Offset: 0x0012894C
		public bool MoveItemToWh(uint itemId)
		{
			bool result;
			try
			{
				result = this.core.c00e2d65a6e19287040c2b393d1566828(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90600) != 0);
			}
			return result;
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x0012A78C File Offset: 0x0012898C
		public bool MoveItemFromWh(string name)
		{
			bool result;
			try
			{
				result = this.core.c9dd0e7ff1efcab5e0e04011a428a0a11(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90604) != 0);
			}
			return result;
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0012A7CC File Offset: 0x001289CC
		public bool MoveItemFromWh(uint itemId)
		{
			bool result;
			try
			{
				result = this.core.c9dd0e7ff1efcab5e0e04011a428a0a11(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90608) != 0);
			}
			return result;
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x0012A80C File Offset: 0x00128A0C
		public bool RepairAllEquipment()
		{
			bool result;
			try
			{
				result = this.core.cb03b26d7c7fe4b346c98216a9d4002e5();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90612) != 0);
			}
			return result;
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x0012A848 File Offset: 0x00128A48
		public bool RepairEquipment(string name)
		{
			bool result;
			try
			{
				result = this.core.cab25a8ba0538772ca8018949521aabeb(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90616) != 0);
			}
			return result;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x0012A888 File Offset: 0x00128A88
		public bool RepairEquipment(uint itemId)
		{
			bool result;
			try
			{
				result = this.core.cab25a8ba0538772ca8018949521aabeb(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90620) != 0);
			}
			return result;
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x0012A8C8 File Offset: 0x00128AC8
		public bool TakeGoldFromWh(long count)
		{
			bool result;
			try
			{
				result = this.core.c916f67f0a5a6f116e1ca7bb9d9b3ae96(count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90624) != 0);
			}
			return result;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0012A908 File Offset: 0x00128B08
		public bool MoveGoldToWh(long count)
		{
			bool result;
			try
			{
				result = this.core.c304300c7f6b8a987fd328deee0b48567(count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90628) != 0);
			}
			return result;
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x0012A948 File Offset: 0x00128B48
		public bool ResFromScroll()
		{
			bool result;
			try
			{
				result = this.core.c4f6d4d4f5d90e76717b7b4d6100d8ae0();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90632) != 0);
			}
			return result;
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x0012A984 File Offset: 0x00128B84
		public bool ResToRespoint()
		{
			bool result;
			try
			{
				result = this.core.cefe559e658a11b9d8bfb0e54eeeb8487();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90636) != 0);
			}
			return result;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x0012A9C0 File Offset: 0x00128BC0
		public bool ProveInnocence()
		{
			bool result;
			try
			{
				result = this.core.c395998c78b205718ac9b3c4ec8438239();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90640) != 0);
			}
			return result;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0012A9FC File Offset: 0x00128BFC
		public bool SetPkMode(bool enabled)
		{
			bool result;
			try
			{
				result = this.core.c5bee0c7eff8a93f3e558f6e63653ba5c(enabled);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90644) != 0);
			}
			return result;
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0012AA3C File Offset: 0x00128C3C
		public bool DuelInvite(string name, bool waitAnswer = false)
		{
			bool result;
			try
			{
				result = this.core.c9c85c7ecf7884d2ebaecc9159c1c54a5(name, waitAnswer);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90648) != 0);
			}
			return result;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0012AA7C File Offset: 0x00128C7C
		public bool DuelInvite(Player obj, bool waitAnswer = false)
		{
			bool result;
			try
			{
				result = this.core.c9c85c7ecf7884d2ebaecc9159c1c54a5(obj, waitAnswer);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90652) != 0);
			}
			return result;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0012AABC File Offset: 0x00128CBC
		public bool DuelInviteAnswer(bool agree)
		{
			bool result;
			try
			{
				result = this.core.cf933af9d01776c63539b7246c7b098c9(agree);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90656) != 0);
			}
			return result;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x0012AAFC File Offset: 0x00128CFC
		public bool BattleFieldInviteAnswer(bool agree)
		{
			bool result;
			try
			{
				result = this.core.c74b894e5fe5a800e292239f79d45b64b(agree);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90660) != 0);
			}
			return result;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0012AB3C File Offset: 0x00128D3C
		public bool LeaveBattleField()
		{
			bool result;
			try
			{
				result = this.core.cc085a303acf70ff819a83a997eaff373();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90664) != 0);
			}
			return result;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x0012AB78 File Offset: 0x00128D78
		public bool CancelBattleFieldRegistration()
		{
			bool result;
			try
			{
				result = this.core.c2a08e824e548cd7abd7cb9bc76b2f63f();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90668) != 0);
			}
			return result;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x0012ABB4 File Offset: 0x00128DB4
		public bool RegisterToBattleField(BattleField battleField)
		{
			bool result;
			try
			{
				result = this.core.cfebe841fb41d3594f2a20c4506098bec(battleField);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90672) != 0);
			}
			return result;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0012ABF4 File Offset: 0x00128DF4
		public bool CancelSkill()
		{
			bool result;
			try
			{
				result = this.core.c13d0d0bf6c0fc1ae54cf9e5114c4796b();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90676) != 0);
			}
			return result;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0012AC30 File Offset: 0x00128E30
		public bool CancelBuff(string name)
		{
			bool result;
			try
			{
				result = this.core.cbb204a42d167a7d01dd1ab10998f38b5(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90680) != 0);
			}
			return result;
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0012AC70 File Offset: 0x00128E70
		public bool CancelBuff(uint buffId)
		{
			bool result;
			try
			{
				result = this.core.cbb204a42d167a7d01dd1ab10998f38b5(buffId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90684) != 0);
			}
			return result;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0012ACB0 File Offset: 0x00128EB0
		public bool Say(ChatType chatType, string text, string reciever = null)
		{
			bool result;
			try
			{
				result = this.core.c75f28aed9361c3d7a720e3ca986ae033(chatType, text, reciever);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90688) != 0);
			}
			return result;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x0012ACF0 File Offset: 0x00128EF0
		public bool PickupAllDrop(SpawnObject obj)
		{
			bool result;
			try
			{
				result = this.core.c496e907a06ec91b36c13b623552bb36e(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90692) != 0);
			}
			return result;
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x0012AD30 File Offset: 0x00128F30
		public bool OpenDropView(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c16053b74fe034847f6d546f5055b72ba(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90696) != 0);
			}
			return result;
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0012AD70 File Offset: 0x00128F70
		public bool CloseDropView()
		{
			bool result;
			try
			{
				result = this.core.c911cb058221458476fc3855ca64d738c();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90700) != 0);
			}
			return result;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x0012ADAC File Offset: 0x00128FAC
		public bool AddFriend(string nick)
		{
			bool result;
			try
			{
				result = this.core.c2e0d4ac99d1873302227eacaf8eb1c17(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90704) != 0);
			}
			return result;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0012ADEC File Offset: 0x00128FEC
		public bool RemoveFriend(string nick)
		{
			bool result;
			try
			{
				result = this.core.cd28cf482b441e46bf7de2f8e72536494(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90708) != 0);
			}
			return result;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x0012AE2C File Offset: 0x0012902C
		public bool AddBlock(string nick)
		{
			bool result;
			try
			{
				result = this.core.c010e3092309acbbcf457a125d7b4ab7a(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90712) != 0);
			}
			return result;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x0012AE6C File Offset: 0x0012906C
		public bool RemoveFromBlock(string nick)
		{
			bool result;
			try
			{
				result = this.core.c15c9808dc0687bf0079a110c3f107e7e(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90716) != 0);
			}
			return result;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0012AEAC File Offset: 0x001290AC
		public bool PartyInviteAnswer(bool agree)
		{
			bool result;
			try
			{
				result = this.core.cffe5901826118ab4a58ef696ce51d974(agree);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90720) != 0);
			}
			return result;
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x0012AEEC File Offset: 0x001290EC
		public bool RaidInviteAnswer(bool agree)
		{
			bool result;
			try
			{
				result = this.core.c361b76d590d11b0c212ade2cd63e28b6(agree);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90724) != 0);
			}
			return result;
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x0012AF2C File Offset: 0x0012912C
		public bool InviteToRaid(string nick, bool waitAnswer = false)
		{
			bool result;
			try
			{
				result = this.core.cbfba258b5c04f27a3cb3d5183e342cfb(nick, waitAnswer);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90728) != 0);
			}
			return result;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0012AF6C File Offset: 0x0012916C
		public bool InviteToParty(string nick, bool waitAnswer = false)
		{
			bool result;
			try
			{
				result = this.core.ce154e5b455a9e7c10b909ff19695e8c2(nick, waitAnswer);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90732) != 0);
			}
			return result;
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x0012AFAC File Offset: 0x001291AC
		public bool InviteAreaToRaid()
		{
			bool result;
			try
			{
				result = this.core.c8258b98de0053d72f47841b73df9538b();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90736) != 0);
			}
			return result;
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x0012AFE8 File Offset: 0x001291E8
		public bool DismissPartyMember(PartyMember obj)
		{
			bool result;
			try
			{
				result = this.core.cff2fc4ed644d3a11ce99e05a18547f5d(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90740) != 0);
			}
			return result;
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x0012B028 File Offset: 0x00129228
		public bool DismissPartyMember(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cff2fc4ed644d3a11ce99e05a18547f5d(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90744) != 0);
			}
			return result;
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x0012B068 File Offset: 0x00129268
		public bool DismissPartyMember(string nick)
		{
			bool result;
			try
			{
				result = this.core.cff2fc4ed644d3a11ce99e05a18547f5d(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90748) != 0);
			}
			return result;
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x0012B0A8 File Offset: 0x001292A8
		public bool LeaveFromParty()
		{
			bool result;
			try
			{
				result = this.core.cf618ffdd5f6a54ff6a169493b998878b();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90752) != 0);
			}
			return result;
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x0012B0E4 File Offset: 0x001292E4
		public bool ChangePartyRole(PartyRole newRole)
		{
			bool result;
			try
			{
				result = this.core.c3f7dc9bfe546a292cd83f739be75d7a2(newRole);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90756) != 0);
			}
			return result;
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x0012B124 File Offset: 0x00129324
		public bool ChangePartyLeader(PartyMember obj)
		{
			bool result;
			try
			{
				result = this.core.c34d03f01c7faf988a2e8d353e61836b0(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90760) != 0);
			}
			return result;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x0012B164 File Offset: 0x00129364
		public bool ChangePartyLeader(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c34d03f01c7faf988a2e8d353e61836b0(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90764) != 0);
			}
			return result;
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0012B1A4 File Offset: 0x001293A4
		public bool ChangePartyLeader(string nick)
		{
			bool result;
			try
			{
				result = this.core.c34d03f01c7faf988a2e8d353e61836b0(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90768) != 0);
			}
			return result;
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0012B1E4 File Offset: 0x001293E4
		public bool ChangePartyItemsDistributor(string nick)
		{
			bool result;
			try
			{
				result = this.core.cdc4add10f399ce12b23115ea9dcfcd26(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90772) != 0);
			}
			return result;
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0012B224 File Offset: 0x00129424
		public bool ChangePartyItemsDistributor(PartyMember obj)
		{
			bool result;
			try
			{
				result = this.core.cdc4add10f399ce12b23115ea9dcfcd26(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90776) != 0);
			}
			return result;
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0012B264 File Offset: 0x00129464
		public bool ChangePartyItemsDistribution(PartyItemDistribution newDistribution)
		{
			bool result;
			try
			{
				result = this.core.c189ac51abf4c327dd9de7d3c4c15fec0(newDistribution);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90780) != 0);
			}
			return result;
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x0012B2A4 File Offset: 0x001294A4
		public bool ChangePartyRollOfDiceDrawing(ItemGrade newGrade)
		{
			bool result;
			try
			{
				result = this.core.c0ba5285ece72bfc3508dcc30e67bfc73(newGrade);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90784) != 0);
			}
			return result;
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x0012B2E4 File Offset: 0x001294E4
		public bool ChangePartyPersonalItemsDraw(PartyPersonalItemsDrawing newDrawing)
		{
			bool result;
			try
			{
				result = this.core.cfd183bc5cc0a6b72280afafd81f5cbf5(newDrawing);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90788) != 0);
			}
			return result;
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0012B324 File Offset: 0x00129524
		public bool RemoveMark(GameMark mark, Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cd15275ec4d27722fd999b7c9dbc3364b(mark, obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90792) != 0);
			}
			return result;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0012B364 File Offset: 0x00129564
		public void TerminateGameClient()
		{
			try
			{
				this.core.c5e071fc90b6534e9e9071f415f5b7deb();
			}
			catch
			{
			}
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0012B394 File Offset: 0x00129594
		public void BuildNavMesh(Gps gps, string meshPath)
		{
			try
			{
				this.core.c829b20549678bea1b7a260db57ef62dc(gps, meshPath);
			}
			catch
			{
			}
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x0012B3C4 File Offset: 0x001295C4
		public void LoadNavMesh(string meshPath)
		{
			try
			{
				this.core.c52a9c117ad0a877319f2ff727697c729(meshPath);
			}
			catch
			{
			}
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x0012B3F4 File Offset: 0x001295F4
		public void LoadNavMesh(byte[] rawData)
		{
			try
			{
				this.core.c52a9c117ad0a877319f2ff727697c729(rawData);
			}
			catch
			{
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0012B424 File Offset: 0x00129624
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0012B460 File Offset: 0x00129660
		public bool forceNavMeshMovements
		{
			get
			{
				bool result;
				try
				{
					result = ca8354a3cc027b4f3342ffb1b599d8dac.c30767ddca1f9c207888833aea5b5fc61(this.core);
				}
				catch
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90796) != 0);
				}
				return result;
			}
			set
			{
				try
				{
					c61d6200fa3543c088a6b99bf98074275.c30767ddca1f9c207888833aea5b5fc61(this.core, value);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0012B490 File Offset: 0x00129690
		public float[] GetNavPath(double sX, double sY, double sZ, double eX, double eY, double eZ)
		{
			float[] result;
			try
			{
				result = this.core.c17a4be523441e91387ff212bf92f3d44(sX, sY, sZ, eX, eY, eZ);
			}
			catch
			{
				result = c54ceceb6ad141fcb2d96667414cdb1ba.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90800));
			}
			return result;
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x0012B4DC File Offset: 0x001296DC
		public bool IsInsideNavMesh(double sX, double sY, double sZ)
		{
			bool result;
			try
			{
				result = this.core.cad86bf1d11bcec6afab26326ae6133de(sX, sY, sZ);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90804) != 0);
			}
			return result;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x0012B51C File Offset: 0x0012971C
		public bool SetMark(GameMark mark, Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cb01b8d7034d7a88475a09b85e42136dc(mark, obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90808) != 0);
			}
			return result;
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0012B55C File Offset: 0x0012975C
		public bool RemoveAllMarks()
		{
			bool result;
			try
			{
				result = this.core.c2579adba2e9378e3c0d0a8ac0933438f();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90812) != 0);
			}
			return result;
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x0012B598 File Offset: 0x00129798
		public bool ResetSkills(Abilities a)
		{
			bool result;
			try
			{
				result = this.core.ce052625893b780662bf81378f0a22210(a);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90816) != 0);
			}
			return result;
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0012B5D8 File Offset: 0x001297D8
		public bool ResetSkills(Ability a)
		{
			bool result;
			try
			{
				result = this.core.ce052625893b780662bf81378f0a22210(a);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90820) != 0);
			}
			return result;
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0012B618 File Offset: 0x00129818
		public bool ChangeSpecialisation(Ability a, Ability b)
		{
			bool result;
			try
			{
				result = this.core.c889c39305bb9ce04612dbb6d92d2e718(a, b);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90824) != 0);
			}
			return result;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0012B658 File Offset: 0x00129858
		public bool LearnSpecialisation(Ability newAbility)
		{
			bool result;
			try
			{
				result = this.core.ccf2073e7c95ff08235c6f51dd522b7dc(newAbility);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90828) != 0);
			}
			return result;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0012B698 File Offset: 0x00129898
		public bool LearnSkill(uint skillId)
		{
			bool result;
			try
			{
				result = this.core.cb18e4b6d516ba2b2d27ec27a685b4419(skillId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90832) != 0);
			}
			return result;
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x0012B6D8 File Offset: 0x001298D8
		public bool LearnPassiveBuff(uint passiveBuffId)
		{
			bool result;
			try
			{
				result = this.core.c699c1ea3b20ffed295837de31a1a3e9c(passiveBuffId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90836) != 0);
			}
			return result;
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0012B718 File Offset: 0x00129918
		public bool PlantItem(string itemName, double x, double y, double z)
		{
			bool result;
			try
			{
				result = this.core.cc13aacc3ac7fdada4634025ec569ce69(itemName, x, y, z);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90840) != 0);
			}
			return result;
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x0012B75C File Offset: 0x0012995C
		public bool PlantItem(string itemName, double x, double y, double z, double rot)
		{
			bool result;
			try
			{
				result = this.core.cc13aacc3ac7fdada4634025ec569ce69(itemName, x, y, z, rot);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90844) != 0);
			}
			return result;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0012B7A0 File Offset: 0x001299A0
		public bool PlantItem(string itemName, double x, double y)
		{
			bool result;
			try
			{
				result = this.core.cc13aacc3ac7fdada4634025ec569ce69(itemName, x, y);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90848) != 0);
			}
			return result;
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0012B7E0 File Offset: 0x001299E0
		public bool PlantItem(uint itemId, double x, double y, double z)
		{
			bool result;
			try
			{
				result = this.core.cc13aacc3ac7fdada4634025ec569ce69(itemId, x, y, z, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(90852));
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90860) != 0);
			}
			return result;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0012B830 File Offset: 0x00129A30
		public bool PlantItem(uint itemId, double x, double y, double z, double rot)
		{
			bool result;
			try
			{
				result = this.core.cc13aacc3ac7fdada4634025ec569ce69(itemId, x, y, z, rot);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90864) != 0);
			}
			return result;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x0012B874 File Offset: 0x00129A74
		public bool PlantItem(uint itemId, double x, double y)
		{
			bool result;
			try
			{
				result = this.core.cc13aacc3ac7fdada4634025ec569ce69(itemId, x, y);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90868) != 0);
			}
			return result;
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x0012B8B4 File Offset: 0x00129AB4
		public void Log(string s, bool mainLogBox = false)
		{
			try
			{
				if (mainLogBox)
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
						RuntimeMethodHandle arg_15_0 = methodof(Core.Log(string, bool)).MethodHandle;
					}
					this.core.c8299fa31317d146976f1ea9cd623369b(s, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				else
				{
					this.core.c8299fa31317d146976f1ea9cd623369b(s, this.pluginPath);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0012B918 File Offset: 0x00129B18
		public void Log(string s, string logBox)
		{
			try
			{
				this.core.c8299fa31317d146976f1ea9cd623369b(s, logBox);
			}
			catch
			{
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0012B948 File Offset: 0x00129B48
		public void Log(string s, Color color, bool mainLogBox = false)
		{
			try
			{
				if (mainLogBox)
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
						RuntimeMethodHandle arg_15_0 = methodof(Core.Log(string, Color, bool)).MethodHandle;
					}
					this.core.c8299fa31317d146976f1ea9cd623369b(s, color, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				else
				{
					this.core.c8299fa31317d146976f1ea9cd623369b(s, color, this.pluginPath);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0012B9B0 File Offset: 0x00129BB0
		public void Log(string s, Color color, string logBox)
		{
			try
			{
				this.core.c8299fa31317d146976f1ea9cd623369b(s, color, logBox);
			}
			catch
			{
			}
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x0012B9E0 File Offset: 0x00129BE0
		public void LogSetBackground(Color color, bool mainLogBox = false)
		{
			try
			{
				if (mainLogBox)
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
						RuntimeMethodHandle arg_15_0 = methodof(Core.LogSetBackground(Color, bool)).MethodHandle;
					}
					this.core.cca63eea59ff63f5ed12c992461dedacf(color, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				else
				{
					this.core.cca63eea59ff63f5ed12c992461dedacf(color, this.pluginPath);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001D77 RID: 7543 RVA: 0x0012BA44 File Offset: 0x00129C44
		public void LogSetBackground(Color color, string logBox)
		{
			try
			{
				this.core.cca63eea59ff63f5ed12c992461dedacf(color, logBox);
			}
			catch
			{
			}
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x0012BA74 File Offset: 0x00129C74
		public void LogSetColor(Color color, bool mainLogBox = false)
		{
			try
			{
				if (mainLogBox)
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
						RuntimeMethodHandle arg_15_0 = methodof(Core.LogSetColor(Color, bool)).MethodHandle;
					}
					this.core.c6c3244fa3c4264235746291c63a5ef7f(color, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(196853));
				}
				else
				{
					this.core.c6c3244fa3c4264235746291c63a5ef7f(color, this.pluginPath);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x0012BAD8 File Offset: 0x00129CD8
		public void LogSetColor(Color color, string logBox)
		{
			try
			{
				this.core.c6c3244fa3c4264235746291c63a5ef7f(color, logBox);
			}
			catch
			{
			}
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x0012BB08 File Offset: 0x00129D08
		public void ClearLogs(bool mainLogBox = false)
		{
			try
			{
				if (mainLogBox)
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
						RuntimeMethodHandle arg_15_0 = methodof(Core.ClearLogs(bool)).MethodHandle;
					}
					this.core.cc8b3de74a1208845f6798f929726f61d(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(150366));
				}
				else
				{
					this.core.cc8b3de74a1208845f6798f929726f61d(this.pluginPath);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x0012BB6C File Offset: 0x00129D6C
		public void ClearLogs(string logBox)
		{
			try
			{
				this.core.cc8b3de74a1208845f6798f929726f61d(logBox);
			}
			catch
			{
			}
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x0012BB9C File Offset: 0x00129D9C
		public bool PlantItemsInZone(string itemName, Zone zone, uint count = 0u)
		{
			bool result;
			try
			{
				result = this.core.c00ca3b77b2fb12a878b05193e8b5ed83(itemName, zone, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90872) != 0);
			}
			return result;
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0012BBDC File Offset: 0x00129DDC
		public bool PlantItemsInZone(uint itemId, Zone zone, uint count = 0u)
		{
			bool result;
			try
			{
				result = this.core.c00ca3b77b2fb12a878b05193e8b5ed83(itemId, zone, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90876) != 0);
			}
			return result;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x0012BC1C File Offset: 0x00129E1C
		public bool PlantItemsAtFarm(uint itemId, uint farmUniqId, uint count = 0u)
		{
			bool result;
			try
			{
				result = this.core.ce6397025e87034f53313d6b93fea913c(itemId, farmUniqId, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90880) != 0);
			}
			return result;
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0012BC5C File Offset: 0x00129E5C
		public bool PlantItemsAtFarm(string itemName, uint farmUniqId, uint count = 0u)
		{
			bool result;
			try
			{
				result = this.core.ce6397025e87034f53313d6b93fea913c(itemName, farmUniqId, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90884) != 0);
			}
			return result;
		}

		// Token: 0x06001D80 RID: 7552 RVA: 0x0012BC9C File Offset: 0x00129E9C
		public bool PlantItemsAtFarm(uint itemId, string ownerName, uint count = 0u)
		{
			bool result;
			try
			{
				result = this.core.ce6397025e87034f53313d6b93fea913c(itemId, ownerName, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90888) != 0);
			}
			return result;
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x0012BCDC File Offset: 0x00129EDC
		public bool PlantItemsAtFarm(string itemName, string ownerName, uint count = 0u)
		{
			bool result;
			try
			{
				result = this.core.ce6397025e87034f53313d6b93fea913c(itemName, ownerName, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90892) != 0);
			}
			return result;
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x0012BD1C File Offset: 0x00129F1C
		public bool CollectItemsInZone(string doodadStageName, string skillDesc, Zone zone)
		{
			bool result;
			try
			{
				result = this.core.c9e7cd66e6462f6e27cb462f9fd6cbed4(doodadStageName, skillDesc, zone);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90896) != 0);
			}
			return result;
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0012BD5C File Offset: 0x00129F5C
		public bool CollectItemsInZone(uint doodadStageId, uint skillId, Zone zone)
		{
			bool result;
			try
			{
				result = this.core.c9e7cd66e6462f6e27cb462f9fd6cbed4(doodadStageId, skillId, zone);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90900) != 0);
			}
			return result;
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x0012BD9C File Offset: 0x00129F9C
		public bool CollectItemsInZone(string doodadStageName, uint skillId, Zone zone)
		{
			bool result;
			try
			{
				result = this.core.c9e7cd66e6462f6e27cb462f9fd6cbed4(doodadStageName, skillId, zone);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90904) != 0);
			}
			return result;
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x0012BDDC File Offset: 0x00129FDC
		public bool CollectItemsInZone(uint doodadStageId, string skillDesc, Zone zone)
		{
			bool result;
			try
			{
				result = this.core.c9e7cd66e6462f6e27cb462f9fd6cbed4(doodadStageId, skillDesc, zone);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90908) != 0);
			}
			return result;
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x0012BE1C File Offset: 0x0012A01C
		public bool CollectItemsAtFarm(uint doodadStage, uint skillId, uint farmUniqId)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStage, skillId, farmUniqId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90912) != 0);
			}
			return result;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x0012BE5C File Offset: 0x0012A05C
		public bool CollectItemsAtFarm(uint doodadStage, string skillDesc, uint farmUniqId)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStage, skillDesc, farmUniqId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90916) != 0);
			}
			return result;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0012BE9C File Offset: 0x0012A09C
		public bool CollectItemsAtFarm(uint doodadStage, uint skillId, string farmOwner)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStage, skillId, farmOwner);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90920) != 0);
			}
			return result;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0012BEDC File Offset: 0x0012A0DC
		public bool CollectItemsAtFarm(uint doodadStage, string skillDesc, string farmOwner)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStage, skillDesc, farmOwner);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90924) != 0);
			}
			return result;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0012BF1C File Offset: 0x0012A11C
		public bool CollectItemsAtFarm(string doodadStageName, string skillDesc, uint farmUniqId)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStageName, skillDesc, farmUniqId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90928) != 0);
			}
			return result;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0012BF5C File Offset: 0x0012A15C
		public bool CollectItemsAtFarm(string doodadStageName, uint skillId, uint farmUniqId)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStageName, skillId, farmUniqId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90932) != 0);
			}
			return result;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0012BF9C File Offset: 0x0012A19C
		public bool CollectItemsAtFarm(string doodadStageName, string skillDesc, string farmOwner)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStageName, skillDesc, farmOwner);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90936) != 0);
			}
			return result;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0012BFDC File Offset: 0x0012A1DC
		public bool CollectItemsAtFarm(string doodadStageName, uint skillId, string farmOwner)
		{
			bool result;
			try
			{
				result = this.core.c3d451daac00a14a28dfd03a7222197cd(doodadStageName, skillId, farmOwner);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90940) != 0);
			}
			return result;
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0012C01C File Offset: 0x0012A21C
		public bool UseDoodadSkill(uint skillId, DoodadObject doodad, bool autoCome = false, double additionalDoodadRadius = 0.0)
		{
			bool result;
			try
			{
				result = this.core.c5ccbc9c2e64fbed9b7976a92e588211b(skillId, doodad, autoCome, additionalDoodadRadius);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90944) != 0);
			}
			return result;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0012C060 File Offset: 0x0012A260
		public bool UseDoodadSkill(uint skillId, DoodadObject doodad, int mpCost, bool autoCome = false, double additionalDoodadRadius = 0.0)
		{
			bool result;
			try
			{
				result = this.core.c5ccbc9c2e64fbed9b7976a92e588211b(skillId, doodad, mpCost, autoCome, additionalDoodadRadius);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90948) != 0);
			}
			return result;
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0012C0A4 File Offset: 0x0012A2A4
		public bool UseDoodadSkill(string skillDesc, DoodadObject doodad, bool autoCome = false, double additionalDoodadRadius = 0.0)
		{
			bool result;
			try
			{
				result = this.core.c5ccbc9c2e64fbed9b7976a92e588211b(skillDesc, doodad, autoCome, additionalDoodadRadius);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90952) != 0);
			}
			return result;
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0012C0E8 File Offset: 0x0012A2E8
		public bool UseDoodadSkill(string skillDesc, DoodadObject doodad, int mpCost, bool autoCome = false, double additionalDoodadRadius = 0.0)
		{
			bool result;
			try
			{
				result = this.core.c5ccbc9c2e64fbed9b7976a92e588211b(skillDesc, doodad, mpCost, autoCome, additionalDoodadRadius);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90956) != 0);
			}
			return result;
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0012C12C File Offset: 0x0012A32C
		public bool UsePortal(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c1c6084a6921012b10432d79ee51691fd(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90960) != 0);
			}
			return result;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0012C16C File Offset: 0x0012A36C
		public bool CancelTrade()
		{
			bool result;
			try
			{
				result = this.core.c7abadca120243bfe26827128b4e869d2();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90964) != 0);
			}
			return result;
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0012C1A8 File Offset: 0x0012A3A8
		public bool RequestTrade(string nick)
		{
			bool result;
			try
			{
				result = this.core.c1b492eaa20cddae49b5c82cdd482c55f(nick);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90968) != 0);
			}
			return result;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0012C1E8 File Offset: 0x0012A3E8
		public bool RequestTrade(Creature obj)
		{
			bool result;
			try
			{
				result = this.core.c1b492eaa20cddae49b5c82cdd482c55f(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90972) != 0);
			}
			return result;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0012C228 File Offset: 0x0012A428
		public bool ConfirmTrade()
		{
			bool result;
			try
			{
				result = this.core.c1bc298390ac3ff7339243133327a6edc();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90976) != 0);
			}
			return result;
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x0012C264 File Offset: 0x0012A464
		public bool LockTrade(bool enable)
		{
			bool result;
			try
			{
				result = this.core.c1870e9e8b310c94fb4173d3e549fee6a(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90980) != 0);
			}
			return result;
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x0012C2A4 File Offset: 0x0012A4A4
		public bool PutGoldInTrade(int count)
		{
			bool result;
			try
			{
				result = this.core.c768c39abdba83b564321f96ff01c5196(count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90984) != 0);
			}
			return result;
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0012C2E4 File Offset: 0x0012A4E4
		public bool PutItemInTrade(string name, int count = 0)
		{
			bool result;
			try
			{
				result = this.core.ca1876d03e37396fd34d613a869e4aa9b(name, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90988) != 0);
			}
			return result;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0012C324 File Offset: 0x0012A524
		public bool PutItemInTrade(uint id, int count = 0)
		{
			bool result;
			try
			{
				result = this.core.ca1876d03e37396fd34d613a869e4aa9b(id, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90992) != 0);
			}
			return result;
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0012C364 File Offset: 0x0012A564
		public bool RemoveItemFromTrade(string name)
		{
			bool result;
			try
			{
				result = this.core.c2665672ed7e8730c0cf123900ee377d8(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(90996) != 0);
			}
			return result;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x0012C3A4 File Offset: 0x0012A5A4
		public bool RemoveItemFromTrade(uint id)
		{
			bool result;
			try
			{
				result = this.core.c2665672ed7e8730c0cf123900ee377d8(id);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91000) != 0);
			}
			return result;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x0012C3E4 File Offset: 0x0012A5E4
		public bool RequestMailList()
		{
			bool result;
			try
			{
				result = this.core.c46fd538d51a47f53a40fa70682bafab9();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91004) != 0);
			}
			return result;
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x0012C420 File Offset: 0x0012A620
		public bool SendMail(string receiverNick, string title, string text, bool isFastMail, ulong goldAmount, List<Item> items)
		{
			bool result;
			try
			{
				result = this.core.c69a7e93281bdb16bd717c7826c12a069(receiverNick, title, text, isFastMail, goldAmount, items);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91008) != 0);
			}
			return result;
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x0012C468 File Offset: 0x0012A668
		public bool BuyItems(uint itemId, int count)
		{
			bool result;
			try
			{
				result = this.core.c4d42427cf88bec5c8969f94a6744cb01(itemId, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91012) != 0);
			}
			return result;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x0012C4A8 File Offset: 0x0012A6A8
		public bool BuyItems(string name, int count)
		{
			bool result;
			try
			{
				result = this.core.c4d42427cf88bec5c8969f94a6744cb01(name, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91016) != 0);
			}
			return result;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x0012C4E8 File Offset: 0x0012A6E8
		public bool SellItems(uint itemId)
		{
			bool result;
			try
			{
				result = this.core.cd4d61eb209099982f7374a0227ccae38(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91020) != 0);
			}
			return result;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0012C528 File Offset: 0x0012A728
		public bool SellItems(string name)
		{
			bool result;
			try
			{
				result = this.core.cd4d61eb209099982f7374a0227ccae38(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91024) != 0);
			}
			return result;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x0012C568 File Offset: 0x0012A768
		public bool CraftItems(uint craftId, int count = 1)
		{
			bool result;
			try
			{
				result = this.core.c9ada8ef6fb48f19e3d7cb7e3ff2b9447(craftId, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91028) != 0);
			}
			return result;
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x0012C5A8 File Offset: 0x0012A7A8
		public bool CraftItems(string craftName, int count = 1)
		{
			bool result;
			try
			{
				result = this.core.c9ada8ef6fb48f19e3d7cb7e3ff2b9447(craftName, count);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91032) != 0);
			}
			return result;
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x0012C5E8 File Offset: 0x0012A7E8
		public bool SellBackpack(bool getGold)
		{
			bool result;
			try
			{
				result = this.core.cc85ac78d1c424de701dec3cb04e567bd(getGold);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91036) != 0);
			}
			return result;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x0012C628 File Offset: 0x0012A828
		public bool BuySpecialItem(uint itemId)
		{
			bool result;
			try
			{
				result = this.core.cde2a25f23ca5d7ebf86a94fae139443c(itemId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91040) != 0);
			}
			return result;
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0012C668 File Offset: 0x0012A868
		public bool BuySpecialItem(string itemName)
		{
			bool result;
			try
			{
				result = this.core.cde2a25f23ca5d7ebf86a94fae139443c(itemName);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91044) != 0);
			}
			return result;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0012C6A8 File Offset: 0x0012A8A8
		public bool SwimUp(bool enable)
		{
			bool result;
			try
			{
				result = this.core.c2a7f6db33c399c24639fb21bf42a2a06(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91048) != 0);
			}
			return result;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0012C6E8 File Offset: 0x0012A8E8
		public bool SwimDown(bool enable)
		{
			bool result;
			try
			{
				result = this.core.ca4808ab009522cdf0ddff50d60eadaf0(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91052) != 0);
			}
			return result;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0012C728 File Offset: 0x0012A928
		public bool Jump(bool enable)
		{
			bool result;
			try
			{
				result = this.core.c290bb5d61d6bec101acda191bccceee3(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91056) != 0);
			}
			return result;
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0012C768 File Offset: 0x0012A968
		public bool MoveBackward(bool enable)
		{
			bool result;
			try
			{
				result = this.core.c2e1decb11766577a3bf449caaebdb4a7(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91060) != 0);
			}
			return result;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0012C7A8 File Offset: 0x0012A9A8
		public bool MoveForward(bool enable)
		{
			bool result;
			try
			{
				result = this.core.ca7cfa11aaa074e7ee1464fb0e223a6e8(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91064) != 0);
			}
			return result;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0012C7E8 File Offset: 0x0012A9E8
		public bool MoveLeft(bool enable)
		{
			bool result;
			try
			{
				result = this.core.c471c0e6836b037c866402d0e72ed0192(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91068) != 0);
			}
			return result;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0012C828 File Offset: 0x0012AA28
		public bool MoveRight(bool enable)
		{
			bool result;
			try
			{
				result = this.core.c030c7e443fc0c956fd3fc907f3910182(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91072) != 0);
			}
			return result;
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0012C868 File Offset: 0x0012AA68
		public bool Turn(double angle, bool waitAnswer = true)
		{
			bool result;
			try
			{
				result = this.core.c4f60c2cb479a81026ab11cb3f9163752(angle, waitAnswer);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91076) != 0);
			}
			return result;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0012C8A8 File Offset: 0x0012AAA8
		public bool TurnDirectly()
		{
			bool result;
			try
			{
				result = this.core.c1c043454188eba299ebf8bcda24fb1df();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91080) != 0);
			}
			return result;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0012C8E4 File Offset: 0x0012AAE4
		public bool TurnDirectly(SpawnObject obj)
		{
			bool result;
			try
			{
				result = this.core.c1c043454188eba299ebf8bcda24fb1df(obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91084) != 0);
			}
			return result;
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0012C924 File Offset: 0x0012AB24
		public bool RotateLeft(bool enable)
		{
			bool result;
			try
			{
				result = this.core.c06e74c9af384cfb4e11affc870a8b257(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91088) != 0);
			}
			return result;
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0012C964 File Offset: 0x0012AB64
		public bool RotateRight(bool enable)
		{
			bool result;
			try
			{
				result = this.core.cedfc44e4d06536e7207cb1d7b6c8f5d8(enable);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91092) != 0);
			}
			return result;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x0012C9A4 File Offset: 0x0012ABA4
		public void CancelMoveTo()
		{
			try
			{
				this.core.cbcb014821c85cae9b0c4968f6a66b9bc();
			}
			catch
			{
			}
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x0012C9D4 File Offset: 0x0012ABD4
		public void SuspendMoveTo()
		{
			try
			{
				this.core.c0b2b13256f9741f6fa45f014169c83f0();
			}
			catch
			{
			}
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x0012CA04 File Offset: 0x0012AC04
		public void ResumeMoveTo()
		{
			try
			{
				this.core.cb99283d759fc7f4b69a3d8ad1e3e4af8();
			}
			catch
			{
			}
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0012CA34 File Offset: 0x0012AC34
		public void SuspendMoveToBeforeUseSkill(bool enabled)
		{
			try
			{
				this.core.c70fc11de8ec843b086d80c502e3d593b(enabled);
			}
			catch
			{
			}
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0012CA64 File Offset: 0x0012AC64
		public bool MoveTo(double x, double y, double z)
		{
			bool result;
			try
			{
				result = this.core.c80d205e01c504d154a7b60400b29b347(x, y, z, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91096), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91104), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91112) != 0);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91116) != 0);
			}
			return result;
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0012CAC8 File Offset: 0x0012ACC8
		public bool MoveTo(double x, double y, double z, bool generatePreMoveEvent)
		{
			bool result;
			try
			{
				result = this.core.c80d205e01c504d154a7b60400b29b347(x, y, z, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91120), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91128), generatePreMoveEvent);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91136) != 0);
			}
			return result;
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0012CB24 File Offset: 0x0012AD24
		public bool MoveTo(SpawnObject obj)
		{
			bool result;
			try
			{
				result = this.core.c80d205e01c504d154a7b60400b29b347(obj, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91140), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91148), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91156) != 0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91160) != 0);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91164) != 0);
			}
			return result;
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0012CB90 File Offset: 0x0012AD90
		public bool MoveTo(SpawnObject obj, bool generatePreMoveEvent)
		{
			bool result;
			try
			{
				result = this.core.c80d205e01c504d154a7b60400b29b347(obj, c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91168), c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91176), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91184) != 0, generatePreMoveEvent);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91188) != 0);
			}
			return result;
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0012CBF0 File Offset: 0x0012ADF0
		public bool ComeTo(double x, double y, double z, double dist = 0.0, double doneDist = 1.5)
		{
			bool result;
			try
			{
				result = this.core.cd590ca606a66bb8f3ab99d7d873d65c1(x, y, z, dist, doneDist, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91192) != 0);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91196) != 0);
			}
			return result;
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0012CC40 File Offset: 0x0012AE40
		public bool ComeTo(double x, double y, double z, bool generatePreMoveEvent, double dist = 0.0, double doneDist = 1.5)
		{
			bool result;
			try
			{
				result = this.core.cd590ca606a66bb8f3ab99d7d873d65c1(x, y, z, dist, doneDist, generatePreMoveEvent);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91200) != 0);
			}
			return result;
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0012CC88 File Offset: 0x0012AE88
		public bool ComeTo(SpawnObject obj, double dist = 1.0, double doneDist = 1.5)
		{
			bool result;
			try
			{
				result = this.core.cd590ca606a66bb8f3ab99d7d873d65c1(obj, dist, doneDist, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91204) != 0);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91208) != 0);
			}
			return result;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0012CCD4 File Offset: 0x0012AED4
		public bool ComeTo(SpawnObject obj, bool generatePreMoveEvent, double dist = 1.0, double doneDist = 1.5)
		{
			bool result;
			try
			{
				result = this.core.cd590ca606a66bb8f3ab99d7d873d65c1(obj, dist, doneDist, generatePreMoveEvent);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91212) != 0);
			}
			return result;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0012CD18 File Offset: 0x0012AF18
		public bool SitToMount()
		{
			bool result;
			try
			{
				result = this.core.cdf641279529285b3314ce4c60e045629();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91216) != 0);
			}
			return result;
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0012CD54 File Offset: 0x0012AF54
		public bool StandFromMount()
		{
			bool result;
			try
			{
				result = this.core.c905b2663e0fe115a3a9d9f10ac93c07b();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91220) != 0);
			}
			return result;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0012CD90 File Offset: 0x0012AF90
		public bool BindSlave()
		{
			bool result;
			try
			{
				result = this.core.c25636578e882adf618515c7832ad3a3c();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91224) != 0);
			}
			return result;
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0012CDCC File Offset: 0x0012AFCC
		public bool BindSlave(Slave slave)
		{
			bool result;
			try
			{
				result = this.core.c25636578e882adf618515c7832ad3a3c(slave);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91228) != 0);
			}
			return result;
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0012CE0C File Offset: 0x0012B00C
		public bool DiscardSlave()
		{
			bool result;
			try
			{
				result = this.core.c458834a088e8c79016b01d15adbe2b87();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91232) != 0);
			}
			return result;
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0012CE48 File Offset: 0x0012B048
		public bool StartQuest(uint questId)
		{
			bool result;
			try
			{
				result = this.core.cabd0ad557844d50ec5f424db4b22794e(questId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91236) != 0);
			}
			return result;
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0012CE88 File Offset: 0x0012B088
		public bool StartQuest(string questName)
		{
			bool result;
			try
			{
				result = this.core.cabd0ad557844d50ec5f424db4b22794e(questName);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91240) != 0);
			}
			return result;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0012CEC8 File Offset: 0x0012B0C8
		public bool CancelQuest(uint questId)
		{
			bool result;
			try
			{
				result = this.core.c97f06d8fd8e20b3fe60eba171604bc18(questId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91244) != 0);
			}
			return result;
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0012CF08 File Offset: 0x0012B108
		public bool CancelQuest(string questName)
		{
			bool result;
			try
			{
				result = this.core.c97f06d8fd8e20b3fe60eba171604bc18(questName);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91248) != 0);
			}
			return result;
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0012CF48 File Offset: 0x0012B148
		public bool CompleteQuest(uint questId, int reward = 0)
		{
			bool result;
			try
			{
				result = this.core.c11fe450148dd98dd4f4a563fde2402cb(questId, reward);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91252) != 0);
			}
			return result;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0012CF88 File Offset: 0x0012B188
		public bool CompleteQuest(string questName, int reward = 0)
		{
			bool result;
			try
			{
				result = this.core.c11fe450148dd98dd4f4a563fde2402cb(questName, reward);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91256) != 0);
			}
			return result;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0012CFC8 File Offset: 0x0012B1C8
		public bool TalkWithQuestNpc(uint questId)
		{
			bool result;
			try
			{
				result = this.core.cc5e89853dc47e2e608e2193d44b37e79(questId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91260) != 0);
			}
			return result;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0012D008 File Offset: 0x0012B208
		public bool TalkWithQuestNpc(uint questId, Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cc5e89853dc47e2e608e2193d44b37e79(questId, obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91264) != 0);
			}
			return result;
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0012D048 File Offset: 0x0012B248
		public bool TalkWithQuestNpc(string questName)
		{
			bool result;
			try
			{
				result = this.core.cc5e89853dc47e2e608e2193d44b37e79(questName);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91268) != 0);
			}
			return result;
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0012D088 File Offset: 0x0012B288
		public bool TalkWithQuestNpc(string questName, Creature obj)
		{
			bool result;
			try
			{
				result = this.core.cc5e89853dc47e2e608e2193d44b37e79(questName, obj);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91272) != 0);
			}
			return result;
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0012D0C8 File Offset: 0x0012B2C8
		public bool Climb(DoodadObject doodad)
		{
			bool result;
			try
			{
				result = this.core.c76cd3a57efb3a6c8a124705446639d75(doodad);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91276) != 0);
			}
			return result;
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0012D108 File Offset: 0x0012B308
		public bool ClimbUp()
		{
			bool result;
			try
			{
				result = this.core.ca9a33266256b921ff134e37c27969ce2();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91280) != 0);
			}
			return result;
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0012D144 File Offset: 0x0012B344
		public bool ClimbDown()
		{
			bool result;
			try
			{
				result = this.core.c5b992e52549fa606ebf0242c2b26ae70();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91284) != 0);
			}
			return result;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0012D180 File Offset: 0x0012B380
		public bool DespawnSlave()
		{
			bool result;
			try
			{
				result = this.core.c5337c837932ea79b6b9a3ea61a2d8f76();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91288) != 0);
			}
			return result;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0012D1BC File Offset: 0x0012B3BC
		public bool DespawnMount()
		{
			bool result;
			try
			{
				result = this.core.cefbd3ae82f074a36e7168886f30cd06c();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91292) != 0);
			}
			return result;
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0012D1F8 File Offset: 0x0012B3F8
		public double getZFromHeightMap(double x, double y)
		{
			double result;
			try
			{
				result = this.core.c990fa03d9af00d4b27bdc6363821a689(x, y);
			}
			catch
			{
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(91296);
			}
			return result;
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0012D238 File Offset: 0x0012B438
		public bool PlaySound(string fileName)
		{
			bool result;
			try
			{
				result = this.core.c67f56db4cdde77092292460331a44974(fileName);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91304) != 0);
			}
			return result;
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x0012D278 File Offset: 0x0012B478
		public bool PlaySound(string fileName, uint minTimeout)
		{
			bool result;
			try
			{
				result = this.core.c67f56db4cdde77092292460331a44974(fileName, minTimeout);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91308) != 0);
			}
			return result;
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0012D2B8 File Offset: 0x0012B4B8
		public bool SetMapPos(double X, double Y, double Z)
		{
			bool result;
			try
			{
				result = this.core.c992ad45fe5eadb4ec1504775c8ccfa33(X, Y, Z);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91312) != 0);
			}
			return result;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0012D2F8 File Offset: 0x0012B4F8
		public bool SetGroupStatus(string name, bool enabled)
		{
			bool result;
			try
			{
				result = this.core.c141a092fa8231eef22d8c76182a19ffc(name, enabled);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91316) != 0);
			}
			return result;
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x0012D338 File Offset: 0x0012B538
		public bool DelAllGroupStatus()
		{
			bool result;
			try
			{
				result = this.core.ca68819501f001583514608f0bda59a29();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91320) != 0);
			}
			return result;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x0012D374 File Offset: 0x0012B574
		public bool DelGroupStatus(string name)
		{
			bool result;
			try
			{
				result = this.core.cb6e6ec5a914c6f4b3e14033f37c3c01e(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91324) != 0);
			}
			return result;
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0012D3B4 File Offset: 0x0012B5B4
		public bool GetGroupStatus(string name)
		{
			bool result;
			try
			{
				result = this.core.c243623cb1207cc5d7afdc5b64f95f284(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91328) != 0);
			}
			return result;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0012D3F4 File Offset: 0x0012B5F4
		public bool GetFilterStatus(string name)
		{
			bool result;
			try
			{
				result = this.core.c5a578a99adb92dee5a3850cca9037e72(name);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91332) != 0);
			}
			return result;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0012D434 File Offset: 0x0012B634
		public bool Unbound()
		{
			bool result;
			try
			{
				result = this.core.c4754833f656b0578def7a9818f563bda();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91336) != 0);
			}
			return result;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0012D470 File Offset: 0x0012B670
		public bool RestoreExp()
		{
			bool result;
			try
			{
				result = this.core.c9d2719ba51a26ca1d9045a7eea2173b4();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91340) != 0);
			}
			return result;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0012D4AC File Offset: 0x0012B6AC
		public LastError GetLastError()
		{
			LastError result;
			try
			{
				result = this.core.cf6bfba1c07e024ffdc24230e2d25696c();
			}
			catch
			{
				result = (LastError)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91344);
			}
			return result;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0012D4E8 File Offset: 0x0012B6E8
		public void SetLastError(LastError newError)
		{
			try
			{
				this.core.c46ecf2e8a4044502d8dec2676b718b4d(newError);
			}
			catch
			{
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0012D518 File Offset: 0x0012B718
		public bool BlockClientDice(bool enabled)
		{
			bool result;
			try
			{
				result = this.core.cf5a0dd57a315e605dac79f74abb0b272(enabled);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91348) != 0);
			}
			return result;
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0012D558 File Offset: 0x0012B758
		public void SetEventsMultiThreadCall(bool enabled)
		{
			try
			{
				this.core.c1cd485be5a8ed7796dbb95d57aa95853(enabled);
			}
			catch
			{
			}
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0012D588 File Offset: 0x0012B788
		public IntPtr GetGameClientHandle()
		{
			IntPtr result;
			try
			{
				result = this.core.c2ad241760728a791967a61883f5cc99b();
			}
			catch
			{
				result = IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0012D5C0 File Offset: 0x0012B7C0
		public bool RessurectMount(bool tryFoundPetManager)
		{
			bool result;
			try
			{
				result = this.core.cf6731a412c05caeba3267cf95a2dd28b(tryFoundPetManager);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91352) != 0);
			}
			return result;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0012D600 File Offset: 0x0012B800
		public bool RunPlugin(string path)
		{
			bool result;
			try
			{
				result = this.core.c49aaf95672aec6f3bdace67fc1490bdc(path);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91356) != 0);
			}
			return result;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x0012D640 File Offset: 0x0012B840
		public bool StopPlugin(string path)
		{
			bool result;
			try
			{
				result = this.core.cf6552f21deb470a5c51ee508f9a298e9(path);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91360) != 0);
			}
			return result;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x0012D680 File Offset: 0x0012B880
		public bool isPluginRun(string path)
		{
			bool result;
			try
			{
				result = this.core.c16a72df4606eace63b86a63bf0dfca08(path);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91364) != 0);
			}
			return result;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x0012D6C0 File Offset: 0x0012B8C0
		public bool CloseGame()
		{
			bool result;
			try
			{
				result = this.core.c54d5df4fe2524d5d4bf28a9b9e125f0a();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91368) != 0);
			}
			return result;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x0012D6FC File Offset: 0x0012B8FC
		public bool LeaveWorldToCharacterSelect()
		{
			bool result;
			try
			{
				result = this.core.c4f6a19a8a1f51e18295192936e9a61ec();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91372) != 0);
			}
			return result;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x0012D738 File Offset: 0x0012B938
		public bool LeaveCharacterSelectToWorldSelect()
		{
			bool result;
			try
			{
				result = this.core.c1f8a7174057ecf95a6e6162d4acd8f54();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91376) != 0);
			}
			return result;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x0012D774 File Offset: 0x0012B974
		public bool ChangeMateState(MateState newMateState)
		{
			bool result;
			try
			{
				result = this.core.cd67a4c5a411b3e1378ba2e513344968e(newMateState);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91380) != 0);
			}
			return result;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0012D7B4 File Offset: 0x0012B9B4
		public bool DeleteCharacter(string nickname)
		{
			bool result;
			try
			{
				result = this.core.cf82f912a80aa1ef7a827ea7fd17c52e3(nickname);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91384) != 0);
			}
			return result;
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0012D7F4 File Offset: 0x0012B9F4
		public bool CreateCharacter(string nickname, CharRace race, CharGender gender)
		{
			bool result;
			try
			{
				result = this.core.ce72c0c8b006dc2a4e7456d8d5bf448b5(nickname, race, gender, (Ability)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91388));
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91392) != 0);
			}
			return result;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0012D840 File Offset: 0x0012BA40
		public bool CreateCharacter(string nickname, CharRace race, CharGender gender, Ability ability)
		{
			bool result;
			try
			{
				result = this.core.ce72c0c8b006dc2a4e7456d8d5bf448b5(nickname, race, gender, ability);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91396) != 0);
			}
			return result;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x0012D884 File Offset: 0x0012BA84
		public bool OpenCoffer(DoodadObject coffer)
		{
			bool result;
			try
			{
				result = this.core.c1da27843eb3a769ccc9beb7872303bc0(coffer);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91400) != 0);
			}
			return result;
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0012D8C4 File Offset: 0x0012BAC4
		public bool CloseCoffer()
		{
			bool result;
			try
			{
				result = this.core.c0a758f21ed2532b0c9c083ad9f4c912c();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91404) != 0);
			}
			return result;
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0012D900 File Offset: 0x0012BB00
		public bool ExpressEmotion(uint slashCommandId)
		{
			bool result;
			try
			{
				result = this.core.c7369fa2fb9f6394672a9e8e1732db9e7(slashCommandId);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91408) != 0);
			}
			return result;
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0012D940 File Offset: 0x0012BB40
		public bool IsSafeForRadar(SpawnObject spawnObject)
		{
			bool result;
			try
			{
				result = this.core.c0f37c09db338855d3863ccd46157962d(spawnObject);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91412) != 0);
			}
			return result;
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0012D980 File Offset: 0x0012BB80
		public bool SkipPrologue()
		{
			bool result;
			try
			{
				result = this.core.c8dd729c3de6399441af197ec4ca2243e();
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91416) != 0);
			}
			return result;
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x0012D9BC File Offset: 0x0012BBBC
		public bool SetAutoAttackState(bool state)
		{
			bool result;
			try
			{
				result = this.core.cd1d3f8dfa4a3eb661af16f48f96cb774(state);
			}
			catch
			{
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91420) != 0);
			}
			return result;
		}

		// Token: 0x04001082 RID: 4226
		public CoreInternal core;

		// Token: 0x04001083 RID: 4227
		public string pluginPath;

		// Token: 0x04001084 RID: 4228
		private CoreInternal.KeyboardEvent cef0033ad67bb2aa52e1b50622fba0dd7;

		// Token: 0x04001085 RID: 4229
		private CoreInternal.UnitImmune c5079a86ad845a09ad3ee7fca48bec96c;

		// Token: 0x04001086 RID: 4230
		private CoreInternal.GameStateChanged c18a8d485d27b1dee8dc5b91ae29b7496;

		// Token: 0x04001087 RID: 4231
		private CoreInternal.TargetChanged cc65fe83eaa7ecfbcc675d77b9e5d6c65;

		// Token: 0x04001088 RID: 4232
		private CoreInternal.NewCreature c43b8e3825a14806b9a3761b45c778de0;

		// Token: 0x04001089 RID: 4233
		private CoreInternal.PartyInvite cd3ee183dfcb2a7bfa069084256f350c4;

		// Token: 0x0400108A RID: 4234
		private CoreInternal.RaidInvite c1252fd56398f82e6fb8f360193b6be59;

		// Token: 0x0400108B RID: 4235
		private CoreInternal.LevelChanged c3ca0e44dc58274cbd86481abf07fbb1c;

		// Token: 0x0400108C RID: 4236
		private CoreInternal.CreatureDied c0af0ded751c7c1a2c969c92817af8012;

		// Token: 0x0400108D RID: 4237
		private CoreInternal.SkillCasting c96b9c1ce38178028633262e404bae2e3;

		// Token: 0x0400108E RID: 4238
		private CoreInternal.TradeStarted c6f2443ac19193b27fd26df3addf35869;

		// Token: 0x0400108F RID: 4239
		private CoreInternal.TradeDone c9672d0cacc1487837c7a06935571cd68;

		// Token: 0x04001090 RID: 4240
		private CoreInternal.ChatMessage c7a43755b896ef786f7d3267c8e137a5b;

		// Token: 0x04001091 RID: 4241
		private CoreInternal.QuestStarted cf92373f7bd6549378351b99ef76a1ba4;

		// Token: 0x04001092 RID: 4242
		private CoreInternal.QuestUpdated caf5faa74fe32f15605124c7ced738f9d;

		// Token: 0x04001093 RID: 4243
		private CoreInternal.QuestCompleted c03639ec18a453618ad6c88ccda0ffc17;

		// Token: 0x04001094 RID: 4244
		private CoreInternal.LootAvailable c682f0526195a82f02b53a67f1629806c;

		// Token: 0x04001095 RID: 4245
		private CoreInternal.NewInvItem c534cb9e5119a4eb7229a4bdf00346931;

		// Token: 0x04001096 RID: 4246
		private CoreInternal.InvItemRemoved cd8835f412e02ee6b68522c11c3f9f636;

		// Token: 0x04001097 RID: 4247
		private CoreInternal.NewMail ccd3ac50bc5d507a22de8369a181368b5;

		// Token: 0x04001098 RID: 4248
		private CoreInternal.LotSelled c03907515698aafc81f6542211a9c0eb9;

		// Token: 0x04001099 RID: 4249
		private CoreInternal.UnitDamaged c74868cdb6316e82968dcb34dca68404c;

		// Token: 0x0400109A RID: 4250
		private CoreInternal.UnitHealed ca833aee3251897821e5642600b79814b;

		// Token: 0x0400109B RID: 4251
		private CoreInternal.LootDice c3963fda1507610b3bbcc76024e8ad4ef;

		// Token: 0x0400109C RID: 4252
		private CoreInternal.NewDoodad c1b082e70fe282fb43f8862ad1b06aab7;

		// Token: 0x0400109D RID: 4253
		private CoreInternal.DoodadRemoved c5cb001f87ba43f44fe09b11cdd1c8c41;

		// Token: 0x0400109E RID: 4254
		private CoreInternal.CreatureRemoved c2c72e0ad4467fff4a60a9ff579532cdb;

		// Token: 0x0400109F RID: 4255
		private CoreInternal.GoldCountChanged c56e38df8ff9da715e30c9b4959d9ac4e;

		// Token: 0x040010A0 RID: 4256
		private CoreInternal.FoundGameMaster c86265f69293de2a5f4e164341732086b;

		// Token: 0x040010A1 RID: 4257
		private CoreInternal.ClientPlantDoodad c5d3c08241889fe0c4c3e1d82ddc1128b;

		// Token: 0x040010A2 RID: 4258
		private CoreInternal.NewBuff cca3706cd3d8015e21f4b646cb769ccfe;

		// Token: 0x040010A3 RID: 4259
		private CoreInternal.BuffRemoved cd63bf3ee97dd46ec1ca95db1386628d8;

		// Token: 0x040010A4 RID: 4260
		private CoreInternal.ErrorMessage cc4e01c8a31335179857aa85d9059b75c;

		// Token: 0x040010A5 RID: 4261
		private CoreInternal.MapPosChanged ce3879c9b14b51ca0c13609aa713c696a;

		// Token: 0x040010A6 RID: 4262
		private CoreInternal.WidgetFilterStatusChanged c11be0376fcdf893640c7a6c2d4a167df;

		// Token: 0x040010A7 RID: 4263
		private CoreInternal.WidgetGroupStatusChanged c7c616f9bd2a3566d496167f9987929f9;

		// Token: 0x040010A8 RID: 4264
		private CoreInternal.ExpChanged c4d45cbba6e28ff9b4f6369d9ab655c98;

		// Token: 0x040010A9 RID: 4265
		private CoreInternal.AbilityExpChanged cff347b49df0bab4adba4d31c0f8e5f38;

		// Token: 0x040010AA RID: 4266
		private CoreInternal.LaborAmountChanged cfd0c67e4ffb2110df41fe429d4e19cf7;

		// Token: 0x040010AB RID: 4267
		private CoreInternal.CofferOpened c57f245808a27d8bafbbadf9452bdafd2;

		// Token: 0x040010AC RID: 4268
		private CoreInternal.NewSkillLearned ce712abb859034bed3f6709b20aea66e7;

		// Token: 0x040010AD RID: 4269
		private CoreInternal.NewPartyMember c57433036557b00ee5b9d74e1bed86f87;

		// Token: 0x040010AE RID: 4270
		private CoreInternal.PartyMemberLeaves cd638bddd90add5ada0ff3df9c490735b;

		// Token: 0x040010AF RID: 4271
		private CoreInternal.BattleFieldInvite cd5494782bb11fc2bc17088c802ac59d1;

		// Token: 0x040010B0 RID: 4272
		private CoreInternal.UserNavMeshPreMoveFull c1927ca84451be252f40fb28231df0bda;

		// Token: 0x040010B1 RID: 4273
		private CoreInternal.UserNavMeshPreMove c56456b6f25545e940466e8cfa40b31e9;
	}
}
