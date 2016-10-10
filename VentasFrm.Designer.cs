namespace Repuestos_Automotriz
{
    partial class Ventas
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
            this.lbl_seleccioneCliente = new System.Windows.Forms.Label();
            this.lbl_montoCredito = new System.Windows.Forms.Label();
            this.lbl_repuesto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_totalRepuesto = new System.Windows.Forms.Label();
            this.lbl_fechaOperacion = new System.Windows.Forms.Label();
            this.lbl_precioVenta = new System.Windows.Forms.Label();
            this.lbl_totalVenta = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_total_repuesto = new System.Windows.Forms.TextBox();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_repuesto = new System.Windows.Forms.ComboBox();
            this.date_fechaOperacion = new System.Windows.Forms.DateTimePicker();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_escribirArchivo = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_monto = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.cmb_precio_venta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_seleccioneCliente
            // 
            this.lbl_seleccioneCliente.AutoSize = true;
            this.lbl_seleccioneCliente.Location = new System.Drawing.Point(167, 15);
            this.lbl_seleccioneCliente.Name = "lbl_seleccioneCliente";
            this.lbl_seleccioneCliente.Size = new System.Drawing.Size(95, 13);
            this.lbl_seleccioneCliente.TabIndex = 0;
            this.lbl_seleccioneCliente.Text = "Seleccione Cliente";
            // 
            // lbl_montoCredito
            // 
            this.lbl_montoCredito.AutoSize = true;
            this.lbl_montoCredito.Location = new System.Drawing.Point(167, 42);
            this.lbl_montoCredito.Name = "lbl_montoCredito";
            this.lbl_montoCredito.Size = new System.Drawing.Size(73, 13);
            this.lbl_montoCredito.TabIndex = 1;
            this.lbl_montoCredito.Text = "Monto Credito";
            // 
            // lbl_repuesto
            // 
            this.lbl_repuesto.AutoSize = true;
            this.lbl_repuesto.Location = new System.Drawing.Point(167, 68);
            this.lbl_repuesto.Name = "lbl_repuesto";
            this.lbl_repuesto.Size = new System.Drawing.Size(53, 13);
            this.lbl_repuesto.TabIndex = 2;
            this.lbl_repuesto.Text = "Repuesto";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(167, 95);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(49, 13);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // lbl_totalRepuesto
            // 
            this.lbl_totalRepuesto.AutoSize = true;
            this.lbl_totalRepuesto.Location = new System.Drawing.Point(167, 121);
            this.lbl_totalRepuesto.Name = "lbl_totalRepuesto";
            this.lbl_totalRepuesto.Size = new System.Drawing.Size(80, 13);
            this.lbl_totalRepuesto.TabIndex = 4;
            this.lbl_totalRepuesto.Text = "Total Repuesto";
            // 
            // lbl_fechaOperacion
            // 
            this.lbl_fechaOperacion.AutoSize = true;
            this.lbl_fechaOperacion.Location = new System.Drawing.Point(451, 42);
            this.lbl_fechaOperacion.Name = "lbl_fechaOperacion";
            this.lbl_fechaOperacion.Size = new System.Drawing.Size(89, 13);
            this.lbl_fechaOperacion.TabIndex = 5;
            this.lbl_fechaOperacion.Text = "Fecha Operación";
            // 
            // lbl_precioVenta
            // 
            this.lbl_precioVenta.AutoSize = true;
            this.lbl_precioVenta.Location = new System.Drawing.Point(451, 95);
            this.lbl_precioVenta.Name = "lbl_precioVenta";
            this.lbl_precioVenta.Size = new System.Drawing.Size(68, 13);
            this.lbl_precioVenta.TabIndex = 6;
            this.lbl_precioVenta.Text = "Precio Venta";
            // 
            // lbl_totalVenta
            // 
            this.lbl_totalVenta.AutoSize = true;
            this.lbl_totalVenta.Location = new System.Drawing.Point(451, 121);
            this.lbl_totalVenta.Name = "lbl_totalVenta";
            this.lbl_totalVenta.Size = new System.Drawing.Size(62, 13);
            this.lbl_totalVenta.TabIndex = 7;
            this.lbl_totalVenta.Text = "Total Venta";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(546, 118);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(110, 20);
            this.txt_total.TabIndex = 8;
            // 
            // txt_total_repuesto
            // 
            this.txt_total_repuesto.Location = new System.Drawing.Point(268, 118);
            this.txt_total_repuesto.Name = "txt_total_repuesto";
            this.txt_total_repuesto.Size = new System.Drawing.Size(163, 20);
            this.txt_total_repuesto.TabIndex = 7;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(268, 12);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(388, 21);
            this.cmb_cliente.TabIndex = 1;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            // 
            // cmb_repuesto
            // 
            this.cmb_repuesto.FormattingEnabled = true;
            this.cmb_repuesto.Location = new System.Drawing.Point(268, 65);
            this.cmb_repuesto.Name = "cmb_repuesto";
            this.cmb_repuesto.Size = new System.Drawing.Size(388, 21);
            this.cmb_repuesto.TabIndex = 4;
            this.cmb_repuesto.SelectedIndexChanged += new System.EventHandler(this.cmb_repuesto_SelectedIndexChanged);
            // 
            // date_fechaOperacion
            // 
            this.date_fechaOperacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_fechaOperacion.Location = new System.Drawing.Point(546, 39);
            this.date_fechaOperacion.Name = "date_fechaOperacion";
            this.date_fechaOperacion.Size = new System.Drawing.Size(110, 20);
            this.date_fechaOperacion.TabIndex = 3;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(317, 144);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_escribirArchivo
            // 
            this.btn_escribirArchivo.Location = new System.Drawing.Point(398, 144);
            this.btn_escribirArchivo.Name = "btn_escribirArchivo";
            this.btn_escribirArchivo.Size = new System.Drawing.Size(88, 23);
            this.btn_escribirArchivo.TabIndex = 10;
            this.btn_escribirArchivo.Text = "Escribir Archivo";
            this.btn_escribirArchivo.UseVisualStyleBackColor = true;
            this.btn_escribirArchivo.Click += new System.EventHandler(this.btn_escribirArchivo_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(492, 144);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.grilla.Location = new System.Drawing.Point(9, 201);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(843, 228);
            this.grilla.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Monto Credito";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Repuesto";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio Venta";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total Repuesto";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total Venta";
            this.Column8.Name = "Column8";
            // 
            // cmb_monto
            // 
            this.cmb_monto.FormattingEnabled = true;
            this.cmb_monto.Location = new System.Drawing.Point(268, 40);
            this.cmb_monto.Name = "cmb_monto";
            this.cmb_monto.Size = new System.Drawing.Size(177, 21);
            this.cmb_monto.TabIndex = 24;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(268, 92);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(163, 20);
            this.txt_cantidad.TabIndex = 5;
            // 
            // cmb_precio_venta
            // 
            this.cmb_precio_venta.FormattingEnabled = true;
            this.cmb_precio_venta.Location = new System.Drawing.Point(546, 91);
            this.cmb_precio_venta.Name = "cmb_precio_venta";
            this.cmb_precio_venta.Size = new System.Drawing.Size(110, 21);
            this.cmb_precio_venta.TabIndex = 25;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 441);
            this.Controls.Add(this.cmb_precio_venta);
            this.Controls.Add(this.cmb_monto);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_escribirArchivo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.date_fechaOperacion);
            this.Controls.Add(this.cmb_repuesto);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.txt_total_repuesto);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_totalVenta);
            this.Controls.Add(this.lbl_precioVenta);
            this.Controls.Add(this.lbl_fechaOperacion);
            this.Controls.Add(this.lbl_totalRepuesto);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.lbl_repuesto);
            this.Controls.Add(this.lbl_montoCredito);
            this.Controls.Add(this.lbl_seleccioneCliente);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_seleccioneCliente;
        private System.Windows.Forms.Label lbl_montoCredito;
        private System.Windows.Forms.Label lbl_repuesto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_totalRepuesto;
        private System.Windows.Forms.Label lbl_fechaOperacion;
        private System.Windows.Forms.Label lbl_precioVenta;
        private System.Windows.Forms.Label lbl_totalVenta;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_total_repuesto;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_repuesto;
        private System.Windows.Forms.DateTimePicker date_fechaOperacion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_escribirArchivo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox cmb_monto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.ComboBox cmb_precio_venta;
    }
}