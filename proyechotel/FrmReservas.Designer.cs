namespace proyechotel
{
    partial class FrmReservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHabitaciones = new System.Windows.Forms.ComboBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.dtSalida = new System.Windows.Forms.DateTimePicker();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Habitacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Salida";
            // 
            // cbHabitaciones
            // 
            this.cbHabitaciones.FormattingEnabled = true;
            this.cbHabitaciones.Location = new System.Drawing.Point(9, 111);
            this.cbHabitaciones.Name = "cbHabitaciones";
            this.cbHabitaciones.Size = new System.Drawing.Size(121, 24);
            this.cbHabitaciones.TabIndex = 4;
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(9, 37);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 24);
            this.cbClientes.TabIndex = 5;
            // 
            // dtSalida
            // 
            this.dtSalida.Location = new System.Drawing.Point(12, 228);
            this.dtSalida.Name = "dtSalida";
            this.dtSalida.Size = new System.Drawing.Size(200, 22);
            this.dtSalida.TabIndex = 6;
            // 
            // dtEntrada
            // 
            this.dtEntrada.Location = new System.Drawing.Point(12, 169);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(200, 22);
            this.dtEntrada.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(9, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(55, 308);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(90, 279);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCliente,
            this.colHabitacion,
            this.colEntrada,
            this.colSalida});
            this.dgvReservas.Location = new System.Drawing.Point(228, 28);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.Size = new System.Drawing.Size(816, 472);
            this.dgvReservas.TabIndex = 11;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick_1);
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 125;
            // 
            // colHabitacion
            // 
            this.colHabitacion.HeaderText = "Habitacion";
            this.colHabitacion.MinimumWidth = 6;
            this.colHabitacion.Name = "colHabitacion";
            this.colHabitacion.Width = 125;
            // 
            // colEntrada
            // 
            this.colEntrada.HeaderText = "Fecha Entrada";
            this.colEntrada.MinimumWidth = 6;
            this.colEntrada.Name = "colEntrada";
            this.colEntrada.Width = 125;
            // 
            // colSalida
            // 
            this.colSalida.HeaderText = "Fecha Salida";
            this.colSalida.MinimumWidth = 6;
            this.colSalida.Name = "colSalida";
            this.colSalida.Width = 125;
            // 
            // FrmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 551);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtEntrada);
            this.Controls.Add(this.dtSalida);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.cbHabitaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FrmReservas";
            this.Text = "FrmReservas";
            this.Load += new System.EventHandler(this.FrmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHabitaciones;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.DateTimePicker dtSalida;
        private System.Windows.Forms.DateTimePicker dtEntrada;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalida;
    }
}