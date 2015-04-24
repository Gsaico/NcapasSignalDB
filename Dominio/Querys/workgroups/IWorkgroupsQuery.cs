using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.workgroups
{
    public interface IWorkgroupsQuery
    {
        int InsertarWorkgroups(Dtos.workgroupsDTO  dto);
        bool ActualizarWorkgroups(Dtos.workgroupsDTO dto);
        bool EliminarWorkgroups(int id);
        Dtos.workgroupsDTO BuscarWorkgroups(int id);
        List<Dtos.workgroupsDTO> ListarWorkgroups(string param);
        List<Dtos.workgroupsDTO> ListarTodosLosWorkgroup_Activos();
     
    }
}
