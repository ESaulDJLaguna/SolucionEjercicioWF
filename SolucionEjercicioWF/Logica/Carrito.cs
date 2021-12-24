using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicioWF.Logica
{
    public class Carrito
    {
        public string codigoArticulo { set; get; }
        public int cantidad { set; get; }

        public Carrito(string codigoArticulo, int cantidad)
        {
            this.codigoArticulo = codigoArticulo;
            this.cantidad = cantidad;
        }
    }
}
