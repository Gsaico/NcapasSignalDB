using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.users
{
    [ServiceContract]
    public interface IUsersService
    {
        [OperationContract]
        string InsertarUsers(Dominio.Dtos.usersDTO dto);
        [OperationContract]
        bool ActualizarUsers(Dominio.Dtos.usersDTO dto);
        [OperationContract]
        bool EliminarUsers(string id);
        [OperationContract]
        Dominio.Dtos.usersDTO BuscarUsers(string id);
        [OperationContract]
        List<Dominio.Dtos.usersDTO> ListarUsers(string param);
    }
}
