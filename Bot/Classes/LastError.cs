using System;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000549 RID: 1353
	public enum LastError
	{
		// Token: 0x040012BA RID: 4794
		Unknown,
		// Token: 0x040012BB RID: 4795
		InvalidParam,
		// Token: 0x040012BC RID: 4796
		NotEnouthMp,
		// Token: 0x040012BD RID: 4797
		ObjectInStealth,
		// Token: 0x040012BE RID: 4798
		NoLineOfSight,
		// Token: 0x040012BF RID: 4799
		ResponseTimeout,
		// Token: 0x040012C0 RID: 4800
		ResponseFalse,
		// Token: 0x040012C1 RID: 4801
		InvalidItemPlace,
		// Token: 0x040012C2 RID: 4802
		InvalidItem,
		// Token: 0x040012C3 RID: 4803
		NoFreeInventorySlots,
		// Token: 0x040012C4 RID: 4804
		MailBoxNotFound,
		// Token: 0x040012C5 RID: 4805
		AuctioneerNotFound,
		// Token: 0x040012C6 RID: 4806
		ComeToFailed,
		// Token: 0x040012C7 RID: 4807
		MailNoBody,
		// Token: 0x040012C8 RID: 4808
		NotEnouthGold,
		// Token: 0x040012C9 RID: 4809
		MailHaveAttachments,
		// Token: 0x040012CA RID: 4810
		SkillRequiredEquipedItem,
		// Token: 0x040012CB RID: 4811
		InvalidTarget,
		// Token: 0x040012CC RID: 4812
		UnmountedState,
		// Token: 0x040012CD RID: 4813
		MountedState,
		// Token: 0x040012CE RID: 4814
		UnknownItemType,
		// Token: 0x040012CF RID: 4815
		AlreadyHaveMount,
		// Token: 0x040012D0 RID: 4816
		CooldownNotReady,
		// Token: 0x040012D1 RID: 4817
		TargetTooFarAway,
		// Token: 0x040012D2 RID: 4818
		AnotherHousingHere,
		// Token: 0x040012D3 RID: 4819
		AlreadyCasting,
		// Token: 0x040012D4 RID: 4820
		PrisonerFail,
		// Token: 0x040012D5 RID: 4821
		StunFail,
		// Token: 0x040012D6 RID: 4822
		SilenceFail,
		// Token: 0x040012D7 RID: 4823
		NotEnouthIngridients,
		// Token: 0x040012D8 RID: 4824
		ActionNotAllowed,
		// Token: 0x040012D9 RID: 4825
		RessurectNeedWaitMoreTime,
		// Token: 0x040012DA RID: 4826
		NoSlave,
		// Token: 0x040012DB RID: 4827
		NoMount,
		// Token: 0x040012DC RID: 4828
		NoQuest,
		// Token: 0x040012DD RID: 4829
		QuestNpcNotFound,
		// Token: 0x040012DE RID: 4830
		AlreadyHaveQuest,
		// Token: 0x040012DF RID: 4831
		QuestAlreadyDone,
		// Token: 0x040012E0 RID: 4832
		MerchantNotFound,
		// Token: 0x040012E1 RID: 4833
		NotEnouthLaborPoints,
		// Token: 0x040012E2 RID: 4834
		NoBackpack,
		// Token: 0x040012E3 RID: 4835
		CrafterNotFound,
		// Token: 0x040012E4 RID: 4836
		NotEnouthHonorPoints,
		// Token: 0x040012E5 RID: 4837
		NotEnouthLivingPoints,
		// Token: 0x040012E6 RID: 4838
		TradeNotLockedYet,
		// Token: 0x040012E7 RID: 4839
		NoTrade,
		// Token: 0x040012E8 RID: 4840
		TradeAlreadyOpen,
		// Token: 0x040012E9 RID: 4841
		CantTradeWithEnemy,
		// Token: 0x040012EA RID: 4842
		InvalidZCoordinate,
		// Token: 0x040012EB RID: 4843
		InvalidAngle,
		// Token: 0x040012EC RID: 4844
		NotEnouthSkillPoints,
		// Token: 0x040012ED RID: 4845
		AlreadyLearned,
		// Token: 0x040012EE RID: 4846
		NotEnouthAbilitySkillLevel,
		// Token: 0x040012EF RID: 4847
		LevelTooLow,
		// Token: 0x040012F0 RID: 4848
		PriestNotFound,
		// Token: 0x040012F1 RID: 4849
		NoParty,
		// Token: 0x040012F2 RID: 4850
		RequestRaid,
		// Token: 0x040012F3 RID: 4851
		RequestParty,
		// Token: 0x040012F4 RID: 4852
		NoFreeWareHouseSlots,
		// Token: 0x040012F5 RID: 4853
		BlacksmithNotFound,
		// Token: 0x040012F6 RID: 4854
		LimitReached,
		// Token: 0x040012F7 RID: 4855
		DoodadHaventThisSkill,
		// Token: 0x040012F8 RID: 4856
		UnknownFarmType,
		// Token: 0x040012F9 RID: 4857
		CannotBePlantedHere,
		// Token: 0x040012FA RID: 4858
		MoveTimeout,
		// Token: 0x040012FB RID: 4859
		MoveTooFarDistance,
		// Token: 0x040012FC RID: 4860
		AnotherMoveCalled,
		// Token: 0x040012FD RID: 4861
		MoveCallFailed,
		// Token: 0x040012FE RID: 4862
		MovePossibleStuck,
		// Token: 0x040012FF RID: 4863
		MovePossibleFullStop,
		// Token: 0x04001300 RID: 4864
		MoveCanceled,
		// Token: 0x04001301 RID: 4865
		MoveUnknownError,
		// Token: 0x04001302 RID: 4866
		GpsCantFindNearestPoint,
		// Token: 0x04001303 RID: 4867
		GpsCantFindEndPoint,
		// Token: 0x04001304 RID: 4868
		PetManagerNotFound,
		// Token: 0x04001305 RID: 4869
		JudgeNotFound,
		// Token: 0x04001306 RID: 4870
		ObjectDissapear,
		// Token: 0x04001307 RID: 4871
		NeedUnpackItem
	}
}
