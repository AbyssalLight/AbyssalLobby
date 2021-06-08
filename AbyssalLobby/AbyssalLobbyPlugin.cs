using AbyssalLobby.Modules;
using BepInEx;
using MonoMod.Cil;
using R2API.Utils;
using System.Security;
using System.Security.Permissions;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace AbyssalLobby
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.KingEnderBrine.ScrollableLobbyUI")]
    [BepInIncompatibility("")]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    [R2APISubmoduleDependency(new string[]
    {
         "LanguageAPI",
    })]

    class AbyssalLobbyPlugin : BaseUnityPlugin
    {
        public const string MODUID = "com.AbyssalLight.AbyssalLobby";
        public const string MODNAME = "AbyssalLobby";
        public const string MODVERSION = "2.3.0";

        public const string developerPrefix = "ABYSS";

        public static AbyssalLobbyPlugin instance;

        public void Awake()
        {
            instance = this;

            RuleCatalogEdits ruleCatalogEdits = new RuleCatalogEdits();
            LobbyImprovments lobbyImprovments = new LobbyImprovments();

            AbyssalTokens.AddTokens();
            On.RoR2.RuleDef.AddChoice += ruleCatalogEdits.RuleDefAddChoice;
            On.RoR2.RuleCatalog.HiddenTestItemsConvar += RuleCatalogEdits.RuleCatalogHiddenTestItemsConvar;
            On.RoR2.RuleCatalog.HiddenTestTrue += RuleCatalogEdits.RuleCatalogHiddenTestTrue;
            On.RoR2.RuleCatalog.Init += RuleCatalogEdits.RuleCatalogInit;
            On.RoR2.RuleDef.FromItem += RuleCatalogEdits.ItemDescriptions;
            On.RoR2.RuleDef.FromEquipment += RuleCatalogEdits.EquipmentDescriptions;

            On.RoR2.UI.RuleCategoryController.SetData += lobbyImprovments.LobbyUI;

        }
    }
}
