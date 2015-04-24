using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.users
{
    public interface IUsersQuery
    {
        string InsertarUsers(Dtos.usersDTO dto);
        bool ActualizarUsers(Dtos.usersDTO dto);
        bool EliminarUsers(string id);
        Dtos.usersDTO  BuscarUsers(string id);
        List<Dtos.usersDTO> ListarUsers(string param);
        List<Dtos.usersDTO> ListarTodosLosUsers();
    }
}
