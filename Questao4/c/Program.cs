using System;

namespace Questao4
{
    public class Program
    {
        public static void Main()
        {
            ClasseTeste classeTeste = new ClasseTeste(String.Empty);
        }
    }

    public class ClasseTeste
    {
        public ClasseTeste(string propriedadeObrigatoria)
        {
            if (string.IsNullOrEmpty(propriedadeObrigatoria))
            {
                throw new ArgumentNullException(nameof(propriedadeObrigatoria), "Esta propriedade é obrigatória");
            }

            PropriedadeObrigatoria = propriedadeObrigatoria;
        }

        public string PropriedadeObrigatoria { get; private set; }
    }
}