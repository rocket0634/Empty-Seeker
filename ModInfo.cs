using EmptySeeker;

namespace EmptySeeker 
{
    internal class ModInfo
    {
        public enum ModSourceEnum
        {
            Invalid,
            Local,
            SteamWorkshop
        }

        public enum MotionControlsSupportEnum
        {
            Supported,
            Required,
            NotSupported
        }

        public ModSourceEnum ModSource;
        public string ID;
        public string Title;
        public string Author;
        public string Description;
        public string Version;
        public string UnityVersion;
        public int FilesizeInBytes;
        public MotionControlsSupportEnum MotionControlsSupport;
        public string PreviewTextureURL;
        public string FilePath;
        public override string ToString()
        {
            return string.Format("Name: {0}\nSource: {1}\nAuthor: {2}\nDescription: {3}", Title, ModSource, Author, Description);
        }
    }
}