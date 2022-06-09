using DesignPatterns.Structural.Facade.interfaces;
using DesignPatterns.Structural.Facade.model;

namespace DesignPatterns.Structural.Facade
{

    public class VideoConverterFacade
    {
      
        public string Convert(string filename, string format)
        {
            Console.WriteLine("VideoConversionFacade: conversion started.");
            VideoFile file = new VideoFile(filename);
            ICodec sourceCodec = CodecFactory.extract(file);
            ICodec destinationCodec;
            if (format.Equals("mp4"))
            {
                destinationCodec = new MPEG4CompressionCodec();
            }
            else
            {
                destinationCodec = new OggCompressionCodec();
            }
            VideoFile buffer = BitrateReader.read(file, sourceCodec);
            VideoFile intermediateResult = BitrateReader.convert(buffer, destinationCodec);
            string result = new AudioMixer().Fix(intermediateResult);
            Console.WriteLine("VideoConversionFacade: conversion completed.");
            return result;
        }
    }
}
