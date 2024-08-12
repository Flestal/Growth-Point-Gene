using RimWorld;
using Verse;

namespace GrowthPointGene
{
    public class GrowthGeneSettings : ModSettings
    {
        public float factor = 1.00f;
        public override void ExposeData()
        {
            Scribe_Values.Look<float>(ref this.factor, "GrowthFactor", defaultValue: 1.00f, forceSave: true);
            base.ExposeData();
        }
    }
}
