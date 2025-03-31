using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class frmSQL : Form
    {
        // Se establecen las vareiables para almacenar los datos de conexión a la base de datos
        private string Servidor = "DESKTOP-MV8BMK3";
        private string Basedatos = "master";
        private string UsuarioId = "sa";
        private string Password = "soldado123";
        //Método para obtener la cadena de conexión a la base de datos
        private string ObtenerConexion()
        {
            return $"Server={Servidor};Database={Basedatos};User Id={UsuarioId};Password={Password}";
        }
        //Metodo para ejecutar los comandos SQL en la base de datos
        private void EjecutaComando(string ConsultaSQL)
        {
            try
            {
                //Se establece para la conexión con la base de datos
                using (SqlConnection conn = new SqlConnection(ObtenerConexion()))
                {
                    conn.Open(); //Se abre la conexión a la base de datos
                    using (SqlCommand cmd = new SqlCommand(ConsultaSQL, conn))
                    {
                        cmd.ExecuteNonQuery(); //refrescamos los datos en el DataGridView
                    }
                }
                llenarGrid();
            }
            catch (SqlException Ex)
            {
                //Se muestra un mensaje de error si existe una excepción SQL
                MessageBox.Show(Ex.Message); 
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema"); // Muestra un mensaje de error generico
            }
        }
        //Metodo para llenar el DataGridView con los datos de la tabla Alumnnos
        private void llenarGrid()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ObtenerConexion()))
                {
                    conn.Open(); //Abrimos la conexión
                    //Se realiza la consulta SQL para obtener todos los registros
                    string sqlQuery = "SELECT * FROM Alumnos"; 
                    SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Alumnos"); //Llea el dataset con los datos obtenidos
                    dgvAlumnos.DataSource = ds.Tables[0]; // Muestra los datos en el DataGridView
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message); //Muestra un mensaje de error si hay una excepción SQL
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema");// Muestra un mensaje de error generico
            }
        }
        //Constructor del formulario
        public frmSQL()
        {
            InitializeComponent(); //Inicializa los componentes del formulario
        }
        //Metodo para insertar un nuevo alumno en la base de datos
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos obligatorios no estén vacios
            if (string.IsNullOrWhiteSpace(txtNoControl.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }
            // Ejecuta la consulta SQL para insertar un nuevo registro
            EjecutaComando($"INSERT INTO Alumnos (NoControl, nombre, carrera) VALUES ('{txtNoControl.Text}', '{txtNombre.Text}', {txtCarrera.Text})");
        }
        // Metodo para actualizar un alumno existente en la base de datos
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos obligatorios no esten vacios
            if (string.IsNullOrWhiteSpace(txtNoControl.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios para actualizar");
                return;
            }
            // Ejecuta la consulta SQL para actualizar el registro
            EjecutaComando($"UPDATE Alumnos SET nombre = '{txtNombre.Text}', carrera = {txtCarrera.Text} WHERE NoControl = '{txtNoControl.Text}'");
        }
        // Metodo para eliminar un alumno de la base de datos
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verifica que se haya ingresado el NoControl
            if (string.IsNullOrWhiteSpace(txtNoControl.Text))
            {
                MessageBox.Show("Ingrese el NoControl para borrar");
                return;
            }
            // Ejecuta la consulta SQL para eliminar el registro
            EjecutaComando($"DELETE FROM Alumnos WHERE NoControl = '{txtNoControl.Text}'");
        }
        // Metodo para buscar un alumno por NoControl y mostrarlo en el DataGridView
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verifica que se haya ingresado el NoControl
            if (string.IsNullOrWhiteSpace(txtNoControl.Text))
            {
                MessageBox.Show("Ingrese el NoControl para buscar");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(ObtenerConexion()))
                {
                    conn.Open(); // Abre la conexión
                    string sqlQuery = $"SELECT * FROM Alumnos WHERE NoControl = '{txtNoControl.Text}'";
                    SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Alumnos");
                    dgvAlumnos.DataSource = ds.Tables[0]; // Muestra los datos obtenidos
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema");
            }
        }
        // Metodo para crear la base de datos ESCOLAR
        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE DATABASE ESCOLAR");
        }
        // Metodo para crear la tabla Alumnos en la base de datos
        private void btnCreaTabla_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE TABLE Alumnos (NoControl varchar(10) PRIMARY KEY, nombre varchar(50), carrera int)");
        }
        // Metodo para refrescar los datos del DataGridView
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }
        // Evento que se ejecuta cuando se carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid(); // Carga los datos al iniciar el formulario
        }
    }
}
