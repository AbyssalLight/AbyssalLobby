using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using RoR2;
using RoR2.UI;
using R2API;
using ScrollableLobbyUI;
using UnityEngine;
using MonoMod.Cil;
using Mono.Cecil.Cil;
using Mono.Cecil;
using UnityEngine.UI;

namespace AbyssalLobby.Modules
{
    class LobbyImprovments
    {
        public void LobbyUI(On.RoR2.UI.RuleCategoryController.orig_SetData orig, RoR2.UI.RuleCategoryController self, RuleCategoryDef categoryDef, RuleChoiceMask availability, RuleBook ruleBook)
        {
            orig(self, categoryDef, availability, ruleBook);

        }
    }
}
