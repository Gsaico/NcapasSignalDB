using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class ServiceWCF_SignalDB : Servicios.acts.IActsService
    {
        LogicaDeNegocios.acts.IActsLogicaDeNegocios  ActsLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public int InsertarActs(Dominio.Dtos.actsDTO dto)
        {
            try
            {
                return ActsLogicaNegocio.InsertarActs(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarActs(Dominio.Dtos.actsDTO dto)
        {
            try
            {
                return ActsLogicaNegocio.ActualizarActs(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarActs(int id)
        {
            try
            {
                return ActsLogicaNegocio.EliminarActs(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public Dominio.Dtos.actsDTO BuscarActs(int id)
        {
            try
            {
                return ActsLogicaNegocio.BuscarActs(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.actsDTO> ListarActs(string param)
        {
            try
            {
                return ActsLogicaNegocio.ListarActs(param);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}