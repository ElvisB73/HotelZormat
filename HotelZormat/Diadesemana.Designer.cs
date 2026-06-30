namespace HotelZormat
{
    partial class Diadesemana
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
            this.CbxDiadesemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbxDiadesemana
            // 
            this.CbxDiadesemana.FormattingEnabled = true;
            this.CbxDiadesemana.Location = new System.Drawing.Point(323, 107);
            this.CbxDiadesemana.Name = "CbxDiadesemana";
            this.CbxDiadesemana.Size = new System.Drawing.Size(148, 28);
            this.CbxDiadesemana.TabIndex = 0;
            this.CbxDiadesemana.SelectedIndexChanged += new System.EventHandler(this.CbxDiadesemana_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia semana";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.Location = new System.Drawing.Point(606, 266);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(90, 31);
            this.btnGestion.TabIndex = 2;
            this.btnGestion.Text = "Hgestion";
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // Diadesemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxDiadesemana);
            this.Name = "Diadesemana";
            this.Text = "Diadesemana";
            this.Load += new System.EventHandler(this.Diadesemana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxDiadesemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestion;
    }
}