using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{

    public enum Gereno { Acao,Comedia,Terro,Romance,Animacao};
     
    public class Filme
    {
        public String Titulo;
        public Gereno GeneroFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Gereno.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "sharknardo 17";
            filmeParaFamilia.GeneroFilme = Gereno.Acao;
            Console.WriteLine("o titulo do Filme é {0}" +
                " e gernero é {1}",filmeParaFamilia.Titulo,
                filmeParaFamilia.GeneroFilme);
        }
    }
}
