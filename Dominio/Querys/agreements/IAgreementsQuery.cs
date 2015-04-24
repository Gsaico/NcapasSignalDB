using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.agreements
{
    public interface IAgreementsQuery
    {
        int InsertarAgreements(Dtos.agreementsDTO dto);
        bool ActualizarAgreements(Dtos.agreementsDTO dto);
        bool EliminarAgreements(int id);
        Dtos.agreementsDTO BuscarAgreements(int id);
        List<Dtos.agreementsDTO> ListarAgreements(string param);
    }
}
