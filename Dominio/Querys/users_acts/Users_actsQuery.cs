using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
    public partial class Querys : users_acts.IUsers_actsQuery 
    {
        public bool InsertarUsers_acts(Dtos.users_actsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.users_acts.Add(entity);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarUsers_acts(Dtos.users_actsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.users_acts.Where(q => q.id_user_act  == dto.id_user_act ).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.users_actsCONVERTIDOR.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarUsers_acts(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.users_acts x = modelo.users_acts.Where(q => q.id_user_act  == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.users_acts.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.users_actsDTO> BuscarUsers_acts_IDACT(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.users_acts.Where(q => q.id_act == id).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.users_actsCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        List<Dtos.users_actsDTO> users_acts.IUsers_actsQuery.BuscarUsers_acts_IDUSER(string id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.users_acts.Where(q => q.id_user == id).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.users_actsCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
