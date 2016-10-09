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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        List<clsVenta> RegistraVenta = new List<clsVenta>();
       

        private void Ventas_Load(object sender, EventArgs e)
        {
            String strFileNameCliente = Application.StartupPath.ToString() + "\\FileCliente.txt";

            txt_total_repuesto.Enabled = false;
            txt_total.Enabled = false;

            try
            {
                //Leer Archivo
                StreamReader FileVenta = new StreamReader(strFileNameCliente);
                String strLineaFile = "";

                //Recorrer
                do
                {
                    //Linea a linea
                    strLineaFile = FileVenta.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        if (strLineaFile.LastIndexOf(';') > 0)
                        {
                            String[] Columnas = strLineaFile.Split(';');

                            clsVenta AgregaVenta = new clsVenta();

                            AgregaVenta.Cliente = Columnas[0];
                            AgregaVenta.MontoCredito = Convert.ToInt32(Columnas[1]);
                            //AgregaVenta.Fecha = Columnas[3];
                            //AgregaVenta.Repuesto = Columnas[4];
                            //AgregaVenta.Cantidad = Convert.ToInt32(Columnas[5]);
                            //AgregaVenta.PrecioVenta = Convert.ToInt32(Columnas[6]);
                            //AgregaVenta.TotalRepuesto = Convert.ToInt32(Columnas[7]);
                            //AgregaVenta.TotalVenta = Convert.ToInt32(Columnas[8]);
                            cmb_cliente.Items.Add(Columnas[0]);


                            //Agrego un nuevo registro a la Lista
                            RegistraVenta.Add(AgregaVenta);

                            cmb_cliente.Text = AgregaVenta.Cliente;    
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
                MessageBox.Show("Archivo de Genero no Existe, Favor revisar [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error General [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean ValidaVenta(out String strError)
        {
            Boolean flgReturn = true;
            String strMensaje = "";

            if (cmb_cliente.Text == "")
            {
                flgReturn = false;
                strMensaje = "Debe ingresar un cliente";
                cmb_cliente.Focus();
            }
            else if (Int32.Parse(txt_monto.Text) == 0) {
                flgReturn = false;
                strMensaje = "Debe ingresar un monto";
                txt_monto.Focus();
            }
            else if (cmb_repuesto.Text == "") {
                flgReturn = false;
                strMensaje = "Debe ingresar algún repuesto";
                cmb_repuesto.Focus();

            }
            else if (Int32.Parse(txt_cantidad.Text) == 0) {
                flgReturn = false;
                strMensaje = "Debe ingresar una cantidad";
                txt_cantidad.Focus();
            }
            
            strError = strMensaje;
            return flgReturn;
            
        }

        private void RegistroVenta() {
            
            clsVenta venta = new clsVenta();
            venta.Cliente = cmb_cliente.Text;
            venta.MontoCredito = Convert.ToInt32(txt_monto.Text);
            venta.Fecha = date_fechaOperacion.Text;
            venta.Repuesto = cmb_repuesto.Text;
            venta.Cantidad = Convert.ToInt32(txt_cantidad.Text);
            venta.PrecioVenta = Convert.ToInt32(txt_venta.Text);
            venta.TotalRepuesto = Convert.ToInt32(txt_total_repuesto.Text);
            venta.TotalVenta = Convert.ToInt32(txt_total.Text);

            RegistraVenta.Add(venta);

            grilla.Rows.Add(cmb_cliente, txt_monto, date_fechaOperacion, cmb_repuesto, txt_cantidad, txt_venta, txt_total);

            MessageBox.Show("Realizado !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String strError;
            if (!ValidaVenta(out strError))
            {
                throw new Exception(strError);
            }
            else {
                RegistroVenta();
            }
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
