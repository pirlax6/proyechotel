namespace proyechotel
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE GESTION HOTELERA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClientes.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClientes.Location = new System.Drawing.Point(12, 90);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 60);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReservas.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservas.Location = new System.Drawing.Point(504, 90);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(200, 60);
            this.btnReservas.TabIndex = 2;
            this.btnReservas.Text = "RESERVAS";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHabitaciones.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabitaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHabitaciones.Location = new System.Drawing.Point(248, 90);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(200, 60);
            this.btnHabitaciones.TabIndex = 3;
            this.btnHabitaciones.Text = "HABITACIONES";
            this.btnHabitaciones.UseVisualStyleBackColor = false;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(755, 90);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 60);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnHabitaciones);
            this.Controls.Add(this.btnReservas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE HOTEL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnSalir;
    }
}

