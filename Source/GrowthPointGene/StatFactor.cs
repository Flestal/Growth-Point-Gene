using RimWorld;
using Verse;
using HarmonyLib;

namespace GrowthPointGene
{
    public static class Pawn_AgeTracker_Patch
    {
        internal static void Patch(Harmony harmony)
        {
            harmony.Patch
                (
                original: AccessTools.PropertyGetter(typeof(Pawn_AgeTracker), "GrowthPointsFactor"),
                postfix: new HarmonyMethod(typeof(Pawn_AgeTracker_Patch), nameof(Postfix))
                );
        }
        static void Postfix(ref float __result, Pawn ___pawn)
        {
            __result *= ___pawn.GetStatValue(GrowthGeneDefOf.GrowthPointsFactor);
        }
    }
}
