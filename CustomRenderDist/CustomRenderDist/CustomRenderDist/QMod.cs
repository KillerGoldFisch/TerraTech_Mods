using GCore.Logging;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CustomRenderDist
{
    public class QMod
    {
        public static void main()
        {
            try {
                HarmonyInstance.Create("net.killergodfisch.CustomRenderDist").PatchAll(Assembly.GetExecutingAssembly());
            } catch (Exception ex) {
                Log.Error("Error while loading CustomRenderDist, see logs fpr further informations!");
                throw ex;
            }

            Log.Info("CustomRenderDist Loaded");
        }
    }
}
