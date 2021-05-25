using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            String nome = "Notebook game";
            var marca = "dell";

            double preco = 5800.00;

            Console.WriteLine("o" + nome + "da marca" + marca + "custo" + preco);

            Console.WriteLine("o {0} da Marca {1} Custa{2}.", nome, marca, preco);

            Console.WriteLine($"a marca {marca} custa {preco}");

            Console.WriteLine($"1 + 1 {1 + 1 }");
        }
    }
}
