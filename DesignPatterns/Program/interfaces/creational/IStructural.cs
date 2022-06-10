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


        /// <summary>
        /// 
        /// O padrão Proxy sugere que você crie uma nova classe proxy com a mesma interface do objeto do serviço original.
        /// Então você atualiza sua aplicação para que ela passe o objeto proxy para todos os clientes do objeto original. 
        /// Ao receber uma solicitação de um cliente, o proxy cria um objeto do serviço real e delega a ele todo o trabalho.<para/>
        /// 
        /// Há dúzias de maneiras de utilizar o padrão Proxy. Vamos ver os usos mais populares.<para/>
        /// 
        /// - Controle de acesso (proxy de proteção). Este é quando você quer que apenas clientes específicos usem o objeto do serviço; <para/>
        /// 
        /// - Execução local de um serviço remoto (proxy remoto). Este é quando o objeto do serviço está localizado em um servidor remoto.<para/>
        /// 
        /// - Registros de pedidos (proxy de registro). Este é quando você quer manter um histórico de pedidos ao objeto do serviço.<para/>
        /// 
        /// -  Cache de resultados de pedidos (proxy de cache). Este é quando você precisa colocar em cache os resultados de pedidos do cliente e gerenciar o ciclo de vida deste cache, especialmente se os resultados são muito grandes.<para/>
        /// 
        /// </summary>
        string Proxy();


        /// <summary>
        /// O padrão Adapter difere do proxy no quesito funcionalidades. Enquanto o proxy ambos objetos compartilham
        /// a mesma interface, e é adicionado ações após ou antes da execução do serviço original, o Adapter
        /// funciona quando o serviço que você deseja utilizar não possui interface comum com o cliente, e não é possível
        /// alterar a interface, assim, por meio de COMPOSIÇÃO, se mantem a interface do cliente, adaptando o serviço que deseja
        /// utilizar criando uma classe Adapter{seuServiço} que implementa a interface existente, mas usa o serviço incompativel.
        /// </summary>
        string Adapter();
    }
}
