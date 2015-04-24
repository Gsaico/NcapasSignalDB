using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.users_acts
{
    [ServiceContract]
    public interface IUsers_actsService
    {
        [OperationContract]
        bool InsertarUsers_acts(Dominio.Dtos.users_actsDTO dto);
        [OperationContract]
        bool ActualizarUsers_acts(Dominio.Dtos.users_actsDTO dto);
        [OperationContract]
        bool EliminarUsers_acts(int id);
        [OperationContract]
        List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDACT(int id);
        [OperationContract]
        List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDUSER(string id);
    }
}
