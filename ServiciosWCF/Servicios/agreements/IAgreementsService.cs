using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.agreements
{
    [ServiceContract]
   public  interface IAgreementsService
    {
        [OperationContract]
        int InsertarAgreements(Dominio.Dtos.agreementsDTO dto);
        [OperationContract]
        bool ActualizarAgreements(Dominio.Dtos.agreementsDTO dto);
        [OperationContract]
        bool EliminarAgreements(int id);
        [OperationContract]
        Dominio.Dtos.agreementsDTO BuscarAgreements(int id);
        [OperationContract]
        List<Dominio.Dtos.agreementsDTO> ListarAgreements(string param);
    }
}
