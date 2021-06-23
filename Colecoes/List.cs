using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public String Nome;
        public double Preco;

        public Produto(String nome,double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    class ColecoesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of trone",49.9);

            var carrinho = new List<Produto>();

            carrinho.Add(livro);

            var combo = new List<Produto> { 
                new Produto("camisa",29.9),
                new Produto("8º temporada Game Of trone",29.9),
                new Produto("camisa",29.9),
                new Produto("calça",35.4)
            };

            carrinho.AddRange(combo);

            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}  {item.Preco}");
            }
        }
    }
}
