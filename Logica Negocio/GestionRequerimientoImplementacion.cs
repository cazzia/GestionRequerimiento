using Capa_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Interface.Peticion;
using Capa_Interface.Respuesta;
using AccesoDatos;

namespace Logica_Negocio
{
    public class GestionRequerimientoImplementacion : IRequerimiento
    {


        public RequerimietoRegistradoDb ActualizarRequerimiento(RegistroActualizado registroActualizado)
        {
            using (GestionRequerimientoEntities1 gestonRequerimiento = new GestionRequerimientoEntities1())
            {
                Requerimiento requerimiento = new Requerimiento();
                RequerimietoRegistradoDb requerimientoRegistrado = new RequerimietoRegistradoDb();
                requerimiento.Id = registroActualizado.Id;
                requerimientoRegistrado.Descripcion = registroActualizado.Descripcion;
                requerimientoRegistrado.UsuarioCreacion = registroActualizado.UsuarioCreacion;
                requerimientoRegistrado.UsuarioResponsable = registroActualizado.UsuarioResponsable;
                requerimientoRegistrado.Estado = registroActualizado.Estado;

                requerimientoRegistrado.FechaSolucion = registroActualizado.FechaSolucion;
                requerimientoRegistrado.Severidad = registroActualizado.Severidad;
                requerimientoRegistrado.Categoria = registroActualizado.Categoria;


                gestonRequerimiento.Requerimiento.Add(requerimiento);
                gestonRequerimiento.SaveChanges();

                return requerimientoRegistrado;


            }




            throw new NotImplementedException();
        }

        public RequerimietoRegistradoDb CrearRequerimiento(RegitroCreado nuevoRequerimiento)
        {
            using (GestionRequerimientoEntities1 gestonRequerimiento = new GestionRequerimientoEntities1())
            {
                Requerimiento requerimiento = new Requerimiento();
                RequerimietoRegistradoDb requerimientoRegistrado = new RequerimietoRegistradoDb();

                requerimiento.NombreRequerimiento = nuevoRequerimiento.NombreRequerimiento;
                requerimiento.Descripcion = nuevoRequerimiento.Descripcion;
                requerimiento.UsuarioCreacion = nuevoRequerimiento.UsuarioCreacion;
                requerimiento.FechaCreacion = nuevoRequerimiento.FechaCreacion;
                requerimiento.UsuarioResponsable = nuevoRequerimiento.UsuarioResponsable;

                requerimiento.Estado = nuevoRequerimiento.Estado;
                requerimiento.FechaSolucion = nuevoRequerimiento.FechaSolucion;
                requerimiento.Severidad = nuevoRequerimiento.Severidad;
                requerimiento.Categoria = nuevoRequerimiento.Categoria;

                gestonRequerimiento.Requerimiento.Add(requerimiento);
                gestonRequerimiento.SaveChanges();

                return requerimientoRegistrado;
            }




        }

        public bool EliminarRequerimiento(int Id)
        {
            throw new NotImplementedException();
        }

        public List<RequerimietoRegistradoDb> ListarTodosRequerimiento()
        {
            using (GestionRequerimientoEntities1 context = new GestionRequerimientoEntities1())
            {
                IQueryable<Requerimiento> productsQuery = from Requerimiento in context.Requerimiento
                                                          select Requerimiento;
                return productsQuery.ToList().Select(ConvertirRequerimiento).ToList();
            }
        }

        private RequerimietoRegistradoDb ConvertirRequerimiento(Requerimiento requerimiento)
        {
            RequerimietoRegistradoDb requerimientoRegistrado = new RequerimietoRegistradoDb();
            requerimientoRegistrado.Id = requerimiento.Id;
            requerimientoRegistrado.NombreRequerimiento = requerimiento.NombreRequerimiento;
            requerimientoRegistrado.Descripcion = requerimiento.Descripcion;
            requerimientoRegistrado.UsuarioCreacion = requerimiento.UsuarioCreacion;
            requerimientoRegistrado.FechaCreacion = requerimiento.FechaCreacion.Value;
            requerimientoRegistrado.UsuarioResponsable = requerimiento.UsuarioResponsable.Value;
            requerimientoRegistrado.Estado = requerimiento.Estado.Value;
            requerimientoRegistrado.FechaSolucion = requerimiento.FechaSolucion.Value;
            requerimientoRegistrado.Severidad = requerimiento.Severidad.Value;
            requerimientoRegistrado.Categoria = requerimiento.Categoria.Value;
            return requerimientoRegistrado;
        }

    }
}
