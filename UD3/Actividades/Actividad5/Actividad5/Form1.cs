using Actividad5.Models;
using Actividad5.Services;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Actividad5
{
    public partial class Form1 : Form
    {
        private readonly IAlumnoService _alumnoService;

        public Form1(IAlumnoService alumnoService)
        {
            InitializeComponent();
            _alumnoService = alumnoService ?? throw new ArgumentNullException(nameof(alumnoService));
            
            // Configurar el formulario
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListaAlumnos();
        }

        private void btnMostrarListaActualizada_Click(object sender, EventArgs e)
        {
            CargarListaAlumnos();
        }

        private void btnInsertarAlumno_Click_1(object sender, EventArgs e)
        {
            // Crear el objeto alumno desde el formulario
            var alumno = new Alumno
            {
                DNI = txtDNI.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim()
            };

            try
            {
                // Usar el servicio para crear el alumno
                var (success, message) = _alumnoService.CreateAlumno(alumno);
                
                if (success)
                {
                    MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarListaAlumnos(); // Recargar la lista
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Ingrese un DNI para buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var alumno = _alumnoService.GetAlumnoByDni(dni);
                
                if (alumno != null)
                {
                    txtNombre.Text = alumno.Nombre;
                    txtApellidos.Text = alumno.Apellidos;
                    MessageBox.Show("Alumno encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún alumno con ese DNI", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtApellidos.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno
            {
                DNI = txtDNI.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim()
            };

            try
            {
                var (success, message) = _alumnoService.UpdateAlumno(alumno);
                
                if (success)
                {
                    MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarListaAlumnos();
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Ingrese un DNI para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el alumno con DNI {dni}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                var (success, message) = _alumnoService.DeleteAlumno(dni);
                
                if (success)
                {
                    MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarListaAlumnos();
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga la lista de alumnos desde la base de datos
        /// </summary>
        private void CargarListaAlumnos()
        {
            try
            {
                txtListaAlumnos.Clear();
                txtListaAlumnos.AppendText("Cargando alumnos..." + Environment.NewLine);
                
                var alumnos = _alumnoService.GetAllAlumnos();
                
                txtListaAlumnos.Clear();
                
                if (alumnos.Any())
                {
                    txtListaAlumnos.AppendText($"=== LISTA DE ALUMNOS ({alumnos.Count}) ===" + Environment.NewLine);
                    txtListaAlumnos.AppendText(Environment.NewLine);
                    
                    foreach (var alumno in alumnos)
                    {
                        txtListaAlumnos.AppendText(alumno.ToString() + Environment.NewLine);
                    }
                }
                else
                {
                    txtListaAlumnos.AppendText("No hay alumnos registrados en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                txtListaAlumnos.Clear();
                txtListaAlumnos.AppendText($"Error al cargar alumnos: {ex.Message}");
            }
        }

        /// <summary>
        /// Limpia todos los campos del formulario
        /// </summary>
        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDNI.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
