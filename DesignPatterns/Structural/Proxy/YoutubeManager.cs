using DesignPatterns.Structural.Proxy.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{

 
    public class YoutubeManager
    {

        private IYoutubeLib service;

        public YoutubeManager(IYoutubeLib service)
        {
            this.service = service;
        }

        public Video? WathVideo(int id)
        {
           return service.GetVideoById(id);
        }
    }
}
