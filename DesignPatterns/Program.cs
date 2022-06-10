using DesignPatterns.Program;
using DesignPatterns.Structural.Adapter.interfaces;
using DesignPatterns.Structural.Adapter.model;
using DesignPatterns.Structural.Proxy;
using DesignPatterns.Structural.Proxy.model;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string pattern = DesignPattern.ChoosePattern().StructuralPatterns().Decorator();
            Console.WriteLine(pattern);

            List<Video> videos = new List<Video>()
            {
                new Video(){Id = 1, Author = "Mateus", Description = "Any video", Name = "Learning Design Patterns"},
                new Video(){Id = 2, Author = "Cesar", Description = "Any video", Name = "Watch a progress intern"}
            };

            Youtube youtube = new Youtube(videos);
            YoutubeCounterProxy proxy = new YoutubeCounterProxy(youtube);
            YoutubeManager manager = new YoutubeManager(proxy);

            manager.WathVideo(1);
            manager.WathVideo(1);
            manager.WathVideo(2);
            Console.WriteLine("Total video views in youtube: " + proxy.Counter);


            Console.WriteLine("ADAPTER client ===========");

            IService myService = new ServiceAdapter(new LegacyService());
            myService.DoAnythingCurrent();

        }
    }
}


