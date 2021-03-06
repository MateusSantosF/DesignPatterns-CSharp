using DesignPatterns.Structural.Facade.interfaces;

namespace DesignPatterns.Structural.Facade.model
{
    public static class CodecFactory
    {

        public static ICodec extract(VideoFile file)
        {
            String type = file.codecType;
            if (type.Equals("mp4"))
            {
                Console.WriteLine("CodecFactory: extracting mpeg audio...");
                return new MPEG4CompressionCodec();
            }
            else
            {
                Console.WriteLine("CodecFactory: extracting ogg audio...");
                return new OggCompressionCodec();
            }
        }
    }
}
