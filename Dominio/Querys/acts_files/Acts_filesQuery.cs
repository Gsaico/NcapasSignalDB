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

        public bool InsertarActs_files(Dtos.acts_filesDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities ())
                {
                    var entity = dto.ToEntity();
                    modelo.acts_files.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarActs_files(Dtos.acts_filesDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities ())
                {
                    var w = modelo.acts_files.Where(q => q.id_acts_files  == dto.id_acts_files ).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.acts_filesCONVERTIDOR.Actualizar (dto, w);
                    modelo.SaveChanges();
                    return true;
                }
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
                using (var modelo = new PersistenciaDatos.SignalDBEntities ())
                {
                    PersistenciaDatos.acts_files x = modelo.acts_files.Where(q => q.id_acts_files  == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.acts_files.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }


        public List<Dtos.acts_filesDTO> BuscarActsfiles_IDACTS(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.acts_files.Where(q => q.id_act == id).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.acts_filesCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
       
    }
}
