using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : departments.IDepartmentsLogicaDeNegocios
    {
        Dominio.Querys.departments.IDepartmentsQuery departmentsQuerys = new Dominio.Querys.Querys();


        public int InsertarDepartments(Dominio.Dtos.departmentsDTO dto)
        {
            try
            {
                return departmentsQuerys.InsertarDepartments(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarDepartments(Dominio.Dtos.departmentsDTO dto)
        {
            try
            {
                return departmentsQuerys.ActualizarDepartments(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarDepartments(int id)
        {
            try
            {
                return departmentsQuerys.EliminarDepartments(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.departmentsDTO BuscarDepartments(int id)
        {
            try
            {
                return departmentsQuerys.BuscarDepartments(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.departmentsDTO> ListarDepartments(string param)
        {
            try
            {
                return departmentsQuerys.ListarDepartments(param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
