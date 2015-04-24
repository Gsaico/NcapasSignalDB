using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//PersistenciaDatos para acceder a DTOS
using PersistenciaDatos;
namespace Dominio.Querys.departments
{
    public interface IDepartmentsQuery
    {
        int InsertarDepartments(Dtos.departmentsDTO dto);
        bool ActualizarDepartments(Dtos.departmentsDTO dto);
        bool EliminarDepartments(int id);
        Dtos.departmentsDTO BuscarDepartments(int id);
        List<Dtos.departmentsDTO> ListarDepartments(string param);
      
    }
}
