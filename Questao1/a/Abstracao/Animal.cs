using System;

namespace Questao1.a.Abstracao
{
    public abstract class Animal
    {
        public abstract void EmitirSons();

        public void Dormir()
        {
            Console.WriteLine("ZzZ");
        }
    }
}