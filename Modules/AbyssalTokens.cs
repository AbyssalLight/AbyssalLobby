using System;
using System.Collections.Generic;
using System.Text;
using R2API;

namespace AbyssalItemVotes.Modules
{
    internal static class AbyssalTokens
    {
        internal static void AddTokens()
        {


            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER1", "Common Items");
            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER1_SUBTITLE", "Vote on Common Items 'Default: Enabled'");

            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER2", "Epic Items");
            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER2_SUBTITLE", "Vote on Epic Items 'Default: Enabled'");

            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER3", "Legendary Items");
            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER3_SUBTITLE", "Vote on Legendary Items 'Default: Enabled'");

            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER_LUNAR", "Lunar Items");
            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER_LUNAR_SUBTITLE", "Vote on Lunar Items 'Default: Enabled'");

            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER_BOSS", "Boss Items");
            LanguageAPI.Add("RULE_HEADER_ITEMS_TIER_BOSS_SUBTITLE", "Vote on Boss Items 'Default: Enabled'");
        }
    }
}
