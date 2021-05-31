using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    class DesafioAtribudo
    {
        int a = 10;

        public static void Executar()
        {
            //Acessa Variável 'a' dentro do método Executar

            DesafioAtribudo valor = new DesafioAtribudo();

            Console.WriteLine(valor.a);
        }
    }
}
