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
    public partial class Gestion_de_Rubros : Form
    {
        public Gestion_de_Rubros()
        {
            InitializeComponent();
        }

        private void Gestion_de_Rubros_Load(object sender, EventArgs e)
        {
            Refrescar();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var controladoraCategorias = Controladora.ControladoraCategorias.Instancia();
            try
            {
                int? id = GetId();
                if (id != null && txtNombre.Text != "")
                {
                    string nombre = txtNombre.Text.Trim();
                    controladoraCategorias.ModificarCategoria((int)id, nombre);
                    MessageBox.Show("Categoría modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Complete el campo y seleccione una categoría para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var controladoraCategorias = Controladora.ControladoraCategorias.Instancia();
            try
            {
                int? id = GetId();
                if (id != null)
                {
                    controladoraCategorias.EliminarCategoria((int)id);
                    MessageBox.Show("Categoría eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Seleccione una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

       

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            tlpBuscar.Enabled = true;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            var controladoraCategorias = Controladora.ControladoraCategorias.Instancia();
            try
            {
                if (txtNombre.Text.Trim() == "")
                    throw new DatosInvalidosException("El nombre de la categoría no puede estar vacío.");


                string nombre = txtNombre.Text.Trim();
                controladoraCategorias.AgregarCategoria(nombre);


                MessageBox.Show("Categoría agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refrescar();
                LimpiarCampos();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region HELPER
        private void Refrescar()
        {
            var ctrlCat = Controladora.ControladoraCategorias.Instancia();
            var ctrlProd = Controladora.ControladoraProductos.Instancia();

            var categorias = ctrlCat.ObtenerCategorias().OrderBy(c => c.Nombre).ToList();
            var productos = ctrlProd.ObtenerProductos().ToList();

            dgvCategorias.DataSource = categorias.Select(c => new { Id = c.Id, Nombre = c.Nombre, ProductosRegistrados = productos.Count(p => p.CategoriaId == c.Id) }).ToList();

            dgvCategorias.Columns["Id"].Visible = false;
            dgvCategorias.Columns["ProductosRegistrados"].HeaderText = "Productos Registrados";

            dgvCategorias.ClearSelection();
            LimpiarCampos();
            CargarComboCategorias();
            ConfigurarGrid(dgvCategorias);

        }
        private void CargarComboCategorias()
        {
            cmbCategoria.Items.Clear();
            var controladoraCategorias = Controladora.ControladoraCategorias.Instancia();
            var lista = controladoraCategorias.ObtenerCategorias();

            foreach (var sucursal in lista)
            {
                cmbCategoria.Items.Add(sucursal.Nombre);
            }
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
            txtNombre.Text = "";
            cmbCategoria.SelectedIndex = -1;
        }
        private int? GetId()
        {
            if (Controladora.ControladoraCategorias.Instancia().ObtenerCategorias().Count != 0)
            {
                try
                {
                    return int.Parse(dgvCategorias.Rows[dgvCategorias.CurrentRow.Index].Cells[0].Value.ToString());
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }
        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null || dgvCategorias.SelectedRows.Count == 0)
                return;

            txtNombre.Text = dgvCategorias.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "";
        }
        #endregion

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var controladoraCategorias = Controladora.ControladoraCategorias.Instancia();
            try
            {
                if (cmbCategoria.SelectedIndex != -1)
                {
                    string nombre = cmbCategoria.Text.Trim();
                    var categoria = controladoraCategorias.BuscarCategoriaPorNombre(nombre);


                    if (categoria != null)
                    {
                        dgvCategorias.DataSource = new List<Entidades.Categoria> { categoria };
                        if (dgvCategorias.Columns["Id"] != null)
                            dgvCategorias.Columns["Id"].Visible = false;
                        btnBuscar.Enabled = false;
                        tlpBuscar.Enabled = false;
                        cmbCategoria.SelectedIndex = -1;
                        dgvCategorias.ClearSelection();
                        ConfigurarGrid(dgvCategorias);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna categoría con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar.Enabled = false;
                        tlpBuscar.Enabled = false;
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

