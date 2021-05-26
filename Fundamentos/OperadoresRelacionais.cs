using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("perferito? {0}", nota == 10.0);
            Console.WriteLine("tem como melhor?{0}", nota != 10.0);
            Console.WriteLine("Passou da media? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação ? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
