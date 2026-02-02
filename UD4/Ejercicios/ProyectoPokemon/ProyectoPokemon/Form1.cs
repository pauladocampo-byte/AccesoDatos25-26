using Dapper;
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

namespace ProyectoPokemon
{
    public partial class Form1 : Form
    {
        const string cadenaConexion = "Initial catalog = Pokemon;Data Source = DESKTOP-S65ABNK; Integrated Security=SSPI";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarNombrePokemon_Click(object sender, EventArgs e)
        {
            lstPokemon.DataSource = GetNombrePokemons();
        }

        public List<string> GetNombrePokemons()
        {
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT Nombre FROM pokemon";
                List<string> listaNombrePokemons = (List<string>)db.Query<string>(consulta);
                return listaNombrePokemons;
            }
        }

        public List<Pokemon> GetListaPokemonByKilos(double kilos)
        {
            Pokemon prueba = new Pokemon(-1, "", kilos, -1);
            using (IDbConnection db = new SqlConnection(cadenaConexion))
            {
                var consulta = @"SELECT * FROM pokemon WHERE peso < @peso";
                List<Pokemon> listaNombrePokemons = (List<Pokemon>)db.Query<Pokemon>(consulta, prueba);
                return listaNombrePokemons;
            }
        }

        private void btnGetPokemonKilos_Click(object sender, EventArgs e)
        {
            double kilos;

            double.TryParse(txtKilos.Text, out kilos);

            List<Pokemon> listaPokemons = GetListaPokemonByKilos(kilos);
            lstPokemon.DataSource = listaPokemons;
        }
    }
}
