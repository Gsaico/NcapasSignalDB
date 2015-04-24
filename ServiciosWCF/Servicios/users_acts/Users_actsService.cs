using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.users_acts
{
    public partial class ServiceWCF_SignalDB : Servicios.users_acts.IUsers_actsService
    {
        LogicaDeNegocios.users_acts.IUsers_actsLogicaDeNegocios users_actsLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public bool InsertarUsers_acts(Dominio.Dtos.users_actsDTO dto)
        {
            try
            {
                return users_actsLogicaNegocio.InsertarUsers_acts(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarUsers_acts(Dominio.Dtos.users_actsDTO dto)
        {
            try
            {
                return users_actsLogicaNegocio.ActualizarUsers_acts(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarUsers_acts(int id)
        {
            try
            {
                return users_actsLogicaNegocio.EliminarUsers_acts(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDACT(int id)
        {
            try
            {
                return users_actsLogicaNegocio.BuscarUsers_acts_IDACT(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDUSER(string id)
        {
            try
            {
                return users_actsLogicaNegocio.BuscarUsers_acts_IDUSER(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}