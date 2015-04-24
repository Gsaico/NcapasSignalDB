using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : acts_files.IActs_filesLogicaDeNegocios
    {
        Dominio.Querys.acts_files.IActs_filesQuery acts_filesQuerys = new Dominio.Querys.Querys();

        public bool InsertarActs_files(Dominio.Dtos.acts_filesDTO dto)
        {
            try
            {
                return acts_filesQuerys.InsertarActs_files(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarActs_files(Dominio.Dtos.acts_filesDTO dto)
        {
            try
            {
                return acts_filesQuerys.ActualizarActs_files(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarActs_files(int id)
        {
            try
            {
                return acts_filesQuerys.EliminarActs_files(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.acts_filesDTO> BuscarActsfiles_IDACT(int id)
        {
            try
            {
                return acts_filesQuerys.BuscarActsfiles_IDACT(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.acts_filesDTO> BuscarUsers_acts_IDUSER(int id)
        {
            try
            {
                return acts_filesQuerys.BuscarUsers_acts_IDUSER(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
