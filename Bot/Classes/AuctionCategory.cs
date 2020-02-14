using System;

namespace ArcheBuddy.Bot.Classes
{
	// Token: 0x02000530 RID: 1328
	public enum AuctionCategory : byte
	{
		// Token: 0x04001155 RID: 4437
		Off,
		// Token: 0x04001156 RID: 4438
		Weapon,
		// Token: 0x04001157 RID: 4439
		Armor,
		// Token: 0x04001158 RID: 4440
		Accessory,
		// Token: 0x04001159 RID: 4441
		Instrument,
		// Token: 0x0400115A RID: 4442
		Costume,
		// Token: 0x0400115B RID: 4443
		Consumable,
		// Token: 0x0400115C RID: 4444
		Craft,
		// Token: 0x0400115D RID: 4445
		Machine,
		// Token: 0x0400115E RID: 4446
		Pet,
		// Token: 0x0400115F RID: 4447
		Etc,
		// Token: 0x04001160 RID: 4448
		DeclareSiege,
		// Token: 0x04001161 RID: 4449
		OneHanded,
		// Token: 0x04001162 RID: 4450
		TwoHanded,
		// Token: 0x04001163 RID: 4451
		Ranged,
		// Token: 0x04001164 RID: 4452
		ClothArmor,
		// Token: 0x04001165 RID: 4453
		LeatherArmor,
		// Token: 0x04001166 RID: 4454
		PlateArmor,
		// Token: 0x04001167 RID: 4455
		Shield,
		// Token: 0x04001168 RID: 4456
		Cape,
		// Token: 0x04001169 RID: 4457
		Ear,
		// Token: 0x0400116A RID: 4458
		Neck,
		// Token: 0x0400116B RID: 4459
		Finger,
		// Token: 0x0400116C RID: 4460
		Tube,
		// Token: 0x0400116D RID: 4461
		Percussion = 25,
		// Token: 0x0400116E RID: 4462
		Potion,
		// Token: 0x0400116F RID: 4463
		Food,
		// Token: 0x04001170 RID: 4464
		Drink,
		// Token: 0x04001171 RID: 4465
		Tool,
		// Token: 0x04001172 RID: 4466
		Bomb,
		// Token: 0x04001173 RID: 4467
		Moonstone,
		// Token: 0x04001174 RID: 4468
		Recipe,
		// Token: 0x04001175 RID: 4469
		Alchemy,
		// Token: 0x04001176 RID: 4470
		Archium,
		// Token: 0x04001177 RID: 4471
		RawIngredient,
		// Token: 0x04001178 RID: 4472
		StuffIngredient,
		// Token: 0x04001179 RID: 4473
		Animal,
		// Token: 0x0400117A RID: 4474
		Plant,
		// Token: 0x0400117B RID: 4475
		HouseDeco,
		// Token: 0x0400117C RID: 4476
		Book,
		// Token: 0x0400117D RID: 4477
		Vehicle,
		// Token: 0x0400117E RID: 4478
		Ship,
		// Token: 0x0400117F RID: 4479
		Glider,
		// Token: 0x04001180 RID: 4480
		Siege,
		// Token: 0x04001181 RID: 4481
		Mount,
		// Token: 0x04001182 RID: 4482
		MountGear,
		// Token: 0x04001183 RID: 4483
		Quest,
		// Token: 0x04001184 RID: 4484
		Junk,
		// Token: 0x04001185 RID: 4485
		Coin,
		// Token: 0x04001186 RID: 4486
		Dagger,
		// Token: 0x04001187 RID: 4487
		OneHandSword,
		// Token: 0x04001188 RID: 4488
		OneHandBlade,
		// Token: 0x04001189 RID: 4489
		OneHandSpear,
		// Token: 0x0400118A RID: 4490
		OneHandAxe,
		// Token: 0x0400118B RID: 4491
		OneHandMace,
		// Token: 0x0400118C RID: 4492
		OneHandStaff,
		// Token: 0x0400118D RID: 4493
		TwoHandSword,
		// Token: 0x0400118E RID: 4494
		TwoHandBlade,
		// Token: 0x0400118F RID: 4495
		TwoHandSpear,
		// Token: 0x04001190 RID: 4496
		TwoHandAxe,
		// Token: 0x04001191 RID: 4497
		TwoHandMace,
		// Token: 0x04001192 RID: 4498
		TwoHandStaff,
		// Token: 0x04001193 RID: 4499
		Bow,
		// Token: 0x04001194 RID: 4500
		ClothHead,
		// Token: 0x04001195 RID: 4501
		ClothChest,
		// Token: 0x04001196 RID: 4502
		ClothWaist,
		// Token: 0x04001197 RID: 4503
		ClothArms,
		// Token: 0x04001198 RID: 4504
		ClothHands,
		// Token: 0x04001199 RID: 4505
		ClothLegs,
		// Token: 0x0400119A RID: 4506
		ClothFeet,
		// Token: 0x0400119B RID: 4507
		LeatherHead,
		// Token: 0x0400119C RID: 4508
		LeatherChest,
		// Token: 0x0400119D RID: 4509
		LeatherWaist,
		// Token: 0x0400119E RID: 4510
		LeatherArms,
		// Token: 0x0400119F RID: 4511
		LeatherHands,
		// Token: 0x040011A0 RID: 4512
		LeatherLegs,
		// Token: 0x040011A1 RID: 4513
		LeatherFeet,
		// Token: 0x040011A2 RID: 4514
		PlateHead,
		// Token: 0x040011A3 RID: 4515
		PlateChest,
		// Token: 0x040011A4 RID: 4516
		PlateWaist,
		// Token: 0x040011A5 RID: 4517
		PlateArms,
		// Token: 0x040011A6 RID: 4518
		PlateHands,
		// Token: 0x040011A7 RID: 4519
		PlateLegs,
		// Token: 0x040011A8 RID: 4520
		PlateFeet,
		// Token: 0x040011A9 RID: 4521
		Ore,
		// Token: 0x040011AA RID: 4522
		RawWood,
		// Token: 0x040011AB RID: 4523
		Rock,
		// Token: 0x040011AC RID: 4524
		Skin,
		// Token: 0x040011AD RID: 4525
		Fur,
		// Token: 0x040011AE RID: 4526
		MachinePart,
		// Token: 0x040011AF RID: 4527
		Meat,
		// Token: 0x040011B0 RID: 4528
		Aquatic,
		// Token: 0x040011B1 RID: 4529
		Grain,
		// Token: 0x040011B2 RID: 4530
		Vegetable,
		// Token: 0x040011B3 RID: 4531
		Fruit,
		// Token: 0x040011B4 RID: 4532
		Spice,
		// Token: 0x040011B5 RID: 4533
		Medicine,
		// Token: 0x040011B6 RID: 4534
		Flower,
		// Token: 0x040011B7 RID: 4535
		Soil,
		// Token: 0x040011B8 RID: 4536
		Gem,
		// Token: 0x040011B9 RID: 4537
		Paper,
		// Token: 0x040011BA RID: 4538
		Metal,
		// Token: 0x040011BB RID: 4539
		Wood,
		// Token: 0x040011BC RID: 4540
		Stone,
		// Token: 0x040011BD RID: 4541
		Cloth = 106,
		// Token: 0x040011BE RID: 4542
		MachineParts,
		// Token: 0x040011BF RID: 4543
		Glass,
		// Token: 0x040011C0 RID: 4544
		Rubber,
		// Token: 0x040011C1 RID: 4545
		Jewel,
		// Token: 0x040011C2 RID: 4546
		AlchemyReagents,
		// Token: 0x040011C3 RID: 4547
		Misc,
		// Token: 0x040011C4 RID: 4548
		Livestock,
		// Token: 0x040011C5 RID: 4549
		Sappling,
		// Token: 0x040011C6 RID: 4550
		Seed,
		// Token: 0x040011C7 RID: 4551
		Furniture,
		// Token: 0x040011C8 RID: 4552
		Adventure,
		// Token: 0x040011C9 RID: 4553
		Toy,
		// Token: 0x040011CA RID: 4554
		Dye,
		// Token: 0x040011CB RID: 4555
		CookingOil,
		// Token: 0x040011CC RID: 4556
		Seasoning
	}
}
