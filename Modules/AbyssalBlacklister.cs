﻿using BepInEx;
using RoR2;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

namespace AbyssalItemVotes.Modules
{
    [BepInDependency("com.bepis.r2api")]

    [BepInPlugin("com.AbyssalLight.AbyssalBlacklister", "AbyssalBlackLister", "0.0.1")]

    class AbyssalBlacklister : BaseUnityPlugin
    {
        public void Awake()
		{
			AbyssalTokens.AddTokens();

			On.RoR2.RuleDef.AddChoice += (orig, self, choiceName, extraData, excludeByDefault) =>
			{
				excludeByDefault = false;
				var myvar = orig(self, choiceName, extraData, excludeByDefault);
				return myvar;
			};

			On.RoR2.RuleCatalog.HiddenTestItemsConvar += (self) =>
			{
				return false;
			};

			On.RoR2.RuleCatalog.HiddenTestTrue += (self) =>
			{
				return false;
			};

			On.RoR2.RuleCatalog.Init += (orig) =>
            {
                #region Difficulty/Artifact
                RuleCatalog.AddCategory("RULE_HEADER_DIFFICULTY", "", new Color32(43, 124, 181, byte.MaxValue));
				RuleCatalog.AddRule(RuleDef.FromDifficulty());
				RuleCatalog.artifactRuleCategory = RuleCatalog.AddCategory("RULE_HEADER_ARTIFACTS", "RULE_HEADER_ARTIFACTS_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.Artifact), "RULE_ARTIFACTS_EMPTY_TIP", "RULE_HEADER_ARTIFACTS_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
				for (ArtifactIndex artifactIndex = (ArtifactIndex)0; artifactIndex < (ArtifactIndex)ArtifactCatalog.artifactCount; artifactIndex++)
				{
					RuleCatalog.AddRule(RuleDef.FromArtifact(artifactIndex));
				}
                #endregion

                #region ItemsTier1
                RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER1", "RULE_HEADER_ITEMS_TIER1_SUBTITLE", new Color32(255, 255, 255, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
				List<ItemIndex> list1 = new List<ItemIndex>();
				ItemIndex item1Index = (ItemIndex)0;
				ItemIndex item1Count = (ItemIndex)ItemCatalog.itemCount;
				while (item1Index < item1Count)
				{
					if (ItemCatalog.GetItemDef(item1Index).tier == ItemTier.Tier1)
                    {
						list1.Add(item1Index);
					}
					item1Index++;
				}
				foreach (ItemIndex item1Index2 in from i in list1
												 where ItemCatalog.GetItemDef(i).inDroppableTier
												 orderby ItemCatalog.GetItemDef(i).tier
												 select i)
				{
					RuleCatalog.AddRule(RuleDef.FromItem(item1Index2));
				}
				#endregion

				#region ItemsTier2
				RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER2", "RULE_HEADER_ITEMS_TIER2_SUBTITLE", new Color32(0, 153, 51, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
				List<ItemIndex> list2 = new List<ItemIndex>();
				ItemIndex item2Index = (ItemIndex)0;
				ItemIndex item2Count = (ItemIndex)ItemCatalog.itemCount;
				while (item2Index < item2Count)
				{
					if (ItemCatalog.GetItemDef(item2Index).tier == ItemTier.Tier2)
					{
						list2.Add(item2Index);
					}
					item2Index++;
				}
				foreach (ItemIndex item2Index2 in from i in list2
												 where ItemCatalog.GetItemDef(i).inDroppableTier
												 orderby ItemCatalog.GetItemDef(i).tier
												 select i)
				{
					RuleCatalog.AddRule(RuleDef.FromItem(item2Index2));
				}
				#endregion

				#region ItemsTier3
				RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER3", "RULE_HEADER_ITEMS_TIER3_SUBTITLE", new Color32(204, 0, 0, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
				List<ItemIndex> list3 = new List<ItemIndex>();
				ItemIndex item3Index = (ItemIndex)0;
				ItemIndex item3Count = (ItemIndex)ItemCatalog.itemCount;
				while (item3Index < item3Count)
				{
					if (ItemCatalog.GetItemDef(item3Index).tier == ItemTier.Tier3)
					{
						list3.Add(item3Index);
					}
					item3Index++;
				}
				foreach (ItemIndex item3Index2 in from i in list3
												  where ItemCatalog.GetItemDef(i).inDroppableTier
												  orderby ItemCatalog.GetItemDef(i).tier
												  select i)
				{
					RuleCatalog.AddRule(RuleDef.FromItem(item3Index2));
				}
				#endregion

				#region ItemsTierLunar
				RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER_LUNAR", "RULE_HEADER_ITEMS_TIER_LUNAR_SUBTITLE", new Color32(0, 153, 255, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
				List<ItemIndex> list4 = new List<ItemIndex>();
				ItemIndex item4Index = (ItemIndex)0;
				ItemIndex item4Count = (ItemIndex)ItemCatalog.itemCount;
				while (item4Index < item4Count)
				{
					if (ItemCatalog.GetItemDef(item4Index).tier == ItemTier.Lunar)
					{
						list4.Add(item4Index);
					}
					item4Index++;
				}
				foreach (ItemIndex item4Index2 in from i in list4
												  where ItemCatalog.GetItemDef(i).inDroppableTier
												  orderby ItemCatalog.GetItemDef(i).tier
												  select i)
				{
					RuleCatalog.AddRule(RuleDef.FromItem(item4Index2));
				}
				#endregion

				#region ItemsTierBoss
				RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER_BOSS", "RULE_HEADER_ITEMS_TIER_BOSS_SUBTITLE", new Color32(255, 255, 102, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
				List<ItemIndex> list5 = new List<ItemIndex>();
				ItemIndex item5Index = (ItemIndex)0;
				ItemIndex item5Count = (ItemIndex)ItemCatalog.itemCount;
				while (item5Index < item5Count)
				{
					if (ItemCatalog.GetItemDef(item5Index).tier == ItemTier.Boss)
					{
						list5.Add(item5Index);
					}
					item5Index++;
				}
				foreach (ItemIndex item5Index2 in from i in list5
												  where ItemCatalog.GetItemDef(i).inDroppableTier
												  orderby ItemCatalog.GetItemDef(i).tier
												  select i)
				{
					RuleCatalog.AddRule(RuleDef.FromItem(item5Index2));
				}
				#endregion

				#region Equipment
				RuleCatalog.AddCategory("RULE_HEADER_EQUIPMENT", "RULE_HEADER_ITEMSANDEQUIPMENT_SUBTITLE", new Color32(byte.MaxValue, 128, 0, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
				List<EquipmentIndex> list6 = new List<EquipmentIndex>();
				EquipmentIndex equipmentIndex = (EquipmentIndex)0;
				EquipmentIndex equipmentCount = (EquipmentIndex)EquipmentCatalog.equipmentCount;
				while (equipmentIndex < equipmentCount)
				{
					list6.Add(equipmentIndex);
					equipmentIndex++;
				}
				foreach (EquipmentIndex equipmentIndex2 in from i in list6
														   where EquipmentCatalog.GetEquipmentDef(i).canDrop
														   select i)
				{
					RuleCatalog.AddRule(RuleDef.FromEquipment(equipmentIndex2));
				}
                #endregion

                #region RuleDefs
                RuleCatalog.AddCategory("RULE_HEADER_MISC", "", new Color32(192, 192, 192, byte.MaxValue), null, "", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
				RuleDef ruleDef = new RuleDef("Misc.StartingMoney", "RULE_MISC_STARTING_MONEY");
				RuleChoiceDef ruleChoiceDef = ruleDef.AddChoice("0", 0U, true);
				ruleChoiceDef.tooltipNameToken = "RULE_STARTINGMONEY_CHOICE_0_NAME";
				ruleChoiceDef.tooltipBodyToken = "RULE_STARTINGMONEY_CHOICE_0_DESC";
				ruleChoiceDef.tooltipNameColor = ColorCatalog.GetColor(ColorCatalog.ColorIndex.LunarCoin);
				ruleChoiceDef.onlyShowInGameBrowserIfNonDefault = true;
				RuleChoiceDef ruleChoiceDef2 = ruleDef.AddChoice("15", 15U, true);
				ruleChoiceDef2.tooltipNameToken = "RULE_STARTINGMONEY_CHOICE_15_NAME";
				ruleChoiceDef2.tooltipBodyToken = "RULE_STARTINGMONEY_CHOICE_15_DESC";
				ruleChoiceDef2.tooltipNameColor = ColorCatalog.GetColor(ColorCatalog.ColorIndex.LunarCoin);
				ruleChoiceDef2.onlyShowInGameBrowserIfNonDefault = true;
				ruleDef.MakeNewestChoiceDefault();
				RuleChoiceDef ruleChoiceDef3 = ruleDef.AddChoice("50", 50U, true);
				ruleChoiceDef3.tooltipNameToken = "RULE_STARTINGMONEY_CHOICE_50_NAME";
				ruleChoiceDef3.tooltipBodyToken = "RULE_STARTINGMONEY_CHOICE_50_DESC";
				ruleChoiceDef3.spritePath = "Textures/MiscIcons/texRuleBonusStartingMoney";
				ruleChoiceDef3.tooltipNameColor = ColorCatalog.GetColor(ColorCatalog.ColorIndex.LunarCoin);
				ruleChoiceDef3.onlyShowInGameBrowserIfNonDefault = true;
				RuleCatalog.AddRule(ruleDef);
				RuleDef ruleDef2 = new RuleDef("Misc.StageOrder", "RULE_MISC_STAGE_ORDER");
				RuleChoiceDef ruleChoiceDef4 = ruleDef2.AddChoice("Normal", StageOrder.Normal, true);
				ruleChoiceDef4.tooltipNameToken = "RULE_STAGEORDER_CHOICE_NORMAL_NAME";
				ruleChoiceDef4.tooltipBodyToken = "RULE_STAGEORDER_CHOICE_NORMAL_DESC";
				ruleChoiceDef4.tooltipNameColor = ColorCatalog.GetColor(ColorCatalog.ColorIndex.LunarCoin);
				ruleChoiceDef4.onlyShowInGameBrowserIfNonDefault = true;
				ruleDef2.MakeNewestChoiceDefault();
				RuleChoiceDef ruleChoiceDef5 = ruleDef2.AddChoice("Random", StageOrder.Random, true);
				ruleChoiceDef5.tooltipNameToken = "RULE_STAGEORDER_CHOICE_RANDOM_NAME";
				ruleChoiceDef5.tooltipBodyToken = "RULE_STAGEORDER_CHOICE_RANDOM_DESC";
				ruleChoiceDef5.spritePath = "Textures/MiscIcons/texRuleMapIsRandom";
				ruleChoiceDef5.tooltipNameColor = ColorCatalog.GetColor(ColorCatalog.ColorIndex.LunarCoin);
				ruleChoiceDef5.onlyShowInGameBrowserIfNonDefault = true;
				RuleCatalog.AddRule(ruleDef2);
				RuleDef ruleDef3 = new RuleDef("Misc.KeepMoneyBetweenStages", "RULE_MISC_KEEP_MONEY_BETWEEN_STAGES");
				RuleChoiceDef ruleChoiceDef6 = ruleDef3.AddChoice("On", true, true);
				ruleChoiceDef6.tooltipNameToken = "";
				ruleChoiceDef6.tooltipBodyToken = "RULE_KEEPMONEYBETWEENSTAGES_CHOICE_ON_DESC";
				ruleChoiceDef6.onlyShowInGameBrowserIfNonDefault = true;
				RuleChoiceDef ruleChoiceDef7 = ruleDef3.AddChoice("Off", false, true);
				ruleChoiceDef7.tooltipNameToken = "";
				ruleChoiceDef7.tooltipBodyToken = "RULE_KEEPMONEYBETWEENSTAGES_CHOICE_OFF_DESC";
				ruleChoiceDef7.onlyShowInGameBrowserIfNonDefault = true;
				ruleDef3.MakeNewestChoiceDefault();
				RuleCatalog.AddRule(ruleDef3);
				RuleDef ruleDef4 = new RuleDef("Misc.AllowDropIn", "RULE_MISC_ALLOW_DROP_IN");
				RuleChoiceDef ruleChoiceDef8 = ruleDef4.AddChoice("On", true, true);
				ruleChoiceDef8.tooltipNameToken = "";
				ruleChoiceDef8.tooltipBodyToken = "RULE_ALLOWDROPIN_CHOICE_ON_DESC";
				ruleChoiceDef8.onlyShowInGameBrowserIfNonDefault = true;
				RuleChoiceDef ruleChoiceDef9 = ruleDef4.AddChoice("Off", false, true);
				ruleChoiceDef9.tooltipNameToken = "";
				ruleChoiceDef9.tooltipBodyToken = "RULE_ALLOWDROPIN_CHOICE_OFF_DESC";
				ruleChoiceDef9.onlyShowInGameBrowserIfNonDefault = true;
				ruleDef4.MakeNewestChoiceDefault();
				RuleCatalog.AddRule(ruleDef4);
				for (int k = 0; k < RuleCatalog.allRuleDefs.Count; k++)
				{
					RuleDef ruleDef5 = RuleCatalog.allRuleDefs[k];
					ruleDef5.globalIndex = k;
					for (int j = 0; j < ruleDef5.choices.Count; j++)
					{
						RuleChoiceDef ruleChoiceDef10 = ruleDef5.choices[j];
						ruleChoiceDef10.localIndex = j;
						ruleChoiceDef10.globalIndex = RuleCatalog.allChoicesDefs.Count;
						RuleCatalog.allChoicesDefs.Add(ruleChoiceDef10);
					}
					RuleCatalog._allChoiceDefsWithUnlocks = (from choiceDef in RuleCatalog.allChoicesDefs
															 where choiceDef.unlockable
															 select choiceDef).ToArray<RuleChoiceDef>();
				}
                #endregion

                RuleCatalog.availability.MakeAvailable();
			};
        }
    }
}