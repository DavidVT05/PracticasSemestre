using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABiblioteca
{
    //Se define la clase estatica para la validacion de las entradas de texto 
    public static class SoloNumeros
    {
        //Se realiza la verificacion para saber si la cadena contiene solo numeros
        //se regresa true si solo contiene numeros y false si continen otros caracteres
        public static bool EsSoloNumero(string texto) => texto.All(char.IsDigit);
        //Aqui verificamos que la cadena solo contega letras 
        //Se regresas true si solo contiene letras, y false si contiene otros caracteres
        public static bool EsSoloLetra(string texto) => texto.All(char.IsLetter);
    }
}
