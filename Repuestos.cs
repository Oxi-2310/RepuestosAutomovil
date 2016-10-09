using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Repuestos_Automotriz
{
    public partial class Repuestos : Form
    {
        public Repuestos()
        {
            InitializeComponent();
        }
        List<clsRepuestos> RegistrarRepuesto = new List<clsRepuestos>();
        List<clsProveedor> RegistraProveedor = new List<clsProveedor>();
        private void Repuestos_Load(object sender, EventArgs e)
        {
            cargarProveedores();
            txt_cantidad.Text = "0";
            txt_precio_costo.Text = "0";
            txt_precio_venta.Text = "0";
            cmb_codigo_proveedor.SelectedIndex = -1;
        }
  

        //Cargar Proveedores.txt
        private void cargarProveedores()
        {
            String Ruta = Application.StartupPath.ToString() + "\\FileProveedor.txt";
            try
            {
                //Leer Archivo
                StreamReader FileProveedor = new StreamReader(Ruta);
                String strLineaFile = "";

                //Recorrer
                do
                {
                    //Linea a linea
                    strLineaFile = FileProveedor.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        //add item
                        if (!String.IsNullOrEmpty(Ruta))
                        {
                            //Crea instancia para leer archivo
                            StreamReader FileSelected = new StreamReader(Ruta);
                            strLineaFile = "";

                            RegistraProveedor.Clear();

                            //Recorre Archivo
                            do
                            {
                                //va leyendo linea a linea
                                strLineaFile = FileSelected.ReadLine();

                                if (!String.IsNullOrEmpty(strLineaFile))
                                {
                                    if (strLineaFile.LastIndexOf(';') > 0)
                                    {
                                        String[] Columnas = strLineaFile.Split(';');

                                        clsProveedor AgregaProveedor = new clsProveedor();

                                        AgregaProveedor.Rut = Columnas[0];
                                        AgregaProveedor.Nombre = Columnas[1];
                                        AgregaProveedor.Direcion = Columnas[2];
                                        //AgregaProveedor.Fono = Convert.ToInt32(Columnas[3]);
                                        AgregaProveedor.Region = Columnas[4];
                                        AgregaProveedor.Comuna = Columnas[5];
                                        //AgregaCliente.Monto = Convert.ToInt32(Columnas[6]);
                                        AgregaProveedor.Ejecutivo = Columnas[7];
                                        AgregaProveedor.Email = Columnas[8];

                                        cmb_codigo_proveedor.Items.Add(Columnas[0]);


                                        //Agrego un nuevo registro a la Lista
                                        RegistraProveedor.Add(AgregaProveedor);

                                        cmb_codigo_proveedor.Text = AgregaProveedor.Rut;
                                        }

                                }
                            }
                            while (!String.IsNullOrEmpty(strLineaFile));
                            //Recorre hasta que no lea mas lineas

                            //Cierro archivo
                            FileSelected.Close();
                        }
                    }
                }
                while (!String.IsNullOrEmpty(strLineaFile));
                //recorrer hasta que no haya mas lieneas
            }
            catch (EndOfStreamException Exc)
            {
                MessageBox.Show("Error al Recorrer el Archivo [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FileNotFoundException Exc)
            {
                MessageBox.Show("Archivo de proveedor no Existe, Favor revisar [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grilla.Rows.Clear();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error General [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                String strError;
                if (!ValidaRegistroRepuesto(out strError))
                {
                    throw new Exception(strError);
                }
                else
                {
                    //RegistroCliente();
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validar
        private Boolean ValidaRegistroRepuesto(out String strError)
        {
            Boolean flgReturn = true;
            String strMensaje = "";

            if (txt_codigo_repuesto.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "ingrese un codigo para el repuesto";
                txt_codigo_repuesto.Focus();
            }
            else if (Convert.ToInt32(txt_codigo_repuesto.Text) == 0)
            {
                flgReturn = false;
                strMensaje = "ingrese un codigo para el repuesto";
                txt_codigo_repuesto.Focus();
            }
            else if (txt_descripcion.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "ingrese una descripcion para del producto";
                txt_descripcion.Focus();
            }
            else if (cmb_codigo_proveedor.SelectedIndex == -1)
            {
                flgReturn = false;
                strMensaje = "Debe Seleccionar un proveedor";
                cmb_codigo_proveedor.Focus();
            }
            else if (Convert.ToInt32(txt_cantidad.Text) == 0)
            {
                flgReturn = false;
                strMensaje = "ingrese cantidad del producto";
                txt_cantidad.Focus();
            }
            else if (Convert.ToInt32(txt_precio_costo.Text) == 0)
            {
                flgReturn = false;
                strMensaje = "ingrese un precio costo";
                txt_precio_costo.Focus();
            }
            else if (Convert.ToInt32(txt_precio_venta.Text) == 0)
            {
                flgReturn = false;
                strMensaje = "ingrese un precio venta";
                txt_precio_venta.Focus();
            }
            else if (Convert.ToInt32(txt_precio_venta.Text) <= Convert.ToInt32(txt_precio_costo.Text))
            {
                flgReturn = false;
                strMensaje = "El precio venta debe ser 20% mayor al del costo";
                txt_precio_venta.Focus();
                double precio_venta;
                precio_venta = Convert.ToInt32(txt_precio_venta.Text) * 1.20;
                txt_precio_venta.Text = Convert.ToString(precio_venta);
            }
            else
            {                
                for (int i = 0; i < grilla.Rows.Count; i++)
                {

                    if ((grilla.Rows[i].Cells[0].Value.ToString()).Equals(cmb_codigo_proveedor.Text))
                    {
                        strMensaje = "Remplanzar registro por estos nuevos datos";
                    }
                }
            }
            strError = strMensaje;
            return flgReturn;
        }

        //evento leave dejar en 0
        private void txt_precio_costo_Leave(object sender, EventArgs e)
        {
            int valorReturn = 0;

            if (!int.TryParse(txt_precio_costo.Text, out valorReturn))
            {
                txt_precio_costo.Text = "0";
            }
        }
        private void txt_precio_venta_Leave(object sender, EventArgs e)
        {
            double precio_venta;
            precio_venta = Convert.ToInt32(txt_precio_venta.Text) * 1.20;
            txt_precio_venta.Text = Convert.ToString(precio_venta);
        }
        private void txt_cantidad_Leave(object sender, EventArgs e)
        {
            int valorReturn = 0;

            if (!int.TryParse(txt_cantidad.Text, out valorReturn))
            {
                txt_cantidad.Text = "0";
            }
        }



        //solo numeros
        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txt_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txt_codigo_repuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txt_precio_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_precio_costo_TextChanged(object sender, EventArgs e)
        {
            double costo;
            costo = Convert.ToInt32(txt_precio_costo.Text) * 1.20;
            txt_precio_venta.Text = Convert.ToString(costo);

        }


    }
}
