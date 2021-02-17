using HarmonyLib;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using PrefsModels;

namespace TrueGraphicsMod.Patches
{
    [HarmonyPatch(typeof(ChromaticAberration), "IsActive")]

    class StopChromeAb
    {
        static bool Prefix(ChromaticAberration __instance)
        {
            __instance.intensity = new ClampedFloatParameter(TGG.chromaticAbIntensity, 0f, 1f, true);
            return TGG.enableChromeAb;
        }
    }

    [HarmonyPatch(typeof(MotionBlur), "IsActive")]
    class StopBlur
    {
        static bool Prefix(MotionBlur __instance)
        {
            __instance.sampleCount = (int)TGG.motionBlurSamples;
            __instance.intensity = new MinFloatParameter(TGG.motionBlurIntensity, 0f, true);
            return TGG.enableMotionBlur;
        }
    }

    [HarmonyPatch(typeof(Vignette), "IsActive")]
    class StopVignette
    {
        static bool Prefix(Vignette __instance)
        {
            __instance.mode = new VignetteModeParameter(VignetteMode.Procedural, true);
            __instance.intensity = new ClampedFloatParameter(TGG.vignetteIntensity, -1f, 1f, true);
            __instance.rounded = new BoolParameter(TGG.vignetteIsRounded, true);
            __instance.roundness = new ClampedFloatParameter(TGG.vignetteRoundness, 0f, 1f, true);
            __instance.color = new ColorParameter(Color.black, false, false, true, false);
            return TGG.enableVignette;
        }
    }

    [HarmonyPatch(typeof(LensDistortion), "IsActive")]
    class LensFix
    {
        static bool Prefix(LensDistortion __instance)
        {
            __instance.intensity = new ClampedFloatParameter(TGG.ldIntensity, -1f, 1f, true);
            __instance.scale = new ClampedFloatParameter(TGG.ldScale, 0.01f, 5f, true);
            __instance.xMultiplier = new ClampedFloatParameter(TGG.ldX, 0f, 1f, true);
            __instance.yMultiplier = new ClampedFloatParameter(TGG.ldY, 0f, 1f, true);
            return TGG.enableLensDistortion;
        }
    }

    /*[HarmonyPatch(typeof(DepthOfField), "IsActive")]
    class DoFFix
    {
        static bool Prefix(DepthOfField __instance)
        {
            __instance.farFocusEnd = new MinFloatParameter(TGG.dofFarFocusEnd, 0, true);
            __instance.nearFocusEnd = new MinFloatParameter(TGG.dofNearFocusEnd, 0, true);
            __instance.farFocusStart = new MinFloatParameter(TGG.dofFarFocusStart, 0, true);
            __instance.nearFocusStart = new MinFloatParameter(TGG.dofNearFocusStart, 0, true);
            __instance.focusDistance = new MinFloatParameter(TGG.dofFocusDistance, 0, true);
            switch (TGG.dofResolution)
            {
                case 0:
                    __instance.resolution = DepthOfFieldResolution.Quarter;
                    break;
                case 1:
                    __instance.resolution = DepthOfFieldResolution.Half;
                    break;
                case 2:
                    __instance.resolution = DepthOfFieldResolution.Full;
                    break;
                default:
                    __instance.resolution = DepthOfFieldResolution.Quarter;
                    break;
            }
            __instance.farSampleCount = (int)TGG.dofFarSampleCount;
            __instance.nearSampleCount = (int)TGG.dofNearSampleCount;
            return TGG.enableDOF;
        }
    }*/

    /*[HarmonyPatch(typeof(ColorAdjustments), "IsActive")]
    class ColorAdjFix
    {
        static bool Prefix(ColorAdjustments __instance)
        {
            __instance.contrast = new ClampedFloatParameter(TGG.caContrast, -100, 100, true);
            __instance.hueShift = new ClampedFloatParameter(TGG.caHue, -180, 180, true);
            __instance.postExposure = new FloatParameter(TGG.caExposure, true);
            __instance.saturation = new ClampedFloatParameter(TGG.caSaturation, -100, 100, true);
            return TGG.colorAdjEnabled;
        }
    }*/

    [HarmonyPatch(typeof(Bloom), "IsActive")]
    class BloomFix
    {
        static bool Prefix(Bloom __instance)
        {
            __instance.intensity = new ClampedFloatParameter(TGG.bloomIntensity, -1f, 1f, true);
            __instance.anamorphic = new BoolParameter(TGG.anamorphicBloom);
            __instance.highQualityFiltering = TGG.highQualityBloom;
            switch (TGG.bloomType)
            {
                case 0:
                    __instance.tint = new ColorParameter(Color.white, false, false, true, false);
                    break;
                case 1:
                    __instance.tint = new ColorParameter(Color.blue, false, false, true, false);
                    break;
                case 2:
                    __instance.tint = new ColorParameter(Color.red, false, false, true, false);
                    break;
                default:
                    __instance.tint = new ColorParameter(Color.white, false, false, true, false);
                    break;
            }
            return TGG.enableBloom;
        }
    }
}
