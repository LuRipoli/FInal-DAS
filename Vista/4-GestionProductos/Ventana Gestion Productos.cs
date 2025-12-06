using Controladora;
using Entidades;
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
    public partial class Ventana_Gestion_Productos : Form
    {
        public Ventana_Gestion_Productos()
        {
            InitializeComponent();

        }
        private void Ventana_Gestion_Productos_Load(object sender, EventArgs e)
        {
            Refrescar();
            CargarCampos();
            LimpiarCampos();
        }
        #region HELPER
        private void Refrescar()
        {
            var controladoraProductos = ControladoraProductos.Instancia();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = controladoraProductos.ObtenerProducto();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = txtDescripcion.Text = txtNombreBuscado.Text = "";
            nudPrecio.Value = 0;
            cmbCategoria.SelectedIndex = -1;
        }
        private void CargarCampos()
        {
            var controladoraCategorias = ControladoraCategorias.Instancia();
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.DataSource = null;
            var categorias = controladoraCategorias.ObtenerCategorias();
            foreach (var x in categorias)
            {
                cmbCategoria.Items.Add(x.Nombre);
            }
        }
        private int? GetId()
        {
            if (Controladora.ControladoraClientes.Instancia().ObtenerClientes().Count != 0)
            {
                try
                {
                    return int.Parse(dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[0].Value.ToString());
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var controladora = ControladoraProductos.Instancia();
            try
            {
                if (txtNombre.Text.Trim() == "" || txtDescripcion.Text.Trim() == "" || cmbCategoria.SelectedItem == null)
                    throw new DatosInvalidosException("Todos los campos deben estar completos.");


                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                decimal precio = nudPrecio.Value;
                Categoria categoria = (Categoria)cmbCategoria.SelectedItem;


                //controladora.AgregarProducto(nombre, descripcion, precio, categoria);


                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
                LimpiarCampos();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            var controladora = ControladoraProductos.Instancia();
            try
            {
                int? id = GetId();
                if (id != null && txtNombre.Text != "" && txtDescripcion.Text != "" && cmbCategoria.SelectedItem != null)
                {
                    string nombre = txtNombre.Text.Trim();
                    string descripcion = txtDescripcion.Text.Trim();
                    decimal precio = nudPrecio.Value;
                    Categoria categoria = (Categoria)cmbCategoria.SelectedItem;


                    //controladora.ModificarProducto((int)id, nombre, descripcion, precio, categoria);
                    MessageBox.Show("Producto modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos y seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (EntidadNoEncontradaException ex)
            {
                MessageBox.Show(ex.Message, "Error de entidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            var controladora = ControladoraProductos.Instancia();
            try
            {
                int? id = GetId();
                if (id != null)
                {
                    controladora.EliminarProducto((int)id);
                    MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (EntidadNoEncontradaException ex)
            {
                MessageBox.Show(ex.Message, "Error de entidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var controladora = ControladoraProductos.Instancia();
            try
            {
                if (txtNombreBuscado.Text != "")
                {
                    string nombreBuscado = txtNombreBuscado.Text;
                    /*var producto = controladora.BuscarProductoPorNombre(nombreBuscado);
                    if (producto != null)
                    {
                        var lista = new List<Producto> { producto };
                        dgvProductos.DataSource = lista;
                        txtNombreBuscado.Clear();
                    }
                    else
                    {
                      MessageBox.Show("No se encontró ningún producto con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }*/
                }
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (EntidadNoEncontradaException ex)
            {
                MessageBox.Show(ex.Message, "Error de entidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            grbBuscarProducto.Enabled = true;
        }
    }
}
