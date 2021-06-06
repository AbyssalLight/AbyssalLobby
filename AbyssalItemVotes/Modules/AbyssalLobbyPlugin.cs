using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssalLobby.Modules
{
    [BepInDependency("com.bepis.r2api")]

    [BepInPlugin("com.AbyssalLight.AbyssalLobby", "AbyssalLobby", "2.0.0")]

    class AbyssalLobbyPlugin : BaseUnityPlugin
    {
        public void Awake()
        {
            LobbyImprovments lobbyImprovments = new LobbyImprovments();
            RuleCatalogEdits ruleCatalogEdits = new RuleCatalogEdits();

            AbyssalTokens.AddTokens();
            ruleCatalogEdits.TurnOnCatalog();
            ruleCatalogEdits.RuleCatalogInit();
            lobbyImprovments.LobbyUI();

        }
    }
}
