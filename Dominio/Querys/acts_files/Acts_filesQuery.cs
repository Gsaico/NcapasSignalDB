using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Convertidores;
using System.Data.Entity;

namespace Dominio.Querys.acts_files
{
    public partial class Acts_filesQuery : acts_files.IActs_filesQuery  
    {

        public int InsertarActs_files(Dtos.acts_filesDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities ())
                {
                    var entity = dto.ToEntity();
                    modelo.acts_files.Add(entity);
                    modelo.SaveChanges();
                    return entity.id_acts_files;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarActs_files(Dtos.acts_filesDTO dto)
        {
            throw new NotImplementedException();
        }

        public bool EliminarActs_files(int id)
        {
            throw new NotImplementedException();
        }

        public Dtos.acts_filesDTO BuscarActs_files(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dtos.acts_filesDTO> ListarActs_files(string param)
        {
            throw new NotImplementedException();
        }
    }
}
