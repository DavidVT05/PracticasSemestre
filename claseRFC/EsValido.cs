using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace claseRFC
{
    public static class EsValido //clase estatica realizar la validacion del RFC en mexico
    {
        //Se utiliza esta expresion para regular la validacion del formato RFC
        private static readonly Regex rfcR = new Regex(@"[A-ZÑ&]{3,4}\d{6}[A-Z\d]{2,3}$", RegexOptions.IgnoreCase);
        //Se verifica que el RFC cumpla con el formato oficial de mexico 
        //regresa true si el RFC es valid y false si no se cumple con el fofrmato 
        public static bool EsValidos(string rfc) => rfcR.IsMatch(rfc.ToUpper());
    }
}
