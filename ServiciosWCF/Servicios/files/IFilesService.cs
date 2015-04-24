using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.files
{
    [ServiceContract]
    public interface IFilesService
    {
        [OperationContract]
        int InsertarFiles(Dominio.Dtos.filesDTO dto);
        [OperationContract]
        bool ActualizarFiles(Dominio.Dtos.filesDTO dto);
        [OperationContract]
        bool EliminarFiles(int id);
        [OperationContract]
        Dominio.Dtos.filesDTO BuscarFiles(int id);
        [OperationContract]
        List<Dominio.Dtos.filesDTO> ListarFiles(string param);
    }
}
