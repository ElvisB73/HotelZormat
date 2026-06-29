using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat
{
    public partial class FrmReserva : Form
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNoches_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {
            string[] tipoHabitacion = { "sencilla", "Doble", "Suite", "Presidencial" };

            CbxTipo.Items.Clear();
            foreach (string tipo in tipoHabitacion)
            {
                CbxTipo.Items.Add(tipo);
            }
        }
    }
}
