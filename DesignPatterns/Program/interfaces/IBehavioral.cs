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
    }
}
