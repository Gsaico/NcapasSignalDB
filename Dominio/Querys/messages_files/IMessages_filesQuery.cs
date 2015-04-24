using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.messages_files
{
    public interface IMessages_filesQuery
    {
        bool InsertarMessages_filesDTO(Dtos.messages_filesDTO dto);
        bool ActualizarMessages_filesDTO(Dtos.messages_filesDTO dto);
        bool EliminarMessages_filesDTO(int id);
        List<Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDMESSAGES(int id);
        List<Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDFILE(int id);
    }
}
