using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionEjercicioWF.Logica
{
    class LArticulos
    {
        public int idArticulo { set; get; }
        public string codigo { set; get; }
        public string descripcion { set; get; }
        public decimal precio { set; get; }
        public byte[] imagen { set; get; }
        public int stock { set; get; }
    }
}
