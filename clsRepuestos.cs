using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repuestos_Automotriz
{
    class clsRepuestos
    {
       String codigoRepuesto;
       String descripcion;
       int qInventario;
       String codigoProveedor;
       int precioCosto;
       int precioVenta;

         public String CodigoRepuesto {
           get { return codigoRepuesto;  }
           set { codigoRepuesto = value; }
         }

         public String Descripcion {
           get { return descripcion;  }
           set { descripcion = value; }
         }

         public int QInventario {
           get { return qInventario;   }
           set { qInventario = value;  }
         }

         public String CodigoProveedor {
           get { return codigoProveedor;  }
           set { codigoProveedor = value; }
         }

         public int PrecioCosto {
           get { return PrecioCosto;  }
           set { PrecioCosto = value; }
         }
         public int PrecioVenta {
           get { return precioVenta;  }
           set { precioVenta = value; }

         }
     }
}

