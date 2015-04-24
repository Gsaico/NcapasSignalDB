using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace LogicaDeNegocios.acts
{
    public interface IActsLogicaDeNegocios
    {
        int InsertarActs(Dominio.Dtos.actsDTO dto);
        bool ActualizarActs(Dominio.Dtos.actsDTO dto);
        bool EliminarActs(int id);
        Dominio.Dtos.actsDTO BuscarActs(int id);
        List<Dominio.Dtos.actsDTO> ListarActs(string param);
    }
}
