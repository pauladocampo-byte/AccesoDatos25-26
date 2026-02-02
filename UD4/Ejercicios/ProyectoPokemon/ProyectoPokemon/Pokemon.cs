namespace ProyectoPokemon
{
    public class Pokemon
    {
        int numero_pokedex;
        string nombre;
        double peso;
        double altura;

        public Pokemon(int numero_pokedex, string nombre, double peso, double altura)
        {
            this.numero_pokedex = numero_pokedex;
            this.nombre = nombre;
            this.peso = peso;
            this.altura = altura;
        }

        public int Numero_pokedex { get => numero_pokedex; set => numero_pokedex = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }


        public override string ToString()
        {
            return "Num Pokedex: " + Numero_pokedex + " ,Nombre: " + Nombre + " , Peso: " + Peso + " , Altura:" + Altura;
        }

    }
}