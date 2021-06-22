using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    class ParametroComValorPadrao
    {
        public static int somar(int a = 1,int b = 1)
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(somar(10,33));
            Console.WriteLine(somar(b : 7));
        }
    }
}
