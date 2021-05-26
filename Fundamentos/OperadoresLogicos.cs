using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var execetouTrabalho1 = false;
            var executouTrabalho2 = false;

            var comprouTv50 = execetouTrabalho1 && executouTrabalho2;
            Console.WriteLine("comprou a tv 50? {0}", comprouTv50);

            var comprouSorvete = execetouTrabalho1 || executouTrabalho2;
            Console.WriteLine("comprou o soverte? {0}", comprouSorvete);

            var comprouTv32 = execetouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);


            Console.WriteLine("Mais saudável ? ? {0}", !comprouSorvete);


        }
    }
}
