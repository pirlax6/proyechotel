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
    public partial class FrmClientes : Form
    {
        int idCliente = 0;
                        
        public FrmClientes()
        {
            InitializeComponent();
        }
        public void MostrarClientes()
        {
            try
            {
                Conexion.conexion.Open();

                string consulta = "SELECT * FROM clientes";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, Conexion.conexion);

                DataTable tabla = new DataTable();

                adaptador.Fill(tabla);

                dgvClientes.DataSource = tabla;

                Conexion.conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();

        }

        private void txtDPI_TextChanged(object sender, EventArgs e)
        {

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

                string consulta = "INSERT INTO clientes(nombre, apellido, dpi, telefono) VALUES (@nombre,@apellido,@dpi,@telefono)";

                MySqlCommand comando = new MySqlCommand(consulta, Conexion.conexion);

                comando.Parameters.AddWithValue("@nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@apellido", txtApellido.Text);
                comando.Parameters.AddWithValue("@dpi", txtDPI.Text);
                comando.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente guardado");

                Conexion.conexion.Close();

                MostrarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            MessageBox.Show("Entró al botón");

            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);

                    if (Conexion.conexion.State == System.Data.ConnectionState.Open)
                    {
                        Conexion.conexion.Close();
                    }

                    Conexion.conexion.Open();

                    string consulta = "DELETE FROM clientes WHERE idCliente=@id";

                    MySqlCommand comando = new MySqlCommand(consulta, Conexion.conexion);

                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Cliente eliminado");

                    Conexion.conexion.Close();

                    MostrarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow.Cells[1].Value != null)
            {
                idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value);

                txtNombre.Text =
                    dgvClientes.CurrentRow.Cells[1].Value.ToString();

                txtApellido.Text =
                    dgvClientes.CurrentRow.Cells[2].Value.ToString();

                txtDPI.Text =
                    dgvClientes.CurrentRow.Cells[3].Value.ToString();

                txtTelefono.Text =
                    dgvClientes.CurrentRow.Cells[4].Value.ToString();
            }
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
