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
            CargarGrilaVentas();
            String strFileNameCliente = Application.StartupPath.ToString() + "\\FileCliente.txt";
            String strFileNameRepuesto = Application.StartupPath.ToString() + "\\FileRepuesto.txt";
            //cmb_cliente.SelectedItem = -1;
            //cmb_monto.Enabled = false;
            //txt_total_repuesto.Enabled = false;
            //cmb_precio_venta.Enabled = false;
            
            List<clsCliente> DatosCliente = new List<clsCliente>();


            try
            {
                //Leer Archivo
                StreamReader FileCliente = new StreamReader(strFileNameCliente);
                String strLineaFile = "";
                
                //Recorrer
                do
                {
                    //Linea a linea
                    strLineaFile = FileCliente.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        if (strLineaFile.LastIndexOf(';') > 0)
                        {
                            String[] Columnas = strLineaFile.Split(';');

                            clsCliente AgregaCliente = new clsCliente();

                            AgregaCliente.Rut = Columnas[0];
                            AgregaCliente.Nombre = Columnas[1];
                            AgregaCliente.Direcion = Columnas[2];
                            AgregaCliente.Fono = Convert.ToInt32(Columnas[3]);
                            AgregaCliente.Region = Columnas[4];
                            AgregaCliente.Comuna = Columnas[5];
                            AgregaCliente.Monto = Convert.ToInt32(Columnas[6]);


                            cmb_cliente.Items.Add(Columnas[0]);
                            cmb_monto.Items.Add(Columnas[6]);


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

            try
            {
                //Leer Archivo
                StreamReader FileRepuesto = new StreamReader(strFileNameRepuesto);
                String strLineaFile = "";

                //Recorrer
                do
                {
                    //Linea a linea
                    strLineaFile = FileRepuesto.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        if (strLineaFile.LastIndexOf(';') > 0)
                        {
                            String[] Columnas = strLineaFile.Split(';');

                            clsRepuestos AgregaRepuesto = new clsRepuestos();

                            AgregaRepuesto.CodigoRepuesto = Columnas[0];
                            AgregaRepuesto.Descripcion = Columnas[1];
                            AgregaRepuesto.QInventario = Convert.ToInt32(Columnas[3]);
                            AgregaRepuesto.CodigoProveedor = Columnas[4];
                            AgregaRepuesto.PrecioCosto = Convert.ToInt32(Columnas[5]);
                            AgregaRepuesto.PrecioVenta = Convert.ToInt32(Columnas[6]);
                            
                            cmb_repuesto.Items.Add(Columnas[0]);

                            //Agrego un nuevo registro a la Lista

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

        private void CargarGrilaVentas()
        {
            String Ruta = Application.StartupPath.ToString() + "\\FileVenta.txt";
            try
            {
                //Leer Archivo
                StreamReader FileVenta = new StreamReader(Ruta);
                String strLineaFile = "";

                //Recorrer
                do
                {
                    //Linea a linea
                    strLineaFile = FileVenta.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        //add item
                        if (!String.IsNullOrEmpty(Ruta))
                        {
                            //Crea instancia para leer archivo
                            StreamReader FileSelected = new StreamReader(Ruta);
                            strLineaFile = "";

                            grilla.Rows.Clear();
                            RegistraVenta.Clear();

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

                                        clsVenta AgregaVenta = new clsVenta();

                                        AgregaVenta.Cliente = Columnas[0];
                                        AgregaVenta.MontoCredito = Convert.ToInt32(Columnas[1]);
                                        AgregaVenta.Fecha = Convert.ToString(Columnas[2]);
                                        AgregaVenta.Repuesto = Convert.ToString(Columnas[3]);
                                        AgregaVenta.Cantidad = Convert.ToInt32(Columnas[4]);
                                        AgregaVenta.PrecioVenta = Convert.ToInt32(Columnas[5]);
                                        AgregaVenta.TotalRepuesto = Convert.ToInt32(Columnas[6]);
                                        AgregaVenta.TotalVenta = Convert.ToInt32(Columnas[7]);


                                        //Agrego un nuevo registro a la Lista
                                        RegistraVenta.Add(AgregaVenta);

                                        grilla.Rows.Add(cmb_cliente.Text, cmb_monto.Text, date_fechaOperacion.Text, cmb_repuesto.Text, txt_cantidad.Text, cmb_precio_venta.Text, txt_total_repuesto.Text, txt_total.Text);
                                    }
                                    else
                                    {
                                        throw new Exception("Formato del archivo incorrecto");
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
                MessageBox.Show("Archivo de Cliente no Existe, Favor revisar [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grilla.Rows.Clear();
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
            else if (Int32.Parse(cmb_monto.Text) == 0) {
                flgReturn = false;
                strMensaje = "Debe ingresar un monto";
                cmb_monto.Focus();
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
            venta.MontoCredito = Convert.ToInt32(cmb_monto.Text);
            venta.Fecha = date_fechaOperacion.Text;
            venta.Repuesto = cmb_repuesto.Text;
            venta.Cantidad = Convert.ToInt32(txt_cantidad.Text);
            venta.PrecioVenta = Convert.ToInt32(cmb_precio_venta.Text);
            venta.TotalRepuesto = Convert.ToInt32(txt_total_repuesto.Text);
            venta.TotalVenta = Convert.ToInt32(txt_total.Text);

            RegistraVenta.Add(venta);

            grilla.Rows.Add(cmb_cliente.Text, cmb_monto.Text, date_fechaOperacion.Text, cmb_repuesto.Text, txt_cantidad.Text, cmb_precio_venta.Text, txt_total_repuesto.Text , txt_total.Text);

            MessageBox.Show("Realizado !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cliente.SelectedIndex == Convert.ToInt32(cmb_cliente.SelectedIndex))
            {
                cmb_monto.SelectedIndex = Convert.ToInt32(cmb_cliente.SelectedIndex);
            }
        }

        private void cmb_repuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_repuesto.SelectedIndex == Convert.ToInt32(cmb_repuesto.SelectedIndex))
            {
                cmb_precio_venta.SelectedIndex = Convert.ToInt32(cmb_repuesto.SelectedIndex);
            }
        }

        private void btn_escribirArchivo_Click(object sender, EventArgs e)
        {
             //Obtiene Path donde se esta ejecutando el programa
            String strFileNameGenero = Application.StartupPath.ToString() + "\\FileVenta.txt";


            String RutaFile = strFileNameGenero;

            StreamWriter EscribeFile = new StreamWriter(RutaFile);

            String LineaEscribe = "";

            for (int i = 0; i <= RegistraVenta.Count - 1; i++)
            {
                LineaEscribe = RegistraVenta[i].Cliente + ";";
                LineaEscribe += RegistraVenta[i].MontoCredito + ";";
                LineaEscribe += RegistraVenta[i].Fecha + ";";
                LineaEscribe += RegistraVenta[i].Repuesto + ";";
                LineaEscribe += RegistraVenta[i].Cantidad + ";";
                LineaEscribe += RegistraVenta[i].PrecioVenta + ";";
                LineaEscribe += RegistraVenta[i].TotalRepuesto + ";";
                LineaEscribe += RegistraVenta[i].TotalVenta.ToString() + ";";

                EscribeFile.WriteLine(LineaEscribe);
            }
            EscribeFile.Close();
            MessageBox.Show("Archivo Creado en Forma Correcta", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
