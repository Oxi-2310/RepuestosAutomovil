namespace Repuestos_Automotriz
{
    partial class Repuestos
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_codigo_repuesto = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.cmb_codigo_proveedor = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_precio_costo = new System.Windows.Forms.TextBox();
            this.txt_precio_venta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_escribir = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Repuesto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion Repuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad Inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Costo";
            // 
            // txt_codigo_repuesto
            // 
            this.txt_codigo_repuesto.Location = new System.Drawing.Point(311, 6);
            this.txt_codigo_repuesto.Name = "txt_codigo_repuesto";
            this.txt_codigo_repuesto.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_repuesto.TabIndex = 5;
            this.txt_codigo_repuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_repuesto_KeyPress);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(311, 32);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(294, 20);
            this.txt_descripcion.TabIndex = 6;
            // 
            // cmb_codigo_proveedor
            // 
            this.cmb_codigo_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_codigo_proveedor.FormattingEnabled = true;
            this.cmb_codigo_proveedor.Location = new System.Drawing.Point(311, 55);
            this.cmb_codigo_proveedor.Name = "cmb_codigo_proveedor";
            this.cmb_codigo_proveedor.Size = new System.Drawing.Size(137, 21);
            this.cmb_codigo_proveedor.TabIndex = 7;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(311, 85);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 8;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            this.txt_cantidad.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            // 
            // txt_precio_costo
            // 
            this.txt_precio_costo.Location = new System.Drawing.Point(311, 112);
            this.txt_precio_costo.Name = "txt_precio_costo";
            this.txt_precio_costo.Size = new System.Drawing.Size(100, 20);
            this.txt_precio_costo.TabIndex = 9;
            this.txt_precio_costo.TextChanged += new System.EventHandler(this.txt_precio_costo_TextChanged);
            this.txt_precio_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_costo_KeyPress);
            this.txt_precio_costo.Leave += new System.EventHandler(this.txt_precio_costo_Leave);
            // 
            // txt_precio_venta
            // 
            this.txt_precio_venta.Location = new System.Drawing.Point(497, 109);
            this.txt_precio_venta.Name = "txt_precio_venta";
            this.txt_precio_venta.Size = new System.Drawing.Size(100, 20);
            this.txt_precio_venta.TabIndex = 10;
            this.txt_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precio_venta_KeyPress);
            this.txt_precio_venta.Leave += new System.EventHandler(this.txt_precio_venta_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio Venta";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(230, 141);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_escribir
            // 
            this.btn_escribir.Location = new System.Drawing.Point(328, 141);
            this.btn_escribir.Name = "btn_escribir";
            this.btn_escribir.Size = new System.Drawing.Size(75, 23);
            this.btn_escribir.TabIndex = 13;
            this.btn_escribir.Text = "Escribir";
            this.btn_escribir.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(426, 141);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 14;
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
            this.Column6});
            this.grilla.Location = new System.Drawing.Point(12, 170);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(743, 246);
            this.grilla.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Repuesto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Codigo Proveedor";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio Costo";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio Venta";
            this.Column6.Name = "Column6";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Repuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 424);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_escribir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_precio_venta);
            this.Controls.Add(this.txt_precio_costo);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cmb_codigo_proveedor);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_codigo_repuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Repuestos";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.Repuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_codigo_repuesto;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox cmb_codigo_proveedor;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_precio_costo;
        private System.Windows.Forms.TextBox txt_precio_venta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_escribir;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}