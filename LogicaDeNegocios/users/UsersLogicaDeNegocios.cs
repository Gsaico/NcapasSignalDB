﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : users.IUsersLogicaDeNegocios
    {
        Dominio.Querys.users.IUsersQuery usersQuerys = new Dominio.Querys.Querys();
        public string InsertarUsers(Dominio.Dtos.usersDTO dto)
        {
            try
            {
                return usersQuerys.InsertarUsers(dto);
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
                return usersQuerys.ActualizarUsers(dto);
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
                return usersQuerys.EliminarUsers(id);
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
                return usersQuerys.BuscarUsers(id);
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
                return usersQuerys.ListarUsers(param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }


        public List<Dominio.Dtos.usersDTO> ListarTodosLosUsers()
        {
            try
            {
                return usersQuerys.ListarTodosLosUsers();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
