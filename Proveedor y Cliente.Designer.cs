namespace Repuestos_Automotriz
{
    partial class ProveedorCliente
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
            this.cmb_registro = new System.Windows.Forms.ComboBox();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_ejecutivo = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_digito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_fono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_monto_credito = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_region = new System.Windows.Forms.ComboBox();
            this.cmb_comuna = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_escribir = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ejecutivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Direccion";
            // 
            // cmb_registro
            // 
            this.cmb_registro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_registro.FormattingEnabled = true;
            this.cmb_registro.Location = new System.Drawing.Point(173, 8);
            this.cmb_registro.Name = "cmb_registro";
            this.cmb_registro.Size = new System.Drawing.Size(121, 21);
            this.cmb_registro.TabIndex = 1;
            this.cmb_registro.SelectedIndexChanged += new System.EventHandler(this.cmb_registro_SelectedIndexChanged);
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(173, 32);
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(100, 20);
            this.txt_rut.TabIndex = 2;
            this.txt_rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rut_KeyPress);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(173, 54);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(142, 20);
            this.txt_nombre.TabIndex = 4;
            // 
            // txt_ejecutivo
            // 
            this.txt_ejecutivo.Enabled = false;
            this.txt_ejecutivo.Location = new System.Drawing.Point(173, 117);
            this.txt_ejecutivo.Name = "txt_ejecutivo";
            this.txt_ejecutivo.Size = new System.Drawing.Size(142, 20);
            this.txt_ejecutivo.TabIndex = 6;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(173, 76);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(142, 20);
            this.txt_direccion.TabIndex = 5;
            // 
            // txt_digito
            // 
            this.txt_digito.Location = new System.Drawing.Point(287, 32);
            this.txt_digito.MaxLength = 1;
            this.txt_digito.Name = "txt_digito";
            this.txt_digito.Size = new System.Drawing.Size(28, 20);
            this.txt_digito.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Location = new System.Drawing.Point(397, 117);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(142, 20);
            this.txt_email.TabIndex = 11;
            // 
            // txt_fono
            // 
            this.txt_fono.Location = new System.Drawing.Point(397, 32);
            this.txt_fono.Name = "txt_fono";
            this.txt_fono.Size = new System.Drawing.Size(100, 20);
            this.txt_fono.TabIndex = 8;
            this.txt_fono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fono_KeyPress);
            this.txt_fono.Leave += new System.EventHandler(this.txt_fono_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comuna";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Region";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Fono";
            // 
            // txt_monto_credito
            // 
            this.txt_monto_credito.Enabled = false;
            this.txt_monto_credito.Location = new System.Drawing.Point(173, 139);
            this.txt_monto_credito.Name = "txt_monto_credito";
            this.txt_monto_credito.Size = new System.Drawing.Size(142, 20);
            this.txt_monto_credito.TabIndex = 7;
            this.txt_monto_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_monto_credito_KeyPress);
            this.txt_monto_credito.Leave += new System.EventHandler(this.txt_monto_credito_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Monto Credito";
            // 
            // cmb_region
            // 
            this.cmb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_region.FormattingEnabled = true;
            this.cmb_region.Location = new System.Drawing.Point(397, 53);
            this.cmb_region.Name = "cmb_region";
            this.cmb_region.Size = new System.Drawing.Size(205, 21);
            this.cmb_region.TabIndex = 9;
            // 
            // cmb_comuna
            // 
            this.cmb_comuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comuna.FormattingEnabled = true;
            this.cmb_comuna.Location = new System.Drawing.Point(397, 76);
            this.cmb_comuna.Name = "cmb_comuna";
            this.cmb_comuna.Size = new System.Drawing.Size(205, 21);
            this.cmb_comuna.TabIndex = 10;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(212, 179);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 12;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_escribir
            // 
            this.btn_escribir.Location = new System.Drawing.Point(293, 179);
            this.btn_escribir.Name = "btn_escribir";
            this.btn_escribir.Size = new System.Drawing.Size(109, 23);
            this.btn_escribir.TabIndex = 13;
            this.btn_escribir.Text = "Escribrir Archivo";
            this.btn_escribir.UseVisualStyleBackColor = true;
            this.btn_escribir.Click += new System.EventHandler(this.btn_escribir_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(408, 179);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grilla.Enabled = false;
            this.grilla.Location = new System.Drawing.Point(12, 208);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(638, 205);
            this.grilla.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Reg.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rut";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Direccion";
            this.Column10.Name = "Column10";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fono";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Región";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Comuna";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Monto Credito";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ejecutivo Asociado";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Email Ejecutivo";
            this.Column9.Name = "Column9";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProveedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 423);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_escribir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.cmb_comuna);
            this.Controls.Add(this.cmb_region);
            this.Controls.Add(this.txt_monto_credito);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_fono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_digito);
            this.Controls.Add(this.txt_ejecutivo);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_rut);
            this.Controls.Add(this.cmb_registro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProveedorCliente";
            this.Text = "Proveedor y Cliente";
            this.Load += new System.EventHandler(this.ProveedorCliente_Load);
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
        private System.Windows.Forms.ComboBox cmb_registro;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_ejecutivo;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_digito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_monto_credito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_region;
        private System.Windows.Forms.ComboBox cmb_comuna;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_escribir;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}