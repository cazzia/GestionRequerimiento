using Capa_Interface.Peticion;
using Capa_Interface.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Interface
{
     public interface IRequerimiento
    {

        RequerimietoRegistradoDb CrearRequerimiento(RegitroCreado nuevoRequerimiento);
        List<RequerimietoRegistradoDb> ListarTodosRequerimiento();
        RequerimietoRegistradoDb ActualizarRequerimiento(RegistroActualizado registroActualizado);
        bool EliminarRequerimiento(int Id);

    }
}
