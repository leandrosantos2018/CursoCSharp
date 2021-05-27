using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //    for(int i = 0;  i < 10;i++)
            //    {
            //        Console.WriteLine($"O valor de i é {i}.");
            //    }   

            double somatorio = 0;
            String entrada;

            Console.WriteLine("Informa o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoturma);

            for(int i = 1; i <= tamanhoturma; i++)
            {
                Console.WriteLine("Informe a Nota do Aluno {0} : ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;


            }

            double media = tamanhoturma > 0 ? somatorio / tamanhoturma : 0;

            Console.WriteLine("Media da Turma: {0}", media);
        }
    }
}
