using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.users_workgroups
{
    public interface IUsers_workgroupsLogicaDeNegocios
    {
        bool InsertarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto);
        bool ActualizarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto);
        bool EliminarUsers_workgroups(int id);
        List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDWORKGROUP(int id);
        List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDUSER(string id);
    }
}
