using Actividad3.Models;
using Actividad3.Services;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        private EquipoService _equipoService;
        private FutbolistaService _futbolistaService;


        // Enum para controlar el tipo de operación
        private enum TipoOperacion { Insertar, Actualizar }

        private TipoOperacion _operacionEquipo = TipoOperacion.Insertar;
        private TipoOperacion _operacionFutbolista = TipoOperacion.Insertar;

        public Form1(EquipoService equipoService, FutbolistaService futbolistaService)
        {
            _equipoService = equipoService;
            _futbolistaService = futbolistaService;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEquipos();
        }

        private void CargarEquipos()
        {
            var equipos = _equipoService.GetAllEquipos();
            // Lógica para mostrar los equipos en la interfaz de usuario
            lbEquipos.DataSource = equipos.ToList();

            cbEquipoSeleccionado.DataSource = equipos.ToList(); // Nueva lista para el combo
            cbEquipoSeleccionado.SelectedIndex = -1; // Sin selección inicial en el combo
        }

        private void lbEquipos_DoubleClick(object sender, EventArgs e)
        {
            if (lbEquipos.SelectedItem is Equipo equipo)
            {
                //CargarFutbolistasDelEquipo(equipo.Nombre);
                CargarFutbolistasDelEquipoByCodigo(equipo.Codigo);
            }
        }

        /// <summary>
        /// Carga los futbolistas del equipo seleccionado.
        /// </summary>
        private void CargarFutbolistasDelEquipo(string nombreEquipo)
        {
            try
            {
                var futbolistas = _futbolistaService.GetFutbolistasByEquipoNombre(nombreEquipo);
                lbFutbolistas.DataSource = futbolistas.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar futbolistas");
            }
        }

        /// <summary>
        /// Carga los futbolistas del equipo seleccionado.
        /// </summary>
        private void CargarFutbolistasDelEquipoByCodigo(string equipoCodigo)
        {
            try
            {
                var futbolistas = _futbolistaService.GetFutbolistasByEquipoCodigo(equipoCodigo);
                lbFutbolistas.DataSource = futbolistas.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar futbolistas");
            }
        }

        private void btnInsertarActualizarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                var equipo = new Equipo(
                    txtCodigo.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtPais.Text.Trim(),
                    txtEstadio.Text.Trim(),
                    txtCiudad.Text.Trim()
                );

                bool exito;
                if (_operacionEquipo == TipoOperacion.Insertar)
                {
                    var (exitoCrearEquipo, mensaje) = _equipoService.CreateEquipo(equipo);


                    if (exitoCrearEquipo)
                    {

                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    exito = _equipoService.UpdateEquipo(equipo);
                    if (exito) MessageBox.Show("Equipo actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearModoEquipo();
                }

                CargarEquipos();
                LimpiarCamposEquipo();
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar equipo", ex);
            }
        }

        private void ResetearModoEquipo()
        {
            _operacionEquipo = TipoOperacion.Insertar;
            lblInsertarActualizarEquipos.Text = "Insertar equipo";
            btnInsertarActualizarEquipo.Text = "Insertar equipo";
            txtCodigo.Enabled = true;
        }

        private void LimpiarCamposEquipo()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPais.Text = string.Empty;
            txtEstadio.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            lbEquipos.SelectedIndex = -1; // Deseleccionar equipo
        }

        private static void MostrarError(string titulo, Exception ex)
        {
            MessageBox.Show(
                $"{titulo}:\n\n{ex.Message}",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void btnInsertarActualizarFutbolista_Click(object sender, EventArgs e)
        {

            if (cbEquipoSeleccionado.SelectedItem is not Equipo equipoSeleccionado)
            {
                MessageBox.Show("Debe seleccionar un equipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!int.TryParse(txtEdadFutbolista.Text, out int edad))
                    edad = 0;

                if (!int.TryParse(txtDorsalFutbolista.Text, out int dorsal))
                    dorsal = 0;

                var futbolista = new Futbolista(
                    txtCodigoFutbolista.Text.Trim(),
                    txtNombreFutbolista.Text.Trim(),
                    equipoSeleccionado.Codigo,
                    txtPosicionFutbolista.Text.Trim(),
                    edad,
                    dorsal
                );

                bool exito;
                if (_operacionFutbolista == TipoOperacion.Insertar)
                {
                    exito = _futbolistaService.CrearFutbolista(futbolista);
                    if (exito) MessageBox.Show("Futbolista insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    exito = _futbolistaService.UpdateFutbolista(futbolista);
                    if (exito) MessageBox.Show("Futbolista actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetearModoFutbolista();
                }

                RefrescarFutbolistas();
                LimpiarCamposFutbolista();
            }
            catch (Exception ex)
            {
                MostrarError("Error al guardar futbolista", ex);
            }
        }

        private void ResetearModoFutbolista()
        {
            _operacionFutbolista = TipoOperacion.Insertar;
            lblInsertarActualizarFutbolistas.Text = "Insertar futbolista";
            btnInsertarActualizarFutbolista.Text = "Insertar futbolista";
            txtCodigoFutbolista.Enabled = true;
        }

        private void RefrescarFutbolistas()
        {
            if (cbEquipoSeleccionado.SelectedItem is Equipo equipo)
            {
                var futbolistas = _futbolistaService.GetFutbolistasByEquipoCodigo(equipo.Codigo);
                lbFutbolistas.DataSource = futbolistas.ToList();
            }
        }

        private void LimpiarCamposFutbolista()
        {
            txtCodigoFutbolista.Text = string.Empty;
            txtNombreFutbolista.Text = string.Empty;
            txtPosicionFutbolista.Text = string.Empty;
            txtEdadFutbolista.Text = string.Empty;
            txtDorsalFutbolista.Text = string.Empty;
            cbEquipoSeleccionado.SelectedIndex = -1; // Deseleccionar equipo del combo
        }

        private void btnBorrarEquipo_Click(object sender, EventArgs e)
        {
            if (lbEquipos.SelectedItem is not Equipo equipo)
            {
                MessageBox.Show("Debe seleccionar un equipo para borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea borrar el equipo '{equipo.Nombre}'?",
                "Confirmar borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    //aqui llamamos al servicio para borrar el equipo
                    _equipoService.DeleteEquipo(equipo.Codigo);
                }
                catch (Exception ex)
                {
                    MostrarError("Error al borrar equipo", ex);
                }
            }
            else
            {
                return;

            }
        }

        private void btnBorrarFutbolista_Click(object sender, EventArgs e)
        {
            if (lbFutbolistas.SelectedItem is not Futbolista futbolista)
            {
                MessageBox.Show("Debe seleccionar un futbolista para borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea borrar el futbolista '{futbolista.Nombre}'?",
                "Confirmar borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _futbolistaService.DeleteFutbolista(futbolista.Codigo);

                    MessageBox.Show("Futbolista eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarFutbolistas();
                }
                catch (Exception ex)
                {
                    MostrarError("Error al borrar futbolista", ex);
                }
            }
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            if (lbEquipos.SelectedItem is not Equipo equipo)
            {
                MessageBox.Show("Debe seleccionar un equipo para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtCodigo.Text = equipo.Codigo;
            txtCodigo.Enabled = false; // No permitir cambiar el código (es la clave)
            txtNombre.Text = equipo.Nombre;
            txtPais.Text = equipo.Pais;
            txtEstadio.Text = equipo.Estadio;
            txtCiudad.Text = equipo.Ciudad;

            _operacionEquipo = TipoOperacion.Actualizar;
            lblInsertarActualizarEquipos.Text = "Editar equipo";
            btnInsertarActualizarEquipo.Text = "Actualizar equipo";

        }

        private void btnEditarFutbolista_Click(object sender, EventArgs e)
        {
            if (lbFutbolistas.SelectedItem is not Futbolista futbolista)
            {
                MessageBox.Show("Debe seleccionar un futbolista para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtCodigoFutbolista.Text = futbolista.Codigo;
            txtCodigoFutbolista.Enabled = false;
            txtNombreFutbolista.Text = futbolista.Nombre;
            txtPosicionFutbolista.Text = futbolista.Posicion;
            txtEdadFutbolista.Text = futbolista.Edad.ToString();
            txtDorsalFutbolista.Text = futbolista.Dorsal.ToString();

            // Seleccionar el equipo del futbolista en el combo
            for (int i = 0; i < cbEquipoSeleccionado.Items.Count; i++)
            {
                if (cbEquipoSeleccionado.Items[i] is Equipo equipo && equipo.Codigo == futbolista.CodigoEquipo)
                {
                    cbEquipoSeleccionado.SelectedIndex = i;
                    break;
                }
            }

            _operacionFutbolista = TipoOperacion.Actualizar;
            lblInsertarActualizarFutbolistas.Text = "Editar futbolista";
            btnInsertarActualizarFutbolista.Text = "Actualizar futbolista";
        }

        private void btnCancelarEquipo_Click(object sender, EventArgs e)
        {
            ResetearModoEquipo();
            LimpiarCamposEquipo();
        }

        private void btnCancelarFutbolista_Click(object sender, EventArgs e)
        {
            ResetearModoFutbolista();
            LimpiarCamposFutbolista();
        }
    }
}
