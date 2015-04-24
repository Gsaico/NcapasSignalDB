using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.messages
{
    [ServiceContract]
    public interface IMessagesService
    {
        [OperationContract]
        int InsertarMessages(Dominio.Dtos.messagesDTO dto);
        [OperationContract]
        bool ActualizarMessages(Dominio.Dtos.messagesDTO dto);
        [OperationContract]
        bool EliminarMessages(int id);
        [OperationContract]
        Dominio.Dtos.messagesDTO BuscarMessages(int id);
        [OperationContract]
        List<Dominio.Dtos.messagesDTO> ListarMessages(string param);
    }
}
