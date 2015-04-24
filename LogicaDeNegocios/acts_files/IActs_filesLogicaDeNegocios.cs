using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.acts_files
{
    public interface IActs_filesLogicaDeNegocios
    {
        bool InsertarActs_files(Dominio.Dtos.acts_filesDTO dto);
        bool ActualizarActs_files(Dominio.Dtos.acts_filesDTO dto);
        bool EliminarActs_files(int id);
        List<Dominio.Dtos.acts_filesDTO> BuscarActsfiles_IDACT(int id);
        List<Dominio.Dtos.acts_filesDTO> BuscarUsers_acts_IDUSER(int id);
    }
}
