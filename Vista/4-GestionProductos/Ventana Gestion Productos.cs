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
        }
        #region HELPER
        private void Refrescar()
        {
            var controladoraProductos = ControladoraProductos.Instancia();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = controladoraProductos.ObtenerProductos().OrderBy(x => x.Categoria.Nombre).ThenBy(x => x.Nombre).Select(x => new { x.Id, x.Nombre, x.Descripcion, Precio = x.Precio.ToString("$#,0.00"), Categoria = x.Categoria.Nombre }).ToList();

            if (dgvProductos.Columns["Id"] != null) dgvProductos.Columns["Id"].Visible = false;
            if (dgvProductos.Columns["CategoriaId"] != null) dgvProductos.Columns["CategoriaId"].Visible = false;

            dgvProductos.ClearSelection();
            LimpiarCampos();
            ConfigurarGrid(dgvProductos);
        }
        private void ConfigurarGrid(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 245);
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ClearSelection();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = txtDescripcion.Text = "";
            nudPrecio.Value = 0;
            cmbCategoria.SelectedIndex = -1;
            cmbProducto.SelectedIndex = -1;
        }
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null || dgvProductos.SelectedRows.Count == 0)
                return;

            txtNombre.Text = dgvProductos.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
            txtDescripcion.Text = dgvProductos.CurrentRow.Cells["Descripcion"].Value?.ToString() ?? "";

            if (decimal.TryParse(dgvProductos.CurrentRow.Cells["Precio"].Value?.ToString(), out decimal precio))
                nudPrecio.Value = precio;

            string categoriaNombre = dgvProductos.CurrentRow.Cells["Categoria"].Value?.ToString() ?? "";

            for (int i = 0; i < cmbCategoria.Items.Count; i++)
            {
                var cat = (Categoria)cmbCategoria.Items[i];
                if (cat.Nombre == categoriaNombre)
                {
                    cmbCategoria.SelectedIndex = i;
                    break;
                }
            }
        }
        private void CargarCampos()
        {
            var controladoraCategorias = ControladoraCategorias.Instancia();

            cmbCategoria.DataSource = null;
            cmbCategoria.Items.Clear();

            var categorias = controladoraCategorias.ObtenerCategorias().ToList();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";   
            cmbCategoria.ValueMember = "Id";         

            cmbCategoria.SelectedIndex = -1;


            cmbProducto.DataSource = null;
            cmbProducto.Items.Clear();

            var productos = ControladoraProductos.Instancia().ObtenerProductos().ToList();

            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";

            cmbProducto.SelectedIndex = -1;
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


        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
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


                controladora.AgregarProducto(nombre, descripcion, precio, categoria);


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


                    controladora.ModificarProducto((int)id, nombre, descripcion, precio, categoria);
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


        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            tlpBuscar.Enabled = true;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            var controladora = ControladoraProductos.Instancia();
            try
            {
                if (cmbProducto.SelectedIndex != -1)
                {
                    string nombreBuscado = cmbProducto.Text;
                    var producto = controladora.ObtenerProductoPorNombre(nombreBuscado);
                    if (producto != null)
                    {
                        var lista = new List<Producto> { producto };
                        dgvProductos.DataSource = lista;
                        if (dgvProductos.Columns["Id"] != null)
                            dgvProductos.Columns["Id"].Visible = false;
                        if (dgvProductos.Columns["CategoriaId"] != null)
                            dgvProductos.Columns["CategoriaId"].Visible = false;
                        cmbProducto.SelectedIndex = -1;
                        ConfigurarGrid(dgvProductos);
                        dgvProductos.ClearSelection();
                    }
                    else
                    {
                      MessageBox.Show("No se encontró ningún producto con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void btnLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
