using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.messages
{
    public partial class ServiceWCF_SignalDB : Servicios.messages.IMessagesService
    {
        LogicaDeNegocios.messages.IMessagesLogicaDeNegocios messagesLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public int InsertarMessages(Dominio.Dtos.messagesDTO dto)
        {
            try
            {
                return messagesLogicaNegocio.InsertarMessages(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarMessages(Dominio.Dtos.messagesDTO dto)
        {
            try
            {
                return messagesLogicaNegocio.ActualizarMessages(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarMessages(int id)
        {
            try
            {
                return messagesLogicaNegocio.EliminarMessages(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public Dominio.Dtos.messagesDTO BuscarMessages(int id)
        {
            try
            {
                return messagesLogicaNegocio.BuscarMessages(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.messagesDTO> ListarMessages(string param)
        {
            try
            {
                return messagesLogicaNegocio.ListarMessages(param);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}