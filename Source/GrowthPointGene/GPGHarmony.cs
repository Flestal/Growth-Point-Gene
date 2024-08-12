using HarmonyLib;
using System.Reflection;
using Verse;

namespace GrowthPointGene
{
    [StaticConstructorOnStartup]
    public static class GPGHarmony
    {
        static GPGHarmony()
        {
            Harmony harmony = new Harmony("Flestal.GPG");
            Pawn_AgeTracker_Patch.Patch(harmony);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
