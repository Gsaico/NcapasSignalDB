using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add
using Dominio.Convertidores; 

namespace Dominio.Querys
{
    public partial class Querys : departments.IDepartmentsQuery 
    {
        public int InsertarDepartments(Dtos.departmentsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = dto.ToEntity();
                    modelo.departments.Add(entity);
                    modelo.SaveChanges();
                    return entity.id_department;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool ActualizarDepartments(Dtos.departmentsDTO dto)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var w = modelo.departments.Where(q => q.id_department  == dto.id_department ).Select(q => q).FirstOrDefault();
                    if (w == null) return false;
                    Dominio.Convertidores.departmentsCONVERTIDOR.Actualizar(dto, w);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public bool EliminarDepartments(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    PersistenciaDatos.departments x = modelo.departments.Where(q => q.id_department  == id).Select(q => q).FirstOrDefault();
                    if (x == null) return false;
                    modelo.departments.Remove(x);
                    modelo.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Dtos.departmentsDTO BuscarDepartments(int id)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.departments.Where(q => q.id_department  == id).Select(q => q).FirstOrDefault();
                    if (entity == null) return null;
                    return Dominio.Convertidores.departmentsCONVERTIDOR.ToDTO(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            };
        }

        public List<Dtos.departmentsDTO> ListarDepartments(string param)
        {
            try
            {
                using (var modelo = new PersistenciaDatos.SignalDBEntities())
                {
                    var entity = modelo.departments.Where(q => q.name.Contains(param)).Select(q => q).ToList();
                    if (entity == null) return null;
                    return Dominio.Convertidores.departmentsCONVERTIDOR.ToDTOs(entity);
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
