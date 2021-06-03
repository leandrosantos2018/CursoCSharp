using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetados
{
    public class CarroOpcional
    {
        double desconto = 0.1;


        String nome;

        //public String Nome { get; set; }

        public string Nome
        {
            get
            {
                return "opcional " + nome;
            }
            set
            {
                nome = value;
            }
        }

        public double Preco { get; set; }

        public double PrecoComDesconto => Preco - (desconto * Preco);


        public CarroOpcional(String nome, double preco)
        {
            nome = this.nome;
            Preco = preco;

        }

        public CarroOpcional()
        {

        }
    }
        class Props
        {
            public static void Executar()
            {
                var carro = new CarroOpcional("Ar condicionado",253);

                Console.WriteLine(carro.PrecoComDesconto);

            }
        }
   }
