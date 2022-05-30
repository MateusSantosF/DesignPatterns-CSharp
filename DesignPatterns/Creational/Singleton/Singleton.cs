using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{

    /// <summary>
    /// Utilize o padrão Singleton quando uma classe em seu programa deve ter apenas uma instância disponível para
    /// todos seus clientes;
    /// por exemplo, um objeto de base de dados único compartilhado por diferentes partes do programa.
    /// 
    /// ATENÇÃO: Em muitos casos, inviabiliza os testes de unidade; Viola o Princicipio de Responsabilidade Única
    /// </summary>
    internal class Singleton
    {

        private static Singleton _singleton;

        private Singleton() { }


        /// <summary>
        ///  Garante uma única instancia da classe, que está armazenada em Cache devido a variavel statica
        /// </summary>
        /// <returns>
        /// Singleton instance
        /// </returns>
        public static Singleton getInstance()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }

        public void bussinesLogic()
        {
            Console.WriteLine("My Isane Business Logic inside Singleton!");
        }
    }
}
