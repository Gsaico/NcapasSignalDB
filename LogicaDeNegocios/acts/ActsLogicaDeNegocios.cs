using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : acts.IActsLogicaDeNegocios
    {
        Dominio.Querys.acts.IActsQuery actsQuerys = new Dominio.Querys.Querys();

        public int InsertarActs(Dominio.Dtos.actsDTO dto)
        {
            try
            {
                return actsQuerys.InsertarActs(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarActs(Dominio.Dtos.actsDTO dto)
        {
            try
            {
                return actsQuerys.ActualizarActs(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarActs(int id)
        {
            try
            {
                return actsQuerys.EliminarActs(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.actsDTO BuscarActs(int id)
        {
            try
            {
                return actsQuerys.BuscarActs(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.actsDTO> ListarActs(string param)
        {
            try
            {
                return actsQuerys.ListarActs(param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
