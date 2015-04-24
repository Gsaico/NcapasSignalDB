using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.departments
{
    public partial class ServiceWCF_SignalDB : Servicios.departments.IDepartmentsService
    {
        LogicaDeNegocios.departments.IDepartmentsLogicaDeNegocios departmentsLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public int InsertarDepartments(Dominio.Dtos.departmentsDTO dto)
        {
            try
            {
                return departmentsLogicaNegocio.InsertarDepartments(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarDepartments(Dominio.Dtos.departmentsDTO dto)
        {
            try
            {
                return departmentsLogicaNegocio.ActualizarDepartments(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarDepartments(int id)
        {
            try
            {
                return departmentsLogicaNegocio.EliminarDepartments(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public Dominio.Dtos.departmentsDTO BuscarDepartments(int id)
        {
            try
            {
                return departmentsLogicaNegocio.BuscarDepartments(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.departmentsDTO> ListarDepartments(string param)
        {
            try
            {
                return departmentsLogicaNegocio.ListarDepartments(param);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}