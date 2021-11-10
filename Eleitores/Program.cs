using System;
using System.Collections.Generic;
using System.Linq;

namespace Eleitores
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var casas = FakeData.GerarCasas(10000, 4);

            var ruas = OrdenarPeloTotalEleitores(casas);
        }

        private static List<Rua> OrdenarPeloTotalEleitores(List<Casa> casas)
        {
            var ruasComTotalEleitores = new Dictionary<Rua, int>();

            foreach (var casa in casas)
            {
                if (ruasComTotalEleitores.ContainsKey(casa.Rua))
                {
                    ruasComTotalEleitores[casa.Rua] += casa.TotalEleitores;
                }
                else
                {
                    ruasComTotalEleitores.Add(casa.Rua, casa.TotalEleitores);
                }
            }

            var ruas = ruasComTotalEleitores.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            return ruas;
        }
    }
}