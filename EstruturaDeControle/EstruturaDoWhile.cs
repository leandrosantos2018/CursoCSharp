using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            String entrada;

            do
            {
                Console.WriteLine("Qual é o seu Nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem-vindo {0}", entrada);
                Console.WriteLine("Deja Continuar? (S/N)");
                entrada = Console.ReadLine();



            } while (entrada.ToLower() == "s");

        }
    }
}
