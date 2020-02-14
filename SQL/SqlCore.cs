using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using A;
using ArcheBuddy.Bot.Classes;

namespace ArcheBuddy.SQL
{
	// Token: 0x020000E9 RID: 233
	public class SqlCore : MarshalProxy
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00033D94 File Offset: 0x00031F94
		internal SqlCore(string text, ClientVersion clientVersion)
		{
			if (!c9d778f467ddda2207141dcb45f2d9c1b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c3c6dca5306f217e4f0a8118ecdcca461.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c994f925d8769b4b088d24160a24fcb09.c30767ddca1f9c207888833aea5b5fc61(c03ab3cc315c27675c59e39a580af7e0e.c0cf59c3e67a46fd4edb3040c5ab0bbfb()), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148842), text)))
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
					RuntimeMethodHandle arg_43_0 = methodof(SqlCore..ctor(string, ClientVersion)).MethodHandle;
				}
				c2e5e290c5e34f024145fe136ad4da993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148845));
				return;
			}
			c2f85881516f7f5a1167506b2e505d817.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15232) != 0);
			this.cfffa987bb40f5a52a78d3ae7981ae443 = clientVersion;
			this.c3e76590440c7f603f07fda2f71aada9b = new SQLiteConnection();
			c518617644be08d27fac23e9d2d4dfcb8.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b, c58db606173fc3119d33baf685e68d1a0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148886), text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148911), this.c3e19e38c76e1baf872a467e05351851d()));
			c033e704b3c5a39a78bce01524463c50d.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b);
			c47afa401db57c6f9a6c6db1fe3c618a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, new Dictionary<uint, SqlSpecialtyItemZone>());
			c844a9f11ced7f2f3668004f846f7af24.c0cf59c3e67a46fd4edb3040c5ab0bbfb(new Thread(new ThreadStart(this.c0b26450d579928ddc2ba39eac2096a8c)));
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00033E7C File Offset: 0x0003207C
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00033E90 File Offset: 0x00032090
		public Dictionary<uint, SqlSpecialtyItemZone> sqlSpecialtyItemZone
		{
			get;
			internal set;
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00033EA4 File Offset: 0x000320A4
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00033EB8 File Offset: 0x000320B8
		public Dictionary<uint, SqlBuff> sqlBuffs
		{
			get;
			internal set;
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00033ECC File Offset: 0x000320CC
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00033EE0 File Offset: 0x000320E0
		public Dictionary<uint, SqlUnitModifier> sqlUnitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00033EF4 File Offset: 0x000320F4
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x00033F08 File Offset: 0x00032108
		public Dictionary<uint, SqlSkillModifier> sqlSkillModifiers
		{
			get;
			internal set;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00033F1C File Offset: 0x0003211C
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00033F30 File Offset: 0x00032130
		public Dictionary<uint, SqlPassiveBuff> sqlPassiveBuffs
		{
			get;
			internal set;
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x00033F44 File Offset: 0x00032144
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x00033F58 File Offset: 0x00032158
		public Dictionary<uint, SqlItemGroup> sqlItemGroups
		{
			get;
			internal set;
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x00033F6C File Offset: 0x0003216C
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00033F80 File Offset: 0x00032180
		public Dictionary<uint, SqlItemCategorie> sqlItemCategories
		{
			get;
			internal set;
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x00033F94 File Offset: 0x00032194
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x00033FA8 File Offset: 0x000321A8
		public Dictionary<uint, SqlItem> sqlItems
		{
			get;
			internal set;
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x00033FBC File Offset: 0x000321BC
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x00033FD0 File Offset: 0x000321D0
		public Dictionary<uint, SqlItemGrade> sqlItemGrades
		{
			get;
			internal set;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00033FE4 File Offset: 0x000321E4
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x00033FF8 File Offset: 0x000321F8
		public Dictionary<uint, SqlWearable> sqlWearables
		{
			get;
			internal set;
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0003400C File Offset: 0x0003220C
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x00034020 File Offset: 0x00032220
		public Dictionary<uint, SqlWearableSlot> sqlWearableSlots
		{
			get;
			internal set;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00034034 File Offset: 0x00032234
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x00034048 File Offset: 0x00032248
		public Dictionary<uint, SqlHoldable> sqlHoldables
		{
			get;
			internal set;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0003405C File Offset: 0x0003225C
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00034070 File Offset: 0x00032270
		public Dictionary<uint, SqlEquipItemAttrModifier> sqlEquipItemAttrModifiers
		{
			get;
			internal set;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00034084 File Offset: 0x00032284
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x00034098 File Offset: 0x00032298
		public Dictionary<uint, SqlNpc> sqlNpcs
		{
			get;
			internal set;
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x000340AC File Offset: 0x000322AC
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x000340C0 File Offset: 0x000322C0
		public Dictionary<uint, SqlSkill> sqlSkills
		{
			get;
			internal set;
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x000340D4 File Offset: 0x000322D4
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x000340E8 File Offset: 0x000322E8
		public Dictionary<uint, SqlDoodadAlmighty> sqlDoodadAlmighties
		{
			get;
			internal set;
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x000340FC File Offset: 0x000322FC
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00034110 File Offset: 0x00032310
		public Dictionary<uint, SqlDoodadFuncGroup> sqlDoodadFuncGroups
		{
			get;
			internal set;
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00034124 File Offset: 0x00032324
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00034138 File Offset: 0x00032338
		public Dictionary<uint, SqlHousing> sqlHousings
		{
			get;
			internal set;
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0003414C File Offset: 0x0003234C
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00034160 File Offset: 0x00032360
		public Dictionary<uint, SqlTaggedSkill> sqlTaggedSkills
		{
			get;
			internal set;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00034174 File Offset: 0x00032374
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00034188 File Offset: 0x00032388
		public Dictionary<uint, SqlTaggedBuff> sqlTaggedBuffs
		{
			get;
			internal set;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0003419C File Offset: 0x0003239C
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x000341B0 File Offset: 0x000323B0
		public Dictionary<uint, SqlTaggedItem> sqlTaggedItems
		{
			get;
			internal set;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000341C4 File Offset: 0x000323C4
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x000341D8 File Offset: 0x000323D8
		public Dictionary<uint, SqlTaggedNpc> sqlTaggedNpcs
		{
			get;
			internal set;
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x000341EC File Offset: 0x000323EC
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00034200 File Offset: 0x00032400
		public Dictionary<uint, SqlEffect> sqlEffects
		{
			get;
			internal set;
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00034214 File Offset: 0x00032414
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00034228 File Offset: 0x00032428
		public Dictionary<uint, SqlSpecialEffect> sqlSpecialEffects
		{
			get;
			internal set;
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0003423C File Offset: 0x0003243C
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00034250 File Offset: 0x00032450
		public Dictionary<uint, SqlQuestContext> sqlQuestContexts
		{
			get;
			internal set;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00034264 File Offset: 0x00032464
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00034278 File Offset: 0x00032478
		public Dictionary<uint, SqlQuestComponent> sqlQuestComponents
		{
			get;
			internal set;
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0003428C File Offset: 0x0003248C
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x000342A0 File Offset: 0x000324A0
		public Dictionary<uint, SqlMerchantPack> sqlMerchantPacks
		{
			get;
			internal set;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x000342B4 File Offset: 0x000324B4
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x000342C8 File Offset: 0x000324C8
		public Dictionary<uint, SqlCraft> sqlCrafts
		{
			get;
			internal set;
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x000342DC File Offset: 0x000324DC
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x000342F0 File Offset: 0x000324F0
		public Dictionary<uint, SqlCraftPack> sqlCraftPacks
		{
			get;
			internal set;
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00034304 File Offset: 0x00032504
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00034318 File Offset: 0x00032518
		public Dictionary<uint, SqlDoodadFuncCraftPack> sqlDoodadFuncCraftPacks
		{
			get;
			internal set;
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x0003432C File Offset: 0x0003252C
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x00034340 File Offset: 0x00032540
		public Dictionary<uint, SqlActabilityGroup> sqlActabilityGroups
		{
			get;
			internal set;
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00034354 File Offset: 0x00032554
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00034368 File Offset: 0x00032568
		public Dictionary<uint, SqlActabilityCategorie> sqlActabilityCategories
		{
			get;
			internal set;
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0003437C File Offset: 0x0003257C
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x00034390 File Offset: 0x00032590
		public Dictionary<uint, SqlAuctionACategory> sqlAuctionACategories
		{
			get;
			internal set;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x000343A4 File Offset: 0x000325A4
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x000343B8 File Offset: 0x000325B8
		public Dictionary<uint, SqlAuctionBCategory> sqlAuctionBCategories
		{
			get;
			internal set;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000343CC File Offset: 0x000325CC
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x000343E0 File Offset: 0x000325E0
		public Dictionary<uint, SqlAuctionCCategory> sqlAuctionCCategories
		{
			get;
			internal set;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000343F4 File Offset: 0x000325F4
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00034408 File Offset: 0x00032608
		public Dictionary<uint, SqlLinearFunc> sqlLinearFuncs
		{
			get;
			internal set;
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0003441C File Offset: 0x0003261C
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00034430 File Offset: 0x00032630
		public Dictionary<uint, SqlSlave> sqlSlaves
		{
			get;
			internal set;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00034444 File Offset: 0x00032644
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00034458 File Offset: 0x00032658
		public Dictionary<uint, SqlBuffUnitModifier> sqlBuffUnitModifiers
		{
			get;
			internal set;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0003446C File Offset: 0x0003266C
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00034480 File Offset: 0x00032680
		public Dictionary<uint, SqlDoodadFuncPurchase> sqlDoodadFuncPurchases
		{
			get;
			internal set;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00034494 File Offset: 0x00032694
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x000344A8 File Offset: 0x000326A8
		public Dictionary<uint, SqlMountSkill> sqlMountSkills
		{
			get;
			internal set;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x000344BC File Offset: 0x000326BC
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x000344D0 File Offset: 0x000326D0
		public Dictionary<uint, SqlSkillReq> sqlSkillReqs
		{
			get;
			internal set;
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x000344E4 File Offset: 0x000326E4
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x000344F8 File Offset: 0x000326F8
		public Dictionary<uint, SqlActorModel> sqlActorModels
		{
			get;
			internal set;
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0003450C File Offset: 0x0003270C
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00034520 File Offset: 0x00032720
		public Dictionary<uint, SqlVehicleModel> sqlVehicleModels
		{
			get;
			internal set;
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00034534 File Offset: 0x00032734
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x00034548 File Offset: 0x00032748
		public Dictionary<uint, SqlModel> sqlModels
		{
			get;
			internal set;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0003455C File Offset: 0x0003275C
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00034570 File Offset: 0x00032770
		public Dictionary<uint, SqlModelAttachPointString> sqlModelAttachPointStrings
		{
			get;
			internal set;
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00034584 File Offset: 0x00032784
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00034598 File Offset: 0x00032798
		public Dictionary<uint, SqlQuestActConAcceptNpc> sqlQuestActConAcceptNpcs
		{
			get;
			internal set;
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x000345AC File Offset: 0x000327AC
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x000345C0 File Offset: 0x000327C0
		public Dictionary<uint, SqlQuestActConAcceptDoodad> sqlQuestActConAcceptDoodads
		{
			get;
			internal set;
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x000345D4 File Offset: 0x000327D4
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x000345E8 File Offset: 0x000327E8
		public Dictionary<uint, SqlQuestActConReportNpc> sqlQuestActConReportNpcs
		{
			get;
			internal set;
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x000345FC File Offset: 0x000327FC
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00034610 File Offset: 0x00032810
		public Dictionary<uint, SqlQuestActConReportDoodad> sqlQuestActConReportDoodads
		{
			get;
			internal set;
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00034624 File Offset: 0x00032824
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x00034638 File Offset: 0x00032838
		public Dictionary<uint, SqlQuestActConReportJournal> sqlQuestActConReportJournals
		{
			get;
			internal set;
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0003464C File Offset: 0x0003284C
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00034660 File Offset: 0x00032860
		public Dictionary<uint, SqlQuestActObjInteraction> sqlQuestActObjInteractions
		{
			get;
			internal set;
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00034674 File Offset: 0x00032874
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x00034688 File Offset: 0x00032888
		public Dictionary<uint, SqlQuestActObjTalk> sqlQuestActObjTalks
		{
			get;
			internal set;
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0003469C File Offset: 0x0003289C
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x000346B0 File Offset: 0x000328B0
		public Dictionary<uint, SqlQuestActSupplySelectiveItem> sqlQuestActSupplySelectiveItems
		{
			get;
			internal set;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x000346C4 File Offset: 0x000328C4
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x000346D8 File Offset: 0x000328D8
		public Dictionary<uint, SqlQuestActObjMonsterGroupHunt> sqlQuestActObjMonsterGroupHunts
		{
			get;
			internal set;
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x000346EC File Offset: 0x000328EC
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00034700 File Offset: 0x00032900
		public Dictionary<uint, SqlQuestActObjMonsterHunt> sqlQuestActObjMonsterHunts
		{
			get;
			internal set;
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00034714 File Offset: 0x00032914
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x00034728 File Offset: 0x00032928
		public Dictionary<uint, SqlQuestActObjItemGroupGather> sqlQuestActObjItemGroupGathers
		{
			get;
			internal set;
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0003473C File Offset: 0x0003293C
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x00034750 File Offset: 0x00032950
		public Dictionary<uint, SqlQuestActObjItemGather> sqlQuestActObjItemGathers
		{
			get;
			internal set;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00034764 File Offset: 0x00032964
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x00034778 File Offset: 0x00032978
		public Dictionary<uint, SqlDoodadFuncFakeUse> sqlDoodadFuncFakeUses
		{
			get;
			internal set;
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0003478C File Offset: 0x0003298C
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x000347A0 File Offset: 0x000329A0
		public Dictionary<uint, SqlPlotEffect> sqlPlotEffects
		{
			get;
			internal set;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x000347B4 File Offset: 0x000329B4
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x000347C8 File Offset: 0x000329C8
		public Dictionary<uint, SqlPlotEvent> sqlPlotEvents
		{
			get;
			internal set;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x000347DC File Offset: 0x000329DC
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x000347F0 File Offset: 0x000329F0
		public Dictionary<uint, SqlDoodadFuncRemoveItem> sqlDoodadFuncRemoveItems
		{
			get;
			internal set;
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00034804 File Offset: 0x00032A04
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x00034818 File Offset: 0x00032A18
		public Dictionary<uint, SqlDoodadFuncConditionalUse> sqlDoodadFuncConditionalUses
		{
			get;
			internal set;
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0003482C File Offset: 0x00032A2C
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x00034840 File Offset: 0x00032A40
		public Dictionary<uint, SqlEquipItemSet> sqlEquipItemSets
		{
			get;
			internal set;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00034854 File Offset: 0x00032A54
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x00034868 File Offset: 0x00032A68
		public List<SqlUnitFormulaVariable> sqlUnitFormulaVariables
		{
			get;
			internal set;
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0003487C File Offset: 0x00032A7C
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x00034890 File Offset: 0x00032A90
		public Dictionary<uint, SqlZoneGroup> sqlZoneGroups
		{
			get;
			internal set;
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000348A4 File Offset: 0x00032AA4
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x000348B8 File Offset: 0x00032AB8
		public Dictionary<uint, SqlZone> sqlZones
		{
			get;
			internal set;
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000348CC File Offset: 0x00032ACC
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000348E0 File Offset: 0x00032AE0
		public Dictionary<uint, SqlSubZone> sqlSubZones
		{
			get;
			internal set;
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000348F4 File Offset: 0x00032AF4
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x00034908 File Offset: 0x00032B08
		public List<SqlZoneClimateElem> sqlZoneClimateElems
		{
			get;
			internal set;
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0003491C File Offset: 0x00032B1C
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00034930 File Offset: 0x00032B30
		public Dictionary<uint, SqlLevel> sqlLevels
		{
			get;
			internal set;
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00034944 File Offset: 0x00032B44
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x00034958 File Offset: 0x00032B58
		public List<SqlDefaultSkill> sqlDefaultSkills
		{
			get;
			internal set;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0003496C File Offset: 0x00032B6C
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00034980 File Offset: 0x00032B80
		public List<SqlCharacterBuff> sqlCharacterBuffs
		{
			get;
			internal set;
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00034994 File Offset: 0x00032B94
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x000349A8 File Offset: 0x00032BA8
		public Dictionary<uint, SqlCharacter> sqlCharacters
		{
			get;
			internal set;
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x000349BC File Offset: 0x00032BBC
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x000349D0 File Offset: 0x00032BD0
		public Dictionary<uint, SqlExpertLimit> sqlExpertLimits
		{
			get;
			internal set;
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x000349E4 File Offset: 0x00032BE4
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x000349F8 File Offset: 0x00032BF8
		public Dictionary<uint, SqlScheduleItem> sqlScheduleItems
		{
			get;
			internal set;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00034A0C File Offset: 0x00032C0C
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x00034A20 File Offset: 0x00032C20
		public Dictionary<uint, SqlAppellation> sqlAppellations
		{
			get;
			internal set;
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00034A34 File Offset: 0x00032C34
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00034A48 File Offset: 0x00032C48
		public SqlAbility[] sqlAbilitys
		{
			get;
			internal set;
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00034A5C File Offset: 0x00032C5C
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00034A70 File Offset: 0x00032C70
		internal bool dbLoaded
		{
			get;
			set;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00034A84 File Offset: 0x00032C84
		private string c3e19e38c76e1baf872a467e05351851d()
		{
			return c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128211);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00034AA0 File Offset: 0x00032CA0
		internal void c0b26450d579928ddc2ba39eac2096a8c()
		{
			try
			{
				this.c08741229bc1a47e957d16328be2841ff();
			}
			catch (Exception ex)
			{
				c2e5e290c5e34f024145fe136ad4da993.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128250), ex));
				cdd6e82cc82d0907870bcea6f8d892056.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10204));
				c09f6fadac8a71c045c787a2424b5e800.c30767ddca1f9c207888833aea5b5fc61(c83cfe3bd000aa92222187ba144960d00.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			}
			finally
			{
				c2b9798ea3504503baef6ebec31a44acb.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b);
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(this.c3e76590440c7f603f07fda2f71aada9b);
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00034B24 File Offset: 0x00032D24
		internal static string c6719f5b2ea2416ec86b0b92dc870ad7a(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(object)).MethodHandle;
				}
				return "";
			}
			string result;
			try
			{
				result = c5bdadb216ff81200f68025e2298d040e.c9963fcf210a214a3206d6500f3b9397b(obj);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128319), ex));
				result = "";
			}
			return result;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00034B90 File Offset: 0x00032D90
		internal static sbyte cab0e03f3a874c26876bb7a3b4d40d163(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.cab0e03f3a874c26876bb7a3b4d40d163(object)).MethodHandle;
				}
				return (sbyte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10208);
			}
			sbyte result;
			try
			{
				result = (sbyte)ca380f926d2888bc2492e5a86406ab62e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128396), ex));
				result = (sbyte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10212);
			}
			return result;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00034C08 File Offset: 0x00032E08
		internal static byte cb5b0d92e670db20df60836286adf42c5(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.cb5b0d92e670db20df60836286adf42c5(object)).MethodHandle;
				}
				return (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10216);
			}
			byte result;
			try
			{
				result = (byte)ca380f926d2888bc2492e5a86406ab62e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128473), ex));
				result = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10220);
			}
			return result;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00034C80 File Offset: 0x00032E80
		internal static uint cabc941092d707a13e497448248cd9bce(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.cabc941092d707a13e497448248cd9bce(object)).MethodHandle;
				}
				return (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10224);
			}
			uint result;
			try
			{
				if (ca380f926d2888bc2492e5a86406ab62e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj) > c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10228))
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
					result = c419245116ad98577a21c259e69a483c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
				}
				else
				{
					result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10232);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128550), ex));
				result = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10236);
			}
			return result;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00034D24 File Offset: 0x00032F24
		internal static int ca27f2bc123658aee801ff6301b99beef(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.ca27f2bc123658aee801ff6301b99beef(object)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10240);
			}
			int result;
			try
			{
				result = ca380f926d2888bc2492e5a86406ab62e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128627), ex));
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10244);
			}
			return result;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00034D9C File Offset: 0x00032F9C
		internal static long cbb7abf924087b4fc4ab344f9dfdf9526(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.cbb7abf924087b4fc4ab344f9dfdf9526(object)).MethodHandle;
				}
				return (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10248);
			}
			long result;
			try
			{
				result = c1c66623b6e4c72e5fe16233e3b16eb15.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128704), ex));
				result = (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10252);
			}
			return result;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00034E14 File Offset: 0x00033014
		internal static double c5df5c2fd7ffeabdf61a81e0ae1a83a1f(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(object)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(10256);
			}
			double result;
			try
			{
				result = c5f07926c97f6aa97ea3be8c21560421b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128781), ex));
				result = c4929ffb646fb9ba9deb5f553efe8c57b.c4fafdd186626774c53f349c01980872a(10264);
			}
			return result;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00034E90 File Offset: 0x00033090
		internal bool c6d416453576edeb5213c93148568a4f1(object obj)
		{
			if (obj == DBNull.Value)
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
					RuntimeMethodHandle arg_1A_0 = methodof(SqlCore.c6d416453576edeb5213c93148568a4f1(object)).MethodHandle;
				}
				return c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10272) != 0;
			}
			bool result;
			try
			{
				long num = c1c66623b6e4c72e5fe16233e3b16eb15.c0cf59c3e67a46fd4edb3040c5ab0bbfb(obj);
				if (num <= (long)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10276))
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
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10280) != 0);
				}
				else
				{
					result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10284) != 0);
				}
			}
			catch (Exception ex)
			{
				cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cb120ea307928c46886d04fa524b370cc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128858), ex));
				result = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10288) != 0);
			}
			return result;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00034F38 File Offset: 0x00033138
		private void c08741229bc1a47e957d16328be2841ff()
		{
			long num = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede();
			this.cfaf1a0bf3f16e8623c09a1bb5c1ec22a();
			this.c1a3f6d8536c7d3d1c0cc7ae14832676b();
			this.c5f2961239acfe0df1c21e12102ff5052();
			this.c945104e5c78577796dcd726e400acdea();
			this.ca61383b4d35a8fc54c5db4c834044754();
			this.c7fe8be6d023c3103c096c401c6611ae9();
			this.c2599f249c63ca6b92380683b7634563c();
			this.cd9aa9527ab367e603d190bc5d6d8b041();
			this.c93df1af1daf331daf2878c233e64c426();
			this.cccaac1051e1e15e8799a74b1c6e333be();
			this.cabf2c9960d89049997cd888f51e4edc1();
			this.c0cd0f29546835372f487f8d4739c4551();
			this.c8cdc0ef585308c183674d610394707fa();
			this.ca3c2d37b5719d8cbce7febf38cd374e6();
			this.c4b2567dd401752d242f592b5ba04a062();
			this.cba4bff6735c08ea4efb4466fd4da4362();
			this.cb20ba848b882613aa52cd7e6ba702a71();
			this.cf7aeeb7f248e725f4ebbc79c3a360f01();
			this.c168270f988421728a4459b1954b6d626();
			this.c1ac2a656e65ff34615bbbfd5d2c70c4a();
			this.ce232104137d3d9a069b3dadc0ab52255();
			this.cf7ae3d1df8ea6a8791c4558e9145f20b();
			this.c18680d45c96aba74b688bde9020efe6d();
			this.c28020710f84265b36f2ffdaacb40ec1c();
			this.c31e9eb97ddabb72f372058506b6d6166();
			this.c21be4cf9a50bdc47ffa3adc9653acb52();
			this.ceeb6686433c34fedbc003a463a3c2186();
			this.c016280797bffb5b36edf91e5a34edbd1();
			this.ca42092bff9417673129939652e22f59a();
			this.ce46153a83cd9327eb8181984ef8a73a4();
			this.ce1248882ca9d496d04aeecb7c1335722();
			this.ca5cd052fed73fe48e6ddb273cea60826();
			this.cede1675f076014f634ff7471672402c9();
			this.c6f42c7fefe77f467144f19e93b336722();
			this.c118eaf98e37434c481129042e6aab90a();
			this.c6f94d6c418f4f6aac6b176d89dc9793e();
			this.cafb7c16e2c6781241da38bf555bbba06();
			this.c321859fcea417e64549916f0143466bc();
			this.c6cb7d2b090f3cf982a9474f5367be0d7();
			this.c71ec101b131b89411abcbc77b9469a63();
			this.cdc58bd4911d8fdbf5d2c31bd23757046();
			this.c252f855fc13dabf0aa6f39d44752c50a();
			this.c8bdc5035c1e58f744d8f3ca5cfd4311b();
			this.cf29b0029d3166d3b7f09fbca4316dc77();
			this.c76ed9a074f4c9bfffbf71e703c82732a();
			this.c326ffa42d262f57da53964ed5100e013();
			this.c499057504477d2b9ca610d0a3a69a1dd();
			this.c8f321a05e6cc03f0b89c349dc4a88121();
			this.ce9de03318b2ec9857212c4788abf5f06();
			this.c0ab6ce466aedd9b77b1061f9b551b419();
			this.cdf55f915fd3e76bdba1372f39e385eb5();
			this.cca945eb7a81eca398427d25b413b01c2();
			this.cc2719ef738d5f7f0a999ab5449b85a61();
			this.c31ec6b75b81eb67a5ae4b9ff89c22e33();
			this.c4e632b37eada736725df158fa4723ac0();
			this.c9ae7faf6e6d471151ba4e0c55f33aba0();
			this.ce8c0a42c49c8fe0549ffd4f3870e73fe();
			this.cc04b1c03860e1fb85600102847ad89a5();
			this.c65f3bd21eac3f9c600d2cb7522a21631();
			this.cb696f94fb3b34cb2524f1ced386de07b();
			this.c28cc401823f1ae25a278e52dcd7c70c9();
			this.c09d43146746550a032ea3d692ce2b4f4();
			this.cb7ec7d03a33ec416b593fa672aa78f56();
			this.c311a14cb267305d4933c93655f55b306();
			this.ceea219e21b43a9f1fb5bbc312577cb39();
			this.ca20664865c435d61d21019921c56548f();
			this.ce30f5732be5cbde79c722563b9be5d62();
			this.c84404d43401634e4149a5462c03a3835();
			this.c9e1a5b5f30463abde704f48bc7bcc08b();
			this.c5e7bbc660fb5ec59b943e71d04efb29c();
			this.ce11c2b640fedb3b90035c2762feeede2();
			this.cd77b022766d7e0d1eb8478f7c93100c9();
			this.c1ab7063b021b8affdabcc6e63050c8ba();
			this.c1dc56d9b9528c32a3a53f8114a36a4d7();
			this.c8144886dff3be57df80c8571871cacdd();
			this.cf08e6aef18e237726f7fc92f7fb19727();
			this.c6efb3a986542da70201083c9e9e23bd2();
			this.c8503c662fdc34b8a7c8e7f75d36eb173();
			this.c850535567fd1e2f94bb9881c7ac62883();
			this.cf7f498ee9f69e218c97b37b5f78444ba();
			this.c788c8d44dd3c9a859c13a226cfeec27f();
			this.cd9af846a78bcb7a6a2e803eea9f68d4f();
			this.c116e780cf5cf5bcc0ea9773e429248f0();
			this.cc4259237aa03aa43c6e606cd63209036();
			this.c9a9b9b37bd73e8bb6d77c6a36545a847();
			this.c4341d452d3546c4e1b04674ebce1eba8();
			this.c7062b5fa5070bd7070d5906fb3679052();
			this.c9310f2bc5c837b7329f8d5a09d9d3503();
			this.c523b1931eb9925c6ffab27975150c2bc();
			this.cd853460db1e9f7ab8e69745d35b9b40b();
			this.c226502a4c4031ac7bccb87b4fa1de75c();
			this.c027c0656eccfa31b1e693ee492a85fa1();
			this.cb9de3ec67a00893543b16313f0a66588();
			this.c708e6dc84eaf4a9a970641eeeb271127();
			this.cd81c56f4ea8044abb06f935da5f25e00();
			this.c37afdfc4e67b45b5f202f77b25ea3d8b();
			this.cf77f4b15ee1869eceff1c6651bea8083();
			this.c373b32e1703eba782fa1132a61d9d5f9();
			this.c0d41c118d13cecb892d088eee011c5d4();
			this.c26ca1c0c6c99ec5d4f246f445009268c();
			this.c7032c9767a7a964264b0be47d9507aa0();
			this.ceea1c5bd3da440f626650a08a11f2c80();
			this.cc58ed1e59c8e429c5905692da86340d3();
			this.c503853c7bfd6265a4fac66b42851a2a8();
			this.c8aab66b3c1c97f2c52caed77c38cb288();
			this.c767f865e19b1f99366e1f689367a5147();
			this.ce49cdc2c2ade65cdb7bab971f4d9ea75();
			long num2 = cc4987d6a853db77954f21abe4e42946a.c270f7259dc6c7e6d1950062475294ede() - num;
			cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cd1a6c92a54a6236568e6a1d4a42f598d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(128935), num2, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129012)));
			c2f85881516f7f5a1167506b2e505d817.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10292) != 0);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00035214 File Offset: 0x00033414
		private void c8aab66b3c1c97f2c52caed77c38cb288()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129089));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10296));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10300)));
							float num2 = (float)SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10304)));
							float num3 = (float)SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10308)));
							float num4 = (float)SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10312)));
							if (c129fb2f83ee1580675b039b954aeeaec.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_F7_0 = methodof(SqlCore.c8aab66b3c1c97f2c52caed77c38cb288()).MethodHandle;
								}
								c12ad849a5fec158edc22a332b2b675bf.c30767ddca1f9c207888833aea5b5fc61(c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num).spawnPoints, c2c5c31a0359ccdc376ba68cdaca8311c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2, num3, num4));
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
								switch (4)
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000353F0 File Offset: 0x000335F0
		private void c503853c7bfd6265a4fac66b42851a2a8()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129168));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10316));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10320)));
							float num2 = (float)SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10324)));
							float num3 = (float)SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10328)));
							float num4 = (float)SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10332)));
							if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_F7_0 = methodof(SqlCore.c503853c7bfd6265a4fac66b42851a2a8()).MethodHandle;
								}
								c12ad849a5fec158edc22a332b2b675bf.c30767ddca1f9c207888833aea5b5fc61(cb4ee9a6c204f25ba6806adc6519e99a2.c30767ddca1f9c207888833aea5b5fc61(c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), c2c5c31a0359ccdc376ba68cdaca8311c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(num2, num3, num4));
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000355CC File Offset: 0x000337CC
		private void c0d41c118d13cecb892d088eee011c5d4()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129241));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10336));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10340)));
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10344)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10348)));
							if (c1ce894679fdaea350d6e31244cf4ed36.c30767ddca1f9c207888833aea5b5fc61(c0d2845495da243309c098e3a4ccdd3a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_D4_0 = methodof(SqlCore.c0d41c118d13cecb892d088eee011c5d4()).MethodHandle;
								}
								if (c1ce894679fdaea350d6e31244cf4ed36.c30767ddca1f9c207888833aea5b5fc61(c0d2845495da243309c098e3a4ccdd3a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									cc2912007ef1076280a9fd23a682d854f.c30767ddca1f9c207888833aea5b5fc61(c43b480edcf24f6ec73d739850d4e7f50.c30767ddca1f9c207888833aea5b5fc61(cc31153654c4d50ab0bdb4a611fbcf574.c30767ddca1f9c207888833aea5b5fc61(c0d2845495da243309c098e3a4ccdd3a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), cc31153654c4d50ab0bdb4a611fbcf574.c30767ddca1f9c207888833aea5b5fc61(c0d2845495da243309c098e3a4ccdd3a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
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
					finally
					{
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000357A4 File Offset: 0x000339A4
		private void c373b32e1703eba782fa1132a61d9d5f9()
		{
			c7b605a0dfd08c1b2a100c71ed2f86b69.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c6fb1c842d684537279001aa886bd47ca.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129354));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10352));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10356)));
							SqlPlotEvent sqlPlotEvent = c670cef2d8d46f28e073f6b9615859902.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c9fcbdc1f39d5252c985e320588e4aa17.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEvent, num);
							cbc813a84c2bcca5cbb937b5ce102838c.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEvent, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10360))));
							c73da3d213ac4daa888cb5ad65c3b7fc6.c30767ddca1f9c207888833aea5b5fc61(c0d2845495da243309c098e3a4ccdd3a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlPlotEvent);
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
							RuntimeMethodHandle arg_DF_0 = methodof(SqlCore.c373b32e1703eba782fa1132a61d9d5f9()).MethodHandle;
						}
					}
					finally
					{
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x06000795 RID: 1941 RVA: 0x00035900 File Offset: 0x00033B00
		private void c26ca1c0c6c99ec5d4f246f445009268c()
		{
			c7c4fd05d9c6006a4800875fd806368b8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c8c0ecff000d7a3554707697bba0dc306.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129425));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10364));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10368)));
							SqlPlotEffect sqlPlotEffect = c9d12de21add9e5c97b75d9a7f0ae1f0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c652fc9ad6d399689639859a8ea9a68a2.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect, num);
							c558e40741200209f3ac6804645105073.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10372))));
							c27b391ad357e5a46e0af06ccabe960c0.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10376))));
							c97e3bb1a06d752dcd2ce750e29332d23.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10380))));
							ce283de5a858a28ccd403ae4892207288.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10384))));
							string text;
							if ((text = c3cb21e5058f53b398a5e1babaf7092b1.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect)) != null)
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
									RuntimeMethodHandle arg_140_0 = methodof(SqlCore.c26ca1c0c6c99ec5d4f246f445009268c()).MethodHandle;
								}
								if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129569)))
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
									if (c1ce894679fdaea350d6e31244cf4ed36.c30767ddca1f9c207888833aea5b5fc61(c0d2845495da243309c098e3a4ccdd3a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c244c1d4762e81111cc543532efbf1121.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect)))
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
										if (c19f6924bdf49b69f20f47d1e9161d047.c30767ddca1f9c207888833aea5b5fc61(ca917d27144d9276d7eb9bd40724a3176.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c506745d87f423701aa77e57ca46bedd0.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect)))
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
											c5883c10000912113bea6c66f98fd72ae.c30767ddca1f9c207888833aea5b5fc61(c0b8e3c33b25977b37bf20a94a9a224c0.c30767ddca1f9c207888833aea5b5fc61(cc31153654c4d50ab0bdb4a611fbcf574.c30767ddca1f9c207888833aea5b5fc61(c0d2845495da243309c098e3a4ccdd3a5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c244c1d4762e81111cc543532efbf1121.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect))), c18816fbcb1daec27bc6ccc39986a75fe.c30767ddca1f9c207888833aea5b5fc61(ca917d27144d9276d7eb9bd40724a3176.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c506745d87f423701aa77e57ca46bedd0.c30767ddca1f9c207888833aea5b5fc61(sqlPlotEffect)));
										}
									}
								}
							}
							c9b22f578a16111ee02703497da47000a.c30767ddca1f9c207888833aea5b5fc61(c3ab0786b3649a98ec47184e0947b9fd1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlPlotEffect);
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00035BB0 File Offset: 0x00033DB0
		private void cf77f4b15ee1869eceff1c6651bea8083()
		{
			c9c43573088596514cdc44c645a548943.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca7c58dc2bf05364ca988edc67fb205fd.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129596));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10388));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10392)));
							SqlQuestActObjMonsterGroupHunt sqlQuestActObjMonsterGroupHunt = cf9126ce68790eaed71e21c2b2c7b282c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c0aa703f6739a2be724409738e8ee212d.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjMonsterGroupHunt, num);
							ccdbc6c5bd85f6799a60afa08ec621f09.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjMonsterGroupHunt, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10396))));
							c0f41f331eaf3c6df2e4c77c28ce178da.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjMonsterGroupHunt, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10400))));
							c00bca964a1231420795911b2340913f1.c30767ddca1f9c207888833aea5b5fc61(c6495ea30c06e42742d055ed5ce2538da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActObjMonsterGroupHunt);
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
						if (!true)
						{
							RuntimeMethodHandle arg_109_0 = methodof(SqlCore.cf77f4b15ee1869eceff1c6651bea8083()).MethodHandle;
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x06000797 RID: 1943 RVA: 0x00035D5C File Offset: 0x00033F5C
		private void c37afdfc4e67b45b5f202f77b25ea3d8b()
		{
			c0201dd2eacc961f4c031565b5f1d1e4e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cba23f6e19c31a3295926489f79dcd55b.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129756));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10404));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10408)));
							SqlQuestActObjMonsterHunt sqlQuestActObjMonsterHunt = c378e31fd686722499c9a4dffc2387bae.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							ce22e95393ce5802aea26c5a671e0dfe9.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjMonsterHunt, num);
							c7b345ca63be35ac9ff7722069a1ff107.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjMonsterHunt, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10412))));
							ccc9b92cfd9d4272c9ef4a005d95c45c5.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjMonsterHunt, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10416))));
							c657ee72f4a7ac25e5d5c40bfb43c5f84.c30767ddca1f9c207888833aea5b5fc61(cb33dd0ae895d5ba6359f020d745a32d9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActObjMonsterHunt);
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
							RuntimeMethodHandle arg_109_0 = methodof(SqlCore.c37afdfc4e67b45b5f202f77b25ea3d8b()).MethodHandle;
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00035F08 File Offset: 0x00034108
		private void cd81c56f4ea8044abb06f935da5f25e00()
		{
			c5a835eb2e73a011daf08a988f72d7ee9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c3ee497851d1d25d0510bcbae0f783f61.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129871));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10420));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10424)));
							SqlQuestActObjItemGroupGather sqlQuestActObjItemGroupGather = c21c22b981580dd42b8d3514062d60e84.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							ca213e8bf0a4e47eafcb6ae0854e497b1.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjItemGroupGather, num);
							ccff7fe395c2f807cc6bb8e34c9feb2d5.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjItemGroupGather, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10428))));
							c81d2ac9de8608305200f25ed882074d6.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjItemGroupGather, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10432))));
							ca34e51f5b5a78a99e7d793be7d57121d.c30767ddca1f9c207888833aea5b5fc61(c637d387120c6dc5381559601ac59dade.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActObjItemGroupGather);
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
							RuntimeMethodHandle arg_109_0 = methodof(SqlCore.cd81c56f4ea8044abb06f935da5f25e00()).MethodHandle;
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000360B4 File Offset: 0x000342B4
		private void c708e6dc84eaf4a9a970641eeeb271127()
		{
			ccf6c28cb1f8d11af07b7f8d4f0817c1f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c2e08a9f669c9c6501b16fb0d26b38ecb.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130011));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10436));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10440)));
							SqlQuestActObjItemGather sqlQuestActObjItemGather = c94caba6ffd42d59247a689e75f7dc792.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c18cf6dbde59de0d65d92e79b51099359.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjItemGather, num);
							c8686b81a99d81a4d7e6e3d2c0d98df66.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjItemGather, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10444))));
							cd7f398a6ab790d73673cb92c36dc66d9.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjItemGather, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10448))));
							c1c39c47a58e4c64365a9fb3a0ab9153b.c30767ddca1f9c207888833aea5b5fc61(cda1406db2ad7090baa534816d1dec0c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActObjItemGather);
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
							RuntimeMethodHandle arg_109_0 = methodof(SqlCore.c708e6dc84eaf4a9a970641eeeb271127()).MethodHandle;
						}
					}
					finally
					{
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00036260 File Offset: 0x00034460
		private void cb9de3ec67a00893543b16313f0a66588()
		{
			c59c1840670d988b1d4336b5403d22875.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cebfe84dda3a743930f0e63e052c3d014.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130126));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10452));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10456)));
							SqlQuestActSupplySelectiveItem sqlQuestActSupplySelectiveItem = c3a2f5ce77a34f0c6f074ea46dadfcbd4.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c3f5e572379af5e223880e08d913cd1c2.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActSupplySelectiveItem, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10460)));
							if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.cb9de3ec67a00893543b16313f0a66588()).MethodHandle;
								}
								cabf78eba5a532147056302489386163a.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActSupplySelectiveItem, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							c03a13c487ab66b652836c131e3ad1bf1.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActSupplySelectiveItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10464))));
							cbdc9bcdf21361cc3e5d7319513372095.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActSupplySelectiveItem, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10468))));
							c98c3215e2e30f53f4da78bf387cf6646.c30767ddca1f9c207888833aea5b5fc61(cad44d877db2020fc17fa32d82227a9ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActSupplySelectiveItem);
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0003645C File Offset: 0x0003465C
		private void cd853460db1e9f7ab8e69745d35b9b40b()
		{
			cac98db5501a84f5d3865364a80cd2ae8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cfee7f25b591848e6f16500db6e5e2de0.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130274));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10472));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10476)));
							SqlQuestActConReportDoodad sqlQuestActConReportDoodad = c365e46ce94ce537f282dd55e0f707b9a.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c14fd869a77e75d7541f7c98e0271c366.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConReportDoodad, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10480)));
							if (c129fb2f83ee1580675b039b954aeeaec.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.cd853460db1e9f7ab8e69745d35b9b40b()).MethodHandle;
								}
								cddd1961c50fea906b23a291a2d15255f.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConReportDoodad, c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							c811ee72d646cc6014ee133c45f23a3cd.c30767ddca1f9c207888833aea5b5fc61(c5ec93290892d970bb75cda0c55333b00.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActConReportDoodad);
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00036610 File Offset: 0x00034810
		private void c7062b5fa5070bd7070d5906fb3679052()
		{
			c11e9a07a3c0d0643eaef369970916b01.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c3b9db45845138c0fa5057146eca83846.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130383));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10484));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10488)));
							SqlQuestActConAcceptDoodad sqlQuestActConAcceptDoodad = c546412a6f846ae5d91425be6dd69f8a2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c62917e9ed3457880134547699ae8039f.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConAcceptDoodad, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10492)));
							if (c129fb2f83ee1580675b039b954aeeaec.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.c7062b5fa5070bd7070d5906fb3679052()).MethodHandle;
								}
								cde1db573022f469cb0add9ea9cc6affb.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConAcceptDoodad, c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							cc913be3d59cb668d30626846b6a303d8.c30767ddca1f9c207888833aea5b5fc61(cf704952060b8b993a3aee9409101bf55.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActConAcceptDoodad);
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x000367C4 File Offset: 0x000349C4
		private void c9310f2bc5c837b7329f8d5a09d9d3503()
		{
			c7e726db368aa797f5d8a5ce1c7e26b60.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c8b4a5608a54232a680bda30b33b3aed8.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130492));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10496));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10500)));
							SqlQuestActConReportJournal sqlQuestActConReportJournal = ce572613498c7b3116ca68a730cf7d256.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c325f32ea5b97302df1efcfe3898f6528.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConReportJournal, num);
							c971dc9280e35f5d6ceed3e4772d5613c.c30767ddca1f9c207888833aea5b5fc61(c7d80476c78f8612fccda79c812bcd9aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActConReportJournal);
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
							RuntimeMethodHandle arg_BB_0 = methodof(SqlCore.c9310f2bc5c837b7329f8d5a09d9d3503()).MethodHandle;
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x0600079E RID: 1950 RVA: 0x000368FC File Offset: 0x00034AFC
		private void ce30f5732be5cbde79c722563b9be5d62()
		{
			c90e4e0e6a8db4fc1bf206698cdcfd8b6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc509436ddd245ddfc6772db634a9b859.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130581));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10504));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10508)));
							SqlDoodadFuncRemoveItem sqlDoodadFuncRemoveItem = c647b723c230a5f90ce40c7e53dd9cf09.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c9d87c2af7823159620758a0a02e89c6b.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncRemoveItem, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10512)));
							if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.ce30f5732be5cbde79c722563b9be5d62()).MethodHandle;
								}
								c059ec01a47bc66ce8b21bfc458875104.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncRemoveItem, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							cdd45c670de21e2b22323c9cbd545d09d.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncRemoveItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10516))));
							ccabd7a7bb677717cd6540d2de9490e99.c30767ddca1f9c207888833aea5b5fc61(ca530a34685cdcc17f52ff79fd623d328.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlDoodadFuncRemoveItem);
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x0600079F RID: 1951 RVA: 0x00036AD4 File Offset: 0x00034CD4
		private void ca20664865c435d61d21019921c56548f()
		{
			c5c9130303ff8c9dd34ea9d9401843895.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c753c21e391136e0bbf4a15d629df289f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130692));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10520));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10524)));
							SqlDoodadFuncConditionalUse sqlDoodadFuncConditionalUse = c3285f352fbf031ab789c8c3705f803e5.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c0287a976c6a7abe2d715cad41920ca5a.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncConditionalUse, num);
							c82b23f3b4c6bdca61b17167e592b12e8.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncConditionalUse, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10528))));
							c4aba848ca940b5c94962d05a4f202c30.c30767ddca1f9c207888833aea5b5fc61(cd3c572ef60c136561410d73a95695a0a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlDoodadFuncConditionalUse);
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
							RuntimeMethodHandle arg_DF_0 = methodof(SqlCore.ca20664865c435d61d21019921c56548f()).MethodHandle;
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007A0 RID: 1952 RVA: 0x00036C30 File Offset: 0x00034E30
		private void ceea219e21b43a9f1fb5bbc312577cb39()
		{
			cd09474fb827cab29b845db0f154669f9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cbc4b3a919e4307cd9200c0f225cb7012.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130809));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10532));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10536)));
							SqlDoodadFuncFakeUse sqlDoodadFuncFakeUse = cfcd5705d05fb7dd58ff6af7a5c37c95e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c9f2df3c6f03f8e527abcb16882b6baf4.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncFakeUse, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10540)));
							if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.ceea219e21b43a9f1fb5bbc312577cb39()).MethodHandle;
								}
								c3d87d2fbbe3db6059487a49f83710112.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncFakeUse, cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							c356fda7210d99f00f954e412ec6c0f3d.c30767ddca1f9c207888833aea5b5fc61(cf035c48f776231f87e8c67f609bc707e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlDoodadFuncFakeUse);
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00036DE4 File Offset: 0x00034FE4
		private void cc58ed1e59c8e429c5905692da86340d3()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(130912));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10544));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10548)));
							SqlSpecialtyBundle sqlSpecialtyBundle = c53bf2cd3bdf7ae1fe62a52cdb1202360.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							cf885d26e42c102bffafdea2f4513bc3f.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialtyBundle, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10552))));
							c298bec808fd9d4afdac016cf41f25374.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialtyBundle, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10556))));
							cf2f84018d363745892af728564fb8695.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialtyBundle, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10560))));
							if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_10A_0 = methodof(SqlCore.cc58ed1e59c8e429c5905692da86340d3()).MethodHandle;
								}
								ced0a7bdc4737489c64a755f2e2270e49.c30767ddca1f9c207888833aea5b5fc61(c4873b79f9d2e72c9d78e0e1146863275.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), sqlSpecialtyBundle);
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00036FC8 File Offset: 0x000351C8
		private void ceea1c5bd3da440f626650a08a11f2c80()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131070));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10564));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10568)));
							if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_91_0 = methodof(SqlCore.ceea1c5bd3da440f626650a08a11f2c80()).MethodHandle;
								}
								c805313a7375038154b8b0e39f29acc24.c30767ddca1f9c207888833aea5b5fc61(c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10572))));
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
					finally
					{
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007A3 RID: 1955 RVA: 0x00037148 File Offset: 0x00035348
		private void c7032c9767a7a964264b0be47d9507aa0()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131179));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10576));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10580)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10584)));
							if (c15e298690915be3761770153071e2761.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_B8_0 = methodof(SqlCore.c7032c9767a7a964264b0be47d9507aa0()).MethodHandle;
								}
								uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10588)));
								string text = SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10592)));
								string text2;
								if ((text2 = text) != null)
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
									if (cecebbe15a82731eb2f8453f1b7665d70.c09b0b0a9d1ddc5f8682426c324989d1d == null)
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
										Dictionary<string, int> expr_133 = c86b56ee89508e7b301b192aa299336a6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10596));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131335), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10600));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131376), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10604));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131423), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10608));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131464), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10612));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131511), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10616));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131560), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10620));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131607), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10624));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131662), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10628));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131707), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10632));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131762), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10636));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131805), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10640));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131858), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10644));
										c5c065556997a707553a401882eaeaa5a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_133, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131903), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10648));
										cecebbe15a82731eb2f8453f1b7665d70.c09b0b0a9d1ddc5f8682426c324989d1d = expr_133;
									}
									int num4;
									if (ccd0d262c9a2ebe3df465ec08958cadeb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cecebbe15a82731eb2f8453f1b7665d70.c09b0b0a9d1ddc5f8682426c324989d1d, text2, ref num4))
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
										switch (num4)
										{
										case 0:
											if (c2f1f7c060174e96578b5f26404fb87b5.c30767ddca1f9c207888833aea5b5fc61(cfdb7fe5327f837a94a0bac2e5678e331.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												c98add4001010a82b7656274fb36e202f.c30767ddca1f9c207888833aea5b5fc61(c3f774c803ebabd23d634080839b20541.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c505a7328b969e180439b256931077ef4.c30767ddca1f9c207888833aea5b5fc61(cfdb7fe5327f837a94a0bac2e5678e331.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 1:
											if (cc6a629cc3aeecb800430d7981927989b.c30767ddca1f9c207888833aea5b5fc61(cf704952060b8b993a3aee9409101bf55.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												cb10b11258dc86e98440bc3708b20bfcb.c30767ddca1f9c207888833aea5b5fc61(c84c02475d0f9e447e3c06b44c5d7c9d6.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cce2b75ec77300040b41040aa0ff03d1b.c30767ddca1f9c207888833aea5b5fc61(cf704952060b8b993a3aee9409101bf55.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 2:
											if (cfdd0316e25629486ed1073699bf3ba85.c30767ddca1f9c207888833aea5b5fc61(c215ba3b9622d956775be3b4a5119a345.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												c4c6fa0b1212503c449571bc21b5aac0d.c30767ddca1f9c207888833aea5b5fc61(c3e75f4c330cc4a2cae471b865d048cc9.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c4f33610a6067c4ad39b8bbc91d59443d.c30767ddca1f9c207888833aea5b5fc61(c215ba3b9622d956775be3b4a5119a345.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 3:
											if (c0d2da68cb777e501239148becb5fac2a.c30767ddca1f9c207888833aea5b5fc61(c5ec93290892d970bb75cda0c55333b00.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												c88ee0b79f86dfd4eeb088308072bebf0.c30767ddca1f9c207888833aea5b5fc61(c1931999764883cafe2b4d2e1cb08cd98.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), ca86b4cde52f0f4f977bfce28d1d62594.c30767ddca1f9c207888833aea5b5fc61(c5ec93290892d970bb75cda0c55333b00.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 4:
											cce875052afcb9728d983850df47bb7ed.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10652) != 0);
											break;
										case 5:
											cce875052afcb9728d983850df47bb7ed.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10656) != 0);
											break;
										case 6:
											if (c1383b020379b0b3111c518638b0028e8.c30767ddca1f9c207888833aea5b5fc61(cad44d877db2020fc17fa32d82227a9ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												c7827077e9e70ad59668650cf514177ff.c30767ddca1f9c207888833aea5b5fc61(c00c835344ee673484ee6125704f0bc75.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cb69c77857adf5ad61e72fbbe983fd31b.c30767ddca1f9c207888833aea5b5fc61(cad44d877db2020fc17fa32d82227a9ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 7:
											if (c98623c64a8ccb10e65bb8a6f615cc661.c30767ddca1f9c207888833aea5b5fc61(cb33dd0ae895d5ba6359f020d745a32d9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												c77815a51bdae11e8f8484f59f2c5e1d2.c30767ddca1f9c207888833aea5b5fc61(ca4c37132857729c448ff998f60bad9f0.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c48e1511559e26aa96c29a70d98eb9914.c30767ddca1f9c207888833aea5b5fc61(cb33dd0ae895d5ba6359f020d745a32d9.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 8:
											if (c77c62e4ed34755042c9e8f48c40cca14.c30767ddca1f9c207888833aea5b5fc61(c6495ea30c06e42742d055ed5ce2538da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												c230d1f2522ddde3fc40d9a8051605f8d.c30767ddca1f9c207888833aea5b5fc61(c7dcd1410a2c07b14c154c8b215012a07.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c1d1335b5273a876b8d47b9fb4f034ab9.c30767ddca1f9c207888833aea5b5fc61(c6495ea30c06e42742d055ed5ce2538da.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 9:
											if (c7351e161ee68c8f03a894eb18c9f9cca.c30767ddca1f9c207888833aea5b5fc61(cda1406db2ad7090baa534816d1dec0c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												ce8a172718a2d20f402c6f3144bc1583f.c30767ddca1f9c207888833aea5b5fc61(cf8a76f5b7768f610e09df017d2f06a8d.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cffbccdeca05d1ef8eec4965a9903d307.c30767ddca1f9c207888833aea5b5fc61(cda1406db2ad7090baa534816d1dec0c8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 10:
											if (ce3d7b3ddeac52d11bf5215236be83a87.c30767ddca1f9c207888833aea5b5fc61(c637d387120c6dc5381559601ac59dade.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												ca54566100fb855710fcde09249c0f959.c30767ddca1f9c207888833aea5b5fc61(c4eae1524dd7ad10b2cac1fc05b86723b.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c31876cdfcff56ba89758cf1d7944791c.c30767ddca1f9c207888833aea5b5fc61(c637d387120c6dc5381559601ac59dade.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 11:
											if (c84e9920314e16f6997ae92066ab4acb1.c30767ddca1f9c207888833aea5b5fc61(c461035dac885f324e71adfeac60fe545.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												cbcdb56e6685f54f71160e82b390d195b.c30767ddca1f9c207888833aea5b5fc61(c33d4993aae0144feb5e857b05601b312.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cf12e4d7f96c88e08bd01aeae77555929.c30767ddca1f9c207888833aea5b5fc61(c461035dac885f324e71adfeac60fe545.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										case 12:
											if (cd66a600b047c8ba9a50f391427cba8db.c30767ddca1f9c207888833aea5b5fc61(c771c345f6e6f12e9bebdffdaf3e7e0ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
												c8bd46b9c0e2265f4d69f498a22d3e940.c30767ddca1f9c207888833aea5b5fc61(cbb6e5d80f30ced53e27b09902872c1b6.c30767ddca1f9c207888833aea5b5fc61(c771c345f6e6f12e9bebdffdaf3e7e0ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3), num);
												c6c1df21562d189a5b689c9887314ddd9.c30767ddca1f9c207888833aea5b5fc61(c9af964f77baeb5190468aaf53ecd38f2.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbb6e5d80f30ced53e27b09902872c1b6.c30767ddca1f9c207888833aea5b5fc61(c771c345f6e6f12e9bebdffdaf3e7e0ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
											}
											break;
										}
									}
								}
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007A4 RID: 1956 RVA: 0x000378D0 File Offset: 0x00035AD0
		private void c027c0656eccfa31b1e693ee492a85fa1()
		{
			c029f0bb12883abbc037433cced8204aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c6ff5c33362a072a4f77526abbd4c2593.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(131934));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10660));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10664)));
							SqlQuestActObjTalk sqlQuestActObjTalk = ceebdf89443fac63a3629f7c89623ed43.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c0b65f5da4b5b79b2de2d6aa0869a71c3.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjTalk, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10668)));
							uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10672)));
							if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_F1_0 = methodof(SqlCore.c027c0656eccfa31b1e693ee492a85fa1()).MethodHandle;
								}
								c3eaf8fb2d78e623c72d6cf8b7f2886fe.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjTalk, c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
								cc2983b2712fc03950bae924a1ad13ff2.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjTalk, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
							}
							c0aa81594c8aeb960ba1a62030b0e9a99.c30767ddca1f9c207888833aea5b5fc61(c771c345f6e6f12e9bebdffdaf3e7e0ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActObjTalk);
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00037AD8 File Offset: 0x00035CD8
		private void c226502a4c4031ac7bccb87b4fa1de75c()
		{
			c4007fe8c982ec75ef93c7e242a9fd5b4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c3f9b0b92c754fc86e4629934e61f60be.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132037));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10676));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10680)));
							SqlQuestActObjInteraction sqlQuestActObjInteraction = cdc332b35caff47d52c735f267ff53570.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c6577fc88ac6f1aead95de9451406f248.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjInteraction, num);
							c557b0bb34e008121c27ece83d000e149.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjInteraction, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10684))));
							c465ba82efc9c64169d944aafc77e31c2.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjInteraction, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10688))));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10692)));
							if (c129fb2f83ee1580675b039b954aeeaec.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_119_0 = methodof(SqlCore.c226502a4c4031ac7bccb87b4fa1de75c()).MethodHandle;
								}
								cf55347c55cd7b62c94d199066970c53a.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActObjInteraction, c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							c9c388a88f9e404817f16c2d3e9c1c8f7.c30767ddca1f9c207888833aea5b5fc61(c461035dac885f324e71adfeac60fe545.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActObjInteraction);
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00037CD4 File Offset: 0x00035ED4
		private void c523b1931eb9925c6ffab27975150c2bc()
		{
			c5015de8e3b0a4265fbb4e160ef4d5a5c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c1930ec6307a6349ac287a345578c9b87.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132171));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10696));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10700)));
							SqlQuestActConReportNpc sqlQuestActConReportNpc = c852b72d5ea24de19bbd5e30522ba99ed.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c3568c8953255bbbdc5d871ef7f3f1db5.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConReportNpc, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10704)));
							if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.c523b1931eb9925c6ffab27975150c2bc()).MethodHandle;
								}
								c666a713d34db9736957378c3e5cc37e3.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConReportNpc, c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							c1f7afe4269df65623a8ec6fea8f1147a.c30767ddca1f9c207888833aea5b5fc61(c215ba3b9622d956775be3b4a5119a345.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActConReportNpc);
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
								switch (4)
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00037E88 File Offset: 0x00036088
		private void c4341d452d3546c4e1b04674ebce1eba8()
		{
			c704b248d8c0894b08a5aa47aa8be03a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ce6d4a9da51ce8f81428f178b5518ba1c.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132268));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10708));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10712)));
							SqlQuestActConAcceptNpc sqlQuestActConAcceptNpc = caadeeb86efb2858b1bde8cbcead02438.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c4647f1c4362eee733e616b377db8ef9d.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConAcceptNpc, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10716)));
							if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.c4341d452d3546c4e1b04674ebce1eba8()).MethodHandle;
								}
								c0b1ad075521fd78f97b1a525c6e229df.c30767ddca1f9c207888833aea5b5fc61(sqlQuestActConAcceptNpc, c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							c14775684f8bb32164cd36565291a67e8.c30767ddca1f9c207888833aea5b5fc61(cfdb7fe5327f837a94a0bac2e5678e331.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestActConAcceptNpc);
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0003803C File Offset: 0x0003623C
		private void c9a9b9b37bd73e8bb6d77c6a36545a847()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132365));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10720));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10724)));
							string text = SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10728)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10732)));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132503)))
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
									RuntimeMethodHandle arg_DB_0 = methodof(SqlCore.c9a9b9b37bd73e8bb6d77c6a36545a847()).MethodHandle;
								}
								if (c8a446629a5d2b0a8aa22208ae15f284d.c30767ddca1f9c207888833aea5b5fc61(c6c4866c61737748d5f1ae6844e91b6a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									if (c4854df3df543555dd566555b21b819da.c30767ddca1f9c207888833aea5b5fc61(cb887a97ec5e07a6fb0e32e901ccd11bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
										c5b1eca8f5421873fd1a494c8ad32c663.c30767ddca1f9c207888833aea5b5fc61(c37934b1ff069fc1753bab22b24791724.c30767ddca1f9c207888833aea5b5fc61(c8935034383fb2a7e4f2d66d87c9d7edd.c30767ddca1f9c207888833aea5b5fc61(c6c4866c61737748d5f1ae6844e91b6a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), c846604c2cfdb122eac96f452179228a2.c30767ddca1f9c207888833aea5b5fc61(cb887a97ec5e07a6fb0e32e901ccd11bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
									}
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0003823C File Offset: 0x0003643C
		private void cc4259237aa03aa43c6e606cd63209036()
		{
			cdb387ec0340d7827ae672149ac09d8b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c6a4fd5b5432dd349c1ccd0f1f4aa6850.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132514));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10736));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10740)));
							SqlModelAttachPointString sqlModelAttachPointString = c544731fd2b376bc0765633f83307aafc.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c26f81fce3922d664c4d4d1cac3d43e6c.c30767ddca1f9c207888833aea5b5fc61(sqlModelAttachPointString, num);
							c43e1a9d2dba22d303148122b108b9b03.c30767ddca1f9c207888833aea5b5fc61(sqlModelAttachPointString, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10744))));
							c66a902e22374dc6733954a0f9ce7c802.c30767ddca1f9c207888833aea5b5fc61(sqlModelAttachPointString, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10748))));
							c474741188cbc8de165807268886c08d6.c30767ddca1f9c207888833aea5b5fc61(cb887a97ec5e07a6fb0e32e901ccd11bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlModelAttachPointString);
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
						if (!true)
						{
							RuntimeMethodHandle arg_109_0 = methodof(SqlCore.cc4259237aa03aa43c6e606cd63209036()).MethodHandle;
						}
					}
					finally
					{
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000383E8 File Offset: 0x000365E8
		private void cf7ae3d1df8ea6a8791c4558e9145f20b()
		{
			c49fb0c729586c37a853af1a1aa8f400e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c254365810f215514c8ffc87221784d43.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132627));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10752));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10756)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10760)));
							string text = SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10764)));
							SqlModel sqlModel = cb5dfec7a5f54ea975768d010ceab0309.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c0caa92b9a237bf6ff1c43496785c75d5.c30767ddca1f9c207888833aea5b5fc61(sqlModel, num);
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132706)))
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
									RuntimeMethodHandle arg_F6_0 = methodof(SqlCore.cf7ae3d1df8ea6a8791c4558e9145f20b()).MethodHandle;
								}
								if (c28386e251893909551d493694873e385.c30767ddca1f9c207888833aea5b5fc61(c55307603d883677336181ff2770cc734.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									c16c1bd87db225baaca47ec1fcd50eb59.c30767ddca1f9c207888833aea5b5fc61(sqlModel, cae09a9a8d0ef132fb1d35065df797864.c30767ddca1f9c207888833aea5b5fc61(c55307603d883677336181ff2770cc734.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132727)))
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
								if (cc03677ce343aca78d07add7f9ffdb66c.c30767ddca1f9c207888833aea5b5fc61(c3088ef73398cae3d9853b600d9347624.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									c038504580dfe6b7752ccf858919566dd.c30767ddca1f9c207888833aea5b5fc61(sqlModel, c4b708c9b3be3882f29ac23f628e8eb5f.c30767ddca1f9c207888833aea5b5fc61(c3088ef73398cae3d9853b600d9347624.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
							}
							c2a9cdd63b06334b5bfbe531503bc06c9.c30767ddca1f9c207888833aea5b5fc61(c6c4866c61737748d5f1ae6844e91b6a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlModel);
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00038634 File Offset: 0x00036834
		private void c1ac2a656e65ff34615bbbfd5d2c70c4a()
		{
			c8b0253e3d08151de646f01d24f9c6f96.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c434805fe9df0de209fe9441759eeab12.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132752));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10768));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10772)));
							SqlActorModel sqlActorModel = c8def7e92a11b49a5a5499ce9cea188ca.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							cb194b93a3285509def83dffbce99461f.c30767ddca1f9c207888833aea5b5fc61(sqlActorModel, num);
							c7f8f0268c3c0d554c381f0df4ec48700.c30767ddca1f9c207888833aea5b5fc61(sqlActorModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10776))));
							c04c84f7d66f2b0aaebf56a17f3a1f234.c30767ddca1f9c207888833aea5b5fc61(sqlActorModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10780))));
							c93e26fa341abd2b0ba953215723b2d34.c30767ddca1f9c207888833aea5b5fc61(c55307603d883677336181ff2770cc734.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlActorModel);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (!true)
					{
						RuntimeMethodHandle arg_11B_0 = methodof(SqlCore.c1ac2a656e65ff34615bbbfd5d2c70c4a()).MethodHandle;
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000387E0 File Offset: 0x000369E0
		private void ce232104137d3d9a069b3dadc0ab52255()
		{
			cbb7db7c16a3a14c56516190bd133351d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cd2cdd2acf4ad38afa2a7b25a714f7a05.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(132839));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10784));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10788)));
							SqlVehicleModel sqlVehicleModel = cb9d0109b27296c571fe0081948ea5f23.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c942829c2bd2ac0d6a8f2ccf7c3e3f4e6.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, num);
							cf07a4bb5ee60bdbd00b0c2ffc07c269b.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10792))));
							c87fc0b46d4ef0b235b6dcef8e9af4b81.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10796))));
							c3b2d6491e231ea8d4076e29548c0a9b6.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10800))));
							c98873d033e1611589962e4ef872303a9.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10804))));
							cf410a044fcfba11d5065f8dc3930b110.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10808))));
							c45c631a875126b6974fd29a6ea63dde6.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10812))));
							c813cc4a6a0b9a6673f863dc1fc1942a5.c30767ddca1f9c207888833aea5b5fc61(sqlVehicleModel, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10816))));
							ce5ea40a62969284aca04c0380377ca6f.c30767ddca1f9c207888833aea5b5fc61(c3088ef73398cae3d9853b600d9347624.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlVehicleModel);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (!true)
					{
						RuntimeMethodHandle arg_1CF_0 = methodof(SqlCore.ce232104137d3d9a069b3dadc0ab52255()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00038A40 File Offset: 0x00036C40
		private void cd9af846a78bcb7a6a2e803eea9f68d4f()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133101));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10820));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10824)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10828)));
							if (cfcb547fe67e75afa08ea5dd0cd8b0a2e.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_B8_0 = methodof(SqlCore.cd9af846a78bcb7a6a2e803eea9f68d4f()).MethodHandle;
								}
								for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10832); i < cde54a87791a3f1ed011f2c89732e9c7c.c30767ddca1f9c207888833aea5b5fc61(c2cb546ebef8fb8cc0484c1f36f58991e.c30767ddca1f9c207888833aea5b5fc61(c10d56073b449e7d7a10ba4e4efb1a038.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10836))
								{
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c3356d1ded035c44dd5c947fae10f99c9.c30767ddca1f9c207888833aea5b5fc61(cc3fe42211e97fe94982d0f27e6045cf7.c30767ddca1f9c207888833aea5b5fc61(c9397020ad9719d3a45f1cc37f34af38b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), c2be19745b3de7ebcfa2088253907e0e7.c30767ddca1f9c207888833aea5b5fc61(c2cb546ebef8fb8cc0484c1f36f58991e.c30767ddca1f9c207888833aea5b5fc61(c10d56073b449e7d7a10ba4e4efb1a038.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), i));
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
								switch (4)
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007AE RID: 1966 RVA: 0x00038C38 File Offset: 0x00036E38
		private void c788c8d44dd3c9a859c13a226cfeec27f()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133220));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10840));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10844)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10848)));
							if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_B5_0 = methodof(SqlCore.c788c8d44dd3c9a859c13a226cfeec27f()).MethodHandle;
								}
								if (cde7625a74d752f89da819b2ea3a0c83e.c30767ddca1f9c207888833aea5b5fc61(c9397020ad9719d3a45f1cc37f34af38b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c3356d1ded035c44dd5c947fae10f99c9.c30767ddca1f9c207888833aea5b5fc61(cc3fe42211e97fe94982d0f27e6045cf7.c30767ddca1f9c207888833aea5b5fc61(c9397020ad9719d3a45f1cc37f34af38b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007AF RID: 1967 RVA: 0x00038DF4 File Offset: 0x00036FF4
		private void c116e780cf5cf5bcc0ea9773e429248f0()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133323));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10852));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10856)));
							string text = SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10860)));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133459)))
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
									RuntimeMethodHandle arg_BC_0 = methodof(SqlCore.c116e780cf5cf5bcc0ea9773e429248f0()).MethodHandle;
								}
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									SqlUnitReq sqlUnitReq = c5a28fc37df649224d7d5aaeeacb537c1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									cefeea0ee75edc32ec4c3826eca510fab.c30767ddca1f9c207888833aea5b5fc61(sqlUnitReq, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10864))));
									c500c17e81ef31dc101164938409cb4b8.c30767ddca1f9c207888833aea5b5fc61(sqlUnitReq, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10868))));
									c885b81b680f9de68b2969eee50dc566b.c30767ddca1f9c207888833aea5b5fc61(sqlUnitReq, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10872))));
									c55ccc31f66349f1952afc1998501f691.c30767ddca1f9c207888833aea5b5fc61(c38f9cfdae45fb912023a4d10750b9c8e.c30767ddca1f9c207888833aea5b5fc61(cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), sqlUnitReq);
								}
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007B0 RID: 1968 RVA: 0x00039020 File Offset: 0x00037220
		private void cf7f498ee9f69e218c97b37b5f78444ba()
		{
			c2b2d58b6d9708452fc5aa3c72b00a4ef.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca4ffc72548f28d16a447adee278d77a3.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133470));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10876));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10880)));
							SqlSkillReq sqlSkillReq = ced13ec79812a3a0c798589bf63c4a45c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c740f02c18ed4899386b9e3f6143a8b28.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReq, num);
							ccc2c95589601a46ba04df523ed124643.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReq, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10884))));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10888)));
							uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10892)));
							if (num2 <= (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10896))
							{
								goto IL_14D;
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
								RuntimeMethodHandle arg_111_0 = methodof(SqlCore.cf7f498ee9f69e218c97b37b5f78444ba()).MethodHandle;
							}
							if (!c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
							{
								goto IL_14D;
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
							ce45ac7ee7972917a52687c56a0b9d92d.c30767ddca1f9c207888833aea5b5fc61(c678b43875ab4da5a1d27923886f983fe.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReq), c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							IL_188:
							cb9a60bb1c560ea1dcd36a17df9a09f6b.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReq, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10900))));
							c1bb263de4030d6fd68c1ab4bc8945a7e.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReq, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10904))));
							ccff91cb363cf42bc44c7f98769153345.c30767ddca1f9c207888833aea5b5fc61(c9397020ad9719d3a45f1cc37f34af38b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlSkillReq);
							continue;
							IL_14D:
							if (cc202d0ad820ef6323059a03284266a07.c30767ddca1f9c207888833aea5b5fc61(c083feae74ac4a96bd761138227cdeea6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
								c82264c5c0e7b239ab160279396743eca.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReq, cd34767de8440ab73d75d8994a923d32f.c30767ddca1f9c207888833aea5b5fc61(c84dea1b0508729084e29c3453c17271f.c30767ddca1f9c207888833aea5b5fc61(c083feae74ac4a96bd761138227cdeea6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3)));
								goto IL_188;
							}
							goto IL_188;
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000392C0 File Offset: 0x000374C0
		private void c8503c662fdc34b8a7c8e7f75d36eb173()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133720));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10908));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10912)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10916)));
							if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_B8_0 = methodof(SqlCore.c8503c662fdc34b8a7c8e7f75d36eb173()).MethodHandle;
								}
								if (c31c1bc19369460d30d5bfdcf61fdbcae.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									if (c5a22bd4f0c36006c67584198763d60e5.c30767ddca1f9c207888833aea5b5fc61(ca2658795bfd0c35ebe1c05096887c663.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)) != null)
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
										c8fadd2e6617b8064a3837917c609a849.c30767ddca1f9c207888833aea5b5fc61(cef85d00aa6cc96d455599559b0d45ba8.c30767ddca1f9c207888833aea5b5fc61(c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), ca2658795bfd0c35ebe1c05096887c663.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007B2 RID: 1970 RVA: 0x000394A0 File Offset: 0x000376A0
		private void c850535567fd1e2f94bb9881c7ac62883()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133827));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10920));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10924)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10928)));
							if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_B5_0 = methodof(SqlCore.c850535567fd1e2f94bb9881c7ac62883()).MethodHandle;
								}
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c9c3e0a996997fecb6a3ccd837dfdd948.c30767ddca1f9c207888833aea5b5fc61(c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0003965C File Offset: 0x0003785C
		private void c6efb3a986542da70201083c9e9e23bd2()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(133910));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10932));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10936)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10940)));
							if (c60410ca0f1f5f22a8ee59b6630fd8b2c.c30767ddca1f9c207888833aea5b5fc61(c16c4f5bd1c2c59a0ee3ff4d79746903c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_B8_0 = methodof(SqlCore.c6efb3a986542da70201083c9e9e23bd2()).MethodHandle;
								}
								if (c31c1bc19369460d30d5bfdcf61fdbcae.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									if (c5a22bd4f0c36006c67584198763d60e5.c30767ddca1f9c207888833aea5b5fc61(ca2658795bfd0c35ebe1c05096887c663.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)) != null)
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
										c8fadd2e6617b8064a3837917c609a849.c30767ddca1f9c207888833aea5b5fc61(cb8782181b5f81d3188bb1206237563bc.c30767ddca1f9c207888833aea5b5fc61(c211bd68403336f07c3228b30f62972b0.c30767ddca1f9c207888833aea5b5fc61(c16c4f5bd1c2c59a0ee3ff4d79746903c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), ca2658795bfd0c35ebe1c05096887c663.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
									}
								}
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0003983C File Offset: 0x00037A3C
		private void cf08e6aef18e237726f7fc92f7fb19727()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134021));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10944));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10948)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10952)));
							if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									RuntimeMethodHandle arg_B8_0 = methodof(SqlCore.cf08e6aef18e237726f7fc92f7fb19727()).MethodHandle;
								}
								if (c31c1bc19369460d30d5bfdcf61fdbcae.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									if (c5a22bd4f0c36006c67584198763d60e5.c30767ddca1f9c207888833aea5b5fc61(ca2658795bfd0c35ebe1c05096887c663.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)) != null)
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
										if (!c4381e84a5a7508c9a70af3a816b760e6.c30767ddca1f9c207888833aea5b5fc61(c6518ac5f607679cb5c5a7a5f978750f6.c30767ddca1f9c207888833aea5b5fc61(c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), ca2658795bfd0c35ebe1c05096887c663.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)))
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
											c8fadd2e6617b8064a3837917c609a849.c30767ddca1f9c207888833aea5b5fc61(c6518ac5f607679cb5c5a7a5f978750f6.c30767ddca1f9c207888833aea5b5fc61(c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), ca2658795bfd0c35ebe1c05096887c663.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
										}
									}
								}
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
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007B5 RID: 1973 RVA: 0x00039A58 File Offset: 0x00037C58
		private void c8144886dff3be57df80c8571871cacdd()
		{
			cf5c614488d4328b53544640036da557a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c16368b68cbc7d7f3bd77cd57b1be624f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134124));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10956));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10960)));
							SqlMountSkill sqlMountSkill = c02bab3b1c362bb2dab0dee8ed5f9a768.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c46e060625d486298eb66693a0e523f94.c30767ddca1f9c207888833aea5b5fc61(sqlMountSkill, num);
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10964)));
							if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.c8144886dff3be57df80c8571871cacdd()).MethodHandle;
								}
								c35078d1757b343b7ac91ccced04ad277.c30767ddca1f9c207888833aea5b5fc61(sqlMountSkill, cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								ccc5325783eb90d13e3f7f6103603769a.c30767ddca1f9c207888833aea5b5fc61(cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), c46182d17a06763174fab5375fbc65e9e.c30767ddca1f9c207888833aea5b5fc61(sqlMountSkill));
							}
							c38c288bb94e2bce3052f498903a32b22.c30767ddca1f9c207888833aea5b5fc61(c427398096670653b4af4d23ae64b850d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlMountSkill);
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00039C2C File Offset: 0x00037E2C
		private void c311a14cb267305d4933c93655f55b306()
		{
			ccab968aefa92d71e8d28d8a42c4be6b5.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc8a4f3993eb90e1d79f5f8cd004e1962.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134199));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10968));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10972)));
						SqlDoodadFuncPurchase sqlDoodadFuncPurchase = ca0aa8acb4af9ccba9e92ae21c2806044.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c9b9b741680106be69de166b649d8cc1f.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncPurchase, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10976)));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.c311a14cb267305d4933c93655f55b306()).MethodHandle;
							}
							c0a336460ec8e0347647dce6786c7cd09.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncPurchase, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							cf8132e61050c6b8ebe61927ded5ce2e2.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncPurchase, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10980))));
						}
						uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10984)));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
							c08d13cace2d12184a81dbca3e942136e.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncPurchase, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
							cd48c9463d48d5b781ec619c6b23a2cb2.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncPurchase, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10988))));
						}
						c7093911b73ca3fd80c59df2eab5a9262.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncPurchase, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10992))));
						cdad4edcfb58e0e41abbf276e99a3e61e.c30767ddca1f9c207888833aea5b5fc61(cf9fafe6dd0cb14e5766aa7067ab8ced8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlDoodadFuncPurchase);
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
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00039E74 File Offset: 0x00038074
		private void c1dc56d9b9528c32a3a53f8114a36a4d7()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134383));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(10996));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11000)));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_90_0 = methodof(SqlCore.c1dc56d9b9528c32a3a53f8114a36a4d7()).MethodHandle;
							}
							ccc7cdf04822aa391c25bd297f9066851.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11004) != 0);
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00039F98 File Offset: 0x00038198
		private void c1ab7063b021b8affdabcc6e63050c8ba()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134476));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11008));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11012)));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_90_0 = methodof(SqlCore.c1ab7063b021b8affdabcc6e63050c8ba()).MethodHandle;
							}
							c2994b8d20179e86c02695194a6af5d20.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11016))));
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
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007B9 RID: 1977 RVA: 0x0003A0D4 File Offset: 0x000382D4
		private void c945104e5c78577796dcd726e400acdea()
		{
			c26c9caeab57bf2c052c8918040072cce.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca081c03c125b27664093420805008ee3.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134581));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11020));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11024)));
						SqlBuffUnitModifier sqlBuffUnitModifier = c0e57954fc13d0fd5b74875bb0ec7ff10.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c8401674608a1a2f65f8aa96db3b9205f.c30767ddca1f9c207888833aea5b5fc61(sqlBuffUnitModifier, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11028)));
						if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.c945104e5c78577796dcd726e400acdea()).MethodHandle;
							}
							c91213e8a34712d69f0f21f1922685ee1.c30767ddca1f9c207888833aea5b5fc61(sqlBuffUnitModifier, c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c6ecfa67da69a7305b5ba3866c82458a5.c30767ddca1f9c207888833aea5b5fc61(c62b16b793f41bf935694cc981e81e494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlBuffUnitModifier);
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0003A25C File Offset: 0x0003845C
		private void cba4bff6735c08ea4efb4466fd4da4362()
		{
			c086f7e9936f815b5e83ddedda754230f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c44189e6fbdbdda4981d49d5aedd4ed6b.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134670));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11032));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11036)));
						SqlSlave sqlSlave = c574048b644741740aff3d3304ed0e571.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cb484faa6dfc47b7210472a4a3cffdb57.c30767ddca1f9c207888833aea5b5fc61(sqlSlave, num);
						ce76f0d1b7eb0f73283f7aaf1c4279e90.c30767ddca1f9c207888833aea5b5fc61(sqlSlave, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11040))));
						c7709e981d4d7b62693902a995edbb651.c30767ddca1f9c207888833aea5b5fc61(sqlSlave, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11044))));
						c01f3bfdb4dbed9d27084ee9322380888.c30767ddca1f9c207888833aea5b5fc61(sqlSlave, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11048))));
						caa09f9a6c842af08ba07b2b4b1aa7005.c30767ddca1f9c207888833aea5b5fc61(sqlSlave, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11052))));
						c02452ed714a9375c9cf2d26ef18865ea.c30767ddca1f9c207888833aea5b5fc61(c16c4f5bd1c2c59a0ee3ff4d79746903c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlSlave);
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
						RuntimeMethodHandle arg_150_0 = methodof(SqlCore.cba4bff6735c08ea4efb4466fd4da4362()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0003A424 File Offset: 0x00038624
		private void ce1248882ca9d496d04aeecb7c1335722()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(134836));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11056));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11060)));
						SqlDynamicUnitModifier sqlDynamicUnitModifier = c980e7916847b1dbff19dbf35baf93621.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cb9476d963e352009f8ed96384e9cea93.c30767ddca1f9c207888833aea5b5fc61(sqlDynamicUnitModifier, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11064)));
						if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_C7_0 = methodof(SqlCore.ce1248882ca9d496d04aeecb7c1335722()).MethodHandle;
							}
							c8138a554c0c6ad57cfdb71d119529edd.c30767ddca1f9c207888833aea5b5fc61(sqlDynamicUnitModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11068))));
							cb9849095641760f3550a5fe0060b6d42.c30767ddca1f9c207888833aea5b5fc61(sqlDynamicUnitModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11072))));
							uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11076)));
							c8a85199cbace31d47d64342cce0309e5.c30767ddca1f9c207888833aea5b5fc61(sqlDynamicUnitModifier, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11080))));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cf898af3db2e03b0e042f3443fbb45662.c30767ddca1f9c207888833aea5b5fc61(sqlDynamicUnitModifier), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135054)))
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
								if (c9077a3763cbba2ca5c1630373a16f80d.c30767ddca1f9c207888833aea5b5fc61(c6609ee52399132037a8250c448bacb6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c279f800743808f9efec0ad68b090f84d.c30767ddca1f9c207888833aea5b5fc61(sqlDynamicUnitModifier, c3298deac4fd59776d822c3b85896ff14.c30767ddca1f9c207888833aea5b5fc61(c6609ee52399132037a8250c448bacb6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									c1534cb1a5a67e9374b0f0a01bf562260.c30767ddca1f9c207888833aea5b5fc61(c6c29fe1b2bc23db74d9df40a3fb2ded8.c30767ddca1f9c207888833aea5b5fc61(c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), sqlDynamicUnitModifier);
								}
							}
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0003A684 File Offset: 0x00038884
		private void c016280797bffb5b36edf91e5a34edbd1()
		{
			ca633b3dc6abcd4ae868d52bac647cf4f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cf358c0379a6ff11008e67527dfe05b95.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135075));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11084));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11088)));
						SqlLinearFunc sqlLinearFunc = c84834092c76ffd4a1e8c1ba0fa8c73ba.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c895ff5900652a485b78b91fc842d2f75.c30767ddca1f9c207888833aea5b5fc61(sqlLinearFunc, num);
						c5ecff3b771aba36c30b5359fe545f34e.c30767ddca1f9c207888833aea5b5fc61(sqlLinearFunc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11092))));
						cab9bd9ff210a1fc11d8090ae9cb08976.c30767ddca1f9c207888833aea5b5fc61(sqlLinearFunc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11096))));
						cb8c757eb297fba8ff473875fdf106065.c30767ddca1f9c207888833aea5b5fc61(c6609ee52399132037a8250c448bacb6d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlLinearFunc);
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
						RuntimeMethodHandle arg_107_0 = methodof(SqlCore.c016280797bffb5b36edf91e5a34edbd1()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007BD RID: 1981 RVA: 0x0003A804 File Offset: 0x00038A04
		private void cd77b022766d7e0d1eb8478f7c93100c9()
		{
			c35b6c706eb1c0f1785b5ad6f795d07e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, caff31baf919ad8474361e2014ee3dd64.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135178));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11100));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11104)));
						SqlAuctionCCategory sqlAuctionCCategory = c411cc418d323937eba1592c954030ce3.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cb53e197f687207ae4d297a298aa3ff1b.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionCCategory, num);
						c62b170d99013461c618e0e33980a5cac.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionCCategory, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11108))));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11112)));
						if (cd4272556fa221e47a689a25dccd89f7a.c30767ddca1f9c207888833aea5b5fc61(ccc10b4bd16736b208f92e116b8166baf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_F5_0 = methodof(SqlCore.cd77b022766d7e0d1eb8478f7c93100c9()).MethodHandle;
							}
							ce8013eaf6fb9d6ff5d18b468763a58e0.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionCCategory, c8c9f77aa0cd2a2151cd56b60a5044cf5.c30767ddca1f9c207888833aea5b5fc61(ccc10b4bd16736b208f92e116b8166baf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c0ae4b47313276eaeb2894b682036b7a8.c30767ddca1f9c207888833aea5b5fc61(c7b5ba1ab45b3081a6e8e1e6a37cfbe86.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlAuctionCCategory);
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

		// Token: 0x060007BE RID: 1982 RVA: 0x0003A9B0 File Offset: 0x00038BB0
		private void ce11c2b640fedb3b90035c2762feeede2()
		{
			c5a667db0976dfd4db7fba2586bfe48ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c1a0e0735daf663f343b0854f828e753e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135301));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11116));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11120)));
						SqlAuctionBCategory sqlAuctionBCategory = cdbba959aa1555e64e46171b7142a28ec.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cc271286bdfb66ddf1d85fe1996a7993f.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionBCategory, num);
						c985117a94f38d56cfb6616251424b26e.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionBCategory, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11124))));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11128)));
						if (c46fe0e3de44f00243c654c71d3ccecf6.c30767ddca1f9c207888833aea5b5fc61(c5e9d6cd00a5512e6c157997f11b975b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_F5_0 = methodof(SqlCore.ce11c2b640fedb3b90035c2762feeede2()).MethodHandle;
							}
							c1b6c0c7357fa08755c20a35ba8d0769f.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionBCategory, cee672e52c87b3acb139c680df596a7f2.c30767ddca1f9c207888833aea5b5fc61(c5e9d6cd00a5512e6c157997f11b975b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c245ad19516667aed89fa4ad8751080d8.c30767ddca1f9c207888833aea5b5fc61(ccc10b4bd16736b208f92e116b8166baf.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlAuctionBCategory);
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0003AB5C File Offset: 0x00038D5C
		private void c5e7bbc660fb5ec59b943e71d04efb29c()
		{
			caef36620ef7d26579a564a3f7c602a05.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cb3100eb63530d685770d307e34a41872.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135424));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11132));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11136)));
						SqlAuctionACategory sqlAuctionACategory = c5f851964e7d2f3b05a7482a005cc7059.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c7def6c3242ec0ebe159078cc9029c191.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionACategory, num);
						c25b3d2324cf580160e31b0df5fecf7f8.c30767ddca1f9c207888833aea5b5fc61(sqlAuctionACategory, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11140))));
						c8c6b328d0ed69854cf72d30c8ecef8b5.c30767ddca1f9c207888833aea5b5fc61(c5e9d6cd00a5512e6c157997f11b975b3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlAuctionACategory);
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
					if (!true)
					{
						RuntimeMethodHandle arg_DD_0 = methodof(SqlCore.c5e7bbc660fb5ec59b943e71d04efb29c()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0003AC98 File Offset: 0x00038E98
		private void c09d43146746550a032ea3d692ce2b4f4()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135507));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11144));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11148)));
						if (c6ee1aa24a145514cd6230a7108bbcb68.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_97_0 = methodof(SqlCore.c09d43146746550a032ea3d692ce2b4f4()).MethodHandle;
							}
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11152)));
							if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								cf80c6fe077517a0abfc491f84d0b9f26.c30767ddca1f9c207888833aea5b5fc61(cdb4e3b7741f72f79a6bd235aed49576e.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
							cef19b22f3026a1d4ca35aad33d219a16.c30767ddca1f9c207888833aea5b5fc61(cdb4e3b7741f72f79a6bd235aed49576e.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11156))));
							c8c642b8f26a6bc131b4883a232f9b8fb.c30767ddca1f9c207888833aea5b5fc61(cdb4e3b7741f72f79a6bd235aed49576e.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11160))));
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007C1 RID: 1985 RVA: 0x0003AE88 File Offset: 0x00039088
		private void cdc58bd4911d8fdbf5d2c31bd23757046()
		{
			c5488674b8872149358ab33e2865f0780.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cbc743a655bd03176764c2f3542c3d8d0.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135632));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11164));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11168)));
						SqlActabilityCategorie sqlActabilityCategorie = c8cd9afe7f01f191be5b95501e2ce1d85.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c56b2013db0c014ae2d9c229b1d653824.c30767ddca1f9c207888833aea5b5fc61(sqlActabilityCategorie, num);
						c23df77290d721ae3333343f1191af9e7.c30767ddca1f9c207888833aea5b5fc61(sqlActabilityCategorie, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11172))));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11176)));
						if (c1bf6df84b876cbccd7c9c86eb8056fbe.c30767ddca1f9c207888833aea5b5fc61(ce1622078ba1a7fcddcb7d938aa45a312.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_F5_0 = methodof(SqlCore.cdc58bd4911d8fdbf5d2c31bd23757046()).MethodHandle;
							}
							cd124af4f22b74618524a0317c271b47d.c30767ddca1f9c207888833aea5b5fc61(sqlActabilityCategorie, cc51d8e860f4d0b159736672189204af5.c30767ddca1f9c207888833aea5b5fc61(ce1622078ba1a7fcddcb7d938aa45a312.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c877b4dc89f8262248ca81014d8183993.c30767ddca1f9c207888833aea5b5fc61(ce17af41007ad8e74eee8b61fc9c04854.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlActabilityCategorie);
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0003B034 File Offset: 0x00039234
		private void c71ec101b131b89411abcbc77b9469a63()
		{
			cc69ac56c1c3c87d59384402c7cbb3c84.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca0929673b63ebbe9f85e07ffacc34222.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135737));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11180));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11184)));
						SqlActabilityGroup sqlActabilityGroup = c7357eaa41b422a7fa2983d74b314a520.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cb09f617302f55e39ef35f702a7774b03.c30767ddca1f9c207888833aea5b5fc61(sqlActabilityGroup, num);
						c9baadc46f46510cbb9334b9c23793dfe.c30767ddca1f9c207888833aea5b5fc61(sqlActabilityGroup, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11188))));
						cbdbfd67fa07547d984e54d522481553f.c30767ddca1f9c207888833aea5b5fc61(sqlActabilityGroup, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11192))));
						ce5d07999e7f69fc488180fdba2e52f35.c30767ddca1f9c207888833aea5b5fc61(ce1622078ba1a7fcddcb7d938aa45a312.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlActabilityGroup);
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
					if (!true)
					{
						RuntimeMethodHandle arg_107_0 = methodof(SqlCore.c71ec101b131b89411abcbc77b9469a63()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0003B1B4 File Offset: 0x000393B4
		private void c84404d43401634e4149a5462c03a3835()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135842));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11196));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11200)));
						SqlCraftMaterial sqlCraftMaterial = cd8eb5a0bf5eb86b5bc31668a27cd4f0f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cff3bd6aba07ca7d36b3e1beca52a70d0.c30767ddca1f9c207888833aea5b5fc61(sqlCraftMaterial, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11204)));
						uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11208)));
						c30f07e67d896087023592bfe77843da3.c30767ddca1f9c207888833aea5b5fc61(sqlCraftMaterial, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11212))));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
								RuntimeMethodHandle arg_109_0 = methodof(SqlCore.c84404d43401634e4149a5462c03a3835()).MethodHandle;
							}
							c65fd6a6e93d5fbb66353509bca4a64e2.c30767ddca1f9c207888833aea5b5fc61(sqlCraftMaterial, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
						}
						if (c6ee1aa24a145514cd6230a7108bbcb68.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
							ceae22fc4c235a26ce8521288e1fa3812.c30767ddca1f9c207888833aea5b5fc61(cf19292f08e7ef1d12787eb9428e7fec9.c30767ddca1f9c207888833aea5b5fc61(cdb4e3b7741f72f79a6bd235aed49576e.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), sqlCraftMaterial);
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
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0003B3A0 File Offset: 0x000395A0
		private void cb7ec7d03a33ec416b593fa672aa78f56()
		{
			ca879ae4e01cefa9256e41559b3f9a868.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c1d59bc3863f5e608b776883458cc7089.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(135957));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11216));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11220)));
						SqlDoodadFuncCraftPack sqlDoodadFuncCraftPack = c6a820f297771edeeb6dd6dd4cc7c9b19.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c168883c93ee1ba94661fe22994e30f46.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncCraftPack, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11224)));
						if (cb12a1610aa8e8de770d99ac52f0ff561.c30767ddca1f9c207888833aea5b5fc61(c7b60141eb8900e19224e53b4f4cf4958.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.cb7ec7d03a33ec416b593fa672aa78f56()).MethodHandle;
							}
							ca81771207079a47a7bb5b5437b08c746.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncCraftPack, c04efabb991f9c0bc589c97adb9f5f5c8.c30767ddca1f9c207888833aea5b5fc61(c7b60141eb8900e19224e53b4f4cf4958.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c2b41ee0fa43a01a3b72410a8aa359070.c30767ddca1f9c207888833aea5b5fc61(cc4851452aacae34dbdf6d47609cd62aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlDoodadFuncCraftPack);
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0003B528 File Offset: 0x00039728
		private void c28cc401823f1ae25a278e52dcd7c70c9()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136064));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11228));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11232)));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11236)));
						if (cb12a1610aa8e8de770d99ac52f0ff561.c30767ddca1f9c207888833aea5b5fc61(c7b60141eb8900e19224e53b4f4cf4958.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_B3_0 = methodof(SqlCore.c28cc401823f1ae25a278e52dcd7c70c9()).MethodHandle;
							}
							if (c6ee1aa24a145514cd6230a7108bbcb68.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								c7560019f39c8f0f5debff52620fe9933.c30767ddca1f9c207888833aea5b5fc61(c70376055552ec04e00796f6ed2ea9e48.c30767ddca1f9c207888833aea5b5fc61(c04efabb991f9c0bc589c97adb9f5f5c8.c30767ddca1f9c207888833aea5b5fc61(c7b60141eb8900e19224e53b4f4cf4958.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), cdb4e3b7741f72f79a6bd235aed49576e.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0003B6B8 File Offset: 0x000398B8
		private void cb696f94fb3b34cb2524f1ced386de07b()
		{
			c72234622f0f5ba31e458aad3451c0573.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c15ccc1cd832e3aedf9087ce0a41eb891.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136179));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11240));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11244)));
						SqlCraftPack sqlCraftPack = c5bcad03c4849bbd92139e46dee9c4dad.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c3570eb90f3dcffa71f89792e775d9ab4.c30767ddca1f9c207888833aea5b5fc61(sqlCraftPack, num);
						cbe2938a97f250032e59e6334dd34776a.c30767ddca1f9c207888833aea5b5fc61(c7b60141eb8900e19224e53b4f4cf4958.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlCraftPack);
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
						RuntimeMethodHandle arg_B9_0 = methodof(SqlCore.cb696f94fb3b34cb2524f1ced386de07b()).MethodHandle;
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0003B7D0 File Offset: 0x000399D0
		private void c65f3bd21eac3f9c600d2cb7522a21631()
		{
			cb116f896be501bf2b970527b94296e8b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4a8a85f49ff04dd159637467984c237d.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136232));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11248));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11252)));
						SqlCraft sqlCraft = cedbe92e1500c69386b37f1f54944f211.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c8f94ccef677b70d1a8a838ba22448924.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, num);
						c402345412b6eb76d24294261549c7a60.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11256))));
						cb0a6ab1961263ebd876d949d52affe44.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11260))));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11264)));
						if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_119_0 = methodof(SqlCore.c65f3bd21eac3f9c600d2cb7522a21631()).MethodHandle;
							}
							c2a040404a6af43bd04e4adc069c540ee.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c287e741973c958fbf3a1854c1524aac4.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11268))));
						uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11272)));
						if (c1fffd416c061205181dbaaa203de1217.c30767ddca1f9c207888833aea5b5fc61(ce17af41007ad8e74eee8b61fc9c04854.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
							c29bd9bf7ca61917c463fb5f7d355a06c.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, c0fa8ce920fb9858114634c548e894ee6.c30767ddca1f9c207888833aea5b5fc61(ce17af41007ad8e74eee8b61fc9c04854.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
						}
						c010d966f99d26e2a8f3c9f8ef2ff56b7.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11276))));
						cf0c7e6c8d60ec86d3e2c04e72dbc6d7a.c30767ddca1f9c207888833aea5b5fc61(sqlCraft, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11280))));
						ce9d4887e833b89c97766d1bd54f73982.c30767ddca1f9c207888833aea5b5fc61(cef8b0edb181d6fc135b4cef9b19316c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlCraft);
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
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x0003BA60 File Offset: 0x00039C60
		private void cc04b1c03860e1fb85600102847ad89a5()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136448));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11284));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11288)));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11292)));
						if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_B3_0 = methodof(SqlCore.cc04b1c03860e1fb85600102847ad89a5()).MethodHandle;
							}
							if (c3dd466c896bc9f17922977c38a61945e.c30767ddca1f9c207888833aea5b5fc61(c5eb31155df47e065e481b47fd1440801.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								c5f3d099c6cd302366f100b39c7c9a8c0.c30767ddca1f9c207888833aea5b5fc61(cba2a1e4a94b01ef0567bb700a55d1090.c30767ddca1f9c207888833aea5b5fc61(c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), c8c92121af95f5116dc8acb67615ac378.c30767ddca1f9c207888833aea5b5fc61(c5eb31155df47e065e481b47fd1440801.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0003BBF0 File Offset: 0x00039DF0
		private void ce8c0a42c49c8fe0549ffd4f3870e73fe()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136549));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11296));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11300)));
						SqlMerchantGood sqlMerchantGood = c75e2cc99917f23f3bfdd4752d573cfd0.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c5871d92a06c0eac3afba132932f15ec1.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantGood, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11304)));
						if (c3dd466c896bc9f17922977c38a61945e.c30767ddca1f9c207888833aea5b5fc61(c5eb31155df47e065e481b47fd1440801.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_C4_0 = methodof(SqlCore.ce8c0a42c49c8fe0549ffd4f3870e73fe()).MethodHandle;
							}
							c26df4ef3f53f56cf4e2bf37f6e285f9d.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantGood, c8c92121af95f5116dc8acb67615ac378.c30767ddca1f9c207888833aea5b5fc61(c5eb31155df47e065e481b47fd1440801.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11308)));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
							c697f01cdb74e9dc77267ec9ec144ca22.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantGood, c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
						}
						c6e2f789433fd87ab0eb154ead1a47e2a.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantGood, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11312))));
						if ((int)c65f27891185aff8647881743d67dc266.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantGood) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11316))
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
							c6e2f789433fd87ab0eb154ead1a47e2a.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantGood, (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11320));
						}
						if (c3dd466c896bc9f17922977c38a61945e.c30767ddca1f9c207888833aea5b5fc61(c5eb31155df47e065e481b47fd1440801.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
							c06213b6aac218af5c33f24caf322a9af.c30767ddca1f9c207888833aea5b5fc61(cb9a566fdfd297a4afc27586a13916f22.c30767ddca1f9c207888833aea5b5fc61(c8c92121af95f5116dc8acb67615ac378.c30767ddca1f9c207888833aea5b5fc61(c5eb31155df47e065e481b47fd1440801.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), sqlMerchantGood);
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
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0003BE3C File Offset: 0x0003A03C
		private void c9ae7faf6e6d471151ba4e0c55f33aba0()
		{
			c4377119328048c81c7a3b435a7bc2b19.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cdd9acb33c730b0a1585bb5e6e6f7da68.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136683));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11324));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11328)));
						SqlMerchantPack sqlMerchantPack = ca85b018b22ecc45d968ceea68dcc447b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cb6b9313027856608d788c2258a5a12bc.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantPack, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11332)));
						if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.c9ae7faf6e6d471151ba4e0c55f33aba0()).MethodHandle;
							}
							cc75c6bce0342277e46dd822c58b1d47d.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantPack, c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c45dfddeb20bcbefd881f9892ae6609a6.c30767ddca1f9c207888833aea5b5fc61(sqlMerchantPack, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11336))));
						c9241feefa32da9556adaa36394fac0ac.c30767ddca1f9c207888833aea5b5fc61(c5eb31155df47e065e481b47fd1440801.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlMerchantPack);
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
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0003BFE8 File Offset: 0x0003A1E8
		private void c4e632b37eada736725df158fa4723ac0()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136788));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11340));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11344)));
						string text = SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11348)));
						if (c15e298690915be3761770153071e2761.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_B0_0 = methodof(SqlCore.c4e632b37eada736725df158fa4723ac0()).MethodHandle;
							}
							c2b87bb8ba3d5baee104a3ca810aa4fa1.c30767ddca1f9c207888833aea5b5fc61(c9b0b0c4e9dfd6978aad2f8d2e2a8ce6a.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), text);
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0003C128 File Offset: 0x0003A328
		private void c31ec6b75b81eb67a5ae4b9ff89c22e33()
		{
			ca3632115d990093c498758ed9a32582d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c3926afa2849f054b00e46e8818f09352.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(136905));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11352));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11356)));
						SqlQuestComponent sqlQuestComponent = c8d50f27847d7293c1a06eb2733216e65.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c426b97761e5f3e31bbb5331d4d984df8.c30767ddca1f9c207888833aea5b5fc61(sqlQuestComponent, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11360)));
						c09971313adf166e93197296519c54735.c30767ddca1f9c207888833aea5b5fc61(sqlQuestComponent, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11364))));
						cbed951f624bb9405bf2f7753d8c6766a.c30767ddca1f9c207888833aea5b5fc61(sqlQuestComponent, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11368))));
						c79c1540a42b416576bbf97ac6e987c9f.c30767ddca1f9c207888833aea5b5fc61(sqlQuestComponent, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11372))));
						c57cab7ccce54dcd1dc4bedcc3169b5cb.c30767ddca1f9c207888833aea5b5fc61(sqlQuestComponent, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11376))));
						c68324020b0261451ac1579fcbc083354.c30767ddca1f9c207888833aea5b5fc61(sqlQuestComponent, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11380))));
						if (c27a39f0226ab6b49132f65c0d76d1cbd.c30767ddca1f9c207888833aea5b5fc61(c72b36d7f64bdf8d3728860bc21df275f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_185_0 = methodof(SqlCore.c31ec6b75b81eb67a5ae4b9ff89c22e33()).MethodHandle;
							}
							cda3b27cfc615150ae7d44632e6de0b6d.c30767ddca1f9c207888833aea5b5fc61(c2219a79d0c970dc2e8d5de6ba7dadc8c.c30767ddca1f9c207888833aea5b5fc61(c9ed96188c1e1a53107b3ff091ee4aeff.c30767ddca1f9c207888833aea5b5fc61(c72b36d7f64bdf8d3728860bc21df275f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), sqlQuestComponent);
						}
						cd8bf32288aecae9107ec2025c0060e92.c30767ddca1f9c207888833aea5b5fc61(cb978869ec4f48ed1aafc732bbd836870.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestComponent);
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0003C36C File Offset: 0x0003A56C
		private void cc2719ef738d5f7f0a999ab5449b85a61()
		{
			cd191003fe38c3b706f4426f3008b2073.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cb7f13be579934f515671a6747e64f86e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(137133));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11384));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11388)));
						SqlQuestContext sqlQuestContext = c760a532bbf5afd46b011700365795715.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c29638cc748dff37607f0197f7697a0cf.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, num);
						c3f1c6a9b60bc8eebd886a8c2665565cc.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11392))));
						cd50491469b44bba5c887707d8a2e38ec.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11396))));
						c87a63c3f2911263a6f2966503421829f.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11400))));
						c89bd16b06f9899e29980f676cea7235b.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11404))));
						cbfdba0848142a55033f69c82908abb69.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11408))));
						c8749a23f81648bb5e6938e88abbca98c.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11412))));
						ca6165d0b02217d2aa90c2042e7ec7ee3.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11416))));
						c30232bf596a4e53f9d6c4b1b96934a22.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11420))));
						c33eb7f13431251541aae2fcf2dec1c11.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11424))));
						cad5dfe1877d4a01efdaad49e245b8882.c30767ddca1f9c207888833aea5b5fc61(sqlQuestContext, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11428))));
						ce6023ecbc6cbfd824a418cee29d16f5e.c30767ddca1f9c207888833aea5b5fc61(c72b36d7f64bdf8d3728860bc21df275f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlQuestContext);
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
						RuntimeMethodHandle arg_229_0 = methodof(SqlCore.cc2719ef738d5f7f0a999ab5449b85a61()).MethodHandle;
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0003C60C File Offset: 0x0003A80C
		private void cdf55f915fd3e76bdba1372f39e385eb5()
		{
			cb19d67a5426378a466130103586dc70e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cfc813895bf1d8284619e6dc029a1d9c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(137473));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11432));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11436)));
						SqlSpecialEffect sqlSpecialEffect = c88392dd54b79406468b260906c8d9ff2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						ca7323570790fd302f9003edf9f3c257e.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialEffect, num);
						c7ae889a6945ba71453de354019a673b9.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialEffect, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11440))));
						c182de9d40103ef99b40740b56ed9550b.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialEffect, SqlCore.cbb7abf924087b4fc4ab344f9dfdf9526(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11444))));
						c671ed7e8a5f75372d7b4cba2671e93ed.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialEffect, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11448))));
						c94ef87400f9dd374e709356a2c7d64fd.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialEffect, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11452))));
						c72ef33ccce504c47504f1cb28549191a.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialEffect, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11456))));
						cc4e75d145e34d7c0f8a413cbcdc25116.c30767ddca1f9c207888833aea5b5fc61(ca917d27144d9276d7eb9bd40724a3176.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlSpecialEffect);
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
						RuntimeMethodHandle arg_173_0 = methodof(SqlCore.cdf55f915fd3e76bdba1372f39e385eb5()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007CF RID: 1999 RVA: 0x0003C7F8 File Offset: 0x0003A9F8
		private void c0ab6ce466aedd9b77b1061f9b551b419()
		{
			c8a33e15a5def86145eb69ef3fd71dad6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c17f568761a6a6087210e212e25503f9d.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(137647));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11460));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11464)));
						SqlEffect sqlEffect = c4fdfcd6e522ecee35fe8157c616a11ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cc6eb6fcbd5a5596ec412cbdbb6bbc9f6.c30767ddca1f9c207888833aea5b5fc61(sqlEffect, num);
						cfa6484921ea6a5ee3acc767717b1b231.c30767ddca1f9c207888833aea5b5fc61(sqlEffect, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11468))));
						c9ed229c6c0594553dd02de3c949607b9.c30767ddca1f9c207888833aea5b5fc61(sqlEffect, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11472))));
						ce94bfc7969fd5ad175d4841b245f8bf7.c30767ddca1f9c207888833aea5b5fc61(c5fbccb83f1c1bbb120eabe9c96a75d27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlEffect);
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
					if (!true)
					{
						RuntimeMethodHandle arg_107_0 = methodof(SqlCore.c0ab6ce466aedd9b77b1061f9b551b419()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007D0 RID: 2000 RVA: 0x0003C978 File Offset: 0x0003AB78
		private void cca945eb7a81eca398427d25b413b01c2()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(137740));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11476));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11480)));
						SqlSkillEffect sqlSkillEffect = c98998d7bc3d1c9d8d0f24b19bf267957.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c5d4c365737387fee9f7cc63671d327ab.c30767ddca1f9c207888833aea5b5fc61(sqlSkillEffect, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11484)));
						uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11488)));
						if (c5048fe81d9947abf0cb7a372413932d1.c30767ddca1f9c207888833aea5b5fc61(c5fbccb83f1c1bbb120eabe9c96a75d27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
								RuntimeMethodHandle arg_E5_0 = methodof(SqlCore.cca945eb7a81eca398427d25b413b01c2()).MethodHandle;
							}
							c95d642cb613628f2f7ab5f3722199b66.c30767ddca1f9c207888833aea5b5fc61(sqlSkillEffect, c2b1bfb75986c8c4424fd59ca2b28f81b.c30767ddca1f9c207888833aea5b5fc61(c5fbccb83f1c1bbb120eabe9c96a75d27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
						}
						if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
							c5e64a16d1e77875246cee6093bea5e56.c30767ddca1f9c207888833aea5b5fc61(c39157643f28a7800f61f2f5cc9ec8be5.c30767ddca1f9c207888833aea5b5fc61(cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), sqlSkillEffect);
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(c053623ba076f2b455a932cad7841518a.c30767ddca1f9c207888833aea5b5fc61(c433e661fb25afa4b6961a4bfa2ec6805.c30767ddca1f9c207888833aea5b5fc61(sqlSkillEffect)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(129569)))
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
								if (c19f6924bdf49b69f20f47d1e9161d047.c30767ddca1f9c207888833aea5b5fc61(ca917d27144d9276d7eb9bd40724a3176.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c5e98d3732d9d746417cb1c5958952286.c30767ddca1f9c207888833aea5b5fc61(c433e661fb25afa4b6961a4bfa2ec6805.c30767ddca1f9c207888833aea5b5fc61(sqlSkillEffect))))
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
									c5883c10000912113bea6c66f98fd72ae.c30767ddca1f9c207888833aea5b5fc61(cb3c14a3b200eb26572566e77fa054966.c30767ddca1f9c207888833aea5b5fc61(cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c18816fbcb1daec27bc6ccc39986a75fe.c30767ddca1f9c207888833aea5b5fc61(ca917d27144d9276d7eb9bd40724a3176.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c5e98d3732d9d746417cb1c5958952286.c30767ddca1f9c207888833aea5b5fc61(c433e661fb25afa4b6961a4bfa2ec6805.c30767ddca1f9c207888833aea5b5fc61(sqlSkillEffect))));
								}
							}
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		private void c76ed9a074f4c9bfffbf71e703c82732a()
		{
			c9f49148f5917feb233ebf47f65f6528a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c6a2de478f912b4e392d20b5ae8ca6391.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(137839));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11492));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11496)));
						SqlCharacter sqlCharacter = cc2713e3d30d539d35e400bc6775f6855.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cb6b87363ff83f639cb596eb057bfb2af.c30767ddca1f9c207888833aea5b5fc61(sqlCharacter, num);
						c565b23fa7ad1c552ef5dbe134f3006eb.c30767ddca1f9c207888833aea5b5fc61(sqlCharacter, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11500))));
						ca033682af15d475199cfaf3aac16e87c.c30767ddca1f9c207888833aea5b5fc61(sqlCharacter, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11504))));
						cf00ed188bab660e2316d9f9ea92cbcde.c30767ddca1f9c207888833aea5b5fc61(cd3c03efb5d2b68122a7cc00b4025d6d8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlCharacter);
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
					if (!true)
					{
						RuntimeMethodHandle arg_107_0 = methodof(SqlCore.c76ed9a074f4c9bfffbf71e703c82732a()).MethodHandle;
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0003CD54 File Offset: 0x0003AF54
		private void c8f321a05e6cc03f0b89c349dc4a88121()
		{
			c18a5ef8f15589e28218fc0a49d94be76.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cf46f52d21310a5bb44fd56ee6638558b.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(137950));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11508));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11512)));
						SqlAppellation sqlAppellation = cf3cbcb0364371d5b761b767c1e6f0f5b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cf49d7edbf8ba354e156efc07efabc27e.c30767ddca1f9c207888833aea5b5fc61(sqlAppellation, num);
						cdfc42b620b77c2686622fe4bf1adfe54.c30767ddca1f9c207888833aea5b5fc61(sqlAppellation, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11516))));
						ce48cb4b06da336c06257d1a19e4f203b.c30767ddca1f9c207888833aea5b5fc61(sqlAppellation, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11520))));
						ccc74530368148b3781ea9771b95ec2e6.c30767ddca1f9c207888833aea5b5fc61(c8b9f6d5795ad46382d8995a207ead655.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlAppellation);
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
					if (!true)
					{
						RuntimeMethodHandle arg_107_0 = methodof(SqlCore.c8f321a05e6cc03f0b89c349dc4a88121()).MethodHandle;
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
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0003CED4 File Offset: 0x0003B0D4
		private void c499057504477d2b9ca610d0a3a69a1dd()
		{
			c269b03762a17b051420007cde272d857.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c5be71b39d96c7e88adbc01dc07ede3aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138035));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11524));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11528)));
						SqlScheduleItem sqlScheduleItem = c4bc1bc34906045fe5d0f9a4ef6fa7fb2.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c9e7ae5cfbe72d5b5c42ae0398eaae3eb.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, num);
						c5361491e67564138fd89eab209d1f86d.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11532))));
						c0af6ff56147103f991e7850dfd566eb8.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11536))));
						cd49e7f616499755b0e2a7c326ae3b68b.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11540))));
						c5f08e3d331248af45cb4f8c9d06ba253.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11544))));
						c164c18ecd79427011e202e35b3526bfb.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11548))));
						cef4f29bb7af8f19307470fbdfffb5425.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11552))));
						c53555eea0ecfed981832112f086f929b.c30767ddca1f9c207888833aea5b5fc61(sqlScheduleItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11556))));
						c18655b22b9358f30d99d5dadb7711739.c30767ddca1f9c207888833aea5b5fc61(c06f20c1a7657eb5a3a9f11f669f6e257.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlScheduleItem);
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
					if (!true)
					{
						RuntimeMethodHandle arg_1BC_0 = methodof(SqlCore.c499057504477d2b9ca610d0a3a69a1dd()).MethodHandle;
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0003D108 File Offset: 0x0003B308
		private void c326ffa42d262f57da53964ed5100e013()
		{
			c91ad5de43e12396a230a46c221a75e9d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c58fd3f07e58564048b3cde25c5ba0827.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138235));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11560));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11564)));
						SqlExpertLimit sqlExpertLimit = ca4104e55e7903b350a5964ade65ee492.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c069b1c59ff045a00a16944e8fef5ac2b.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit, num - (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11568));
						c8aa0166babd36c8e4472e93a187ad221.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11572))));
						c0cb014d2b34a4c964ce1c5043eec1b6a.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11576))));
						c3f617d76c764a55b0fbd8aaa3b78cb76.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11580))));
						caba3cfd568c27ccf8465344c24df34e7.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11584))));
						c87029e5b313697d8f214dc7fb8284105.c30767ddca1f9c207888833aea5b5fc61(c6624df94015a09b0925f7ddb83f328ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cf47c08ccb4d03f2db337bee5cddda637.c30767ddca1f9c207888833aea5b5fc61(sqlExpertLimit), sqlExpertLimit);
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
					if (!true)
					{
						RuntimeMethodHandle arg_162_0 = methodof(SqlCore.c326ffa42d262f57da53964ed5100e013()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007D5 RID: 2005 RVA: 0x0003D2E0 File Offset: 0x0003B4E0
		private void ce9de03318b2ec9857212c4788abf5f06()
		{
			cde2a4ebb9d1321ac8790f09ea16f5466.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c4bfaf42c7ebe111bcbe423a393275f67.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138358));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11588));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11592)));
						SqlCharacterBuff sqlCharacterBuff = cb409eebcac245e48f5088cb89accb167.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c3e896ddfe6f06009876ed4b7eaf16db9.c30767ddca1f9c207888833aea5b5fc61(sqlCharacterBuff, num);
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11596)));
						if (c292e7af346687cd51cd72d5d2d876247.c30767ddca1f9c207888833aea5b5fc61(cd3c03efb5d2b68122a7cc00b4025d6d8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_D1_0 = methodof(SqlCore.ce9de03318b2ec9857212c4788abf5f06()).MethodHandle;
							}
							cc5431582d023c280a64b1451a102eae0.c30767ddca1f9c207888833aea5b5fc61(sqlCharacterBuff, c8ca3191c4e3fe56edaf2c3ccc7949fce.c30767ddca1f9c207888833aea5b5fc61(cd3c03efb5d2b68122a7cc00b4025d6d8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c26922c44217e9079796e7da799fcc976.c30767ddca1f9c207888833aea5b5fc61(sqlCharacterBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11600))));
						c28b79c8537ca0ed3fd04a28fc575e368.c30767ddca1f9c207888833aea5b5fc61(c20c868fb5c976c4f3e502fca13a816c3.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), sqlCharacterBuff);
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0003D48C File Offset: 0x0003B68C
		private void cf7aeeb7f248e725f4ebbc79c3a360f01()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138465));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11604));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11608)));
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11612)));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11616)));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_D2_0 = methodof(SqlCore.cf7aeeb7f248e725f4ebbc79c3a360f01()).MethodHandle;
							}
							if (c70c4cecf449a99317d56daab248a55d1.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								c18cedd6eb9cc7dc248909c5b5d3660aa.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), c17c43bc0d3fbee21a6ef8c0de88b4544.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							}
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0003D634 File Offset: 0x0003B834
		private void cb20ba848b882613aa52cd7e6ba702a71()
		{
			c3f5849b3706042c0165aae4c028724b6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ce9972dae0ebb32e50560806d9c7b2dcb.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138562));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11620));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11624)));
						SqlHousing sqlHousing = c2c63853873279de86efda97c86edd08e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c738ad66113d763efa0cca3c8ccbbf7c7.c30767ddca1f9c207888833aea5b5fc61(sqlHousing, num);
						ce7a5373d78884a144ee29e9ee89613f4.c30767ddca1f9c207888833aea5b5fc61(sqlHousing, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11628))));
						cbc94d53336b1088a213594b0f501939f.c30767ddca1f9c207888833aea5b5fc61(sqlHousing, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11632))));
						cece6c45c4fb863ec216f8331581e9b40.c30767ddca1f9c207888833aea5b5fc61(sqlHousing, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11636))));
						ceda9050df7c527367dafb682ce124479.c30767ddca1f9c207888833aea5b5fc61(sqlHousing, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11640))));
						c23991473e3e08a59f1253e708cd14f89.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlHousing);
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
					if (!true)
					{
						RuntimeMethodHandle arg_14F_0 = methodof(SqlCore.cb20ba848b882613aa52cd7e6ba702a71()).MethodHandle;
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

		// Token: 0x060007D8 RID: 2008 RVA: 0x0003D7FC File Offset: 0x0003B9FC
		private void c767f865e19b1f99366e1f689367a5147()
		{
			List<SqlDoodadFuncGroup> list = c96b900f67d42d852dada13af67ce7937.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)).ToList<SqlDoodadFuncGroup>();
			for (int i = c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11644); i < c2669abedf6db64e3ed5c98c68ef5dc26.c30767ddca1f9c207888833aea5b5fc61(list); i += c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11648))
			{
				try
				{
					if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), ""))
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
							RuntimeMethodHandle arg_5A_0 = methodof(SqlCore.c767f865e19b1f99366e1f689367a5147()).MethodHandle;
						}
						if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138673)))
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
							if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(36724)))
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
								if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(34504)))
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
									if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138676)))
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
										if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138679)))
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
											if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138682)))
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
												if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138685)))
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
													if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(33968)))
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
														if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138688)))
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
															if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138691)))
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
																if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138694)))
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
																	if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i)), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138699)))
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
																		string expr_2BE = cc8be2b9893d17b1baabfcf88fbe4375e.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i));
																		uint num = c65b0c535c9829535e44f09e1d13d7815.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i));
																		if (!c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(expr_2BE, cbe74434d03032e03663533e1cb398c7c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ref num, c2cb9b8fc302b86cc4e8108a85f0ddc37.c0cf59c3e67a46fd4edb3040c5ab0bbfb())))
																		{
																			goto IL_32F;
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
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					c8cf0dd2a0607e6beec9ab2ed277167c3.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c65b0c535c9829535e44f09e1d13d7815.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i))), ca3f92b24e656b72e4f4cf916704c7a7d.c30767ddca1f9c207888833aea5b5fc61(cd2dc7225351969c548746a3cd5f5a3cf.c30767ddca1f9c207888833aea5b5fc61(cba35015d3225b8e3a3b7c35b730afe70.c30767ddca1f9c207888833aea5b5fc61(list, i))));
					IL_32F:;
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
			list = cbe9976b104834a3d939ddef805b5132d.c8a754f5f2ca4adde825691a9c31a0e83;
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0003DB94 File Offset: 0x0003BD94
		private void c9e1a5b5f30463abde704f48bc7bcc08b()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138704));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11652));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11656)));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11660)));
						uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11664)));
						uint num4 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11668)));
						string text = SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11672)));
						uint num5 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11676)));
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138926)))
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
								RuntimeMethodHandle arg_13C_0 = methodof(SqlCore.c9e1a5b5f30463abde704f48bc7bcc08b()).MethodHandle;
							}
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138953)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138996)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								c9949fc8c6f216e0c1e99f3a92b31c567.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), c99f3e0c9b83b7b32377f7f360f745702.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
								c447b355edfa45b4bfede63d98e01dde1.c30767ddca1f9c207888833aea5b5fc61(cf759ff9d97a71f768f1605e15ff52468.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), num3);
								c6bb21f384b0c74d2c2f1c21e5ee936f6.c30767ddca1f9c207888833aea5b5fc61(cf759ff9d97a71f768f1605e15ff52468.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), num5);
								c8eedf24e06fb77b249de383e99c78ed5.c30767ddca1f9c207888833aea5b5fc61(cf759ff9d97a71f768f1605e15ff52468.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), num2);
								continue;
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139035)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c022a842fa2ae0754243f492941f85d8d.c30767ddca1f9c207888833aea5b5fc61(cf035c48f776231f87e8c67f609bc707e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4))
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
									if (c1d8bbba9911373b89f0d0b1269858030.c30767ddca1f9c207888833aea5b5fc61(c9354f12bc312750d64b8013759264be6.c30767ddca1f9c207888833aea5b5fc61(cf035c48f776231f87e8c67f609bc707e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4)) != null)
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
										c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c1d8bbba9911373b89f0d0b1269858030.c30767ddca1f9c207888833aea5b5fc61(c9354f12bc312750d64b8013759264be6.c30767ddca1f9c207888833aea5b5fc61(cf035c48f776231f87e8c67f609bc707e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4)));
										continue;
									}
									if (c1d8bbba9911373b89f0d0b1269858030.c30767ddca1f9c207888833aea5b5fc61(c9354f12bc312750d64b8013759264be6.c30767ddca1f9c207888833aea5b5fc61(cf035c48f776231f87e8c67f609bc707e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4)) != null)
									{
										continue;
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
									if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
										c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
										continue;
									}
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139070)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c9dc8208a3dee49b3f888b8c2ef4984de.c30767ddca1f9c207888833aea5b5fc61(cd3c572ef60c136561410d73a95695a0a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4))
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
									if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c5c6d76d7b861be01f17878cb799d0939.c30767ddca1f9c207888833aea5b5fc61(ce7899d481e6c20de013ea732bcb8fda5.c30767ddca1f9c207888833aea5b5fc61(cd3c572ef60c136561410d73a95695a0a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4))))
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
										c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c5c6d76d7b861be01f17878cb799d0939.c30767ddca1f9c207888833aea5b5fc61(ce7899d481e6c20de013ea732bcb8fda5.c30767ddca1f9c207888833aea5b5fc61(cd3c572ef60c136561410d73a95695a0a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4))));
										continue;
									}
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139119)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c1193f5701b7116333dbbb28af9494afe.c30767ddca1f9c207888833aea5b5fc61(ca530a34685cdcc17f52ff79fd623d328.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4))
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
									c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11680);
									if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
										cc0ffc0209ea8f6bf26af31406138401d.c30767ddca1f9c207888833aea5b5fc61(c432bcb9801e2affc4cc6adfee3655385.c30767ddca1f9c207888833aea5b5fc61(ca530a34685cdcc17f52ff79fd623d328.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									}
									c8c0e1da209eb792693ba9a091c035c12.c30767ddca1f9c207888833aea5b5fc61(cb6a16d6da73e081da72abcfc62c8166e.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), c432bcb9801e2affc4cc6adfee3655385.c30767ddca1f9c207888833aea5b5fc61(ca530a34685cdcc17f52ff79fd623d328.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139160)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c6624fb0ac089f18d26b62aff578973a0.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139201)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								c5e510b6e67e2fc69aee9761dde685e3c.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11684) != 0);
								continue;
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139252)))
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
							if (c0f1c8988db14979f966d509e52f32516.c30767ddca1f9c207888833aea5b5fc61(cc4851452aacae34dbdf6d47609cd62aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4))
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
								if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									cd104edc5778a5b1bb0689cf54be80c0b.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), c968432cb0d621d2c76a83c209ce99353.c30767ddca1f9c207888833aea5b5fc61(cc250a7960b3920c2b834c4ff0b303734.c30767ddca1f9c207888833aea5b5fc61(cc4851452aacae34dbdf6d47609cd62aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4)));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139291)))
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
							if (c3780134a507d592c1126f2453ef7d3fb.c30767ddca1f9c207888833aea5b5fc61(cf9fafe6dd0cb14e5766aa7067ab8ced8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4))
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
								if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									c0862fb3ecd08146d436398a91db7d7ad.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), c977195dcf3902345a6996748824ee736.c30767ddca1f9c207888833aea5b5fc61(cf9fafe6dd0cb14e5766aa7067ab8ced8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num4));
									c011c2a06f005acc66e40fb7200d239e5.c30767ddca1f9c207888833aea5b5fc61(c4ccf2c31a2b455e788328cda7d55070b.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), num);
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139328)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139381)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139428)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139467)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(138953)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139502)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c994887b7ec0c72a20a8bb7f480501f40.c30767ddca1f9c207888833aea5b5fc61(c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
									continue;
								}
							}
						}
						if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(text, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139551)))
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
							if (cd1097eb56d1e44f90e3ff0c93d6835a0.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c1a9700d9c0b25c403abf00924938096f.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2).fishBuySkillId = num3;
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

		// Token: 0x060007DA RID: 2010 RVA: 0x0003E7D4 File Offset: 0x0003C9D4
		private void c8bdc5035c1e58f744d8f3ca5cfd4311b()
		{
			c8c22b73c4e9266bae34d52d8e2124ced.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cc965b755d0854664a4951207ab981f38.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139586));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11688));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11692)));
						SqlDoodadFuncGroup sqlDoodadFuncGroup = c57ce1467176facd02f3f2cc41424b9ff.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c6d682214bb3521c52071fc738de76e2f.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncGroup, num);
						c8cf0dd2a0607e6beec9ab2ed277167c3.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncGroup, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11696))));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11700)));
						if (c129fb2f83ee1580675b039b954aeeaec.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								RuntimeMethodHandle arg_F5_0 = methodof(SqlCore.c8bdc5035c1e58f744d8f3ca5cfd4311b()).MethodHandle;
							}
							c131fa0e2f829bab8e429c51a20a81a19.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadFuncGroup, c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
							c0c4595f60249684302b6b9f76999385c.c30767ddca1f9c207888833aea5b5fc61(c788a0ffdedcd7f3a8b3de0202ff90090.c30767ddca1f9c207888833aea5b5fc61(c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), sqlDoodadFuncGroup);
						}
						c9878ca3a6a0d808cabc22a07a87adb5b.c30767ddca1f9c207888833aea5b5fc61(c1af96cfae4c0c0bae742028668bc15bc.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlDoodadFuncGroup);
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
							switch (1)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0003E9A0 File Offset: 0x0003CBA0
		private void cf29b0029d3166d3b7f09fbca4316dc77()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139705));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11704));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11708)));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11712)));
						if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_B0_0 = methodof(SqlCore.cf29b0029d3166d3b7f09fbca4316dc77()).MethodHandle;
							}
							ccde32370b82edb913ce9583cd4f9849a.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), num2);
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0003EAE0 File Offset: 0x0003CCE0
		private void c252f855fc13dabf0aa6f39d44752c50a()
		{
			c554d51e9d87d0d0bc7264051454765c6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c57f8c91260dcb5d331a6e62d4602315d.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139804));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11716));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11720)));
							SqlDoodadAlmighty sqlDoodadAlmighty = c8845167acd6d00afe480c3a27835b17b.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							cdb3937fe93eca879799846be992e2edd.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadAlmighty, num);
							c808d780aff009b3886d75d12673769b6.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadAlmighty, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11724))));
							c5ac169b50f8dbf4aae89f0bd00949707.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadAlmighty, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11728))));
							caf01a45529adc21c2f3d79992077b090.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadAlmighty, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11732))));
							c9bf2b83a4859c5da7f27b9d91a8ab10a.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadAlmighty, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11736))));
							c4b051145c27e8df6da258a4a819f4123.c30767ddca1f9c207888833aea5b5fc61(sqlDoodadAlmighty, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11740))));
							ca9708375391f006d9411ca3534272788.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlDoodadAlmighty);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (!true)
					{
						RuntimeMethodHandle arg_187_0 = methodof(SqlCore.c252f855fc13dabf0aa6f39d44752c50a()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0003ECF8 File Offset: 0x0003CEF8
		private void c118eaf98e37434c481129042e6aab90a()
		{
			cea03911ef2b678407baa5e40622a8045.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c0edc16061a3f9342767bfce81cbeeee2.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(139976));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11744));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11748)));
						SqlZoneGroup sqlZoneGroup = c70765143851dee15501bb64a3d72e8ac.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c56526706209d01025ea463026ac4209e.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, num);
						cc6e16faf67be9b10d1faa8e240a6d5f3.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11752))));
						c50cd2b46e6af99257a9f895346d223d8.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11756))));
						caa3bfc720fa1e10c4a237dd08b5c9ef4.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11760))));
						c56fe553421afdf31a08a12c0d1eacd60.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11764))));
						cdfc3075908a4804155232b84384764e1.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11768))));
						c4a4db68996217058c42f117fc498b88e.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11772))));
						cdda78f1887e0329e92e96058ea882835.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11776))));
						cc559502c55fc794d23b9008e54e22eed.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c033b1b9f1b9eef1ad10449f2449b6bfd.c30767ddca1f9c207888833aea5b5fc61(sqlZoneGroup), sqlZoneGroup);
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
						RuntimeMethodHandle arg_1C2_0 = methodof(SqlCore.c118eaf98e37434c481129042e6aab90a()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007DE RID: 2014 RVA: 0x0003EF30 File Offset: 0x0003D130
		private void c6f94d6c418f4f6aac6b176d89dc9793e()
		{
			cc7ceae92373f59da7c2c7a4b37b9d259.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cbd2553e62805c05ea2fff01d36337831.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(140116));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11780));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11784)));
						SqlZone sqlZone = cbcbee5bedbb7dda46eaa733c3c0ea918.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c4e7c0de640635a24ef0c62187ee19ec3.c30767ddca1f9c207888833aea5b5fc61(sqlZone, num);
						c7b4bac04cb0fff6a24c18cb8f525c482.c30767ddca1f9c207888833aea5b5fc61(sqlZone, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11788))));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11792)));
						c65524a74d81a0e0a49b648768c1c0877.c30767ddca1f9c207888833aea5b5fc61(sqlZone, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11796))));
						c94301750fdaeb9df84a4c407d1f3297f.c30767ddca1f9c207888833aea5b5fc61(sqlZone, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11800))));
						uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11804)));
						if (num3 > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11808))
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
								RuntimeMethodHandle arg_15A_0 = methodof(SqlCore.c6f94d6c418f4f6aac6b176d89dc9793e()).MethodHandle;
							}
							if (c8d312256425a2d85a74f1a35a4f10044.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
								c62e405c975ef3a92bad14c43fd465b41.c30767ddca1f9c207888833aea5b5fc61(c457fa60720431d201a6bab70d86762b0.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2), num3);
							}
						}
						if (c8d312256425a2d85a74f1a35a4f10044.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
							c5ef5eb3632591a254eccb7226c01f545.c30767ddca1f9c207888833aea5b5fc61(sqlZone, c457fa60720431d201a6bab70d86762b0.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c29a166bd16147cf946b23d340b683f1e.c30767ddca1f9c207888833aea5b5fc61(c9cb2d039ea85b1f6043d05acb4bc5b10.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlZone);
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
							switch (7)
							{
							case 0:
								continue;
							}
							break;
						}
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007DF RID: 2015 RVA: 0x0003F190 File Offset: 0x0003D390
		private void c6cb7d2b090f3cf982a9474f5367be0d7()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(140324));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11812));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						SqlSpecialty sqlSpecialty = c6810082ed0861ec13f1cf1164e26ee7e.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c82a89894c021bbd8ea0b53f24f3e985e.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialty, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11816))));
						cc2e47c9fbefb7c47713b80c05a8a7257.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialty, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11820))));
						c8c60d08ab6c7d965778e14106c5ba7d3.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialty, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11824))));
						c3d0a447046ecf686b47e0b6086e17a37.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialty, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11828))));
						if (c8d312256425a2d85a74f1a35a4f10044.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca72e8141daebca2db7adac4999328c1d.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialty)))
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
								RuntimeMethodHandle arg_113_0 = methodof(SqlCore.c6cb7d2b090f3cf982a9474f5367be0d7()).MethodHandle;
							}
							c1f61e6ffbcd7d4d575ff61b99433829f.c30767ddca1f9c207888833aea5b5fc61(ca4ce6a7f48aae340b05b1b538fa03475.c30767ddca1f9c207888833aea5b5fc61(c457fa60720431d201a6bab70d86762b0.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ca72e8141daebca2db7adac4999328c1d.c30767ddca1f9c207888833aea5b5fc61(sqlSpecialty))), sqlSpecialty);
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0003F358 File Offset: 0x0003D558
		private void c321859fcea417e64549916f0143466bc()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(140476));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11832));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11836)));
						bool flag = this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11840)));
						if (c8d312256425a2d85a74f1a35a4f10044.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
								RuntimeMethodHandle arg_B4_0 = methodof(SqlCore.c321859fcea417e64549916f0143466bc()).MethodHandle;
							}
							c833e4ecf35c135077e347e2684faf584.c30767ddca1f9c207888833aea5b5fc61(c457fa60720431d201a6bab70d86762b0.c30767ddca1f9c207888833aea5b5fc61(cc7cada798b0c8eb62d679aff560a9261.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), flag);
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
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0003F49C File Offset: 0x0003D69C
		private void cafb7c16e2c6781241da38bf555bbba06()
		{
			cb2b7f29d8e2b593ca234d2ce06e8914d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca3cca94b62124bdbc2cc4c076f31ff09.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(140561));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11844));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11848)));
						SqlSubZone sqlSubZone = cd163f688712aaba16f640fda75acc861.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c13a892973855dac1eaa798b98e387430.c30767ddca1f9c207888833aea5b5fc61(sqlSubZone, num);
						cbd2dbd7fe40cbe036fc31a7e2fc734a5.c30767ddca1f9c207888833aea5b5fc61(sqlSubZone, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11852))));
						c731309e945e8ac95d42aebf3695ed748.c30767ddca1f9c207888833aea5b5fc61(sqlSubZone, (double)SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11856))));
						c1ea057a5ba0c66f4551f838e99183caf.c30767ddca1f9c207888833aea5b5fc61(sqlSubZone, (double)SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11860))));
						ccc4bd8c15ec0a1e395426e1de32426f0.c30767ddca1f9c207888833aea5b5fc61(sqlSubZone, (double)SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11864))));
						c32bbe3d560d567e25f54658c95f190fd.c30767ddca1f9c207888833aea5b5fc61(sqlSubZone, (double)SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11868))));
						cbe753ba4a5ef696be964993d729ee775.c30767ddca1f9c207888833aea5b5fc61(cf32a865a639973ea58e45b85ec95d111.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlSubZone);
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
						RuntimeMethodHandle arg_177_0 = methodof(SqlCore.cafb7c16e2c6781241da38bf555bbba06()).MethodHandle;
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0003F68C File Offset: 0x0003D88C
		private void c6f42c7fefe77f467144f19e93b336722()
		{
			c1ed0c57d31d0452b77a67e95620c90c4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c637daa4bdfaee9f2327c04c4616debd4.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(140646));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11872));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11876)));
						SqlLevel sqlLevel = c58c1b228d0bfc5c5ce34fb48060e6c3a.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cc59d07c39de5ecf050c326f2025c1054.c30767ddca1f9c207888833aea5b5fc61(sqlLevel, num);
						c67b3e77fdba7018a99bcdcbce5f6bbd1.c30767ddca1f9c207888833aea5b5fc61(sqlLevel, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11880))));
						cde652753d02dc39ff65548a4f5d13b6c.c30767ddca1f9c207888833aea5b5fc61(sqlLevel, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11884))));
						ccca9b55c8a137f1ef814a36c520c84d4.c30767ddca1f9c207888833aea5b5fc61(sqlLevel, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11888))));
						c15311e590fbfbdc1d4265c1e9557825d.c30767ddca1f9c207888833aea5b5fc61(ccc3e419615259a6d394934110192cd27.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlLevel);
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
						RuntimeMethodHandle arg_12B_0 = methodof(SqlCore.c6f42c7fefe77f467144f19e93b336722()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0003F830 File Offset: 0x0003DA30
		private void cede1675f076014f634ff7471672402c9()
		{
			cb99a1117a58ef543f04a2d537cbd3340.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca35a3b6daf8bdb171c8c6755f2fb0c31.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(140771));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11892));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11896)));
						SqlDefaultSkill sqlDefaultSkill = cafcf2f5dff2f757d8a4a393311efb064.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						cda4f34b60021546f6b39c744718448ee.c30767ddca1f9c207888833aea5b5fc61(sqlDefaultSkill, num);
						cea636dd0d26b93de4ee61604314c8813.c30767ddca1f9c207888833aea5b5fc61(sqlDefaultSkill, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11900))));
						c4cf80a158d362cbc7ed01a383bc83e39.c30767ddca1f9c207888833aea5b5fc61(sqlDefaultSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11904))));
						c96e3e6e8d306d90b78f8a6b815b39fcb.c30767ddca1f9c207888833aea5b5fc61(c648f6b58c92fea172956087588fb9353.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), sqlDefaultSkill);
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
						RuntimeMethodHandle arg_106_0 = methodof(SqlCore.cede1675f076014f634ff7471672402c9()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0003F9AC File Offset: 0x0003DBAC
		private void c1a3f6d8536c7d3d1c0cc7ae14832676b()
		{
			ce33dcf9a2833c02a0a05d39f1196f2e4.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c20ec2cde07b2a155754179d579d7e72e.ce8915750eb2dc86a075214c6cf229baa(c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11908)));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11912)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11916)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11920));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11924)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59327));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11928)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11932)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11936));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11940)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59580));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11944)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11948)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11952));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11956)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59661));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11960)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11964)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11968));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11972)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59733));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11976)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11980)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11984));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11988)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59808));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11992)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(11996)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12000));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12004)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59486));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12008)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12012)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12016));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12020)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59394));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12024)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12028)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12032));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12036)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(59906));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12040)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12044)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12048));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12052)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(60008));
			cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12056)] = c96913261b8207516df9a121a5deab02f.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
			cdbca8e536842f362ea4ace19d3a377e3.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12060)], (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12064));
			c235a73dd28945ff2a09e187d0024ec4a.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12068)], c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(60097));
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0003FD90 File Offset: 0x0003DF90
		private void c2599f249c63ca6b92380683b7634563c()
		{
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(140898));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12072));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						SqlSkillReagent sqlSkillReagent = caabc8f02c41e496e32f2862dbeb51aea.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c3474f0c5e1ec6b4d45fd1b7d83dc6a60.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReagent, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12076))));
						cbec4b475c6832002d5e6d266f5c60f09.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReagent, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12080))));
						c711d0cfaec9f831332e5273ef65959e0.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReagent, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12084))));
						c94de9c4f80172f92daedabb4edb77e37.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReagent, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12088))));
						if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c5045a61c86ab73d7407c9048ccb7d65b.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReagent)))
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
								RuntimeMethodHandle arg_113_0 = methodof(SqlCore.c2599f249c63ca6b92380683b7634563c()).MethodHandle;
							}
							cdfb0197f3f68b2f7be2b416addeb3dd1.c30767ddca1f9c207888833aea5b5fc61(c03e5f8388f83f683ddb5e98427174f64.c30767ddca1f9c207888833aea5b5fc61(cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c5045a61c86ab73d7407c9048ccb7d65b.c30767ddca1f9c207888833aea5b5fc61(sqlSkillReagent))), sqlSkillReagent);
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
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007E6 RID: 2022 RVA: 0x0003FF58 File Offset: 0x0003E158
		private void c93df1af1daf331daf2878c233e64c426()
		{
			c10e7582baf0a5e7ba42f88f5b10ec452.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c8349233743ffc19522d3838220bc7ae6.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(141011));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12092));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12096)));
						SqlItemCategorie sqlItemCategorie = ca01318ad782655d99e6b38ecef503ef1.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c58cb3340f2bc58ceff1868169653e3b2.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, num);
						ce7283b1cf066c6a03ee4cb6aba4c658b.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12100))));
						c2dbc62c22a576d62c6d3df2945f3cc06.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12104))));
						cabe70f4c489a65a231747960ed31e1bd.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12108))));
						c403c6a4c7ef91d663f38374973c0f2d2.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12112))));
						c972e599259024d08bbbc9d9edc1882f6.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12116))));
						cbec37a8c2ba6cd9bba9d794af64849e3.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12120))));
						cef6caa0f98188cc1fb8973bfc083cd31.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12124))));
						if (ccd57fed770a9c6c7c05995622f01179a.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12128))
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
								RuntimeMethodHandle arg_1AE_0 = methodof(SqlCore.c93df1af1daf331daf2878c233e64c426()).MethodHandle;
							}
							c0b94b0594b18d3143267a49a94563a61.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie, c856d946e00dee3f0f9c57801a4f563cd.c30767ddca1f9c207888833aea5b5fc61(c10a633fa3abc4a913663035836bf8c4d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), ccd57fed770a9c6c7c05995622f01179a.c30767ddca1f9c207888833aea5b5fc61(sqlItemCategorie)));
						}
						c7b82b1d9369f90768012295a68950bd7.c30767ddca1f9c207888833aea5b5fc61(c9f639aa43ffe834a0d8d39b39a321f7b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlItemCategorie);
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007E7 RID: 2023 RVA: 0x000401C4 File Offset: 0x0003E3C4
		private void cd9aa9527ab367e603d190bc5d6d8b041()
		{
			c0f7682d66984ec7fb7795562547fdac6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c3ab460e5db33a1eabc0e10b2a67425f7.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(141247));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12132));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12136)));
						SqlItemGroup sqlItemGroup = c9c2dd14776a62cd3be74d0d1b7223686.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c054955d9b58928becc63ad7e373cd82b.c30767ddca1f9c207888833aea5b5fc61(sqlItemGroup, num);
						c657865155e29f6263fe4654b7eeb197d.c30767ddca1f9c207888833aea5b5fc61(sqlItemGroup, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12140))));
						c769efcbb833a7c13ac000dc1db170384.c30767ddca1f9c207888833aea5b5fc61(sqlItemGroup, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12144))));
						c2ecfcf05fb66304f579d62a681cfb2c9.c30767ddca1f9c207888833aea5b5fc61(c10a633fa3abc4a913663035836bf8c4d.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlItemGroup);
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
						RuntimeMethodHandle arg_108_0 = methodof(SqlCore.cd9aa9527ab367e603d190bc5d6d8b041()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00040344 File Offset: 0x0003E544
		private void c7fe8be6d023c3103c096c401c6611ae9()
		{
			c6eecb80d15a01523779d5ce574657a2e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c901179546f4f3bb55a53afc46eb8c54e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				try
				{
					c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(141381));
					cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12148));
					c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
					try
					{
						while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12152)));
							SqlSkill sqlSkill = cc8e8d76b9ed2573ec35ab88ac344b2f8.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							ceb9a3f90e84b6f2bd0a3c6a8bafc377c.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, num);
							c2ae06275d93cef213a10cac2489c3cca.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12156))));
							cee564375a60fe023a6077f8c61619767.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12160))));
							cc3c62a88a8956b6f393de95b6ca6b033.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12164))));
							cb8fb673988b8d3034075f3c99500980a.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12168))));
							cf788a7b1bf451405e8d0a837b02cde3b.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.cbb7abf924087b4fc4ab344f9dfdf9526(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12172))));
							cb8a664b02d7117fcadf3fc5c880edd3c.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12176))));
							c5d922ff67d83a0a8b6e9511b58f4224f.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12180))));
							ce808a42c93903843951dd862ec7ff37f.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12184))));
							c55b4d6f6a8680ce072b42db5c7e9c654.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12188))));
							cdcb01a3214cd655a80cacea9a4c221ae.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12192))));
							c2efca2dfaa9769cac3f0efc802bd6abe.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12196))));
							c83678253aa14bac0732fa785529b58df.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12200))));
							cc1f9e1d2053742f37882ca0f5f8260f0.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12204))));
							cdaf7f3de8530d126d696b7d4bac85cd7.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12208))));
							cd4caf871426cc0dcc05293034e588802.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12212))));
							c15a725c661c8e590b5a5e2c25badb62e.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12216))));
							c9d0903f7c41499eab916812813fb61e0.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12220))));
							c489555d39ccdb266f86fdf2f7b0c744b.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12224))));
							ca1d2c6246e1db56d8ec309eccdf8495e.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12228))));
							c62a5f8ba68e8ce80f506372e4f672fbe.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12232))));
							cfac52090388c49f7fe63d23e6fc058ab.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12236))));
							cb7e101e6de369bc77ff0338d812d03f6.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12240))));
							ccc0cd613f4f79f6a33cc8419ffe3fc4f.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12244))));
							c91806b29288ac6407d342b7a32cb2d04.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12248))));
							c56823e90d70b8a397b5e08d576444cbe.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12252))));
							c96c66b29f7401af86b84a9ef9c626c73.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12256))));
							cb30bf4bef21614dfb9613b2f93250636.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12260))));
							c345d4ee3ad7d91aa312ea024f675ab79.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.cab0e03f3a874c26876bb7a3b4d40d163(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12264))));
							c9948e14cb4dabd3f5c7408c7dc5eaa11.c30767ddca1f9c207888833aea5b5fc61(sqlSkill, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12268))));
							if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) != 0)
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
									RuntimeMethodHandle arg_4CA_0 = methodof(SqlCore.c7fe8be6d023c3103c096c401c6611ae9()).MethodHandle;
								}
								if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12272))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12276)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12280))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12284)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12288))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12292)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12296))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12300)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12304))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12308)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12312))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12316)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12320))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12324)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12328))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12332)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12336))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12340)]), sqlSkill);
								}
								else if (cee7dea64b8b8a484e514aaa6be56c89d.c30767ddca1f9c207888833aea5b5fc61(sqlSkill) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12344))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(cff559ab17493f2a507a091a4b4b529c6.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12348)]), sqlSkill);
								}
							}
							ce6d76d97ccd1bff17a0ad5382da7bf78.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlSkill);
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
						if (sQLiteDataReader != null)
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
							cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
						}
					}
				}
				catch (Exception ex)
				{
					cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00040B70 File Offset: 0x0003ED70
		private void ca5cd052fed73fe48e6ddb273cea60826()
		{
			ca0488e9b6b9dfcd5b487b4c6cad9ef20.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cd6e3da22aadcce9c6af3e7546746c7a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(142629));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12352));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12356)));
						SqlUnitFormulaVariable sqlUnitFormulaVariable = cd6ba7b77dbd29eb0fee6e1ed35cd8b27.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c961cd4b47fca8ab29f72f14a195f8c46.c30767ddca1f9c207888833aea5b5fc61(sqlUnitFormulaVariable, num);
						c643fe4d0c89e734853039b86e72347a4.c30767ddca1f9c207888833aea5b5fc61(sqlUnitFormulaVariable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12360))));
						cb7361595102a14ce4c2734fcdf130334.c30767ddca1f9c207888833aea5b5fc61(sqlUnitFormulaVariable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12364))));
						c1233ac3b0357e0bbec17539f9e1cbba4.c30767ddca1f9c207888833aea5b5fc61(sqlUnitFormulaVariable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12368))));
						c74c053a6ea1f5ad96105d55e0977268d.c30767ddca1f9c207888833aea5b5fc61(sqlUnitFormulaVariable, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12372))));
						cfbd728fd8dd046d9d65f685d18f822dc.c30767ddca1f9c207888833aea5b5fc61(c7f37d2bb35d4acbc5ef787ee7baec76c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), sqlUnitFormulaVariable);
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
						RuntimeMethodHandle arg_14E_0 = methodof(SqlCore.ca5cd052fed73fe48e6ddb273cea60826()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00040D34 File Offset: 0x0003EF34
		private void c18680d45c96aba74b688bde9020efe6d()
		{
			cbc6051b337d54040c061dbb5fc991908.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c9bc001d56da2749d33b3cf83dc0cd992.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(142833));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12376));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12380)));
						SqlNpc sqlNpc = c423dc45b27ca6bd6b37ad65999574726.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c18e4aae8e182d24e66a71f7565f0f0be.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, num);
						c3afd8c71d7298920076955bd650bbd26.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12384))));
						c2b24ed64283bbcf884f7be228281b7b0.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12388))));
						c2c92a21d81bdbceb000544845dabb09c.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12392))));
						cd157168a53e4d8fbc4eeca3401ce3f3b.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12396))));
						cc02725aac7774a63ec0b861bcbcf6b56.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12400))));
						c5cc2730f3f552069cdbf1792268260ab.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12404))));
						ca8f0a62f014926068eff0be630e2e85d.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12408))));
						cb768b5abb582df140c2035a04795ced7.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12412))));
						c2a2acec4d5f519fbcb2683d19e39ff16.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12416))));
						c1f0b02f4b293175a889834f04b306c80.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12420))));
						c3821b5a146bbdc4a161dc65dbc7896ff.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12424))));
						uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12428)));
						c996ab2c20ad5a75a48505a0f4ac6493c.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12432))));
						c2d297e5251a3908b3577fbdee8492823.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12436))));
						cb37344ca377e9ec3f5737a1ea0870dce.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12440))));
						c3141e2f8ec6b8f50ed8339400b1c0c83.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12444))));
						c5e12a3d5ffbf5c61c8e7f5d1661f54b4.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12448))));
						c1c1aa4955e5144f02a8a888e9e17c5c4.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12452))));
						cc2bc891a440c4aa99cc75a6c1879939f.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12456))));
						c69cdfee725f5caaf7b3f767a1f87c71d.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12460))));
						if (cfc57f486803be7593e9bd407e7742d81.c30767ddca1f9c207888833aea5b5fc61(sqlNpc) != (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12464))
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
								RuntimeMethodHandle arg_387_0 = methodof(SqlCore.c18680d45c96aba74b688bde9020efe6d()).MethodHandle;
							}
							c3821b5a146bbdc4a161dc65dbc7896ff.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12468));
						}
						if (c8a446629a5d2b0a8aa22208ae15f284d.c30767ddca1f9c207888833aea5b5fc61(c6c4866c61737748d5f1ae6844e91b6a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
							c4794e9175c0dca64c2696f2c8fcc022a.c30767ddca1f9c207888833aea5b5fc61(sqlNpc, c8935034383fb2a7e4f2d66d87c9d7edd.c30767ddca1f9c207888833aea5b5fc61(c6c4866c61737748d5f1ae6844e91b6a7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
						}
						c4cfcb103e5b85356db7589d1e76987c8.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlNpc);
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000411A0 File Offset: 0x0003F3A0
		private void c8cdc0ef585308c183674d610394707fa()
		{
			cd0bc0a9f136406f83badbedb14a4597f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c950b8a97da0c7db0609838ceee2222d7.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(143723));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12472));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12476);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						SqlWearable sqlWearable = c8b09802542d1bf729fa51293e1debe52.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c7df584319d63e19a5f4b9582f798c710.c30767ddca1f9c207888833aea5b5fc61(sqlWearable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12480))));
						c3854bb80658737d0840daa0a0862d985.c30767ddca1f9c207888833aea5b5fc61(sqlWearable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12484))));
						cfee5e947ddf4717c9538182238f5f278.c30767ddca1f9c207888833aea5b5fc61(sqlWearable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12488))));
						c486d19e33b755a9c83a1c0de088921e9.c30767ddca1f9c207888833aea5b5fc61(sqlWearable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12492))));
						cb9b0a7edb78eee880a601ea7e51de6c9.c30767ddca1f9c207888833aea5b5fc61(ca1545833045485e7e1aaf72dd8285b93.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlWearable);
						num += (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12496);
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
						RuntimeMethodHandle arg_141_0 = methodof(SqlCore.c8cdc0ef585308c183674d610394707fa()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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

		// Token: 0x060007EC RID: 2028 RVA: 0x00041358 File Offset: 0x0003F558
		private void c0cd0f29546835372f487f8d4739c4551()
		{
			c5221467713660f69b7040166d632b023.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cb25802cb995517d50211844a080ee235.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(143885));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12500));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12504)));
						SqlHoldable sqlHoldable = cecf2ae9eabb749925cf8760c1b0fcc69.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c59007a73b8c26830f5bdb7511b4f26c4.c30767ddca1f9c207888833aea5b5fc61(sqlHoldable, num);
						ce337e5f56f482051915cfb5915eb1dfb.c30767ddca1f9c207888833aea5b5fc61(sqlHoldable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12508))));
						c55d1a298fa6c58fd8fb2becd305257d1.c30767ddca1f9c207888833aea5b5fc61(sqlHoldable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12512))));
						c5ecf5ce5db4c15d13a671603fdb7717c.c30767ddca1f9c207888833aea5b5fc61(sqlHoldable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12516))));
						c9cd00d088845389663d74adfbb40bfec.c30767ddca1f9c207888833aea5b5fc61(sqlHoldable, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12520))));
						c2f8dabbc9c742388684eb8323daf3466.c30767ddca1f9c207888833aea5b5fc61(sqlHoldable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12524))));
						c4e6e30ded5b7ee257c586265184f9287.c30767ddca1f9c207888833aea5b5fc61(sqlHoldable, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12528))));
						c4d04cdce3f9c7dcf83eab761167775d0.c30767ddca1f9c207888833aea5b5fc61(cabda6a183494e6e5ea3246ed0b954a6f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlHoldable);
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
						RuntimeMethodHandle arg_197_0 = methodof(SqlCore.c0cd0f29546835372f487f8d4739c4551()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00041568 File Offset: 0x0003F768
		private void c168270f988421728a4459b1954b6d626()
		{
			c38943a574e08ddde79cbf4a9aabdb2eb.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c2dc2a0f30aeb73f5077b52d118b2dc90.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(144075));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12532));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12536)));
						SqlEquipItemAttrModifier sqlEquipItemAttrModifier = c1c4763231df3e4ecbb2ae2720e1f0f39.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						ceffd99e90e7359c6355fe62fe258b315.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemAttrModifier, num);
						ced30183f69310bed8dd6102f7cfacdb0.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemAttrModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12540))));
						cf06b8d72bc46d6cca83a824e0b20eb5c.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemAttrModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12544))));
						ce3a29f97328f9b668c5f8369abd3641f.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemAttrModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12548))));
						c3285a07ac58afefd34756db6b2901017.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemAttrModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12552))));
						cc16c0b479ccffe0074f951bf798bbbba.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemAttrModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12556))));
						c1ec6bae736633686a79941dfda828951.c30767ddca1f9c207888833aea5b5fc61(c7c3d0fa2c9a889210fe6e0c0c0cf1ce7.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlEquipItemAttrModifier);
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
						RuntimeMethodHandle arg_173_0 = methodof(SqlCore.c168270f988421728a4459b1954b6d626()).MethodHandle;
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

		// Token: 0x060007EE RID: 2030 RVA: 0x00041754 File Offset: 0x0003F954
		private void cabf2c9960d89049997cd888f51e4edc1()
		{
			c9f5a97a06fee6291c0377917ddbb0cae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c0d3f3e6427f16912f8cc29b093fcb21f.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(144277));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12560));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12564)));
						SqlWearableSlot sqlWearableSlot = c5c21827ba75535f7aa266d58fdef8713.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c2128d29fcd3c741f2d5572e9f4f0bba9.c30767ddca1f9c207888833aea5b5fc61(sqlWearableSlot, num);
						c340878b6604c27be1ed3ea526932d511.c30767ddca1f9c207888833aea5b5fc61(sqlWearableSlot, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12568))));
						c6b7f1c7f2b00de56bb2af041aed70b86.c30767ddca1f9c207888833aea5b5fc61(sqlWearableSlot, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12572))));
						ce2aca46bd6ce1e09d75fce3e92a163ec.c30767ddca1f9c207888833aea5b5fc61(c6c9ceed50cee492f304fa50147fb5185.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlWearableSlot);
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
						RuntimeMethodHandle arg_107_0 = methodof(SqlCore.cabf2c9960d89049997cd888f51e4edc1()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000418D4 File Offset: 0x0003FAD4
		private void cccaac1051e1e15e8799a74b1c6e333be()
		{
			c233e4f1930df8ea3fe372218c24352f2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c059e6e6f6489afa529fec81db572ac32.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(144384));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12576));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12580)));
						SqlItemGrade sqlItemGrade = cdee075caab8551d5b0191f73a62779c7.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c7be2136e50c85f1d5207452a2cb501be.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, num);
						c6541b98c472a37c56e5367c039542512.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12584))));
						c2062a1fdaa04bad49d3ad75348e21268.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12588))));
						c5c4708343759009266a5806167e45abd.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12592))));
						cead5892614127fad77de721f7df241fe.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12596))));
						c52a67f57e069d85015d2783bbf43eee2.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12600))));
						c91a6da6592633f478f8918d207cd10a6.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12604))));
						c193bbd52c82102bfd8984bf6291b219b.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.c5df5c2fd7ffeabdf61a81e0ae1a83a1f(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12608))));
						cce21baabe16fbe0cde8f3c8e1e92364d.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12612))));
						c8e45c2d7f479bc4a3327a78e66f66309.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12616))));
						ce1874302849abc9a1d04ceced2452f25.c30767ddca1f9c207888833aea5b5fc61(sqlItemGrade, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12620))));
						cea6acb81f072728833263f59d43236c4.c30767ddca1f9c207888833aea5b5fc61(ca1ff773b84810010f2b6b184b34e1e52.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlItemGrade);
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
						RuntimeMethodHandle arg_227_0 = methodof(SqlCore.cccaac1051e1e15e8799a74b1c6e333be()).MethodHandle;
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00041B74 File Offset: 0x0003FD74
		private void ca3c2d37b5719d8cbce7febf38cd374e6()
		{
			cbf56f15738375b3955d678c0d539b791.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, ca00d8400745fc745c8d8b9d9f76c98a3.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(144798));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12624));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12628)));
						SqlEquipItemSet sqlEquipItemSet = cb232bc58131a58a16e2b49583849126d.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c8655fe0d30c7d43832dfc691c6fd13d8.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemSet, num);
						c441dc96b50b40569864227f8f034f6d5.c30767ddca1f9c207888833aea5b5fc61(sqlEquipItemSet, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12632))));
						c63c7638ec1861cb4f5525745aa355307.c30767ddca1f9c207888833aea5b5fc61(c091fac1f6015e1cbe73e2d8e6295db4e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlEquipItemSet);
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
						RuntimeMethodHandle arg_DD_0 = methodof(SqlCore.ca3c2d37b5719d8cbce7febf38cd374e6()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00041CB0 File Offset: 0x0003FEB0
		private void c4b2567dd401752d242f592b5ba04a062()
		{
			c3c08077387d8250683ca02431b659c84.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c00b746731838daa65028b5d15af89f0b.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(144871));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12636));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12640)));
							SqlItem sqlItem = c619afe9b8a528fd33b35d82ca93ca415.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c2ba84506812d42536d62091483a1025b.c30767ddca1f9c207888833aea5b5fc61(sqlItem, num);
							cf7bbf13613c6dc60218865329edd9975.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12644))));
							c58e88177e66d2fee706154b57a6f0464.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12648))));
							cb539af252e517b000f0b468b37a4817c.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12652))));
							cf1402f262b3fb17d78e73cae358388df.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12656))));
							cd2c4383fe0888bfaf7106daded538999.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12660))));
							c9db7bd535884939845e0eb51ef045f5b.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12664))));
							cd9470ad7f613c618b0b525053e5ea497.c30767ddca1f9c207888833aea5b5fc61(sqlItem, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12668))));
							c1c09c3254bd345a774787330d084f401.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12672))));
							cf4bb244f9f604b5d8db486c81298f2ea.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12676))));
							c9272ed65a1896114827636d71015e527.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12680))));
							cee5469e11768d15b41563669da557f8a.c30767ddca1f9c207888833aea5b5fc61(sqlItem, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12684))));
							ce1c8eec0e9575ad6ba8b9e3f70644815.c30767ddca1f9c207888833aea5b5fc61(sqlItem, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12688))));
							c90214860acfc6b4d8eebbba911d64ae6.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12692))));
							cd6a3931a9d540161bd0a206e8292e1e3.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cb5b0d92e670db20df60836286adf42c5(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12696))));
							cbdf5c39b85423e2b351473c1cd7a7fea.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12700))));
							ccbccd1a17159ef720d6cc128c5debefe.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12704))));
							ccc9fec53da7bea1c62b7a3f4a79dd9ef.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12708))));
							c85e3696be46a05c5c66606bcaa505d7d.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12712))));
							c9a250471e503e373fa69bed8b96f8182.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12716))));
							c46852496e812bd18f3d456011ebbec43.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12720))));
							ce5f923fed6dd92ea822ee042f7da4661.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12724))));
							cc9db6bc2680407d564ea7825d3b4ea79.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12728))));
							c404ffd3acec285c5e631668b7d6a5aa4.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12732))));
							c32e7a54d13f4dd09155c722a889d798d.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12736))));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12740)));
							c2e5ae287b9bdc7e2f4f25b63f6c98efa.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12744))));
							c0a1b171bcc3fc99ee17265156929bc98.c30767ddca1f9c207888833aea5b5fc61(sqlItem, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12748))));
							c77e7921f372df9b2100ebcfc23905f77.c30767ddca1f9c207888833aea5b5fc61(sqlItem, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12752))));
							if (!c5d51d6c6b3dfb3fc353a14809dc6e20a.c30767ddca1f9c207888833aea5b5fc61(c245e7ab3e849b68a932077ceb79c8053.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c0060583123193ba18e1f824d13baf016.c30767ddca1f9c207888833aea5b5fc61(sqlItem)))
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
									RuntimeMethodHandle arg_4A8_0 = methodof(SqlCore.c4b2567dd401752d242f592b5ba04a062()).MethodHandle;
								}
								c3bf48c3e8d08baac2372011a94e8b2bd.c30767ddca1f9c207888833aea5b5fc61(c245e7ab3e849b68a932077ceb79c8053.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c0060583123193ba18e1f824d13baf016.c30767ddca1f9c207888833aea5b5fc61(sqlItem), c66bdcbdf9453e826837f8a85fc3ffbae.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
							}
							cf5f84feb5fbff24e072c8dd5d54128a9.c30767ddca1f9c207888833aea5b5fc61(cedd235847007583c508a64824eedc6b8.c30767ddca1f9c207888833aea5b5fc61(cfde279b99224e7949fd6be7173a166e6.c30767ddca1f9c207888833aea5b5fc61(c245e7ab3e849b68a932077ceb79c8053.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c0060583123193ba18e1f824d13baf016.c30767ddca1f9c207888833aea5b5fc61(sqlItem))), sqlItem);
							if (c6d8c1d114b637ce836465b5698ac47d0.c30767ddca1f9c207888833aea5b5fc61(sqlItem) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12756))
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
								try
								{
									cb735243e5cd4a655bad96c07e2686931.c30767ddca1f9c207888833aea5b5fc61(sqlItem, c8ab1de532af36c5e9cce454a538c725f.c30767ddca1f9c207888833aea5b5fc61(c9f639aa43ffe834a0d8d39b39a321f7b.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c6d8c1d114b637ce836465b5698ac47d0.c30767ddca1f9c207888833aea5b5fc61(sqlItem)));
								}
								catch
								{
								}
							}
							if (cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(sqlItem) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12760))
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
								try
								{
									c8ed8b6f71f7ba2186df2e0c90da6eafa.c30767ddca1f9c207888833aea5b5fc61(sqlItem, cbcf04927ee927d76d9a019803b981136.c30767ddca1f9c207888833aea5b5fc61(cabda6a183494e6e5ea3246ed0b954a6f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cd0a0fb61e5ec154fc0da9cdd212bd1e0.c30767ddca1f9c207888833aea5b5fc61(sqlItem)));
								}
								catch
								{
								}
							}
							if (cef937c4179bbad602e3f4568533301c4.c30767ddca1f9c207888833aea5b5fc61(sqlItem) > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12764))
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
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cef937c4179bbad602e3f4568533301c4.c30767ddca1f9c207888833aea5b5fc61(sqlItem)))
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
									try
									{
										cc47389c3cc59c21597837e68378c98ae.c30767ddca1f9c207888833aea5b5fc61(sqlItem, cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cef937c4179bbad602e3f4568533301c4.c30767ddca1f9c207888833aea5b5fc61(sqlItem)));
									}
									catch
									{
									}
								}
							}
							if (num2 > (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12768))
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
								if (cb78a2c20fb1512ba05c37847dc67290a.c30767ddca1f9c207888833aea5b5fc61(c091fac1f6015e1cbe73e2d8e6295db4e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									cf5f84feb5fbff24e072c8dd5d54128a9.c30767ddca1f9c207888833aea5b5fc61(c7e97cb3356537956eee053ca060db2f6.c30767ddca1f9c207888833aea5b5fc61(cd1096ae840226947d45535dc2f567104.c30767ddca1f9c207888833aea5b5fc61(c091fac1f6015e1cbe73e2d8e6295db4e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2)), sqlItem);
									c7b8269d8c5ad5d8fd9ec9ad9d2d52560.c30767ddca1f9c207888833aea5b5fc61(sqlItem, cd1096ae840226947d45535dc2f567104.c30767ddca1f9c207888833aea5b5fc61(c091fac1f6015e1cbe73e2d8e6295db4e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
							}
							c31bb363cbd98bd1d8eed6512059e1a2a.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlItem);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007F2 RID: 2034 RVA: 0x000423F8 File Offset: 0x000405F8
		private void ca61383b4d35a8fc54c5db4c834044754()
		{
			cc1e69c76cf1b8b93cbefb0ac0a0547b2.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cd3ae40a5739cbc2db7a471df56d56f4e.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(146607));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12772));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12776)));
						SqlPassiveBuff sqlPassiveBuff = cfcf3d5807b6d073e7fc3c65f32d8d6ce.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
						c5e112734921eb6f0fff579c67ada84d1.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff, num);
						c85862147bbc49c37a37c9342fb992fb6.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12780))));
						cf0a14db545685d28f7087f0c9482142e.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12784))));
						ce41a5ba2872e00e8e5875eef4bae807a.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12788))));
						c334a36f2065ab6eb31d77e7bef8c9fd0.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12792))));
						c029076f1df2d134ec258493210cf11fb.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12796))));
						if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) != 0)
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
								RuntimeMethodHandle arg_160_0 = methodof(SqlCore.ca61383b4d35a8fc54c5db4c834044754()).MethodHandle;
							}
							if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12800))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12804)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12808))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12812)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12816))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12820)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12824))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12828)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12832))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12836)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12840))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12844)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12848))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12852)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12856))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12860)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12864))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12868)]), sqlPassiveBuff);
							}
							else if (cbd79e03824a217059cc919cbba305bc4.c30767ddca1f9c207888833aea5b5fc61(sqlPassiveBuff) == c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12872))
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
								c04e35c2436ecbb740fe6ccd4bf8607ed.c30767ddca1f9c207888833aea5b5fc61(c562dfa2074066cccad431bef11178fab.c30767ddca1f9c207888833aea5b5fc61(cd4328f07c9c63c4c4f2828b2a5f402aa.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this)[c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12876)]), sqlPassiveBuff);
							}
						}
						c2ea3fc788b6ea4d8552b2b085ea9f395.c30767ddca1f9c207888833aea5b5fc61(c517b4c2c8c2159d91e155b373146b96f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlPassiveBuff);
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00042890 File Offset: 0x00040A90
		private void ca42092bff9417673129939652e22f59a()
		{
			cdbd45b939219f694021ae10a1abae4ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c293a0d70b8bf10720be25caa67bc34d3.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(146805));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12880));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12884);
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12888)));
							SqlUnitModifier sqlUnitModifier = c4e93d8911a460a634acbba66b9b51369.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c3db407fdf5b544fb552bd47432daffb1.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier, num2);
							ca1d7514b8e9c2c618bb00b328b7a24af.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12892))));
							c7037e92839bc185782c31845e545b648.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12896))));
							c6985d90b03b801bdf2c2c4c98946a787.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12900))));
							cd8394f942ec3d5db6956ead53e249679.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12904))));
							c5a21ea9766c3e3b55c0fadcbb9b41b99.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12908))));
							c600b437e0a2f61f4b1a6916cc87c6fa5.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12912))));
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb33dfab893cd8e591ef6eee88ea80b7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147047)))
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
									RuntimeMethodHandle arg_1A0_0 = methodof(SqlCore.ca42092bff9417673129939652e22f59a()).MethodHandle;
								}
								if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier)))
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
									cd7e9945679b033c2cf026de56202e967.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier))), sqlUnitModifier);
									goto IL_42B;
								}
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb33dfab893cd8e591ef6eee88ea80b7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147056)))
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
								if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier)))
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
									cd7e9945679b033c2cf026de56202e967.c30767ddca1f9c207888833aea5b5fc61(c31808c81db7aeb29becf248de4f219c8.c30767ddca1f9c207888833aea5b5fc61(c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier))), sqlUnitModifier);
									goto IL_42B;
								}
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb33dfab893cd8e591ef6eee88ea80b7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147065)))
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
								if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier)))
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
									cd7e9945679b033c2cf026de56202e967.c30767ddca1f9c207888833aea5b5fc61(c6d2c8529a486dd4f0da9ca45110de9cc.c30767ddca1f9c207888833aea5b5fc61(c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier))), sqlUnitModifier);
									goto IL_42B;
								}
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb33dfab893cd8e591ef6eee88ea80b7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147072)))
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
								if (c70c4cecf449a99317d56daab248a55d1.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier)))
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
									cd7e9945679b033c2cf026de56202e967.c30767ddca1f9c207888833aea5b5fc61(c5a7c8f887bc7cdc8a833a04530874141.c30767ddca1f9c207888833aea5b5fc61(c17c43bc0d3fbee21a6ef8c0de88b4544.c30767ddca1f9c207888833aea5b5fc61(c197b008364008b3b920ac12bac84598a.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier))), sqlUnitModifier);
									goto IL_42B;
								}
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb33dfab893cd8e591ef6eee88ea80b7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147087)))
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
								if (c60410ca0f1f5f22a8ee59b6630fd8b2c.c30767ddca1f9c207888833aea5b5fc61(c16c4f5bd1c2c59a0ee3ff4d79746903c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier)))
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
									cd7e9945679b033c2cf026de56202e967.c30767ddca1f9c207888833aea5b5fc61(cbc6918d421008a30d898d7f80fce2155.c30767ddca1f9c207888833aea5b5fc61(c211bd68403336f07c3228b30f62972b0.c30767ddca1f9c207888833aea5b5fc61(c16c4f5bd1c2c59a0ee3ff4d79746903c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier))), sqlUnitModifier);
									goto IL_42B;
								}
							}
							if (c03eb9e5c3ceee17355efb08798a945a8.c0cf59c3e67a46fd4edb3040c5ab0bbfb(ceb33dfab893cd8e591ef6eee88ea80b7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier), c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147098)))
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
								if (c4386e29cdee77f483cec05c804dcb764.c30767ddca1f9c207888833aea5b5fc61(c62b16b793f41bf935694cc981e81e494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier)))
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
									cd7e9945679b033c2cf026de56202e967.c30767ddca1f9c207888833aea5b5fc61(cc606614886bfbfabd1a9064b66a7973b.c30767ddca1f9c207888833aea5b5fc61(c7f4bab171c905ff1ad0898c5ee5e209a.c30767ddca1f9c207888833aea5b5fc61(c6252a99f0a24ba89330abacc49111f5e.c30767ddca1f9c207888833aea5b5fc61(c62b16b793f41bf935694cc981e81e494.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), cc28eb384d4bed7f916adef7199363ce7.c30767ddca1f9c207888833aea5b5fc61(sqlUnitModifier)))), sqlUnitModifier);
								}
							}
							IL_42B:
							c9d60d3bc640e9588456615734aec34f9.c30767ddca1f9c207888833aea5b5fc61(ca95358aa50b158d3e0172c27e7113f73.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlUnitModifier);
							num += (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12916);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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

		// Token: 0x060007F4 RID: 2036 RVA: 0x00042D94 File Offset: 0x00040F94
		private void cfaf1a0bf3f16e8623c09a1bb5c1ec22a()
		{
			c731007f9584a2baf1bf0ccbd1f557da6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c7a0eb94094a340bba95f0dfdacfe4da0.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147131));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12920));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12924)));
							SqlZoneClimateElem sqlZoneClimateElem = cc0dd37f3bab16be2ed96a7171b7f3b13.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							c2a48883accd28f65c8f4f2672992127e.c30767ddca1f9c207888833aea5b5fc61(sqlZoneClimateElem, num);
							c949daff84db3a8d41cc61a3b0435bfc1.c30767ddca1f9c207888833aea5b5fc61(sqlZoneClimateElem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12928))));
							c410facb5c7ae8cb1de2ccdc116370a4f.c30767ddca1f9c207888833aea5b5fc61(sqlZoneClimateElem, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12932))));
							c9836650c6b660bcb36b2c83f1d778680.c30767ddca1f9c207888833aea5b5fc61(c98c27c98817912fb61c51daa9884ea66.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), sqlZoneClimateElem);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (!true)
					{
						RuntimeMethodHandle arg_11A_0 = methodof(SqlCore.cfaf1a0bf3f16e8623c09a1bb5c1ec22a()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
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
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00042F3C File Offset: 0x0004113C
		private void c5f2961239acfe0df1c21e12102ff5052()
		{
			cc36c0286bc61560a876f814bbf7f94f0.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c9a53657dff72459cb32dea6fa57b85c3.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(147256));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12936));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12940)));
							SqlBuff sqlBuff = c49133ee635fa22b97b5aa956e3e528d6.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							cf142057c8e4f384457d9dfe7466f8d9d.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, num);
							cae199b5cdb97bf076b89ed4f4fe83cc3.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12944))));
							ca2c98b72354a2f3346c13b2582b7ca8b.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12948))));
							ce6da74b440eb60d32db489598303c20e.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12952))));
							c7cba2346b06a8cb8ae476783ddfda973.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.cbb7abf924087b4fc4ab344f9dfdf9526(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12956))));
							c1f5de14f690161c4fd0f660a600000d1.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12960))));
							cc3c848fb24d3b83bc52b82eac6ba5726.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12964))));
							cc011ee726b08799c363c7161386360f2.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12968))));
							cefe396bb8c8e0cd14b4a1ac145a10a3d.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12972))));
							cfca1ebc49cf2285198b6b52c24a19819.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12976))));
							cc5090997a29f7c16f6ec52d478940ba0.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12980))));
							c8f25651f5a56a73c99db99841306a9ea.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12984))));
							c00aa88ca5e32278a3cb29245ab407390.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12988))));
							c4a12fb35ba10d733f44dec7f41723bfd.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12992))));
							cf9284364e3cead46be161acbe8f86e09.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(12996))));
							c5354c367f926283660f747b26edfe81d.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13000))));
							c0c3cd01628861bc2cb89c6d991cd8f8f.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13004))));
							c711941b9b27d41957b62c2c239785a27.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13008))));
							cdc2e0e547bb195fe06d204801f724ca5.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, this.c6d416453576edeb5213c93148568a4f1(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13012))));
							c777f2f53695739e5998e3d6df9e39f28.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13016))));
							c7ebfac63cda98a7467a9d018e17afc32.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13020))));
							c1791213777e8ca23703c1726d83eab78.c30767ddca1f9c207888833aea5b5fc61(sqlBuff, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13024))));
							c13481698a713d28cd5c8a94fc94b33e2.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlBuff);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (!true)
					{
						RuntimeMethodHandle arg_3D3_0 = methodof(SqlCore.c5f2961239acfe0df1c21e12102ff5052()).MethodHandle;
					}
				}
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000433A0 File Offset: 0x000415A0
		private void c28020710f84265b36f2ffdaacb40ec1c()
		{
			c9beb4a123ea77e7afedd8b03ea3b72b1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, cfb47e7824e243cff517b31617f592486.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148244));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13028));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13032)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13036)));
							if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_C5_0 = methodof(SqlCore.c28020710f84265b36f2ffdaacb40ec1c()).MethodHandle;
								}
								if (!cfcb547fe67e75afa08ea5dd0cd8b0a2e.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									SqlTaggedSkill sqlTaggedSkill = cc6616bb61d346fe06ad18f3714b4c096.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									c915755c780546033c9a86ff342abc2e3.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedSkill, num);
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c2cb546ebef8fb8cc0484c1f36f58991e.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedSkill), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
									c67bbd97481585144ee1e4811d4cfb837.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlTaggedSkill);
								}
								else
								{
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c2cb546ebef8fb8cc0484c1f36f58991e.c30767ddca1f9c207888833aea5b5fc61(c10d56073b449e7d7a10ba4e4efb1a038.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
							}
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
				finally
				{
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000435A8 File Offset: 0x000417A8
		private void ceeb6686433c34fedbc003a463a3c2186()
		{
			c5222660b2579f004b905621dc2222bc1.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c5bf2e9a39b0d3d72edcdd08b398295c2.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148337));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13040));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13044)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13048)));
							if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_C5_0 = methodof(SqlCore.ceeb6686433c34fedbc003a463a3c2186()).MethodHandle;
								}
								if (!cc202d0ad820ef6323059a03284266a07.c30767ddca1f9c207888833aea5b5fc61(c083feae74ac4a96bd761138227cdeea6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									SqlTaggedBuff sqlTaggedBuff = c62fe11390a801087b21b3a7a2535754c.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									c6bd0c1abf517747aa5682eb59190912d.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedBuff, num);
									ce45ac7ee7972917a52687c56a0b9d92d.c30767ddca1f9c207888833aea5b5fc61(cd34767de8440ab73d75d8994a923d32f.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedBuff), c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
									ce137aa9c1cc9934a27dcc025fe333fc9.c30767ddca1f9c207888833aea5b5fc61(c083feae74ac4a96bd761138227cdeea6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlTaggedBuff);
								}
								else
								{
									ce45ac7ee7972917a52687c56a0b9d92d.c30767ddca1f9c207888833aea5b5fc61(cd34767de8440ab73d75d8994a923d32f.c30767ddca1f9c207888833aea5b5fc61(c84dea1b0508729084e29c3453c17271f.c30767ddca1f9c207888833aea5b5fc61(c083feae74ac4a96bd761138227cdeea6.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
							}
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000437B0 File Offset: 0x000419B0
		private void c21be4cf9a50bdc47ffa3adc9653acb52()
		{
			c02b0259af88d91dd715fe7bfda24f945.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c8346d773ef183b86681cb3c1c9a165fc.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148426));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13052));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13056)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13060)));
							if (cb6ce56682ec1ae3235ebea8ba1832be6.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_C5_0 = methodof(SqlCore.c21be4cf9a50bdc47ffa3adc9653acb52()).MethodHandle;
								}
								if (!c4faad190baee93b88d7fcbf8b7ce63a0.c30767ddca1f9c207888833aea5b5fc61(c69a3b9ffb35e6bc7527f38b5ad08f19f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									SqlTaggedItem sqlTaggedItem = c0e2b931ada10b6f06c3128cea44fb6d4.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									ce80fabf2bd33bc2e3340a93b17985c1b.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedItem, num);
									cf5f84feb5fbff24e072c8dd5d54128a9.c30767ddca1f9c207888833aea5b5fc61(cdf68288db438603905d4a5c8546862c8.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedItem), c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
									c6f62b1b2affc2660eb7760e35796b408.c30767ddca1f9c207888833aea5b5fc61(c69a3b9ffb35e6bc7527f38b5ad08f19f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlTaggedItem);
								}
								else
								{
									cf5f84feb5fbff24e072c8dd5d54128a9.c30767ddca1f9c207888833aea5b5fc61(cdf68288db438603905d4a5c8546862c8.c30767ddca1f9c207888833aea5b5fc61(cae069ef88fd60766410b012f4f66eb03.c30767ddca1f9c207888833aea5b5fc61(c69a3b9ffb35e6bc7527f38b5ad08f19f.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), c7988bb24bb0d2a875dc56a901b65cafe.c30767ddca1f9c207888833aea5b5fc61(c3c9f1d04385cff2c86df3836931a1e02.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
							}
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000439B8 File Offset: 0x00041BB8
		private void c31e9eb97ddabb72f372058506b6d6166()
		{
			c111a4af7e26cc77207224039ccf2aaad.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c3fbb787f24f4c74d1483e9ad9030ccf6.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148515));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13064));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13068)));
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13072)));
							if (c0736fd5f04910bac72b539b23fcf70c7.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2))
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
									RuntimeMethodHandle arg_C5_0 = methodof(SqlCore.c31e9eb97ddabb72f372058506b6d6166()).MethodHandle;
								}
								if (!c2e5d5d31b16178edcdb4000b77ee3f9f.c30767ddca1f9c207888833aea5b5fc61(ce3680b6174a8092b99998b9983c2a71c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
									SqlTaggedNpc sqlTaggedNpc = cdca5e6d52019e0f053201e4fbbd7391a.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
									cd2588d8c4cd8cf675d4e2585e21a7be3.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedNpc, num);
									c3ab4d504b7580cd2f496fa21abcab0ee.c30767ddca1f9c207888833aea5b5fc61(cffdf2e84fcfef42bdf49b36fd7c73849.c30767ddca1f9c207888833aea5b5fc61(sqlTaggedNpc), c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
									c8ebedd06d829c33417aaec99d9fa5400.c30767ddca1f9c207888833aea5b5fc61(ce3680b6174a8092b99998b9983c2a71c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlTaggedNpc);
								}
								else
								{
									c3ab4d504b7580cd2f496fa21abcab0ee.c30767ddca1f9c207888833aea5b5fc61(cffdf2e84fcfef42bdf49b36fd7c73849.c30767ddca1f9c207888833aea5b5fc61(c8cd39f0034b00f921d003fc525fddaf5.c30767ddca1f9c207888833aea5b5fc61(ce3680b6174a8092b99998b9983c2a71c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num)), c7cfe439c69a6231aa61faa36ef22cc00.c30767ddca1f9c207888833aea5b5fc61(cc47dc3006cbb857e3bd29dfdab43721c.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num2));
								}
							}
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00043BC0 File Offset: 0x00041DC0
		private void ce46153a83cd9327eb8181984ef8a73a4()
		{
			cbb0ec55d7503b92342b6f301a08fb43e.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this, c1dc839fab1130406cbe79232891f79a6.c0cf59c3e67a46fd4edb3040c5ab0bbfb());
			SQLiteCommand sQLiteCommand = cb9a3f3ab59a421c9b276b7f2bea616ae.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this.c3e76590440c7f603f07fda2f71aada9b);
			try
			{
				c05bd10dfcee68933994fec06d4a3f97f.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, c18b57b77328324f24e8a135188b3a747.ca2627375a3c55a847928012559959362(148600));
				cacb0364d98b6b2a2967d7b8ecfeb7f28.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand, (CommandType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13076));
				c02c20572ac4ed67add3758a911676fdc.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				SQLiteDataReader sQLiteDataReader = this.c00f66411c697a0fd0527c2c113d211f0 = c99a1e94f4307e7da09b56343acfbbac3.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				try
				{
					uint num = (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13080);
					while (c7d4008a26af18441aba6308d6edd3b29.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0))
					{
						try
						{
							uint num2 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13084)));
							SqlSkillModifier sqlSkillModifier = c748898ab276180282346ed7ca4fe3d3d.c0cf59c3e67a46fd4edb3040c5ab0bbfb();
							ceda60182bc91661da8751ed928b4cfa7.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, num2);
							cac4764c3506d53a9fbf6b4125937dcc6.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13088))));
							c79e676e44bc917dd32bfe13b30b485df.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, SqlCore.c6719f5b2ea2416ec86b0b92dc870ad7a(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13092))));
							c54b2d7fa1bcfbad48016d5a42ca63ec8.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13096))));
							c9867b953bccacf92c8a05a217b8acc41.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13100))));
							c8090fa10c7a195aa3cc19d5fc094520e.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13104))));
							c2281eb18ae37d54dfeeaefc460c0fdee.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, SqlCore.ca27f2bc123658aee801ff6301b99beef(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13108))));
							uint num3 = SqlCore.cabc941092d707a13e497448248cd9bce(cf9655c2a53ef0a4222e45432da54cc65.c30767ddca1f9c207888833aea5b5fc61(this.c00f66411c697a0fd0527c2c113d211f0, c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13112)));
							if (c73542bb9af3b28e3bce76db9c901eef5.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier) == 0u)
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
									RuntimeMethodHandle arg_1AD_0 = methodof(SqlCore.ce46153a83cd9327eb8181984ef8a73a4()).MethodHandle;
								}
								if (c159fba57220daa31cc621cdfca17333f.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3))
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
									c17519cb041aaed33d0f4b3d789117eb1.c30767ddca1f9c207888833aea5b5fc61(c1d654f4294e20c4abcd7db17f5fab0a9.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier), cbd70ef91c3c2f3ecc0f0cd87aa3bb674.c30767ddca1f9c207888833aea5b5fc61(cb03838ddb7719fd5f7c890cb870f7d65.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num3));
								}
							}
							else if (cfcb547fe67e75afa08ea5dd0cd8b0a2e.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c73542bb9af3b28e3bce76db9c901eef5.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier)))
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
								c29e9a39c203ba209c33971a36bcc28b3.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier, c2cb546ebef8fb8cc0484c1f36f58991e.c30767ddca1f9c207888833aea5b5fc61(c10d56073b449e7d7a10ba4e4efb1a038.c30767ddca1f9c207888833aea5b5fc61(cfb049e52d1562fbede6797ad14d0c774.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c73542bb9af3b28e3bce76db9c901eef5.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier))));
							}
							if (c639d5b9a3eb6456a0e6a95f2c89e9d9b.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c2d2cae7b5e4e8d45b4f73ce588baf6f1.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier)))
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
								c9d3c700ce604c901ab31b0c3e1a0097e.c30767ddca1f9c207888833aea5b5fc61(c70ebe81d4d547e40f3308d0e4215ce3a.c30767ddca1f9c207888833aea5b5fc61(c41de4f3237e1442a3de864dc38c1de55.c30767ddca1f9c207888833aea5b5fc61(c283a52b54979f9b98de11dad93c773db.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), c2d2cae7b5e4e8d45b4f73ce588baf6f1.c30767ddca1f9c207888833aea5b5fc61(sqlSkillModifier))), sqlSkillModifier);
							}
							c126885f1a4ef0724e11365412a7066a4.c30767ddca1f9c207888833aea5b5fc61(cbcdd3de78df7622d0b069e0417d058ee.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num, sqlSkillModifier);
							num += (uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13116);
						}
						catch (Exception ex)
						{
							cc4987d6a853db77954f21abe4e42946a.cc9982884fcd8751391914f88648f21e6(cccc120cc278c1fcab67209dc452eb98f.c30767ddca1f9c207888833aea5b5fc61(ex));
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
					if (sQLiteDataReader != null)
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
						cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteDataReader);
					}
				}
				c439726e280a3b2e4875dd759d6823932.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
			}
			finally
			{
				if (sQLiteCommand != null)
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
					cf9986b7738b38d16bce255a902ec1313.c30767ddca1f9c207888833aea5b5fc61(sQLiteCommand);
				}
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00043F14 File Offset: 0x00042114
		private void c53804aaabbc3f79cc5b6c8861dd0a5e3(uint num, float num2)
		{
			try
			{
				if (c129fb2f83ee1580675b039b954aeeaec.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num))
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
						RuntimeMethodHandle arg_24_0 = methodof(SqlCore.c53804aaabbc3f79cc5b6c8861dd0a5e3(uint, float)).MethodHandle;
					}
					c480d682c2d070e54f9e0a6ff7d31201a.c30767ddca1f9c207888833aea5b5fc61(c9872de2b8eb8dfe962814eeba7cb0444.c30767ddca1f9c207888833aea5b5fc61(c0da1725bbd7eec4f5c49073856483a44.c0cf59c3e67a46fd4edb3040c5ab0bbfb(this), num), num2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00043F74 File Offset: 0x00042174
		private void ce49cdc2c2ade65cdb7bab971f4d9ea75()
		{
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13120), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13124));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13128), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13132));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13136), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13140));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13144), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13148));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13152), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13156));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13160), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13164));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13168), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13172));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13176), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13180));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13184), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13188));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13192), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13196));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13200), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13204));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13208), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13212));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13216), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13220));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13224), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13228));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13232), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13236));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13240), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13244));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13248), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13252));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13256), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13260));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13264), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13268));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13272), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13276));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13280), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13284));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13288), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13292));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13296), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13300));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13304), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13308));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13312), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13316));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13320), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13324));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13328), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13332));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13336), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13340));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13344), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13348));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13352), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13356));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13360), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13364));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13368), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13372));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13376), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13380));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13384), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13388));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13392), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13396));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13400), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13404));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13408), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13412));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13416), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13420));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13424), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13428));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13432), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13436));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13440), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13444));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13448), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13452));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13456), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13460));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13464), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13468));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13472), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13476));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13480), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13484));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13488), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13492));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13496), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13500));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13504), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13508));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13512), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13516));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13520), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13524));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13528), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13532));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13536), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13540));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13544), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13548));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13552), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13556));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13560), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13564));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13568), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13572));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13576), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13580));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13584), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13588));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13592), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13596));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13600), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13604));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13608), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13612));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13616), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13620));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13624), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13628));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13632), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13636));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13640), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13644));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13648), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13652));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13656), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13660));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13664), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13668));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13672), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13676));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13680), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13684));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13688), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13692));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13696), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13700));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13704), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13708));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13712), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13716));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13720), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13724));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13728), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13732));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13736), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13740));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13744), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13748));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13752), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13756));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13760), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13764));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13768), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13772));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13776), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13780));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13784), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13788));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13792), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13796));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13800), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13804));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13808), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13812));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13816), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13820));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13824), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13828));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13832), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13836));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13840), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13844));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13848), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13852));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13856), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13860));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13864), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13868));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13872), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13876));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13880), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13884));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13888), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13892));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13896), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13900));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13904), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13908));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13912), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13916));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13920), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13924));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13928), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13932));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13936), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13940));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13944), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13948));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13952), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13956));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13960), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13964));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13968), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13972));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13976), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13980));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13984), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13988));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(13992), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(13996));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14000), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14004));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14008), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14012));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14016), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14020));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14024), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14028));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14032), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14036));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14040), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14044));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14048), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14052));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14056), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14060));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14064), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14068));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14072), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14076));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14080), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14084));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14088), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14092));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14096), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14100));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14104), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14108));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14112), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14116));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14120), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14124));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14128), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14132));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14136), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14140));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14144), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14148));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14152), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14156));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14160), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14164));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14168), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14172));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14176), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14180));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14184), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14188));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14192), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14196));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14200), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14204));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14208), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14212));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14216), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14220));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14224), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14228));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14232), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14236));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14240), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14244));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14248), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14252));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14256), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14260));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14264), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14268));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14272), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14276));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14280), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14284));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14288), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14292));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14296), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14300));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14304), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14308));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14312), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14316));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14320), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14324));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14328), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14332));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14336), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14340));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14344), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14348));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14352), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14356));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14360), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14364));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14368), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14372));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14376), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14380));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14384), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14388));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14392), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14396));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14400), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14404));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14408), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14412));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14416), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14420));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14424), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14428));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14432), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14436));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14440), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14444));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14448), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14452));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14456), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14460));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14464), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14468));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14472), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14476));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14480), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14484));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14488), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14492));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14496), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14500));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14504), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14508));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14512), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14516));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14520), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14524));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14528), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14532));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14536), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14540));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14544), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14548));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14552), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14556));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14560), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14564));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14568), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14572));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14576), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14580));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14584), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14588));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14592), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14596));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14600), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14604));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14608), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14612));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14616), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14620));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14624), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14628));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14632), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14636));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14640), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14644));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14648), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14652));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14656), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14660));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14664), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14668));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14672), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14676));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14680), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14684));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14688), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14692));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14696), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14700));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14704), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14708));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14712), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14716));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14720), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14724));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14728), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14732));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14736), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14740));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14744), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14748));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14752), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14756));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14760), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14764));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14768), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14772));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14776), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14780));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14784), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14788));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14792), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14796));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14800), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14804));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14808), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14812));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14816), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14820));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14824), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14828));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14832), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14836));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14840), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14844));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14848), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14852));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14856), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14860));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14864), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14868));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14872), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14876));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14880), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14884));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14888), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14892));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14896), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14900));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14904), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14908));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14912), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14916));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14920), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14924));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14928), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14932));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14936), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14940));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14944), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14948));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14952), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14956));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14960), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14964));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14968), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14972));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14976), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14980));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14984), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14988));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(14992), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(14996));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15000), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15004));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15008), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15012));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15016), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15020));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15024), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15028));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15032), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15036));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15040), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15044));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15048), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15052));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15056), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15060));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15064), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15068));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15072), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15076));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15080), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15084));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15088), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15092));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15096), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15100));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15104), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15108));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15112), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15116));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15120), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15124));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15128), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15132));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15136), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15140));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15144), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15148));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15152), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15156));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15160), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15164));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15168), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15172));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15176), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15180));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15184), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15188));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15192), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15196));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15200), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15204));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15208), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15212));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15216), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15220));
			this.c53804aaabbc3f79cc5b6c8861dd0a5e3((uint)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(15224), c4929ffb646fb9ba9deb5f553efe8c57b.cdf46f43e0afdf3dce063f22f1e47bb37(15228));
		}

		// Token: 0x040003EB RID: 1003
		private SQLiteConnection c3e76590440c7f603f07fda2f71aada9b;

		// Token: 0x040003EC RID: 1004
		private SQLiteDataReader c00f66411c697a0fd0527c2c113d211f0;

		// Token: 0x040003ED RID: 1005
		internal ClientVersion cfffa987bb40f5a52a78d3ae7981ae443;

		// Token: 0x040003EE RID: 1006
		[CompilerGenerated]
		private Dictionary<uint, SqlSpecialtyItemZone> c4620cb721de3c9f75aff065b090c5b97;

		// Token: 0x040003EF RID: 1007
		[CompilerGenerated]
		private Dictionary<uint, SqlBuff> c8e4d663d260fafe79e957c50c7971c93;

		// Token: 0x040003F0 RID: 1008
		[CompilerGenerated]
		private Dictionary<uint, SqlUnitModifier> cf8d1277b6b49684049aed9d55fa077a9;

		// Token: 0x040003F1 RID: 1009
		[CompilerGenerated]
		private Dictionary<uint, SqlSkillModifier> c69a4ededdfe6e96c0c89a29c5bc4bc87;

		// Token: 0x040003F2 RID: 1010
		[CompilerGenerated]
		private Dictionary<uint, SqlPassiveBuff> c64ae36fcbb176c0a2c9fe0e6236a1b32;

		// Token: 0x040003F3 RID: 1011
		[CompilerGenerated]
		private Dictionary<uint, SqlItemGroup> cd294c02232d743c8cc77fecf2d971d9e;

		// Token: 0x040003F4 RID: 1012
		[CompilerGenerated]
		private Dictionary<uint, SqlItemCategorie> c681bc99758fc5ce0b945c2ca32e31f84;

		// Token: 0x040003F5 RID: 1013
		[CompilerGenerated]
		private Dictionary<uint, SqlItem> c62fddbaa9d5c2aec0ea93a9eb0a7361c;

		// Token: 0x040003F6 RID: 1014
		[CompilerGenerated]
		private Dictionary<uint, SqlItemGrade> c1791e8b5e8ada67e3c92262511f743e9;

		// Token: 0x040003F7 RID: 1015
		[CompilerGenerated]
		private Dictionary<uint, SqlWearable> c7850c94ab7c032c9955fb202eae9a5ff;

		// Token: 0x040003F8 RID: 1016
		[CompilerGenerated]
		private Dictionary<uint, SqlWearableSlot> c8366a3cf3b42b5c3c9f16e46c4867618;

		// Token: 0x040003F9 RID: 1017
		[CompilerGenerated]
		private Dictionary<uint, SqlHoldable> c19a678e4081e7b8109b60d5976aeb3a4;

		// Token: 0x040003FA RID: 1018
		[CompilerGenerated]
		private Dictionary<uint, SqlEquipItemAttrModifier> cf228fc14c97a7499aff734eedd8a71d4;

		// Token: 0x040003FB RID: 1019
		[CompilerGenerated]
		private Dictionary<uint, SqlNpc> c2bce13edf1777c587a2493af74821012;

		// Token: 0x040003FC RID: 1020
		[CompilerGenerated]
		private Dictionary<uint, SqlSkill> c1aa0b013fc19a95ea32cddffe3eae65d;

		// Token: 0x040003FD RID: 1021
		[CompilerGenerated]
		private Dictionary<uint, SqlDoodadAlmighty> c2041f667fe308e116527733ee311dd2d;

		// Token: 0x040003FE RID: 1022
		[CompilerGenerated]
		private Dictionary<uint, SqlDoodadFuncGroup> ce53f7697719b679e04531ae5ca6d3d94;

		// Token: 0x040003FF RID: 1023
		[CompilerGenerated]
		private Dictionary<uint, SqlHousing> cf4e7cefc026df262e10c6d7650a6953f;

		// Token: 0x04000400 RID: 1024
		[CompilerGenerated]
		private Dictionary<uint, SqlTaggedSkill> c0b9695225d04a4006d2d30f5bfca1c58;

		// Token: 0x04000401 RID: 1025
		[CompilerGenerated]
		private Dictionary<uint, SqlTaggedBuff> cdf96d5df644dd9bf6a4b75b18310ec09;

		// Token: 0x04000402 RID: 1026
		[CompilerGenerated]
		private Dictionary<uint, SqlTaggedItem> c2e34dc29a88cdc1ad848548f714f1cdd;

		// Token: 0x04000403 RID: 1027
		[CompilerGenerated]
		private Dictionary<uint, SqlTaggedNpc> ce3fc42b4756ca99cc29d3ac9bfb4efc9;

		// Token: 0x04000404 RID: 1028
		[CompilerGenerated]
		private Dictionary<uint, SqlEffect> c457ea111ef217bccda312e56c4eb5252;

		// Token: 0x04000405 RID: 1029
		[CompilerGenerated]
		private Dictionary<uint, SqlSpecialEffect> ca1672b84720e7240997d71583b18e917;

		// Token: 0x04000406 RID: 1030
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestContext> ccff0e318c6d83ae98bdc53337cfb405d;

		// Token: 0x04000407 RID: 1031
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestComponent> cd264d4762f75916df559cb84822968f6;

		// Token: 0x04000408 RID: 1032
		[CompilerGenerated]
		private Dictionary<uint, SqlMerchantPack> cff85fd26100abdc1bd278714516b50d4;

		// Token: 0x04000409 RID: 1033
		[CompilerGenerated]
		private Dictionary<uint, SqlCraft> cadd9259b35a97860ec1b35ac95f1b43b;

		// Token: 0x0400040A RID: 1034
		[CompilerGenerated]
		private Dictionary<uint, SqlCraftPack> cdaf9b17ce153482f60865da2a6629a7b;

		// Token: 0x0400040B RID: 1035
		[CompilerGenerated]
		private Dictionary<uint, SqlDoodadFuncCraftPack> cd82988aa2fd5e47d3ae8d872c27a08ef;

		// Token: 0x0400040C RID: 1036
		[CompilerGenerated]
		private Dictionary<uint, SqlActabilityGroup> c0dbfef51e08c523952c3cc95ed7c6ece;

		// Token: 0x0400040D RID: 1037
		[CompilerGenerated]
		private Dictionary<uint, SqlActabilityCategorie> cd7f8f9c2b677a0b6194a3418b04d347f;

		// Token: 0x0400040E RID: 1038
		[CompilerGenerated]
		private Dictionary<uint, SqlAuctionACategory> c1912f180e08f3ebad29734f693bda28e;

		// Token: 0x0400040F RID: 1039
		[CompilerGenerated]
		private Dictionary<uint, SqlAuctionBCategory> c1af074eb9d705d60d7b5cd5b27636df3;

		// Token: 0x04000410 RID: 1040
		[CompilerGenerated]
		private Dictionary<uint, SqlAuctionCCategory> c16138727f7465363f254f3b1076d8588;

		// Token: 0x04000411 RID: 1041
		[CompilerGenerated]
		private Dictionary<uint, SqlLinearFunc> c59d2b5aa3b66c0fb46a9f6faeca8f64a;

		// Token: 0x04000412 RID: 1042
		[CompilerGenerated]
		private Dictionary<uint, SqlSlave> c0b28323c7c59a290e570d2504c803edd;

		// Token: 0x04000413 RID: 1043
		[CompilerGenerated]
		private Dictionary<uint, SqlBuffUnitModifier> c4b0af302c5e234b6ed29fa3e265fb4be;

		// Token: 0x04000414 RID: 1044
		[CompilerGenerated]
		private Dictionary<uint, SqlDoodadFuncPurchase> cd68b14df1b98fe114789969556eb2b50;

		// Token: 0x04000415 RID: 1045
		[CompilerGenerated]
		private Dictionary<uint, SqlMountSkill> c57482eb14c7bf66f2a0226bc4dd3bf1d;

		// Token: 0x04000416 RID: 1046
		[CompilerGenerated]
		private Dictionary<uint, SqlSkillReq> c9f3c69e449239f217797a188228402b7;

		// Token: 0x04000417 RID: 1047
		[CompilerGenerated]
		private Dictionary<uint, SqlActorModel> c54e87fd938af4b06ef0273b47b804b0e;

		// Token: 0x04000418 RID: 1048
		[CompilerGenerated]
		private Dictionary<uint, SqlVehicleModel> c5b7ce29ede434aef3ce7fa430b95392b;

		// Token: 0x04000419 RID: 1049
		[CompilerGenerated]
		private Dictionary<uint, SqlModel> cacbca77e942dada0b13df2a668b18c1b;

		// Token: 0x0400041A RID: 1050
		[CompilerGenerated]
		private Dictionary<uint, SqlModelAttachPointString> c86075500484b16155dbdd2d978c1e82b;

		// Token: 0x0400041B RID: 1051
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActConAcceptNpc> ce7a7abeb0d01390a98caac175f1597cb;

		// Token: 0x0400041C RID: 1052
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActConAcceptDoodad> c9dfb6c8e0bc34746695dba5a062092d1;

		// Token: 0x0400041D RID: 1053
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActConReportNpc> cfbdfbf81c78cb1d294b9657f13defce5;

		// Token: 0x0400041E RID: 1054
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActConReportDoodad> c01a65a20d673507b1f818bcf7d66e399;

		// Token: 0x0400041F RID: 1055
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActConReportJournal> c393a116c0eaedb9c95d2111e12f85e08;

		// Token: 0x04000420 RID: 1056
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActObjInteraction> cd193811aa86c16b2ff2a8bf7410bfbfe;

		// Token: 0x04000421 RID: 1057
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActObjTalk> cd876267fea87ae6e805917be9face6e7;

		// Token: 0x04000422 RID: 1058
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActSupplySelectiveItem> cdcfca327db75eee66905fa2336f94079;

		// Token: 0x04000423 RID: 1059
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActObjMonsterGroupHunt> cab800b97e3d4a96f3e87256090d884fd;

		// Token: 0x04000424 RID: 1060
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActObjMonsterHunt> c2bf3caa3440bc1e47ac7373f1d1b9250;

		// Token: 0x04000425 RID: 1061
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActObjItemGroupGather> c9857b1626b4ebb747badb1bc1ab95bfe;

		// Token: 0x04000426 RID: 1062
		[CompilerGenerated]
		private Dictionary<uint, SqlQuestActObjItemGather> c42c52427ce1251ee35888a22e80e93d5;

		// Token: 0x04000427 RID: 1063
		[CompilerGenerated]
		private Dictionary<uint, SqlDoodadFuncFakeUse> c7d7ce3a43e6e14ae7030d829eeebadcd;

		// Token: 0x04000428 RID: 1064
		[CompilerGenerated]
		private Dictionary<uint, SqlPlotEffect> c273902d5689339993b87b6518d48cc0e;

		// Token: 0x04000429 RID: 1065
		[CompilerGenerated]
		private Dictionary<uint, SqlPlotEvent> cf47747d937e436382a0a79a9a367d09d;

		// Token: 0x0400042A RID: 1066
		[CompilerGenerated]
		private Dictionary<uint, SqlDoodadFuncRemoveItem> cd823fe842824c2ea2d467db193966baa;

		// Token: 0x0400042B RID: 1067
		[CompilerGenerated]
		private Dictionary<uint, SqlDoodadFuncConditionalUse> c06ed808edf952f576a5447025f539df5;

		// Token: 0x0400042C RID: 1068
		[CompilerGenerated]
		private Dictionary<uint, SqlEquipItemSet> c61b5af29d825d502b7ea660c8241217a;

		// Token: 0x0400042D RID: 1069
		[CompilerGenerated]
		private List<SqlUnitFormulaVariable> cb1f0e9ff1c28ab669ed72475ff1f2463;

		// Token: 0x0400042E RID: 1070
		[CompilerGenerated]
		private Dictionary<uint, SqlZoneGroup> ca3f8d81742df2ac81f5827eab63e7815;

		// Token: 0x0400042F RID: 1071
		[CompilerGenerated]
		private Dictionary<uint, SqlZone> cd7b695766ada7eecfbdb6f013fc1410b;

		// Token: 0x04000430 RID: 1072
		[CompilerGenerated]
		private Dictionary<uint, SqlSubZone> cd372fae0b1816a056040bbe157872aa3;

		// Token: 0x04000431 RID: 1073
		[CompilerGenerated]
		private List<SqlZoneClimateElem> c6502d02ad2fdfceb1b3652e439adc01f;

		// Token: 0x04000432 RID: 1074
		[CompilerGenerated]
		private Dictionary<uint, SqlLevel> cae432a138e688233d549d3d9ec2929fc;

		// Token: 0x04000433 RID: 1075
		[CompilerGenerated]
		private List<SqlDefaultSkill> c1ee0c670fa69226bcc1149206dddd5fb;

		// Token: 0x04000434 RID: 1076
		[CompilerGenerated]
		private List<SqlCharacterBuff> c971de35e88b989d935e38aa9ee8f8848;

		// Token: 0x04000435 RID: 1077
		[CompilerGenerated]
		private Dictionary<uint, SqlCharacter> c6d39b612de613a32e94a4b8a63aa8946;

		// Token: 0x04000436 RID: 1078
		[CompilerGenerated]
		private Dictionary<uint, SqlExpertLimit> c2c539de60c08c13fbfef9faf9cf68722;

		// Token: 0x04000437 RID: 1079
		[CompilerGenerated]
		private Dictionary<uint, SqlScheduleItem> cdf8d363569c35bfa76054f3eb8620359;

		// Token: 0x04000438 RID: 1080
		[CompilerGenerated]
		private Dictionary<uint, SqlAppellation> cce7e92e30225ebaa95fc0f40671f381e;

		// Token: 0x04000439 RID: 1081
		[CompilerGenerated]
		private SqlAbility[] c6a0c0c94dd9c2b4d1bead34e88e5d1f8;

		// Token: 0x0400043A RID: 1082
		[CompilerGenerated]
		private bool c586a9179c28e5b94f0746158dc9dfd1e;
	}
}
