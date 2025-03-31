using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prueba
{
    public partial class frmMySQL : Form
    {
        //Variables privadas para almacenar los datos de conexión a la basee de datos MySQL
        private string Servidor = "localhost";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "root";
        private string Password = "";
        // Metodo para obtener la cadena de conexión a la base de datos
        private string ObtenerConexion()
        {
            return $"Server={Servidor};Database={Basedatos};User Id={UsuarioId};Password={Password};SslMode=none";
        }
        // Metodo para ejecutar comandos SQL en la base de datos con parámetros opcionales
        private void EjecutaComando(string ConsultaSQL, Dictionary<string, object> parametros = null)
        {
            try
            {
                // Establece la conexión con la base de datos
                using (MySqlConnection conn = new MySqlConnection(ObtenerConexion()))
                {
                    conn.Open(); // Abrimos la conexión
                    using (MySqlCommand cmd = new MySqlCommand(ConsultaSQL, conn))
                    {
                        // Si hay parametros, los agrega a la consulta para prevenir SQL Injection
                        if (parametros != null)
                        {
                            foreach (var param in parametros)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        cmd.ExecuteNonQuery(); // Ejecuta la consulta SQL
                    }
                }
                llenarGrid(); // Refresca los datos en el DataGridView
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message); // Muestra un mensaje de error si hay una excepción de MySQL
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema"); // Muestra un mensaje de error generico
            }
        }
        // Metodo para llenar el DataGridView con los datos de la tabla "Alumnos"
        private void llenarGrid()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ObtenerConexion()))
                {
                    conn.Open(); // Abre la conexión
                    string sqlQuery = "SELECT * FROM Alumnos"; // Consulta SQL para obtener todos los registros
                    MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuery, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Alumnos"); // Llena el dataset con los datos obtenidos
                    dgvAlumnos.DataSource = ds.Tables[0]; // Muestra los datos en el DataGridView
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message); // Muestra un mensaje de error si hay una excepción SQL
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema");  // Muestra un mensaje de error genérico
            }
        }
        // Constructor del formulario
        public frmMySQL()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }
        // Metodo para crear la base de datos "ESCOLAR"
        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE DATABASE ESCOLAR");
        }
        // Metodo para crear la tabla "Alumnos" en la base de datos
        private void btnCreaTabla_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE TABLE Alumnos (NoControl VARCHAR(10) PRIMARY KEY, nombre VARCHAR(50), carrera INT)");
        }
        // Metodo para refrescar los datos del DataGridView
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }
        // Metodo para insertar un nuevo alumno en la base de datos
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos obligatorios no esten vacios
            if (string.IsNullOrWhiteSpace(txtNoControl.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            var parametros = new Dictionary<string, object>
        {
            {"@NoControl", txtNoControl.Text},
            {"@Nombre", txtNombre.Text},
            {"@Carrera", txtCarrera.Text}
        };

            EjecutaComando("INSERT INTO Alumnos (NoControl, nombre, carrera) VALUES (@NoControl, @Nombre, @Carrera)", parametros);
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

            var parametros = new Dictionary<string, object>
        {
            {"@NoControl", txtNoControl.Text},
            {"@Nombre", txtNombre.Text},
            {"@Carrera", txtCarrera.Text}
        };

            EjecutaComando("UPDATE Alumnos SET nombre = @Nombre, carrera = @Carrera WHERE NoControl = @NoControl", parametros);
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

            var parametros = new Dictionary<string, object>
        {
            {"@NoControl", txtNoControl.Text}
        };

            EjecutaComando("DELETE FROM Alumnos WHERE NoControl = @NoControl", parametros);
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
                using (MySqlConnection conn = new MySqlConnection(ObtenerConexion()))
                {
                    conn.Open(); // Abre la conexión
                    string sqlQuery = "SELECT * FROM Alumnos WHERE NoControl = @NoControl";
                    MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuery, conn);
                    adp.SelectCommand.Parameters.AddWithValue("@NoControl", txtNoControl.Text);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Alumnos");
                    dgvAlumnos.DataSource = ds.Tables[0]; // Muestra los datos obtenidos
                }
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en el sistema");
            }
        }
        // Evento que se ejecuta cuando se carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid(); // Carga los datos al iniciar el formulario
        }
    }
}
