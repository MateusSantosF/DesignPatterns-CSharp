namespace DesignPatterns.Structural.Facade.model
{
    public class VideoFile
    {
        public string name { get; set; }
        public string codecType { get; set; }


        public VideoFile(String name)
        {
            this.name = name;
            this.codecType = name.Substring(name.IndexOf(".") + 1);
        }

        
    }
}
