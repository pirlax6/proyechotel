using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyechotel
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtDPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Add(
                txtNombre.Text,
                txtApellido.Text,
                txtDPI.Text,
                txtTelefono.Text
            );

            MessageBox.Show("Cliente agregado");
            txtNombre.Clear();
            txtApellido.Clear();
            txtDPI.Clear();
            txtTelefono.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDPI.Clear();
            txtTelefono.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                dgvClientes.Rows.RemoveAt(
                    dgvClientes.SelectedRows[0].Index
                );

                MessageBox.Show("Cliente eliminado");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text =
    dgvClientes.CurrentRow.Cells[0].Value.ToString();

            txtApellido.Text =
                dgvClientes.CurrentRow.Cells[1].Value.ToString();

            txtDPI.Text =
                dgvClientes.CurrentRow.Cells[2].Value.ToString();

            txtTelefono.Text =
                dgvClientes.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
    {
        dgvClientes.CurrentRow.Cells[0].Value =
            txtNombre.Text;

        dgvClientes.CurrentRow.Cells[1].Value =
            txtApellido.Text;

        dgvClientes.CurrentRow.Cells[2].Value =
            txtDPI.Text;

        dgvClientes.CurrentRow.Cells[3].Value =
            txtTelefono.Text;

        MessageBox.Show("Cliente actualizado");
    }
        }
    }
}
