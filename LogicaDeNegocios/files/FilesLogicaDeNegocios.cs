using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocios
{
    public partial class LogicaDeNegocios_SignalDB : files.IFilesLogicaDeNegocios
    {
        Dominio.Querys.files.IFilesQuery filesQuerys = new Dominio.Querys.Querys();


        public int InsertarFiles(Dominio.Dtos.filesDTO dto)
        {
            try
            {
                return filesQuerys.InsertarFiles(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarFiles(Dominio.Dtos.filesDTO dto)
        {
            try
            {
                return filesQuerys.ActualizarFiles(dto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarFiles(int id)
        {
            try
            {
                return filesQuerys.EliminarFiles(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dominio.Dtos.filesDTO BuscarFiles(int id)
        {
            try
            {
                return filesQuerys.BuscarFiles(id);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dominio.Dtos.filesDTO> ListarFiles(string param)
        {
            try
            {
                return filesQuerys.ListarFiles(param);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
