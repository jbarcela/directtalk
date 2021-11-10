namespace Eleitores
{
    public class Casa
    {
        public Casa(Rua rua, int numero, int totalEleitores)
        {
            Rua = rua;
            Numero = numero;
            TotalEleitores = totalEleitores;
        }

        public Rua Rua { get; private set; }

        public int Numero { get; private set; }

        public int TotalEleitores { get; private set; }
    }
}