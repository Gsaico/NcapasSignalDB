using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.users
{
   public interface IUsersLogicaDeNegocios
    {
        string InsertarUsers(Dominio.Dtos.usersDTO dto);
        bool ActualizarUsers(Dominio.Dtos.usersDTO dto);
        bool EliminarUsers(string id);
        Dominio.Dtos.usersDTO BuscarUsers(string id);
        List<Dominio.Dtos.usersDTO> ListarUsers(string param);
        List<Dominio.Dtos.usersDTO> ListarTodosLosUsers();
    }
}
