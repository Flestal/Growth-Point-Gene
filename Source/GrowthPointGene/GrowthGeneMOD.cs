using RimWorld;
using Verse;
using UnityEngine;
using System;

namespace GrowthPointGene
{
    public class GrowthGeneMOD : Mod
    {
        private GrowthGeneSettings settings;
        public GrowthGeneMOD(ModContentPack content) : base(content)
        {
            this.settings = base.GetSettings<GrowthGeneSettings>();
            LongEventHandler.ExecuteWhenFinished(OnDefsLoaded);
        }
        private void OnDefsLoaded()
        {
            GrowthGeneDefOf.Gene_Growth.statFactors[0].value = this.settings.factor;
            Log.Message(GrowthGeneDefOf.Gene_Growth.statFactors[0].stat.defName +" : "+GrowthGeneDefOf.Gene_Growth.statFactors[0].value);
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);
            this.settings.factor = (float)Math.Round(listing_Standard.SliderLabeled
            (
                "Growth Factor : " + this.settings.factor,
                this.settings.factor,
                -1.0f,
                10.0f,
                0.3f,
                "growthfactorexplanation"
            ),2);
            base.DoSettingsWindowContents(inRect);
        }
        public override string SettingsCategory()
        {
            return "Growth Points Gene";
        }
        public override void WriteSettings()
        {
            GrowthGeneDefOf.Gene_Growth.statFactors[0].value = this.settings.factor;
            base.WriteSettings();
        }
    }
}
