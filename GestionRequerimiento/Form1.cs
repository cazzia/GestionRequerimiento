using System;
using System.Linq;
using System.Windows.Forms;
using AccesoDatos;
using Capa_Interface;
using Capa_Interface.Peticion;
using Logica_Negocio;

namespace GestionRequerimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GestionRequerimientoEntities1 db = new GestionRequerimientoEntities1();

            cboUsuarioCreacion.DataSource = db.Usuarios.ToList();
            cboUsuarioCreacion.ValueMember = "Id";
            cboUsuarioCreacion.DisplayMember = "Nombres";


            cboUsuarioResponsable.DataSource = db.Usuarios.ToList();
            cboUsuarioResponsable.ValueMember = "Id";
            cboUsuarioResponsable.DisplayMember = "Nombres";

            cboEstado.DataSource = db.Estados.ToList();
            cboEstado.ValueMember = "Id";
            cboEstado.DisplayMember = "Nombre";

            cboSeveridad.DataSource = db.Severidad.ToList();
            cboSeveridad.ValueMember = "Id";
            cboSeveridad.DisplayMember = "Nombre";

            cboCategoria.DataSource = db.Categoria.ToList();
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {


                GestionRequerimientoEntities1 db = new GestionRequerimientoEntities1();
                Requerimiento requerimiento = new Requerimiento();
                IRequerimiento gestionRequerimiento = new GestionRequerimientoImplementacion();
                RegitroCreado nuevoRegistro = new RegitroCreado();
                String nombre = txtNombre.Text;
                String descripcion = txtDescripcion.Text;
                int usuarioCreacion = int.Parse(cboUsuarioCreacion.SelectedValue.ToString());
                int usuarioResponsable = int.Parse(cboUsuarioResponsable.SelectedValue.ToString());
                int estado = int.Parse(cboEstado.SelectedValue.ToString());
                int severidad = int.Parse(cboSeveridad.SelectedValue.ToString());
                int categoria = int.Parse(cboCategoria.SelectedValue.ToString());
                DateTime fechaCreacion = dtpFechaCreacion.Value;
                DateTime fechaSolucion = dtpFechaSolucion.Value;

                nuevoRegistro.NombreRequerimiento = nombre;
                nuevoRegistro.Descripcion = descripcion;
                nuevoRegistro.UsuarioCreacion = usuarioCreacion;
                nuevoRegistro.FechaCreacion = fechaCreacion;
                nuevoRegistro.UsuarioResponsable = usuarioResponsable;
                nuevoRegistro.Estado = estado;
                nuevoRegistro.FechaSolucion = fechaSolucion;
                nuevoRegistro.Severidad = severidad;
                nuevoRegistro.Categoria = categoria;

                gestionRequerimiento.CrearRequerimiento(nuevoRegistro);

                MessageBox.Show("El requerimiento se guardo correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR : ");
            }
            
        }

        private void _btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                IRequerimiento gestionRequerimiento = new GestionRequerimientoImplementacion();
                RegistroActualizado registroActualizado = new RegistroActualizado();

                int id = int.Parse(txtId.Text);
                String descripcion = txtDescripcion.Text;
                int usuarioCreacion = int.Parse(cboUsuarioCreacion.SelectedValue.ToString());
                int usuarioResponsable = int.Parse(cboUsuarioResponsable.SelectedValue.ToString());
                int estado = int.Parse(cboEstado.SelectedValue.ToString());
                int severidad = int.Parse(cboSeveridad.SelectedValue.ToString());
                int categoria = int.Parse(cboCategoria.SelectedValue.ToString());
                
                DateTime fechaSolucion = dtpFechaSolucion.Value;

                registroActualizado.Id = id;
                registroActualizado.Descripcion = descripcion;
                registroActualizado.UsuarioCreacion = usuarioResponsable;
                registroActualizado.UsuarioResponsable = usuarioResponsable;
                registroActualizado.Estado = estado;
                registroActualizado.FechaSolucion = fechaSolucion;
                registroActualizado.Severidad = severidad;
                registroActualizado.Categoria = categoria;

                gestionRequerimiento.ActualizarRequerimiento(registroActualizado);
                
                ////db.Requerimiento.Add(requerimiento);
                //db.SaveChanges();

                MessageBox.Show("El requerimiento se guardo correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR : ");
            }
        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            new ListadoRequerimientos().Show();
        }
    }
    }

