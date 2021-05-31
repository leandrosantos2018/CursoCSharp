using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    public class Produto
    {
        public String Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto(String nome,double preco , double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;

        }
        public Produto()
        {

        }

        public double CaldularDesconto()
        {
            return Preco - Preco * Desconto;
        }


    }
    class AtributiEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 6.3,
                Desconto = 0.1
            };

            Console.WriteLine("Preço com desconto : {0}",produto1.CaldularDesconto());
        }
    }
}
