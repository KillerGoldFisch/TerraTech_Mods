using GCore.Logging;
using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomRenderDist
{
    [HarmonyPatch(typeof(CameraManager))]
    [HarmonyPatch("SetClipDist01")]
    internal class Patch_CameraManager_SetClipDist01
    {
        static void Prefix(CameraManager __instance, ref float clipDist01)
        {
            clipDist01 *= 5;
            Log.Info("Set clipDist to " + clipDist01);
        }

        static void Postfix(CameraManager __instance)
        {
            Log.Info("CameraManager.DrawDist = " + __instance.DrawDist);
        }
    }
}
