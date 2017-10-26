using AccesoDatos;
using Capa_Interface.Respuesta;
using Logica_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionRequerimiento
{
    public partial class ListadoRequerimientos : Form
    {
        GestionRequerimientoImplementacion gestor = new GestionRequerimientoImplementacion();

        public ListadoRequerimientos()
        {
            InitializeComponent();
        }

        private void ListadoRequerimientos_Load(object sender, EventArgs e)
        {
            List<RequerimietoRegistradoDb> lista = gestor.ListarTodosRequerimiento();
            dataGridView1.DataSource = lista;
        }
    }
}
