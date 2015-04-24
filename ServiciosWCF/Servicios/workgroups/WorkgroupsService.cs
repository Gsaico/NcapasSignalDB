using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.workgroups
{
    public partial class ServiceWCF_SignalDB : Servicios.workgroups.IWorkgroupsService
    {
        LogicaDeNegocios.workgroups.IWorkgroupsLogicaDeNegocios workgroupsLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public int InsertarWorkgroups(Dominio.Dtos.workgroupsDTO dto)
        {
            try
            {
                return workgroupsLogicaNegocio.InsertarWorkgroups(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarWorkgroups(Dominio.Dtos.workgroupsDTO dto)
        {
            try
            {
                return workgroupsLogicaNegocio.ActualizarWorkgroups(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarWorkgroups(int id)
        {
            try
            {
                return workgroupsLogicaNegocio.EliminarWorkgroups(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public Dominio.Dtos.workgroupsDTO BuscarWorkgroups(int id)
        {
            try
            {
                return workgroupsLogicaNegocio.BuscarWorkgroups(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.workgroupsDTO> ListarWorkgroups(string param)
        {
            try
            {
                return workgroupsLogicaNegocio.ListarWorkgroups(param);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.workgroupsDTO> ListarTodosLosWorkgroup_Activos()
        {
            try
            {
                return workgroupsLogicaNegocio.ListarTodosLosWorkgroup_Activos();
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}