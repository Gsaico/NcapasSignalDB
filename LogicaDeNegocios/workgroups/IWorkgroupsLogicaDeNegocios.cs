using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.workgroups
{
    public interface IWorkgroupsLogicaDeNegocios
    {
        int InsertarWorkgroups(Dominio.Dtos.workgroupsDTO dto);
        bool ActualizarWorkgroups(Dominio.Dtos.workgroupsDTO dto);
        bool EliminarWorkgroups(int id);
        Dominio.Dtos.workgroupsDTO BuscarWorkgroups(int id);
        List<Dominio.Dtos.workgroupsDTO> ListarWorkgroups(string param);
        List<Dominio.Dtos.workgroupsDTO> ListarTodosLosWorkgroup_Activos();
    }
}
