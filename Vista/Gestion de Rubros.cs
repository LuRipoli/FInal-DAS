using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vista
{
    public partial class Gestion_de_Rubros : Form
    {
        ControladoraCategorias controladora = new ControladoraCategorias();

        public Gestion_de_Rubros()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CmbIngresoDeDatos.Enabled = true;
        }

        private void Gestion_de_Rubros_Load(object sender, EventArgs e)
        {
            CmbIngresoDeDatos.Enabled = false;
            cmbBuscarNombre.Enabled = false;
            cmbBuscarId.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string aux = txtAgregar.Text;
                controladora.AgregarCategoria(aux);
                MessageBox.Show("Categoría agregada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbIngresoDeDatos.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
