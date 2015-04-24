using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.messages_files
{
    public interface IMessages_filesLogicaDeNegocios
    {
        bool InsertarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto);
        bool ActualizarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto);
        bool EliminarMessages_filesDTO(int id);
        List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDMESSAGES(int id);
        List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDFILE(int id);
    }
}
