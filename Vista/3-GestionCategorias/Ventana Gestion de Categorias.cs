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
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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
            var controladoraCategorias = Controladora.ControladoraCategorias.Instancia();
            dgvCategorias.DataSource = controladoraCategorias.ObtenerCategorias();
            if (dgvCategorias.Columns["Id"] != null)
                dgvCategorias.Columns["Id"].Visible = false;

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = txtNombreBuscado.Text = "";
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
                if (txtNombreBuscado.Text.Trim() != "")
                {
                    string nombre = txtNombreBuscado.Text.Trim();
                    var categoria = controladoraCategorias.BuscarCategoriaPorNombre(nombre);


                    if (categoria != null)
                    {
                        dgvCategorias.DataSource = new List<Entidades.Categoria> { categoria };
                        if (dgvCategorias.Columns["Id"] != null)
                            dgvCategorias.Columns["Id"].Visible = false;
                        btnBuscar.Enabled = false;
                        tlpBuscar.Enabled = false;
                        txtNombreBuscado.Clear();
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
    }
}

