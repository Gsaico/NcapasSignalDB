using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : messages_files.IMessages_filesLogicaDeNegocios
    {
        Dominio.Querys.messages_files.IMessages_filesQuery messages_filesQuerys = new Dominio.Querys.Querys();


        public bool InsertarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto)
        {
            try
            {
                return messages_filesQuerys.InsertarMessages_filesDTO(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarMessages_filesDTO(Dominio.Dtos.messages_filesDTO dto)
        {
            try
            {
                return messages_filesQuerys.ActualizarMessages_filesDTO(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarMessages_filesDTO(int id)
        {
            try
            {
                return messages_filesQuerys.EliminarMessages_filesDTO(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDMESSAGES(int id)
        {
            try
            {
                return messages_filesQuerys.BuscarMessages_filesDTO_IDMESSAGES(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDFILE(int id)
        {
            try
            {
                return messages_filesQuerys.BuscarMessages_filesDTO_IDFILE(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
