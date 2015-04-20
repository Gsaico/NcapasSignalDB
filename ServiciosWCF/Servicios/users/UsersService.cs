﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosWCF.Servicios.users
{
    public partial class ServiceWCF_SignakDB : IUsersService
    {
        LogicaDeNegocios.users.IUsersLogicaDeNegocios UsersLogicaNegocio = new LogicaDeNegocios.users.LogicaDeNegocios_SignalDB();

              
        public string InsertarUsers(Dominio.Dtos.usersDTO dto)
        {
            try
            {
                return UsersLogicaNegocio.InsertarUsers(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsers(Dominio.Dtos.usersDTO dto)
        {
            try
            {
                return UsersLogicaNegocio.ActualizarUsers (dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsers(string id)
        {
            try
            {
                return UsersLogicaNegocio.EliminarUsers (id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.usersDTO BuscarUsers(string id)
        {
            try
            {
                return UsersLogicaNegocio.BuscarUsers (id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dominio.Dtos.usersDTO> ListarUsers(string param)
        {
            try
            {
                return UsersLogicaNegocio.ListarUsers (param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}