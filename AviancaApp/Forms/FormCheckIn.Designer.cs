namespace AviancaApp.Forms
{
    partial class FormCheckIn
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
            this.cbReserva = new System.Windows.Forms.ComboBox();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbReserva
            // 
            this.cbReserva.FormattingEnabled = true;
            this.cbReserva.Location = new System.Drawing.Point(211, 163);
            this.cbReserva.Name = "cbReserva";
            this.cbReserva.Size = new System.Drawing.Size(121, 24);
            this.cbReserva.TabIndex = 0;
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(163, 261);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(100, 22);
            this.txtAsiento.TabIndex = 1;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(369, 283);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.cbReserva);
            this.Name = "FormCheckIn";
            this.Text = "FormCheckIn";
            this.Load += new System.EventHandler(this.FormCheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbReserva;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.Button btnCheckIn;
    }
}