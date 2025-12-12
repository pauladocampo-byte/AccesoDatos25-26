using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad8
{
    public partial class Form1 : Form
    {
        const string NOMBRE_FICHERO = "alumnos/nombres.txt";
        BindingList<string> listaAlumnos = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();
            cargarAlumnos();
            lstAlumnos.DataSource = listaAlumnos;
        }

        private void cargarAlumnos()
        {
            StreamReader fichero;
            string linea = "";

            fichero = File.OpenText(NOMBRE_FICHERO);

            while (linea != null)
            {
                linea = fichero.ReadLine();

                if (linea != null)
                {
                    listaAlumnos.Add(linea);
                }
            }

            fichero.Close();

        }

        private void btnInsertarAlumnos_Click(object sender, EventArgs e)
        {
            StreamWriter fichero;
            string alumno;

            alumno = txtNombre.Text + " " + txtApellidos.Text;

            listaAlumnos.Add(alumno);
            fichero = File.AppendText(NOMBRE_FICHERO);
            fichero.WriteLine(alumno);
            fichero.Close();

            txtApellidos.Clear();
            txtNombre.Clear();

        }
    }
}
