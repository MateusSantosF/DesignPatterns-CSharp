namespace DesignPatterns.Program.interfaces.creational
{
    public interface IStructural
    {

        /// <summary>
        /// Utilize o padrão quando você quer que o código cliente trate tanto os objetos simples como 
        /// os compostos de forma uniforme.<para/>
        /// 
        ///  Todos os elementos definidos pelo padrão Composite compartilham uma interface comum. 
        ///  Usando essa interface o cliente não precisa se preocupar com a classe concreta dos objetos com os quais está trabalhando
        /// </summary>
        string Composite();


        /// <summary>
        /// Permite acoplar comportamentos para objetos ao coloca-lós dentro de wrappers que possuem outros comportamentos.<para />
        /// Quando Utilizar: <para />Utilize o padrão Decorator quando você precisa ser capaz de projetar comportamentos
        /// adicionais para objetos em tempo de execução sem quebrar o código que usa esses objetos;
        /// <para />Utilize o padrão quando é complicado ou impossível estender o comportamento de um objeto usando herança.
        /// </summary>
        string Decorator();

        /// <summary>
        ///  O padrão Facade, cria uma interface facilitadora para o cliente acessar um subprograma mais complexo,
        ///  reduzindo acomplamento e a necessidade de se conhecer todas as subclasses e construtores do subprograma complexo
        /// </summary>
        string Facade();

        /// <summary>
        /// Utilize o padrão Flyweight apenas quando seu programa deve suportar um grande número 
        /// de objetos que mal cabem na RAM disponível.
        /// <para/>
        /// A ideia é separar propriedades imutaveis entre objetos que serão criados em grande número em seu programa
        /// assim, guardando a referência das propriedades imutaveis para replicar sempre que um novo objeto é criado.
        /// </summary>
        string Flyweight();
    }
}
