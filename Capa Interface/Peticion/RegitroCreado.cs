using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Interface.Peticion
{
    public class RegitroCreado
    {

        public String NombreRequerimiento { get; set; }
        public String Descripcion { get; set; }
        public int UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioResponsable { get; set; }
        public int Estado { get; set; }
        public DateTime FechaSolucion { get; set; }
        public int Severidad { get; set; }
        public int Categoria { get; set; }


        public RegitroCreado()
        {
            FechaCreacion = DateTime.Now;

        }



    }
}
