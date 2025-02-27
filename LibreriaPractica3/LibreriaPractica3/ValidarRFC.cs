using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibreriaPractica3
{
    public class ValidarRFC
    {
        public static bool EsRFCValido(string rfc)
        {
            if (string.IsNullOrWhiteSpace(rfc) || rfc.Length != 13)
                return false;

            string validarRFC = @"^[A-Z]{4}\d{6}[A-Z0-9]{3}$";
            return Regex.IsMatch(rfc.ToUpper(), validarRFC);
        }

        public static string CorregirRFC(string rfc)
        {
            // Convertir a mayúsculas automáticamente
            return rfc.ToUpper();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
