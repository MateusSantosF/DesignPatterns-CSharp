namespace DesignPatterns.Structural.Adapter.interfaces
{
    public interface IService
    {
        /// <summary>
        /// O padrão Adapter difere do proxy no quesito funcionalidades. Enquanto o proxy ambos objetos compartilham
        /// a mesma interface, e é adicionado ações após ou antes da execução do serviço original, o Adapter
        /// funciona quando o serviço que você deseja utilizar não possui interface comum com o cliente, e não é possível
        /// alterar a interface, assim, por meio de COMPOSIÇÃO, se mantem a interface do cliente, adaptando o serviço que deseja
        /// utilizar criando uma classe Adapter{seuServiço} que implementa a interface existente, mas usa o serviço incompativel.
        /// </summary>
        void DoAnythingCurrent();
    }
}
