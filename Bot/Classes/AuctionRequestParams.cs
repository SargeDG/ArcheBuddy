using System;
using A;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x0200052C RID: 1324
	public class AuctionRequestParams : MarshalProxy
	{
		// Token: 0x06001DFE RID: 7678 RVA: 0x0012F4DC File Offset: 0x0012D6DC
		public AuctionRequestParams()
		{
			this.auctionCategory = (AuctionCategory)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91720);
			this.minLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91724);
			this.maxLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91728);
			this.searchText = "";
			this.completeMatch = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91732) != 0);
			this.grade = (ItemGrade)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91736);
			this.sortType = (AuctionSortType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91740);
			this.sortOrder = (SortOrder)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91744);
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0012F56C File Offset: 0x0012D76C
		public AuctionRequestParams(AuctionCategory aucCategory)
		{
			this.auctionCategory = aucCategory;
			this.minLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91748);
			this.maxLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91752);
			this.searchText = "";
			this.completeMatch = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91756) != 0);
			this.grade = (ItemGrade)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91760);
			this.sortType = (AuctionSortType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91764);
			this.sortOrder = (SortOrder)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91768);
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x0012F5F4 File Offset: 0x0012D7F4
		public AuctionRequestParams(AuctionCategory aucCategory, byte aucMinLevel, byte aucMaxLevel)
		{
			this.auctionCategory = aucCategory;
			this.minLevel = aucMinLevel;
			this.maxLevel = aucMaxLevel;
			this.searchText = "";
			this.completeMatch = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91772) != 0);
			this.grade = (ItemGrade)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91776);
			this.sortType = (AuctionSortType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91780);
			this.sortOrder = (SortOrder)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91784);
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0012F668 File Offset: 0x0012D868
		public AuctionRequestParams(AuctionCategory aucCategory, ItemGrade aucGrade)
		{
			this.auctionCategory = aucCategory;
			this.minLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91788);
			this.maxLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91792);
			this.searchText = "";
			this.completeMatch = (c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91796) != 0);
			this.grade = aucGrade;
			this.sortType = (AuctionSortType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91800);
			this.sortOrder = (SortOrder)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91804);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0012F6E4 File Offset: 0x0012D8E4
		public AuctionRequestParams(string aucSearchText, bool aucCompleteMatch = false)
		{
			this.auctionCategory = (AuctionCategory)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91808);
			this.minLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91812);
			this.maxLevel = (byte)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91816);
			this.searchText = aucSearchText;
			this.completeMatch = aucCompleteMatch;
			this.grade = (ItemGrade)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91820);
			this.sortType = (AuctionSortType)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91824);
			this.sortOrder = (SortOrder)c4929ffb646fb9ba9deb5f553efe8c57b.c185d731bee241637ed623c74ebeedc15(91828);
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0012F768 File Offset: 0x0012D968
		public AuctionRequestParams(AuctionCategory aucCategory, byte aucMinLevel, byte aucMaxLevel, string aucSearchText, bool aucCompleteMatch, ItemGrade aucGrade, AuctionSortType aucSortType, SortOrder aucSortOrder)
		{
			this.auctionCategory = aucCategory;
			this.minLevel = aucMinLevel;
			this.maxLevel = aucMaxLevel;
			this.searchText = aucSearchText;
			this.completeMatch = aucCompleteMatch;
			this.grade = aucGrade;
			this.sortType = aucSortType;
			this.sortOrder = aucSortOrder;
		}

		// Token: 0x0400113E RID: 4414
		public AuctionCategory auctionCategory;

		// Token: 0x0400113F RID: 4415
		public byte minLevel;

		// Token: 0x04001140 RID: 4416
		public byte maxLevel;

		// Token: 0x04001141 RID: 4417
		public string searchText;

		// Token: 0x04001142 RID: 4418
		public bool completeMatch;

		// Token: 0x04001143 RID: 4419
		public ItemGrade grade;

		// Token: 0x04001144 RID: 4420
		public AuctionSortType sortType;

		// Token: 0x04001145 RID: 4421
		public SortOrder sortOrder;
	}
}
