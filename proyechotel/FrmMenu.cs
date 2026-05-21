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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            FrmHabitaciones frm = new FrmHabitaciones();
            frm.Show();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FrmReservas frm = new FrmReservas();
            frm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
