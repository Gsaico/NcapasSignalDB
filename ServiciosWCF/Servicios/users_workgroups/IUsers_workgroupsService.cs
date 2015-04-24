using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.users_workgroups
{
    [ServiceContract]
    public interface IUsers_workgroupsService
    {
        [OperationContract]
        bool InsertarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto);
        [OperationContract]
        bool ActualizarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto);
        [OperationContract]
        bool EliminarUsers_workgroups(int id);
        [OperationContract]
        List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDWORKGROUP(int id);
        [OperationContract]
        List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDUSER(string id);
    }
}
