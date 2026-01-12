using Actividad6.Models;
using Actividad6.Services;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Actividad6
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
            CargarListBoxItemsAdd();
            CargarListBoxDataSource();
        }

        private void btnMostrarListaActualizada_Click(object sender, EventArgs e)
        {
            CargarListaAlumnos();
        }

        #region CRUD Operations

        private void btnInsertarAlumno_Click_1(object sender, EventArgs e)
        {
            var alumno = new Alumno
            {
                DNI = txtDNI.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim()
            };

            try
            {
                var (success, message) = _alumnoService.CreateAlumno(alumno);
                
                if (success)
                {
                    MessageBox.Show(message, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    RefrescarTodasLasListas();
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
                    
                    // Seleccionar en ambos ListBox
                    SeleccionarEnListBoxItemsAdd(alumno);
                    SeleccionarEnListBoxDataSource(alumno);
                    
                    MessageBox.Show("Alumno encontrado y seleccionado en ambos ListBox", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    RefrescarTodasLasListas();
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
                    RefrescarTodasLasListas();
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

        #endregion

        #region MÉTODO 1: Items.Add() - Manual

        /// <summary>
        /// MÉTODO 1: Carga alumnos usando Items.Add() - Enfoque manual
        /// Este es el método tradicional donde añadimos elementos uno por uno
        /// </summary>
        private void CargarListBoxItemsAdd()
        {
            try
            {
                // 1. Limpiar items existentes
                lstAlumnosItemsAdd.Items.Clear();
                
                // 2. Obtener datos del servicio
                var alumnos = _alumnoService.GetAllAlumnos();
                
                if (alumnos.Any())
                {
                    // 3. Configurar DisplayMember ANTES de añadir items
                    lstAlumnosItemsAdd.DisplayMember = "ToDisplayString";
                    
                    // 4. Añadir cada alumno manualmente con foreach
                    foreach (var alumno in alumnos)
                    {
                        lstAlumnosItemsAdd.Items.Add(alumno);
                    }
                }
                
                // 5. Actualizar etiqueta informativa
                label5.Text = $"Items.Add - {alumnos.Count} elementos";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ListBox (Items.Add): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarItemsAdd_Click(object sender, EventArgs e)
        {
            CargarListBoxItemsAdd();
            MessageBox.Show("?? MÉTODO Items.Add() RECARGADO\n\n" +
                          "Características de este método:\n\n" +
                          "? Control manual sobre cada elemento\n" +
                          "? Se añade item por item con foreach\n" +
                          "? DisplayMember se configura antes de añadir\n" +
                          "? Más código pero más control\n" +
                          "? Ideal para casos donde necesitas lógica específica\n\n" +
                          "Código usado:\n" +
                          "foreach (var alumno in alumnos)\n" +
                          "{\n" +
                          "    lstAlumnos.Items.Add(alumno);\n" +
                          "}",
                          "Método Items.Add()", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstAlumnosItemsAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento se dispara automáticamente al cambiar selección
            // En este caso no hacemos nada automático
        }

        private void btnSeleccionarItemsAdd_Click(object sender, EventArgs e)
        {
            if (lstAlumnosItemsAdd.SelectedItem != null)
            {
                var alumno = (Alumno)lstAlumnosItemsAdd.SelectedItem;
                
                txtDNI.Text = alumno.DNI;
                txtNombre.Text = alumno.Nombre;
                txtApellidos.Text = alumno.Apellidos;

                MessageBox.Show($"?? SELECCIÓN CON Items.Add()\n\n" +
                              $"Alumno: {alumno.ToDisplayString()}\n\n" +
                              $"Cómo funciona:\n" +
                              $"• SelectedItem devuelve: object\n" +
                              $"• Se hace casting: (Alumno)SelectedItem\n" +
                              $"• Acceso directo a todas las propiedades\n" +
                              $"• Objeto completo disponible inmediatamente\n\n" +
                              $"Código:\n" +
                              $"var alumno = (Alumno)lstAlumnos.SelectedItem;",
                              "Selección Items.Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno de la lista (Items.Add)", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SeleccionarEnListBoxItemsAdd(Alumno alumno)
        {
            for (int i = 0; i < lstAlumnosItemsAdd.Items.Count; i++)
            {
                var item = (Alumno)lstAlumnosItemsAdd.Items[i];
                if (item.DNI == alumno.DNI)
                {
                    lstAlumnosItemsAdd.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion

        #region MÉTODO 2: DataSource - Automático

        /// <summary>
        /// MÉTODO 2: Carga alumnos usando DataSource - Enfoque automático
        /// Este método vincula directamente una lista completa al control
        /// </summary>
        private void CargarListBoxDataSource()
        {
            try
            {
                // 1. Obtener datos del servicio
                var alumnos = _alumnoService.GetAllAlumnos();
                
                // 2. Configurar las propiedades de binding ANTES de asignar DataSource
                lstAlumnosDataSource.DisplayMember = "ToDisplayString";  // Qué mostrar
                lstAlumnosDataSource.ValueMember = "DNI";               // Qué valor obtener
                
                // 3. ¡Una sola línea hace todo el trabajo!
                lstAlumnosDataSource.DataSource = alumnos;
                
                // 4. Actualizar etiqueta informativa
                label6.Text = $"DataSource - {alumnos.Count} elementos";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ListBox (DataSource): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarDataSource_Click(object sender, EventArgs e)
        {
            CargarListBoxDataSource();
            MessageBox.Show("? MÉTODO DataSource RECARGADO\n\n" +
                          "Características de este método:\n\n" +
                          "? Vinculación automática con UNA SOLA línea\n" +
                          "? DisplayMember: qué propiedad mostrar\n" +
                          "? ValueMember: qué valor obtener con SelectedValue\n" +
                          "? Menos código, más automático\n" +
                          "? Sincronización automática con la fuente\n" +
                          "? Más eficiente para listas grandes\n\n" +
                          "Código usado:\n" +
                          "lstAlumnos.DisplayMember = \"ToDisplayString\";\n" +
                          "lstAlumnos.ValueMember = \"DNI\";\n" +
                          "lstAlumnos.DataSource = alumnos;",
                          "Método DataSource", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstAlumnosDataSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento se dispara automáticamente al cambiar selección
            // En este caso no hacemos nada automático
        }

        private void btnSeleccionarDataSource_Click(object sender, EventArgs e)
        {
            if (lstAlumnosDataSource.SelectedValue != null)
            {
                // OPCIÓN A: Usar SelectedValue (obtiene el DNI gracias a ValueMember)
                string dni = lstAlumnosDataSource.SelectedValue.ToString()!;
                var alumno = _alumnoService.GetAlumnoByDni(dni);
                
                if (alumno != null)
                {
                    txtDNI.Text = alumno.DNI;
                    txtNombre.Text = alumno.Nombre;
                    txtApellidos.Text = alumno.Apellidos;

                    // OPCIÓN B: También se puede usar SelectedItem (igual que Items.Add)
                    var alumnoDirecto = (Alumno)lstAlumnosDataSource.SelectedItem!;

                    MessageBox.Show($"? SELECCIÓN CON DataSource\n\n" +
                                  $"Alumno: {alumno.ToDisplayString()}\n\n" +
                                  $"Dos formas de obtener datos:\n\n" +
                                  $"?? OPCIÓN A - SelectedValue:\n" +
                                  $"   • Devuelve: '{dni}' (ValueMember)\n" +
                                  $"   • Buscar: GetAlumnoByDni(dni)\n" +
                                  $"   • Ventaja: Solo obtienes el valor clave\n\n" +
                                  $"?? OPCIÓN B - SelectedItem:\n" +
                                  $"   • Devuelve: objeto completo\n" +
                                  $"   • Casting: (Alumno)SelectedItem\n" +
                                  $"   • Ventaja: Acceso directo al objeto\n\n" +
                                  $"En este ejemplo usamos OPCIÓN A para mostrar la diferencia.",
                                  "Selección DataSource", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno de la lista (DataSource)", 
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SeleccionarEnListBoxDataSource(Alumno alumno)
        {
            // Con DataSource, podemos buscar por valor o por índice
            for (int i = 0; i < lstAlumnosDataSource.Items.Count; i++)
            {
                var item = (Alumno)lstAlumnosDataSource.Items[i];
                if (item.DNI == alumno.DNI)
                {
                    lstAlumnosDataSource.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion

        #region Métodos Auxiliares

        /// <summary>
        /// Carga la lista de alumnos en el TextBox (método tradicional)
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
        /// Refresca todas las listas después de operaciones CRUD
        /// </summary>
        private void RefrescarTodasLasListas()
        {
            CargarListaAlumnos();        // TextBox tradicional
            CargarListBoxItemsAdd();     // ListBox con Items.Add()
            CargarListBoxDataSource();   // ListBox con DataSource
        }

        /// <summary>
        /// Limpia todos los campos del formulario
        /// </summary>
        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            lstAlumnosItemsAdd.ClearSelected();
            lstAlumnosDataSource.ClearSelected();
            txtDNI.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        #endregion

        #region Eventos placeholder para evitar errores de compilación

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Método original - mantenido para compatibilidad
        }

        private void btnSeleccionarListBox_Click(object sender, EventArgs e)
        {
            // Método original - mantenido para compatibilidad
        }

        private void SeleccionarEnListBox(Alumno alumno)
        {
            // Método original - mantenido para compatibilidad
        }

        private void CargarListBox()
        {
            // Método original - mantenido para compatibilidad
        }

        #endregion
    }
}