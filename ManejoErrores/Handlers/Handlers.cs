using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ManejoErrores.Handlers
{
    public static class Handlers
    {
        public static Exception ErrorServicios(Exception ex)
        {
            var errlog = new MyError(ex.Message, "Critico" );
            var faultException = new FaultException<MyError>(errlog, new FaultReason(ex.ToString()));

            throw faultException;
        }
    }
}
