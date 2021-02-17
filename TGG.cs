using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace TrueGraphicsMod
{
    public class TGG : MonoBehaviour
    {
        Rect TGGRect;
        private static bool shouldDisplayMenu;
        public static bool enableChromeAb;
        public static float chromaticAbIntensity;
        public static bool enableMotionBlur;
        public static float motionBlurIntensity;
        public static float motionBlurSamples;
        public static bool enableFilmGrain;
        public static float filmGrainIntensity;
        public static float filmGrainResponsiveness;
        public static bool enableVignette;
        public static float vignetteIntensity;
        public static bool vignetteIsRounded;
        public static float vignetteRoundness;
        public static bool enableLensDistortion;
        public static float ldIntensity;
        public static float ldScale;
        public static float ldX;
        public static float ldY;
        public static bool enableBloom;
        public static float bloomIntensity;
        public static bool highQualityBloom;
        public static float bloomScatter;
        public static bool anamorphicBloom;
        public static int bloomType;
        public static bool isDay;
        public static bool colorAdjEnabled;
        public static float caContrast;
        public static float caHue;
        public static float caSaturation;
        public static float caExposure;
        public static bool enableDOF;
        public static float dofFarFocusEnd;
        public static float dofFarFocusStart;
        public static float dofFocusDistance;
        public static float dofFarMaxBlur;
        public static int dofFarSampleCount;
        public static bool dofHighQualityFiltering;
        public static float dofNearMaxBlur;
        public static int dofNearSampleCount;
        public static int dofResolution;
        public static float dofNearFocusEnd;
        public static float dofNearFocusStart;
        public void Start()
        {
            isDay = true;
            shouldDisplayMenu = false;
            if (PlayerPrefs.HasKey("tgm_chromeAb_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_chromeAb_enabled") == 0)
                {
                    enableChromeAb = false;
                }
                else
                {
                    enableChromeAb = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_chromeAb_intensity", 0);
                enableChromeAb = false;
            }
            if (PlayerPrefs.HasKey("tgm_chromeAb_intensity"))
            {
                chromaticAbIntensity = PlayerPrefs.GetFloat("tgm_chromeAb_intensity");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_chromeAb_intensity", 0);
                chromaticAbIntensity = 0;
            }
            if (PlayerPrefs.HasKey("tgm_motionBlur_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_motionBlur_enabled") == 0)
                {
                    enableMotionBlur = false;
                }
                else
                {
                    enableMotionBlur = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_motionBlur_enabled", 0);
                enableMotionBlur = false;
            }
            if (PlayerPrefs.HasKey("tgm_motionBlur_intensity"))
            {
                motionBlurIntensity = PlayerPrefs.GetFloat("tgm_motionBlur_intensity");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_motionBlur_intensity", 0);
                motionBlurIntensity = 0;
            }
            if (PlayerPrefs.HasKey("tgm_motionBlur_samples"))
            {
                motionBlurSamples = PlayerPrefs.GetFloat("tgm_motionBlur_samples");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_motionBlur_samples", 10);
                motionBlurSamples = 10;
            }
            if (PlayerPrefs.HasKey("tgm_filmGrain_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_filmGrain_enabled") == 0)
                {
                    enableFilmGrain = false;
                }
                else
                {
                    enableFilmGrain = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_filmGrain_enabled", 0);
                enableFilmGrain = false;
            }
            if (PlayerPrefs.HasKey("tgm_filmGrain_intensity"))
            {
                filmGrainIntensity = PlayerPrefs.GetFloat("tgm_filmGrain_intensity");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_filmGrain_intensity", 0);
                filmGrainIntensity = 0;
            }
            if (PlayerPrefs.HasKey("tgm_filmGrain_responsiveness"))
            {
                filmGrainResponsiveness = PlayerPrefs.GetFloat("tgm_filmGrain_responsiveness");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_filmGrain_responsiveness", 0);
                filmGrainResponsiveness = 0;
            }
            if (PlayerPrefs.HasKey("tgm_vignette_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_vignette_enabled") == 0)
                {
                    enableVignette = false;
                }
                else
                {
                    enableVignette = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_vignette_enabled", 0);
                enableVignette = false;
            }
            if (PlayerPrefs.HasKey("tgm_vignetteR_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_vignetteR_enabled") == 0)
                {
                    vignetteIsRounded = false;
                }
                else
                {
                    vignetteIsRounded = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_vignetteR_enabled", 0);
                vignetteIsRounded = false;
            }
            if (PlayerPrefs.HasKey("tgm_vignette_intensity"))
            {
                vignetteIntensity = PlayerPrefs.GetFloat("tgm_vignette_intensity");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_vignette_intensity", 0);
                vignetteIntensity = 0;
            }
            if (PlayerPrefs.HasKey("tgm_vignette_roundness"))
            {
                vignetteRoundness = PlayerPrefs.GetFloat("tgm_vignette_roundness");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_vignette_roundness", 0);
                vignetteRoundness = 0;
            }
            if (PlayerPrefs.HasKey("tgm_lensDistortion_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_lensDistortion_enabled") == 0)
                {
                    enableLensDistortion = false;
                }
                else
                {
                    enableLensDistortion = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_lensDistortion_enabled", 0);
                enableLensDistortion = false;
            }
            if (PlayerPrefs.HasKey("tgm_lensDistortion_intensity"))
            {
                ldIntensity = PlayerPrefs.GetFloat("tgm_lensDistortion_intensity");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_lensDistortion_intensity", 0);
                ldIntensity = 0;
            }
            if (PlayerPrefs.HasKey("tgm_lensDistortion_scale"))
            {
                ldScale = PlayerPrefs.GetFloat("tgm_lensDistortion_scale");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_lensDistortion_scale", 0);
                ldScale = 0;
            }
            if (PlayerPrefs.HasKey("tgm_lensDistortion_x"))
            {
                ldX = PlayerPrefs.GetFloat("tgm_lensDistortion_x");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_lensDistortion_x", 0);
                ldX = 1;
            }
            if (PlayerPrefs.HasKey("tgm_lensDistortion_y"))
            {
                ldY = PlayerPrefs.GetFloat("tgm_lensDistortion_y");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_lensDistortion_y", 0);
                ldY = 1;
            }
            if (PlayerPrefs.HasKey("tgm_bloom_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_bloom_enabled") == 0)
                {
                    enableBloom = false;
                }
                else
                {
                    enableBloom = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_bloom_enabled", 0);
                enableBloom = false;
            }
            if (PlayerPrefs.HasKey("tgm_hqbloom_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_hqbloom_enabled") == 0)
                {
                    highQualityBloom = false;
                }
                else
                {
                    highQualityBloom = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_hqbloom_enabled", 0);
                highQualityBloom = false;
            }
            if (PlayerPrefs.HasKey("tgm_anabloom_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_anabloom_enabled") == 0)
                {
                    anamorphicBloom = false;
                }
                else
                {
                    anamorphicBloom = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_anabloom_enabled", 0);
                anamorphicBloom = false;
            }
            if (PlayerPrefs.HasKey("tgm_bloom_intensity"))
            {
                bloomIntensity = PlayerPrefs.GetFloat("tgm_bloom_intensity");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_bloom_intensity", 0);
                bloomIntensity = 0;
            }
            if (PlayerPrefs.HasKey("tgm_bloom_scatter"))
            {
                bloomScatter = PlayerPrefs.GetFloat("tgm_bloom_scatter");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_bloom_scatter", 0);
                bloomScatter = 0;
            }
            if (PlayerPrefs.HasKey("tgm_bloom_type"))
            {
                bloomType = PlayerPrefs.GetInt("tgm_bloom_type");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_bloom_type", 0);
                bloomType = 0;
            }
            if (PlayerPrefs.HasKey("tgm_colorAdj_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_colorAdj_enabled") == 0)
                {
                    colorAdjEnabled = false;
                }
                else
                {
                    colorAdjEnabled = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_colorAdj_enabled", 0);
                colorAdjEnabled = false;
            }
            if (PlayerPrefs.HasKey("tgm_colorAdj_contrast"))
            {
                caContrast = PlayerPrefs.GetFloat("tgm_colorAdj_contrast");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_colorAdj_contrast", 0);
                caContrast = 0;
            }
            if (PlayerPrefs.HasKey("tgm_colorAdj_hue"))
            {
                caHue = PlayerPrefs.GetFloat("tgm_colorAdj_hue");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_colorAdj_hue", 0);
                caHue = 0;
            }
            if (PlayerPrefs.HasKey("tgm_colorAdj_saturation"))
            {
                caSaturation = PlayerPrefs.GetFloat("tgm_colorAdj_saturation");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_colorAdj_saturation", 0);
                caSaturation = 0;
            }
            if (PlayerPrefs.HasKey("tgm_colorAdj_exposure"))
            {
                caExposure = PlayerPrefs.GetFloat("tgm_colorAdj_exposure");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_colorAdj_exposure", 0);
                caExposure = 0;
            }
            if (PlayerPrefs.HasKey("tgm_dof_enabled"))
            {
                if (PlayerPrefs.GetInt("tgm_dof_enabled") == 0)
                {
                    enableDOF = false;
                }
                else
                {
                    enableDOF = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_dof_enabled", 0);
                enableDOF = false;
            }
            if (PlayerPrefs.HasKey("tgm_dof_hqf"))
            {
                if (PlayerPrefs.GetInt("tgm_dof_hqf") == 0)
                {
                    dofHighQualityFiltering = false;
                }
                else
                {
                    dofHighQualityFiltering = true;
                }
            }
            else
            {
                PlayerPrefs.SetInt("tgm_dof_hqf", 0);
                dofHighQualityFiltering = false;
            }
            if (PlayerPrefs.HasKey("tgm_dof_nearfocusstart"))
            {
                dofNearFocusStart = PlayerPrefs.GetFloat("tgm_dof_nearfocusstart");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_dof_nearfocusstart", 0);
                dofNearFocusStart = 0;
            }
            if (PlayerPrefs.HasKey("tgm_dof_farfocusstart"))
            {
                dofFarFocusStart = PlayerPrefs.GetFloat("tgm_dof_farfocusstart");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_dof_farfocusstart", 10);
                dofFarFocusStart = 10;
            }
            if (PlayerPrefs.HasKey("tgm_dof_nearfocusend"))
            {
                dofNearFocusEnd = PlayerPrefs.GetFloat("tgm_dof_nearfocusend");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_dof_nearfocusend", 4);
                dofNearFocusEnd = 4;
            }
            if (PlayerPrefs.HasKey("tgm_dof_farfocusend"))
            {
                dofFarFocusEnd = PlayerPrefs.GetFloat("tgm_dof_farfocusend");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_dof_farfocusend", 20);
                dofFarFocusEnd = 20;
            }
            if (PlayerPrefs.HasKey("tgm_dof_focusdistance"))
            {
                dofFocusDistance = PlayerPrefs.GetFloat("tgm_dof_focusdistance");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_dof_focusdistance", 10);
                dofFocusDistance = 10;
            }
            if (PlayerPrefs.HasKey("tgm_dof_nearsamplecount"))
            {
                dofNearSampleCount = PlayerPrefs.GetInt("tgm_dof_nearsamplecount");
            }
            else
            {
                PlayerPrefs.SetInt("tgm_dof_nearsamplecount", 5);
                dofNearSampleCount = 5;
            }
            if (PlayerPrefs.HasKey("tgm_dof_farsamplecount"))
            {
                dofFarSampleCount = PlayerPrefs.GetInt("tgm_dof_farsamplecount");
            }
            else
            {
                PlayerPrefs.SetFloat("tgm_dof_farsamplecount", 7);
                dofFarSampleCount = 7;
            }
            if (PlayerPrefs.HasKey("tgm_dof_resolution"))
            {
                dofResolution = PlayerPrefs.GetInt("tgm_dof_resolution");
            }
            else
            {
                PlayerPrefs.SetInt("tgm_dof_resolution", 1);
                dofResolution = 1;
            }
            PlayerPrefs.Save();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.F10))
            {
                shouldDisplayMenu = !shouldDisplayMenu;
            }
        }

        public void OnGUI()
        {
            if (shouldDisplayMenu)
            {
                int windowWidth = 500;
                int windowHeight = Screen.height - 50;
                GUI.backgroundColor = Color.black;
                TGGRect = GUI.Window(43244, new Rect((Screen.width / 2) - windowWidth / 2, 25, windowWidth, windowHeight), TGGMenuWindow, "TrueGraphicsMod");
            }
        }

        private void TGGMenuWindow(int windowId)
        {
            GamePrefs gamePrefs = DI.DependencyInjector.Resolve<GamePrefs>();
            var disabledText = new GUIStyle(GUI.skin.button);
            disabledText.normal.textColor = Color.red;
            var enabledText = new GUIStyle(GUI.skin.button);
            enabledText.normal.textColor = Color.green;
            var warmText = new GUIStyle(GUI.skin.button);
            warmText.normal.textColor = Color.red;
            var coldText = new GUIStyle(GUI.skin.button);
            coldText.normal.textColor = Color.blue;
            var normalText = new GUIStyle(GUI.skin.button);
            normalText.normal.textColor = Color.white;
            var titleText = new GUIStyle(GUI.skin.label);
            titleText.fontStyle = FontStyle.Bold;
            titleText.alignment = TextAnchor.MiddleCenter;
            GUI.backgroundColor = Color.white;
            if (GUILayout.Button("Chromatic Aberration", enableChromeAb ? enabledText : disabledText))
            {
                enableChromeAb = !enableChromeAb;
                if (enableChromeAb)
                {
                    PlayerPrefs.SetInt("tgm_chromeAb_enabled", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("tgm_chromeAb_enabled", 0);
                }
                PlayerPrefs.Save();
            }
            if (enableChromeAb)
            {
                GUILayout.Label("Chromatic Aberration Intensity: " + chromaticAbIntensity.ToString());
                chromaticAbIntensity = GUILayout.HorizontalSlider(chromaticAbIntensity, 0f, 2f);
                PlayerPrefs.SetFloat("tgm_chromeAb_intensity", chromaticAbIntensity);
            }
            if (GUILayout.Button("Motion Blur", enableMotionBlur ? enabledText : disabledText))
            {
                enableMotionBlur = !enableMotionBlur;
                if (enableMotionBlur)
                {
                    PlayerPrefs.SetInt("tgm_motionBlur_enabled", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("tgm_motionBlur_enabled", 0);
                }
                PlayerPrefs.Save();
            }
            if (enableMotionBlur)
            {
                GUILayout.Label("Motion Blur Intensity: " + motionBlurIntensity.ToString());
                motionBlurIntensity = GUILayout.HorizontalSlider(motionBlurIntensity, 0f, 10f);
                PlayerPrefs.SetFloat("tgm_motionBlur_intensity", motionBlurIntensity);
                GUILayout.Label("Motion Blur Samples: " + motionBlurSamples.ToString());
                motionBlurSamples = GUILayout.HorizontalSlider(motionBlurSamples, 2f, 20f);
                PlayerPrefs.SetFloat("tgm_motionBlur_samples", motionBlurSamples);
            }
            if (GUILayout.Button("Film Grain", enableFilmGrain ? enabledText : disabledText))
            {
                enableFilmGrain = !enableFilmGrain;
                if (enableFilmGrain)
                {
                    PlayerPrefs.SetInt("tgm_chromeAb_enabled", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("tgm_chromeAb_enabled", 0);
                }
                PlayerPrefs.Save();
            }
            if (enableFilmGrain)
            {
                GUILayout.Label("Film Grain Intensity: " + filmGrainIntensity.ToString());
                filmGrainIntensity = GUILayout.HorizontalSlider(filmGrainIntensity, 0f, 2f);
                PlayerPrefs.SetFloat("tgm_filmGrain_intensity", filmGrainIntensity);
                GUILayout.Label("Film Grain Responsiveness: " + filmGrainResponsiveness.ToString());
                filmGrainResponsiveness = GUILayout.HorizontalSlider(filmGrainResponsiveness, 0f, 2f);
                PlayerPrefs.SetFloat("tgm_filmGrain_responsiveness", filmGrainResponsiveness);
            }
            if (GUILayout.Button("Vignette", enableVignette ? enabledText : disabledText))
            {
                enableVignette = !enableVignette;
                if (enableVignette)
                {
                    PlayerPrefs.SetInt("tgm_vignette_enabled", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("tgm_vignette_enabled", 0);
                }
                PlayerPrefs.Save();
            }
            if (enableVignette)
            {
                GUILayout.Label("Vignette Intensity: " + vignetteIntensity.ToString());
                vignetteIntensity = GUILayout.HorizontalSlider(vignetteIntensity, -1f, 1f);
                PlayerPrefs.SetFloat("tgm_vignette_intensity", vignetteIntensity);
                if (GUILayout.Button("Vignette Rounded", vignetteIsRounded ? enabledText : disabledText))
                {
                    vignetteIsRounded = !vignetteIsRounded;
                    PlayerPrefs.SetInt("tgm_vignetteR_enabled", vignetteIsRounded ? 1 : 0);
                    PlayerPrefs.Save();
                }
                if (vignetteIsRounded)
                {
                    GUILayout.Label("Vignette Roundness: " + vignetteRoundness.ToString());
                    vignetteRoundness = GUILayout.HorizontalSlider(vignetteRoundness, 0f, 1f);
                    PlayerPrefs.SetFloat("tgm_vignette_roundness", vignetteRoundness);
                }
            }
            if (GUILayout.Button("Lens Distortion", enableLensDistortion ? enabledText : disabledText))
            {
                enableLensDistortion = !enableLensDistortion;
                if (enableLensDistortion)
                {
                    PlayerPrefs.SetInt("tgm_lensDistortion_enabled", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("tgm_lensDistortion_enabled", 0);
                }
                PlayerPrefs.Save();
            }
            if (enableLensDistortion)
            {
                GUILayout.Label("Lens Distortion Settings:", titleText);
                GUILayout.Label("Intensity: " + ldIntensity.ToString());
                ldIntensity = GUILayout.HorizontalSlider(ldIntensity, -1f, 1f);
                PlayerPrefs.SetFloat("tgm_lensDistortion_intensity", ldIntensity);
                GUILayout.Label("Scale: " + ldScale.ToString());
                ldScale = GUILayout.HorizontalSlider(ldScale, 0.01f, 5f);
                PlayerPrefs.SetFloat("tgm_lensDistortion_scale", ldScale);
                GUILayout.Label("X Multiplier: " + ldX.ToString());
                ldX = GUILayout.HorizontalSlider(ldX, 0f, 1f);
                PlayerPrefs.SetFloat("tgm_lensDistortion_x", ldX);
                GUILayout.Label("Y Multiplier: " + ldY.ToString());
                ldY = GUILayout.HorizontalSlider(ldY, 0f, 1f);
                PlayerPrefs.SetFloat("tgm_lensDistortion_y", ldY);
            }
            if (GUILayout.Button("Bloom", enableBloom ? enabledText : disabledText))
            {
                enableBloom = !enableBloom;
                PlayerPrefs.SetInt("tgm_bloom_enabled", enableBloom ? 1 : 0);
                PlayerPrefs.Save();
            }
            if (enableBloom)
            {
                GUILayout.Label("Bloom Settings:", titleText);
                if (GUILayout.Button("High Quality Bloom", highQualityBloom ? enabledText : disabledText))
                {
                    highQualityBloom = !highQualityBloom;
                    PlayerPrefs.SetInt("tgm_hqbloom_enabled", highQualityBloom ? 1 : 0);
                }
                if (GUILayout.Button("Anamorphic Bloom", anamorphicBloom ? enabledText : disabledText))
                {
                    anamorphicBloom = !anamorphicBloom;
                    PlayerPrefs.SetInt("tgm_anabloom_enabled", anamorphicBloom ? 1 : 0);
                }
                GUILayout.Label("Bloom Intensity: " + bloomIntensity.ToString());
                bloomIntensity = GUILayout.HorizontalSlider(bloomIntensity, 0f, 1f);
                PlayerPrefs.SetFloat("tgm_bloom_intensity", bloomIntensity);
                GUILayout.Label("Bloom Scatter: " + bloomScatter.ToString());
                bloomScatter = GUILayout.HorizontalSlider(bloomScatter, 0f, 1f);
                PlayerPrefs.SetFloat("tgm_bloom_scatter", bloomScatter);
                GUILayout.Label("Bloom Style:");
                string typeText;
                GUIStyle typeStyle;
                switch (bloomType)
                {
                    case 0:
                        typeText = "Normal Bloom";
                        typeStyle = normalText;
                        break;
                    case 1:
                        typeText = "Cool Bloom";
                        typeStyle = coldText;
                        break;
                    case 2:
                        typeText = "Warm Bloom";
                        typeStyle = warmText;
                        break;
                    default:
                        typeText = "Normal Bloom";
                        typeStyle = normalText;
                        break;
                }
                if (GUILayout.Button(typeText, typeStyle))
                {
                    if (bloomType == 2)
                    {
                        bloomType = 0;
                    } else
                    {
                        bloomType += 1;
                    }
                }
            }
            if (GUILayout.Button("Color Adjustments", colorAdjEnabled ? enabledText : disabledText))
            {
                colorAdjEnabled = !colorAdjEnabled;
                PlayerPrefs.SetInt("tgm_colorAdj_enabled", colorAdjEnabled ? 1 : 0);
                PlayerPrefs.Save();
            }
            /*if (colorAdjEnabled)
            {
                GUILayout.Label("Saturation: " + caSaturation.ToString());
                caSaturation = GUILayout.HorizontalSlider(caSaturation, -100f, 100f);
                PlayerPrefs.SetFloat("tgm_colorAdj_saturation", caSaturation);
                GUILayout.Label("Contrast: " + caContrast.ToString());
                caContrast = GUILayout.HorizontalSlider(caContrast, -100f, 100f);
                PlayerPrefs.SetFloat("tgm_colorAdj_contrast", caContrast);
                GUILayout.Label("Exposure: " + caExposure.ToString());
                caExposure = GUILayout.HorizontalSlider(caExposure, 0f, 100f);
                PlayerPrefs.SetFloat("tgm_colorAdj_exposure", caExposure);
                GUILayout.Label("Hue Shift: " + caHue.ToString());
                caHue = GUILayout.HorizontalSlider(caHue, -180f, 180f);
                PlayerPrefs.SetFloat("tgm_colorAdj_hue", caHue);
            }*/
            /*if (GUILayout.Button("Depth of Field", enableDOF ? enabledText : disabledText))
            {
                enableDOF = !enableDOF;
                PlayerPrefs.SetInt("tgm_dof_enable", enableDOF ? 1 : 0);
                PlayerPrefs.Save();
            }
            if (enableDOF)
            {
                if (GUILayout.Button("High Quality DoF", dofHighQualityFiltering ? enabledText : disabledText))
                {
                    dofHighQualityFiltering = !dofHighQualityFiltering;
                    PlayerPrefs.SetInt("tgm_dof_hqf", dofHighQualityFiltering ? 1 : 0);
                    PlayerPrefs.Save();
                }
                GUILayout.Label("Near Focus Start: " + dofNearFocusStart.ToString());
                dofNearFocusStart = GUILayout.HorizontalSlider(dofNearFocusStart, 0f, 10000f);
                PlayerPrefs.SetFloat("tgm_dof_nearfocusstart", dofNearFocusStart);
                GUILayout.Label("Near Focus End: " + dofNearFocusEnd.ToString());
                dofNearFocusEnd = GUILayout.HorizontalSlider(dofNearFocusEnd, 0f, 10000f);
                PlayerPrefs.SetFloat("tgm_dof_nearfocusend", dofNearFocusEnd);
                GUILayout.Label("Near Sample Count: " + dofNearSampleCount.ToString());
                dofNearSampleCount = (int)GUILayout.HorizontalSlider(dofNearSampleCount, 3, 16);
                PlayerPrefs.SetInt("tgm_dof_nearsamplecount", dofNearSampleCount);
                GUILayout.Label("Near Max Blur: " + dofNearMaxBlur.ToString());
                dofNearMaxBlur = GUILayout.HorizontalSlider(dofNearMaxBlur, 0f, 16f);
                PlayerPrefs.SetFloat("tgm_dof_nearmaxblur", dofNearMaxBlur);
                GUILayout.Label("Far Focus Start: " + dofFarFocusStart.ToString());
                dofFarFocusStart = GUILayout.HorizontalSlider(dofFarFocusStart, 0f, 10000f);
                PlayerPrefs.SetFloat("tgm_dof_farfocusstart", dofFarFocusStart);
                GUILayout.Label("Far Focus End: " + dofFarFocusEnd.ToString());
                dofFarFocusEnd = GUILayout.HorizontalSlider(dofFarFocusEnd, 0f, 10000f);
                PlayerPrefs.SetFloat("tgm_dof_farfocusend", caSaturation);
                GUILayout.Label("Far Sample Count: " + dofFarSampleCount.ToString());
                dofFarSampleCount = (int)GUILayout.HorizontalSlider(dofFarSampleCount, 3, 16);
                PlayerPrefs.SetInt("tgm_dof_farsamplecount", dofFarSampleCount);
                GUILayout.Label("Far Max Blur: " + dofFarMaxBlur.ToString());
                dofFarMaxBlur = GUILayout.HorizontalSlider(dofFarMaxBlur, 0f, 16f);
                PlayerPrefs.SetFloat("tgm_dof_farmaxblur", dofFarMaxBlur);
                GUILayout.Label("Focus Distance: " + dofFocusDistance.ToString());
                dofFocusDistance = GUILayout.HorizontalSlider(dofFocusDistance, 0f, 100f);
                PlayerPrefs.SetFloat("tgm_dof_focusdistance", dofFocusDistance);
                string dofResText;
                switch (dofResolution)
                {
                    case 0:
                        dofResText = "DoF Resolution: Quarter";
                        break;
                    case 1:
                        dofResText = "DoF Resolution: Half";
                        break;
                    case 2:
                        dofResText = "DoF Resolution: Full";
                        break;
                    default:
                        dofResText = "DoF Resolution: Quarter";
                        break;
                }
                if (GUILayout.Button(dofResText, normalText))
                {
                    if (dofResolution == 2)
                    {
                        dofResolution = 0;
                    } else
                    {
                        dofResolution += 1;
                    }
                    PlayerPrefs.SetInt("tgm_dof_resolution", dofResolution);
                    PlayerPrefs.Save();
                }
            }*/
            
            if (GUILayout.Button(isDay ? "Set Night Mode" : "Set Day Mode", normalText))
            {
                isDay = !isDay;
                FindObjectOfType<DayNightController>().SetDayNightMode(isDay);
            }
            if (GUILayout.Button("Save", enabledText))
            {
                PlayerPrefs.Save();
            }
            if (GUILayout.Button("Support The Creator", enabledText)){
                System.Diagnostics.Process.Start("https://paypal.me/maxbridgland");
            }
            GUILayout.Label("Created by Max Bridgland\nDiscord: macs#0420\nTwitter: @maxbridgland");
        }
    }
}
