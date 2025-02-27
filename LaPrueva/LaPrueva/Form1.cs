using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaPractica3;  // Se manda llamar la libreria

namespace LaPrueva
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            // Se crea una instancia para el UserControl
            CuadroTexto cuadroTexto = new CuadroTexto()
            {
                Location = new Point(10, 10),   //Se establece la ubicacion del control en el formulario
                Size = new Size(350, 100)   // Se establece el tamaño del control
            };
            this.Controls.Add(cuadroTexto); // Agregar el control al formulario 
        }

        private void btnProbarNumeros_Click(object sender, EventArgs e)
        {
            string texto = txtValidar.Text; // Obtener el texto del TextBox
            bool esSoloNumeros = ValidacionNumerosLetras.EsSoloNumeros(texto);

            if (esSoloNumeros)
            {
                MessageBox.Show("El texto contiene solo numeros.");
            }
            else
            {
                MessageBox.Show("El texto no contiene solo numeros.");
            }
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            string texto = txtValidar.Text; // Obtener el texto del TextBox
            bool esSoloLetras = ValidacionNumerosLetras.EsSoloLetras(texto);

            if (esSoloLetras)
            {
                MessageBox.Show("El texto contiene solo letras.");
            }
            else
            {
                MessageBox.Show("El texto no contiene solo letras.");
            }
        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {
            string texto = txtValidar.Text; // Obtener el texto del TextBox
            bool esAlfanumerico = ValidacionNumerosLetras.EsAlfanumerico(texto);

            if (esAlfanumerico)
            {
                MessageBox.Show("El texto es alfanumerico.");
            }
            else
            {
                MessageBox.Show("El texto no es alfanumerico.");
            }
        }

        private void btnValRFC_Click(object sender, EventArgs e)
        {
            string rfc = txtRFC.Text; // Obtener el RFC del TextBox
            bool esValido = ValidarRFC.EsRFCValido(rfc);

            if (esValido)
            {
                lblResultado.Text = "El RFC es válido.";
            }
            else
            {
                lblResultado.Text = "El RFC no es válido.";
            }
        }

        private void btnCorregir_Click(object sender, EventArgs e)
        {
            // Evento para corregir el RFC (convertir a mayúsculas)
                string rfc = txtRFC.Text; // Obtener el RFC del TextBox
                string rfcCorregido = ValidarRFC.CorregirRFC(rfc);

                lblResultado.Text = $"RFC corregido: {rfcCorregido}";
            
        }
    }
}
