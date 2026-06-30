using Hotel.Negocio_;
using Hotel.Negocio_.DaL;
using Hotel.Negocio_.Modelo;
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
    public partial class FrmHabitacionGestiion : Form
    {
        private HabitacionDAL dal = new HabitacionDAL();
        private Habitacion habitacionActual = null;

        public FrmHabitacionGestiion()
        {
            InitializeComponent();
        }

        // ============================================================
        // EVENTO: Form_Load
        // PASO 1 – Carga el ComboBox con tipos de habitación
        // PASO 2 – Carga el ListBox con habitaciones del PISO 3 (FOREACH)
        // ============================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // PASO 1 – Tipos (hardcodeados igual que tu BD)
            cboTipo.Items.Clear();
            cboTipo.Items.Add("SENCILLA");
            cboTipo.Items.Add("DOBLE");
            cboTipo.Items.Add("SUITE");
            cboTipo.SelectedIndex = 0;

            CargarHabitacionesPiso3();
        }

        // ── Carga habitaciones del piso 3 desde la BD ───────────────
        private void CargarHabitacionesPiso3()
        {
            // PASO 2 – FOREACH sobre los datos que vienen de la BD
            lstHabitaciones.Items.Clear();

            var habitacionesPiso3 = dal.ObtenerPorPiso(3);

            foreach (Habitacion h in habitacionesPiso3)
            {
                lstHabitaciones.Items.Add(h.Numero + " - " + h.Tipo);
            }
        }

        // ============================================================
        // MÉTODO: ObtenerTarifa
        // PASO 4 – Tarifa según el tipo (SWITCH)
        // La tabla no tiene columna Tarifa, se calcula aquí
        // ============================================================
        private decimal ObtenerTarifa(string tipo)
        {
            switch (tipo)
            {
                case "SENCILLA": return 2500m;
                case "DOBLE": return 4000m;
                case "SUITE": return 7000m;
                default:
                    throw new ArgumentException($"Tipo desconocido: {tipo}");
            }
        }

        // ============================================================
        // MÉTODO: ObtenerColorEstado
        // PASO 5 – Color según el estado (SWITCH)
        // ============================================================
        private Color ObtenerColorEstado(string estado)
        {
            switch (estado)
            {
                case "DISPONIBLE": return Color.Green;
                case "OCUPADA": return Color.Red;
                case "RESERVADA": return Color.Blue;
                case "LIMPIEZA": return Color.Orange;
                default: return Color.Black;
            }
        }

        // ============================================================
        // MÉTODO: ConfigurarBotones
        // PASO 6 – Habilitar solo el botón correcto según estado (SWITCH)
        // ============================================================
        private void ConfigurarBotones(string estado)
        {
            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;
            btnReservar.Enabled = false;
            btnLimpiar.Enabled = false;

            switch (estado)
            {
                case "DISPONIBLE": btnCheckIn.Enabled = true; break;
                case "OCUPADA": btnCheckOut.Enabled = true; break;
                case "RESERVADA": btnReservar.Enabled = true; break;
                case "LIMPIEZA": btnLimpiar.Enabled = true; break;
            }
        }

        // ============================================================
        // EVENTO: cboTipo_SelectedIndexChanged
        // PASO 3 – Ícono según el tipo (SWITCH)
        // PASO 4 – Muestra tarifa visualmente
        // ============================================================
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // PASO 3 – Ícono
            switch (cboTipo.Text)
            {
                case "SENCILLA": lblIcono.Text = "🛏"; break;
                case "DOBLE": lblIcono.Text = "🛌"; break;
                case "SUITE": lblIcono.Text = "🏨"; break;
                default: lblIcono.Text = "❓"; break;
            }

            // PASO 4 – Tarifa
            try
            {
                decimal tarifa = ObtenerTarifa(cboTipo.Text);
                lblTarifa.Text = "Tarifa: RD$ " + tarifa.ToString("N2");
            }
            catch (ArgumentException ex)
            {
                lblTarifa.Text = ex.Message;
            }
        }

        // ============================================================
        // EVENTO: btnBuscar_Click
        // PASO 8 – Buscar habitación en BD (TRY / CATCH)
        // ============================================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtBuscar.Text.Trim());

                habitacionActual = dal.BuscarPorNumero(numero);

                if (habitacionActual == null)
                    throw new Exception($"No se encontró la habitación {numero}.");

                // Actualizar UI con datos reales de la BD
                lblEstado.Text = "Estado: " + habitacionActual.Estado;
                lblEstado.ForeColor = ObtenerColorEstado(habitacionActual.Estado);
                cboTipo.Text = habitacionActual.Tipo;
                ConfigurarBotones(habitacionActual.Estado);
            }
            catch (FormatException)
            {
                // PASO 8 – CATCH para entrada inválida
                MessageBox.Show("Debe escribir un número válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ============================================================
        // MÉTODO: ObtenerMensajeConfirmacion
        // PASO 7 – Mensaje según la acción (SWITCH)
        // ============================================================
        private string ObtenerMensajeConfirmacion(string accion)
        {
            switch (accion)
            {
                case "CheckIn": return "¿Desea realizar el Check In?";
                case "CheckOut": return "¿Desea realizar el Check Out?";
                case "Reservar": return "¿Desea realizar la Reserva?";
                case "Limpiar": return "¿Desea marcar la habitación para Limpieza?";
                default: return "¿Confirmar acción?";
            }
        }

        // ── Eventos de los 4 botones de acción ──────────────────────

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ObtenerMensajeConfirmacion("CheckIn"), "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuardarCambio("OCUPADA");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ObtenerMensajeConfirmacion("CheckOut"), "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuardarCambio("DISPONIBLE");
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ObtenerMensajeConfirmacion("Reservar"), "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuardarCambio("RESERVADA");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ObtenerMensajeConfirmacion("Limpiar"), "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GuardarCambio("LIMPIEZA");
            }
        }

        // ============================================================
        // MÉTODO: GuardarCambio
        // PASO 9 – Guardar en BD con TRY / CATCH / FINALLY
        // ============================================================
        private void GuardarCambio(string nuevoEstado)
        {
            btnGuardar.Enabled = false;

            try
            {
                if (habitacionActual == null)
                    throw new Exception("Primero busque una habitación.");

                // Si intenta Check In y ya está OCUPADA → excepción personalizada
                if (nuevoEstado == "OCUPADA" && habitacionActual.Estado == "OCUPADA")
                    throw new HabitacionException(habitacionActual.Numero);

                // Guardar en la BD real
                dal.ActualizarEstado(habitacionActual.Numero, nuevoEstado);

                // Actualizar objeto en memoria
                habitacionActual.Estado = nuevoEstado;

                // Refrescar UI
                lblEstado.Text = "Estado: " + nuevoEstado;
                lblEstado.ForeColor = ObtenerColorEstado(nuevoEstado);
                ConfigurarBotones(nuevoEstado);

                // Refrescar lista del piso 3
                CargarHabitacionesPiso3();

                MessageBox.Show("Cambio guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (HabitacionException ex)
            {
                MessageBox.Show(ex.Message, "Habitación Ocupada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // PASO 9 – FINALLY: siempre vuelve a habilitar
                btnGuardar.Enabled = true;
            }
        }
    }
}
