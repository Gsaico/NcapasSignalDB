using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.users_acts
{
    public interface IUsers_actsQuery
    {
        bool InsertarUsers_acts(Dtos.users_actsDTO dto);
        bool ActualizarUsers_acts(Dtos.users_actsDTO dto);
        bool EliminarUsers_acts(int id);
        List<Dtos.users_actsDTO> BuscarUsers_acts_IDACT(int id);
        List<Dtos.users_actsDTO> BuscarUsers_acts_IDUSER(string id);
    }
}
