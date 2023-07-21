namespace MetroTextures.Metro
{
    /// <summary>
    /// Metro Paths
    /// </summary>
    public class MPaths
    {
        /// <summary>
        /// Provides Functions To Get And Check Texture Files From Texture Folder
        /// </summary>
        /// <param name="textureFolder">Folder With Textures Config</param>
        /// <returns>Files Textures Paths</returns>
        public static List<string> GetTexturePaths(string textureFolder)
        {
            if (string.IsNullOrEmpty(textureFolder)) throw new ArgumentNullException(nameof(textureFolder));

            if (!Directory.Exists(textureFolder)) throw new Exception($"Can't Find Folder By Path: '{textureFolder}'");

            return Directory.GetFiles(textureFolder, "*.lua", SearchOption.AllDirectories).ToList();
        }
    }
}
