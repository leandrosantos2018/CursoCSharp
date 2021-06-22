using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    public class Cliente
    {
        public String Nome;
        DateTime Nascimento;

        public Cliente()
        {
        }

        public Cliente(String nome,DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
        public String GetNascimento()
        {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month,
                Nascimento.Year);
        }
    }
                         
    class Readonly
    {
        

        public static void Executar()
        {
            var Novocliente = new Cliente("Leandro", new DateTime(2021,06,05));
         
            Console.WriteLine(Novocliente.Nome);
            Console.WriteLine(Novocliente.GetNascimento());
        }
    }
}

