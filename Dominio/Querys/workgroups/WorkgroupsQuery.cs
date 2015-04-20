using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
    public partial class Querys : workgroups.IWorkgroupsQuery 
    {
        public int InsertarWorkgroups(Dtos.workgroupsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.workgroups.Add(entity);
                    modelo.SaveChanges();
                    return entity.id_workgroup ;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarWorkgroups(Dtos.workgroupsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.workgroups.Where(q => q.id_workgroup  == dto.id_workgroup ).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.workgroupsCONVERTIDOR .Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarWorkgroups(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.workgroups x = modelo.workgroups.Where(q => q.id_workgroup  == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.workgroups.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.workgroupsDTO BuscarWorkgroups(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.workgroups.Where(q => q.id_workgroup  == id).Select(q => q).FirstOrDefault();
                    if (entity == null) return null;
                    return Dominio.Convertidores.workgroupsCONVERTIDOR .ToDTO(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.workgroupsDTO> ListarWorkgroups(string param)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.workgroups .Where(q => q.name_workgroup.Contains(param)).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.workgroupsCONVERTIDOR .ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public List<Dtos.workgroupsDTO> ListarTodosLosWorkgroup_Activos()
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.workgroups.Where(q => q.status == 1).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.workgroupsCONVERTIDOR .ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
