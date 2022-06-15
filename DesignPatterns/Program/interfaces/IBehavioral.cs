namespace DesignPatterns.Program.interfaces
{
    public interface IBehavioral
    {
        /// <summary>
        /// Utilize o padrão Command quando você quer:
        /// <para/> - parametrizar objetos com operações;
        /// <para/> - colocar operações em fila, agendar sua execução, ou executá-las remotamente.
        /// <para/> - implementar operações reversíveis.
        /// </summary>
        string Command();

        /// <summary>
        /// Utilize o padrão Memento quando você quer produzir retratos do estado de um objeto para ser
        /// capaz de restaurar um estado anterior do objeto.
        /// </summary>
        string Memento();

        /// <summary>
        /// Utilize o padrão Observer quando mudanças no estado de um objeto podem precisar 
        /// mudar outros objetos, e o atual conjunto de objetos é desconhecido de antemão ou muda dinamicamente.
        /// </summary>
        string Observer();

        /// <summary>
        /// Utilize o padrão Strategy quando você quer usar diferentes variantes de um algoritmo dentro de um objeto
        /// e ser capaz de trocar de um algoritmo para outro durante a execução.
        /// </summary>
        string Strategy();

        /// <summary>
        /// Utilize o padrão quando você não pode reutilizar um componente em um programa 
        /// diferente porque ele é muito dependente de outros componentes. Assim, ao aplicar o Mediator, o componente
        /// passa a se comunicar apenas com o Mediador, e não mais com outros componentes.
        /// </summary>
        string Mediator();

        /// <summary>
        /// O padrão Visitor permite que você execute uma operação sobre um conjunto de objetos com diferentes 
        /// classes ao ter o objeto visitante implementando diversas variantes da mesma operação, que correspondem a 
        /// todas as classes alvo.
        /// </summary>
        string Visitor();

        /// <summary>
        ///  Utilize o padrão Iterator quando sua coleção tiver uma estrutura de dados complexa por debaixo
        ///  dos panos, mas você quer esconder a complexidade dela de seus clientes (seja por motivos de conveniência ou 
        ///  segurança)
        /// </summary>
        string Iterator();

        string ChainOfResponsability();
    }
}
