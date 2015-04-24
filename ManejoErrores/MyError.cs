using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ManejoErrores
{   [DataContract()]
    public class MyError
    {

    private string _mensaje;
    private string _tipo;

    public MyError(string mensaje, string tipo)
    {
        _mensaje = mensaje;
        _tipo = tipo;
    
    }
    [DataMember]
    public string Mensaje
    {
        get { return _mensaje; }
        set { _mensaje = value; }
    }
    [DataMember]
    public string Tipo
    {
        get { return _tipo; }
        set { _tipo = value; }
    }

    }
}
