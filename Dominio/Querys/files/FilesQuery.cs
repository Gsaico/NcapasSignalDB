using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
   public partial class Querys : files.IFilesQuery 
    {
        public int InsertarFiles(Dtos.filesDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.files.Add(entity);
                    modelo.SaveChanges();
                    return entity.id_file ;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarFiles(Dtos.filesDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.files.Where(q => q.id_file  == dto.id_file).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.filesCONVERTIDOR.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
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
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.files x = modelo.files.Where(q => q.id_file == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.files .Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.filesDTO BuscarFiles(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.files.Where(q => q.id_file == id).Select(q => q).FirstOrDefault();
                    if (entity == null) return null;
                    return Dominio.Convertidores.filesCONVERTIDOR.ToDTO(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.filesDTO> ListarFiles(string param)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.files.Where(q => q.name_file .Contains(param)).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.filesCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
