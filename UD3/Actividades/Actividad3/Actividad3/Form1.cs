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

namespace Actividad3
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conexion = new SqlConnection("server=PO235PDOCAMPO\\SQLEXPRESS;database=CentroEducativo;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            conexion.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexion.Close();
        }

        private void btnMostrarListaActualizada_Click(object sender, EventArgs e)
        {
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

            consulta = "INSERT INTO Alumnos VALUES (@DNI, @Nombre, @Apellidos)";

            SqlCommand comando = new SqlCommand(consulta, conexion);

            comando.Parameters.AddWithValue("@DNI", SqlDbType.VarChar);
            comando.Parameters.AddWithValue("@Nombre", SqlDbType.VarChar);
            comando.Parameters.AddWithValue("@Apellidos", SqlDbType.VarChar);

            comando.Parameters["@DNI"].Value = dni;
            comando.Parameters["@Nombre"].Value = nombre;
            comando.Parameters["@Apellidos"].Value = apellidos;

            numFilasAfectadas = comando.ExecuteNonQuery();

            if (numFilasAfectadas == 1)
            {
                MessageBox.Show("La inserción fue un éxito");
            }
            else
            {
                MessageBox.Show("Algo no funciona");
            }
        }
    }
}
