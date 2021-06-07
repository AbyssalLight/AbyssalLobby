using R2API;

namespace AbyssalLobby.Modules
{
    internal class AbyssalTokens
    {
        internal static void AddTokens()
        {
            string prefix = AbyssalLobbyPlugin.developerPrefix + "_ITEMS_";

            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER1", "Common Items");
            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER1_SUBTITLE", "Vote on Common Items 'Default: Enabled'");

            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER2", "Uncommon Items");
            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER2_SUBTITLE", "Vote on Uncommon Items 'Default: Enabled'");

            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER3", "Legendary Items");
            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER3_SUBTITLE", "Vote on Legendary Items 'Default: Enabled'");

            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER_LUNAR", "Lunar Items");
            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER_LUNAR_SUBTITLE", "Vote on Lunar Items 'Default: Enabled'");

            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER_BOSS", "Boss Items");
            LanguageAPI.Add(prefix + "RULE_HEADER_ITEMS_TIER_BOSS_SUBTITLE", "Vote on Boss Items 'Default: Enabled'");

        }
    }
}
