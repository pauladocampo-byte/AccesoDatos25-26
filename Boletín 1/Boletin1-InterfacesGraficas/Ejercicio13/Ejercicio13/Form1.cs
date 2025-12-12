using System.Runtime;
using System.Windows.Forms;

namespace Ejercicio13;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public string rutaCarpetaPrincipal;
    public string rutaCarpetaSecundaria;

    private void Form1_Load(object sender, EventArgs e)
    {
        using (var fbd = new FolderBrowserDialog())
        {
            DialogResult result = fbd.ShowDialog();
            rutaCarpetaPrincipal = fbd.SelectedPath;

            lstCarpetas.DataSource = ListarDirectorios(rutaCarpetaPrincipal);
        }
    }

    private void lstCarpetas_DoubleClick(object sender, EventArgs e)
    {
        List<string> listaFicherosYCarpetas;

        rutaCarpetaSecundaria = rutaCarpetaPrincipal + @"\" + lstCarpetas.SelectedItem.ToString();

        listaFicherosYCarpetas = ListarDirectorios(rutaCarpetaSecundaria);
        listaFicherosYCarpetas.AddRange(ListarFicheros(rutaCarpetaSecundaria));

        lstArchivos.DataSource = listaFicherosYCarpetas;
    }

    private void lstArchivos_DoubleClick(object sender, EventArgs e)
    {
        string rutaFichero = rutaCarpetaSecundaria + @"\" + lstArchivos.SelectedItem.ToString();

        txtInfoFicheroCarpeta.Text = MuestraInfoFicheroCarpeta(rutaFichero);
    }

    public List<string> ListarDirectorios(string ruta)
    {
        List<string> listaCarpetas = new List<string>();
        DirectoryInfo di = new DirectoryInfo(ruta);

        foreach (var d in di.GetDirectories("*", SearchOption.TopDirectoryOnly))
        {
            listaCarpetas.Add(d.Name);
        }

        return listaCarpetas;
    }

    public List<string> ListarFicheros(string ruta)
    {
        List<string> listaFicheros = new List<string>();
        DirectoryInfo di = new DirectoryInfo(ruta);

        foreach (var d in di.GetFiles("*", SearchOption.TopDirectoryOnly))
        {
            listaFicheros.Add(d.Name);
        }

        return listaFicheros;
    }

    public string MuestraInfoFicheroCarpeta(string ruta)
    {
        string infoCompleta = "";

        FileInfo detalles = new FileInfo(ruta);
        infoCompleta = "Nombre: " + detalles.Name;
        infoCompleta += Environment.NewLine;
        infoCompleta += "Ruta: " + detalles.FullName;
        infoCompleta += Environment.NewLine;

        FileAttributes attr = File.GetAttributes(ruta);
        if ((attr & FileAttributes.Directory) == FileAttributes.Directory) infoCompleta += "Tipo: Directorio";
        else infoCompleta += "Tipo: Fichero";
        infoCompleta += Environment.NewLine;

        infoCompleta += "Ultima modificacion: " + detalles.LastWriteTime;
        infoCompleta += Environment.NewLine;
        infoCompleta += "Es de sólo lectura: " + detalles.IsReadOnly;
        infoCompleta += Environment.NewLine;

        return infoCompleta;
    }
}
