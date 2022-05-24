using MonoMod.Cil;
using R2API;
using RoR2;
using RoR2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AbyssalLobby.Modules
{
    internal class RuleCatalogEdits
    {
        public static void RuleCatalogInit()
        {
            string prefix = AbyssalLobbyPlugin.developerPrefix + "_ITEMS_";

            #region ItemsTier1
            RuleCatalog.AddCategory(prefix + "RULE_HEADER_ITEMS_TIER1", prefix + "RULE_HEADER_ITEMS_TIER1_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.Tier1Item), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
            List<ItemIndex> list1 = new List<ItemIndex>();
            ItemIndex item1Index = 0;
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
                                              select i)
            {
                RuleCatalog.AddRule(ForItems(item1Index2));
            }
            #endregion

            #region ItemsTier2
            RuleCatalog.AddCategory(prefix + "RULE_HEADER_ITEMS_TIER2", prefix + "RULE_HEADER_ITEMS_TIER2_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.Tier2Item), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
            List<ItemIndex> list2 = new List<ItemIndex>();
            ItemIndex item2Index = 0;
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
                                              select i)
            {
                RuleCatalog.AddRule(ForItems(item2Index2));
            }
            #endregion

            #region ItemsTier3
            RuleCatalog.AddCategory(prefix + "RULE_HEADER_ITEMS_TIER3", prefix + "RULE_HEADER_ITEMS_TIER3_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.Tier3Item), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
            List<ItemIndex> list3 = new List<ItemIndex>();
            ItemIndex item3Index = 0;
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
                                              select i)
            {
                RuleCatalog.AddRule(ForItems(item3Index2));
            }
            #endregion

            #region ItemsTierLunar
            RuleCatalog.AddCategory(prefix + "RULE_HEADER_ITEMS_TIER_LUNAR", prefix + "RULE_HEADER_ITEMS_TIER_LUNAR_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.LunarItem), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
            List<ItemIndex> list4 = new List<ItemIndex>();
            ItemIndex item4Index = 0;
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
                                              select i)
            {
                RuleCatalog.AddRule(ForItems(item4Index2));
            }
            #endregion

            #region ItemsTierBoss
            RuleCatalog.AddCategory(prefix + "RULE_HEADER_ITEMS_TIER_BOSS", prefix + "RULE_HEADER_ITEMS_TIER_BOSS_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.BossItem), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
            List<ItemIndex> list5 = new List<ItemIndex>();
            ItemIndex item5Index = 0;
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
                                              select i)
            {
                RuleCatalog.AddRule(ForItems(item5Index2));
            }
            #endregion

            #region Equipment
            RuleCatalog.AddCategory("RULE_HEADER_EQUIPMENT", "RULE_HEADER_ITEMSANDEQUIPMENT_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.Equipment), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
            List<EquipmentIndex> list6 = new List<EquipmentIndex>();
            EquipmentIndex equipmentIndex = 0;
            EquipmentIndex equipmentCount = (EquipmentIndex)EquipmentCatalog.equipmentCount;
            while (equipmentIndex < equipmentCount)
            {
                list6.Add(equipmentIndex);
                equipmentIndex++;
            }
            foreach (EquipmentIndex equipmentIndex2 in from i in list6
                                                       where EquipmentCatalog.GetEquipmentDef(i).canDrop
                                                       orderby EquipmentCatalog.GetEquipmentDef(i).isLunar
                                                       select i)
            {
                RuleCatalog.AddRule(ForEquipment(equipmentIndex2));
            }
            #endregion
        }

        public static RuleDef ForItems(ItemIndex itemIndex)
        {
            ItemDef itemDef = ItemCatalog.GetItemDef(itemIndex);
            RuleDef ruleDef = new RuleDef("Items." + itemDef.name, itemDef.nameToken);
            RuleChoiceDef ruleChoiceDef = ruleDef.AddChoice("On", null, false);
            ruleChoiceDef.sprite = itemDef.pickupIconSprite;
            ruleChoiceDef.tooltipNameToken = itemDef.nameToken;
            ruleChoiceDef.tooltipBodyToken = itemDef.descriptionToken;
            ruleChoiceDef.unlockable = itemDef.unlockableDef;
            ruleChoiceDef.tooltipNameColor = ColorCatalog.GetColor(itemDef.colorIndex);
            ruleChoiceDef.itemIndex = itemIndex;
            ruleChoiceDef.selectionUISound = "Play_UI_artifactSelect";
            ruleChoiceDef.extraData = itemDef;
            ruleDef.MakeNewestChoiceDefault();
            RuleChoiceDef ruleChoiceDef2 = ruleDef.AddChoice("Off", null, false);
            ruleChoiceDef2.spritePath = "Textures/MiscIcons/texUnlockIcon";
            ruleChoiceDef2.tooltipNameToken = itemDef.nameToken;
            ruleChoiceDef2.getTooltipName = new Func<RuleChoiceDef, string>(RuleChoiceDef.GetOffTooltipNameFromToken);
            ruleChoiceDef2.tooltipBodyToken = itemDef.descriptionToken;
            ruleChoiceDef2.tooltipNameColor = ColorCatalog.GetColor(ColorCatalog.ColorIndex.Unaffordable);
            ruleChoiceDef.selectionUISound = "Play_UI_artifactDeselect";
            ruleChoiceDef.extraData = itemDef;
            return ruleDef;
        }

        public static RuleDef ForEquipment(EquipmentIndex equipmentIndex)
        {
            EquipmentDef equipmentDef = EquipmentCatalog.GetEquipmentDef(equipmentIndex);
            RuleDef ruleDef = new RuleDef("Equipment." + equipmentDef.name, equipmentDef.nameToken);
            RuleChoiceDef ruleChoiceDef = ruleDef.AddChoice("On", null, false);
            ruleChoiceDef.sprite = equipmentDef.pickupIconSprite;
            ruleChoiceDef.tooltipNameToken = equipmentDef.nameToken;
            ruleChoiceDef.tooltipBodyToken = equipmentDef.descriptionToken;
            ruleChoiceDef.unlockable = equipmentDef.unlockableDef;
            ruleChoiceDef.tooltipNameColor = ColorCatalog.GetColor(equipmentDef.colorIndex);
            ruleChoiceDef.equipmentIndex = equipmentIndex;
            ruleChoiceDef.selectionUISound = "Play_UI_artifactSelect";
            ruleChoiceDef.extraData = equipmentDef;
            ruleChoiceDef.availableInMultiPlayer = equipmentDef.appearsInMultiPlayer;
            ruleChoiceDef.availableInSinglePlayer = equipmentDef.appearsInSinglePlayer;
            ruleDef.MakeNewestChoiceDefault();
            RuleChoiceDef ruleChoiceDef2 = ruleDef.AddChoice("Off", null, false);
            ruleChoiceDef2.spritePath = "Textures/MiscIcons/texUnlockIcon";
            ruleChoiceDef2.tooltipNameToken = equipmentDef.nameToken;
            ruleChoiceDef2.getTooltipName = new Func<RuleChoiceDef, string>(RuleChoiceDef.GetOffTooltipNameFromToken);
            ruleChoiceDef2.tooltipBodyToken = equipmentDef.descriptionToken;
            ruleChoiceDef2.tooltipNameColor = ColorCatalog.GetColor(ColorCatalog.ColorIndex.Unaffordable);
            ruleChoiceDef.selectionUISound = "Play_UI_artifactDeselect";
            ruleChoiceDef.extraData = equipmentDef;
            return ruleDef;
        }
    }
}
