using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
    public partial class Querys : users.IUsersQuery
    {

        public string InsertarUsers(Dtos.usersDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.users.Add(entity);
                    modelo.SaveChanges();
                    return entity.id_user;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsers(Dtos.usersDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.users.Where(q => q.id_user  == dto.id_user ).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.usersCONVERTIDOR.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsers(string id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.users  x = modelo.users.Where(q => q.id_user  == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.users.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.usersDTO BuscarUsers(string id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.users.Where(q => q.id_user  == id).Select(q => q).FirstOrDefault();
                    if (entity == null) return null;
                    return Dominio.Convertidores.usersCONVERTIDOR.ToDTO(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.usersDTO> ListarUsers(string param)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.users.Where(q => q.fullname .Contains(param)).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.usersCONVERTIDOR .ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }


        public List<Dtos.usersDTO> ListarTodosLosUsers()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.users.ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.usersCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
