using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotonLibreria
{
    public partial class Boton1: UserControl
    {
        private Color colorOriginal;
        public Boton1()
        {
            InitializeComponent();
            colorOriginal = this.BackColor;
            this.MouseEnter += (s, e) => this.BackColor = Color.DarkBlue;
            this.MouseLeave += (s, e) => this.BackColor = colorOriginal;
            this.DoubleClick += btnAgregar_Click;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Daras click, estas seguro?", "Aceptar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return;
            }
        }
    }
}
