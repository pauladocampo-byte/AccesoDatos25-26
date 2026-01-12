using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Actividad4
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection conexion;
        
        public Form1(IConfiguration configuration)
        {
            InitializeComponent();
            string connectionString = configuration.GetConnectionString("Actividad4ConnectionString") 
                ?? throw new InvalidOperationException("Connection string 'Actividad4ConnectionString' not found");
            
            conexion = new SqlConnection(connectionString);
            conexion.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion?.Close();
        }

        private void btnMostrarListaActualizada_Click(object sender, EventArgs e)
        {
            txtListaAlumnos.Clear(); // Limpiar antes de mostrar
            
            string consulta = "SELECT DNI, Nombre, Apellidos FROM Alumnos";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                txtListaAlumnos.AppendText(registros["DNI"].ToString());
                txtListaAlumnos.AppendText("-");
                txtListaAlumnos.AppendText(registros["Nombre"].ToString());
                txtListaAlumnos.AppendText("-");
                txtListaAlumnos.AppendText(registros["Apellidos"].ToString());
                txtListaAlumnos.AppendText(Environment.NewLine);
            }

            registros.Close();
        }

        private void btnInsertarAlumno_Click_1(object sender, EventArgs e)
        {
            string dni, nombre, apellidos, consulta;
            int numFilasAfectadas;

            dni = txtDNI.Text;
            nombre = txtNombre.Text;
            apellidos = txtApellidos.Text;

            // Validación básica
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellidos))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            consulta = "INSERT INTO Alumnos VALUES (@DNI, @Nombre, @Apellidos)";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@DNI", dni);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);

            try
            {
                numFilasAfectadas = comando.ExecuteNonQuery();

                if (numFilasAfectadas == 1)
                {
                    MessageBox.Show("La inserción fue un éxito");
                    // Limpiar campos después de insertar
                    txtDNI.Clear();
                    txtNombre.Clear();
                    txtApellidos.Clear();
                }
                else
                {
                    MessageBox.Show("Algo no funciona");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}");
            }
        }
    }
}
