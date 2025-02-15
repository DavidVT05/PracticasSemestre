using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace GUI_Dinamica
{
    public partial class Practica2 : Form
    {
        private FlowLayoutPanel Imagen;
        private Button btnAgregar;
        private MenuStrip menu;
        private Button btnSalir;
        private List<PictureBox> imagina = new List<PictureBox>();
        public Practica2()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración de la ventana
            this.Text = "Galeria de imagenes.";
            this.Size = new Size(800, 600);
            //MenuStrip
            menu = new MenuStrip();
            this.MainMenuStrip = menu;
            //contenido del menu
            ToolStripMenuItem menuCarpeta = new ToolStripMenuItem("Carpeta.");
            ToolStripMenuItem menuImagen = new ToolStripMenuItem("Agregar imagen.");
            menuImagen.Click += BtnAgregar_Click;
            ToolStripMenuItem menuSalir = new ToolStripMenuItem("Salir.");
            menuSalir.Click += menuSalir_Click;
            menuCarpeta.DropDownItems.Add(menuImagen);
            menuCarpeta.DropDownItems.Add(new ToolStripSeparator());
            menuCarpeta.DropDownItems.Add(menuSalir);
            //Agregar las opciones al menu
            menu.Items.Add(menuCarpeta);
            this.Controls.Add(menu);
            this.MainMenuStrip = menu;
            menu.Dock = DockStyle.Top;
            //Panel para mostrar ls imagenes en miniatura
            Imagen = new FlowLayoutPanel();
            Imagen.Dock = DockStyle.Fill;
            Imagen.AutoScroll = true;
            this.Controls.Add(Imagen);
            //Boton para agregar las imagenes
            btnAgregar = new Button();
            btnAgregar.Text = "Agrega la imagen.";
            btnAgregar.Size = new Size(150, 30);
            btnAgregar.Location = new Point(20, 40);
            btnAgregar.Click += BtnAgregar_Click;
            this.Controls.Add(btnAgregar);
            //Boton para salir
            btnSalir = new Button();
            btnSalir.Text = "Salir.";
            btnSalir.Size = new Size(100, 30);
            btnSalir.Location = new Point(20, 300);
            btnSalir.Click += BtnSalir_Click;
            this.Controls.Add(btnSalir);
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {

        }
        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrir = new OpenFileDialog())
            {
                abrir.Title = "Seleccionar imagen.";
                abrir.Filter = " Agrega las imagenes (*.jpg; *png;) | *.jpg; *pnj";
                abrir.Multiselect = false;
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    string panelImagen = abrir.FileName;
                    AgregarImag(panelImagen);
                }
            }
        }
        private void AgregarImag(string panelImagen)
        {
            //Crearemos las miniaturas para las imagenes
            PictureBox picture = new PictureBox();
            picture.Image = Image.FromFile(panelImagen);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.Size = new Size(150, 150);
            picture.Padding = new Padding(10);
            picture.Cursor = Cursors.Hand;
            picture.Tag = panelImagen; // se guarda la imagen de tipo tag
            //Agregar imagen al realisar click
            picture.Click += (sender, e) => AbrirImagen(panelImagen);
            //menu para eliminar fotos
            ContextMenuStrip Cmenu = new ContextMenuStrip();
            ToolStripMenuItem eliminar = new ToolStripMenuItem("Eliminar.");
            eliminar.Click += (sender, e) =>
            {
                Imagen.Controls.Remove(picture);
                imagina.Remove(picture);
            };
            Cmenu.Items.Add(eliminar);
            picture.ContextMenuStrip = Cmenu;
            imagina.Add(picture);
            Imagen.Controls.Add(picture);
        }
        private void AbrirImagen(String panelImagen)
        {
            //SE crea una nueva ventana para mostrar la imagen en grande
            Form fullImagenes = new Form();
            fullImagenes.Text = Path.GetFileName(panelImagen);
            fullImagenes.Size = new Size(800, 600);
            fullImagenes.StartPosition = FormStartPosition.CenterScreen;
            // creamos el cuadro para mostrar la imagen
            PictureBox teximagen = new PictureBox();
            teximagen.Image = Image.FromFile(panelImagen);
            teximagen.Dock = DockStyle.Fill;
            teximagen.SizeMode = PictureBoxSizeMode.Zoom;
            //Agregamos el cuadroal form inicial
            fullImagenes.Controls.Add(teximagen);
            //se muestr el form como ventana independiente
            fullImagenes.ShowDialog();
        }
    }
}
