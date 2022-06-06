using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.model
{
    public class Tree
    {

        public int X { get; set; }

        public int Y { get; set; }

        public TreeType Type { get; set; }

        public Tree(int x, int y, TreeType type)
        {
            X = x;
            Y = y;
            Type = type;
        }


    }
}
