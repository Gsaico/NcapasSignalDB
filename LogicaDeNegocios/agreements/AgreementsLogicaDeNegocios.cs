using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : agreements.IAgreementsLogicaDeNegocios
    {
        Dominio.Querys.agreements.IAgreementsQuery agreementsQuerys = new Dominio.Querys.Querys();


        public int InsertarAgreements(Dominio.Dtos.agreementsDTO dto)
        {
            try
            {
                return agreementsQuerys.InsertarAgreements(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarAgreements(Dominio.Dtos.agreementsDTO dto)
        {
            try
            {
                return agreementsQuerys.ActualizarAgreements(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarAgreements(int id)
        {
            try
            {
                return agreementsQuerys.EliminarAgreements(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.agreementsDTO BuscarAgreements(int id)
        {
            try
            {
                return agreementsQuerys.BuscarAgreements(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.agreementsDTO> ListarAgreements(string param)
        {
            try
            {
                return agreementsQuerys.ListarAgreements(param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
