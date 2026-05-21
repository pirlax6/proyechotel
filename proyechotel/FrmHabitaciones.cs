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
    public partial class FrmHabitaciones : Form
    {
        public FrmHabitaciones()
        {
            InitializeComponent();
        }
        public void MostrarHabitaciones()
        {
            try
            {
                if (Conexion.conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.conexion.Close();
                }

                Conexion.conexion.Open();

                string consulta = "SELECT * FROM habitaciones";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(
                    consulta,
                    Conexion.conexion
                );

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvHabitaciones.DataSource = tabla;

                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            MostrarHabitaciones();

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

                string consulta = "INSERT INTO habitaciones(numero, tipo, precio, estado) VALUES (@numero,@tipo,@precio,@estado)";

                MySqlCommand comando = new MySqlCommand(consulta, Conexion.conexion);

                comando.Parameters.AddWithValue("@numero", txtNumero.Text);
                comando.Parameters.AddWithValue("@tipo",   txtTipo.Text);
                comando.Parameters.AddWithValue("@precio", txtPrecio.Text);
                comando.Parameters.AddWithValue("@estado", txtEstado.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Habitación guardada");

                Conexion.conexion.Close();
                MostrarHabitaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
