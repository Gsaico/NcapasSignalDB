using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class ServiceWCF_SignalDB : Servicios.users.IUsersService
    {
        LogicaDeNegocios.users.IUsersLogicaDeNegocios UsersLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();
              
        public string InsertarUsers(Dominio.Dtos.usersDTO dto)
        {
            try
            {
                return UsersLogicaNegocio.InsertarUsers(dto);
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException();
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
               // throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);    
            }
        }

        public bool ActualizarUsers(Dominio.Dtos.usersDTO dto)
        {
            try
            {
                return UsersLogicaNegocio.ActualizarUsers (dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarUsers(string id)
        {
            try
            {
                return UsersLogicaNegocio.EliminarUsers (id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public Dominio.Dtos.usersDTO BuscarUsers(string id)
        {
            try
            {
                return UsersLogicaNegocio.BuscarUsers (id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.usersDTO> ListarUsers(string param)
        {
            try
            {
                return UsersLogicaNegocio.ListarUsers (param);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }


        public List<Dominio.Dtos.usersDTO> ListarTodosLosUsers()
        {
            try
            {
                return UsersLogicaNegocio.ListarTodosLosUsers();
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}