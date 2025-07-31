namespace AviancaApp.Forms
{
    partial class FormAeropuerto
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.dgvAeropuertos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCodigoIATA = new System.Windows.Forms.TextBox();
            this.lblCodigoIATA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeropuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(745, 195);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(323, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(745, 425);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(323, 22);
            this.txtPais.TabIndex = 1;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(745, 349);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(323, 22);
            this.txtCiudad.TabIndex = 2;
            // 
            // dgvAeropuertos
            // 
            this.dgvAeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAeropuertos.Location = new System.Drawing.Point(33, 173);
            this.dgvAeropuertos.Name = "dgvAeropuertos";
            this.dgvAeropuertos.RowHeadersWidth = 51;
            this.dgvAeropuertos.RowTemplate.Height = 24;
            this.dgvAeropuertos.Size = new System.Drawing.Size(545, 407);
            this.dgvAeropuertos.TabIndex = 3;
            this.dgvAeropuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAeropuertos_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.Location = new System.Drawing.Point(768, 512);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 42);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(626, 512);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 42);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(928, 512);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 42);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AviancaApp.Properties.Resources._7_Avianca_logo_959_487_cy_90_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(416, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 108);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(636, 201);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 20);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPais.Location = new System.Drawing.Point(639, 427);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(41, 20);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "País";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCiudad.Location = new System.Drawing.Point(636, 349);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(66, 20);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCodigoIATA
            // 
            this.txtCodigoIATA.Location = new System.Drawing.Point(745, 272);
            this.txtCodigoIATA.Name = "txtCodigoIATA";
            this.txtCodigoIATA.Size = new System.Drawing.Size(323, 22);
            this.txtCodigoIATA.TabIndex = 11;
            // 
            // lblCodigoIATA
            // 
            this.lblCodigoIATA.AutoSize = true;
            this.lblCodigoIATA.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoIATA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCodigoIATA.Location = new System.Drawing.Point(636, 274);
            this.lblCodigoIATA.Name = "lblCodigoIATA";
            this.lblCodigoIATA.Size = new System.Drawing.Size(97, 20);
            this.lblCodigoIATA.TabIndex = 12;
            this.lblCodigoIATA.Text = "CodigoIata";
            // 
            // FormAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1089, 609);
            this.Controls.Add(this.lblCodigoIATA);
            this.Controls.Add(this.txtCodigoIATA);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvAeropuertos);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtNombre);
            this.Name = "FormAeropuerto";
            this.Text = "FormAeropuerto";
            this.Load += new System.EventHandler(this.FormAeropuerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAeropuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.DataGridView dgvAeropuertos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCodigoIATA;
        private System.Windows.Forms.Label lblCodigoIATA;
    }
}