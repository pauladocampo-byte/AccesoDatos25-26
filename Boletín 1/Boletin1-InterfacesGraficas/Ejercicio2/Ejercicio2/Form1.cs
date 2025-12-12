namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtRutaFichero.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnGuardarEnFichero_Click(object sender, EventArgs e)
        {
            string rutaFichero;
            StreamWriter fichero;

            rutaFichero = txtRutaFichero.Text + @"\registroDeUsuario.txt";

            if (File.Exists(rutaFichero))
            {
                fichero = File.AppendText(rutaFichero);
                AgregarFrase(fichero, txtFrases.Text);
            }
            else
            {
                fichero = File.CreateText(rutaFichero);
                AgregarFrase(fichero, txtFrases.Text);
            }
        }

        public void AgregarFrase(StreamWriter fichero, string frase)
        {
            fichero.WriteLine(frase);
            fichero.Close();
            txtFrases.Clear();
        }
    }
}