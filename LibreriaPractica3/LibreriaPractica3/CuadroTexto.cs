using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LibreriaPractica3
{
    public partial class CuadroTexto : UserControl
    {
        // Definir los tipos de entrada permitidos
        public enum InputType { Numbers, Letters, Alphanumeric }

        // Campo para almacenar el tipo de entrada
        private InputType inputType = InputType.Alphanumeric;

        // Propiedad para acceder y modificar el tipo de entrada
        public InputType InputMode
        {
            get { return inputType; }
            set { inputType = value; }
        }

        // El TextBox para mostrar el texto
        private TextBox txtPersonalizado;

        // Botones para cambiar el tipo de entrada
        private Button btnNumeros;
        private Button btnLetras;
        private Button btnAmbos;

        public CuadroTexto()
        {
            InitializeComponent();
            InitializeControls(); // Inicializar los controles (TextBox y botones)
        }

        private void InitializeControls()
        {
            // Crear y configurar el TextBox
            txtPersonalizado = new TextBox
            {
                Location = new Point(10, 10),
                Size = new Size(300, 30),
                BorderStyle = BorderStyle.FixedSingle
            };
            txtPersonalizado.TextChanged += CustomTextBox_TextChanged;
            this.Controls.Add(txtPersonalizado);

            // Crear y configurar los botones
            btnNumeros = new Button
            {
                Text = "Solo Números",
                Location = new Point(10, 50),
                Size = new Size(100, 30)
            };
            btnNumeros.Click += BtnNumeros_Click;
            this.Controls.Add(btnNumeros);

            btnLetras = new Button
            {
                Text = "Solo Letras",
                Location = new Point(120, 50),
                Size = new Size(100, 30)
            };
            btnLetras.Click += BtnLetras_Click;
            this.Controls.Add(btnLetras);

            btnAmbos = new Button
            {
                Text = "Alfanumérico",
                Location = new Point(230, 50),
                Size = new Size(100, 30)
            };
            btnAmbos.Click += BtnAlfanum_Click;
            this.Controls.Add(btnAmbos);
        }

        // Evento que valida el texto al cambiar
        private void CustomTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = txtPersonalizado.Text;
            bool isValid = false;

            // Validación según el tipo de entrada
            if (inputType == InputType.Numbers)
            {
                isValid = Regex.IsMatch(text, @"^\d+$"); // Solo números
            }
            else if (inputType == InputType.Letters)
            {
                isValid = Regex.IsMatch(text, @"^[a-zA-Z]+$"); // Solo letras
            }
            else if (inputType == InputType.Alphanumeric)
            {
                isValid = Regex.IsMatch(text, @"^[a-zA-Z0-9]+$"); // Letras y números
            }

            // Cambiar el borde y color de fondo según la validez
            txtPersonalizado.BorderStyle = isValid ? BorderStyle.FixedSingle : BorderStyle.Fixed3D;
            txtPersonalizado.BackColor = isValid ? Color.White : Color.LightCoral;
        }

        // Métodos para los botones
        private void BtnNumeros_Click(object sender, EventArgs e)
        {
            InputMode = InputType.Numbers; // Cambiar a solo números
        }

        private void BtnLetras_Click(object sender, EventArgs e)
        {
            InputMode = InputType.Letters; // Cambiar a solo letras
        }

        private void BtnAlfanum_Click(object sender, EventArgs e)
        {
            InputMode = InputType.Alphanumeric; // Cambiar a alfanumérico (letras y números)
        }
    }
}
