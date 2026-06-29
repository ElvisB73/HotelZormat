namespace HotelZormat
{
    partial class FrmReserva
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
            this.lbltipos = new System.Windows.Forms.Label();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.txtNoches = new System.Windows.Forms.TextBox();
            this.lblNoches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltipos
            // 
            this.lbltipos.AutoSize = true;
            this.lbltipos.Location = new System.Drawing.Point(111, 191);
            this.lbltipos.Name = "lbltipos";
            this.lbltipos.Size = new System.Drawing.Size(43, 20);
            this.lbltipos.TabIndex = 0;
            this.lbltipos.Text = "Tipo:";
            this.lbltipos.Click += new System.EventHandler(this.label1_Click);
            // 
            // CbxTipo
            // 
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Location = new System.Drawing.Point(284, 191);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(222, 28);
            this.CbxTipo.TabIndex = 1;
            // 
            // txtNoches
            // 
            this.txtNoches.Location = new System.Drawing.Point(284, 271);
            this.txtNoches.Name = "txtNoches";
            this.txtNoches.Size = new System.Drawing.Size(222, 26);
            this.txtNoches.TabIndex = 2;
            this.txtNoches.TextChanged += new System.EventHandler(this.txtNoches_TextChanged);
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Location = new System.Drawing.Point(111, 277);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(67, 20);
            this.lblNoches.TabIndex = 3;
            this.lblNoches.Text = "Noches:";
            // 
            // FrmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.txtNoches);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.lbltipos);
            this.Name = "FrmReserva";
            this.Text = "FrmReserva";
            this.Load += new System.EventHandler(this.FrmReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipos;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.TextBox txtNoches;
        private System.Windows.Forms.Label lblNoches;
    }
}