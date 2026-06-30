using System;

namespace HotelZormat
{
    partial class FrmHabitacionGestiion
    {
        private System.ComponentModel.IContainer components = null;

        // ── Controles ────────────────────────────────────────────────
        private System.Windows.Forms.Label lblTituloTipo;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblIcono;
        private System.Windows.Forms.Label lblTarifa;

        private System.Windows.Forms.Label lblTituloLista;
        private System.Windows.Forms.ListBox lstHabitaciones;

        private System.Windows.Forms.Label lblTituloBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.Label lblEstado;

        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Instanciar ───────────────────────────────────────────
            this.lblTituloTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblIcono = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();

            this.lblTituloLista = new System.Windows.Forms.Label();
            this.lstHabitaciones = new System.Windows.Forms.ListBox();

            this.lblTituloBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();

            this.lblEstado = new System.Windows.Forms.Label();

            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ── Formulario ───────────────────────────────────────────
            this.Text = "Sistema de Habitaciones - Hotel";
            this.Size = new System.Drawing.Size(500, 540);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // ── lblTituloTipo ────────────────────────────────────────
            this.lblTituloTipo.Text = "Tipo de habitación:";
            this.lblTituloTipo.Location = new System.Drawing.Point(20, 20);
            this.lblTituloTipo.Size = new System.Drawing.Size(150, 20);

            // ── cboTipo ──────────────────────────────────────────────
            this.cboTipo.Location = new System.Drawing.Point(20, 44);
            this.cboTipo.Size = new System.Drawing.Size(150, 24);
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
           // this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);

            // ── lblIcono ─────────────────────────────────────────────
            this.lblIcono.Text = "🛏";
            this.lblIcono.Location = new System.Drawing.Point(185, 40);
            this.lblIcono.Size = new System.Drawing.Size(50, 30);
            this.lblIcono.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);

            // ── lblTarifa ────────────────────────────────────────────
            this.lblTarifa.Text = "Tarifa: RD$ 0.00";
            this.lblTarifa.Location = new System.Drawing.Point(240, 48);
            this.lblTarifa.Size = new System.Drawing.Size(200, 20);
            this.lblTarifa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // ── lblTituloLista ───────────────────────────────────────
            this.lblTituloLista.Text = "Habitaciones - Piso 3:";
            this.lblTituloLista.Location = new System.Drawing.Point(20, 90);
            this.lblTituloLista.Size = new System.Drawing.Size(160, 20);

            // ── lstHabitaciones ──────────────────────────────────────
            this.lstHabitaciones.Location = new System.Drawing.Point(20, 112);
            this.lstHabitaciones.Size = new System.Drawing.Size(150, 100);

            // ── lblTituloBuscar ──────────────────────────────────────
            this.lblTituloBuscar.Text = "Buscar habitación (número):";
            this.lblTituloBuscar.Location = new System.Drawing.Point(20, 230);
            this.lblTituloBuscar.Size = new System.Drawing.Size(200, 20);

            // ── txtBuscar ────────────────────────────────────────────
            this.txtBuscar.Location = new System.Drawing.Point(20, 254);
            this.txtBuscar.Size = new System.Drawing.Size(120, 24);

            // ── btnBuscar ────────────────────────────────────────────
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Location = new System.Drawing.Point(150, 252);
            this.btnBuscar.Size = new System.Drawing.Size(80, 28);
           // this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // ── lblEstado ────────────────────────────────────────────
            this.lblEstado.Text = "Estado: ---";
            this.lblEstado.Location = new System.Drawing.Point(20, 295);
            this.lblEstado.Size = new System.Drawing.Size(200, 22);
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // ── Botones de acción ────────────────────────────────────
            this.btnCheckIn.Text = "✔ Check In";
            this.btnCheckIn.Location = new System.Drawing.Point(20, 330);
            this.btnCheckIn.Size = new System.Drawing.Size(100, 32);
            this.btnCheckIn.Enabled = false;
            //this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);

            this.btnCheckOut.Text = "✔ Check Out";
            this.btnCheckOut.Location = new System.Drawing.Point(130, 330);
            this.btnCheckOut.Size = new System.Drawing.Size(100, 32);
            this.btnCheckOut.Enabled = false;
            //this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);

            this.btnReservar.Text = "✔ Reservar";
            this.btnReservar.Location = new System.Drawing.Point(240, 330);
            this.btnReservar.Size = new System.Drawing.Size(100, 32);
            this.btnReservar.Enabled = false;
            //this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);

            this.btnLimpiar.Text = "✔ Limpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(350, 330);
            this.btnLimpiar.Size = new System.Drawing.Size(100, 32);
            this.btnLimpiar.Enabled = false;
            //this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // ── btnGuardar ───────────────────────────────────────────
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(20, 380);
            this.btnGuardar.Size = new System.Drawing.Size(440, 36);
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            // Nota: btnGuardar en este diseño lo activa el botón de acción (CheckIn, etc.)
            // Si lo prefieres como botón separado, conecta el evento aquí:
            // this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ── Agregar controles al formulario ──────────────────────
            this.Controls.Add(this.lblTituloTipo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblIcono);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.lblTituloLista);
            this.Controls.Add(this.lstHabitaciones);
            this.Controls.Add(this.lblTituloBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);

            // ── Evento Load ──────────────────────────────────────────
            this.Load += new System.EventHandler(this.FrmHabitacionGestiion_Load);

            this.ResumeLayout(false);
        }

        private void FrmHabitacionGestiion_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}