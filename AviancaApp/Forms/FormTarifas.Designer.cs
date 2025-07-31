namespace AviancaApp.Forms
{
    partial class FormTarifas
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
            this.cbVuelo = new System.Windows.Forms.ComboBox();
            this.lblVuelo = new System.Windows.Forms.Label();
            this.lblClaseAsiento = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTarifas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbClaseAsiento = new System.Windows.Forms.ComboBox();
            this.cbAsientosDisponlibles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVuelo
            // 
            this.cbVuelo.FormattingEnabled = true;
            this.cbVuelo.Location = new System.Drawing.Point(853, 215);
            this.cbVuelo.Name = "cbVuelo";
            this.cbVuelo.Size = new System.Drawing.Size(238, 24);
            this.cbVuelo.TabIndex = 0;
            // 
            // lblVuelo
            // 
            this.lblVuelo.AutoSize = true;
            this.lblVuelo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVuelo.Location = new System.Drawing.Point(668, 215);
            this.lblVuelo.Name = "lblVuelo";
            this.lblVuelo.Size = new System.Drawing.Size(53, 20);
            this.lblVuelo.TabIndex = 4;
            this.lblVuelo.Text = "Vuelo";
            // 
            // lblClaseAsiento
            // 
            this.lblClaseAsiento.AutoSize = true;
            this.lblClaseAsiento.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaseAsiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblClaseAsiento.Location = new System.Drawing.Point(660, 301);
            this.lblClaseAsiento.Name = "lblClaseAsiento";
            this.lblClaseAsiento.Size = new System.Drawing.Size(114, 20);
            this.lblClaseAsiento.TabIndex = 5;
            this.lblClaseAsiento.Text = "Clase Asiento";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrecio.Location = new System.Drawing.Point(668, 401);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(58, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(660, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asientos Disponibles";
            // 
            // dgvTarifas
            // 
            this.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifas.Location = new System.Drawing.Point(12, 215);
            this.dgvTarifas.Name = "dgvTarifas";
            this.dgvTarifas.RowHeadersWidth = 51;
            this.dgvTarifas.RowTemplate.Height = 24;
            this.dgvTarifas.Size = new System.Drawing.Size(642, 369);
            this.dgvTarifas.TabIndex = 8;
            this.dgvTarifas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarifas_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(690, 544);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 40);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnActualizar.Location = new System.Drawing.Point(945, 544);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 40);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(690, 615);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 39);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Location = new System.Drawing.Point(945, 615);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 39);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AviancaApp.Properties.Resources._7_Avianca_logo_959_487_cy_90_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(382, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 127);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(853, 399);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(238, 22);
            this.txtPrecio.TabIndex = 2;
            // 
            // cbClaseAsiento
            // 
            this.cbClaseAsiento.FormattingEnabled = true;
            this.cbClaseAsiento.Location = new System.Drawing.Point(853, 301);
            this.cbClaseAsiento.Name = "cbClaseAsiento";
            this.cbClaseAsiento.Size = new System.Drawing.Size(238, 24);
            this.cbClaseAsiento.TabIndex = 14;
            // 
            // cbAsientosDisponlibles
            // 
            this.cbAsientosDisponlibles.FormattingEnabled = true;
            this.cbAsientosDisponlibles.Location = new System.Drawing.Point(853, 485);
            this.cbAsientosDisponlibles.Name = "cbAsientosDisponlibles";
            this.cbAsientosDisponlibles.Size = new System.Drawing.Size(238, 24);
            this.cbAsientosDisponlibles.TabIndex = 15;
            // 
            // FormTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1103, 676);
            this.Controls.Add(this.cbAsientosDisponlibles);
            this.Controls.Add(this.cbClaseAsiento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvTarifas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblClaseAsiento);
            this.Controls.Add(this.lblVuelo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cbVuelo);
            this.Name = "FormTarifas";
            this.Text = "FormTarifas";
            this.Load += new System.EventHandler(this.FormTarifas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVuelo;
        private System.Windows.Forms.Label lblVuelo;
        private System.Windows.Forms.Label lblClaseAsiento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTarifas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbClaseAsiento;
        private System.Windows.Forms.ComboBox cbAsientosDisponlibles;
    }
}