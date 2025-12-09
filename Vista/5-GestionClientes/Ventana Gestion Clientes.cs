using Controladora;
using Entidades;
using Modelo;
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
    public partial class Ventana_Gestion_Clientes : Form
    {
        public Ventana_Gestion_Clientes()
        {
            InitializeComponent();
            Refrescar();
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
        #region HELPER
        private void Refrescar()
        {
            var controladoraClientes = ControladoraClientes.Instancia();
            var clientes = controladoraClientes.ObtenerClientes().OrderBy(x => x.TipoCliente).ThenBy(x => x.Nombre).ToList();
            dgvClientes.DataSource = clientes;
            if (dgvClientes.Columns["Id"] != null)
                dgvClientes.Columns["Id"].Visible = false;
            if (dgvClientes.Columns["TipoCliente"] != null)
                dgvClientes.Columns["TipoCliente"].HeaderText = "Tipo de Cliente";
            CargarComboClientes();
        }
        private void CargarComboClientes()
        {
            cmbClientes.DataSource = null;
            var controladoraClientes = ControladoraClientes.Instancia();
            var clientes = controladoraClientes.ObtenerClientes();
            foreach (var cliente in clientes)
            {
                cmbClientes.Items.Add(cliente.Nombre);
            }
        }
        private void LimpiarCampos()
        {
            cmbClientes.SelectedIndex = -1;
            txtNombre.Clear();
            txtEmail.Clear();
        }
        private int? GetId()
        {
            if (Controladora.ControladoraClientes.Instancia().ObtenerClientes().Count != 0)
            {
                try
                {
                    return int.Parse(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value.ToString());
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

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {
            var controladoraClientes = Controladora.ControladoraClientes.Instancia();
            try
            {
                string nombre = txtNombre.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (!rdbMayorista.Checked && !rdbMinorista.Checked)
                    throw new DatosInvalidosException("Debe seleccionar un tipo de cliente.");
                int tipoCliente = rdbMinorista.Checked ? 1 : 2;

                controladoraClientes.AgregarCliente(nombre, email, tipoCliente);
                MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnModificarCliente_Click_1(object sender, EventArgs e)
        {
            var controladoraClientes = ControladoraClientes.Instancia();
            try
            {
                int? id = GetId();
                if (id != null && txtEmail.Text != "" && txtNombre.Text != "" && (rdbMayorista.Checked || rdbMinorista.Checked))
                {
                    string nombre = txtNombre.Text;
                    string email = txtEmail.Text;
                    int tipoCliente = rdbMinorista.Checked ? 1 : 2;
                    controladoraClientes.ModificarCliente((int)id, nombre, email, tipoCliente);
                    MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos y seleccione un cliente para modificar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminarCliente_Click_1(object sender, EventArgs e)
        {
            var controladoraClientes = ControladoraClientes.Instancia();
            try
            {
                int? id = GetId();
                if (id != null)
                {
                    controladoraClientes.EliminarCliente((int)id);
                    MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrescar();
                    LimpiarCampos();
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

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            tlpBuscar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            var controladoraClientes = ControladoraClientes.Instancia();
            try
            {
                if (cmbClientes.SelectedIndex!= -1)
                {
                    string nombreBuscado = cmbClientes.Text;
                    var cliente = controladoraClientes.BuscarClientePorNombre(nombreBuscado);
                    if (cliente != null)
                    {
                        var listaClientes = new List<Entidades.Cliente>();
                        listaClientes.Add(cliente);
                        dgvClientes.DataSource = listaClientes;
                        if (dgvClientes.Columns["Id"] != null)
                            dgvClientes.Columns["Id"].Visible = false;
                        if (dgvClientes.Columns["TipoCliente"] != null)
                            dgvClientes.Columns["TipoCliente"].HeaderText = "Tipo de Cliente";
                        btnBuscar.Enabled = false;
                        tlpBuscar.Enabled = false;
                        cmbClientes.SelectedIndex=-1;
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
