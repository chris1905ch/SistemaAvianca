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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReservas));
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbVuelo = new System.Windows.Forms.ComboBox();
            this.cbTarifa = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(236, 144);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(200, 24);
            this.cbCliente.TabIndex = 0;
            // 
            // cbVuelo
            // 
            this.cbVuelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVuelo.FormattingEnabled = true;
            this.cbVuelo.Location = new System.Drawing.Point(236, 204);
            this.cbVuelo.Name = "cbVuelo";
            this.cbVuelo.Size = new System.Drawing.Size(200, 24);
            this.cbVuelo.TabIndex = 1;
            // 
            // cbTarifa
            // 
            this.cbTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarifa.FormattingEnabled = true;
            this.cbTarifa.Location = new System.Drawing.Point(236, 264);
            this.cbTarifa.Name = "cbTarifa";
            this.cbTarifa.Size = new System.Drawing.Size(200, 24);
            this.cbTarifa.TabIndex = 2;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(236, 393);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(200, 24);
            this.cbEstado.TabIndex = 3;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReservar.Location = new System.Drawing.Point(169, 482);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(94, 42);
            this.btnReservar.TabIndex = 4;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarifa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(144, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reservas";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Location = new System.Drawing.Point(236, 334);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaReserva.TabIndex = 10;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.Location = new System.Drawing.Point(32, 336);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(135, 20);
            this.lblFechaReserva.TabIndex = 11;
            this.lblFechaReserva.Text = "Fecha Reserva";
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(477, 591);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbTarifa);
            this.Controls.Add(this.cbVuelo);
            this.Controls.Add(this.cbCliente);
            this.Name = "FormReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReservas";
            this.Load += new System.EventHandler(this.FormReservas_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbVuelo;
        private System.Windows.Forms.ComboBox cbTarifa;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.Label lblFechaReserva;
    }
}