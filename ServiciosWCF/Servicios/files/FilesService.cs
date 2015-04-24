using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.files
{
    public partial class ServiceWCF_SignalDB : Servicios.files.IFilesService 
    {
        LogicaDeNegocios.files.IFilesLogicaDeNegocios filesLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public int InsertarFiles(Dominio.Dtos.filesDTO dto)
        {
            try
            {
                return filesLogicaNegocio.InsertarFiles(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarFiles(Dominio.Dtos.filesDTO dto)
        {
            try
            {
                return filesLogicaNegocio.ActualizarFiles(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarFiles(int id)
        {
            try
            {
                return filesLogicaNegocio.EliminarFiles(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public Dominio.Dtos.filesDTO BuscarFiles(int id)
        {
            try
            {
                return filesLogicaNegocio.BuscarFiles(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.filesDTO> ListarFiles(string param)
        {
            try
            {
                return filesLogicaNegocio.ListarFiles(param);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}