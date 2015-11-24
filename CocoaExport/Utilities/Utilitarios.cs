using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocoaExport.Utilities
{
   public static class Utilitarios
    {
        public static bool Validacion (TextBox Vacio, ErrorProvider error, string mensaje)
        {
            bool valido = false;
            if (Vacio.Text.Trim().Length == 0)
            {
                error.SetError(Vacio, mensaje);
                Vacio.Focus();
                valido = false;
            }

            return valido;
        }
    }
}
