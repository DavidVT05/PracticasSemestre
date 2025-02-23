using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadroTexto
{
    public partial class CuadroText: UserControl
    {
        public enum InputType { Numeros, Letras, Ambos }
        public InputType ValorEntrada { get; set; } = InputType.Ambos;
        public CuadroText()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (ValorEntrada == InputType.Numeros && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                this.BackColor = Color.Coral;
            }
            else if (ValorEntrada == InputType.Letras && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                this.BackColor = Color.Bisque;
            }
            else
            {
                this.BackColor = Color.Black;
            }
        }
    }
}
