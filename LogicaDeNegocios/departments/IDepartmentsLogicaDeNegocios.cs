using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace LogicaDeNegocios.departments
{
    public interface IDepartmentsLogicaDeNegocios
    {
        int InsertarDepartments(Dominio.Dtos.departmentsDTO dto);
        bool ActualizarDepartments(Dominio.Dtos.departmentsDTO dto);
        bool EliminarDepartments(int id);
        Dominio.Dtos.departmentsDTO BuscarDepartments(int id);
        List<Dominio.Dtos.departmentsDTO> ListarDepartments(string param);
    }
}
