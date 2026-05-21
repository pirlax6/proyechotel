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
    public partial class FrmHabitaciones : Form
    {
        public FrmHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvHabitaciones.Rows.Add(
        txtNumero.Text,
        txtTipo.Text,
        txtPrecio.Text,
        txtEstado.Text
    );

            MessageBox.Show("Habitación agregada");

            txtNumero.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
            txtEstado.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtTipo.Clear();
            txtPrecio.Clear();
            txtEstado.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.SelectedRows.Count > 0)
            {
                dgvHabitaciones.Rows.RemoveAt(
                    dgvHabitaciones.SelectedRows[0].Index
                );

                MessageBox.Show("Habitación eliminada");
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow != null)
            {
                dgvHabitaciones.CurrentRow.Cells[0].Value =
                    txtNumero.Text;

                dgvHabitaciones.CurrentRow.Cells[1].Value =
                    txtTipo.Text;

                dgvHabitaciones.CurrentRow.Cells[2].Value =
                    txtPrecio.Text;

                dgvHabitaciones.CurrentRow.Cells[3].Value =
                    txtEstado.Text;

                MessageBox.Show("Habitación actualizada");
            }
        }

        private void dgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumero.Text =
        dgvHabitaciones.CurrentRow.Cells[0].Value.ToString();

            txtTipo.Text =
                dgvHabitaciones.CurrentRow.Cells[1].Value.ToString();

            txtPrecio.Text =
                dgvHabitaciones.CurrentRow.Cells[2].Value.ToString();

            txtEstado.Text =
                dgvHabitaciones.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
