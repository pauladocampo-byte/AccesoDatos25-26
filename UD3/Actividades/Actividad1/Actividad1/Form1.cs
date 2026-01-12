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

namespace Actividad1
{
    public partial class Form1 : Form
    {
        SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion = new SqlConnection("server=PO235PDOCAMPO\\SQLEXPRESS;database=BDMontecastelo;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");

            conexion.Open();
            MessageBox.Show("Se ha realizado la conexión!");
            conexion.Close();
            MessageBox.Show("Se ha realizado la desconexión!");
        }
    }
}
