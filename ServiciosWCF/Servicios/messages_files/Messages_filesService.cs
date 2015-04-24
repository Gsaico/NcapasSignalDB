using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.messages_files
{
    public partial class ServiceWCF_SignalDB : Servicios.messages_files.IMessages_filesService
    {
        LogicaDeNegocios.messages_files.IMessages_filesLogicaDeNegocios messages_filesLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public bool InsertarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto)
        {
            try
            {
                return messages_filesLogicaNegocio.InsertarMessages_filesDTO(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto)
        {
            try
            {
                return messages_filesLogicaNegocio.ActualizarMessages_filesDTO(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarMessages_filesDTO(int id)
        {
            try
            {
                return messages_filesLogicaNegocio.EliminarMessages_filesDTO(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDMESSAGES(int id)
        {
            try
            {
                return messages_filesLogicaNegocio.BuscarMessages_filesDTO_IDMESSAGES(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDFILE(int id)
        {
            try
            {
                return messages_filesLogicaNegocio.BuscarMessages_filesDTO_IDFILE(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}