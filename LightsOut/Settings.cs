using System.Collections;
using System.Reflection;
using UnityEngine;

namespace LightsOut
{
    // http://forum.kerbalspaceprogram.com/index.php?/topic/147576-modders-notes-for-ksp-12/#comment-2754813
    // search for "Mod integration into Stock Settings

    // HighLogic.CurrentGame.Parameters.CustomParams<LightsOutSettings>().useKeysUP
    public class LightsOutSettings : GameParameters.CustomParameterNode
    {
        public override string Title { get { return "General"; } }
        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override string Section { get { return "Lights Out"; } }
        public override string DisplaySection { get { return "Lights Out"; } }
        public override int SectionOrder { get { return 3; } }
        public override bool HasPresets { get { return true; } }

        [GameParameters.CustomParameterUI("U and P keys active",
            toolTip = "Use the U key to toggle the vessel lights, P key to toggle the building lights")]
        public bool useKeysUandP = true;



        public override void SetDifficultyPreset(GameParameters.Preset preset)
        {
           
        }

        public override bool Enabled(MemberInfo member, GameParameters parameters)
        {

            return true;
        }

        public override bool Interactible(MemberInfo member, GameParameters parameters)
        {

            return true;
        }

        public override IList ValidValues(MemberInfo member)
        {
            return null;
        }
    }    
}
