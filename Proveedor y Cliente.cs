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
    public partial class ProveedorCliente : Form
    {

        public ProveedorCliente()
        {
            InitializeComponent();
        }
        //validar rut
        public String Dv(String dv)
        {

            int test = Int32.Parse(dv);
            int count, acc, accInt, intDv;
            String digitoV = "";
            count = 2;
            acc = 0;
            accInt = 0;
            intDv = 11;

            while (test != 0)
            {
                acc = (test % 10) * count;
                accInt += acc;
                count++;
                test /= 10;
                if (count == 8)
                {
                    count = 2;
                }
            }

            intDv = (11 - accInt % 11);
            if (intDv == 11)
            {
                digitoV = 0.ToString();
            }
            else if (intDv == 10)
            {
                digitoV = "K";
            }
            else
            {
                digitoV = intDv.ToString();
            }
            return digitoV;
        }

        //clases cliente y proveedor
        List<clsCliente> RegistraCliente = new List<clsCliente>();
        List<clsProveedor> RegistraProveedor = new List<clsProveedor>();

        //Evento LOAD
        private void ProveedorCliente_Load(object sender, EventArgs e)
        {
            txt_fono.Text = "0";
            txt_monto_credito.Text = "0";
            cmb_registro.Items.Add("Cliente");
            cmb_registro.Items.Add("Proveedor");

            //donde esta el archivo
            String strFileNameRegion = Application.StartupPath.ToString() + "\\FileRegion.txt";
            String strFileNameComuna = Application.StartupPath.ToString() + "\\FileComuna.txt";
            //Recorrer
            try
            {
                //Leer Archivo
                StreamReader FileRegion = new StreamReader(strFileNameRegion);
                StreamReader FileComuna = new StreamReader(strFileNameComuna);
                String strLineaFile = "";

                //Recorrer
                do
                {
                    //Linea a linea
                    strLineaFile = FileRegion.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        //add item
                        cmb_region.Items.Add(strLineaFile);
                    }
                }
                while (!String.IsNullOrEmpty(strLineaFile));
                //recorrer hasta que no haya mas lieneas

                do
                {
                    //Linea a linea
                    strLineaFile = FileComuna.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        //add item
                        cmb_comuna.Items.Add(strLineaFile);
                    }
                }
                while (!String.IsNullOrEmpty(strLineaFile));
                //recorrer hasta que no haya mas lieneas
                //Cerrar Archivo
                FileRegion.Close();
                FileComuna.Close();

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
        
        //Cargar grilla con datos Clietne o Proveedor
        private void CargarGrillaClientes()
        {
            String Ruta = Application.StartupPath.ToString() + "\\FileCliente.txt";
            try
            {
                //Leer Archivo
                StreamReader FileCliente = new StreamReader(Ruta);
                String strLineaFile = "";

                //Recorrer
                do
                {
                    //Linea a linea
                    strLineaFile = FileCliente.ReadLine();
                    if (!String.IsNullOrEmpty(strLineaFile))
                    {
                        //add item
                        if (!String.IsNullOrEmpty(Ruta))
                        {
                            //Crea instancia para leer archivo
                            StreamReader FileSelected = new StreamReader(Ruta);
                            strLineaFile = "";

                            grilla.Rows.Clear();
                            RegistraCliente.Clear();

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

                                        clsCliente AgregaCliente = new clsCliente();

                                        AgregaCliente.Rut = Columnas[0];
                                        AgregaCliente.Nombre = Columnas[1];
                                        AgregaCliente.Direcion = Columnas[2];
                                        //AgregaCliente.Fono = Convert.ToInt32(Columnas[3]);
                                        AgregaCliente.Region = Columnas[4];
                                        AgregaCliente.Comuna = Columnas[5];
                                        //AgregaCliente.Monto = Convert.ToInt32(Columnas[6]);


                                        //Agrego un nuevo registro a la Lista
                                        RegistraCliente.Add(AgregaCliente);



                                        grilla.Rows.Add(cmb_registro.Text, Columnas[0], Columnas[1], Columnas[2], Columnas[3], Columnas[4], Columnas[5], Columnas[6]);
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
        private void CargarGrillaProveedores()
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

                            grilla.Rows.Clear();
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



                                        //Agrego un nuevo registro a la Lista
                                        RegistraProveedor.Add(AgregaProveedor);



                                        grilla.Rows.Add(cmb_registro.Text, Columnas[0], Columnas[1], Columnas[2], Columnas[3], Columnas[4], Columnas[5], Columnas[6], Columnas[7], Columnas[8]);
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
                MessageBox.Show("Archivo de proveedor no Existe, Favor revisar [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grilla.Rows.Clear();
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Error General [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //boton guardar
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String strError;

            try
            {
                if (cmb_registro.Text == "Cliente")
                {
                    if (!ValidaRegistroCliente(out strError))
                    {
                        throw new Exception(strError);
                    }
                    else
                    {
                        RegistroCliente();
                    }
                }
                else if (cmb_registro.Text == "Proveedor")
                {
                    if (!ValidaRegistroProveedor(out strError))
                    {
                        throw new Exception(strError);
                    }
                    else
                    {
                        RegistroProveedor();
                    }
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un tipo de registro", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validar proveedor o cliente
        private Boolean ValidaRegistroCliente(out String strError)
        {
            Boolean flgReturn = true;
            String strMensaje = "";
            String rut = "";

            if (txt_rut.Text == "")
            {
                flgReturn = false;
                strMensaje = "ingresar rut valido";
                txt_rut.Focus();
            }
            else if (!(txt_digito.Text.ToUpper() == Dv(txt_rut.Text)))
            {
                flgReturn = false;
                strMensaje = "Digito no concuerda";
                txt_digito.Focus();
            }
                
            else if (txt_nombre.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "Ingrese nombre";
                txt_nombre.Focus();

            }
            else if (txt_direccion.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar Direccion";
                txt_direccion.Focus();
            }
            else if (Convert.ToInt32(txt_fono.Text) == 0)
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar un Numero de telefono";
                txt_fono.Focus();
            }
            else if (cmb_region.SelectedIndex == -1)
            {
                flgReturn = false;
                strMensaje = "Debe Seleccionar una region";
                cmb_region.Focus();
            }
            else if (cmb_comuna.SelectedIndex == -1)
            {
                flgReturn = false;
                strMensaje = "Debe Seleccionar una comuna";
                cmb_comuna.Focus();
            }
            else if (Convert.ToInt32(txt_monto_credito.Text) == 0)
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar un Monto";
                txt_monto_credito.Focus();
            }
            else
            {
                rut = txt_rut.Text + "-" + txt_digito.Text;

                for (int i = 0; i < grilla.Rows.Count; i++)
                {

                    if ((grilla.Rows[i].Cells[1].Value.ToString()).Equals(rut))
                    {
                        flgReturn = false;
                        strMensaje = "Rut ya ha sido ingresado";
                        txt_rut.Focus();
                    }
                }
            }
            
            strError = strMensaje;
            return flgReturn;
        }
        private Boolean ValidaRegistroProveedor(out String strError)
        {
            Boolean flgReturn = true;
            String strMensaje = "";
            String email = txt_email.Text;
            String rut = "";

            if (txt_rut.Text == "")
            {
                flgReturn = false;
                strMensaje = "ingresar rut valido";
                txt_rut.Focus();
            }
            else if (!(txt_digito.Text.ToUpper() == Dv(txt_rut.Text)))
            {
                flgReturn = false;
                strMensaje = "Digito no concuerda";
                txt_digito.Focus();
            }
            else if (txt_nombre.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "Ingrese nombre";
                txt_nombre.Focus();

            }
            else if (txt_direccion.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar Direccion";
                txt_direccion.Focus();
            }
            else if (Convert.ToInt32(txt_fono.Text) == 0)
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar un Numero de telefono";
                txt_fono.Focus();
            }
            else if (cmb_region.SelectedIndex == -1)
            {
                flgReturn = false;
                strMensaje = "Debe Seleccionar una region";
                cmb_region.Focus();
            }
            else if (cmb_comuna.SelectedIndex == -1)
            {
                flgReturn = false;
                strMensaje = "Debe Seleccionar una comuna";
                cmb_comuna.Focus();
            }
            else if (txt_ejecutivo.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar Nombre de un ejecutivo";
                txt_ejecutivo.Focus();
            }
            else if (txt_ejecutivo.Text.Trim() == "")
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar Nombre de un ejecutivo";
                txt_ejecutivo.Focus();
            }
            else if (email.IndexOf("@") == -1 || email.IndexOf(".") == -1 || email.Length < 5)
            {
                flgReturn = false;
                strMensaje = "Debe Ingresar un Correo Valido";
                txt_email.Focus();
            }
            else
            {
                rut = txt_rut.Text + "-" + txt_digito.Text;

                for (int i = 0; i < grilla.Rows.Count; i++)
                {

                    if ((grilla.Rows[i].Cells[1].Value.ToString()).Equals(rut))
                    {
                        flgReturn = false;
                        strMensaje = "Rut ya ha sido ingresado";
                        txt_rut.Focus();
                    }
                }
            }
            strError = strMensaje;
            return flgReturn;
        }
        

        //registrar proveedor o cliente
        private void RegistroCliente()
        {
            clsCliente AgregarCliente = new clsCliente();

            AgregarCliente.Rut = (String) (txt_rut.Text + "-" + txt_digito.Text.ToUpper());
            AgregarCliente.Nombre = txt_nombre.Text;
            AgregarCliente.Direcion = txt_direccion.Text;
            AgregarCliente.Fono = Convert.ToInt32(txt_fono.Text);
            AgregarCliente.Region = cmb_region.Text;
            AgregarCliente.Comuna = cmb_comuna.Text;
            AgregarCliente.Monto = Convert.ToInt32(txt_monto_credito.Text);

            //Agregar registro a la lista
            RegistraCliente.Add(AgregarCliente);

            //Agregar Registro a la grilla
            grilla.Rows.Add(cmb_registro.Text, AgregarCliente.Rut, AgregarCliente.Nombre, AgregarCliente.Direcion, AgregarCliente.Fono, AgregarCliente.Region, AgregarCliente.Comuna, AgregarCliente.Monto, " ", " ");

            MessageBox.Show("Registro Exitoso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void RegistroProveedor()
        {
            clsProveedor AgregarProveedor = new clsProveedor();

            AgregarProveedor.Rut = (String)(txt_rut.Text + "-" + txt_digito.Text.ToUpper());
            AgregarProveedor.Nombre = txt_nombre.Text;
            AgregarProveedor.Direcion = txt_direccion.Text;
            AgregarProveedor.Fono = Convert.ToInt32(txt_fono.Text);
            AgregarProveedor.Region = cmb_region.Text;
            AgregarProveedor.Comuna = cmb_comuna.Text;
            AgregarProveedor.Ejecutivo = txt_ejecutivo.Text;
            AgregarProveedor.Email = txt_email.Text;

            //Agregar registro a la lista
            RegistraProveedor.Add(AgregarProveedor);

            //Agregar Registro a la grilla
            grilla.Rows.Add(cmb_registro.Text, AgregarProveedor.Rut, AgregarProveedor.Nombre, AgregarProveedor.Direcion, AgregarProveedor.Fono, AgregarProveedor.Region, AgregarProveedor.Comuna, " ", AgregarProveedor.Ejecutivo, AgregarProveedor.Email);

            MessageBox.Show("Registro Exitoso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //cambio evento registro Cliente o proveedor
        private void cmb_registro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_registro.Text == "Cliente")
            {
                txt_email.Enabled = false;
                txt_ejecutivo.Enabled = false;
                txt_monto_credito.Enabled = true;
                txt_monto_credito.Text = "0";
                txt_email.Text = "";
                txt_ejecutivo.Text = "";
                CargarGrillaClientes();
            }
            if (cmb_registro.Text == "Proveedor")
            {
                txt_email.Enabled = true;
                txt_ejecutivo.Enabled = true;
                txt_monto_credito.Enabled = false;
                txt_monto_credito.Text = "";
                CargarGrillaProveedores();
            }
        }

        //Solo numeros 
        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_fono_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_monto_credito_KeyPress(object sender, KeyPressEventArgs e)
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

        //evento leave dejar en 0
        private void txt_fono_Leave(object sender, EventArgs e)
        {
            int valorReturn = 0;

            if (!int.TryParse(txt_fono.Text, out valorReturn))
            {
                txt_fono.Text = "0";
            }
        }
        private void txt_monto_credito_Leave(object sender, EventArgs e)
        {
            int valorReturn = 0;

            if (!int.TryParse(txt_monto_credito.Text, out valorReturn))
            {
                txt_monto_credito.Text = "0";
            }
        }

        //Guardar archivo txt
        private void btn_escribir_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (cmb_registro.Text == "Cliente")
                {
                    //Obtiene Path donde se esta ejecutando el programa
                    String strFileNameGenero = Application.StartupPath.ToString() + "\\FileCliente.txt";

                    //if (saveFileDialog1.FileName != "")
                    //{
                        String RutaFile = strFileNameGenero;

                        StreamWriter EscribeFile = new StreamWriter(RutaFile);

                        String LineaEscribe = "";

                        for (int i = 0; i <= RegistraCliente.Count - 1; i++)
                        {
                            LineaEscribe = RegistraCliente[i].Rut + ";";
                            LineaEscribe += RegistraCliente[i].Nombre + ";";
                            LineaEscribe += RegistraCliente[i].Direcion + ";";
                            LineaEscribe += RegistraCliente[i].Fono + ";";
                            LineaEscribe += RegistraCliente[i].Region+ ";";
                            LineaEscribe += RegistraCliente[i].Comuna+ ";";
                            LineaEscribe += RegistraCliente[i].Monto.ToString() +";";


                            EscribeFile.WriteLine(LineaEscribe);
                        }
                        EscribeFile.Close();
                        MessageBox.Show("Archivo Creado en Forma Correcta", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //}
                    //else
                    //{
                    //    throw new Exception("Debe Seleccionar una ruta para guardar el archivo");
                    //}
                }
                else if (cmb_registro.Text == "Proveedor")
                {
                    //Obtiene Path donde se esta ejecutando el programa
                    String strFileNameGenero = Application.StartupPath.ToString() + "\\FileProveedor.txt";

                    //if (saveFileDialog1.FileName != "")
                    //{
                    String RutaFile = strFileNameGenero;

                    StreamWriter EscribeFile = new StreamWriter(RutaFile);

                    String LineaEscribe = "";

                    for (int i = 0; i <= RegistraProveedor.Count - 1; i++)
                    {                     
                        LineaEscribe = RegistraProveedor[i].Rut + ";";
                        LineaEscribe += RegistraProveedor[i].Nombre + ";";
                        LineaEscribe += RegistraProveedor[i].Direcion + ";";
                        LineaEscribe += RegistraProveedor[i].Fono + ";";
                        LineaEscribe += RegistraProveedor[i].Region + ";";
                        LineaEscribe += RegistraProveedor[i].Comuna + ";";
                        LineaEscribe += RegistraProveedor[i].Ejecutivo + ";";
                        LineaEscribe += RegistraProveedor[i].Email + ";";

                        EscribeFile.WriteLine(LineaEscribe);
                    }
                    EscribeFile.Close();
                    MessageBox.Show("Archivo Creado en Forma Correcta", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Debe agregar un cliente o proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (DirectoryNotFoundException Exc)
            {
                MessageBox.Show("Error en ruta para crear archivo [" + Exc.Message + "]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception Exc)
            {
                MessageBox.Show(Exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cerrar
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}