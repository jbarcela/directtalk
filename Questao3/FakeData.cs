using System.Collections.Generic;
using Bogus;

namespace Eleitores
{
    public static class FakeData
    {
        const string LOCALE = "pt_BR";
        public static List<Casa> GerarCasas(int numeroCasas, int numeroRuas)
        {
            var ruas =
                new Faker<Rua>(LOCALE).CustomInstantiator(f => 
                    new Rua(
                        f.Address.ZipCode(), 
                        f.Address.StreetName()))
                    .Generate(numeroRuas);

            var casas = 
                new Faker<Casa>(LOCALE).CustomInstantiator(f => 
                    new Casa(
                        f.PickRandom(ruas), 
                        f.Random.Int(1, 1000),
                        f.Random.Int(1, 10)))
                    .Generate(numeroCasas);
            
            return casas;
        } 
    }
}