using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];


            alunos[0] = "Leandro";
            alunos[1] = "lucas";
            alunos[2] = "flavio";
            alunos[3] = "emanuel";
            alunos[4] = "bia";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 5.5, 4.8 };
            
        }
    }
}
