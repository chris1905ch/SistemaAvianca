namespace AviancaApp.Forms
{
    partial class FormReservas
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
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbVuelo = new System.Windows.Forms.ComboBox();
            this.cbTarifa = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(40, 55);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 24);
            this.cbCliente.TabIndex = 0;
            // 
            // cbVuelo
            // 
            this.cbVuelo.FormattingEnabled = true;
            this.cbVuelo.Location = new System.Drawing.Point(242, 55);
            this.cbVuelo.Name = "cbVuelo";
            this.cbVuelo.Size = new System.Drawing.Size(121, 24);
            this.cbVuelo.TabIndex = 1;
            // 
            // cbTarifa
            // 
            this.cbTarifa.FormattingEnabled = true;
            this.cbTarifa.Location = new System.Drawing.Point(424, 55);
            this.cbTarifa.Name = "cbTarifa";
            this.cbTarifa.Size = new System.Drawing.Size(121, 24);
            this.cbTarifa.TabIndex = 2;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(627, 55);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 3;
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(352, 271);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbTarifa);
            this.Controls.Add(this.cbVuelo);
            this.Controls.Add(this.cbCliente);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbVuelo;
        private System.Windows.Forms.ComboBox cbTarifa;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnReservar;
    }
}