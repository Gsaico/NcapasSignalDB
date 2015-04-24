using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : workgroups.IWorkgroupsLogicaDeNegocios
    {
        Dominio.Querys.workgroups.IWorkgroupsQuery workgroupsQuerys = new Dominio.Querys.Querys();

        public int InsertarWorkgroups(Dominio.Dtos.workgroupsDTO dto)
        {
            try
            {
                return workgroupsQuerys.InsertarWorkgroups(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarWorkgroups(Dominio.Dtos.workgroupsDTO dto)
        {
            try
            {
                return workgroupsQuerys.ActualizarWorkgroups(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarWorkgroups(int id)
        {
            try
            {
                return workgroupsQuerys.EliminarWorkgroups(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.workgroupsDTO BuscarWorkgroups(int id)
        {
            try
            {
                return workgroupsQuerys.BuscarWorkgroups(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.workgroupsDTO> ListarWorkgroups(string param)
        {
            try
            {
                return workgroupsQuerys.ListarWorkgroups(param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.workgroupsDTO> ListarTodosLosWorkgroup_Activos()
        {
            try
            {
                return workgroupsQuerys.ListarTodosLosWorkgroup_Activos();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
