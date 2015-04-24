using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.files
{
    public interface IFilesQuery
    {
        int InsertarFiles(Dtos.filesDTO dto);
        bool ActualizarFiles(Dtos.filesDTO dto);
        bool EliminarFiles(int id);
        Dtos.filesDTO BuscarFiles(int id);
        List<Dtos.filesDTO> ListarFiles(string param);
        
    }
}
