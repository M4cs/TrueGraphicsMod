using UnityEngine;
using BepInEx;
using HarmonyLib;
using System.Reflection;
using GameOverlay;

namespace TrueGraphicsMod
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    [BepInProcess("Drift Racing Online.exe")]
    public class Main : BaseUnityPlugin
    {
        public const string pluginGuid = "com.maxbridgland.TrueGraphicsMod";
        public const string pluginName = "TrueGraphicsMod";
        public const string pluginVersion = "1.0.0";
        public static Harmony harmony;
        public static TGG modInstance;

        public void Awake()
        {
            Main.modInstance = new GameObject().AddComponent<TGG>();
            GameObject.DontDestroyOnLoad(Main.modInstance);
            harmony = new Harmony(pluginGuid);
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
