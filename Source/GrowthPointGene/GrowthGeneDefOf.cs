using RimWorld;
using Verse;

namespace GrowthPointGene
{
    [DefOf]
    public static class GrowthGeneDefOf
    {
        static GrowthGeneDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(GrowthGeneDefOf));
            Log.Message("DefOfHelper OK");
        }
        public static GeneDef Gene_Growth;
        public static StatDef GrowthPointsFactor;
    }
}
