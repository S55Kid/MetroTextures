namespace MetroTextures.Metro
{
    public class DDSUtils
    {
        public static bool MakeConfigForDDS(string ddsPath, string textureFolder)
        {
            if (!File.Exists(ddsPath)) return false;

            var name = ddsPath.Split('\\').Last().Trim();
            var luaPath = Path.Combine(textureFolder, name.Replace(".dds", ".lua"));

            var config = new TextureConfigSDK()
            {
                Width = 2048,
                Height = 2048,
                SWidth = 2048,
                SHeight = 2048,
                AuxParams = new float[4] { 1, 1, 1, 1 },
                AuxParams1 = new float[4] { 1, 1, 1, 1 },
                AvgColor = new float[4] { 1, 1, 1, 1 },
                SurfXform = new float[4] { 0, 0, 1, 1 },
                ShaderName = "geometry\\default",
                GameMtlName = "default"
            };

            File.Move(ddsPath, Path.Combine(textureFolder, name));

            return MConfig.WriteLuaConfig(luaPath, config);
        }
    }
}
