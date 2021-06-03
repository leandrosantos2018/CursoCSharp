using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    class Params
    {
        public static void Recepcionar(params String[] pessoas)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine("olá {0}",pessoa);
            }
        }

        public static void Executar()
        {
            Recepcionar("Leandro", "Naiani", "Mirella");

        }
    }
}
