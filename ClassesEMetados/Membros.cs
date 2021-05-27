using System;


namespace CursoCSharp.ClassesEMetados
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa p = new Pessoa();
            String i ;
            p.Nome = "Leandro";
            p.Idade = 25;

            //Console.WriteLine($"{p.Nome} tem {p.Idade}");

           
            p.Apresentar();
            p.ApresentaNoConsole();

            var fulado = new Pessoa();
            fulado.Nome = "beto";
            fulado.Idade = 21;

            var apresentaDoFulano = fulado.Apresentar();
            Console.WriteLine(fulado.Apresentar());
        }
    }
}
