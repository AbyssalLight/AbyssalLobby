using AbyssalLobby.Modules;
using BepInEx;
using RoR2.UI;
using R2API.Utils;
using System.Security;
using System.Security.Permissions;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace AbyssalLobby
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.KingEnderBrine.ScrollableLobbyUI")]
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

            AbyssalTokens.AddTokens();
            On.RoR2.RuleCatalog.Init += delegate(On.RoR2.RuleCatalog.orig_Init orig)
            {
                orig();
                RuleCatalogEdits.RuleCatalogInit();
            };
        }
    }
}
