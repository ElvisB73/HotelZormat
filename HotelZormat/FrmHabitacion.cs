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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CambiarColor(string Estado)
        {
            switch(Estado)
            {
                case "Disponible":
                    lblBotonEstado.Text = "Disponible";
                    lblBotonEstado.ForeColor = Color.Green;
                    break;

                case "Mantenimiento":
                    lblBotonEstado.Text = "Mantenimiento";
                    lblBotonEstado.ForeColor = Color.Orange;
                    break;
            }

        }
    }
}
