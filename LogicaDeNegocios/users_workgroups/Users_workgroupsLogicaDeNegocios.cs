using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : users_workgroups.IUsers_workgroupsLogicaDeNegocios 
    {
        Dominio.Querys.users_workgroups.IUsers_workgroupsQuery users_workgroupsQuerys = new Dominio.Querys.Querys();


        public bool InsertarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto)
        {
            try
            {
                return users_workgroupsQuerys.InsertarUsers_workgroups(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto)
        {
            try
            {
                return users_workgroupsQuerys.ActualizarUsers_workgroups(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsers_workgroups(int id)
        {
            try
            {
                return users_workgroupsQuerys.EliminarUsers_workgroups(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDWORKGROUP(int id)
        {
            try
            {
                return users_workgroupsQuerys.BuscarUsers_workgroups_IDWORKGROUP(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDUSER(string id)
        {
            try
            {
                return users_workgroupsQuerys.BuscarUsers_workgroups_IDUSER(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
