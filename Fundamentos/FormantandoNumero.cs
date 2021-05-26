using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormantandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C1", cultura));

            int inteiro = 256;

            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
