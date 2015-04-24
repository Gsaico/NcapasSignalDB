using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.workgroups
{
    [ServiceContract]
    public interface IWorkgroupsService
    {
        [OperationContract]
        int InsertarWorkgroups(Dominio.Dtos.workgroupsDTO dto);
        [OperationContract]
        bool ActualizarWorkgroups(Dominio.Dtos.workgroupsDTO dto);
        [OperationContract]
        bool EliminarWorkgroups(int id);
        [OperationContract]
        Dominio.Dtos.workgroupsDTO BuscarWorkgroups(int id);
        [OperationContract]
        List<Dominio.Dtos.workgroupsDTO> ListarWorkgroups(string param);
        [OperationContract]
        List<Dominio.Dtos.workgroupsDTO> ListarTodosLosWorkgroup_Activos();
    }
}
