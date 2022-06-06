using DesignPatterns.Structural.Flyweight.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Flyweight.TreeFactory
{
    public static class TreeFactory
    {
        private static List<TreeType> Types = new List<TreeType>();

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            TreeType? result = result = Types.FirstOrDefault(tree =>
                 tree.Name.Equals(name) &&
                 tree.Texture.Equals(texture) &&
                 tree.Color.Equals(color)
                ) ?? null;
                 
            if(result == null)
            {         
                result = new TreeType(name, color, texture);
                Types.Add(result);
                Console.WriteLine("This message should only be seen twice ");
            }
            return result;
        }
    }
}
