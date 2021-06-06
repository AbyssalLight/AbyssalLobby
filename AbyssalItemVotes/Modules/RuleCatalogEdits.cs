using RoR2;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace AbyssalLobby.Modules
{
    class RuleCatalogEdits
    {
        public void TurnOnCatalog()
        {
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
        }

        public void RuleCatalogInit()
        {
            On.RoR2.RuleCatalog.Init += (orig) =>
            {
                #region Difficulty/Artifact
                RuleCatalog.AddCategory("RULE_HEADER_DIFFICULTY", "", new Color32(43, 124, 181, byte.MaxValue));
                RuleCatalog.AddRule(RuleDef.FromDifficulty());
                RuleCatalog.artifactRuleCategory = RuleCatalog.AddCategory("RULE_HEADER_ARTIFACTS", "RULE_HEADER_ARTIFACTS_SUBTITLE", ColorCatalog.GetColor(ColorCatalog.ColorIndex.Artifact), "RULE_ARTIFACTS_EMPTY_TIP", "RULE_HEADER_ARTIFACTS_EDIT", new Func<bool>(RuleCatalog.HiddenTestFalse), RuleCatalog.RuleCategoryType.VoteResultGrid);
                for (ArtifactIndex artifactIndex = 0; artifactIndex < (ArtifactIndex)ArtifactCatalog.artifactCount; artifactIndex++)
                {
                    RuleCatalog.AddRule(RuleDef.FromArtifact(artifactIndex));
                }
                #endregion

                #region ItemsTier1
                RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER1", "RULE_HEADER_ITEMS_TIER1_SUBTITLE", new Color32(255, 255, 255, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
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
                                                  orderby ItemCatalog.GetItemDef(i).tier
                                                  select i)
                {
                    RuleCatalog.AddRule(RuleDef.FromItem(item1Index2));
                }
                #endregion

                #region ItemsTier2
                RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER2", "RULE_HEADER_ITEMS_TIER2_SUBTITLE", new Color32(0, 153, 51, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
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
                                                  orderby ItemCatalog.GetItemDef(i).tier
                                                  select i)
                {
                    RuleCatalog.AddRule(RuleDef.FromItem(item2Index2));
                }
                #endregion

                #region ItemsTier3
                RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER3", "RULE_HEADER_ITEMS_TIER3_SUBTITLE", new Color32(204, 0, 0, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
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
                                                  orderby ItemCatalog.GetItemDef(i).tier
                                                  select i)
                {
                    RuleCatalog.AddRule(RuleDef.FromItem(item3Index2));
                }
                #endregion

                #region ItemsTierLunar
                RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER_LUNAR", "RULE_HEADER_ITEMS_TIER_LUNAR_SUBTITLE", new Color32(0, 153, 255, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
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
                                                  orderby ItemCatalog.GetItemDef(i).tier
                                                  select i)
                {
                    RuleCatalog.AddRule(RuleDef.FromItem(item4Index2));
                }
                #endregion

                #region ItemsTierBoss
                RuleCatalog.AddCategory("RULE_HEADER_ITEMS_TIER_BOSS", "RULE_HEADER_ITEMS_TIER_BOSS_SUBTITLE", new Color32(255, 255, 102, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
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
                                                  orderby ItemCatalog.GetItemDef(i).tier
                                                  select i)
                {
                    RuleCatalog.AddRule(RuleDef.FromItem(item5Index2));
                }
                #endregion

                #region Equipment
                RuleCatalog.AddCategory("RULE_HEADER_EQUIPMENT", "RULE_HEADER_ITEMSANDEQUIPMENT_SUBTITLE", new Color32(byte.MaxValue, 128, 0, byte.MaxValue), null, "RULE_HEADER_ITEMSANDEQUIPMENT_EDIT", new Func<bool>(RuleCatalog.HiddenTestItemsConvar), RuleCatalog.RuleCategoryType.VoteResultGrid);
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
                    RuleCatalog.AddRule(RuleDef.FromEquipment(equipmentIndex2));
                }
                #endregion

                RuleCatalog.availability.MakeAvailable();
            };
        }
    }
}
