using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.users_acts
{
    public interface IUsers_actsLogicaDeNegocios
    {
        bool InsertarUsers_acts(Dominio.Dtos.users_actsDTO dto);
        bool ActualizarUsers_acts(Dominio.Dtos.users_actsDTO dto);
        bool EliminarUsers_acts(int id);
        List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDACT(int id);
        List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDUSER(string id);
    }
}
