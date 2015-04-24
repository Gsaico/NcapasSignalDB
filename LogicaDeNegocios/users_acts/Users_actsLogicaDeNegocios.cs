using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : users_acts.IUsers_actsLogicaDeNegocios
    {
        Dominio.Querys.users_acts.IUsers_actsQuery users_actsQuerys = new Dominio.Querys.Querys();


        public bool InsertarUsers_acts(Dominio.Dtos.users_actsDTO dto)
        {
            try
            {
                return users_actsQuerys.InsertarUsers_acts(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsers_acts(Dominio.Dtos.users_actsDTO dto)
        {
            try
            {
                return users_actsQuerys.ActualizarUsers_acts(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsers_acts(int id)
        {
            try
            {
                return users_actsQuerys.EliminarUsers_acts(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDACT(int id)
        {
            try
            {
                return users_actsQuerys.BuscarUsers_acts_IDACT(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.users_actsDTO> BuscarUsers_acts_IDUSER(string id)
        {
            try
            {
                return users_actsQuerys.BuscarUsers_acts_IDUSER(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
