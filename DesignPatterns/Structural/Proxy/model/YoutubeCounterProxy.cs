namespace DesignPatterns.Structural.Proxy.model
{
    public class YoutubeCounterProxy : IYoutubeLib
    {
        public int Counter { get; set; }

        private IYoutubeLib service;
        public YoutubeCounterProxy(IYoutubeLib service)
        {
            this.service = service;
            Counter = 0;
        }

        public Video? GetVideoById(int id)
        {
            Counter++;
            return service.GetVideoById(id);
        }

        public List<Video> ListAllVideos()
        {
            Counter++;
            return service.ListAllVideos();
        }
    }
}
