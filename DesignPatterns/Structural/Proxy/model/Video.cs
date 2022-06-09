using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy.model
{
    public class Video : IVideo
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public Video()
        {

        }

        public Video(int id,string name, string author, string description)
        {
            Id = id;
            Name = name;
            Author = author;
            Description = description;
        }
    }
}
