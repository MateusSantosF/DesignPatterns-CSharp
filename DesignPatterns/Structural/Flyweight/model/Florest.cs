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

        /// <summary>
        /// Utilize o padrão Flyweight apenas quando seu programa deve suportar um grande número 
        /// de objetos que mal cabem na RAM disponível.
        /// <para/>
        /// A ideia é separar propriedades imutaveis entre objetos que serão criados em grande número em seu programa
        /// assim, guardando a referência das propriedades imutaveis para replicar sempre que um novo objeto é criado.
        /// </summary>
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
