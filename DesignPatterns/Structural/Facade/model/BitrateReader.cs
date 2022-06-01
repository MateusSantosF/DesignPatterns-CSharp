using DesignPatterns.Structural.Facade.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.model
{
    public class BitrateReader
    {
        public static VideoFile read(VideoFile file, ICodec codec)
        {
            Console.WriteLine("BitrateReader: reading file...");
            return file;
        }

        public static VideoFile convert(VideoFile buffer, ICodec codec)
        {
            Console.WriteLine("BitrateReader: writing file...");
            return buffer;
        }
    }
}
