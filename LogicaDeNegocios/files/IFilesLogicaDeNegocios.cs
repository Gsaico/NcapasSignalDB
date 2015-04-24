using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.files
{
    public interface IFilesLogicaDeNegocios
    {
        int InsertarFiles(Dominio.Dtos.filesDTO dto);
        bool ActualizarFiles(Dominio.Dtos.filesDTO dto);
        bool EliminarFiles(int id);
        Dominio.Dtos.filesDTO BuscarFiles(int id);
        List<Dominio.Dtos.filesDTO> ListarFiles(string param);
        
    }
}
