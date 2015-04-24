using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : messages.IMessagesLogicaDeNegocios 
    {
        Dominio.Querys.messages.IMessagesQuery messagesQuerys = new Dominio.Querys.Querys();


        public int InsertarMessages(Dominio.Dtos.messagesDTO dto)
        {
            try
            {
                return messagesQuerys.InsertarMessages(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarMessages(Dominio.Dtos.messagesDTO dto)
        {
            try
            {
                return messagesQuerys.ActualizarMessages(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarMessages(int id)
        {
            try
            {
                return messagesQuerys.EliminarMessages(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.messagesDTO BuscarMessages(int id)
        {
            try
            {
                return messagesQuerys.BuscarMessages(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.messagesDTO> ListarMessages(string param)
        {
            try
            {
                return messagesQuerys.ListarMessages(param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
