using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.model
{
    public class Florest
    {

        public List<Tree> Trees { get; set; }

        public Florest(){
            Trees = new List<Tree>();
        }

        public Tree PlantTree(int x, int y, string name, string color, string texture)
        {   
            var tree =  new Tree(x, y, TreeFactory.TreeFactory.GetTreeType(name, color, texture));
            Trees.Add(tree);
            return tree;
        }
    }
}
