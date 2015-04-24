using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoErrores.Handlers
{
    public sealed class Helper
    {
        public static bool IsDateTime(object expression)
        {
            try
            {
                var dt = DateTime.Parse(expression.ToString());
                return true;
            }
            catch(FormatException)
            {
            return false;
            }
        
        }

    }
}
