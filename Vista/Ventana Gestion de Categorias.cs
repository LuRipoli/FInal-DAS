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
            cmbModificar.Enabled = false;
            cmbEliminarCategoria.Enabled = false;
            cargardatosDgvClientes();

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
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscarNombre.Text))
                {
                    MessageBox.Show("El nombre de la categoría no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var categoria = controladora.BuscarCategoriaPorNombre(txtBuscarNombre.Text.Trim());

                if (categoria != null)
                {
                    dgvClientes.Rows.Clear();

                    if (dgvClientes.Columns.Count == 0)
                    {
                        dgvClientes.Columns.Add("Id", "Id");
                        dgvClientes.Columns.Add("Nombre", "Nombre");
                    }

                    dgvClientes.Rows.Add(categoria.Id, categoria.Nombre);

                    if (dgvClientes.Rows.Count > 0)
                    {
                        dgvClientes.ClearSelection();
                        dgvClientes.Rows[0].Selected = true;
                    }

                    MessageBox.Show("Categoría encontrada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvClientes.Rows.Clear();
                    MessageBox.Show("Categoría no encontrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            cmbModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                controladora.ModificarCategoria(int.Parse(txtModificarId.Text), txtModificarNombre.Text);
                MessageBox.Show("Categoría modificada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbModificar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            cmbEliminarCategoria.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                controladora.EliminarCategoria(int.Parse(txtEliminarId.Text));
                MessageBox.Show("Categoría eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbEliminarCategoria.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCategoriaId_Click(object sender, EventArgs e)
        {
            cmbBuscarId.Enabled = true;
        }

        private void BuscarCategoriaNombre_Click(object sender, EventArgs e)
        {
            cmbBuscarNombre.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 vistaBase = new Form1();
            vistaBase.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 vistaBase = new Form1();
            vistaBase.Close();
            Application.Exit();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBuscarId.Text?.Trim(), out int categoriaId))
                {
                    MessageBox.Show("Id inválido. Introduzca un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var categoria = controladora.BuscarCategoriaPorId(categoriaId);
                if (categoria != null)
                {
                    dgvClientes.Rows.Clear();

                    if (dgvClientes.Columns.Count == 0)
                    {
                        dgvClientes.Columns.Add("Id", "Id");
                        dgvClientes.Columns.Add("Nombre", "Nombre");
                    }

                    dgvClientes.Rows.Add(categoria.Id, categoria.Nombre);

                    if (dgvClientes.Rows.Count > 0)
                    {
                        dgvClientes.ClearSelection();
                        dgvClientes.Rows[0].Selected = true;
                    }

                    MessageBox.Show("Categoría encontrada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgvClientes.Rows.Clear();
                    MessageBox.Show("Categoría no encontrada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PrecargarDatos()
        {
            try
            {
                controladora.AgregarCategoria("Bebidas");
                controladora.AgregarCategoria("Snacks");
                controladora.AgregarCategoria("Lácteos");
                controladora.AgregarCategoria("Carnes");
                controladora.AgregarCategoria("Verduras");
            }
            catch (Exception)
            {
                // Ignorar errores si las categorías ya existen
            }
        }

        public void cargardatosDgvClientes()
        {
            try
            {
                var categorias = controladora.ObtenerCategorias();
                dgvClientes.Rows.Clear();

                if (dgvClientes.Columns.Count == 0)
                {
                    dgvClientes.Columns.Add("Id", "Id");
                    dgvClientes.Columns.Add("Nombre", "Nombre");
                    dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                if (categorias == null)
                {
                    return;
                }

                foreach (var cat in categorias)
                {
                    dgvClientes.Rows.Add(cat.Id, cat.Nombre);
                }

                if (dgvClientes.Rows.Count > 0)
                {
                    dgvClientes.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar categorías", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
