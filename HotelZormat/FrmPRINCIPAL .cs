using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelZormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("hiciste click");
            if (txtUsuario.Text == "Admin" && txtContraseña.Text == "1234")
            {
                MessageBox.Show("bienvenido admin");

             
            }
            else { MessageBox.Show("eso no es eso"); }
            
           



            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connStr = ConfigurationBD.ObtenerConnectionString();
            try
            {
                using (var conn = new SqlConnection(ConnStr))
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT COUNT(*) FROM HABITACIONES", CONN);
                    int TOTAL = (int)cmd.ExecuteScalar();

                    MessageBox.Show("conectado. Hay" + TOTAL + "habitaciones en la BD.");

                }
            }
            catch (sqlException ex)
            {
                MessageBox.Show(" Error de conexion" + ex.Message, " BD inaccesible",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
