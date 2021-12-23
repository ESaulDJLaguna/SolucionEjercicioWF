using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Logica
{
    class Bases
    {
        public static object Decimales(TextBox CajaTexto, KeyPressEventArgs e)
        {
            // Si al precionar una tecla es un punto o una coma
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                // Establece KeyChar (el caracter presionado actualmente) con la información que tiene ESTE if en la condición (de la posición) 0 (e.KeyChar == '.'). Solo el punto. O sea, este if solo convierte la coma en punto, NO evalúa si se mostrará en la caja de texto o no.
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            // LA PROPIEDAD Handled OBTIENE O ESTABLECE UN VALOR QUE INDICA SI SE CONTROLÓ EL EVENTO    
            // Si la tecla presionada es un número...
            if (char.IsDigit(e.KeyChar))
            {
                // ... no se "bloquea" el teclado y permite mostrarla en el text Box
                e.Handled = false;
            }
            // Sí permite presionar la tecla de borrado
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // Si se presionó un punto y ya existe un punto decimal escrito en la caja de texto...
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf(".") != 0))
            {
                // ... no permite la escritura ("bloquea" el teclado)
                e.Handled = true;
            }
            // Si se precionó un punto, ...
            else if (e.KeyChar == '.')
            {
                // ... lo permite. Se muestra en el Text Box
                e.Handled = false;
            }
            // Si se presiona una coma, ...
            else if (e.KeyChar == ',')
            {
                // ... lo permite. Se mostraría como coma en el Text Box si no existiera el if del principio que convierte la coma en punto.
                e.Handled = false;
            }
            // Bloquea cualquier otro caracter.
            else
            {
                e.Handled = true;
            }
            return null;
        }
    }
}
