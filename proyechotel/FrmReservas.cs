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
    public partial class FrmReservas : Form
    {
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            cbClientes.Items.Add("Carlos Pérez");
            cbClientes.Items.Add("María López");
            cbClientes.Items.Add("Juan García");

            cbHabitaciones.Items.Add("101");
            cbHabitaciones.Items.Add("102");
            cbHabitaciones.Items.Add("103");
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvReservas.Rows.Add(
          cbClientes.Text,
          cbHabitaciones.Text,
          dtEntrada.Text,
          dtSalida.Text
      );

            MessageBox.Show("Reserva agregada");

            cbClientes.SelectedItem = null;
            cbHabitaciones.SelectedItem = null;

            cbClientes.ResetText();
            cbHabitaciones.ResetText();

            dtEntrada.Value = DateTime.Now;
            dtSalida.Value = DateTime.Now;

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbClientes.SelectedIndex = -1;
            cbHabitaciones.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                dgvReservas.Rows.RemoveAt(
                    dgvReservas.SelectedRows[0].Index
                );

                MessageBox.Show("Reserva eliminada");
            }
        }

        private void dgvReservas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvReservas.Rows.Add(
        cbClientes.Text,
        cbHabitaciones.Text,
        dtEntrada.Text,
        dtSalida.Text
    );

            MessageBox.Show("Reserva agregada");
        }
    }
}
