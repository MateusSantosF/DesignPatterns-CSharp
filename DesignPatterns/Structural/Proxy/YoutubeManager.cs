using DesignPatterns.Structural.Proxy.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{

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
    public class YoutubeManager
    {

        private IYoutubeLib service;

        public YoutubeManager(IYoutubeLib service)
        {
            this.service = service;
        }

        public Video? WathVideo(int id)
        {
           return service.GetVideoById(id);
        }
    }
}
