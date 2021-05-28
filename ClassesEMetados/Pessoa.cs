using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    class Pessoa
    {
        public String Nome;
        public int Idade;

        public String Apresentar()
        {
            return String.Format(
                $"olá me chamo {Nome} e tenho {Idade} anos .");

        }

        public void ApresentaNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void zera()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
