using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
//using PersistenciaDatos;

namespace Dominio.Querys.acts_files
{
    public interface IActs_filesQuery
    {


        bool InsertarActs_files(Dtos.acts_filesDTO dto);
        bool ActualizarActs_files(Dtos.acts_filesDTO dto);
        bool EliminarActs_files(int id);
        List<Dtos.acts_filesDTO> BuscarActsfiles_IDACTS(int id);
    }
}
