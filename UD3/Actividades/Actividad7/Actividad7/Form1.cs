using Actividad7.Models;
using Actividad7.Services;

namespace Actividad7
{
    public partial class Form1 : Form
    {
        private readonly IAlumnoService _alumnoService;
        private readonly IMatriculaService _matriculaService;

        public Form1(IAlumnoService alumnoService, IMatriculaService matriculaService)
        {
            InitializeComponent();
            _alumnoService = alumnoService ?? throw new ArgumentNullException(nameof(alumnoService));
            _matriculaService = matriculaService ?? throw new ArgumentNullException(nameof(matriculaService));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar datos iniciales
                CargarAlumnos();
                CargarAsignaturas();
                CargarMatriculas();
                
                // Mostrar mensaje de bienvenida
                MessageBox.Show(
                    "?? ¡Actividad 7 cargada correctamente!\n\n" +
                    "? Tablas relacionadas implementadas:\n" +
                    "  • Alumnos (clave primaria: Id)\n" +
                    "  • Asignaturas\n" +
                    "  • Matriculas (relación por Id)\n\n" +
                    "?? Integridad referencial activada\n\n" +
                    "?? Explora las pestañas para ver la funcionalidad completa",
                    "Actividad 7 - Tablas Relacionadas",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la aplicación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region TAB ALUMNOS - Gestión de Alumnos

        private void btnInsertarAlumno_Click(object sender, EventArgs e)
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
                    MessageBox.Show($"? {message}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposAlumno();
                    CargarAlumnos();
                    CargarMatriculas(); // Actualizar también matrículas
                }
                else
                {
                    MessageBox.Show($"? {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?? Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("?? Ingrese un DNI para buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var alumno = _alumnoService.GetAlumnoByDni(dni);
                
                if (alumno != null)
                {
                    txtNombre.Text = alumno.Nombre;
                    txtApellidos.Text = alumno.Apellidos;
                    
                    // Seleccionar en la lista
                    SeleccionarAlumnoEnLista(alumno);
                    
                    MessageBox.Show($"? Alumno encontrado: {alumno.ToDisplayString()}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"? No se encontró ningún alumno con DNI: {dni}", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtApellidos.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?? Error al buscar alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"? {message}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposAlumno();
                    CargarAlumnos();
                    CargarMatriculas(); // Actualizar también matrículas
                }
                else
                {
                    MessageBox.Show($"? {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?? Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("?? Ingrese un DNI para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"?? ¿Está seguro de que desea eliminar el alumno con DNI {dni}?\n\n" +
                $"?? ATENCIÓN: Si este alumno tiene matrículas asociadas, la operación fallará\n" +
                $"debido a la INTEGRIDAD REFERENCIAL.\n\n" +
                $"¿Continuar?",
                "?? Confirmar eliminación - Integridad Referencial",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                var (success, message) = _alumnoService.DeleteAlumno(dni);
                
                if (success)
                {
                    MessageBox.Show($"? {message}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposAlumno();
                    CargarAlumnos();
                    CargarMatriculas();
                }
                else
                {
                    // Este es el caso importante - mostrar el error de integridad referencial
                    MessageBox.Show(
                        $"?? INTEGRIDAD REFERENCIAL VIOLADA\n\n" +
                        $"{message}\n\n" +
                        $"?? EXPLICACIÓN: La base de datos protege la consistencia de los datos.\n" +
                        $"Para eliminar este alumno, primero debe eliminar todas sus matrículas.",
                        "?? Error de Integridad Referencial",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?? Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarAlumno_Click(object sender, EventArgs e)
        {
            LimpiarCamposAlumno();
        }

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedItem is Alumno alumno)
            {
                txtDNI.Text = alumno.DNI;
                txtNombre.Text = alumno.Nombre;
                txtApellidos.Text = alumno.Apellidos;
                
                // También actualizar el DNI en la pestaña de matrículas
                txtDNIMatricula.Text = alumno.DNI;
            }
        }

        #endregion

        #region TAB MATRICULAS - Gestión de Matrículas

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            string dni = txtDNIMatricula.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("?? Ingrese el DNI del alumno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboAsignaturas.SelectedItem is not Asignatura asignatura)
            {
                MessageBox.Show("?? Seleccione una asignatura", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var (success, message) = _matriculaService.MatricularAlumno(dni, asignatura.ID_Asignatura);
                
                if (success)
                {
                    MessageBox.Show($"? {message}", "Matrícula Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMatriculas();
                }
                else
                {
                    MessageBox.Show($"? {message}", "Error en Matrícula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?? Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarNota_Click(object sender, EventArgs e)
        {
            if (lstMatriculas.SelectedItem is not Matricula matricula)
            {
                MessageBox.Show("?? Seleccione una matrícula de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(txtNota.Text.Trim(), out decimal nota))
            {
                MessageBox.Show("?? Ingrese una nota válida (0-10)", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var (success, message) = _matriculaService.ActualizarNota(matricula.ID_Matricula, nota);
                
                if (success)
                {
                    MessageBox.Show($"? {message}", "Nota Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMatriculas();
                    txtNota.Clear();
                }
                else
                {
                    MessageBox.Show($"? {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?? Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarMatricula_Click(object sender, EventArgs e)
        {
            if (lstMatriculas.SelectedItem is not Matricula matricula)
            {
                MessageBox.Show("?? Seleccione una matrícula de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"??? ¿Está seguro de que desea eliminar esta matrícula?\n\n" +
                $"Alumno: {matricula.NombreCompleto}\n" +
                $"Asignatura: {matricula.CodigoAsignatura} - {matricula.NombreAsignatura}",
                "Confirmar eliminación de matrícula",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                var (success, message) = _matriculaService.EliminarMatricula(matricula.ID_Matricula);
                
                if (success)
                {
                    MessageBox.Show($"? {message}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarMatriculas();
                }
                else
                {
                    MessageBox.Show($"? {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?? Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMatriculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMatriculas.SelectedItem is Matricula matricula)
            {
                txtDNIMatricula.Text = matricula.DNI_Alumno ?? "";
                
                // Seleccionar la asignatura en el combo
                for (int i = 0; i < cboAsignaturas.Items.Count; i++)
                {
                    if (cboAsignaturas.Items[i] is Asignatura asignatura && 
                        asignatura.ID_Asignatura == matricula.ID_Asignatura)
                    {
                        cboAsignaturas.SelectedIndex = i;
                        break;
                    }
                }
                
                // Mostrar la nota si existe
                if (matricula.Nota.HasValue)
                {
                    txtNota.Text = matricula.Nota.Value.ToString("F1");
                }
                else
                {
                    txtNota.Clear();
                }
            }
        }

        #endregion

        #region TAB INTEGRIDAD REFERENCIAL

        private void btnProbarIntegridad_Click(object sender, EventArgs e)
        {
            txtResultadoIntegridad.Clear();
            txtResultadoIntegridad.AppendText("?? INICIANDO PRUEBAS DE INTEGRIDAD REFERENCIAL\n");
            txtResultadoIntegridad.AppendText("=" + new string('=', 60) + "\n\n");

            ProbarIntegridadReferencial();
        }

        private void ProbarIntegridadReferencial()
        {
            // PRUEBA 1: Intentar matricular alumno inexistente
            txtResultadoIntegridad.AppendText("?? PRUEBA 1: Matricular alumno inexistente\n");
            txtResultadoIntegridad.AppendText("Intentando matricular DNI '99999999X' (no existe)...\n");
            
            var (success1, message1) = _matriculaService.MatricularAlumno("99999999X", 1);
            txtResultadoIntegridad.AppendText($"Resultado: {(success1 ? "?" : "?")} {message1}\n\n");

            // PRUEBA 2: Intentar matricular en asignatura inexistente
            txtResultadoIntegridad.AppendText("?? PRUEBA 2: Matricular en asignatura inexistente\n");
            txtResultadoIntegridad.AppendText("Intentando matricular en asignatura ID 999 (no existe)...\n");
            
            // Obtener un alumno existente
            var alumnos = _alumnoService.GetAllAlumnos();
            if (alumnos.Any())
            {
                var (success2, message2) = _matriculaService.MatricularAlumno(alumnos.First().DNI, 999);
                txtResultadoIntegridad.AppendText($"Resultado: {(success2 ? "?" : "?")} {message2}\n\n");
            }
            else
            {
                txtResultadoIntegridad.AppendText("? No hay alumnos en la base de datos para realizar esta prueba.\n\n");
            }

            // PRUEBA 3: Matricular dos veces en la misma asignatura
            txtResultadoIntegridad.AppendText("?? PRUEBA 3: Matrícula duplicada\n");
            if (alumnos.Any())
            {
                var alumno = alumnos.First();
                txtResultadoIntegridad.AppendText($"Matriculando a {alumno.ToDisplayString()} en la primera asignatura...\n");
                
                var (success3a, message3a) = _matriculaService.MatricularAlumno(alumno.DNI, 1);
                txtResultadoIntegridad.AppendText($"Primera matrícula: {(success3a ? "?" : "?")} {message3a}\n");
                
                var (success3b, message3b) = _matriculaService.MatricularAlumno(alumno.DNI, 1);
                txtResultadoIntegridad.AppendText($"Segunda matrícula: {(success3b ? "?" : "?")} {message3b}\n\n");
            }

            // PRUEBA 4: Intentar eliminar alumno con matrículas
            txtResultadoIntegridad.AppendText("??? PRUEBA 4: Eliminar alumno con matrículas\n");
            var matriculas = _matriculaService.GetAllMatriculas();
            if (matriculas.Any())
            {
                var matriculaConAlumno = matriculas.First();
                txtResultadoIntegridad.AppendText($"Intentando eliminar alumno: {matriculaConAlumno.DNI_Alumno}...\n");
                
                var (success4, message4) = _alumnoService.DeleteAlumno(matriculaConAlumno.DNI_Alumno ?? "");
                txtResultadoIntegridad.AppendText($"Resultado: {(success4 ? "?" : "?")} {message4}\n\n");
            }
            else
            {
                txtResultadoIntegridad.AppendText("? No hay matrículas para realizar esta prueba.\n\n");
            }

            txtResultadoIntegridad.AppendText("?? CONCLUSIONES:\n");
            txtResultadoIntegridad.AppendText("=" + new string('=', 20) + "\n");
            txtResultadoIntegridad.AppendText("? La integridad referencial protege la consistencia de los datos\n");
            txtResultadoIntegridad.AppendText("? Previene operaciones que podrían dejar datos huérfanos\n");
            txtResultadoIntegridad.AppendText("? Garantiza que las relaciones entre tablas sean válidas\n");
            txtResultadoIntegridad.AppendText("? Los errores son informativos y ayudan a entender las restricciones\n\n");
            
            txtResultadoIntegridad.AppendText("?? INTEGRIDAD REFERENCIAL = DATOS CONSISTENTES Y CONFIABLES! ??\n");
        }

        #endregion

        #region Métodos Auxiliares

        private void CargarAlumnos()
        {
            try
            {
                var alumnos = _alumnoService.GetAllAlumnos();
                
                lstAlumnos.DataSource = null;
                lstAlumnos.DisplayMember = "ToDisplayString";
                lstAlumnos.ValueMember = "DNI";
                lstAlumnos.DataSource = alumnos;
                
                lblListaAlumnos.Text = $"Lista de Alumnos ({alumnos.Count} registros)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alumnos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarAsignaturas()
        {
            try
            {
                var asignaturas = _matriculaService.GetAsignaturasDisponibles();
                
                cboAsignaturas.DataSource = null;
                cboAsignaturas.DisplayMember = "ToDisplayString";
                cboAsignaturas.ValueMember = "ID_Asignatura";
                cboAsignaturas.DataSource = asignaturas;
                cboAsignaturas.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar asignaturas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarMatriculas()
        {
            try
            {
                var matriculas = _matriculaService.GetAllMatriculas();
                
                lstMatriculas.DataSource = null;
                lstMatriculas.DisplayMember = "ToDisplayString";
                lstMatriculas.DataSource = matriculas;
                
                lblListaMatriculas.Text = $"Lista de Matrículas ({matriculas.Count} registros)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar matrículas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposAlumno()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDNI.Focus();
        }

        private void SeleccionarAlumnoEnLista(Alumno alumno)
        {
            for (int i = 0; i < lstAlumnos.Items.Count; i++)
            {
                if (lstAlumnos.Items[i] is Alumno item && item.DNI == alumno.DNI)
                {
                    lstAlumnos.SelectedIndex = i;
                    break;
                }
            }
        }

        #endregion
    }
}