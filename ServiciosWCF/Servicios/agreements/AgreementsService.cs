using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF
{
    public partial class ServiceWCF_SignalDB : Servicios.agreements.IAgreementsService 
    {
        LogicaDeNegocios.agreements.IAgreementsLogicaDeNegocios agreementsLogicaNegocio = new LogicaDeNegocios.LogicaDeNegocios_SignalDB();

        public int InsertarAgreements(Dominio.Dtos.agreementsDTO dto)
        {
            try
            {
                return agreementsLogicaNegocio.InsertarAgreements(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool ActualizarAgreements(Dominio.Dtos.agreementsDTO dto)
        {
            try
            {
                return agreementsLogicaNegocio.ActualizarAgreements(dto);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public bool EliminarAgreements(int id)
        {
            try
            {
                return agreementsLogicaNegocio.EliminarAgreements(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public Dominio.Dtos.agreementsDTO BuscarAgreements(int id)
        {
            try
            {
                return agreementsLogicaNegocio.BuscarAgreements(id);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }

        public List<Dominio.Dtos.agreementsDTO> ListarAgreements(string param)
        {
            try
            {
                return agreementsLogicaNegocio.ListarAgreements(param);
            }
            catch (Exception ex)
            {
                throw ManejoErrores.Handlers.Handlers.ErrorServicios(ex);
            }
        }
    }
}