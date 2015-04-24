using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.messages_files
{
    [ServiceContract]
    public interface IMessages_filesService
    {
        [OperationContract]
        bool InsertarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto);
        [OperationContract]
        bool ActualizarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto);
        [OperationContract]
        bool EliminarMessages_filesDTO(int id);
        [OperationContract]
        List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDMESSAGES(int id);
        [OperationContract]
        List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDFILE(int id);
    }
}
