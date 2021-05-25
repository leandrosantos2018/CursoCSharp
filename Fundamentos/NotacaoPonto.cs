using System;


namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola".ToUpper().Insert(3, "world").Replace("world"," mundo");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            String valorImportante = null;

            Console.WriteLine(valorImportante?.Length);
        }
    }
}
