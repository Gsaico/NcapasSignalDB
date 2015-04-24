using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.departments
{
    [ServiceContract]
    public interface IDepartmentsService
    {
        [OperationContract]
        int InsertarDepartments(Dominio.Dtos.departmentsDTO dto);
        [OperationContract]
        bool ActualizarDepartments(Dominio.Dtos.departmentsDTO dto);
        [OperationContract]
        bool EliminarDepartments(int id);
        [OperationContract]
        Dominio.Dtos.departmentsDTO BuscarDepartments(int id);
        [OperationContract]
        List<Dominio.Dtos.departmentsDTO> ListarDepartments(string param);
    }
}
