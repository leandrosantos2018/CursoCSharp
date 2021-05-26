using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o Seu Nome?");
            String Nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?");

            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salario?");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{Nome} {idade} R$ {salario}");



        }
    }
}
