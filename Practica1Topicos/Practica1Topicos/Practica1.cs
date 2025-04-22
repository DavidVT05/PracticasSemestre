namespace Practica1Topicos
{
    public partial class Practica1 : Form
    {
        
        public Practica1()
        {
            InitializeComponent();
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text == "" || txtTelefono.Text == "" || txtCorreo.Text  == "")
            {
                MessageBox.Show("Quedo un espacio vacio, favor de rellenar todos los espacios");
            }
            else
            {
                string contacto = $"Nombre: {txtNombre.Text}, Telefono: {txtTelefono.Text}, Correo: {txtCorreo.Text}";
                
                
                if (lstLista.Items.Contains(contacto))
                {
                    MessageBox.Show("El contacto ya fue ingresado a la agenda.");
                }
                else
                {
                    lstLista.Items.Add(contacto);
                    MessageBox.Show("El contacto se agrego correctamente.");
                    ActualizarTamano(); //se manda llamar la funcion para ajustar el tamaño
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var selectedItem = lstLista.SelectedItem;
            if (selectedItem != null)
            {
                lstLista.Items.Remove(selectedItem);
                MessageBox.Show("Se elimino correctamente el contacto.");
            }
            else
            {
                MessageBox.Show("Se debe de seleccionar un contacto a eliminar.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este programa sirve como una agenda de contactos donde se iran agregando uno por uno el nombre, telefono y correo electronico de cada usuario, asi mismo podremos eliminar contactos");
        }
        //funcion para ajustar el tamaño de el listbox a los datos ingresados
        private void ActualizarTamano()
        {
            lstLista.Height = lstLista.ItemHeight * lstLista.Items.Count + 20;
        }
    }
}
