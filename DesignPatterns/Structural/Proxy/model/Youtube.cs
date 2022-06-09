namespace DesignPatterns.Structural.Proxy.model
{
    public class Youtube : IYoutubeLib
    {

        private List<Video> Videos;

        public Youtube(List<Video> videos)
        {
            Videos = videos;
        }

        public Video? GetVideoById(int id)
        {
            return Videos.FirstOrDefault(v => v.Id.Equals(id));
        }

        public List<Video> ListAllVideos()
        {
            return Videos;
        }
    }
}
