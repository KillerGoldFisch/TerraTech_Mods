using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaLootBoxes
{
    [HarmonyPatch(typeof(BlockRewardPoolTable))]
    [HarmonyPatch("GetRewardBlocks")]
    internal class Patch_BlockRewardPoolTable_GetRewardBlocks
    {
        static void Postfix(ref BlockTypes[]  __result)
        {
            __result = Enum.GetValues(typeof(BlockTypes)).Cast<BlockTypes>().ToArray();
        }
    }

    [HarmonyPatch(typeof(EncounterDetails))]
    [HarmonyPatch("AmountToAwardFromPool", PropertyMethod.Getter)]
    internal class Patch_EncounterDetails_AmountToAwardFromPool
    {
        static void Postfix(ref int __result)
        {
            __result = Enum.GetValues(typeof(BlockTypes)).Length;
        }
    }
}
