//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersistenciaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class departments
    {
        public departments()
        {
            this.users = new HashSet<users>();
        }
    
        public int id_department { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<users> users { get; set; }
    }
}
