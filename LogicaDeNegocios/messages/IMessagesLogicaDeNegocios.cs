using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.messages
{
    public interface IMessagesLogicaDeNegocios
    {
        int InsertarMessages(Dominio.Dtos.messagesDTO dto);
        bool ActualizarMessages(Dominio.Dtos.messagesDTO dto);
        bool EliminarMessages(int id);
        Dominio.Dtos.messagesDTO BuscarMessages(int id);
        List<Dominio.Dtos.messagesDTO> ListarMessages(string param);
        
    }
}
