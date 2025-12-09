using Controladora;
using Modelo;
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

namespace Vista
{
    public partial class Ventana_Gestion_Sucursales : Form
    {
        public Ventana_Gestion_Sucursales()
        {
            InitializeComponent();
            Refrescar();
            LimpiarCampos();
        }



        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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

        private void btnBuscarSucursal_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            tlpBuscar.Enabled = true;
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            var controladoraSucursales = Controladora.ControladoraSucursales.Instancia();
            try
            {
                if (txtDireccion.Text.Trim() == "" || txtNombre.Text.Trim() == "")
                    throw new DatosInvalidosException("Los campos no pueden estar vacíos.");

                string nombre = txtNombre.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                controladoraSucursales.AgregarSucursal(nombre, direccion);
                MessageBox.Show("Sucursal agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refrescar();
                LimpiarCampos();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarSucursal_Click(object sender, EventArgs e)
        {
            var controladoraSucursales = ControladoraSucursales.Instancia();
            try
            {
                int? id = GetId();
                if (id != null && txtDireccion.Text != "" && txtNombre.Text != "")
                {
                    string nombre = txtNombre.Text;
                    string direccion = txtDireccion.Text;
                    controladoraSucursales.ModificarSucursal((int)id, nombre, direccion);
                    MessageBox.Show("Sucursal modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione una sucursal para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            var controladoraSucursales = ControladoraSucursales.Instancia();
            try
            {
                int? id = GetId();
                if (id != null)
                {
                    controladoraSucursales.EliminarSucursal((int)id);
                    MessageBox.Show("Sucursal eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una sucursal para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #region HELPER
        public void Refrescar()
        {
            var controladoraSucursales = Controladora.ControladoraSucursales.Instancia();
            var listaSucursales = controladoraSucursales.ObtenerSucursales().OrderBy(x => x.Nombre).ToList();
            dgvSucursales.DataSource = listaSucursales;
            if (dgvSucursales.Columns["Id"] != null)
                dgvSucursales.Columns["Id"].Visible = false;
            CargarComboSucursales();
        }
        public void LimpiarCampos()
        {
            txtDireccion.Text = txtNombre.Text =  "";
            cmbSucursal.SelectedIndex = -1;
        }
        public int? GetId()
        {
            if (Controladora.ControladoraSucursales.Instancia().ObtenerSucursales().Count != 0)
            {
                try
                {
                    return int.Parse(dgvSucursales.Rows[dgvSucursales.CurrentRow.Index].Cells[0].Value.ToString());
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void CargarComboSucursales()
        {
            cmbSucursal.Items.Clear();
            var controladoraSucursales = Controladora.ControladoraSucursales.Instancia();
            var lista = controladoraSucursales.ObtenerSucursales(); 

            foreach (var sucursal in lista)
            {
                cmbSucursal.Items.Add(sucursal.Nombre);
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            var controladoraSucursales = ControladoraSucursales.Instancia();
            try
            {
                if (cmbSucursal.SelectedIndex!=-1)
                {
                    string nombreBuscado = cmbSucursal.Text;
                    var sucursal = controladoraSucursales.BuscarSucursalPorNombre(nombreBuscado);
                    if (sucursal != null)
                    {
                        var listaSucursales = new List<Entidades.Sucursal>();
                        listaSucursales.Add(sucursal);
                        dgvSucursales.DataSource = listaSucursales;
                        if (dgvSucursales.Columns["Id"] != null)
                            dgvSucursales.Columns["Id"].Visible = false; btnBuscar.Enabled = false;
                        tlpBuscar.Enabled = false;
                        cmbSucursal.SelectedIndex=-1;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún cliente con ese nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
