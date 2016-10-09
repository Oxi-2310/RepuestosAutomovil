using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repuestos_Automotriz
{
    class clsProveedor
    {
        String rut;
        String nombre;
        String direcion;
        int fono;
        String region;
        String comuna;
        String ejecutivo;
        String email;

        public String Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Direcion
        {
            get { return direcion; }
            set { direcion = value; }
        }
        
        public int Fono
        {
            get { return fono; }
            set { fono = value; }
        }
       
        public String Region
        {
            get { return region; }
            set { region = value; }
        }
        
        public String Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        
        public String Ejecutivo
        {
            get { return ejecutivo; }
            set { ejecutivo = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
