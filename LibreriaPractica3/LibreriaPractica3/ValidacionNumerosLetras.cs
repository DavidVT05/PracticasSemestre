using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibreriaPractica3
{
    public class ValidacionNumerosLetras
    {
        // Valida si el texto solo contiene números
        public static bool EsSoloNumeros(string texto)
        {
            return Regex.IsMatch(texto, @"^\d+$");
        }

        // Valida si el texto solo contiene letras
        public static bool EsSoloLetras(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z]+$");
        }

        // Valida si el texto contiene solo letras y números
        public static bool EsAlfanumerico(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z0-9]+$");
        }
    }
}
