using Actividad3.Models;
using Actividad3.Services;

namespace Actividad3
{
    public partial class Form1 : Form
    {
        private EquipoService _equipoService;
        private FutbolistaService _futbolistaService;
        public Form1(EquipoService equipoService, FutbolistaService futbolistaService )
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
    }
}
