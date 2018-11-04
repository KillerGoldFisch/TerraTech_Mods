using GCore.Logging;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MegaLootBoxes
{
    public class QMod
    {
        public static void main()
        {
            try {
                HarmonyInstance.Create("net.killergodfisch.MegaLootBoxes").PatchAll(Assembly.GetExecutingAssembly());
            }catch(Exception ex) {
                Log.Error("Error while loading MegaLootBoxes, see logs fpr further informations!");
                throw ex;
            }

            Log.Info("MegaLootBoxes Loaded");
        }
    }
}
