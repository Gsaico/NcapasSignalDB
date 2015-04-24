using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.agreements
{
    public interface IAgreementsLogicaDeNegocios
    {
        int InsertarAgreements(Dominio.Dtos.agreementsDTO dto);
        bool ActualizarAgreements(Dominio.Dtos.agreementsDTO dto);
        bool EliminarAgreements(int id);
        Dominio.Dtos.agreementsDTO BuscarAgreements(int id);
        List<Dominio.Dtos.agreementsDTO> ListarAgreements(string param);
    }
}
