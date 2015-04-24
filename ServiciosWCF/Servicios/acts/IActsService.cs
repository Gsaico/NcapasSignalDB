using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.acts
{
    [ServiceContract]
    public interface IActsService
    {
        [OperationContract]
        int InsertarActs(Dominio.Dtos.actsDTO dto);
        [OperationContract]
        bool ActualizarActs(Dominio.Dtos.actsDTO dto);
        [OperationContract]
        bool EliminarActs(int id);
        [OperationContract]
        Dominio.Dtos.actsDTO BuscarActs(int id);
        [OperationContract]
        List<Dominio.Dtos.actsDTO> ListarActs(string param);
    }
}
