using JetBrains.Annotations;
using RimWorld.QuestGen;
using System;
using UnityEngine;
using Verse;

namespace LDB
{
    internal class LDB_Settings : ModSettings
    {
        public static float BeggarRequestValueFactor = 0.85f;

        public static float MaxRequestValue = 700f;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref BeggarRequestValueFactor, "BeggarRequestValueFactor");
            Scribe_Values.Look(ref MaxRequestValue, "MaxRequestValue");
        }

        public void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();

            listingStandard.Begin(inRect);

            BeggarRequestValueFactor = (float)Math.Round(listingStandard.SliderLabeled("LDB.BeggarRequestValueFactor".Translate() + "(" + BeggarRequestValueFactor.ToString() + ")", BeggarRequestValueFactor, 0.01f, 1.7f), 2);

            listingStandard.Label(" ");

            MaxRequestValue = (float)Math.Round(listingStandard.SliderLabeled("LDB.MaxRequestValue".Translate() + "(" + MaxRequestValue.ToString() + ")", MaxRequestValue, 300f, 1400f), 0);

            listingStandard.Label(" ");

            if (Widgets.ButtonText(new Rect(0f, listingStandard.CurHeight, 150f, 30f), "reset", true, true, true))
            {
                BeggarRequestValueFactor = 0.85f;
                MaxRequestValue = 700f;
            }


            listingStandard.End();
        }
    }
}
