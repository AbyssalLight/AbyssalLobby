using BepInEx;
using MonoMod.Cil;

namespace AbyssalLobby.Modules
{
    [BepInDependency("com.bepis.r2api")]

    [BepInPlugin("com.AbyssalLight.AbyssalLobby", "AbyssalLobby", "2.0.0")]

    class AbyssalLobbyPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            RuleCatalogEdits ruleCatalogEdits = new RuleCatalogEdits();
            LobbyImprovments lobbyImprovments = new LobbyImprovments();

            AbyssalTokens.AddTokens();
            On.RoR2.RuleDef.AddChoice += ruleCatalogEdits.RuleDefAddChoice;
            On.RoR2.RuleCatalog.HiddenTestItemsConvar += RuleCatalogEdits.RuleCatalogHiddenTestItemsConvar;
            On.RoR2.RuleCatalog.HiddenTestTrue += RuleCatalogEdits.RuleCatalogHiddenTestTrue;
            On.RoR2.RuleCatalog.Init += RuleCatalogEdits.RuleCatalogInit;

            //IL.RoR2.UI.RuleCategoryController.SetData += new ILContext.Manipulator(lobbyImprovments.LobbyUI);

        }
    }
}
