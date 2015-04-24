using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
    public partial class Querys :users_workgroups.IUsers_workgroupsQuery  
    {
        public bool InsertarUsers_workgroups(Dtos.users_workgroupsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.users_workgroups.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsers_workgroups(Dtos.users_workgroupsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.users_workgroups.Where(q => q.id_workgroup == dto.id_workgroup).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.users_workgroupsCONVERTIDOR.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsers_workgroups(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.users_workgroups x = modelo.users_workgroups.Where(q => q.id_workgroup == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.users_workgroups.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDWORKGROUP(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.users_workgroups.Where(q => q.id_workgroup  == id).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.users_workgroupsCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.users_workgroupsDTO> BuscarUsers_workgroups_IDUSER(string id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.users_workgroups.Where(q => q.id_user == id).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.users_workgroupsCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
