using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.acts
{
    public interface IActsQuery
    {
        int InsertarActs(Dtos.actsDTO dto);
        bool ActualizarActs(Dtos.actsDTO dto);
        bool EliminarActs(int id);
        Dtos.actsDTO BuscarActs(int id);
        List<Dtos.actsDTO> ListarActs(string param);
        
    }
}
