using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosWCF.Servicios.acts_files
{
    [ServiceContract]
    public interface IActs_filesService
    {
        [OperationContract]
        bool InsertarActs_files(Dominio.Dtos.acts_filesDTO dto);
        [OperationContract]
        bool ActualizarActs_files(Dominio.Dtos.acts_filesDTO dto);
        [OperationContract]
        bool EliminarActs_files(int id);
        [OperationContract]
        List<Dominio.Dtos.acts_filesDTO> BuscarActsfiles_IDACT(int id);
        [OperationContract]
        List<Dominio.Dtos.acts_filesDTO> BuscarUsers_acts_IDUSER(int id);
    }
}
