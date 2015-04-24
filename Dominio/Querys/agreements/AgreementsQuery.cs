using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
    public partial class Querys : agreements.IAgreementsQuery
    {
        public int InsertarAgreements(Dtos.agreementsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.agreements.Add(entity);
                    modelo.SaveChanges();
                    return entity.id_act;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarAgreements(Dtos.agreementsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.agreements.Where(q => q.id_act == dto.id_act).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.agreementsCONVERTIDOR.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarAgreements(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.agreements x = modelo.agreements.Where(q => q.id_act == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.agreements.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.agreementsDTO BuscarAgreements(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.agreements.Where(q => q.id_act == id).Select(q => q).FirstOrDefault();
                    if (entity == null) return null;
                    return Dominio.Convertidores.agreementsCONVERTIDOR.ToDTO(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.agreementsDTO> ListarAgreements(string param)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.agreements.Where(q => q.name.Contains(param)).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.agreementsCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
