using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class ServiceWCF_SignalDB : Servicios.acts_files.IActs_filesService
    {
        LogicaDeNegocios.acts_files.IActs_filesLogicaDeNegocios acts_filesLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();


        public bool InsertarActs_files(Dominio.Dtos.acts_filesDTO dto)
        {
            try
            {
                return acts_filesLogicaNegocio.InsertarActs_files(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarActs_files(Dominio.Dtos.acts_filesDTO dto)
        {
            try
            {
                return acts_filesLogicaNegocio.ActualizarActs_files(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarActs_files(int id)
        {
            try
            {
                return acts_filesLogicaNegocio.EliminarActs_files(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.acts_filesDTO> BuscarActsfiles_IDACT(int id)
        {
            try
            {
                return acts_filesLogicaNegocio.BuscarActsfiles_IDACT(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.acts_filesDTO> BuscarUsers_acts_IDUSER(int id)
        {
            try
            {
                return acts_filesLogicaNegocio.BuscarUsers_acts_IDUSER(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}