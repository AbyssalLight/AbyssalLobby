using System;
using System.Collections.Generic;
using System.Text;
using BepInEx;
using RoR2;
using R2API;
using ScrollableLobbyUI;
using UnityEngine;
using MonoMod.Cil;
using Mono.Cecil.Cil;

namespace AbyssalLobby.Modules
{
    class LobbyImprovments
    {
        public void LobbyUI(ILContext il)
        {
            ILCursor ilcursor = new ILCursor(il);
            ILCursor ilcursor2 = ilcursor;


        }

        private void CloseGrid()
        {

        }

        private GameObject minimizeResultGrid;
    }
}
