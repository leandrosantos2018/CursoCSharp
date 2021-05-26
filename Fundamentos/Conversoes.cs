using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes 
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTrucada = (int) nota;
            Console.WriteLine("Nota Trucada:{0}", notaTrucada);

            Console.WriteLine("Digite sua idade:");
            String idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idade Inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("resultado : {0}", idadeInteiro);

            Console.WriteLine("Digite um numero");
            String palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("resultado:{0}", numero);
        
        }
    }
}
