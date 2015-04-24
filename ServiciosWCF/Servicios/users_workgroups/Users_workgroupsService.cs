using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.users_workgroups
{
    public partial class ServiceWCF_SignalDB : Servicios.users_workgroups.IUsers_workgroupsService
    {
        LogicaDeNegocios.users_workgroups.IUsers_workgroupsLogicaDeNegocios users_workgroupsLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public bool InsertarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto)
        {
            try
            {
                return users_workgroupsLogicaNegocio.InsertarUsers_workgroups(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarUsers_workgroups(Dominio.Dtos.users_workgroupsDTO dto)
        {
            try
            {
                return users_workgroupsLogicaNegocio.ActualizarUsers_workgroups(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarUsers_workgroups(int id)
        {
            try
            {
                return users_workgroupsLogicaNegocio.EliminarUsers_workgroups(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDWORKGROUP(int id)
        {
            try
            {
                return users_workgroupsLogicaNegocio.BuscarUsers_workgroups_IDWORKGROUP(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDUSER(string id)
        {
            try
            {
                return users_workgroupsLogicaNegocio.BuscarUsers_workgroups_IDUSER(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}