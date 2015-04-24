using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.messages
{
    public interface IMessagesQuery
    {
        int InsertarMessages(Dtos.messagesDTO dto);
        bool ActualizarMessages(Dtos.messagesDTO dto);
        bool EliminarMessages(int  id);
        Dtos.messagesDTO BuscarMessages(int id);
        List<Dtos.messagesDTO> ListarMessages(string param);
        
    }
}
