namespace AviancaApp.Forms
{
    partial class Vuelos
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cbRuta = new System.Windows.Forms.ComboBox();
            this.cbAvion = new System.Windows.Forms.ComboBox();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.dtLlegada = new System.Windows.Forms.DateTimePicker();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.dgvVuelos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.AccessibleDescription = "";
            this.txtNumero.Location = new System.Drawing.Point(144, 119);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 0;
            // 
            // cbRuta
            // 
            this.cbRuta.FormattingEnabled = true;
            this.cbRuta.Location = new System.Drawing.Point(61, 193);
            this.cbRuta.Name = "cbRuta";
            this.cbRuta.Size = new System.Drawing.Size(121, 24);
            this.cbRuta.TabIndex = 1;
            // 
            // cbAvion
            // 
            this.cbAvion.FormattingEnabled = true;
            this.cbAvion.Location = new System.Drawing.Point(246, 193);
            this.cbAvion.Name = "cbAvion";
            this.cbAvion.Size = new System.Drawing.Size(121, 24);
            this.cbAvion.TabIndex = 2;
            // 
            // dtSalida
            // 
            this.dtSalida.Location = new System.Drawing.Point(471, 92);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(200, 22);
            this.dtSalida.TabIndex = 3;
            // 
            // dtLlegada
            // 
            this.dtLlegada.Location = new System.Drawing.Point(471, 146);
            this.dtLlegada.Name = "dtLlegada";
            this.dtLlegada.Size = new System.Drawing.Size(200, 22);
            this.dtLlegada.TabIndex = 4;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(452, 244);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 5;
            // 
            // dgvVuelos
            // 
            this.dgvVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelos.Location = new System.Drawing.Point(100, 263);
            this.dgvVuelos.Name = "dgvVuelos";
            this.dgvVuelos.RowHeadersWidth = 51;
            this.dgvVuelos.RowTemplate.Height = 24;
            this.dgvVuelos.Size = new System.Drawing.Size(240, 150);
            this.dgvVuelos.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(407, 322);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "button1";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(497, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "button2";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVuelos);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.dtLlegada);
            this.Controls.Add(this.dtSalida);
            this.Controls.Add(this.cbAvion);
            this.Controls.Add(this.cbRuta);
            this.Controls.Add(this.txtNumero);
            this.Name = "Vuelos";
            this.Text = "Vuelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cbRuta;
        private System.Windows.Forms.ComboBox cbAvion;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.DateTimePicker dtLlegada;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.DataGridView dgvVuelos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}