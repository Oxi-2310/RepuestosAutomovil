using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repuestos_Automotriz
{
    class clsVenta
    {
           String cliente;
           int montoCredito;
           String fecha;
           String repuesto;
           int cantidad;
           int precioVenta;
           int totalRepuesto;
           int totalVenta;

           public String Cliente {
               get { return cliente     ;   }
               set { cliente = value    ;   } 
           }

           public int MontoCredito {
           get { return montoCredito ;  }
           set { montoCredito = value;  } 
           }

           public String Fecha {
           get { return fecha ; }
           set { fecha = value; } 
       }
           public String Repuesto {
           get { return repuesto    ; }
           set { repuesto = value   ; } 
       }
           public int Cantidad {
           get { return cantidad    ;  }
           set { cantidad = value   ;  }  
       }
           public int PrecioVenta {
           get { return precioVenta     ;    }
           set { precioVenta = value    ;    } 
       }
           public int TotalRepuesto {
           get { return totalRepuesto   ;   }
           set { totalRepuesto = value  ;   } 
       }
           public int TotalVenta {
           get { return totalVenta  ;   }
           set { totalVenta = value ;   } 
       }
    }
}
