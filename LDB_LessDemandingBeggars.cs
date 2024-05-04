using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace LDB
{
    internal class LDB_LessDemandingBeggars : Mod
    {
        private const string SETTINGS_CATEGORY_TITLE = "Less Demanding Beggars";

        public static LDB_Settings settings;

        public LDB_LessDemandingBeggars(ModContentPack content) : base(content)
        {
            LDB_LessDemandingBeggars.settings = GetSettings<LDB_Settings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            LDB_LessDemandingBeggars.settings.DoSettingsWindowContents(inRect);
            // base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return SETTINGS_CATEGORY_TITLE;
        }
    }
}
