using MySql.Data.MySqlClient;
using proyectohotel;
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
        int idReserva = 0;
        public FrmReservas()
        {
            InitializeComponent();
        }
        public void MostrarReservas()
        {
            try
            {
                if (Conexion.conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.conexion.Close();
                }

                Conexion.conexion.Open();

                string consulta = "SELECT * FROM reservas";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(
                    consulta,
                    Conexion.conexion
                );

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvReservas.DataSource = tabla;

                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            if (dgvReservas.CurrentRow.Cells[1].Value != null)
            {
                idReserva = Convert.ToInt32(
                    dgvReservas.CurrentRow.Cells[0].Value
                );

                cbClientes.Text =
                    dgvReservas.CurrentRow.Cells[1].Value.ToString();

                cbHabitaciones.Text =
                    dgvReservas.CurrentRow.Cells[2].Value.ToString();

                dtEntrada.Value = Convert.ToDateTime(
                    dgvReservas.CurrentRow.Cells[3].Value
                );

                dtSalida.Value = Convert.ToDateTime(
                    dgvReservas.CurrentRow.Cells[4].Value
                );
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conexion.conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.conexion.Close();
                }

                Conexion.conexion.Open();

                string consulta = "INSERT INTO reservas(cliente, habitacion, fechaEntrada, fechaSalida) VALUES (@cliente,@habitacion,@entrada,@salida)";

                MySqlCommand comando = new MySqlCommand(consulta, Conexion.conexion);

                comando.Parameters.AddWithValue("@cliente", cbClientes.Text);
                comando.Parameters.AddWithValue("@habitacion", cbHabitaciones.Text);
                comando.Parameters.AddWithValue("@entrada", dtEntrada.Value);
                comando.Parameters.AddWithValue("@salida", dtSalida.Value);

                comando.ExecuteNonQuery();

                MessageBox.Show("Reserva guardada");

                Conexion.conexion.Close();

                MostrarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbClientes.SelectedIndex = -1;
            cbHabitaciones.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Conexion.conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.conexion.Close();
                }

                Conexion.conexion.Open();

                string consulta = "DELETE FROM reservas WHERE idReserva=@id";

                MySqlCommand comando = new MySqlCommand(
                    consulta,
                    Conexion.conexion
                );

                comando.Parameters.AddWithValue("@id", idReserva);

                comando.ExecuteNonQuery();

                MessageBox.Show("Reserva eliminada");

                Conexion.conexion.Close();

                MostrarReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
