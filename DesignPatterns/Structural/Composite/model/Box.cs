using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.model
{
    public class Box : Sale
    {

        public List<Sale> SaleList { get; set; }

        /// <summary>
        /// Utilize o padrão quando você quer que o código cliente trate tanto os objetos simples como 
        /// os compostos de forma uniforme.<para/>
        /// 
        ///  Todos os elementos definidos pelo padrão Composite compartilham uma interface comum. 
        ///  Usando essa interface o cliente não precisa se preocupar com a classe concreta dos objetos com os quais está trabalhando
        /// </summary>
        public Box()
        {
            SaleList = new List<Sale>();
        }

        public override void AddItem(Sale item)
        {
            SaleList.Add(item);
        }

        public override Sale GetChild(int index )
        {
            return SaleList[index];
        }

        public override float GetPrice()
        {
            float price = 0;

            SaleList.ForEach(item =>
            {
                price+= item.GetPrice();
            });

            return price;
        }

        public override void RemoveItem(Sale item)
        {
            SaleList.Remove(item);
        }
    }
}
