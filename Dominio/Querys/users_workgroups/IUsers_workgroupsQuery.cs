using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.users_workgroups
{
    public interface IUsers_workgroupsQuery
    {
        bool InsertarUsers_workgroups(Dtos.users_workgroupsDTO dto);
        bool ActualizarUsers_workgroups(Dtos.users_workgroupsDTO dto);
        bool EliminarUsers_workgroups(int id);
        List<Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDWORKGROUP(int id);
        List<Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDUSER(string id);
    }
}
