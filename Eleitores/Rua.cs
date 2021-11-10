namespace Eleitores
{
    public class Rua
    {
        public Rua(string cep, string nome)
        {
            Cep = cep;
            Nome = nome;
        }

        public string Cep { get; private set; }

        public string Nome { get; private set; }
    }
}