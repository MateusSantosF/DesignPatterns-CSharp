using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.model
{
    public interface IYoutubeLib
    {

        List<Video> ListAllVideos();

        Video? GetVideoById(int id);
    }
}
