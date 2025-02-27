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

    //Se realiza un boton personalizado que cambia de color al pasar el mouse y darle click y tiene una confirmacion
    public partial class Boton1: UserControl
    {
        private Color colorOriginal; //Se inicializa la variable
        
        public Boton1() //Se realia el contructor para inicializar el boton y los eventos persolaizados
        {
            InitializeComponent();
            colorOriginal = this.BackColor;
            this.MouseEnter += (s, e) => this.BackColor = Color.DarkBlue;
            this.MouseLeave += (s, e) => this.BackColor = colorOriginal;
            this.DoubleClick += btnAgregar_Click;
        }
        //Se realiza el evento para que el texBox muestre un cuadro de confirmacion, al darle click
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
