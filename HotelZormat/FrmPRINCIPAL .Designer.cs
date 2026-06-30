namespace HotelZormat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIniciarsesion = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.BtnConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(490, 250);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 43);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIniciarsesion
            // 
            this.btnIniciarsesion.Location = new System.Drawing.Point(307, 250);
            this.btnIniciarsesion.Name = "btnIniciarsesion";
            this.btnIniciarsesion.Size = new System.Drawing.Size(132, 43);
            this.btnIniciarsesion.TabIndex = 1;
            this.btnIniciarsesion.Text = "Iniciar Sesión";
            this.btnIniciarsesion.UseVisualStyleBackColor = true;
            this.btnIniciarsesion.Click += new System.EventHandler(this.btnIniciarsesion_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(284, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(387, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(284, 160);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(387, 26);
            this.txtContraseña.TabIndex = 3;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(175, 97);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(68, 20);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "Usuario:";
            this.lbUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(175, 160);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(96, 20);
            this.lbContraseña.TabIndex = 5;
            this.lbContraseña.Text = "Contraseña:";
            // 
            // BtnConexion
            // 
            this.BtnConexion.Location = new System.Drawing.Point(203, 282);
            this.BtnConexion.Name = "BtnConexion";
            this.BtnConexion.Size = new System.Drawing.Size(98, 49);
            this.BtnConexion.TabIndex = 6;
            this.BtnConexion.Text = "Conexion";
            this.BtnConexion.UseVisualStyleBackColor = true;
            //this.BtnConexion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConexion);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIniciarsesion);
            this.Controls.Add(this.btnCancelar);
            this.Name = "Form1";
            this.Text = "Hotel_Zormat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIniciarsesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.Button BtnConexion;
    }
}

