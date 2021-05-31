using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    public class CalculadoraEstatica
    {
        // Método de instância
        public  int Somar(int a, int b)
        {
            return a + b;
        }
        // Método de Classes
        public static int Multiplicar(int a , int b)
        {
            return a * b;
        }
    }

    class MetadoEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 20);
            Console.WriteLine(resultado);
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2,2));
        }
    }
}
