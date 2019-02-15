using UnityEngine;
using ToolbarControl_NS;

namespace LightsOut
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class RegisterToolbar : MonoBehaviour
    {
        void Start()
        {
            ToolbarControl.RegisterMod(LightsOut.MODID, LightsOut.MODNAME);
        }
    }
}