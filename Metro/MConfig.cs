using System.Globalization;

namespace MetroTextures.Metro
{
    [Serializable]
    public struct TextureConfigSDK
    {
        public bool Draft;
        public bool MipBlur;
        public bool MipSrgb;
        public bool Animated;
        public bool Mipmapped;
        public bool Streamable;
        public bool TreatAsMetal;
        public bool UseSourceImage;
        public bool UseToksvigFactor;
        public bool OverrideAvgColor;

        public int Type;
        public int Width;
        public int Height;
        public int Format;
        public int MipMax;
        public int SWidth;  
        public int SHeight;
        public int Priority;
        public int AlphaAdj;
        public int DispType;
        public int MipFilter;
        public int SlotCount;
        public int GlossMultiplier;
        public int ParallaxHeightMul;

        public float DetScaleU;
        public float DetScaleV;
        public float BumpHeight;
        public float DispHeight;
        public float DetIntensity;
        public float Reflectivity;
        public float MipBlurFactor;

        public string DetName;
        public string BumpName;
        public string Aux0Name;
        public string Aux1Name;
        public string Aux2Name;
        public string Aux3Name;
        public string Aux4Name;
        public string Aux5Name;
        public string Aux6Name;
        public string Aux7Name;
        public string ShaderName;
        public string GameMtlName;

        public float[] AvgColor;
        public float[] SurfXform;
        public float[] AuxParams;
        public float[] AuxParams1;
    }

    public class MConfig
    {
        public static TextureConfigSDK ReadTextureConfigFromLua(string luaPath)
        {
            if (!File.Exists(luaPath)) throw new FileNotFoundException(nameof(luaPath));

            var result = new TextureConfigSDK();

            var luaCodes = File.ReadAllLines(luaPath);


            for (int i = 0; i< luaCodes.Length; i++)
            {
                string luaCode = luaCodes[i].Trim(' ', '\t');

                if (luaCode.StartsWith("alpha_adj"))
                    result.AlphaAdj = GetIntParam(luaCode, "alpha_adj");

                if (luaCode.StartsWith("animated"))
                    result.Animated = GetBoolParam(luaCode, "animated");

                if (luaCode.StartsWith("aux0_name"))
                    result.Aux0Name = GetParam(luaCode, "aux0_name");

                if (luaCode.StartsWith("aux1_name"))
                    result.Aux1Name = GetParam(luaCode, "aux1_name");

                if (luaCode.StartsWith("aux2_name"))
                    result.Aux2Name = GetParam(luaCode, "aux2_name");

                if (luaCode.StartsWith("aux3_name"))
                    result.Aux3Name = GetParam(luaCode, "aux3_name");

                if (luaCode.StartsWith("aux4_name"))
                    result.Aux4Name = GetParam(luaCode, "aux4_name");

                if (luaCode.StartsWith("aux5_name"))
                    result.Aux5Name = GetParam(luaCode, "aux5_name");

                if (luaCode.StartsWith("aux6_name"))
                    result.Aux6Name = GetParam(luaCode, "aux6_name");

                if (luaCode.StartsWith("aux7_name"))
                    result.Aux7Name = GetParam(luaCode, "aux7_name");

                if (luaCode.StartsWith("aux_params") && !luaCode.StartsWith("aux_params_1"))
                    result.AuxParams = GetFloatArray(luaCodes, "aux_params", i);

                if (luaCode.StartsWith("aux_params_1"))
                    result.AuxParams1 = GetFloatArray(luaCodes, "aux_params_1", i);

                if (luaCode.StartsWith("avg_color"))
                    result.AvgColor = GetFloatArray(luaCodes, "avg_color", i);

                if (luaCode.StartsWith("bump_height"))
                    result.BumpHeight = GetFloatParam(luaCode, "bump_height");

                if (luaCode.StartsWith("bump_name"))
                    result.BumpName = GetParam(luaCode, "bump_name");

                if (luaCode.StartsWith("det_intensity"))
                    result.DetIntensity = GetFloatParam(luaCode, "det_intensity");

                if (luaCode.StartsWith("det_name"))
                    result.DetName = GetParam(luaCode, "det_name");

                if (luaCode.StartsWith("det_scale_u"))
                    result.DetScaleU = GetFloatParam(luaCode, "det_scale_u");

                if (luaCode.StartsWith("det_scale_v"))
                    result.DetScaleV = GetFloatParam(luaCode, "det_scale_v");

                if (luaCode.StartsWith("displ_height"))
                    result.DispHeight = GetFloatParam(luaCode, "displ_height");

                if (luaCode.StartsWith("displ_type"))
                    result.DispType = GetIntParam(luaCode, "displ_type");

                if (luaCode.StartsWith("draft"))
                    result.Draft = GetBoolParam(luaCode, "draft");

                if (luaCode.StartsWith("format"))
                    result.Format = GetIntParam(luaCode, "format");

                if (luaCode.StartsWith("gamemtl_name"))
                    result.GameMtlName = GetParam(luaCode, "gamemtl_name");

                if (luaCode.StartsWith("gloss_multiplier"))
                    result.GlossMultiplier = GetIntParam(luaCode, "gloss_multiplier");

                if (luaCode.StartsWith("height"))
                    result.Height = GetIntParam(luaCode, "height");

                if (luaCode.StartsWith("mip_blur") && !luaCode.StartsWith("mip_blur_factor"))
                    result.MipBlur = GetBoolParam(luaCode, "mip_blur");

                if (luaCode.StartsWith("mip_blur_factor"))
                    result.MipBlurFactor = GetFloatParam(luaCode, "mip_blur_factor");

                if (luaCode.StartsWith("mip_filter"))
                    result.MipFilter = GetIntParam(luaCode, "mip_filter");

                if (luaCode.StartsWith("mip_max"))
                    result.MipMax = GetIntParam(luaCode, "mip_max");

                if (luaCode.StartsWith("mip_srgb"))
                    result.MipSrgb = GetBoolParam(luaCode, "mip_srgb");

                if (luaCode.StartsWith("mipmapped"))
                    result.Mipmapped = GetBoolParam(luaCode, "mipmapped");

                if (luaCode.StartsWith("override_avg_color"))
                    result.OverrideAvgColor = GetBoolParam(luaCode, "override_avg_color");

                if (luaCode.StartsWith("parallax_height_mul"))
                    result.ParallaxHeightMul = GetIntParam(luaCode, "parallax_height_mul");

                if (luaCode.StartsWith("priority"))
                    result.Priority = GetIntParam(luaCode, "priority");

                if (luaCode.StartsWith("reflectivity"))
                    result.Reflectivity = GetFloatParam(luaCode, "reflectivity");

                if (luaCode.StartsWith("s_height"))
                    result.SHeight = GetIntParam(luaCode, "s_height");

                if (luaCode.StartsWith("s_width"))
                    result.SWidth = GetIntParam(luaCode, "s_width");

                if (luaCode.StartsWith("shader_name"))
                    result.ShaderName = GetParam(luaCode, "shader_name");

                if (luaCode.StartsWith("slot_count"))
                    result.SlotCount = GetIntParam(luaCode, "slot_count");

                if (luaCode.StartsWith("streamable"))
                    result.Streamable = GetBoolParam(luaCode, "streamable");

                if (luaCode.StartsWith("surf_xform"))
                    result.SurfXform = GetFloatArray(luaCodes, "surf_xform", i);

                if (luaCode.StartsWith("treat_as_metal"))
                    result.TreatAsMetal = GetBoolParam(luaCode, "treat_as_metal");

                if (luaCode.StartsWith("type"))
                    result.Type = GetIntParam(luaCode, "type");

                if (luaCode.StartsWith("use_source_image"))
                    result.UseSourceImage = GetBoolParam(luaCode, "use_source_image");

                if (luaCode.StartsWith("use_toksvig_factor"))
                    result.UseToksvigFactor = GetBoolParam(luaCode, "use_toksvig_factor");

                if (luaCode.StartsWith("width"))
                    result.Width = GetIntParam(luaCode, "width");
            }

            return result;
        }

        public static bool WriteLuaConfig(string luaPath, TextureConfigSDK config)
        {
            try
            {
                var content = new List<string>()
                {
                    "texture = create_section {",
                    $"   alpha_adj = {config.AlphaAdj},",
                    $"   animated = {config.Animated.ToString().ToLower()},",
                    $"   aux0_name = \"{config.Aux0Name}\",",
                    $"   aux1_name = \"{config.Aux1Name}\",",
                    $"   aux2_name = \"{config.Aux2Name}\",",
                    $"   aux3_name = \"{config.Aux3Name}\",",
                    $"   aux4_name = \"{config.Aux4Name}\",",
                    $"   aux5_name = \"{config.Aux5Name}\",",
                    $"   aux6_name = \"{config.Aux6Name}\",",
                    $"   aux7_name = \"{config.Aux7Name}\",",
                    "   aux_params = create_section {",
                    $"      {config.AuxParams[0].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AuxParams[1].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AuxParams[2].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AuxParams[3].ToString(CultureInfo.InvariantCulture)},",
                    "   }",
                    "\n",
                    "   aux_params_1 = create_section {",
                    $"      {config.AuxParams1[0].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AuxParams1[1].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AuxParams1[2].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AuxParams1[3].ToString(CultureInfo.InvariantCulture)},",
                    "   }",
                    "\n",
                    "   avg_color = create_section {",
                    $"      {config.AvgColor[0].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AvgColor[1].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AvgColor[2].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.AvgColor[3].ToString(CultureInfo.InvariantCulture)},",
                    "   }",
                    "\n",
                    $"   bump_height = {config.BumpHeight.ToString(CultureInfo.InvariantCulture)},",
                    $"   bump_name = \"{config.BumpName}\",",
                    $"   det_intensity = {config.DetIntensity.ToString(CultureInfo.InvariantCulture)},",
                    $"   det_name = \"{config.DetName}\",",
                    $"   det_scale_u = {config.DetScaleU.ToString(CultureInfo.InvariantCulture)},",
                    $"   det_scale_v = {config.DetScaleV.ToString(CultureInfo.InvariantCulture)},",
                    $"   displ_height = {config.DispHeight.ToString(CultureInfo.InvariantCulture)},",
                    $"   displ_type = {config.DispType},",
                    $"   draft = {config.Draft.ToString().ToLower()},",
                    $"   format = {config.Format},",
                    $"   gamemtl_name = \"{config.GameMtlName}\",",
                    $"   gloss_multiplier = {config.GlossMultiplier},",
                    $"   height = {config.Height},",
                    $"   mip_blur = {config.MipBlur.ToString().ToLower()},",
                    $"   mip_blur_factor = {config.MipBlurFactor.ToString(CultureInfo.InvariantCulture)},",
                    $"   mip_filter = {config.MipFilter},",
                    $"   mip_max = {config.MipMax},",
                    $"   mip_srgb = {config.MipSrgb.ToString().ToLower()},",
                    $"   mipmapped = {config.Mipmapped.ToString().ToLower()},",
                    $"   override_avg_color = {config.OverrideAvgColor.ToString().ToLower()},",
                    $"   parallax_height_mul = {config.ParallaxHeightMul},",
                    $"   priority = {config.Priority},",
                    $"   reflectivity = {config.Reflectivity.ToString(CultureInfo.InvariantCulture)},",
                    $"   s_height = {config.SHeight},",
                    $"   s_width = {config.SWidth},",
                    $"   shader_name = \"{config.ShaderName}\",",
                    $"   slot_count = {config.SlotCount},",
                    $"   streamable = {config.Streamable.ToString().ToLower()},",
                    "   surf_xform = create_section {",
                    $"      {config.SurfXform[0].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.SurfXform[1].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.SurfXform[2].ToString(CultureInfo.InvariantCulture)},",
                    $"      {config.SurfXform[3].ToString(CultureInfo.InvariantCulture)},",
                    "   }",
                    "\n",
                    $"   treat_as_metal = {config.TreatAsMetal.ToString().ToLower()},",
                    $"   type = {config.Type},",
                    $"   use_source_image = {config.UseSourceImage.ToString().ToLower()},",
                    $"   use_toksvig_factor = {config.UseToksvigFactor.ToString().ToLower()},",
                    $"   width = {config.Width},",
                    "}"
                };

                File.WriteAllLines(luaPath, content);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Config Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static string GetParam(string luaCode, string paramName)
        {
            if (string.IsNullOrEmpty(luaCode)) throw new ArgumentNullException(nameof(luaCode));
            if (string.IsNullOrEmpty(paramName)) throw new ArgumentNullException(nameof(paramName));

            if (!luaCode.Contains(paramName)) throw new ArgumentException(nameof(paramName));

            return luaCode.Split('=').Last().Trim(' ', ',', '\t').Replace("\"", string.Empty);
        }

        public static int GetIntParam(string luaCode, string paramName) => int.Parse(GetParam(luaCode, paramName).Trim(' ', ',', '\t'));

        public static bool GetBoolParam(string luaCode, string paramName) => bool.Parse(GetParam(luaCode, paramName).Trim(' ', ',', '\t'));

        public static float GetFloatParam(string luaCode, string paramName) => float.Parse(GetParam(luaCode, paramName).Trim(' ', ',', '\t'), CultureInfo.InvariantCulture);

        public static int[] GetIntArray(string[] luaCodes, string arrayName, int arrayInd = 0, int arrayLen = 4)
        {
            int[] arr = new int[arrayLen];
            string param = GetParam(luaCodes[arrayInd], arrayName);

            if (string.IsNullOrEmpty(param)) return arr;

            for (int i = 0; i < arr.Length; i++)
            {
                arrayInd++;

                arr[i] = int.Parse(luaCodes[arrayInd].Trim(' ', ',', '\t'));
            }

            return arr;
        }

        public static float[] GetFloatArray(string[] luaCodes, string arrayName, int arrayInd = 0, int arrayLen = 4)
        {
            float[] arr = new float[arrayLen];
            string param = GetParam(luaCodes[arrayInd], arrayName);

            if (string.IsNullOrEmpty(param)) return arr;

            for (int i = 0; i < arr.Length; i++)
            {
                arrayInd++;

                arr[i] = float.Parse(luaCodes[arrayInd].Trim(' ', ',', '\t'), CultureInfo.InvariantCulture);
            }

            return arr;
        }
    }
}
