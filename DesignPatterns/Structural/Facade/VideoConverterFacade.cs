using DesignPatterns.Structural.Facade.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Facade.interfaces;

namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    ///  O padrão Facade, cria uma interface facilitadora para o cliente acessar um subprograma mais complexo,
    ///  reduzindo acomplamento e a necessidade de se conhecer todas as subclasses e construtores do subprograma complexo
    /// </summary>
    /// <returns></returns>
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
