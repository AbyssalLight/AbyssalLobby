using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using RoR2;
using R2API;
using ScrollableLobbyUI;
using UnityEngine;
using UnityEngine.Events;
using RoR2.UI;

namespace AbyssalLobby.Modules
{
    class LobbyImprovments
    {
        public void Awake()
        {
            On.RoR2.UI.RuleCategoryController.SetData += (On.RoR2.UI.RuleCategoryController.orig_SetData orig, RoR2.UI.RuleCategoryController self, RuleCategoryDef categoryDef, RuleChoiceMask availability, RuleBook ruleBook) => 
            {
                orig(self, categoryDef, availability, ruleBook);
                this.minimizeResultGrid.GetComponent<HGButton>().onClick.AddListener(new UnityAction(this.CloseGrid));
                RuleCatalog.RuleCategoryType ruleCategoryType = self.ruleCategoryType;
                if (ruleCategoryType != RuleCatalog.RuleCategoryType.StripVote)
                {
                    if (ruleCategoryType == RuleCatalog.RuleCategoryType.VoteResultGrid)
                    {
                        self.voteResultGridContainer.gameObject.SetActive(false);
                    }
                }
            };
        }

        private void CloseGrid()
        {

        }

        private GameObject minimizeResultGrid;
    }
}
