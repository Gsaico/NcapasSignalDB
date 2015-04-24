using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
    public partial class Querys : messages_files.IMessages_filesQuery   
    {

        public bool InsertarMessages_filesDTO(Dtos.messages_filesDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.messages_files.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarMessages_filesDTO(Dtos.messages_filesDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.messages_files.Where(q => q.id_messages_files == dto.id_messages_files).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.messages_filesCONVERTIDOR.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
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
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.messages_files x = modelo.messages_files.Where(q => q.id_messages_files == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.messages_files.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDMESSAGES(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.messages_files.Where(q => q.id_message  == id).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.messages_filesCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.messages_filesDTO> BuscarMessages_filesDTO_IDFILE(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.messages_files.Where(q => q.id_file == id).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.messages_filesCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
