using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaPractica3
{
    public partial class Boton : UserControl
    {
        public Boton()
        {
            // Establecer el evento del mouse
            this.MouseEnter += (sender, e) => this.BackColor = hoverColor;
            this.MouseLeave += (sender, e) => this.BackColor = DefaultBackColor;
        }
        // Propiedad para cambiar color al pasar el cursor
        private Color hoverColor = Color.LightBlue;
        public Color HoverColor
        {
            get { return hoverColor; }
            set { hoverColor = value; }
        }
        // Evento de doble clic con confirmacion
        public event EventHandler DoubleClickConfirmed;

        protected override void OnDoubleClick(EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que deseas continuar?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DoubleClickConfirmed?.Invoke(this, e);
            }
        }
    }
}
